using Prism.Ioc;
using PrismNotification.Dialogs;
using System.Windows;
using WpfMVVM.UserDetailDialogs;
using WpfMVVM.Views;

namespace WpfMVVM;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override Window CreateShell()
    {
        return this.Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // https://prismlibrary.com/docs/wpf/dialog-service.html
        containerRegistry.RegisterDialog<UserDetailDialog, UserDetailDialogViewModel>();

        NotificationDialogService.RegisterDialog(containerRegistry);
    }
}
