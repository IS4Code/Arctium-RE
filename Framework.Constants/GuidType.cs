using System;

namespace Framework.Constants
{
	[Serializable]
	public enum GuidType
	{
		Null,
		Uniq,
		Player,
		Item,
		WorldTransaction,
		StaticDoor,
		Transport,
		Conversation,
		Creature,
		Vehicle,
		Pet,
		GameObject,
		Unit = 8
	}
}
