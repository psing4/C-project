using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadSaveImage0709
{
    public partial class HistogramForm : Form
    {
        Graphics grBm;
        Bitmap bitmap;
        const int Histo_Width = 256;
        const int Histo_Height = 200;
        public HistogramForm(int[,] grayArray, int width,int height)
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(Histo_Width, Histo_Height);
            setShadowBitmap();
            viewHistogram(0, 0, grayArray, width, height);
        }
        void setShadowBitmap()
        {
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            grBm = Graphics.FromImage(bitmap);
            grBm.Clear(BackColor);
        }

        private void HistogramForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawImage(bitmap, 0, 0);

        }
        void viewHistogram(int leftTopX,int letfTopY,int[,]histoArray,int Width, int Height)
        {
            int x, y;
            Color color;
            Bitmap histoMap = new Bitmap(Histo_Width, Histo_Height);
            int[] histogram = new int[256];
            //c 나 c++은 배열명은 포인터 상수값(바뀌지 않는다.)
            //단 함수의 파라미터로 넘어갈떄는 바뀔수 있다. 
            histogram.Initialize();

            for (y = 0; y < Height; y++)
            { 
                for (x = 0; x < Width; x++)
                { 
                    histogram[histoArray[y, x]]++;//histogram 의미 명도의 분포가 들어감  
                }
            }
            int max_cnt = 0;
            for(x=0;x<Histo_Width;x++)
            {
                if (histogram[x] > max_cnt)
                    max_cnt = histogram[x];
            }
            for (x = 0; x < Histo_Width; x++)
            {
                for (y = 0; y < Histo_Height; y++)
                {
                    color = Color.FromArgb(255, 255, 255);
                    histoMap.SetPixel(x, y, color);
                }
            }
            for (x = 0; x < Histo_Width; x++)
            {
                double dHeight = (double)histogram[x] * (Histo_Height - 1) / (double)max_cnt;
                //가장 큰 원소의 비율 기준으로 그린다.
                // y의 크기 : maxCnt = dHeight(새로운 y) : histogram[x]
                for (y=0;y< (int)dHeight; y++)
                {
                    color = Color.FromArgb(255, 180, 0);
                    histoMap.SetPixel(x, (Histo_Height - 1) - y,color);
                }
            }
            grBm.DrawImage(histoMap, leftTopX, letfTopY);
            //grBm 과 bitmap이 연결되고 => histoMap 이게 bitmap에 저장이 된다. 
            Invalidate();
            //페인트 객체 강제로 발생한다. 


        }
    }
}
