using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ProdutoDTO
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Byte foto { get; set; }
        public float valorPago { get; set; }
        public float valorVenda { get; set; }
        public int qtd { get; set; }
        public int idUnidaMedida { get; set; }
        public int idCategoria { get; set; }
        public int idSubCategoria { get; set; }
    }
}
