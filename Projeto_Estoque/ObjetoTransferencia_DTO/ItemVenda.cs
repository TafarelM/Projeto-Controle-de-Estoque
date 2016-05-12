using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ItemVenda
    {
        public int idItemVenda { get; set; }
        public int quantidade { get; set; }
        public float valor { get; set; }
        public int idVenda { get; set; }
        public int idProduto { get; set; }
    }
}
