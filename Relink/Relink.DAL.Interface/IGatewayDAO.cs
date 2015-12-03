using System;
using System.Collections.Generic;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface IGatewayDAO
	{
		string[] Load();
		void Save(Gateway gate);
		HashSet<Gateway> GetAllGateway();
	}
}