namespace SistemaCinema {
    partial class Acesso {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso));
            pictureBox1 = new PictureBox();
            Login = new CustomButton();
            customButton2 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.invertido2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(83, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 140);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Login.BackColor = Color.FromArgb(39, 39, 39);
            Login.BackgroundColor = Color.FromArgb(39, 39, 39);
            Login.BorderColor = Color.FromArgb(61, 61, 61);
            Login.BorderRadius = 25;
            Login.BorderSize = 0;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 132, 132);
            Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(31, 227);
            Login.Name = "Login";
            Login.Size = new Size(243, 56);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.TextColor = Color.White;
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
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
            customButton2.Location = new Point(31, 307);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(243, 56);
            customButton2.TabIndex = 2;
            customButton2.Text = "Cadastro";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // Acesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(304, 462);
            Controls.Add(customButton2);
            Controls.Add(Login);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Acesso";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso";
            Load += Acesso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private CustomButton Login;
        private CustomButton customButton2;
    }
}
