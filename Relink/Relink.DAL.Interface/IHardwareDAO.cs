using System;
using System.Collections.Generic;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface IHardwareDAO
	{
		List<Hardware> Load();
		void Save(List<Hardware> hardware);
		List<Hardware> GetAllHardware();
	}
}