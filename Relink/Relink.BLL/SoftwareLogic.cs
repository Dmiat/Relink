using Relink.BLL.Interface;
using Relink.DAL.Interface;
using Relink.DAL.Textfile;
using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL
{
	public class SoftwareLogic : ISoftwareLogic
	{
		private static ISoftwareDAO softwareDAO = new SoftwareTextfile();
		private HashSet<Software> allSoftware = new HashSet<Software>();

		public IEnumerable<Software> GetAllSoftware()
		{
			return allSoftware; // TODO : ToList()
		}

		public HashSet<Software> Load()
		{
			allSoftware = softwareDAO.GetAllSoftware();

			HashSet<Software> usersoft = new HashSet<Software>();

			string[] softdat = softwareDAO.Load();

			foreach (var item in softdat)
			{
				usersoft.Add(
					new Software(item));
			}

			return usersoft;
		}

		public void Save(HashSet<Software> software)
		{
			softwareDAO.Save(software);
		}
	}
}