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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Pedidos.Items.Clear();

            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                Pedidos.Items.Add($"Pedido #{pedido.Id} - Cliente: {pedido.NomeCliente}");

                foreach (var item in pedido.Itens)
                {
                    Pedidos.Itens.Add($" {item.Nome} - Quantidade: {item.Quantidade}");
                }

                Pedidos.Itens.Add("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
