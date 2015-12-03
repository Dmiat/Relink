using System.Net;

namespace Relink.Entities
{
	public class Server
	{
		public IPAddress IP { get; set; }
		public string CoopName { get; set; }

		public Server(IPAddress IPAddress)
		{
			this.IP = IPAddress;
		}

		public override string ToString()
		{
			return $"{this.IP.ToString()} {CoopName}";
		}
	}
}