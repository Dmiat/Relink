using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.Entities
{
	public class Memory : Hardware
	{
		public Memory(string name, int[] cost, string description, int size) : base(name, cost, description)
		{
			this.Size = size;
		}

		public int Size { get; }
	}
}
