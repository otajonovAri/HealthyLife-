using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
	internal class InvalidUserCredentialsException : Exception
	{
		public const string Code = "invalide_user_credentails";

		public InvalidUserCredentialsException() : base("Username or password is incorrect")
		{
		}
	}
}
