using Relink.Entities.Interface;
using System;

namespace Relink.Entities
{
	public class Gateway : ISellable
	{
		public Gateway(string name)
		{
			this.Name = name;
		}

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

		public string Name { get; set; }

		public override string ToString()
		{
			return $"{this.Name} _ _ _ _ _ _ _ _ {this.Cost().ToString()}";
		}

		public int Cost()
		{
			switch (this.Name)
			{
				case "gate1":
					return 100;
				case "gate2":
					return 200;
				case "gate3":
					return 300;
				case "gate4":
					return 400;
				case "gate5":
					return 500;
				case "gate6":
					return 600;
				case "gate7":
					return 700;
				case "gate8":
					return 800;
				default:
					return -1;
			}
		}
	}
}