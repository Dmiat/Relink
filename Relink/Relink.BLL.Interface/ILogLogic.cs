using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.BLL.Interface
{
	public interface ILogLogic
	{
		// strings?
                bool AddLog(string log);
		bool RemoveLog(string log);
	}
}
