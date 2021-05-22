using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using SampleModule.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfMVVM.UserDetailDialogs
{
    /// <summary>
    /// ユーザー詳細画面用 ViewModel。
    /// </summary>
    /// <remarks>
    /// https://prismlibrary.com/docs/wpf/dialog-service.html
    /// </remarks>
    public class UserDetailDialogViewModel : BindableBase, IDialogAware
    {
        public string Title => "ユーザー詳細画面";

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        //private DelegateCommand _closeWindowCommand;
        //public DelegateCommand CloseWindowCommand
        //{
        //    get => _closeWindowCommand;
        //    set => SetProperty(ref _closeWindowCommand, value);
        //}

        public event Action<IDialogResult> RequestClose;

        public UserDetailDialogViewModel()
        {
            //CloseWindowCommand = new DelegateCommand(CloseDialog);
        }

        //public virtual void RaiseRequestClose(IDialogResult dialogResult)
        //{
        //    RequestClose?.Invoke(dialogResult);
        //}

        //protected virtual void CloseDialog()
        //{
        //    RaiseRequestClose(new DialogResult(ButtonResult.OK));
        //}

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            User = parameters.GetValue<User>(nameof(User));
        }
    }
}
