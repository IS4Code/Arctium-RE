using AuthServer.Game.Entities;
using AuthServer.Network;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class CinematicHandler
	{
		public static void HandleStartCinematic(ref WorldClass session)
		{
			Character arg_24_0 = session.Character;
			PacketWriter packetWriter = new PacketWriter(ServerMessage.StartCinematic, true);
			packetWriter.WriteUInt32(0u);
			session.Send(ref packetWriter);
			arg_24_0.LoginCinematic = false;
		}
	}
}
