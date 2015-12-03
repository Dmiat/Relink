using System;

namespace Relink.PL
{
	internal class Get
	{
		private Get()
		{
		}

		public static Get GetMe { get; } = new Get();

		internal string[] User()
		{
			string[] output = new string[2];

			Console.Write("Login: >   ");
			output[0] = Console.ReadLine();
			Console.Write("Password: >   ");
			output[1] = Console.ReadLine();

			return output;
		}
	}
}