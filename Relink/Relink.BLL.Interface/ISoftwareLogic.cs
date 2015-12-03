using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL.Interface
{
	public interface ISoftwareLogic
	{
		HashSet<Software> Load();
		void Save(HashSet<Software> software);
		IEnumerable<Software> GetAllSoftware();
        }
}