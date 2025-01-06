using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KeyPassWallet.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		#endregion Observable Property Methodes

		#region RelayCommands

		[RelayCommand]
		private void SelectWallet()
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
