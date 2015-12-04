using Relink.BLL.Interface;
using Relink.DAL.Interface;
using Relink.DAL.Textfile;
using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL
{
	public class GatewayLogic : IGatewayLogic
	{
		private IGatewayDAO gatewayDAO = new GatewayTextfile();
		private List<Gateway> allGateway = new List<Gateway>();

		public IEnumerable<Gateway> GetAllGateway()
		{
			return allGateway;
		}

		public List<Gateway> Load()
		{
			allGateway = gatewayDAO.GetAllGateway();
			return gatewayDAO.Load();
		}

		public void Save(List<Gateway> gate)
		{
			gatewayDAO.Save(gate);
		}
	}
}