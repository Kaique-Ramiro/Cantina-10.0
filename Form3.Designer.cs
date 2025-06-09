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
            Consumo = new RadioButton();
            Viagem = new RadioButton();
            button1 = new Button();
            Dinheiro = new RadioButton();
            Crédito = new RadioButton();
            Débito = new RadioButton();
            Pix = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(17, 25, 12);
            label1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 241, 238);
            label1.Location = new Point(30, 42);
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
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(191, 30);
            label2.TabIndex = 1;
            label2.Text = "Modo de Entrega:";
            // 
            // Consumo
            // 
            Consumo.AutoSize = true;
            Consumo.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Consumo.ForeColor = Color.FromArgb(230, 255, 0);
            Consumo.Location = new Point(7, 165);
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
            Viagem.Location = new Point(7, 96);
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
            button1.Location = new Point(188, 388);
            button1.Name = "button1";
            button1.Size = new Size(214, 48);
            button1.TabIndex = 8;
            button1.Text = "PRONTO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dinheiro
            // 
            Dinheiro.AutoSize = true;
            Dinheiro.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dinheiro.ForeColor = Color.FromArgb(230, 255, 0);
            Dinheiro.Location = new Point(30, 228);
            Dinheiro.Name = "Dinheiro";
            Dinheiro.Size = new Size(109, 31);
            Dinheiro.TabIndex = 5;
            Dinheiro.TabStop = true;
            Dinheiro.Text = "Dinheiro";
            Dinheiro.UseVisualStyleBackColor = true;
            // 
            // Crédito
            // 
            Crédito.AutoSize = true;
            Crédito.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Crédito.ForeColor = Color.FromArgb(230, 255, 0);
            Crédito.Location = new Point(30, 165);
            Crédito.Name = "Crédito";
            Crédito.Size = new Size(195, 31);
            Crédito.TabIndex = 3;
            Crédito.TabStop = true;
            Crédito.Text = "Cartão de Crédito";
            Crédito.UseVisualStyleBackColor = true;
            Crédito.CheckedChanged += Crédito_CheckedChanged;
            // 
            // Débito
            // 
            Débito.AutoSize = true;
            Débito.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Débito.ForeColor = Color.FromArgb(230, 255, 0);
            Débito.Location = new Point(30, 96);
            Débito.Name = "Débito";
            Débito.Size = new Size(187, 31);
            Débito.TabIndex = 2;
            Débito.TabStop = true;
            Débito.Text = "Cartão de Dédito";
            Débito.UseVisualStyleBackColor = true;
            // 
            // Pix
            // 
            Pix.AutoSize = true;
            Pix.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pix.ForeColor = Color.FromArgb(230, 255, 0);
            Pix.Location = new Point(30, 286);
            Pix.Name = "Pix";
            Pix.Size = new Size(58, 31);
            Pix.TabIndex = 4;
            Pix.TabStop = true;
            Pix.Text = "Pix";
            Pix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Pix);
            groupBox1.Controls.Add(Débito);
            groupBox1.Controls.Add(Crédito);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Dinheiro);
            groupBox1.Location = new Point(0, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 465);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(Viagem);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Consumo);
            groupBox2.Location = new Point(386, -9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 465);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton Consumo;
        private RadioButton Viagem;
        private Button button1;
        private RadioButton Dinheiro;
        private RadioButton Crédito;
        private RadioButton Débito;
        private RadioButton Pix;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}