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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form6_Load);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PedidosBalcao.SelectedItem is Pedido pedidoSelecionado)
            {
               DialogResult resultado = MessageBox.Show("Este pedido está pronto para ser entregue?", "Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    pedidoSelecionado.Status = "- Entregue";
                    PedidosBalcao.Items[PedidosBalcao.SelectedIndex] = pedidoSelecionado;
                    PreparoPedidos.Instancia.Pedidos.Remove(pedidoSelecionado);
                    PedidosBalcao.Items.Remove(pedidoSelecionado);
                    ComandaBalcao.Items.Clear();
                    HistoricoGlobal.HistoricoPedidos.Add(pedidoSelecionado);
                    HistoricoBalcao.Items.Add(pedidoSelecionado);
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            PedidosBalcao.Items.Clear();
            if (PedidosBalcao.SelectedItem is Pedido pedidoSelecionado)
            {
                foreach (Cardapio item in pedidoSelecionado.Itens)
                {
                    ComandaBalcao.Items.Add($"{item.Nome} - Quantidade: {item.Quantidade} - {pedidoSelecionado.Tipo}");
                }
            }
        }

        private void PedidosBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComandaBalcao.Items.Clear();
            if (PedidosBalcao.SelectedItem is Pedido pedidoSelecionado)
            {
                foreach (Cardapio item in pedidoSelecionado.Itens)
                {
                    ComandaBalcao.Items.Add($"{item.Nome} - Quantidade: {item.Quantidade} - {pedidoSelecionado.Tipo}");
                }
            }
        }

        private void HistoricoBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
