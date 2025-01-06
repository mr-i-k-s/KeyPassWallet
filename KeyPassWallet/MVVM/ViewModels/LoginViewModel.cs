using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MVVM.ViewModels;

namespace KeyPassWallet.MVVM.ViewModels
{
	public partial class LoginViewModel : ViewModelBase
	{
        #region Variables

        [ObservableProperty]
        private string _password;

        #endregion Variables

        #region Properties

        #endregion Properties

        #region Constructors

        public LoginViewModel()
        {
            
        }

		#endregion Constructors

		#region Methodes

		#endregion Methodes 

		#region Observable Property Methodes

		#endregion Observable Property Methodes

		#region RelayCommands

		[RelayCommand]
		private void OpenWallet()
		{
			
		}

		[RelayCommand]
		private void CreateNewWallet()
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
