using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia_DTO
{
    public class ClienteFisico : Cliente
    {
        public int idClienteFisico { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime dataNasc { get; set; }
        public string sexo { get; set; }
        public int idClienteFK { get; set; }
    }
}
