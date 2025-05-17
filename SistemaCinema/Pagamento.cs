using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCinema {
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        public Pagamento(string cadeirasEscolhidas, string valorTotal)
        {
            InitializeComponent();
            txt_cadeirasescolhidas.Text = cadeirasEscolhidas;
            txt_ValorPagar.Text = valorTotal;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Caramba meu que doideira.", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Caramba meu que doideira.", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void customButton2_Click_1(object sender, EventArgs e)
        {
            QrCode code = new QrCode();
            code.ShowDialog();
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            OpcaoCartao cartao = new OpcaoCartao();
            cartao.Show();
        }
    }
}
