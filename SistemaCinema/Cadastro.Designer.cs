namespace SistemaCinema.Login_Cadastro {
    partial class Cadastro {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            txt_Senha = new TextBox();
            lbl_Senha = new Label();
            lbl_Email = new Label();
            txt_Email = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_Senha2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_nome = new TextBox();
            label4 = new Label();
            cb_Senha = new CheckBox();
            cb_Senha2 = new CheckBox();
            mkt_cpf = new MaskedTextBox();
            customButton2 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_Senha
            // 
            txt_Senha.BackColor = Color.FromArgb(33, 33, 33);
            txt_Senha.BorderStyle = BorderStyle.FixedSingle;
            txt_Senha.Font = new Font("JetBrains Mono", 11.9999981F);
            txt_Senha.ForeColor = Color.White;
            txt_Senha.Location = new Point(20, 357);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(290, 27);
            txt_Senha.TabIndex = 15;
            txt_Senha.TextChanged += txt_Senha_TextChanged;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("JetBrains Mono", 11.9999981F);
            lbl_Senha.ForeColor = Color.White;
            lbl_Senha.Location = new Point(20, 333);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(59, 20);
            lbl_Senha.TabIndex = 14;
            lbl_Senha.Text = "Senha";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("JetBrains Mono", 11.9999981F);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(20, 117);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(179, 20);
            lbl_Email.TabIndex = 13;
            lbl_Email.Text = "E-mail ou Usuário";
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.FromArgb(33, 33, 33);
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("JetBrains Mono", 11.9999981F);
            txt_Email.ForeColor = Color.White;
            txt_Email.Location = new Point(20, 141);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(337, 27);
            txt_Email.TabIndex = 12;
            txt_Email.TextChanged += txt_Email_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.userlmn_e063d76e77c60d6dd5f65e9a17ec1541;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(20, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 77);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("JetBrains Mono", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 19);
            label1.Name = "label1";
            label1.Size = new Size(237, 77);
            label1.TabIndex = 18;
            label1.Text = "Bem-vindo!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Senha2
            // 
            txt_Senha2.BackColor = Color.FromArgb(33, 33, 33);
            txt_Senha2.BorderStyle = BorderStyle.FixedSingle;
            txt_Senha2.Font = new Font("JetBrains Mono", 11.9999981F);
            txt_Senha2.ForeColor = Color.White;
            txt_Senha2.Location = new Point(20, 429);
            txt_Senha2.Name = "txt_Senha2";
            txt_Senha2.Size = new Size(290, 27);
            txt_Senha2.TabIndex = 21;
            txt_Senha2.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 405);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 20;
            label2.Text = "Confirme a Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 189);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 22;
            label3.Text = "Nome Completo";
            // 
            // txt_nome
            // 
            txt_nome.BackColor = Color.FromArgb(33, 33, 33);
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Font = new Font("JetBrains Mono", 11.9999981F);
            txt_nome.ForeColor = Color.White;
            txt_nome.Location = new Point(20, 213);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(337, 27);
            txt_nome.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 261);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 24;
            label4.Text = "CPF";
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
            cb_Senha.Location = new Point(322, 357);
            cb_Senha.Name = "cb_Senha";
            cb_Senha.Size = new Size(34, 30);
            cb_Senha.TabIndex = 26;
            cb_Senha.UseVisualStyleBackColor = true;
            cb_Senha.CheckedChanged += cb_Senha_CheckedChanged;
            // 
            // cb_Senha2
            // 
            cb_Senha2.Appearance = Appearance.Button;
            cb_Senha2.BackgroundImage = Properties.Resources.oiobrancofechado;
            cb_Senha2.BackgroundImageLayout = ImageLayout.Stretch;
            cb_Senha2.Checked = true;
            cb_Senha2.CheckState = CheckState.Checked;
            cb_Senha2.FlatAppearance.BorderColor = Color.FromArgb(27, 25, 29);
            cb_Senha2.FlatAppearance.BorderSize = 0;
            cb_Senha2.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 25, 29);
            cb_Senha2.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 25, 29);
            cb_Senha2.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 25, 29);
            cb_Senha2.FlatStyle = FlatStyle.Flat;
            cb_Senha2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Senha2.ForeColor = Color.White;
            cb_Senha2.Location = new Point(322, 429);
            cb_Senha2.Name = "cb_Senha2";
            cb_Senha2.Size = new Size(34, 30);
            cb_Senha2.TabIndex = 27;
            cb_Senha2.UseVisualStyleBackColor = true;
            cb_Senha2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // mkt_cpf
            // 
            mkt_cpf.BackColor = Color.FromArgb(33, 33, 33);
            mkt_cpf.BorderStyle = BorderStyle.FixedSingle;
            mkt_cpf.Font = new Font("JetBrains Mono", 11.9999981F);
            mkt_cpf.ForeColor = Color.White;
            mkt_cpf.Location = new Point(20, 285);
            mkt_cpf.Mask = "000\\.000\\.000\\-00";
            mkt_cpf.Name = "mkt_cpf";
            mkt_cpf.Size = new Size(157, 27);
            mkt_cpf.TabIndex = 28;
            mkt_cpf.MaskInputRejected += mkt_cpf_MaskInputRejected;
            // 
            // customButton2
            // 
            customButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customButton2.BackColor = Color.FromArgb(27, 25, 29);
            customButton2.BackgroundColor = Color.FromArgb(27, 25, 29);
            customButton2.BorderColor = Color.FromArgb(61, 61, 61);
            customButton2.BorderRadius = 25;
            customButton2.BorderSize = 2;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 132, 132);
            customButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("JetBrains Mono", 11.9999981F);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(20, 495);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(337, 55);
            customButton2.TabIndex = 29;
            customButton2.Text = "Cadastrar";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(377, 571);
            Controls.Add(customButton2);
            Controls.Add(mkt_cpf);
            Controls.Add(cb_Senha2);
            Controls.Add(cb_Senha);
            Controls.Add(label4);
            Controls.Add(txt_nome);
            Controls.Add(label3);
            Controls.Add(txt_Senha2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txt_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Email);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Senha;
        private Label lbl_Senha;
        private Label lbl_Email;
        private TextBox txt_Email;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_Senha2;
        private Label label2;
        private Label label3;
        private TextBox txt_nome;
        private Label label4;
        private CheckBox cb_Senha;
        private CheckBox cb_Senha2;
        private MaskedTextBox mkt_cpf;
        private CustomButton customButton2;
    }
}