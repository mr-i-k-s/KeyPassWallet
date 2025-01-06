namespace KeyPassWallet.Interfaces
{
	public interface IWindowService
	{
		void ShowWindow(object viewModel);
		bool? ShowDialog(object viewModel);
	}
}
