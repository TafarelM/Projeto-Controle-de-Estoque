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
    public partial class FrmConsultarCategoria : Form
    {
        public FrmConsultarCategoria()
        {
            InitializeComponent();
            //para não gerar colunas automaticas no dataGrid
            dataGridViewCategoria.AutoGenerateColumns = false;
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizarGrid()
        {
            //O METODO É O BOTÃO PESQUISAR
            //  PESQUISAR
            CategoriaBLL categoria = new CategoriaBLL();
            CategoriaColecao categoriaColecao = new CategoriaColecao();


            //PASSA COMO PARAMETRO OQUE FOR DIGITADO NO CAMPO TXTPESQUISAR PARA O METODO CONSULTARNOME E OQUE FOR ENCONTRADO ELE VAI JOGAR NA COLEÇÃO DE CLIENTES
            categoriaColecao = categoria.ConsultarNome(txtPesquisar.Text);

            //CONFIGURANDO O DATAGRID
            //limpando o dataGrid se caso ouver dados
            dataGridViewCategoria.DataSource = null;
            //usando a coleção de cliente como fonte de dados para o dataGrid
            dataGridViewCategoria.DataSource = categoriaColecao;

            //
            dataGridViewCategoria.Update();
            dataGridViewCategoria.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //criei o metodo com o codigo do botão para reutilizar codigo
            AtualizarGrid();
        }

        //INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmManterCategoria frmManterCategoria = new FrmManterCategoria(AcaoNaTela.Inserir, null);
            //pegando o dialogResult
            DialogResult dialogResult = frmManterCategoria.ShowDialog();
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
            if (dataGridViewCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Categoria categoriaSelecionado = (dataGridViewCategoria.SelectedRows[0].DataBoundItem as Categoria);

            FrmManterCategoria frmManterCategoria = new FrmManterCategoria(AcaoNaTela.Alterar, categoriaSelecionado);

            DialogResult dialogResult = frmManterCategoria.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dataGridViewCategoria.SelectedRows.Count == 0)
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
            Categoria categoriaSelecionado = (dataGridViewCategoria.SelectedRows[0].DataBoundItem as Categoria);

            //Instanciar  a regra de negocioas
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            //chamar o metodo excluir e guarda na variavel retorno
            string retorno = categoriaBLL.Excluir(categoriaSelecionado);

            //verificar se a exlcusão funciono
            //se o retorno for numero é porque deu certo, senão deu erro
            try
            {
                //excluido com sucesso
                int idCategoria = Convert.ToInt32(retorno);
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
            if (dataGridViewCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Categoria categoriaSelecionado = (dataGridViewCategoria.SelectedRows[0].DataBoundItem as Categoria);

            FrmManterCategoria frmManterCategoria = new FrmManterCategoria(AcaoNaTela.Consultar, categoriaSelecionado);
            frmManterCategoria.ShowDialog();
        }
        
        //SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

//END
    }
}
