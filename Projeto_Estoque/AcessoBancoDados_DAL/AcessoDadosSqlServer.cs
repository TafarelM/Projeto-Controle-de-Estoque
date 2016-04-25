using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace que contém as classes que manipulam dados
using System.Data;
using System.Data.SqlClient;
//para usar a string de conexão da propriedades
using AcessoBancoDados_DAL.Properties;


namespace AcessoBancoDados_DAL
{
    public class AcessoDadosSqlServer
    {
        //CRIAR A CONEXÃO
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //PARÂMETRO QUE VÃO PARA O BANCO
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }



        //PERSISTÊNCIA - INSERIR, ALTERAR, EXLUCIR
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            //trantando erro
            try
            {
                //CRIA A CONEXÃO
                SqlConnection sqlConnection = CriarConexao();
                //ABRIR A CONEXÃO
                sqlConnection.Open();
                //CRIAR O COMANDO QUE VAI LEVAR A INFORMAÇÃO PARA O BANCO
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //COLOCA AS COISAS DENTRO DO COMANDO(dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //em segundos

                //ADICIONAR OS PARÂMETROS NO COMANDO
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //EXECUTA O COMANDO, OU SEJA, MANDA O COMANDO IR ATÉ O BANCO DE DADOS
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //mostrar o erro
                throw new Exception(ex.Message);
            }
        }



        //CONSULTAR REGISTRO DO BANCO DE DADOS
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            //trantamento de exeçoes
            try
            {
                //CRIA A CONEXÃO
                SqlConnection sqlConnection = CriarConexao();
                //ABRIR A CONEXÃO
                sqlConnection.Open();
                //CRIAR O COMANDO QUE VAI LEVAR A INFORMAÇÃO PARA O BANCO
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //COLOCA AS COISAS DENTRO DO COMANDO(dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //em segundos

                //ADICIONAR OS PARÂMETROS NO COMANDO
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //CRIAR UM ADPATADOR
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = tabela de dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                //mostra o erro
                throw new Exception(ex.Message);
            }
        }
    }
}