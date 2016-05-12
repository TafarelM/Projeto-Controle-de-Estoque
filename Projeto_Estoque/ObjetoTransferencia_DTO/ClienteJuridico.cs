using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ClienteJuridico : Cliente
    {
        public int idClienteJuridico { get; set; }
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string inscricaoEstadual { get; set; }
        public int idClienteFK { get; set; }
    }
}
