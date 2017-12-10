using System;
using System.Collections.Generic;

namespace AuthServer.WorldServer.Game.Entities
{
	[Serializable]
	public class Creature
	{
		public int Id;

		public string Name;

		public string SubName;

		public string IconName;

		public List<uint> Flag = new List<uint>(2);

		public int Type;

		public int Family;

		public int Rank;

		public List<int> QuestKillNpcId = new List<int>(2);

		public List<int> DisplayInfoId = new List<int>(4);

		public float HealthModifier;

		public float PowerModifier;

		public byte RacialLeader;

		public List<int> QuestItemId = new List<int>(6);

		public int MovementInfoId;

		public int ExpansionRequired;
	}
}
