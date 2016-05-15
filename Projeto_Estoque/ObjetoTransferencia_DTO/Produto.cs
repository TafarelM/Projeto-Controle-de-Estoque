using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public decimal valorPago { get; set; }
        public decimal valorVenda { get; set; }
        public int quantidade { get; set; }
        public string descricao { get; set; }
        public int idUnidaMedida { get; set; }
        public int idCategoria { get; set; }
        public int idSubcategoria { get; set; }
    }
}
