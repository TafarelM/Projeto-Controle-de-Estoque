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
    /// Interaction logic for ConsultarProdutos.xaml
    /// </summary>
    public partial class ConsultarProdutos : Window
    {
        public ConsultarProdutos()
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


    }
}
