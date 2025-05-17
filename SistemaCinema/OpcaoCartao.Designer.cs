namespace SistemaCinema
{
    partial class OpcaoCartao
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
            label1 = new Label();
            label2 = new Label();
            txt_emailCartao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            mkt_numcartao = new MaskedTextBox();
            customButton2 = new CustomButton();
            mkt_venc = new MaskedTextBox();
            mkt_codsegunranca = new MaskedTextBox();
            txt_NomeTitular = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(293, 24);
            label1.TabIndex = 0;
            label1.Text = "Método de Pagamento: Cartão";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 76);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome do Titular:";
            // 
            // txt_emailCartao
            // 
            txt_emailCartao.BackColor = Color.FromArgb(27, 25, 29);
            txt_emailCartao.BorderStyle = BorderStyle.FixedSingle;
            txt_emailCartao.Font = new Font("Microsoft Sans Serif", 12F);
            txt_emailCartao.ForeColor = Color.White;
            txt_emailCartao.Location = new Point(36, 141);
            txt_emailCartao.Name = "txt_emailCartao";
            txt_emailCartao.Size = new Size(283, 26);
            txt_emailCartao.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 121);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 167);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 5;
            label4.Text = "Número do Cartão:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 221);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 7;
            label5.Text = "Vencimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(190, 220);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 9;
            label6.Text = "Cod Segurança:";
            // 
            // mkt_numcartao
            // 
            mkt_numcartao.BackColor = Color.FromArgb(27, 25, 29);
            mkt_numcartao.BorderStyle = BorderStyle.FixedSingle;
            mkt_numcartao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkt_numcartao.ForeColor = Color.White;
            mkt_numcartao.Location = new Point(36, 190);
            mkt_numcartao.Mask = "0000 0000 0000 0000";
            mkt_numcartao.Name = "mkt_numcartao";
            mkt_numcartao.Size = new Size(283, 26);
            mkt_numcartao.TabIndex = 11;
            mkt_numcartao.TextAlign = HorizontalAlignment.Center;
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
            customButton2.Location = new Point(36, 289);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(293, 66);
            customButton2.TabIndex = 32;
            customButton2.Text = "Finalizar Compra";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // mkt_venc
            // 
            mkt_venc.BackColor = Color.FromArgb(27, 25, 29);
            mkt_venc.BorderStyle = BorderStyle.FixedSingle;
            mkt_venc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkt_venc.ForeColor = Color.White;
            mkt_venc.Location = new Point(36, 240);
            mkt_venc.Name = "mkt_venc";
            mkt_venc.Size = new Size(134, 26);
            mkt_venc.TabIndex = 33;
            mkt_venc.TextAlign = HorizontalAlignment.Center;
            // 
            // mkt_codsegunranca
            // 
            mkt_codsegunranca.BackColor = Color.FromArgb(27, 25, 29);
            mkt_codsegunranca.BorderStyle = BorderStyle.FixedSingle;
            mkt_codsegunranca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkt_codsegunranca.ForeColor = Color.White;
            mkt_codsegunranca.Location = new Point(185, 240);
            mkt_codsegunranca.Name = "mkt_codsegunranca";
            mkt_codsegunranca.Size = new Size(134, 26);
            mkt_codsegunranca.TabIndex = 34;
            mkt_codsegunranca.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_NomeTitular
            // 
            txt_NomeTitular.BackColor = Color.FromArgb(27, 25, 29);
            txt_NomeTitular.BorderStyle = BorderStyle.FixedSingle;
            txt_NomeTitular.Font = new Font("Microsoft Sans Serif", 12F);
            txt_NomeTitular.ForeColor = Color.White;
            txt_NomeTitular.Location = new Point(36, 95);
            txt_NomeTitular.Name = "txt_NomeTitular";
            txt_NomeTitular.Size = new Size(283, 26);
            txt_NomeTitular.TabIndex = 35;
            // 
            // OpcaoCartao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 29);
            ClientSize = new Size(368, 385);
            Controls.Add(txt_NomeTitular);
            Controls.Add(mkt_codsegunranca);
            Controls.Add(mkt_venc);
            Controls.Add(customButton2);
            Controls.Add(mkt_numcartao);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_emailCartao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            ForeColor = Color.White;
            Name = "OpcaoCartao";
            Text = "OpcaoCartao";
            Load += OpcaoCartao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private TextBox txt_NomeTitutar;
        private TextBox txt_emailCartao;
        private Label label6;
        private MaskedTextBox mkt_numcartao;
        private CustomButton customButton2;
        private MaskedTextBox mkt_venc;
        private MaskedTextBox mkt_codsegunranca;
        private TextBox txt_NomeTitular;
    }
}