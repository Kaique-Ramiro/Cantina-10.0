namespace CANTINA_10._0
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            PedidosBalcao = new ListBox();
            ComandaBalcao = new ListBox();
            HistoricoBalcao = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PedidosBalcao
            // 
            PedidosBalcao.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PedidosBalcao.FormattingEnabled = true;
            PedidosBalcao.Location = new Point(35, 77);
            PedidosBalcao.Name = "PedidosBalcao";
            PedidosBalcao.Size = new Size(411, 395);
            PedidosBalcao.TabIndex = 0;
            PedidosBalcao.SelectedIndexChanged += PedidosBalcao_SelectedIndexChanged;
            // 
            // ComandaBalcao
            // 
            ComandaBalcao.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComandaBalcao.FormattingEnabled = true;
            ComandaBalcao.Location = new Point(469, 77);
            ComandaBalcao.Name = "ComandaBalcao";
            ComandaBalcao.Size = new Size(373, 142);
            ComandaBalcao.TabIndex = 1;
            // 
            // HistoricoBalcao
            // 
            HistoricoBalcao.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HistoricoBalcao.FormattingEnabled = true;
            HistoricoBalcao.Location = new Point(469, 277);
            HistoricoBalcao.Name = "HistoricoBalcao";
            HistoricoBalcao.Size = new Size(373, 142);
            HistoricoBalcao.TabIndex = 2;
            HistoricoBalcao.SelectedIndexChanged += HistoricoBalcao_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 53);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 3;
            label1.Text = "🛎️ Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(598, 51);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 4;
            label2.Text = "📓 Comanda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 252);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 5;
            label3.Text = "🕐 Histórico";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(469, 433);
            button1.Name = "button1";
            button1.Size = new Size(373, 39);
            button1.TabIndex = 6;
            button1.Text = "Entregar Pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(35, 496);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 7;
            button2.Text = "↩️";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(35, 496);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 8;
            button3.Text = "↩️";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(868, 537);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HistoricoBalcao);
            Controls.Add(ComandaBalcao);
            Controls.Add(PedidosBalcao);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PedidosBalcao;
        private ListBox ComandaBalcao;
        private ListBox HistoricoBalcao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}