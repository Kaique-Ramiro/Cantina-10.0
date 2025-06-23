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
            if (PedidosBalcao.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido para entregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PedidosBalcao.SelectedItem is Pedido pedidoSelecionado)
            {
                DialogResult resultado = MessageBox.Show("Este pedido está pronto para ser entregue?", "Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    pedidoSelecionado.Status = "- Entregue";
                    PedidosBalcao.Items[PedidosBalcao.SelectedIndex] = pedidoSelecionado;
                    PreparoPedidos.Instancia.Pedidos.Remove(pedidoSelecionado);
                    PedidosBalcao.Items.Remove(pedidoSelecionado);
                    ComandaBalcao.Items.Clear();
                    HistoricoBalcao.Items.Add(pedidoSelecionado);
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (UsuarioGlobal.UsuarioLogado == "admin")
            {
                button2.Visible = true;
                button3.Visible = false;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = true;
            }
            PedidosBalcao.Items.Clear();
            foreach (var pedido in HistoricoGlobal.HistoricoPedidos)
            {
                if (pedido.Status == "- Finalizado")
                {
                    PedidosBalcao.Items.Add(pedido);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
