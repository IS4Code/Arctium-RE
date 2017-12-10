using Framework.Constants.Net;
using System;

namespace Framework.Network.Packets
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class Opcode2Attribute : Attribute
	{
		public ClientMessage Opcode
		{
			get;
			set;
		}

		public string WoWBuild
		{
			get;
			set;
		}

		public Opcode2Attribute(ClientMessage opcode, string wowBuild)
		{
			this.Opcode = opcode;
			this.WoWBuild = wowBuild;
		}
	}
}
