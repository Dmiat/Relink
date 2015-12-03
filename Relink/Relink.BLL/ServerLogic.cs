using Relink.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Relink.Entities;
using System.Net;

namespace Relink.BLL
{
	public class ServerLogic : IServerLogic
	{
		public delegate void LogEventHandler(object sender, EventArgs e);

		public event LogEventHandler onFileOperation;
		public event LogEventHandler onConnect;
		public event LogEventHandler onDisconnect;

		private LogLogic logLogic = new LogLogic();

		public bool AddFile(Server server, File file)
		{
			if (onConnect != null)
			{
				onFileOperation(this, EventArgs.Empty);
			}
			throw new NotImplementedException();
		}

		public bool Connect(User user, IPAddress serverIP)
		{	
			if (onConnect != null) // to method
						// get state
			{
				onConnect(this, EventArgs.Empty);
			}
			user.IPNow = serverIP;
			return true;
		}

		public bool Disconnect(User user)
		{
			if (onConnect != null)
			{
				onDisconnect(this, EventArgs.Empty);
			}
			user.IPNow = user.IPHome;
			return true;
		}

		public File GetFile(Server server, string filename)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<File> GetFiles(Server server)
		{
			throw new NotImplementedException();
		}

		public void Load()
		{
			return;
		}

		public bool RemoveFile(Server server, File file)
		{
			if (onConnect != null)
			{
				onFileOperation(this, EventArgs.Empty);
			}
			throw new NotImplementedException();
		}

		public void Save()
		{
			return;
		}
	}
}
