using Npgsql;
using SistemaCinema.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;

namespace SistemaCinema {
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerCadastro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=ByteBlaze";
        public string strSQL = "";

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT COUNT(1) FROM clientes WHERE email = @email AND senha = @senha";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    ComandoSQL.Parameters.AddWithValue("@email", txt_Email.Text);
                    ComandoSQL.Parameters.AddWithValue("@senha", txt_Senha.Text);

                    int count = Convert.ToInt32(ComandoSQL.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Login Realizado com Sucesso.", "Sistema Informa");
                        this.Hide();
                        MainMenu menu = new MainMenu();
                        menu.ShowDialog();
                        this.Show();
                        if (MainMenu.ActiveForm != null) Login.ActiveForm.Close();

                    }
                    else
                    {
                        MessageBox.Show("Email ou Senha incorretos");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Acesso acss = new Acesso();
            acss.ShowDialog();
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (cb_Senha.CheckState == CheckState.Checked)
            {
                txt_Senha.UseSystemPasswordChar = true;
            }
        }



        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Acesso acss = new Acesso();
            acss.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
