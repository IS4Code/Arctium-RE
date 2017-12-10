using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.WorldServer.Game.Entities
{
	[DataContract]
	[Serializable]
	public class Item
	{
		[DataMember]
		public ulong Guid
		{
			get;
			set;
		}

		[DataMember]
		public int Id
		{
			get;
			set;
		}

		[DataMember]
		public Dictionary<string, Tuple<int, int>> DisplayInfoIds
		{
			get;
			set;
		}

		[DataMember]
		public int DisplayInfoId
		{
			get;
			set;
		}

		[DataMember]
		public byte InventoryType
		{
			get;
			set;
		}

		[DataMember]
		public int ModId
		{
			get;
			set;
		}

		public Item()
		{
			this.<DisplayInfoIds>k__BackingField = new Dictionary<string, Tuple<int, int>>();
			base..ctor();
		}
	}
}
