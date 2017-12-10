using AuthServer.Game.Entities;
using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class LogoutHandler : Manager
	{
		[Opcode2(ClientMessage.CliLogoutRequest, "17658")]
		public static void HandleLogoutRequest(ref PacketReader packet, WorldClass2 session)
		{
			Character character = session.Character;
			PacketWriter packetWriter;
			while (true)
			{
				IL_DA:
				uint arg_B6_0 = 2356821893u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B6_0 ^ 3488573736u)) % 6u)
					{
					case 1u:
						Manager.ObjectMgr.SavePositionToDB(character);
						arg_B6_0 = (num * 2991657712u ^ 1093469771u);
						continue;
					case 2u:
						Manager.WorldMgr.WriteOutOfRangeObjects(Manager.SpawnMgr.GetOutOfRangeCreatures(character), Manager.WorldMgr.Sessions.ToList<KeyValuePair<ulong, WorldClass>>()[0].Value);
						arg_B6_0 = (num * 3357637708u ^ 3124184774u);
						continue;
					case 3u:
						goto IL_DA;
					case 4u:
						Manager.WorldMgr.DeleteSession(character.Guid);
						arg_B6_0 = (num * 1832138036u ^ 1888841376u);
						continue;
					case 5u:
						packetWriter = new PacketWriter(ServerMessage.LogoutComplete, true);
						Manager.WorldMgr.GetSession(character.Guid);
						arg_B6_0 = (num * 1880255037u ^ 1323852181u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}
	}
}
