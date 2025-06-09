namespace CANTINA_10._0
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Pedidos = new ListBox();
            Preparando = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            btn_Finalizar = new Button();
            pictureBox1 = new PictureBox();
            btn__voltar = new Button();
            Historico = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pedidos
            // 
            Pedidos.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pedidos.FormattingEnabled = true;
            Pedidos.Location = new Point(32, 101);
            Pedidos.Name = "Pedidos";
            Pedidos.Size = new Size(316, 334);
            Pedidos.TabIndex = 0;
            Pedidos.SelectedIndexChanged += Pedidos_SelectedIndexChanged;
            // 
            // Preparando
            // 
            Preparando.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Preparando.FormattingEnabled = true;
            Preparando.Location = new Point(447, 101);
            Preparando.Name = "Preparando";
            Preparando.Size = new Size(355, 180);
            Preparando.TabIndex = 1;
            Preparando.SelectedIndexChanged += Preparando_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 75);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 2;
            label1.Text = "🛎️ Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(552, 75);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 3;
            label2.Text = "🕑 Comanda";
            // 
            // button1
            // 
            button1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(447, 452);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 4;
            button1.Text = "Cancelar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(678, 452);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 5;
            button2.Text = "Preparar Pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_Finalizar
            // 
            btn_Finalizar.BackColor = Color.FromArgb(230, 255, 0);
            btn_Finalizar.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Finalizar.Location = new Point(563, 503);
            btn_Finalizar.Name = "btn_Finalizar";
            btn_Finalizar.Size = new Size(140, 45);
            btn_Finalizar.TabIndex = 6;
            btn_Finalizar.Text = "Finalizar Pedido";
            btn_Finalizar.UseVisualStyleBackColor = false;
            btn_Finalizar.Click += btn_Finalizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn__voltar
            // 
            btn__voltar.BackColor = Color.FromArgb(243, 241, 238);
            btn__voltar.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn__voltar.Location = new Point(32, 531);
            btn__voltar.Name = "btn__voltar";
            btn__voltar.Size = new Size(75, 29);
            btn__voltar.TabIndex = 8;
            btn__voltar.Text = "↩️";
            btn__voltar.UseVisualStyleBackColor = false;
            btn__voltar.Click += btn__voltar_Click;
            // 
            // Historico
            // 
            Historico.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Historico.FormattingEnabled = true;
            Historico.Location = new Point(447, 338);
            Historico.Name = "Historico";
            Historico.Size = new Size(355, 92);
            Historico.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(552, 312);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 10;
            label3.Text = "🕐Histórico";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(857, 576);
            Controls.Add(label3);
            Controls.Add(Historico);
            Controls.Add(btn__voltar);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Finalizar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Preparando);
            Controls.Add(Pedidos);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pedidos;
        private ListBox Preparando;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button btn_Finalizar;
        private PictureBox pictureBox1;
        private Button btn__voltar;
        private ListBox Historico;
        private Label label3;
    }
}