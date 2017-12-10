using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class Address
	{
		[DataMember(Name = "ip")]
		public string Ip
		{
			get;
			set;
		}

		[DataMember(Name = "port")]
		public int Port
		{
			get;
			set;
		}
	}
}
