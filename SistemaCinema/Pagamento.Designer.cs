namespace SistemaCinema {
    partial class Pagamento {
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
            label1 = new Label();
            customButton2 = new CustomButton();
            customButton1 = new CustomButton();
            label4 = new Label();
            txt_ValorPagar = new TextBox();
            label2 = new Label();
            txt_cadeirasescolhidas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 20);
            label1.Name = "label1";
            label1.Size = new Size(257, 100);
            label1.TabIndex = 10;
            label1.Text = "Escolha um método de pagamento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customButton2
            // 
            customButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customButton2.BackColor = Color.Transparent;
            customButton2.BackgroundColor = Color.Transparent;
            customButton2.BorderColor = Color.Lime;
            customButton2.BorderRadius = 20;
            customButton2.BorderSize = 2;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 132, 132);
            customButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Microsoft Sans Serif", 20.25F);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(393, 190);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(158, 73);
            customButton2.TabIndex = 31;
            customButton2.Text = "PIX";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click_1;
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
            customButton1.Font = new Font("Microsoft Sans Serif", 20.25F);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(54, 190);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(158, 73);
            customButton1.TabIndex = 33;
            customButton1.Text = "Cartão";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click_1;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(366, 349);
            label4.Name = "label4";
            label4.Size = new Size(199, 48);
            label4.TabIndex = 34;
            label4.Text = "Valor a ser pago";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_ValorPagar
            // 
            txt_ValorPagar.BackColor = Color.FromArgb(33, 33, 33);
            txt_ValorPagar.BorderStyle = BorderStyle.FixedSingle;
            txt_ValorPagar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ValorPagar.ForeColor = Color.White;
            txt_ValorPagar.Location = new Point(366, 400);
            txt_ValorPagar.Name = "txt_ValorPagar";
            txt_ValorPagar.Size = new Size(199, 29);
            txt_ValorPagar.TabIndex = 35;
            txt_ValorPagar.Text = "0,00";
            txt_ValorPagar.TextAlign = HorizontalAlignment.Center;
            txt_ValorPagar.TextChanged += txt_nome_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 345);
            label2.Name = "label2";
            label2.Size = new Size(199, 57);
            label2.TabIndex = 36;
            label2.Text = "Cadeiras escolhidas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_cadeirasescolhidas
            // 
            txt_cadeirasescolhidas.BackColor = Color.FromArgb(33, 33, 33);
            txt_cadeirasescolhidas.BorderStyle = BorderStyle.FixedSingle;
            txt_cadeirasescolhidas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cadeirasescolhidas.ForeColor = Color.White;
            txt_cadeirasescolhidas.Location = new Point(32, 400);
            txt_cadeirasescolhidas.Name = "txt_cadeirasescolhidas";
            txt_cadeirasescolhidas.Size = new Size(199, 29);
            txt_cadeirasescolhidas.TabIndex = 37;
            txt_cadeirasescolhidas.TextAlign = HorizontalAlignment.Center;
            txt_cadeirasescolhidas.TextChanged += textBox1_TextChanged;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(599, 454);
            Controls.Add(txt_cadeirasescolhidas);
            Controls.Add(label2);
            Controls.Add(txt_ValorPagar);
            Controls.Add(label4);
            Controls.Add(customButton1);
            Controls.Add(customButton2);
            Controls.Add(label1);
            Name = "Pagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagamento";
            Load += Pagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private Label label4;
        private TextBox txt_ValorPagar;
        private Label label2;
        private TextBox txt_cadeirasescolhidas;
    }
}