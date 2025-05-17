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
using NpgsqlTypes;

namespace SistemaCinema {
    public partial class Sessões : Form
    {
        public Sessões()
        {
            InitializeComponent();
            // Filme 1
            Venom();
            // Filme 2
            RoboSelvagem();
            // Filme 3
            YourName();
            // Filme 4
            MinhaMae();
        }
        public static void Mano()
        {
            Global.VenonAtv = false;
            Global.RoboAtv = false;
            Global.YoNameAtv = false;
            Global.MommyAtv = false;
        }

        public static class Global
        {
            public static bool VenonAtv { get; set; }
            public static bool RoboAtv { get; set; }
            public static bool YoNameAtv { get; set; }
            public static bool MommyAtv { get; set; }
        }

        public void Venom()
        {
            try
            {
                // Titulo
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT titulo FROM filmes WHERE titulo = 'Venom';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_filme1.Text = "Titulo: " + titulo;
                        Global.VenonAtv = true;
                    }
                    else
                    {
                        lbl_filme1.Text = "Título não encontrado";
                        Global.VenonAtv = false;
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT genero FROM filmes WHERE genero = 'Ação/Ficção científica';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var genero = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (genero != null)
                    {
                        lbl_Genero1.Text = "Gênero: " + genero;
                    }
                    else
                    {
                        lbl_Genero1.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT classificacao FROM filmes WHERE classificacao = '14+';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var classificacao = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (classificacao != null)
                    {
                        lbl_classi1.Text = "Classificação: " + classificacao;
                    }
                    else
                    {
                        lbl_classi1.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT duracao FROM filmes WHERE duracao = 112;";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var duracao = ComandoSQL.ExecuteScalar() as int?;
                    // Exibe o valor no label
                    if (duracao.HasValue)
                    {
                        lbl_Dur1.Text = "Duração: " + duracao + "min";
                    }
                    else
                    {
                        lbl_Dur1.Text = "Título não encontrado";
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
                Global.VenonAtv = false;
            }
        }

        public void RoboSelvagem()
        {
            try
            {
                // Titulo
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT titulo FROM filmes WHERE titulo = 'Robô Selvagem';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_filme2.Text = "Titulo: " + titulo;
                        Global.RoboAtv = true;
                    }
                    else
                    {
                        lbl_filme2.Text = "Título não encontrado";
                        Global.RoboAtv = false;
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT genero FROM filmes WHERE genero = 'Animação/Aventura';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var genero = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (genero != null)
                    {
                        lbl_Genero2.Text = "Gênero: " + genero;
                    }
                    else
                    {
                        lbl_Genero2.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT classificacao FROM filmes WHERE classificacao = '10+';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var classificacao = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (classificacao != null)
                    {
                        lbl_classi2.Text = "Classificação: " + classificacao;
                    }
                    else
                    {
                        lbl_classi2.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT duracao FROM filmes WHERE duracao = 98;";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var duracao = ComandoSQL.ExecuteScalar() as int?;
                    // Exibe o valor no label
                    if (duracao.HasValue)
                    {
                        lbl_Dur2.Text = "Duração: " + duracao + "min";
                    }
                    else
                    {
                        lbl_Dur2.Text = "Título não encontrado";
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
                Global.RoboAtv = false;
            }
        }

        public void YourName()
        {
            try
            {
                // Titulo
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT titulo FROM filmes WHERE titulo = 'Your Name';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_filme3.Text = "Titulo: " + titulo;
                        Global.YoNameAtv = true;
                    }
                    else
                    {
                        lbl_filme3.Text = "Título não encontrado";
                        Global.YoNameAtv = false;
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT genero FROM filmes WHERE genero = 'Animação/Fantasia';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var genero = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (genero != null)
                    {
                        lbl_Genero3.Text = "Gênero: " + genero;
                    }
                    else
                    {
                        lbl_Genero3.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT classificacao FROM filmes WHERE classificacao = '12+';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var classificacao = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (classificacao != null)
                    {
                        lbl_classi3.Text = "Classificação: " + classificacao;
                    }
                    else
                    {
                        lbl_classi3.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT duracao FROM filmes WHERE duracao = 106;";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var duracao = ComandoSQL.ExecuteScalar() as int?;
                    // Exibe o valor no label
                    if (duracao.HasValue)
                    {
                        lbl_Dur3.Text = "Duração: " + duracao + "min";
                    }
                    else
                    {
                        lbl_Dur3.Text = "Título não encontrado";
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

        public void MinhaMae()
        {
            try
            {
                // Titulo
                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT titulo FROM filmes WHERE titulo = 'Minha mãe é uma peça';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var titulo = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (titulo != null)
                    {
                        lbl_filme4.Text = "Titulo: " + titulo;
                        Global.MommyAtv = true;
                    }
                    else
                    {
                        lbl_filme4.Text = "Título não encontrado";
                        Global.MommyAtv = false;
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT genero FROM filmes WHERE genero = 'Comédia';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var genero = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (genero != null)
                    {
                        lbl_Genero4.Text = "Gênero: " + genero;
                    }
                    else
                    {
                        lbl_Genero4.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT classificacao FROM filmes WHERE classificacao = '12+';";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var genero = ComandoSQL.ExecuteScalar() as string;
                    // Exibe o valor no label
                    if (genero != null)
                    {
                        lbl_classi4.Text = "Classificação: " + genero;
                    }
                    else
                    {
                        lbl_classi4.Text = "Título não encontrado";
                    }
                }

                conectar = new NpgsqlConnection(strCon);
                conectar.Open();
                strSQL = "SELECT duracao FROM filmes WHERE duracao = 85;";

                using (ComandoSQL = new NpgsqlCommand(strSQL, conectar))
                {
                    // Executa a consulta e obtém o valor da coluna 'titulo'
                    var duracao = ComandoSQL.ExecuteScalar() as int?;
                    // Exibe o valor no label
                    if (duracao.HasValue)
                    {
                        lbl_Dur4.Text = "Duração: " + duracao + "min";
                    }
                    else
                    {
                        lbl_Dur4.Text = "Título não encontrado";
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
                Global.MommyAtv = false;
            }
        }

        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerCadastro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=ByteBlaze";
        public string strSQL = "";



        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void lbl_Genero2_Click(object sender, EventArgs e)
        {

        }

        private void Sessões_Load(object sender, EventArgs e)
        {

        }

        public static void What()
        {
            GlobalSessões.Atv = false;
            GlobalSessões.Fechar = false;
        }

        public static class GlobalSessões
        {
            public static bool Atv { get; set; }
            public static bool Fechar { get; set; }
        }


        private void customButton2_Click_1(object sender, EventArgs e)
        {
            GlobalSessões.Atv = true;
            GlobalSessões.Fechar = true;
            this.Close();
            Global.VenonAtv = true;
        }

        private void customButton5_Click_1(object sender, EventArgs e)
        {
            GlobalSessões.Atv = true;
            GlobalSessões.Fechar = true;
            this.Close();
            Global.YoNameAtv = true;
        }

        private void customButton3_Click_1(object sender, EventArgs e)
        {
            GlobalSessões.Atv = true;
            GlobalSessões.Fechar = true;
            this.Close();
            Global.RoboAtv = true;
        }

        private void customButton7_Click_1(object sender, EventArgs e)
        {
            GlobalSessões.Atv = true;
            GlobalSessões.Fechar = true;
            this.Close();
            Global.MommyAtv = true;
        }

        private void lbl_filme2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_classi1_Click(object sender, EventArgs e)
        {

        }
    }
}