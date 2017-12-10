using System;
using System.Runtime.Serialization;

namespace AuthServer.Game.WorldEntities
{
	[DataContract]
	[Serializable]
	public enum PlayerSpellState
	{
		Unchanged,
		Changed,
		New,
		Removed,
		Temporary
	}
}
