using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristeg
{
    class DeSteg
    {
        const int imOffset = 40;
        string pass;
        Bitmap image;
        public DeSteg(string p, Bitmap b)
        {
            pass = p;
            image = b;
        }

        public string extractHiddenMsg()
        {
            int length = getMsgLength();

            BitArray msg = new BitArray(length);
            
            for(int i=0; i< length; i++)
            {
                int posx = (i+imOffset) % image.Width;
                int posy = (i + imOffset) / image.Height;
                Color pixel = image.GetPixel(posx, posy);

                int checker = Convert.ToInt32(pixel.R) + Convert.ToInt32(pixel.G) + Convert.ToInt32(pixel.B);
                if (checker % 2 == 1) msg.Set(i, true);
                if (checker % 2 == 0) msg.Set(i, false);
            }

            byte[] byteMsg = BitArrayToByteArray(msg);

            string strMsg = Encoding.UTF8.GetString(byteMsg);
            strMsg = Crypto.Decrypt(strMsg, pass);
            strMsg = Crypto.Decompress(strMsg);
            return strMsg;
        }

        private byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }

        public int getMsgLength()
        {
            BitArray msg = new BitArray(32);
            for(int i=0;i<32;i++)
            {
                int posx = i % image.Width;
                int posy = i / image.Height;
                Color pixel = image.GetPixel(posx, posy);

                int checker = Convert.ToInt32(pixel.R) + Convert.ToInt32(pixel.G) + Convert.ToInt32(pixel.B);

                if (checker % 2 == 1) msg.Set(i, true);
                if (checker % 2 == 0) msg.Set(i, false);
            }
            return getIntFromBitArray(msg);
        }

        private int getIntFromBitArray(BitArray bitArray)
        {

            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];

        }

    }
}
