﻿#pragma checksum "..\..\InkPadWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42E948F9BE5880AA0F293DB50D3BB7A075D9537A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Canvas;
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


namespace Canvas {
    
    
    /// <summary>
    /// InkPadWindow
    /// </summary>
    public partial class InkPadWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEraser;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackWhite;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackBlack;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFrontWhite;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFrontBlack;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFrontRed;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFrontGreen;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFrontBlue;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\InkPadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas inkCanv;
        
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
            System.Uri resourceLocater = new System.Uri("/Canvas;component/inkpadwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InkPadWindow.xaml"
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
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\InkPadWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEraser = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\InkPadWindow.xaml"
            this.btnEraser.Click += new System.Windows.RoutedEventHandler(this.btnEraser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnBackWhite = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\InkPadWindow.xaml"
            this.btnBackWhite.Click += new System.Windows.RoutedEventHandler(this.btnBackWhite_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBackBlack = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\InkPadWindow.xaml"
            this.btnBackBlack.Click += new System.Windows.RoutedEventHandler(this.btnBackBlack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnFrontWhite = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\InkPadWindow.xaml"
            this.btnFrontWhite.Click += new System.Windows.RoutedEventHandler(this.btnFrontWhite_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnFrontBlack = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\InkPadWindow.xaml"
            this.btnFrontBlack.Click += new System.Windows.RoutedEventHandler(this.btnFrontBlack_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnFrontRed = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\InkPadWindow.xaml"
            this.btnFrontRed.Click += new System.Windows.RoutedEventHandler(this.btnFrontRed_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnFrontGreen = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\InkPadWindow.xaml"
            this.btnFrontGreen.Click += new System.Windows.RoutedEventHandler(this.btnFrontGreen_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnFrontBlue = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\InkPadWindow.xaml"
            this.btnFrontBlue.Click += new System.Windows.RoutedEventHandler(this.btnFrontBlue_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.inkCanv = ((System.Windows.Controls.InkCanvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
