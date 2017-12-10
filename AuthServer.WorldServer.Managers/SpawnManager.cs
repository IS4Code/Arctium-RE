using AuthServer.WorldServer.Game.Entities;
using Framework.Constants.Misc;
using Framework.Logging;
using Framework.Misc;
using Framework.ObjectDefines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AuthServer.WorldServer.Managers
{
	public sealed class SpawnManager : Singleton<SpawnManager>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SpawnManager.__c __9 = new SpawnManager.__c();

			public static Func<Waypoint, int> __9__12_0;

			internal int <GetLastWPIndex>b__12_0(Waypoint wp)
			{
				return wp.Index;
			}
		}

		public Dictionary<ulong, CreatureSpawn> CreatureSpawns;

		public Dictionary<ulong, CreatureSpawn> CreatureSpawnsFile;

		public Dictionary<ulong, GameObjectSpawn> GameObjectSpawns;

		public Dictionary<ulong, CreatureSpawn> preMadeSpawns;

		public Dictionary<ulong, GameObjectSpawn> preMadeSpawns2;

		private Dictionary<ulong, List<Waypoint>> waypoints;

		public void ClearSpawns()
		{
		}

		private SpawnManager()
		{
			while (true)
			{
				IL_14F:
				uint arg_11E_0 = 3419753491u;
				while (true)
				{
					uint num;
					switch ((num = (arg_11E_0 ^ 4166347725u)) % 9u)
					{
					case 0u:
						arg_11E_0 = ((!SpawnManager.smethod_5(Module.smethod_34<string>(3998541984u))) ? 3080705907u : 3847066629u);
						continue;
					case 1u:
						this.Initialize();
						arg_11E_0 = 3251319907u;
						continue;
					case 2u:
						this.waypoints = new Dictionary<ulong, List<Waypoint>>();
						arg_11E_0 = ((SpawnManager.smethod_5(Module.smethod_37<string>(3944903225u)) ? 2575663796u : 2790913321u) ^ num * 2659903749u);
						continue;
					case 3u:
						goto IL_14F;
					case 4u:
						arg_11E_0 = ((!SpawnManager.smethod_5(Module.smethod_33<string>(921669354u))) ? 3145729640u : 3026661308u);
						continue;
					case 5u:
						SpawnManager.smethod_7(SpawnManager.smethod_6(Module.smethod_33<string>(1138970044u)));
						arg_11E_0 = (num * 1677415986u ^ 3691455769u);
						continue;
					case 6u:
						SpawnManager.smethod_7(SpawnManager.smethod_6(Module.smethod_35<string>(2234073573u)));
						arg_11E_0 = (num * 480825781u ^ 2964226360u);
						continue;
					case 8u:
						SpawnManager.smethod_7(SpawnManager.smethod_6(Module.smethod_37<string>(2484030797u)));
						arg_11E_0 = (num * 3921531482u ^ 3098397118u);
						continue;
					}
					return;
				}
			}
		}

		public void Initialize()
		{
			this.LoadCreatureWaypoints();
			while (true)
			{
				IL_38:
				uint arg_20_0 = 1917998263u;
				while (true)
				{
					uint num;
					switch ((num = (arg_20_0 ^ 986731147u)) % 3u)
					{
					case 1u:
						this.LoadCreatureSpawns();
						arg_20_0 = (num * 316896139u ^ 2267655666u);
						continue;
					case 2u:
						goto IL_38;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.LoadGameobjectSpawns();
		}

		public void UpdateSpawnEmote(ulong guid, int emote)
		{
			this.CreatureSpawns[guid].Emote = emote;
			StringBuilder stringBuilder;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 1512577389u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4D_0 ^ 18032223u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 2u:
						this.CreatureSpawnsFile[guid].Emote = emote;
						arg_4D_0 = (num * 64973333u ^ 2431847214u);
						continue;
					case 3u:
						stringBuilder = SpawnManager.smethod_8();
						arg_4D_0 = (num * 3620092624u ^ 847020610u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			using (Dictionary<ulong, CreatureSpawn>.Enumerator enumerator = this.CreatureSpawnsFile.GetEnumerator())
			{
				while (true)
				{
					IL_1AB:
					uint arg_17C_0 = enumerator.MoveNext() ? 1933591873u : 470851310u;
					while (true)
					{
						uint num;
						switch ((num = (arg_17C_0 ^ 18032223u)) % 5u)
						{
						case 0u:
						{
							KeyValuePair<ulong, CreatureSpawn> current;
							SpawnManager.smethod_10(stringBuilder, SpawnManager.smethod_9(Module.smethod_33<string>(45909257u), new object[]
							{
								current.Value.Id,
								current.Value.Map,
								current.Value.Position.X,
								current.Value.Position.Y,
								current.Value.Position.Z,
								current.Value.Position.O,
								current.Value.Emote
							}));
							arg_17C_0 = (num * 800012124u ^ 2150310667u);
							continue;
						}
						case 1u:
						{
							KeyValuePair<ulong, CreatureSpawn> current = enumerator.Current;
							arg_17C_0 = 2078491004u;
							continue;
						}
						case 2u:
							arg_17C_0 = 1933591873u;
							continue;
						case 4u:
							goto IL_1AB;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			SpawnManager.smethod_12(Module.smethod_34<string>(3998541984u), SpawnManager.smethod_11(stringBuilder));
		}

		public void AddSpawn(CreatureSpawn spawn)
		{
			this.CreatureSpawns.Add(spawn.Guid, spawn);
			this.CreatureSpawnsFile.Add(spawn.Guid, spawn);
			while (true)
			{
				IL_ED:
				uint arg_D5_0 = 3922490915u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D5_0 ^ 3761259110u)) % 3u)
					{
					case 1u:
						SpawnManager.smethod_13(Module.smethod_36<string>(307414319u), SpawnManager.smethod_9(Module.smethod_37<string>(2922251266u), new object[]
						{
							spawn.Id,
							spawn.Map,
							spawn.Position.X,
							spawn.Position.Y,
							spawn.Position.Z,
							spawn.Position.O,
							spawn.Emote
						}));
						arg_D5_0 = (num * 1825042784u ^ 1305675415u);
						continue;
					case 2u:
						goto IL_ED;
					}
					return;
				}
			}
		}

		public void AddWayPoint(Waypoint waypoint)
		{
			if (!this.waypoints.ContainsKey(waypoint.CreatureGuid))
			{
				goto IL_DB;
			}
			goto IL_12A;
			uint arg_10A_0;
			while (true)
			{
				IL_105:
				uint num;
				switch ((num = (arg_10A_0 ^ 2809646139u)) % 5u)
				{
				case 1u:
					goto IL_12A;
				case 2u:
					this.waypoints.Add(waypoint.CreatureGuid, new List<Waypoint>());
					arg_10A_0 = (num * 408980959u ^ 1259594681u);
					continue;
				case 3u:
					goto IL_DB;
				case 4u:
					this.waypoints[waypoint.CreatureGuid].Add(waypoint);
					SpawnManager.smethod_13(Module.smethod_33<string>(487067974u), SpawnManager.smethod_9(Module.smethod_34<string>(3783405393u), new object[]
					{
						waypoint.CreatureGuid,
						waypoint.Point.X,
						waypoint.Point.Y,
						waypoint.Point.Z,
						waypoint.Point.O,
						waypoint.Index,
						waypoint.WaitTime
					}));
					arg_10A_0 = (num * 914029717u ^ 2473375718u);
					continue;
				}
				break;
			}
			return;
			IL_DB:
			arg_10A_0 = 3680989355u;
			goto IL_105;
			IL_12A:
			waypoint.Index = this.GetLastWPIndex(waypoint.CreatureGuid);
			arg_10A_0 = 3213433008u;
			goto IL_105;
		}

		public int GetLastWPIndex(ulong guid)
		{
			IEnumerable<Waypoint> arg_2B_0 = this.waypoints[guid];
			Func<Waypoint, int> arg_2B_1;
			if ((arg_2B_1 = SpawnManager.__c.__9__12_0) == null)
			{
				arg_2B_1 = (SpawnManager.__c.__9__12_0 = new Func<Waypoint, int>(SpawnManager.__c.__9.<GetLastWPIndex>b__12_0));
			}
			return arg_2B_0.OrderBy(arg_2B_1).ToArray<Waypoint>()[this.waypoints[guid].Count - 1].Index;
		}

		public void AddSpawn(GameObjectSpawn spawn)
		{
			this.GameObjectSpawns.Add(spawn.Guid, spawn);
			SpawnManager.smethod_13(Module.smethod_36<string>(648926041u), SpawnManager.smethod_14(SpawnManager.smethod_9(Module.smethod_33<string>(3088118917u), new object[]
			{
				spawn.Id,
				spawn.Map,
				spawn.Position.X,
				spawn.Position.Y,
				spawn.Position.Z,
				spawn.Position.O
			}), SpawnManager.smethod_9(Module.smethod_34<string>(4036951862u), new object[]
			{
				spawn.GameObject.Rot.X,
				spawn.GameObject.Rot.Y,
				spawn.GameObject.Rot.Z,
				spawn.GameObject.Rot.O,
				spawn.AnimProgress,
				spawn.State
			})));
		}

		public void RemoveWaypoint(Waypoint wayPoint)
		{
			Waypoint wayPoint;
			StringBuilder stringBuilder;
			while (true)
			{
				IL_16F:
				uint arg_13D_0 = 1252686121u;
				while (true)
				{
					uint num;
					switch ((num = (arg_13D_0 ^ 10291043u)) % 9u)
					{
					case 0u:
						goto IL_16F;
					case 1u:
					{
						int num2;
						num2++;
						arg_13D_0 = 1333700840u;
						continue;
					}
					case 2u:
						wayPoint = wayPoint2;
						arg_13D_0 = (num * 1469421495u ^ 1154545119u);
						continue;
					case 3u:
					{
						int num2 = 0;
						arg_13D_0 = (num * 4202381741u ^ 1823053787u);
						continue;
					}
					case 4u:
					{
						int num2;
						this.waypoints[wayPoint.CreatureGuid][num2].Index--;
						arg_13D_0 = (num * 957938104u ^ 1119971496u);
						continue;
					}
					case 5u:
					{
						int num2;
						arg_13D_0 = ((num2 >= this.waypoints[wayPoint.CreatureGuid].Count) ? 1977392277u : 158463845u);
						continue;
					}
					case 6u:
						stringBuilder = SpawnManager.smethod_8();
						this.waypoints[wayPoint.CreatureGuid].RemoveAll((Waypoint r) => r.Index == wayPoint.Index);
						arg_13D_0 = (num * 894924530u ^ 1305365032u);
						continue;
					case 8u:
					{
						int num2;
						arg_13D_0 = ((this.waypoints[wayPoint.CreatureGuid][num2].Index > wayPoint.Index) ? 1981754272u : 715177856u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			foreach (KeyValuePair<ulong, List<Waypoint>> current in this.waypoints)
			{
				using (List<Waypoint>.Enumerator enumerator2 = current.Value.GetEnumerator())
				{
					while (true)
					{
						IL_297:
						int arg_26B_0 = (!enumerator2.MoveNext()) ? 1596937901 : 26561718;
						while (true)
						{
							switch ((arg_26B_0 ^ 10291043) % 4)
							{
							case 0:
								goto IL_297;
							case 1:
							{
								Waypoint current2 = enumerator2.Current;
								SpawnManager.smethod_10(stringBuilder, SpawnManager.smethod_9(Module.smethod_35<string>(3759077104u), new object[]
								{
									current2.CreatureGuid,
									current2.Point.X,
									current2.Point.Y,
									current2.Point.Z,
									current2.Point.O,
									current2.Index,
									current2.WaitTime
								}));
								arg_26B_0 = 241486627;
								continue;
							}
							case 3:
								arg_26B_0 = 26561718;
								continue;
							}
							goto Block_9;
						}
					}
					Block_9:;
				}
			}
			SpawnManager.smethod_12(Module.smethod_36<string>(1331949485u), SpawnManager.smethod_11(stringBuilder));
		}

		public void RemoveSpawn(CreatureSpawn spawn, bool delete)
		{
			if (delete)
			{
				StringBuilder stringBuilder;
				while (true)
				{
					IL_5C:
					uint arg_44_0 = 102419110u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 1668610261u)) % 3u)
						{
						case 0u:
							goto IL_5C;
						case 1u:
							this.CreatureSpawnsFile.Remove(spawn.Guid);
							this.CreatureSpawns.Remove(spawn.Guid);
							stringBuilder = SpawnManager.smethod_8();
							arg_44_0 = (num * 2432127833u ^ 1076985941u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:
				using (Dictionary<ulong, CreatureSpawn>.Enumerator enumerator = this.CreatureSpawnsFile.GetEnumerator())
				{
					while (true)
					{
						IL_185:
						int arg_15A_0 = enumerator.MoveNext() ? 1991770314 : 1945756631;
						while (true)
						{
							switch ((arg_15A_0 ^ 1668610261) % 4)
							{
							case 0:
								arg_15A_0 = 1991770314;
								continue;
							case 1:
								goto IL_185;
							case 3:
							{
								KeyValuePair<ulong, CreatureSpawn> current = enumerator.Current;
								SpawnManager.smethod_10(stringBuilder, SpawnManager.smethod_9(Module.smethod_34<string>(1495316827u), new object[]
								{
									current.Value.Id,
									current.Value.Map,
									current.Value.Position.X,
									current.Value.Position.Y,
									current.Value.Position.Z,
									current.Value.Position.O,
									current.Value.Emote
								}));
								arg_15A_0 = 835919088;
								continue;
							}
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
				SpawnManager.smethod_12(Module.smethod_33<string>(1138970044u), SpawnManager.smethod_11(stringBuilder));
			}
		}

		public void RemoveSpawn(GameObjectSpawn spawn)
		{
			this.GameObjectSpawns.Remove(spawn.Guid);
			StringBuilder stringBuilder;
			while (true)
			{
				IL_44:
				uint arg_2C_0 = 4012003314u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2C_0 ^ 2695777957u)) % 3u)
					{
					case 0u:
						goto IL_44;
					case 1u:
						stringBuilder = SpawnManager.smethod_8();
						arg_2C_0 = (num * 2867795827u ^ 3662844227u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			using (Dictionary<ulong, GameObjectSpawn>.Enumerator enumerator = this.GameObjectSpawns.GetEnumerator())
			{
				while (true)
				{
					IL_1E1:
					uint arg_1B2_0 = (!enumerator.MoveNext()) ? 3679854817u : 2267341827u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1B2_0 ^ 2695777957u)) % 5u)
						{
						case 0u:
							arg_1B2_0 = 2267341827u;
							continue;
						case 1u:
							goto IL_1E1;
						case 2u:
							SpawnManager.smethod_10(stringBuilder, SpawnManager.smethod_14(SpawnManager.smethod_9(Module.smethod_33<string>(3088118917u), new object[]
							{
								spawn.Id,
								spawn.Map,
								spawn.Position.X,
								spawn.Position.Y,
								spawn.Position.Z,
								spawn.Position.O
							}), SpawnManager.smethod_9(Module.smethod_35<string>(261510741u), new object[]
							{
								spawn.GameObject.Rot.X,
								spawn.GameObject.Rot.Y,
								spawn.GameObject.Rot.Z,
								spawn.GameObject.Rot.O,
								spawn.AnimProgress,
								spawn.State
							})));
							arg_1B2_0 = (num * 3846870361u ^ 1228420013u);
							continue;
						case 3u:
						{
							KeyValuePair<ulong, GameObjectSpawn> arg_74_0 = enumerator.Current;
							arg_1B2_0 = 2841696158u;
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			SpawnManager.smethod_12(Module.smethod_35<string>(1324711985u), SpawnManager.smethod_11(stringBuilder));
		}

		public CreatureSpawn FindSpawn(ulong guid)
		{
			CreatureSpawn result;
			this.CreatureSpawns.TryGetValue(guid, out result);
			return result;
		}

		public GameObjectSpawn FindSpawn(long guid)
		{
			GameObjectSpawn result;
			this.GameObjectSpawns.TryGetValue((ulong)guid, out result);
			return result;
		}

		[IteratorStateMachine(typeof(SpawnManager.<GetInRangeCreatures>d__19))]
		public IEnumerable<CreatureSpawn> GetInRangeCreatures(WorldObject obj)
		{
			SpawnManager.<GetInRangeCreatures>d__19 expr_07 = new SpawnManager.<GetInRangeCreatures>d__19(-2);
			expr_07.__4__this = this;
			expr_07.__3__obj = obj;
			return expr_07;
		}

		[IteratorStateMachine(typeof(SpawnManager.<GetInRangeObjects>d__20))]
		public IEnumerable<GameObjectSpawn> GetInRangeObjects(WorldObject obj)
		{
			SpawnManager.<GetInRangeObjects>d__20 expr_07 = new SpawnManager.<GetInRangeObjects>d__20(-2);
			expr_07.__4__this = this;
			expr_07.__3__obj = obj;
			return expr_07;
		}

		public IEnumerable<CreatureSpawn> GetInRangeCreatures2(WorldObject obj, bool meh)
		{
			List<CreatureSpawn> list = new List<CreatureSpawn>();
			using (Dictionary<ulong, CreatureSpawn>.Enumerator enumerator = new Dictionary<ulong, CreatureSpawn>(this.CreatureSpawns).GetEnumerator())
			{
				while (true)
				{
					IL_108:
					uint arg_D1_0 = (!enumerator.MoveNext()) ? 1029218472u : 226583693u;
					while (true)
					{
						uint num;
						switch ((num = (arg_D1_0 ^ 217325220u)) % 7u)
						{
						case 0u:
						{
							KeyValuePair<ulong, CreatureSpawn> current;
							arg_D1_0 = (((!obj.CheckDistance(current.Value, 100000f)) ? 585138839u : 50482668u) ^ num * 1366446683u);
							continue;
						}
						case 1u:
						{
							KeyValuePair<ulong, CreatureSpawn> current = enumerator.Current;
							arg_D1_0 = 1081756557u;
							continue;
						}
						case 2u:
							goto IL_108;
						case 4u:
							arg_D1_0 = 226583693u;
							continue;
						case 5u:
						{
							KeyValuePair<ulong, CreatureSpawn> current;
							list.Add(current.Value);
							arg_D1_0 = (num * 3102075345u ^ 982577887u);
							continue;
						}
						case 6u:
						{
							KeyValuePair<ulong, CreatureSpawn> current;
							arg_D1_0 = (((!obj.ToCharacter().InRangeObjects.ContainsKey(current.Key)) ? 3815954578u : 3784905265u) ^ num * 4188323886u);
							continue;
						}
						}
						goto Block_5;
					}
				}
				Block_5:;
			}
			return list;
		}

		[IteratorStateMachine(typeof(SpawnManager.<GetOutOfRangeCreatures>d__22))]
		public IEnumerable<CreatureSpawn> GetOutOfRangeCreatures(WorldObject obj)
		{
			SpawnManager.<GetOutOfRangeCreatures>d__22 expr_07 = new SpawnManager.<GetOutOfRangeCreatures>d__22(-2);
			expr_07.__4__this = this;
			expr_07.__3__obj = obj;
			return expr_07;
		}

		public void LoadCreatureSpawns()
		{
			if (this.CreatureSpawns == null)
			{
				goto IL_1A;
			}
			goto IL_96;
			uint arg_65_0;
			bool flag;
			bool flag2;
			while (true)
			{
				IL_60:
				uint num;
				switch ((num = (arg_65_0 ^ 1524569722u)) % 6u)
				{
				case 1u:
					this.CreatureSpawnsFile = new Dictionary<ulong, CreatureSpawn>();
					arg_65_0 = (num * 358794246u ^ 1309962346u);
					continue;
				case 2u:
					flag = false;
					flag2 = false;
					arg_65_0 = 123143254u;
					continue;
				case 3u:
					goto IL_96;
				case 4u:
					this.CreatureSpawns = new Dictionary<ulong, CreatureSpawn>();
					arg_65_0 = (num * 19215032u ^ 3342281501u);
					continue;
				case 5u:
					goto IL_1A;
				}
				break;
			}
			StreamReader streamReader = SpawnManager.smethod_15(Module.smethod_36<string>(307414319u));
			try
			{
				int num2 = 10000;
				while (true)
				{
					IL_6F6:
					uint arg_650_0 = 981451751u;
					while (true)
					{
						uint num;
						Creature arg_1A6_0;
						Creature creature;
						switch ((num = (arg_650_0 ^ 1524569722u)) % 38u)
						{
						case 0u:
						{
							ulong num3 = 0uL;
							arg_650_0 = 958144028u;
							continue;
						}
						case 1u:
						{
							string[] array;
							ulong num3 = ulong.Parse(array[0]);
							int num4 = int.Parse(array[1]);
							int num5 = int.Parse(array[2]);
							arg_650_0 = (num * 2119059u ^ 3327670421u);
							continue;
						}
						case 2u:
							arg_650_0 = (SpawnManager.smethod_18(streamReader) ? 747850818u : 1461667358u);
							continue;
						case 3u:
						{
							string[] array;
							float o = float.Parse(array[5]);
							arg_650_0 = (num * 2611195834u ^ 2430692469u);
							continue;
						}
						case 4u:
							flag2 = true;
							arg_650_0 = (num * 3002735187u ^ 2663054816u);
							continue;
						case 5u:
							arg_1A6_0 = null;
							goto IL_1A6;
						case 6u:
						{
							string[] array;
							float o = float.Parse(array[6]);
							int emote = int.Parse(array[7]);
							arg_650_0 = (num * 3904469367u ^ 2227231295u);
							continue;
						}
						case 7u:
						{
							string[] array;
							arg_650_0 = ((array.Length != 7) ? 224207891u : 518462223u);
							continue;
						}
						case 8u:
						{
							string[] array;
							float z = float.Parse(array[4]);
							arg_650_0 = (num * 4232840693u ^ 3786714935u);
							continue;
						}
						case 9u:
						{
							string[] array;
							arg_650_0 = ((array.Length == 8) ? 1330120259u : 2048322271u);
							continue;
						}
						case 10u:
						{
							ulong num3;
							CreatureSpawn value;
							this.CreatureSpawnsFile.Add(num3, value);
							arg_650_0 = (num * 1233841498u ^ 1180760474u);
							continue;
						}
						case 11u:
							goto IL_6F6;
						case 12u:
						{
							ulong num3;
							CreatureSpawn value;
							this.CreatureSpawns.Add(num3, value);
							arg_650_0 = (num * 4197746823u ^ 522438082u);
							continue;
						}
						case 13u:
							Log.Message(LogType.Debug, Module.smethod_34<string>(3127249109u), Array.Empty<object>());
							flag = true;
							arg_650_0 = (num * 2116225594u ^ 3173140791u);
							continue;
						case 14u:
						{
							string[] array;
							int num4 = int.Parse(array[0]);
							int num5 = int.Parse(array[1]);
							arg_650_0 = 1277984794u;
							continue;
						}
						case 15u:
						{
							float x = 0f;
							float y = 0f;
							arg_650_0 = (num * 2688627230u ^ 99094095u);
							continue;
						}
						case 16u:
						{
							string[] array;
							float x = float.Parse(array[4]);
							float y = float.Parse(array[5]);
							arg_650_0 = (num * 2941514440u ^ 2694688977u);
							continue;
						}
						case 17u:
							Log.Message(LogType.Debug, Module.smethod_37<string>(2659301302u), Array.Empty<object>());
							arg_650_0 = (num * 3710228926u ^ 4010143204u);
							continue;
						case 18u:
						{
							int num4 = 0;
							arg_650_0 = (num * 2421001289u ^ 1886888772u);
							continue;
						}
						case 19u:
						{
							string[] array;
							float z = float.Parse(array[5]);
							arg_650_0 = (num * 483235344u ^ 1035959018u);
							continue;
						}
						case 21u:
						{
							string[] array;
							int emote = int.Parse(array[6]);
							arg_650_0 = (num * 2265660278u ^ 2930380541u);
							continue;
						}
						case 22u:
						{
							string[] array;
							float x = float.Parse(array[2]);
							arg_650_0 = (num * 1182226807u ^ 2854965704u);
							continue;
						}
						case 23u:
						{
							float z = 0f;
							float o = 0f;
							arg_650_0 = (num * 2243190588u ^ 4130535944u);
							continue;
						}
						case 24u:
						{
							ulong num3;
							int num4;
							int num5;
							float o;
							int emote;
							float z;
							float x;
							float y;
							CreatureSpawn value = new CreatureSpawn(212)
							{
								SGuid = new SmartGuid(num3, num4, GuidType.Creature, (ulong)num5),
								Guid = num3,
								Id = num4,
								Creature = creature,
								Position = new Vector4
								{
									X = x,
									Y = y,
									Z = z,
									O = o
								},
								Map = (uint)num5,
								Emote = emote
							};
							arg_650_0 = (num * 3325252821u ^ 1081726913u);
							continue;
						}
						case 25u:
							arg_650_0 = ((!flag2) ? 265209513u : 866334176u);
							continue;
						case 26u:
						{
							string[] array;
							float y = float.Parse(array[3]);
							arg_650_0 = (num * 3618369892u ^ 2259650920u);
							continue;
						}
						case 27u:
						{
							string[] array;
							arg_650_0 = (((array.Length != 7) ? 202482177u : 1237354634u) ^ num * 2631541755u);
							continue;
						}
						case 28u:
						{
							num2++;
							string[] array = SpawnManager.smethod_17(SpawnManager.smethod_16(streamReader), new char[]
							{
								','
							});
							arg_650_0 = (flag ? 900633349u : 600465647u);
							continue;
						}
						case 29u:
						{
							string[] array;
							arg_650_0 = (((array.Length != 7) ? 4192149553u : 2900835666u) ^ num * 3431770562u);
							continue;
						}
						case 30u:
							arg_650_0 = (((creature != null) ? 1717833002u : 656419342u) ^ num * 1298903974u);
							continue;
						case 31u:
							arg_650_0 = (num * 4128277434u ^ 2697294288u);
							continue;
						case 32u:
						{
							int num5 = 0;
							arg_650_0 = (num * 2048102388u ^ 4077460585u);
							continue;
						}
						case 33u:
						{
							int num4;
							if (!Manager.ObjectMgr.Creatures.ContainsKey(num4))
							{
								arg_650_0 = 1735060541u;
								continue;
							}
							arg_1A6_0 = Manager.ObjectMgr.Creatures[num4];
							goto IL_1A6;
						}
						case 34u:
						{
							int emote = 0;
							string[] array;
							arg_650_0 = (((array.Length != 6) ? 3598428491u : 3633428560u) ^ num * 3974302224u);
							continue;
						}
						case 35u:
						{
							string[] array;
							arg_650_0 = (((array.Length == 6) ? 4019163477u : 2933942023u) ^ num * 578514298u);
							continue;
						}
						case 36u:
						{
							ulong num3;
							arg_650_0 = (this.CreatureSpawnsFile.ContainsKey(num3) ? 423623362u : 1294610342u);
							continue;
						}
						case 37u:
						{
							ulong num3;
							arg_650_0 = (((!this.CreatureSpawns.ContainsKey(num3)) ? 1174138681u : 762860525u) ^ num * 1034182491u);
							continue;
						}
						}
						goto Block_26;
						IL_1A6:
						creature = arg_1A6_0;
						arg_650_0 = 740054584u;
					}
				}
				Block_26:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_739:
						uint arg_720_0 = 1653238839u;
						while (true)
						{
							uint num;
							switch ((num = (arg_720_0 ^ 1524569722u)) % 3u)
							{
							case 1u:
								SpawnManager.smethod_19(streamReader);
								arg_720_0 = (num * 2485317961u ^ 1939970520u);
								continue;
							case 2u:
								goto IL_739;
							}
							goto Block_29;
						}
					}
					Block_29:;
				}
			}
			if (flag)
			{
				StringBuilder stringBuilder;
				while (true)
				{
					IL_77C:
					uint arg_763_0 = 1869693337u;
					while (true)
					{
						uint num;
						switch ((num = (arg_763_0 ^ 1524569722u)) % 3u)
						{
						case 1u:
							stringBuilder = SpawnManager.smethod_8();
							arg_763_0 = (num * 3100820718u ^ 2209814309u);
							continue;
						case 2u:
							goto IL_77C;
						}
						goto Block_6;
					}
				}
				Block_6:
				using (Dictionary<ulong, CreatureSpawn>.Enumerator enumerator = this.CreatureSpawnsFile.GetEnumerator())
				{
					while (true)
					{
						IL_8BD:
						uint arg_88D_0 = enumerator.MoveNext() ? 1577597638u : 2144502716u;
						while (true)
						{
							uint num;
							switch ((num = (arg_88D_0 ^ 1524569722u)) % 5u)
							{
							case 0u:
								arg_88D_0 = 1577597638u;
								continue;
							case 1u:
							{
								KeyValuePair<ulong, CreatureSpawn> current = enumerator.Current;
								arg_88D_0 = 1342272355u;
								continue;
							}
							case 3u:
							{
								KeyValuePair<ulong, CreatureSpawn> current;
								SpawnManager.smethod_10(stringBuilder, SpawnManager.smethod_9(Module.smethod_35<string>(3759077104u), new object[]
								{
									current.Value.Id,
									current.Value.Map,
									current.Value.Position.X,
									current.Value.Position.Y,
									current.Value.Position.Z,
									current.Value.Position.O,
									current.Value.Emote
								}));
								arg_88D_0 = (num * 2137885228u ^ 1501199090u);
								continue;
							}
							case 4u:
								goto IL_8BD;
							}
							goto Block_31;
						}
					}
					Block_31:;
				}
				SpawnManager.smethod_12(Module.smethod_34<string>(3998541984u), SpawnManager.smethod_11(stringBuilder));
				goto IL_936;
			}
			goto IL_961;
			uint arg_940_0;
			while (true)
			{
				IL_93B:
				uint num;
				switch ((num = (arg_940_0 ^ 1524569722u)) % 5u)
				{
				case 0u:
					goto IL_936;
				case 1u:
					this.LoadCreatureSpawns();
					arg_940_0 = (num * 1535762664u ^ 999084619u);
					continue;
				case 2u:
					this.CreatureSpawns = new Dictionary<ulong, CreatureSpawn>();
					this.CreatureSpawnsFile = new Dictionary<ulong, CreatureSpawn>();
					arg_940_0 = (num * 1285116544u ^ 794420355u);
					continue;
				case 3u:
					goto IL_961;
				}
				break;
			}
			StringBuilder stringBuilder2 = SpawnManager.smethod_8();
			using (Dictionary<ulong, CreatureSpawn>.Enumerator enumerator = this.CreatureSpawnsFile.GetEnumerator())
			{
				while (true)
				{
					IL_AA5:
					int arg_A79_0 = enumerator.MoveNext() ? 112548055 : 1862462057;
					while (true)
					{
						switch ((arg_A79_0 ^ 1524569722) % 4)
						{
						case 0:
							arg_A79_0 = 112548055;
							continue;
						case 1:
						{
							KeyValuePair<ulong, CreatureSpawn> current2 = enumerator.Current;
							SpawnManager.smethod_10(stringBuilder2, SpawnManager.smethod_9(Module.smethod_35<string>(1814433606u), new object[]
							{
								current2.Key,
								current2.Value.Id,
								current2.Value.Map,
								current2.Value.Position.X,
								current2.Value.Position.Y,
								current2.Value.Position.Z,
								current2.Value.Position.O,
								current2.Value.Emote
							}));
							arg_A79_0 = 1547431680;
							continue;
						}
						case 2:
							goto IL_AA5;
						}
						goto Block_35;
					}
				}
				Block_35:;
			}
			SpawnManager.smethod_12(Module.smethod_37<string>(292722155u), SpawnManager.smethod_11(stringBuilder2));
			while (true)
			{
				IL_B4B:
				uint arg_B2A_0 = 323566519u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B2A_0 ^ 1524569722u)) % 5u)
					{
					case 1u:
						this.LoadCreatureSpawns();
						arg_B2A_0 = (num * 1871577909u ^ 1461636678u);
						continue;
					case 2u:
						this.CreatureSpawnsFile = new Dictionary<ulong, CreatureSpawn>();
						arg_B2A_0 = (num * 3158367289u ^ 1455055445u);
						continue;
					case 3u:
						this.CreatureSpawns = new Dictionary<ulong, CreatureSpawn>();
						arg_B2A_0 = (num * 1500603824u ^ 1579227831u);
						continue;
					case 4u:
						goto IL_B4B;
					}
					goto Block_11;
				}
			}
			Block_11:
			goto IL_B52;
			IL_936:
			arg_940_0 = 409409393u;
			goto IL_93B;
			IL_961:
			if (flag2)
			{
				arg_940_0 = 998176945u;
				goto IL_93B;
			}
			IL_B52:
			Log.Message(LogType.Debug, Module.smethod_35<string>(611352373u), new object[]
			{
				this.CreatureSpawns.Count
			});
			return;
			IL_1A:
			arg_65_0 = 919221850u;
			goto IL_60;
			IL_96:
			arg_65_0 = ((this.CreatureSpawnsFile == null) ? 2128908445u : 1242068224u);
			goto IL_60;
		}

		public void LoadCreatureWaypoints()
		{
			StreamReader streamReader = SpawnManager.smethod_15(Module.smethod_35<string>(2234073573u));
			try
			{
				while (true)
				{
					IL_182:
					uint arg_14A_0 = (!SpawnManager.smethod_18(streamReader)) ? 1285668127u : 1841545135u;
					while (true)
					{
						uint num;
						switch ((num = (arg_14A_0 ^ 1669394394u)) % 7u)
						{
						case 0u:
						{
							ulong num2;
							this.waypoints.Add(num2, new List<Waypoint>());
							arg_14A_0 = (num * 1920135413u ^ 4134762485u);
							continue;
						}
						case 1u:
						{
							string[] expr_96 = SpawnManager.smethod_17(SpawnManager.smethod_16(streamReader), new char[]
							{
								','
							});
							ulong num2 = ulong.Parse(expr_96[0]);
							float x = float.Parse(expr_96[1]);
							float y = float.Parse(expr_96[2]);
							float z = float.Parse(expr_96[3]);
							float o = float.Parse(expr_96[4]);
							int index = int.Parse(expr_96[5]);
							int waitTime = int.Parse(expr_96[6]);
							Waypoint item = new Waypoint
							{
								CreatureGuid = num2,
								Point = new Vector4
								{
									X = x,
									Y = y,
									Z = z,
									O = o
								},
								Index = index,
								WaitTime = waitTime
							};
							arg_14A_0 = 1977668938u;
							continue;
						}
						case 2u:
						{
							ulong num2;
							arg_14A_0 = ((this.waypoints.ContainsKey(num2) ? 4125832734u : 2945254981u) ^ num * 62416986u);
							continue;
						}
						case 3u:
							arg_14A_0 = 1285668127u;
							continue;
						case 5u:
							goto IL_182;
						case 6u:
						{
							ulong num2;
							Waypoint item;
							this.waypoints[num2].Add(item);
							arg_14A_0 = 220001912u;
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_1C8:
						uint arg_1AF_0 = 747701470u;
						while (true)
						{
							uint num;
							switch ((num = (arg_1AF_0 ^ 1669394394u)) % 3u)
							{
							case 0u:
								goto IL_1C8;
							case 2u:
								SpawnManager.smethod_19(streamReader);
								arg_1AF_0 = (num * 2198306379u ^ 1790037380u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
		}

		public void LoadGameobjectSpawns()
		{
			if (this.GameObjectSpawns == null)
			{
				while (true)
				{
					IL_41:
					uint arg_28_0 = 3530881873u;
					while (true)
					{
						uint num;
						switch ((num = (arg_28_0 ^ 3883006564u)) % 3u)
						{
						case 1u:
							this.GameObjectSpawns = new Dictionary<ulong, GameObjectSpawn>();
							arg_28_0 = (num * 2629725413u ^ 141764694u);
							continue;
						case 2u:
							goto IL_41;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			int num2 = 50000;
			using (Dictionary<int, GameObject>.Enumerator enumerator = Manager.ObjectMgr.GameObjectSpawns.GetEnumerator())
			{
				while (true)
				{
					IL_1FE:
					uint arg_1C6_0 = enumerator.MoveNext() ? 3162762357u : 2214645096u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1C6_0 ^ 3883006564u)) % 7u)
						{
						case 0u:
						{
							GameObjectSpawn gameObjectSpawn;
							this.GameObjectSpawns.Add((ulong)((long)num2), gameObjectSpawn);
							arg_1C6_0 = (num * 292576894u ^ 189371222u);
							continue;
						}
						case 1u:
						{
							KeyValuePair<int, GameObject> current = enumerator.Current;
							arg_1C6_0 = 3027911185u;
							continue;
						}
						case 2u:
							goto IL_1FE;
						case 3u:
							arg_1C6_0 = 3162762357u;
							continue;
						case 5u:
						{
							KeyValuePair<int, GameObject> current;
							GameObjectSpawn gameObjectSpawn = new GameObjectSpawn(33)
							{
								SGuid = new SmartGuid((ulong)((long)num2), current.Value.Id, GuidType.GameObject, (ulong)current.Value.Map),
								Guid = (ulong)((long)num2),
								Id = current.Value.Id,
								GameObject = current.Value,
								Position = new Vector4
								{
									X = current.Value.Pos.X,
									Y = current.Value.Pos.Y,
									Z = current.Value.Pos.Z,
									O = current.Value.Pos.O
								},
								Map = (uint)current.Value.Map
							};
							arg_1C6_0 = (((gameObjectSpawn.Position.X == 0f) ? 1641797584u : 826141433u) ^ num * 1132252456u);
							continue;
						}
						case 6u:
							num2++;
							arg_1C6_0 = (num * 431808991u ^ 638424871u);
							continue;
						}
						goto Block_7;
					}
				}
				Block_7:;
			}
			StreamReader streamReader = SpawnManager.smethod_15(Module.smethod_35<string>(1324711985u));
			try
			{
				int num3 = 70000;
				while (true)
				{
					IL_4E0:
					uint arg_497_0 = (!SpawnManager.smethod_18(streamReader)) ? 4007557740u : 3943314680u;
					while (true)
					{
						uint num;
						GameObject arg_25A_0;
						GameObject gameObject;
						switch ((num = (arg_497_0 ^ 3883006564u)) % 11u)
						{
						case 0u:
						{
							int num4;
							if (!Manager.ObjectMgr.GameObjects.ContainsKey(num4))
							{
								arg_497_0 = (num * 2066109709u ^ 4114345367u);
								continue;
							}
							arg_25A_0 = Manager.ObjectMgr.GameObjects[num4];
							goto IL_25A;
						}
						case 1u:
							arg_497_0 = (((gameObject == null) ? 956813484u : 212872656u) ^ num * 2937783407u);
							continue;
						case 2u:
						{
							float x;
							float y;
							float z;
							float o;
							gameObject.Pos = new Vector4
							{
								X = x,
								Y = y,
								Z = z,
								O = o
							};
							int num4;
							int num5;
							int num6;
							int num7;
							GameObjectSpawn value = new GameObjectSpawn(33)
							{
								SGuid = new SmartGuid((ulong)((long)num3), gameObject.Id, GuidType.GameObject, (ulong)num5),
								Guid = (ulong)((long)num3),
								Id = num4,
								GameObject = gameObject,
								Position = new Vector4
								{
									X = x,
									Y = y,
									Z = z,
									O = o
								},
								AnimProgress = (byte)num6,
								State = (byte)num7,
								Map = (uint)num5
							};
							arg_497_0 = (num * 3318439521u ^ 4094514482u);
							continue;
						}
						case 3u:
							goto IL_4E0;
						case 4u:
							arg_497_0 = 4007557740u;
							continue;
						case 6u:
						{
							float x2;
							float y2;
							float z2;
							float o2;
							gameObject.Rot = new Vector4
							{
								X = x2,
								Y = y2,
								Z = z2,
								O = o2
							};
							arg_497_0 = (num * 2906587653u ^ 4204273687u);
							continue;
						}
						case 7u:
						{
							GameObjectSpawn value;
							this.GameObjectSpawns.Add((ulong)((long)num3), value);
							arg_497_0 = (num * 3581299932u ^ 1939841136u);
							continue;
						}
						case 8u:
						{
							string[] expr_27D = SpawnManager.smethod_17(SpawnManager.smethod_16(streamReader), new char[]
							{
								','
							});
							int num4 = int.Parse(expr_27D[0]);
							int num5 = int.Parse(expr_27D[1]);
							float x = float.Parse(expr_27D[2]);
							float y = float.Parse(expr_27D[3]);
							float z = float.Parse(expr_27D[4]);
							float o = float.Parse(expr_27D[5]);
							float x2 = float.Parse(expr_27D[6]);
							float y2 = float.Parse(expr_27D[7]);
							float z2 = float.Parse(expr_27D[8]);
							float o2 = float.Parse(expr_27D[9]);
							int num6 = int.Parse(expr_27D[10]);
							int num7 = int.Parse(expr_27D[11]);
							arg_497_0 = (num * 512904553u ^ 2901577556u);
							continue;
						}
						case 9u:
							arg_25A_0 = null;
							goto IL_25A;
						case 10u:
							num3++;
							arg_497_0 = 3509578595u;
							continue;
						}
						goto Block_13;
						IL_25A:
						gameObject = arg_25A_0;
						arg_497_0 = 3053898084u;
					}
				}
				Block_13:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_529:
						uint arg_510_0 = 2540624100u;
						while (true)
						{
							uint num;
							switch ((num = (arg_510_0 ^ 3883006564u)) % 3u)
							{
							case 0u:
								goto IL_529;
							case 2u:
								SpawnManager.smethod_19(streamReader);
								arg_510_0 = (num * 3441258001u ^ 2287197116u);
								continue;
							}
							goto Block_17;
						}
					}
					Block_17:;
				}
			}
			Log.Message(LogType.Debug, Module.smethod_36<string>(741469589u), new object[]
			{
				this.GameObjectSpawns.Count
			});
		}

		static bool smethod_5(string string_0)
		{
			return File.Exists(string_0);
		}

		static FileStream smethod_6(string string_0)
		{
			return File.Create(string_0);
		}

		static void smethod_7(Stream stream_0)
		{
			stream_0.Dispose();
		}

		static StringBuilder smethod_8()
		{
			return new StringBuilder();
		}

		static string smethod_9(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}

		static StringBuilder smethod_10(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.AppendLine(string_0);
		}

		static string smethod_11(object object_0)
		{
			return object_0.ToString();
		}

		static void smethod_12(string string_0, string string_1)
		{
			File.WriteAllText(string_0, string_1);
		}

		static void smethod_13(string string_0, string string_1)
		{
			File.AppendAllText(string_0, string_1);
		}

		static string smethod_14(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static StreamReader smethod_15(string string_0)
		{
			return new StreamReader(string_0);
		}

		static string smethod_16(TextReader textReader_0)
		{
			return textReader_0.ReadLine();
		}

		static string[] smethod_17(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		static bool smethod_18(StreamReader streamReader_0)
		{
			return streamReader_0.EndOfStream;
		}

		static void smethod_19(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}
}
