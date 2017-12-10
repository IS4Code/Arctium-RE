using AuthServer.Game.Entities;
using AuthServer.Game.Chat;
using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants;
using Framework.Constants.Net;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.IO;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class ChatHandler : Manager
	{
		[Opcode(ClientMessage.ChatMessageSay, "17930")]
		public static void HandleChatMessageSay(ref PacketReader packet, WorldClass session)
		{
			BitUnpack arg_0F_0 = new BitUnpack(packet);
			int num = packet.Read<int>();
			int num2 = (int)arg_0F_0.GetBits<byte>(8) << 1;
			bool bit = arg_0F_0.GetBit();
			ChatMessageValues chatMessageValues;
			while (true)
			{
				IL_10D:
				uint arg_E0_0 = 325641967u;
				while (true)
				{
					uint num3;
					switch ((num3 = (arg_E0_0 ^ 1114592966u)) % 8u)
					{
					case 0u:
						goto IL_10D;
					case 1u:
					{
						string text = packet.ReadString((uint)(bit ? ((byte)num2 + 1) : ((byte)num2)));
						arg_E0_0 = 1695780296u;
						continue;
					}
					case 2u:
						return;
					case 3u:
					{
						string text;
						arg_E0_0 = ((ChatCommandParser.CheckForCommand(text) ? 3993131816u : 2950447498u) ^ num3 * 3295186339u);
						continue;
					}
					case 4u:
					{
						string text;
						ChatCommandParser.ExecuteChatHandler2(text, Manager.WorldMgr.GetSession2(session.Character.Guid));
						arg_E0_0 = (num3 * 451064634u ^ 332353724u);
						continue;
					}
					case 6u:
					{
						string text;
						chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSay, text, true, true, session.Character.Name);
						chatMessageValues.Language = (byte)num;
						arg_E0_0 = (num3 * 3671775661u ^ 3376883115u);
						continue;
					}
					case 7u:
					{
						string text;
						ChatCommandParser.ExecuteChatHandler(text, session);
						arg_E0_0 = (num3 * 3654367289u ^ 3353498485u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			ChatHandler.SendMessage(ref session, chatMessageValues, null);
		}

		[Opcode(ClientMessage.ChatMessageYell, "17930")]
		public static void HandleChatMessageYell(ref PacketReader packet, WorldClass session)
		{
			new BitUnpack(packet);
			while (true)
			{
				IL_DF:
				uint arg_B2_0 = 1471274433u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B2_0 ^ 1457246423u)) % 8u)
					{
					case 0u:
						goto IL_DF;
					case 1u:
					{
						byte count;
						string message = packet.ReadString((uint)count);
						arg_B2_0 = (num * 1956220272u ^ 333181946u);
						continue;
					}
					case 2u:
					{
						ChatMessageValues chatMessageValues;
						ChatHandler.SendMessage(ref session, chatMessageValues, null);
						arg_B2_0 = (num * 1360094918u ^ 3810658607u);
						continue;
					}
					case 3u:
					{
						ChatMessageValues chatMessageValues;
						int num2;
						chatMessageValues.Language = (byte)num2;
						arg_B2_0 = (num * 1375933563u ^ 3990099844u);
						continue;
					}
					case 5u:
					{
						string message;
						ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageYell, message, true, true, session.Character.Name);
						arg_B2_0 = (num * 1524374222u ^ 112341642u);
						continue;
					}
					case 6u:
					{
						int num2 = packet.Read<int>();
						arg_B2_0 = (num * 3683192221u ^ 500492390u);
						continue;
					}
					case 7u:
					{
						byte count = ChatHandler.smethod_0(packet);
						arg_B2_0 = (num * 1784485323u ^ 3798317019u);
						continue;
					}
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.ChatMessageYell, "17930")]
		public static void HandleChatMessageWhisper(ref PacketReader packet, WorldClass session)
		{
			BitUnpack arg_0F_0 = new BitUnpack(packet);
			packet.Read<int>();
			byte bits = arg_0F_0.GetBits<byte>(8);
			byte bits2 = arg_0F_0.GetBits<byte>(9);
			while (true)
			{
				IL_12D:
				uint arg_FB_0 = 508952321u;
				while (true)
				{
					uint num;
					switch ((num = (arg_FB_0 ^ 680197638u)) % 9u)
					{
					case 0u:
						goto IL_12D;
					case 2u:
					{
						string message;
						ChatMessageValues chatMessage = new ChatMessageValues(MessageType.ChatMessageWhisper, message, false, true, session.Character.Name);
						WorldClass session2;
						ChatHandler.SendMessage(ref session2, chatMessage, session);
						arg_FB_0 = (num * 176779959u ^ 339669786u);
						continue;
					}
					case 3u:
						return;
					case 4u:
					{
						string message;
						ChatMessageValues chatMessage = new ChatMessageValues(MessageType.ChatMessageWhisperInform, message, false, true, session.Character.Name);
						WorldClass session2;
						ChatHandler.SendMessage(ref session, chatMessage, session2);
						arg_FB_0 = 1982110815u;
						continue;
					}
					case 5u:
					{
						string name;
						WorldClass session2 = Manager.WorldMgr.GetSession(name);
						arg_FB_0 = (num * 827851986u ^ 138547638u);
						continue;
					}
					case 6u:
					{
						string name = packet.ReadString((uint)bits2);
						arg_FB_0 = (num * 3640695171u ^ 579213927u);
						continue;
					}
					case 7u:
					{
						string message = packet.ReadString((uint)bits);
						arg_FB_0 = (num * 3110842643u ^ 1736535012u);
						continue;
					}
					case 8u:
					{
						WorldClass session2;
						arg_FB_0 = (((session2 != null) ? 3244820180u : 2596212753u) ^ num * 1051122596u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void SendMessage(ref WorldClass session, ChatMessageValues chatMessage, WorldClass pSession = null)
		{
			Character character = session.Character;
			PacketWriter packetWriter;
			while (true)
			{
				IL_2C6:
				uint arg_280_0 = 3219657197u;
				while (true)
				{
					uint num;
					switch ((num = (arg_280_0 ^ 2724133076u)) % 14u)
					{
					case 0u:
						Manager.WorldMgr.SendByDist(character, packetWriter, 90000f);
						arg_280_0 = 3801484219u;
						continue;
					case 1u:
						goto IL_2CD;
					case 2u:
						packetWriter = new PacketWriter(ServerMessage.Chat, true);
						arg_280_0 = 3086779355u;
						continue;
					case 3u:
					{
						ulong guid = character.Guid;
						arg_280_0 = (num * 2535786402u ^ 3025165946u);
						continue;
					}
					case 4u:
						goto IL_2C6;
					case 5u:
					{
						BitPack arg_1D6_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteUInt8((byte)chatMessage.ChatType);
						packetWriter.WriteUInt8(chatMessage.Language);
						if (chatMessage.ChatType != MessageType.ChatMessageRaidWarning && chatMessage.ChatType != MessageType.ChatMessageSystem)
						{
							ulong guid;
							packetWriter.WriteSmartGuid(guid, global::GuidType.Player);
							packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
							packetWriter.WriteSmartGuid(guid, global::GuidType.Player);
							packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
						}
						else
						{
							packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
							packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
							packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
							packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
						}
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteSmartGuid(0uL, global::GuidType.Player);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteFloat(0f);
						arg_1D6_0.WriteStringLength(chatMessage.From, 11);
						arg_1D6_0.Write<int>(0, 11);
						arg_1D6_0.Write<int>(0, 5);
						arg_1D6_0.Write<int>(0, 7);
						arg_1D6_0.WriteStringLength(chatMessage.Message, 12);
						arg_1D6_0.Write<int>(0, 11);
						arg_1D6_0.Write<bool>(false);
						arg_1D6_0.Write<bool>(false);
						arg_1D6_0.Flush();
						packetWriter.WriteString(chatMessage.From, false);
						arg_280_0 = 3261358435u;
						continue;
					}
					case 6u:
						arg_280_0 = (((pSession != null) ? 3836401640u : 3716149786u) ^ num * 3311463245u);
						continue;
					case 7u:
						return;
					case 9u:
					{
						MessageType chatType;
						arg_280_0 = (((chatType != MessageType.ChatMessageYell) ? 62246047u : 1826229881u) ^ num * 1877845205u);
						continue;
					}
					case 10u:
					{
						ulong guid = pSession.Character.Guid;
						arg_280_0 = (num * 35042165u ^ 1911025126u);
						continue;
					}
					case 11u:
					{
						MessageType chatType;
						arg_280_0 = (((chatType == MessageType.ChatMessageSay) ? 3596693928u : 2666586472u) ^ num * 3026481033u);
						continue;
					}
					case 12u:
						arg_280_0 = (num * 878843307u ^ 1944765790u);
						continue;
					case 13u:
					{
						packetWriter.WriteString(chatMessage.Message, false);
						MessageType chatType = chatMessage.ChatType;
						arg_280_0 = (num * 638995587u ^ 2704000042u);
						continue;
					}
					}
					goto Block_6;
				}
			}
			Block_6:
			goto IL_2E0;
			IL_2CD:
			Manager.WorldMgr.SendByDist(character, packetWriter, 625f);
			return;
			IL_2E0:
			session.Send(ref packetWriter);
		}

		static byte smethod_0(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadByte();
		}
	}
}
