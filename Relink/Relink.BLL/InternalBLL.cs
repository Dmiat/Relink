using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.BLL
{
	internal class InternalBLL
	{
		internal static int MaxMoneyReward { get; } = 2000; // TODO : ask DAL
		internal static int MaxRelinkReward { get; } = 4;
		internal static int MaxNeuromancerReward { get; } = 4;
	}
}
