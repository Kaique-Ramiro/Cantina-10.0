using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CANTINA_10._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            User.Enter += textBox_Usuario_Enter;
            User.Leave += textBox_Usuario_Leave;
            Senha.Enter += textBox_Senha_Enter;
            Senha.Leave += textBox_Senha_Leave;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            User.Text = "";
        }
        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Text))
            {
                User.Text = "Digite seu usu�rio:";
                User.ForeColor = Color.Gray;
            }
        }
        private void textBox_Senha_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_Senha_Click(object sender, EventArgs e)
        {
            Senha.Text = "";
        }
        private void textBox_Senha_Enter(object sender, EventArgs e)
        {
            if (Senha.Text == "Digite sua senha:")
            {
                Senha.Text = "";
                Senha.ForeColor = Color.Black;
                Senha.PasswordChar = '*';
            }
        }
        private void textBox_Senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Senha.Text))
            {
                Senha.Text = "Digite sua senha:";
                Senha.ForeColor = Color.Gray;
                Senha.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("usuarios.json"))
                File.Delete("usuarios.json");
            if (!System.IO.File.Exists("usuarios.json"))
                GerarArquivoUsuarios();
            UsuarioGlobal.Usuarios = Persistencia.CarregarLista<Usuario>("usuarios.json");
            Estoque.Itens = Persistencia.CarregarLista<Cardapio>("estoque.json");
            HistoricoGlobal.HistoricoPedidos = Persistencia.CarregarLista<Pedido>("historico.json");


            if (Estoque.Itens.Count == 0)
            {
                Estoque.Itens.Add(new Cardapio(5, "P�o de queijo", 3.50, 20, false));
                Estoque.Itens.Add(new Cardapio(2, "Coxinha", 5.00, 20, false));
                Estoque.Itens.Add(new Cardapio(6, "Pastel de Carne", 6.00, 20, true));
                Estoque.Itens.Add(new Cardapio(7, "Pastel de Queijo", 5.50, 20, true));
                Estoque.Itens.Add(new Cardapio(8, "Suco Natural (300ml)", 4.00, 20, false));
                Estoque.Itens.Add(new Cardapio(9, "Refrigerante Lata", 4.50, 20, false));
                Estoque.Itens.Add(new Cardapio(4, "Hamb�rguer simples", 8.00, 20, true));
                Estoque.Itens.Add(new Cardapio(3, "Hamb�rguer com queijo", 9.00, 20, true));
                Estoque.Itens.Add(new Cardapio(10, "X-Tudo", 12.00, 20, true));
                Estoque.Itens.Add(new Cardapio(1, "�gua Mineral (500ml)", 2.50, 20, false));
            }
            Senha.Text = "Digite sua senha:";
            Senha.ForeColor = Color.Gray;
            Senha.PasswordChar = '\0';
        }
        private static string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        private void GerarArquivoUsuarios()
        {
            var usuarios = new List<Usuario>()
            {
                new Usuario { Nome = "admin", Senha = GerarHash("admin") },
                new Usuario { Nome = "caixa", Senha = GerarHash("vendasbolt") },
                new Usuario { Nome = "telao", Senha = GerarHash("telaobolt") },
                new Usuario { Nome = "cozinha", Senha = GerarHash("cozinhabolt") },
                new Usuario { Nome = "balcao", Senha = GerarHash("balcaobolt") }
            };
            Persistencia.SalvarLista(usuarios, "usuarios.json");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = User.Text;
            string senhaDigitada = Senha.Text;
            string hashSenha = GerarHash(senhaDigitada);

            var usuarioObj = UsuarioGlobal.Usuarios.FirstOrDefault(u => u.Nome == usuario);
            if (usuarioObj != null && usuarioObj.Senha == hashSenha)
            {
                UsuarioGlobal.UsuarioLogado = usuario;
                if (usuario == "admin")
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
                else if (usuario == "caixa")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else if (usuario == "telao")
                {
                    Form7 form7 = new Form7();
                    form7.Show();
                    this.Hide();
                }
                else if (usuario == "cozinha")
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else if (usuario == "balcao")
                {
                    Form6 form6 = new Form6();
                    form6.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usu�rio ou senha incorretos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Senha.Text != "Digite sua senha:")
            {
                if (Senha.PasswordChar == '*')
                {
                    Senha.PasswordChar = '\0';
                }
                else
                {
                    Senha.PasswordChar = '*';
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair do servi�o?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Persistencia.SalvarLista(UsuarioGlobal.Usuarios, "usuarios.json");
            Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
            Persistencia.SalvarLista(HistoricoGlobal.HistoricoPedidos, "pedidos.json");
        }
    }
}
