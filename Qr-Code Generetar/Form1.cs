using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace Qr_Code_Generetar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void olusturBTN_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            qrpcrBox.Image = enc.Encode(lnkBOX.Text);

            sonucLBL.ForeColor = Color.Green;

            sonucLBL.Text = "QR Oluşturuldu";
        }
    }
}
