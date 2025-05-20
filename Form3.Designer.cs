namespace CANTINA_10._0
{
    partial class Form3
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
            Débito = new RadioButton();
            Crédito = new RadioButton();
            Pix = new RadioButton();
            Dinheiro = new RadioButton();
            Consumo = new RadioButton();
            Viagem = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(17, 25, 12);
            label1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 241, 238);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 0;
            label1.Text = "Método de Pagamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(17, 25, 12);
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(243, 241, 238);
            label2.Location = new Point(455, 33);
            label2.Name = "label2";
            label2.Size = new Size(191, 30);
            label2.TabIndex = 1;
            label2.Text = "Modo de Entrega:";
            // 
            // Débito
            // 
            Débito.AutoSize = true;
            Débito.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Débito.ForeColor = Color.FromArgb(230, 255, 0);
            Débito.Location = new Point(30, 105);
            Débito.Name = "Débito";
            Débito.Size = new Size(187, 31);
            Débito.TabIndex = 2;
            Débito.TabStop = true;
            Débito.Text = "Cartão de Dédito";
            Débito.UseVisualStyleBackColor = true;
            // 
            // Crédito
            // 
            Crédito.AutoSize = true;
            Crédito.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Crédito.ForeColor = Color.FromArgb(230, 255, 0);
            Crédito.Location = new Point(30, 156);
            Crédito.Name = "Crédito";
            Crédito.Size = new Size(195, 31);
            Crédito.TabIndex = 3;
            Crédito.TabStop = true;
            Crédito.Text = "Cartão de Crédito";
            Crédito.UseVisualStyleBackColor = true;
            // 
            // Pix
            // 
            Pix.AutoSize = true;
            Pix.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pix.ForeColor = Color.FromArgb(230, 255, 0);
            Pix.Location = new Point(30, 211);
            Pix.Name = "Pix";
            Pix.Size = new Size(58, 31);
            Pix.TabIndex = 4;
            Pix.TabStop = true;
            Pix.Text = "Pix";
            Pix.UseVisualStyleBackColor = true;
            // 
            // Dinheiro
            // 
            Dinheiro.AutoSize = true;
            Dinheiro.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dinheiro.ForeColor = Color.FromArgb(230, 255, 0);
            Dinheiro.Location = new Point(30, 268);
            Dinheiro.Name = "Dinheiro";
            Dinheiro.Size = new Size(109, 31);
            Dinheiro.TabIndex = 5;
            Dinheiro.TabStop = true;
            Dinheiro.Text = "Dinheiro";
            Dinheiro.UseVisualStyleBackColor = true;
            // 
            // Consumo
            // 
            Consumo.AutoSize = true;
            Consumo.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Consumo.ForeColor = Color.FromArgb(230, 255, 0);
            Consumo.Location = new Point(455, 105);
            Consumo.Name = "Consumo";
            Consumo.Size = new Size(258, 31);
            Consumo.TabIndex = 6;
            Consumo.TabStop = true;
            Consumo.Text = "Consumo dentro da Loja";
            Consumo.UseVisualStyleBackColor = true;
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Viagem.ForeColor = Color.FromArgb(230, 255, 0);
            Viagem.Location = new Point(455, 156);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(136, 31);
            Viagem.TabIndex = 7;
            Viagem.TabStop = true;
            Viagem.Text = "Pra Viagem";
            Viagem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 25, 12);
            button1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(308, 368);
            button1.Name = "button1";
            button1.Size = new Size(214, 48);
            button1.TabIndex = 8;
            button1.Text = "PRONTO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Viagem);
            Controls.Add(Consumo);
            Controls.Add(Dinheiro);
            Controls.Add(Pix);
            Controls.Add(Crédito);
            Controls.Add(Débito);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton Débito;
        private RadioButton Crédito;
        private RadioButton Pix;
        private RadioButton Dinheiro;
        private RadioButton Consumo;
        private RadioButton Viagem;
        private Button button1;
    }
}