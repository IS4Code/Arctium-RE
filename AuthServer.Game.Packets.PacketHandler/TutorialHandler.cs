using AuthServer.Network;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class TutorialHandler
	{
		public static void HandleTutorialFlags(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.TutorialFlags, true);
			int num = 0;
			while (true)
			{
				IL_7D:
				uint arg_51_0 = (num < 32) ? 1187423804u : 261051288u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_51_0 ^ 625843242u)) % 5u)
					{
					case 1u:
						session.Send(ref packetWriter);
						arg_51_0 = (num2 * 2264823921u ^ 805874538u);
						continue;
					case 2u:
						goto IL_7D;
					case 3u:
						packetWriter.WriteUInt8(0);
						num++;
						arg_51_0 = 163168761u;
						continue;
					case 4u:
						arg_51_0 = 1187423804u;
						continue;
					}
					return;
				}
			}
		}
	}
}
