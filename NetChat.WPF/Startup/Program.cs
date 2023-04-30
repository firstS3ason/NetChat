

using Microsoft.Extensions.Hosting;
using System;

namespace NetChat.WPF.Startup
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder()
            .UseContentRoot(App.currentDirectoryPath)
            .ConfigureServices(App.ConfigureServices);


    }
}
