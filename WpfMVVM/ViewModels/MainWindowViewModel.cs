using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismNotification.Dialogs;
using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.ObjectModel;
using WpfMVVM.UserDetailDialogs;

namespace WpfMVVM.ViewModels;

public sealed class MainWindowViewModel : BindableBase
{
    private IDialogService _dialogService;

    private User _user;
    /// <summary>
    /// ユーザー情報。
    /// </summary>
    public User User
    {
        get => this._user;
        set => this.SetProperty(ref this._user, value);
    }

    private int _requestId;
    /// <summary>
    /// 取得したいユーザーのID。
    /// </summary>
    public int RequestId
    {
        get => this._requestId;
        set => this.SetProperty(ref this._requestId, value);
    }

    /// <summary>
    /// ユーザー一覧。
    /// </summary>
    public ObservableCollection<User> Users { get; private set; } = new ObservableCollection<User>();

    /// <summary>
    /// ユーザー情報取得コマンド。
    /// </summary>
    public DelegateCommand GetUserCommand { get; private set; }

    /// <summary>
    /// ユーザー情報表示コマンド。
    /// </summary>
    public DelegateCommand<User> ShowUserDetailCommand { get; private set; }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    /// <param name="dialogService">Dialog Service</param>
    /// <remarks>
    /// https://prismlibrary.com/docs/wpf/dialog-service.html#using-the-dialog-service
    /// </remarks>
    public MainWindowViewModel(IDialogService dialogService)
    {
        this._dialogService = dialogService;

        foreach (User user in SampleModel.GetUsers())
        {
            this.Users.Add(user);
        }

        this.GetUserCommand = new DelegateCommand(() => this.GetUserCommandExecute());
        this.ShowUserDetailCommand = new DelegateCommand<User>((user) => this.ShowUserDetailCommandExecute(user));
    }

    /// <summary>
    /// ユーザー情報取得処理。
    /// </summary>
    private void GetUserCommandExecute()
    {
        if (SampleModel.TryGetUser(RequestId, out User user))
        {
            User = user;
        }
        else
        {
            User = null;

            NotificationDialogService.ShowDialog(
                this._dialogService,
                "対象データはありません。",
                NotificationDialogButtons.Ok,
                dialogResult =>
                {
                    switch (dialogResult.Result)
                    {
                        case ButtonResult.OK:
                            // OKの場合の処理。
                            break;
                        default:
                            break;
                    }
                });
        }
    }

    /// <summary>
    /// ユーザー詳細情報表示処理。
    /// </summary>
    private void ShowUserDetailCommandExecute(User user)
    {
        DialogParameters parameters = new DialogParameters()
        {
            { nameof(User), user }
        };

        this._dialogService.ShowDialog(
            nameof(UserDetailDialog),
            parameters,
            dialogResult =>
            {
                // UserDetailWindow 表示後の処理。
            });
    }
}
