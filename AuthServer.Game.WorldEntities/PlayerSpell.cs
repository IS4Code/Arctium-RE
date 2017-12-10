using System;
using System.Runtime.Serialization;

namespace AuthServer.Game.WorldEntities
{
	[DataContract]
	[Serializable]
	public class PlayerSpell
	{
		[DataMember]
		public uint SpellId;

		[DataMember]
		public PlayerSpellState State;

		[DataMember]
		public bool Active;

		[DataMember]
		public bool Dependent;

		[DataMember]
		public bool Disabled;
	}
}
