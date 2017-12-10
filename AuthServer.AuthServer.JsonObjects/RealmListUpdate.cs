using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmListUpdate
	{
		[DataMember(Name = "wowRealmAddress")]
		public uint WowRealmAddress
		{
			get;
			set;
		}

		[DataMember(Name = "update")]
		public Update Update
		{
			get;
			set;
		}

		[DataMember(Name = "deleting")]
		public bool Deleting
		{
			get;
			set;
		}
	}
}
