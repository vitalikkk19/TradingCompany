﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Command
{
    internal class GetListCommand : ICommand
    {
        private SupplyListViewModel slvm;

        public GetListCommand(SupplyListViewModel slvm)
        {
            this.slvm = slvm;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            slvm.GetSupplyList();
        }
    }
}
