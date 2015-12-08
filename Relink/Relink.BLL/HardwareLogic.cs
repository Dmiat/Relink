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
		private List<Hardware> allHardware = new List<Hardware>();

		public IEnumerable<Hardware> GetAllHardware()
		{
			return allHardware;
                }

		public List<Hardware> Load()
		{
			allHardware = hardwareDAO.GetAllHardware();
			return hardwareDAO.Load();
		}

		public void Save(List<Hardware> hardware)
		{
			hardwareDAO.Save(hardware);
		}
	}
}