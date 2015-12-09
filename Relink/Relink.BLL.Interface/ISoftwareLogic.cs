using Relink.Entities;
using System;
using System.Collections.Generic;

namespace Relink.BLL.Interface
{
	public interface ISoftwareLogic
	{
		List<Software> Load();
		void Save(List<Software> software);
		IEnumerable<Software> GetAllSoftware();
		void Add(string softwarename, List<Software> swlist);
        }
}