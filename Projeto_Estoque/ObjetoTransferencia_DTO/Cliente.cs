using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string cep { get; set; }
        public string descricao { get; set; }
        public string tipoCliente { get; set; }
    }
}
