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

namespace SistemaCinema
{
    public partial class QrCode : Form
    {
        public QrCode()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento Realizado!", "Sistema Informa.");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("00020126550014br.gov.bcb.pix0111407576698590218So para um projeto5204000053039865802BR5921KAIQUE LEMOS CARRENHO6009SAO PAULO62290525YFFD3mPYAWBiaYYGxnOsrqWXI630499EB");
        }
    }
}
