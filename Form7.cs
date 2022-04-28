using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using ZXing;


namespace Webbanhang
{
    public partial class Form7 : Form
    {
       
        private Capture cap=null;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public Form7()
        {
            InitializeComponent();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;



        }
        private void Form7_Load(object sender, EventArgs e)
        {
            //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //videoCaptureDevice.Start();
            //timer1.Start();
            //cap = new Capture(0); //set up camera
            //timer1.Enabled = true;
            //timer1.Tick += timer1_Tick; 
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (System.InvalidOperationException)
            {

            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Bitmap imgBarCode = (Bitmap)pictureBox1.Image;
            if (imgBarCode != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgBarCode);
                    string decoded = result.ToString().Trim();
                    int i = Int32.Parse(decoded);
                    imgBarCode.Dispose();
                    Form3 f3 = new Form3(Program.p1[i]);
                    f3.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap imgQRCode = (Bitmap)pictureBox1.Image;
            if (imgQRCode != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgQRCode);
                    string decoded = result.ToString().Trim();
                    int i = Int32.Parse(decoded);
                    imgQRCode.Dispose();
                    Form3 f3 = new Form3(Program.p1[i]);
                    f3.ShowDialog();
                    
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.videoCaptureDevice.Stop();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap imgQRCode = (Bitmap)pictureBox1.Image;
            if (imgQRCode != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgQRCode);
                    string decoded = result.ToString().Trim();
                    imgQRCode.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }
    }
}
