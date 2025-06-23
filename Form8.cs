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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void AtualizarLista()
        {
            listEstoque.Items.Clear();
            foreach (var item in Estoque.Itens.OrderBy(x => x.ID))
            {
                listEstoque.Items.Add(item);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (UsuarioGlobal.UsuarioLogado == "admin")
            {
                button1.Visible = true;
                button2.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = true;
            }
            AtualizarLista();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            int IDitem;
            string idStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do item:", "Adicionar Item", "");
            string nomeItem = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do item:", "Adicionar Item", "");
            if (string.IsNullOrWhiteSpace(nomeItem))
            {
                MessageBox.Show("Nome do item não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int quantidade;
            string quantidadeStr = Microsoft.VisualBasic.Interaction.InputBox("Digite a quantidade:", "Adicionar Item", "1");
            if (!int.TryParse(quantidadeStr, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double preco;
            string precoStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o preço do item:", "Adicionar Item", "0.00");
            if (!double.TryParse(precoStr, out preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listEstoque.SelectedItem is Cardapio pedidoSelecionado)
            {
                Estoque.Itens.Remove(pedidoSelecionado);
                listEstoque.Items.Remove(pedidoSelecionado);
            }
        }

        private void Quant_Click(object sender, EventArgs e)
        {
            if (listEstoque.SelectedItem is Cardapio pedidoSelecionado)
            {
                string novaQuantidadeStr = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova quantidade:", "Alterar Quantidade", pedidoSelecionado.Quantidade.ToString());
                if (int.TryParse(novaQuantidadeStr, out int novaQuantidade) && novaQuantidade >= 0)
                {
                    pedidoSelecionado.Quantidade = novaQuantidade;
                    listEstoque.Items[listEstoque.SelectedIndex] = pedidoSelecionado;
                }
                else
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (listEstoque.SelectedItem != null)
            {
                Cardapio itemSelecionado = (Cardapio)listEstoque.SelectedItem;
                string IDitemSTR = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do item:", "Editar Item", itemSelecionado.ID.ToString());
                if (int.TryParse(IDitemSTR, out int IDitem) || IDitem < 0)
                {
                    MessageBox.Show("ID inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string novoNome = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo nome do item:", "Editar Item", itemSelecionado.Nome);
                if (string.IsNullOrWhiteSpace(novoNome))
                {
                    MessageBox.Show("Nome do item não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string novaQuantidadeStr = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova quantidade:", "Editar Item", itemSelecionado.Quantidade.ToString());
                if (!int.TryParse(novaQuantidadeStr, out int novaQuantidade) || novaQuantidade < 0)
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string novoPrecoStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo preço:", "Editar Item", itemSelecionado.Preco.ToString("F2"));
                if (!double.TryParse(novoPrecoStr, out double novoPreco) || novoPreco < 0)
                {
                    MessageBox.Show("Preço inválido. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool novaChapa = itemSelecionado.Chapa;
                string chapaStr = Microsoft.VisualBasic.Interaction.InputBox("O item é preparado na chapa? (Sim/Não)", "Editar Item", novaChapa ? "Sim" : "Não");
                if (chapaStr.Equals("Sim", StringComparison.OrdinalIgnoreCase))
                {
                    novaChapa = true;
                }
                else if (chapaStr.Equals("Não", StringComparison.OrdinalIgnoreCase))
                {
                    novaChapa = false;
                }
                else
                {
                    MessageBox.Show("Opção inválida. Por favor, insira 'Sim' ou 'Não'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                itemSelecionado.ID = IDitem;
                itemSelecionado.Nome = novoNome;
                itemSelecionado.Quantidade = novaQuantidade;
                itemSelecionado.Preco = novoPreco;
                itemSelecionado.Chapa = novaChapa;

                listEstoque.Items[listEstoque.SelectedIndex] = itemSelecionado;
            }

            AtualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
