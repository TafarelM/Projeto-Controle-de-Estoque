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
    public class ClienteJuridicoDAL
    {

        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //INSERIR
        public string Inserir(ClienteJuridico clienteJuridico)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona dados
                //cliente juridico
                acessoDadosSqlServer.AdicionarParametros("@nomeFatansia", clienteJuridico.nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@razaoSocial", clienteJuridico.razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@cnpj", clienteJuridico.cnpj);
                acessoDadosSqlServer.AdicionarParametros("@inscrEstadual", clienteJuridico.inscricaoEstadual);
                //cliente
                acessoDadosSqlServer.AdicionarParametros("@rua", clienteJuridico.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", clienteJuridico.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", clienteJuridico.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", clienteJuridico.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", clienteJuridico.estado);
                acessoDadosSqlServer.AdicionarParametros("@telefone", clienteJuridico.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", clienteJuridico.celular);
                acessoDadosSqlServer.AdicionarParametros("@email", clienteJuridico.email);
                acessoDadosSqlServer.AdicionarParametros("@cep", clienteJuridico.cep);
                acessoDadosSqlServer.AdicionarParametros("@descricao", clienteJuridico.descricao);
                acessoDadosSqlServer.AdicionarParametros("@tipoCliente", clienteJuridico.tipoCliente);
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
        public string Alterar(ClienteJuridico clientejuridico)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                //cliente fisico
                acessoDadosSqlServer.AdicionarParametros("@idClienteFisico", clientejuridico.idClienteJuridico);
                acessoDadosSqlServer.AdicionarParametros("@nomeFantasia", clientejuridico.nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@razaoSocial", clientejuridico.razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@cnpj", clientejuridico.cnpj);
                acessoDadosSqlServer.AdicionarParametros("@inscrEstadual", clientejuridico.inscricaoEstadual);
                acessoDadosSqlServer.AdicionarParametros("@idClienteFK", clientejuridico.idClienteFK);
                //cliente
                acessoDadosSqlServer.AdicionarParametros("@idClienteF", clientejuridico.idCliente);
                acessoDadosSqlServer.AdicionarParametros("@rua", clientejuridico.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", clientejuridico.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", clientejuridico.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", clientejuridico.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", clientejuridico.estado);
                acessoDadosSqlServer.AdicionarParametros("@telefone", clientejuridico.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", clientejuridico.celular);
                acessoDadosSqlServer.AdicionarParametros("@email", clientejuridico.email);
                acessoDadosSqlServer.AdicionarParametros("@cep", clientejuridico.cep);
                acessoDadosSqlServer.AdicionarParametros("@descricao", clientejuridico.descricao);
                acessoDadosSqlServer.AdicionarParametros("@tipoCliente", clientejuridico.tipoCliente);
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
        public string Excluir(ClienteJuridico clienteJuridico)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idClientefisico", clienteJuridico.idClienteJuridico);
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
        public ClienteJuridicoColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ClienteJuridicoColecao clienteJuridicoColecao = new ClienteJuridicoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableClienteJ = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableClienteJ.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    ClienteJuridico clienteJ = new ClienteJuridico();
                    //cliente Juridico
                    clienteJ.idClienteFK = Convert.ToInt32(linha["idClienteJuridico"]);
                    clienteJ.nomeFantasia = Convert.ToString(linha["nomeFatansia"]);
                    clienteJ.razaoSocial = Convert.ToString(linha["razaoSocial"]);
                    clienteJ.cnpj = Convert.ToString(linha["cnpj"]);
                    clienteJ.inscricaoEstadual = Convert.ToString(linha["inscricaoEstadual"]);
                    clienteJ.idClienteFK = Convert.ToInt32(linha["idCliente"]);
                    //cliente
                    clienteJ.idCliente = Convert.ToInt32(linha["idCliente"]);
                    clienteJ.rua = Convert.ToString(linha["rua"]);
                    clienteJ.numero = Convert.ToString(linha["numero"]);
                    clienteJ.bairro = Convert.ToString(linha["bairro"]);
                    clienteJ.cidade = Convert.ToString(linha["cidade"]);
                    clienteJ.estado = Convert.ToString(linha["estado"]);
                    clienteJ.telefone = Convert.ToString(linha["telefone"]);
                    clienteJ.celular = Convert.ToString(linha["celular"]);
                    clienteJ.email = Convert.ToString(linha["email"]);
                    clienteJ.cep = Convert.ToString(linha["cep"]);
                    clienteJ.descricao = Convert.ToString(linha["descricao"]);
                    clienteJ.tipoCliente = Convert.ToString(linha["tipocliente"]);


                    //adiciona os dados de cliente na clienteColecao
                    clienteJuridicoColecao.Add(clienteJ);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return clienteJuridicoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Cliente por nome. \nDetalhes: " + exception.Message);
            }

        }

        //CONSULTAR ID
        public ClienteJuridicoColecao ConsultaId(int idClienteJuridico)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ClienteJuridicoColecao clienteJuridicoColecao = new ClienteJuridicoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idClienteJuridico", idClienteJuridico);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableClienteJuridico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");
                //
                foreach (DataRow linha in dataTableClienteJuridico.Rows)
                {
                    //
                    ClienteJuridico clienteJ = new ClienteJuridico();

                    //cliente Juridico
                    clienteJ.idClienteFK = Convert.ToInt32(linha["idClienteJuridico"]);
                    clienteJ.nomeFantasia = Convert.ToString(linha["nomeFatansia"]);
                    clienteJ.razaoSocial = Convert.ToString(linha["razaoSocial"]);
                    clienteJ.cnpj = Convert.ToString(linha["cnpj"]);
                    clienteJ.inscricaoEstadual = Convert.ToString(linha["inscricaoEstadual"]);
                    clienteJ.idClienteFK = Convert.ToInt32(linha["idCliente"]);
                    //cliente
                    clienteJ.idCliente = Convert.ToInt32(linha["idCliente"]);
                    clienteJ.rua = Convert.ToString(linha["rua"]);
                    clienteJ.numero = Convert.ToString(linha["numero"]);
                    clienteJ.bairro = Convert.ToString(linha["bairro"]);
                    clienteJ.cidade = Convert.ToString(linha["cidade"]);
                    clienteJ.estado = Convert.ToString(linha["estado"]);
                    clienteJ.telefone = Convert.ToString(linha["telefone"]);
                    clienteJ.celular = Convert.ToString(linha["celular"]);
                    clienteJ.email = Convert.ToString(linha["email"]);
                    clienteJ.cep = Convert.ToString(linha["cep"]);
                    clienteJ.descricao = Convert.ToString(linha["descricao"]);
                    clienteJ.tipoCliente = Convert.ToString(linha["tipocliente"]);

                    //adiciona a coleção
                    clienteJuridicoColecao.Add(clienteJ);
                }

                return clienteJuridicoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar a Cliente por Código. \nDetalhes: " + exception.Message);
            }
        }

//
    }
}
