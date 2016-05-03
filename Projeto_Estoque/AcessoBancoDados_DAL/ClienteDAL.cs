using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add
using ObjetoTransferencia_DTO;
using System.Data;

namespace AcessoBancoDados_DAL
{
    public class ClienteDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(ClienteDTO cliente)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@nome", cliente.nome);

                //executa a manipulção
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(ClienteDTO cliente)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idCliente", cliente.idCliente);
                acessoDadosSqlServer.AdicionarParametros("@nome", cliente.nome);
                acessoDadosSqlServer.AdicionarParametros("@dataNascimento", cliente.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@sexo", cliente.sexo);
                acessoDadosSqlServer.AdicionarParametros("@limiteCompra", cliente.limiteCompra);
                //executa e manipula
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(ClienteDTO cliente)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idCliente", cliente.idCliente);
                //chamar a procedure para manipulação
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ClienteColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ClienteColecao clienteColecao = new ClienteColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Cliente cliente = new Cliente();
                    //
                    cliente.idCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.nome = Convert.ToString(linha["Nome"]);
                    cliente.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.limiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    //adiciona os dados de cliente na clienteColecao
                    clienteColecao.Add(cliente);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return clienteColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Cliente por nome. \nDetalhes: " + exception.Message);
            }

        }

        public ClienteColecao ConsultaId(int idCliente)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ClienteColecao clienteColecao = new ClienteColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idCliente", idCliente);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorId");
                //
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //
                    Cliente cliente = new Cliente();

                    cliente.idCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.nome = Convert.ToString(linha["Nome"]);
                    cliente.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.limiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    //adiciona a coleção
                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Cliente por Código. \nDetalhes: " + exception.Message);
            }
        }
    }
}
