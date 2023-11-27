using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using WpfMVVM.Services.Interfaces;

namespace WpfMVVM.Services;

/// <summary>
/// ダイアログサービス。
/// </summary>
public sealed class DialogService : IDialogService
{
    public Task<MessageBoxResult> ShowMesageDialog(string message, string title, MessageBoxButton buttons)
    {
        return Task.Run(() =>
        {
            return MessageBox.Show(message, title, buttons);
        });
    }

    public void ShowDialog<T>(ObservableObject viewModel) where T : Window, new()
    {
        T window = new T();
        window.DataContext = viewModel;
        window.ShowDialog();
    }
}
