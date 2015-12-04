using Relink.BLL.Interface;
using Relink.DAL.Interface;
using Relink.DAL.Textfile;
using Relink.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Relink.BLL
{
	public class SoftwareLogic : ISoftwareLogic
	{
		private static ISoftwareDAO softwareDAO = new SoftwareTextfile();
		private List<Software> allSoftware = new List<Software>();

		public IEnumerable<Software> GetAllSoftware()
		{
			return allSoftware; // TODO : ToList()
		}

		public List<Software> Load()
		{
			allSoftware = softwareDAO.GetAllSoftware().ToList();
			return softwareDAO.Load().ToList();
		}

		public void Save(List<Software> software)
		{
			softwareDAO.Save(software);
		}
	}
}