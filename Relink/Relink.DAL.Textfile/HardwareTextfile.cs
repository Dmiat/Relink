using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using System.Collections.Generic;

namespace Relink.DAL.Textfile
{
	public class HardwareTextfile : IHardwareDAO
	{
		private string workFolderPath = ConfigurationManager.AppSettings["workFolderPath"];
		private string hardwareDatFileName = ConfigurationManager.AppSettings["FileName_hardwareFile"];
		private string allHardwareFileName = ConfigurationManager.AppSettings["FileName_allHardware"];


		public string[] Load()
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
				return fin.ReadLine().Trim().Split(' ');
			}
		}

		public void Save(HashSet<Hardware> hardware)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, hardwareDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				foreach (var item in hardware)
				{
					fout.Write(item.ToString() + " ");
				}
			}
		}

		public HashSet<Hardware> GetAllHardware()
		{
			HashSet<Hardware> output = new HashSet<Hardware>();

			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, allHardwareFileName),
								FileMode.Open, FileAccess.Read)))
			{
				foreach (var item in fin.ReadLine().Trim().Split(';'))
				{
					output.Add(new Hardware(item));
				}
			}

			return output;
		}
	}
}