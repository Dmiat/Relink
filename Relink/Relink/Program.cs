using Relink.BLL;
using Relink.BLL.Interface;
using Relink.Entities;
using Relink.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Relink
{
	public class Program
	{
		private Program()
		{
		}

		public static IUserLogic userLogic = new UserLogic();
		public static IGatewayLogic gatewayLogic = new GatewayLogic();
		public static ISoftwareLogic softwareLogic = new SoftwareLogic();
		public static IHardwareLogic hardwareLogic = new HardwareLogic();
		public static IQuestLogic questLogic = new QuestLogic();
		public static IServerLogic serverLogic = new ServerLogic();

		public static User user;
		public static List<Gateway> gate;
		public static List<Software> software = new List<Software>();
		public static List<Hardware> hardware = new List<Hardware>();
		public static List<Quest> quest = new List<Quest>();

		private static void Main(string[] args)
		{
		
		}
		
		public static void Load()
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