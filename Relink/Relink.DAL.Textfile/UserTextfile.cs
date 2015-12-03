using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;

namespace Relink.DAL.Textfile
{
	public class UserTextfile : IUserDAO
	{
		private string workFolderPath = ConfigurationManager.AppSettings["workFolderPath"];
		private string userDatFileName = ConfigurationManager.AppSettings["FileName_userFile"];

		public string[] Load()
		/*
		 * Format:
		 * login password money moneyback
		 */
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, userDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				return fin.ReadLine().Trim().Split(' ');
			}
		}

		public int GetPasswd()
		{
			return "Novikova".GetHashCode(); // TODO : keep non-string passwd
		}

		public void Save(User user)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, userDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.Write(user.ToString());
			}
		}
	}
}