﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Project.ViewModels;

namespace WPF_Project.Command
{
    class LoginCommand : ICommand
    {
        private Action<object> execute;

        private Predicate<object> canExecute;

        private event EventHandler CanExecuteChangedInternal;
        //public event EventHandler CanExecuteChanged;

        private AuthViewModel _lvm;

        public LoginCommand(AuthViewModel lvm)
        {
            _lvm = lvm;
        }

        //public RelayCommand(Action<object> execute) : this(execute, DefaultCanExecute) { }

        //public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        //{
        //    if (execute == null)
        //    {
        //        throw new ArgumentNullException("execute");
        //    }

        //    if (canExecute == null)
        //    {
        //        throw new ArgumentNullException("canExecute");
        //    }

        //    this.execute = execute;
        //    this.canExecute = canExecute;
        //}

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
                this.CanExecuteChangedInternal += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
                this.CanExecuteChangedInternal -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute != null && this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        public void OnCanExecuteChanged()
        {
            EventHandler handler = this.CanExecuteChangedInternal;
            if (handler != null)
            {
                handler.Invoke(this, EventArgs.Empty);
            }
        }

        public void Destroy()
        {
            this.canExecute = _ => false;
            this.execute = _ => { return; };
        }

        private static bool DefaultCanExecute(object parameter)
        {
            return true;
        }
    }
}