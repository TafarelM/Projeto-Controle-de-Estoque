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
    public class ClienteFisicoDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //INSERIR
        public string Inserir(ClienteFisico clienteFisico)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona dados
                //cliente fisico
                acessoDadosSqlServer.AdicionarParametros("@nome", clienteFisico.nome);
                acessoDadosSqlServer.AdicionarParametros("@cpf", clienteFisico.cpf);
                acessoDadosSqlServer.AdicionarParametros("@rg", clienteFisico.rg);
                acessoDadosSqlServer.AdicionarParametros("@dataNasc", clienteFisico.dataNasc);
                acessoDadosSqlServer.AdicionarParametros("@sexo", clienteFisico.sexo);
                //cliente
                acessoDadosSqlServer.AdicionarParametros("@rua", clienteFisico.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", clienteFisico.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", clienteFisico.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", clienteFisico.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", clienteFisico.estado);
                acessoDadosSqlServer.AdicionarParametros("@telefone", clienteFisico.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", clienteFisico.celular);
                acessoDadosSqlServer.AdicionarParametros("@email", clienteFisico.email);
                acessoDadosSqlServer.AdicionarParametros("@cep", clienteFisico.cep);
                acessoDadosSqlServer.AdicionarParametros("@descricao", clienteFisico.descricao);
                acessoDadosSqlServer.AdicionarParametros("@tipoCliente", clienteFisico.tipoCliente);
                //executa a manipulção
                //pode aceitar procedure ou comando sql
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
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

        //ALTERAR
        public string Alterar(ClienteFisico clienteFisico)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                //cliente fisico
                acessoDadosSqlServer.AdicionarParametros("@idClienteFisico", clienteFisico.idClienteFisico);
                acessoDadosSqlServer.AdicionarParametros("@nome", clienteFisico.nome);
                acessoDadosSqlServer.AdicionarParametros("@cpf", clienteFisico.cpf);
                acessoDadosSqlServer.AdicionarParametros("@rg", clienteFisico.rg);
                acessoDadosSqlServer.AdicionarParametros("@dataNasc", clienteFisico.dataNasc);
                acessoDadosSqlServer.AdicionarParametros("@sexo", clienteFisico.sexo);
                acessoDadosSqlServer.AdicionarParametros("@idClienteFK", clienteFisico.idClienteFK);
                //cliente
                acessoDadosSqlServer.AdicionarParametros("@idClienteF", clienteFisico.idCliente);
                acessoDadosSqlServer.AdicionarParametros("@rua", clienteFisico.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", clienteFisico.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", clienteFisico.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", clienteFisico.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", clienteFisico.estado);
                acessoDadosSqlServer.AdicionarParametros("@telefone", clienteFisico.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", clienteFisico.celular);
                acessoDadosSqlServer.AdicionarParametros("@email", clienteFisico.email);
                acessoDadosSqlServer.AdicionarParametros("@cep", clienteFisico.cep);
                acessoDadosSqlServer.AdicionarParametros("@descricao", clienteFisico.descricao);
                acessoDadosSqlServer.AdicionarParametros("@tipoCliente", clienteFisico.tipoCliente);
                //executa e manipula
                //pode aceitar procedure ou comando sql
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //EXLCUIR
        public string Excluir(ClienteFisico clienteFisico)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idClientefisico", clienteFisico.idClienteFisico);
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
        public ClienteFisicoColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ClienteFisicoColecao clienteFisicoColecao = new ClienteFisicoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableClienteF = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableClienteF.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    ClienteFisico clienteF = new ClienteFisico();
                    //cliente fisico
                    clienteF.idClienteFK = Convert.ToInt32(linha["idClienteFisico"]);
                    clienteF.nome = Convert.ToString(linha["nome"]);
                    clienteF.cpf = Convert.ToString(linha["cpf"]);
                    clienteF.rg = Convert.ToString(linha["rg"]);
                    clienteF.dataNasc = Convert.ToDateTime(linha["dataNasc"]);
                    clienteF.sexo = Convert.ToString(linha["sexo"]);
                    clienteF.idClienteFK = Convert.ToInt32(linha["idCliente"]);
                    //cliente
                    clienteF.idCliente = Convert.ToInt32(linha["idCliente"]);
                    clienteF.rua = Convert.ToString(linha["rua"]);
                    clienteF.numero = Convert.ToString(linha["numero"]);
                    clienteF.bairro = Convert.ToString(linha["bairro"]);
                    clienteF.cidade = Convert.ToString(linha["cidade"]);
                    clienteF.estado = Convert.ToString(linha["estado"]);
                    clienteF.telefone = Convert.ToString(linha["telefone"]);
                    clienteF.celular = Convert.ToString(linha["celular"]);
                    clienteF.email = Convert.ToString(linha["email"]);
                    clienteF.cep = Convert.ToString(linha["cep"]);
                    clienteF.descricao = Convert.ToString(linha["descricao"]);
                    clienteF.tipoCliente = Convert.ToString(linha["tipocliente"]);


                    //adiciona os dados de cliente na clienteColecao
                    clienteFisicoColecao.Add(clienteF);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return clienteFisicoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Cliente por nome. \nDetalhes: " + exception.Message);
            }

        }

        //CONSULTAR ID
        public ClienteFisicoColecao ConsultaId(int idClienteFisico)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ClienteFisicoColecao clienteFisicoColecao = new ClienteFisicoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idClienteFisico", idClienteFisico);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableClienteFisico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");
                //
                foreach (DataRow linha in dataTableClienteFisico.Rows)
                {
                    //
                    ClienteFisico clienteF = new ClienteFisico();

                    //cliente fisico
                    clienteF.idClienteFK = Convert.ToInt32(linha["idClienteFisico"]);
                    clienteF.nome = Convert.ToString(linha["nome"]);
                    clienteF.cpf = Convert.ToString(linha["cpf"]);
                    clienteF.rg = Convert.ToString(linha["rg"]);
                    clienteF.dataNasc = Convert.ToDateTime(linha["dataNasc"]);
                    clienteF.sexo = Convert.ToString(linha["sexo"]);
                    clienteF.idClienteFK = Convert.ToInt32(linha["idCliente"]);
                    //cliente
                    clienteF.idCliente = Convert.ToInt32(linha["idCliente"]);
                    clienteF.rua = Convert.ToString(linha["rua"]);
                    clienteF.numero = Convert.ToString(linha["numero"]);
                    clienteF.bairro = Convert.ToString(linha["bairro"]);
                    clienteF.cidade = Convert.ToString(linha["cidade"]);
                    clienteF.estado = Convert.ToString(linha["estado"]);
                    clienteF.telefone = Convert.ToString(linha["telefone"]);
                    clienteF.celular = Convert.ToString(linha["celular"]);
                    clienteF.email = Convert.ToString(linha["email"]);
                    clienteF.cep = Convert.ToString(linha["cep"]);
                    clienteF.descricao = Convert.ToString(linha["descricao"]);
                    clienteF.tipoCliente = Convert.ToString(linha["tipocliente"]);

                    //adiciona a coleção
                    clienteFisicoColecao.Add(clienteF);
                }

                return clienteFisicoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Cliente por Código. \nDetalhes: " + exception.Message);
            }
        }
    }
}
