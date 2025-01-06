using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassWallet.MVVM.Models
{
	public class KeyPassWallet
	{
        public string Title { get; set; }
        public List<KeyPassData> Keys { get; set; }
    }
}
