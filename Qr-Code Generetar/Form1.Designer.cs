namespace Qr_Code_Generetar
{
    partial class Form1
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
            this.lnkBOX = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.olusturBTN = new System.Windows.Forms.Button();
            this.qrpcrBox = new System.Windows.Forms.PictureBox();
            this.sonucLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrpcrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkBOX
            // 
            this.lnkBOX.Location = new System.Drawing.Point(12, 33);
            this.lnkBOX.Name = "lnkBOX";
            this.lnkBOX.Size = new System.Drawing.Size(287, 22);
            this.lnkBOX.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 14);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(238, 16);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Link, Telefon Numarası Veya Yazı Girin";
            // 
            // olusturBTN
            // 
            this.olusturBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olusturBTN.Location = new System.Drawing.Point(12, 61);
            this.olusturBTN.Name = "olusturBTN";
            this.olusturBTN.Size = new System.Drawing.Size(287, 31);
            this.olusturBTN.TabIndex = 2;
            this.olusturBTN.Text = "Oluştur";
            this.olusturBTN.UseVisualStyleBackColor = true;
            this.olusturBTN.Click += new System.EventHandler(this.olusturBTN_Click);
            // 
            // qrpcrBox
            // 
            this.qrpcrBox.Location = new System.Drawing.Point(13, 127);
            this.qrpcrBox.Name = "qrpcrBox";
            this.qrpcrBox.Size = new System.Drawing.Size(286, 263);
            this.qrpcrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrpcrBox.TabIndex = 3;
            this.qrpcrBox.TabStop = false;
            // 
            // sonucLBL
            // 
            this.sonucLBL.Location = new System.Drawing.Point(15, 105);
            this.sonucLBL.Name = "sonucLBL";
            this.sonucLBL.Size = new System.Drawing.Size(151, 19);
            this.sonucLBL.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 407);
            this.Controls.Add(this.sonucLBL);
            this.Controls.Add(this.qrpcrBox);
            this.Controls.Add(this.olusturBTN);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.lnkBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.qrpcrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lnkBOX;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button olusturBTN;
        private System.Windows.Forms.PictureBox qrpcrBox;
        private System.Windows.Forms.Label sonucLBL;
    }
}

