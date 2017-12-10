using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmListUpdates
	{
		[DataMember(Name = "updates")]
		public IList<RealmListUpdate> Updates
		{
			get;
			set;
		}
	}
}
