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


namespace Apresentacao_ViewForms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        //CONSUTAR PRODUTO
        private void button2_Click(object sender, EventArgs e)
        {
            //FrmManterProduto frmMantertarProduto = new FrmManterProduto();
            //frmMantertarProduto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmManterCliente frmCliente = new FrmManterCliente();
            frmCliente.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmManterCategoria frmManterCategoria = new FrmManterCategoria(AcaoNaTela.Inserir, null);
            frmManterCategoria.ShowDialog();
        }

        private void btnConsultarCategoria_Click(object sender, EventArgs e)
        {
            FrmConsultarCategoria frmConsultarCategoria = new FrmConsultarCategoria();
            frmConsultarCategoria.ShowDialog();
        }
    }
}
