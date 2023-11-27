using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMVVM.Services.Interfaces;

/// <summary>
/// ダイアログサービス用インターフェイス。
/// </summary>
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

    /// <summary>
    /// Window を表示する。
    /// </summary>
    /// <typeparam name="T">Window クラスを継承したクラス。</typeparam>
    /// <param name="viewModel">ViewModel インスタンス。</param>
    void ShowDialog<T>(ObservableObject viewModel) where T : Window, new();
}
