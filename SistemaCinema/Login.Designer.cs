namespace SistemaCinema {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_Email = new TextBox();
            lbl_Email = new Label();
            lbl_Senha = new Label();
            txt_Senha = new TextBox();
            lbl_Link = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            customButton1 = new CustomButton();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            eyeGlobal = new ImageList(components);
            cb_Senha = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.FromArgb(33, 33, 33);
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Email.ForeColor = Color.White;
            txt_Email.Location = new Point(20, 189);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(337, 26);
            txt_Email.TabIndex = 2;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("JetBrains Mono", 11.9999981F);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(20, 167);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(179, 20);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "E-mail ou Usuário";
            lbl_Email.Click += lbl_Email_Click;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("JetBrains Mono", 11.9999981F);
            lbl_Senha.ForeColor = Color.White;
            lbl_Senha.Location = new Point(20, 267);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(59, 20);
            lbl_Senha.TabIndex = 4;
            lbl_Senha.Text = "Senha";
            // 
            // txt_Senha
            // 
            txt_Senha.BackColor = Color.FromArgb(33, 33, 33);
            txt_Senha.BorderStyle = BorderStyle.FixedSingle;
            txt_Senha.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Senha.ForeColor = Color.White;
            txt_Senha.Location = new Point(20, 289);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(297, 26);
            txt_Senha.TabIndex = 5;
            txt_Senha.TextChanged += textBox2_TextChanged;
            // 
            // lbl_Link
            // 
            lbl_Link.AutoSize = true;
            lbl_Link.Font = new Font("JetBrains Mono", 8.249999F);
            lbl_Link.LinkColor = Color.FromArgb(128, 128, 255);
            lbl_Link.Location = new Point(191, 318);
            lbl_Link.Name = "lbl_Link";
            lbl_Link.Size = new Size(126, 14);
            lbl_Link.TabIndex = 7;
            lbl_Link.TabStop = true;
            lbl_Link.Text = "Esqueceu a senha?";
            lbl_Link.LinkClicked += lbl_link_LinkClicked;
            // 
            // label1
            // 
            label1.Font = new Font("JetBrains Mono", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 23);
            label1.Name = "label1";
            label1.Size = new Size(246, 72);
            label1.TabIndex = 9;
            label1.Text = "Bem-vindo de volta! \r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.userlmn_e063d76e77c60d6dd5f65e9a17ec1541;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(20, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 72);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customButton1.BackColor = Color.FromArgb(39, 39, 39);
            customButton1.BackgroundColor = Color.FromArgb(39, 39, 39);
            customButton1.BorderColor = Color.FromArgb(61, 61, 61);
            customButton1.BorderRadius = 25;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 132, 132);
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("JetBrains Mono", 11.9999981F);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(20, 374);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(337, 51);
            customButton1.TabIndex = 12;
            customButton1.Text = "Logar";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 8.249999F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 507);
            label2.Name = "label2";
            label2.Size = new Size(105, 14);
            label2.TabIndex = 13;
            label2.Text = "Não tem conta?\r\n";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("JetBrains Mono", 8.249999F);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(195, 507);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 14);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registre agora.\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // eyeGlobal
            // 
            eyeGlobal.ColorDepth = ColorDepth.Depth32Bit;
            eyeGlobal.ImageStream = (ImageListStreamer)resources.GetObject("eyeGlobal.ImageStream");
            eyeGlobal.TransparentColor = Color.Transparent;
            eyeGlobal.Images.SetKeyName(0, "eye.png");
            // 
            // cb_Senha
            // 
            cb_Senha.Appearance = Appearance.Button;
            cb_Senha.BackgroundImage = Properties.Resources.oiobrancofechado;
            cb_Senha.BackgroundImageLayout = ImageLayout.Stretch;
            cb_Senha.Checked = true;
            cb_Senha.CheckState = CheckState.Checked;
            cb_Senha.FlatAppearance.BorderColor = Color.FromArgb(27, 25, 29);
            cb_Senha.FlatAppearance.BorderSize = 0;
            cb_Senha.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 25, 29);
            cb_Senha.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 25, 29);
            cb_Senha.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 25, 29);
            cb_Senha.FlatStyle = FlatStyle.Flat;
            cb_Senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Senha.ForeColor = Color.White;
            cb_Senha.Location = new Point(323, 289);
            cb_Senha.Name = "cb_Senha";
            cb_Senha.Size = new Size(34, 27);
            cb_Senha.TabIndex = 15;
            cb_Senha.UseVisualStyleBackColor = true;
            cb_Senha.CheckedChanged += cb_Senha_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(377, 533);
            Controls.Add(cb_Senha);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(customButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lbl_Link);
            Controls.Add(txt_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Email);
            Font = new Font("JetBrains Mono", 8.249999F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Email;
        private Label lbl_Email;
        private Label lbl_Senha;
        private TextBox txt_Senha;
        private LinkLabel lbl_Link;
        private Label label1;
        private PictureBox pictureBox1;
        private CustomButton customButton1;
        private Label label2;
        private LinkLabel linkLabel1;
        private ImageList eyeGlobal;
        private CheckBox cb_Senha;
    }
}