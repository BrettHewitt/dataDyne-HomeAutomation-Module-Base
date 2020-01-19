using System;
using System.Windows.Input;

namespace ModuleBase
{
    public class ModuleActionCommand : ICommand
    {
        private Action _ExecuteAction;
        private Func<bool> _CanExecuteAction = () => true;

        public event EventHandler CanExecuteChanged;

        public Action ExecuteAction
        {
            get
            {
                return _ExecuteAction;
            }
            set
            {
                _ExecuteAction = value;
            }
        }

        public Func<bool> CanExecuteAction
        {
            get
            {
                return _CanExecuteAction;
            }
            set
            {
                _CanExecuteAction = value;

                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteAction();
        }

        public void Execute(object parameter)
        {
             ExecuteAction();
        }

        public void RaiseCanExecuteChangedNotification()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
