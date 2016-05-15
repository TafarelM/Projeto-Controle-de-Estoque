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
    public class ProdutoBLL
    {
        public string Inserir(Produto produto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            string idProduto = produtoDAL.Inserir(produto);

            return idProduto;
        }

        public string Alterar(Produto produto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            string idProduto = produtoDAL.Alterar(produto);

            return idProduto;
        }

        public string Excluir(Produto produto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            string idProduto = produtoDAL.Excluir(produto);

            return idProduto;
        }

        public ProdutoColecao ConsultarNome(string nome)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            return produtoDAL.ConsultarNome(nome);
        }

        public ProdutoColecao ConsultaId(int idProduto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            return produtoDAL.ConsultaId(idProduto);
        }
    }
}
