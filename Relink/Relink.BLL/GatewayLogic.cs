using Relink.BLL.Interface;
using Relink.DAL.Interface;
using Relink.DAL.Textfile;
using Relink.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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

		public void Change(string name, List<Gateway> gate)
		{
			var gatewaylist = from item in this.allGateway
				where item.Name == name
				select item;
			var thisgate = gatewaylist.First();

			gate[0] = thisgate;
		}
	}
}