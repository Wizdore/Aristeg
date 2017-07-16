using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristeg
{
    class Steg
    {
        private Image carrierImage;
        private String password;
        private Byte[] hiddenMessage;

        public void setPassword(string pass)
        {
            password = pass;
        }


        public void setCarrierImage(Image i)
        {
            carrierImage = i;
        }

        public void encryptMessage(string message)
        {
            string compressedMessage = Crypto.Compress(message);
            string encMessage = Crypto.Encrypt(compressedMessage, password);

            hiddenMessage = Encoding.ASCII.GetBytes(encMessage);
        }

        public int minImageSizeInInteger()
        {
            return (hiddenMessage.Length * 8) + 100;
        }

        public String minImageSize()
        {
            int sz = (hiddenMessage.Length * 8) + 100;
            int sqrSz = (int)Math.Ceiling(Math.Sqrt(sz)+1)+1;
            string ret = "" + sqrSz + "x" + sqrSz + " (" + Math.Ceiling((sz / 1000.00)+1) + " KiloPixels)";
            return ret;
        }

        public Image getSteggedImage()
        {
            imgmap i = new imgmap(carrierImage, hiddenMessage);
            return i.getSteggedImage();
        }

    }
}
