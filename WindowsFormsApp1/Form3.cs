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
            label1.Text = "X = " + e.X + "\nY = " + e.Y;

            int merge_x = Convert.ToInt32(label1.Text);
            merging();
        }

       private void merging()
        {
            
        }


        // merge this coordinate with image coordinate (0,0)

        

        //resize the image according to the other edge coordinated of the first image




    }
}
