using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL.Interface
{
	public interface IGatewayLogic
	{
		Gateway Load();
		void Save(Gateway gate);
		IEnumerable<Gateway> GetAllGateway();
	}
}