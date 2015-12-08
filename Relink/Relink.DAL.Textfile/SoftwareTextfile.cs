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
				string str = fin.ReadLine();

				if (str == null)
				{
					return new List<Software>();
				}

                                return JsonConvert.DeserializeObject<List<Software>>(str);
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
                        using (StreamReader fin = new StreamReader(
								new FileStream(
									Path.Combine(workFolderPath, allSoftwareFileName),
									FileMode.Open, FileAccess.Read)))
			{
				string str = fin.ReadLine();
                                var a = JsonConvert.DeserializeObject<List<Software>>(str);
				return a;
			}
		}
	}
}