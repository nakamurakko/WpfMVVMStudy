using SampleModule.DataTypes;
using System.Windows;

namespace WpfCodeBehind.Views;

/// <summary>
/// Interaction logic for UserDetailWindow.xaml
/// </summary>
public partial class UserDetailWindow : Window
{
    public UserDetailWindow()
    {
        this.InitializeComponent();
    }

    /// <summary>
    /// ユーザー情報を設定する。
    /// </summary>
    /// <param name="user">ユーザー情報。</param>
    public void SetUser(User user)
    {
        this.UserIdTextBlock.Text = user.Id.ToString();
        this.UserNameTextBlock.Text = user.Name;
    }
}
