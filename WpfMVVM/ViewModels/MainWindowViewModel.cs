using Prism.Commands;
using Prism.Mvvm;
using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.ObjectModel;

namespace WpfMVVM.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private User _user;
        /// <summary>
        /// ユーザー情報。
        /// </summary>
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private int _requestId;
        /// <summary>
        /// 取得したいユーザーのID。
        /// </summary>
        public int RequestId
        {
            get => _requestId;
            set => SetProperty(ref _requestId, value);
        }

        /// <summary>
        /// ユーザー一覧。
        /// </summary>
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        /// <summary>
        /// ユーザー情報取得コマンド。
        /// </summary>
        public DelegateCommand GetUserCommand { get; set; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public MainWindowViewModel()
        {
            foreach (var user in SampleModel.GetUsers())
            {
                Users.Add(user);
            }

            GetUserCommand = new DelegateCommand(() => GetUserCommandExecute());
        }

        /// <summary>
        /// ユーザー情報取得処理。
        /// </summary>
        private void GetUserCommandExecute()
        {
            User user;
            if (SampleModel.TryGetUser(RequestId, out user))
            {
                User = user;
            }
            else
            {
                User = null;
            }
        }
    }
}
