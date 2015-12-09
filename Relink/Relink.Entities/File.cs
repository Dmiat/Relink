using System;

namespace Relink.Entities
{
	public class File
	{
		// I wanna to make inode separately, but...sorry(
		public File(string path, int startBlock = 0, int length = 1, string content = "")
		{
			this.Id = Guid.NewGuid();
			this.Path = path;
			this.StartBlock = startBlock;
			this.Length = length;
			this.Content = content;
		}

		public string Content { get; set; }
		public Guid Id { get; }
		public int Length { get; set; }
		public string Name
		{
			get
			{
				string[] items = this.Path.Split('/');
				return items[items.Length];
			}
		}

		public string Path { get; set; }
		public int StartBlock { get; set; }
	}
}