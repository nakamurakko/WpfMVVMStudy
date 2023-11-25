using Microsoft.Extensions.DependencyInjection;
using System;
using WpfMVVM.Services.Interfaces;
using WpfMVVM.UserDetailWindows;
using WpfMVVM.ViewModels;

namespace WpfMVVM.Services;

/// <summary>
/// App 共有サービス。
/// </summary>
/// <remarks>
/// https://learn.microsoft.com/ja-jp/dotnet/communitytoolkit/mvvm/ioc
/// </remarks>
public static class AppSharedServices
{
    /// <summary>
    /// 共有サービス一覧。
    /// </summary>
    public static IServiceProvider Services { get; private set; } = ConfigureServices();

    /// <summary>
    /// サービスを設定する。
    /// </summary>
    private static IServiceProvider ConfigureServices()
    {
        ServiceCollection services = new ServiceCollection();

        services.AddSingleton<IDialogService, DialogService>();
        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<UserDetailWindow>();
        services.AddTransient<UserDetailWindowViewModel>();

        return services.BuildServiceProvider();
    }
}
