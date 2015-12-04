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
		/*
		 * TODO list:
		 *	write part
		 *		file
		 */
		{
			try
			{
				if (!Login())
				{
					Console.WriteLine("Wrong password");
					return;
				}

				Load();
				Show();

				Server server = new Server(new IPEndPoint(new IPAddress(new byte[] { 8, 8, 8, 8 }), 440));
				serverLogic.Connect(user, server.IP);

				Show();

				serverLogic.Disconnect(user);

				Show();

				Console.WriteLine(questLogic.Get());
			}
			finally
			{
				Save();
			}
		}

		private static void AddRandomQuest()
		{
			quest.Add(questLogic.Get());
		}

		private static void Save()
		{
			userLogic.Save(user);
			gatewayLogic.Save(gate);
			softwareLogic.Save(software);
			hardwareLogic.Save(hardware);
			questLogic.Save();
			serverLogic.Save();
		}

		private static void AddMoneyBankToUser(int val)
		{
			userLogic.AddMoneyBank(user, val);
		}

		private static void AddNeuromancerRating(int val)
		{
			userLogic.AddNeuromancerRating(user, val);
                }

		private static void AddRelinkRating(int val)
		{
			userLogic.AddRelinkRating(user, val);
                }

		private static void AddMoneyToUser(int val)
		{
			userLogic.AddMoney(user, val);
		}
		private static void Show()
		{
			Console.WriteLine(user.ToString());
			Console.WriteLine(gate.ToString());

			foreach (var item in software)
			{
				Console.WriteLine(item.ToString());
			}

			foreach (var item in hardware)
			{
				Console.WriteLine(item.ToString());
			}
		}

		private static bool Login()
		{
			string[] userdat = Get.GetMe.User();
			int passwddat = userLogic.GetPasswd();

			if (passwddat == userdat[1].GetHashCode())
			{
				return true;
			}
			return false;
		}

		private static void Load()
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