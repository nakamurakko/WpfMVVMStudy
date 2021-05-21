using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.Generic;
using System.Windows;

namespace WpfCodeBehind.Views
{
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
            InitializeComponent();

            foreach (var user in SampleModel.GetUsers())
            {
                Users.Add(user);
            }

            UserListView.ItemsSource = Users;
        }

        /// <summary>
        /// ユーザー情報取得ボタンクリック。
        /// </summary>
        /// <param name="sender">通知元のオブジェクト。</param>
        /// <param name="e">イベントデータ。</param>
        private void GetUserButton_Click(object sender, RoutedEventArgs e)
        {
            User user;

            if (int.TryParse(RequestIdTextBox.Text, out var i) && SampleModel.TryGetUser(int.Parse(RequestIdTextBox.Text), out user))
            {
                UserNameTextBlock.Text = user.Name;
            }
            else
            {
                UserNameTextBlock.Text = "";
                MessageBox.Show("対象データはありません。", "Notification");
            }
        }
    }
}
