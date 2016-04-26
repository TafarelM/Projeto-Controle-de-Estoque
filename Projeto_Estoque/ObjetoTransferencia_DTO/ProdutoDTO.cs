using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class ProdutoDTO
    {
        public int id_produto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Byte foto { get; set; }
        public float valor_pago { get; set; }
        public float valor_venda { get; set; }
        public int qtd { get; set; }
        public int id_umed { get; set; }
        public int id_cat { get; set; }
        public int id_scat { get; set; }
    }
}
