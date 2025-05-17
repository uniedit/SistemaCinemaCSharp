using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Npgsql;

namespace SistemaCinema
{
    public partial class OpcaoCartao : Form
    {
        public OpcaoCartao()
        {
            InitializeComponent();
        }
        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerCadastro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=ByteBlaze";
        public string strSQL = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            try { 
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT COUNT(1) FROM cartao WHERE nome_titular = @nome_titular AND email = @email AND numero_cartao = @numero_cartao AND data_validade = @data_validade";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    ComandoSQL.Parameters.AddWithValue("@nome_titular", txt_NomeTitular.Text);
                    ComandoSQL.Parameters.AddWithValue("@email", txt_emailCartao.Text);
                    ComandoSQL.Parameters.AddWithValue("@numero_cartao", mkt_numcartao.Text);
                    ComandoSQL.Parameters.AddWithValue("@data_validade", mkt_venc.Text);

                    int count = Convert.ToInt32(ComandoSQL.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Pagamento Efetivado.", "Sistema Informa");
                        Application.Exit();

                    }
                    else
                    {
                        MessageBox.Show("Campos Incorretos");
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void OpcaoCartao_Load(object sender, EventArgs e)
        {

        }
    }
}
