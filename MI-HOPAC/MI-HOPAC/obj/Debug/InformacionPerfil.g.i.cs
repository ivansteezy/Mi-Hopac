<<<<<<< HEAD:MI-HOPAC/MI-HOPAC/obj/Debug/InformacionPerfil.g.i.cs
﻿#pragma checksum "..\..\InformacionPerfil.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0713268814B64D6DCD21661A5DFEA07AE20ACDCC0456E531CD137F223067EBFD"
=======
﻿#pragma checksum "..\..\IniciaSesion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E899177FFE95C92EA859A16DBBC1C9F5277CCBB2A80D9CCF47EA205DCFFAEF0"
>>>>>>> TerminarNotas:MI-HOPAC/MI-HOPAC/obj/Debug/IniciaSesion.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MI_HOPAC;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace MI_HOPAC {
    
    
    /// <summary>
    /// InformacionPerfil
    /// </summary>
    public partial class InformacionPerfil : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\InformacionPerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush ProfilePhoto;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\InformacionPerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCedula;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\InformacionPerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UbicacionButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MI-HOPAC;component/informacionperfil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InformacionPerfil.xaml"
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
            this.ProfilePhoto = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 2:
            
            #line 31 "..\..\InformacionPerfil.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCedula = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UbicacionButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\InformacionPerfil.xaml"
            this.UbicacionButton.Click += new System.Windows.RoutedEventHandler(this.UbicacionButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 42 "..\..\InformacionPerfil.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
