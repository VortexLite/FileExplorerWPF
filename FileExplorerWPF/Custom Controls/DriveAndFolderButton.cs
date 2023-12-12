using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FileExplorerWPF.Custom_Controls
{
    public class DriveAndFolderButton : RadioButton
    {
        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(DriveAndFolderButton));

        public ICommand UnPinCommand
        {
            get { return (ICommand)GetValue(UnPinCommandProperty); }
            set { SetValue(UnPinCommandProperty, value);}
        }

        public static readonly DependencyProperty UnPinCommandProperty =
            DependencyProperty.Register("UnPinCommand", typeof(ICommand), typeof(DriveAndFolderButton));
    }
}
