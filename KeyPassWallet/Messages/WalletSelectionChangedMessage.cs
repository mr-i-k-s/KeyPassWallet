using CommunityToolkit.Mvvm.Messaging.Messages;
using KeyPassWallet.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassWallet.Messages
{
	public class WalletSelectionChangedMessage : ValueChangedMessage<KeyWallet>
	{
		public WalletSelectionChangedMessage(KeyWallet value) : base(value)
		{
		}
	}
}
