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
    public class ProdutoDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Produto produto)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@nome", produto.nome);
                acessoDadosSqlServer.AdicionarParametros("@valorPago", produto.valorPago);
                acessoDadosSqlServer.AdicionarParametros("@valorVenda", produto.valorVenda);
                acessoDadosSqlServer.AdicionarParametros("@quantidade", produto.quantidade);
                acessoDadosSqlServer.AdicionarParametros("@descricao", produto.descricao);
                acessoDadosSqlServer.AdicionarParametros("@idUnidadeMedida", produto.idUnidaMedida);
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", produto.idCategoria);
                acessoDadosSqlServer.AdicionarParametros("@idSubcategoria", produto.idSubcategoria);

                //executa a manipulção
                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "insert into produto (nome, pro_valorPago, valorVenda, quantidade, descricao, idUnidadeMedida, idCategoria, idSubcategoria)values (@nome, @valorPago, @valorVenda, @quantidade, @descricao, @idUnidadeMedida, @idCategoria, @idSubcategoria); select @IDENTITY").ToString();
                return idProduto;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(Produto produto)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idProduto", produto.idProduto);
                acessoDadosSqlServer.AdicionarParametros("@nome", produto.nome);
                acessoDadosSqlServer.AdicionarParametros("@valorPago", produto.valorPago);
                acessoDadosSqlServer.AdicionarParametros("@valorVenda", produto.valorVenda);
                acessoDadosSqlServer.AdicionarParametros("@quantidade", produto.quantidade);
                acessoDadosSqlServer.AdicionarParametros("@descricao", produto.descricao);
                acessoDadosSqlServer.AdicionarParametros("@idUnidadeMedida", produto.idUnidaMedida);
                acessoDadosSqlServer.AdicionarParametros("@idCategoria", produto.idCategoria);
                acessoDadosSqlServer.AdicionarParametros("@idSubcategoria", produto.idSubcategoria);
                //executa e manipula
                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE Produto SET nome = (@nome), descricao = (@descricao), valorPago = (@valorPago), valorVenda = (@valorVenda), quantidade = (@quantidade), idUnidadeMedida = (@idUnidadeMedida), idCategoria = (@idCategoria), " +
                "idSubcategoria = (@idSubcategoria) WHERE idProduto = (@idProduto)").ToString();
                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Produto produto)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idProduto", produto.idProduto);
                //chamar a procedure para manipulação
                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "delete from produto where idProduto = @idProduto").ToString();
                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ProdutoColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ProdutoColecao produtoColecao = new ProdutoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT produto.idProduto, produto.nome, produto.valorPago, produto.valorVenda, produto.quantidade,  produto.descricao, unidadeMedida.nome, categoria.nome, subcategoria.nome FROM produto INNER JOIN unidadeMedida ON produto.idUnidadeMedida = unidadeMedida.idUnidadeMedida INNER JOIN categoria ON produto.idCategoria = categoria.idCategoria INNER JOIN subcategoria ON produto.idSubcategoria = subcategoria.idSubcategoria WHERE produto.nome like '%' + @Nome + '%'");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Produto produto = new Produto();
                    //
                    produto.idProduto = Convert.ToInt32(linha["IdProduto"]);
                    produto.nome = Convert.ToString(linha["nome"]);
                    produto.valorPago = Convert.ToDecimal(linha["valorPago"]);
                    produto.valorVenda = Convert.ToDecimal(linha["valorVenda"]);
                    produto.quantidade = Convert.ToInt32(linha["quantidade"]);
                    produto.descricao = Convert.ToString(linha["descricao"]);
                    produto.idUnidaMedida = Convert.ToInt32(linha["idUnidadeMedida"]);
                    produto.idCategoria = Convert.ToInt32(linha["idCategoria"]);
                    produto.idSubcategoria = Convert.ToInt32(linha["idSubcategoria"]);

                    //adiciona os dados de cliente na clienteColecao
                    produtoColecao.Add(produto);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return produtoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Produto por nome. \nDetalhes: " + exception.Message);
            }

        }

        public ProdutoColecao ConsultaId(int idProduto)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                ProdutoColecao produtoColecao = new ProdutoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idProduto", idProduto);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM produto WHERE (idProduto)");
                //
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //
                    Produto produto = new Produto();

                    produto.idProduto = Convert.ToInt32(linha["IdProduto"]);
                    produto.nome = Convert.ToString(linha["nome"]);
                    produto.valorPago = Convert.ToDecimal(linha["valorPago"]);
                    produto.valorVenda = Convert.ToDecimal(linha["valorVenda"]);
                    produto.quantidade = Convert.ToInt32(linha["quantidade"]);
                    produto.descricao = Convert.ToString(linha["descricao"]);
                    produto.idUnidaMedida = Convert.ToInt32(linha["idUnidadeMedida"]);
                    produto.idCategoria = Convert.ToInt32(linha["idCategoria"]);
                    produto.idSubcategoria = Convert.ToInt32(linha["idSubcategoria"]);

                    //adiciona a coleção
                    produtoColecao.Add(produto);
                }

                return produtoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Produto por Código. \nDetalhes: " + exception.Message);
            }
        }

//end
    }
}
