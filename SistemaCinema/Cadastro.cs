using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace SistemaCinema.Login_Cadastro {
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerCadastro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=ByteBlaze";
        public string strSQL = "";

        public void LimparDados() {

            //Limpar a caixa de texto
            mkt_cpf.Clear();
            txt_nome.Clear();
            txt_Email.Clear();
            txt_Senha.Clear();
            txt_Senha2.Clear();

            return;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (mkt_cpf.Text.Trim().Length == 14) {
                    conectar = new NpgsqlConnection(strCon);
                    conectar.Open();
                    strSQL = "SELECT * FROM clientes WHERE CPF = '" + mkt_cpf.Text + "'";
                    ComandoSQL = new NpgsqlCommand(strSQL, conectar);
                    LerCadastro = ComandoSQL.ExecuteReader();
                    if (LerCadastro.Read()){
                        MessageBox.Show("Já existe esse cliente!", "Sistema Informa");
                    } else {
                        
                        LerCadastro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;

                        if (txt_Senha.Text == txt_Senha2.Text) {
                            
                            strSQL = "INSERT INTO clientes " + "(email, nome, cpf, senha)" +
                            "VALUES (" +
                            "'" + txt_Email.Text + "'," +
                            "'" + txt_nome.Text + "'," +
                            "'" + mkt_cpf.Text + "'," +
                            "'" + txt_Senha.Text + "');";

                            ComandoSQL = new NpgsqlCommand(strSQL, conectar);
                            ComandoSQL.ExecuteNonQuery();
                            MessageBox.Show("Cadastrado com Sucesso","Sistema Informa");

                            LimparDados();
                            
                            this.Hide();
                            Login log = new Login();
                            log.ShowDialog();
                            this.Show();
                            if (Login.ActiveForm != null) Cadastro.ActiveForm.Close();

                        } else {
                            MessageBox.Show("As senhas não estão iguais", "Sistema Informa");
                            txt_Senha2.Focus();
                        }
                    }

                    conectar.Close();
                } else {
                    MessageBox.Show("Inseria o campo CPF", "Sistema Informa");

                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);

            }
            
        }

        private void cb_Senha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Senha.CheckState == CheckState.Checked)
            {
                txt_Senha.UseSystemPasswordChar = true;
                cb_Senha.BackgroundImage = Properties.Resources.oiobrancofechado;
            }
            else
            {
                txt_Senha.UseSystemPasswordChar = false;
                cb_Senha.BackgroundImage = Properties.Resources.view_1_1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Senha2.CheckState == CheckState.Checked)
            {
                txt_Senha2.UseSystemPasswordChar = true;
                cb_Senha2.BackgroundImage = Properties.Resources.oiobrancofechado;

            }
            else
            {
                txt_Senha2.UseSystemPasswordChar = false;
                cb_Senha2.BackgroundImage = Properties.Resources.view_1_1;
            }
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            if (cb_Senha.CheckState == CheckState.Checked)
            {
                txt_Senha.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cb_Senha2.CheckState == CheckState.Checked)
            {
                txt_Senha2.UseSystemPasswordChar = true;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
