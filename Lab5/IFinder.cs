using System;
using Emgu.CV;
using Emgu.CV.Structure;



namespace Lab5
{
    abstract class IFinder
    {
        public Image<Bgr, byte> SourseImage { get; protected set; }
        public VideoCapture capture { get; protected set; }

        /*--- Control Functions ---*/
        public void CaptureStart()
        {
            capture.Start();
        }

        public void CapturePause()
        {
            capture.Pause();
        }

        public void CaptureStop()
        {
            capture.Stop();
        }

        /*-------------------------*/


        /*--- Sub / Unsub ---*/
        public void SubImageGrabben(EventHandler someFunc)
        {
            capture.ImageGrabbed += someFunc;
        }

        public void UnSubImageGrabben(EventHandler someFunc)
        {
            capture.ImageGrabbed -= someFunc;
        }
        /*--------------------*/
    }
}
