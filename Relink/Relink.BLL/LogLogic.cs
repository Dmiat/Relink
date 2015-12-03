using Relink.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.BLL
{
	public class LogLogic : ILogLogic
	{
		public bool AddLog(string log)
		{
			if (log.Length == 0)
			{
				throw new ArgumentException("Log length is zero.");
			}

			Console.WriteLine(log);
			return true;

		}

		public bool RemoveLog(string log)
		{
			if (false)
			{
				throw new ArgumentException();
			}

			Console.WriteLine(log + "removed");
			return true;
		}
	}
}
