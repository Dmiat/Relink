using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using System.Collections.Generic;

namespace Relink.DAL.Textfile
{
	public class GatewayTextfile : IGatewayDAO
	{
		private string workFolderPath = ConfigurationManager.AppSettings["workFolderPath"];
		private string gatewayDatFileName = ConfigurationManager.AppSettings["FileName_gatewayFile"];
		private string allGatewayDatFileName = ConfigurationManager.AppSettings["FileName_allGateway"];

		public string[] Load()
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
				return fin.ReadLine().Trim().Split(' ');
			}
		}

		void IGatewayDAO.Save(Gateway gate)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, gatewayDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(gate.ToString());
			}
		}

		public HashSet<Gateway> GetAllGateway()
		{
			HashSet<Gateway> output = new HashSet<Gateway>();

			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, allGatewayDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				foreach (var item in fin.ReadLine().Trim().Split(';'))
				{
					output.Add(new Gateway(item));
				}
			}

			return output;
		}
	}
}