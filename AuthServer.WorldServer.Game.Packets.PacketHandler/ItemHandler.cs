using AuthServer.Game.Entities;
using AuthServer.Game.Packets.PacketHandler;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Net;
using Framework.Misc;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using Framework.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace AuthServer.WorldServer.Game.Packets.PacketHandler
{
	public class ItemHandler
	{
		[Opcode2(ClientMessage.UnEquipItem, "18125")]
		public static void HandleUnEquipItem(ref PacketReader packet, WorldClass2 session)
		{
			packet.Skip(5);
			byte b = packet.Read<byte>();
			byte b2;
			while (true)
			{
				IL_303:
				uint arg_2B5_0 = 1819372127u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B5_0 ^ 1136699870u)) % 16u)
					{
					case 0u:
					{
						session.Character.SetUpdateField<ushort>(1035 + (int)(b2 * 2) + 1, 0, 0);
						session.Character.SetUpdateField<ushort>(1035 + (int)(b2 * 2) + 1, 0, 1);
						WorldClass session2;
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						ObjectHandler.HandleUpdateObjectValues(ref session2, true);
						arg_2B5_0 = (num * 3374913412u ^ 2282626695u);
						continue;
					}
					case 1u:
						b2 = packet.Read<byte>();
						arg_2B5_0 = (num * 1902157130u ^ 174221922u);
						continue;
					case 2u:
						session.Character.Bag.Remove(b);
						arg_2B5_0 = (num * 4091420843u ^ 2617997471u);
						continue;
					case 3u:
					{
						WorldClass session2;
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						session.Character.SetUpdateField<int>(1035 + (int)(b2 * 2), 0, 0);
						arg_2B5_0 = (num * 3351533450u ^ 858014557u);
						continue;
					}
					case 4u:
					{
						WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_2B5_0 = (num * 3970539045u ^ 265521657u);
						continue;
					}
					case 5u:
						session.Character.SetUpdateField<ulong>(1085 + (int)(b2 * 4), 0uL, 0);
						session.Character.SetUpdateField<ulong>(1085 + (int)(b2 * 4) + 2, 0uL, 0);
						arg_2B5_0 = (num * 4224354357u ^ 2053361779u);
						continue;
					case 6u:
						arg_2B5_0 = (((!session.Character.Equipment.ContainsKey(b2)) ? 1606302786u : 36007046u) ^ num * 2311842534u);
						continue;
					case 7u:
					{
						session.Character.Equipment.Remove(b2);
						Item item;
						session.Character.Bag.Add(b, item);
						SmartGuid smartGuid = new SmartGuid(item.Guid, 0, GuidType.Item, 0uL);
						arg_2B5_0 = 523317569u;
						continue;
					}
					case 8u:
						goto IL_30A;
					case 9u:
					{
						WorldClass session2;
						session2.Character = session.Character;
						arg_2B5_0 = (num * 1020405840u ^ 1878556788u);
						continue;
					}
					case 11u:
						arg_2B5_0 = (session.Character.Bag.ContainsKey(b) ? 1868005100u : 1269139193u);
						continue;
					case 12u:
					{
						Item item = session.Character.Equipment[b2];
						arg_2B5_0 = (num * 125860851u ^ 2899062321u);
						continue;
					}
					case 13u:
						session.Character.SetUpdateField<ushort>(1035 + (int)(b2 * 2) + 1, 0, 0);
						arg_2B5_0 = (num * 1261327750u ^ 544625808u);
						continue;
					case 14u:
						goto IL_303;
					case 15u:
					{
						SmartGuid smartGuid;
						session.Character.SetUpdateField<ulong>(1085 + (int)(b * 4), smartGuid.Guid, 0);
						session.Character.SetUpdateField<ulong>(1085 + (int)(b * 4) + 2, smartGuid.HighGuid, 0);
						arg_2B5_0 = (num * 4049090278u ^ 4148349777u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			return;
			IL_30A:
			ItemHandler.AddItem(session, b2);
		}

		[Opcode2(ClientMessage.EquipItem, "18125")]
		public static void HandleEquipItem(ref PacketReader packet, WorldClass2 session)
		{
			packet.Skip(4);
			byte bagSlot = packet.Read<byte>();
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 2890883479u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 3187418839u)) % 3u)
					{
					case 1u:
						ItemHandler.AddItem(session, bagSlot);
						arg_2B_0 = (num * 4216493879u ^ 2545498223u);
						continue;
					case 2u:
						goto IL_43;
					}
					return;
				}
			}
		}

		private static void AddItem(WorldClass2 session, byte bagSlot)
		{
			WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
			byte equipSlot;
			Item item2;
			SmartGuid smartGuid;
			while (true)
			{
				IL_14F:
				uint arg_122_0 = 3901046590u;
				while (true)
				{
					uint num;
					switch ((num = (arg_122_0 ^ 2735090873u)) % 8u)
					{
					case 0u:
						goto IL_14F;
					case 1u:
						session.Character.Bag.Remove(bagSlot);
						arg_122_0 = (num * 413465045u ^ 3934698462u);
						continue;
					case 3u:
					{
						Item item;
						equipSlot = ItemHandler.GetEquipSlot(item.InventoryType);
						if (!session.Character.Equipment.ContainsKey(equipSlot))
						{
							arg_122_0 = (num * 88286537u ^ 102903164u);
							continue;
						}
						goto IL_928;
					}
					case 4u:
						smartGuid = new SmartGuid(item2.Guid, 0, GuidType.Item, 0uL);
						arg_122_0 = (num * 3934272609u ^ 2187647340u);
						continue;
					case 5u:
						item2 = session.Character.Bag[bagSlot];
						arg_122_0 = (num * 2864327870u ^ 3823397051u);
						continue;
					case 6u:
					{
						Item item;
						session.Character.Equipment.Add(equipSlot, item);
						if (session.Character.Bag.ContainsKey(bagSlot))
						{
							arg_122_0 = (num * 2375106689u ^ 756885426u);
							continue;
						}
						goto IL_912;
					}
					case 7u:
					{
						Item item;
						if (session.Character.Bag.TryGetValue(bagSlot, out item))
						{
							arg_122_0 = (num * 2306049815u ^ 322888747u);
							continue;
						}
						goto IL_B4B;
					}
					}
					goto Block_4;
				}
			}
			uint arg_A6D_0;
			int index;
			Dictionary<byte, Item> dictionary;
			while (true)
			{
				IL_A68:
				uint num;
				switch ((num = (arg_A6D_0 ^ 2735090873u)) % 52u)
				{
				case 0u:
				{
					Item item3;
					session.Character.SetUpdateField<ushort>(1035 + (int)(equipSlot * 2) + 1, (ushort)item3.ModId, 0);
					arg_A6D_0 = (num * 2688365806u ^ 3665580916u);
					continue;
				}
				case 2u:
					session.Character.SetUpdateField<ushort>(1035 + (int)(equipSlot * 2) + 1, 0, 1);
					arg_A6D_0 = (num * 397079707u ^ 2550042554u);
					continue;
				case 3u:
				{
					byte b;
					arg_A6D_0 = (((int)b < session.Character.Bag.Count) ? 3012765023u : 3532292612u);
					continue;
				}
				case 4u:
				{
					Item item4 = session.Character.Equipment[equipSlot];
					arg_A6D_0 = (num * 625219965u ^ 158864307u);
					continue;
				}
				case 5u:
				{
					int num2;
					arg_A6D_0 = ((num2 >= 16) ? 3752629640u : 3003850106u);
					continue;
				}
				case 6u:
				{
					int num2 = 0;
					arg_A6D_0 = (num * 2687791784u ^ 2016439126u);
					continue;
				}
				case 7u:
				{
					int num3;
					index = num3;
					arg_A6D_0 = (num * 971334227u ^ 618718611u);
					continue;
				}
				case 8u:
				{
					byte b;
					b += 1;
					arg_A6D_0 = (num * 1052352431u ^ 2217463802u);
					continue;
				}
				case 9u:
					goto IL_928;
				case 10u:
					goto IL_912;
				case 11u:
				{
					int num2;
					session.Character.SetUpdateField<ulong>(1085 + (23 + num2) * 4 + 2, 0uL, 0);
					arg_A6D_0 = (num * 3990101372u ^ 1156157827u);
					continue;
				}
				case 12u:
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4), 0uL, 0);
					arg_A6D_0 = (num * 2450056873u ^ 1905378433u);
					continue;
				case 13u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_A6D_0 = (num * 2846314608u ^ 3060895351u);
					continue;
				case 14u:
					session.Character.SetUpdateField<ushort>(1035 + (int)(equipSlot * 2) + 1, 0, 0);
					arg_A6D_0 = (num * 3375404461u ^ 3611762605u);
					continue;
				case 15u:
				{
					int num2;
					session.Character.SetUpdateField<ulong>(1085 + (23 + num2) * 4, 0uL, 0);
					arg_A6D_0 = 3244715514u;
					continue;
				}
				case 16u:
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4) + 2, 0uL, 0);
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4), smartGuid.Guid, 0);
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4) + 2, smartGuid.HighGuid, 0);
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					session.Character.SetUpdateField<int>(1035 + (int)(equipSlot * 2), 0, 0);
					arg_A6D_0 = (num * 1510252851u ^ 1999990189u);
					continue;
				case 17u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_A6D_0 = (num * 1475435762u ^ 2350161561u);
					continue;
				case 18u:
				{
					int num2;
					num2++;
					arg_A6D_0 = (num * 312829336u ^ 108542544u);
					continue;
				}
				case 19u:
				{
					Item item3;
					session.Character.Equipment.Add(equipSlot, item3);
					Item item4;
					session.Character.Bag.Add(bagSlot, item4);
					arg_A6D_0 = (num * 2281705214u ^ 4242836535u);
					continue;
				}
				case 20u:
					session.Character.SetUpdateField<int>(1035 + (int)(equipSlot * 2), item2.Id, 0);
					arg_A6D_0 = (num * 1960862831u ^ 2754346203u);
					continue;
				case 21u:
				{
					byte b = 0;
					arg_A6D_0 = (num * 269226237u ^ 265745344u);
					continue;
				}
				case 22u:
				{
					int num3 = 0;
					arg_A6D_0 = (num * 888651060u ^ 1045458128u);
					continue;
				}
				case 23u:
					arg_A6D_0 = (num * 3169614868u ^ 1615237482u);
					continue;
				case 24u:
					arg_A6D_0 = (num * 1798968942u ^ 2783094218u);
					continue;
				case 25u:
					session.Character.Equipment.Remove(equipSlot);
					arg_A6D_0 = (num * 2316556123u ^ 1531280410u);
					continue;
				case 26u:
				{
					Item item3 = session.Character.Bag[bagSlot];
					Item item4;
					SmartGuid smartGuid2 = new SmartGuid(item4.Guid, 0, GuidType.Item, 0uL);
					SmartGuid smartGuid3 = new SmartGuid(item3.Guid, 0, GuidType.Item, 0uL);
					arg_A6D_0 = (num * 2984176438u ^ 4129044090u);
					continue;
				}
				case 27u:
				{
					byte b;
					SmartGuid smartGuid4;
					session.Character.SetUpdateField<ulong>(1085 + (int)((23 + b) * 4) + 2, smartGuid4.HighGuid, 0);
					arg_A6D_0 = (num * 2890893173u ^ 349214354u);
					continue;
				}
				case 28u:
				{
					SmartGuid smartGuid2;
					session.Character.SetUpdateField<ulong>(1085 + (int)(bagSlot * 4), smartGuid2.Guid, 0);
					session.Character.SetUpdateField<ulong>(1085 + (int)(bagSlot * 4) + 2, smartGuid2.HighGuid, 0);
					arg_A6D_0 = (num * 737849647u ^ 1775535865u);
					continue;
				}
				case 29u:
				{
					int num3;
					arg_A6D_0 = ((num3 < Manager.WorldMgr.CharaterList.Count) ? 4017585302u : 2853305574u);
					continue;
				}
				case 30u:
					goto IL_588;
				case 31u:
				{
					int num3;
					num3++;
					arg_A6D_0 = 4264159176u;
					continue;
				}
				case 32u:
					arg_A6D_0 = ((session.Character.Equipment.ContainsKey(equipSlot) ? 3897993171u : 4023075236u) ^ num * 3842347572u);
					continue;
				case 33u:
					goto IL_B4B;
				case 34u:
					session.Character.SetUpdateField<ushort>(1035 + (int)(equipSlot * 2) + 1, (ushort)item2.ModId, 0);
					arg_A6D_0 = (num * 2822665324u ^ 3380783635u);
					continue;
				case 35u:
					arg_A6D_0 = (num * 3349837127u ^ 2233701625u);
					continue;
				case 36u:
				{
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4) + 2, 0uL, 0);
					SmartGuid smartGuid3;
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4), smartGuid3.Guid, 0);
					arg_A6D_0 = (num * 927448395u ^ 866192737u);
					continue;
				}
				case 37u:
					session.Character.SetUpdateField<ushort>(1035 + (int)(equipSlot * 2) + 1, 0, 0);
					arg_A6D_0 = (num * 1706796764u ^ 3182899609u);
					continue;
				case 38u:
				{
					Item item3;
					session.Character.SetUpdateField<int>(1035 + (int)(equipSlot * 2), item3.Id, 0);
					arg_A6D_0 = (num * 42299747u ^ 2380411742u);
					continue;
				}
				case 39u:
					arg_A6D_0 = (num * 1318585816u ^ 3647086635u);
					continue;
				case 40u:
					session.Character.Bag = dictionary;
					arg_A6D_0 = (num * 2027637424u ^ 1585480347u);
					continue;
				case 41u:
					arg_A6D_0 = (((!session.Character.Bag.ContainsKey(bagSlot)) ? 1338625282u : 395459323u) ^ num * 783094712u);
					continue;
				case 42u:
					session.Character.SetUpdateField<int>(1035 + (int)(equipSlot * 2), 0, 0);
					arg_A6D_0 = (num * 1468912291u ^ 969255781u);
					continue;
				case 43u:
					Manager.WorldMgr.CharaterList[index] = session.Character;
					arg_A6D_0 = 2195683288u;
					continue;
				case 44u:
				{
					byte b;
					SmartGuid smartGuid4;
					session.Character.SetUpdateField<ulong>(1085 + (int)((23 + b) * 4), smartGuid4.Guid, 0);
					arg_A6D_0 = (num * 1452020312u ^ 1516754462u);
					continue;
				}
				case 45u:
					session.Character.SetUpdateField<ushort>(1035 + (int)(equipSlot * 2) + 1, 0, 1);
					arg_A6D_0 = (num * 4099664907u ^ 2811872651u);
					continue;
				case 46u:
				{
					byte b;
					SmartGuid smartGuid4 = new SmartGuid(session.Character.Bag[23 + b].Guid, 0, GuidType.Item, 0uL);
					arg_A6D_0 = 3795433309u;
					continue;
				}
				case 47u:
					session.Character.Bag.Remove(bagSlot);
					arg_A6D_0 = (num * 75564486u ^ 2509859790u);
					continue;
				case 48u:
				{
					SmartGuid smartGuid3;
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4) + 2, smartGuid3.HighGuid, 0);
					arg_A6D_0 = (num * 2532079306u ^ 2782626003u);
					continue;
				}
				case 49u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					ObjectHandler.HandleUpdateObjectValues(ref session2, true);
					arg_A6D_0 = (num * 617855158u ^ 1998553940u);
					continue;
				case 50u:
					session.Character.SetUpdateField<ulong>(1085 + (int)(equipSlot * 4), 0uL, 0);
					arg_A6D_0 = (num * 2240052089u ^ 4263156475u);
					continue;
				case 51u:
				{
					int num3;
					arg_A6D_0 = ((Manager.WorldMgr.CharaterList[num3].Guid != session.Character.Guid) ? 3122669558u : 3428108934u);
					continue;
				}
				}
				break;
			}
			ItemHandler.smethod_1(ItemHandler.smethod_0(Helper.DataDirectory(), Module.smethod_34<string>(1144845388u)), Json.CreateString<List<Character>>(Manager.WorldMgr.CharaterList));
			return;
			Block_4:
			dictionary = new Dictionary<byte, Item>();
			using (Dictionary<byte, Item>.Enumerator enumerator = session.Character.Bag.GetEnumerator())
			{
				while (true)
				{
					IL_1ED:
					int arg_1C4_0 = enumerator.MoveNext() ? -232738112 : -1969773645;
					while (true)
					{
						switch ((arg_1C4_0 ^ -1559876423) % 4)
						{
						case 0:
							arg_1C4_0 = -232738112;
							continue;
						case 1:
						{
							KeyValuePair<byte, Item> current = enumerator.Current;
							dictionary.Add((current.Key > bagSlot) ? (current.Key - 1) : current.Key, current.Value);
							arg_1C4_0 = -1601354682;
							continue;
						}
						case 3:
							goto IL_1ED;
						}
						goto Block_16;
					}
				}
				Block_16:;
			}
			session.Character.Bag.Clear();
			IL_588:
			arg_A6D_0 = 2199478937u;
			goto IL_A68;
			IL_912:
			session2.Character = session.Character;
			arg_A6D_0 = 3632523060u;
			goto IL_A68;
			IL_928:
			arg_A6D_0 = (session.Character.Equipment.ContainsKey(equipSlot) ? 2517109469u : 3799877539u);
			goto IL_A68;
			IL_B4B:
			index = 0;
			arg_A6D_0 = 3332340327u;
			goto IL_A68;
		}

		[Opcode2(ClientMessage.DestroyItem, "18125")]
		public static void HandleDestroyItem(ref PacketReader packet, WorldClass2 session)
		{
			packet.Read<uint>();
			byte b;
			Dictionary<byte, Item> dictionary;
			WorldClass session2;
			while (true)
			{
				IL_E1:
				uint arg_B8_0 = 1479706634u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B8_0 ^ 940884380u)) % 7u)
					{
					case 0u:
						goto IL_E1;
					case 1u:
						session.Character.Bag.Remove(b);
						arg_B8_0 = (num * 3750115250u ^ 704789659u);
						continue;
					case 2u:
						if (b >= 23)
						{
							arg_B8_0 = (num * 10468204u ^ 43277318u);
							continue;
						}
						goto IL_439;
					case 3u:
					{
						Item arg_6A_0 = session.Character.Bag[b];
						arg_B8_0 = (num * 4157225570u ^ 1490106046u);
						continue;
					}
					case 4u:
						dictionary = new Dictionary<byte, Item>();
						arg_B8_0 = (num * 2455461421u ^ 1748343064u);
						continue;
					case 5u:
						packet.Read<byte>();
						b = packet.Read<byte>();
						session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_B8_0 = (num * 1883076200u ^ 3879309864u);
						continue;
					}
					goto Block_2;
				}
			}
			uint arg_63A_0;
			Item item;
			while (true)
			{
				IL_635:
				uint num;
				switch ((num = (arg_63A_0 ^ 940884380u)) % 30u)
				{
				case 0u:
					session.Character.SetUpdateField<int>(1035 + (int)(b * 2), 0, 0);
					session.Character.SetUpdateField<ushort>(1035 + (int)(b * 2) + 1, 0, 0);
					session.Character.SetUpdateField<ushort>(1035 + (int)(b * 2) + 1, 0, 0);
					session.Character.SetUpdateField<ushort>(1035 + (int)(b * 2) + 1, 0, 1);
					arg_63A_0 = (num * 2347620057u ^ 297415167u);
					continue;
				case 1u:
				{
					PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
					BitPack arg_5AD_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
					packetWriter.WriteUInt32(1u);
					Character character;
					packetWriter.WriteUInt16((ushort)character.Map);
					arg_5AD_0.Write<bool>(true);
					arg_5AD_0.Flush();
					arg_63A_0 = (num * 364780618u ^ 4039577125u);
					continue;
				}
				case 2u:
				{
					byte b2;
					arg_63A_0 = (((int)b2 < session.Character.Bag.Count) ? 1177635618u : 1980991802u);
					continue;
				}
				case 3u:
				{
					PacketWriter packetWriter;
					packetWriter.WriteInt32(0);
					arg_63A_0 = (num * 1863506504u ^ 2872540547u);
					continue;
				}
				case 4u:
					session2.Character = session.Character;
					arg_63A_0 = 2092284884u;
					continue;
				case 5u:
				{
					PacketWriter packetWriter;
					SmartGuid guid;
					packetWriter.WriteSmartGuid(guid);
					session.Send(ref packetWriter);
					arg_63A_0 = (num * 1992055980u ^ 2561592906u);
					continue;
				}
				case 6u:
					arg_63A_0 = (num * 2481838976u ^ 2085966606u);
					continue;
				case 7u:
				{
					byte b2;
					b2 += 1;
					arg_63A_0 = (num * 581392080u ^ 1120063516u);
					continue;
				}
				case 8u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_63A_0 = (num * 3730459737u ^ 4119815487u);
					continue;
				case 9u:
					arg_63A_0 = (num * 4013260396u ^ 3339049186u);
					continue;
				case 10u:
				{
					int num2 = 0;
					arg_63A_0 = (num * 170813716u ^ 815519874u);
					continue;
				}
				case 11u:
					goto IL_439;
				case 12u:
				{
					byte b2;
					SmartGuid smartGuid;
					session.Character.SetUpdateField<ulong>(1085 + (int)((23 + b2) * 4) + 2, smartGuid.HighGuid, 0);
					arg_63A_0 = (num * 599351454u ^ 1201031827u);
					continue;
				}
				case 13u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_63A_0 = (num * 1722599098u ^ 78266358u);
					continue;
				case 14u:
				{
					int num3 = 0;
					arg_63A_0 = (num * 2079855051u ^ 1201392757u);
					continue;
				}
				case 15u:
				{
					byte b2;
					SmartGuid smartGuid;
					session.Character.SetUpdateField<ulong>(1085 + (int)((23 + b2) * 4), smartGuid.Guid, 0);
					arg_63A_0 = (num * 1686053465u ^ 2337712971u);
					continue;
				}
				case 16u:
				{
					Character character = session.Character;
					arg_63A_0 = (num * 2024021156u ^ 3868436006u);
					continue;
				}
				case 17u:
					session.Character.Bag = dictionary;
					arg_63A_0 = (num * 2306417256u ^ 1137006036u);
					continue;
				case 19u:
				{
					PacketWriter packetWriter;
					Character character;
					packetWriter.WriteUInt16((ushort)character.Map);
					int num3;
					packetWriter.WriteUInt32((uint)num3);
					SmartGuid guid = new SmartGuid(item.Guid, 0, GuidType.Item, 0uL);
					arg_63A_0 = (num * 3758715600u ^ 4001188091u);
					continue;
				}
				case 20u:
					session.Character.SetUpdateField<ulong>(1085 + (int)(b * 4), 0uL, 0);
					session.Character.SetUpdateField<ulong>(1085 + (int)(b * 4) + 2, 0uL, 0);
					arg_63A_0 = (num * 4263489551u ^ 4220117414u);
					continue;
				case 21u:
				{
					int num3;
					arg_63A_0 = (((num3 > 0) ? 897509384u : 511989551u) ^ num * 999052215u);
					continue;
				}
				case 22u:
				{
					int num2;
					arg_63A_0 = ((num2 >= 16) ? 906854550u : 933086591u);
					continue;
				}
				case 23u:
				{
					int num2;
					session.Character.SetUpdateField<ulong>(1085 + (23 + num2) * 4, 0uL, 0);
					arg_63A_0 = 869087837u;
					continue;
				}
				case 24u:
				{
					byte b2 = 0;
					arg_63A_0 = (num * 877610943u ^ 4050923773u);
					continue;
				}
				case 25u:
				{
					int num2;
					num2++;
					arg_63A_0 = (num * 3409590307u ^ 4053566833u);
					continue;
				}
				case 26u:
				{
					byte b2;
					SmartGuid smartGuid = new SmartGuid(session.Character.Bag[23 + b2].Guid, 0, GuidType.Item, 0uL);
					arg_63A_0 = 684885291u;
					continue;
				}
				case 27u:
				{
					int num2;
					session.Character.SetUpdateField<ulong>(1085 + (23 + num2) * 4 + 2, 0uL, 0);
					arg_63A_0 = (num * 2108742514u ^ 956540315u);
					continue;
				}
				case 28u:
					goto IL_6C0;
				case 29u:
					arg_63A_0 = (num * 66432867u ^ 1045735881u);
					continue;
				}
				break;
			}
			return;
			Block_2:
			using (Dictionary<byte, Item>.Enumerator enumerator = session.Character.Bag.GetEnumerator())
			{
				while (true)
				{
					IL_176:
					int arg_14D_0 = (!enumerator.MoveNext()) ? 177736481 : 1734923895;
					while (true)
					{
						switch ((arg_14D_0 ^ 940884380) % 4)
						{
						case 0:
							arg_14D_0 = 1734923895;
							continue;
						case 2:
							goto IL_176;
						case 3:
						{
							KeyValuePair<byte, Item> current = enumerator.Current;
							dictionary.Add((current.Key > b) ? (current.Key - 1) : current.Key, current.Value);
							arg_14D_0 = 1924910954;
							continue;
						}
						}
						goto Block_10;
					}
				}
				Block_10:;
			}
			session.Character.Bag.Clear();
			goto IL_6C0;
			IL_439:
			item = session.Character.Equipment[b];
			session.Character.Equipment.Remove(b);
			arg_63A_0 = 875231736u;
			goto IL_635;
			IL_6C0:
			arg_63A_0 = 1448980257u;
			goto IL_635;
		}

		public static byte GetEquipSlot(byte equipSlot)
		{
			uint arg_5B_0;
			switch (equipSlot)
			{
			case 11:
				IL_13B:
				equipSlot = 10;
				arg_5B_0 = 3909118595u;
				break;
			case 12:
				IL_1D8:
				equipSlot = 12;
				arg_5B_0 = 2734251434u;
				break;
			case 13:
				IL_1E6:
				equipSlot = 15;
				arg_5B_0 = 2734251434u;
				break;
			case 14:
				IL_149:
				equipSlot = 16;
				arg_5B_0 = 2555984845u;
				break;
			case 15:
				IL_198:
				equipSlot = 15;
				arg_5B_0 = 4106678855u;
				break;
			case 16:
				IL_1B8:
				equipSlot = 14;
				arg_5B_0 = 3064797242u;
				break;
			case 17:
				IL_202:
				equipSlot = 15;
				arg_5B_0 = 2734251434u;
				break;
			case 18:
				return 18;
			case 19:
				IL_109:
				equipSlot = 18;
				arg_5B_0 = 3529446854u;
				break;
			case 20:
				IL_18B:
				equipSlot = 4;
				arg_5B_0 = 4115910047u;
				break;
			case 21:
				IL_1F4:
				equipSlot = 15;
				arg_5B_0 = 2734251434u;
				break;
			case 22:
			case 23:
				IL_210:
				equipSlot = 16;
				arg_5B_0 = 2165381071u;
				break;
			case 24:
				return 24;
			case 25:
			case 26:
			case 27:
			case 28:
				IL_21E:
				equipSlot = 15;
				arg_5B_0 = 2264719853u;
				break;
			default:
				IL_51:
				arg_5B_0 = 2612180903u;
				break;
			}
			while (true)
			{
				uint num;
				switch ((num = (arg_5B_0 ^ 3438758084u)) % 26u)
				{
				case 0u:
					goto IL_202;
				case 1u:
					goto IL_1F4;
				case 2u:
					goto IL_1E6;
				case 3u:
					goto IL_1D8;
				case 4u:
					goto IL_210;
				case 5u:
					arg_5B_0 = (num * 666848517u ^ 3393978215u);
					continue;
				case 6u:
					goto IL_1B8;
				case 7u:
					return 24;
				case 8u:
					arg_5B_0 = (num * 1276685670u ^ 3974509926u);
					continue;
				case 9u:
					goto IL_198;
				case 10u:
					goto IL_18B;
				case 11u:
					arg_5B_0 = (num * 3754330600u ^ 2814399218u);
					continue;
				case 12u:
					equipSlot -= 1;
					arg_5B_0 = 2734251434u;
					continue;
				case 13u:
					goto IL_51;
				case 14u:
					arg_5B_0 = (num * 2535710746u ^ 4198311014u);
					continue;
				case 15u:
					goto IL_149;
				case 16u:
					goto IL_13B;
				case 17u:
					arg_5B_0 = (num * 1048723800u ^ 4201033698u);
					continue;
				case 18u:
					goto IL_21E;
				case 19u:
					arg_5B_0 = (num * 1924184679u ^ 4016858399u);
					continue;
				case 20u:
					goto IL_109;
				case 21u:
					arg_5B_0 = (num * 1804965198u ^ 420479472u);
					continue;
				case 23u:
					arg_5B_0 = (num * 496771006u ^ 3039250676u);
					continue;
				case 24u:
					return 18;
				case 25u:
					arg_5B_0 = (num * 3078994998u ^ 2299167308u);
					continue;
				}
				break;
			}
			return equipSlot;
		}

		public static void HandleItemPushResult(int itemId, ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.ItemPushResult, true);
			BitPack bitPack = new BitPack(packetWriter, session.Character.Guid, 0uL, 0uL, 0uL);
			bitPack.WriteGuidMask(new byte[]
			{
				1
			});
			while (true)
			{
				IL_3EC:
				uint arg_377_0 = 909021692u;
				while (true)
				{
					uint num;
					switch ((num = (arg_377_0 ^ 935844983u)) % 26u)
					{
					case 0u:
						packetWriter.WriteInt32(0);
						bitPack.WriteGuidBytes(new byte[]
						{
							0,
							6
						});
						arg_377_0 = (num * 928309760u ^ 2986799762u);
						continue;
					case 1u:
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 3938014638u ^ 1429137374u);
						continue;
					case 2u:
						bitPack.WriteGuidMask(new byte[]
						{
							5
						});
						arg_377_0 = (num * 1720432155u ^ 3025882064u);
						continue;
					case 3u:
						session.Send(ref packetWriter);
						arg_377_0 = (num * 3073065698u ^ 2572400910u);
						continue;
					case 4u:
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 3496805978u ^ 1994654579u);
						continue;
					case 5u:
						packetWriter.WriteInt32(itemId);
						arg_377_0 = (num * 3055987258u ^ 3242072529u);
						continue;
					case 6u:
						goto IL_3EC;
					case 7u:
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 2896448710u ^ 3382928632u);
						continue;
					case 8u:
						bitPack.WriteGuidBytes(new byte[]
						{
							5,
							7
						});
						arg_377_0 = (num * 2018327844u ^ 4127578553u);
						continue;
					case 9u:
						bitPack.WriteGuidBytes(new byte[]
						{
							1
						});
						arg_377_0 = (num * 2939031280u ^ 1844060896u);
						continue;
					case 10u:
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.WriteGuidMask(new byte[]
						{
							3
						});
						arg_377_0 = (num * 4174044662u ^ 1408249211u);
						continue;
					case 11u:
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 2759647948u ^ 645900932u);
						continue;
					case 12u:
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 1692886088u ^ 1243261087u);
						continue;
					case 14u:
						bitPack.Write<bool>(true);
						arg_377_0 = (num * 3998004725u ^ 1832986328u);
						continue;
					case 15u:
						packetWriter.WriteUInt8(1);
						arg_377_0 = (num * 1248761089u ^ 2873989142u);
						continue;
					case 16u:
						packetWriter.WriteInt32(1);
						arg_377_0 = (num * 2808146406u ^ 2093798743u);
						continue;
					case 17u:
						bitPack.Write<bool>(false);
						bitPack.WriteGuidMask(new byte[]
						{
							4
						});
						arg_377_0 = (num * 73540350u ^ 2658189703u);
						continue;
					case 18u:
						packetWriter.WriteInt32(0);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt32(0u);
						bitPack.WriteGuidBytes(new byte[]
						{
							2
						});
						arg_377_0 = (num * 3281236275u ^ 2278699308u);
						continue;
					case 19u:
						bitPack.WriteGuidBytes(new byte[]
						{
							4,
							3
						});
						arg_377_0 = (num * 3370243852u ^ 2197024189u);
						continue;
					case 20u:
						packetWriter.WriteInt32(0);
						packetWriter.WriteInt32(0);
						arg_377_0 = (num * 3926998091u ^ 214892544u);
						continue;
					case 21u:
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 2485854747u ^ 992343886u);
						continue;
					case 22u:
						bitPack.WriteGuidMask(new byte[1]);
						bitPack.Write<bool>(true);
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 2532008586u ^ 2581047111u);
						continue;
					case 23u:
						bitPack.Write<bool>(true);
						bitPack.WriteGuidMask(new byte[]
						{
							2,
							6
						});
						bitPack.Write<bool>(true);
						bitPack.WriteGuidMask(new byte[]
						{
							7
						});
						bitPack.Flush();
						arg_377_0 = (num * 2517137752u ^ 2854991386u);
						continue;
					case 24u:
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 3447671502u ^ 3800525856u);
						continue;
					case 25u:
						bitPack.Write<bool>(false);
						arg_377_0 = (num * 3805512309u ^ 3362271688u);
						continue;
					}
					return;
				}
			}
		}

		static string smethod_0(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static void smethod_1(string string_0, string string_1)
		{
			File.WriteAllText(string_0, string_1);
		}
	}
}
