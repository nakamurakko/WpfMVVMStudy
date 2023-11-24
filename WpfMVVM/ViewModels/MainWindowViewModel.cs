using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.ObjectModel;
using System.Windows;
using WpfMVVM.Services;
using WpfMVVM.Services.Interfaces;
using WpfMVVM.UserDetailDialogs;

namespace WpfMVVM.ViewModels;

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
    private void GetUser()
    {
        if (SampleModel.TryGetUser(this.RequestId, out User user))
        {
            this.User = user;
        }
        else
        {
            this.User = null;

            this._dialogService.ShowMesageDialog("対象データはありません。", "", MessageBoxButton.OK);
            //NotificationDialogService.ShowDialog(
            //    this._dialogService,
            //    "対象データはありません。",
            //    NotificationDialogButtons.Ok,
            //    dialogResult =>
            //    {
            //        switch (dialogResult.Result)
            //        {
            //            case ButtonResult.OK:
            //                // OKの場合の処理。
            //                break;
            //            default:
            //                break;
            //        }
            //    });
        }
    }

    /// <summary>
    /// ユーザー詳細情報表示処理。
    /// </summary>
    [RelayCommand]
    private void ShowUserDetail(User user)
    {
        //DialogParameters parameters = new DialogParameters()
        //{
        //    { nameof(User), user }
        //};

        //this._dialogService.ShowDialog(
        //    nameof(UserDetailDialog),
        //    parameters,
        //    dialogResult =>
        //    {
        //        // UserDetailWindow 表示後の処理。
        //    });
    }
}
