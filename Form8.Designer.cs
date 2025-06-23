namespace CANTINA_10._0
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            listEstoque = new ListBox();
            AddItem = new Button();
            Remove = new Button();
            Quant = new Button();
            EditItem = new Button();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listEstoque
            // 
            listEstoque.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listEstoque.FormattingEnabled = true;
            listEstoque.Location = new Point(36, 79);
            listEstoque.Name = "listEstoque";
            listEstoque.Size = new Size(459, 378);
            listEstoque.TabIndex = 0;
            // 
            // AddItem
            // 
            AddItem.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItem.Location = new Point(552, 280);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(226, 77);
            AddItem.TabIndex = 1;
            AddItem.Text = "Adicionar Item";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // Remove
            // 
            Remove.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove.Location = new Point(552, 381);
            Remove.Name = "Remove";
            Remove.Size = new Size(226, 76);
            Remove.TabIndex = 2;
            Remove.Text = "Remover Item";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Quant
            // 
            Quant.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quant.Location = new Point(552, 79);
            Quant.Name = "Quant";
            Quant.Size = new Size(226, 76);
            Quant.TabIndex = 3;
            Quant.Text = "Alterar Quantidade";
            Quant.UseVisualStyleBackColor = true;
            Quant.Click += Quant_Click;
            // 
            // EditItem
            // 
            EditItem.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditItem.Location = new Point(552, 180);
            EditItem.Name = "EditItem";
            EditItem.Size = new Size(226, 76);
            EditItem.TabIndex = 4;
            EditItem.Text = "Editar Item";
            EditItem.UseVisualStyleBackColor = true;
            EditItem.Click += EditItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 22);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 5;
            label1.Text = "📦Estoque";
            // 
            // button1
            // 
            button1.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(36, 516);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 6;
            button1.Text = "↩️";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(67, 516);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 8;
            button2.Text = "↩️";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(859, 573);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(EditItem);
            Controls.Add(Quant);
            Controls.Add(Remove);
            Controls.Add(AddItem);
            Controls.Add(listEstoque);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEstoque;
        private Button AddItem;
        private Button Remove;
        private Button Quant;
        private Button EditItem;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}