using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//referencias adicionadas
using System.Data;
using ObjetoTransferencia_DTO;

namespace AcessoBancoDados_DAL
{
    public class CategoriaDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
            AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //INSERIR
        public string Inserir(Categoria categoria)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@nome", categoria.nome);
                acessoDadosSqlServer.AdicionarParametros("@descricao", categoria.descricao);
                //executa a manipulção
                //pode aceitar procedure ou comando sql
                string idCategoria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCategoria;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        //ALTERAR
        public string Alterar(Categoria categoria)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", categoria.idCategoria);
                acessoDadosSqlServer.AdicionarParametros("@nome", categoria.nome);
                acessoDadosSqlServer.AdicionarParametros("@descricao", categoria.descricao);
                //executa e manipula
                //pode aceitar procedure ou comando sql
                string idCategoria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCategoria;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //EXLCUIR
        public string Excluir(Categoria categoria)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", categoria.idCategoria);
                //chamar a procedure para manipulação
                //pode aceitar procedure ou comando sql
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //CONSULTAR
        public CategoriaColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                CategoriaColecao categoriaColecao = new CategoriaColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableCategoria = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableCategoria.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Categoria categoria = new Categoria();
                    //
                    categoria.idCategoria = Convert.ToInt32(linha["idCategoria"]);
                    categoria.nome = Convert.ToString(linha["nome"]);
                    categoria.descricao = Convert.ToString(linha["descricao"]);

                    //adiciona os dados de cliente na clienteColecao
                    categoriaColecao.Add(categoria);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return categoriaColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Categoria por nome. \nDetalhes: " + exception.Message);
            }

        }

        //CONSULTAR ID
        public CategoriaColecao ConsultaId(int idCategoria)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                CategoriaColecao categoriaColecao = new CategoriaColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", idCategoria);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableCategoria = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");
                //
                foreach (DataRow linha in dataTableCategoria.Rows)
                {
                    //
                    Categoria categoria = new Categoria();

                    categoria.idCategoria = Convert.ToInt32(linha["idCategoria"]);
                    categoria.nome = Convert.ToString(linha["nome"]);
                    categoria.descricao = Convert.ToString(linha["descricao"]);

                    //adiciona a coleção
                    categoriaColecao.Add(categoria);
                }

                return categoriaColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Categoria por Código. \nDetalhes: " + exception.Message);
            }
        }

//end
    }
}
