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
    public class UnidadeMedidaDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(UnidadeMedida unidadeMedida)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@nome", unidadeMedida.nome);
                acessoDadosSqlServer.AdicionarParametros("@descricao", unidadeMedida.descricao);

                //executa a manipulção
                string idUnidadeMedida = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "").ToString();
                return idUnidadeMedida;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(UnidadeMedida unidadeMedida)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idProduto", unidadeMedida.idUnidadeMedida);
                acessoDadosSqlServer.AdicionarParametros("@nome", unidadeMedida.nome);
                acessoDadosSqlServer.AdicionarParametros("@descricao", unidadeMedida.descricao);

                //executa e manipula
                string idUnidadeMedida = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "").ToString();
                return idUnidadeMedida;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(UnidadeMedida unidadeMedida)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idUnidadeMedida", unidadeMedida.idUnidadeMedida);
                //chamar a procedure para manipulação
                string idUnidadeMedida = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "delete from unidadeMedida where idUnidadeMedida = @idUnidadeMedida").ToString();
                return idUnidadeMedida;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public UnidadeMedidaColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                UnidadeMedidaColecao unidadeMedidaColecao = new UnidadeMedidaColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableUnidadeMedida = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableUnidadeMedida.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    UnidadeMedida unidadeMedida = new UnidadeMedida();
                    //
                    unidadeMedida.idUnidadeMedida = Convert.ToInt32(linha["IdUnidadeMedida"]);
                    unidadeMedida.nome = Convert.ToString(linha["nome"]);
                    unidadeMedida.descricao = Convert.ToString(linha["descricao"]);

                    //adiciona os dados de cliente na clienteColecao
                    unidadeMedidaColecao.Add(unidadeMedida);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return unidadeMedidaColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Unidade de Medida por nome. \nDetalhes: " + exception.Message);
            }

        }

        public UnidadeMedidaColecao ConsultaId(int idUnidadeMedida)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                UnidadeMedidaColecao unidadeMedidaColecao = new UnidadeMedidaColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idUnidadeMedida", idUnidadeMedida);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableUnidadeMedida = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM UnidadeMedida WHERE (idUnidadeMedida)");
                //
                foreach (DataRow linha in dataTableUnidadeMedida.Rows)
                {
                    //
                    UnidadeMedida unidadeMedida = new UnidadeMedida();

                    unidadeMedida.idUnidadeMedida = Convert.ToInt32(linha["IdUnidadeMedida"]);
                    unidadeMedida.nome = Convert.ToString(linha["nome"]);
                    unidadeMedida.descricao = Convert.ToString(linha["descricao"]);

                    //adiciona a coleção
                    unidadeMedidaColecao.Add(unidadeMedida);
                }

                return unidadeMedidaColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Unidade de Medida pelo Código. \nDetalhes: " + exception.Message);
            }
        }
    }
}
