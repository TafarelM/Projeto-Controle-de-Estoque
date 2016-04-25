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
    /// Interaction logic for VendaProdutos.xaml
    /// </summary>
    public partial class VendaProdutos : Window
    {
        public VendaProdutos()
        {
            InitializeComponent();
        }

        //para pode arrastar a janela
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

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
    }
}
