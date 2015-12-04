using System;
using System.Collections.Generic;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface ISoftwareDAO
	{
		List<Software> Load();
		void Save(List<Software> software);
		IEnumerable<Software> GetAllSoftware();
	}
}