using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL.Interface
{
	public interface IGatewayLogic
	{
		List<Gateway> Load();
		void Save(List<Gateway> gate);
		IEnumerable<Gateway> GetAllGateway();
		void Change(string name, List<Gateway> gate);
	}
}