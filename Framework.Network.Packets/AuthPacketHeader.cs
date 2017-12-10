using Framework.Constants.Net;
using System;

namespace Framework.Network.Packets
{
	public class AuthPacketHeader
	{
		public byte Message
		{
			get;
			set;
		}

		public AuthChannel Channel
		{
			get;
			set;
		}
	}
}
