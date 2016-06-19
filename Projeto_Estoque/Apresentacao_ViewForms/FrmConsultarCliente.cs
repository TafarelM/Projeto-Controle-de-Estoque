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
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
            //para não gerar colunas automaticas no dataGrid
            dataGridViewCliente.AutoGenerateColumns = false;
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizarGrid()
        {

        }

        //PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        //INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        //ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        //EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        //CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        //SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {

        }

//END
    }
}
