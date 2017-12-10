using Framework.Constants.Net;
using System;

namespace Framework.Network.Packets
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class OpcodeAttribute : Attribute
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

		public OpcodeAttribute(ClientMessage opcode, string wowBuild)
		{
			while (true)
			{
				IL_53:
				uint arg_37_0 = 863362973u;
				while (true)
				{
					uint num;
					switch ((num = (arg_37_0 ^ 107037266u)) % 4u)
					{
					case 0u:
						this.WoWBuild = wowBuild;
						arg_37_0 = (num * 2679755926u ^ 3411717595u);
						continue;
					case 2u:
						goto IL_53;
					case 3u:
						this.Opcode = opcode;
						arg_37_0 = (num * 1265873067u ^ 1408933031u);
						continue;
					}
					return;
				}
			}
		}
	}
}
