﻿#pragma checksum "..\..\Menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "99EDC14A5AC51D38D33FF5F4A91EA8C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Apresentacao_GUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Apresentacao_GUI {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_principal;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle cabeca_janela;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_close;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_minimizar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Dashbord;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle DashBoard;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Dashboard_title;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_title_dashboard;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_VendaProduto;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ItensVendidos;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CategoriaProduto;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CompraProdutos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Apresentacao_GUI;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\Menu.xaml"
            ((Apresentacao_GUI.Menu)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid_principal = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.cabeca_janela = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.img_close = ((System.Windows.Controls.Image)(target));
            
            #line 15 "..\..\Menu.xaml"
            this.img_close.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.image_close_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\Menu.xaml"
            this.img_close.MouseLeave += new System.Windows.Input.MouseEventHandler(this.img_close_MouseLeave);
            
            #line default
            #line hidden
            
            #line 15 "..\..\Menu.xaml"
            this.img_close.MouseMove += new System.Windows.Input.MouseEventHandler(this.img_close_MouseMove);
            
            #line default
            #line hidden
            return;
            case 5:
            this.img_minimizar = ((System.Windows.Controls.Image)(target));
            
            #line 16 "..\..\Menu.xaml"
            this.img_minimizar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.image1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 16 "..\..\Menu.xaml"
            this.img_minimizar.MouseLeave += new System.Windows.Input.MouseEventHandler(this.imageMinimizar_MouseLeave);
            
            #line default
            #line hidden
            
            #line 16 "..\..\Menu.xaml"
            this.img_minimizar.MouseMove += new System.Windows.Input.MouseEventHandler(this.img_minimizar_MouseMove);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Dashbord = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.DashBoard = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.Dashboard_title = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.lbl_title_dashboard = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btn_VendaProduto = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Menu.xaml"
            this.btn_VendaProduto.Click += new System.Windows.RoutedEventHandler(this.btn_VendaProduto_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_ItensVendidos = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Menu.xaml"
            this.btn_ItensVendidos.Click += new System.Windows.RoutedEventHandler(this.btn_ItensVendidos_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_CategoriaProduto = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Menu.xaml"
            this.btn_CategoriaProduto.Click += new System.Windows.RoutedEventHandler(this.btn_CategoriaProduto_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_CompraProdutos = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Menu.xaml"
            this.btn_CompraProdutos.Click += new System.Windows.RoutedEventHandler(this.btn_CompraProdutos_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

