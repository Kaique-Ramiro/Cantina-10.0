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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox_Usuario = new TextBox();
            textBox_Senha = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 255, 0);
            label1.Font = new Font("Swis721 Blk BT", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 44);
            label1.Name = "label1";
            label1.Size = new Size(369, 115);
            label1.TabIndex = 0;
            label1.Text = "SENAI";
            label1.Click += label1_Click;
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
            button1.Location = new Point(220, 283);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(448, 283);
            button2.Name = "button2";
            button2.Size = new Size(141, 49);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox_Usuario
            // 
            textBox_Usuario.ForeColor = SystemColors.InactiveCaption;
            textBox_Usuario.Location = new Point(220, 199);
            textBox_Usuario.Name = "textBox_Usuario";
            textBox_Usuario.Size = new Size(369, 23);
            textBox_Usuario.TabIndex = 5;
            textBox_Usuario.Text = "Digite seu usuário:";
            textBox_Usuario.TextChanged += textBox_Usuario_TextChanged;
            // 
            // textBox_Senha
            // 
            textBox_Senha.ForeColor = SystemColors.InactiveCaption;
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
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(375, 170);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 401);
            Controls.Add(label2);
            Controls.Add(textBox_Senha);
            Controls.Add(textBox_Usuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox_Usuario;
        private TextBox textBox_Senha;
        private Label label2;
    }
}
