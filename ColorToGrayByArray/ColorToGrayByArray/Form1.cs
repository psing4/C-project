using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorToGrayByArray
{
    public partial class Form1 : Form
    {
        Image image;
        Bitmap gBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtOpen_Click(object sender, EventArgs e)
        {
            string filiterName = "All Files(*.*)|*.*|Bitmpap File(*.bmp)|*.bmp|"; //파일 확장자 추가 
            filiterName = filiterName + "Gif File(*.gif)|*.gif|Jpeg File(*.jpg)|*.jpg"; //파일 확장자 추가
            Graphics gr = CreateGraphics();//Form아래의 메소드 
            ofdOpen.Title = "파일열기"; //파일열기 다이얼로그의 이름 

            ofdOpen.Filter = filiterName;
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                string strFilname = ofdOpen.FileName;
                image = Image.FromFile(strFilname);//static 
                gr.DrawImage(image, 10, 50, image.Width, image.Height);
            }
            gr.Dispose();

        }

        private void BtGrayBright_Click(object sender, EventArgs e)
        {
            int x, y;
            int brightness;
            const int ADD_VALUE = 50;
            Color color;
            int[,] grayArray = new int[image.Height, image.Width];
            Graphics gr = CreateGraphics();
            gBitmap = new Bitmap(image);
            for(y=0;y<image.Height;y++)
            {
                for(x=0;x<image.Width;x++)
                {
                    color = gBitmap.GetPixel(x, y);
                    brightness = (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);

                    grayArray[y, x] = brightness;

                }
            }
            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    grayArray[y, x] += ADD_VALUE;
                    if (grayArray[y, x] > 255) grayArray[y, x] = 255;

                }
            }
            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    color = Color.FromArgb(grayArray[y, x], grayArray[y, x], grayArray[y, x]);
                    gBitmap.SetPixel(x, y, color);
                }
            }
            gr.DrawImage(gBitmap, 20 + gBitmap.Width, 50, gBitmap.Width, gBitmap.Height);
            gr.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            if (image == null)
            {

            }
            else
            {
                if(gBitmap == null)
                {

                }
                else
                {
                    graphics.DrawString("졸려", Font, Brushes.Black, 10, 10);
                    graphics.DrawImage(image, 10, 50, image.Width, image.Height);
                    graphics.DrawImage(gBitmap, 20 + gBitmap.Width, 50, gBitmap.Width, gBitmap.Height);
                }
                
            }
            graphics.Dispose();//

        }
    }
}
