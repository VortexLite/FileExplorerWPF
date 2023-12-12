using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileExplorerWPF.Commands
{
    public class RelayCommand:ICommand
    {
        private Action<object> exeute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested += value;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            exeute(parameter);
        }

        public RelayCommand(Action<object> exeute, Func<object, bool> canExecute = null)
        {
            this.exeute = exeute;
            this.canExecute = canExecute;
        }
    }
}
