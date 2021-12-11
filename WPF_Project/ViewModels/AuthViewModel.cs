using BusinessLogic.Interfaces;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF_Project.Command;
using WPF_Project.Models;

namespace WPF_Project.ViewModels
{
    public class AuthViewModel //: INotifyPropertyChanged
    {
       // private RelayCommand _LoginButtonCommand;
       // public RelayCommand LoginButtonCommand
       // {
       //     get { return _LoginButtonCommand; }
       //     private set { _LoginButtonCommand = value; }
       // }
       // public event PropertyChangedEventHandler PropertyChanged;

       // public void OnPropertyChanged(string property)
       // {
       //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
       // }
       // private string _username;

       // public string Username
       // {
       //     get
       //     {
       //         return _username;
       //     }
       //     set
       //     {
       //         _username = value;
       //         OnPropertyChanged(nameof(Username));
       //     }
       // }

       // private readonly IAuthManager _security;
       //// private readonly IUserInfoManager _userInfoManager;
       // private AuthModel _user;
       // public AuthViewModel(IAuthManager security, AuthModel user)
       // {
       //     this._security = security;
       //     this._user = user;
       //     //this._userInfoManager = userInfoManager;
       //     //_LoginButtonCommand = new RelayCommand(Login, p => true);
       //     //CloseCommand = new RelayCommand(CloseWindow, p => true);
       //     //ExitCommand = new RelayCommand(Exit, p => true);

       // }

       // public void Login(object obj)
       // {
       //     var pwdBox = obj as PasswordBox;

       //     if (_security.Login(Username, pwdBox.Password))
       //     {
       //         _user.Login = Username;
       //         _user.ID_Person = this._security.GetPersonByLogin(_user.Login).ID_Person;
       //         CloseCommand.Execute(CloseHandlerOk);
       //     }
       //     else
       //     {
       //         MessageBox.Show("wrong login or password");
       //     }
       // }
       // public void Exit(object obj = null)
       // {
       //     CloseCommand.Execute(CloseHandlerCancel);
       // }

       // public void CloseWindow(object obj)
       // {
       //     var handler = obj as EventHandler;
       //     if (handler != null) handler.Invoke(this, EventArgs.Empty);
       // }
       // public EventHandler CloseHandlerOk;
       // public EventHandler CloseHandlerCancel;

       // public RelayCommand CloseCommand { get; private set; }
       // public RelayCommand ExitCommand { get; private set; }

    }
}