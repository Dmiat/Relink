using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Relink.DAL.Textfile
{
	public class GatewayTextfile : IGatewayDAO
	{
		private string workFolderPath = InternalDAO.workFolderPath;
		private string gatewayDatFileName = InternalDAO.gatewayDatFileName;
		private string allGatewayDatFileName = InternalDAO.allGatewayDatFileName;

		public List<Gateway> Load()
		{
			/*
			 * Format:
			 * name
			 */
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, gatewayDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return JsonConvert.DeserializeObject<List<Gateway>>(fin.ReadLine());
			}
		}

		void IGatewayDAO.Save(List<Gateway> gate)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, gatewayDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(JsonConvert.SerializeObject(gate));
			}
		}

		public List<Gateway> GetAllGateway()
		{
			List<Gateway> output = new List<Gateway>();

			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, allGatewayDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return JsonConvert.DeserializeObject<List<Gateway>>(fin.ReadLine());
			}
		}
	}
}