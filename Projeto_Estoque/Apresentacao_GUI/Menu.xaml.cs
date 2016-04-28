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
        private void btn_VendaProduto_Click(object sender, RoutedEventArgs e)
        {
            VendaProdutos vendaProdutos = new VendaProdutos();
            vendaProdutos.ShowDialog();
        }
 
        private void btn_ItensVendidos_Click(object sender, RoutedEventArgs e)
        {
            ItensVendidos itensVendidos = new ItensVendidos();
            itensVendidos.ShowDialog();
        }

        private void btn_CategoriaProdutos_Click(object sender, RoutedEventArgs e)
        {
            EstoqueCategoria categoriaProduto = new EstoqueCategoria();
            categoriaProduto.ShowDialog();
        }

        private void btn_ComprasProdutos_Click(object sender, RoutedEventArgs e)
        {
            CompraProdutos compraProduto = new CompraProdutos();
            compraProduto.ShowDialog();
        }

        private void btn_produto_Click(object sender, RoutedEventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.ShowDialog();
        }
        //FIM BTNS

        //BTNS INF USUARIO
        //user perfil
        private void btn_userPerfil_Click(object sender, RoutedEventArgs e)
        {
            UserPerfil userPerfil = new UserPerfil();
            userPerfil.ShowDialog();
        }

        private void btn_userPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            btn_userPerfil.Opacity = 1;
        }

        private void btn_userPerfil_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_userPerfil.Opacity = 0.7;
        }

        //user config
        private void btn_userConfig_Click(object sender, RoutedEventArgs e)
        {
            UserConfig userConfig = new UserConfig();
            userConfig.ShowDialog();
        }

        private void btn_userConfig_MouseMove(object sender, MouseEventArgs e)
        {
            btn_userConfig.Opacity = 1;
        }

        private void btn_userConfig_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_userConfig.Opacity = 0.7;
        }

        //user opção
        private void btn_userOpcao_Click(object sender, RoutedEventArgs e)
        {
            UserOpcao userOpcao = new UserOpcao();
            userOpcao.ShowDialog();
        }

        private void btn_userOpcao_MouseMove(object sender, MouseEventArgs e)
        {
            btn_userOpcao.Opacity = 1;
        }

        private void btn_userOpcao_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_userOpcao.Opacity = 0.7;
        }
        //FIM BTNS INF USUARIO



    }
}
