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
    public partial class FrmManterFornecedor : Form
    {
        //parar poder usar o metodo do clienteCadastrar
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmManterFornecedor(AcaoNaTela acaoNaTela, Fornecedor fornecedor)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmManterCliente
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                this.Text = "Inserir Fornecedor";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Fornecedor";

                //grava o conteudo no campo da tela
                txtId.Text = fornecedor.idFornecedor.ToString();
                txtNomeFantasia.Text = fornecedor.nomeFantasia;
                txtRazaoSocial.Text = fornecedor.razaoSocial;
                txtInscrEstadual.Text = fornecedor.inscricaoEstadual;
                txtCnpj.Text = fornecedor.cnpj;
                txtRua.Text = fornecedor.rua;
                txtBairro.Text = fornecedor.bairro;
                txtNumero.Text = fornecedor.numero;
                txtCidade.Text = fornecedor.cidade;
                txtEstado.Text = fornecedor.estado;
                txtCep.Text = fornecedor.cep;
                txtTelefone.Text = fornecedor.telefone;
                txtCelular.Text = fornecedor.celular;
                txtEmail.Text = fornecedor.email;
                txtDescricao.Text = fornecedor.descricao;

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Fornecedor";

                //grava o conteudo no campo da tela
                txtId.Text = fornecedor.idFornecedor.ToString();
                txtNomeFantasia.Text = fornecedor.nomeFantasia;
                txtRazaoSocial.Text = fornecedor.razaoSocial;
                txtInscrEstadual.Text = fornecedor.inscricaoEstadual;
                txtCnpj.Text = fornecedor.cnpj;
                txtRua.Text = fornecedor.rua;
                txtBairro.Text = fornecedor.bairro;
                txtNumero.Text = fornecedor.numero;
                txtCidade.Text = fornecedor.cidade;
                txtEstado.Text = fornecedor.estado;
                txtCep.Text = fornecedor.cep;
                txtTelefone.Text = fornecedor.telefone;
                txtCelular.Text = fornecedor.celular;
                txtEmail.Text = fornecedor.email;
                txtDescricao.Text = fornecedor.descricao;

                //desabilitando os campos da tela
                txtId.Enabled = false;
                txtNomeFantasia.Enabled = false;
                txtRazaoSocial.Enabled = false;
                txtInscrEstadual.Enabled = false;
                txtCnpj.Enabled = false;
                txtRua.Enabled = false;
                txtBairro.Enabled = false;
                txtNumero.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
                txtCep.Enabled = false;
                txtTelefone.Enabled = false;
                txtCelular.Enabled = false;
                txtEmail.Enabled = false;
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
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.nomeFantasia = txtNomeFantasia.Text;
                fornecedor.razaoSocial = txtRazaoSocial.Text;
                fornecedor.inscricaoEstadual = txtInscrEstadual.Text;
                fornecedor.cnpj = txtCnpj.Text;
                fornecedor.rua = txtRua.Text;
                fornecedor.bairro = txtBairro.Text;
                fornecedor.numero = txtNumero.Text;
                fornecedor.cidade = txtCidade.Text;
                fornecedor.estado = txtEstado.Text;
                fornecedor.cep = txtCep.Text;
                fornecedor.telefone = txtTelefone.Text;
                fornecedor.celular = txtCelular.Text;
                fornecedor.email = txtEmail.Text;
                fornecedor.descricao = txtDescricao.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                FornecedorBLL fornecedorBLL = new FornecedorBLL();
                string retorno = fornecedorBLL.Inserir(fornecedor);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idFornecedor = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idFornecedor.ToString());
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
        }

        //CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
