using Framework.Constants.Net;
using System;

namespace AuthServer.AuthServer.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class BnetServiceAttribute : Attribute
	{
		public BnetServiceHash Hash
		{
			get;
			set;
		}

		public BnetServiceAttribute(BnetServiceHash hash)
		{
			this.Hash = hash;
		}
	}
}
