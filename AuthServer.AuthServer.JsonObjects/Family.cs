using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class Family
	{
		[DataMember(Name = "family")]
		public int Id
		{
			get;
			set;
		}

		[DataMember(Name = "addresses")]
		public IList<Address> Addresses
		{
			get;
			set;
		}
	}
}
