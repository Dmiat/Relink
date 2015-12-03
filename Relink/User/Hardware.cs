namespace Relink.Entities
{
	public class Hardware
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

		public override string ToString()
		{
			return this.Name;
		}
	}
}