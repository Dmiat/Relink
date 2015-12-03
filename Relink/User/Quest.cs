using System;

namespace Relink.Entities
{
	public class Quest
	{
		public string Name { get; set; }
		public int MoneyReward { get; set; }
		public int RelinkReward { get; set; }
		public int NeuromancerReward { get; set; }
		public int MoneyPunish { get; set; }
		public int RelinkPunish { get; set; }
		public int NeuromancerPunish { get; set; }

		public Quest(string name, int moneyReward = 0, int relinkReward = 0, int neuromancerReward = 0, int moneyPunish = 0, int relinkPunish = 0, int neuromancerPunish = 0)
		{
			//json
			//newtonsoft.json (with ne get) get class JObject
			this.Name = name;
			this.MoneyReward = moneyReward;
			this.NeuromancerReward = relinkReward;
			this.RelinkReward = neuromancerReward;
			this.MoneyPunish = moneyPunish;
			this.RelinkPunish = relinkPunish;
			this.NeuromancerPunish = neuromancerPunish;
		}

		public override string ToString()
		{
			return $"Name: {this.Name} {Environment.NewLine} MoneyReward: {this.MoneyReward} {Environment.NewLine} NeuromancerReward: {this.NeuromancerReward} {Environment.NewLine} RelinkReward: {this.RelinkReward} {Environment.NewLine} MoneyPunish: {this.MoneyPunish} {Environment.NewLine} RelinkPunish: {this.RelinkPunish} {Environment.NewLine} NeuromancerPunish: {this.NeuromancerPunish} {Environment.NewLine}";
                }
	}
}