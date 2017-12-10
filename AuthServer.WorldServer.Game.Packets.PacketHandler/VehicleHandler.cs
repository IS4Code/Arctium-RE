using AuthServer.Network;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;

namespace AuthServer.WorldServer.Game.Packets.PacketHandler
{
	internal class VehicleHandler
	{
		[Opcode(ClientMessage.CastSpell, "21796")]
		public static void HandleCastSpell(ref PacketReader packet, WorldClass session)
		{
		}
	}
}
