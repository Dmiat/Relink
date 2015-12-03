using Relink.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Relink.Entities;
using System.Configuration;
using System.IO;

namespace Relink.DAL.Textfile
{
	public class QuestTextfile : IQuestDAO
	{
		private string workFolderPath = ConfigurationManager.AppSettings["workFolderPath"];
		private string questDatFileName = ConfigurationManager.AppSettings["FileName_questFile"]; // internal DAL
		private HashSet<string> names = new HashSet<string>();
		private HashSet<int> moneyRewards = new HashSet<int>();
		private HashSet<int> relinkRewards = new HashSet<int>();
		private HashSet<int> NeuromancerRewards = new HashSet<int>();
		private HashSet<int> moneyPunish = new HashSet<int>();
		private HashSet<int> relinkPunish = new HashSet<int>();
		private HashSet<int> NeuromancerPunish = new HashSet<int>(); // to list
										// extension for list .getrandmelement
		
		public Quest GetRandomQuest()
		{
			Random rand = new Random(); // grobal random
			return new Quest(
				names.ElementAt(rand.Next(0, names.Count)),
				moneyRewards.ElementAt(rand.Next(0, moneyRewards.Count)),
				relinkRewards.ElementAt(rand.Next(0, relinkRewards.Count)),
				NeuromancerRewards.ElementAt(rand.Next(0, NeuromancerRewards.Count)),
				moneyPunish.ElementAt(rand.Next(0, moneyPunish.Count)),
				relinkPunish.ElementAt(rand.Next(0, relinkPunish.Count)),
				NeuromancerPunish.ElementAt(rand.Next(0, NeuromancerPunish.Count))
				);
		}

		public void Load()
		{
			/*
			 * Format:
			 *
			 * questname;
			 * moneyreward;
			 * relinkreward;
			 * neuromancerreward;
			 * moneypunish;
			 * relinkpunish;
			 * neuromancerpunish;
			 */
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, questDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				string[] asd = default(string[]);

				// names
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.names.Add(item);
				}

				// moneyreward
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.moneyRewards.Add(Int32.Parse(item));
				}

				// relinkreward
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.relinkRewards.Add(Int32.Parse(item));
				}

				// neuromancerreward
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.NeuromancerRewards.Add(Int32.Parse(item));
				}

				// moneypunish
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.moneyPunish.Add(Int32.Parse(item));
				}

				// relinkpunish
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.relinkPunish.Add(Int32.Parse(item));
				}

				// neuromancerpunish
				asd = fin.ReadLine().Trim().Split(';');
				foreach (var item in asd)
				{
					this.NeuromancerPunish.Add(Int32.Parse(item));
				}
			}
		}

		public void Save()
		{
			return;
		}

		
	}
}
