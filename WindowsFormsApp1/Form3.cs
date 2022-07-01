using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        
        public Form3()
        {
            InitializeComponent();
        }

        //pick the rectangle image1 from the folder using browse button and display it on the picture box

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Choose Image(*.png)|*.png;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                }


                    }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    
        




        //getting the image1 top coordinates
        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            //var HorizontalSize1 = pictureBox1.Width;
            //var verticalSize1 = pictureBox1.Height;
            
            label1.Text = "X = " + e.X + "\nY = " + e.Y;


            //image1 coordinates
            int topLeftX = 95;
            int topLeftY = 107;
            int topRightX = 265;
            int topRightY = 107;
            int bottomLeftX = 95;
            int bottomLeftY = 190;
            int bottomRightX = 265;
            int bottomRightY = 190;



            Rectangle myImage = new Rectangle();
            myImage.Location = new Point(95, 107);

            myImage.Size = new Size(170, 83);



            //Getting Top left coordinates from Real sense
            //gettting Top Right Coordinates from Real sense 
            //getting Botttom left coordinates from Real sense
            //getting Bottom right coordinates from Real sense


            //lets mention this foam coorinates as image1 coordinates
            //merging these coordinates and projecting by resizing the actual size of image 2 that is already stored in the PC

            // int merge_x = Convert.ToInt32(label1.Text);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Imagelocation(string ImageFoam)
        {
            try
            {
                
                
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // Image foamImage = new Image("testimage.jpg");
        }

        // merge this coordinate with image coordinate (0,0)



        //resize the image according to the other edge coordinated of the first image




    }
}
