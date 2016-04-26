using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    class ClienteDTO
    {
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string rg { get; set; }
        public string r_social { get; set; }
        public int tipo { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string fone { get; set; }
        public string cel { get; set; }
        public string email { get; set; }
        public string end_numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
