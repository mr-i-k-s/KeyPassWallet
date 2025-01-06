using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassWallet.MVVM.Models
{
	public class KeyWallet
	{
        public string Title { get; set; }
		public string Date { get; set; }
		public List<KeyPassData> Keys { get; set; }
    }
}
