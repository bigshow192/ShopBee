using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using QRCoder;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Video;
namespace Webbanhang
{
    public partial class Form6 : Form
    {
        private int k = 0;
        private Capture _capture = null;
        private bool _captureInProgress;
        BarcodeLib.Barcode code128 = new Barcode();
        

        public Form6()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new Capture(0);
                _capture.ImageGrabbed += ProcessFrame;
                _capture.Start();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
            
            private void ProcessFrame(object sender, EventArgs arg)
            {
                Mat frame = new Mat();
                _capture.Retrieve(frame, 0);
                Mat grayFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);
                Mat smallGrayFrame = new Mat();
                CvInvoke.PyrDown(grayFrame, smallGrayFrame);
                Mat smoothedGrayFrame = new Mat();
                CvInvoke.PyrUp(smallGrayFrame, smoothedGrayFrame);

                //Image<Gray, Byte> smallGrayFrame = grayFrame.PyrDown();
                //Image<Gray, Byte> smoothedGrayFrame = smallGrayFrame.PyrUp();
                Mat cannyFrame = new Mat();
                CvInvoke.Canny(smoothedGrayFrame, cannyFrame, 100, 60);

            //Image<Gray, Byte> cannyFrame = smoothedGrayFrame.Canny(100, 60);
            
            imageBox1.Image = frame;
                //grayscaleImageBox.Image = grayFrame;
                //smoothedGrayscaleImageBox.Image = smoothedGrayFrame;
                //cannyImageBox.Image = cannyFrame;
            }

            

            private void ReleaseData()
            {
                if (_capture != null)
                    _capture.Dispose();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            k++;
            Bitmap screenBitmap = new Bitmap(this.Width, this.Height,
PixelFormat.Format32bppArgb);
            Graphics screenGraphics = Graphics.FromImage(screenBitmap);
            screenGraphics.CopyFromScreen(new Point(this.Left,
            this.Top), Point.Empty, this.Size);
            screenBitmap.Save("D:\\Cam\\" + k + ".png",
            ImageFormat.Png);
        }
    }
    }

