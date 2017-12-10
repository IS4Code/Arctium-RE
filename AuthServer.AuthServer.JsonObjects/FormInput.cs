using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class FormInput
	{
		[DataMember(Name = "input_id")]
		public string Id
		{
			get;
			set;
		}

		[DataMember(Name = "type")]
		public string Type
		{
			get;
			set;
		}

		[DataMember(Name = "label")]
		public string Label
		{
			get;
			set;
		}

		[DataMember(Name = "max_length")]
		public int MaxLength
		{
			get;
			set;
		}
	}
}
