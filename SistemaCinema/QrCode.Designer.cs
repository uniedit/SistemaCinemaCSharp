namespace SistemaCinema
{
    partial class QrCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            pictureBox1 = new PictureBox();
            customButton1 = new CustomButton();
            label1 = new Label();
            label2 = new Label();
            lbl_Cod = new Label();
            customButton2 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.e_o_pix_nada_ainda;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(103, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 165);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customButton1.BackColor = Color.Transparent;
            customButton1.BackgroundColor = Color.Transparent;
            customButton1.BorderColor = Color.Cyan;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 2;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 132, 132);
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(210, 274);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(174, 40);
            customButton1.TabIndex = 34;
            customButton1.Text = "Finalizar";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 18);
            label1.Name = "label1";
            label1.Size = new Size(393, 34);
            label1.TabIndex = 35;
            label1.Text = "Método de Pagamento: Pix / QrCode\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 228);
            label2.Name = "label2";
            label2.Size = new Size(393, 43);
            label2.TabIndex = 36;
            label2.Text = "Método de Pagamento: Pix/ Código";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Cod
            // 
            lbl_Cod.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Cod.ForeColor = Color.White;
            lbl_Cod.Location = new Point(53, 328);
            lbl_Cod.Name = "lbl_Cod";
            lbl_Cod.Size = new Size(309, 120);
            lbl_Cod.TabIndex = 37;
            lbl_Cod.Text = "MARCÃO POR FAVOR ME MANDA UM PIX DE 10 REAIS PARA COMPRAR UMA COXINHA E UMA COCA  DE 200ML, TO PROGRAMANDO A 364 DIAS. ESTOU TRABALHANDO NA ESCALA 364X1\r\n\r\n";
            lbl_Cod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customButton2
            // 
            customButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customButton2.BackColor = Color.Transparent;
            customButton2.BackgroundColor = Color.Transparent;
            customButton2.BorderColor = Color.Cyan;
            customButton2.BorderRadius = 20;
            customButton2.BorderSize = 2;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 132, 132);
            customButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(12, 274);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(174, 40);
            customButton2.TabIndex = 38;
            customButton2.Text = "Copiar Código";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // QrCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(396, 467);
            Controls.Add(customButton2);
            Controls.Add(lbl_Cod);
            Controls.Add(label2);
            Controls.Add(customButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Location = new Point(393, 190);
            Name = "QrCode";
            Text = "QrCode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private CustomButton customButton1;
        private Label label1;
        private Label label2;
        private Label lbl_Cod;
        private CustomButton customButton2;
    }
}