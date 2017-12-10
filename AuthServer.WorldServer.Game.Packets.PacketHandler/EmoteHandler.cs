using AuthServer.Game.Packets.PacketHandler;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;
using System.IO;
using System.Linq;

namespace AuthServer.WorldServer.Game.Packets.PacketHandler
{
	public class EmoteHandler
	{
		private static uint currEmote;

		[Opcode2(ClientMessage.Emote, "18125")]
		public static void HandleEmote(ref PacketReader packet, WorldClass2 session)
		{
			uint emote;
			Emote emote2;
			while (true)
			{
				IL_AD:
				uint arg_89_0 = 1752535003u;
				while (true)
				{
					uint num;
					switch ((num = (arg_89_0 ^ 716655401u)) % 6u)
					{
					case 0u:
						return;
					case 2u:
						packet.ReadSmartGuid();
						emote = EmoteHandler.smethod_0(packet);
						EmoteHandler.smethod_0(packet);
						arg_89_0 = (num * 3806359023u ^ 581283706u);
						continue;
					case 3u:
						emote2 = Manager.WorldMgr.EmoteList.SingleOrDefault((Emote e) => (long)e.Id == (long)((ulong)emote));
						arg_89_0 = (num * 608702844u ^ 55036292u);
						continue;
					case 4u:
						goto IL_AD;
					case 5u:
						arg_89_0 = (((emote2 != null) ? 797466682u : 1979322787u) ^ num * 1562950612u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			EmoteHandler.SendEmote((uint)emote2.EmoteId, Manager.WorldMgr.GetSession(session.Character.Guid), null);
		}

		public static void SendEmote(uint emoteId, WorldClass session, WorldObject obj)
		{
			if (EmoteHandler.currEmote == emoteId)
			{
				goto IL_E5;
			}
			goto IL_128;
			uint arg_EF_0;
			while (true)
			{
				IL_EA:
				uint num;
				switch ((num = (arg_EF_0 ^ 1873394811u)) % 11u)
				{
				case 0u:
					goto IL_E5;
				case 1u:
					session.Character.SetUpdateField<uint>(126, EmoteHandler.currEmote, 0);
					arg_EF_0 = (num * 4147380447u ^ 138217182u);
					continue;
				case 2u:
					EmoteHandler.currEmote = 0u;
					arg_EF_0 = (num * 3833008646u ^ 365122923u);
					continue;
				case 3u:
				{
					PacketWriter packetWriter;
					packetWriter.WriteSmartGuid(obj.SGuid);
					arg_EF_0 = 1585922093u;
					continue;
				}
				case 4u:
					return;
				case 5u:
				{
					PacketWriter packetWriter;
					packetWriter.WriteUInt32(EmoteHandler.currEmote);
					arg_EF_0 = (num * 253797390u ^ 407574363u);
					continue;
				}
				case 6u:
					ObjectHandler.HandleUpdateObjectValues(ref session, false);
					arg_EF_0 = (num * 1970048225u ^ 635778716u);
					continue;
				case 7u:
					goto IL_128;
				case 8u:
				{
					PacketWriter packetWriter = new PacketWriter(ServerMessage.Emote, true);
					arg_EF_0 = ((obj != null) ? 1431597716u : 968750983u);
					continue;
				}
				case 9u:
				{
					PacketWriter packetWriter;
					packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
					packetWriter.WriteUInt32(EmoteHandler.currEmote);
					arg_EF_0 = (num * 3022621322u ^ 2711098370u);
					continue;
				}
				}
				break;
			}
			obj.SetUpdateField<uint>(126, EmoteHandler.currEmote, 0);
			ObjectHandler.HandleUpdateObjectValues(ref session, obj, false);
			return;
			IL_E5:
			arg_EF_0 = 471120040u;
			goto IL_EA;
			IL_128:
			EmoteHandler.currEmote = emoteId;
			arg_EF_0 = 1058711449u;
			goto IL_EA;
		}

		static uint smethod_0(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt32();
		}
	}
}
