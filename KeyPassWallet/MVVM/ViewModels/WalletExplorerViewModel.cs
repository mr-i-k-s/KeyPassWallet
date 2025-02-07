﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using KeyPassWallet.Messages;
using KeyPassWallet.MVVM.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.MVVM.ViewModels;

namespace KeyPassWallet.MVVM.ViewModels
{
	public partial class WalletExplorerViewModel : ViewModelBase
	{
        #region Variables

        [ObservableProperty]
        private KeyWallet _selectedWallet;

		#endregion Variables

		#region Properties

		public ObservableCollection<KeyWallet> Wallets { get; set; }

        #endregion Properties

        #region Constructors

        public WalletExplorerViewModel()
        {
            
        }

		#endregion Constructors

		#region Methodes

		#endregion Methodes 

		#region Observable Property Methodes

		partial void OnSelectedWalletChanged(KeyWallet value)
		{
			if(value != null)
			{
				WeakReferenceMessenger.Default.Send(new WalletSelectionChangedMessage(value));
			}
		}

		#endregion Observable Property Methodes

		#region RelayCommands

		[RelayCommand]
		private void CreateWallet()
		{
			var viewModel = App.ServiceProvider.GetRequiredService<WalletCreateViewModel>();
			WeakReferenceMessenger.Default.Send(new ViewModelChangedMessage(viewModel));
		}

		[RelayCommand]
		private void ImportWallet()
		{

		}

		[RelayCommand]
		private void DeleteWallet()
		{

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
