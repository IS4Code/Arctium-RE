using AuthServer.Game.Entities;
using AuthServer.Network;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Constants;
using Framework.Constants.Misc;
using Framework.Constants.Movement;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Misc;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace AuthServer.Game.Managers
{
	public sealed class WorldManager : Singleton<WorldManager>
	{
		public enum AccountDataTypes
		{
			GlobalConfigCache,
			PerCharacterConfigCache,
			GlobalBindingsCache,
			PerCharacterBindingsCache,
			GlobalMacrosCache,
			PerCharacterMacrosCache,
			PerCharacterLayoutCache,
			PerCharacterChatCache
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly WorldManager.__c __9 = new WorldManager.__c();

			public static Func<string, string> __9__40_0;

			internal string SendHotfixesb__40_0(string s)
			{
				return WorldManager.__c.smethod_0(s, Module.smethod_37<string>(3974021651u), "");
			}

			static string smethod_0(string string_0, string string_1, string string_2)
			{
				return string_0.Replace(string_1, string_2);
			}
		}

		public List<Emote> EmoteList = new List<Emote>();

		public List<Character> CharaterList = new List<Character>();

		public List<Races> ChrRaces = new List<Races>();

		public ConcurrentDictionary<ulong, WorldClass> Sessions;

		public ConcurrentDictionary<ulong, WorldClass2> Sessions2;

		public Dictionary<uint, uint> SpellVisualIds = new Dictionary<uint, uint>();

		public Dictionary<uint, uint> MountDisplays = new Dictionary<uint, uint>();

		public Dictionary<string, Tuple<uint, uint>> MountSpells = new Dictionary<string, Tuple<uint, uint>>();

		public Dictionary<uint, uint> DefaultPowerTypes = new Dictionary<uint, uint>();

		public Dictionary<uint, uint> DefaultChrSpec = new Dictionary<uint, uint>();

		private static readonly object taskObject = WorldManager.smethod_53();

		public Dictionary<string, DBInfo> DBInfo = new Dictionary<string, DBInfo>();

		public WorldClass Session
		{
			get;
			set;
		}

		private WorldManager()
		{
			StreamReader streamReader = WorldManager.smethod_7(WorldManager.smethod_6(WorldManager.smethod_5(), Module.smethod_35<string>(1758028300u)));
			try
			{
				while (!WorldManager.smethod_11(streamReader))
				{
					string[] array = WorldManager.smethod_9(WorldManager.smethod_8(streamReader), new char[]
					{
						';'
					});
					string[] array2 = WorldManager.smethod_10(array[3], new char[]
					{
						','
					}, StringSplitOptions.RemoveEmptyEntries);
					DBInfo dBInfo = new DBInfo
					{
						Name = array[0],
						TableHash = uint.Parse(array[1]),
						HasIndex = bool.Parse(array[2])
					};
					dBInfo.FieldBytes = new sbyte[array2.Length];
					for (int i = 0; i < array2.Length; i++)
					{
						dBInfo.FieldBytes[i] = sbyte.Parse(array2[i]);
					}
					this.DBInfo.Add(array[0], dBInfo);
				}
			}
			finally
			{
				if (streamReader != null)
				{
					WorldManager.smethod_12(streamReader);
				}
			}
			StreamReader streamReader2 = WorldManager.smethod_7(WorldManager.smethod_6(WorldManager.smethod_5(), Module.smethod_36<string>(330893391u)));
			try
			{
				while (!WorldManager.smethod_11(streamReader2))
				{
					string[] array3 = WorldManager.smethod_9(WorldManager.smethod_8(streamReader2), new char[]
					{
						','
					});
					try
					{
						if (!this.SpellVisualIds.ContainsKey(uint.Parse(WorldManager.smethod_13(array3[1], Module.smethod_34<string>(1801001672u), ""))))
						{
							this.SpellVisualIds.Add(uint.Parse(WorldManager.smethod_13(array3[1], Module.smethod_36<string>(1708679815u), "")), uint.Parse(WorldManager.smethod_13(array3[2], Module.smethod_36<string>(1708679815u), "")));
						}
					}
					catch (Exception)
					{
					}
				}
			}
			finally
			{
				if (streamReader2 != null)
				{
					WorldManager.smethod_12(streamReader2);
				}
			}
			using (StreamReader streamReader3 = WorldManager.smethod_7(WorldManager.smethod_6(WorldManager.smethod_5(), Module.smethod_35<string>(3730591132u))))
			{
				while (!streamReader3.EndOfStream)
				{
					string[] array4 = WorldManager.smethod_9(WorldManager.smethod_8(streamReader3), new char[]
					{
						','
					});
					int num;
					if (array4.Length >= 3 && int.TryParse(WorldManager.smethod_13(array4[0], Module.smethod_35<string>(764625391u), ""), out num))
					{
						try
						{
							uint item = uint.Parse(WorldManager.smethod_13(array4[0], Module.smethod_35<string>(764625391u), ""));
							uint item2 = uint.Parse(WorldManager.smethod_13(array4[1], Module.smethod_34<string>(1801001672u), ""));
							string text = WorldManager.smethod_13(WorldManager.smethod_13(array4[2], Module.smethod_37<string>(3974021651u), ""), Module.smethod_36<string>(2793817990u), "");
							int num2 = 2;
							while (this.MountSpells.ContainsKey(text))
							{
								string arg_321_0 = text;
								int num3 = num2;
								num2 = num3 + 1;
								text = arg_321_0 + num3.ToString();
							}
							this.MountSpells.Add(text, Tuple.Create<uint, uint>(item, item2));
						}
						catch (Exception)
						{
						}
					}
				}
			}
			using (StreamReader streamReader4 = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(Module.smethod_33<string>(2373467861u))))
			{
				while (!streamReader4.EndOfStream)
				{
					string[] array5 = streamReader4.ReadLine().Split(new char[]
					{
						','
					});
					try
					{
						uint key = uint.Parse(array5[1].Replace(Module.smethod_35<string>(764625391u), ""));
						uint value = uint.Parse(array5[2].Replace(Module.smethod_34<string>(1801001672u), ""));
						if (!this.MountDisplays.ContainsKey(key))
						{
							this.MountDisplays.Add(key, value);
						}
					}
					catch (Exception)
					{
					}
				}
				Log.Message(LogType.Debug, string.Format(Module.smethod_36<string>(889432748u), this.MountSpells.Count), Array.Empty<object>());
			}
			using (StreamReader streamReader5 = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(Module.smethod_34<string>(1585865081u))))
			{
				while (!streamReader5.EndOfStream)
				{
					string[] array6 = streamReader5.ReadLine().Split(new char[]
					{
						';'
					});
					try
					{
						uint key2 = uint.Parse(array6[1].Replace(Module.smethod_35<string>(764625391u), ""));
						uint value2 = uint.Parse(array6[2].Replace(Module.smethod_33<string>(3031927268u), ""));
						if (!this.DefaultPowerTypes.ContainsKey(key2))
						{
							this.DefaultPowerTypes.Add(key2, value2);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			using (StreamReader streamReader6 = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(Module.smethod_35<string>(4080432764u))))
			{
				while (!streamReader6.EndOfStream)
				{
					string[] array7 = streamReader6.ReadLine().Split(new string[]
					{
						Module.smethod_36<string>(3508781973u)
					}, StringSplitOptions.None);
					try
					{
						uint value3 = uint.Parse(array7[0].Replace(Module.smethod_33<string>(3031927268u), ""));
						uint key3 = uint.Parse(array7[6].Replace(Module.smethod_35<string>(764625391u), ""));
						if (!this.DefaultChrSpec.ContainsKey(key3))
						{
							this.DefaultChrSpec.Add(key3, value3);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			this.Sessions = new ConcurrentDictionary<ulong, WorldClass>();
			this.Sessions2 = new ConcurrentDictionary<ulong, WorldClass2>();
			this.LoadEmotes();
			this.LoadRaces();
			this.StartRangeUpdateTimers();
		}

		public void LoadEmotes()
		{
			this.EmoteList.Add(new Emote
			{
				Id = 3,
				EmoteId = 14
			});
			while (true)
			{
				IL_119B:
				uint arg_1096_0 = 383320789u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1096_0 ^ 1033623843u)) % 62u)
					{
					case 0u:
						this.EmoteList.Add(new Emote
						{
							Id = 61,
							EmoteId = 12
						});
						arg_1096_0 = (num * 3988128806u ^ 1907664105u);
						continue;
					case 1u:
						this.EmoteList.Add(new Emote
						{
							Id = 183,
							EmoteId = 14
						});
						arg_1096_0 = (num * 3949113554u ^ 3858867641u);
						continue;
					case 2u:
						this.EmoteList.Add(new Emote
						{
							Id = 20,
							EmoteId = 11
						});
						this.EmoteList.Add(new Emote
						{
							Id = 21,
							EmoteId = 4
						});
						this.EmoteList.Add(new Emote
						{
							Id = 22,
							EmoteId = 19
						});
						arg_1096_0 = (num * 1985080112u ^ 2700034040u);
						continue;
					case 3u:
						this.EmoteList.Add(new Emote
						{
							Id = 303,
							EmoteId = 22
						});
						arg_1096_0 = (num * 879220111u ^ 3539647698u);
						continue;
					case 4u:
						this.EmoteList.Add(new Emote
						{
							Id = 65,
							EmoteId = 18
						});
						arg_1096_0 = (num * 226760681u ^ 3881186566u);
						continue;
					case 5u:
						this.EmoteList.Add(new Emote
						{
							Id = 143,
							EmoteId = 18
						});
						arg_1096_0 = (num * 672488247u ^ 4288360987u);
						continue;
					case 6u:
						this.EmoteList.Add(new Emote
						{
							Id = 33,
							EmoteId = 2
						});
						arg_1096_0 = (num * 2412453073u ^ 2583259582u);
						continue;
					case 7u:
						this.EmoteList.Add(new Emote
						{
							Id = 87,
							EmoteId = 12
						});
						this.EmoteList.Add(new Emote
						{
							Id = 92,
							EmoteId = 20
						});
						arg_1096_0 = (num * 1761933501u ^ 3017686905u);
						continue;
					case 8u:
						this.EmoteList.Add(new Emote
						{
							Id = 304,
							EmoteId = 25
						});
						this.EmoteList.Add(new Emote
						{
							Id = 305,
							EmoteId = 25
						});
						this.EmoteList.Add(new Emote
						{
							Id = 306,
							EmoteId = 22
						});
						this.EmoteList.Add(new Emote
						{
							Id = 307,
							EmoteId = 15
						});
						this.EmoteList.Add(new Emote
						{
							Id = 323,
							EmoteId = 1
						});
						arg_1096_0 = (num * 2919730049u ^ 1023028719u);
						continue;
					case 9u:
						this.EmoteList.Add(new Emote
						{
							Id = 59,
							EmoteId = 68
						});
						this.EmoteList.Add(new Emote
						{
							Id = 60,
							EmoteId = 11
						});
						arg_1096_0 = (num * 3336805849u ^ 1391685926u);
						continue;
					case 10u:
						this.EmoteList.Add(new Emote
						{
							Id = 204,
							EmoteId = 15
						});
						arg_1096_0 = (num * 324831070u ^ 2312068459u);
						continue;
					case 11u:
						this.EmoteList.Add(new Emote
						{
							Id = 8,
							EmoteId = 20
						});
						arg_1096_0 = (num * 2382385865u ^ 912716636u);
						continue;
					case 12u:
						this.EmoteList.Add(new Emote
						{
							Id = 28,
							EmoteId = 431
						});
						this.EmoteList.Add(new Emote
						{
							Id = 31,
							EmoteId = 18
						});
						arg_1096_0 = (num * 1069288867u ^ 3171396263u);
						continue;
					case 13u:
						this.EmoteList.Add(new Emote
						{
							Id = 379,
							EmoteId = 18
						});
						arg_1096_0 = (num * 1204384598u ^ 2498832053u);
						continue;
					case 14u:
						this.EmoteList.Add(new Emote
						{
							Id = 368,
							EmoteId = 25
						});
						arg_1096_0 = (num * 2115931019u ^ 4196830548u);
						continue;
					case 15u:
						this.EmoteList.Add(new Emote
						{
							Id = 84,
							EmoteId = 24
						});
						this.EmoteList.Add(new Emote
						{
							Id = 86,
							EmoteId = 13
						});
						arg_1096_0 = (num * 1813435559u ^ 3064602599u);
						continue;
					case 16u:
						this.EmoteList.Add(new Emote
						{
							Id = 223,
							EmoteId = 430
						});
						this.EmoteList.Add(new Emote
						{
							Id = 243,
							EmoteId = 21
						});
						arg_1096_0 = (num * 3444559954u ^ 2173418787u);
						continue;
					case 17u:
						this.EmoteList.Add(new Emote
						{
							Id = 45,
							EmoteId = 11
						});
						arg_1096_0 = (num * 678895071u ^ 3909931692u);
						continue;
					case 18u:
						this.EmoteList.Add(new Emote
						{
							Id = 41,
							EmoteId = 23
						});
						arg_1096_0 = (num * 3866074734u ^ 4248679983u);
						continue;
					case 19u:
						this.EmoteList.Add(new Emote
						{
							Id = 120,
							EmoteId = 6
						});
						arg_1096_0 = (num * 2002016998u ^ 2747455175u);
						continue;
					case 20u:
						this.EmoteList.Add(new Emote
						{
							Id = 113,
							EmoteId = 14
						});
						this.EmoteList.Add(new Emote
						{
							Id = 118,
							EmoteId = 6
						});
						arg_1096_0 = (num * 3616658991u ^ 3550801574u);
						continue;
					case 21u:
						this.EmoteList.Add(new Emote
						{
							Id = 329,
							EmoteId = 1
						});
						arg_1096_0 = (num * 3591773383u ^ 238948831u);
						continue;
					case 22u:
						this.EmoteList.Add(new Emote
						{
							Id = 71,
							EmoteId = 20
						});
						this.EmoteList.Add(new Emote
						{
							Id = 72,
							EmoteId = 25
						});
						this.EmoteList.Add(new Emote
						{
							Id = 74,
							EmoteId = 16
						});
						arg_1096_0 = (num * 4037692556u ^ 1919369583u);
						continue;
					case 23u:
						this.EmoteList.Add(new Emote
						{
							Id = 66,
							EmoteId = 274
						});
						arg_1096_0 = (num * 2243908024u ^ 3279251898u);
						continue;
					case 24u:
						this.EmoteList.Add(new Emote
						{
							Id = 75,
							EmoteId = 15
						});
						this.EmoteList.Add(new Emote
						{
							Id = 76,
							EmoteId = 11
						});
						this.EmoteList.Add(new Emote
						{
							Id = 77,
							EmoteId = 14
						});
						this.EmoteList.Add(new Emote
						{
							Id = 78,
							EmoteId = 66
						});
						arg_1096_0 = (num * 821018009u ^ 4120528689u);
						continue;
					case 25u:
						this.EmoteList.Add(new Emote
						{
							Id = 48,
							EmoteId = 3
						});
						this.EmoteList.Add(new Emote
						{
							Id = 51,
							EmoteId = 20
						});
						this.EmoteList.Add(new Emote
						{
							Id = 52,
							EmoteId = 11
						});
						arg_1096_0 = (num * 3432060165u ^ 1844422215u);
						continue;
					case 26u:
						this.EmoteList.Add(new Emote
						{
							Id = 327,
							EmoteId = 25
						});
						arg_1096_0 = (num * 2096857026u ^ 281974834u);
						continue;
					case 27u:
						this.EmoteList.Add(new Emote
						{
							Id = 34,
							EmoteId = 10
						});
						this.EmoteList.Add(new Emote
						{
							Id = 35,
							EmoteId = 7
						});
						arg_1096_0 = (num * 400824335u ^ 2672116513u);
						continue;
					case 28u:
						this.EmoteList.Add(new Emote
						{
							Id = 5,
							EmoteId = 21
						});
						arg_1096_0 = (num * 4015744615u ^ 4208577417u);
						continue;
					case 29u:
						goto IL_119B;
					case 31u:
						this.EmoteList.Add(new Emote
						{
							Id = 83,
							EmoteId = 6
						});
						arg_1096_0 = (num * 4072189047u ^ 3535729883u);
						continue;
					case 32u:
						this.EmoteList.Add(new Emote
						{
							Id = 97,
							EmoteId = 1
						});
						this.EmoteList.Add(new Emote
						{
							Id = 100,
							EmoteId = 4
						});
						arg_1096_0 = (num * 783184666u ^ 740102824u);
						continue;
					case 33u:
						this.EmoteList.Add(new Emote
						{
							Id = 343,
							EmoteId = 21
						});
						arg_1096_0 = (num * 3541583344u ^ 1152898197u);
						continue;
					case 34u:
						this.EmoteList.Add(new Emote
						{
							Id = 450,
							EmoteId = 25
						});
						this.EmoteList.Add(new Emote
						{
							Id = 453,
							EmoteId = 1
						});
						this.EmoteList.Add(new Emote
						{
							Id = 456,
							EmoteId = 483
						});
						this.EmoteList.Add(new Emote
						{
							Id = 506,
							EmoteId = 60
						});
						arg_1096_0 = (num * 126481702u ^ 2173508319u);
						continue;
					case 35u:
						this.EmoteList.Add(new Emote
						{
							Id = 372,
							EmoteId = 274
						});
						this.EmoteList.Add(new Emote
						{
							Id = 373,
							EmoteId = 274
						});
						arg_1096_0 = (num * 1882115798u ^ 1999724116u);
						continue;
					case 36u:
						this.EmoteList.Add(new Emote
						{
							Id = 366,
							EmoteId = 377
						});
						arg_1096_0 = (num * 396734040u ^ 4282366865u);
						continue;
					case 37u:
						this.EmoteList.Add(new Emote
						{
							Id = 141,
							EmoteId = 26
						});
						arg_1096_0 = (num * 874622311u ^ 3406593241u);
						continue;
					case 38u:
						this.EmoteList.Add(new Emote
						{
							Id = 43,
							EmoteId = 5
						});
						arg_1096_0 = (num * 1064566403u ^ 2092857606u);
						continue;
					case 39u:
						this.EmoteList.Add(new Emote
						{
							Id = 101,
							EmoteId = 3
						});
						this.EmoteList.Add(new Emote
						{
							Id = 102,
							EmoteId = 3
						});
						this.EmoteList.Add(new Emote
						{
							Id = 107,
							EmoteId = 6
						});
						arg_1096_0 = (num * 977384842u ^ 1300664921u);
						continue;
					case 40u:
						this.EmoteList.Add(new Emote
						{
							Id = 324,
							EmoteId = 1
						});
						this.EmoteList.Add(new Emote
						{
							Id = 325,
							EmoteId = 1
						});
						arg_1096_0 = (num * 438029976u ^ 4097691800u);
						continue;
					case 41u:
						this.EmoteList.Add(new Emote
						{
							Id = 58,
							EmoteId = 17
						});
						arg_1096_0 = (num * 1129476334u ^ 1384260922u);
						continue;
					case 42u:
						this.EmoteList.Add(new Emote
						{
							Id = 406,
							EmoteId = 20
						});
						this.EmoteList.Add(new Emote
						{
							Id = 433,
							EmoteId = 1
						});
						arg_1096_0 = (num * 2600772560u ^ 2077837713u);
						continue;
					case 43u:
						this.EmoteList.Add(new Emote
						{
							Id = 37,
							EmoteId = 7
						});
						arg_1096_0 = (num * 3039431943u ^ 2652790730u);
						continue;
					case 44u:
						this.EmoteList.Add(new Emote
						{
							Id = 264,
							EmoteId = 275
						});
						arg_1096_0 = (num * 1016826721u ^ 2004982134u);
						continue;
					case 45u:
						this.EmoteList.Add(new Emote
						{
							Id = 24,
							EmoteId = 21
						});
						this.EmoteList.Add(new Emote
						{
							Id = 25,
							EmoteId = 6
						});
						this.EmoteList.Add(new Emote
						{
							Id = 26,
							EmoteId = 4
						});
						arg_1096_0 = (num * 928883127u ^ 4103030592u);
						continue;
					case 46u:
						this.EmoteList.Add(new Emote
						{
							Id = 12,
							EmoteId = 24
						});
						this.EmoteList.Add(new Emote
						{
							Id = 17,
							EmoteId = 2
						});
						this.EmoteList.Add(new Emote
						{
							Id = 19,
							EmoteId = 3
						});
						arg_1096_0 = (num * 3080942513u ^ 1159393063u);
						continue;
					case 47u:
						this.EmoteList.Add(new Emote
						{
							Id = 378,
							EmoteId = 7
						});
						arg_1096_0 = (num * 3859871708u ^ 791082682u);
						continue;
					case 48u:
						this.EmoteList.Add(new Emote
						{
							Id = 124,
							EmoteId = 6
						});
						this.EmoteList.Add(new Emote
						{
							Id = 132,
							EmoteId = 479
						});
						arg_1096_0 = (num * 133261945u ^ 1781375818u);
						continue;
					case 49u:
						this.EmoteList.Add(new Emote
						{
							Id = 93,
							EmoteId = 1
						});
						this.EmoteList.Add(new Emote
						{
							Id = 94,
							EmoteId = 5
						});
						arg_1096_0 = (num * 1311885094u ^ 3377101607u);
						continue;
					case 50u:
						this.EmoteList.Add(new Emote
						{
							Id = 47,
							EmoteId = 11
						});
						arg_1096_0 = (num * 1367274857u ^ 508205686u);
						continue;
					case 51u:
						this.EmoteList.Add(new Emote
						{
							Id = 328,
							EmoteId = 24
						});
						arg_1096_0 = (num * 1143844133u ^ 3790230005u);
						continue;
					case 52u:
						this.EmoteList.Add(new Emote
						{
							Id = 95,
							EmoteId = 6
						});
						arg_1096_0 = (num * 3116750435u ^ 3360215427u);
						continue;
					case 53u:
						this.EmoteList.Add(new Emote
						{
							Id = 67,
							EmoteId = 273
						});
						arg_1096_0 = (num * 2799762999u ^ 178461902u);
						continue;
					case 54u:
						this.EmoteList.Add(new Emote
						{
							Id = 55,
							EmoteId = 3
						});
						arg_1096_0 = (num * 2620263892u ^ 808570436u);
						continue;
					case 55u:
						this.EmoteList.Add(new Emote
						{
							Id = 23,
							EmoteId = 11
						});
						arg_1096_0 = (num * 154120020u ^ 917128732u);
						continue;
					case 56u:
						this.EmoteList.Add(new Emote
						{
							Id = 6,
							EmoteId = 24
						});
						arg_1096_0 = (num * 551626148u ^ 2234039218u);
						continue;
					case 57u:
						this.EmoteList.Add(new Emote
						{
							Id = 136,
							EmoteId = 19
						});
						arg_1096_0 = (num * 403777378u ^ 4202562932u);
						continue;
					case 58u:
						this.EmoteList.Add(new Emote
						{
							Id = 82,
							EmoteId = 22
						});
						arg_1096_0 = (num * 1935989534u ^ 2806915022u);
						continue;
					case 59u:
						this.EmoteList.Add(new Emote
						{
							Id = 326,
							EmoteId = 1
						});
						arg_1096_0 = (num * 985577322u ^ 1151179855u);
						continue;
					case 60u:
						this.EmoteList.Add(new Emote
						{
							Id = 32,
							EmoteId = 6
						});
						arg_1096_0 = (num * 289906865u ^ 3244127327u);
						continue;
					case 61u:
						this.EmoteList.Add(new Emote
						{
							Id = 53,
							EmoteId = 3
						});
						arg_1096_0 = (num * 684403862u ^ 3910573083u);
						continue;
					}
					return;
				}
			}
		}

		public void LoadRaces()
		{
			this.ChrRaces.Add(new Races
			{
				Id = 1u,
				MaleDisplayId = 49u,
				FemaleDisplayId = 50u,
				CinematicSequence = 81u,
				Faction = 1u
			});
			this.ChrRaces.Add(new Races
			{
				Id = 2u,
				MaleDisplayId = 51u,
				FemaleDisplayId = 52u,
				CinematicSequence = 21u,
				Faction = 2u
			});
			this.ChrRaces.Add(new Races
			{
				Id = 3u,
				MaleDisplayId = 53u,
				FemaleDisplayId = 54u,
				CinematicSequence = 41u,
				Faction = 3u
			});
			while (true)
			{
				IL_532:
				uint arg_4ED_0 = 2844743432u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4ED_0 ^ 3663340779u)) % 14u)
					{
					case 0u:
						this.ChrRaces.Add(new Races
						{
							Id = 29u,
							MaleDisplayId = 75082u,
							FemaleDisplayId = 75083u,
							CinematicSequence = 0u,
							Faction = 4u
						});
						this.ChrRaces.Add(new Races
						{
							Id = 30u,
							MaleDisplayId = 75084u,
							FemaleDisplayId = 75085u,
							CinematicSequence = 0u,
							Faction = 1629u
						});
						arg_4ED_0 = (num * 3899624556u ^ 578884844u);
						continue;
					case 2u:
						this.ChrRaces.Add(new Races
						{
							Id = 5u,
							MaleDisplayId = 57u,
							FemaleDisplayId = 58u,
							CinematicSequence = 2u,
							Faction = 5u
						});
						arg_4ED_0 = (num * 3849523252u ^ 3668419392u);
						continue;
					case 3u:
						this.ChrRaces.Add(new Races
						{
							Id = 4u,
							MaleDisplayId = 55u,
							FemaleDisplayId = 56u,
							CinematicSequence = 61u,
							Faction = 4u
						});
						arg_4ED_0 = (num * 1634226968u ^ 2493302219u);
						continue;
					case 4u:
						this.ChrRaces.Add(new Races
						{
							Id = 9u,
							MaleDisplayId = 6894u,
							FemaleDisplayId = 6895u,
							CinematicSequence = 172u,
							Faction = 2204u
						});
						arg_4ED_0 = (num * 2619368077u ^ 3772967955u);
						continue;
					case 5u:
						this.ChrRaces.Add(new Races
						{
							Id = 22u,
							MaleDisplayId = 29422u,
							FemaleDisplayId = 29423u,
							CinematicSequence = 170u,
							Faction = 2203u
						});
						arg_4ED_0 = (num * 2046422190u ^ 792325859u);
						continue;
					case 6u:
						this.ChrRaces.Add(new Races
						{
							Id = 10u,
							MaleDisplayId = 15476u,
							FemaleDisplayId = 15475u,
							CinematicSequence = 162u,
							Faction = 1610u
						});
						arg_4ED_0 = (num * 2372201018u ^ 2396748051u);
						continue;
					case 7u:
						this.ChrRaces.Add(new Races
						{
							Id = 6u,
							MaleDisplayId = 59u,
							FemaleDisplayId = 60u,
							CinematicSequence = 141u,
							Faction = 6u
						});
						arg_4ED_0 = (num * 3362953633u ^ 3896888015u);
						continue;
					case 8u:
						this.ChrRaces.Add(new Races
						{
							Id = 11u,
							MaleDisplayId = 16125u,
							FemaleDisplayId = 16126u,
							CinematicSequence = 163u,
							Faction = 1629u
						});
						arg_4ED_0 = (num * 2041017202u ^ 903895460u);
						continue;
					case 9u:
						this.ChrRaces.Add(new Races
						{
							Id = 7u,
							MaleDisplayId = 1563u,
							FemaleDisplayId = 1564u,
							CinematicSequence = 101u,
							Faction = 115u
						});
						arg_4ED_0 = (num * 2116441773u ^ 4134192853u);
						continue;
					case 10u:
						this.ChrRaces.Add(new Races
						{
							Id = 24u,
							MaleDisplayId = 38551u,
							FemaleDisplayId = 38552u,
							CinematicSequence = 259u,
							Faction = 2395u
						});
						arg_4ED_0 = (num * 3765964621u ^ 2300467412u);
						continue;
					case 11u:
						this.ChrRaces.Add(new Races
						{
							Id = 27u,
							MaleDisplayId = 75078u,
							FemaleDisplayId = 75079u,
							CinematicSequence = 259u,
							Faction = 1610u
						});
						this.ChrRaces.Add(new Races
						{
							Id = 28u,
							MaleDisplayId = 75080u,
							FemaleDisplayId = 75081u,
							CinematicSequence = 0u,
							Faction = 6u
						});
						arg_4ED_0 = (num * 2697379296u ^ 486200463u);
						continue;
					case 12u:
						goto IL_532;
					case 13u:
						this.ChrRaces.Add(new Races
						{
							Id = 8u,
							MaleDisplayId = 1478u,
							FemaleDisplayId = 1479u,
							CinematicSequence = 121u,
							Faction = 116u
						});
						arg_4ED_0 = (num * 4236021631u ^ 237223990u);
						continue;
					}
					return;
				}
			}
		}

		public void StartRangeUpdateTimers()
		{
			Thread expr_11 = WorldManager.smethod_14(new ThreadStart(this.UpdateTask));
			WorldManager.smethod_15(expr_11, true);
			WorldManager.smethod_16(expr_11);
		}

		private void UpdateTask()
		{
			while (true)
			{
				object object_ = WorldManager.taskObject;
				bool flag = false;
				try
				{
					WorldManager.smethod_17(object_, ref flag);
					WorldManager.smethod_18(50);
					using (List<KeyValuePair<ulong, WorldClass>>.Enumerator enumerator = this.Sessions.ToList<KeyValuePair<ulong, WorldClass>>().GetEnumerator())
					{
						while (true)
						{
							IL_D0:
							int arg_A4_0 = enumerator.MoveNext() ? 961296191 : 1040266866;
							while (true)
							{
								switch ((arg_A4_0 ^ 665094178) % 4)
								{
								case 1:
								{
									KeyValuePair<ulong, WorldClass> current = enumerator.Current;
									WorldClass value = current.Value;
									Character character = value.Character;
									this.WriteInRangeObjects(Manager.SpawnMgr.GetInRangeCreatures(character), value, ObjectType.Unit);
									this.WriteInRangeObjects(Manager.SpawnMgr.GetInRangeObjects(character), value, ObjectType.GameObject);
									this.WriteOutOfRangeObjects(Manager.SpawnMgr.GetOutOfRangeCreatures(character), value);
									arg_A4_0 = 661127700;
									continue;
								}
								case 2:
									goto IL_D0;
								case 3:
									arg_A4_0 = 961296191;
									continue;
								}
								goto Block_4;
							}
						}
						Block_4:;
					}
				}
				finally
				{
					if (flag)
					{
						while (true)
						{
							IL_128:
							uint arg_10F_0 = 28277465u;
							while (true)
							{
								uint num;
								switch ((num = (arg_10F_0 ^ 665094178u)) % 3u)
								{
								case 0u:
									goto IL_128;
								case 2u:
									WorldManager.smethod_19(object_);
									arg_10F_0 = (num * 50070957u ^ 75260493u);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
			}
		}

		public bool AddSession(ulong guid, ref WorldClass session)
		{
			return this.Sessions.TryAdd(guid, session);
		}

		public WorldClass DeleteSession(ulong guid)
		{
			WorldClass result;
			this.Sessions.TryRemove(guid, out result);
			return result;
		}

		public WorldClass GetSession(string name)
		{
			IEnumerator<KeyValuePair<ulong, WorldClass>> enumerator = this.Sessions.GetEnumerator();
			try
			{
				WorldClass value;
				while (true)
				{
					IL_AC:
					uint arg_79_0 = WorldManager.smethod_21(enumerator) ? 1123578797u : 80446224u;
					while (true)
					{
						uint num;
						switch ((num = (arg_79_0 ^ 906019294u)) % 6u)
						{
						case 1u:
							goto IL_AC;
						case 2u:
							goto IL_BB;
						case 3u:
						{
							KeyValuePair<ulong, WorldClass> current = enumerator.Current;
							arg_79_0 = (WorldManager.smethod_20(current.Value.Character.Name, name) ? 204615514u : 757521103u);
							continue;
						}
						case 4u:
						{
							KeyValuePair<ulong, WorldClass> current;
							value = current.Value;
							arg_79_0 = (num * 1777530322u ^ 1277159314u);
							continue;
						}
						case 5u:
							arg_79_0 = 1123578797u;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				goto IL_FA;
				IL_BB:
				return value;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_F2:
						uint arg_DA_0 = 325433707u;
						while (true)
						{
							uint num;
							switch ((num = (arg_DA_0 ^ 906019294u)) % 3u)
							{
							case 1u:
								WorldManager.smethod_12(enumerator);
								arg_DA_0 = (num * 3562700384u ^ 864247161u);
								continue;
							case 2u:
								goto IL_F2;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			IL_FA:
			return null;
		}

		public WorldClass GetSession(ulong guid)
		{
			WorldClass result;
			if (this.Sessions.TryGetValue(guid, out result))
			{
				return result;
			}
			return null;
		}

		public bool AddSession2(ulong guid, ref WorldClass2 session)
		{
			return this.Sessions2.TryAdd(guid, session);
		}

		public WorldClass2 DeleteSession2(ulong guid)
		{
			WorldClass2 result;
			this.Sessions2.TryRemove(guid, out result);
			return result;
		}

		public WorldClass2 GetSession2(string name)
		{
			IEnumerator<KeyValuePair<ulong, WorldClass2>> enumerator = this.Sessions2.GetEnumerator();
			try
			{
				KeyValuePair<ulong, WorldClass2> current;
				while (true)
				{
					IL_A4:
					uint arg_71_0 = WorldManager.smethod_21(enumerator) ? 2804172031u : 3884806164u;
					while (true)
					{
						uint num;
						switch ((num = (arg_71_0 ^ 3663131711u)) % 6u)
						{
						case 0u:
							arg_71_0 = 2804172031u;
							continue;
						case 1u:
							goto IL_B1;
						case 2u:
							arg_71_0 = ((WorldManager.smethod_20(current.Value.Character.Name, name) ? 587633784u : 1054374254u) ^ num * 2411786678u);
							continue;
						case 3u:
							goto IL_A4;
						case 4u:
							current = enumerator.Current;
							arg_71_0 = 3002903789u;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				goto IL_BB;
				IL_B1:
				return current.Value;
				IL_BB:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_F2:
						uint arg_DA_0 = 2350916655u;
						while (true)
						{
							uint num;
							switch ((num = (arg_DA_0 ^ 3663131711u)) % 3u)
							{
							case 0u:
								goto IL_F2;
							case 2u:
								WorldManager.smethod_12(enumerator);
								arg_DA_0 = (num * 488464690u ^ 3685562903u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			return null;
		}

		public WorldClass2 GetSession2(ulong guid)
		{
			WorldClass2 result;
			if (this.Sessions2.TryGetValue(0uL, out result))
			{
				return result;
			}
			return null;
		}

		public WorldClass2 GetSession2()
		{
			return this.Sessions2.First<KeyValuePair<ulong, WorldClass2>>().Value;
		}

		public void WriteCreateObject(ref PacketWriter updateObject, WorldObject obj, UpdateFlag updateFlags, ObjectType type)
		{
			updateObject.WriteUInt8(1);
			while (true)
			{
				IL_126:
				uint arg_F5_0 = 674662183u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F5_0 ^ 145398461u)) % 9u)
					{
					case 0u:
						arg_F5_0 = ((type != ObjectType.Unit) ? 1990474711u : 1061379083u);
						continue;
					case 2u:
						arg_F5_0 = (((type == ObjectType.GameObject) ? 131431087u : 1498186933u) ^ num * 2612077386u);
						continue;
					case 3u:
						updateObject.WriteSmartGuid(obj.Guid, global::GuidType.Player);
						arg_F5_0 = (num * 3017626571u ^ 983361560u);
						continue;
					case 4u:
						goto IL_126;
					case 5u:
						updateObject.WriteSmartGuid(obj.SGuid);
						arg_F5_0 = 1641718289u;
						continue;
					case 6u:
						obj.WriteUpdateFields(ref updateObject);
						obj.WriteDynamicUpdateFields(ref updateObject);
						arg_F5_0 = (num * 4147143403u ^ 515290481u);
						continue;
					case 7u:
						updateObject.WriteUInt8((byte)type);
						Manager.WorldMgr.WriteUpdateObjectMovement(ref updateObject, ref obj, updateFlags, type);
						obj.SetUpdateFields();
						arg_F5_0 = 1130912710u;
						continue;
					case 8u:
						arg_F5_0 = (((type != ObjectType.Player) ? 2708534600u : 3055127722u) ^ num * 3889688142u);
						continue;
					}
					return;
				}
			}
		}

		private void WriteInRangeObjects(IEnumerable<WorldObject> objects, WorldClass session, ObjectType type)
		{
			Character character = session.Character;
			UpdateFlag updateFlags;
			while (true)
			{
				IL_43:
				int arg_2A_0 = 1234824824;
				while (true)
				{
					switch ((arg_2A_0 ^ 985693193) % 3)
					{
					case 1:
					{
						int arg_1B_0 = objects.Count<WorldObject>();
						if (type != ObjectType.GameObject)
						{
							updateFlags = UpdateFlag.Alive;
						}
						else
						{
							updateFlags = (UpdateFlag.Rotation | UpdateFlag.StationaryPosition);
						}
						if (arg_1B_0 > 0)
						{
							arg_2A_0 = 806033563;
							continue;
						}
						return;
					}
					case 2:
						goto IL_43;
					}
					goto Block_3;
				}
			}
			Block_3:
			IEnumerator<WorldObject> enumerator = objects.GetEnumerator();
			try
			{
				while (true)
				{
					IL_282:
					uint arg_225_0 = (!WorldManager.smethod_21(enumerator)) ? 924584528u : 1822438603u;
					while (true)
					{
						uint num;
						switch ((num = (arg_225_0 ^ 985693193u)) % 16u)
						{
						case 0u:
						{
							WorldObject current;
							arg_225_0 = (((!character.InRangeObjects.ContainsKey(current.Guid)) ? 3520304230u : 2991050421u) ^ num * 3218604820u);
							continue;
						}
						case 1u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteUInt8(0);
							packetWriter.WriteInt32(0);
							arg_225_0 = (num * 1971030994u ^ 185807692u);
							continue;
						}
						case 2u:
						{
							WorldObject current = enumerator.Current;
							PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
							arg_225_0 = 628504039u;
							continue;
						}
						case 3u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteUInt16((ushort)character.Map);
							arg_225_0 = (num * 3400387387u ^ 2257466905u);
							continue;
						}
						case 4u:
							goto IL_282;
						case 5u:
						{
							PacketWriter packetWriter;
							uint data;
							packetWriter.WriteUInt32Pos(data, 13);
							arg_225_0 = (num * 2454347700u ^ 1429499287u);
							continue;
						}
						case 6u:
						{
							WorldObject current;
							arg_225_0 = (((character.Guid != current.Guid) ? 3687278576u : 3094749975u) ^ num * 4233083803u);
							continue;
						}
						case 7u:
						{
							WorldObject current;
							WorldObject worldObject = current;
							arg_225_0 = (num * 2094950269u ^ 583101170u);
							continue;
						}
						case 8u:
							arg_225_0 = 1822438603u;
							continue;
						case 10u:
						{
							PacketWriter packetWriter;
							session.Send(ref packetWriter);
							arg_225_0 = (num * 4007941317u ^ 1157130079u);
							continue;
						}
						case 11u:
						{
							WorldObject worldObject;
							character.InRangeObjects.Add(worldObject.Guid, worldObject);
							arg_225_0 = 964864693u;
							continue;
						}
						case 12u:
						{
							PacketWriter packetWriter;
							uint data = (uint)WorldManager.smethod_23(WorldManager.smethod_22(packetWriter)) - 17u;
							arg_225_0 = 733619068u;
							continue;
						}
						case 13u:
						{
							WorldObject current;
							arg_225_0 = (((!(current is Character)) ? 1739856535u : 1828267210u) ^ num * 2159438873u);
							continue;
						}
						case 14u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteInt32(1);
							arg_225_0 = (num * 24512047u ^ 1709481080u);
							continue;
						}
						case 15u:
						{
							PacketWriter packetWriter;
							WorldObject worldObject;
							this.WriteCreateObject(ref packetWriter, worldObject, updateFlags, type);
							arg_225_0 = (num * 208065683u ^ 1445449785u);
							continue;
						}
						}
						goto Block_9;
					}
				}
				Block_9:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_2C8:
						uint arg_2AF_0 = 571821702u;
						while (true)
						{
							uint num;
							switch ((num = (arg_2AF_0 ^ 985693193u)) % 3u)
							{
							case 0u:
								goto IL_2C8;
							case 1u:
								WorldManager.smethod_12(enumerator);
								arg_2AF_0 = (num * 2789025238u ^ 661065302u);
								continue;
							}
							goto Block_13;
						}
					}
					Block_13:;
				}
			}
		}

		public void WriteOutOfRangeObjects(IEnumerable<WorldObject> objects, WorldClass session)
		{
			Character character = session.Character;
			int num = objects.Count<WorldObject>();
			while (true)
			{
				IL_43:
				uint arg_2A_0 = 693627332u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2A_0 ^ 21199706u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 1u:
						if (num > 0)
						{
							arg_2A_0 = (num2 * 2386250042u ^ 475668437u);
							continue;
						}
						return;
					}
					goto Block_2;
				}
			}
			Block_2:
			IEnumerator<WorldObject> enumerator = objects.GetEnumerator();
			try
			{
				while (true)
				{
					IL_1D7:
					uint arg_196_0 = (!WorldManager.smethod_21(enumerator)) ? 1433957386u : 899731421u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_196_0 ^ 21199706u)) % 9u)
						{
						case 0u:
						{
							PacketWriter packetWriter;
							session.Send(ref packetWriter);
							arg_196_0 = (num2 * 2193315011u ^ 3754142677u);
							continue;
						}
						case 1u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteUInt32((uint)num);
							arg_196_0 = (num2 * 3660954480u ^ 3218481449u);
							continue;
						}
						case 2u:
							goto IL_1D7;
						case 3u:
						{
							WorldObject current = enumerator.Current;
							arg_196_0 = 1035913311u;
							continue;
						}
						case 4u:
						{
							PacketWriter packetWriter;
							WorldObject current;
							packetWriter.WriteSmartGuid(current.SGuid);
							packetWriter.WriteInt32(0);
							character.InRangeObjects.Remove(current.Guid);
							CreatureSpawn spawn = Manager.SpawnMgr.FindSpawn(current.Guid);
							Manager.SpawnMgr.RemoveSpawn(spawn, false);
							arg_196_0 = (num2 * 1433764750u ^ 3590980830u);
							continue;
						}
						case 5u:
						{
							PacketWriter packetWriter = new PacketWriter(ServerMessage.ObjectUpdate, true);
							BitPack arg_E0_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
							packetWriter.WriteUInt32(0u);
							packetWriter.WriteUInt16((ushort)character.Map);
							arg_E0_0.Write<bool>(true);
							arg_E0_0.Flush();
							arg_196_0 = (num2 * 4148304612u ^ 867955073u);
							continue;
						}
						case 6u:
							arg_196_0 = 899731421u;
							continue;
						case 8u:
						{
							PacketWriter packetWriter;
							packetWriter.WriteUInt16((ushort)character.Map);
							arg_196_0 = (num2 * 4287648869u ^ 736804586u);
							continue;
						}
						}
						goto Block_5;
					}
				}
				Block_5:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_21D:
						uint arg_204_0 = 239391907u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_204_0 ^ 21199706u)) % 3u)
							{
							case 0u:
								goto IL_21D;
							case 2u:
								WorldManager.smethod_12(enumerator);
								arg_204_0 = (num2 * 1157515060u ^ 2781673789u);
								continue;
							}
							goto Block_9;
						}
					}
					Block_9:;
				}
			}
		}

		[IteratorStateMachine(typeof(WorldManager.<GetInRangeCharacter>d__32))]
		public IEnumerable<Character> GetInRangeCharacter(WorldObject obj)
		{
			WorldManager.<GetInRangeCharacter>d__32 expr_07 = new WorldManager.<GetInRangeCharacter>d__32(-2);
			expr_07.__4__this = this;
			expr_07.__3__obj = obj;
			return expr_07;
		}

		[IteratorStateMachine(typeof(WorldManager.<GetOutOfRangeCharacter>d__33))]
		public IEnumerable<Character> GetOutOfRangeCharacter(WorldObject obj)
		{
			WorldManager.<GetOutOfRangeCharacter>d__33 expr_07 = new WorldManager.<GetOutOfRangeCharacter>d__33(-2);
			expr_07.__4__this = this;
			expr_07.__3__obj = obj;
			return expr_07;
		}

		public void SendByDist(WorldObject obj, PacketWriter packet, float dist)
		{
			IEnumerator<KeyValuePair<ulong, WorldClass>> enumerator = this.Sessions.GetEnumerator();
			try
			{
				while (true)
				{
					IL_AA:
					uint arg_7B_0 = WorldManager.smethod_21(enumerator) ? 2458791872u : 3517714363u;
					while (true)
					{
						uint num;
						switch ((num = (arg_7B_0 ^ 4117508765u)) % 5u)
						{
						case 0u:
							goto IL_AA;
						case 1u:
						{
							KeyValuePair<ulong, WorldClass> current = enumerator.Current;
							arg_7B_0 = (obj.CheckDistance(current.Value.Character, dist) ? 3560768156u : 2549315586u);
							continue;
						}
						case 3u:
						{
							KeyValuePair<ulong, WorldClass> current;
							current.Value.Send(ref packet);
							arg_7B_0 = (num * 2408584879u ^ 3353124525u);
							continue;
						}
						case 4u:
							arg_7B_0 = 2458791872u;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_EE:
						uint arg_D6_0 = 4040458552u;
						while (true)
						{
							uint num;
							switch ((num = (arg_D6_0 ^ 4117508765u)) % 3u)
							{
							case 0u:
								goto IL_EE;
							case 2u:
								WorldManager.smethod_12(enumerator);
								arg_D6_0 = (num * 61350925u ^ 2293884979u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
		}

		public void SendByDist2(WorldObject obj, PacketWriter packet, float dist)
		{
			IEnumerator<KeyValuePair<ulong, WorldClass2>> enumerator = this.Sessions2.GetEnumerator();
			try
			{
				while (true)
				{
					IL_BD:
					uint arg_8A_0 = WorldManager.smethod_21(enumerator) ? 40362623u : 2011750552u;
					while (true)
					{
						uint num;
						switch ((num = (arg_8A_0 ^ 204828737u)) % 6u)
						{
						case 0u:
							arg_8A_0 = 40362623u;
							continue;
						case 1u:
						{
							KeyValuePair<ulong, WorldClass2> current;
							arg_8A_0 = ((obj.CheckDistance(current.Value.Character, dist) ? 3596064837u : 2379713056u) ^ num * 4178867009u);
							continue;
						}
						case 2u:
							goto IL_BD;
						case 4u:
						{
							KeyValuePair<ulong, WorldClass2> current = enumerator.Current;
							arg_8A_0 = 1216636346u;
							continue;
						}
						case 5u:
						{
							KeyValuePair<ulong, WorldClass2> current;
							current.Value.Send(ref packet);
							arg_8A_0 = (num * 2413282981u ^ 105961856u);
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
				if (enumerator != null)
				{
					while (true)
					{
						IL_101:
						uint arg_E9_0 = 622670937u;
						while (true)
						{
							uint num;
							switch ((num = (arg_E9_0 ^ 204828737u)) % 3u)
							{
							case 0u:
								goto IL_101;
							case 2u:
								WorldManager.smethod_12(enumerator);
								arg_E9_0 = (num * 561996056u ^ 3528409004u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
		}

		public void WriteAccountDataTimes(AccountDataMasks mask, ref WorldClass session, bool meh = false)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.AccountDataTimes, true);
			while (true)
			{
				IL_143:
				uint arg_10A_0 = 3668158452u;
				while (true)
				{
					uint num;
					switch ((num = (arg_10A_0 ^ 4025612247u)) % 11u)
					{
					case 0u:
						arg_10A_0 = (num * 1971086703u ^ 2146890618u);
						continue;
					case 1u:
						goto IL_69;
					case 2u:
						packetWriter.WriteSmartGuid(session.Character.Guid, global::GuidType.Player);
						Log.Message(LogType.Debug, WorldManager.smethod_24(Module.smethod_33<string>(3670714664u), session.Character.Guid), Array.Empty<object>());
						packetWriter.WriteUnixTime();
						arg_10A_0 = (num * 3181084677u ^ 775392923u);
						continue;
					case 3u:
						goto IL_7A;
					case 4u:
						goto IL_143;
					case 5u:
					{
						int num2;
						arg_10A_0 = ((num2 < 8) ? 3491153182u : 4111038315u);
						continue;
					}
					case 6u:
					{
						int num2;
						switch (num2)
						{
						case 0:
						case 2:
						case 4:
							goto IL_7A;
						case 1:
						case 3:
							goto IL_69;
						default:
							arg_10A_0 = 4026970799u;
							continue;
						}
						break;
					}
					case 7u:
					{
						int num2;
						num2++;
						arg_10A_0 = 2290808960u;
						continue;
					}
					case 9u:
					{
						int num2 = 0;
						arg_10A_0 = (num * 2213661120u ^ 3147778097u);
						continue;
					}
					case 10u:
						arg_10A_0 = (num * 2365755116u ^ 2832131068u);
						continue;
					}
					goto Block_3;
					IL_69:
					packetWriter.WriteUInt32(0u);
					arg_10A_0 = 4158533852u;
					continue;
					IL_7A:
					packetWriter.WriteUInt32(0u);
					arg_10A_0 = 4158533852u;
				}
			}
			Block_3:
			session.Send(ref packetWriter);
		}

		public void SendToInRangeCharacter(Character pChar, PacketWriter packet)
		{
			using (List<KeyValuePair<ulong, WorldClass>>.Enumerator enumerator = this.Sessions.ToList<KeyValuePair<ulong, WorldClass>>().GetEnumerator())
			{
				while (true)
				{
					IL_CE:
					uint arg_9B_0 = enumerator.MoveNext() ? 1328269498u : 508812519u;
					while (true)
					{
						uint num;
						switch ((num = (arg_9B_0 ^ 1311648729u)) % 6u)
						{
						case 0u:
						{
							KeyValuePair<ulong, WorldClass> current;
							current.Value.Send(ref packet);
							arg_9B_0 = (num * 1624707868u ^ 1707921748u);
							continue;
						}
						case 1u:
							goto IL_CE;
						case 2u:
							arg_9B_0 = 1328269498u;
							continue;
						case 3u:
						{
							KeyValuePair<ulong, WorldClass> current;
							WorldObject worldObject;
							arg_9B_0 = (((!pChar.InRangeObjects.TryGetValue(current.Value.Character.Guid, out worldObject)) ? 969593120u : 80473267u) ^ num * 488022060u);
							continue;
						}
						case 5u:
						{
							KeyValuePair<ulong, WorldClass> current = enumerator.Current;
							arg_9B_0 = 130797068u;
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
		}

		public void WriteUpdateObjectMovement(ref PacketWriter packet, ref WorldObject wObject, UpdateFlag updateFlags, ObjectType type = ObjectType.Player)
		{
			ObjectMovementValues objectMovementValues = new ObjectMovementValues(updateFlags);
			while (true)
			{
				IL_6CC:
				uint arg_60F_0 = 129998000u;
				while (true)
				{
					uint num;
					switch ((num = (arg_60F_0 ^ 1215747490u)) % 44u)
					{
					case 0u:
						goto IL_4B9;
					case 1u:
						arg_60F_0 = (((type == ObjectType.Unit) ? 1762629752u : 624449284u) ^ num * 3921122461u);
						continue;
					case 2u:
						packet.WriteFloat(wObject.Position.O);
						packet.WriteFloat(0f);
						arg_60F_0 = (num * 1090892758u ^ 3245297273u);
						continue;
					case 3u:
						packet.WriteFloat(wObject.Position.Y);
						arg_60F_0 = (num * 787746376u ^ 972146496u);
						continue;
					case 4u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						arg_60F_0 = (num * 1192361361u ^ 3230239995u);
						continue;
					}
					case 5u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						arg_60F_0 = (num * 4071676343u ^ 4233786399u);
						continue;
					}
					case 6u:
						objectMovementValues.MovementFlags |= MovementFlag.Collision;
						arg_60F_0 = (num * 3125468036u ^ 4201600533u);
						continue;
					case 7u:
						arg_60F_0 = (objectMovementValues.HasRotation ? 783855162u : 461242124u);
						continue;
					case 8u:
						packet.WriteFloat(wObject.Position.Y);
						arg_60F_0 = (num * 1872323493u ^ 3277724555u);
						continue;
					case 9u:
					{
						packet.WriteUInt32(0u);
						packet.WriteUInt32(0u);
						CreatureSpawn expr_49A = wObject as CreatureSpawn;
						if (expr_49A != null && expr_49A.Id == 114791)
						{
							arg_60F_0 = 1626558302u;
							continue;
						}
						goto IL_4B9;
					}
					case 10u:
					{
						BitPack bitPack = new BitPack(packet, 0uL, 0uL, 0uL, 0uL);
						arg_60F_0 = (num * 144501222u ^ 3352292114u);
						continue;
					}
					case 11u:
					{
						BitPack bitPack;
						bitPack.Write<uint>((uint)objectMovementValues.MovementFlags, 30);
						arg_60F_0 = 333079794u;
						continue;
					}
					case 12u:
						packet.WriteUInt32(0u);
						arg_60F_0 = (objectMovementValues.HasStationaryPosition ? 1407329u : 702657881u);
						continue;
					case 13u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Write<bool>(objectMovementValues.IsSelf);
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Flush();
						arg_60F_0 = (num * 958593297u ^ 3636374212u);
						continue;
					}
					case 14u:
						packet.WriteFloat(MovementSpeed.FlyBackSpeed);
						arg_60F_0 = (num * 4195910354u ^ 2408132270u);
						continue;
					case 15u:
						packet.WriteFloat(wObject.Position.X);
						arg_60F_0 = (num * 1628950764u ^ 1220746505u);
						continue;
					case 16u:
						packet.WriteFloat(MovementSpeed.RunBackSpeed);
						arg_60F_0 = (num * 2555421199u ^ 3184962399u);
						continue;
					case 17u:
						packet.WriteFloat(wObject.Position.Z);
						arg_60F_0 = (num * 3121449693u ^ 238152381u);
						continue;
					case 18u:
						packet.WriteFloat(wObject.Position.Z);
						packet.WriteFloat(wObject.Position.O);
						arg_60F_0 = (num * 1251600730u ^ 3521839613u);
						continue;
					case 19u:
						arg_60F_0 = (((type != ObjectType.GameObject) ? 3315887855u : 3604501638u) ^ num * 713846617u);
						continue;
					case 20u:
						packet.WriteFloat(MovementSpeed.TurnSpeed);
						arg_60F_0 = (num * 769968778u ^ 1298751733u);
						continue;
					case 21u:
						packet.WriteFloat(MovementSpeed.RunSpeed);
						arg_60F_0 = (num * 1508763429u ^ 2576139551u);
						continue;
					case 23u:
					{
						packet.WriteFloat(MovementSpeed.PitchSpeed);
						packet.WriteUInt32(0u);
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Flush();
						arg_60F_0 = (num * 1702723272u ^ 4258413466u);
						continue;
					}
					case 24u:
						packet.WriteUInt32(0u);
						arg_60F_0 = 1412853704u;
						continue;
					case 25u:
						packet.WriteFloat(MovementSpeed.WalkSpeed);
						arg_60F_0 = (num * 1472905094u ^ 1122743905u);
						continue;
					case 26u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Flush();
						arg_60F_0 = (num * 1681626296u ^ 2014118735u);
						continue;
					}
					case 27u:
						arg_60F_0 = (((!objectMovementValues.IsAlive) ? 2584000468u : 2545470181u) ^ num * 3029667794u);
						continue;
					case 28u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_60F_0 = (num * 3984996728u ^ 2662328856u);
						continue;
					}
					case 29u:
						packet.WriteFloat(MovementSpeed.SwimBackSpeed);
						arg_60F_0 = (num * 298942841u ^ 3422764309u);
						continue;
					case 30u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Write<bool>(objectMovementValues.HasRotation);
						arg_60F_0 = (num * 599397252u ^ 1918635711u);
						continue;
					}
					case 31u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(objectMovementValues.HasStationaryPosition);
						arg_60F_0 = (num * 1497745409u ^ 1763630698u);
						continue;
					}
					case 32u:
						objectMovementValues.MovementFlags = MovementFlag.Gravity;
						arg_60F_0 = (num * 868046579u ^ 4244940630u);
						continue;
					case 33u:
						packet.WriteFloat(MovementSpeed.SwimSpeed);
						arg_60F_0 = (num * 628557227u ^ 1283953472u);
						continue;
					case 34u:
						packet.WriteFloat(MovementSpeed.FlySpeed);
						arg_60F_0 = (num * 594481187u ^ 1398282350u);
						continue;
					case 35u:
						packet.WriteFloat(0f);
						arg_60F_0 = (num * 2961737432u ^ 787087167u);
						continue;
					case 36u:
						packet.WriteInt64(Quaternion.GetCompressed(wObject.Position.O));
						arg_60F_0 = (num * 1693518408u ^ 2944617932u);
						continue;
					case 37u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(objectMovementValues.IsAlive);
						bitPack.Write<int>(0);
						arg_60F_0 = (num * 1103236590u ^ 736974011u);
						continue;
					}
					case 38u:
						packet.WriteFloat(wObject.Position.X);
						arg_60F_0 = (num * 3011618815u ^ 150330436u);
						continue;
					case 39u:
						packet.WriteSmartGuid(wObject.SGuid);
						arg_60F_0 = 1647713622u;
						continue;
					case 40u:
					{
						BitPack bitPack;
						bitPack.Write<uint>((uint)objectMovementValues.MovementFlags2, 18);
						arg_60F_0 = (num * 887354071u ^ 4121645171u);
						continue;
					}
					case 41u:
						goto IL_6CC;
					case 42u:
						packet.WriteSmartGuid(wObject.Guid, global::GuidType.Player);
						arg_60F_0 = 1647713622u;
						continue;
					case 43u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_60F_0 = (num * 3024857735u ^ 3973602051u);
						continue;
					}
					}
					return;
					IL_4B9:
					arg_60F_0 = ((wObject is CreatureSpawn) ? 1468379108u : 219133965u);
				}
			}
		}

		public void SendHotfixes(WorldClass session)
		{
			List<string> list = new List<string>();
			StreamReader streamReader = WorldManager.smethod_7(WorldManager.smethod_6(WorldManager.smethod_5(), Module.smethod_36<string>(1335227554u)));
			try
			{
				while (true)
				{
					IL_76:
					int arg_4D_0 = (!WorldManager.smethod_11(streamReader)) ? -1821766704 : -1918179255;
					while (true)
					{
						switch ((arg_4D_0 ^ -943006534) % 4)
						{
						case 0:
							arg_4D_0 = -1821766704;
							continue;
						case 1:
							goto IL_76;
						case 2:
							list.Add(WorldManager.smethod_8(streamReader));
							arg_4D_0 = -2045482233;
							continue;
						}
						goto Block_31;
					}
				}
				Block_31:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_B9:
						uint arg_A0_0 = 4282511890u;
						while (true)
						{
							uint num;
							switch ((num = (arg_A0_0 ^ 3351960762u)) % 3u)
							{
							case 1u:
								WorldManager.smethod_12(streamReader);
								arg_A0_0 = (num * 675983878u ^ 1158056770u);
								continue;
							case 2u:
								goto IL_B9;
							}
							goto Block_35;
						}
					}
					Block_35:;
				}
			}
			List<string> list2 = new List<string>();
			StreamReader streamReader2 = WorldManager.smethod_7(WorldManager.smethod_6(WorldManager.smethod_5(), Module.smethod_37<string>(4149292156u)));
			try
			{
				while (true)
				{
					IL_137:
					int arg_10E_0 = WorldManager.smethod_11(streamReader2) ? -263276491 : -1168098321;
					while (true)
					{
						switch ((arg_10E_0 ^ -943006534) % 4)
						{
						case 0:
							arg_10E_0 = -1168098321;
							continue;
						case 1:
							list2.Add(WorldManager.smethod_8(streamReader2));
							arg_10E_0 = -138331108;
							continue;
						case 2:
							goto IL_137;
						}
						goto Block_37;
					}
				}
				Block_37:;
			}
			finally
			{
				if (streamReader2 != null)
				{
					while (true)
					{
						IL_17A:
						uint arg_161_0 = 4002669197u;
						while (true)
						{
							uint num;
							switch ((num = (arg_161_0 ^ 3351960762u)) % 3u)
							{
							case 1u:
								WorldManager.smethod_12(streamReader2);
								arg_161_0 = (num * 2460620703u ^ 2420999515u);
								continue;
							case 2u:
								goto IL_17A;
							}
							goto Block_41;
						}
					}
					Block_41:;
				}
			}
			List<string> list3 = new List<string>();
			StreamReader streamReader3 = WorldManager.smethod_7(WorldManager.smethod_6(WorldManager.smethod_5(), Module.smethod_34<string>(808308818u)));
			try
			{
				while (true)
				{
					IL_1FC:
					int arg_1D3_0 = WorldManager.smethod_11(streamReader3) ? -1478501989 : -286397264;
					while (true)
					{
						switch ((arg_1D3_0 ^ -943006534) % 4)
						{
						case 0:
							arg_1D3_0 = -286397264;
							continue;
						case 2:
							list3.Add(WorldManager.smethod_8(streamReader3));
							arg_1D3_0 = -323844719;
							continue;
						case 3:
							goto IL_1FC;
						}
						goto Block_43;
					}
				}
				Block_43:;
			}
			finally
			{
				if (streamReader3 != null)
				{
					while (true)
					{
						IL_242:
						uint arg_229_0 = 3819996849u;
						while (true)
						{
							uint num;
							switch ((num = (arg_229_0 ^ 3351960762u)) % 3u)
							{
							case 1u:
								WorldManager.smethod_12(streamReader3);
								arg_229_0 = (num * 159726851u ^ 558385827u);
								continue;
							case 2u:
								goto IL_242;
							}
							goto Block_47;
						}
					}
					Block_47:;
				}
			}
			KeyValuePair<string, string[]>[] arg_29D_0 = new Dictionary<string, string[]>
			{
				{
					Module.smethod_36<string>(2845959532u),
					list.ToArray()
				},
				{
					Module.smethod_37<string>(3973992180u),
					list2.ToArray()
				},
				{
					Module.smethod_33<string>(2366910524u),
					list3.ToArray()
				}
			}.ToArray<KeyValuePair<string, string[]>>();
			new List<HotfixEntry>();
			KeyValuePair<string, string[]>[] array = arg_29D_0;
			while (true)
			{
				IL_DE5:
				uint arg_CB3_0 = 4114314167u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CB3_0 ^ 3351960762u)) % 73u)
					{
					case 0u:
					{
						int num2;
						num2++;
						arg_CB3_0 = 3883525235u;
						continue;
					}
					case 1u:
					{
						string[] array2;
						int num3;
						arg_CB3_0 = ((!WorldManager.smethod_20(WorldManager.smethod_37(array2[num3]), Module.smethod_34<string>(1249328511u))) ? 3156625681u : 3129884034u);
						continue;
					}
					case 2u:
					{
						PacketWriter binaryWriter_ = new PacketWriter(ServerMessage.DBReply, true);
						arg_CB3_0 = (num * 3936356842u ^ 3734980536u);
						continue;
					}
					case 3u:
					{
						string[] array2;
						uint uint_ = uint.Parse(array2[0]);
						arg_CB3_0 = (num * 752231235u ^ 248922869u);
						continue;
					}
					case 4u:
					{
						int num2;
						arg_CB3_0 = ((num2 >= array.Length) ? 3005882202u : 2541234465u);
						continue;
					}
					case 5u:
					{
						int num3;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes[num3] == 4) ? 3340753439u : 2622676352u);
						continue;
					}
					case 6u:
					{
						string[] array3;
						int num4;
						array3[num4] = Module.smethod_35<string>(1226427678u);
						arg_CB3_0 = 2151535425u;
						continue;
					}
					case 7u:
					{
						DBInfo dBInfo;
						int num5;
						sbyte b = dBInfo.FieldBytes[num5];
						arg_CB3_0 = 2277441523u;
						continue;
					}
					case 8u:
					{
						DBInfo dBInfo;
						int num5;
						arg_CB3_0 = ((num5 < dBInfo.FieldBytes.Length) ? 4161359915u : 2686295563u);
						continue;
					}
					case 9u:
					{
						string[] array2 = array2.Skip(1).ToArray<string>();
						arg_CB3_0 = (num * 665224995u ^ 3775302635u);
						continue;
					}
					case 10u:
					{
						string[] value;
						int num6;
						IEnumerable<string> arg_B51_0 = WorldManager.smethod_27(value[num6], new string[]
						{
							Module.smethod_36<string>(2162936088u)
						}, StringSplitOptions.None);
						Func<string, string> arg_B51_1;
						if ((arg_B51_1 = WorldManager.__c.__9__40_0) == null)
						{
							arg_B51_1 = (WorldManager.__c.__9__40_0 = new Func<string, string>(WorldManager.__c.__9.SendHotfixesb__40_0));
						}
						string[] array2 = arg_B51_0.Select(arg_B51_1).ToArray<string>();
						arg_CB3_0 = 2682721714u;
						continue;
					}
					case 11u:
						arg_CB3_0 = (num * 897889744u ^ 139128096u);
						continue;
					case 12u:
					{
						PacketWriter binaryWriter_;
						string[] value;
						WorldManager.smethod_25(binaryWriter_, (uint)((value.Length < 50) ? value.Length : 50));
						arg_CB3_0 = 2362296894u;
						continue;
					}
					case 13u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_42(binaryWriter_2, float.Parse(array2[num3]));
						arg_CB3_0 = (num * 2460759494u ^ 2459602260u);
						continue;
					}
					case 14u:
					{
						int num5;
						num5++;
						arg_CB3_0 = 2385465178u;
						continue;
					}
					case 15u:
					{
						DBInfo dBInfo;
						arg_CB3_0 = (((!dBInfo.HasIndex) ? 2075256828u : 1600314029u) ^ num * 2037012033u);
						continue;
					}
					case 16u:
					{
						string[] array2;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes.Length > array2.Length) ? 4046074280u : 2412213547u);
						continue;
					}
					case 17u:
					{
						string[] array3;
						int num4;
						arg_CB3_0 = ((num4 < array3.Length) ? 3792741066u : 2454995688u);
						continue;
					}
					case 18u:
					{
						sbyte b;
						arg_CB3_0 = (((b == -1) ? 1065433920u : 343619630u) ^ num * 4037374063u);
						continue;
					}
					case 19u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_43(binaryWriter_2, long.Parse(array2[num3]));
						arg_CB3_0 = (num * 2526707777u ^ 3029318587u);
						continue;
					}
					case 20u:
					{
						KeyValuePair<string, string[]> keyValuePair;
						string[] value = keyValuePair.Value;
						PacketWriter binaryWriter_ = new PacketWriter(ServerMessage.DBReply, true);
						int num7 = 0;
						int num5 = 0;
						arg_CB3_0 = (num * 1465778865u ^ 3761136241u);
						continue;
					}
					case 21u:
					{
						int num2 = 0;
						arg_CB3_0 = (num * 661521374u ^ 3527479349u);
						continue;
					}
					case 22u:
					{
						string[] array2;
						int num3;
						arg_CB3_0 = ((num3 < array2.Length) ? 3424934690u : 4211295968u);
						continue;
					}
					case 23u:
					{
						PacketWriter binaryWriter_;
						byte[] byte_;
						WorldManager.smethod_30(binaryWriter_, byte_);
						arg_CB3_0 = (num * 978835068u ^ 1601987398u);
						continue;
					}
					case 24u:
					{
						PacketWriter binaryWriter_;
						int num8;
						WorldManager.smethod_26(binaryWriter_, num8);
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_30(binaryWriter_, WorldManager.smethod_45(WorldManager.smethod_22(binaryWriter_2) as MemoryStream));
						int num6;
						num6++;
						arg_CB3_0 = (num * 731127645u ^ 920579482u);
						continue;
					}
					case 25u:
					{
						int num9;
						num9++;
						arg_CB3_0 = (num * 2102584341u ^ 2859284816u);
						continue;
					}
					case 26u:
					{
						string[] array2;
						int num3;
						arg_CB3_0 = (((!WorldManager.smethod_20(WorldManager.smethod_37(array2[num3]), Module.smethod_37<string>(3155964920u))) ? 3145619627u : 3838415364u) ^ num * 1067950292u);
						continue;
					}
					case 28u:
					{
						int num4;
						num4++;
						arg_CB3_0 = (num * 2499463060u ^ 3235126393u);
						continue;
					}
					case 29u:
					{
						string[] value;
						int num6;
						arg_CB3_0 = ((num6 < value.Length) ? 3581861470u : 4094187285u);
						continue;
					}
					case 30u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_36(binaryWriter_2, WorldManager.smethod_28(int.Parse(array2[num3])), 0, 3);
						arg_CB3_0 = (num * 582767338u ^ 2510263648u);
						continue;
					}
					case 31u:
					{
						string[] array2;
						int num3;
						arg_CB3_0 = ((WorldManager.smethod_20(WorldManager.smethod_37(array2[num3]), Module.smethod_35<string>(1450348988u)) ? 3407953591u : 3089505394u) ^ num * 2930763513u);
						continue;
					}
					case 32u:
					{
						PacketWriter binaryWriter_;
						session.Send(ref binaryWriter_);
						arg_CB3_0 = (num * 436278088u ^ 3797916996u);
						continue;
					}
					case 33u:
					{
						PacketWriter binaryWriter_;
						session.Send(ref binaryWriter_);
						arg_CB3_0 = (num * 888513865u ^ 1101150870u);
						continue;
					}
					case 34u:
					{
						int num3;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes[num3] == -1) ? 3121901486u : 3955779979u);
						continue;
					}
					case 35u:
					{
						string[] array2;
						DBInfo dBInfo;
						string[] array3 = new string[dBInfo.FieldBytes.Length - array2.Length];
						arg_CB3_0 = (num * 4111128937u ^ 1747399980u);
						continue;
					}
					case 36u:
					{
						int num3;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes[num3] == 1) ? 4252407131u : 3337104815u);
						continue;
					}
					case 37u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_25(binaryWriter_2, uint.Parse(array2[num3]));
						arg_CB3_0 = 2622676352u;
						continue;
					}
					case 38u:
					{
						PacketWriter binaryWriter_;
						uint uint_;
						WorldManager.smethod_25(binaryWriter_, uint_);
						arg_CB3_0 = (num * 2723354798u ^ 725568371u);
						continue;
					}
					case 39u:
					{
						int num6;
						arg_CB3_0 = ((num6 <= 0) ? 3655471179u : 4205951225u);
						continue;
					}
					case 40u:
					{
						int num2;
						KeyValuePair<string, string[]> keyValuePair = array[num2];
						string key = keyValuePair.Key;
						DBInfo dBInfo = this.DBInfo[key];
						arg_CB3_0 = 4093983988u;
						continue;
					}
					case 41u:
					{
						DBInfo dBInfo;
						int num10;
						byte[] byte_ = WorldManager.smethod_28(num10++).Concat(WorldManager.smethod_29(dBInfo.TableHash)).ToArray<byte>();
						arg_CB3_0 = 4134788138u;
						continue;
					}
					case 42u:
					{
						string[] array2;
						int num3;
						arg_CB3_0 = ((WorldManager.smethod_20(WorldManager.smethod_37(array2[num3]), Module.smethod_36<string>(1664999740u)) ? 2252339831u : 2892691487u) ^ num * 1970336797u);
						continue;
					}
					case 43u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_38(binaryWriter_2, sbyte.Parse(array2[num3]));
						arg_CB3_0 = (num * 4227732606u ^ 753402639u);
						continue;
					}
					case 44u:
					{
						int num3;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes[num3] == 8) ? 3301808171u : 2544414077u);
						continue;
					}
					case 45u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_44(binaryWriter_2, ulong.Parse(array2[num3]));
						arg_CB3_0 = 2544414077u;
						continue;
					}
					case 46u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_26(binaryWriter_2, int.Parse(array2[num3]));
						arg_CB3_0 = (num * 4264943359u ^ 867232177u);
						continue;
					}
					case 47u:
					{
						int num6 = 0;
						arg_CB3_0 = (num * 2974403205u ^ 1972425475u);
						continue;
					}
					case 48u:
						arg_CB3_0 = (num * 2811483129u ^ 2973242412u);
						continue;
					case 49u:
						arg_CB3_0 = (num * 3984516638u ^ 3954005623u);
						continue;
					case 50u:
					{
						int num3;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes[num3] != 3) ? 3119984824u : 3658735878u);
						continue;
					}
					case 51u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_39(binaryWriter_2, short.Parse(array2[num3]));
						arg_CB3_0 = (num * 4060967414u ^ 638278327u);
						continue;
					}
					case 52u:
						arg_CB3_0 = (num * 3520865308u ^ 2545961172u);
						continue;
					case 53u:
					{
						int num9;
						arg_CB3_0 = (((num9 <= 50) ? 3369612915u : 3411185519u) ^ num * 55113301u);
						continue;
					}
					case 54u:
					{
						int num9 = 0;
						arg_CB3_0 = (num * 3226780449u ^ 3946266654u);
						continue;
					}
					case 55u:
					{
						int num6;
						arg_CB3_0 = (((num6 % 50 == 0) ? 43002753u : 880411684u) ^ num * 3167421029u);
						continue;
					}
					case 56u:
					{
						string[] array3;
						string[] array2 = array2.Concat(array3).ToArray<string>();
						arg_CB3_0 = (num * 1849339066u ^ 1844800191u);
						continue;
					}
					case 57u:
					{
						string[] array2;
						int num3;
						arg_CB3_0 = (((!WorldManager.smethod_41(WorldManager.smethod_37(array2[num3]), Module.smethod_35<string>(3143151842u))) ? 2640793704u : 2332470793u) ^ num * 148078949u);
						continue;
					}
					case 58u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_40(binaryWriter_2, ushort.Parse(array2[num3]));
						arg_CB3_0 = 4123887515u;
						continue;
					}
					case 59u:
						goto IL_DE5;
					case 60u:
						arg_CB3_0 = (num * 3283479811u ^ 3538258094u);
						continue;
					case 61u:
					{
						PacketWriter binaryWriter_;
						WorldManager.smethod_31(binaryWriter_, 128);
						BinaryWriter binaryWriter_2 = WorldManager.smethod_33(WorldManager.smethod_32());
						arg_CB3_0 = (num * 489730257u ^ 1920912783u);
						continue;
					}
					case 62u:
					{
						string[] array2;
						int num3;
						byte[] array4 = WorldManager.smethod_35(WorldManager.smethod_34(), array2[num3]);
						int num8;
						num8 += array4.Length + 1;
						arg_CB3_0 = (num * 3187481465u ^ 467302530u);
						continue;
					}
					case 63u:
					{
						PacketWriter binaryWriter_;
						string[] value;
						int num6;
						WorldManager.smethod_26(binaryWriter_, (value.Length - num6 < 50) ? (value.Length - num6) : 50);
						arg_CB3_0 = 3655471179u;
						continue;
					}
					case 64u:
					{
						BinaryWriter binaryWriter_2;
						byte[] array4;
						WorldManager.smethod_36(binaryWriter_2, array4, 0, array4.Length);
						WorldManager.smethod_31(binaryWriter_2, 0);
						arg_CB3_0 = (num * 3314784077u ^ 839358295u);
						continue;
					}
					case 65u:
					{
						sbyte b;
						int num7;
						num7 += (int)b;
						arg_CB3_0 = (num * 4038829678u ^ 2226515981u);
						continue;
					}
					case 66u:
					{
						int num4 = 0;
						arg_CB3_0 = (num * 2373268253u ^ 918918337u);
						continue;
					}
					case 67u:
						arg_CB3_0 = (num * 3471201856u ^ 2935453722u);
						continue;
					case 68u:
					{
						int num3;
						DBInfo dBInfo;
						arg_CB3_0 = ((dBInfo.FieldBytes[num3] == 2) ? 4011232868u : 4123887515u);
						continue;
					}
					case 69u:
					{
						int num7;
						int num8 = num7;
						int num3 = 0;
						arg_CB3_0 = (num * 1931592375u ^ 3608255983u);
						continue;
					}
					case 70u:
					{
						string[] array2;
						int num3;
						BinaryWriter binaryWriter_2;
						WorldManager.smethod_31(binaryWriter_2, byte.Parse(array2[num3]));
						arg_CB3_0 = 3337104815u;
						continue;
					}
					case 71u:
					{
						int num3;
						num3++;
						arg_CB3_0 = 3725859157u;
						continue;
					}
					case 72u:
					{
						int num10 = 1;
						int num9 = 0;
						arg_CB3_0 = (num * 2356110470u ^ 612677495u);
						continue;
					}
					}
					return;
				}
			}
		}

		public T Clone<T>(T source)
		{
			if (!WorldManager.smethod_47(WorldManager.smethod_46(typeof(T).TypeHandle)))
			{
				goto IL_33;
			}
			goto IL_6E;
			int arg_3D_0;
			IFormatter iformatter_;
			Stream stream;
			while (true)
			{
				IL_38:
				switch ((arg_3D_0 ^ -1470923769) % 6)
				{
				case 0:
					goto IL_33;
				case 1:
					goto IL_6E;
				case 2:
					goto IL_78;
				case 3:
					iformatter_ = WorldManager.smethod_49();
					stream = WorldManager.smethod_32();
					arg_3D_0 = -1460486632;
					continue;
				case 4:
					goto IL_92;
				}
				break;
			}
			goto IL_9C;
			IL_78:
			throw WorldManager.smethod_48(Module.smethod_37<string>(321870052u), Module.smethod_36<string>(2617192361u));
			IL_92:
			T result = default(T);
			return result;
			IL_9C:
			Stream stream2 = stream;
			try
			{
				WorldManager.smethod_50(iformatter_, stream, source);
				WorldManager.smethod_51(stream, 0L, SeekOrigin.Begin);
				result = (T)((object)WorldManager.smethod_52(iformatter_, stream));
			}
			finally
			{
				if (stream2 != null)
				{
					while (true)
					{
						IL_102:
						uint arg_E9_0 = 2476003598u;
						while (true)
						{
							uint num;
							switch ((num = (arg_E9_0 ^ 2824043527u)) % 3u)
							{
							case 0u:
								goto IL_102;
							case 2u:
								WorldManager.smethod_12(stream2);
								arg_E9_0 = (num * 4231273988u ^ 3716994402u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			return result;
			IL_33:
			arg_3D_0 = -1615506447;
			goto IL_38;
			IL_6E:
			arg_3D_0 = ((source == null) ? -2106654699 : -1845476174);
			goto IL_38;
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

		static string[] smethod_10(string string_0, char[] char_0, StringSplitOptions stringSplitOptions_0)
		{
			return string_0.Split(char_0, stringSplitOptions_0);
		}

		static bool smethod_11(StreamReader streamReader_0)
		{
			return streamReader_0.EndOfStream;
		}

		static void smethod_12(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static string smethod_13(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static Thread smethod_14(ThreadStart threadStart_0)
		{
			return new Thread(threadStart_0);
		}

		static void smethod_15(Thread thread_0, bool bool_0)
		{
			thread_0.IsBackground = bool_0;
		}

		static void smethod_16(Thread thread_0)
		{
			thread_0.Start();
		}

		static void smethod_17(object object_0, ref bool bool_0)
		{
			Monitor.Enter(object_0, ref bool_0);
		}

		static void smethod_18(int int_0)
		{
			Thread.Sleep(int_0);
		}

		static void smethod_19(object object_0)
		{
			Monitor.Exit(object_0);
		}

		static bool smethod_20(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static bool smethod_21(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static Stream smethod_22(BinaryWriter binaryWriter_0)
		{
			return binaryWriter_0.BaseStream;
		}

		static long smethod_23(Stream stream_0)
		{
			return stream_0.Length;
		}

		static string smethod_24(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static void smethod_25(BinaryWriter binaryWriter_0, uint uint_0)
		{
			binaryWriter_0.Write(uint_0);
		}

		static void smethod_26(BinaryWriter binaryWriter_0, int int_0)
		{
			binaryWriter_0.Write(int_0);
		}

		static string[] smethod_27(string string_0, string[] string_1, StringSplitOptions stringSplitOptions_0)
		{
			return string_0.Split(string_1, stringSplitOptions_0);
		}

		static byte[] smethod_28(int int_0)
		{
			return BitConverter.GetBytes(int_0);
		}

		static byte[] smethod_29(uint uint_0)
		{
			return BitConverter.GetBytes(uint_0);
		}

		static void smethod_30(BinaryWriter binaryWriter_0, byte[] byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static void smethod_31(BinaryWriter binaryWriter_0, byte byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static MemoryStream smethod_32()
		{
			return new MemoryStream();
		}

		static BinaryWriter smethod_33(Stream stream_0)
		{
			return new BinaryWriter(stream_0);
		}

		static Encoding smethod_34()
		{
			return Encoding.ASCII;
		}

		static byte[] smethod_35(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static void smethod_36(BinaryWriter binaryWriter_0, byte[] byte_0, int int_0, int int_1)
		{
			binaryWriter_0.Write(byte_0, int_0, int_1);
		}

		static string smethod_37(object object_0)
		{
			return object_0.ToString();
		}

		static void smethod_38(BinaryWriter binaryWriter_0, sbyte sbyte_0)
		{
			binaryWriter_0.Write(sbyte_0);
		}

		static void smethod_39(BinaryWriter binaryWriter_0, short short_0)
		{
			binaryWriter_0.Write(short_0);
		}

		static void smethod_40(BinaryWriter binaryWriter_0, ushort ushort_0)
		{
			binaryWriter_0.Write(ushort_0);
		}

		static bool smethod_41(string string_0, string string_1)
		{
			return string_0.Contains(string_1);
		}

		static void smethod_42(BinaryWriter binaryWriter_0, float float_0)
		{
			binaryWriter_0.Write(float_0);
		}

		static void smethod_43(BinaryWriter binaryWriter_0, long long_0)
		{
			binaryWriter_0.Write(long_0);
		}

		static void smethod_44(BinaryWriter binaryWriter_0, ulong ulong_0)
		{
			binaryWriter_0.Write(ulong_0);
		}

		static byte[] smethod_45(MemoryStream memoryStream_0)
		{
			return memoryStream_0.ToArray();
		}

		static Type smethod_46(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_47(Type type_0)
		{
			return type_0.IsSerializable;
		}

		static ArgumentException smethod_48(string string_0, string string_1)
		{
			return new ArgumentException(string_0, string_1);
		}

		static BinaryFormatter smethod_49()
		{
			return new BinaryFormatter();
		}

		static void smethod_50(IFormatter iformatter_0, Stream stream_0, object object_0)
		{
			iformatter_0.Serialize(stream_0, object_0);
		}

		static long smethod_51(Stream stream_0, long long_0, SeekOrigin seekOrigin_0)
		{
			return stream_0.Seek(long_0, seekOrigin_0);
		}

		static object smethod_52(IFormatter iformatter_0, Stream stream_0)
		{
			return iformatter_0.Deserialize(stream_0);
		}

		static object smethod_53()
		{
			return new object();
		}
	}
}
