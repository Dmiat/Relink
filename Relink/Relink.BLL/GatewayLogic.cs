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
		private HashSet<Gateway> allGateway = new HashSet<Gateway>();

		public IEnumerable<Gateway> GetAllGateway()
		{
			return allGateway;
		}

		public Gateway Load()
		{
			allGateway = gatewayDAO.GetAllGateway();

			string[] gatedat = gatewayDAO.Load();

			Gateway gate = new Gateway(gatedat[0]);

			return gate;
		}

		public void Save(Gateway gate)
		{
			gatewayDAO.Save(gate);
		}
	}
}