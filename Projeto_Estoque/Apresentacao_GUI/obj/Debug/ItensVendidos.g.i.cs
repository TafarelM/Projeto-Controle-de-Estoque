﻿#pragma checksum "..\..\ItensVendidos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0891B5CD4EFE4BC34ED36569C3993BB1"
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
    /// ItensVendidos
    /// </summary>
    public partial class ItensVendidos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_main;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_cabecalho_window;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_window;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid btn_window;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_minimizer;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_corpo_window;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ItensVendidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_corpo_window;
        
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
            System.Uri resourceLocater = new System.Uri("/Apresentacao_GUI;component/itensvendidos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ItensVendidos.xaml"
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
            
            #line 8 "..\..\ItensVendidos.xaml"
            ((Apresentacao_GUI.ItensVendidos)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid_main = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.border_cabecalho_window = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.grid_window = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.btn_window = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ItensVendidos.xaml"
            this.btn_close.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_close_MouseLeave);
            
            #line default
            #line hidden
            
            #line 18 "..\..\ItensVendidos.xaml"
            this.btn_close.MouseMove += new System.Windows.Input.MouseEventHandler(this.btn_close_MouseMove);
            
            #line default
            #line hidden
            
            #line 18 "..\..\ItensVendidos.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_minimizer = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\ItensVendidos.xaml"
            this.btn_minimizer.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_minimizer_MouseLeave);
            
            #line default
            #line hidden
            
            #line 30 "..\..\ItensVendidos.xaml"
            this.btn_minimizer.MouseMove += new System.Windows.Input.MouseEventHandler(this.btn_minimizer_MouseMove);
            
            #line default
            #line hidden
            
            #line 30 "..\..\ItensVendidos.xaml"
            this.btn_minimizer.Click += new System.Windows.RoutedEventHandler(this.btn_minimizer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.border_corpo_window = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.grid_corpo_window = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

