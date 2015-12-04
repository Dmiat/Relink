using Relink.DAL.Interface;
using System;
using System.Configuration;
using System.IO;
using Relink.Entities;
using Newtonsoft.Json;

namespace Relink.DAL.Textfile
{
	public class UserTextfile : IUserDAO
	{
		private string workFolderPath = InternalDAO.workFolderPath;
		private string userDatFileName = InternalDAO.userDatFileName;

		public User Load()
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, userDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				JsonSerializerSettings settings = new JsonSerializerSettings();
				settings.Converters.Add(new IPAddressConverter());
				settings.Converters.Add(new IPEndPointConverter());
				return JsonConvert.DeserializeObject<User>(fin.ReadLine(), settings);
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
				JsonSerializerSettings settings = new JsonSerializerSettings();
				settings.Converters.Add(new IPAddressConverter());
				settings.Converters.Add(new IPEndPointConverter());
				fout.WriteLine(JsonConvert.SerializeObject(user, settings));
			}
		}
	}
}