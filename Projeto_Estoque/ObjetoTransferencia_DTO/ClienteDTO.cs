using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ClienteDTO
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string cpf_Cnpj { get; set; }
        public string rg { get; set; }
        public string r_Social { get; set; }
        public int tipo { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string cel { get; set; }
        public string email { get; set; }
        public string numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
