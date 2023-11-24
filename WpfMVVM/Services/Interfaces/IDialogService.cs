using System.Threading.Tasks;
using System.Windows;

namespace WpfMVVM.Services.Interfaces;

public interface IDialogService
{
    /// <summary>
    /// メッセージダイアログを表示する。
    /// </summary>
    /// <param name="title">タイトル</param>
    /// <param name="message">メッセージ</param>
    /// <param name="accept"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<MessageBoxResult> ShowMesageDialog(string message, string title, MessageBoxButton buttons);
}
