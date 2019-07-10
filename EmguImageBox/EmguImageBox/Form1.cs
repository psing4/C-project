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
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace EmguImageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void ImageBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = "click a right mouse button";
            Bgr fwColor = new Bgr(0, 255, 255);
            Point stPoint = new Point(20, 100);

            using(Image<Bgr,Byte>imgeObj = new Image<Bgr, byte>(this.ClientSize))
            {
                MCvFont f = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 1.0, 1.0);
                imgeObj.Draw(msg, ref f, stPoint, fwColor);
                ibCanvas.Image = imgeObj;
            }
        }
    }
}
