using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using System.Collections.Generic;

namespace Relink.DAL.Textfile
{
	public class SoftwareTextfile : ISoftwareDAO
	{
		private string workFolderPath = ConfigurationManager.AppSettings["workFolderPath"];
		private string softwareDatFileName = ConfigurationManager.AppSettings["FileName_softwareFile"];
		private string allSoftwareFileName = ConfigurationManager.AppSettings["FileName_allSoftware"];
		

		public string[] Load()
		{
			/*
			 * Format:
			 * name
			 */
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, softwareDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return fin.ReadLine().Trim().Split(' ');
			}
		}

		public void Save(HashSet<Software> software)
		{
			using (StreamWriter fout = new StreamWriter(
								new FileStream(
									Path.Combine(workFolderPath, softwareDatFileName),
									FileMode.Open, FileAccess.Write)))
			{
				foreach (var item in software)
				{
					fout.Write(item.ToString() + " ");
				}
			}
		}

		public HashSet<Software> GetAllSoftware()
		{
			HashSet<Software> output = new HashSet<Software>();
                        using (StreamReader fin = new StreamReader(
								new FileStream(
									Path.Combine(workFolderPath, allSoftwareFileName),
									FileMode.Open, FileAccess.Read)))
			{
				foreach (var item in fin.ReadLine().Trim().Split(';'))
				{
					output.Add(new Software(item));
                                } 
			}

			return output;
		}
	}
}