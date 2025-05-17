using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;
using NpgsqlTypes;
using static SistemaCinema.Descrição;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace SistemaCinema {
    public partial class Assentos : Form
    {
        public Assentos()
        {
            InitializeComponent();
            StatusAssentos();
            txt_valorIngressos.Text = "0.00";

        }



        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=ByteBlaze";
        public string strSQL = "";


        public static void Mano()
        {
            GlobalAssent.Fechar = false;
            GlobalAssent.Assent = false;
        }

        public static class GlobalAssent
        {
            public static bool Fechar { get; set; }
            public static bool Assent { get; set; }
        }

        private Button[] botoesAssentos;

        public void StatusAssentos()
        {
            botoesAssentos = new Button[] {

                btn_A1, btn_A2, btn_A3, btn_A4, btn_A5,
                btn_B1, btn_B2, btn_B3, btn_B4, btn_B5,
                btn_C1, btn_C2, btn_C3, btn_C4, btn_C5,
                btn_D1, btn_D2, btn_D3, btn_D4, btn_D5

            };

            try
            {
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT numero_assento, disponivel FROM Assentos WHERE horario_id = @horarioId";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    ComandoSQL.Parameters.AddWithValue("@horarioId", 1);
                    NpgsqlDataReader reader = ComandoSQL.ExecuteReader();

                    while (reader.Read())
                    {
                        string numeroAssento = reader["numero_assento"].ToString();
                        bool disponivel = (bool)reader["disponivel"];

                        // Encontra o botão correspondente no array e o desabilita se não estiver disponível
                        foreach (Button botao in botoesAssentos)
                        {
                            if (botao.Text == numeroAssento && !disponivel)
                            {
                                botao.Enabled = false; // Desabilita o botão se o assento estiver ocupado
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Assentos_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            txt_cadeiras.Clear();

        }

        private void customButton21_Click_1(object sender, EventArgs e)
        {
            Pagamento pag = new Pagamento(txt_cadeiras.Text, txt_valorIngressos.Text);
            pag.Show();

            //GlobalAssent.Assent = true;
            //this.Close();
        }

        private void customButton22_Click_1(object sender, EventArgs e)
        {
            GlobalAssent.Fechar = true;
            this.Close();
        }

        private void btn_A1_Click(object sender, EventArgs e)
        {
            if (btn_A1 != null)
            {
                txt_cadeiras.Text += btn_A1.Text + " ";

            }

            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);

            btn_A1.Enabled = false;

        }

        private void btn_A2_Click(object sender, EventArgs e)
        {
            if (btn_A2 != null)
            {
                txt_cadeiras.Text += btn_A2.Text + " ";
                string ValorInicial = txt_valorIngressos.Text;
                double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
                double ValorSomado = ValorConvertido + 20.00;
                txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            }
            btn_A2.Enabled = false;
        }

        private void btn_A3_Click(object sender, EventArgs e)
        {
            if (btn_A3 != null)
            {
                txt_cadeiras.Text += btn_A3.Text + " ";

                string ValorInicial = txt_valorIngressos.Text;
                double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
                double ValorSomado = ValorConvertido + 20.00;
                txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);

            }
            btn_A3.Enabled = false;
        }

        private void btn_B4_Click(object sender, EventArgs e)
        {
            if (btn_B4 != null)
            {
                txt_cadeiras.Text += btn_B4.Text + " ";
                string ValorInicial = txt_valorIngressos.Text;
                double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
                double ValorSomado = ValorConvertido + 20.00;
                txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            }
            btn_B4.Enabled = false;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            txt_cadeiras.Clear();
            txt_valorIngressos.Text = "0.00";
            botoesAssentos = new Button[] {

                btn_A1, btn_A5, btn_B3, btn_B4, btn_B5,
                btn_C1, btn_C2, btn_C3, btn_C4, btn_C5

            };

            foreach (Button botao in botoesAssentos)
            {
                if (botao.Enabled == false)
                {
                    botao.Enabled = true; // Desabilita o botão se o assento estiver ocupado
                }
            }


        }

        private void btn_C1_Click(object sender, EventArgs e)
        {
            if (btn_C1 != null)
            {
                txt_cadeiras.Text += btn_C1.Text + " ";

            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_C1.Enabled = false;
        }

        private void btn_C2_Click(object sender, EventArgs e)
        {
            if (btn_C2 != null)
            {
                txt_cadeiras.Text += btn_C2.Text + " ";
            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_C2.Enabled = false;
        }

        private void btn_C3_Click(object sender, EventArgs e)
        {
            if (btn_C3 != null)
            {
                txt_cadeiras.Text += btn_C3.Text + " ";

            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_C3.Enabled = false;
        }

        private void btn_C4_Click(object sender, EventArgs e)
        {
            if (btn_C4 != null)
            {
                txt_cadeiras.Text += btn_C4.Text + " ";

            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_C4.Enabled = false;
        }

        private void btn_B5_Click(object sender, EventArgs e)
        {
            if (btn_B5 != null)
            {
                txt_cadeiras.Text += btn_B5.Text + " ";
            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_B5.Enabled = false;
        }

        private void btn_B3_Click(object sender, EventArgs e)
        {
            if (btn_B3 != null)
            {
                txt_cadeiras.Text += btn_B3.Text + " ";
            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_B3.Enabled = false;
        }

        private void btn_A4_Click(object sender, EventArgs e)
        {
            if (btn_A4 != null)
            {
                txt_cadeiras.Text += btn_A4.Text + " ";
            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_A4.Enabled = false;
        }

        private void btn_A5_Click(object sender, EventArgs e)
        {
            if (btn_A5 != null)
            {
                txt_cadeiras.Text += btn_A5.Text + " ";
            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_A5.Enabled = false;
        }

        private void btn_C5_Click(object sender, EventArgs e)
        {
            if (btn_C5 != null)
            {
                txt_cadeiras.Text += btn_C5.Text + " ";
            }
            string ValorInicial = txt_valorIngressos.Text;
            double ValorConvertido = double.Parse(ValorInicial, new CultureInfo("pt-BR"));
            double ValorSomado = ValorConvertido + 20.00;
            txt_valorIngressos.Text = ValorSomado.ToString("F2", CultureInfo.CurrentCulture);
            btn_C5.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cadeiras_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_D1_Click(object sender, EventArgs e)
        {

        }
    }
}
