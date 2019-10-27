using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.OCR;


namespace Lab5
{
    class TextFinder: IFinder
    {
        private string path = "D:\\Some Shit\\";

        public TextFinder(string FileName, int ch = 0)
        {
            if (ch == 0) SourseImage = new Image<Bgr, byte>(FileName);
            else capture = new VideoCapture(FileName);
        }

        private Image<Gray, byte> BinarIzation(int threshold = 80, Image<Bgr, byte> img = null)// if null - SourseImage, else - Frame from Video
        {
            Image<Bgr, byte> copyImage;

            if (img == null) copyImage = SourseImage.Copy();
            else copyImage = new Image<Bgr, byte>(img.Bitmap);

            var binarImage = copyImage.Convert<Gray, byte>();

            binarImage = binarImage.Canny(threshold, 255);

            return binarImage;
        }

        public Image<Gray, byte> DilateImage(int threshold = 80, int iteration = 4, Image<Bgr, byte> img = null)
        {
            return BinarIzation(threshold, img).Dilate(iteration);
        }

        private VectorOfVectorOfPoint GetROI(int threshold = 80, int iteration = 4, Image<Bgr, byte> img = null)
        {
            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(DilateImage(threshold, iteration, img), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            return contours;
        }

        public Image<Bgr, byte> DrawROI(int threshold = 80, int iteration = 4, Image<Bgr,byte> img = null)
        {
            var contours = GetROI(threshold, iteration, img);

            Image<Bgr, byte> copyImage;
            if (img == null) copyImage = SourseImage.Copy();
            else copyImage = new Image<Bgr, byte>(img.Bitmap);

            for (int i = 0; i < contours.Size; i++)
            {
                if (CvInvoke.ContourArea(contours[i], false) > 50)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    copyImage.Draw(rect, new Bgr(Color.Green), 1);
                }
            }

            return copyImage;
        }

        public List<Image<Bgr, byte>> GetListOfImageOfROI(int threshold = 80, int iteration = 4, Image<Bgr,byte> img = null)
        {
            var areaOfRio = GetROI(threshold, iteration, img);

            var listOfImages = new List<Image<Bgr, byte>>();

            for (int i = 0; i < areaOfRio.Size; i++)
            {
                if (CvInvoke.ContourArea(areaOfRio[i], false) > 50)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(areaOfRio[i]);

                    Image<Bgr, byte> roiImage;

                    if (img == null)
                    {
                        SourseImage.ROI = rect;

                        roiImage = SourseImage.Copy();

                        SourseImage.ROI = Rectangle.Empty;
                    }
                    else
                    {
                        img.ROI = rect;
                        roiImage = img.Copy();

                        img.ROI = Rectangle.Empty;
                    }

                    if(roiImage.Width*roiImage.Height > 5000) listOfImages.Add(roiImage);

                    
                }
            }

            return listOfImages;

        }

        public string CharacterRecognition(Image<Bgr, byte> img, int lang = 1)
        {
            Tesseract ocr;
            if (lang == 0) ocr = new Tesseract(path, "eng", OcrEngineMode.Default);
            else ocr = new Tesseract(path, "rus", OcrEngineMode.Default);

            ocr.SetImage(img);
            ocr.Recognize();

            string txt = ocr.GetUTF8Text();

            //Tesseract.Character[] words = ocr.GetCharacters();

            return txt;
        }

    }
}
