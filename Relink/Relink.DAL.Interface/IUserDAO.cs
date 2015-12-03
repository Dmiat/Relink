using System;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface IUserDAO
	{
		string[] Load();

		int GetPasswd();
		void Save(User user);
	}
}