using KeyPassWallet.MVVM.ViewModels;
using KeyPassWallet.MVVM.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using KeyPassWallet.Interfaces;
using KeyPassWallet.Services;

namespace KeyPassWallet
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static IServiceProvider ServiceProvider { get; private set; }

		public App()
		{
			var serviceCollection = new ServiceCollection();
			ConfigureServices(serviceCollection);

			ServiceProvider = serviceCollection.BuildServiceProvider();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			var windowService = ServiceProvider.GetRequiredService<IWindowService>();
			var mainWindowViewModel = ServiceProvider.GetRequiredService<MainWindowViewModel>();
			windowService.ShowWindow(mainWindowViewModel);
		}

		private void ConfigureServices(IServiceCollection services)
		{
			// Configure Logging
			services.AddLogging();

			// Register Services
			services.AddTransient<IWindowService, WindowService>();

			// Register ViewModels
			services.AddTransient<MainWindowViewModel>();
			services.AddTransient<WalletExplorerViewModel>();
			services.AddTransient<WalletCreateViewModel>();

			// Register Views
			services.AddTransient<MainWindowView>();
			services.AddTransient<WalletExplorerView>();
			services.AddTransient<WalletCreateView>();
		}
	}

}
