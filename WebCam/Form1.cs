using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace WebCam
{
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        private Image captured_image;
        private int frames;
        private bool count_frames = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            frames = (int)frames_field.Value;
            timer2.Interval = (int)interval2_field.Value;

            timer1.Stop();
            timer1.Interval = (int)interval_field.Value;
            if (frames > 0)
            {
                timer2.Start();
                count_frames = true;
            }
            else
                timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture();
        }

        private void capture_button_Click(object sender, EventArgs e)
        {
            captured_image = pictureBox1.Image != null ? pictureBox1.Image : null;
            pictureBox2.Image = captured_image;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (captured_image != null)
            {
                SaveFileDialog s = new SaveFileDialog
                {
                    FileName = "Image",
                    DefaultExt = ".jpg",
                    Filter = "Image (.jpg)|*.jpg"
                };

                if (s.ShowDialog() == DialogResult.OK)
                {
                    // Save Image
                    string filename = s.FileName;
                    FileStream fstream = new FileStream(filename, FileMode.Create);
                    captured_image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (frames > 0 && count_frames)
            {
                pictureBox1.Image = capture.QueryFrame().ToImage<Bgr, Byte>().ToBitmap();
                frames--;
                return;
            }
            if (frames <= 0 && count_frames)
            {
                timer1.Stop();
                frames = (int)frames_field.Value;
                timer2.Start();
                return;
            }

            pictureBox1.Image = capture.QueryFrame().ToImage<Bgr, Byte>().ToBitmap();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();
        }
    }
}
