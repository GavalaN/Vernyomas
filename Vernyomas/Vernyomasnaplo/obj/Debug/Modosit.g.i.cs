﻿#pragma checksum "..\..\Modosit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57B9DB00FFAD25DD19D6D46F8E859A5D4EB2620C669A4A7D6B780F7530275FF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Vernyomasnaplo;


namespace Vernyomasnaplo {
    
    
    /// <summary>
    /// Modosit
    /// </summary>
    public partial class Modosit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDatum;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIdo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSzisztoles;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiasztoles;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPulzus;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVissza;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Modosit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOK;
        
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
            System.Uri resourceLocater = new System.Uri("/Vernyomasnaplo;component/modosit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Modosit.xaml"
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
            
            #line 8 "..\..\Modosit.xaml"
            ((Vernyomasnaplo.Modosit)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbDatum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbIdo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbSzisztoles = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbDiasztoles = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbPulzus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnVissza = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Modosit.xaml"
            this.btnVissza.Click += new System.Windows.RoutedEventHandler(this.btnVissza_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Modosit.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.btnOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

