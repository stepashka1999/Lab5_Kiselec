using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*---Initialization---*/

        FaceFinder FaceFndr;
        TextFinder TxtFndr;
                
        /*---Params---*/

        int func = 0; // | 0 - do nothing | 1 - Pictures with text from Video | 2 - Pictures with face from Video ( All ) | 3 - Pictures with face from Video ( One by One )
        bool ButPlay = false; // | true = play | false = pause

        private void loadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            var result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                FaceFndr = new FaceFinder(OFD.FileName);
                TxtFndr = new TextFinder(OFD.FileName);

                FirstImage_Box.Image = TxtFndr.SourseImage.Resize(FirstImage_Box.Width, FirstImage_Box.Height, Inter.Linear);
            }

            Threshold_Bar.Visible = true;
            Threshold_lbl.Visible = true;

            Iteration_lbl.Visible = true;
            Iteration_Bar.Visible = true;
        }

        private void Threshold_Bar_Scroll(object sender, EventArgs e)
        {
            Threshold_lbl.Text = $"Threshold: {Threshold_Bar.Value}";
        }

        private void Iteration_Bar_Scroll(object sender, EventArgs e)
        {
            Iteration_lbl.Text = $"Iteration: {Iteration_Bar.Value}";
        }

        private void RIOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SecondImage_Box.Image = TxtFndr.DrawROI(Threshold_Bar.Value, Iteration_Bar.Value).Resize(SecondImage_Box.Width, SecondImage_Box.Height, Inter.Linear);
        }

        private void ImagesWithWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicturesRIO_lbl.Visible = !PicturesRIO_lbl.Visible;
            Pictures_cb.Visible = !Pictures_cb.Visible;
            TextOfPicture_lbl.Visible = !TextOfPicture_lbl.Visible;
            Lang_cb.Visible = !Lang_cb.Visible;

            Pictures_cb.Items.Clear();

            List<Image<Bgr, byte>> listOfPicturesWithROI;


            if (func == 0)  listOfPicturesWithROI = TxtFndr.GetListOfImageOfROI(Threshold_Bar.Value, Iteration_Bar.Value);
            else
            {
                Mat frame = new Mat();
                TxtFndr.capture.Retrieve(frame);
                // TxtFndr.capture.QueryFrame().ToImage<Bgr, byte>();

                var img = frame.ToImage<Bgr, byte>();

                listOfPicturesWithROI = TxtFndr.GetListOfImageOfROI(Threshold_Bar.Value, Iteration_Bar.Value, img);
            }

            for(int i = 0; i < listOfPicturesWithROI.Count; i++)
            {
                Pictures_cb.Items.Add($"ROI - {i+1}");
            }

        }

        private void Pictures_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image<Bgr, byte> image;

            if(func == 0) image = TxtFndr.GetListOfImageOfROI(Threshold_Bar.Value, Iteration_Bar.Value)[Pictures_cb.SelectedIndex];
            else if(func == 1)
            {
                Mat frame = new Mat();
                TxtFndr.capture.Retrieve(frame);
                // TxtFndr.capture.QueryFrame().ToImage<Bgr, byte>();

                var img = frame.ToImage<Bgr, byte>();

                image = TxtFndr.GetListOfImageOfROI(Threshold_Bar.Value, Iteration_Bar.Value, img)[Pictures_cb.SelectedIndex];

            }
            else
            {
                Mat frame = new Mat();

                FaceFndr.capture.Retrieve(frame);

                image = FaceFndr.ListOfFace(frame.ToImage<Bgr, byte>().Copy())[Pictures_cb.SelectedIndex];

                TextOfPicture_lbl.Text = $"Text: {FaceFndr.FacePredict(image)}";
            }
            SecondImage_Box.Image = image;

            if (func < 2)
            {
                var val = 0;

                if (Lang_cb.Checked) val = 1;
                else val = 0;

                TextOfPicture_lbl.Text = $"Text: {TxtFndr.CharacterRecognition(image, val)}";
            }

        }


        /*------------VIDEO------------*/
        private void LoadVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            var result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                FaceFndr = new FaceFinder(OFD.FileName, 1);
                TxtFndr = new TextFinder(OFD.FileName, 1);

                TxtFndr.SubImageGrabben(ProcessFrame);
                FaceFndr.SubImageGrabben(ProcessFrame);
            }

            Play_Buton.Visible = true;
           
            Threshold_Bar.Visible = true;
            Threshold_lbl.Visible = true;

            Iteration_lbl.Visible = true;
            Iteration_Bar.Visible = true;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = new Mat();
            if (func == 1) TxtFndr.capture.Retrieve(frame);
            else FaceFndr.capture.Retrieve(frame);
            // TxtFndr.capture.QueryFrame().ToImage<Bgr, byte>();

            Image<Bgr,byte> img = frame.ToImage<Bgr, byte>();
                      
            FirstImage_Box.Image = img.Resize(FirstImage_Box.Height, FirstImage_Box.Height, Inter.Linear);

            switch (func)
            {
                case 1:
                    SecondImage_Box.Image = TxtFndr.DrawROI(Threshold_Bar.Value, Iteration_Bar.Value, img).Resize(FirstImage_Box.Height, FirstImage_Box.Height, Inter.Linear);
                    break;
                case 2:
                    SecondImage_Box.Image = FaceFndr.DetectFace(func, img).Resize(FirstImage_Box.Height, FirstImage_Box.Height, Inter.Linear);
                    break;
            }


        }

        private void VideoRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = 1;    
        }

        /*---Video Control Buttons---*/

            /*--- Play / Pause ---*/
        private void Play_Buton_Click(object sender, EventArgs e)
        {
            if (!ButPlay)
            {
                if (func == 1) TxtFndr.CaptureStart();
                else if (func == 2) FaceFndr.CaptureStart();
            }
            else
            {
                if (func == 1) TxtFndr.CapturePause();
                else if (func == 2) FaceFndr.CapturePause();
            }

            ButPlay = !ButPlay;

            /*--- Picture control panel ---*/

            PicturesRIO_lbl.Visible = true;
            Pictures_cb.Visible = true;
            TextOfPicture_lbl.Visible = true;
            Lang_cb.Visible = true;

            /*----------------------------*/

            if (!ButPlay)
            {
                Pictures_cb.Items.Clear();//clear when click pause

                Mat frame = new Mat();
                if (func == 1) TxtFndr.capture.Retrieve(frame);
                else if (func == 2) FaceFndr.capture.Retrieve(frame);
                // TxtFndr.capture.QueryFrame().ToImage<Bgr, byte>();

                var img = frame.ToImage<Bgr, byte>();

                if (func == 1)
                {
                     var listOfPicturesWithROI = TxtFndr.GetListOfImageOfROI(Threshold_Bar.Value, Iteration_Bar.Value, img);

                    for (int i = 0; i < listOfPicturesWithROI.Count; i++)
                    {
                        Pictures_cb.Items.Add($"ROI - {i + 1}");
                    }
                }
                else if(func == 2)
                {
                    var ArrayOfFaces = FaceFndr.GetArrayOfFace(func,img);

                    for (int i = 0 ; i < ArrayOfFaces.Length; i++)
                    {
                        Pictures_cb.Items.Add($"ROI - {i + 1}");
                    }
                }
            }
        }

        private void videoRIOFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = 2;
        }

        private void rIOFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondImage_Box.Image = FaceFndr.DetectFace().Resize(SecondImage_Box.Width, SecondImage_Box.Height, Inter.Linear);
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat frame = new Mat();

            FaceFndr.capture.Retrieve(frame);

            var listOfFaces = FaceFndr.ListOfFace(frame.ToImage<Bgr, byte>().Copy());

            FaceFndr.Train(listOfFaces);
        }

        private void readFacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaceFndr.ReadRecognition();
        }

    }
}
