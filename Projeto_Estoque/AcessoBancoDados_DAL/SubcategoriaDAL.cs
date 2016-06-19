using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//referencias adicionadas
using AcessoBancoDados_DAL;
using ObjetoTransferencia_DTO;
using System.Data;


namespace AcessoBancoDados_DAL
{
    public class SubcategoriaDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Subcategoria subcategoria)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@nome", subcategoria.nome);
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", subcategoria.idCategoria);

                //executa a manipulção
                string idSubcategoria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "").ToString();
                return idSubcategoria;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(Subcategoria subcategoria)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idSubcategoria", subcategoria.idSubcategoria);
                acessoDadosSqlServer.AdicionarParametros("@nome", subcategoria.nome);
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", subcategoria.idCategoria);

                //executa e manipula
                string idSubcategoria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "").ToString();
                return idSubcategoria;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Subcategoria subcategoria)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idProduto", subcategoria.idSubcategoria);
                //chamar a procedure para manipulação
                string idSubcategoria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "").ToString();
                return idSubcategoria;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public SubcategoriaColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                SubcategoriaColecao subcategoriaColecao = new SubcategoriaColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableSubcategoria = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableSubcategoria.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Subcategoria subcategoria = new Subcategoria();
                    //
                    subcategoria.idSubcategoria = Convert.ToInt32(linha["IdSubcategoria"]);
                    subcategoria.nome = Convert.ToString(linha["nome"]);
                    subcategoria.idCategoria = Convert.ToInt32(linha["idCategoria"]);


                    //adiciona os dados de cliente na clienteColecao
                    subcategoriaColecao.Add(subcategoria);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return subcategoriaColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Produto por nome. \nDetalhes: " + exception.Message);
            }

        }

        public SubcategoriaColecao ConsultaId(int idSubcategoria)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                SubcategoriaColecao subcategoriaColecao = new SubcategoriaColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idSubcategoria", idSubcategoria);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableSubcategoria = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM Subcategoria where (idSubcategoria)");
                //
                foreach (DataRow linha in dataTableSubcategoria.Rows)
                {
                    //
                    Subcategoria subcategoria = new Subcategoria();

                    subcategoria.idSubcategoria = Convert.ToInt32(linha["IdSubcategoria"]);
                    subcategoria.nome = Convert.ToString(linha["nome"]);
                    subcategoria.idCategoria = Convert.ToInt32(linha["idCategoria"]);

                    //adiciona a coleção
                    subcategoriaColecao.Add(subcategoria);
                }

                return subcategoriaColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Subcategoria por Código. \nDetalhes: " + exception.Message);
            }
        }

//END
    }
}
