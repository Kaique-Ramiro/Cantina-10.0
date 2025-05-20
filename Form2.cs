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
            Cardapio.Items.Add(new Cardapio("Pão de queijo", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Coxinha", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Pastel de Carne", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Pastel de Queijo", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Suco Natural (300ml)", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Refrigerante Lata", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Hambúrguer simples", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Hambúrguer com queijo", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("X-Tudo", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Água Mineral (500ml)", 3.50, 0));
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
                    Cardapio novoItem = new Cardapio(produtoSelecionado.Nome, produtoSelecionado.Preco, 1);
                    Carrinho.Items.Add(novoItem);
                }

                double somaTotal = 0;
                foreach (Cardapio item in Carrinho.Items)
                {
                    somaTotal += item.Preco;
                }
                label3.Text = "R$" + somaTotal.ToString("F2");
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
                    label3.Text = "R$ 0,00";
                }
                else
                {
                    label3.Text = "R$" + somaTotal.ToString("F2");
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

            string nomeCliente = textBox1.Text;
            string mensagem = $"{Horariopedido}";
            mensagem += $"\n {nomeCliente} realizou os seguintes pedidos:\n\n";

            foreach (var item in Carrinho.Items)
            {
                mensagem += "-" + item.ToString() + "\n";
            }
            mensagem += $"\nTotal: R$ {somaFinal:F2}";
            mensagem += "\n\nEstes pedidos estão corretos?";
            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                
                MessageBox.Show($"O pedido de {nomeCliente} foi realizado com sucesso", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Carrinho.Items.Clear();
                label3.Text = "R$ 0,00";
            }
            else
            {
                DialogResult resultado2 = MessageBox.Show("Deseja remover todos os itens do pedido?", "Remover Itens", MessageBoxButtons.YesNo);
                if (resultado2 == DialogResult.Yes)
                {
                    Carrinho.Items.Clear();
                    label3.Text = "R$ 0,00";
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
            label3.Text = "R$ 0, 00";
        }
    }
}