using Relink.BLL;
using Relink.BLL.Interface;
using Relink.Entities;
using System.Collections.Generic;

namespace Relink.PL.Providers
{
	public class LogicProvider
	{
		public static IGatewayLogic gatewayLogic { get; } = new GatewayLogic();
		public static IHardwareLogic hardwareLogic { get; } = new HardwareLogic();
		public static IQuestLogic questLogic { get; } = new QuestLogic();
		public static IServerLogic serverLogic { get; } = new ServerLogic();
		public static ISoftwareLogic softwareLogic { get; } = new SoftwareLogic();
		public static IUserLogic userLogic { get; } = new UserLogic();

		public static User user;
		public static List<Gateway> gate;
		public static List<Software> software = new List<Software>();
		public static List<Hardware> hardware = new List<Hardware>();
		public static List<Quest> quest = new List<Quest>();

		internal static void Save()
		{
			userLogic.Save(user);
			gatewayLogic.Save(gate);
			softwareLogic.Save(software);
			hardwareLogic.Save(hardware);
			questLogic.Save();
			serverLogic.Save();
		}

		internal static void Load()
		{
			user = userLogic.Load();
			gate = gatewayLogic.Load();
			software = softwareLogic.Load();
			hardware = hardwareLogic.Load();
			questLogic.Load();
			serverLogic.Load();

		}
	}
}