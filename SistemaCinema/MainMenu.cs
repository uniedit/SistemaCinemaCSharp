using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaCinema.Assentos;
using static SistemaCinema.Descrição;
using static SistemaCinema.Sessões;
using static System.Windows.Forms.DataFormats;

namespace SistemaCinema {
    public partial class MainMenu : Form
    {
        private Form activeForm;

        public MainMenu()
        {
            InitializeComponent();
            //customizeMenu();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {

        }

        private void timerMenuBack_Tick(object sender, EventArgs e)
        {

        }

        /* private void customizeMenu() {
            panelSubMenuUm.Visible = false;
            panelSubMenuDois.Visible = false;
        }

        private void hideSubMenu() {
            if (panelSubMenuDois.Visible == true) {
                panelSubMenuDois.Visible = false;
                btn_um.Image = Properties.Resources.seta_para_baixo_2__1_;
            }

            if (panelSubMenuUm.Visible == true) {
                panelSubMenuUm.Visible = false;
                btn_um.Image = Properties.Resources.seta_para_baixo_2__1_;
            }
        } 

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
                btn_um.Image = Properties.Resources.seta_para_cima_2__1_;
            } else {
                subMenu.Visible = false;
                btn_um.Image = Properties.Resources.seta_para_baixo_2__1_;
            }

        } */

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelGlobal.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelGlobal.Controls.OfType<MiForm>().FirstOrDefault();


            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelGlobal.Controls.Add(formulario);
                panelGlobal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MainMenu>();
            panelGlobal.Controls.Clear();
            this.Size = new Size(233, 493);
            //showSubMenu(panelSubMenuUm);
        }

        private void panelSubMenuUm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1093, 493);
            //showSubMenu(panelSubMenuDois);
            panelGlobal.Controls.Clear();
            AbrirFormulario<Sessões>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Login>();
            //hideSubMenu();
        }

        private void SideMenu_Load(object sender, EventArgs e)
        {

        }

        private void panelGlobal_Paint(object sender, PaintEventArgs e)
        {
            if (GlobalSessões.Atv == true)
            {
                AbrirFormulario<Descrição>();
                GlobalSessões.Atv = false;
            }
            if (Globals.Fechar == true)
            {
                AbrirFormulario<Sessões>();
                //panelGlobal.Controls.Clear();
                Globals.Fechar = false;
            }
            if (Globals.Assentos == true)
            {
                AbrirFormulario<Assentos>();
                Globals.Assentos = false;
            }
            if (GlobalAssent.Fechar == true)
            {
                AbrirFormulario<Sessões>();
                //panelGlobal.Controls.Clear();
                GlobalAssent.Fechar = false;
            }
            if (GlobalAssent.Assent == true)
            {
                AbrirFormulario<Pagamento>();
                GlobalAssent.Assent = false;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Acesso>();
            //hideSubMenu();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TsTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (TsTheme.CheckState == CheckState.Checked)
            {
                btn_um.ForeColor = Color.Black;
                btn_um.Image = Properties.Resources._11botao_de_inicio;
                btn_dois.ForeColor = Color.Black;
                btn_dois.Image = Properties.Resources.claquete;
                btn_tres.ForeColor = Color.Black;
                btn_tres.Image = Properties.Resources.vista_lateral_vazia_do_carrinho_de_compras;
                btn_quatro.ForeColor = Color.Black;
                btn_quatro.Image = Properties.Resources._11Close;
                panelSideMenu.BackColor = Color.WhiteSmoke;
                lbl_Theme.ForeColor = Color.Black;
                lbl_Theme.Image = Properties.Resources._22moon;
                lbl_Theme.Text = "   Modo Escuro";
                lbl_Title.ForeColor = Color.Black;

            }
            else
            {
                btn_um.ForeColor = Color.White;
                btn_um.Image = Properties.Resources._11inicio_branco;
                btn_dois.ForeColor = Color.White;
                btn_dois.Image = Properties.Resources.claq;
                btn_tres.ForeColor = Color.White;
                btn_tres.Image = Properties.Resources.carrinh;
                btn_quatro.ForeColor = Color.White;
                btn_quatro.Image = Properties.Resources.Close;
                panelSideMenu.BackColor = Color.FromArgb(39, 39, 39);
                lbl_Theme.ForeColor = Color.White;
                lbl_Theme.Image = Properties.Resources._11sun;
                lbl_Theme.Text = "   Modo Claro";
                lbl_Title.ForeColor = Color.White;
            }
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Quer Encerrar o Programa?", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            this.Size = new Size(833, 493);
            panelGlobal.Controls.Clear();
            AbrirFormulario<Pagamento>();
        }

        private void lbl_Theme_Click(object sender, EventArgs e)
        {

        }
        bool controle = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (controle == true)
            {
                this.Size = new Size(233, 493);
                controle = false;
            }
            }
        }
    }
