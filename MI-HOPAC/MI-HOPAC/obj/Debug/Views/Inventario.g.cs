﻿#pragma checksum "..\..\..\Views\Inventario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE83447184BE96F058EBB45847CF8F5CFF8CADAE14CEB03951CD504BDFF4CFBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MI_HOPAC;
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


namespace MI_HOPAC.Views {
    
    
    /// <summary>
    /// Inventario
    /// </summary>
    public partial class Inventario : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\Inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridInventario;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\Inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Mod;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\Inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Agr;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\Inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Eli;
        
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
            System.Uri resourceLocater = new System.Uri("/MI-HOPAC;component/views/inventario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Inventario.xaml"
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
            this.GridInventario = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Mod = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\Inventario.xaml"
            this.Mod.Click += new System.Windows.RoutedEventHandler(this.Mod_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Agr = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Views\Inventario.xaml"
            this.Agr.Click += new System.Windows.RoutedEventHandler(this.Agr_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Eli = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\Inventario.xaml"
            this.Eli.Click += new System.Windows.RoutedEventHandler(this.Eli_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

