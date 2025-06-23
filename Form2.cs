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
        private object item;

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
        private void AtualizarCardapioListBox()
        {
            int selectedIndex = Cardapio.SelectedIndex;


            Cardapio.BeginUpdate();
            Cardapio.Items.Clear();
            foreach (var item in Estoque.Itens.OrderBy(x => x.ID))
            {
                Cardapio.Items.Add(item);
            }
            Cardapio.EndUpdate();

            if (selectedIndex >= 0 && selectedIndex < Cardapio.Items.Count)
                Cardapio.SelectedIndex = selectedIndex;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(UsuarioGlobal.UsuarioLogado == "admin")
            {
                button5.Visible = true;
                button6.Visible = false;
            }
            else
            {
                button5.Visible = false;
                button6.Visible = true;
            }
            Cardapio.Items.Clear();
            foreach (var item in Estoque.Itens.OrderBy(x => x.ID))
            {
                Cardapio.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cardapio.SelectedItem is Cardapio produtoSelecionado)
            {
                if (produtoSelecionado.Quantidade <= 5)
                {
                    MessageBox.Show("Estoque insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (produtoSelecionado.Quantidade <= 5)
                {
                    MessageBox.Show("Estoque baixo! Apenas " + produtoSelecionado.Quantidade + "unidades restantes");
                }
                bool encontrado = false;
                foreach (Cardapio item in Carrinho.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade++;
                        encontrado = true;

                        int index = Carrinho.Items.IndexOf(item);
                        Carrinho.Items.RemoveAt(index);
                        Carrinho.Items.Insert(index, item);

                        break;
                    }
                }
                if (!encontrado)
                {
                    Cardapio novoItem = new Cardapio(produtoSelecionado.ID, produtoSelecionado.Nome, produtoSelecionado.Preco, 1, produtoSelecionado.Chapa);
                    Carrinho.Items.Add(novoItem);
                }

                produtoSelecionado.Quantidade--;
                AtualizarCardapioListBox();
                Cardapio.Focus();

                double somaTotal = 0;
                foreach (Cardapio item in Carrinho.Items)
                {
                    somaTotal += item.Preco * item.Quantidade;
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
            if (Carrinho.SelectedItem is Cardapio produtoSelecionado)
            {
                foreach (Cardapio item in Carrinho.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        var estoqueItem = Estoque.Itens.FirstOrDefault(i => i.Nome == item.Nome);
                        if (estoqueItem != null)
                            estoqueItem.Quantidade++;

                        item.Quantidade--;

                        if (item.Quantidade == 0)
                        {
                            if (estoqueItem != null)
                                estoqueItem.Quantidade += Math.Max(0, item.Quantidade);
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
                    somaTotal += item.Preco * item.Quantidade;
                }
                if (somaTotal == 0)
                {
                    label5.Text = somaTotal == 0 ? "R$0,00" : "R$ " + somaTotal.ToString("F2");
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
                somaFinal += item.Preco * item.Quantidade;
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

                MessageBox.Show($"O pedido de {nomeCliente} foi realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                var pedidosEmPreparo = Persistencia.CarregarLista<Pedido>("pedidos.json");
                var historico = Persistencia.CarregarLista<Pedido>("historico.json");

                int maiorId = 0;
                if ( pedidosEmPreparo.Any())   
                     maiorId = pedidosEmPreparo.Max(p => p.Id);
                if (historico.Any())
                    maiorId = Math.Max(maiorId, historico.Max(p => p.Id));

                int novoId = maiorId + 1;



                Pedido novoPedido = new Pedido(form3.Entrega)
                {
                    Id = novoId,
                    NomeCliente = textBox1.Text,
                    Itens = Carrinho.Items.Cast<Cardapio>()
                    .Select(item => new Cardapio(item.ID, item.Nome, item.Preco, item.Quantidade, item.Chapa))
                    .ToList(),
                    DataHora = DateTime.Now,
                    Tipo = form3.Entrega,
                };
                PreparoPedidos.Instancia.Pedidos.Add(novoPedido);
                Persistencia.SalvarLista(PreparoPedidos.Instancia.Pedidos, "pedidos.json");
                Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
                if (!novoPedido.Itens.Any(item => item.Chapa))
                {
                    novoPedido.Status = "- Finalizado";
                    HistoricoGlobal.HistoricoPedidos.Add(novoPedido);
                    Persistencia.SalvarLista(HistoricoGlobal.HistoricoPedidos, "historico.json");
                }

                textBox1.Clear();
                Carrinho.Items.Clear();
                somaFinal = 0;
                label5.Text = "R$ 0,00";
            }
            else
            {
                DialogResult resultado2 = MessageBox.Show("Deseja remover todos os itens do pedido?", "Remover Itens", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado2 == DialogResult.Yes)
                {
                    var itemsParaDevolver = Carrinho.Items.Cast<Cardapio>().ToList();

                    foreach (Cardapio item in itemsParaDevolver)
                    {
                        var estoqueItem = Estoque.Itens.FirstOrDefault(i => i.Nome == item.Nome);
                        if (estoqueItem != null)
                            estoqueItem.Quantidade += item.Quantidade;
                    }
                    Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
                    textBox1.Clear();
                    Carrinho.Items.Clear();
                    AtualizarCardapioListBox();
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
            var itensParaDevolver = Carrinho.Items.Cast<Cardapio>().ToList();
            
            foreach (Cardapio item in itensParaDevolver)
            {
                var estoqueItem = Estoque.Itens.FirstOrDefault(i => i.Nome == item.Nome);
                if (estoqueItem != null)     
                    estoqueItem.Quantidade += item.Quantidade;
            }
            Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
            Carrinho.Items.Clear();
            AtualizarCardapioListBox();
            label5.Text = "R$ 0, 00";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Hide();

        }
    }
}