using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmListTicketIdentity
	{
		[DataMember(Name = "gameAccountID")]
		public int GameAccountId
		{
			get;
			set;
		}

		[DataMember(Name = "gameAccountRegion")]
		public int GameAccountRegion
		{
			get;
			set;
		}
	}
}
