using Relink.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Relink.BLL.Interface
{
	public interface IServerLogic
	{
		bool Connect(User user, IPAddress serverIP);
		bool Disconnect(User user);
		IEnumerable<File> GetFiles(Server server);
		File GetFile(Server server, string filename);
		bool AddFile(Server server, File file);
		bool RemoveFile(Server server, File file);
		void Load();
		void Save();
	}
}
