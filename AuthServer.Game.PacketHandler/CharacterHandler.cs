using AuthServer.Game.Entities;
using AuthServer.Game.Packets.PacketHandler;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Game.Packets.PacketHandler;
using AuthServer.WorldServer.Managers;
using Framework.Constants;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Misc;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using Framework.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace AuthServer.Game.PacketHandler
{
	public class CharacterHandler : Manager
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CharacterHandler.__c __9 = new CharacterHandler.__c();

			public static Func<Namegen, string> __9__3_1;

			internal string HandleGenerateRandomCharacterNameb__3_1(Namegen n)
			{
				return n.Name;
			}
		}

		private static ulong lastSession = 0uL;

		public static bool chatRunning = true;

		[Opcode(ClientMessage.EnumCharacters, "18125")]
		public static void HandleEnumCharactersResult(ref PacketReader packet, WorldClass session)
		{
			session.Character = null;
			if (CharacterHandler.smethod_1(CharacterHandler.smethod_0(Helper.DataDirectory(), Module.smethod_33<string>(1012059880u))))
			{
				goto IL_25;
			}
			goto IL_6AE;
			uint arg_57_0;
			while (true)
			{
				IL_52:
				uint num;
				PacketWriter packetWriter;
				int num2;
				BitPack bitPack;
				int num3;
				uint arg_339_0;
				bool flag;
				switch ((num = (arg_57_0 ^ 3546639019u)) % 39u)
				{
				case 0u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].FacialHair);
					arg_57_0 = (num * 3871093834u ^ 3049929460u);
					continue;
				case 1u:
					packetWriter.WriteFloat(Manager.WorldMgr.CharaterList[num2].Position.X);
					arg_57_0 = (num * 2307388802u ^ 1187397841u);
					continue;
				case 2u:
					bitPack.Write<int>(1);
					bitPack.Write<int>(0);
					bitPack.Write<int>(0);
					arg_57_0 = (num * 2127932406u ^ 461565267u);
					continue;
				case 3u:
					goto IL_99A;
				case 4u:
					goto IL_811;
				case 5u:
					bitPack.Write<int>(0);
					bitPack.Write<int>(1);
					bitPack.Write<int>(0);
					arg_57_0 = (num * 1909605126u ^ 1519434621u);
					continue;
				case 6u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].HairColor);
					arg_57_0 = (num * 2613601680u ^ 188208087u);
					continue;
				case 7u:
					packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].Map);
					arg_57_0 = (num * 134783787u ^ 585703934u);
					continue;
				case 8u:
					num2 = 0;
					arg_57_0 = (num * 1874718705u ^ 448644109u);
					continue;
				case 9u:
					bitPack.Flush();
					packetWriter.WriteInt32(Manager.WorldMgr.CharaterList.Count);
					arg_57_0 = (num * 629279092u ^ 801581919u);
					continue;
				case 10u:
					goto IL_398;
				case 11u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Skin);
					arg_57_0 = (num * 3814152332u ^ 1947054060u);
					continue;
				case 12u:
					packetWriter.WriteSmartGuid(Manager.WorldMgr.CharaterList[num2].GuildGuid, global::GuidType.Player);
					packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].CharacterFlags);
					arg_57_0 = (num * 2310401924u ^ 98665580u);
					continue;
				case 13u:
					bitPack.Write<int>(1);
					arg_57_0 = (num * 968182909u ^ 87796692u);
					continue;
				case 14u:
					goto IL_6AE;
				case 15u:
					CharacterHandler.smethod_3(CharacterHandler.smethod_2(CharacterHandler.smethod_0(Helper.DataDirectory(), Module.smethod_34<string>(1144845388u))));
					arg_57_0 = (num * 1138724256u ^ 99620003u);
					continue;
				case 16u:
					packetWriter.WriteUInt32(0u);
					arg_57_0 = (num * 1007004570u ^ 3344957856u);
					continue;
				case 17u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Race);
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Class);
					arg_57_0 = (num * 3930009718u ^ 2102488844u);
					continue;
				case 18u:
					packetWriter.WriteUInt32(0u);
					arg_57_0 = (num * 1489152377u ^ 3564692854u);
					continue;
				case 19u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Face);
					arg_57_0 = (num * 149408727u ^ 3820009058u);
					continue;
				case 20u:
					packetWriter.WriteUInt32(0u);
					packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].PetDisplayInfo);
					arg_57_0 = (num * 1110553608u ^ 3564960664u);
					continue;
				case 21u:
					packetWriter.WriteUInt32(0u);
					arg_57_0 = (num * 917377323u ^ 3999301969u);
					continue;
				case 22u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Level);
					packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].Zone);
					arg_57_0 = (num * 1508659266u ^ 2200773903u);
					continue;
				case 23u:
					IL_329:
					if (num3 < 23)
					{
						goto IL_398;
					}
					arg_339_0 = 3538062956u;
					break;
				case 24u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].HairStyle);
					arg_57_0 = (num * 258059524u ^ 1046586389u);
					continue;
				case 25u:
					packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].CustomizeFlags);
					arg_57_0 = (num * 2758559348u ^ 3118814838u);
					continue;
				case 26u:
					flag = false;
					num3 = 0;
					arg_57_0 = (num * 2666996767u ^ 3953141618u);
					continue;
				case 27u:
					packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].PetFamily);
					arg_57_0 = (num * 4066988638u ^ 1168559191u);
					continue;
				case 28u:
					packetWriter.WriteUInt8(0);
					arg_57_0 = (num * 2924172985u ^ 3507841469u);
					continue;
				case 29u:
					packetWriter.WriteFloat(Manager.WorldMgr.CharaterList[num2].Position.Y);
					arg_57_0 = (num * 2110621870u ^ 2892101880u);
					continue;
				case 30u:
					packetWriter = new PacketWriter(ServerMessage.EnumCharactersResult, true);
					bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
					arg_57_0 = 3979521935u;
					continue;
				case 31u:
					packetWriter.WriteFloat(Manager.WorldMgr.CharaterList[num2].Position.Z);
					arg_57_0 = (num * 238996209u ^ 4232709328u);
					continue;
				case 32u:
					arg_57_0 = (((Manager.WorldMgr.CharaterList == null) ? 3582413963u : 2685933514u) ^ num * 3262820671u);
					continue;
				case 33u:
					IL_37E:
					if (num2 < Manager.WorldMgr.CharaterList.Count)
					{
						goto IL_126;
					}
					arg_339_0 = 2407627896u;
					break;
				case 34u:
					goto IL_25;
				case 35u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].HornStyle);
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].BlindFolds);
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Tattoos);
					arg_57_0 = (num * 957095111u ^ 1914876318u);
					continue;
				case 36u:
					packetWriter.WriteUInt8(Manager.WorldMgr.CharaterList[num2].Gender);
					arg_57_0 = (num * 4224067557u ^ 2068767078u);
					continue;
				case 37u:
					goto IL_126;
				case 38u:
					Manager.WorldMgr.CharaterList = new List<Character>();
					arg_57_0 = (num * 1258260271u ^ 1965682678u);
					continue;
				default:
					goto IL_811;
				}
				string name;
				while (true)
				{
					IL_334:
					switch ((num = (arg_339_0 ^ 3546639019u)) % 13u)
					{
					case 0u:
						goto IL_329;
					case 1u:
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt8(0);
						arg_339_0 = (num * 1122833897u ^ 3614880232u);
						continue;
					case 2u:
						session.Send(ref packetWriter);
						arg_339_0 = (num * 1900107504u ^ 1966250030u);
						continue;
					case 3u:
						packetWriter.WriteString(name, true);
						arg_339_0 = (num * 1731080081u ^ 2729717507u);
						continue;
					case 4u:
						goto IL_2CD;
					case 5u:
						packetWriter.WriteUInt32(0u);
						arg_339_0 = (num * 637694094u ^ 448731726u);
						continue;
					case 6u:
						num2++;
						arg_339_0 = (num * 1173775919u ^ 2404844881u);
						continue;
					case 7u:
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt32(0u);
						bitPack.Write<int>(CharacterHandler.smethod_6(CharacterHandler.smethod_5(), name).Length, 6);
						arg_339_0 = (num * 3317182053u ^ 761679791u);
						continue;
					case 8u:
						packetWriter.WriteUInt16(0);
						arg_339_0 = (num * 1407846318u ^ 2309420174u);
						continue;
					case 10u:
						goto IL_243;
					case 11u:
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Write<int>(0, 5);
						bitPack.Flush();
						arg_339_0 = (num * 1666249630u ^ 963420602u);
						continue;
					case 12u:
						goto IL_37E;
					}
					return;
				}
				IL_126:
				bool arg_13B_0 = Manager.WorldMgr.CharaterList[num2].LoginCinematic;
				name = Manager.WorldMgr.CharaterList[num2].Name;
				packetWriter.WriteSmartGuid(Manager.WorldMgr.CharaterList[num2].Guid, global::GuidType.Player);
				arg_57_0 = 3243624136u;
				continue;
				IL_398:
				flag = false;
				arg_57_0 = 4016560583u;
				continue;
				IL_99A:
				packetWriter.WriteUInt32(Manager.WorldMgr.CharaterList[num2].PetLevel);
				arg_57_0 = (num * 2312245282u ^ 1285680378u);
				continue;
				IL_811:
				using (Dictionary<byte, Item>.Enumerator enumerator = Manager.WorldMgr.CharaterList[num2].Equipment.GetEnumerator())
				{
					while (true)
					{
						IL_971:
						uint arg_928_0 = enumerator.MoveNext() ? 4221460984u : 3491304591u;
						while (true)
						{
							switch ((num = (arg_928_0 ^ 3546639019u)) % 11u)
							{
							case 0u:
							{
								KeyValuePair<byte, Item> current;
								packetWriter.WriteInt32(current.Value.DisplayInfoId);
								packetWriter.WriteUInt32(0u);
								arg_928_0 = (num * 3196428972u ^ 556558901u);
								continue;
							}
							case 1u:
							{
								KeyValuePair<byte, Item> current = enumerator.Current;
								arg_928_0 = 3615480248u;
								continue;
							}
							case 2u:
							{
								KeyValuePair<byte, Item> current;
								arg_928_0 = (((current.Key != 15) ? 717825882u : 101407626u) ^ num * 2290213457u);
								continue;
							}
							case 3u:
							{
								byte b;
								b += 1;
								arg_928_0 = (num * 3503197238u ^ 2949610752u);
								continue;
							}
							case 4u:
								goto IL_97F;
							case 6u:
								arg_928_0 = 4221460984u;
								continue;
							case 7u:
							{
								KeyValuePair<byte, Item> current;
								arg_928_0 = ((((int)current.Key == num3) ? 398889445u : 474685837u) ^ num * 2374242494u);
								continue;
							}
							case 8u:
							{
								KeyValuePair<byte, Item> current;
								byte b = current.Key;
								arg_928_0 = (num * 1448942928u ^ 209798463u);
								continue;
							}
							case 9u:
							{
								byte b;
								packetWriter.WriteUInt8(b);
								arg_928_0 = 3998454492u;
								continue;
							}
							case 10u:
								goto IL_971;
							}
							goto Block_11;
						}
					}
					Block_11:
					goto IL_987;
					IL_97F:
					flag = true;
					IL_987:
					goto IL_A51;
				}
				goto IL_99A;
				IL_A51:
				if (!flag)
				{
					goto IL_2CD;
				}
				IL_243:
				num3++;
				arg_339_0 = 2988058974u;
				goto IL_334;
				IL_2CD:
				arg_339_0 = 2995244852u;
				goto IL_334;
			}
			return;
			IL_25:
			Manager.WorldMgr.CharaterList = Json.CreateObject<List<Character>>(CharacterHandler.smethod_4(CharacterHandler.smethod_0(Helper.DataDirectory(), Module.smethod_33<string>(1012059880u))));
			arg_57_0 = 2343455517u;
			goto IL_52;
			IL_6AE:
			arg_57_0 = 3967426555u;
			goto IL_52;
		}

		[Opcode(ClientMessage.CreateCharacter, "18156")]
		public static void HandleCreateCharacter(ref PacketReader packet, WorldClass session)
		{
			string name;
			Character pcharacter;
			PacketWriter packetWriter;
			while (true)
			{
				IL_75B:
				uint arg_6C1_0 = 985380630u;
				while (true)
				{
					uint num;
					ulong guid;
					ulong arg_41D_0;
					switch ((num = (arg_6C1_0 ^ 1028551618u)) % 35u)
					{
					case 0u:
						arg_6C1_0 = (Manager.WorldMgr.CharaterList.Any((Character c) => CharacterHandler.__c__DisplayClass1_0.smethod_0(c.Name, name)) ? 1046617093u : 271931922u);
						continue;
					case 1u:
					{
						ActionButton actionButton = new ActionButton
						{
							Action = 119212uL,
							SlotId = 1,
							SpecGroup = pcharacter.ActiveSpecGroup
						};
						arg_6C1_0 = (num * 2120388645u ^ 2458026040u);
						continue;
					}
					case 2u:
					{
						Item item;
						pcharacter.Equipment.Add(ItemHandler.GetEquipSlot(item.InventoryType), item);
						arg_6C1_0 = (num * 864281780u ^ 2303982439u);
						continue;
					}
					case 3u:
					{
						byte race;
						byte @class;
						byte gender;
						byte skin;
						int zone;
						int map;
						float x;
						float y;
						float z;
						float o;
						byte face;
						byte hairStyle;
						byte facialHair;
						byte hornStyle;
						byte blindFolds;
						byte tattoos;
						CharacterFlag characterFlags;
						byte hairColor;
						pcharacter = new Character(guid, 4592)
						{
							Guid = guid,
							Name = name,
							AccountId = 1u,
							Race = race,
							Class = @class,
							Gender = gender,
							Skin = skin,
							Zone = (uint)zone,
							Map = (uint)map,
							Position = new Vector4
							{
								X = x,
								Y = y,
								Z = z,
								O = o
							},
							Face = face,
							HairStyle = hairStyle,
							FacialHair = facialHair,
							HornStyle = hornStyle,
							BlindFolds = blindFolds,
							Tattoos = tattoos,
							CharacterFlags = (uint)characterFlags,
							HairColor = hairColor,
							Level = 1
						};
						arg_6C1_0 = (num * 2763845485u ^ 3228747185u);
						continue;
					}
					case 4u:
					{
						int num2 = 0;
						arg_6C1_0 = (num * 1775812274u ^ 880878285u);
						continue;
					}
					case 5u:
					{
						Item item;
						Item item2;
						item.InventoryType = item2.InventoryType;
						item.Guid = (ulong)((long)(pcharacter.Equipment.Count + pcharacter.Bag.Count) + 1L);
						arg_6C1_0 = ((item.InventoryType == 18) ? 903267311u : 457554016u);
						continue;
					}
					case 6u:
					{
						uint[] array;
						arg_6C1_0 = (((array == null) ? 1731946765u : 1858551295u) ^ num * 2714328298u);
						continue;
					}
					case 7u:
					{
						CharacterFlag characterFlags = CharacterFlag.Decline;
						arg_6C1_0 = (num * 220391134u ^ 2015972157u);
						continue;
					}
					case 8u:
						packetWriter.WriteUInt8(53);
						arg_6C1_0 = (num * 181734751u ^ 3388545914u);
						continue;
					case 9u:
						arg_41D_0 = 1uL;
						goto IL_41D;
					case 11u:
					{
						int num2;
						num2++;
						arg_6C1_0 = 114322827u;
						continue;
					}
					case 12u:
					{
						int map = 1669;
						int zone = 0;
						float x = 4851.645f;
						arg_6C1_0 = 1136245746u;
						continue;
					}
					case 13u:
						if (Manager.WorldMgr.CharaterList.Count <= 0)
						{
							arg_6C1_0 = (num * 526635500u ^ 3603251270u);
							continue;
						}
						arg_41D_0 = Manager.WorldMgr.CharaterList[Manager.WorldMgr.CharaterList.Count - 1].Guid + 10uL;
						goto IL_41D;
					case 14u:
						arg_6C1_0 = (num * 2026561294u ^ 932960213u);
						continue;
					case 15u:
					{
						int num2;
						uint[] array;
						arg_6C1_0 = ((num2 < array.Length) ? 131065434u : 1825506867u);
						continue;
					}
					case 16u:
						goto IL_766;
					case 17u:
					{
						int num2;
						uint[] array;
						Item item2 = Manager.Equipments.AvailableItems[(int)array[num2]];
						Item item;
						item.Id = item2.Id;
						item.DisplayInfoIds = item2.DisplayInfoIds;
						arg_6C1_0 = (num * 1005856648u ^ 1867141104u);
						continue;
					}
					case 18u:
						CharacterHandler.smethod_8(packet);
						arg_6C1_0 = (num * 2772800459u ^ 373937858u);
						continue;
					case 19u:
					{
						Item item;
						arg_6C1_0 = (((!pcharacter.Equipment.ContainsKey(ItemHandler.GetEquipSlot(item.InventoryType))) ? 2845124146u : 3122201077u) ^ num * 48532093u);
						continue;
					}
					case 20u:
						session.Send(ref packetWriter);
						arg_6C1_0 = (num * 2021283018u ^ 2886228345u);
						continue;
					case 21u:
					{
						Item item;
						Item item2;
						item.DisplayInfoId = item2.DisplayInfoIds[Module.smethod_34<string>(1624274959u)].Item1;
						arg_6C1_0 = (num * 2379711510u ^ 3749418316u);
						continue;
					}
					case 22u:
					{
						ActionButton actionButton;
						Manager.ActionMgr.AddActionButton(pcharacter, actionButton, true);
						CharStartOutfit expr_287 = Manager.Equipments.CharStartOutfits.SingleOrDefault(delegate(CharStartOutfit cso)
						{
							if (cso.RaceId == pcharacter.Race)
							{
								while (true)
								{
									IL_68:
									uint arg_4C_0 = 1548136435u;
									while (true)
									{
										uint num3;
										switch ((num3 = (arg_4C_0 ^ 1028053410u)) % 4u)
										{
										case 1u:
											arg_4C_0 = (((cso.ClassId != pcharacter.Class) ? 3884541746u : 2739672217u) ^ num3 * 3400271744u);
											continue;
										case 2u:
											goto IL_68;
										case 3u:
											goto IL_6F;
										}
										goto Block_3;
									}
								}
								Block_3:
								return false;
								IL_6F:
								return cso.SexId == pcharacter.Gender;
							}
							return false;
						});
						uint[] array = (expr_287 != null) ? expr_287.ItemId : null;
						arg_6C1_0 = 825491585u;
						continue;
					}
					case 23u:
						return;
					case 24u:
					{
						int num2;
						uint[] array;
						arg_6C1_0 = ((Manager.Equipments.AvailableItems.ContainsKey((int)array[num2]) ? 3748426148u : 3148270045u) ^ num * 3971136190u);
						continue;
					}
					case 25u:
						packetWriter.WriteUInt8(24);
						arg_6C1_0 = (num * 3821477349u ^ 1910352278u);
						continue;
					case 26u:
					{
						float y = 9884.408f;
						float z = -64.7009f;
						float o = 0f;
						arg_6C1_0 = (num * 2678738025u ^ 622810963u);
						continue;
					}
					case 27u:
						packetWriter.WriteUInt8(50);
						session.Send(ref packetWriter);
						arg_6C1_0 = (num * 3721327335u ^ 2890541034u);
						continue;
					case 28u:
					{
						int num2;
						uint[] array;
						arg_6C1_0 = ((array[num2] == 0u) ? 903267311u : 486266913u);
						continue;
					}
					case 29u:
						goto IL_75B;
					case 30u:
					{
						BitUnpack expr_E3 = new BitUnpack(packet);
						uint bits = expr_E3.GetBits<uint>(6);
						bool arg_16C_0 = expr_E3.GetBit();
						byte race = CharacterHandler.smethod_7(packet);
						byte @class = CharacterHandler.smethod_7(packet);
						byte gender = CharacterHandler.smethod_7(packet);
						byte skin = CharacterHandler.smethod_7(packet);
						byte face = CharacterHandler.smethod_7(packet);
						byte hairStyle = CharacterHandler.smethod_7(packet);
						byte hairColor = CharacterHandler.smethod_7(packet);
						byte facialHair = CharacterHandler.smethod_7(packet);
						CharacterHandler.smethod_7(packet);
						byte hornStyle = CharacterHandler.smethod_7(packet);
						byte blindFolds = CharacterHandler.smethod_7(packet);
						byte tattoos = CharacterHandler.smethod_7(packet);
						name = Character.NormalizeName(packet.ReadString(bits));
						arg_6C1_0 = ((arg_16C_0 ? 2268253766u : 3358961518u) ^ num * 245408120u);
						continue;
					}
					case 31u:
					{
						Item item2;
						arg_6C1_0 = (((item2.DisplayInfoIds.Count <= 0) ? 3612939726u : 3084024304u) ^ num * 134985129u);
						continue;
					}
					case 32u:
					{
						Item item = new Item();
						arg_6C1_0 = (num * 2707710018u ^ 2794208195u);
						continue;
					}
					case 33u:
						Manager.WorldMgr.CharaterList.Add(pcharacter);
						CharacterHandler.smethod_9(CharacterHandler.smethod_0(Helper.DataDirectory(), Module.smethod_37<string>(2717626567u)), Json.CreateString<List<Character>>(Manager.WorldMgr.CharaterList));
						arg_6C1_0 = 360563180u;
						continue;
					case 34u:
						packetWriter = new PacketWriter(ServerMessage.CreateChar, true);
						arg_6C1_0 = ((Manager.WorldMgr.CharaterList.Count < 11) ? 469416310u : 490450368u);
						continue;
					}
					return;
					IL_41D:
					guid = arg_41D_0;
					arg_6C1_0 = 228667689u;
				}
			}
			return;
			IL_766:
			session.Send(ref packetWriter);
		}

		[Opcode(ClientMessage.CharDelete, "18156")]
		public static void HandleCharDelete(ref PacketReader packet, WorldClass session)
		{
			ulong num = packet.ReadSmartGuid();
			int index = 0;
			int num2 = 0;
			PacketWriter packetWriter;
			while (true)
			{
				IL_14C:
				uint arg_116_0 = 3956756290u;
				while (true)
				{
					uint num3;
					switch ((num3 = (arg_116_0 ^ 3624521121u)) % 10u)
					{
					case 0u:
						arg_116_0 = (num3 * 1221351189u ^ 3039305110u);
						continue;
					case 1u:
						packetWriter.WriteUInt8(51);
						arg_116_0 = (num3 * 1283754437u ^ 4214349614u);
						continue;
					case 2u:
						num2++;
						arg_116_0 = 3045691952u;
						continue;
					case 3u:
						arg_116_0 = ((Manager.WorldMgr.CharaterList[num2].Guid != num) ? 3855266751u : 3638570767u);
						continue;
					case 5u:
						arg_116_0 = (num3 * 91464111u ^ 367832605u);
						continue;
					case 6u:
						goto IL_14C;
					case 7u:
						arg_116_0 = ((num2 >= Manager.WorldMgr.CharaterList.Count) ? 3093896274u : 4143858192u);
						continue;
					case 8u:
						index = num2;
						arg_116_0 = (num3 * 891506522u ^ 822658361u);
						continue;
					case 9u:
						Manager.WorldMgr.CharaterList.RemoveAt(index);
						CharacterHandler.smethod_9(CharacterHandler.smethod_0(Helper.DataDirectory(), Module.smethod_35<string>(205105435u)), Json.CreateString<List<Character>>(Manager.WorldMgr.CharaterList));
						packetWriter = new PacketWriter(ServerMessage.DeleteChar, true);
						arg_116_0 = 3445904986u;
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			session.Send(ref packetWriter);
		}

		[Opcode(ClientMessage.GenerateRandomCharacterName, "18156")]
		public static void HandleGenerateRandomCharacterName(ref PacketReader packet, WorldClass session)
		{
			byte race;
			byte gender;
			string NewName;
			while (true)
			{
				IL_1C7:
				uint arg_195_0 = 698975311u;
				while (true)
				{
					uint num;
					switch ((num = (arg_195_0 ^ 1646302372u)) % 9u)
					{
					case 0u:
					{
						PacketWriter packetWriter;
						BitPack expr_14F = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						expr_14F.Write<int>(1);
						expr_14F.Write<int>(CharacterHandler.smethod_13(NewName), 6);
						expr_14F.Flush();
						packetWriter.WriteString(NewName, true);
						session.Send(ref packetWriter);
						arg_195_0 = (num * 3767414363u ^ 2062469097u);
						continue;
					}
					case 1u:
						race = CharacterHandler.smethod_7(packet);
						gender = CharacterHandler.smethod_7(packet);
						arg_195_0 = (num * 1582143918u ^ 3312408962u);
						continue;
					case 2u:
						goto IL_1C7;
					case 3u:
					{
						IEnumerable<Namegen> arg_E6_0 = from n in Manager.Equipments.Namegens
						where n.Race == race && n.Sex == gender
						select n;
						Func<Namegen, string> arg_E6_1;
						if ((arg_E6_1 = CharacterHandler.__c.__9__3_1) == null)
						{
							arg_E6_1 = (CharacterHandler.__c.__9__3_1 = new Func<Namegen, string>(CharacterHandler.__c.__9.HandleGenerateRandomCharacterNameb__3_1));
						}
						List<string> list = arg_E6_0.Select(arg_E6_1).ToList<string>();
						arg_195_0 = 1426866854u;
						continue;
					}
					case 4u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.GenerateRandomCharacterNameResult, true);
						arg_195_0 = (num * 2017727992u ^ 2716674277u);
						continue;
					}
					case 5u:
					{
						List<string> list;
						Random random_;
						NewName = list[CharacterHandler.smethod_12(random_, list.Count)];
						arg_195_0 = 775139803u;
						continue;
					}
					case 6u:
					{
						Random random_ = CharacterHandler.smethod_11(CharacterHandler.smethod_10());
						arg_195_0 = (num * 1271455048u ^ 1163812784u);
						continue;
					}
					case 7u:
						arg_195_0 = ((Manager.WorldMgr.CharaterList.Any((Character c) => CharacterHandler.__c__DisplayClass3_0.smethod_0(c.Name, NewName)) ? 2759389124u : 2765169318u) ^ num * 3791994652u);
						continue;
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.PlayerLogin, "18125")]
		public static void HandlePlayerLogin(ref PacketReader packet, WorldClass session)
		{
			WorldClass session;
			while (true)
			{
				IL_9EF:
				uint arg_901_0 = 2109433998u;
				while (true)
				{
					uint num;
					switch ((num = (arg_901_0 ^ 1223399219u)) % 56u)
					{
					case 0u:
					{
						ulong num2;
						Log.Message(LogType.Error, Module.smethod_37<string>(88126927u), new object[]
						{
							num2
						});
						arg_901_0 = (num * 2998728080u ^ 1934339344u);
						continue;
					}
					case 1u:
					{
						ulong num2;
						int num3;
						arg_901_0 = ((Manager.WorldMgr.CharaterList[num3].Guid != num2) ? 617600691u : 1713614465u);
						continue;
					}
					case 2u:
						arg_901_0 = (num * 1137494816u ^ 4082842479u);
						continue;
					case 3u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 3431606706u ^ 2632230413u);
						continue;
					}
					case 4u:
					{
						PacketWriter expr_82C = new PacketWriter(ServerMessage.ObjectUpdate, true);
						expr_82C.WriteBytes(Module.smethod_34<string>(3884700158u).ToByteArray(), 0);
						new PacketWriter(ServerMessage.TokenTime, true);
						expr_82C.WriteBytes(Module.smethod_36<string>(1612858198u).ToByteArray(), 0);
						arg_901_0 = (num * 1879318810u ^ 716567833u);
						continue;
					}
					case 5u:
						Manager.WorldMgr.DeleteSession2(0uL);
						arg_901_0 = (num * 1189156347u ^ 2277702030u);
						continue;
					case 6u:
						goto IL_9EF;
					case 7u:
						TimeHandler.HandleLoginSetTimeSpeed(ref session);
						arg_901_0 = (num * 333596354u ^ 1983047535u);
						continue;
					case 8u:
					{
						int num3;
						num3++;
						arg_901_0 = 355966023u;
						continue;
					}
					case 9u:
					{
						PacketWriter expr_700 = new PacketWriter(ServerMessage.FeatureSystemStatusGlueScreen, true);
						BitPack bitPack = new BitPack(expr_700, 0uL, 0uL, 0uL, 0uL);
						bitPack.Write<bool>(true);
						bitPack.Write<bool>(true);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(true);
						bitPack.Write<bool>(true);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(true);
						bitPack.Flush();
						expr_700.WriteUInt32(300u);
						expr_700.WriteUInt32(0u);
						expr_700.WriteUInt64(0uL);
						arg_901_0 = (num * 2175956409u ^ 3780706177u);
						continue;
					}
					case 10u:
					{
						PacketWriter expr_69C = new PacketWriter(ServerMessage.TokenBalance, true);
						expr_69C.WriteUInt32(4u);
						expr_69C.WriteUInt64(0uL);
						expr_69C.WriteUInt64(200uL);
						expr_69C.WriteUInt32(0u);
						expr_69C.WriteUInt8(128);
						Manager.WorldMgr.SendHotfixes(session);
						arg_901_0 = (num * 4019793613u ^ 432098202u);
						continue;
					}
					case 12u:
					{
						ulong num2;
						arg_901_0 = (Manager.WorldMgr.AddSession(num2, ref session) ? 485688646u : 812137123u);
						continue;
					}
					case 13u:
						session.Character.InRangeObjects = new Dictionary<ulong, WorldObject>();
						arg_901_0 = (num * 2621062377u ^ 143411677u);
						continue;
					case 14u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(true);
						arg_901_0 = (num * 3586527354u ^ 4249280723u);
						continue;
					}
					case 15u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_901_0 = (num * 3100239295u ^ 2263719723u);
						continue;
					}
					case 16u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 1745531438u ^ 4205023082u);
						continue;
					}
					case 17u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 1362508336u ^ 3593666036u);
						continue;
					}
					case 18u:
					{
						WorldClass2 session2;
						Manager.WorldMgr.AddSession2(0uL, ref session2);
						arg_901_0 = (num * 2049441101u ^ 2006304175u);
						continue;
					}
					case 19u:
					{
						WorldClass2 session2;
						session.Character.MaskSize = session2.Character.DataLength / 32;
						session.Character.Mask = CharacterHandler.smethod_14(session2.Character.DataLength, false);
						arg_901_0 = 697404918u;
						continue;
					}
					case 20u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(true);
						arg_901_0 = (num * 1206507022u ^ 205999934u);
						continue;
					}
					case 21u:
					{
						WorldClass2 session2 = Manager.WorldMgr.GetSession2(CharacterHandler.lastSession);
						arg_901_0 = 1974258356u;
						continue;
					}
					case 22u:
						arg_901_0 = ((session.Character.InRangeObjects == null) ? 1051004094u : 1266603656u);
						continue;
					case 23u:
					{
						SpellHandler.HandleSendKnownSpells(ref session);
						MiscHandler.HandleUpdateActionButtons(ref session);
						ObjectHandler.HandleUpdateObjectCreate(ref session, false);
						MiscHandler.HandleMessageOfTheDay(ref session);
						PacketWriter packetWriter = new PacketWriter(ServerMessage.EnableDJump, true);
						arg_901_0 = (num * 4074190088u ^ 1394568894u);
						continue;
					}
					case 24u:
					{
						WorldClass2 session2;
						session2.Character = session.Character;
						arg_901_0 = (num * 1082901483u ^ 597255709u);
						continue;
					}
					case 25u:
					{
						ulong num2;
						WorldClass2 session2 = Manager.WorldMgr.GetSession2(num2);
						arg_901_0 = (num * 3455854197u ^ 1866927823u);
						continue;
					}
					case 26u:
					{
						int num3;
						session.Character = Manager.WorldMgr.CharaterList[num3];
						arg_901_0 = (num * 4148353782u ^ 1902783245u);
						continue;
					}
					case 27u:
						arg_901_0 = ((session.Character.DataLength == 0) ? 186882811u : 102827312u);
						continue;
					case 28u:
					{
						int num3;
						arg_901_0 = ((num3 >= Manager.WorldMgr.CharaterList.Count) ? 1293088559u : 1473609242u);
						continue;
					}
					case 29u:
						session = session3;
						arg_901_0 = (num * 2206934813u ^ 4284536329u);
						continue;
					case 30u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 1525853337u ^ 3244045523u);
						continue;
					}
					case 31u:
					{
						WorldClass2 session2;
						arg_901_0 = (((session2 == null) ? 3275857864u : 2895121952u) ^ num * 1633499006u);
						continue;
					}
					case 32u:
					{
						packet.Skip(1);
						int num3 = 0;
						arg_901_0 = (num * 212707490u ^ 2573082407u);
						continue;
					}
					case 33u:
					{
						WorldClass2 session2;
						arg_901_0 = ((session2 == null) ? 2017587829u : 938245131u);
						continue;
					}
					case 34u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 204167864u ^ 2594718021u);
						continue;
					}
					case 35u:
					{
						ulong num2 = packet.ReadSmartGuid();
						arg_901_0 = (num * 2052128146u ^ 2233755605u);
						continue;
					}
					case 36u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 276547180u ^ 1183076517u);
						continue;
					}
					case 37u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						packetWriter.WriteInt32(596542156);
						arg_901_0 = (num * 2042259161u ^ 2030303449u);
						continue;
					}
					case 38u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 3908126672u ^ 3761608889u);
						continue;
					}
					case 39u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_901_0 = (num * 3640662639u ^ 2549018999u);
						continue;
					}
					case 40u:
						session.Character.DataLength = 4592;
						arg_901_0 = (num * 4042880795u ^ 170420520u);
						continue;
					case 41u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 3191967602u ^ 1245434114u);
						continue;
					}
					case 42u:
						CharacterHandler.HandleUpdateTalentData(ref session);
						arg_901_0 = (num * 3066887801u ^ 1020889134u);
						continue;
					case 43u:
						return;
					case 44u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 1135176753u ^ 2877534391u);
						continue;
					}
					case 45u:
						new PacketWriter(ServerMessage.QueryNPCTextResponse, true).WriteBytes(Module.smethod_35<string>(2765390876u).ToByteArray(), 0);
						arg_901_0 = (num * 955012231u ^ 3008044948u);
						continue;
					case 46u:
					{
						TutorialHandler.HandleTutorialFlags(ref session);
						Manager.WorldMgr.WriteAccountDataTimes(AccountDataMasks.CharacterCacheMask, ref session, false);
						PacketWriter expr_145 = new PacketWriter(ServerMessage.FeatureSystemStatus, true);
						BitPack bitPack = new BitPack(expr_145, 0uL, 0uL, 0uL, 0uL);
						expr_145.WriteUInt8(0);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt32(300u);
						expr_145.WriteUInt32(0u);
						expr_145.WriteUInt64(0uL);
						arg_901_0 = (num * 877440298u ^ 2665220209u);
						continue;
					}
					case 47u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 3361445611u ^ 3248346210u);
						continue;
					}
					case 48u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 1301617949u ^ 734200671u);
						continue;
					}
					case 49u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(true);
						bitPack.Write<bool>(true);
						arg_901_0 = (num * 2586834557u ^ 2373236671u);
						continue;
					}
					case 50u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 1285613539u ^ 2128412513u);
						continue;
					}
					case 51u:
						TimeHandler.HandleSetTimezoneInformation(ref session);
						arg_901_0 = (num * 1029888462u ^ 22558446u);
						continue;
					case 52u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 4006276023u ^ 1933819661u);
						continue;
					}
					case 53u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 118807035u ^ 3108732667u);
						continue;
					}
					case 54u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_901_0 = (num * 3081863939u ^ 2509441064u);
						continue;
					}
					case 55u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(true);
						arg_901_0 = (num * 2401763381u ^ 5334391u);
						continue;
					}
					}
					goto Block_8;
				}
			}
			Block_8:
			Thread expr_A0A = CharacterHandler.smethod_15(delegate
			{
				CharacterHandler.__c__DisplayClass5_0.smethod_0(60000);
				while (true)
				{
					IL_E6:
					uint arg_BE_0 = 627908470u;
					while (true)
					{
						uint num4;
						switch ((num4 = (arg_BE_0 ^ 1241288239u)) % 7u)
						{
						case 0u:
							goto IL_E6;
						case 1u:
						{
							ChatMessageValues chatMessage = new ChatMessageValues(MessageType.ChatMessageSystem, Module.smethod_35<string>(247267755u), false, false, "");
							ChatHandler.SendMessage(ref session, chatMessage, null);
							arg_BE_0 = (num4 * 3600508056u ^ 2115568771u);
							continue;
						}
						case 2u:
							arg_BE_0 = (CharacterHandler.chatRunning ? 1942895890u : 427430865u);
							continue;
						case 3u:
							arg_BE_0 = (num4 * 2839635370u ^ 794873364u);
							continue;
						case 4u:
						{
							ChatMessageValues chatMessage = new ChatMessageValues(MessageType.ChatMessageRaidWarning, Module.smethod_34<string>(968118675u), false, false, "");
							ChatHandler.SendMessage(ref session, chatMessage, null);
							arg_BE_0 = 1602299179u;
							continue;
						}
						case 6u:
							CharacterHandler.__c__DisplayClass5_0.smethod_0(300000);
							arg_BE_0 = (num4 * 2553612224u ^ 3806675214u);
							continue;
						}
						return;
					}
				}
			});
			CharacterHandler.smethod_16(expr_A0A, true);
			CharacterHandler.smethod_17(expr_A0A);
		}

		public static void SendAchievementData(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.AchievementData, true);
			packetWriter.WriteInt32(0);
			packetWriter.WriteInt32(0);
			session.Send(ref packetWriter);
		}

		public static void SendAchievementData2(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.AchievementEarned, true);
			while (true)
			{
				IL_D5:
				uint arg_B9_0 = 1097642250u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B9_0 ^ 920807091u)) % 4u)
					{
					case 0u:
						goto IL_D5;
					case 1u:
					{
						BitPack arg_9B_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						packetWriter.WriteInt32(347);
						packetWriter.WritePackedTime();
						packetWriter.WriteInt32(1);
						packetWriter.WriteInt32(1);
						arg_9B_0.Write<bool>(false);
						arg_9B_0.Flush();
						arg_B9_0 = (num * 1782001013u ^ 2345619637u);
						continue;
					}
					case 3u:
						session.Send(ref packetWriter);
						arg_B9_0 = (num * 958584268u ^ 580067537u);
						continue;
					}
					return;
				}
			}
		}

		public static void SendAchievementData3(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.AchievementData3, true);
			while (true)
			{
				IL_FB:
				uint arg_E3_0 = 796621983u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E3_0 ^ 729870235u)) % 3u)
					{
					case 1u:
					{
						BitPack arg_BC_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteInt32(1);
						packetWriter.WriteInt32(347);
						packetWriter.WritePackedTime();
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						packetWriter.WriteInt32(1);
						packetWriter.WriteInt32(1);
						packetWriter.WriteInt32(1);
						packetWriter.WriteInt32(347);
						packetWriter.WriteUInt64(1uL);
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						packetWriter.WritePackedTime();
						packetWriter.WriteInt32(1);
						packetWriter.WriteInt32(1);
						arg_BC_0.Write<bool>(false);
						arg_BC_0.Flush();
						session.Send(ref packetWriter);
						arg_E3_0 = (num * 2798950401u ^ 2940619756u);
						continue;
					}
					case 2u:
						goto IL_FB;
					}
					return;
				}
			}
		}

		public static void HandleUpdateTalentData(ref WorldClass session)
		{
			Character arg_07_0 = session.Character;
			while (true)
			{
				IL_149:
				uint arg_114_0 = 2336220948u;
				while (true)
				{
					uint num;
					switch ((num = (arg_114_0 ^ 2694051853u)) % 10u)
					{
					case 1u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.UpdateTalentData, true);
						new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						arg_114_0 = (num * 4091140174u ^ 1393755383u);
						continue;
					}
					case 2u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(0);
						packetWriter.WriteUInt32(577u);
						arg_114_0 = (num * 2576662839u ^ 2303702196u);
						continue;
					}
					case 3u:
					{
						int num2 = 1;
						PacketWriter packetWriter;
						packetWriter.WriteInt32(1);
						arg_114_0 = (num * 1547270570u ^ 3895761691u);
						continue;
					}
					case 4u:
					{
						int num3 = 0;
						arg_114_0 = (num * 2989932553u ^ 3494113025u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_114_0 = (num * 3157688677u ^ 2864369220u);
						continue;
					}
					case 6u:
					{
						int num2;
						int num3;
						arg_114_0 = ((num3 >= num2) ? 2865398006u : 3744571924u);
						continue;
					}
					case 7u:
					{
						int num3;
						num3++;
						arg_114_0 = (num * 1440862752u ^ 4096493061u);
						continue;
					}
					case 8u:
						goto IL_149;
					case 9u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(577u);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt32(0u);
						arg_114_0 = 3226918498u;
						continue;
					}
					}
					return;
				}
			}
		}

		static string smethod_0(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static bool smethod_1(string string_0)
		{
			return File.Exists(string_0);
		}

		static FileStream smethod_2(string string_0)
		{
			return File.Create(string_0);
		}

		static void smethod_3(Stream stream_0)
		{
			stream_0.Dispose();
		}

		static string smethod_4(string string_0)
		{
			return File.ReadAllText(string_0);
		}

		static Encoding smethod_5()
		{
			return Encoding.UTF8;
		}

		static byte[] smethod_6(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static byte smethod_7(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadByte();
		}

		static uint smethod_8(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt32();
		}

		static void smethod_9(string string_0, string string_1)
		{
			File.WriteAllText(string_0, string_1);
		}

		static int smethod_10()
		{
			return Environment.TickCount;
		}

		static Random smethod_11(int int_0)
		{
			return new Random(int_0);
		}

		static int smethod_12(Random random_0, int int_0)
		{
			return random_0.Next(int_0);
		}

		static int smethod_13(string string_0)
		{
			return string_0.Length;
		}

		static BitArray smethod_14(int int_0, bool bool_0)
		{
			return new BitArray(int_0, bool_0);
		}

		static Thread smethod_15(ThreadStart threadStart_0)
		{
			return new Thread(threadStart_0);
		}

		static void smethod_16(Thread thread_0, bool bool_0)
		{
			thread_0.IsBackground = bool_0;
		}

		static void smethod_17(Thread thread_0)
		{
			thread_0.Start();
		}
	}
}
