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
            User = new TextBox();
            Senha = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
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
            button1.Location = new Point(220, 316);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 3;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 241, 238);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(17, 25, 12);
            button2.Location = new Point(448, 316);
            button2.Name = "button2";
            button2.Size = new Size(141, 49);
            button2.TabIndex = 4;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.BackColor = Color.FromArgb(243, 241, 238);
            User.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.ForeColor = Color.FromArgb(124, 122, 106);
            User.Location = new Point(220, 201);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(369, 41);
            User.TabIndex = 5;
            User.Text = "Digite seu usuário:";
            User.TextChanged += textBox_Usuario_TextChanged;
            // 
            // Senha
            // 
            Senha.BackColor = Color.FromArgb(243, 241, 238);
            Senha.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.ForeColor = Color.FromArgb(124, 122, 106);
            Senha.Location = new Point(220, 252);
            Senha.Multiline = true;
            Senha.Name = "Senha";
            Senha.Size = new Size(369, 41);
            Senha.TabIndex = 6;
            Senha.Text = "Digite sua senha:";
            Senha.TextChanged += textBox_Senha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 241, 238);
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
            // button3
            // 
            button3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(602, 256);
            button3.Name = "button3";
            button3.Size = new Size(39, 34);
            button3.TabIndex = 9;
            button3.Text = "👁️‍🗨️";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(787, 401);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Senha);
            Controls.Add(User);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox User;
        private TextBox Senha;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}
