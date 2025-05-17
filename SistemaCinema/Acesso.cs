using System.Drawing.Drawing2D;
using System.Drawing;
using SistemaCinema.Login_Cadastro;

namespace SistemaCinema {
    public partial class Acesso : Form {
        public Acesso() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void Login_Click(object sender, EventArgs e) {
            this.Hide();
            Login logi = new Login();
            logi.ShowDialog();
            this.Show();
        }

        private void customButton2_Click(object sender, EventArgs e) {
            this.Hide();
            Cadastro cad = new Cadastro();
            cad.ShowDialog();
            this.Show();
        }

        private void Acesso_Load(object sender, EventArgs e) {

        }
    }
}
