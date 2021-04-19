namespace InspectionSequencer.ViewModels
{
    using System;
    using System.Windows.Input;
    class DelegateCommand : ICommand
    {
        

        private Action<object> execute;
        private Func<object, bool> canExecute;

        public DelegateCommand(Action<object> execute) : this(execute,null)
        {

        }

        public DelegateCommand(Action<object> execute, Func<object,bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            //合ってる？
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecute != null){
                return this.canExecute(parameter);
            }
            else
            {
                return true;
            }
        }

        public void Execute(object parameter)
        {
           if(this.execute != null)
            {
                this.execute(parameter);
            }
        }
    }
}
