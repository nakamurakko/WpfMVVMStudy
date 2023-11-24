using System.Threading.Tasks;
using System.Windows;
using WpfMVVM.Services.Interfaces;

namespace WpfMVVM.Services;

public sealed class DialogService : IDialogService
{
    public Task<MessageBoxResult> ShowMesageDialog(string message, string title, MessageBoxButton buttons)
    {
        return Task.Run(() =>
        {
            return MessageBox.Show(message, title, buttons);
        });
    }
}
