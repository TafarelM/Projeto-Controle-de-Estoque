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
    /// Interaction logic for Produtos.xaml
    /// </summary>
    public partial class Produtos : Window
    {
        public Produtos()
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
        //fim CONFIG JANELA

    }
}
