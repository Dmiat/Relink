using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.DAL.Textfile
{
	internal static class ListExtension
	{
		public static T GetRandomElement<T>(this List<T> list)
		{
			Random rand = new Random(); // grobal random

			return list[rand.Next(0, list.Count)];
		}
	}

	internal class QuestData
	{
		public List<string> names { get; } = new List<string>();
		public List<int> moneyRewards { get; } = new List<int>();
		public List<int> relinkRewards { get; } = new List<int>();
		public List<int> NeuromancerRewards { get; } = new List<int>();
		public List<int> moneyPunish { get; } = new List<int>();
		public List<int> relinkPunish { get; } = new List<int>();
		public List<int> NeuromancerPunish { get; } = new List<int>();
	}

	internal static class InternalDAO
	{
		internal static string allGatewayDatFileName = ConfigurationManager.AppSettings["FileName_allGateway"];
		internal static string allHardwareFileName = ConfigurationManager.AppSettings["FileName_allHardware"];
		internal static string allSoftwareFileName = ConfigurationManager.AppSettings["FileName_allSoftware"];
		internal static string gatewayDatFileName = ConfigurationManager.AppSettings["FileName_gatewayFile"];
		internal static string memoryDatFileName = ConfigurationManager.AppSettings["FileName_allMemory"];
		internal static string modemDatFileName = ConfigurationManager.AppSettings["FileName_allModem"];
		internal static string processorDatFileName = ConfigurationManager.AppSettings["FileName_allProcessor"];
		internal static string questDatFileName = ConfigurationManager.AppSettings["FileName_questFile"];
		internal static string softwareDatFileName = ConfigurationManager.AppSettings["FileName_softwareFile"];
		internal static string userDatFileName = ConfigurationManager.AppSettings["FileName_userFile"];
		internal static string UserHWDatFileName = ConfigurationManager.AppSettings["FileName_hardwareFile"];
		internal static string workFolderPath = ConfigurationManager.AppSettings["workFolderPath"];
	}
}
