using Relink.Entities.Interface;
using System;

namespace Relink.Entities
{
	public class Hardware : ISellable
	{
		public Hardware(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }

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

		public override string ToString()
		{
			return $"{this.Name} _ _ _ _ _ _ _ _ {this.Cost().ToString()}";
		}

		public int Cost()
		{
			switch (this.Name)
			{
				case "hard1":
					return 100;
				case "hard2":
					return 200;
				case "hard3":
					return 300;
				case "hard4":
					return 400;
				case "hard5":
					return 500;
				case "hard6":
					return 600;
				case "hard7":
					return 700;
				case "hard8":
					return 800;
				case "hard9":
					return 900;
				default:
					return -1;
			}
		}
	}
}