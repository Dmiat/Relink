using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL.Interface
{
	public interface IHardwareLogic
	{
		List<Hardware> Load();
		void Save(List<Hardware> hardware);
		IEnumerable<Hardware> GetAllHardware();
        }
}