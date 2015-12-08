using System.Net;

namespace Relink.Entities
{
	public class Server
	{
		public IPEndPoint IP { get; set; }
		public string CoopName { get; set; }

		// svg js css <- google it for hdd

		public Server(IPEndPoint IPAddress)
		{
			this.IP = IPAddress;
		}

		public override string ToString()
		{
			return $"{this.IP.ToString()} {CoopName}";
		}
	}
}