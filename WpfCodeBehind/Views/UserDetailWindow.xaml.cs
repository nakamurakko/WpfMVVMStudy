using SampleModule.DataTypes;
using System.Windows;

namespace WpfCodeBehind.Views
{
    /// <summary>
    /// Interaction logic for UserDetailWindow.xaml
    /// </summary>
    public partial class UserDetailWindow : Window
    {
        public UserDetailWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ユーザー情報を設定する。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        public void SetUser(User user)
        {
            UserIdTextBlock.Text = user.Id.ToString();
            UserNameTextBlock.Text = user.Name;
        }
    }
}
