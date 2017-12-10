using AuthServer.Game.Entities;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.IO;

namespace WorldServer.Game.Packets.PacketHandler
{
	public class CacheHandler : Manager
	{
		[Opcode2(ClientMessage.CliQueryCreature, "17930")]
		public static void HandleQueryCreature(ref PacketReader packet, WorldClass2 session)
		{
			int num = packet.Read<int>();
			PacketWriter packetWriter = new PacketWriter(ServerMessage.QueryCreatureResponse, true);
			Creature creature;
			while (true)
			{
				IL_2D5:
				uint arg_273_0 = 935609141u;
				while (true)
				{
					uint num2;
					Creature arg_94_0;
					Creature creature2;
					switch ((num2 = (arg_273_0 ^ 1968969320u)) % 21u)
					{
					case 0u:
						arg_273_0 = (num2 * 1160359644u ^ 1382369928u);
						continue;
					case 1u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0, 11);
						arg_273_0 = (num2 * 677173750u ^ 1461952003u);
						continue;
					}
					case 2u:
					{
						int num3;
						arg_273_0 = ((num3 < 8) ? 494615343u : 1586928102u);
						continue;
					}
					case 3u:
					{
						BitPack bitPack;
						bitPack.Write<int>(CacheHandler.smethod_0(creature.Name) + 1, 11);
						arg_273_0 = (num2 * 1758624067u ^ 374741763u);
						continue;
					}
					case 4u:
					{
						BitPack bitPack;
						bitPack.Write<int>(CacheHandler.smethod_0(creature.IconName) + 1, 6);
						arg_273_0 = (num2 * 1232297304u ^ 4160998185u);
						continue;
					}
					case 5u:
					{
						int num3;
						num3++;
						arg_273_0 = 1308934713u;
						continue;
					}
					case 6u:
					{
						int num3 = 0;
						arg_273_0 = (num2 * 3728719144u ^ 2678938313u);
						continue;
					}
					case 7u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0, 11);
						arg_273_0 = 1141993764u;
						continue;
					}
					case 8u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_273_0 = (num2 * 3762835184u ^ 3777278325u);
						continue;
					}
					case 9u:
					{
						BitPack bitPack;
						bool flag;
						bitPack.Write<bool>(flag);
						arg_273_0 = (num2 * 138756829u ^ 2636086554u);
						continue;
					}
					case 10u:
					{
						bool flag;
						if (flag)
						{
							arg_273_0 = (num2 * 2594936822u ^ 3565690882u);
							continue;
						}
						goto IL_461;
					}
					case 11u:
						arg_94_0 = null;
						goto IL_94;
					case 12u:
					{
						BitPack bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						arg_273_0 = (num2 * 4280214209u ^ 1042752614u);
						continue;
					}
					case 13u:
					{
						int num3;
						arg_273_0 = ((num3 == 0) ? 1779483626u : 1978272905u);
						continue;
					}
					case 14u:
					{
						BitPack bitPack;
						bitPack.Write<byte>(creature.RacialLeader);
						arg_273_0 = (num2 * 1236445006u ^ 3192248368u);
						continue;
					}
					case 16u:
					{
						creature = creature2;
						BitPack bitPack;
						bitPack.Write<int>((CacheHandler.smethod_0(creature.SubName) != 0) ? (CacheHandler.smethod_0(creature.SubName) + 1) : 0, 11);
						arg_273_0 = 1985970779u;
						continue;
					}
					case 17u:
						if (!Manager.ObjectMgr.Creatures.ContainsKey(num))
						{
							arg_273_0 = (num2 * 3085956927u ^ 2159627834u);
							continue;
						}
						arg_94_0 = Manager.ObjectMgr.Creatures[num];
						goto IL_94;
					case 18u:
					{
						bool flag = creature2 != null;
						packetWriter.WriteInt32(num);
						arg_273_0 = (num2 * 2288083706u ^ 371019689u);
						continue;
					}
					case 19u:
						goto IL_2D5;
					case 20u:
					{
						BitPack bitPack;
						bitPack.Flush();
						packetWriter.WriteCString(creature.Name);
						arg_273_0 = (num2 * 2500615134u ^ 1082460273u);
						continue;
					}
					}
					goto Block_6;
					IL_94:
					creature2 = arg_94_0;
					arg_273_0 = 499258206u;
				}
			}
			uint arg_57B_0;
			while (true)
			{
				IL_576:
				uint num2;
				switch ((num2 = (arg_57B_0 ^ 1968969320u)) % 13u)
				{
				case 0u:
					goto IL_5BD;
				case 1u:
					packetWriter.WriteUInt32(0u);
					packetWriter.WriteInt32(0);
					packetWriter.WriteInt32(creature.MovementInfoId);
					arg_57B_0 = (num2 * 2108068086u ^ 2103927701u);
					continue;
				case 2u:
					packetWriter.WriteFloat(creature.PowerModifier);
					arg_57B_0 = (num2 * 3254214234u ^ 1483086716u);
					continue;
				case 3u:
					packetWriter.WriteCString(creature.SubName);
					arg_57B_0 = (num2 * 68929227u ^ 1745800214u);
					continue;
				case 4u:
					arg_57B_0 = ((!CacheHandler.smethod_1(creature.IconName, "")) ? 2105694095u : 1920274108u);
					continue;
				case 6u:
					arg_57B_0 = (num2 * 3208784011u ^ 1758951452u);
					continue;
				case 7u:
					arg_57B_0 = ((CacheHandler.smethod_1(creature.SubName, "") ? 515129868u : 272658274u) ^ num2 * 1474246403u);
					continue;
				case 8u:
					session.Send(ref packetWriter);
					arg_57B_0 = 930990882u;
					continue;
				case 9u:
					goto IL_461;
				case 10u:
					packetWriter.WriteInt32(creature.ExpansionRequired);
					packetWriter.WriteInt32(0);
					arg_57B_0 = (num2 * 374667452u ^ 3127358176u);
					continue;
				case 11u:
					packetWriter.WriteInt32(0);
					packetWriter.WriteInt32(creature.DisplayInfoId[0]);
					packetWriter.WriteInt32(creature.DisplayInfoId[1]);
					packetWriter.WriteInt32(creature.DisplayInfoId[2]);
					packetWriter.WriteInt32(creature.DisplayInfoId[3]);
					packetWriter.WriteFloat(creature.HealthModifier);
					arg_57B_0 = (num2 * 3255905299u ^ 1742458378u);
					continue;
				case 12u:
					packetWriter.WriteCString(creature.IconName);
					arg_57B_0 = (num2 * 3969563941u ^ 2161894101u);
					continue;
				}
				break;
			}
			return;
			Block_6:
			using (List<uint>.Enumerator enumerator = creature.Flag.GetEnumerator())
			{
				while (true)
				{
					IL_359:
					uint arg_32C_0 = enumerator.MoveNext() ? 282529697u : 694090308u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_32C_0 ^ 1968969320u)) % 5u)
						{
						case 0u:
						{
							uint current;
							packetWriter.WriteUInt32(current);
							arg_32C_0 = (num2 * 555555645u ^ 4034385136u);
							continue;
						}
						case 1u:
						{
							uint current = enumerator.Current;
							arg_32C_0 = 2123150290u;
							continue;
						}
						case 2u:
							arg_32C_0 = 282529697u;
							continue;
						case 3u:
							goto IL_359;
						}
						goto Block_12;
					}
				}
				Block_12:;
			}
			packetWriter.WriteInt32(creature.Type);
			packetWriter.WriteInt32(creature.Family);
			packetWriter.WriteInt32(creature.Rank);
			packetWriter.WriteInt32(0);
			goto IL_5BD;
			IL_461:
			Log.Message(LogType.Debug, Module.smethod_36<string>(1817613708u), new object[]
			{
				num
			});
			arg_57B_0 = 2105694095u;
			goto IL_576;
			IL_5BD:
			arg_57B_0 = 602327916u;
			goto IL_576;
		}

		[Opcode2(ClientMessage.CliQueryGameObject, "17930")]
		public static void HandleQueryGameObject(ref PacketReader packet, WorldClass2 session)
		{
			new BitUnpack(packet);
			PacketWriter packetWriter;
			GameObject gameObject;
			int num2;
			while (true)
			{
				IL_1F1:
				uint arg_1AF_0 = 939672256u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1AF_0 ^ 920590424u)) % 13u)
					{
					case 0u:
						packetWriter.WriteInt32(gameObject.Type);
						arg_1AF_0 = (num * 3489202542u ^ 804866110u);
						continue;
					case 1u:
						num2 = packet.Read<int>();
						packetWriter = new PacketWriter(ServerMessage.QueryGameObjectResponse, true);
						arg_1AF_0 = (num * 4230693193u ^ 1260749569u);
						continue;
					case 2u:
						goto IL_1F1;
					case 3u:
					{
						int num3;
						arg_1AF_0 = ((num3 < 3) ? 649306648u : 501273771u);
						continue;
					}
					case 4u:
						packetWriter.WriteCString(gameObject.CastBarCaption);
						arg_1AF_0 = (num * 1049916045u ^ 2977864359u);
						continue;
					case 5u:
					{
						int num3 = 0;
						arg_1AF_0 = (num * 1422964311u ^ 1103477659u);
						continue;
					}
					case 6u:
						packetWriter.WriteInt32(gameObject.DisplayInfoId);
						packetWriter.WriteCString(gameObject.Name);
						arg_1AF_0 = (num * 1555460888u ^ 1306993837u);
						continue;
					case 7u:
					{
						GameObject gameObject2;
						gameObject = gameObject2;
						arg_1AF_0 = (num * 3863233653u ^ 3067406073u);
						continue;
					}
					case 8u:
						arg_1AF_0 = (num * 3223686670u ^ 3681640510u);
						continue;
					case 10u:
						packetWriter.WriteCString(gameObject.IconName);
						arg_1AF_0 = (num * 719648425u ^ 184840880u);
						continue;
					case 11u:
					{
						packetWriter.WriteCString("");
						int num3;
						num3++;
						arg_1AF_0 = 997737950u;
						continue;
					}
					case 12u:
					{
						BitPack arg_69_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						GameObject gameObject2 = Manager.ObjectMgr.GameObjects.ContainsKey(num2) ? Manager.ObjectMgr.GameObjects[num2] : null;
						bool flag = gameObject2 != null;
						packetWriter.WriteInt32(num2);
						arg_69_0.Write<bool>(flag);
						arg_69_0.Flush();
						packetWriter.WriteInt32(0);
						if (flag)
						{
							arg_1AF_0 = 1462109909u;
							continue;
						}
						goto IL_3B5;
					}
					}
					goto Block_4;
				}
			}
			uint arg_390_0;
			uint data;
			while (true)
			{
				IL_38B:
				uint num;
				switch ((num = (arg_390_0 ^ 920590424u)) % 6u)
				{
				case 0u:
					arg_390_0 = (num * 1830974033u ^ 1499644793u);
					continue;
				case 2u:
					goto IL_376;
				case 3u:
					session.Send(ref packetWriter);
					arg_390_0 = 1203705223u;
					continue;
				case 4u:
					packetWriter.WriteUInt32Pos(data, 10);
					arg_390_0 = (num * 267662565u ^ 3800569846u);
					continue;
				case 5u:
					goto IL_3B5;
				}
				break;
			}
			return;
			Block_4:
			packetWriter.WriteCString(gameObject.Unk);
			using (List<int>.Enumerator enumerator = gameObject.Data.GetEnumerator())
			{
				while (true)
				{
					IL_26E:
					int arg_245_0 = (!enumerator.MoveNext()) ? 1793865676 : 1818950977;
					while (true)
					{
						switch ((arg_245_0 ^ 920590424) % 4)
						{
						case 1:
						{
							int current = enumerator.Current;
							packetWriter.WriteInt32(current);
							arg_245_0 = 1520035619;
							continue;
						}
						case 2:
							arg_245_0 = 1818950977;
							continue;
						case 3:
							goto IL_26E;
						}
						goto Block_9;
					}
				}
				Block_9:;
			}
			packetWriter.WriteFloat(gameObject.Size);
			packetWriter.WriteUInt8((byte)gameObject.QuestItemId.Count);
			using (List<int>.Enumerator enumerator = gameObject.QuestItemId.GetEnumerator())
			{
				while (true)
				{
					IL_312:
					int arg_2E9_0 = enumerator.MoveNext() ? 1696554899 : 1349067385;
					while (true)
					{
						switch ((arg_2E9_0 ^ 920590424) % 4)
						{
						case 0:
							goto IL_312;
						case 2:
							arg_2E9_0 = 1696554899;
							continue;
						case 3:
						{
							int current2 = enumerator.Current;
							packetWriter.WriteInt32(current2);
							arg_2E9_0 = 2058465060;
							continue;
						}
						}
						goto Block_13;
					}
				}
				Block_13:;
			}
			packetWriter.WriteInt32(gameObject.ExpansionRequired);
			data = (uint)CacheHandler.smethod_3(CacheHandler.smethod_2(packetWriter)) - 14u;
			IL_376:
			arg_390_0 = 842632948u;
			goto IL_38B;
			IL_3B5:
			Log.Message(LogType.Debug, Module.smethod_33<string>(1557632366u), new object[]
			{
				num2
			});
			arg_390_0 = 1862001515u;
			goto IL_38B;
		}

		[Opcode(ClientMessage.ChatMessageYell, "17930")]
		public static void HandleCliQueryNPCText(ref PacketReader packet, WorldClass session)
		{
		}

		[Opcode(ClientMessage.QueryPlayerName, "17930")]
		public static void HandleQueryPlayerName(ref PacketReader packet, WorldClass session)
		{
			new BitUnpack(packet);
			while (true)
			{
				IL_2C4:
				uint arg_266_0 = 471575205u;
				while (true)
				{
					uint num;
					switch ((num = (arg_266_0 ^ 1440773968u)) % 20u)
					{
					case 0u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_266_0 = (num * 9976705u ^ 4278873949u);
						continue;
					}
					case 1u:
					{
						PacketWriter packetWriter;
						ulong guid;
						packetWriter.WriteSmartGuid(guid, GuidType.Player);
						arg_266_0 = (num * 3356870011u ^ 2872268516u);
						continue;
					}
					case 2u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.QueryPlayerNameResponse, true);
						arg_266_0 = (num * 1962979321u ^ 1311665818u);
						continue;
					}
					case 3u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						Character character;
						bitPack.Write<int>(CacheHandler.smethod_0(character.Name), 6);
						arg_266_0 = (num * 593699102u ^ 4074552841u);
						continue;
					}
					case 4u:
					{
						PacketWriter packetWriter;
						BitPack bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						arg_266_0 = (num * 98231616u ^ 3990223424u);
						continue;
					}
					case 5u:
					{
						ulong guid = packet.ReadSmartGuid();
						arg_266_0 = (num * 1518480733u ^ 2785396495u);
						continue;
					}
					case 6u:
					{
						Character character = session.Character;
						arg_266_0 = (num * 3329339062u ^ 2472802355u);
						continue;
					}
					case 8u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0, 7);
						int num2;
						num2++;
						arg_266_0 = 2068035702u;
						continue;
					}
					case 9u:
					{
						PacketWriter packetWriter;
						ulong guid;
						packetWriter.WriteSmartGuid(guid, GuidType.Player);
						packetWriter.WriteSmartGuid(guid, GuidType.Player);
						packetWriter.WriteSmartGuid(guid, GuidType.Player);
						arg_266_0 = (num * 383643938u ^ 3979968437u);
						continue;
					}
					case 10u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_266_0 = (num * 761741687u ^ 799826553u);
						continue;
					}
					case 11u:
					{
						int num2 = 0;
						arg_266_0 = (num * 313403947u ^ 3917986335u);
						continue;
					}
					case 12u:
					{
						PacketWriter packetWriter;
						Character character;
						packetWriter.WriteString(character.Name, true);
						arg_266_0 = (num * 3484391811u ^ 3965746378u);
						continue;
					}
					case 13u:
					{
						PacketWriter packetWriter;
						Character character;
						packetWriter.WriteUInt8(character.Gender);
						packetWriter.WriteUInt8(character.Class);
						packetWriter.WriteUInt8(character.Level);
						arg_266_0 = (num * 1948881771u ^ 2848931159u);
						continue;
					}
					case 14u:
					{
						int num2;
						arg_266_0 = ((num2 < 5) ? 1177672364u : 684800184u);
						continue;
					}
					case 15u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(1u);
						Character character;
						packetWriter.WriteUInt8(character.Race);
						arg_266_0 = (num * 2813796845u ^ 22854294u);
						continue;
					}
					case 16u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(0);
						arg_266_0 = (num * 814051796u ^ 671529825u);
						continue;
					}
					case 17u:
						goto IL_2C4;
					case 18u:
					{
						ulong guid;
						Manager.WorldMgr.GetSession(guid);
						arg_266_0 = (num * 1913069791u ^ 1097462928u);
						continue;
					}
					case 19u:
					{
						Character character;
						arg_266_0 = (((character == null) ? 259922602u : 215274471u) ^ num * 2701800891u);
						continue;
					}
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.QueryRealmName, "17930")]
		public static void HandleQueryRealmName(ref PacketReader packet, WorldClass session)
		{
			Character arg_06_0 = session.Character;
			PacketWriter packetWriter;
			while (true)
			{
				IL_11C:
				uint arg_F4_0 = 2976964066u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F4_0 ^ 4166151237u)) % 7u)
					{
					case 0u:
					{
						string text;
						packetWriter.WriteString(text, true);
						arg_F4_0 = (num * 113468112u ^ 614109454u);
						continue;
					}
					case 1u:
					{
						uint data = packet.Read<uint>();
						arg_F4_0 = (num * 1651165884u ^ 74766170u);
						continue;
					}
					case 2u:
						goto IL_11C;
					case 3u:
					{
						BitPack arg_7F_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						uint data;
						packetWriter.WriteUInt32(data);
						packetWriter.WriteUInt8(0);
						arg_7F_0.Write<int>(1);
						arg_7F_0.Write<int>(0);
						string text;
						arg_7F_0.Write<int>(CacheHandler.smethod_0(text), 8);
						arg_7F_0.Write<int>(CacheHandler.smethod_0(text), 8);
						arg_7F_0.Flush();
						packetWriter.WriteString(text, true);
						arg_F4_0 = (num * 1933647756u ^ 4288531599u);
						continue;
					}
					case 4u:
						packetWriter = new PacketWriter(ServerMessage.RealmQueryResponse, true);
						arg_F4_0 = (num * 1626494029u ^ 1913905659u);
						continue;
					case 6u:
					{
						string text = Module.smethod_36<string>(4208195762u);
						arg_F4_0 = (num * 2984712636u ^ 1236121516u);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}

		[Opcode(ClientMessage.ChatMessageYell, "17930")]
		public static void HandleDBQueryBulk(ref PacketReader packet, WorldClass session)
		{
		}

		public static void SendHotfixes(WorldClass session)
		{
		}

		public static void HandleBroadcastText(ref WorldClass session, int id)
		{
		}

		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static Stream smethod_2(BinaryWriter binaryWriter_0)
		{
			return binaryWriter_0.BaseStream;
		}

		static long smethod_3(Stream stream_0)
		{
			return stream_0.Length;
		}
	}
}
