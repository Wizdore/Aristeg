namespace Aristeg
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaveSteggedImage = new System.Windows.Forms.Button();
            this.txt_LockPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LoadCarrierImage = new System.Windows.Forms.Button();
            this.btn_loadText = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_toolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SaveHiddenMessage = new System.Windows.Forms.Button();
            this.txt_UnlockPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LoadSteggedImage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveSteggedImage);
            this.groupBox1.Controls.Add(this.txt_LockPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_LoadCarrierImage);
            this.groupBox1.Controls.Add(this.btn_loadText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EnSteg";
            // 
            // btn_SaveSteggedImage
            // 
            this.btn_SaveSteggedImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveSteggedImage.Location = new System.Drawing.Point(7, 175);
            this.btn_SaveSteggedImage.Name = "btn_SaveSteggedImage";
            this.btn_SaveSteggedImage.Size = new System.Drawing.Size(229, 54);
            this.btn_SaveSteggedImage.TabIndex = 4;
            this.btn_SaveSteggedImage.Text = "Save Stegged Image";
            this.btn_SaveSteggedImage.UseVisualStyleBackColor = true;
            this.btn_SaveSteggedImage.Click += new System.EventHandler(this.btn_SaveSteggedImage_Click);
            // 
            // txt_LockPassword
            // 
            this.txt_LockPassword.Location = new System.Drawing.Point(67, 19);
            this.txt_LockPassword.MaxLength = 12;
            this.txt_LockPassword.Name = "txt_LockPassword";
            this.txt_LockPassword.Size = new System.Drawing.Size(169, 20);
            this.txt_LockPassword.TabIndex = 3;
            this.txt_LockPassword.TextChanged += new System.EventHandler(this.txt_LockPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // btn_LoadCarrierImage
            // 
            this.btn_LoadCarrierImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadCarrierImage.Location = new System.Drawing.Point(7, 115);
            this.btn_LoadCarrierImage.Name = "btn_LoadCarrierImage";
            this.btn_LoadCarrierImage.Size = new System.Drawing.Size(229, 54);
            this.btn_LoadCarrierImage.TabIndex = 1;
            this.btn_LoadCarrierImage.Text = "Load Carrier Image";
            this.btn_LoadCarrierImage.UseVisualStyleBackColor = true;
            this.btn_LoadCarrierImage.Click += new System.EventHandler(this.btn_LoadCarrierImage_Click);
            // 
            // btn_loadText
            // 
            this.btn_loadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadText.Location = new System.Drawing.Point(7, 55);
            this.btn_loadText.Name = "btn_loadText";
            this.btn_loadText.Size = new System.Drawing.Size(229, 54);
            this.btn_loadText.TabIndex = 0;
            this.btn_loadText.Text = "Load Text Message";
            this.btn_loadText.UseVisualStyleBackColor = true;
            this.btn_loadText.Click += new System.EventHandler(this.btn_loadText_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_toolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(266, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_toolStrip
            // 
            this.lbl_toolStrip.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lbl_toolStrip.Name = "lbl_toolStrip";
            this.lbl_toolStrip.Size = new System.Drawing.Size(42, 17);
            this.lbl_toolStrip.Text = "Ready!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SaveHiddenMessage);
            this.groupBox2.Controls.Add(this.txt_UnlockPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_LoadSteggedImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DeSteg";
            // 
            // btn_SaveHiddenMessage
            // 
            this.btn_SaveHiddenMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveHiddenMessage.Location = new System.Drawing.Point(7, 116);
            this.btn_SaveHiddenMessage.Name = "btn_SaveHiddenMessage";
            this.btn_SaveHiddenMessage.Size = new System.Drawing.Size(229, 54);
            this.btn_SaveHiddenMessage.TabIndex = 4;
            this.btn_SaveHiddenMessage.Text = "Save Hidden Message";
            this.btn_SaveHiddenMessage.UseVisualStyleBackColor = true;
            this.btn_SaveHiddenMessage.Click += new System.EventHandler(this.btn_SaveHiddenMessage_Click);
            // 
            // txt_UnlockPassword
            // 
            this.txt_UnlockPassword.Location = new System.Drawing.Point(67, 19);
            this.txt_UnlockPassword.MaxLength = 12;
            this.txt_UnlockPassword.Name = "txt_UnlockPassword";
            this.txt_UnlockPassword.Size = new System.Drawing.Size(169, 20);
            this.txt_UnlockPassword.TabIndex = 3;
            this.txt_UnlockPassword.TextChanged += new System.EventHandler(this.txt_UnlockPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btn_LoadSteggedImage
            // 
            this.btn_LoadSteggedImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadSteggedImage.Location = new System.Drawing.Point(7, 56);
            this.btn_LoadSteggedImage.Name = "btn_LoadSteggedImage";
            this.btn_LoadSteggedImage.Size = new System.Drawing.Size(229, 54);
            this.btn_LoadSteggedImage.TabIndex = 0;
            this.btn_LoadSteggedImage.Text = "Load Stegged Image";
            this.btn_LoadSteggedImage.UseVisualStyleBackColor = true;
            this.btn_LoadSteggedImage.Click += new System.EventHandler(this.btn_LoadSteggedImage_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Splash";
            this.Text = "Aristeg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveSteggedImage;
        private System.Windows.Forms.TextBox txt_LockPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LoadCarrierImage;
        private System.Windows.Forms.Button btn_loadText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SaveHiddenMessage;
        private System.Windows.Forms.TextBox txt_UnlockPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LoadSteggedImage;
        private System.Windows.Forms.ToolStripStatusLabel lbl_toolStrip;
    }
}

