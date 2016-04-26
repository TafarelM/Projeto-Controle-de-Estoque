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

namespace Apresentacao_GUI
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
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
            btn_close.Opacity = 0.6;
        }
        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_close.Opacity = 1;
        }
        private void btn_close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        //minimizar
        private void btn_minimizer_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_minimizer.Opacity = 0.6;
        }
        private void btn_minimizer_MouseMove(object sender, MouseEventArgs e)
        {
            btn_minimizer.Opacity = 1;
        }
        private void btn_minimizer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        //config janela

        /*

//fechar
private void image_close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
{
this.Close();
}
private void img_close_MouseLeave(object sender, MouseEventArgs e)
{
img_close.Opacity = 0.6;
}
private void img_close_MouseMove(object sender, MouseEventArgs e)
{
img_close.Opacity = 1;
}

//minimizar
private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
{
this.WindowState = WindowState.Minimized;
}
private void imageMinimizar_MouseLeave(object sender, MouseEventArgs e)
{
img_minimizar.Opacity = 0.6;
}
private void img_minimizar_MouseMove(object sender, MouseEventArgs e)
{
img_minimizar.Opacity = 1;
}
//CONFIG JANELA


//btn VENDA PRODUTO
private void btn_VendaProduto_Click(object sender, RoutedEventArgs e)
{
VendaProdutos vendaProdutos = new VendaProdutos();
vendaProdutos.Show();
}

//btn ITENS VENDIDOS
private void btn_ItensVendidos_Click(object sender, RoutedEventArgs e)
{
ItensVendidos itensVendidos = new ItensVendidos();
itensVendidos.Show();
}

//btn CATEGORIA PRODUTO
private void btn_CategoriaProduto_Click(object sender, RoutedEventArgs e)
{
EstoqueCategoria categoriaProduto = new EstoqueCategoria();
categoriaProduto.Show();
}

//btn COMPRAS PRODUTOS
private void btn_CompraProdutos_Click(object sender, RoutedEventArgs e)
{
CompraProdutos compraProduto = new CompraProdutos();
compraProduto.Show();
}
*/
    }
}
