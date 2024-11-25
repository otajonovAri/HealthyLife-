using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
	internal class DisplayShowMethod
	{
		public int EntryCount = 3;

		public void EntryDisplayMessageInfo()
		{
			while(EntryCount != 0)
			{
				try
				{
					rest:
					Console.Write("Enter username: ");
					string username = Console.ReadLine();

					Console.Write("Enter password: ");
					string password = Console.ReadLine();

					///// User name , User password checekd
					//if(ValidateUser(username, password))
					//{
					//	continue;
					//}

					User user = new User
					{
						UserName = username,
						Password = password
					};

					ValidateUser(user);
					Console.Clear();
					Console.WriteLine("Welcome to the system...");
				}
				catch (InvalidUserCredentialsException ex)
				{
					Console.Clear();
					Logger.LogError(InvalidUserCredentialsException.Code, ex.Message);
				}
				finally
				{
					Console.WriteLine("Session finished");
				}
				EntryCount--;
			}
			Console.WriteLine("Too many login errors have occurred :(");
		}
		public static void ValidateUser(User user)
		{
			const string validUserName = "admin";
			const string valideUserPassword = "password";

			if (user.UserName != validUserName || user.Password != valideUserPassword)
			{
				throw new InvalidUserCredentialsException();
			}
		}
		//public static bool ValidateUser(string username, string password)
		//{
		//	if(username == null || password == null)
		//	{
		//		return false;
		//	}
		//	if(username.Length < 3 || username.Length > 50)
		//	{
		//		return false;
		//	}
		//	return true;
		//}
	}
}
