using AuthServer.Game.Entities;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Misc;
using Framework.Logging;
using Framework.Misc;
using Framework.ObjectDefines;
using Framework.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AuthServer.Game.Managers
{
	public sealed class ObjectManager : Singleton<ObjectManager>
	{
		private Dictionary<ulong, WorldObject> objectList;

		public Dictionary<int, Creature> Creatures;

		public Dictionary<int, GameObject> GameObjects;

		public Dictionary<int, GameObject> GameObjectSpawns;

		private ObjectManager()
		{
			this.objectList = new Dictionary<ulong, WorldObject>();
			this.Creatures = new Dictionary<int, Creature>();
			this.GameObjects = new Dictionary<int, GameObject>();
			this.GameObjectSpawns = new Dictionary<int, GameObject>();
			this.LoadCreatureStats();
			this.LoadGameobjectStats();
		}

		private void LoadGameobjectStats()
		{
			StreamReader streamReader = ObjectManager.smethod_7(ObjectManager.smethod_6(ObjectManager.smethod_5(), Module.smethod_34<string>(3113314240u)));
			try
			{
				while (true)
				{
					IL_578:
					uint arg_4FB_0 = (!ObjectManager.smethod_11(streamReader)) ? 1410011869u : 196725348u;
					while (true)
					{
						uint num;
						switch ((num = (arg_4FB_0 ^ 898338295u)) % 24u)
						{
						case 0u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Rot.O = float.Parse(ObjectManager.smethod_10(array[7], Module.smethod_35<string>(764625391u), ""));
							arg_4FB_0 = (num * 895885331u ^ 1952920246u);
							continue;
						}
						case 1u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Rot.X = float.Parse(ObjectManager.smethod_10(array[4], Module.smethod_35<string>(764625391u), ""));
							gameObject.Rot.Y = float.Parse(ObjectManager.smethod_10(array[5], Module.smethod_36<string>(1708679815u), ""));
							arg_4FB_0 = (num * 1576813854u ^ 2551339022u);
							continue;
						}
						case 2u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Pos.Z = float.Parse(ObjectManager.smethod_10(array[3], Module.smethod_36<string>(1708679815u), ""));
							arg_4FB_0 = (num * 675112681u ^ 2788424843u);
							continue;
						}
						case 4u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Id = int.Parse(ObjectManager.smethod_10(array[0], Module.smethod_37<string>(3974021651u), ""));
							arg_4FB_0 = (num * 4261590861u ^ 4262697089u);
							continue;
						}
						case 5u:
							arg_4FB_0 = 1410011869u;
							continue;
						case 6u:
						{
							GameObject gameObject;
							gameObject.Size = 1f;
							gameObject.ExpansionRequired = 0;
							arg_4FB_0 = (((gameObject.Pos.X != 0f) ? 1568691151u : 766348954u) ^ num * 1725030754u);
							continue;
						}
						case 7u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Data[2] = int.Parse(ObjectManager.smethod_10(array[22], Module.smethod_36<string>(1708679815u), ""));
							arg_4FB_0 = (num * 2424818602u ^ 1740370703u);
							continue;
						}
						case 8u:
							arg_4FB_0 = (num * 2109999096u ^ 1669666073u);
							continue;
						case 9u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Type = int.Parse(ObjectManager.smethod_10(array[23], Module.smethod_35<string>(764625391u), ""));
							gameObject.Flags = 0;
							arg_4FB_0 = (num * 2072144266u ^ 3328121305u);
							continue;
						}
						case 10u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Name = ObjectManager.smethod_10(array[17], Module.smethod_35<string>(764625391u), "");
							arg_4FB_0 = (num * 1007957585u ^ 1680924238u);
							continue;
						}
						case 11u:
						{
							GameObject gameObject;
							gameObject.CastBarCaption = "";
							arg_4FB_0 = (num * 1393127583u ^ 1847872546u);
							continue;
						}
						case 12u:
						{
							GameObject gameObject;
							this.GameObjectSpawns.Add(gameObject.Id, gameObject);
							arg_4FB_0 = (num * 324219867u ^ 141241546u);
							continue;
						}
						case 13u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Data[0] = int.Parse(ObjectManager.smethod_10(array[20], Module.smethod_35<string>(764625391u), ""));
							gameObject.Data[1] = int.Parse(ObjectManager.smethod_10(array[21], Module.smethod_35<string>(764625391u), ""));
							arg_4FB_0 = (num * 1359554154u ^ 2341914706u);
							continue;
						}
						case 14u:
						{
							GameObject gameObject;
							int num2;
							arg_4FB_0 = ((num2 < gameObject.Data.Capacity) ? 1375737346u : 32195042u);
							continue;
						}
						case 15u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Rot.Z = float.Parse(ObjectManager.smethod_10(array[6], Module.smethod_36<string>(1708679815u), ""));
							arg_4FB_0 = (num * 2261474200u ^ 197803303u);
							continue;
						}
						case 16u:
						{
							int num2 = 0;
							arg_4FB_0 = (num * 2548405617u ^ 3881400663u);
							continue;
						}
						case 17u:
							goto IL_578;
						case 18u:
						{
							string[] array = ObjectManager.smethod_9(ObjectManager.smethod_8(streamReader), new char[]
							{
								';'
							});
							GameObject gameObject = new GameObject();
							arg_4FB_0 = 99861715u;
							continue;
						}
						case 19u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Map = int.Parse(ObjectManager.smethod_10(array[18], Module.smethod_33<string>(3031927268u), ""));
							gameObject.Pos.X = float.Parse(ObjectManager.smethod_10(array[1], Module.smethod_35<string>(764625391u), ""));
							arg_4FB_0 = (num * 3854447194u ^ 1843160590u);
							continue;
						}
						case 20u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.DisplayInfoId = int.Parse(ObjectManager.smethod_10(array[19], Module.smethod_37<string>(3974021651u), ""));
							gameObject.IconName = "";
							arg_4FB_0 = (num * 1078527560u ^ 3062867076u);
							continue;
						}
						case 21u:
						{
							GameObject gameObject;
							gameObject.Data.Add(0);
							int num2;
							num2++;
							arg_4FB_0 = 1052732761u;
							continue;
						}
						case 22u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Pos.O = float.Parse(ObjectManager.smethod_10(array[8], Module.smethod_37<string>(3974021651u), ""));
							arg_4FB_0 = (num * 3549561052u ^ 1511440678u);
							continue;
						}
						case 23u:
						{
							GameObject gameObject;
							string[] array;
							gameObject.Pos.Y = float.Parse(ObjectManager.smethod_10(array[2], Module.smethod_37<string>(3974021651u), ""));
							arg_4FB_0 = (num * 3929716262u ^ 2241756295u);
							continue;
						}
						}
						goto Block_6;
					}
				}
				Block_6:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_5BE:
						uint arg_5A5_0 = 1984994331u;
						while (true)
						{
							uint num;
							switch ((num = (arg_5A5_0 ^ 898338295u)) % 3u)
							{
							case 0u:
								goto IL_5BE;
							case 2u:
								ObjectManager.smethod_12(streamReader);
								arg_5A5_0 = (num * 2509285686u ^ 1928312965u);
								continue;
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
			}
			Log.Message(LogType.Debug, Module.smethod_35<string>(2457428245u), new object[]
			{
				this.GameObjectSpawns.Count
			});
			StreamReader streamReader2 = ObjectManager.smethod_7(ObjectManager.smethod_6(ObjectManager.smethod_5(), Module.smethod_37<string>(1782713009u)));
			try
			{
				while (true)
				{
					IL_942:
					uint arg_8E9_0 = ObjectManager.smethod_11(streamReader2) ? 1932786469u : 1436813079u;
					while (true)
					{
						uint num;
						switch ((num = (arg_8E9_0 ^ 898338295u)) % 15u)
						{
						case 0u:
							arg_8E9_0 = 1436813079u;
							continue;
						case 1u:
						{
							GameObject gameObject2;
							gameObject2.Flags = 0;
							arg_8E9_0 = (num * 2594108462u ^ 1925334862u);
							continue;
						}
						case 2u:
							arg_8E9_0 = (num * 3504691912u ^ 329545337u);
							continue;
						case 3u:
						{
							GameObject gameObject2;
							string[] array2;
							gameObject2.ExpansionRequired = int.Parse(ObjectManager.smethod_10(array2[8 + gameObject2.Data.Capacity], Module.smethod_33<string>(3031927268u), ""));
							arg_8E9_0 = (num * 1459362805u ^ 4010932252u);
							continue;
						}
						case 4u:
						{
							GameObject gameObject2;
							string[] array2;
							gameObject2.CastBarCaption = ObjectManager.smethod_10(array2[5], Module.smethod_37<string>(3974021651u), "");
							arg_8E9_0 = (num * 3840120136u ^ 1217508012u);
							continue;
						}
						case 5u:
						{
							GameObject gameObject2;
							int num3;
							arg_8E9_0 = ((num3 >= gameObject2.Data.Capacity) ? 37102694u : 11895287u);
							continue;
						}
						case 6u:
						{
							int num3;
							num3++;
							arg_8E9_0 = (num * 161028676u ^ 4248176169u);
							continue;
						}
						case 7u:
						{
							GameObject gameObject2;
							string[] array2;
							int num3;
							gameObject2.Data.Add(int.Parse(ObjectManager.smethod_10(array2[8 + num3], Module.smethod_34<string>(1801001672u), "")));
							arg_8E9_0 = 1726923679u;
							continue;
						}
						case 8u:
						{
							GameObject gameObject2;
							string[] array2;
							gameObject2.DisplayInfoId = int.Parse(ObjectManager.smethod_10(array2[2], Module.smethod_37<string>(3974021651u), ""));
							gameObject2.Name = ObjectManager.smethod_13(ObjectManager.smethod_10(array2[3], Module.smethod_33<string>(3031927268u), ""), Array.Empty<char>());
							gameObject2.IconName = ObjectManager.smethod_10(array2[4], Module.smethod_35<string>(764625391u), "");
							arg_8E9_0 = (num * 1458478346u ^ 2751135251u);
							continue;
						}
						case 9u:
						{
							int num3 = 0;
							arg_8E9_0 = (num * 2525264134u ^ 757837691u);
							continue;
						}
						case 10u:
						{
							string[] array2 = ObjectManager.smethod_9(ObjectManager.smethod_8(streamReader2), new char[]
							{
								';'
							});
							GameObject gameObject2 = new GameObject();
							gameObject2.Id = int.Parse(ObjectManager.smethod_10(array2[0], Module.smethod_35<string>(764625391u), ""));
							gameObject2.Type = int.Parse(ObjectManager.smethod_10(array2[1], Module.smethod_34<string>(1801001672u), ""));
							arg_8E9_0 = 2074676599u;
							continue;
						}
						case 11u:
							goto IL_942;
						case 13u:
						{
							GameObject gameObject2;
							string[] array2;
							gameObject2.Unk = ObjectManager.smethod_10(array2[6], Module.smethod_33<string>(3031927268u), "");
							gameObject2.Size = float.Parse(ObjectManager.smethod_10(array2[7], Module.smethod_33<string>(3031927268u), ""));
							arg_8E9_0 = (num * 802583443u ^ 1696953485u);
							continue;
						}
						case 14u:
						{
							GameObject gameObject2;
							this.GameObjects.Add(gameObject2.Id, gameObject2);
							arg_8E9_0 = (num * 209810929u ^ 601569456u);
							continue;
						}
						}
						goto Block_13;
					}
				}
				Block_13:;
			}
			finally
			{
				if (streamReader2 != null)
				{
					while (true)
					{
						IL_98B:
						uint arg_972_0 = 635919884u;
						while (true)
						{
							uint num;
							switch ((num = (arg_972_0 ^ 898338295u)) % 3u)
							{
							case 1u:
								ObjectManager.smethod_12(streamReader2);
								arg_972_0 = (num * 1668626149u ^ 3201008350u);
								continue;
							case 2u:
								goto IL_98B;
							}
							goto Block_17;
						}
					}
					Block_17:;
				}
			}
			Log.Message(LogType.Debug, Module.smethod_34<string>(3179387485u), new object[]
			{
				this.GameObjects.Count
			});
		}

		private void LoadCreatureStats()
		{
			StreamReader streamReader = ObjectManager.smethod_7(ObjectManager.smethod_6(ObjectManager.smethod_5(), Module.smethod_33<string>(1670519287u)));
			try
			{
				while (true)
				{
					IL_46F:
					uint arg_3FE_0 = (!ObjectManager.smethod_11(streamReader)) ? 891516526u : 357099618u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3FE_0 ^ 962500516u)) % 21u)
						{
						case 0u:
						{
							Creature creature;
							arg_3FE_0 = ((this.Creatures.ContainsKey(creature.Id) ? 3128584920u : 4227032504u) ^ num * 2908312957u);
							continue;
						}
						case 1u:
						{
							int num2;
							num2++;
							arg_3FE_0 = (num * 3760297338u ^ 761304653u);
							continue;
						}
						case 2u:
						{
							Creature creature;
							int num2;
							arg_3FE_0 = ((num2 >= creature.DisplayInfoId.Capacity) ? 1826714675u : 962217110u);
							continue;
						}
						case 3u:
						{
							Creature creature;
							int num3;
							arg_3FE_0 = ((num3 >= creature.Flag.Capacity) ? 178621674u : 1082107858u);
							continue;
						}
						case 4u:
						{
							Creature creature;
							this.Creatures.Add(creature.Id, creature);
							arg_3FE_0 = (num * 3320803128u ^ 971468011u);
							continue;
						}
						case 5u:
						{
							Creature creature;
							string[] array;
							creature.Type = int.Parse(ObjectManager.smethod_10(array[11], Module.smethod_37<string>(3974021651u), ""));
							arg_3FE_0 = (num * 322104996u ^ 1287243419u);
							continue;
						}
						case 6u:
						{
							string[] array = ObjectManager.smethod_9(ObjectManager.smethod_8(streamReader), new char[]
							{
								';'
							});
							Creature creature = new Creature();
							creature.Id = int.Parse(ObjectManager.smethod_10(array[0], Module.smethod_33<string>(3031927268u), ""));
							arg_3FE_0 = 495850200u;
							continue;
						}
						case 7u:
						{
							Creature creature;
							string[] array;
							creature.PowerModifier = float.Parse(ObjectManager.smethod_10(array[21], Module.smethod_33<string>(3031927268u), ""));
							creature.RacialLeader = 0;
							arg_3FE_0 = (num * 3101138571u ^ 1476083757u);
							continue;
						}
						case 8u:
						{
							Creature creature;
							string[] array;
							creature.ExpansionRequired = int.Parse(ObjectManager.smethod_10(array[24], Module.smethod_35<string>(764625391u), ""));
							int num3 = 0;
							arg_3FE_0 = (num * 1465096509u ^ 1517737139u);
							continue;
						}
						case 9u:
						{
							Creature creature;
							string[] array;
							creature.Name = ObjectManager.smethod_10(array[1], Module.smethod_35<string>(764625391u), "");
							arg_3FE_0 = (num * 2108520970u ^ 2443991076u);
							continue;
						}
						case 11u:
						{
							int num2 = 0;
							arg_3FE_0 = (num * 713364425u ^ 63404157u);
							continue;
						}
						case 12u:
						{
							Creature creature;
							string[] array;
							creature.HealthModifier = float.Parse(ObjectManager.smethod_10(array[20], Module.smethod_36<string>(1708679815u), ""));
							arg_3FE_0 = (num * 3886034994u ^ 240629416u);
							continue;
						}
						case 13u:
						{
							Creature creature;
							int num2;
							string[] array;
							creature.DisplayInfoId.Add(int.Parse(ObjectManager.smethod_10(array[16 + num2], Module.smethod_35<string>(764625391u), "")));
							arg_3FE_0 = 781590967u;
							continue;
						}
						case 14u:
						{
							Creature creature;
							int num3;
							string[] array;
							creature.Flag.Add(uint.Parse(ObjectManager.smethod_10(array[9 + num3], Module.smethod_37<string>(3974021651u), "")));
							num3++;
							arg_3FE_0 = 339349203u;
							continue;
						}
						case 15u:
						{
							Creature creature;
							string[] array;
							creature.Family = int.Parse(ObjectManager.smethod_10(array[12], Module.smethod_37<string>(3974021651u), ""));
							arg_3FE_0 = (num * 3084234110u ^ 2956493402u);
							continue;
						}
						case 16u:
							goto IL_46F;
						case 17u:
							arg_3FE_0 = 891516526u;
							continue;
						case 18u:
						{
							Creature creature;
							string[] array;
							creature.MovementInfoId = int.Parse(ObjectManager.smethod_10(array[23], Module.smethod_33<string>(3031927268u), ""));
							arg_3FE_0 = (num * 3054748301u ^ 309845739u);
							continue;
						}
						case 19u:
						{
							Creature creature;
							string[] array;
							creature.SubName = ObjectManager.smethod_10(array[27], Module.smethod_36<string>(1708679815u), "");
							creature.IconName = ObjectManager.smethod_10(array[29], Module.smethod_36<string>(1708679815u), "");
							arg_3FE_0 = (num * 652892886u ^ 1126547174u);
							continue;
						}
						case 20u:
						{
							Creature creature;
							string[] array;
							creature.Rank = int.Parse(ObjectManager.smethod_10(array[13], Module.smethod_34<string>(1801001672u), ""));
							arg_3FE_0 = (num * 3944529478u ^ 4069980401u);
							continue;
						}
						}
						goto Block_6;
					}
				}
				Block_6:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_4B5:
						uint arg_49C_0 = 1353314390u;
						while (true)
						{
							uint num;
							switch ((num = (arg_49C_0 ^ 962500516u)) % 3u)
							{
							case 1u:
								ObjectManager.smethod_12(streamReader);
								arg_49C_0 = (num * 3941676610u ^ 3949420580u);
								continue;
							case 2u:
								goto IL_4B5;
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
			}
			Log.Message(LogType.Debug, Module.smethod_33<string>(142857120u), new object[]
			{
				this.Creatures.Count
			});
		}

		public WorldObject FindObject(ulong guid)
		{
			using (Dictionary<ulong, WorldObject>.Enumerator enumerator = this.objectList.GetEnumerator())
			{
				WorldObject value;
				while (true)
				{
					IL_9B:
					uint arg_6B_0 = (!enumerator.MoveNext()) ? 2960130776u : 3644716465u;
					while (true)
					{
						uint num;
						switch ((num = (arg_6B_0 ^ 4131174034u)) % 6u)
						{
						case 0u:
							arg_6B_0 = 3644716465u;
							continue;
						case 1u:
							goto IL_A9;
						case 2u:
							goto IL_9B;
						case 3u:
						{
							KeyValuePair<ulong, WorldObject> current = enumerator.Current;
							arg_6B_0 = ((current.Key != guid) ? 3522449388u : 2492948935u);
							continue;
						}
						case 5u:
						{
							KeyValuePair<ulong, WorldObject> current;
							value = current.Value;
							arg_6B_0 = (num * 240380306u ^ 4243008403u);
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:
				goto IL_AB;
				IL_A9:
				return value;
				IL_AB:;
			}
			return null;
		}

		public void SetPosition(ref Character pChar, Vector4 vector, bool dbUpdate = true)
		{
			pChar.Position = vector;
			while (true)
			{
				IL_5B:
				uint arg_43_0 = 3964324102u;
				while (true)
				{
					uint num;
					switch ((num = (arg_43_0 ^ 2893124303u)) % 3u)
					{
					case 1u:
						Manager.WorldMgr.Sessions2[0uL].Character = pChar;
						this.SavePositionToDB(pChar);
						arg_43_0 = (num * 596668322u ^ 2830923776u);
						continue;
					case 2u:
						goto IL_5B;
					}
					return;
				}
			}
		}

		public void SetMap(ref Character pChar, uint mapId, bool dbUpdate = true)
		{
			pChar.Map = mapId;
			Manager.WorldMgr.Sessions2[0uL].Character = pChar;
			this.SavePositionToDB(pChar);
		}

		public void SetZone(ref Character pChar, uint zoneId, bool dbUpdate = true)
		{
			pChar.Zone = zoneId;
			Manager.WorldMgr.Sessions2[0uL].Character = pChar;
			this.SaveZoneToDB(pChar);
		}

		public void SaveChar(Character pChar)
		{
			int num = 0;
			while (true)
			{
				IL_11D:
				uint arg_EC_0 = 726814213u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_EC_0 ^ 1466069075u)) % 9u)
					{
					case 0u:
						arg_EC_0 = ((num >= Manager.WorldMgr.CharaterList.Count) ? 449547290u : 1272737857u);
						continue;
					case 1u:
						ObjectManager.smethod_15(ObjectManager.smethod_14(Helper.DataDirectory(), Module.smethod_33<string>(1012059880u)), Json.CreateString<List<Character>>(Manager.WorldMgr.CharaterList));
						arg_EC_0 = 261035639u;
						continue;
					case 2u:
						arg_EC_0 = (num2 * 2731361459u ^ 4159068288u);
						continue;
					case 3u:
						Manager.WorldMgr.CharaterList[num] = pChar;
						arg_EC_0 = (num2 * 1479547532u ^ 1044054354u);
						continue;
					case 5u:
						num++;
						arg_EC_0 = 181286562u;
						continue;
					case 6u:
						goto IL_11D;
					case 7u:
						arg_EC_0 = (num2 * 1115401797u ^ 332474851u);
						continue;
					case 8u:
						arg_EC_0 = ((Manager.WorldMgr.CharaterList[num].Guid == pChar.Guid) ? 1009204976u : 202502060u);
						continue;
					}
					return;
				}
			}
		}

		public void SavePositionToDB(Character pChar)
		{
			int num = 0;
			while (true)
			{
				IL_F0:
				uint arg_C4_0 = 4203615896u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C4_0 ^ 4171363183u)) % 8u)
					{
					case 0u:
						Manager.WorldMgr.CharaterList[num].Position = pChar.Position;
						arg_C4_0 = (num2 * 1671861827u ^ 3331856394u);
						continue;
					case 1u:
						arg_C4_0 = ((Manager.WorldMgr.CharaterList[num].Guid != pChar.Guid) ? 4002925572u : 3969543359u);
						continue;
					case 3u:
						num++;
						arg_C4_0 = 2804824219u;
						continue;
					case 4u:
						arg_C4_0 = ((num >= Manager.WorldMgr.CharaterList.Count) ? 2428345285u : 2871598926u);
						continue;
					case 5u:
						arg_C4_0 = (num2 * 3807632820u ^ 4028535809u);
						continue;
					case 6u:
						goto IL_F0;
					case 7u:
						arg_C4_0 = (num2 * 40449732u ^ 2689799047u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			ObjectManager.smethod_15(ObjectManager.smethod_14(Helper.DataDirectory(), Module.smethod_36<string>(2576790355u)), Json.CreateString<List<Character>>(Manager.WorldMgr.CharaterList));
		}

		public void SaveZoneToDB(Character pChar)
		{
			ObjectManager.smethod_15(ObjectManager.smethod_14(Helper.DataDirectory(), Module.smethod_35<string>(205105435u)), Json.CreateString<List<Character>>(Manager.WorldMgr.CharaterList));
		}

		static Assembly smethod_5()
		{
			return Assembly.GetExecutingAssembly();
		}

		static Stream smethod_6(Assembly assembly_0, string string_0)
		{
			return assembly_0.GetManifestResourceStream(string_0);
		}

		static StreamReader smethod_7(Stream stream_0)
		{
			return new StreamReader(stream_0);
		}

		static string smethod_8(TextReader textReader_0)
		{
			return textReader_0.ReadLine();
		}

		static string[] smethod_9(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		static string smethod_10(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static bool smethod_11(StreamReader streamReader_0)
		{
			return streamReader_0.EndOfStream;
		}

		static void smethod_12(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static string smethod_13(string string_0, char[] char_0)
		{
			return string_0.TrimStart(char_0);
		}

		static string smethod_14(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static void smethod_15(string string_0, string string_1)
		{
			File.WriteAllText(string_0, string_1);
		}
	}
}
