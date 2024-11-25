﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
	internal class LogEntry
	{
		public int Id { get; set; }
		public string Code { get; set; }
		public string Message { get; set; }
		public DateTime Timestamp { get; set; }
	}
}
