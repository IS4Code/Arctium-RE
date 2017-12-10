using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class JsonFormatter
	{
		public sealed class Settings
		{
			public static JsonFormatter.Settings Default
			{
				[CompilerGenerated]
				get
				{
					return JsonFormatter.Settings.<Default>k__BackingField;
				}
			}

			public bool FormatDefaultValues
			{
				[CompilerGenerated]
				get
				{
					return this.<FormatDefaultValues>k__BackingField;
				}
			}

			public TypeRegistry TypeRegistry
			{
				[CompilerGenerated]
				get
				{
					return this.<TypeRegistry>k__BackingField;
				}
			}

			static Settings()
			{
				JsonFormatter.Settings.<Default>k__BackingField = new JsonFormatter.Settings(false);
			}

			public Settings(bool formatDefaultValues) : this(formatDefaultValues, TypeRegistry.Empty)
			{
			}

			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry)
			{
				while (true)
				{
					IL_39:
					uint arg_21_0 = 337738775u;
					while (true)
					{
						uint num;
						switch ((num = (arg_21_0 ^ 867835497u)) % 3u)
						{
						case 0u:
							goto IL_39;
						case 1u:
							this.<FormatDefaultValues>k__BackingField = formatDefaultValues;
							arg_21_0 = (num * 911724236u ^ 3093297566u);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				this.<TypeRegistry>k__BackingField = Preconditions.CheckNotNull<TypeRegistry>(typeRegistry, Module.smethod_34<string>(3473407542u));
			}
		}

		internal const string AnyTypeUrlField = "@type";

		internal const string AnyDiagnosticValueField = "@value";

		internal const string AnyWellKnownTypeValueField = "value";

		private const string TypeUrlPrefix = "type.googleapis.com";

		private const string NameValueSeparator = ": ";

		private const string PropertySeparator = ", ";

		private static readonly JsonFormatter diagnosticFormatter;

		private static readonly string[] CommonRepresentations;

		private readonly JsonFormatter.Settings settings;

		private const string Hex = "0123456789abcdef";

		public static JsonFormatter Default
		{
			[CompilerGenerated]
			get
			{
				return JsonFormatter.<Default>k__BackingField;
			}
		}

		static JsonFormatter()
		{
			JsonFormatter.<Default>k__BackingField = new JsonFormatter(JsonFormatter.Settings.Default);
			while (true)
			{
				IL_882:
				uint arg_84D_0 = 2105186147u;
				while (true)
				{
					uint num;
					switch ((num = (arg_84D_0 ^ 234456420u)) % 10u)
					{
					case 0u:
					{
						int num2;
						arg_84D_0 = (JsonFormatter.smethod_0(JsonFormatter.CommonRepresentations[num2], "") ? 720579340u : 12377199u);
						continue;
					}
					case 1u:
					{
						int num2;
						arg_84D_0 = ((num2 < JsonFormatter.CommonRepresentations.Length) ? 364004868u : 1489577538u);
						continue;
					}
					case 2u:
					{
						int num2;
						JsonFormatter.CommonRepresentations[num2] = ((char)num2).ToString();
						arg_84D_0 = (num * 3338840995u ^ 866146391u);
						continue;
					}
					case 3u:
						JsonFormatter.diagnosticFormatter = new JsonFormatter(JsonFormatter.Settings.Default);
						arg_84D_0 = (num * 3340594438u ^ 4021155467u);
						continue;
					case 5u:
						goto IL_882;
					case 6u:
						arg_84D_0 = (num * 1015052829u ^ 3531897317u);
						continue;
					case 7u:
					{
						int num2;
						num2++;
						arg_84D_0 = 141203301u;
						continue;
					}
					case 8u:
					{
						int num2 = 0;
						arg_84D_0 = (num * 120494982u ^ 3077917624u);
						continue;
					}
					case 9u:
						JsonFormatter.CommonRepresentations = new string[]
						{
							Module.smethod_35<string>(3735484591u),
							Module.smethod_36<string>(1127891634u),
							Module.smethod_36<string>(3787642865u),
							Module.smethod_33<string>(1601913941u),
							Module.smethod_36<string>(2763107699u),
							Module.smethod_35<string>(1525040782u),
							Module.smethod_37<string>(25233657u),
							Module.smethod_36<string>(589553280u),
							Module.smethod_36<string>(517210735u),
							Module.smethod_36<string>(175699013u),
							Module.smethod_34<string>(2250255420u),
							Module.smethod_35<string>(3861404913u),
							Module.smethod_33<string>(2573209709u),
							Module.smethod_37<string>(1456899246u),
							Module.smethod_36<string>(2939733328u),
							Module.smethod_35<string>(2266603047u),
							Module.smethod_35<string>(965520826u),
							Module.smethod_33<string>(3116461434u),
							Module.smethod_34<string>(309449935u),
							Module.smethod_34<string>(1312889300u),
							Module.smethod_34<string>(2316328665u),
							Module.smethod_35<string>(3301884957u),
							Module.smethod_34<string>(403186547u),
							Module.smethod_33<string>(3282715620u),
							Module.smethod_37<string>(2654821710u),
							Module.smethod_35<string>(3707565257u),
							Module.smethod_33<string>(4260568725u),
							Module.smethod_33<string>(3717317000u),
							Module.smethod_33<string>(4043268035u),
							Module.smethod_35<string>(2140682725u),
							Module.smethod_34<string>(3760787723u),
							Module.smethod_34<string>(844206240u),
							"",
							"",
							Module.smethod_35<string>(1623041770u),
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							Module.smethod_37<string>(2012035484u),
							"",
							Module.smethod_34<string>(3826860968u),
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							Module.smethod_34<string>(535333037u),
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							"",
							Module.smethod_33<string>(502295817u),
							Module.smethod_36<string>(1292777727u),
							Module.smethod_37<string>(4232521494u),
							Module.smethod_33<string>(1480148922u),
							Module.smethod_36<string>(3414190604u),
							Module.smethod_34<string>(4108070804u),
							Module.smethod_37<string>(1573726602u),
							Module.smethod_33<string>(3653155822u),
							Module.smethod_36<string>(2731167160u),
							Module.smethod_34<string>(3076968072u),
							Module.smethod_33<string>(1972354143u),
							Module.smethod_37<string>(3735828405u),
							Module.smethod_33<string>(2624256213u),
							Module.smethod_34<string>(3170704684u),
							Module.smethod_37<string>(2596349090u),
							Module.smethod_36<string>(1923659629u),
							Module.smethod_36<string>(971467008u),
							Module.smethod_34<string>(3639387744u),
							Module.smethod_36<string>(2875852250u),
							Module.smethod_35<string>(2896204657u),
							Module.smethod_37<string>(229740472u),
							Module.smethod_34<string>(2233338564u),
							Module.smethod_35<string>(2728405334u),
							Module.smethod_33<string>(278437790u),
							Module.smethod_34<string>(1323635811u),
							Module.smethod_36<string>(3052477879u),
							Module.smethod_36<string>(734238370u),
							Module.smethod_37<string>(2187305989u),
							Module.smethod_34<string>(1792318871u),
							Module.smethod_35<string>(1553243435u),
							Module.smethod_35<string>(252161214u),
							Module.smethod_36<string>(1148092637u),
							Module.smethod_34<string>(386269691u)
						};
						arg_84D_0 = (num * 2032237027u ^ 2587709937u);
						continue;
					}
					return;
				}
			}
		}

		public JsonFormatter(JsonFormatter.Settings settings)
		{
			this.settings = settings;
		}

		public string Format(IMessage message)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_37<string>(1018619835u));
			StringBuilder stringBuilder = JsonFormatter.smethod_1();
			if (message.Descriptor.IsWellKnownType)
			{
				goto IL_53;
			}
			goto IL_7D;
			uint arg_5D_0;
			while (true)
			{
				IL_58:
				uint num;
				switch ((num = (arg_5D_0 ^ 1893909843u)) % 5u)
				{
				case 0u:
					goto IL_53;
				case 2u:
					goto IL_7D;
				case 3u:
					arg_5D_0 = (num * 3650264944u ^ 2709657310u);
					continue;
				case 4u:
					this.WriteWellKnownTypeValue(stringBuilder, message.Descriptor, message, false);
					arg_5D_0 = (num * 572768486u ^ 1430449262u);
					continue;
				}
				break;
			}
			return JsonFormatter.smethod_2(stringBuilder);
			IL_53:
			arg_5D_0 = 326038624u;
			goto IL_58;
			IL_7D:
			this.WriteMessage(stringBuilder, message);
			arg_5D_0 = 448933710u;
			goto IL_58;
		}

		public static string ToDiagnosticString(IMessage message)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_33<string>(879293356u));
			return JsonFormatter.diagnosticFormatter.Format(message);
		}

		private void WriteMessage(StringBuilder builder, IMessage message)
		{
			if (message == null)
			{
				goto IL_03;
			}
			goto IL_42;
			uint arg_22_0;
			while (true)
			{
				IL_1D:
				uint num;
				switch ((num = (arg_22_0 ^ 1191668176u)) % 5u)
				{
				case 0u:
					return;
				case 1u:
					JsonFormatter.WriteNull(builder);
					arg_22_0 = (num * 3769227776u ^ 1774658636u);
					continue;
				case 3u:
					goto IL_03;
				case 4u:
					goto IL_42;
				}
				break;
			}
			bool flag;
			JsonFormatter.smethod_3(builder, flag ? Module.smethod_33<string>(553342321u) : Module.smethod_37<string>(2801062202u));
			return;
			IL_03:
			arg_22_0 = 353656167u;
			goto IL_1D;
			IL_42:
			JsonFormatter.smethod_3(builder, Module.smethod_33<string>(1205244391u));
			flag = this.WriteMessageFields(builder, message, false);
			arg_22_0 = 781025262u;
			goto IL_1D;
		}

		private bool WriteMessageFields(StringBuilder builder, IMessage message, bool assumeFirstFieldWritten)
		{
			MessageDescriptor.FieldCollection arg_10_0 = message.Descriptor.Fields;
			bool flag = !assumeFirstFieldWritten;
			IEnumerator<FieldDescriptor> enumerator = arg_10_0.InFieldNumberOrder().GetEnumerator();
			try
			{
				while (true)
				{
					IL_2DC:
					uint arg_277_0 = (!JsonFormatter.smethod_4(enumerator)) ? 1402409953u : 165060205u;
					while (true)
					{
						uint num;
						switch ((num = (arg_277_0 ^ 1026981942u)) % 18u)
						{
						case 0u:
							goto IL_2DC;
						case 1u:
						{
							IFieldAccessor accessor;
							this.WriteString(builder, JsonFormatter.ToCamelCase(accessor.Descriptor.Name));
							arg_277_0 = 2158668u;
							continue;
						}
						case 2u:
							JsonFormatter.smethod_3(builder, Module.smethod_35<string>(1861489385u));
							arg_277_0 = (num * 1604822745u ^ 4165754308u);
							continue;
						case 3u:
						{
							FieldDescriptor current;
							arg_277_0 = (((current.ContainingOneof == null) ? 3993627330u : 4061494123u) ^ num * 2698464613u);
							continue;
						}
						case 4u:
						{
							FieldDescriptor current;
							arg_277_0 = ((current.IsMap ? 557618324u : 1346986289u) ^ num * 3523831294u);
							continue;
						}
						case 5u:
							arg_277_0 = 165060205u;
							continue;
						case 6u:
						{
							FieldDescriptor current;
							arg_277_0 = (((current.ContainingOneof.Accessor.GetCaseFieldDescriptor(message) == current) ? 1639784039u : 1485527544u) ^ num * 102455092u);
							continue;
						}
						case 7u:
							arg_277_0 = ((this.settings.FormatDefaultValues ? 3114586957u : 2496116398u) ^ num * 366372929u);
							continue;
						case 8u:
						{
							object value;
							this.WriteValue(builder, value);
							arg_277_0 = (num * 706076324u ^ 2679077334u);
							continue;
						}
						case 9u:
						{
							IFieldAccessor accessor;
							object value = accessor.GetValue(message);
							FieldDescriptor current;
							arg_277_0 = ((current.ContainingOneof == null) ? 1199652783u : 1019682452u);
							continue;
						}
						case 10u:
							arg_277_0 = ((!flag) ? 728559882u : 177645191u);
							continue;
						case 11u:
						{
							IFieldAccessor accessor;
							object value;
							arg_277_0 = ((JsonFormatter.IsDefaultValue(accessor, value) ? 3374691353u : 2561747861u) ^ num * 2582743489u);
							continue;
						}
						case 12u:
							JsonFormatter.smethod_3(builder, Module.smethod_33<string>(770643011u));
							arg_277_0 = (num * 3177800768u ^ 2732923271u);
							continue;
						case 13u:
						{
							FieldDescriptor current = enumerator.Current;
							IFieldAccessor accessor = current.Accessor;
							arg_277_0 = 1838540119u;
							continue;
						}
						case 14u:
							flag = false;
							arg_277_0 = (num * 1748852978u ^ 4087060504u);
							continue;
						case 16u:
						{
							FieldDescriptor current;
							arg_277_0 = ((!current.IsRepeated) ? 43422670u : 1297104004u);
							continue;
						}
						case 17u:
						{
							object value;
							arg_277_0 = (((!this.CanWriteSingleValue(value)) ? 79996240u : 617027788u) ^ num * 3622050552u);
							continue;
						}
						}
						goto Block_12;
					}
				}
				Block_12:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_322:
						uint arg_309_0 = 806593370u;
						while (true)
						{
							uint num;
							switch ((num = (arg_309_0 ^ 1026981942u)) % 3u)
							{
							case 0u:
								goto IL_322;
							case 1u:
								JsonFormatter.smethod_5(enumerator);
								arg_309_0 = (num * 1467593674u ^ 3772019397u);
								continue;
							}
							goto Block_16;
						}
					}
					Block_16:;
				}
			}
			return !flag;
		}

		internal static string ToCamelCase(string input)
		{
			bool flag = false;
			bool flag2 = true;
			bool flag3 = false;
			bool flag4 = true;
			StringBuilder stringBuilder;
			while (true)
			{
				IL_375:
				uint arg_2FF_0 = 206191107u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2FF_0 ^ 1595978530u)) % 26u)
					{
					case 0u:
						arg_2FF_0 = (flag ? 1603620348u : 2116974277u);
						continue;
					case 1u:
						arg_2FF_0 = (num * 921501118u ^ 2646579005u);
						continue;
					case 2u:
					{
						int num2;
						flag3 = char.IsUpper(JsonFormatter.smethod_8(input, num2));
						arg_2FF_0 = ((JsonFormatter.smethod_8(input, num2) != '_') ? 2014014175u : 1522825025u);
						continue;
					}
					case 3u:
						stringBuilder = JsonFormatter.smethod_7(JsonFormatter.smethod_6(input));
						arg_2FF_0 = (num * 3404772411u ^ 3836015716u);
						continue;
					case 5u:
					{
						int num2;
						arg_2FF_0 = ((num2 >= JsonFormatter.smethod_6(input)) ? 129582978u : 1556003292u);
						continue;
					}
					case 6u:
						flag2 = flag3;
						arg_2FF_0 = (num * 3401987335u ^ 3236208019u);
						continue;
					case 7u:
						arg_2FF_0 = (((!(JsonFormatter.smethod_9(stringBuilder) != 0 & flag3)) ? 1074442757u : 1398498653u) ^ num * 1659372825u);
						continue;
					case 8u:
					{
						int num2;
						JsonFormatter.smethod_10(stringBuilder, char.ToUpperInvariant(JsonFormatter.smethod_8(input, num2)));
						arg_2FF_0 = (num * 1223792315u ^ 4255231802u);
						continue;
					}
					case 9u:
						flag4 = false;
						arg_2FF_0 = 124173991u;
						continue;
					case 10u:
					{
						int num2;
						arg_2FF_0 = (((!char.IsLower(JsonFormatter.smethod_8(input, num2 + 1))) ? 1610385050u : 872322695u) ^ num * 1535989244u);
						continue;
					}
					case 11u:
					{
						int num2 = 0;
						arg_2FF_0 = (num * 876724130u ^ 3224443425u);
						continue;
					}
					case 12u:
						arg_2FF_0 = (num * 481699166u ^ 3413616311u);
						continue;
					case 13u:
					{
						int num2;
						num2++;
						arg_2FF_0 = 1241253698u;
						continue;
					}
					case 14u:
						arg_2FF_0 = ((flag2 ? 3299883306u : 3839360487u) ^ num * 4167389073u);
						continue;
					case 15u:
						arg_2FF_0 = (num * 453685883u ^ 3547237922u);
						continue;
					case 16u:
					{
						int num2;
						arg_2FF_0 = (((num2 + 1 >= JsonFormatter.smethod_6(input)) ? 1237449138u : 1995674580u) ^ num * 3175157116u);
						continue;
					}
					case 17u:
						flag = true;
						arg_2FF_0 = (num * 3244509933u ^ 5483590u);
						continue;
					case 18u:
						arg_2FF_0 = (num * 708484385u ^ 3542515945u);
						continue;
					case 19u:
						flag4 = false;
						arg_2FF_0 = (num * 1710123292u ^ 65179576u);
						continue;
					case 20u:
					{
						int num2;
						JsonFormatter.smethod_10(stringBuilder, char.ToLowerInvariant(JsonFormatter.smethod_8(input, num2)));
						arg_2FF_0 = 802972479u;
						continue;
					}
					case 21u:
						arg_2FF_0 = (flag4 ? 286125421u : 1997697216u);
						continue;
					case 22u:
					{
						flag = false;
						int num2;
						arg_2FF_0 = ((char.IsLower(JsonFormatter.smethod_8(input, num2)) ? 102838578u : 10531385u) ^ num * 2992309858u);
						continue;
					}
					case 23u:
						arg_2FF_0 = (((JsonFormatter.smethod_9(stringBuilder) == 0) ? 1531264032u : 2039260088u) ^ num * 3332678773u);
						continue;
					case 24u:
						goto IL_375;
					case 25u:
					{
						int num2;
						JsonFormatter.smethod_10(stringBuilder, JsonFormatter.smethod_8(input, num2));
						arg_2FF_0 = 802972479u;
						continue;
					}
					}
					goto Block_11;
				}
			}
			Block_11:
			return JsonFormatter.smethod_2(stringBuilder);
		}

		private static void WriteNull(StringBuilder builder)
		{
			JsonFormatter.smethod_3(builder, Module.smethod_37<string>(2976185352u));
		}

		private static bool IsDefaultValue(IFieldAccessor accessor, object value)
		{
			if (accessor.Descriptor.IsMap)
			{
				goto IL_80;
			}
			goto IL_F9;
			uint arg_99_0;
			while (true)
			{
				IL_94:
				uint num;
				switch ((num = (arg_99_0 ^ 4280658443u)) % 17u)
				{
				case 0u:
					goto IL_139;
				case 1u:
					goto IL_18B;
				case 2u:
					goto IL_14B;
				case 3u:
					goto IL_10B;
				case 4u:
					goto IL_19C;
				case 5u:
					goto IL_16B;
				case 6u:
					goto IL_175;
				case 7u:
					arg_99_0 = (num * 3683522956u ^ 3727520145u);
					continue;
				case 8u:
					goto IL_11A;
				case 9u:
					goto IL_159;
				case 11u:
					goto IL_1A6;
				case 12u:
					goto IL_F9;
				case 13u:
					goto IL_80;
				case 14u:
					goto IL_186;
				case 15u:
					goto IL_1B8;
				case 16u:
					switch (accessor.Descriptor.FieldType)
					{
					case FieldType.Double:
						goto IL_139;
					case FieldType.Float:
						goto IL_14B;
					case FieldType.Int64:
					case FieldType.SFixed64:
					case FieldType.SInt64:
						goto IL_1A6;
					case FieldType.UInt64:
					case FieldType.Fixed64:
						goto IL_159;
					case FieldType.Int32:
					case FieldType.SFixed32:
					case FieldType.SInt32:
					case FieldType.Enum:
						goto IL_1B8;
					case FieldType.Fixed32:
					case FieldType.UInt32:
						goto IL_19C;
					case FieldType.Bool:
						goto IL_16B;
					case FieldType.String:
						goto IL_175;
					case FieldType.Group:
					case FieldType.Message:
						goto IL_186;
					case FieldType.Bytes:
						goto IL_18B;
					default:
						arg_99_0 = 4078190519u;
						continue;
					}
					break;
				}
				break;
			}
			goto IL_129;
			IL_10B:
			return JsonFormatter.smethod_11((IList)value) == 0;
			IL_11A:
			return JsonFormatter.smethod_11((IDictionary)value) == 0;
			IL_129:
			throw JsonFormatter.smethod_12(Module.smethod_37<string>(3706621566u));
			IL_139:
			return (double)value == 0.0;
			IL_14B:
			return (float)value == 0f;
			IL_159:
			return (ulong)value == 0uL;
			IL_16B:
			return !(bool)value;
			IL_175:
			return JsonFormatter.smethod_0((string)value, "");
			IL_186:
			return value == null;
			IL_18B:
			return (ByteString)value == ByteString.Empty;
			IL_19C:
			return (uint)value == 0u;
			IL_1A6:
			return (long)value == 0L;
			IL_1B8:
			return (int)value == 0;
			IL_80:
			arg_99_0 = 3224821924u;
			goto IL_94;
			IL_F9:
			arg_99_0 = (accessor.Descriptor.IsRepeated ? 3955385819u : 2280332705u);
			goto IL_94;
		}

		private void WriteValue(StringBuilder builder, object value)
		{
			if (value == null)
			{
				goto IL_3D0;
			}
			goto IL_514;
			uint arg_443_0;
			IMessage message;
			while (true)
			{
				IL_43E:
				uint num;
				switch ((num = (arg_443_0 ^ 1621593297u)) % 45u)
				{
				case 0u:
				{
					IFormattable iformattable_;
					JsonFormatter.smethod_3(builder, JsonFormatter.smethod_14(iformattable_, Module.smethod_37<string>(463483597u), JsonFormatter.smethod_13()));
					JsonFormatter.smethod_10(builder, '"');
					arg_443_0 = (num * 1120607371u ^ 1237620014u);
					continue;
				}
				case 1u:
				{
					string string_;
					arg_443_0 = ((JsonFormatter.smethod_0(string_, Module.smethod_33<string>(2067889814u)) ? 1470280542u : 1344471735u) ^ num * 3801585783u);
					continue;
				}
				case 2u:
					goto IL_3D0;
				case 3u:
					JsonFormatter.smethod_10(builder, '"');
					arg_443_0 = 675135676u;
					continue;
				case 4u:
				{
					string string_;
					JsonFormatter.smethod_3(builder, string_);
					arg_443_0 = 1962219002u;
					continue;
				}
				case 5u:
					JsonFormatter.smethod_10(builder, '"');
					arg_443_0 = 285065u;
					continue;
				case 6u:
				{
					string string_;
					JsonFormatter.smethod_3(builder, string_);
					arg_443_0 = (num * 2637677370u ^ 484980000u);
					continue;
				}
				case 7u:
				{
					string string_ = JsonFormatter.smethod_14((IFormattable)value, Module.smethod_37<string>(2830180628u), JsonFormatter.smethod_13());
					arg_443_0 = 2014343763u;
					continue;
				}
				case 8u:
					arg_443_0 = ((value is IList) ? 562811476u : 580610538u);
					continue;
				case 9u:
					return;
				case 10u:
					arg_443_0 = (((!(value is ulong)) ? 894267377u : 2111319714u) ^ num * 2039564499u);
					continue;
				case 11u:
					arg_443_0 = ((value is IMessage) ? 612800465u : 780826631u);
					continue;
				case 12u:
				{
					string string_;
					arg_443_0 = (((!JsonFormatter.smethod_0(string_, Module.smethod_36<string>(1747034000u))) ? 789481878u : 1261914176u) ^ num * 2487908142u);
					continue;
				}
				case 13u:
					return;
				case 14u:
					return;
				case 15u:
					arg_443_0 = ((message.Descriptor.IsWellKnownType ? 3939740412u : 2493888616u) ^ num * 2958175161u);
					continue;
				case 16u:
				{
					IFormattable iformattable_2 = (IFormattable)value;
					JsonFormatter.smethod_3(builder, JsonFormatter.smethod_14(iformattable_2, Module.smethod_36<string>(3197162969u), JsonFormatter.smethod_13()));
					arg_443_0 = 938862962u;
					continue;
				}
				case 17u:
					goto IL_524;
				case 18u:
					this.WriteString(builder, (string)value);
					arg_443_0 = (num * 3748833977u ^ 3700612484u);
					continue;
				case 19u:
					arg_443_0 = ((!(value is float)) ? 1392691437u : 1811379471u);
					continue;
				case 20u:
					goto IL_514;
				case 21u:
				{
					string string_;
					arg_443_0 = (((!JsonFormatter.smethod_0(string_, Module.smethod_36<string>(3040738343u))) ? 2083151485u : 747813150u) ^ num * 3475292503u);
					continue;
				}
				case 22u:
					this.WriteString(builder, JsonFormatter.smethod_2(value));
					arg_443_0 = (num * 134500564u ^ 3861462201u);
					continue;
				case 23u:
					arg_443_0 = ((!(value is string)) ? 2137321841u : 113335327u);
					continue;
				case 24u:
					return;
				case 25u:
					return;
				case 27u:
					arg_443_0 = ((value is System.Enum) ? 1354778316u : 969072339u);
					continue;
				case 28u:
					goto IL_567;
				case 29u:
					arg_443_0 = (((value is uint) ? 3782599111u : 3277769563u) ^ num * 779659031u);
					continue;
				case 30u:
					goto IL_575;
				case 31u:
					arg_443_0 = ((!(value is IDictionary)) ? 281656066u : 961388721u);
					continue;
				case 32u:
					this.WriteMessage(builder, (IMessage)value);
					arg_443_0 = 1501640264u;
					continue;
				case 33u:
					goto IL_585;
				case 34u:
					return;
				case 35u:
				{
					IFormattable iformattable_ = (IFormattable)value;
					arg_443_0 = (num * 884156031u ^ 613677387u);
					continue;
				}
				case 36u:
					this.WriteList(builder, (IList)value);
					arg_443_0 = (num * 1369545683u ^ 1933103671u);
					continue;
				case 37u:
					goto IL_590;
				case 38u:
					message = (IMessage)value;
					arg_443_0 = (num * 3377440258u ^ 549686281u);
					continue;
				case 39u:
					arg_443_0 = ((value is int) ? 1147142102u : 496046534u);
					continue;
				case 40u:
					arg_443_0 = ((value is ByteString) ? 958105146u : 746957512u);
					continue;
				case 41u:
					arg_443_0 = ((!(value is long)) ? 1056076373u : 14796910u);
					continue;
				case 42u:
					goto IL_597;
				case 43u:
					return;
				case 44u:
					arg_443_0 = (((value is double) ? 1158894087u : 1118235386u) ^ num * 426890782u);
					continue;
				}
				break;
			}
			goto IL_54C;
			IL_524:
			JsonFormatter.smethod_3(builder, ((bool)value) ? Module.smethod_36<string>(3538674691u) : Module.smethod_34<string>(1042425975u));
			return;
			IL_54C:
			throw JsonFormatter.smethod_12(JsonFormatter.smethod_16(Module.smethod_35<string>(4267368532u), JsonFormatter.smethod_15(value)));
			IL_567:
			this.WriteDictionary(builder, (IDictionary)value);
			return;
			IL_575:
			this.WriteWellKnownTypeValue(builder, message.Descriptor, value, true);
			return;
			IL_585:
			JsonFormatter.smethod_10(builder, '"');
			return;
			IL_590:
			JsonFormatter.WriteNull(builder);
			return;
			IL_597:
			JsonFormatter.smethod_10(builder, '"');
			JsonFormatter.smethod_3(builder, ((ByteString)value).ToBase64());
			JsonFormatter.smethod_10(builder, '"');
			return;
			IL_3D0:
			arg_443_0 = 1786467716u;
			goto IL_43E;
			IL_514:
			arg_443_0 = ((!(value is bool)) ? 1455669594u : 1677959900u);
			goto IL_43E;
		}

		private void WriteWellKnownTypeValue(StringBuilder builder, MessageDescriptor descriptor, object value, bool inField)
		{
			if (value == null)
			{
				goto IL_1BC;
			}
			goto IL_388;
			uint arg_2F8_0;
			while (true)
			{
				IL_2F3:
				uint num;
				switch ((num = (arg_2F8_0 ^ 4090170974u)) % 29u)
				{
				case 0u:
					return;
				case 1u:
					JsonFormatter.WriteNull(builder);
					arg_2F8_0 = (num * 1877992003u ^ 2773682643u);
					continue;
				case 2u:
					arg_2F8_0 = (JsonFormatter.smethod_0(descriptor.FullName, Timestamp.Descriptor.FullName) ? 3217486200u : 3574881537u);
					continue;
				case 3u:
					this.MaybeWrapInString(builder, value, new Action<StringBuilder, IMessage>(this.WriteDuration), inField);
					arg_2F8_0 = (num * 1829125597u ^ 3222558612u);
					continue;
				case 4u:
					goto IL_396;
				case 5u:
					this.WriteStruct(builder, (IMessage)value);
					arg_2F8_0 = (num * 3774375972u ^ 556406196u);
					continue;
				case 6u:
					arg_2F8_0 = (((value is IMessage) ? 1912902122u : 582492792u) ^ num * 2564002733u);
					continue;
				case 7u:
					arg_2F8_0 = (JsonFormatter.smethod_0(descriptor.FullName, Any.Descriptor.FullName) ? 3536211615u : 3571490622u);
					continue;
				case 8u:
					this.WriteMessage(builder, (IMessage)value);
					arg_2F8_0 = 4077993154u;
					continue;
				case 9u:
					return;
				case 10u:
					return;
				case 11u:
					goto IL_388;
				case 12u:
					arg_2F8_0 = (JsonFormatter.smethod_0(descriptor.FullName, Duration.Descriptor.FullName) ? 3268657528u : 3448284902u);
					continue;
				case 13u:
					goto IL_1BC;
				case 14u:
					return;
				case 15u:
				{
					IFieldAccessor accessor;
					this.WriteList(builder, (IList)accessor.GetValue((IMessage)value));
					arg_2F8_0 = (num * 2611565836u ^ 2501006461u);
					continue;
				}
				case 16u:
				{
					IMessage message = (IMessage)value;
					value = message.Descriptor.Fields[1].Accessor.GetValue(message);
					arg_2F8_0 = (num * 3798110305u ^ 2388251596u);
					continue;
				}
				case 17u:
					goto IL_3A7;
				case 18u:
					return;
				case 19u:
					arg_2F8_0 = (JsonFormatter.smethod_0(descriptor.FullName, ListValue.Descriptor.FullName) ? 4208204463u : 2536632612u);
					continue;
				case 21u:
					arg_2F8_0 = (JsonFormatter.smethod_0(descriptor.FullName, Value.Descriptor.FullName) ? 3288729026u : 4209721692u);
					continue;
				case 22u:
					return;
				case 23u:
				{
					IFieldAccessor accessor = descriptor.Fields[1].Accessor;
					arg_2F8_0 = (num * 1635729332u ^ 795913930u);
					continue;
				}
				case 24u:
					this.MaybeWrapInString(builder, value, new Action<StringBuilder, IMessage>(this.WriteFieldMask), inField);
					arg_2F8_0 = (num * 3076190033u ^ 1309081541u);
					continue;
				case 25u:
					arg_2F8_0 = ((!JsonFormatter.smethod_0(descriptor.FullName, Struct.Descriptor.FullName)) ? 3703239507u : 2834781220u);
					continue;
				case 26u:
					arg_2F8_0 = ((!JsonFormatter.smethod_0(descriptor.FullName, FieldMask.Descriptor.FullName)) ? 3068033736u : 2240089743u);
					continue;
				case 27u:
					goto IL_3B8;
				case 28u:
					this.MaybeWrapInString(builder, value, new Action<StringBuilder, IMessage>(this.WriteTimestamp), inField);
					arg_2F8_0 = (num * 2100669825u ^ 2573983994u);
					continue;
				}
				break;
			}
			return;
			IL_396:
			this.WriteStructFieldValue(builder, (IMessage)value);
			return;
			IL_3A7:
			this.WriteAny(builder, (IMessage)value);
			return;
			IL_3B8:
			this.WriteValue(builder, value);
			return;
			IL_1BC:
			arg_2F8_0 = 2577887678u;
			goto IL_2F3;
			IL_388:
			arg_2F8_0 = (descriptor.IsWrapperType ? 3493451338u : 2533086339u);
			goto IL_2F3;
		}

		private void MaybeWrapInString(StringBuilder builder, object value, Action<StringBuilder, IMessage> action, bool inField)
		{
			if (inField)
			{
				goto IL_2B;
			}
			goto IL_71;
			uint arg_4D_0;
			while (true)
			{
				IL_48:
				uint num;
				switch ((num = (arg_4D_0 ^ 1284980570u)) % 6u)
				{
				case 0u:
					JsonFormatter.smethod_10(builder, '"');
					arg_4D_0 = (num * 1954168205u ^ 746514839u);
					continue;
				case 2u:
					goto IL_2B;
				case 3u:
					JsonFormatter.smethod_10(builder, '"');
					action(builder, (IMessage)value);
					arg_4D_0 = (num * 3070723735u ^ 4181027863u);
					continue;
				case 4u:
					goto IL_71;
				case 5u:
					return;
				}
				break;
			}
			return;
			IL_2B:
			arg_4D_0 = 271489915u;
			goto IL_48;
			IL_71:
			action(builder, (IMessage)value);
			arg_4D_0 = 1770649979u;
			goto IL_48;
		}

		private void WriteTimestamp(StringBuilder builder, IMessage value)
		{
			int nanoseconds = (int)value.Descriptor.Fields[2].Accessor.GetValue(value);
			while (true)
			{
				IL_DD:
				uint arg_BD_0 = 1940827272u;
				while (true)
				{
					uint num;
					switch ((num = (arg_BD_0 ^ 1468087769u)) % 5u)
					{
					case 0u:
						goto IL_DD;
					case 1u:
					{
						Timestamp timestamp;
						JsonFormatter.AppendNanoseconds(builder, Math.Abs(timestamp.Nanos));
						builder.Append('Z');
						arg_BD_0 = (num * 3455065510u ^ 1115450730u);
						continue;
					}
					case 2u:
					{
						DateTime dateTime;
						builder.Append(dateTime.ToString(Module.smethod_33<string>(3806295334u), JsonFormatter.smethod_13()));
						arg_BD_0 = (num * 1009534176u ^ 525238786u);
						continue;
					}
					case 4u:
					{
						Timestamp timestamp = Timestamp.Normalize((long)value.Descriptor.Fields[1].Accessor.GetValue(value), nanoseconds);
						DateTime dateTime = timestamp.ToDateTime();
						arg_BD_0 = (num * 3588276034u ^ 1685304037u);
						continue;
					}
					}
					return;
				}
			}
		}

		private void WriteDuration(StringBuilder builder, IMessage value)
		{
			int nanoseconds = (int)value.Descriptor.Fields[2].Accessor.GetValue(value);
			while (true)
			{
				IL_13F:
				uint arg_117_0 = 4253338763u;
				while (true)
				{
					uint num;
					switch ((num = (arg_117_0 ^ 2255544103u)) % 7u)
					{
					case 0u:
						goto IL_13F;
					case 1u:
					{
						Duration duration;
						arg_117_0 = (((duration.Nanos >= 0) ? 3724940179u : 2907188943u) ^ num * 1078750781u);
						continue;
					}
					case 2u:
						JsonFormatter.smethod_10(builder, '-');
						arg_117_0 = (num * 2905510713u ^ 469180835u);
						continue;
					case 3u:
					{
						Duration duration;
						builder.Append(duration.Seconds.ToString(Module.smethod_34<string>(4146480682u), JsonFormatter.smethod_13()));
						JsonFormatter.AppendNanoseconds(builder, Math.Abs(duration.Nanos));
						builder.Append('s');
						arg_117_0 = 3210663445u;
						continue;
					}
					case 5u:
					{
						Duration duration = Duration.Normalize((long)value.Descriptor.Fields[1].Accessor.GetValue(value), nanoseconds);
						arg_117_0 = (num * 802476659u ^ 1779589909u);
						continue;
					}
					case 6u:
					{
						Duration duration;
						arg_117_0 = (((duration.Seconds == 0L) ? 1033999782u : 709844870u) ^ num * 1922538178u);
						continue;
					}
					}
					return;
				}
			}
		}

		private void WriteFieldMask(StringBuilder builder, IMessage value)
		{
			IList source = (IList)value.Descriptor.Fields[1].Accessor.GetValue(value);
			while (true)
			{
				IL_7B:
				uint arg_63_0 = 374105818u;
				while (true)
				{
					uint num;
					switch ((num = (arg_63_0 ^ 690287539u)) % 3u)
					{
					case 1u:
						this.AppendEscapedString(builder, JsonFormatter.smethod_17(Module.smethod_35<string>(3357156987u), source.Cast<string>().Select(new Func<string, string>(JsonFormatter.ToCamelCase))));
						arg_63_0 = (num * 3001847033u ^ 2578035016u);
						continue;
					case 2u:
						goto IL_7B;
					}
					return;
				}
			}
		}

		private void WriteAny(StringBuilder builder, IMessage value)
		{
			if (this == JsonFormatter.diagnosticFormatter)
			{
				goto IL_123;
			}
			goto IL_22E;
			uint arg_1D8_0;
			string text;
			string typeName;
			ByteString data;
			while (true)
			{
				IL_1D3:
				uint num;
				switch ((num = (arg_1D8_0 ^ 2944959968u)) % 18u)
				{
				case 0u:
					JsonFormatter.smethod_3(builder, Module.smethod_36<string>(2189550737u));
					arg_1D8_0 = (num * 2502956005u ^ 315454798u);
					continue;
				case 1u:
					this.WriteString(builder, Module.smethod_34<string>(264869712u));
					arg_1D8_0 = (num * 2227417492u ^ 1566934416u);
					continue;
				case 2u:
					JsonFormatter.smethod_3(builder, Module.smethod_33<string>(1205244391u));
					arg_1D8_0 = (num * 229784025u ^ 1737445429u);
					continue;
				case 3u:
					goto IL_22E;
				case 4u:
				{
					MessageDescriptor messageDescriptor;
					arg_1D8_0 = ((messageDescriptor.IsWellKnownType ? 940325233u : 382285410u) ^ num * 1420331474u);
					continue;
				}
				case 6u:
					this.WriteString(builder, text);
					arg_1D8_0 = (num * 2231002834u ^ 497954846u);
					continue;
				case 7u:
					goto IL_123;
				case 8u:
				{
					MessageDescriptor messageDescriptor;
					IMessage message;
					this.WriteWellKnownTypeValue(builder, messageDescriptor, message, true);
					arg_1D8_0 = (num * 2850913905u ^ 1569957665u);
					continue;
				}
				case 9u:
					this.WriteString(builder, Module.smethod_36<string>(1095253436u));
					arg_1D8_0 = (num * 3488007177u ^ 3626640480u);
					continue;
				case 10u:
				{
					IMessage message;
					this.WriteMessageFields(builder, message, true);
					arg_1D8_0 = 3120906837u;
					continue;
				}
				case 11u:
					JsonFormatter.smethod_3(builder, Module.smethod_37<string>(2625673813u));
					arg_1D8_0 = (num * 1893406148u ^ 1239828248u);
					continue;
				case 12u:
				{
					typeName = JsonFormatter.GetTypeName(text);
					MessageDescriptor messageDescriptor = this.settings.TypeRegistry.Find(typeName);
					arg_1D8_0 = (((messageDescriptor == null) ? 1883758825u : 634719812u) ^ num * 3697141193u);
					continue;
				}
				case 13u:
					return;
				case 14u:
				{
					MessageDescriptor messageDescriptor;
					IMessage message = messageDescriptor.Parser.ParseFrom(data);
					arg_1D8_0 = 4184464822u;
					continue;
				}
				case 15u:
					goto IL_28E;
				case 16u:
					this.WriteDiagnosticOnlyAny(builder, value);
					arg_1D8_0 = (num * 1942897562u ^ 2064551389u);
					continue;
				case 17u:
					JsonFormatter.smethod_3(builder, Module.smethod_33<string>(770643011u));
					arg_1D8_0 = (num * 2989998736u ^ 3277770459u);
					continue;
				}
				break;
			}
			JsonFormatter.smethod_3(builder, Module.smethod_34<string>(573742915u));
			return;
			IL_28E:
			throw JsonFormatter.smethod_19(JsonFormatter.smethod_18(Module.smethod_37<string>(1193978753u), new object[]
			{
				typeName
			}));
			IL_123:
			arg_1D8_0 = 2335350580u;
			goto IL_1D3;
			IL_22E:
			text = (string)value.Descriptor.Fields[1].Accessor.GetValue(value);
			data = (ByteString)value.Descriptor.Fields[2].Accessor.GetValue(value);
			arg_1D8_0 = 3794430646u;
			goto IL_1D3;
		}

		private void WriteDiagnosticOnlyAny(StringBuilder builder, IMessage value)
		{
			string text = (string)value.Descriptor.Fields[1].Accessor.GetValue(value);
			while (true)
			{
				IL_15F:
				uint arg_133_0 = 2392209720u;
				while (true)
				{
					uint num;
					switch ((num = (arg_133_0 ^ 3870517497u)) % 8u)
					{
					case 0u:
						goto IL_15F;
					case 1u:
					{
						ByteString byteString = (ByteString)value.Descriptor.Fields[2].Accessor.GetValue(value);
						JsonFormatter.smethod_3(builder, Module.smethod_35<string>(1315362458u));
						arg_133_0 = (num * 966451833u ^ 3477661149u);
						continue;
					}
					case 2u:
						JsonFormatter.smethod_3(builder, Module.smethod_35<string>(1861489385u));
						arg_133_0 = (num * 1105940164u ^ 2594348938u);
						continue;
					case 3u:
					{
						JsonFormatter.smethod_10(builder, '"');
						ByteString byteString;
						JsonFormatter.smethod_3(builder, byteString.ToBase64());
						arg_133_0 = (num * 1041690270u ^ 2219002669u);
						continue;
					}
					case 4u:
						this.WriteString(builder, text);
						JsonFormatter.smethod_3(builder, Module.smethod_35<string>(2224724046u));
						this.WriteString(builder, Module.smethod_36<string>(525672202u));
						arg_133_0 = (num * 3124114611u ^ 822621031u);
						continue;
					case 5u:
						this.WriteString(builder, Module.smethod_36<string>(2843911711u));
						arg_133_0 = (num * 2535852553u ^ 586824779u);
						continue;
					case 7u:
						JsonFormatter.smethod_3(builder, Module.smethod_37<string>(2625673813u));
						arg_133_0 = (num * 1835877891u ^ 3038523408u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			JsonFormatter.smethod_10(builder, '"');
			JsonFormatter.smethod_3(builder, Module.smethod_37<string>(4261757804u));
		}

		internal static string GetTypeName(string typeUrl)
		{
			string[] array = JsonFormatter.smethod_20(typeUrl, new char[]
			{
				'/'
			});
			if (array.Length == 2)
			{
				while (true)
				{
					IL_72:
					uint arg_56_0 = 3151831623u;
					while (true)
					{
						uint num;
						switch ((num = (arg_56_0 ^ 4074557162u)) % 4u)
						{
						case 0u:
							goto IL_72;
						case 1u:
							arg_56_0 = (((!JsonFormatter.smethod_21(array[0], Module.smethod_36<string>(3185423433u))) ? 1688608980u : 1554082005u) ^ num * 2836047921u);
							continue;
						case 2u:
							goto IL_79;
						}
						goto Block_3;
					}
				}
				Block_3:
				return array[1];
			}
			IL_79:
			throw new InvalidProtocolBufferException(JsonFormatter.smethod_18(Module.smethod_36<string>(3330108523u), new object[]
			{
				typeUrl
			}));
		}

		private static void AppendNanoseconds(StringBuilder builder, int nanos)
		{
			if (nanos != 0)
			{
				while (true)
				{
					IL_EA:
					uint arg_BE_0 = 2755904108u;
					while (true)
					{
						uint num;
						switch ((num = (arg_BE_0 ^ 4246923664u)) % 8u)
						{
						case 0u:
							goto IL_EA;
						case 1u:
							return;
						case 3u:
							builder.Append((nanos / 1000).ToString(Module.smethod_34<string>(4146480682u), CultureInfo.InvariantCulture));
							arg_BE_0 = (num * 2836589119u ^ 1569229996u);
							continue;
						case 4u:
							JsonFormatter.smethod_10(builder, '.');
							arg_BE_0 = (((nanos % 1000000 == 0) ? 1498919302u : 1130443669u) ^ num * 4250277154u);
							continue;
						case 5u:
							arg_BE_0 = ((nanos % 1000 != 0) ? 3081477135u : 2598399651u);
							continue;
						case 6u:
							goto IL_F2;
						case 7u:
							builder.Append(nanos.ToString(Module.smethod_34<string>(4146480682u), CultureInfo.InvariantCulture));
							arg_BE_0 = 3212650194u;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				return;
				IL_F2:
				builder.Append((nanos / 1000000).ToString(Module.smethod_35<string>(266120881u), JsonFormatter.smethod_13()));
				return;
			}
		}

		private void WriteStruct(StringBuilder builder, IMessage message)
		{
			JsonFormatter.smethod_3(builder, Module.smethod_37<string>(3531321590u));
			IDictionary arg_34_0 = (IDictionary)message.Descriptor.Fields[1].Accessor.GetValue(message);
			bool flag = true;
			IDictionaryEnumerator dictionaryEnumerator = JsonFormatter.smethod_22(arg_34_0);
			try
			{
				while (true)
				{
					IL_1E7:
					uint arg_192_0 = (!dictionaryEnumerator.MoveNext()) ? 4229945257u : 2952868706u;
					while (true)
					{
						uint num;
						switch ((num = (arg_192_0 ^ 2580031324u)) % 14u)
						{
						case 0u:
							arg_192_0 = ((!flag) ? 3702602805u : 2791664705u);
							continue;
						case 1u:
						{
							string text;
							arg_192_0 = ((string.IsNullOrEmpty(text) ? 813358995u : 3145148u) ^ num * 3875071783u);
							continue;
						}
						case 2u:
							goto IL_1F4;
						case 3u:
						{
							string text;
							this.WriteString(builder, text);
							arg_192_0 = 4269558113u;
							continue;
						}
						case 4u:
						{
							DictionaryEntry dictionaryEntry = (DictionaryEntry)JsonFormatter.smethod_23(dictionaryEnumerator);
							arg_192_0 = 2724570036u;
							continue;
						}
						case 5u:
							builder.Append(Module.smethod_37<string>(2625673813u));
							arg_192_0 = (num * 2747275843u ^ 327982255u);
							continue;
						case 6u:
							arg_192_0 = 2952868706u;
							continue;
						case 8u:
							goto IL_1E7;
						case 9u:
							flag = false;
							arg_192_0 = (num * 2129621272u ^ 1202167034u);
							continue;
						case 10u:
						{
							DictionaryEntry dictionaryEntry;
							string text = (string)dictionaryEntry.Key;
							IMessage message2 = (IMessage)dictionaryEntry.Value;
							arg_192_0 = (num * 3751823832u ^ 1855786393u);
							continue;
						}
						case 11u:
						{
							IMessage message2;
							arg_192_0 = (((message2 == null) ? 1939098143u : 1225008165u) ^ num * 651841765u);
							continue;
						}
						case 12u:
						{
							IMessage message2;
							this.WriteStructFieldValue(builder, message2);
							arg_192_0 = (num * 1911013297u ^ 1059866813u);
							continue;
						}
						case 13u:
							builder.Append(Module.smethod_37<string>(697226722u));
							arg_192_0 = (num * 1842344663u ^ 367209326u);
							continue;
						}
						goto Block_7;
					}
				}
				Block_7:
				goto IL_204;
				IL_1F4:
				throw new InvalidOperationException(Module.smethod_35<string>(2322725034u));
				IL_204:;
			}
			finally
			{
				IDisposable disposable = dictionaryEnumerator as IDisposable;
				while (true)
				{
					IL_26D:
					uint arg_250_0 = 4267085182u;
					while (true)
					{
						uint num;
						switch ((num = (arg_250_0 ^ 2580031324u)) % 4u)
						{
						case 1u:
							disposable.Dispose();
							arg_250_0 = (num * 1362292923u ^ 740849479u);
							continue;
						case 2u:
							arg_250_0 = (((disposable != null) ? 3932733553u : 3302698384u) ^ num * 3209670766u);
							continue;
						case 3u:
							goto IL_26D;
						}
						goto Block_11;
					}
				}
				Block_11:;
			}
			builder.Append(flag ? Module.smethod_33<string>(718184315u) : Module.smethod_35<string>(531921192u));
		}

		private void WriteStructFieldValue(StringBuilder builder, IMessage message)
		{
			FieldDescriptor caseFieldDescriptor = message.Descriptor.Oneofs[0].Accessor.GetCaseFieldDescriptor(message);
			if (caseFieldDescriptor == null)
			{
				goto IL_4E;
			}
			goto IL_FD;
			uint arg_BB_0;
			IMessage message2;
			object value;
			while (true)
			{
				IL_B6:
				uint num;
				switch ((num = (arg_BB_0 ^ 1183245376u)) % 13u)
				{
				case 0u:
					goto IL_A9;
				case 1u:
				{
					int fieldNumber;
					switch (fieldNumber)
					{
					case 1:
						goto IL_55;
					case 2:
					case 3:
					case 4:
						goto IL_A9;
					case 5:
					case 6:
						goto IL_25;
					default:
						arg_BB_0 = (num * 761499672u ^ 1029049007u);
						continue;
					}
					break;
				}
				case 2u:
				{
					int fieldNumber = caseFieldDescriptor.FieldNumber;
					arg_BB_0 = (num * 1799281849u ^ 342414610u);
					continue;
				}
				case 4u:
					goto IL_131;
				case 5u:
					goto IL_55;
				case 6u:
					goto IL_4E;
				case 7u:
					return;
				case 8u:
					return;
				case 9u:
					goto IL_143;
				case 10u:
					arg_BB_0 = (num * 1723709832u ^ 772204564u);
					continue;
				case 11u:
					goto IL_25;
				case 12u:
					goto IL_FD;
				}
				break;
				IL_25:
				message2 = (IMessage)caseFieldDescriptor.Accessor.GetValue(message);
				arg_BB_0 = 429340318u;
				continue;
				IL_55:
				JsonFormatter.WriteNull(builder);
				arg_BB_0 = 1183295375u;
				continue;
				IL_A9:
				this.WriteValue(builder, value);
				arg_BB_0 = 1204574075u;
			}
			throw JsonFormatter.smethod_19(JsonFormatter.smethod_16(Module.smethod_33<string>(2821884892u), caseFieldDescriptor.FieldNumber));
			IL_131:
			throw JsonFormatter.smethod_19(Module.smethod_37<string>(2041301265u));
			IL_143:
			this.WriteWellKnownTypeValue(builder, message2.Descriptor, message2, true);
			return;
			IL_4E:
			arg_BB_0 = 1569912375u;
			goto IL_B6;
			IL_FD:
			value = caseFieldDescriptor.Accessor.GetValue(message);
			arg_BB_0 = 1377419097u;
			goto IL_B6;
		}

		internal void WriteList(StringBuilder builder, IList list)
		{
			JsonFormatter.smethod_3(builder, Module.smethod_34<string>(678226038u));
			bool flag = true;
			IEnumerator enumerator = JsonFormatter.smethod_24(list);
			try
			{
				while (true)
				{
					IL_109:
					uint arg_CD_0 = JsonFormatter.smethod_4(enumerator) ? 1962729465u : 438768879u;
					while (true)
					{
						uint num;
						switch ((num = (arg_CD_0 ^ 785520532u)) % 8u)
						{
						case 0u:
							goto IL_109;
						case 1u:
							JsonFormatter.smethod_3(builder, Module.smethod_34<string>(2674358257u));
							arg_CD_0 = (num * 331944329u ^ 2404039570u);
							continue;
						case 2u:
							arg_CD_0 = ((flag ? 3031902911u : 2911374385u) ^ num * 2185536370u);
							continue;
						case 4u:
							flag = false;
							arg_CD_0 = (num * 662842544u ^ 1992362164u);
							continue;
						case 5u:
						{
							object value = JsonFormatter.smethod_23(enumerator);
							arg_CD_0 = (this.CanWriteSingleValue(value) ? 1774570422u : 205099124u);
							continue;
						}
						case 6u:
							arg_CD_0 = 1962729465u;
							continue;
						case 7u:
						{
							object value;
							this.WriteValue(builder, value);
							arg_CD_0 = 850942128u;
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
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					while (true)
					{
						IL_156:
						uint arg_13D_0 = 511921399u;
						while (true)
						{
							uint num;
							switch ((num = (arg_13D_0 ^ 785520532u)) % 3u)
							{
							case 0u:
								goto IL_156;
							case 1u:
								JsonFormatter.smethod_5(disposable);
								arg_13D_0 = (num * 3749246981u ^ 3467009229u);
								continue;
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
			}
			JsonFormatter.smethod_3(builder, flag ? Module.smethod_33<string>(815132178u) : Module.smethod_36<string>(2554541531u));
		}

		internal void WriteDictionary(StringBuilder builder, IDictionary dictionary)
		{
			JsonFormatter.smethod_3(builder, Module.smethod_33<string>(1205244391u));
			bool flag;
			while (true)
			{
				IL_41:
				uint arg_28_0 = 1877896257u;
				while (true)
				{
					uint num;
					switch ((num = (arg_28_0 ^ 1706756498u)) % 3u)
					{
					case 0u:
						goto IL_41;
					case 2u:
						flag = true;
						arg_28_0 = (num * 2005849876u ^ 855307335u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			IDictionaryEnumerator dictionaryEnumerator = JsonFormatter.smethod_22(dictionary);
			try
			{
				DictionaryEntry dictionaryEntry;
				while (true)
				{
					IL_3BB:
					uint arg_33A_0 = dictionaryEnumerator.MoveNext() ? 1239589536u : 1696484136u;
					while (true)
					{
						uint num;
						string text;
						string arg_A6_0;
						switch ((num = (arg_33A_0 ^ 1706756498u)) % 25u)
						{
						case 0u:
							goto IL_3C8;
						case 1u:
							arg_33A_0 = ((dictionaryEntry.Key is string) ? 1469448581u : 551450587u);
							continue;
						case 2u:
							builder.Append(Module.smethod_36<string>(2783308702u));
							arg_33A_0 = (num * 1127247588u ^ 1667832443u);
							continue;
						case 3u:
							builder.Append(Module.smethod_36<string>(2189550737u));
							this.WriteValue(builder, dictionaryEntry.Value);
							arg_33A_0 = (num * 2949434496u ^ 2299761527u);
							continue;
						case 4u:
							text = ((IFormattable)dictionaryEntry.Key).ToString(Module.smethod_34<string>(4146480682u), CultureInfo.InvariantCulture);
							arg_33A_0 = 2037932184u;
							continue;
						case 5u:
							arg_33A_0 = (num * 3685257922u ^ 2478047566u);
							continue;
						case 6u:
							arg_33A_0 = ((!(dictionaryEntry.Key is int)) ? 1761283116u : 1474877148u);
							continue;
						case 7u:
							arg_33A_0 = (((!(dictionaryEntry.Key is uint | dictionaryEntry.Key is long)) ? 154128754u : 602943044u) ^ num * 308279604u);
							continue;
						case 8u:
							arg_33A_0 = (num * 797594830u ^ 3688723238u);
							continue;
						case 9u:
							dictionaryEntry = (DictionaryEntry)JsonFormatter.smethod_23(dictionaryEnumerator);
							arg_33A_0 = 877786491u;
							continue;
						case 10u:
							arg_33A_0 = (num * 84442549u ^ 3932133283u);
							continue;
						case 11u:
							arg_33A_0 = (((dictionaryEntry.Key is ulong) ? 1149477556u : 752474327u) ^ num * 1359419299u);
							continue;
						case 12u:
							flag = false;
							arg_33A_0 = (num * 2848758122u ^ 827214974u);
							continue;
						case 13u:
							arg_33A_0 = 1239589536u;
							continue;
						case 14u:
							if (!(bool)dictionaryEntry.Key)
							{
								arg_33A_0 = (num * 2841398597u ^ 1800827696u);
								continue;
							}
							arg_A6_0 = Module.smethod_36<string>(3538674691u);
							goto IL_A6;
						case 15u:
							arg_33A_0 = ((this.CanWriteSingleValue(dictionaryEntry.Value) ? 3310036630u : 2342237269u) ^ num * 3756831377u);
							continue;
						case 16u:
							text = (string)dictionaryEntry.Key;
							arg_33A_0 = (num * 1712387202u ^ 1559269433u);
							continue;
						case 17u:
							goto IL_3BB;
						case 18u:
							arg_33A_0 = (((!flag) ? 3815661299u : 3344577367u) ^ num * 1263165256u);
							continue;
						case 19u:
							arg_33A_0 = ((!(dictionaryEntry.Key is bool)) ? 1494067161u : 733728343u);
							continue;
						case 20u:
							goto IL_3E9;
						case 21u:
							arg_A6_0 = Module.smethod_36<string>(878923460u);
							goto IL_A6;
						case 23u:
							this.WriteString(builder, text);
							arg_33A_0 = 1987575248u;
							continue;
						case 24u:
							arg_33A_0 = ((dictionaryEntry.Key != null) ? 1891803265u : 77108712u);
							continue;
						}
						goto Block_14;
						IL_A6:
						text = arg_A6_0;
						arg_33A_0 = 1245927648u;
					}
				}
				Block_14:
				goto IL_3F9;
				IL_3C8:
				throw new ArgumentException(Module.smethod_36<string>(4262100141u) + dictionaryEntry.Key.GetType());
				IL_3E9:
				throw new ArgumentException(Module.smethod_36<string>(505471199u));
				IL_3F9:;
			}
			finally
			{
				IDisposable disposable = dictionaryEnumerator as IDisposable;
				while (true)
				{
					IL_462:
					uint arg_445_0 = 1343691655u;
					while (true)
					{
						uint num;
						switch ((num = (arg_445_0 ^ 1706756498u)) % 4u)
						{
						case 0u:
							disposable.Dispose();
							arg_445_0 = (num * 1187453380u ^ 976489128u);
							continue;
						case 1u:
							arg_445_0 = (((disposable != null) ? 3944150536u : 4224579894u) ^ num * 43037206u);
							continue;
						case 3u:
							goto IL_462;
						}
						goto Block_18;
					}
				}
				Block_18:;
			}
			builder.Append(flag ? Module.smethod_33<string>(718184315u) : Module.smethod_37<string>(4261757804u));
		}

		private bool CanWriteSingleValue(object value)
		{
			return !(value is System.Enum) || JsonFormatter.smethod_25(JsonFormatter.smethod_15(value), value);
		}

		private void WriteString(StringBuilder builder, string text)
		{
			JsonFormatter.smethod_10(builder, '"');
			while (true)
			{
				IL_46:
				uint arg_2E_0 = 1434834133u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2E_0 ^ 85713705u)) % 3u)
					{
					case 0u:
						goto IL_46;
					case 2u:
						this.AppendEscapedString(builder, text);
						JsonFormatter.smethod_10(builder, '"');
						arg_2E_0 = (num * 236353829u ^ 1758264799u);
						continue;
					}
					return;
				}
			}
		}

		private void AppendEscapedString(StringBuilder builder, string text)
		{
			int num = 0;
			while (true)
			{
				IL_5F1:
				uint arg_530_0 = 1846827121u;
				while (true)
				{
					uint num2;
					char c;
					switch ((num2 = (arg_530_0 ^ 378675745u)) % 45u)
					{
					case 0u:
						arg_530_0 = (num2 * 1769404686u ^ 282958495u);
						continue;
					case 1u:
					{
						uint num3;
						switch (num3)
						{
						case 65529u:
						case 65530u:
						case 65531u:
							goto IL_4AA;
						default:
							arg_530_0 = (num2 * 4030455468u ^ 6638233u);
							continue;
						}
						break;
					}
					case 2u:
						arg_530_0 = ((c < '⁪') ? 1758744393u : 1794591867u);
						continue;
					case 3u:
						arg_530_0 = (num2 * 1984689094u ^ 1756000179u);
						continue;
					case 4u:
						JsonFormatter.smethod_10(builder, c);
						arg_530_0 = 204809859u;
						continue;
					case 5u:
						goto IL_4AA;
					case 6u:
						arg_530_0 = (num2 * 505053412u ^ 1146458224u);
						continue;
					case 7u:
						JsonFormatter.HexEncodeUtf16CodeUnit(builder, c);
						arg_530_0 = 204809859u;
						continue;
					case 8u:
						arg_530_0 = (((c > '؃') ? 126242925u : 1978267055u) ^ num2 * 2823460072u);
						continue;
					case 9u:
						arg_530_0 = (((c <= '‮') ? 1420906855u : 1943137000u) ^ num2 * 126858580u);
						continue;
					case 10u:
						arg_530_0 = (num2 * 2923135211u ^ 2267758429u);
						continue;
					case 11u:
						num++;
						arg_530_0 = (num2 * 1701426663u ^ 2716447437u);
						continue;
					case 12u:
					{
						uint num3;
						arg_530_0 = (((num3 != 6069u) ? 743885276u : 1102580079u) ^ num2 * 156084174u);
						continue;
					}
					case 13u:
						arg_530_0 = ((c >= '⁠') ? 1293798222u : 351757129u);
						continue;
					case 14u:
						num++;
						arg_530_0 = 626622256u;
						continue;
					case 15u:
						arg_530_0 = (num2 * 3234385929u ^ 219499013u);
						continue;
					case 16u:
						arg_530_0 = (((!char.IsLowSurrogate(JsonFormatter.smethod_8(text, num))) ? 294549374u : 1967959459u) ^ num2 * 779020898u);
						continue;
					case 17u:
					{
						uint num3;
						arg_530_0 = ((num3 <= 6069u) ? 112513670u : 878161075u);
						continue;
					}
					case 18u:
					{
						uint num3;
						arg_530_0 = (((num3 == 1807u) ? 1944286232u : 906072978u) ^ num2 * 1414208657u);
						continue;
					}
					case 19u:
						goto IL_5F1;
					case 20u:
						arg_530_0 = (((c > '⁯') ? 3148994109u : 2706491755u) ^ num2 * 195023842u);
						continue;
					case 21u:
					{
						uint num3;
						arg_530_0 = (((num3 == 173u) ? 1925607482u : 1760918748u) ^ num2 * 1616589227u);
						continue;
					}
					case 22u:
						arg_530_0 = ((!char.IsLowSurrogate(c)) ? 911407970u : 1936909389u);
						continue;
					case 23u:
						JsonFormatter.smethod_3(builder, JsonFormatter.CommonRepresentations[(int)c]);
						arg_530_0 = (num2 * 2286699068u ^ 1552861794u);
						continue;
					case 25u:
						JsonFormatter.HexEncodeUtf16CodeUnit(builder, JsonFormatter.smethod_8(text, num));
						arg_530_0 = (num2 * 38600255u ^ 662416119u);
						continue;
					case 26u:
						arg_530_0 = (((num != JsonFormatter.smethod_6(text)) ? 399278843u : 2016153571u) ^ num2 * 2716759789u);
						continue;
					case 27u:
						arg_530_0 = (((c >= '\u00a0') ? 335218729u : 1796577537u) ^ num2 * 3480010470u);
						continue;
					case 28u:
						arg_530_0 = ((c < '؀') ? 6026717u : 10830991u);
						continue;
					case 29u:
						arg_530_0 = (num2 * 3643996886u ^ 1141154257u);
						continue;
					case 30u:
						arg_530_0 = ((c < '​') ? 1196350279u : 248682042u);
						continue;
					case 31u:
						goto IL_5FB;
					case 32u:
					{
						uint num3;
						arg_530_0 = (((num3 == 1757u) ? 1101543879u : 810387022u) ^ num2 * 3935811525u);
						continue;
					}
					case 33u:
						JsonFormatter.HexEncodeUtf16CodeUnit(builder, c);
						arg_530_0 = 1623761411u;
						continue;
					case 34u:
						arg_530_0 = ((num < JsonFormatter.smethod_6(text)) ? 459812831u : 1775182443u);
						continue;
					case 35u:
						c = JsonFormatter.smethod_8(text, num);
						arg_530_0 = 350165194u;
						continue;
					case 36u:
						goto IL_60B;
					case 37u:
						arg_530_0 = ((c >= '\u2028') ? 1643367623u : 1431628688u);
						continue;
					case 38u:
						arg_530_0 = (((c <= '⁤') ? 3531448517u : 3032388499u) ^ num2 * 3308678086u);
						continue;
					case 39u:
					{
						uint num3;
						arg_530_0 = ((num3 == 65279u) ? 282558471u : 302954218u);
						continue;
					}
					case 40u:
						arg_530_0 = (((c <= '‏') ? 1774472964u : 1556005980u) ^ num2 * 3162960129u);
						continue;
					case 41u:
					{
						uint num3;
						arg_530_0 = (((num3 == 6068u) ? 2107133309u : 1709396087u) ^ num2 * 156478454u);
						continue;
					}
					case 42u:
						arg_530_0 = ((!char.IsHighSurrogate(c)) ? 1389434594u : 1388112344u);
						continue;
					case 43u:
					{
						uint num3 = (uint)c;
						arg_530_0 = ((num3 <= 1807u) ? 2134994838u : 1682343479u);
						continue;
					}
					case 44u:
						arg_530_0 = (num2 * 1644279278u ^ 351349603u);
						continue;
					}
					goto Block_26;
					IL_4AA:
					JsonFormatter.HexEncodeUtf16CodeUnit(builder, c);
					arg_530_0 = 521086641u;
				}
			}
			Block_26:
			return;
			IL_5FB:
			throw JsonFormatter.smethod_12(Module.smethod_35<string>(700003834u));
			IL_60B:
			throw JsonFormatter.smethod_12(Module.smethod_36<string>(919325466u));
		}

		private static void HexEncodeUtf16CodeUnit(StringBuilder builder, char c)
		{
			JsonFormatter.smethod_3(builder, Module.smethod_37<string>(2479521734u));
			JsonFormatter.smethod_10(builder, JsonFormatter.smethod_26(Module.smethod_34<string>(1494192179u), (int)(c >> 12 & '\u000f')));
			JsonFormatter.smethod_10(builder, JsonFormatter.smethod_26(Module.smethod_37<string>(3209957948u), (int)(c >> 8 & '\u000f')));
			JsonFormatter.smethod_10(builder, JsonFormatter.smethod_26(Module.smethod_36<string>(3494994616u), (int)(c >> 4 & '\u000f')));
			JsonFormatter.smethod_10(builder, JsonFormatter.smethod_26(Module.smethod_33<string>(859621345u), (int)(c & '\u000f')));
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static StringBuilder smethod_1()
		{
			return new StringBuilder();
		}

		static string smethod_2(object object_0)
		{
			return object_0.ToString();
		}

		static StringBuilder smethod_3(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.Append(string_0);
		}

		static bool smethod_4(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_5(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static int smethod_6(string string_0)
		{
			return string_0.Length;
		}

		static StringBuilder smethod_7(int int_0)
		{
			return new StringBuilder(int_0);
		}

		static char smethod_8(string string_0, int int_0)
		{
			return string_0[int_0];
		}

		static int smethod_9(StringBuilder stringBuilder_0)
		{
			return stringBuilder_0.Length;
		}

		static StringBuilder smethod_10(StringBuilder stringBuilder_0, char char_0)
		{
			return stringBuilder_0.Append(char_0);
		}

		static int smethod_11(ICollection icollection_0)
		{
			return icollection_0.Count;
		}

		static ArgumentException smethod_12(string string_0)
		{
			return new ArgumentException(string_0);
		}

		static CultureInfo smethod_13()
		{
			return CultureInfo.InvariantCulture;
		}

		static string smethod_14(IFormattable iformattable_0, string string_0, IFormatProvider iformatProvider_0)
		{
			return iformattable_0.ToString(string_0, iformatProvider_0);
		}

		static System.Type smethod_15(object object_0)
		{
			return object_0.GetType();
		}

		static string smethod_16(object object_0, object object_1)
		{
			return object_0 + object_1;
		}

		static string smethod_17(string string_0, IEnumerable<string> ienumerable_0)
		{
			return string.Join(string_0, ienumerable_0);
		}

		static string smethod_18(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}

		static InvalidOperationException smethod_19(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static string[] smethod_20(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		static bool smethod_21(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static IDictionaryEnumerator smethod_22(IDictionary idictionary_0)
		{
			return idictionary_0.GetEnumerator();
		}

		static object smethod_23(IEnumerator ienumerator_0)
		{
			return ienumerator_0.Current;
		}

		static IEnumerator smethod_24(IEnumerable ienumerable_0)
		{
			return ienumerable_0.GetEnumerator();
		}

		static bool smethod_25(System.Type type_0, object object_0)
		{
			return System.Enum.IsDefined(type_0, object_0);
		}

		static char smethod_26(string string_0, int int_0)
		{
			return string_0[int_0];
		}
	}
}
