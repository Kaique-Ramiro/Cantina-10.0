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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Consumo.Checked = true;
            Débito.Checked = true;
        }
        public string FormaSelecionada { get; private set; }

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
                FormaSelecionada = "Consumo na Loja";
            else if (Viagem.Checked)
                FormaSelecionada = "Para Viagem";
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (FormaSelecionada == "Dinheiro - Para Viagem")
            {
                while (true)
                {
                    string valorStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o Valor Recebido:", "Dinheiro", "0");
            }

        }
    }
}
