using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.Entities
{
	public class Modem : Hardware
	{
		public Modem(string name, int[] cost, string description, int speed) : base(name, cost, description)
		{
			this.Speed = speed;
		}

		public int Speed { get; }
	}
}
