// Updated by XamlIntelliSenseFileGenerator 7/1/2023 10:36:27 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C58FF23F94153A856FB1CACA7DAEFD1CA7FD91B376C351B133D45995A7123020"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FileExplorerWPF;
using FileExplorerWPF.Custom_Controls;
using FileExplorerWPF.Properties;
using FileExplorerWPF.ViewModel;
using FontAwesome.WPF;
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


namespace FileExplorerWPF
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TitleBarGrid;

#line default
#line hidden


#line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;

#line default
#line hidden


#line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizedButton;

#line default
#line hidden


#line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;

#line default
#line hidden


#line 121 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush ImageBrush;

#line default
#line hidden


#line 390 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ToogleExpandCollapseSubMenu;

#line default
#line hidden


#line 404 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;

#line default
#line hidden


#line 433 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl FileOperationPanel;

#line default
#line hidden


#line 509 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Addressbar;

#line default
#line hidden


#line 521 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewControl;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FileExplorerWPF;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler)
        {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.MainWindowF = ((FileExplorerWPF.MainWindow)(target));

#line 17 "..\..\MainWindow.xaml"
                    this.MainWindowF.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.TitleBarGrid = ((System.Windows.Controls.Grid)(target));
                    return;
                case 3:
                    this.MinimizeButton = ((System.Windows.Controls.Button)(target));

#line 74 "..\..\MainWindow.xaml"
                    this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.MaximizedButton = ((System.Windows.Controls.Button)(target));

#line 79 "..\..\MainWindow.xaml"
                    this.MaximizedButton.Click += new System.Windows.RoutedEventHandler(this.MaximizedButton_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.CloseButton = ((System.Windows.Controls.Button)(target));

#line 84 "..\..\MainWindow.xaml"
                    this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.ImageBrush = ((System.Windows.Media.ImageBrush)(target));
                    return;
                case 7:
                    this.ToogleExpandCollapseSubMenu = ((System.Windows.Controls.Primitives.ToggleButton)(target));
                    return;
                case 8:
                    this.SearchBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:

#line 415 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Primitives.ToggleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.FileOperationPanel = ((System.Windows.Controls.ItemsControl)(target));
                    return;
                case 11:
                    this.Addressbar = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 12:
                    this.ListViewControl = ((System.Windows.Controls.ListView)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window MainWindowF;
    }
}

