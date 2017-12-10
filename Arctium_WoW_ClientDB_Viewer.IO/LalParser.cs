using Arctium_WoW_ClientDB_Viewer.ClientDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Threading;

namespace Arctium_WoW_ClientDB_Viewer.IO
{
	internal class LalParser
	{
		private List<string> keyWords = new List<string>
		{
			Module.smethod_34<string>(229441821u)
		};

		private List<string> types = new List<string>
		{
			Module.smethod_34<string>(2330057163u),
			Module.smethod_37<string>(4086281002u),
			Module.smethod_34<string>(1514091022u),
			Module.smethod_33<string>(2088974017u),
			Module.smethod_33<string>(1647815300u),
			Module.smethod_34<string>(3399569773u),
			Module.smethod_34<string>(108041842u),
			Module.smethod_34<string>(1486427655u),
			Module.smethod_33<string>(2082416680u),
			Module.smethod_33<string>(2408367715u),
			Module.smethod_37<string>(2128715485u),
			Module.smethod_37<string>(1894972360u),
			Module.smethod_33<string>(1814069486u),
			Module.smethod_36<string>(1548752093u)
		};

		public static LalFile Parse(string file)
		{
			string text = LalParser.smethod_0(file);
			LalFile expr_0C = new LalFile();
			LalParser.ParseFileOptions(expr_0C, ref text);
			LalParser.ParseTypeName(expr_0C, ref text);
			LalParser.ParseFields(expr_0C, ref text);
			return expr_0C;
		}

