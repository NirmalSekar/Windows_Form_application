using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        //int lastImage = 0;
        //int finalImage = 0;
        string setup = "AFT_LEFT_0";
        string imageLocation = @"C:\Users\nsekar\Desktop\Image_testing\";
        public Form1()
        {
            InitializeComponent();
            DrawImagePara();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X + "Y = " + e.Y;

        }

         private void DrawImagePara(PaintEventArgs e)
          {
                // Create image.
                pictureBox1.Image = Image.FromFile(imageLocation + setup + ".jpg");

                Image newImage = pictureBox1.Image;

                // Create parallelogram for drawing image.
                Point ulCorner = new Point(1000, 300);

                Point destPara = ulCorner;

                // Draw image to screen.
                e.Graphics.DrawImage(newImage, destPara);
           }
        
        
    }
}
