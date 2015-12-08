using Relink.Entities.Interface;
using System;

namespace Relink.Entities
{
	public class Hardware : ISellable
	{
		public Hardware(string name, int[] cost, string description)
		{
			this.Name = name;
			this.Cost = cost;
			this.Description = description;
		}

		public string Name { get; set; }
		public int[] Cost { get; }
		public string Description { get; }

		#region operators
		public static bool operator ==(Hardware rhs, Hardware lhs)
			=> (rhs.Name == lhs.Name);

		public static bool operator !=(Hardware rhs, Hardware lhs)
			=> (rhs.Name != lhs.Name);

		public override bool Equals(Object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}

			// If parameter cannot be cast to Point return false.
			Hardware p = obj as Hardware;
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