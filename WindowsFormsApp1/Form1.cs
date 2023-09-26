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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                ptBox.Image = Image.FromFile(imagePath);

                
                location.Text = imagePath;
                size.Text += " Size: " + ptBox.Image.Width + "x" + ptBox.Image.Height;
            }
        }

        private void scaleToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            scale.Checked = true;
            strech.Checked = false;
            actualsize.Checked = false;
            this.ptBox.SizeMode = PictureBoxSizeMode.CenterImage;
      
        }

        private void strech_Click(object sender, EventArgs e)
        {

            scale.Checked = false;
            strech.Checked = true;
            actualsize.Checked = false;
            this.ptBox.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void actualSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            scale.Checked = false;
            strech.Checked = false;
            actualsize.Checked = true;
            this.ptBox.SizeMode = PictureBoxSizeMode.Normal;



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
