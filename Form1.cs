namespace CANTINA_10._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_Usuario.Enter += textBox_Usuario_Enter;
            textBox_Usuario.Leave += textBox_Usuario_Leave;
            textBox_Senha.Enter += textBox_Senha_Enter;
            textBox_Senha.Leave += textBox_Senha_Leave;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            textBox_Usuario.Text = "";
        }
        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Usuario.Text))
            {
                textBox_Usuario.Text = "Digite seu usuário:";
                textBox_Usuario.ForeColor = Color.Gray;
            }
        }
        private void textBox_Senha_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_Senha_Click(object sender, EventArgs e)
        {
            textBox_Senha.Text = "";
        }
        private void textBox_Senha_Enter(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "Digite sua senha:")
            {
                textBox_Senha.Text = "";
                textBox_Senha.ForeColor = Color.Black;
            }
        }
        private void textBox_Senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Senha.Text))
            {
                textBox_Senha.Text = "Digite sua senha:";
                textBox_Senha.ForeColor = Color.Gray;
            }
        }
    }
}
