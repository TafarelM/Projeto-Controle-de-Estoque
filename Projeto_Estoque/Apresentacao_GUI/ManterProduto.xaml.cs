using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

//add
using Negocios_BLL;
using ObjetoTransferencia_DTO;


namespace Apresentacao_GUI
{
    /// <summary>
    /// Interaction logic for ManterProduto.xaml
    /// </summary>
    public partial class ManterProduto : Window
    {
        public ManterProduto()
        {
            InitializeComponent();
        }

        //CONFIG DA JANELA
        //para pode arrastar a janela
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        //close
        private void btn_close_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_close.Opacity = 0.7;
        }
        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_close.Opacity = 1;
        }
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //minimizar
        private void btn_minimizer_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_minimizer.Opacity = 0.7;
        }
        private void btn_minimizer_MouseMove(object sender, MouseEventArgs e)
        {
            btn_minimizer.Opacity = 1;
        }
        private void btn_minimizer_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        //FIM CONFIG JANELA

        //BTNS
        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();

            produto.idProduto = int.Parse(txt_idProduto.Text);
            produto.nome = txt_nome.Text;
            produto.valorPago = float.Parse(txt_valorPago.Text);
            produto.valorVenda = float.Parse(txt_valorVenda.Text);
            produto.qtd = int.Parse(txt_qtd.Text);
            produto.descricao = txt_descricao.Text;
            produto.idUnidaMedida = int.Parse(txt_unidadeMedida.Text);
            produto.idCategoria = int.Parse(txt_categoria.Text);
            produto.idSubCategoria = int.Parse(txt_subCategoria.Text);

            ProdutoBLL produtoBLL = new ProdutoBLL();

        }

        private void btn_limpar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //FIM BTNS




    }
}
