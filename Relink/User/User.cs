using System;
using System.Net;

namespace Relink.Entities
{
	public class User
	{
		public User(string login)
		{
			this.Login = login;
			this.IPNow = IPHome;
		}

		public string Login { get; set; }
		public int Money { get; set; }
		public int MoneyBank { get; set; }
		public int RelinkRating { get; set; }
		public int NeuromancerRating { get; set; }
		public IPAddress IPNow { get; set; }
		public IPAddress IPHome { get; } = new IPAddress(new byte[] { 82, 114, 229, 159 });

		public override string ToString()
		{
			return $"{this.Login} {this.Money} {this.MoneyBank} {this.NeuromancerRating} {this.RelinkRating} {this.IPHome} {IPNow}";
                }
	}
}