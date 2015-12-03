using Relink.Entities;
using System;

namespace Relink.BLL
{
	public interface IUserLogic
	{
		User Load();
		void Save(User user);
		int GetPasswd();
		bool AddMoney(User user, int val);
		bool AddMoneyBank(User user, int val);
		bool AddRelinkRating(User user, int val);
		bool AddNeuromancerRating(User user, int val);
		int GetMoney(User user);
		int GetMoneyBank(User user);
		int GetRelinkRating(User user);
		int GetNeuromancerRating(User user);
		bool SetMoney(User user, int val);
		bool SetMoneyBank(User user, int val);
		bool SetRelinkRating(User user, int val);
		bool SetNeuromancerRating(User user, int val);
        }
}