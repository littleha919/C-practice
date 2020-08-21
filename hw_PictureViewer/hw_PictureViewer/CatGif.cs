using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_PictureViewer
{
    public partial class CatGif : Form
    {
        public CatGif()
        {
            InitializeComponent();
        }

        private void StretchPic()
        {
            // Stretch the picture to fit the control.  
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Load the picture into the control.  
            // You should replace the bold image
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.  
            pictureBox1.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal) 
            + @"\Image.gif");
}
    }
}
