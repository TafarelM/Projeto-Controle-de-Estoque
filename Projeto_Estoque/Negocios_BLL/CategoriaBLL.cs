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
    public class CategoriaBLL
    {
        public string Inserir(Categoria categoria)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            string idCategoria = categoriaDAL.Inserir(categoria);

            return idCategoria;
        }

        public string Alterar(Categoria categoria)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            string idCategoria = categoriaDAL.Alterar(categoria);

            return idCategoria;
        }

        public string Excluir(Categoria categoria)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            string idCategoria = categoriaDAL.Excluir(categoria);

            return idCategoria;
        }

        public CategoriaColecao ConsultarNome(string nome)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            return categoriaDAL.ConsultarNome(nome);
        }

        public CategoriaColecao ConsultaId(int idCategoria)
        {
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            return categoriaDAL.ConsultaId(idCategoria);
        }

//end
    }
}