		private static void ParseFileOptions(LalFile lalFile, ref string fileContent)
		{
			Match match_ = LalParser.smethod_1(fileContent, Module.smethod_33<string>(3610078847u));
			if (LalParser.smethod_3(LalParser.smethod_2(match_)) == 2)
			{
				while (true)
				{
					IL_BF:
					uint arg_A3_0 = 48035529u;
					while (true)
					{
						uint num;
						switch ((num = (arg_A3_0 ^ 1449306096u)) % 4u)
						{
						case 0u:
							fileContent = LalParser.smethod_9(fileContent, LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 0)), "");
							arg_A3_0 = (num * 888027102u ^ 355448175u);
							continue;
						case 1u:
							lalFile.FileOptions = (Arctium_WoW_ClientDB_Viewer.ClientDB.FileOptions)LalParser.smethod_8(LalParser.smethod_4(typeof(Arctium_WoW_ClientDB_Viewer.ClientDB.FileOptions).TypeHandle), LalParser.smethod_7(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 1)), new char[]
							{
								' '
							}));
							arg_A3_0 = (num * 1662666148u ^ 4263500748u);
							continue;
						case 2u:
							goto IL_BF;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		private static void ParseTypeName(LalFile lalFile, ref string fileContent)
		{
			Match match_ = LalParser.smethod_1(fileContent, Module.smethod_36<string>(2954750933u));
			if (LalParser.smethod_3(LalParser.smethod_2(match_)) == 2)
			{
				goto IL_8E;
			}
			goto IL_B8;
			uint arg_98_0;
			while (true)
			{
				IL_93:
				uint num;
				switch ((num = (arg_98_0 ^ 2246949106u)) % 5u)
				{
				case 0u:
					return;
				case 2u:
					goto IL_B8;
				case 3u:
					goto IL_8E;
				case 4u:
					lalFile.TypeName = LalParser.smethod_10(LalParser.smethod_7(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 1)), new char[]
					{
						' '
					}), Module.smethod_34<string>(698124881u), "");
					fileContent = LalParser.smethod_9(fileContent, LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 0)), "");
					arg_98_0 = (num * 4169154842u ^ 3725544783u);
					continue;
				}
				break;
			}
			return;
			IL_8E:
			arg_98_0 = 2794222649u;
			goto IL_93;
			IL_B8:
			LalParser.smethod_11(Module.smethod_33<string>(836216381u));
			arg_98_0 = 2986272894u;
			goto IL_93;
		}

		private static void ParseFields(LalFile lalFile, ref string fileContent)
		{
			fileContent = LalParser.smethod_10(fileContent, Module.smethod_33<string>(4044680227u), "");
			string[] array = LalParser.smethod_12(fileContent, new string[]
			{
				Module.smethod_36<string>(1391877413u),
				Module.smethod_37<string>(1748879223u)
			}, StringSplitOptions.RemoveEmptyEntries);
			int num = 0;
			while (true)
			{
				IL_AF7:
				uint arg_ABA_0 = 1484983441u;
				while (true)
				{
					uint num2;
					LalField lalField;
					Match match_;
					string string_;
					int arg_4E6_0;
					IEnumerator enumerator;
					switch ((num2 = (arg_ABA_0 ^ 1058820709u)) % 11u)
					{
					case 0u:
						lalField = new LalField();
						lalField.Name = LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 1));
						arg_ABA_0 = (num2 * 2206441011u ^ 1453140542u);
						continue;
					case 1u:
						match_ = LalParser.smethod_1(string_, Module.smethod_37<string>(2859151699u));
						arg_ABA_0 = (num2 * 19887995u ^ 2446759507u);
						continue;
					case 2u:
						goto IL_5B6;
					case 3u:
					{
						int count = 0;
						arg_ABA_0 = (((!int.TryParse(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 2)), out count)) ? 158362706u : 1763962982u) ^ num2 * 3396028457u);
						continue;
					}
					case 4u:
						lalField.Type = LalParser.smethod_4(typeof(LalTypes.LalList).TypeHandle);
						arg_ABA_0 = 1691254943u;
						continue;
					case 5u:
					{
						int count;
						lalField.Count = count;
						arg_ABA_0 = (num2 * 1289185944u ^ 2669991515u);
						continue;
					}
					case 6u:
						lalField.CountField = LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 2));
						arg_ABA_0 = 411774275u;
						continue;
					case 7u:
						break;
					case 8u:
						IL_4D6:
						if (num >= array.Length)
						{
							arg_4E6_0 = 26573409;
							goto IL_4E1;
						}
						break;
					case 9u:
					{
						if (LalParser.smethod_13(string_, Module.smethod_37<string>(2479315437u)))
						{
							arg_ABA_0 = (num2 * 1116820749u ^ 4207479811u);
							continue;
						}
						int count2;
						while (true)
						{
							IL_90:
							count2 = 0;
							int arg_77_0 = 1781959800;
							while (true)
							{
								switch ((arg_77_0 ^ 1058820709) % 3)
								{
								case 1:
									goto IL_90;
								case 2:
									arg_77_0 = 2025344770;
									continue;
								}
								goto Block_2;
							}
						}
						IL_9A:
						enumerator = LalParser.smethod_15(LalParser.smethod_14(string_, Module.smethod_35<string>(3874797942u)));
						try
						{
							while (true)
							{
								IL_450:
								uint arg_3E3_0 = LalParser.smethod_22(enumerator) ? 1300706457u : 135954734u;
								while (true)
								{
									switch ((num2 = (arg_3E3_0 ^ 1058820709u)) % 20u)
									{
									case 0u:
										arg_3E3_0 = 1300706457u;
										continue;
									case 1u:
									{
										LalField lalField2;
										Match match_2;
										lalField2.Name = LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 2));
										lalField2.Type = LalTypeMapper.ReadValue[LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 1))];
										arg_3E3_0 = 497203653u;
										continue;
									}
									case 2u:
									{
										LalField lalField2;
										lalField2.Type = LalParser.smethod_19(lalField2.Type);
										arg_3E3_0 = 497203653u;
										continue;
									}
									case 3u:
									{
										LalField lalField2;
										string[] array2;
										lalField2.Name = array2[0];
										arg_3E3_0 = (num2 * 3441136566u ^ 4039319588u);
										continue;
									}
									case 4u:
									{
										LalField lalField2;
										lalFile.Fields.Add(lalField2.Name, lalField2);
										arg_3E3_0 = 1933705408u;
										continue;
									}
									case 5u:
									{
										string[] array2;
										arg_3E3_0 = ((int.TryParse(array2[1], out count2) ? 899283194u : 1707677606u) ^ num2 * 1576736428u);
										continue;
									}
									case 6u:
									{
										Match match_2;
										arg_3E3_0 = (((!LalParser.smethod_17(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 2)), Module.smethod_35<string>(3357156987u))) ? 4123448422u : 2981478371u) ^ num2 * 1635760263u);
										continue;
									}
									case 8u:
									{
										Match match_2 = (Match)LalParser.smethod_16(enumerator);
										LalField lalField2 = new LalField();
										arg_3E3_0 = 1047333543u;
										continue;
									}
									case 9u:
									{
										LalField lalField2;
										Match match_2;
										lalField2.Type = LalParser.smethod_19(LalTypeMapper.ReadValue[LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 1))]);
										arg_3E3_0 = (num2 * 899378993u ^ 869144234u);
										continue;
									}
									case 10u:
										arg_3E3_0 = (num2 * 1893172718u ^ 3659220617u);
										continue;
									case 11u:
									{
										LalField lalField2;
										lalField2.Count = count2;
										arg_3E3_0 = (num2 * 616472215u ^ 653733557u);
										continue;
									}
									case 12u:
									{
										Match match_2;
										string[] array2 = LalParser.smethod_18(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 2)), new char[]
										{
											','
										});
										arg_3E3_0 = (num2 * 2239082508u ^ 2451866668u);
										continue;
									}
									case 13u:
									{
										Match match_2;
										arg_3E3_0 = (((!LalParser.smethod_20(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 1)), Module.smethod_33<string>(1654372637u))) ? 3120592684u : 3529357398u) ^ num2 * 2613277203u);
										continue;
									}
									case 14u:
									{
										LalField lalField2;
										string[] array2;
										lalField2.CountField = array2[1];
										Match match_2;
										lalField2.Type = LalTypeMapper.ReadValue[LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 1))];
										arg_3E3_0 = (num2 * 2492547944u ^ 186733518u);
										continue;
									}
									case 15u:
									{
										Match match_2;
										arg_3E3_0 = ((LalParser.smethod_20(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_2), 1)), Module.smethod_36<string>(512027337u)) ? 3688620915u : 2470893792u) ^ num2 * 3584088089u);
										continue;
									}
									case 16u:
									{
										LalField lalField2;
										lalField2.Type = LalParser.smethod_21(LalParser.smethod_4(typeof(List__).TypeHandle), new Type[]
										{
											lalField2.Type
										});
										arg_3E3_0 = (num2 * 2000398997u ^ 240492983u);
										continue;
									}
									case 17u:
										goto IL_450;
									case 18u:
										arg_3E3_0 = (num2 * 1030411593u ^ 904127691u);
										continue;
									case 19u:
									{
										LalField lalField2;
										string[] array2;
										lalField2.Name = array2[0];
										arg_3E3_0 = 567916307u;
										continue;
									}
									}
									goto Block_14;
								}
							}
							Block_14:;
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							while (true)
							{
								IL_4C8:
								uint arg_4AB_0 = 492483066u;
								while (true)
								{
									switch ((num2 = (arg_4AB_0 ^ 1058820709u)) % 4u)
									{
									case 0u:
										goto IL_4C8;
									case 1u:
										LalParser.smethod_23(disposable);
										arg_4AB_0 = (num2 * 2428450929u ^ 2607384174u);
										continue;
									case 3u:
										arg_4AB_0 = (((disposable != null) ? 2691626095u : 2801039380u) ^ num2 * 177541341u);
										continue;
									}
									goto Block_18;
								}
							}
							Block_18:;
						}
						goto IL_4D0;
						Block_2:
						goto IL_9A;
					}
					case 10u:
						goto IL_AF7;
					default:
						goto IL_5B6;
					}
					string_ = array[num];
					arg_ABA_0 = 521850888u;
					continue;
					IL_4E1:
					switch ((arg_4E6_0 ^ 1058820709) % 3)
					{
					case 1:
						goto IL_4D6;
					case 2:
						IL_502:
						arg_4E6_0 = 217027748;
						goto IL_4E1;
					}
					return;
					IL_4D0:
					num++;
					goto IL_502;
					IL_5B6:
					lalField.Value = new LalTypes.LalList();
					enumerator = LalParser.smethod_15(LalParser.smethod_14(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_), 3)), Module.smethod_37<string>(2537758586u)));
					try
					{
						while (true)
						{
							IL_9CE:
							uint arg_965_0 = LalParser.smethod_22(enumerator) ? 1672334713u : 1672136332u;
							while (true)
							{
								switch ((num2 = (arg_965_0 ^ 1058820709u)) % 19u)
								{
								case 0u:
									goto IL_9CE;
								case 1u:
								{
									LalField lalField3;
									Match match_3;
									lalField3.Type = LalTypeMapper.ReadValue[LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 1))];
									arg_965_0 = ((LalParser.smethod_20(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 1)), Module.smethod_36<string>(512027337u)) ? 3997377174u : 2646884777u) ^ num2 * 3420361559u);
									continue;
								}
								case 2u:
								{
									LalField lalField3;
									string[] array3;
									((LalTypes.LalList)lalField.Value).Fields.Add(array3[0], lalField3);
									arg_965_0 = 1198504658u;
									continue;
								}
								case 4u:
									arg_965_0 = 1672334713u;
									continue;
								case 5u:
								{
									Match match_3 = (Match)LalParser.smethod_16(enumerator);
									arg_965_0 = 1138778410u;
									continue;
								}
								case 6u:
								{
									Match match_3;
									arg_965_0 = (((!LalParser.smethod_17(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 2)), Module.smethod_35<string>(3357156987u))) ? 510099539u : 5492353u) ^ num2 * 638669356u);
									continue;
								}
								case 7u:
								{
									LalField lalField3;
									string[] array3;
									lalField3.Name = array3[0];
									arg_965_0 = (num2 * 1351782445u ^ 1586121538u);
									continue;
								}
								case 8u:
								{
									Match match_3;
									((LalTypes.LalList)lalField.Value).Fields.Add(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 2)), new LalField
									{
										Name = LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 2)),
										Type = LalTypeMapper.ReadValue[LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 1))]
									});
									arg_965_0 = 1198504658u;
									continue;
								}
								case 9u:
								{
									LalField lalField3 = new LalField();
									arg_965_0 = 1183109674u;
									continue;
								}
								case 10u:
									arg_965_0 = (num2 * 2216412817u ^ 536817293u);
									continue;
								case 11u:
									arg_965_0 = (num2 * 3596800634u ^ 850867408u);
									continue;
								case 12u:
								{
									int count;
									Match match_3;
									string[] array3;
									((LalTypes.LalList)lalField.Value).Fields.Add(array3[0], new LalField
									{
										Name = array3[0],
										Count = count,
										Type = LalParser.smethod_19(LalTypeMapper.ReadValue[LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 1))])
									});
									arg_965_0 = (num2 * 2871084302u ^ 149273108u);
									continue;
								}
								case 13u:
								{
									Match match_3;
									string[] array3 = LalParser.smethod_18(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 2)), new char[]
									{
										','
									});
									arg_965_0 = (num2 * 1155440148u ^ 2030793012u);
									continue;
								}
								case 14u:
								{
									LalField lalField3;
									string[] array3;
									lalField3.CountField = array3[1];
									arg_965_0 = (num2 * 1490940552u ^ 2765525279u);
									continue;
								}
								case 15u:
								{
									LalField lalField3;
									lalField3.Type = LalParser.smethod_21(LalParser.smethod_4(typeof(List__).TypeHandle), new Type[]
									{
										lalField3.Type
									});
									arg_965_0 = (num2 * 3792481497u ^ 1451514239u);
									continue;
								}
								case 16u:
								{
									Match match_3;
									arg_965_0 = (((!LalParser.smethod_20(LalParser.smethod_6(LalParser.smethod_5(LalParser.smethod_2(match_3), 1)), Module.smethod_37<string>(1894972360u))) ? 2771168239u : 3539991657u) ^ num2 * 4061374352u);
									continue;
								}
								case 17u:
								{
									int count;
									string[] array3;
									arg_965_0 = ((int.TryParse(array3[1], out count) ? 2791513213u : 3825198839u) ^ num2 * 3676104902u);
									continue;
								}
								case 18u:
								{
									LalField lalField3;
									lalField3.Type = LalParser.smethod_19(lalField3.Type);
									arg_965_0 = 1707575115u;
									continue;
								}
								}
								goto Block_24;
							}
						}
						Block_24:;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						while (true)
						{
							IL_A46:
							uint arg_A29_0 = 1097970408u;
							while (true)
							{
								switch ((num2 = (arg_A29_0 ^ 1058820709u)) % 4u)
								{
								case 1u:
									arg_A29_0 = (((disposable != null) ? 4166600810u : 2434598868u) ^ num2 * 2932860529u);
									continue;
								case 2u:
									LalParser.smethod_23(disposable);
									arg_A29_0 = (num2 * 3516599910u ^ 1656150021u);
									continue;
								case 3u:
									goto IL_A46;
								}
								goto Block_28;
							}
						}
						Block_28:;
					}
					lalFile.Fields.Add(lalField.Name, lalField);
					goto IL_4D0;
				}
			}
		}

		public static Tuple<Type, Dictionary<Tuple<string, string>, Array>, Dictionary<Tuple<string, string>, string>, Arctium_WoW_ClientDB_Viewer.ClientDB.FileOptions> CreateType(LalFile lalFile)
		{
			if (lalFile == null)
			{
				goto IL_A7;
			}
			goto IL_E3;
			uint arg_B1_0;
			ModuleBuilder moduleBuilder_;
			string typeName;
			TypeBuilder typeBuilder_;
			Dictionary<Tuple<string, string>, Array> dictionary;
			Dictionary<Tuple<string, string>, string> dictionary2;
			while (true)
			{
				IL_AC:
				uint num;
				switch ((num = (arg_B1_0 ^ 15419579u)) % 9u)
				{
				case 0u:
					goto IL_A7;
				case 1u:
					goto IL_E3;
				case 2u:
					typeBuilder_ = LalParser.smethod_29(moduleBuilder_, typeName, TypeAttributes.Public | TypeAttributes.AutoClass | TypeAttributes.BeforeFieldInit, LalParser.smethod_4(typeof(object).TypeHandle));
					arg_B1_0 = (num * 942524104u ^ 1939291948u);
					continue;
				case 3u:
					new Dictionary<string, Type>();
					arg_B1_0 = (num * 2030176622u ^ 2356821604u);
					continue;
				case 4u:
				{
					AssemblyName assemblyName_;
					moduleBuilder_ = LalParser.smethod_28(LalParser.smethod_27(LalParser.smethod_26(), assemblyName_, AssemblyBuilderAccess.Run), typeName);
					arg_B1_0 = (num * 4000518090u ^ 2889643907u);
					continue;
				}
				case 6u:
				{
					AssemblyName assemblyName_;
					LalParser.smethod_25(assemblyName_, typeName);
					arg_B1_0 = (num * 100443052u ^ 506180307u);
					continue;
				}
				case 7u:
					goto IL_735;
				case 8u:
				{
					dictionary = new Dictionary<Tuple<string, string>, Array>();
					dictionary2 = new Dictionary<Tuple<string, string>, string>();
					AssemblyName assemblyName_ = LalParser.smethod_24();
					arg_B1_0 = (num * 595552796u ^ 507178737u);
					continue;
				}
				}
				break;
			}
			using (Dictionary<string, LalField>.Enumerator enumerator = lalFile.Fields.GetEnumerator())
			{
				while (true)
				{
					IL_702:
					KeyValuePair<string, LalField> current;
					Type type;
					if (enumerator.MoveNext())
					{
						TypeBuilder typeBuilder_2;
						while (true)
						{
							IL_18E:
							current = enumerator.Current;
							uint arg_16D_0 = 410578653u;
							while (true)
							{
								uint num;
								switch ((num = (arg_16D_0 ^ 15419579u)) % 5u)
								{
								case 0u:
									typeBuilder_2 = LalParser.smethod_29(moduleBuilder_, current.Key, TypeAttributes.Public | TypeAttributes.AutoClass | TypeAttributes.BeforeFieldInit, LalParser.smethod_4(typeof(object).TypeHandle));
									arg_16D_0 = (num * 399109714u ^ 3274743919u);
									continue;
								case 1u:
									goto IL_18E;
								case 3u:
									arg_16D_0 = 1525299149u;
									continue;
								case 4u:
									if (LalParser.smethod_30(current.Value.Type, LalParser.smethod_4(typeof(LalTypes.LalList).TypeHandle)))
									{
										arg_16D_0 = (num * 2624883420u ^ 1334639623u);
										continue;
									}
									goto IL_6E0;
								}
								goto Block_6;
							}
						}
						IL_19E:
						using (Dictionary<string, LalField>.Enumerator enumerator2 = ((LalTypes.LalList)current.Value.Value).Fields.GetEnumerator())
						{
							while (true)
							{
								IL_39B:
								uint arg_356_0 = (!enumerator2.MoveNext()) ? 427631032u : 158090009u;
								while (true)
								{
									uint num;
									switch ((num = (arg_356_0 ^ 15419579u)) % 10u)
									{
									case 0u:
										arg_356_0 = 158090009u;
										continue;
									case 1u:
									{
										KeyValuePair<string, LalField> current2;
										LalParser.smethod_35(typeBuilder_2, current2.Key, current2.Value.Type, FieldAttributes.Public);
										arg_356_0 = 1967242083u;
										continue;
									}
									case 2u:
									{
										KeyValuePair<string, LalField> current2 = enumerator2.Current;
										arg_356_0 = ((!LalParser.smethod_31(current2.Value.Type)) ? 632281821u : 1208095778u);
										continue;
									}
									case 4u:
									{
										KeyValuePair<string, LalField> current2;
										arg_356_0 = ((current2.Value.Count != -1) ? 454254818u : 2028484060u);
										continue;
									}
									case 5u:
									{
										KeyValuePair<string, LalField> current2;
										arg_356_0 = ((!LalParser.smethod_33(current2.Value.CountField)) ? 1163462514u : 1513878685u);
										continue;
									}
									case 6u:
										goto IL_39B;
									case 7u:
									{
										KeyValuePair<string, LalField> current2;
										dictionary2.Add(Tuple.Create<string, string>(current.Key, current2.Key), current2.Value.CountField);
										arg_356_0 = (num * 2968662757u ^ 2968556817u);
										continue;
									}
									case 8u:
									{
										KeyValuePair<string, LalField> current2;
										arg_356_0 = ((LalParser.smethod_32(current2.Value.Type) ? 2022810550u : 1216053832u) ^ num * 1768732942u);
										continue;
									}
									case 9u:
									{
										KeyValuePair<string, LalField> current2;
										dictionary.Add(Tuple.Create<string, string>(current.Key, current2.Key), LalParser.smethod_34(current2.Value.Type, new object[]
										{
											current2.Value.Count
										}) as Array);
										arg_356_0 = (num * 1206323925u ^ 1991522769u);
										continue;
									}
									}
									goto Block_20;
								}
							}
							Block_20:;
						}
						type = LalParser.smethod_36(typeBuilder_2);
						goto IL_539;
						Block_6:
						goto IL_19E;
					}
					uint arg_677_0 = 227544863u;
					while (true)
					{
						IL_672:
						uint num;
						switch ((num = (arg_677_0 ^ 15419579u)) % 19u)
						{
						case 0u:
							dictionary.Add(Tuple.Create<string, string>(lalFile.TypeName, current.Key), LalParser.smethod_34(current.Value.Type, new object[]
							{
								current.Value.Count
							}) as Array);
							arg_677_0 = (num * 2191491227u ^ 2074769772u);
							continue;
						case 1u:
							LalParser.smethod_35(typeBuilder_, current.Key, type, FieldAttributes.Public);
							arg_677_0 = 231630780u;
							continue;
						case 2u:
							arg_677_0 = ((current.Value.Count == -1) ? 953902779u : 133976172u);
							continue;
						case 3u:
							arg_677_0 = (num * 3504080691u ^ 3491596885u);
							continue;
						case 4u:
							goto IL_702;
						case 5u:
							dictionary2.Add(Tuple.Create<string, string>(lalFile.TypeName, current.Key), current.Value.CountField);
							arg_677_0 = (num * 3936314229u ^ 2363937753u);
							continue;
						case 6u:
							type = LalParser.smethod_19(type);
							arg_677_0 = (num * 3687777923u ^ 1631836316u);
							continue;
						case 7u:
							dictionary2.Add(Tuple.Create<string, string>(typeName, current.Key), current.Value.CountField);
							arg_677_0 = (num * 1946601831u ^ 794486070u);
							continue;
						case 9u:
							goto IL_539;
						case 10u:
							dictionary.Add(Tuple.Create<string, string>(typeName, current.Key), LalParser.smethod_34(type, new object[]
							{
								current.Value.Count
							}) as Array);
							arg_677_0 = (num * 2392230552u ^ 2586742411u);
							continue;
						case 11u:
							arg_677_0 = (num * 3621362825u ^ 72620167u);
							continue;
						case 12u:
							arg_677_0 = ((LalParser.smethod_33(current.Value.CountField) ? 4223961564u : 3448767313u) ^ num * 2917935756u);
							continue;
						case 13u:
							arg_677_0 = ((LalParser.smethod_33(current.Value.CountField) ? 3085320494u : 2267419280u) ^ num * 4063420489u);
							continue;
						case 14u:
							goto IL_6E0;
						case 15u:
							type = LalParser.smethod_21(LalParser.smethod_4(typeof(List__).TypeHandle), new Type[]
							{
								type
							});
							arg_677_0 = (num * 866117937u ^ 641229923u);
							continue;
						case 16u:
							arg_677_0 = (num * 3593916999u ^ 1220321514u);
							continue;
						case 17u:
							LalParser.smethod_35(typeBuilder_, current.Key, current.Value.Type, FieldAttributes.Public);
							arg_677_0 = 1822950704u;
							continue;
						case 18u:
							arg_677_0 = ((current.Value.Count != -1) ? 1786420790u : 915152435u);
							continue;
						}
						goto Block_12;
					}
					IL_539:
					arg_677_0 = 1613233896u;
					goto IL_672;
					IL_6E0:
					arg_677_0 = ((!LalParser.smethod_31(current.Value.Type)) ? 915152435u : 535817718u);
					goto IL_672;
				}
				Block_12:;
			}
			return Tuple.Create<Type, Dictionary<Tuple<string, string>, Array>, Dictionary<Tuple<string, string>, string>, Arctium_WoW_ClientDB_Viewer.ClientDB.FileOptions>(LalParser.smethod_36(typeBuilder_), dictionary, dictionary2, lalFile.FileOptions);
			IL_735:
			return null;
			IL_A7:
			arg_B1_0 = 440927792u;
			goto IL_AC;
			IL_E3:
			typeName = lalFile.TypeName;
			arg_B1_0 = 2090040595u;
			goto IL_AC;
		}

		internal static IList CreateList(Type type)
		{
			return LalParser.smethod_37(LalParser.smethod_21(LalParser.smethod_4(typeof(List__).TypeHandle), new Type[]
			{
				type
			})) as IList;
		}

		static string smethod_0(string string_0)
		{
			return File.ReadAllText(string_0);
		}

		static Match smethod_1(string string_0, string string_1)
		{
			return Regex.Match(string_0, string_1);
		}

		static GroupCollection smethod_2(Match match_0)
		{
			return match_0.Groups;
		}

		static int smethod_3(GroupCollection groupCollection_0)
		{
			return groupCollection_0.Count;
		}

		static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static Group smethod_5(GroupCollection groupCollection_0, int int_0)
		{
			return groupCollection_0[int_0];
		}

		static string smethod_6(Capture capture_0)
		{
			return capture_0.Value;
		}

		static string smethod_7(string string_0, char[] char_0)
		{
			return string_0.Trim(char_0);
		}

		static object smethod_8(Type type_0, string string_0)
		{
			return Enum.Parse(type_0, string_0);
		}

		static string smethod_9(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static string smethod_10(string string_0, string string_1, string string_2)
		{
			return Regex.Replace(string_0, string_1, string_2);
		}

		static void smethod_11(string string_0)
		{
			Console.WriteLine(string_0);
		}

		static string[] smethod_12(string string_0, string[] string_1, StringSplitOptions stringSplitOptions_0)
		{
			return string_0.Split(string_1, stringSplitOptions_0);
		}

		static bool smethod_13(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}

		static MatchCollection smethod_14(string string_0, string string_1)
		{
			return Regex.Matches(string_0, string_1);
		}

		static IEnumerator smethod_15(MatchCollection matchCollection_0)
		{
			return matchCollection_0.GetEnumerator();
		}

		static object smethod_16(IEnumerator ienumerator_0)
		{
			return ienumerator_0.Current;
		}

		static bool smethod_17(string string_0, string string_1)
		{
			return string_0.Contains(string_1);
		}

		static string[] smethod_18(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		static Type smethod_19(Type type_0)
		{
			return type_0.MakeArrayType();
		}

		static bool smethod_20(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static Type smethod_21(Type type_0, Type[] type_1)
		{
			return type_0.MakeGenericType(type_1);
		}

		static bool smethod_22(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_23(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static AssemblyName smethod_24()
		{
			return new AssemblyName();
		}

		static void smethod_25(AssemblyName assemblyName_0, string string_0)
		{
			assemblyName_0.Name = string_0;
		}

		static AppDomain smethod_26()
		{
			return Thread.GetDomain();
		}

		static AssemblyBuilder smethod_27(AppDomain appDomain_0, AssemblyName assemblyName_0, AssemblyBuilderAccess assemblyBuilderAccess_0)
		{
			return appDomain_0.DefineDynamicAssembly(assemblyName_0, assemblyBuilderAccess_0);
		}

		static ModuleBuilder smethod_28(AssemblyBuilder assemblyBuilder_0, string string_0)
		{
			return assemblyBuilder_0.DefineDynamicModule(string_0);
		}

		static TypeBuilder smethod_29(ModuleBuilder moduleBuilder_0, string string_0, TypeAttributes typeAttributes_0, Type type_0)
		{
			return moduleBuilder_0.DefineType(string_0, typeAttributes_0, type_0);
		}

		static bool smethod_30(Type type_0, Type type_1)
		{
			return type_0 == type_1;
		}

		static bool smethod_31(Type type_0)
		{
			return type_0.IsArray;
		}

		static bool smethod_32(Type type_0)
		{
			return type_0.IsGenericType;
		}

		static bool smethod_33(string string_0)
		{
			return string.IsNullOrEmpty(string_0);
		}

		static object smethod_34(Type type_0, object[] object_0)
		{
			return Activator.CreateInstance(type_0, object_0);
		}

		static FieldBuilder smethod_35(TypeBuilder typeBuilder_0, string string_0, Type type_0, FieldAttributes fieldAttributes_0)
		{
			return typeBuilder_0.DefineField(string_0, type_0, fieldAttributes_0);
		}

		static Type smethod_36(TypeBuilder typeBuilder_0)
		{
			return typeBuilder_0.CreateType();
		}

		static object smethod_37(Type type_0)
		{
			return Activator.CreateInstance(type_0);
		}
	}
}
