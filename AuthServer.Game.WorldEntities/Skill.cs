using System;
using System.Runtime.Serialization;

namespace AuthServer.Game.WorldEntities
{
	[DataContract]
	[Serializable]
	public class Skill
	{
		[DataMember]
		public uint Id
		{
			get;
			set;
		}

		[DataMember]
		public uint SkillLevel
		{
			get;
			set;
		}
	}
}
