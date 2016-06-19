using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//add
using Negocios_BLL;
using ObjetoTransferencia_DTO;

namespace Apresentacao_ViewForms
{
    public partial class FrmConsultarProduto : Form
    {
        public FrmConsultarProduto()
        {
            InitializeComponent();
            //para não gerar colunas automaticas no dataGrid
            dataGridViewProduto.AutoGenerateColumns = false;
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizarGrid()
        {
            //O METODO É O BOTÃO PESQUISAR
            //  PESQUISAR
            ProdutoBLL produtoBLL = new ProdutoBLL();
            ProdutoColecao produtoColecao = new ProdutoColecao();


            //PASSA COMO PARAMETRO OQUE FOR DIGITADO NO CAMPO TXTPESQUISAR PARA O METODO CONSULTARNOME E OQUE FOR ENCONTRADO ELE VAI JOGAR NA COLEÇÃO DE CLIENTES
            produtoColecao = produtoBLL.ConsultarNome(txtPesquisar.Text);

            //CONFIGURANDO O DATAGRID
            //limpando o dataGrid se caso ouver dados
            dataGridViewProduto.DataSource = null;
            //usando a coleção de cliente como fonte de dados para o dataGrid
            dataGridViewProduto.DataSource = produtoColecao;

            //
            dataGridViewProduto.Update();
            dataGridViewProduto.Refresh();
        }

        //PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //criei o metodo com o codigo do botão para reutilizar codigo
            AtualizarGrid();
        }

        //INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmManterProduto frmManterProduto = new FrmManterProduto(AcaoNaTela.Inserir, null);
            //pegando o dialogResult
            DialogResult dialogResult = frmManterProduto.ShowDialog();
            //
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado no grid
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);

            FrmManterProduto frmManterProduto = new FrmManterProduto(AcaoNaTela.Alterar, produtoSelecionado);

            DialogResult dialogResult = frmManterProduto.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }
            //perguntar se ele tem certeza que excluir o registro
            DialogResult resultado = MessageBox.Show("Tem Certeza que deseja excluir esse registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //pegar o Produto selecionado
            Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);

            //Instanciar  a regra de negocioas
            ProdutoBLL produtoBLL = new ProdutoBLL();
            //chamar o metodo excluir e guarda na variavel retorno
            string retorno = produtoBLL.Excluir(produtoSelecionado);

            //verificar se a exlcusão funciono
            //se o retorno for numero é porque deu certo, senão deu erro
            try
            {
                //excluido com sucesso
                int idProduto = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                //se der erro
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado no grid
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);

            FrmManterProduto frmManterProduto = new FrmManterProduto(AcaoNaTela.Consultar, produtoSelecionado);
            frmManterProduto.ShowDialog();
        }

        //SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

//end
    }
}
