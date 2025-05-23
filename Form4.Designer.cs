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
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pedidos
            // 
            Pedidos.FormattingEnabled = true;
            Pedidos.Location = new Point(32, 114);
            Pedidos.Name = "Pedidos";
            Pedidos.Size = new Size(298, 304);
            Pedidos.TabIndex = 0;
            // 
            // Preparando
            // 
            Preparando.FormattingEnabled = true;
            Preparando.Location = new Point(451, 114);
            Preparando.Name = "Preparando";
            Preparando.Size = new Size(370, 304);
            Preparando.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 89);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 2;
            label1.Text = "🛎️ Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(575, 88);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 3;
            label2.Text = "🕑 Preparando";
            // 
            // button1
            // 
            button1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(478, 439);
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
            button2.Location = new Point(668, 439);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 5;
            button2.Text = "Preparar Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(575, 503);
            button3.Name = "button3";
            button3.Size = new Size(140, 45);
            button3.TabIndex = 6;
            button3.Text = "Finalizar Pedido";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(243, 241, 238);
            button4.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(32, 531);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 8;
            button4.Text = "↩️";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(872, 572);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
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
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
    }
}