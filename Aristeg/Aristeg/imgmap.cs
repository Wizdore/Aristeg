using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristeg
{
    class imgmap
    {
        Bitmap im;
        BitArray text;

        const int imOffset = 40;
        int imw;
        int imh;
        int pixelCount;

        public Image getSteggedImage()
        {
            return im;
        }

        public imgmap(Image i, Byte[] t)
        {
            im = new Bitmap(i);
            text = new BitArray(t);

            imw = im.Width;
            imh = im.Height;
            pixelCount = imw * imh;

            embedMsg();
        }

        private void embedMsg()
        {

            int length = text.Length;

            BitArray b = new BitArray(BitConverter.GetBytes(length));
            
            for(int i=0; i<b.Length; i++)
            {
                bool isOdd = b.Get(i);
                setim(i, isOdd);
            }
            

            for(int i=0;i<text.Length;i++)
            {
                bool isOdd = text.Get(i);
                setim(i + imOffset, isOdd);
            }
        }

        private void setim(int i, bool isOdd)
        {
            int posh = i / imh;
            int posw = i % imw;
            Color pixel = im.GetPixel(posw, posh);

            int checker = Convert.ToInt32(pixel.R) + Convert.ToInt32(pixel.G) + Convert.ToInt32(pixel.B);
            Color newPixel = pixel;

            if(isOdd == true && checker%2 == 0)
            {
                Random r = new Random();
                int randNum = r.Next(1, 4);

                if(randNum == 1)
                {
                    int col = Convert.ToInt32(pixel.R);

                    if (col > 128)  col--;
                    else col++;
                    newPixel = Color.FromArgb(col, Convert.ToInt32(pixel.G), Convert.ToInt32(pixel.B));
                }
                else if(randNum == 2)
                {
                    int col = Convert.ToInt32(pixel.G);

                    if (col > 128) col--;
                    else col++;
                    newPixel = Color.FromArgb(Convert.ToInt32(pixel.R), col, Convert.ToInt32(pixel.B));
                }
                else if(randNum == 3)
                {
                    int col = Convert.ToInt32(pixel.B);

                    if (col > 128) col--;
                    else col++;
                    newPixel = Color.FromArgb(Convert.ToInt32(pixel.R), Convert.ToInt32(pixel.G), col);
                }

            }
            else if (isOdd == false && checker % 2 == 1)
            {
                Random r = new Random();
                int randNum = r.Next(1, 4);

                if (randNum == 1)
                {
                    int col = Convert.ToInt32(pixel.R);

                    if (col > 128) col = col - 1;
                    else col++;
                    newPixel = Color.FromArgb(col, Convert.ToInt32(pixel.G), Convert.ToInt32(pixel.B));
                }
                else if (randNum == 2)
                {
                    int col = Convert.ToInt32(pixel.G);

                    if (col > 128) col = col - 1;
                    else col++;
                    newPixel = Color.FromArgb(Convert.ToInt32(pixel.R), col, Convert.ToInt32(pixel.B));
                }
                else if (randNum == 3)
                {
                    int col = Convert.ToInt32(pixel.B);

                    if (col > 128) col = col - 1;
                    else col++;
                    newPixel = Color.FromArgb(Convert.ToInt32(pixel.R), Convert.ToInt32(pixel.G), col);
                }

            }

            im.SetPixel(posw, posh, newPixel);
        }
    }
}
