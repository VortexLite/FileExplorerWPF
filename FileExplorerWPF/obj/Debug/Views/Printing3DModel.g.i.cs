﻿#pragma checksum "..\..\..\Views\Printing3DModel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0944107B8143EB8CA39A676675FA8D622B91B65F47F39A2F8EAE48E3E889DFA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FileExplorerWPF.Custom_Controls;
using FileExplorerWPF.Properties;
using FileExplorerWPF.ViewModel;
using FileExplorerWPF.Views;
using HelixToolkit.Wpf;
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


namespace FileExplorerWPF.Views {
    
    
    /// <summary>
    /// Printing3DModel
    /// </summary>
    public partial class Printing3DModel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizedButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameModel;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Printer;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountModel;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Scale;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Materilal;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Printing;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HelixToolkit.Wpf.HelixViewport3D viewport;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\Views\Printing3DModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgBar;
        
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
            System.Uri resourceLocater = new System.Uri("/FileExplorerWPF;component/views/printing3dmodel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Printing3DModel.xaml"
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
            
            #line 19 "..\..\..\Views\Printing3DModel.xaml"
            ((FileExplorerWPF.Views.Printing3DModel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Views\Printing3DModel.xaml"
            ((FileExplorerWPF.Views.Printing3DModel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Views\Printing3DModel.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MaximizedButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\Printing3DModel.xaml"
            this.MaximizedButton.Click += new System.Windows.RoutedEventHandler(this.MaximizedButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Views\Printing3DModel.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NameModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Printer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.CountModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Scale = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Materilal = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.Printing = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\..\Views\Printing3DModel.xaml"
            this.Printing.Click += new System.Windows.RoutedEventHandler(this.Printing_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 157 "..\..\..\Views\Printing3DModel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.viewport = ((HelixToolkit.Wpf.HelixViewport3D)(target));
            
            #line 166 "..\..\..\Views\Printing3DModel.xaml"
            this.viewport.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Viewport_MouseDown);
            
            #line default
            #line hidden
            
            #line 167 "..\..\..\Views\Printing3DModel.xaml"
            this.viewport.MouseMove += new System.Windows.Input.MouseEventHandler(this.Viewport_MouseMove);
            
            #line default
            #line hidden
            
            #line 168 "..\..\..\Views\Printing3DModel.xaml"
            this.viewport.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Viewport_MouseUp);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ProgBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
