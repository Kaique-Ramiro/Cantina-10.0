namespace CANTINA_10._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox_Usuario = new TextBox();
            textBox_Senha = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(230, 255, 0);
            pictureBox2.Location = new Point(-3, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(795, 115);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 241, 238);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(17, 25, 12);
            button1.Location = new Point(220, 283);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 3;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 241, 238);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(17, 25, 12);
            button2.Location = new Point(448, 283);
            button2.Name = "button2";
            button2.Size = new Size(141, 49);
            button2.TabIndex = 4;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox_Usuario
            // 
            textBox_Usuario.BackColor = Color.FromArgb(243, 241, 238);
            textBox_Usuario.ForeColor = Color.FromArgb(124, 122, 106);
            textBox_Usuario.Location = new Point(220, 199);
            textBox_Usuario.Name = "textBox_Usuario";
            textBox_Usuario.Size = new Size(369, 23);
            textBox_Usuario.TabIndex = 5;
            textBox_Usuario.Text = "Digite seu usuário:";
            textBox_Usuario.TextChanged += textBox_Usuario_TextChanged;
            // 
            // textBox_Senha
            // 
            textBox_Senha.BackColor = Color.FromArgb(243, 241, 238);
            textBox_Senha.ForeColor = Color.FromArgb(124, 122, 106);
            textBox_Senha.Location = new Point(220, 240);
            textBox_Senha.Name = "textBox_Senha";
            textBox_Senha.Size = new Size(369, 23);
            textBox_Senha.TabIndex = 6;
            textBox_Senha.Text = "Digite sua senha:";
            textBox_Senha.TextChanged += textBox_Senha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 25, 12);
            label2.Location = new Point(375, 170);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_13_5_2025_104955_;
            pictureBox1.Location = new Point(220, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 401);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox_Senha);
            Controls.Add(textBox_Usuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox_Usuario;
        private TextBox textBox_Senha;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
