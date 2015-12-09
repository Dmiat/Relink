using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.BLL
{
	public class ImageLogic
	{
		public static byte[] GetImage()
		{
			var a = File.ReadAllBytes(@"D:\prgepam\YetAnotherVer\YAR\Relink\Relink\Relink.PL\mm\hddmap.png");
			return a;
		}
	}
}
