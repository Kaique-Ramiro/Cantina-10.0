using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANTINA_10._0
{
    internal class PreparoPedidos
    {
        public static PreparoPedidos Instancia { get; } = new PreparoPedidos();
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
