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
    public class SubcategoriaBLL
    {
        public string Inserir(Subcategoria subcategoria)
        {
            SubcategoriaDAL subcategoriaDAL = new SubcategoriaDAL();
            string idSubcategoria = subcategoriaDAL.Inserir(subcategoria);

            return idSubcategoria;
        }

        public string Alterar(Subcategoria subcategoria)
        {
            SubcategoriaDAL subcategoriaDAL = new SubcategoriaDAL();
            string idSubcategoria = subcategoriaDAL.Alterar(subcategoria);

            return idSubcategoria;
        }

        public string Excluir(Subcategoria subcategoria)
        {
            SubcategoriaDAL subcategoriaDAL = new SubcategoriaDAL();
            string idSubcategoria = subcategoriaDAL.Excluir(subcategoria);

            return idSubcategoria;
        }

        public SubcategoriaColecao ConsultarNome(string nome)
        {
            SubcategoriaDAL SubcategoriaDAL = new SubcategoriaDAL();
            return SubcategoriaDAL.ConsultarNome(nome);
        }

        public SubcategoriaColecao ConsultaId(int idSubcategoria)
        {
            SubcategoriaDAL subcategoriaDAL = new SubcategoriaDAL();
            return subcategoriaDAL.ConsultaId(idSubcategoria);
        }

//end
    }
}
