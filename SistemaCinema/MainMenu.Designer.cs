namespace SistemaCinema {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelSideMenu = new Panel();
            btn_quatro = new Button();
            btn_tres = new Button();
            panel1 = new Panel();
            TsTheme = new ToggleButton();
            lbl_Theme = new Label();
            btn_dois = new Button();
            btn_um = new Button();
            panelLogo = new Panel();
            lbl_Title = new Label();
            pcBox = new PictureBox();
            panelGlobal = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSideMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBox).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(39, 39, 39);
            panelSideMenu.Controls.Add(btn_quatro);
            panelSideMenu.Controls.Add(btn_tres);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Controls.Add(btn_dois);
            panelSideMenu.Controls.Add(btn_um);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(218, 454);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // btn_quatro
            // 
            btn_quatro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_quatro.BackgroundImageLayout = ImageLayout.Zoom;
            btn_quatro.Dock = DockStyle.Bottom;
            btn_quatro.FlatAppearance.BorderSize = 0;
            btn_quatro.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btn_quatro.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_quatro.FlatStyle = FlatStyle.Flat;
            btn_quatro.Font = new Font("JetBrains Mono", 11.9999981F);
            btn_quatro.ForeColor = Color.White;
            btn_quatro.Image = Properties.Resources.Close;
            btn_quatro.ImageAlign = ContentAlignment.MiddleLeft;
            btn_quatro.Location = new Point(0, 344);
            btn_quatro.Name = "btn_quatro";
            btn_quatro.Padding = new Padding(10, 0, 10, 0);
            btn_quatro.Size = new Size(218, 49);
            btn_quatro.TabIndex = 7;
            btn_quatro.Text = "Sair";
            btn_quatro.UseVisualStyleBackColor = true;
            btn_quatro.Click += btn_quatro_Click;
            // 
            // btn_tres
            // 
            btn_tres.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_tres.Dock = DockStyle.Top;
            btn_tres.FlatAppearance.BorderSize = 0;
            btn_tres.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btn_tres.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_tres.FlatStyle = FlatStyle.Flat;
            btn_tres.Font = new Font("JetBrains Mono", 11.9999981F);
            btn_tres.ForeColor = Color.White;
            btn_tres.Image = Properties.Resources.carrinh;
            btn_tres.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tres.Location = new Point(0, 180);
            btn_tres.Name = "btn_tres";
            btn_tres.Padding = new Padding(10, 0, 0, 0);
            btn_tres.Size = new Size(218, 49);
            btn_tres.TabIndex = 6;
            btn_tres.Text = "Carrinho";
            btn_tres.UseVisualStyleBackColor = true;
            btn_tres.Click += btn_tres_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TsTheme);
            panel1.Controls.Add(lbl_Theme);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 61);
            panel1.TabIndex = 5;
            // 
            // TsTheme
            // 
            TsTheme.AutoSize = true;
            TsTheme.Location = new Point(160, 21);
            TsTheme.MinimumSize = new Size(45, 22);
            TsTheme.Name = "TsTheme";
            TsTheme.OffBackColor = Color.Gray;
            TsTheme.OffToggleColor = Color.Gainsboro;
            TsTheme.OnBackColor = Color.FromArgb(255, 13, 54);
            TsTheme.OnToggleColor = Color.WhiteSmoke;
            TsTheme.Size = new Size(45, 22);
            TsTheme.TabIndex = 0;
            TsTheme.UseVisualStyleBackColor = true;
            TsTheme.CheckedChanged += TsTheme_CheckedChanged;
            // 
            // lbl_Theme
            // 
            lbl_Theme.Font = new Font("JetBrains Mono", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Theme.ForeColor = Color.White;
            lbl_Theme.Image = Properties.Resources._11sun;
            lbl_Theme.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_Theme.Location = new Point(14, 11);
            lbl_Theme.Name = "lbl_Theme";
            lbl_Theme.Size = new Size(140, 41);
            lbl_Theme.TabIndex = 0;
            lbl_Theme.Text = "   Modo Claro";
            lbl_Theme.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Theme.Click += lbl_Theme_Click;
            // 
            // btn_dois
            // 
            btn_dois.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_dois.Dock = DockStyle.Top;
            btn_dois.FlatAppearance.BorderSize = 0;
            btn_dois.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btn_dois.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_dois.FlatStyle = FlatStyle.Flat;
            btn_dois.Font = new Font("JetBrains Mono", 11.9999981F);
            btn_dois.ForeColor = Color.White;
            btn_dois.Image = Properties.Resources.claq;
            btn_dois.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dois.Location = new Point(0, 131);
            btn_dois.Name = "btn_dois";
            btn_dois.Padding = new Padding(10, 0, 0, 0);
            btn_dois.Size = new Size(218, 49);
            btn_dois.TabIndex = 3;
            btn_dois.Text = "Sessões";
            btn_dois.UseVisualStyleBackColor = true;
            btn_dois.Click += btn_dois_Click;
            // 
            // btn_um
            // 
            btn_um.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_um.BackgroundImageLayout = ImageLayout.Zoom;
            btn_um.Dock = DockStyle.Top;
            btn_um.FlatAppearance.BorderSize = 0;
            btn_um.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btn_um.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_um.FlatStyle = FlatStyle.Flat;
            btn_um.Font = new Font("JetBrains Mono", 11.9999981F);
            btn_um.ForeColor = Color.White;
            btn_um.Image = Properties.Resources._11inicio_branco;
            btn_um.ImageAlign = ContentAlignment.MiddleLeft;
            btn_um.Location = new Point(0, 82);
            btn_um.Name = "btn_um";
            btn_um.Padding = new Padding(10, 0, 10, 0);
            btn_um.Size = new Size(218, 49);
            btn_um.TabIndex = 1;
            btn_um.Text = "Início";
            btn_um.UseVisualStyleBackColor = true;
            btn_um.Click += btn_um_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lbl_Title);
            panelLogo.Controls.Add(pcBox);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(218, 82);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(78, 13);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(127, 51);
            lbl_Title.TabIndex = 12;
            lbl_Title.Text = "CineBlaze";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcBox
            // 
            pcBox.BackgroundImage = Properties.Resources.balde_de_pipoca1;
            pcBox.BackgroundImageLayout = ImageLayout.Center;
            pcBox.InitialImage = (Image)resources.GetObject("pcBox.InitialImage");
            pcBox.Location = new Point(3, -1);
            pcBox.Name = "pcBox";
            pcBox.Size = new Size(86, 76);
            pcBox.TabIndex = 11;
            pcBox.TabStop = false;
            // 
            // panelGlobal
            // 
            panelGlobal.BackColor = Color.FromArgb(64, 64, 64);
            panelGlobal.Dock = DockStyle.Fill;
            panelGlobal.Location = new Point(218, 0);
            panelGlobal.Name = "panelGlobal";
            panelGlobal.Size = new Size(859, 454);
            panelGlobal.TabIndex = 1;
            panelGlobal.Paint += panelGlobal_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(1077, 454);
            Controls.Add(panelGlobal);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += SideMenu_Load;
            panelSideMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btn_um;
        private Button btn_dois;
        private Panel panelGlobal;
        private Panel panel1;
        private Label lbl_Theme;
        private ToggleButton TsTheme;
        private Button btn_quatro;
        private Button btn_tres;
        private Label lbl_Title;
        private PictureBox pcBox;
        private System.Windows.Forms.Timer timer1;
    }
}