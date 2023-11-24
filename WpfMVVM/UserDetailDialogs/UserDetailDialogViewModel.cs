using CommunityToolkit.Mvvm.ComponentModel;
using SampleModule.DataTypes;

namespace WpfMVVM.UserDetailDialogs;

/// <summary>
/// ユーザー詳細画面用 ViewModel。
/// </summary>
public partial class UserDetailDialogViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "ユーザー詳細画面";

    [ObservableProperty]
    private User _user;

    public UserDetailDialogViewModel()
    {
    }

    public bool CanCloseDialog()
    {
        return true;
    }

    public void OnDialogClosed()
    {

    }

    public void OnDialogOpened(/*IDialogParameters parameters*/)
    {
        //User = parameters.GetValue<User>(nameof(User));
    }
}
