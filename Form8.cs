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
            foreach (var item in Estoque.Itens)
            {
                

            }
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
    }
}
