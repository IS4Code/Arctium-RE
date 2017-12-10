using AuthServer.Game.Entities;
using AuthServer.Game.Chat;
using AuthServer.Game.PacketHandler;
using AuthServer.Game.Packets.PacketHandler;
using AuthServer.Game.WorldEntities;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Game.Packets.PacketHandler;
using AuthServer.WorldServer.Managers;
using Framework.Constants;
using Framework.Constants.Net;
using Framework.Misc;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AuthServer.WorldServer.Game.Chat.Commands
{
	public class PlayerCommands
	{
		[ChatCommand("token", "Usage: !fly #state (Turns the fly mode 'on' or 'off')")]
		public static void Token(string[] args, WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.TokenBalance, true);
			while (true)
			{
				IL_6F:
				uint arg_57_0 = 1763307969u;
				while (true)
				{
					uint num;
					switch ((num = (arg_57_0 ^ 1636081516u)) % 3u)
					{
					case 1u:
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt64(100uL);
						packetWriter.WriteUInt64(100uL);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt8(128);
						arg_57_0 = (num * 1182945109u ^ 3991643388u);
						continue;
					case 2u:
						goto IL_6F;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}

		[ChatCommand("pepe", "Usage: !fly #state (Turns the fly mode 'on' or 'off')")]
		public static void Pepe(string[] args, WorldClass session)
		{
			uint key = Command.Read<uint>(args, 1);
			while (true)
			{
				IL_1B6:
				uint arg_179_0 = 1718620233u;
				while (true)
				{
					uint num;
					switch ((num = (arg_179_0 ^ 632479821u)) % 12u)
					{
					case 0u:
					{
						Character character;
						character.SetUpdateField<uint>(197, Manager.WorldMgr.SpellVisualIds[key], 0);
						ObjectHandler.HandleUpdateObjectValues(ref session, false);
						arg_179_0 = (num * 1482540242u ^ 3396001420u);
						continue;
					}
					case 1u:
					{
						Character character;
						arg_179_0 = (((character.TargetGuid != 0uL) ? 3547717079u : 4139604592u) ^ num * 2531616229u);
						continue;
					}
					case 2u:
						goto IL_1B6;
					case 3u:
					{
						Character character;
						WorldObject worldObject;
						arg_179_0 = ((character.InRangeObjects.TryGetValue(character.TargetGuid, out worldObject) ? 610091185u : 910267601u) ^ num * 472408399u);
						continue;
					}
					case 4u:
					{
						Character character = session.Character;
						arg_179_0 = (num * 3588819684u ^ 2278578907u);
						continue;
					}
					case 5u:
					{
						WorldObject worldObject;
						worldObject.SetUpdateField<uint>(51, Manager.WorldMgr.SpellVisualIds[key], 0);
						arg_179_0 = (num * 4251318012u ^ 1944527522u);
						continue;
					}
					case 6u:
						return;
					case 7u:
					{
						WorldObject worldObject;
						worldObject.SetUpdateField<uint>(197, Manager.WorldMgr.SpellVisualIds[key], 0);
						arg_179_0 = (num * 2587597175u ^ 1311852375u);
						continue;
					}
					case 8u:
					{
						Character character;
						character.SetUpdateField<uint>(51, Manager.WorldMgr.SpellVisualIds[key], 0);
						arg_179_0 = 716724225u;
						continue;
					}
					case 10u:
					{
						Character character;
						arg_179_0 = (((character == null) ? 3347781018u : 2509900318u) ^ num * 616928269u);
						continue;
					}
					case 11u:
					{
						WorldObject worldObject;
						ObjectHandler.HandleUpdateObjectValues(ref session, worldObject, false);
						arg_179_0 = (num * 2614470153u ^ 102468488u);
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:;
		}

		[ChatCommand("additem", "Usage: !additem #id (space seperated)")]
		public static void AddItem(string[] args, WorldClass session)
		{
			int num = 1;
			while (true)
			{
				IL_434:
				uint arg_3C6_0 = 1829759189u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3C6_0 ^ 1674950473u)) % 24u)
					{
					case 1u:
						ObjectHandler.HandleUpdateObjectValues(ref session, false);
						arg_3C6_0 = (num2 * 537081957u ^ 3186376958u);
						continue;
					case 2u:
						num++;
						arg_3C6_0 = 75021146u;
						continue;
					case 3u:
					{
						string[] array;
						arg_3C6_0 = (((array.Length == 2) ? 1232050948u : 1915115869u) ^ num2 * 2595338616u);
						continue;
					}
					case 4u:
						arg_3C6_0 = ((session.Character != null) ? 291931743u : 1735681059u);
						continue;
					case 5u:
					{
						string[] array;
						string key = array[1];
						arg_3C6_0 = (num2 * 4197116070u ^ 1286010251u);
						continue;
					}
					case 6u:
					{
						Item item;
						session.Character.Bag.Add((byte)(23 + session.Character.Bag.Count), item);
						SmartGuid smartGuid;
						ObjectHandler.HandleUpdateObjectCreateItem(smartGuid, item, ref session);
						session.Character.SetUpdateField<ulong>(1085 + (23 + (session.Character.Bag.Count - 1)) * 4, smartGuid.Guid, 0);
						arg_3C6_0 = (num2 * 2906721303u ^ 2992431741u);
						continue;
					}
					case 7u:
					{
						SmartGuid smartGuid = new SmartGuid((ulong)((long)(session.Character.Equipment.Count + session.Character.Bag.Count) + 1L), 0, global::GuidType.Item, 0uL);
						arg_3C6_0 = 427942867u;
						continue;
					}
					case 8u:
					{
						string key;
						Item item2;
						Tuple<int, int> value;
						arg_3C6_0 = (((!item2.DisplayInfoIds.TryGetValue(key, out value)) ? 147921934u : 415209884u) ^ num2 * 980580965u);
						continue;
					}
					case 9u:
					{
						Item item;
						item.ModId = 0;
						arg_3C6_0 = (num2 * 1739646005u ^ 1970339299u);
						continue;
					}
					case 10u:
					{
						KeyValuePair<string, Tuple<int, int>> keyValuePair;
						Tuple<int, int> value = keyValuePair.Value;
						arg_3C6_0 = (num2 * 2872625823u ^ 1149135434u);
						continue;
					}
					case 11u:
						arg_3C6_0 = (((!session.Character.Bag.ContainsKey((byte)(23 + session.Character.Bag.Count))) ? 3267056309u : 2867974769u) ^ num2 * 501669318u);
						continue;
					case 12u:
						arg_3C6_0 = (num2 * 2629657664u ^ 2925816922u);
						continue;
					case 13u:
					{
						Item item;
						item.DisplayInfoId = 0;
						arg_3C6_0 = 1924704u;
						continue;
					}
					case 14u:
					{
						SmartGuid smartGuid;
						session.Character.SetUpdateField<ulong>(1085 + (23 + (session.Character.Bag.Count - 1)) * 4 + 2, smartGuid.HighGuid, 0);
						arg_3C6_0 = (num2 * 19108411u ^ 1876869570u);
						continue;
					}
					case 15u:
					{
						Item item2;
						KeyValuePair<string, Tuple<int, int>> keyValuePair = item2.DisplayInfoIds.First<KeyValuePair<string, Tuple<int, int>>>();
						arg_3C6_0 = (num2 * 1957593868u ^ 2780049903u);
						continue;
					}
					case 16u:
					{
						Item item;
						Tuple<int, int> value;
						item.ModId = value.Item2;
						arg_3C6_0 = (num2 * 618062442u ^ 2937530254u);
						continue;
					}
					case 17u:
					{
						Command.Read<string>(args, num);
						string[] array = PlayerCommands.smethod_0(args[num], new char[]
						{
							','
						});
						int key2 = int.Parse(array[0]);
						string key = Module.smethod_35<string>(792828044u);
						arg_3C6_0 = 1184314290u;
						continue;
					}
					case 18u:
					{
						Item item;
						SmartGuid smartGuid;
						item.Guid = smartGuid.Guid;
						arg_3C6_0 = (num2 * 663636228u ^ 349664418u);
						continue;
					}
					case 19u:
						arg_3C6_0 = ((num < args.Length) ? 66922632u : 1568779497u);
						continue;
					case 20u:
					{
						Item item2;
						Item item = Manager.WorldMgr.Clone<Item>(item2);
						arg_3C6_0 = (((item2.DisplayInfoIds.Count > 0) ? 2398290181u : 3862010328u) ^ num2 * 1331310107u);
						continue;
					}
					case 21u:
					{
						Item item;
						Tuple<int, int> value;
						item.DisplayInfoId = value.Item1;
						arg_3C6_0 = 1870228257u;
						continue;
					}
					case 22u:
					{
						Item item2;
						int key2;
						arg_3C6_0 = ((Manager.Equipments.AvailableItems.TryGetValue(key2, out item2) ? 249080243u : 952724005u) ^ num2 * 849715817u);
						continue;
					}
					case 23u:
						goto IL_434;
					}
					return;
				}
			}
		}

		public static void redirect(string[] args, WorldClass session)
		{
			Command.Read<byte>(args, 1);
			ushort port = Command.Read<ushort>(args, 2);
			AuthenticationHandler.HandleConnectTo(session, port, 1, null);
		}

		public static void resume(string[] args, WorldClass2 session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.ResumeComms, true);
			AuthenticationHandler.session2.Send(ref packetWriter);
		}

		[ChatCommand("scale", "Usage: !morph #size")]
		public static void Scale(string[] args, WorldClass session)
		{
			float value = Command.Read<float>(args, 1);
			while (true)
			{
				IL_88:
				uint arg_68_0 = 4283022209u;
				while (true)
				{
					uint num;
					switch ((num = (arg_68_0 ^ 2334673387u)) % 5u)
					{
					case 1u:
					{
						Character character = session.Character;
						arg_68_0 = (((character != null) ? 2875468458u : 2165037985u) ^ num * 3832046762u);
						continue;
					}
					case 2u:
						ObjectHandler.HandleUpdateObjectValues(ref session, false);
						arg_68_0 = (num * 4030837747u ^ 3617015413u);
						continue;
					case 3u:
						goto IL_88;
					case 4u:
					{
						Character character;
						character.SetUpdateField<float>(11, value, 0);
						arg_68_0 = (num * 4124739661u ^ 604476506u);
						continue;
					}
					}
					return;
				}
			}
		}

		[ChatCommand("morph", "Usage: !morph #displayId (Change the current displayId for your own character)")]
		public static void Morph(string[] args, WorldClass session)
		{
			uint value = Command.Read<uint>(args, 1);
			while (true)
			{
				IL_158:
				uint arg_11F_0 = 63500067u;
				while (true)
				{
					uint num;
					switch ((num = (arg_11F_0 ^ 476227230u)) % 11u)
					{
					case 1u:
						return;
					case 2u:
					{
						Character character;
						character.SetUpdateField<uint>(105, value, 0);
						character.SetUpdateField<uint>(106, value, 0);
						arg_11F_0 = 613835216u;
						continue;
					}
					case 3u:
					{
						Character character = session.Character;
						arg_11F_0 = (num * 476781196u ^ 1888348752u);
						continue;
					}
					case 4u:
					{
						Character character;
						WorldObject worldObject;
						arg_11F_0 = (((!character.InRangeObjects.TryGetValue(character.TargetGuid, out worldObject)) ? 2509420664u : 3957326664u) ^ num * 340830921u);
						continue;
					}
					case 5u:
						ObjectHandler.HandleUpdateObjectValues(ref session, false);
						arg_11F_0 = (num * 3531595648u ^ 3174139861u);
						continue;
					case 6u:
					{
						WorldObject worldObject;
						worldObject.SetUpdateField<uint>(106, value, 0);
						ObjectHandler.HandleUpdateObjectValues(ref session, worldObject, false);
						arg_11F_0 = (num * 2802560967u ^ 1545472198u);
						continue;
					}
					case 7u:
					{
						WorldObject worldObject;
						worldObject.SetUpdateField<uint>(105, value, 0);
						arg_11F_0 = (num * 1539819193u ^ 1189985039u);
						continue;
					}
					case 8u:
					{
						Character character;
						arg_11F_0 = (((character.TargetGuid == 0uL) ? 882975940u : 1605636547u) ^ num * 1709330534u);
						continue;
					}
					case 9u:
					{
						Character character;
						arg_11F_0 = (((character != null) ? 2401194492u : 3921580979u) ^ num * 3948722587u);
						continue;
					}
					case 10u:
						goto IL_158;
					}
					return;
				}
			}
		}

		[ChatCommand("move", "")]
		public static void MoveMonster(string[] args, WorldClass session)
		{
			Character character = session.Character;
			while (true)
			{
				IL_AC:
				uint arg_90_0 = 1715452917u;
				while (true)
				{
					uint num;
					switch ((num = (arg_90_0 ^ 101168722u)) % 4u)
					{
					case 0u:
						goto IL_AC;
					case 1u:
					{
						WorldObject worldObject;
						character.InRangeObjects.TryGetValue(character.TargetGuid, out worldObject);
						arg_90_0 = (num * 1873354886u ^ 1428528878u);
						continue;
					}
					case 3u:
						new BitPack(new PacketWriter(ServerMessage.MonsterMove, true), 0uL, 0uL, 0uL, 0uL);
						arg_90_0 = (((character.TargetGuid == 0uL) ? 307058786u : 1196434273u) ^ num * 3633925430u);
						continue;
					}
					return;
				}
			}
		}

		[ChatCommand("ad", "")]
		public static void Ad(string[] args, WorldClass session)
		{
			CharacterHandler.chatRunning = !CharacterHandler.chatRunning;
		}

		[ChatCommand("emote", "")]
		public static void Emote(string[] args, WorldClass session)
		{
			uint num = Command.Read<uint>(args, 1);
			Character character = session.Character;
			while (true)
			{
				IL_117:
				uint arg_E6_0 = 2943245641u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E6_0 ^ 4158616629u)) % 9u)
					{
					case 0u:
					{
						WorldObject obj;
						EmoteHandler.SendEmote(num, session, obj);
						arg_E6_0 = (num2 * 3198014440u ^ 740941437u);
						continue;
					}
					case 2u:
						goto IL_117;
					case 3u:
						Manager.SpawnMgr.UpdateSpawnEmote(character.TargetGuid, (int)num);
						arg_E6_0 = (num2 * 337297984u ^ 3395473971u);
						continue;
					case 4u:
						arg_E6_0 = (((character == null) ? 3050889447u : 3931306584u) ^ num2 * 356843814u);
						continue;
					case 5u:
						return;
					case 6u:
						arg_E6_0 = (((character.TargetGuid == 0uL) ? 2416919021u : 3702899840u) ^ num2 * 1965687462u);
						continue;
					case 7u:
						EmoteHandler.SendEmote(num, session, null);
						arg_E6_0 = 2151236751u;
						continue;
					case 8u:
					{
						WorldObject obj;
						arg_E6_0 = ((character.InRangeObjects.TryGetValue(character.TargetGuid, out obj) ? 2180342551u : 2149252405u) ^ num2 * 3369828462u);
						continue;
					}
					}
					return;
				}
			}
		}

		[ChatCommand2("fly", "Usage: !fly #state (Turns the fly mode 'on' or 'off')")]
		public static void Fly(string[] args, WorldClass2 session)
		{
			string string_ = Command.Read<string>(args, 1);
			ChatMessageValues chatMessage;
			WorldClass session2;
			while (true)
			{
				IL_143:
				uint arg_111_0 = 74139009u;
				while (true)
				{
					uint num;
					string arg_97_0;
					string message;
					switch ((num = (arg_111_0 ^ 751543426u)) % 9u)
					{
					case 0u:
						goto IL_143;
					case 1u:
						arg_111_0 = (PlayerCommands.smethod_1(string_, Module.smethod_35<string>(1142952995u)) ? 1156352228u : 1876095834u);
						continue;
					case 2u:
						if (!PlayerCommands.smethod_1(string_, Module.smethod_34<string>(3568268802u)))
						{
							arg_111_0 = (num * 889914241u ^ 4118200537u);
							continue;
						}
						arg_97_0 = Module.smethod_33<string>(1125855370u);
						goto IL_97;
					case 3u:
						arg_97_0 = Module.smethod_33<string>(1343156060u);
						goto IL_97;
					case 4u:
						chatMessage = new ChatMessageValues(MessageType.ChatMessageSystem, message, false, false, "");
						arg_111_0 = ((PlayerCommands.smethod_1(string_, Module.smethod_36<string>(1227666401u)) ? 2103906062u : 285076005u) ^ num * 40417034u);
						continue;
					case 6u:
						goto IL_14B;
					case 7u:
						MoveHandler.HandleMoveUnsetCanFly(ref session);
						ChatHandler.SendMessage(ref session2, chatMessage, null);
						arg_111_0 = (num * 901046953u ^ 3272910860u);
						continue;
					case 8u:
						MoveHandler.HandleMoveSetCanFly(ref session);
						arg_111_0 = (num * 2102033886u ^ 2020440812u);
						continue;
					}
					return;
					IL_97:
					message = arg_97_0;
					session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
					arg_111_0 = 1815729218u;
				}
			}
			return;
			IL_14B:
			ChatHandler.SendMessage(ref session2, chatMessage, null);
		}

		[ChatCommand("loc", "Usage: !loc #name (If name is used the location will be written to 'locations.txt'")]
		public static void Loc(string[] args, WorldClass session)
		{
			StringBuilder stringBuilder = PlayerCommands.smethod_2();
			while (true)
			{
				IL_1DD:
				uint arg_1A7_0 = 3261115234u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1A7_0 ^ 3513100511u)) % 10u)
					{
					case 0u:
					{
						Character character;
						string text;
						PlayerCommands.smethod_3(stringBuilder, Module.smethod_36<string>(4228929354u), new object[]
						{
							character.Position.X,
							character.Position.Y,
							character.Position.Z,
							character.Map,
							text
						});
						WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_1A7_0 = 3547119953u;
						continue;
					}
					case 1u:
					{
						Character character = session.Character;
						arg_1A7_0 = (num * 1193712059u ^ 205718962u);
						continue;
					}
					case 2u:
					{
						WorldClass session2;
						ChatMessageValues chatMessageValues;
						ChatHandler.SendMessage(ref session2, chatMessageValues, null);
						arg_1A7_0 = (((args.Length == 2) ? 3301650u : 861707431u) ^ num * 2532835481u);
						continue;
					}
					case 3u:
						goto IL_1DD;
					case 5u:
					{
						string text = Command.Read<string>(args, 1);
						arg_1A7_0 = (num * 3003187881u ^ 3619766294u);
						continue;
					}
					case 6u:
					{
						string text = Module.smethod_34<string>(2443429458u);
						arg_1A7_0 = (((args.Length == 2) ? 2241954866u : 4138748003u) ^ num * 403371386u);
						continue;
					}
					case 7u:
					{
						ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSay, "", false, false, "");
						string message;
						chatMessageValues.Message = message;
						arg_1A7_0 = (num * 3459372250u ^ 2827844733u);
						continue;
					}
					case 8u:
					{
						string message = PlayerCommands.smethod_4(stringBuilder);
						arg_1A7_0 = (num * 604131715u ^ 1080288080u);
						continue;
					}
					case 9u:
						PlayerCommands.smethod_6(PlayerCommands.smethod_5(Helper.DataDirectory(), Module.smethod_37<string>(205042696u)), PlayerCommands.smethod_4(stringBuilder));
						arg_1A7_0 = (num * 365716950u ^ 1501688729u);
						continue;
					}
					return;
				}
			}
		}

		public static void Pos(string[] args, WorldClass session)
		{
			StringBuilder stringBuilder = PlayerCommands.smethod_2();
			Character character = session.Character;
			while (true)
			{
				IL_9A:
				uint arg_82_0 = 1957202373u;
				while (true)
				{
					uint num;
					switch ((num = (arg_82_0 ^ 1639149000u)) % 3u)
					{
					case 1u:
						PlayerCommands.smethod_3(stringBuilder, Module.smethod_34<string>(2818375906u), new object[]
						{
							character.Position.X,
							character.Position.Y,
							character.Position.Z,
							character.Map
						});
						arg_82_0 = (num * 185926334u ^ 559745566u);
						continue;
					case 2u:
						goto IL_9A;
					}
					goto Block_1;
				}
			}
			Block_1:
			PlayerCommands.smethod_7(Module.smethod_35<string>(751232362u), PlayerCommands.smethod_4(stringBuilder));
		}

		[ChatCommand2("tele", "Usage: !tele [#x #y #z #o #map]")]
		public static void Teleport(string[] args, WorldClass2 session)
		{
			Character character = session.Character;
			Vector4 vector = null;
			while (true)
			{
				IL_242:
				uint arg_1F0_0 = 2112909349u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1F0_0 ^ 700326001u)) % 17u)
					{
					case 0u:
						arg_1F0_0 = (((args.Length != 6) ? 705920024u : 1577708191u) ^ num * 4023469191u);
						continue;
					case 1u:
						goto IL_249;
					case 2u:
					{
						WorldClass session2;
						ObjectHandler.HandleUpdateObjectCreate(ref session2, false);
						arg_1F0_0 = (num * 588693918u ^ 1430701430u);
						continue;
					}
					case 3u:
					{
						uint num2 = 0u;
						arg_1F0_0 = (num * 4163379390u ^ 2139403819u);
						continue;
					}
					case 4u:
					{
						vector.O = Command.Read<float>(args, 4);
						uint num2 = Command.Read<uint>(args, 5);
						arg_1F0_0 = (num * 3616440802u ^ 4146376212u);
						continue;
					}
					case 5u:
						goto IL_242;
					case 6u:
						arg_1F0_0 = ((vector == null) ? 1586124666u : 1574237313u);
						continue;
					case 7u:
					{
						WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_1F0_0 = (num * 1045242768u ^ 3372533483u);
						continue;
					}
					case 8u:
					{
						uint num2;
						Manager.ObjectMgr.SetMap(ref character, num2, true);
						arg_1F0_0 = (num * 2796418504u ^ 3686915041u);
						continue;
					}
					case 9u:
						arg_1F0_0 = (((args.Length > 2) ? 2243806273u : 3241221484u) ^ num * 3475097384u);
						continue;
					case 10u:
					{
						uint num2 = Command.Read<uint>(args, 4);
						arg_1F0_0 = 1218564924u;
						continue;
					}
					case 11u:
					{
						uint num2;
						arg_1F0_0 = (((character.Map != num2) ? 287739596u : 1286675196u) ^ num * 2806516929u);
						continue;
					}
					case 13u:
						MoveHandler.HandleMoveTeleport(ref session, vector);
						arg_1F0_0 = (num * 2679361539u ^ 963707279u);
						continue;
					case 14u:
						arg_1F0_0 = (num * 1975813144u ^ 2471817556u);
						continue;
					case 15u:
					{
						uint num2;
						MoveHandler.HandleTransferPending(ref session, num2);
						MoveHandler.HandleNewWorld(ref session, vector, num2);
						Manager.ObjectMgr.SetPosition(ref character, vector, true);
						arg_1F0_0 = 161756150u;
						continue;
					}
					case 16u:
						vector = new Vector4
						{
							X = Command.Read<float>(args, 1),
							Y = Command.Read<float>(args, 2),
							Z = Command.Read<float>(args, 3)
						};
						arg_1F0_0 = (num * 3137894414u ^ 1911778908u);
						continue;
					}
					goto Block_5;
				}
			}
			Block_5:
			return;
			IL_249:
			Manager.ObjectMgr.SetPosition(ref character, vector, true);
		}

		[ChatCommand2("flightspeed", "Usage: !flightspeed #speed (Set the current flight speed)")]
		public static void FlightSpeed(string[] args, WorldClass2 session)
		{
			ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
			WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
			while (true)
			{
				IL_1B9:
				uint arg_174_0 = 3755792972u;
				while (true)
				{
					uint num;
					switch ((num = (arg_174_0 ^ 3686115593u)) % 14u)
					{
					case 1u:
						arg_174_0 = (((args.Length != 1) ? 837379586u : 860848558u) ^ num * 1164964500u);
						continue;
					case 2u:
						arg_174_0 = (num * 1509042133u ^ 4259098934u);
						continue;
					case 3u:
					{
						float num2 = Command.Read<float>(args, 1);
						arg_174_0 = 2384937691u;
						continue;
					}
					case 4u:
						return;
					case 5u:
					{
						float num2;
						arg_174_0 = (((num2 <= 0f) ? 593964588u : 1056003193u) ^ num * 549373294u);
						continue;
					}
					case 6u:
					{
						float num2;
						chatMessageValues.Message = PlayerCommands.smethod_8(Module.smethod_34<string>(1908673153u), num2, Module.smethod_37<string>(1841067745u));
						MoveHandler.HandleMoveSetFlightSpeed(ref session, num2);
						arg_174_0 = (num * 1788690956u ^ 734722931u);
						continue;
					}
					case 7u:
						chatMessageValues.Message = Module.smethod_34<string>(3259395599u);
						arg_174_0 = 2150161397u;
						continue;
					case 8u:
					{
						float num2;
						arg_174_0 = (((num2 > 1000f) ? 2497142980u : 2458282412u) ^ num * 3544215381u);
						continue;
					}
					case 9u:
						goto IL_1B9;
					case 10u:
						ChatHandler.SendMessage(ref session2, chatMessageValues, null);
						arg_174_0 = (num * 787953366u ^ 548096069u);
						continue;
					case 11u:
						chatMessageValues.Message = Module.smethod_37<string>(2308760292u);
						arg_174_0 = 2443999411u;
						continue;
					case 12u:
						goto IL_1CB;
					case 13u:
						MoveHandler.HandleMoveSetFlightSpeed(ref session, 7f);
						arg_174_0 = (num * 2392267140u ^ 3730153113u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			ChatHandler.SendMessage(ref session2, chatMessageValues, null);
			return;
			IL_1CB:
			ChatHandler.SendMessage(ref session2, chatMessageValues, null);
		}

		[ChatCommand2("swimspeed", "Usage: !swimspeed #speed (Set the current swim speed)")]
		public static void SwimSpeed(string[] args, WorldClass2 session)
		{
			ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
			WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
			while (true)
			{
				IL_180:
				uint arg_143_0 = 242268950u;
				while (true)
				{
					uint num;
					switch ((num = (arg_143_0 ^ 940840503u)) % 12u)
					{
					case 0u:
						goto IL_180;
					case 1u:
						return;
					case 2u:
						MoveHandler.HandleMoveSetSwimSpeed(ref session, 4.72222f);
						arg_143_0 = (num * 2795734267u ^ 1376101017u);
						continue;
					case 3u:
					{
						float num2;
						chatMessageValues.Message = PlayerCommands.smethod_8(Module.smethod_36<string>(263734244u), num2, Module.smethod_34<string>(3168640974u));
						MoveHandler.HandleMoveSetSwimSpeed(ref session, num2);
						arg_143_0 = (num * 1452786484u ^ 1555171921u);
						continue;
					}
					case 4u:
						goto IL_188;
					case 5u:
					{
						float num2;
						arg_143_0 = (((num2 <= 1000f) ? 3836652238u : 2314080613u) ^ num * 3097301610u);
						continue;
					}
					case 6u:
						ChatHandler.SendMessage(ref session2, chatMessageValues, null);
						arg_143_0 = (num * 753213370u ^ 1140599134u);
						continue;
					case 8u:
						arg_143_0 = (num * 3335570767u ^ 3509745444u);
						continue;
					case 9u:
						arg_143_0 = (((args.Length != 1) ? 3443313538u : 3990332174u) ^ num * 3823416731u);
						continue;
					case 10u:
					{
						float num2 = Command.Read<float>(args, 1);
						arg_143_0 = 1929187494u;
						continue;
					}
					case 11u:
					{
						float num2;
						arg_143_0 = (((num2 > 0f) ? 1835697547u : 156303292u) ^ num * 2145833633u);
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:
			goto IL_1A2;
			IL_188:
			chatMessageValues.Message = Module.smethod_35<string>(2793876848u);
			ChatHandler.SendMessage(ref session2, chatMessageValues, null);
			return;
			IL_1A2:
			chatMessageValues.Message = Module.smethod_34<string>(1158780257u);
			ChatHandler.SendMessage(ref session2, chatMessageValues, null);
		}

		[ChatCommand2("runspeed", "Usage: !runspeed #speed (Set the current run speed)")]
		public static void RunSpeed(string[] args, WorldClass2 session)
		{
			ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
			WorldClass session2;
			while (true)
			{
				IL_1D3:
				uint arg_18A_0 = 4176309388u;
				while (true)
				{
					uint num;
					switch ((num = (arg_18A_0 ^ 2405970416u)) % 15u)
					{
					case 0u:
					{
						float num2;
						chatMessageValues.Message = PlayerCommands.smethod_8(Module.smethod_35<string>(1506754294u), num2, Module.smethod_37<string>(1841067745u));
						arg_18A_0 = (num * 800059025u ^ 804599302u);
						continue;
					}
					case 1u:
						ChatHandler.SendMessage(ref session2, chatMessageValues, null);
						arg_18A_0 = (num * 2170197594u ^ 4269691514u);
						continue;
					case 2u:
					{
						float num2;
						arg_18A_0 = (((num2 <= 0f) ? 3407314960u : 3517761121u) ^ num * 3494936206u);
						continue;
					}
					case 3u:
					{
						float num2;
						MoveHandler.HandleMoveSetRunSpeed(ref session, num2);
						arg_18A_0 = (num * 1321767256u ^ 546749099u);
						continue;
					}
					case 4u:
						session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_18A_0 = (((args.Length != 1) ? 2264077066u : 2271036540u) ^ num * 1290353334u);
						continue;
					case 5u:
						goto IL_1D3;
					case 6u:
						goto IL_1DA;
					case 7u:
						arg_18A_0 = (num * 2749398746u ^ 1648528065u);
						continue;
					case 8u:
						MoveHandler.HandleMoveSetRunSpeed(ref session, 7f);
						arg_18A_0 = (num * 3682433977u ^ 2828595402u);
						continue;
					case 9u:
						ChatHandler.SendMessage(ref session2, chatMessageValues, null);
						arg_18A_0 = (num * 1659224401u ^ 3391581061u);
						continue;
					case 10u:
					{
						float num2 = Command.Read<float>(args, 1);
						arg_18A_0 = 3617948030u;
						continue;
					}
					case 11u:
					{
						float num2;
						arg_18A_0 = (((num2 > 1000f) ? 284787890u : 1964456558u) ^ num * 523364555u);
						continue;
					}
					case 12u:
						chatMessageValues.Message = Module.smethod_36<string>(3678851464u);
						arg_18A_0 = 2344925435u;
						continue;
					case 14u:
						return;
					}
					goto Block_4;
				}
			}
			Block_4:
			return;
			IL_1DA:
			chatMessageValues.Message = Module.smethod_36<string>(3875678096u);
			ChatHandler.SendMessage(ref session2, chatMessageValues, null);
		}

		[ChatCommand("mount", "Usage: !mount #displayId (Without 'displayId' to remove the mount)")]
		public static void Mount(string[] args, WorldClass session)
		{
			WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
			Character character = session.Character;
			if (args.Length == 1)
			{
				goto IL_58;
			}
			goto IL_C5;
			uint arg_99_0;
			int value;
			while (true)
			{
				IL_94:
				uint num;
				switch ((num = (arg_99_0 ^ 2431579815u)) % 8u)
				{
				case 0u:
					return;
				case 1u:
					SpellHandler.AuraUpdate(session2, 0u);
					arg_99_0 = (num * 1897529436u ^ 2432020601u);
					continue;
				case 2u:
					character.SetUpdateField<int>(107, 0, 0);
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_99_0 = (num * 1759251590u ^ 717662379u);
					continue;
				case 3u:
					goto IL_58;
				case 4u:
					character.SetUpdateField<int>(107, value, 0);
					arg_99_0 = (num * 1260205911u ^ 1736463469u);
					continue;
				case 5u:
					goto IL_C5;
				case 6u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_99_0 = (num * 1281342187u ^ 2294839322u);
					continue;
				}
				break;
			}
			return;
			IL_58:
			arg_99_0 = 2607041774u;
			goto IL_94;
			IL_C5:
			value = Command.Read<int>(args, 1);
			arg_99_0 = 2767437739u;
			goto IL_94;
		}

		public static void SpellMount(string[] args, WorldClass session)
		{
			WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
			while (true)
			{
				IL_165:
				uint arg_127_0 = 1441926884u;
				while (true)
				{
					uint num;
					switch ((num = (arg_127_0 ^ 1257404313u)) % 12u)
					{
					case 0u:
					{
						uint spellId;
						SpellHandler.AuraUpdate(session2, spellId);
						arg_127_0 = 758146703u;
						continue;
					}
					case 1u:
					{
						Character character = session.Character;
						arg_127_0 = (((args.Length == 1) ? 1635089121u : 184635616u) ^ num * 1962911094u);
						continue;
					}
					case 3u:
					{
						int value = Command.Read<int>(args, 1);
						uint spellId = 61451u;
						arg_127_0 = 483423801u;
						continue;
					}
					case 4u:
						goto IL_165;
					case 5u:
					{
						Character character;
						character.SetUpdateField<int>(107, 0, 0);
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						arg_127_0 = (num * 116139448u ^ 1724334562u);
						continue;
					}
					case 6u:
					{
						Character character;
						int value;
						character.SetUpdateField<int>(107, value, 0);
						arg_127_0 = (num * 3023767135u ^ 824396802u);
						continue;
					}
					case 7u:
					{
						uint spellId = Command.Read<uint>(args, 2);
						arg_127_0 = (num * 1481116793u ^ 3667671958u);
						continue;
					}
					case 8u:
						arg_127_0 = (((args.Length != 3) ? 3247025893u : 2640440978u) ^ num * 1421287721u);
						continue;
					case 9u:
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						arg_127_0 = (num * 2642789649u ^ 129902054u);
						continue;
					case 10u:
						SpellHandler.AuraUpdate(session2, 0u);
						arg_127_0 = (num * 3266202374u ^ 1678561344u);
						continue;
					case 11u:
						return;
					}
					return;
				}
			}
		}

		[ChatCommand("anim", "Usage: !anim #animId (Without 'displayId' to remove the mount)")]
		public static void Anim(string[] args, WorldClass session)
		{
			WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
			while (true)
			{
				IL_F5:
				uint arg_C4_0 = 748655597u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C4_0 ^ 69853152u)) % 9u)
					{
					case 0u:
					{
						Character character;
						character.SetUpdateField<int>(198, 0, 0);
						arg_C4_0 = (num * 1018807500u ^ 2773365502u);
						continue;
					}
					case 2u:
					{
						Character character = session.Character;
						arg_C4_0 = (num * 4218065386u ^ 4232213979u);
						continue;
					}
					case 3u:
						return;
					case 4u:
					{
						int value = Command.Read<int>(args, 1);
						arg_C4_0 = 1409293650u;
						continue;
					}
					case 5u:
						goto IL_F5;
					case 6u:
						arg_C4_0 = (((args.Length != 1) ? 2369793173u : 3333729281u) ^ num * 278843252u);
						continue;
					case 7u:
					{
						Character character;
						int value;
						character.SetUpdateField<int>(198, value, 0);
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						arg_C4_0 = (num * 914865269u ^ 2817355795u);
						continue;
					}
					case 8u:
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						arg_C4_0 = (num * 345280611u ^ 1528605511u);
						continue;
					}
					return;
				}
			}
		}

		[ChatCommand("addspell", "")]
		public static void AddSpell(string[] args, WorldClass session)
		{
			List<uint> list = new List<uint>();
			while (true)
			{
				IL_FB:
				uint arg_CA_0 = 153344653u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CA_0 ^ 738334050u)) % 9u)
					{
					case 0u:
						goto IL_FB;
					case 1u:
					{
						int num2;
						arg_CA_0 = ((num2 < args.Length) ? 95648395u : 969937008u);
						continue;
					}
					case 2u:
					{
						int num2;
						num2++;
						arg_CA_0 = (num * 3437627881u ^ 3609141513u);
						continue;
					}
					case 3u:
					{
						int num2 = 1;
						arg_CA_0 = (num * 4043879021u ^ 3278567395u);
						continue;
					}
					case 4u:
					{
						int num2;
						uint num3 = Command.Read<uint>(args, num2);
						arg_CA_0 = 1470943964u;
						continue;
					}
					case 5u:
					{
						uint num3;
						list.Add(num3);
						arg_CA_0 = (num * 540092637u ^ 61050278u);
						continue;
					}
					case 7u:
					{
						uint num3;
						session.Character.SpellList.Add(new PlayerSpell
						{
							SpellId = num3,
							State = PlayerSpellState.Unchanged
						});
						arg_CA_0 = (num * 3755660076u ^ 47272571u);
						continue;
					}
					case 8u:
						Manager.ObjectMgr.SaveChar(session.Character);
						arg_CA_0 = (num * 3670958506u ^ 1293082197u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			SpellHandler.HandleLearnedSpells(ref session, list);
		}

		[ChatCommand("scene", "")]
		public static void PlayScene(string[] args, WorldClass session)
		{
			Command.Read<int>(args, 1);
			new PacketWriter(ServerMessage.LevelUpInfo, true);
		}

		[ChatCommand2("commentator", "Usage: !anim #animId (Without 'displayId' to remove the mount)")]
		public static void commentator(string[] args, WorldClass2 session)
		{
			string string_ = Command.Read<string>(args, 1);
			while (true)
			{
				IL_216:
				uint arg_1D4_0 = 1066883875u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1D4_0 ^ 37456894u)) % 13u)
					{
					case 0u:
					{
						Vector4 vector;
						Character character;
						MoveHandler.HandleNewWorld(ref session, vector, character.Map);
						arg_1D4_0 = (num * 301003948u ^ 1875652667u);
						continue;
					}
					case 2u:
					{
						WorldClass session2;
						ObjectHandler.HandleUpdateObjectCreate(ref session2, false);
						arg_1D4_0 = (num * 799125543u ^ 2279749415u);
						continue;
					}
					case 3u:
					{
						Character character;
						Manager.ObjectMgr.SetMap(ref character, character.Map, true);
						arg_1D4_0 = (num * 2576046294u ^ 2362481632u);
						continue;
					}
					case 4u:
						goto IL_216;
					case 5u:
					{
						Character character = session.Character;
						arg_1D4_0 = (((!PlayerCommands.smethod_1(string_, Module.smethod_34<string>(3568268802u))) ? 2646011147u : 3872167317u) ^ num * 242888976u);
						continue;
					}
					case 6u:
					{
						Character character;
						character.SetUpdateField<int>(224, 0, 0);
						arg_1D4_0 = (num * 758568693u ^ 3149285992u);
						continue;
					}
					case 7u:
					{
						Character character;
						character.SetUpdateField<int>(224, 4718592, 0);
						arg_1D4_0 = (num * 1402365876u ^ 2413476074u);
						continue;
					}
					case 8u:
					{
						Vector4 vector;
						Character character;
						Manager.ObjectMgr.SetPosition(ref character, vector, true);
						arg_1D4_0 = (num * 1715737310u ^ 1279218844u);
						continue;
					}
					case 9u:
					{
						Character character;
						Vector4 vector = new Vector4
						{
							X = character.Position.X,
							Y = character.Position.Y,
							Z = character.Position.Z,
							O = character.Position.O
						};
						MoveHandler.HandleTransferPending(ref session, character.Map);
						arg_1D4_0 = 449833418u;
						continue;
					}
					case 10u:
					{
						WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_1D4_0 = (num * 1103425487u ^ 2672189u);
						continue;
					}
					case 11u:
						arg_1D4_0 = (PlayerCommands.smethod_1(string_, Module.smethod_34<string>(342814116u)) ? 459696942u : 118508920u);
						continue;
					case 12u:
						arg_1D4_0 = (num * 3228837998u ^ 1371421640u);
						continue;
					}
					return;
				}
			}
		}

		[ChatCommand("phase", "")]
		public static void Phase(string[] args, WorldClass session)
		{
			string string_ = Command.Read<string>(args, 1);
			while (true)
			{
				IL_218:
				uint arg_1D2_0 = 2832763991u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1D2_0 ^ 4194529215u)) % 14u)
					{
					case 0u:
					{
						WorldClass2 expr_1B0 = Manager.WorldMgr.GetSession2(session.Character.Guid);
						PacketWriter packetWriter;
						expr_1B0.Send(ref packetWriter);
						expr_1B0.Send(ref packetWriter);
						arg_1D2_0 = (num * 3654543458u ^ 2215459279u);
						continue;
					}
					case 1u:
					{
						int num2;
						string[] array;
						arg_1D2_0 = ((num2 < array.Length) ? 3145040889u : 2170365812u);
						continue;
					}
					case 3u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt16(1);
						arg_1D2_0 = (num * 664224499u ^ 3130443040u);
						continue;
					}
					case 4u:
					{
						PacketWriter packetWriter;
						string s;
						packetWriter.WriteUInt16(ushort.Parse(s));
						int num2;
						num2++;
						arg_1D2_0 = (num * 3034986035u ^ 2189235004u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter;
						ushort data;
						packetWriter.WriteUInt16(data);
						arg_1D2_0 = (num * 3997316103u ^ 3353737090u);
						continue;
					}
					case 6u:
					{
						int num2;
						string[] array;
						string s = array[num2];
						arg_1D2_0 = 2341843464u;
						continue;
					}
					case 7u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteInt32(PlayerCommands.smethod_0(string_, new char[]
						{
							','
						}).Length);
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						string[] array = PlayerCommands.smethod_0(string_, new char[]
						{
							','
						});
						int num2 = 0;
						arg_1D2_0 = (num * 304268429u ^ 4156627557u);
						continue;
					}
					case 8u:
					{
						ushort data2 = Command.Read<ushort>(args, 2);
						arg_1D2_0 = (num * 1842233139u ^ 2123076014u);
						continue;
					}
					case 9u:
						goto IL_218;
					case 10u:
					{
						PacketWriter packetWriter;
						ushort data2;
						packetWriter.WriteUInt16(data2);
						packetWriter.WriteUInt32(0u);
						arg_1D2_0 = (num * 3373873840u ^ 726305087u);
						continue;
					}
					case 11u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(2u);
						arg_1D2_0 = (num * 2506387890u ^ 19162419u);
						continue;
					}
					case 12u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(2u);
						arg_1D2_0 = (num * 864160562u ^ 2644623478u);
						continue;
					}
					case 13u:
					{
						ushort data = Command.Read<ushort>(args, 3);
						PacketWriter packetWriter = new PacketWriter(ServerMessage.PhaseChange, true);
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						arg_1D2_0 = (num * 2966518844u ^ 814912192u);
						continue;
					}
					}
					return;
				}
			}
		}

		[ChatCommand("level", "")]
		public static void level(string[] args, WorldClass session)
		{
			int num = Command.Read<int>(args, 1);
			if (num > 0)
			{
				while (true)
				{
					IL_1EF:
					uint arg_1A1_0 = 4066609599u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_1A1_0 ^ 2842339712u)) % 16u)
						{
						case 0u:
						{
							Character character = session.Character;
							arg_1A1_0 = (num2 * 1933870507u ^ 3369180597u);
							continue;
						}
						case 1u:
						{
							int num3;
							num3++;
							arg_1A1_0 = (num2 * 2488008533u ^ 3389246535u);
							continue;
						}
						case 2u:
						{
							int num3;
							arg_1A1_0 = ((num3 >= 6) ? 2888380605u : 3443604526u);
							continue;
						}
						case 3u:
						{
							PacketWriter packetWriter = new PacketWriter(ServerMessage.LevelUpInfo, true);
							arg_1A1_0 = (num2 * 4072169897u ^ 4211103565u);
							continue;
						}
						case 4u:
						{
							PacketWriter packetWriter;
							session.Send(ref packetWriter);
							arg_1A1_0 = (num2 * 3752315970u ^ 2916894440u);
							continue;
						}
						case 5u:
						{
							Character character;
							character.SetUpdateField<int>(84, num, 0);
							character.Level = (byte)num;
							arg_1A1_0 = (num2 * 2914383052u ^ 42211909u);
							continue;
						}
						case 6u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteInt32(num);
							packetWriter.WriteInt32(1);
							int num3 = 0;
							arg_1A1_0 = (num2 * 3471677199u ^ 2790679640u);
							continue;
						}
						case 7u:
						{
							int num4;
							arg_1A1_0 = ((num4 >= 4) ? 3503452600u : 3071209260u);
							continue;
						}
						case 8u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteInt32(1);
							arg_1A1_0 = (num2 * 3164345364u ^ 669271012u);
							continue;
						}
						case 9u:
						{
							ObjectHandler.HandleUpdateObjectValues(ref session, false);
							Character character;
							Manager.ObjectMgr.SaveChar(character);
							arg_1A1_0 = (num2 * 1022661948u ^ 2345124311u);
							continue;
						}
						case 10u:
							goto IL_1EF;
						case 12u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteInt32(0);
							int num4;
							num4++;
							arg_1A1_0 = 2992839095u;
							continue;
						}
						case 13u:
						{
							int num4 = 0;
							arg_1A1_0 = (num2 * 3427952374u ^ 502175529u);
							continue;
						}
						case 14u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteInt32(0);
							arg_1A1_0 = 3687856897u;
							continue;
						}
						case 15u:
							arg_1A1_0 = (((num < 111) ? 2251810583u : 3230732159u) ^ num2 * 1465466636u);
							continue;
						}
						goto Block_5;
					}
				}
				Block_5:;
			}
		}

		[ChatCommand("addnpc", "")]
		public static void AddNpc(string[] args, WorldClass session)
		{
			Character character = session.Character;
			int num = Command.Read<int>(args, 1);
			Creature arg_124_0;
			if (Manager.ObjectMgr.Creatures.ContainsKey(num))
			{
				arg_124_0 = Manager.ObjectMgr.Creatures[num];
				goto IL_124;
			}
			goto IL_F4;
			uint arg_FE_0;
			Creature creature;
			while (true)
			{
				IL_F9:
				uint num2;
				switch ((num2 = (arg_FE_0 ^ 2534362544u)) % 6u)
				{
				case 1u:
					goto IL_123;
				case 2u:
					goto IL_F4;
				case 3u:
					arg_FE_0 = (((creature != null) ? 2702037040u : 3458726402u) ^ num2 * 2983178236u);
					continue;
				case 4u:
				{
					ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
					arg_FE_0 = (num2 * 2079116983u ^ 102561659u);
					continue;
				}
				case 5u:
				{
					CreatureSpawn expr_43 = new CreatureSpawn(212);
					expr_43.Guid = CreatureSpawn.GetLastGuid() + 1uL;
					expr_43.Id = num;
					expr_43.Creature = creature;
					expr_43.Position = character.Position;
					expr_43.Map = character.Map;
					ChatMessageValues chatMessageValues;
					chatMessageValues.Message = Module.smethod_34<string>(2415766091u);
					expr_43.AddToWorld();
					ChatHandler.SendMessage(ref session, chatMessageValues, null);
					arg_FE_0 = (num2 * 2976917232u ^ 2653811486u);
					continue;
				}
				}
				break;
			}
			return;
			IL_123:
			arg_124_0 = null;
			goto IL_124;
			IL_F4:
			arg_FE_0 = 2690437133u;
			goto IL_F9;
			IL_124:
			creature = arg_124_0;
			arg_FE_0 = 3975361229u;
			goto IL_F9;
		}

		[ChatCommand("addobj", "")]
		public static void AddObj(string[] args, WorldClass session)
		{
			Character character = session.Character;
			while (true)
			{
				IL_193:
				uint arg_15D_0 = 2409484771u;
				while (true)
				{
					uint num;
					GameObject arg_A8_0;
					GameObject gameObject;
					switch ((num = (arg_15D_0 ^ 2771311783u)) % 10u)
					{
					case 0u:
						goto IL_193;
					case 1u:
					{
						ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
						arg_15D_0 = (num * 1088631807u ^ 904937051u);
						continue;
					}
					case 2u:
					{
						int num2 = Command.Read<int>(args, 1);
						arg_15D_0 = (num * 1675425073u ^ 2677720368u);
						continue;
					}
					case 3u:
					{
						int num2;
						if (!Manager.ObjectMgr.GameObjects.ContainsKey(num2))
						{
							arg_15D_0 = (num * 3721396215u ^ 3360830707u);
							continue;
						}
						arg_A8_0 = Manager.ObjectMgr.GameObjects[num2];
						goto IL_A8;
					}
					case 4u:
					{
						ChatMessageValues chatMessageValues;
						GameObjectSpawn gameObjectSpawn;
						chatMessageValues.Message = PlayerCommands.smethod_9(Module.smethod_36<string>(2115977944u), gameObjectSpawn.Guid);
						gameObjectSpawn.AddToWorld();
						arg_15D_0 = (num * 2922612322u ^ 1570456389u);
						continue;
					}
					case 5u:
						arg_A8_0 = null;
						goto IL_A8;
					case 6u:
					{
						ChatMessageValues chatMessageValues;
						ChatHandler.SendMessage(ref session, chatMessageValues, null);
						arg_15D_0 = (num * 4198403952u ^ 2777288528u);
						continue;
					}
					case 8u:
						arg_15D_0 = (((gameObject == null) ? 2291507222u : 4252875860u) ^ num * 1343743451u);
						continue;
					case 9u:
					{
						int num2;
						GameObjectSpawn gameObjectSpawn = new GameObjectSpawn(33)
						{
							Guid = GameObjectSpawn.GetLastGuid() + 1uL,
							Id = num2,
							GameObject = gameObject,
							Position = character.Position,
							Map = character.Map
						};
						arg_15D_0 = (num * 3162054964u ^ 1030765125u);
						continue;
					}
					}
					return;
					IL_A8:
					gameObject = arg_A8_0;
					arg_15D_0 = 3084081077u;
				}
			}
		}

		[ChatCommand("delobj", "")]
		public static void DelObj(string[] args, WorldClass session)
		{
			ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
			while (true)
			{
				IL_1E9:
				uint arg_1AF_0 = 506554980u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1AF_0 ^ 294601927u)) % 11u)
					{
					case 0u:
						goto IL_1E9;
					case 1u:
					{
						PacketWriter packetWriter;
						BitPack arg_190_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteUInt32(0u);
						Character character;
						packetWriter.WriteUInt16((ushort)character.Map);
						arg_190_0.Write<bool>(true);
						arg_190_0.Flush();
						arg_1AF_0 = (num * 1793924343u ^ 670418767u);
						continue;
					}
					case 3u:
					{
						GameObjectSpawn gameObjectSpawn;
						Manager.SpawnMgr.RemoveSpawn(gameObjectSpawn);
						arg_1AF_0 = (num * 3980062442u ^ 1628117540u);
						continue;
					}
					case 4u:
						goto IL_1F1;
					case 5u:
					{
						PacketWriter packetWriter;
						Character character;
						packetWriter.WriteUInt16((ushort)character.Map);
						packetWriter.WriteUInt32(1u);
						GameObjectSpawn gameObjectSpawn;
						packetWriter.WriteSmartGuid(gameObjectSpawn.SGuid);
						character.InRangeObjects.Remove(gameObjectSpawn.Guid);
						arg_1AF_0 = (num * 478705733u ^ 643532772u);
						continue;
					}
					case 6u:
					{
						GameObjectSpawn gameObjectSpawn;
						Manager.SpawnMgr.RemoveSpawn(gameObjectSpawn);
						PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
						arg_1AF_0 = (num * 3130564786u ^ 1002002126u);
						continue;
					}
					case 7u:
					{
						long guid = Command.Read<long>(args, 1);
						Character character = session.Character;
						arg_1AF_0 = (num * 1999704058u ^ 2069843722u);
						continue;
					}
					case 8u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteInt32(0);
						session.Send(ref packetWriter);
						chatMessageValues.Message = Module.smethod_37<string>(3565125905u);
						arg_1AF_0 = (num * 974640372u ^ 3306596998u);
						continue;
					}
					case 9u:
					{
						long guid;
						GameObjectSpawn gameObjectSpawn = Manager.SpawnMgr.FindSpawn(guid);
						arg_1AF_0 = (((gameObjectSpawn != null) ? 2183375789u : 2809248709u) ^ num * 318700939u);
						continue;
					}
					case 10u:
						chatMessageValues.Message = Module.smethod_33<string>(1061694192u);
						ChatHandler.SendMessage(ref session, chatMessageValues, null);
						arg_1AF_0 = 372086733u;
						continue;
					}
					return;
				}
			}
			return;
			IL_1F1:
			ChatHandler.SendMessage(ref session, chatMessageValues, null);
		}

		[ChatCommand("delnpc", "")]
		public static void DeleteNpc(string[] args, WorldClass session)
		{
			ChatMessageValues chatMessageValues = new ChatMessageValues(MessageType.ChatMessageSystem, "", false, false, "");
			Character character = session.Character;
			CreatureSpawn creatureSpawn = Manager.SpawnMgr.FindSpawn(character.TargetGuid);
			if (creatureSpawn != null)
			{
				goto IL_F8;
			}
			goto IL_1E1;
			uint arg_1A3_0;
			while (true)
			{
				IL_19E:
				uint num;
				switch ((num = (arg_1A3_0 ^ 2072920967u)) % 12u)
				{
				case 0u:
				{
					PacketWriter packetWriter;
					session.Send(ref packetWriter);
					arg_1A3_0 = (num * 3844952634u ^ 2173330347u);
					continue;
				}
				case 1u:
				{
					PacketWriter packetWriter;
					packetWriter.WriteUInt16((ushort)character.Map);
					packetWriter.WriteUInt32(1u);
					packetWriter.WriteSmartGuid(creatureSpawn.SGuid);
					character.InRangeObjects.Remove(creatureSpawn.Guid);
					arg_1A3_0 = (num * 2873974358u ^ 799837162u);
					continue;
				}
				case 2u:
				{
					Manager.SpawnMgr.RemoveSpawn(creatureSpawn, true);
					PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
					arg_1A3_0 = (num * 47304701u ^ 1964397943u);
					continue;
				}
				case 3u:
					ChatHandler.SendMessage(ref session, chatMessageValues, null);
					arg_1A3_0 = (num * 3704620640u ^ 2790218823u);
					continue;
				case 5u:
					goto IL_F8;
				case 6u:
				{
					PacketWriter packetWriter;
					BitPack arg_D9_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
					packetWriter.WriteUInt32(0u);
					packetWriter.WriteUInt16((ushort)character.Map);
					arg_D9_0.Write<bool>(true);
					arg_D9_0.Flush();
					arg_1A3_0 = (num * 3804477740u ^ 1720354034u);
					continue;
				}
				case 7u:
					return;
				case 8u:
					chatMessageValues.Message = Module.smethod_33<string>(844393502u);
					arg_1A3_0 = (num * 1013692842u ^ 4107925085u);
					continue;
				case 9u:
					goto IL_1E1;
				case 10u:
					ChatHandler.SendMessage(ref session, chatMessageValues, null);
					arg_1A3_0 = (num * 3738969421u ^ 2060519994u);
					continue;
				case 11u:
				{
					Manager.SpawnMgr.RemoveSpawn(creatureSpawn, true);
					PacketWriter packetWriter;
					packetWriter.WriteInt32(0);
					arg_1A3_0 = (num * 773743163u ^ 1507818754u);
					continue;
				}
				}
				break;
			}
			return;
			IL_F8:
			arg_1A3_0 = 86060769u;
			goto IL_19E;
			IL_1E1:
			chatMessageValues.Message = Module.smethod_33<string>(1061694192u);
			arg_1A3_0 = 753816660u;
			goto IL_19E;
		}

		static string[] smethod_0(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static StringBuilder smethod_2()
		{
			return new StringBuilder();
		}

		static StringBuilder smethod_3(StringBuilder stringBuilder_0, string string_0, object[] object_0)
		{
			return stringBuilder_0.AppendFormat(string_0, object_0);
		}

		static string smethod_4(object object_0)
		{
			return object_0.ToString();
		}

		static string smethod_5(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static void smethod_6(string string_0, string string_1)
		{
			File.AppendAllText(string_0, string_1);
		}

		static void smethod_7(string string_0, string string_1)
		{
			File.WriteAllText(string_0, string_1);
		}

		static string smethod_8(object object_0, object object_1, object object_2)
		{
			return object_0 + object_1 + object_2;
		}

		static string smethod_9(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}
	}
}
