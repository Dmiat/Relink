using Relink.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Relink.Entities;
using Relink.DAL.Interface;
using Relink.DAL.Textfile;

namespace Relink.BLL
{
	public class QuestLogic : IQuestLogic
	{
		private IQuestDAO questDAO = new QuestTextfile();
		


		public bool Done(Quest quest)
		{
			return true;
		}

		public Quest Get()
		{
			return questDAO.GetRandomQuest();
		}

		public void Failure(User user, Quest quest)
		{
			user.Money -= (user.Money - quest.MoneyPunish < 0 ? user.Money : quest.MoneyPunish);
			user.RelinkRating -= (user.RelinkRating - quest.RelinkPunish < 0 ? user.RelinkRating : quest.RelinkPunish);
			user.NeuromancerRating -= (user.NeuromancerRating - quest.NeuromancerPunish < 0 ? user.NeuromancerRating : quest.NeuromancerPunish);
		}

		public void Success(User user, Quest quest)
		{
			if ((quest.MoneyReward > InternalBLL.MaxMoneyReward) ||
					(quest.RelinkReward > InternalBLL.MaxRelinkReward) ||
					(quest.NeuromancerReward > InternalBLL.MaxNeuromancerReward))
                        {
				throw new InvalidOperationException("Too big reward.");
			}

			user.Money += quest.MoneyReward;
			user.RelinkRating += quest.RelinkReward;
			user.NeuromancerRating += quest.NeuromancerReward;
		}

		public void Load()
		{
			questDAO.Load();
		}

		public void Save()
		{
			questDAO.Save();
		}
	}
}
