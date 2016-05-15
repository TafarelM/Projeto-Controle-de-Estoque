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
    public partial class FrmManterProduto : Form
    {

        //parar poder usar o metodo do clienteCadastrar
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmManterProduto(AcaoNaTela acaoNaTela, Produto produto)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmClienteCadastrar
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                this.Text = "Inserir Produto";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Produto";
                //grava o conteudo no campo da tela
                txtId.Text = produto.idProduto.ToString();
                txtNome.Text = produto.nome;
                txtValorPago.Text = produto.valorPago.ToString();
                txtValorVenda.Text = produto.valorVenda.ToString();
                txtQtd.Text = produto.quantidade.ToString();
                txtDescricao.Text = produto.descricao;

                //testeeeeeeeeeeeeeeeeeeee
                CategoriaBLL bll = new CategoriaBLL();
                //cbCategoria.DataSource = bll.localizar("");
                cbCategoria.DisplayMember = "cat_nome";
                cbCategoria.ValueMember = "cat_cod";


                try
                {
                    //combo da subcategoria
                    SubcategoriaBLL sbll = new SubcategoriaBLL();
                   // cbSubcategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                    cbSubcategoria.DisplayMember = "scat_nome";
                    cbSubcategoria.ValueMember = "scat_cod";
                }
                catch
                {
                    //MessageBox.Show("Cadastre uma categoria");
                }
                //combo und medida
                UnidadeMedidaBLL ubll = new UnidadeMedidaBLL();
                //cbUnidadeMedida.DataSource = ubll.Localizar("");
                cbUnidadeMedida.DisplayMember = "umed_nome";
                cbUnidadeMedida.ValueMember = "umed_cod";


            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Produto";

                //grava o conteudo nos campos da tela
                txtId.Text = produto.idProduto.ToString();
                txtNome.Text = produto.nome;
                txtValorPago.Text = produto.valorPago.ToString();
                txtValorVenda.Text = produto.valorVenda.ToString();
                txtQtd.Text = produto.quantidade.ToString();
                txtDescricao.Text = produto.descricao;

                //testeeeeeeeeeeeeeeeeeeee
                CategoriaBLL bll = new CategoriaBLL();
                //cbCategoria.DataSource = bll.localizar("");
                cbCategoria.DisplayMember = "cat_nome";
                cbCategoria.ValueMember = "cat_cod";


                try
                {
                    //combo da subcategoria
                    SubcategoriaBLL sbll = new SubcategoriaBLL();
                    //.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                    cbSubcategoria.DisplayMember = "scat_nome";
                    cbSubcategoria.ValueMember = "scat_cod";
                }
                catch
                {
                    //MessageBox.Show("Cadastre uma categoria");
                }
                //combo und medida
                UnidadeMedidaBLL ubll = new UnidadeMedidaBLL();
                //cbUnidadeMedida.DataSource = ubll.Localizar("");
                cbUnidadeMedida.DisplayMember = "umed_nome";
                cbUnidadeMedida.ValueMember = "umed_cod";



                //desabilitando os campos da tela
                txtId.Enabled = false;
                txtNome.Enabled = false;


                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fexar";
                btnCancelar.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //SALVAR

            //verifica se é inserção ou alteração
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Produto produto = new Produto();

                produto.nome = txtNome.Text;
                produto.valorPago = Convert.ToDecimal(txtValorPago.Text);
                produto.valorVenda = Convert.ToDecimal(txtValorVenda.Text);
                produto.quantidade = Convert.ToInt32(txtQtd.Text);
                produto.idUnidaMedida = Convert.ToInt32(cbUnidadeMedida.SelectedValue);
                produto.idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                produto.idSubcategoria = Convert.ToInt32(cbSubcategoria.SelectedValue);

                //envia para o metodo tudo q foi colocado na classe cliente
                ProdutoBLL produtoBLL = new ProdutoBLL();
                string retorno = produtoBLL.Inserir(produto);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idProduto.ToString());
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

                Produto produto = new Produto();

                produto.nome = txtNome.Text;
                produto.valorPago = Convert.ToDecimal(txtValorPago.Text);
                produto.valorVenda = Convert.ToDecimal(txtValorVenda.Text);
                produto.quantidade = Convert.ToInt32(txtQtd.Text);
                produto.idUnidaMedida = Convert.ToInt32(cbUnidadeMedida.SelectedValue);
                produto.idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                produto.idSubcategoria = Convert.ToInt32(cbSubcategoria.SelectedValue);

                //envia para o metodo tudo q foi colocado na classe cliente
                ProdutoBLL produtoBLL = new ProdutoBLL();
                string retorno = produtoBLL.Alterar(produto);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idProduto = Convert.ToInt32(retorno);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtQtd.Clear();
            txtDescricao.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //sair
            DialogResult = DialogResult.No;
        }
    }
}
