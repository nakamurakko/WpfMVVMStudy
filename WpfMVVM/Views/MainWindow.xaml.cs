using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMVVM.Services;
using WpfMVVM.ViewModels;

namespace WpfMVVM.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();

        this.DataContext = AppSharedServices.Services.GetService<MainWindowViewModel>();
    }
}
