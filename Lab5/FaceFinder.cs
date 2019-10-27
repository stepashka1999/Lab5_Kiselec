using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Collections.Generic;
using System.Drawing;


namespace Lab5
{
    
    class FaceFinder: IFinder
    {
        private string path = "D:\\Some Shit\\haarcascade_frontalface_default.xml";

        private CascadeClassifier cc;

        FaceRecognizer faceRecognizer = new EigenFaceRecognizer(80, double.PositiveInfinity); // Object for face recognizion

        public FaceFinder(string FileName, int ch = 0)
        {
            if (ch == 0) SourseImage = new Image<Bgr, byte>(FileName);
            else capture = new VideoCapture(FileName);

            cc = new CascadeClassifier(path);
        }

        public Image<Bgr, byte> DetectFace(int ch = 0, Image<Bgr,byte> frameImage = null) // 0 - From GrayImage, 2 = From frame
        {
            Image<Bgr, byte> img = null;
            

            if (ch == 0)
            {
                img = SourseImage;
            }
            else if (ch == 2)
            {
                img = frameImage;
            }

            var faceDetected = GetArrayOfFace(ch, img);

            foreach (Rectangle face in faceDetected)
                img.Draw(face, new Bgr(Color.GreenYellow), 2);

            return img;
        }

        public Rectangle[] GetArrayOfFace( int ch = 0, Image<Bgr, byte> frameImage = null)
        {
            Image<Gray, byte> grayImage = null;

            if (ch == 0)
            {
                grayImage = SourseImage.Convert<Gray, byte>();
            }
            else if (ch == 2)
            {
                var img = frameImage;
                grayImage = img.Convert<Gray,byte>();
            }

            Rectangle[] faceDetected = cc.DetectMultiScale(grayImage, 1.1, 10, new Size(20, 20));

            return faceDetected;
        }


        /*--- List Of Faces ---*/
        public List<Image<Bgr,byte>> ListOfFace(Image<Bgr,byte> img)
        {
            var rectOfFaceDetected = GetArrayOfFace(2, img.Copy());

            var listOfFace = new List<Image<Bgr, byte>>();

            foreach(Rectangle rect in rectOfFaceDetected)
            {
                img.ROI = rect;
                
                var interImg = img.Copy();

                listOfFace.Add(interImg);

                img.ROI = Rectangle.Empty;
            }

            return listOfFace;
        }

        public void Train(VectorOfMat faces, VectorOfInt facesIndex)
        {       
            faceRecognizer.Train(faces, facesIndex);

            faceRecognizer.Write("Tmp.YAML");
        }

        public void ReadRecognition()
        {
            faceRecognizer.Read("Tmp.YAML");
        }

        public int FacePredict(Image<Bgr,byte> img)
        {
            var copy = img.Copy();
            
            var grayImage = copy.Resize(80, 80, Emgu.CV.CvEnum.Inter.Linear).Convert<Gray, byte>();
            return faceRecognizer.Predict(grayImage.Mat).Label;
        }

    }
}
