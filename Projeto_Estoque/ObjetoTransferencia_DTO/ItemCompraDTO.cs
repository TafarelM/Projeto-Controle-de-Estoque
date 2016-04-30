using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ItemCompraDTO
    {
        public int idItemCompra { get; set; }
        public int qtd { get; set; }
        public float valor { get; set; }
        public int idCompra { get; set; }
        public int idProduto { get; set; }
    }
}
