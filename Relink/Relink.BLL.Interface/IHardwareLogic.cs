using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL.Interface
{
	public interface IHardwareLogic
	{
		HashSet<Hardware> Load();
		void Save(HashSet<Hardware> hardware);
		IEnumerable<Hardware> GetAllHardware();
        }
}