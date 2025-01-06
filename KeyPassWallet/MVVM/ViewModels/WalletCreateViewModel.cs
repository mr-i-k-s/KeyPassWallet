using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using KeyPassWallet.Messages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MVVM.ViewModels;

namespace KeyPassWallet.MVVM.ViewModels
{
	public partial class WalletCreateViewModel : ViewModelBase
	{
        #region Variables

        #endregion Variables

        #region Properties

        #endregion Properties

        #region Constructors

        public WalletCreateViewModel()
        {
            
        }

		#endregion Constructors

		#region Methodes

		#endregion Methodes 

		#region Observable Property Methodes

		#endregion Observable Property Methodes

		#region RelayCommands

		[RelayCommand]
		private void Create()
		{
			var viewModel = App.ServiceProvider.GetRequiredService<WalletExplorerViewModel>();
			WeakReferenceMessenger.Default.Send(new ViewModelChangedMessage(viewModel));
		}

		[RelayCommand]
		private void Back()
		{
			var viewModel = App.ServiceProvider.GetRequiredService<WalletExplorerViewModel>();
			WeakReferenceMessenger.Default.Send(new ViewModelChangedMessage(viewModel));
		}

		#endregion RelayCommands

		#region Messages

		#endregion Messages

		#region Events

		#endregion Events

		#region Dispose

		#endregion Dispose
	}
}
