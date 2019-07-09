﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorBrightBy3Array
{
    public partial class Form1 : Form
    {
        Image image;

        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            string filterName = "All Files(*.*)|*.*|Bitmap File(*.bmp)|*.bmp|";
            filterName = filterName + "Gif Fle(*.gif)|*.gif|Jpeg File(*.jpg)|*.jpg";
            ofdOpen.Title = "RGB 컬러영상 파일 열기";
            ofdOpen.Filter = filterName;
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                string strFilename = ofdOpen.FileName;
                image = Image.FromFile(strFilename);
                gr.DrawImage(image, 10, 50, image.Width, image.Height);
            }
            gr.Dispose();
        }

        private void btColorBright3_Click(object sender, EventArgs e)
        {
            int x, y, z;
            const int ADD_VALUE = 50;
            Color color;
            int[,,] colorArray =    //3차원 배열 -> 면,행,열 
                new int[3, image.Height, image.Width]; //3은 색의 갯수 
            Graphics gr = CreateGraphics();
            Bitmap gBitmap = new Bitmap(image);

            for (y = 0; y < image.Height; y++)
                for (x = 0; x < image.Width; x++)
                {
                    color = gBitmap.GetPixel(x, y);
                    colorArray[0, y, x] = color.R;
                    colorArray[1, y, x] = color.G;
                    colorArray[2, y, x] = color.B;
                }
            for(z =0; z <3; ++z)
                for (y = 0; y < image.Height; y++)
                    for (x = 0; x < image.Width; x++)
                    {
                        colorArray[z, y, x] += ADD_VALUE ;
                        if(colorArray[z, y, x] > 255)
                            colorArray[z, y, x] = 255; //255이상으로 넘어가면 의미가 없음 -> clanpping 
                    }

            for (z = 0; z < 3; ++z)
                for (y = 0; y < 10; y++)
                    for (x = 0; x < image.Width; x++)
                    {
                        colorArray[z, y, x] = 127 ; //위의 가로를 회색으로 테두리 
                        colorArray[z, image.Height-1-y, x] = 127;//아래 가로를 회색으로 




                    }

            for (x = 0; x < 10 ; x++)
                for (y = 0; y < image.Height ; y++)
                    for (z = 0; z < 3; ++z)                        
                    {
                        colorArray[z, y, x] = 127;
                        colorArray[z, y, image.Width-1-x] = 127;
                    }
            for (y = 0; y < image.Height; y++)
                for (x = 0; x < image.Width; x++)
                {
                    color = Color.FromArgb(
                        colorArray[0, y, x],
                        colorArray[1, y, x], 
                        colorArray[2, y, x]);
                    gBitmap.SetPixel(x, y, color);
                }

            gr.DrawImage(gBitmap, 20 + gBitmap.Width, 50,
                gBitmap.Width, gBitmap.Height);
            gr.Dispose();
        }
    }
}
