using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aristeg
{
    public partial class Splash : Form
    {
        Steg ensteg;

        public Splash()
        {
            InitializeComponent();
            ensteg = new Steg();

            ButtonStatesEnsteg(false);
            ButtonStatesDesteg(false);
            lbl_toolStrip.Text = "Enter password to start";
        }

        private void ButtonStatesDesteg(bool state)
        {
            btn_LoadSteggedImage.Enabled = state;
            btn_SaveHiddenMessage.Enabled = state;
        }

        private void ButtonStatesEnsteg(bool state)
        {
            btn_LoadCarrierImage.Enabled = state;
            btn_loadText.Enabled = state;
            btn_SaveSteggedImage.Enabled = state;
        }

        private void btn_loadText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the text file to be hidden";
            ofd.Filter = "Text File|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                StreamReader sr = new StreamReader(file);

                string hiddenMessage = File.ReadAllText(file);
                ensteg.encryptMessage(hiddenMessage);

                if (hiddenMessage.Length > 0)
                {
                    lbl_toolStrip.Text = "Select img Bigger than " + ensteg.minImageSize();
                    btn_LoadCarrierImage.Enabled = true;
                }
                else
                {
                    lbl_toolStrip.Text = "Text file is empty";
                    btn_LoadCarrierImage.Enabled = false;
                }
            }
        }

        private void btn_LoadCarrierImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the Carrier Image";
            ofd.Filter = "jpg Image|*.jpg|jpeg Image|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                Image carrierImage = Image.FromFile(file);
                ensteg.setCarrierImage(carrierImage);

                int pixelCount = carrierImage.Width * carrierImage.Height;
                int minImageSize = ensteg.minImageSizeInInteger();

                if (minImageSize > pixelCount)
                {
                    DialogResult result = MessageBox.Show("Image needs to be " + ensteg.minImageSize() + " or bigger.", "Image size(" + (carrierImage.Width * carrierImage.Height) / 1000.00 + " kiloPixels) too small");
                }
                else
                {
                    lbl_toolStrip.Text = "Now save the Stegged Image";
                    btn_SaveSteggedImage.Enabled = true;

                }
            }
        }

        private void txt_LockPassword_TextChanged(object sender, EventArgs e)
        {
            ensteg.setPassword(txt_LockPassword.Text);
            if(txt_LockPassword.Text.Length > 0)
            {
                btn_loadText.Enabled = true;
                lbl_toolStrip.Text = "Now Open the secret message.";
            }
            else ButtonStatesEnsteg(false);
            //Console.WriteLine(txt_LockPassword.Text);
        }

        private void btn_SaveSteggedImage_Click(object sender, EventArgs e)
        {
            Image myImage = ensteg.getSteggedImage();

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "jpg Image File(*.jpg)|*.jpg",
                DefaultExt = "jpg",
                AddExtension = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                myImage.Save(sfd.FileName);
            }
        }


        private string unlockPass;
        private Bitmap steggedImage;
        private string deSteggedMessage;

        private void txt_UnlockPassword_TextChanged(object sender, EventArgs e)
        {
            unlockPass = txt_UnlockPassword.Text;
            if (txt_UnlockPassword.Text.Length > 0)
            {
                btn_LoadSteggedImage.Enabled = true;
                lbl_toolStrip.Text = "Load the Stegged image";
            }
            else ButtonStatesDesteg(false);
        }

        private void btn_LoadSteggedImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the Stegged Image";
            ofd.Filter = "jpg Image|*.jpg|jpeg Image|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                steggedImage = (Bitmap)Image.FromFile(file);
            }

            DeSteg deSteg = new DeSteg(unlockPass, steggedImage);
            int msgLength = deSteg.getMsgLength();

            if (msgLength > (steggedImage.Height * steggedImage.Width) + 40)
            {
                MessageBox.Show("Invalid Image");
            }
            else
            {

                try
                {
                    deSteggedMessage = deSteg.extractHiddenMsg();
                }catch(Exception ex)
                {
                    MessageBox.Show("Password Did not match");
                    return;
                }

                lbl_toolStrip.Text = "Save txt file recovered from the Image";
                btn_SaveHiddenMessage.Enabled = true;
            }
        }

        private void btn_SaveHiddenMessage_Click(object sender, EventArgs e)
        {
            DeSteg deSteg = new DeSteg(unlockPass, steggedImage);

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "txt Text File(*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, deSteggedMessage);
            }

        }
    }
}
