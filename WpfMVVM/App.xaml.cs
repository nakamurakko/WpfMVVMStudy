using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WpfMVVM.Services;
using WpfMVVM.Services.Interfaces;

namespace WpfMVVM;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App: Application
{
    /// <summary>
    /// https://learn.microsoft.com/ja-jp/dotnet/communitytoolkit/mvvm/ioc
    /// </summary>
    public IServiceProvider Services { get; private set; }

    public App()
    {
        this.Services = this.ConfigureServices();

        this.InitializeComponent();
    }

    private IServiceProvider ConfigureServices()
    {
        ServiceCollection services = new ServiceCollection();

        services.AddSingleton<IDialogService, DialogService>();

        return services.BuildServiceProvider();
    }
}
