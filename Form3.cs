using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANTINA_10._0
{
    public partial class Form3 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> OpcoesSelecionadas {  get; private set; } = new List<string>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TipoPedido {  get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Troco { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double TotalPedido { get; set; }

        public Form3()
        {
            InitializeComponent();
            Consumo.Checked = true;
            Débito.Checked = true;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormaSelecionada { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Entrega { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Dinheiro.Checked)
                FormaSelecionada = "Dinheiro";
            else if (Crédito.Checked)
                FormaSelecionada = "Crédito";
            else if (Débito.Checked)
                FormaSelecionada = "Débito";
            else if (Pix.Checked)
                FormaSelecionada = "Pix";
            else
            {
                MessageBox.Show("Selecione o Método de Pagamento");
                return;
            }
            if (Consumo.Checked)
               Entrega = " - Consumo na Loja";
            else if (Viagem.Checked)
               Entrega = " - Para Viagem";
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (FormaSelecionada == "Dinheiro - Para Viagem")
            {
                while (true)
                {
                    string valorStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o Valor Recebido:", "Dinheiro", "0");
                    if (double .TryParse(valorStr, out double valorRecebido))
                    {
                        if (valorRecebido >= TotalPedido)
                        {
                            Troco = valorRecebido - TotalPedido;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor Inválido. Por favor, Insira Novamente.");
                    }
                }
            }
            else if (FormaSelecionada == "Dinheiro - Consumo na Loja")
            {
                while (true)
                {
                    string valorStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o Valor Recebido:", "Dinheiro", "0");
                    if (double.TryParse(valorStr, out double valorRecebido))
                    {
                        if (valorRecebido >= TotalPedido)
                        {
                            Troco = valorRecebido - TotalPedido;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor Inválido. Por favor, Insira Novamente.");
                    }
                }
            }
        }
    }
}
