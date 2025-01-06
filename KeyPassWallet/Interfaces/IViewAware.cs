using System.Windows;

namespace KeyPassWallet.Interfaces
{
	public interface IViewAware
	{
		Window View { get; set; }
	}
}
