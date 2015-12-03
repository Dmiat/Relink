using Relink.DAL.Interface;
using Relink.DAL.Textfile;
using Relink.Entities;
using System;

namespace Relink.BLL
{
	public class UserLogic : IUserLogic
	{
		private static IUserDAO userDAO = new UserTextfile();

		public bool AddMoney(User user, int val)
		{
			if (val > InternalBLL.MaxMoneyReward)
			{
				throw new ArgumentException("Too big reward."); // numerating?
			}

			user.Money += val;

			return true;
		}

		public bool AddMoneyBank(User user, int val)
		{
			if (val > user.Money)
			{
				throw new ArgumentException("Too big reward.");
			}

			user.MoneyBank += val;

			return true;
		}

		public bool AddNeuromancerRating(User user, int val)
		{
			if (val > InternalBLL.MaxNeuromancerReward)
			{
				throw new ArgumentException("Too big reward.");
			}

			user.NeuromancerRating += val;
			return true;
		}

		public bool AddRelinkRating(User user, int val)
		{
			if (val > InternalBLL.MaxRelinkReward)
			{
				throw new ArgumentException("Too big reward.");
			}

			user.RelinkRating += val;
			return true;
		}

		public int GetMoney(User user)
		{
			return user.Money;
		}

		public int GetMoneyBank(User user)
		{
			return user.MoneyBank;
		}

		public int GetNeuromancerRating(User user)
		{
			return user.NeuromancerRating;
		}

		public int GetPasswd()
		{
			return userDAO.GetPasswd();
		}

		public int GetRelinkRating(User user)
		{
			return user.RelinkRating;
		}

		public User Load()
		{
			string[] userdat = userDAO.Load();

			User user = new User(userdat[0]);

			user.Money = Int32.Parse(userdat[1]);
			user.MoneyBank = Int32.Parse(userdat[2]);

			return user;
		}

		public void Save(User user)
		{
			userDAO.Save(user);
		}

		public bool SetMoney(User user, int val)
		{
			user.Money = val;
			return true;
		}

		public bool SetMoneyBank(User user, int val)
		{
			user.MoneyBank = val;
			return true;
		}

		public bool SetNeuromancerRating(User user, int val)
		{
			user.NeuromancerRating = val;
			return true;
		}

		public bool SetRelinkRating(User user, int val)
		{
			user.RelinkRating = val;
			return true;
		}
	}
}