using CommunityToolkit.Mvvm.ComponentModel;
using SampleModule.DataTypes;

namespace WpfMVVM.UserDetailWindows;

public sealed partial class UserDetailWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "ユーザー詳細画面";

    [ObservableProperty]
    private User _user;

    public UserDetailWindowViewModel()
    {
    }
}
