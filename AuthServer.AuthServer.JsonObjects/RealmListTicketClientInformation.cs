using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmListTicketClientInformation
	{
		[DataMember(Name = "info")]
		public RealmListTicketInformation Info
		{
			get;
			set;
		}
	}
}
