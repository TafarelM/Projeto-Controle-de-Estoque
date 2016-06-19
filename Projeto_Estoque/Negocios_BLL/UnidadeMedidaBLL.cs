using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add
using ObjetoTransferencia_DTO;
using AcessoBancoDados_DAL;

namespace Negocios_BLL
{
    public class UnidadeMedidaBLL
    {
        public string Inserir(UnidadeMedida unidadeMedida)
        {
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            string idUnidadeMedida = unidadeMedidaDAL.Inserir(unidadeMedida);

            return idUnidadeMedida;
        }

        public string Alterar(UnidadeMedida unidadeMedida)
        {
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            string idUnidadeMedida = unidadeMedidaDAL.Alterar(unidadeMedida);

            return idUnidadeMedida;
        }

        public string Excluir(UnidadeMedida UnidadeMedida)
        {
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            string idUnidadeMedida = unidadeMedidaDAL.Excluir(UnidadeMedida);

            return idUnidadeMedida;
        }

        public UnidadeMedidaColecao ConsultarNome(string nome)
        {
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            return unidadeMedidaDAL.ConsultarNome(nome);
        }

        public UnidadeMedidaColecao ConsultaId(int idUnidadeMedida)
        {
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            return unidadeMedidaDAL.ConsultaId(idUnidadeMedida);
        }

//end
    }
}
