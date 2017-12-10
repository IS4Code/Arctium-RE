using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class PostLogonForm
	{
		[DataMember(Name = "authentication_state")]
		public string AuthenticationState
		{
			get;
			set;
		}

		[DataMember(Name = "login_ticket")]
		public string LoginTicket
		{
			get;
			set;
		}
	}
}
