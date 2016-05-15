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
    public class FornecedorDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Fornecedor fornecedor)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@nomefantasia", fornecedor.nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@razaoSocial", fornecedor.razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@inscrEstadual", fornecedor.inscricaoEstadual);
                acessoDadosSqlServer.AdicionarParametros("@cnpj", fornecedor.cnpj);
                acessoDadosSqlServer.AdicionarParametros("@rua", fornecedor.rua);
                acessoDadosSqlServer.AdicionarParametros("@bairro", fornecedor.bairro);
                acessoDadosSqlServer.AdicionarParametros("@numero", fornecedor.numero);
                acessoDadosSqlServer.AdicionarParametros("@cidade", fornecedor.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", fornecedor.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", fornecedor.cep);
                acessoDadosSqlServer.AdicionarParametros("@telefone", fornecedor.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", fornecedor.celular);
                acessoDadosSqlServer.AdicionarParametros("@email", fornecedor.email);
                acessoDadosSqlServer.AdicionarParametros("@descricao", fornecedor.descricao);

                //executa a manipulção
                string idFornecedor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idFornecedor;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(Fornecedor fornecedor)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idFornecedor", fornecedor.idFornecedor);
                acessoDadosSqlServer.AdicionarParametros("@nomefantasia", fornecedor.nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@razaoSocial", fornecedor.razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@inscrEstadual", fornecedor.inscricaoEstadual);
                acessoDadosSqlServer.AdicionarParametros("@cnpj", fornecedor.cnpj);
                acessoDadosSqlServer.AdicionarParametros("@rua", fornecedor.rua);
                acessoDadosSqlServer.AdicionarParametros("@bairro", fornecedor.bairro);
                acessoDadosSqlServer.AdicionarParametros("@numero", fornecedor.numero);
                acessoDadosSqlServer.AdicionarParametros("@cidade", fornecedor.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", fornecedor.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", fornecedor.cep);
                acessoDadosSqlServer.AdicionarParametros("@telefone", fornecedor.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", fornecedor.celular);
                acessoDadosSqlServer.AdicionarParametros("@email", fornecedor.email);
                acessoDadosSqlServer.AdicionarParametros("@descricao", fornecedor.descricao);

                //executa e manipula
                string idFornecedor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idFornecedor;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Fornecedor fornecedor)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idFornecedor", fornecedor.idFornecedor);
                //chamar a procedure para manipulação
                string idFornecedor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
                return idFornecedor;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public FornecedorColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                FornecedorColecao fornecedorColecao = new FornecedorColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableFornecedor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableFornecedor.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Fornecedor fornecedor = new Fornecedor();
                    //
                    fornecedor.idFornecedor = Convert.ToInt32(linha["IdFornecedor"]);
                    fornecedor.nomeFantasia = Convert.ToString(linha["nomeFantasia"]);
                    fornecedor.razaoSocial = Convert.ToString(linha["razaoSocial"]);
                    fornecedor.cnpj = Convert.ToString(linha["cnpj"]);
                    fornecedor.inscricaoEstadual = Convert.ToString(linha["inscricaoEstadual"]);
                    fornecedor.cep = Convert.ToString(linha["cep"]);
                    fornecedor.rua = Convert.ToString(linha["rua"]);
                    fornecedor.numero = Convert.ToString(linha["numero"]);
                    fornecedor.bairro = Convert.ToString(linha["bairro"]);
                    fornecedor.cidade = Convert.ToString(linha["cidade"]);
                    fornecedor.estado = Convert.ToString(linha["estado"]);
                    fornecedor.telefone = Convert.ToString(linha["telefone"]);
                    fornecedor.celular = Convert.ToString(linha["celular"]);
                    fornecedor.email = Convert.ToString(linha["email"]);
                    fornecedor.descricao = Convert.ToString(linha["descricao"]);

                    //adiciona os dados de cliente na clienteColecao
                    fornecedorColecao.Add(fornecedor);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return fornecedorColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Fornecedor por nome. \nDetalhes: " + exception.Message);
            }

        }

        public FornecedorColecao ConsultaId(int idFornecedor)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                FornecedorColecao fornecedorColecao = new FornecedorColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idFornecedor", idFornecedor);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableFornecedor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "");
                //
                foreach (DataRow linha in dataTableFornecedor.Rows)
                {
                    //
                    Fornecedor fornecedor = new Fornecedor();
                    //
                    fornecedor.idFornecedor = Convert.ToInt32(linha["IdFornecedor"]);
                    fornecedor.nomeFantasia = Convert.ToString(linha["nomeFantasia"]);
                    fornecedor.razaoSocial = Convert.ToString(linha["razaoSocial"]);
                    fornecedor.cnpj = Convert.ToString(linha["cnpj"]);
                    fornecedor.inscricaoEstadual = Convert.ToString(linha["inscricaoEstadual"]);
                    fornecedor.cep = Convert.ToString(linha["cep"]);
                    fornecedor.rua = Convert.ToString(linha["rua"]);
                    fornecedor.numero = Convert.ToString(linha["numero"]);
                    fornecedor.bairro = Convert.ToString(linha["bairro"]);
                    fornecedor.cidade = Convert.ToString(linha["cidade"]);
                    fornecedor.estado = Convert.ToString(linha["estado"]);
                    fornecedor.telefone = Convert.ToString(linha["telefone"]);
                    fornecedor.celular = Convert.ToString(linha["celular"]);
                    fornecedor.email = Convert.ToString(linha["email"]);
                    fornecedor.descricao = Convert.ToString(linha["descricao"]);

                    //adiciona a coleção
                    fornecedorColecao.Add(fornecedor);
                }

                return fornecedorColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Fornecedor por Código. \nDetalhes: " + exception.Message);
            }
        }

//end
    }
}
