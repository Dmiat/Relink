using System;
using System.Collections.Generic;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface IGatewayDAO
	{
		List<Gateway> Load();
		void Save(List<Gateway> gate);
		List<Gateway> GetAllGateway();
	}
}