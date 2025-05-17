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
using static SistemaCinema.Sessões;

namespace SistemaCinema {
    public partial class Descrição : Form
    {
        public Descrição()
        {
            InitializeComponent();
            if (Global.VenonAtv == true)
            {
                Venom();
                picBox.BackgroundImage = Properties.Resources.VENOOOOOOOOON;
            }
            if (Global.RoboAtv == true)
            {
                RoboSelvagem();
                picBox.BackgroundImage = Properties.Resources.cc85122f8c6571afb0102ec2e27daae5_jpg_c_310_420_x_f_jpg_q_x_xxyxx;
            }
            if (Global.YoNameAtv == true)
            {
                YourName();
                picBox.BackgroundImage = Properties.Resources.your_name__01_Capa_p;
            }
            if (Global.MommyAtv == true)
            {
                Minhamãe();
                picBox.BackgroundImage = Properties.Resources._100_cartaz;
            }
        }

        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerCadastro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=ByteBlaze";
        public string strSQL = "";

        public void RoboSelvagem()
        {
            try
            {
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT descricao FROM filmes WHERE descricao = 'A épica aventura acompanha a jornada de uma robô – a unidade ROZZUM 7134, “Roz” – que naufraga em uma ilha desabitada e precisa aprender a se adaptar ao ambiente hostil, construindo pouco a pouco relacionamentos com os animais nativos, e até adotando um filhotinho de ganso órfão.';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_sinopse.Text = titulo;
                        lbl_Sala.Text = "Sala 2";
                        Global.YoNameAtv = true;
                    }
                    else
                    {
                        lbl_sinopse.Text = "Título não encontrado";
                        Global.YoNameAtv = false;
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conectar.Close();
                Global.YoNameAtv = false;
            }
        }
        public void Minhamãe()
        {
            try
            {
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT descricao FROM filmes WHERE descricao = 'Dona Hermínia é uma senhora de meia-idade, divorciada do marido, que a trocou por uma mulher mais jovem. Hiperativa, ela não larga o pé de seus filhos Marcelina e Juliano. Um dia, após descobrir que eles a consideram chata, ela resolve sair de casa sem avisar ninguém, deixando todos preocupados. Dona Hermínia decide visitar a querida tia Zélia para desabafar suas tristezas atuais e recordar os bons tempos do passado.';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_sinopse.Text = titulo;
                        lbl_Sala.Text = "Sala 4";
                        Global.YoNameAtv = true;
                    }
                    else
                    {
                        lbl_sinopse.Text = "Título não encontrado";
                        Global.YoNameAtv = false;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conectar.Close();
                Global.YoNameAtv = false;
            }
        }
        public void Venom()
        {
            try
            {
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT descricao FROM filmes WHERE descricao = 'O jornalista investigativo Eddie Brock é possuído por uma forma alienígena simbionte, ganhando poderes-sobre humanos. Perverso, sombrio e alimentado pela raiva, Venom tenta controlar os novos e perigosos poderes inebriantes de Eddie.';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_sinopse.Text = titulo;
                        lbl_Sala.Text = "Sala 1";
                        Global.YoNameAtv = true;
                    }
                    else
                    {
                        lbl_sinopse.Text = "Título não encontrado";
                        Global.YoNameAtv = false;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conectar.Close();
                Global.YoNameAtv = false;
            }
        }
        public void YourName()
        {
            try
            {
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT descricao FROM filmes WHERE descricao = 'Mitsuha é a filha do prefeito de uma pequena cidade, mas sonha em tentar a sorte em Tóquio. Taki trabalha em um restaurante em Tóquio e deseja largar o seu emprego. Os dois não se conhecem, mas estão conectados pelas imagens de seus sonhos.';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_sinopse.Text = titulo;
                        lbl_Sala.Text = "Sala 3";
                        Global.YoNameAtv = true;
                    }
                    else
                    {
                        lbl_sinopse.Text = "Título não encontrado";
                        Global.YoNameAtv = false;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conectar.Close();
                Global.YoNameAtv = false;
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void customButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Descrição_Load(object sender, EventArgs e)
        {

        }

        private void customButton6_Click_1(object sender, EventArgs e)
        {
            Globals.Assentos = true;
            this.Close();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            Globals.Assentos = true;
            this.Close();
        }

        public static void Mano()
        {
            Globals.Fechar = false;
            Globals.Assentos = false;
        }

        public static class Globals
        {
            public static bool Fechar { get; set; }
            public static bool Assentos { get; set; }
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            Globals.Fechar = true;
            this.Close();
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click_1(object sender, EventArgs e)
        {
            Globals.Assentos = true;
            this.Close();
        }

        private void customButton2_Click_1(object sender, EventArgs e)
        {
            Globals.Assentos = true;
            this.Close();
        }

        private void lbl_sinopse_Click(object sender, EventArgs e)
        {

        }
    }
}
