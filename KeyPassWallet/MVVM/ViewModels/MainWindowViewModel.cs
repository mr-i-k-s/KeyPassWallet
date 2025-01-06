using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using KeyPassWallet.Messages;
using KeyPassWallet.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MVVM.ViewModels;

namespace KeyPassWallet.MVVM.ViewModels
{
	public partial class MainWindowViewModel : ViewModelBase, IRecipient<ViewModelChangedMessage>

	{
        #region Variables

        [ObservableProperty]
        private ViewModelBase _currViewModel;

        #endregion Variables

        #region Properties

        #endregion Properties

        #region Constructors

        #endregion Constructors

        #region Methodes

        public MainWindowViewModel()
        {
			CurrViewModel = new WalletExplorerViewModel();

			WeakReferenceMessenger.Default.Register<ViewModelChangedMessage>(this);
		}

		#endregion Methodes 

		#region Observable Property Methodes

		#endregion Observable Property Methodes

		#region RelayCommands

		#endregion RelayCommands

		#region Messages

		public void Receive(ViewModelChangedMessage message)
		{
			var viewModel = message.Value as ViewModelBase;

			if (viewModel != null)
            {
				CurrViewModel = viewModel;
			}
		}

		#endregion Messages

		#region Events

		#endregion Events

		#region Dispose

		#endregion Dispose
	}
}
