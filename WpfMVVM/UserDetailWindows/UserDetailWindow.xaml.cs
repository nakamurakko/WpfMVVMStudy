using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMVVM.Services;

namespace WpfMVVM.UserDetailWindows;

/// <summary>
/// ユーザー詳細画面。
/// </summary>
public partial class UserDetailWindow : Window
{
    public UserDetailWindow()
    {
        this.InitializeComponent();

        this.DataContext = AppSharedServices.Services.GetService<UserDetailWindowViewModel>();
    }
}
