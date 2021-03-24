using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguOpenCVExample
{
    public partial class ImageViewer : Form
    {
        public ImageViewer(Image image, double _pixelCount)
        {
            InitializeComponent();
            _image = image;
            pixelCount = _pixelCount;
        }

        Image _image;
        double pixelCount;

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = _image;         
            label1.Text = pixelCount.ToString();
            this.Refresh();
        }
    }
}
