namespace CANTINA_10._0
{
    partial class Form2
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
            Cardapio = new ListBox();
            Carrinho = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cardapio.FormattingEnabled = true;
            Cardapio.Location = new Point(41, 116);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(397, 346);
            Cardapio.TabIndex = 0;
            // 
            // Carrinho
            // 
            Carrinho.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Carrinho.FormattingEnabled = true;
            Carrinho.Location = new Point(489, 77);
            Carrinho.Name = "Carrinho";
            Carrinho.Size = new Size(342, 292);
            Carrinho.TabIndex = 1;
            Carrinho.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 25, 12);
            label1.Location = new Point(41, 90);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 2;
            label1.Text = "PRODUTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 25, 12);
            label2.Location = new Point(521, 52);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 3;
            label2.Text = "CARRINHO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(124, 122, 106);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(230, 255, 0);
            label3.Location = new Point(489, 55);
            label3.Name = "label3";
            label3.Size = new Size(26, 17);
            label3.TabIndex = 4;
            label3.Text = "\U0001f6d2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_14_5_2025_8435_;
            pictureBox1.Location = new Point(41, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(17, 12, 25);
            button1.Location = new Point(608, 395);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 6;
            button1.Text = "ADICIONAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 255, 0);
            button2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(17, 12, 25);
            button2.Location = new Point(599, 446);
            button2.Name = "button2";
            button2.Size = new Size(138, 45);
            button2.TabIndex = 7;
            button2.Text = "REMOVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(17, 12, 25);
            button3.Location = new Point(585, 498);
            button3.Name = "button3";
            button3.Size = new Size(166, 45);
            button3.TabIndex = 8;
            button3.Text = "FiNALIZAR PEDIDO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 482);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 9;
            label4.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(127, 507);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 26);
            textBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(837, 77);
            button4.Name = "button4";
            button4.Size = new Size(44, 35);
            button4.TabIndex = 11;
            button4.Text = "🗑️";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(740, 372);
            label5.Name = "label5";
            label5.Size = new Size(91, 27);
            label5.TabIndex = 12;
            label5.Text = "R$ 0, 00";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(890, 573);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Carrinho);
            Controls.Add(Cardapio);
            Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form2";
            Text = "XX";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Cardapio;
        private ListBox Carrinho;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox textBox1;
        private Button button4;
        private Label label5;
    }
}