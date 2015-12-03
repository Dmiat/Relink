using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Relink.Entities;

namespace Relink.DAL.Interface
{
	public interface IQuestDAO
	{
		void Load();
		void Save();
		Quest GetRandomQuest();
	}
}
