using Relink.Entities.Interface;
using System;

namespace Relink.Entities
{
	public class Software : ISellable
	{
		public Software(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }

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

		public override string ToString()
		{
			return $"{this.Name} _ _ _ _ _ _ _ _ {this.Cost().ToString()}";
		}

		public int Cost()
		{
			switch (this.Name)
			{
				case "soft1":
					return 100;
				case "soft2":
					return 200;
				case "soft3":
					return 300;
				case "soft4":
					return 400;
				case "soft5":
					return 500;
				case "soft6":
					return 600;
				case "soft7":
					return 700;
				case "soft8":
					return 800;
				default:
					return -1;
			}
		}
	}
}