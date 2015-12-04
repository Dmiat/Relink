using Relink.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Relink.Entities;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace Relink.DAL.Textfile
{


	public class QuestTextfile : IQuestDAO
	{
		private string workFolderPath = InternalDAO.workFolderPath;
		private string questDatFileName = InternalDAO.questDatFileName;

		private QuestData questData = new QuestData();

		public Quest GetRandomQuest()
		{
			return new Quest(
				questData.names.GetRandomElement(),
				questData.moneyRewards.GetRandomElement(),
				questData.relinkRewards.GetRandomElement(),
				questData.NeuromancerRewards.GetRandomElement(),
                                questData.moneyPunish.GetRandomElement(),
				questData.relinkPunish.GetRandomElement(),
                                questData.NeuromancerPunish.GetRandomElement()
				);
		}

		public void Load()
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, questDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				questData = JsonConvert.DeserializeObject<QuestData>(fin.ReadLine());
			}
		}

		public void Save()
		{
			return;
		}

		
	}
}
