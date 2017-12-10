using Framework.Constants.Net;
using System;

namespace Framework.Attributes
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class AuthMessageAttribute : Attribute
	{
		public AuthClientMessage Message
		{
			get;
			set;
		}

		public AuthChannel Channel
		{
			get;
			set;
		}

		public AuthMessageAttribute(AuthClientMessage message, AuthChannel channel)
		{
			this.Message = message;
			this.Channel = channel;
		}
	}
}
