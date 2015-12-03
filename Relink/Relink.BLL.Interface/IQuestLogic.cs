using Relink.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relink.BLL.Interface
{
	public interface IQuestLogic
	{
		//HashSet<Quest> Load();
		//void Save(HashSet<Quest> questSet);
		Quest Get();
		bool Done(Quest quest);
		void Success(User user, Quest quest);
		void Failure(User user, Quest quest);
		void Load();
		void Save();
	}
}
