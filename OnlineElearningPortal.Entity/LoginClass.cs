using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_ELearnPortal.Entity
{
	public class LoginClass
	{
		public string userName { get; set; }
		public string password { get; set; }

		public LoginClass(string userName, string password)
		{
			this.userName = userName;
			this.password = password;

		}
	}
}
