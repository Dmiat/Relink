using System;
using System.Collections.Generic;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface ISoftwareDAO
	{
		string[] Load();
		void Save(HashSet<Software> software);
		HashSet<Software> GetAllSoftware();
	}
}