using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//referencias adicionadas
using ObjetoTransferencia_DTO;
using System.Data;

namespace AcessoBancoDados_DAL
{
    public class CompraDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Compra compra)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@data", compra.data);
                acessoDadosSqlServer.AdicionarParametros("@notaFiscal", compra.notaFiscal);
                acessoDadosSqlServer.AdicionarParametros("@total", compra.total);
                acessoDadosSqlServer.AdicionarParametros("@formaPagamento", compra.formaPagamento);
                acessoDadosSqlServer.AdicionarParametros("@status", compra.status);
                acessoDadosSqlServer.AdicionarParametros("@idFornecedor", compra.idFornecedor);
                acessoDadosSqlServer.AdicionarParametros("@tipoPagamento", compra.idTipoPagamento);
                //executa a manipulção
                string idCompra = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCompra;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(Compra compra)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idCompra", compra.idCompra);
                acessoDadosSqlServer.AdicionarParametros("@data", compra.data);
                acessoDadosSqlServer.AdicionarParametros("@notaFiscal", compra.notaFiscal);
                acessoDadosSqlServer.AdicionarParametros("@total", compra.total);
                acessoDadosSqlServer.AdicionarParametros("@formaPagamento", compra.formaPagamento);
                acessoDadosSqlServer.AdicionarParametros("@status", compra.status);
                acessoDadosSqlServer.AdicionarParametros("@idFornecedor", compra.idFornecedor);
                acessoDadosSqlServer.AdicionarParametros("@idTipoPagamento", compra.idTipoPagamento);
                //executa e manipula
                string idCompra = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCompra;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Compra compra)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idCompra", compra.idCompra);
                //chamar a procedure para manipulação
                string idCompra = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCompra;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public CompraColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                CompraColecao compraColecao = new CompraColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableCompra = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableCompra.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Compra compra = new Compra();
                    //
                    compra.idCompra = Convert.ToInt32(linha["idCompra"]);
                    compra.data = Convert.ToDateTime(linha["data"]);
                    compra.notaFiscal = Convert.ToString(linha["notaFiscal"]);
                    compra.total = Convert.ToDecimal(linha["total"]);
                    compra.formaPagamento = Convert.ToString(linha["formaPagamento"]);
                    compra.status = Convert.ToString(linha["status"]);
                    compra.idFornecedor = Convert.ToInt32(linha["idFornecedor"]);
                    compra.idTipoPagamento = Convert.ToInt32(linha["idTipoPagamento"]);

                    //adiciona os dados de cliente na clienteColecao
                    compraColecao.Add(compra);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return compraColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Cliente por nome. \nDetalhes: " + exception.Message);
            }

        }

        public CompraColecao ConsultaId(int idCompra)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                CompraColecao compraColecao = new CompraColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idCompra", idCompra);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableCompra = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");
                //
                foreach (DataRow linha in dataTableCompra.Rows)
                {
                    //
                    Compra compra = new Compra();

                    compra.idCompra = Convert.ToInt32(linha["idCompra"]);
                    compra.data = Convert.ToDateTime(linha["data"]);
                    compra.notaFiscal = Convert.ToString(linha["notaFiscal"]);
                    compra.total = Convert.ToDecimal(linha["total"]);
                    compra.formaPagamento = Convert.ToString(linha["formaPagamento"]);
                    compra.status = Convert.ToString(linha["status"]);
                    compra.idFornecedor = Convert.ToInt32(linha["idFornecedor"]);
                    compra.idTipoPagamento = Convert.ToInt32(linha["idTipoPagamento"]);

                    //adiciona a coleção
                    compraColecao.Add(compra);
                }

                return compraColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Cliente por Código. \nDetalhes: " + exception.Message);
            }
        }
    }
}