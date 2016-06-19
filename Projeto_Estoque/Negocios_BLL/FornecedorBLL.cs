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
    public class FornecedorBLL
    {
        public string Inserir(Fornecedor fornecedor)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            string idFornecedor = fornecedorDAL.Inserir(fornecedor);

            return idFornecedor;
        }

        public string Alterar(Fornecedor fornecedor)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            string idFornecedor = fornecedorDAL.Alterar(fornecedor);

            return idFornecedor;
        }

        public string Excluir(Fornecedor Fornecedor)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            string idFornecedor = fornecedorDAL.Excluir(Fornecedor);

            return idFornecedor;
        }

        public FornecedorColecao ConsultarNome(string nome)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.ConsultarNome(nome);
        }

        public FornecedorColecao ConsultaId(int idFornecedor)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.ConsultaId(idFornecedor);
        }

//end
    }
}
