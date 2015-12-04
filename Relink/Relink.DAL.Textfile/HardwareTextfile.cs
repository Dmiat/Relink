using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Relink.DAL.Textfile
{
	public class HardwareTextfile : IHardwareDAO
	{
		private string workFolderPath = InternalDAO.workFolderPath;
		private string hardwareDatFileName = InternalDAO.hardwareDatFileName;
		private string allHardwareFileName = InternalDAO.allHardwareFileName;


		public List<Hardware> Load()
		{
			/*
			 * Format:
			 * name
			 */

			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, hardwareDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return JsonConvert.DeserializeObject<List<Hardware>>(fin.ReadLine());
			}
		}

		public void Save(List<Hardware> hardware)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, hardwareDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(JsonConvert.SerializeObject(hardware));
			}
		}

		public List<Hardware> GetAllHardware()
		{
			List<Hardware> output = new List<Hardware>();

			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, allHardwareFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return JsonConvert.DeserializeObject<List<Hardware>>(fin.ReadLine());
			}
		}
	}
}