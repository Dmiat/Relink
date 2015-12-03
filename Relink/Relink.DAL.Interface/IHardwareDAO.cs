using System;
using System.Collections.Generic;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface IHardwareDAO
	{
		string[] Load();
		void Save(HashSet<Hardware> hardware);
		HashSet<Hardware> GetAllHardware();
	}
}