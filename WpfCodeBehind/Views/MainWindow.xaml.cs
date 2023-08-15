using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfCodeBehind.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// ユーザー一覧。
    /// </summary>
    private List<User> Users { get; set; } = new List<User>();

    /// <summary>
    /// コンストラクター。
    /// </summary>
    public MainWindow()
    {
        this.InitializeComponent();

        foreach (User user in SampleModel.GetUsers())
        {
            this.Users.Add(user);
        }

        this.UserListView.ItemsSource = Users;
    }

    /// <summary>
    /// ユーザー情報取得ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト。</param>
    /// <param name="e">イベントデータ。</param>
    private void GetUserButton_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(this.RequestIdTextBox.Text, out int i) && SampleModel.TryGetUser(int.Parse(this.RequestIdTextBox.Text), out User user))
        {
            this.UserNameTextBlock.Text = user.Name;
        }
        else
        {
            this.UserNameTextBlock.Text = "";
            MessageBox.Show("対象データはありません。", "Notification");
        }
    }

    /// <summary>
    /// リストボックスのアイテムの MouseDown イベント。
    /// ユーザー詳細情報を表示する。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト。</param>
    /// <param name="e">イベントデータ。</param>
    private void UserItemGrid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        User user = (sender as Grid).DataContext as User;

        if (user != null)
        {
            UserDetailWindow userDetailWindow = new UserDetailWindow();
            userDetailWindow.SetUser(user);

            userDetailWindow.ShowDialog();
        }
    }
}
