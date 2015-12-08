using Relink.Entities.Interface;
using System;

namespace Relink.Entities
{
	public class Gateway : ISellable
	{
		// {"Name":"TRINITY-1686a","Cost":"113750","MaxCPU":"8","MaxMemory":"128","MaxSecurity":"3","MaxBandwidth":"8","Rating":"10","Description":"TRINITY"}
		public Gateway(string name, int[] cost, int maxCPU, int maxMemory, int maxSecurity, int maxBandwidth, int rating, string description)
		{
			this.Name = name;
			this.Cost = cost;
			this.MaxCPU = maxCPU;
			this.MaxMemory = maxMemory;
			this.MaxSecurity = maxSecurity;
			this.MaxBandwidth = maxBandwidth;
			this.Rating = rating;
			this.Description = description;
		}
		
		public string Name { get; set; }
		public int[] Cost { get; }
		public int MaxCPU { get; }
		public int MaxMemory { get; }
		public int MaxSecurity { get; }
		public int MaxBandwidth { get; }
		public int Rating { get; }
		public string Description { get; }


		#region operators
		public static bool operator ==(Gateway rhs, Gateway lhs)
			=> (rhs.Name == lhs.Name);

		public static bool operator !=(Gateway rhs, Gateway lhs)
			=> (rhs.Name != lhs.Name);

		public override bool Equals(Object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}

			// If parameter cannot be cast to Point return false.
			Gateway p = obj as Gateway;
			if ((System.Object)p == null)
			{
				return false;
			}

			// Return true if the fields match:
			return (Name == p.Name);
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}
		#endregion
	}
}