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
    public partial class Form1 : Form
    {
        Graphics grBm;
        Bitmap bitmap;
        Image image;
        int[,] grayArray;
        public Form1()
        {
            InitializeComponent();
            setShadowBitmap();
        }
        private void setShadowBitmap()
        {
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height); //클라이언트 영역 만큼 비트맵을 만듬 
            grBm = Graphics.FromImage(bitmap);//bitmap 과 grBm(그래픽스 객체)와 연결 
            grBm.Clear(BackColor);
        }

        private void OpenItem_Click(object sender, EventArgs e)
        {
            string filterName = "All Files(*.*)|*.*|Bitmap File(*.bmp)|*.bmp|Gif File(*.gif)|*.gif)|*.gif|";
            filterName = filterName + "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|TIFF(*.tiff)*.tiff";
            ofdOpen.Title = "Open Image";
            ofdOpen.Filter = filterName;
            if(ofdOpen.ShowDialog() == DialogResult.OK)
            {
                string strFilename = ofdOpen.FileName;
                image = Image.FromFile(strFilename);
                this.ClientSize = new System.Drawing.Size(image.Width, image.Height);
                setShadowBitmap();
                grBm.DrawImage(image, 0, 0, image.Width, image.Height);
                copyBitmap2Array();
            }
            Invalidate();
        }
        void copyBitmap2Array()
        {
            int x, y, brightness;
            Color color;
            grayArray = new int[bitmap.Height, bitmap.Width];
            for(y=0;y<bitmap.Height;y++)
            {
                for(x=0;x<bitmap.Width;x++)
                {
                    color = bitmap.GetPixel(x, y);
                    brightness = color.R;
                    grayArray[y, x] = brightness;
                }
            }
        }
        void displayGrayArray(int leftTopx,int leftTopY,int[,]grayA, int Width, int Height)
        {
            int x, y;
            Color color;
            Bitmap gBitmap = new Bitmap(Width, Height);
            for(y=0;y<Height;y++)
            {
                for(x=0;x<Width;x++)
                {
                    color = Color.FromArgb(grayA[y, x], grayA[y, x], grayA[y, x]);
                    gBitmap.SetPixel(x, y, color);
                }
            }
            grBm.DrawImage(gBitmap, leftTopx, leftTopY, gBitmap.Width, gBitmap.Height);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics; //get 글래픽스를 가져옵니다. 
            gr.DrawImage(bitmap, 0, 0);
        }

        private void SfdSave_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.M)
            {
                if (menuStrip1.Visible)
                {
                    menuStrip1.Visible = false;
                }
                else menuStrip1.Visible = true;
            }
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            string filterName = "All Files(*.*)|*.*|Bitmap File(*.bmp)|*.bmp|Gif File(*.gif)|*.gif)|*.gif|";
            filterName = filterName + "JPEG(*.jpg)|*.jpg|PHG(*.png)|*.png|TIFF(*.tif)*.tif";
            sfdSave.Title = "Save Image as";
            sfdSave.OverwritePrompt = true;
            sfdSave.Filter = filterName;
            if(sfdSave.ShowDialog() == DialogResult.OK)
            {
                string strFliename = sfdSave.FileName;
                string strLowFilename = strFliename.ToLower();
                bitmap.Save(strLowFilename);
            }
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x, y;
            int brightness;
            const int ADD_VALUE = 0;
            Color color;
            int[,] grayArray = new int[image.Height, image.Width];
            Graphics gr = CreateGraphics();
            
            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    color = bitmap.GetPixel(x, y);
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
                    bitmap.SetPixel(x, y, color);
                }
            }
            gr.DrawImage(bitmap, 0,0);
        }

        private void ConsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            adjustBright(35);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        /*void adjustBright(int brightvalue)
        {
            int x, y;
            for(y=0;y<bitmap.Height;y++)
                for(x=0;x<bitmap.Width;x++)
                {
                    grayArray[y, x] += brightvalue;
                    if (grayArray[y, x] > 255) grayArray[y, x]=255;
                    if (grayArray[y, x] < 0) grayArray[y, x] = 0;

                }
        }
        */
        void adjustBright(int brightValue)
        {
            int x, y, index, newValue;
            int[] LUT = new int[256];
            for (index=0;index<256;index++)
            {
                newValue = index + brightValue;
                if (newValue > 255) newValue = 255;
                if (newValue < 0) newValue = 0;
                LUT[index] = newValue;
            }
            for(y=0;y<bitmap.Height;y++)
            {
                for(x=0;x<bitmap.Width;x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];
                }
            }
        }
        private void SubItem_Click(object sender, EventArgs e)
        {
            adjustBright(-35);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }

        private void IncreItem_Click(object sender, EventArgs e)
        {
            adjustContrast(1.4);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        /*void adjustContrast(double contrastValue)
        {
            int x, y;
            for(y=0;y<bitmap.Height;y++)
            {
                for(x=0;x<bitmap.Width;x++)
                {
                    grayArray[y, x] = (int)(grayArray[y, x] * contrastValue);
                    if (grayArray[y, x] > 255) grayArray[y, x] = 255;
                }
            }
        }
        */
        void adjustContrast(double ContrastValue)
        {
            int x, y, index, newValue;
            int[] LUT = new int[256];
            for (index = 0; index < 256; index++)
            {
                newValue = (int)(index*ContrastValue);
                if (newValue > 255) newValue = 255;

                LUT[index] = newValue;
            }
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];
                }
            }
        }

        private void DecreItem_Click(object sender, EventArgs e)
        {
            adjustContrast(1.0 / 1.4);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }

        private void InverseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InverseItem_Click(object sender, EventArgs e)
        {
            inverseByLUT();
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        void inverseByLUT()
        {
            int x, y, index;
            int[] LUT = new int[256];
            for(index =0;index<256;index++)
            {
                LUT[index] = 255 - index;
            }
            for(y=0;y<bitmap.Height;y++)
                for(x=0;x<bitmap.Width;x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];
                }
        }
        void adjustGamma(double gammaValue)
        {
            int x, y, index;
            int[] LUT = new int[256];
            for(index=0;index<256;index++)
            {
                LUT[index] = (int)(255.0 * Math.Pow((double)index / 255, 1.0 / gammaValue)); //a의 b승 
            }
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];
                }
            }
        }
        private void Gamma1Item_Click(object sender, EventArgs e)
        {
            adjustGamma(2.5);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }

        private void Gamma2Item_Click(object sender, EventArgs e)
        {
            adjustGamma(0.5);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        void adjustContrastAlpha(int alphaValue)
        {
            int x, y, newValue,index;
            int[] LUT = new int[256];
            for (index = 0; index < 256; index++)
            {
                newValue = (int)(255.0 / (255.0 - 2.0 * alphaValue) * (index - alphaValue));//a의 b승 
                if (newValue > 255) newValue = 255;
                if (newValue < 0) newValue = 0;
                LUT[index] = newValue;
            }
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];
                }
            }
        }
        private void Increase1Item_Click(object sender, EventArgs e)
        {
            adjustContrastAlpha(30);
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        void adjustContrastS()
        {
            int x, y,  index;
            double newValue;

            
            int[] LUT = new int[256];
            for (index = 0; index <= 127; index++)
            {
                LUT[index] = (int)(index * index / 127.0);
            }
            for (index =128;index<256;index++)
            {
                newValue = index - 255.0;
                newValue = newValue * newValue / 127;
                newValue = 255 - newValue;
                LUT[index] = (int)newValue;
            }
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];
                }
            }
        }
        private void Increase2Item_Click(object sender, EventArgs e)
        {
            adjustContrastS();
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }

        private void DeceaseItem_Click(object sender, EventArgs e)
        {

        }

        private void CapItem_Click(object sender, EventArgs e)
        {
            int x, y, index;
            int[] LUT = new int[256];
            for(index=0;index<256;index++)
            {
                double newValue = index / 127 - 1;
                newValue = 255 * newValue * newValue;
                newValue = 255 - newValue;
                if (newValue > 255) newValue = 255;
                if (newValue < 0) newValue = 0;
                LUT[index] =(int) newValue;
            }
            for(y=0;y<bitmap.Height;y++)
            {
                for(x=0;x<bitmap.Width;x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];

                }
            }
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }

        private void CupItem_Click(object sender, EventArgs e)
        {
            int x, y, index;
            int[] LUT = new int[256];
            for (index = 0; index < 256; index++)
            {
                double newValue = index / 127 - 1;
                newValue = 255 * newValue * newValue;
                if (newValue > 255) newValue = 255;
                if (newValue < 0) newValue = 0;
                LUT[index] = (int)newValue;
            }
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];

                }
            }
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        void display(int x, int y, int []LUT)
        {
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    grayArray[y, x] = LUT[grayArray[y, x]];

                }
            }
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
        }
        HistogramForm histo;
        private void HistogramViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            histo = new HistogramForm(grayArray, bitmap.Width, bitmap.Height);
            histo.Show();
        }

        private void BasicStrechItem_Click(object sender, EventArgs e)
        {
            baiscStrech();
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
            Invalidate();
        }
        void baiscStrech()
        {
            int x, y;
            int alpha = 0, beta = 255;
            int[] histogram = new int[256];
            int[] LUT = new int[256];

            histogram.Initialize();
            for(y=0;y<bitmap.Height;y++)
            {
                for(x=0;x<bitmap.Width;x++)
                {
                    histogram[grayArray[y, x]]++;
                }
            }
            for(x=0;x<256;x++)
            {
                if(histogram[x] != 0) //0이 아닌 최초의 값을 알파에 집어넣은다.
                {
                    alpha = x;
                    break;
                }
            }
            for(x=255;x>0;x--) //0이 아닌 제일 마지막 값을 베타에 넣는다.
            {
                beta = x;
                break;
            }
            for(x=0;x<alpha;x++)
            {
                LUT[x] = 0;
            }
            for(x=255;x>0;x--)
            {
                LUT[x] = 255;
            }
            for(x=alpha;x<=beta;x++)
            {
                LUT[x] = (int)(x - alpha) * 255 / (beta - alpha);
                //(beta - alpha) : 255 = x-a : T

            }
            display(x, y, LUT);
        }

        private void RateStrechItem_Click(object sender, EventArgs e)
        {
            rateStrech(3.0, 3.0);
            UserInvalidate();

        }
        void UserInvalidate()
        {
            displayGrayArray(0, 0, grayArray, bitmap.Width, bitmap.Height);
            Invalidate();
        }
        void rateStrech(double alphaPercent, double betaPercent)
        {
            //비율 값으로 알파 베타 값을 정한다. 
            int x, y;
            int alpha = 0, beta = 255;
            int histoSum;
            int[] histogram = new int[256];
            int[] LUT = new int[256];
            int numberOfPixels;
            histogram.Initialize();
            for(y=0;y<bitmap.Height;y++)
            {
                for(x=0;x<bitmap.Width;x++)
                {
                    histogram[grayArray[y, x]]++;
                }
            }
            numberOfPixels = bitmap.Width * bitmap.Height; //전체 픽셀의 갯수 
            histoSum = 0;
            for(x=0;x<256;x++)
            {
                histoSum += histogram[x];
                if(histoSum*100/numberOfPixels >= alphaPercent) //알파 퍼센트 까지 찾고 
                {
                    alpha = x; //알파 퍼센트를 넘는 그 순간을 알파에 집어넣는다.
                    break;
                }
            }
            histoSum = 0;
            for(x=255;x>0;x--)
            {
                histoSum += histogram[x];
                if(histoSum*100/numberOfPixels >= betaPercent)//베타 퍼센트 까지 찾고 
                {
                    beta = x;
                    break;
                }
            }
            for (x = 0; x < alpha; x++) LUT[x] = 0;
            for (x = 255; x > beta; x--) LUT[x] = 255;
            for(x=alpha; x<=beta;x++)
            {
                LUT[x] = (int)(x - alpha) * 255 / (beta - alpha);
            }
            display(x, y, LUT);
        }

        private void EqualizationItem_Click(object sender, EventArgs e)
        {
            equalization();
            UserInvalidate();
        }
        
        void histoCount(int x, int y, int []histogram)
        {
            histogram.Initialize();
            for (y = 0; y < bitmap.Height; y++)
            {
                for (x = 0; x < bitmap.Width; x++)
                {
                    histogram[grayArray[y, x]]++;
                }
            }
        }
        void equalization() //histogram 평활화 
        {
            int x=0, y=0 ;
            int sum;
            double scale;
            int[] histogram = new int[256];
            int[] LUT = new int[256];
            int numberOfPixels;
            histoCount(x, y, histogram);
            numberOfPixels = bitmap.Width * bitmap.Height;
            sum = 0;
            scale = 255.0 / numberOfPixels;
            for (x = 0; x < 256; x++)
            {
                sum += histogram[x];
                LUT[x] = (int)(sum * scale + 0.5);
            }
            display(x, y, LUT);
                

        }
    }
}
