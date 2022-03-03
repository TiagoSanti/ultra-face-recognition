﻿using OpenCvSharp;

namespace UltraFaceRecognition
{
    class Camera
    {
        public VideoCapture? Capture;

        public void StartCamera()
        {
            Capture = new VideoCapture(0);
        }

        public bool IsStarted()
        {
            return Capture != null;
        }

        public Mat? GetFrame()
        {
            if (IsStarted())
            {
                return Capture.RetrieveMat();
            }
            else
            {
                Console.WriteLine("Camera hasn't been started yet");

                return null;
            }
        }

        internal void ShowImage(Mat mat)
        {
            if (IsStarted())
            {
                if (mat != null)
                {
                    Cv2.ImShow("Camera", mat);
                }
            }
        }

        internal void Close()
        {
            Cv2.DestroyAllWindows();
        }
    }
}
