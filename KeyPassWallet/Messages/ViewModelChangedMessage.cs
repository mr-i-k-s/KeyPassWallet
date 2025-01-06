using CommunityToolkit.Mvvm.Messaging.Messages;
using KeyPassWallet.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MVVM.ViewModels;

namespace KeyPassWallet.Messages
{
	public class ViewModelChangedMessage : ValueChangedMessage<ViewModelBase>
	{
		public ViewModelChangedMessage(ViewModelBase value) : base(value)
		{
		}
	}
}
