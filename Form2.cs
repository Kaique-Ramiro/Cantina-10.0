using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANTINA_10._0
{
    public partial class Form2 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Horariopedido { get; private set; } = DateTime.Now;
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cardapio.Items.Clear();
            Cardapio.Items.Add(new Cardapio("Pão de queijo", 3.50, 0, false));
            Cardapio.Items.Add(new Cardapio("Coxinha", 5.00, 0, false));
            Cardapio.Items.Add(new Cardapio("Pastel de Carne", 6.00, 0, true));
            Cardapio.Items.Add(new Cardapio("Pastel de Queijo", 5.50, 0, true));
            Cardapio.Items.Add(new Cardapio("Suco Natural (300ml)", 4.00, 0, false));
            Cardapio.Items.Add(new Cardapio("Refrigerante Lata", 4.50, 0, false));
            Cardapio.Items.Add(new Cardapio("Hambúrguer simples", 8.00, 0, true));
            Cardapio.Items.Add(new Cardapio("Hambúrguer com queijo", 9.00, 0, true));
            Cardapio.Items.Add(new Cardapio("X-Tudo", 12.00, 0, true));
            Cardapio.Items.Add(new Cardapio("Água Mineral (500ml)", 2.50, 0, false));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cardapio.SelectedItem is Cardapio produtoSelecionado)
            {
                bool encontrado = false;
                foreach (Cardapio item in Carrinho.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade++;
                        item.Preco += produtoSelecionado.Preco;
                        encontrado = true;

                        int index = Carrinho.Items.IndexOf(item);
                        Carrinho.Items.RemoveAt(index);
                        Carrinho.Items.Insert(index, item);

                        break;
                    }
                }
                if (!encontrado)
                {
                    Cardapio novoItem = new Cardapio(produtoSelecionado.Nome, produtoSelecionado.Preco, 1, produtoSelecionado.Chapa);
                    Carrinho.Items.Add(novoItem);
                }

                double somaTotal = 0;
                foreach (Cardapio item in Carrinho.Items)
                {
                    somaTotal += item.Preco;
                }
                label5.Text = "R$" + somaTotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Selecione um item válido do cardápio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cardapio.SelectedItem is Cardapio produtoSelecionado)
            {
                bool encontrado = false;
                foreach (Cardapio item in Carrinho.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade--;
                        item.Preco -= produtoSelecionado.Preco;
                        encontrado = true;

                        if (item.Quantidade == 0)
                        {
                            Carrinho.Items.Remove(item);
                        }
                        else
                        {
                            int index = Carrinho.Items.IndexOf(item);
                            Carrinho.Items.RemoveAt(index);
                            Carrinho.Items.Insert(index, item);
                        }

                        break;

                    }
                }

                double somaTotal = 0;
                foreach (Cardapio item in Carrinho.Items)
                {
                    somaTotal += item.Preco;
                }
                if (somaTotal == 0)
                {
                    label5.Text = "R$ 0,00";
                }
                else
                {
                    label5.Text = "R$" + somaTotal.ToString("F2");
                }
            }
            else
            {
                MessageBox.Show("Selecione um item válido do cardápio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double somaFinal = 0;
            foreach (Cardapio item in Carrinho.Items)
            {
                somaFinal += item.Preco;
            }
            if (Carrinho.Items.Count == 0)
            {
                MessageBox.Show("Nenhum pedido foi realizado no momento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor insira seu nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form3 form3 = new Form3();
            form3.TotalPedido = somaFinal;
            if (form3.ShowDialog() == DialogResult.OK)
            {
                string forma = form3.FormaSelecionada;
                string Entrega = form3.Entrega;
                MessageBox.Show("Forma de Pagamento: " + forma);
            }

            string nomeCliente = textBox1.Text;
            string mensagem = $"{Horariopedido}";
            mensagem += $"\n {nomeCliente} realizou os seguintes pedidos:\n\n";

            foreach (var item in Carrinho.Items)
            {
                mensagem += "-" + item.ToString() + "\n";
            }
            mensagem += $"\nTotal: R$ {somaFinal:F2}";
            mensagem += "\nTroco: R$ " + (form3.Troco).ToString("F2");
            mensagem += "\n\nEstes pedidos estão corretos?";
            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                MessageBox.Show($"O pedido de {nomeCliente} foi realizado com sucesso", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Pedido novoPedido = new Pedido(form3.Entrega)
                {
                    Id = PreparoPedidos.Instancia.Pedidos.Count + 1,
                    NomeCliente = textBox1.Text,
                    Itens = Carrinho.Items.Cast<Cardapio>()
                    .Select(item => new Cardapio(item.Nome, item.Preco, item.Quantidade, item.Chapa))
                    .ToList(),
                    DataHora = DateTime.Now,
                    Tipo = form3.Entrega,
                };
                PreparoPedidos.Instancia.Pedidos.Add(novoPedido);
                if (!novoPedido.Itens.Any(item => item.Chapa))
                {
                    novoPedido.Status = "- Finalizado";
                    HistoricoGlobal.HistoricoPedidos.Add(novoPedido);
                }
                
                textBox1.Clear();
                Carrinho.Items.Clear();
                somaFinal = 0;
                label5.Text = "R$ 0,00";
            }
            else
            {
                DialogResult resultado2 = MessageBox.Show("Deseja remover todos os itens do pedido?", "Remover Itens", MessageBoxButtons.YesNo);
                if (resultado2 == DialogResult.Yes)
                {
                    textBox1.Clear();
                    Carrinho.Items.Clear();
                    label5.Text = "R$ 0,00";
                }
                else
                {
                    MessageBox.Show("Os itens continuarão no pedido.", "Itens mantidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Carrinho.Items.Clear();
            label5.Text = "R$ 0, 00";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}