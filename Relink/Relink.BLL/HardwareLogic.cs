using Relink.BLL.Interface;
using Relink.DAL.Interface;
using Relink.DAL.Textfile;
using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL
{
	public class HardwareLogic : IHardwareLogic
	{
		private IHardwareDAO hardwareDAO = new HardwareTextfile();
		private HashSet<Hardware> allHardware = new HashSet<Hardware>();

		public IEnumerable<Hardware> GetAllHardware()
		{
			return allHardware;
                }

		public HashSet<Hardware> Load()
		{
			allHardware = hardwareDAO.GetAllHardware();

			HashSet<Hardware> hard = new HashSet<Hardware>();

			string[] harddat = hardwareDAO.Load();

			foreach (var item in harddat)
			{
				hard.Add(
					new Hardware(item));
			}

			return hard;
		}

		public void Save(HashSet<Hardware> hardware)
		{
			hardwareDAO.Save(hardware);
		}
	}
}