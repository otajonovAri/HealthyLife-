using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
	internal class Logger
	{
		 public static void LogError(string code, string message)
       {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss} ERR]{code}, {message}");
       }
	}
}
