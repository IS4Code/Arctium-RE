using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmCharacterCountList
	{
		[DataMember(Name = "counts")]
		public IList<object> Counts
		{
			get;
			set;
		}
	}
}
