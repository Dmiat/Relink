using Relink.Entities.Interface;
using System;

namespace Relink.Entities
{
	public class Software : ISellable
	{
		public Software(string name, int[] cost = null, int[] aviliableVersions = null, int[] size = null, string description = "Empty")
		{
			this.Name = name;
			this.Cost = cost;
			this.AviliableVersions = aviliableVersions;
			this.Size = size;
			this.Description = description;
		}

		public string Name { get; set; }
		public int[] Cost { get; }
		public int[] AviliableVersions { get; }
		public int[] Size { get; }
		public string Description { get; }

		#region operators
		public static bool operator ==(Software rhs, Software lhs)
			=> (rhs.Name == lhs.Name);

		public static bool operator !=(Software rhs, Software lhs)
			=> (rhs.Name != lhs.Name);

		public override bool Equals(Object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}

			// If parameter cannot be cast to Point return false.
			Software p = obj as Software;
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