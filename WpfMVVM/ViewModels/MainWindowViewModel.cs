using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using WpfMVVM.Services;
using WpfMVVM.Services.Interfaces;
using WpfMVVM.UserDetailWindows;

namespace WpfMVVM.ViewModels;

/// <summary>
/// ユーザー詳細画面用 ViewModel。
/// </summary>
public sealed partial class MainWindowViewModel : ObservableObject
{
    private IDialogService _dialogService;

    /// <summary>
    /// ユーザー情報。
    /// </summary>
    [ObservableProperty]
    private User _user;

    /// <summary>
    /// 取得したいユーザーのID。
    /// </summary>
    [ObservableProperty]
    private int _requestId;

    /// <summary>
    /// ユーザー一覧。
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<User> _users = new ObservableCollection<User>();

    /// <summary>
    /// コンストラクター。
    /// </summary>
    /// <param name="dialogService">Dialog Service</param>
    /// <remarks>
    /// 
    /// </remarks>
    public MainWindowViewModel()
    {
        this._dialogService = AppSharedServices.Services.GetService<IDialogService>();

        foreach (User user in SampleModel.GetUsers())
        {
            this.Users.Add(user);
        }
    }

    /// <summary>
    /// ユーザー情報取得処理。
    /// </summary>
    [RelayCommand]
    private async Task GetUserAsync()
    {
        if (SampleModel.TryGetUser(this.RequestId, out User user))
        {
            this.User = user;
        }
        else
        {
            this.User = null;

            MessageBoxResult dialogResult = await this._dialogService.ShowMesageDialog("対象データはありません。", "", MessageBoxButton.OK);
            switch (dialogResult)
            {
                case MessageBoxResult.OK:
                    // OKの場合の処理。
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>
    /// ユーザー詳細情報表示処理。
    /// </summary>
    [RelayCommand]
    private void ShowUserDetail(User user)
    {
        UserDetailWindow userDetailWindow = AppSharedServices.Services.GetService<UserDetailWindow>();
        (userDetailWindow.DataContext as UserDetailWindowViewModel).SetUser(user);
        userDetailWindow.ShowDialog();
    }
}
