using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class FormInputValue
	{
		[DataMember(Name = "input_id")]
		public string Id
		{
			get;
			set;
		}

		[DataMember(Name = "value")]
		public string Value
		{
			get;
			set;
		}
	}
}
