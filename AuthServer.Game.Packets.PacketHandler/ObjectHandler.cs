using AuthServer.Game.Entities;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Constants;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class ObjectHandler : Manager
	{
		public static void HandleUpdateObjectCreate(ref WorldClass session, bool tele = false)
		{
			WorldObject character = session.Character;
			while (true)
			{
				IL_238:
				uint arg_1F2_0 = 2275508388u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1F2_0 ^ 3154599871u)) % 14u)
					{
					case 0u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteSmartGuid(character.Guid, global::GuidType.Player);
						arg_1F2_0 = (num * 3881833045u ^ 1180485233u);
						continue;
					}
					case 1u:
						(character as Character).InRangeObjects.Clear();
						arg_1F2_0 = (num * 2283818524u ^ 355223714u);
						continue;
					case 2u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(4);
						UpdateFlag updateFlags = UpdateFlag.Self | UpdateFlag.Alive | UpdateFlag.Rotation;
						arg_1F2_0 = (num * 103799057u ^ 21624365u);
						continue;
					}
					case 3u:
					{
						PacketWriter packetWriter;
						character.WriteUpdateFields(ref packetWriter);
						arg_1F2_0 = (num * 49266881u ^ 2307507266u);
						continue;
					}
					case 4u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_1F2_0 = (num * 1672062260u ^ 2814400482u);
						continue;
					}
					case 6u:
					{
						PacketWriter packetWriter;
						UpdateFlag updateFlags;
						Manager.WorldMgr.WriteUpdateObjectMovement(ref packetWriter, ref character, updateFlags, ObjectType.Player);
						arg_1F2_0 = (num * 86580379u ^ 2193049942u);
						continue;
					}
					case 7u:
						character.SetUpdateFields();
						arg_1F2_0 = (num * 2334973880u ^ 3652082974u);
						continue;
					case 8u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(1);
						arg_1F2_0 = (num * 2061835051u ^ 1546086745u);
						continue;
					}
					case 9u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
						arg_1F2_0 = (num * 3719673916u ^ 4267485768u);
						continue;
					}
					case 10u:
					{
						PacketWriter packetWriter;
						character.WriteDynamicUpdateFields(ref packetWriter);
						uint data = (uint)ObjectHandler.smethod_1(ObjectHandler.smethod_0(packetWriter)) - 17u;
						packetWriter.WriteUInt32Pos(data, 13);
						arg_1F2_0 = (num * 91628017u ^ 979890369u);
						continue;
					}
					case 11u:
					{
						PacketWriter packetWriter;
						BitPack arg_A2_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						if (session.Character.Bag == null)
						{
							session.Character.Bag = new Dictionary<byte, Item>();
						}
						if (session.Character.Equipment == null)
						{
							session.Character.Equipment = new Dictionary<byte, Item>();
						}
						packetWriter.WriteInt32(1);
						packetWriter.WriteUInt16((ushort)character.Map);
						arg_A2_0.Write<int>(0);
						arg_A2_0.Flush();
						packetWriter.WriteInt32(0);
						arg_1F2_0 = 3587135917u;
						continue;
					}
					case 12u:
						goto IL_238;
					case 13u:
						if (!tele)
						{
							arg_1F2_0 = (num * 4070430128u ^ 2204553002u);
							continue;
						}
						return;
					}
					goto Block_4;
				}
			}
			Block_4:
			using (Dictionary<byte, Item>.Enumerator enumerator = session.Character.Bag.GetEnumerator())
			{
				while (true)
				{
					IL_39B:
					uint arg_35F_0 = enumerator.MoveNext() ? 4174226275u : 4027859808u;
					while (true)
					{
						uint num;
						switch ((num = (arg_35F_0 ^ 3154599871u)) % 8u)
						{
						case 0u:
							arg_35F_0 = 4174226275u;
							continue;
						case 1u:
							ObjectHandler.HandleUpdateObjectValues(ref session, false);
							arg_35F_0 = (num * 2901385184u ^ 3008738973u);
							continue;
						case 2u:
							goto IL_39B;
						case 3u:
						{
							SmartGuid smartGuid;
							session.Character.SetUpdateField<ulong>(1085 + (23 + (session.Character.Bag.Count - 1)) * 4, smartGuid.Guid, 0);
							arg_35F_0 = (num * 1633749325u ^ 882616989u);
							continue;
						}
						case 4u:
						{
							KeyValuePair<byte, Item> current = enumerator.Current;
							arg_35F_0 = 2355109817u;
							continue;
						}
						case 5u:
						{
							SmartGuid smartGuid;
							session.Character.SetUpdateField<ulong>(1085 + (23 + (session.Character.Bag.Count - 1)) * 4 + 2, smartGuid.HighGuid, 0);
							arg_35F_0 = (num * 2081811083u ^ 929503609u);
							continue;
						}
						case 6u:
						{
							KeyValuePair<byte, Item> current;
							SmartGuid smartGuid = new SmartGuid(current.Value.Guid, 0, global::GuidType.Item, 0uL);
							ObjectHandler.HandleUpdateObjectCreateItem(smartGuid, current.Value, ref session);
							arg_35F_0 = (num * 935936635u ^ 2677446734u);
							continue;
						}
						}
						goto Block_8;
					}
				}
				Block_8:;
			}
			using (Dictionary<byte, Item>.Enumerator enumerator = session.Character.Equipment.GetEnumerator())
			{
				while (true)
				{
					IL_60C:
					uint arg_5CB_0 = (!enumerator.MoveNext()) ? 4153873960u : 2528389413u;
					while (true)
					{
						uint num;
						switch ((num = (arg_5CB_0 ^ 3154599871u)) % 9u)
						{
						case 0u:
						{
							KeyValuePair<byte, Item> current2;
							session.Character.SetUpdateField<ulong>(1085 + (int)(current2.Key * 4) + 2, 0uL, 0);
							arg_5CB_0 = (num * 2903315187u ^ 1606612479u);
							continue;
						}
						case 1u:
						{
							KeyValuePair<byte, Item> current2;
							session.Character.SetUpdateField<ushort>(1035 + (int)(current2.Key * 2) + 1, (ushort)current2.Value.ModId, 0);
							arg_5CB_0 = (num * 2254772229u ^ 3249291789u);
							continue;
						}
						case 2u:
							arg_5CB_0 = 2528389413u;
							continue;
						case 3u:
							goto IL_60C;
						case 4u:
						{
							KeyValuePair<byte, Item> current2 = enumerator.Current;
							SmartGuid smartGuid2 = new SmartGuid(current2.Value.Guid, 0, global::GuidType.Item, 0uL);
							ObjectHandler.HandleUpdateObjectCreateItem(smartGuid2, current2.Value, ref session);
							session.Character.SetUpdateField<ulong>(1085 + (int)(current2.Key * 4), 0uL, 0);
							arg_5CB_0 = 3525416964u;
							continue;
						}
						case 6u:
						{
							KeyValuePair<byte, Item> current2;
							session.Character.SetUpdateField<int>(1035 + (int)(current2.Key * 2), current2.Value.Id, 0);
							ObjectHandler.HandleUpdateObjectValues(ref session, false);
							arg_5CB_0 = (num * 2025118931u ^ 1226385667u);
							continue;
						}
						case 7u:
						{
							KeyValuePair<byte, Item> current2;
							SmartGuid smartGuid2;
							session.Character.SetUpdateField<ulong>(1085 + (int)(current2.Key * 4), smartGuid2.Guid, 0);
							session.Character.SetUpdateField<ulong>(1085 + (int)(current2.Key * 4) + 2, smartGuid2.HighGuid, 0);
							session.Character.SetUpdateField<ushort>(1035 + (int)(current2.Key * 2) + 1, 0, 0);
							arg_5CB_0 = (num * 1833648401u ^ 1914681319u);
							continue;
						}
						case 8u:
						{
							KeyValuePair<byte, Item> current2;
							session.Character.SetUpdateField<ushort>(1035 + (int)(current2.Key * 2) + 1, 0, 1);
							session.Character.SetUpdateField<int>(1035 + (int)(current2.Key * 2), 0, 0);
							arg_5CB_0 = (num * 772582332u ^ 2291984992u);
							continue;
						}
						}
						goto Block_12;
					}
				}
				Block_12:;
			}
		}

		private static void WriteInRangeObjects(IEnumerable<WorldObject> objects, WorldClass session, ObjectType type)
		{
			Character character = session.Character;
			int arg_10_0 = objects.Count<WorldObject>();
			UpdateFlag updateFlag = UpdateFlag.Alive;
			if (arg_10_0 > 0)
			{
				updateFlag |= ((type == ObjectType.GameObject) ? UpdateFlag.StationaryPosition : UpdateFlag.Alive);
				IEnumerator<WorldObject> enumerator = objects.GetEnumerator();
				try
				{
					while (true)
					{
						IL_361:
						uint arg_2F0_0 = (!ObjectHandler.smethod_3(enumerator)) ? 1527969684u : 1848967450u;
						while (true)
						{
							uint num;
							switch ((num = (arg_2F0_0 ^ 969171285u)) % 21u)
							{
							case 0u:
								arg_2F0_0 = (((type == ObjectType.GameObject) ? 1738499285u : 646977882u) ^ num * 1593683944u);
								continue;
							case 1u:
							{
								PacketWriter packetWriter;
								packetWriter.WriteUInt8(1);
								arg_2F0_0 = (((type == ObjectType.Player) ? 3818654308u : 3591559160u) ^ num * 648131247u);
								continue;
							}
							case 2u:
							{
								PacketWriter packetWriter;
								WorldObject worldObject;
								packetWriter.WriteSmartGuid(worldObject.SGuid);
								arg_2F0_0 = 2122628810u;
								continue;
							}
							case 3u:
							{
								WorldObject current;
								arg_2F0_0 = (((character.Guid != current.Guid) ? 2929494894u : 2211260839u) ^ num * 4047706010u);
								continue;
							}
							case 4u:
							{
								PacketWriter packetWriter;
								packetWriter.WriteUInt8((byte)type);
								arg_2F0_0 = 2032235371u;
								continue;
							}
							case 5u:
								ObjectHandler.smethod_2(5);
								arg_2F0_0 = (num * 2857407048u ^ 4065091795u);
								continue;
							case 6u:
							{
								PacketWriter packetWriter;
								uint data;
								packetWriter.WriteUInt32Pos(data, 13);
								arg_2F0_0 = (num * 945023592u ^ 666258815u);
								continue;
							}
							case 7u:
								arg_2F0_0 = ((type == ObjectType.Unit) ? 1066124101u : 1317094159u);
								continue;
							case 8u:
							{
								PacketWriter packetWriter;
								WorldObject worldObject;
								worldObject.WriteDynamicUpdateFields(ref packetWriter);
								arg_2F0_0 = (num * 3168312685u ^ 1016797372u);
								continue;
							}
							case 9u:
							{
								WorldObject current;
								WorldObject worldObject = current;
								arg_2F0_0 = (((!character.InRangeObjects.ContainsKey(current.Guid)) ? 241293809u : 970459467u) ^ num * 547093509u);
								continue;
							}
							case 11u:
							{
								WorldObject worldObject;
								character.InRangeObjects.Add(worldObject.Guid, worldObject);
								arg_2F0_0 = (num * 1271401156u ^ 2252314095u);
								continue;
							}
							case 12u:
							{
								PacketWriter packetWriter;
								uint data = (uint)ObjectHandler.smethod_1(ObjectHandler.smethod_0(packetWriter)) - 17u;
								arg_2F0_0 = 1218186453u;
								continue;
							}
							case 13u:
							{
								PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
								BitPack arg_131_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
								packetWriter.WriteInt32(1);
								packetWriter.WriteUInt16((ushort)character.Map);
								arg_131_0.Write<int>(0);
								arg_131_0.Flush();
								arg_2F0_0 = (num * 3222425454u ^ 2984538751u);
								continue;
							}
							case 14u:
							{
								PacketWriter packetWriter;
								WorldObject worldObject;
								packetWriter.WriteSmartGuid(worldObject.Guid, global::GuidType.Player);
								arg_2F0_0 = (num * 1757694464u ^ 3297668298u);
								continue;
							}
							case 15u:
								goto IL_361;
							case 16u:
							{
								PacketWriter packetWriter;
								packetWriter.WriteInt32(0);
								arg_2F0_0 = (num * 4015340619u ^ 2939785537u);
								continue;
							}
							case 17u:
							{
								WorldObject current = enumerator.Current;
								arg_2F0_0 = 1029453396u;
								continue;
							}
							case 18u:
							{
								PacketWriter packetWriter;
								session.Send(ref packetWriter);
								arg_2F0_0 = (num * 3659980510u ^ 976080836u);
								continue;
							}
							case 19u:
							{
								PacketWriter packetWriter;
								WorldObject worldObject;
								Manager.WorldMgr.WriteUpdateObjectMovement(ref packetWriter, ref worldObject, updateFlag, type);
								worldObject.SetUpdateFields();
								worldObject.WriteUpdateFields(ref packetWriter);
								arg_2F0_0 = (num * 3313353577u ^ 2170531980u);
								continue;
							}
							case 20u:
								arg_2F0_0 = 1848967450u;
								continue;
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_3A7:
							uint arg_38E_0 = 1857051829u;
							while (true)
							{
								uint num;
								switch ((num = (arg_38E_0 ^ 969171285u)) % 3u)
								{
								case 0u:
									goto IL_3A7;
								case 2u:
									ObjectHandler.smethod_4(enumerator);
									arg_38E_0 = (num * 3244275826u ^ 1817846266u);
									continue;
								}
								goto Block_14;
							}
						}
						Block_14:;
					}
				}
			}
		}

		public static void HandleUpdateObjectCreateItem(SmartGuid guid, Item item2, ref WorldClass session)
		{
			int id = item2.Id;
			while (true)
			{
				IL_1E2:
				uint arg_1B9_0 = 2511239562u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1B9_0 ^ 4026668597u)) % 7u)
					{
					case 0u:
						goto IL_1E2;
					case 1u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
						arg_1B9_0 = (num * 930516696u ^ 722285656u);
						continue;
					}
					case 2u:
					{
						WorldObject character = session.Character;
						arg_1B9_0 = (num * 3409398618u ^ 278691816u);
						continue;
					}
					case 3u:
					{
						PacketWriter packetWriter;
						uint data = (uint)ObjectHandler.smethod_1(ObjectHandler.smethod_0(packetWriter)) - 17u;
						arg_1B9_0 = (num * 3608865686u ^ 1852252423u);
						continue;
					}
					case 4u:
					{
						PacketWriter packetWriter;
						uint data;
						packetWriter.WriteUInt32Pos(data, 13);
						session.Send(ref packetWriter);
						arg_1B9_0 = (num * 1567485334u ^ 1076014059u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter;
						BitPack arg_6D_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteUInt32(1u);
						WorldObject character;
						packetWriter.WriteUInt16((ushort)character.Map);
						packetWriter.WriteUInt8(0);
						packetWriter.WriteInt32(0);
						packetWriter.WriteUInt8(1);
						packetWriter.WriteSmartGuid(guid);
						packetWriter.WriteUInt8(1);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Write<int>(0);
						arg_6D_0.Flush();
						packetWriter.WriteUInt32(0u);
						WorldObject expr_101 = new WorldObject(230);
						expr_101.Guid = session.Character.Guid;
						expr_101.SetItemUpdateFields(guid, id, item2.ModId);
						expr_101.WriteUpdateFields(ref packetWriter);
						expr_101.WriteDynamicUpdateFields(ref packetWriter);
						arg_1B9_0 = (num * 64307666u ^ 2886005418u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleUpdateObjectValues(ref WorldClass session, bool broadcast = false)
		{
			WorldObject character = session.Character;
			PacketWriter packetWriter;
			while (true)
			{
				IL_181:
				uint arg_148_0 = 607021314u;
				while (true)
				{
					uint num;
					switch ((num = (arg_148_0 ^ 415926280u)) % 11u)
					{
					case 0u:
						character.WriteDynamicUpdateFields(ref packetWriter);
						arg_148_0 = (num * 2669928215u ^ 2408650936u);
						continue;
					case 1u:
						packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
						arg_148_0 = (num * 1462708285u ^ 3455762409u);
						continue;
					case 2u:
						goto IL_181;
					case 3u:
						Manager.WorldMgr.SendToInRangeCharacter(character as Character, packetWriter);
						arg_148_0 = 625155154u;
						continue;
					case 5u:
						new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteUInt32(1u);
						packetWriter.WriteUInt16((ushort)character.Map);
						arg_148_0 = (num * 4087013210u ^ 3756105403u);
						continue;
					case 6u:
						packetWriter.WriteSmartGuid(character.Guid, global::GuidType.Player);
						character.WriteUpdateFields(ref packetWriter);
						arg_148_0 = (num * 1587475413u ^ 2510458295u);
						continue;
					case 7u:
					{
						uint data = (uint)ObjectHandler.smethod_1(ObjectHandler.smethod_0(packetWriter)) - 17u;
						packetWriter.WriteUInt32Pos(data, 13);
						arg_148_0 = ((broadcast ? 1303551731u : 1806187314u) ^ num * 1103903223u);
						continue;
					}
					case 8u:
						packetWriter.WriteUInt8(0);
						arg_148_0 = (num * 3208002226u ^ 2425809978u);
						continue;
					case 9u:
						goto IL_189;
					case 10u:
						packetWriter.WriteInt32(0);
						packetWriter.WriteUInt8(0);
						arg_148_0 = (num * 250629053u ^ 2467687846u);
						continue;
					}
					return;
				}
			}
			return;
			IL_189:
			session.Send(ref packetWriter);
		}

		public static void HandleUpdateObjectValues(ref WorldClass session, WorldObject obj, bool broadcast = false)
		{
			WorldObject character = session.Character;
			while (true)
			{
				IL_1DE:
				uint arg_195_0 = 3838918492u;
				while (true)
				{
					uint num;
					switch ((num = (arg_195_0 ^ 2293926252u)) % 15u)
					{
					case 1u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_195_0 = (num * 1908781805u ^ 753648174u);
						continue;
					}
					case 2u:
						return;
					case 3u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(1u);
						arg_195_0 = (num * 731726856u ^ 77037749u);
						continue;
					}
					case 4u:
						goto IL_1DE;
					case 5u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteInt32(0);
						arg_195_0 = (num * 3606854279u ^ 1362373309u);
						continue;
					}
					case 6u:
					{
						PacketWriter packetWriter;
						Manager.WorldMgr.SendToInRangeCharacter(character as Character, packetWriter);
						arg_195_0 = 2338729526u;
						continue;
					}
					case 7u:
					{
						PacketWriter packetWriter;
						new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						arg_195_0 = (num * 1333306621u ^ 1308058188u);
						continue;
					}
					case 8u:
					{
						PacketWriter packetWriter;
						uint data = (uint)ObjectHandler.smethod_1(ObjectHandler.smethod_0(packetWriter)) - 17u;
						packetWriter.WriteUInt32Pos(data, 13);
						arg_195_0 = (num * 1914621205u ^ 2418392944u);
						continue;
					}
					case 9u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(0);
						arg_195_0 = (num * 880452894u ^ 877143482u);
						continue;
					}
					case 10u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
						arg_195_0 = (num * 4173316949u ^ 3732895873u);
						continue;
					}
					case 11u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteSmartGuid(obj.SGuid);
						obj.WriteUpdateFields(ref packetWriter);
						obj.WriteDynamicUpdateFields(ref packetWriter);
						arg_195_0 = (num * 2326981483u ^ 2821617165u);
						continue;
					}
					case 12u:
						arg_195_0 = (((!broadcast) ? 3218131395u : 3828016721u) ^ num * 2357201326u);
						continue;
					case 13u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt16((ushort)character.Map);
						arg_195_0 = (num * 4256119138u ^ 2559866254u);
						continue;
					}
					case 14u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(0);
						arg_195_0 = (num * 4029856956u ^ 1381471971u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static PacketWriter HandleDestroyObject(ref WorldClass session, ulong guid, bool animation = false, bool item = false)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.DestroyObject, true);
			while (true)
			{
				IL_82:
				int arg_6C_0 = -527747855;
				while (true)
				{
					switch ((arg_6C_0 ^ -1331919861) % 3)
					{
					case 0:
						goto IL_82;
					case 1:
					{
						BitPack arg_56_0 = new BitPack(packetWriter, guid, 0uL, 0uL, 0uL);
						if (item)
						{
							SmartGuid guid2 = new SmartGuid(guid, 0, global::GuidType.Item, 0uL);
							packetWriter.WriteSmartGuid(guid2);
						}
						else
						{
							packetWriter.WriteSmartGuid(guid, global::GuidType.Player);
						}
						arg_56_0.Write<bool>(animation);
						arg_56_0.Flush();
						arg_6C_0 = -1061865820;
						continue;
					}
					}
					return packetWriter;
				}
			}
			return packetWriter;
		}

		[Opcode(ClientMessage.ChatMessageYell, "17930")]
		public static void HandleObjectUpdateFailed(ref PacketReader packet, WorldClass session)
		{
			byte[] expr_06 = new byte[8];
			ObjectHandler.smethod_5(expr_06, fieldof(<PrivateImplementationDetails>.F33CCE85FC4963E786F0E3E51BF6D41F7DF910C5).FieldHandle);
			byte[] mask = expr_06;
			while (true)
			{
				IL_A7:
				uint arg_87_0 = 1795528629u;
				while (true)
				{
					uint num;
					switch ((num = (arg_87_0 ^ 1171644517u)) % 5u)
					{
					case 0u:
						goto IL_A7;
					case 1u:
					{
						byte[] expr_69 = new byte[8];
						ObjectHandler.smethod_5(expr_69, fieldof(<PrivateImplementationDetails>.F194F7A523191120A0E0795F84A21254E1B48C5F).FieldHandle);
						byte[] bytes = expr_69;
						arg_87_0 = (num * 2480489431u ^ 3809568048u);
						continue;
					}
					case 2u:
					{
						byte[] bytes;
						ulong packedValue = new BitUnpack(packet).GetPackedValue(mask, bytes);
						arg_87_0 = (num * 2972380924u ^ 2047378812u);
						continue;
					}
					case 4u:
					{
						ulong packedValue;
						Log.Message(LogType.Debug, Module.smethod_33<string>(2827741252u), new object[]
						{
							packedValue
						});
						arg_87_0 = (num * 1499607034u ^ 1240785080u);
						continue;
					}
					}
					return;
				}
			}
		}

		static Stream smethod_0(BinaryWriter binaryWriter_0)
		{
			return binaryWriter_0.BaseStream;
		}

		static long smethod_1(Stream stream_0)
		{
			return stream_0.Length;
		}

		static void smethod_2(int int_0)
		{
			Thread.Sleep(int_0);
		}

		static bool smethod_3(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_4(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static void smethod_5(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}
}
