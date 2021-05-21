using Prism.Ioc;
using System.Windows;
using WpfMVVM.Dialogs;
using WpfMVVM.Views;

namespace WpfMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // https://prismlibrary.com/docs/wpf/dialog-service.html
            containerRegistry.RegisterDialog<NotificationDialog, NotificationDialogViewModel>();
        }
    }
}
