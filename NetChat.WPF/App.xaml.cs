using System;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NetChat.WPF.Startup;

namespace NetChat.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public static bool isDesignMode { get; set; } = true;
        public static string currentDirectoryPath => isDesignMode ? GetSourceCodePath() : Environment.CurrentDirectory;
        private IHost? _host;
        public IHost host => _host ??= Program
            .CreateHostBuilder(Environment.GetCommandLineArgs())
            .Build();
        protected override async void OnStartup(StartupEventArgs e)
        {
            isDesignMode = false;
            base.OnStartup(e);
            await host.StartAsync().ConfigureAwait(false);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            await host.StopAsync().ConfigureAwait(false);
        }
        public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {

        }
        public static string GetSourceCodePath([CallerFilePath] string path = null) => path;
    }
}
