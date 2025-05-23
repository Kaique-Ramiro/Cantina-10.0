using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANTINA_10._0
{
    internal class Pedido
    {
        public int Id { get; set; } = 0;
        public string NomeCliente { get; set; }
        public List<Cardapio> Itens { get; set; }
        public int Quantidade {  get; set; }
        public DateTime DataHora { get; set; }
    }
}
