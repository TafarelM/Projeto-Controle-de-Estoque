using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//add
using ObjetoTransferencia_DTO;
using Negocios_BLL;

namespace Apresentacao_ViewForms
{
    public partial class FrmManterCategoria : Form
    {
        //parar poder usar o metodo do clienteCadastrar
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmManterCategoria(AcaoNaTela acaoNaTela, Categoria categoria)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmClienteCadastrar
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                this.Text = "Inserir Categoria";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Categoria";
                //grava o conteudo no campo da tela
                txtId.Text = categoria.idCategoria.ToString();
                txtNome.Text = categoria.nome;
                txtDescricao.Text = categoria.descricao;

                //desabilitando os campos da tela
                txtId.Enabled = false;

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Categoria";

                //grava o conteudo no campo da tela
                txtId.Text = categoria.idCategoria.ToString();
                txtNome.Text = categoria.nome;
                txtDescricao.Text = categoria.descricao;

                //desabilitando os campos da tela
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtDescricao.Enabled = false;

                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
                btnCancelar.Focus();
            }
        }

        //SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se é inserção ou alteração
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Categoria categoria = new Categoria();

                categoria.nome = txtNome.Text;
                categoria.descricao = txtDescricao.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                CategoriaBLL categoriaBLL = new CategoriaBLL();                
                string  retorno = categoriaBLL.Inserir(categoria);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idCategoria.ToString());
                    //
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Inserir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Alterar))
            {
                //ALTERAR

                Categoria categoria = new Categoria();

                categoria.idCategoria = Convert.ToInt32(txtId.Text);
                categoria.nome = txtNome.Text;
                categoria.descricao = txtDescricao.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                CategoriaBLL categoriaBLL = new CategoriaBLL();
                string retorno = categoriaBLL.Alterar(categoria);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro Alterado com Sucesso!. ");
                    //
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Alterar o registro. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }

        }

        //CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
