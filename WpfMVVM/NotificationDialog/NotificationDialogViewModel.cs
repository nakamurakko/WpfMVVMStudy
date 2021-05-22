using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfMVVM.NotificationDialogs
{
    /// <summary>
    /// NotificationDialog 用 ViewModel。
    /// </summary>
    /// <remarks>
    /// https://prismlibrary.com/docs/wpf/dialog-service.html
    /// </remarks>
    public class NotificationDialogViewModel : BindableBase, IDialogAware
    {
        public string Title => "Notification";

        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        private DelegateCommand<string> _closeDialogCommand;
        public DelegateCommand<string> CloseDialogCommand
        {
            get => _closeDialogCommand;
            set => SetProperty(ref _closeDialogCommand, value);
        }

        public event Action<IDialogResult> RequestClose;

        public NotificationDialogViewModel()
        {
            CloseDialogCommand = new DelegateCommand<string>(CloseDialog);
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }

        protected virtual void CloseDialog(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if ("true".Equals(parameter?.ToLower()))
            {
                result = ButtonResult.OK;
            }
            else if ("false".Equals(parameter?.ToLower()))
            {
                result = ButtonResult.Cancel;
            }

            RaiseRequestClose(new DialogResult(result));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>(NotificationDialogParamKey.DialogMessage);
        }
    }
}
