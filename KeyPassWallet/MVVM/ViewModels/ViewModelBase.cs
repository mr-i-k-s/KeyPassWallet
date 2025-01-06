using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using KeyPassWallet.Interfaces;

namespace WeatherApp.MVVM.ViewModels
{
	public abstract class ViewModelBase : ObservableValidator, IViewAware
	{
		public Window View { get; set; }

		public void Close()
		{
			View.Close();
		}

		public void Close(bool? result)
		{
			View.DialogResult = result;
			View.Close();
		}
	}
}
