using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmListServerIPAddresses
	{
		[DataMember(Name = "families")]
		public IList<Family> Families
		{
			get;
			set;
		}
	}
}
