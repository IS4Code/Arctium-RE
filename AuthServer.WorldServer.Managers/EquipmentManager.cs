using AuthServer.WorldServer.Game.Entities;
using Framework.Constants.Misc;
using Framework.Logging;
using Framework.Misc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AuthServer.WorldServer.Managers
{
	public class EquipmentManager : Singleton<EquipmentManager>
	{
		public ConcurrentDictionary<int, Item> AvailableItems = new ConcurrentDictionary<int, Item>();

		public ConcurrentDictionary<int, Item> ItemRefs = new ConcurrentDictionary<int, Item>();

		public ConcurrentDictionary<int, int> AvailableDisplayIds = new ConcurrentDictionary<int, int>();

		public ConcurrentDictionary<int, Dictionary<string, Tuple<int, int>>> AvailableDisplayIds2 = new ConcurrentDictionary<int, Dictionary<string, Tuple<int, int>>>();

		public List<CharStartOutfit> CharStartOutfits = new List<CharStartOutfit>();

		public List<Namegen> Namegens = new List<Namegen>();

		private string[] line;

		private EquipmentManager()
		{
			while (true)
			{
				IL_7A:
				uint arg_62_0 = 1209675309u;
				while (true)
				{
					uint num;
					switch ((num = (arg_62_0 ^ 183618116u)) % 3u)
					{
					case 0u:
						goto IL_7A;
					case 1u:
						this.LoadAvailableItmes();
						arg_62_0 = (num * 1531967429u ^ 3032100478u);
						continue;
					}
					return;
				}
			}
		}

		private void LoadAvailableItmes()
		{
			StreamReader streamReader = EquipmentManager.smethod_7(EquipmentManager.smethod_6(EquipmentManager.smethod_5(), Module.smethod_33<string>(2775282556u)));
			try
			{
				while (true)
				{
					IL_224:
					uint arg_1D7_0 = (!EquipmentManager.smethod_10(streamReader)) ? 3461010831u : 3426587474u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1D7_0 ^ 2626580690u)) % 12u)
						{
						case 0u:
						{
							CharStartOutfit charStartOutfit;
							charStartOutfit.ClassId = byte.Parse(this.line[27]);
							charStartOutfit.SexId = byte.Parse(this.line[28]);
							charStartOutfit.OutfitId = byte.Parse(this.line[29]);
							arg_1D7_0 = (num * 2077656181u ^ 2075374387u);
							continue;
						}
						case 1u:
						{
							int num2 = 1;
							arg_1D7_0 = (num * 4094123927u ^ 4252297251u);
							continue;
						}
						case 2u:
						{
							CharStartOutfit charStartOutfit;
							int num2;
							arg_1D7_0 = ((num2 > charStartOutfit.ItemId.Length) ? 2555147717u : 2500467789u);
							continue;
						}
						case 3u:
						{
							CharStartOutfit charStartOutfit;
							int num2;
							charStartOutfit.ItemId[num2 - 1] = uint.Parse(this.line[num2]);
							arg_1D7_0 = 3707076784u;
							continue;
						}
						case 4u:
							goto IL_224;
						case 5u:
						{
							this.line = EquipmentManager.smethod_9(EquipmentManager.smethod_8(streamReader), new char[]
							{
								';'
							});
							CharStartOutfit charStartOutfit = new CharStartOutfit();
							charStartOutfit.Id = uint.Parse(this.line[0]);
							arg_1D7_0 = 2242302911u;
							continue;
						}
						case 6u:
						{
							int num2;
							num2++;
							arg_1D7_0 = (num * 2585752736u ^ 1017943336u);
							continue;
						}
						case 7u:
						{
							CharStartOutfit charStartOutfit;
							charStartOutfit.PetDisplayId = uint.Parse(this.line[25]);
							charStartOutfit.RaceId = byte.Parse(this.line[26]);
							arg_1D7_0 = (num * 362195882u ^ 714632876u);
							continue;
						}
						case 9u:
						{
							CharStartOutfit charStartOutfit;
							charStartOutfit.PetFamilyId = byte.Parse(this.line[30]);
							arg_1D7_0 = (num * 599166167u ^ 762590322u);
							continue;
						}
						case 10u:
							arg_1D7_0 = 3461010831u;
							continue;
						case 11u:
						{
							CharStartOutfit charStartOutfit;
							this.CharStartOutfits.Add(charStartOutfit);
							arg_1D7_0 = (num * 3430256344u ^ 2239010134u);
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
				if (streamReader != null)
				{
					while (true)
					{
						IL_26A:
						uint arg_251_0 = 4257077129u;
						while (true)
						{
							uint num;
							switch ((num = (arg_251_0 ^ 2626580690u)) % 3u)
							{
							case 0u:
								goto IL_26A;
							case 1u:
								EquipmentManager.smethod_11(streamReader);
								arg_251_0 = (num * 835379987u ^ 2486029765u);
								continue;
							}
							goto Block_13;
						}
					}
					Block_13:;
				}
			}
			StreamReader streamReader2 = EquipmentManager.smethod_7(EquipmentManager.smethod_6(EquipmentManager.smethod_5(), Module.smethod_33<string>(2116823149u)));
			try
			{
				while (true)
				{
					IL_359:
					int arg_32D_0 = (!EquipmentManager.smethod_10(streamReader2)) ? -1013399805 : -1101339282;
					while (true)
					{
						switch ((arg_32D_0 ^ -1668386606) % 4)
						{
						case 1:
						{
							this.line = EquipmentManager.smethod_9(EquipmentManager.smethod_8(streamReader2), new char[]
							{
								';'
							});
							string s = EquipmentManager.smethod_12(this.line[1], Module.smethod_37<string>(3974021651u), "");
							string s2 = EquipmentManager.smethod_12(this.line[0], Module.smethod_33<string>(3031927268u), "");
							this.AvailableDisplayIds.TryAdd(int.Parse(s2), int.Parse(s));
							arg_32D_0 = -2100030119;
							continue;
						}
						case 2:
							arg_32D_0 = -1013399805;
							continue;
						case 3:
							goto IL_359;
						}
						goto Block_15;
					}
				}
				Block_15:;
			}
			finally
			{
				if (streamReader2 != null)
				{
					while (true)
					{
						IL_39F:
						uint arg_386_0 = 3923196079u;
						while (true)
						{
							uint num;
							switch ((num = (arg_386_0 ^ 2626580690u)) % 3u)
							{
							case 0u:
								goto IL_39F;
							case 1u:
								EquipmentManager.smethod_11(streamReader2);
								arg_386_0 = (num * 4013498643u ^ 3261947067u);
								continue;
							}
							goto Block_19;
						}
					}
					Block_19:;
				}
			}
			StreamReader streamReader3 = EquipmentManager.smethod_7(EquipmentManager.smethod_6(EquipmentManager.smethod_5(), Module.smethod_36<string>(359555861u)));
			try
			{
				while (true)
				{
					IL_6E0:
					uint arg_67B_0 = (!EquipmentManager.smethod_10(streamReader3)) ? 4276022470u : 2181295176u;
					while (true)
					{
						uint num;
						string key;
						switch ((num = (arg_67B_0 ^ 2626580690u)) % 18u)
						{
						case 0u:
							goto IL_6E0;
						case 1u:
							goto IL_541;
						case 2u:
						{
							string s3;
							this.AvailableDisplayIds2.TryAdd(int.Parse(s3), new Dictionary<string, Tuple<int, int>>());
							arg_67B_0 = (num * 223768797u ^ 1426707423u);
							continue;
						}
						case 3u:
							goto IL_52B;
						case 5u:
							arg_67B_0 = (num * 1466427458u ^ 97242185u);
							continue;
						case 6u:
						{
							this.line = EquipmentManager.smethod_9(EquipmentManager.smethod_8(streamReader3), new char[]
							{
								';'
							});
							string s3 = EquipmentManager.smethod_12(this.line[1], Module.smethod_34<string>(1801001672u), "");
							arg_67B_0 = 3157067419u;
							continue;
						}
						case 7u:
							goto IL_4FF;
						case 8u:
							arg_67B_0 = (num * 2221118697u ^ 3909868360u);
							continue;
						case 9u:
							goto IL_4D3;
						case 10u:
							goto IL_4E9;
						case 11u:
							arg_67B_0 = 4276022470u;
							continue;
						case 12u:
						{
							string s3;
							int item;
							this.AvailableDisplayIds2[int.Parse(s3)].Add(key, Tuple.Create<int, int>(item, int.Parse(EquipmentManager.smethod_12(this.line[3], Module.smethod_35<string>(764625391u), ""))));
							arg_67B_0 = 2331671664u;
							continue;
						}
						case 13u:
						{
							int num3 = int.Parse(EquipmentManager.smethod_12(this.line[3], Module.smethod_33<string>(3031927268u), ""));
							arg_67B_0 = (num * 284313300u ^ 514507668u);
							continue;
						}
						case 14u:
						{
							int num3;
							switch (num3)
							{
							case 0:
								goto IL_4D3;
							case 1:
								goto IL_4E9;
							case 2:
								goto IL_4FF;
							case 3:
								goto IL_52B;
							case 4:
								goto IL_541;
							default:
								arg_67B_0 = (num * 2855740908u ^ 4218272821u);
								continue;
							}
							break;
						}
						case 15u:
							key = Module.smethod_36<string>(102126220u);
							arg_67B_0 = 2880666535u;
							continue;
						case 16u:
						{
							int item = this.AvailableDisplayIds[int.Parse(EquipmentManager.smethod_12(this.line[2], Module.smethod_35<string>(764625391u), ""))];
							string s3;
							arg_67B_0 = ((this.AvailableDisplayIds2.ContainsKey(int.Parse(s3)) ? 3711815613u : 3173784448u) ^ num * 2379889547u);
							continue;
						}
						case 17u:
							arg_67B_0 = (((int.Parse(EquipmentManager.smethod_12(this.line[2], Module.smethod_34<string>(1801001672u), "")) == 0) ? 869108670u : 1918094454u) ^ num * 1926906206u);
							continue;
						}
						goto Block_24;
						IL_4D3:
						key = Module.smethod_33<string>(3446856637u);
						arg_67B_0 = 2458526896u;
						continue;
						IL_4E9:
						key = Module.smethod_35<string>(1436672640u);
						arg_67B_0 = 2241113722u;
						continue;
						IL_4FF:
						key = EquipmentManager.smethod_12(this.line[3], Module.smethod_34<string>(1801001672u), "");
						arg_67B_0 = 2241113722u;
						continue;
						IL_52B:
						key = Module.smethod_37<string>(3389766987u);
						arg_67B_0 = 2241113722u;
						continue;
						IL_541:
						key = Module.smethod_36<string>(1114921850u);
						arg_67B_0 = 2241113722u;
					}
				}
				Block_24:;
			}
			finally
			{
				if (streamReader3 != null)
				{
					while (true)
					{
						IL_729:
						uint arg_710_0 = 2388129943u;
						while (true)
						{
							uint num;
							switch ((num = (arg_710_0 ^ 2626580690u)) % 3u)
							{
							case 0u:
								goto IL_729;
							case 2u:
								EquipmentManager.smethod_11(streamReader3);
								arg_710_0 = (num * 573678255u ^ 992583810u);
								continue;
							}
							goto Block_28;
						}
					}
					Block_28:;
				}
			}
			StreamReader streamReader4 = EquipmentManager.smethod_7(EquipmentManager.smethod_6(EquipmentManager.smethod_5(), Module.smethod_35<string>(3912916760u)));
			try
			{
				while (true)
				{
					IL_8D8:
					uint arg_89C_0 = (!EquipmentManager.smethod_10(streamReader4)) ? 3398431451u : 3176612841u;
					while (true)
					{
						uint num;
						switch ((num = (arg_89C_0 ^ 2626580690u)) % 8u)
						{
						case 0u:
							arg_89C_0 = 3398431451u;
							continue;
						case 1u:
							this.line = EquipmentManager.smethod_9(EquipmentManager.smethod_8(streamReader4), new char[]
							{
								';'
							});
							arg_89C_0 = 2481746045u;
							continue;
						case 2u:
						{
							int num4;
							Dictionary<string, Tuple<int, int>> dictionary;
							arg_89C_0 = ((this.AvailableDisplayIds2.TryGetValue(num4, out dictionary) ? 3095803325u : 2725875438u) ^ num * 4288170837u);
							continue;
						}
						case 4u:
							goto IL_8D8;
						case 5u:
						{
							int num4;
							string s4;
							this.AvailableItems.TryAdd(num4, new Item
							{
								Id = num4,
								DisplayInfoIds = this.AvailableDisplayIds2[num4],
								InventoryType = byte.Parse(s4)
							});
							arg_89C_0 = (num * 402617654u ^ 3623275920u);
							continue;
						}
						case 6u:
						{
							int num4;
							string s4;
							this.AvailableItems.TryAdd(num4, new Item
							{
								Id = num4,
								InventoryType = byte.Parse(s4)
							});
							arg_89C_0 = 3483778670u;
							continue;
						}
						case 7u:
						{
							string arg_7A4_0 = EquipmentManager.smethod_12(this.line[0], Module.smethod_36<string>(1708679815u), "");
							string s4 = EquipmentManager.smethod_12(this.line[2], Module.smethod_35<string>(764625391u), "");
							int num4 = int.Parse(arg_7A4_0);
							arg_89C_0 = (num * 1860668236u ^ 1191528156u);
							continue;
						}
						}
						goto Block_31;
					}
				}
				Block_31:;
			}
			finally
			{
				if (streamReader4 != null)
				{
					while (true)
					{
						IL_921:
						uint arg_908_0 = 2965684795u;
						while (true)
						{
							uint num;
							switch ((num = (arg_908_0 ^ 2626580690u)) % 3u)
							{
							case 0u:
								goto IL_921;
							case 1u:
								EquipmentManager.smethod_11(streamReader4);
								arg_908_0 = (num * 2627898260u ^ 3996126377u);
								continue;
							}
							goto Block_35;
						}
					}
					Block_35:;
				}
			}
			StreamReader streamReader5 = EquipmentManager.smethod_7(EquipmentManager.smethod_6(EquipmentManager.smethod_5(), Module.smethod_35<string>(4192676738u)));
			try
			{
				while (true)
				{
					IL_A4C:
					uint arg_A14_0 = (!EquipmentManager.smethod_10(streamReader5)) ? 2962417221u : 4091737895u;
					while (true)
					{
						uint num;
						switch ((num = (arg_A14_0 ^ 2626580690u)) % 7u)
						{
						case 0u:
							arg_A14_0 = 2962417221u;
							continue;
						case 1u:
						{
							string name = this.line[0];
							arg_A14_0 = (num * 3704255759u ^ 3887901866u);
							continue;
						}
						case 2u:
							goto IL_A4C;
						case 3u:
						{
							byte race = byte.Parse(this.line[1]);
							byte sex = byte.Parse(this.line[2]);
							arg_A14_0 = (num * 469991047u ^ 3704787315u);
							continue;
						}
						case 4u:
							this.line = EquipmentManager.smethod_9(EquipmentManager.smethod_8(streamReader5), new char[]
							{
								';'
							});
							arg_A14_0 = 4277341210u;
							continue;
						case 5u:
						{
							string name;
							byte race;
							byte sex;
							this.Namegens.Add(new Namegen
							{
								Name = name,
								Race = race,
								Sex = sex
							});
							arg_A14_0 = (num * 905516309u ^ 3416554058u);
							continue;
						}
						}
						goto Block_37;
					}
				}
				Block_37:;
			}
			finally
			{
				if (streamReader5 != null)
				{
					while (true)
					{
						IL_A95:
						uint arg_A7C_0 = 3292403005u;
						while (true)
						{
							uint num;
							switch ((num = (arg_A7C_0 ^ 2626580690u)) % 3u)
							{
							case 1u:
								EquipmentManager.smethod_11(streamReader5);
								arg_A7C_0 = (num * 830996846u ^ 714018961u);
								continue;
							case 2u:
								goto IL_A95;
							}
							goto Block_41;
						}
					}
					Block_41:;
				}
			}
			Item arg_AAD_0 = this.AvailableItems[112454];
			while (true)
			{
				IL_B05:
				uint arg_AEC_0 = 2636670562u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AEC_0 ^ 2626580690u)) % 3u)
					{
					case 0u:
						goto IL_B05;
					case 2u:
						Log.Message(LogType.Debug, Module.smethod_33<string>(3912832510u), new object[]
						{
							this.AvailableItems.Count
						});
						arg_AEC_0 = (num * 513635594u ^ 549473989u);
						continue;
					}
					return;
				}
			}
		}

		public string GetEmbeddedResource(string ns, string res)
		{
			StreamReader streamReader = EquipmentManager.smethod_7(EquipmentManager.smethod_6(EquipmentManager.smethod_5(), EquipmentManager.smethod_13(Module.smethod_36<string>(235071774u), ns, res)));
			string result;
			try
			{
				result = EquipmentManager.smethod_14(streamReader);
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_5F:
						uint arg_47_0 = 1779120404u;
						while (true)
						{
							uint num;
							switch ((num = (arg_47_0 ^ 735590380u)) % 3u)
							{
							case 0u:
								goto IL_5F;
							case 1u:
								EquipmentManager.smethod_11(streamReader);
								arg_47_0 = (num * 1175224119u ^ 183579225u);
								continue;
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
			}
			return result;
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

		static bool smethod_10(StreamReader streamReader_0)
		{
			return streamReader_0.EndOfStream;
		}

		static void smethod_11(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static string smethod_12(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static string smethod_13(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		static string smethod_14(TextReader textReader_0)
		{
			return textReader_0.ReadToEnd();
		}
	}
}
