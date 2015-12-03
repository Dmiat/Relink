namespace Relink.Entities
{
	public class Software
	{
		public Software(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }

		public override string ToString()
		{
			return this.Name;
		}
	}
}