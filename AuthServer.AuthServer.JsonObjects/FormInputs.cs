using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class FormInputs
	{
		[DataMember(Name = "type")]
		public string Type
		{
			get;
			set;
		}

		[DataMember(Name = "inputs")]
		public List<FormInput> Inputs
		{
			get;
			set;
		}
	}
}
