using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        Image<Bgr, byte> imgInput;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imagebr = new OpenFileDialog();
            imagebr.Filter = "Image Files|* .jpg;*.png";
            if(imagebr.ShowDialog() == DialogResult.OK)
            {
                recImage.Image = Image.FromFile(imagebr.FileName);
                
                
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            VectorOfVectorOfPoint Contours = new VectorOfVectorOfPoint();
            Mat m = new Mat();
           // CvInvoke.FindContours(recImage, Contours, m, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
        }
    }
}
