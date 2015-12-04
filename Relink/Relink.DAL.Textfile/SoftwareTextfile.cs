using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Relink.DAL.Textfile
{
	public class SoftwareTextfile : ISoftwareDAO
	{
		private string workFolderPath = InternalDAO.workFolderPath;
		private string softwareDatFileName = InternalDAO.softwareDatFileName;
		private string allSoftwareFileName = InternalDAO.allSoftwareFileName;

		public List<Software> Load()
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, softwareDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return JsonConvert.DeserializeObject<List<Software>>(fin.ReadLine());
			}
		}

		public void Save(List<Software> software)
		{
			using (StreamWriter fout = new StreamWriter(
								new FileStream(
									Path.Combine(workFolderPath, softwareDatFileName),
									FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(JsonConvert.SerializeObject(software));
			}
		}

		public IEnumerable<Software> GetAllSoftware()
		{
			HashSet<Software> output = new HashSet<Software>();
                        using (StreamReader fin = new StreamReader(
								new FileStream(
									Path.Combine(workFolderPath, allSoftwareFileName),
									FileMode.Open, FileAccess.Read)))
			{
				return JsonConvert.DeserializeObject<List<Software>>(fin.ReadLine());
			}
		}
	}
}