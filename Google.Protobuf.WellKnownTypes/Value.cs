using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Value : IMessage<Value>, IEquatable<Value>, IDeepCloneable<Value>, IMessage
	{
		public enum KindOneofCase
		{
			None,
			NullValue,
			NumberValue,
			StringValue,
			BoolValue,
			StructValue,
			ListValue
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Value.__c __9 = new Value.__c();

			internal Value cctor>b__55_0()
			{
				return new Value();
			}
		}

		private static readonly MessageParser<Value> _parser = new MessageParser<Value>(new Func<Value>(Value.__c.__9.<.cctor>b__55_0));

		public const int NullValueFieldNumber = 1;

		public const int NumberValueFieldNumber = 2;

		public const int StringValueFieldNumber = 3;

		public const int BoolValueFieldNumber = 4;

		public const int StructValueFieldNumber = 5;

		public const int ListValueFieldNumber = 6;

		private object kind_;

		private Value.KindOneofCase kindCase_;

		public static MessageParser<Value> Parser
		{
			get
			{
				return Value._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return StructReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Value.Descriptor;
			}
		}

		public NullValue NullValue
		{
			get
			{
				if (this.kindCase_ != Value.KindOneofCase.NullValue)
				{
					return NullValue.NULL_VALUE;
				}
				return (NullValue)this.kind_;
			}
			set
			{
				this.kind_ = value;
				this.kindCase_ = Value.KindOneofCase.NullValue;
			}
		}

		public double NumberValue
		{
			get
			{
				if (this.kindCase_ != Value.KindOneofCase.NumberValue)
				{
					return 0.0;
				}
				return (double)this.kind_;
			}
			set
			{
				this.kind_ = value;
				this.kindCase_ = Value.KindOneofCase.NumberValue;
			}
		}

		public string StringValue
		{
			get
			{
				if (this.kindCase_ != Value.KindOneofCase.StringValue)
				{
					return "";
				}
				return (string)this.kind_;
			}
			set
			{
				this.kind_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
				while (true)
				{
					IL_49:
					uint arg_31_0 = 1219508036u;
					while (true)
					{
						uint num;
						switch ((num = (arg_31_0 ^ 160639072u)) % 3u)
						{
						case 0u:
							goto IL_49;
						case 2u:
							this.kindCase_ = Value.KindOneofCase.StringValue;
							arg_31_0 = (num * 3704655072u ^ 2062357241u);
							continue;
						}
						return;
					}
				}
			}
		}

		public bool BoolValue
		{
			get
			{
				return this.kindCase_ == Value.KindOneofCase.BoolValue && (bool)this.kind_;
			}
			set
			{
				this.kind_ = value;
				this.kindCase_ = Value.KindOneofCase.BoolValue;
			}
		}

		public Struct StructValue
		{
			get
			{
				if (this.kindCase_ != Value.KindOneofCase.StructValue)
				{
					return null;
				}
				return (Struct)this.kind_;
			}
			set
			{
				this.kind_ = value;
				this.kindCase_ = ((value == null) ? Value.KindOneofCase.None : Value.KindOneofCase.StructValue);
			}
		}

		public ListValue ListValue
		{
			get
			{
				if (this.kindCase_ != Value.KindOneofCase.ListValue)
				{
					return null;
				}
				return (ListValue)this.kind_;
			}
			set
			{
				this.kind_ = value;
				while (true)
				{
					IL_36:
					int arg_20_0 = 1941352082;
					while (true)
					{
						switch ((arg_20_0 ^ 1003313620) % 3)
						{
						case 0:
							goto IL_36;
						case 2:
							this.kindCase_ = ((value == null) ? Value.KindOneofCase.None : Value.KindOneofCase.ListValue);
							arg_20_0 = 362592831;
							continue;
						}
						return;
					}
				}
			}
		}

		public Value.KindOneofCase KindCase
		{
			get
			{
				return this.kindCase_;
			}
		}

		public Value()
		{
		}

		public Value(Value other) : this()
		{
			switch (other.KindCase)
			{
			case Value.KindOneofCase.NullValue:
				this.NullValue = other.NullValue;
				return;
			case Value.KindOneofCase.NumberValue:
				this.NumberValue = other.NumberValue;
				return;
			case Value.KindOneofCase.StringValue:
				this.StringValue = other.StringValue;
				return;
			case Value.KindOneofCase.BoolValue:
				this.BoolValue = other.BoolValue;
				return;
			case Value.KindOneofCase.StructValue:
				this.StructValue = other.StructValue.Clone();
				return;
			case Value.KindOneofCase.ListValue:
				this.ListValue = other.ListValue.Clone();
				return;
			default:
				return;
			}
		}

		public Value Clone()
		{
			return new Value(this);
		}

		public void ClearKind()
		{
			this.kindCase_ = Value.KindOneofCase.None;
			this.kind_ = null;
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Value);
		}

		public bool Equals(Value other)
		{
			if (other == null)
			{
				goto IL_F6;
			}
			goto IL_1B4;
			int arg_14E_0;
			while (true)
			{
				IL_149:
				switch ((arg_14E_0 ^ -1157632992) % 19)
				{
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_14E_0 = ((this.NumberValue != other.NumberValue) ? -2065761332 : -1377871954);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_14E_0 = ((this.NullValue == other.NullValue) ? -1269934402 : -887493226);
					continue;
				case 7:
					goto IL_F6;
				case 8:
					arg_14E_0 = (Value.smethod_1(this.ListValue, other.ListValue) ? -772368568 : -80128937);
					continue;
				case 9:
					return false;
				case 10:
					arg_14E_0 = ((this.KindCase == other.KindCase) ? -1481722621 : -2094044351);
					continue;
				case 11:
					arg_14E_0 = ((this.BoolValue == other.BoolValue) ? -1663207624 : -304973300);
					continue;
				case 12:
					arg_14E_0 = (Value.smethod_1(this.StructValue, other.StructValue) ? -146472511 : -170554786);
					continue;
				case 13:
					return true;
				case 14:
					goto IL_1B4;
				case 15:
					return false;
				case 16:
					return false;
				case 17:
					return false;
				case 18:
					arg_14E_0 = ((!Value.smethod_0(this.StringValue, other.StringValue)) ? -1899277804 : -722029849);
					continue;
				}
				break;
			}
			return true;
			IL_F6:
			arg_14E_0 = -1796955242;
			goto IL_149;
			IL_1B4:
			arg_14E_0 = ((other == this) ? -514571654 : -1694549476);
			goto IL_149;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.kindCase_ == Value.KindOneofCase.NullValue)
			{
				goto IL_45;
			}
			goto IL_1D8;
			uint arg_187_0;
			while (true)
			{
				IL_182:
				uint num2;
				switch ((num2 = (arg_187_0 ^ 292250634u)) % 13u)
				{
				case 0u:
					arg_187_0 = ((this.kindCase_ == Value.KindOneofCase.ListValue) ? 1415421870u : 257165338u);
					continue;
				case 1u:
					num ^= this.StructValue.GetHashCode();
					arg_187_0 = (num2 * 1035520549u ^ 3580176533u);
					continue;
				case 2u:
					num ^= this.ListValue.GetHashCode();
					arg_187_0 = (num2 * 1917418421u ^ 736083694u);
					continue;
				case 3u:
					num ^= this.NumberValue.GetHashCode();
					arg_187_0 = (num2 * 2832867848u ^ 3824330689u);
					continue;
				case 4u:
					num ^= this.NullValue.GetHashCode();
					arg_187_0 = (num2 * 313496679u ^ 491854507u);
					continue;
				case 5u:
					goto IL_1D8;
				case 6u:
					arg_187_0 = ((this.kindCase_ != Value.KindOneofCase.StructValue) ? 1761912941u : 497580946u);
					continue;
				case 7u:
					arg_187_0 = ((this.kindCase_ != Value.KindOneofCase.StringValue) ? 200565252u : 759389871u);
					continue;
				case 8u:
					num ^= this.BoolValue.GetHashCode();
					arg_187_0 = (num2 * 3727320478u ^ 2013890702u);
					continue;
				case 9u:
					num ^= this.StringValue.GetHashCode();
					arg_187_0 = (num2 * 3409724289u ^ 1723784737u);
					continue;
				case 10u:
					goto IL_45;
				case 12u:
					arg_187_0 = ((this.kindCase_ == Value.KindOneofCase.BoolValue) ? 913408809u : 2105605652u);
					continue;
				}
				break;
			}
			return num ^ (int)this.kindCase_;
			IL_45:
			arg_187_0 = 1552725299u;
			goto IL_182;
			IL_1D8:
			arg_187_0 = ((this.kindCase_ == Value.KindOneofCase.NumberValue) ? 1604369478u : 2049080737u);
			goto IL_182;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.kindCase_ == Value.KindOneofCase.NullValue)
			{
				goto IL_1A2;
			}
			goto IL_254;
			uint arg_1F0_0;
			while (true)
			{
				IL_1EB:
				uint num;
				switch ((num = (arg_1F0_0 ^ 2300104802u)) % 18u)
				{
				case 0u:
					arg_1F0_0 = ((this.kindCase_ == Value.KindOneofCase.ListValue) ? 2181047854u : 3062471772u);
					continue;
				case 1u:
					arg_1F0_0 = ((this.kindCase_ != Value.KindOneofCase.StringValue) ? 2338725130u : 3734549707u);
					continue;
				case 2u:
					goto IL_1A2;
				case 3u:
					output.WriteRawTag(42);
					output.WriteMessage(this.StructValue);
					arg_1F0_0 = (num * 947883934u ^ 453013432u);
					continue;
				case 5u:
					arg_1F0_0 = ((this.kindCase_ == Value.KindOneofCase.StructValue) ? 2847654545u : 3519545666u);
					continue;
				case 6u:
					output.WriteRawTag(50);
					arg_1F0_0 = (num * 4206287955u ^ 3538988526u);
					continue;
				case 7u:
					output.WriteRawTag(32);
					arg_1F0_0 = (num * 1780016933u ^ 1956500739u);
					continue;
				case 8u:
					arg_1F0_0 = ((this.kindCase_ != Value.KindOneofCase.BoolValue) ? 4196695423u : 2800780081u);
					continue;
				case 9u:
					output.WriteRawTag(8);
					arg_1F0_0 = (num * 2157477268u ^ 27745503u);
					continue;
				case 10u:
					goto IL_254;
				case 11u:
					output.WriteEnum((int)this.NullValue);
					arg_1F0_0 = (num * 2672844199u ^ 2544000123u);
					continue;
				case 12u:
					output.WriteMessage(this.ListValue);
					arg_1F0_0 = (num * 1543478822u ^ 3910927276u);
					continue;
				case 13u:
					output.WriteRawTag(26);
					arg_1F0_0 = (num * 3519178911u ^ 562717185u);
					continue;
				case 14u:
					output.WriteBool(this.BoolValue);
					arg_1F0_0 = (num * 1716930570u ^ 2374100819u);
					continue;
				case 15u:
					output.WriteDouble(this.NumberValue);
					arg_1F0_0 = (num * 3102080262u ^ 291641025u);
					continue;
				case 16u:
					output.WriteString(this.StringValue);
					arg_1F0_0 = (num * 1139137887u ^ 2778431974u);
					continue;
				case 17u:
					output.WriteRawTag(17);
					arg_1F0_0 = (num * 2653324029u ^ 2557875940u);
					continue;
				}
				break;
			}
			return;
			IL_1A2:
			arg_1F0_0 = 3659391527u;
			goto IL_1EB;
			IL_254:
			arg_1F0_0 = ((this.kindCase_ != Value.KindOneofCase.NumberValue) ? 2332457047u : 2867497769u);
			goto IL_1EB;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1DE:
				uint arg_199_0 = 4188091112u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_199_0 ^ 2412404914u)) % 14u)
					{
					case 0u:
						goto IL_1DE;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.StructValue);
						arg_199_0 = (num2 * 1166252893u ^ 820998969u);
						continue;
					case 2u:
						arg_199_0 = ((this.kindCase_ != Value.KindOneofCase.NumberValue) ? 2260815769u : 2698281472u);
						continue;
					case 3u:
						arg_199_0 = ((this.kindCase_ != Value.KindOneofCase.StringValue) ? 2535585282u : 2759116489u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ListValue);
						arg_199_0 = (num2 * 1103773483u ^ 3524489031u);
						continue;
					case 6u:
						num += 9;
						arg_199_0 = (num2 * 1917190313u ^ 3670992923u);
						continue;
					case 7u:
						arg_199_0 = ((this.kindCase_ == Value.KindOneofCase.StructValue) ? 2682767557u : 4254348034u);
						continue;
					case 8u:
						arg_199_0 = (((this.kindCase_ == Value.KindOneofCase.NullValue) ? 748834461u : 531983610u) ^ num2 * 1806729309u);
						continue;
					case 9u:
						num += 2;
						arg_199_0 = (num2 * 1544157725u ^ 3185548378u);
						continue;
					case 10u:
						arg_199_0 = ((this.kindCase_ == Value.KindOneofCase.BoolValue) ? 3458356209u : 2808586445u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NullValue);
						arg_199_0 = (num2 * 1129035340u ^ 242252500u);
						continue;
					case 12u:
						arg_199_0 = ((this.kindCase_ != Value.KindOneofCase.ListValue) ? 2965984374u : 2236826017u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.StringValue);
						arg_199_0 = (num2 * 3875489008u ^ 1784170834u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Value other)
		{
			if (other != null)
			{
				goto IL_A6;
			}
			IL_06:
			int arg_49_0 = 2113175860;
			goto IL_44;
			IL_0D:
			this.NumberValue = other.NumberValue;
			arg_49_0 = 1635569781;
			goto IL_44;
			IL_20:
			this.BoolValue = other.BoolValue;
			arg_49_0 = 405745041;
			goto IL_44;
			IL_33:
			this.NullValue = other.NullValue;
			arg_49_0 = 624850428;
			IL_44:
			switch ((arg_49_0 ^ 1589847026) % 14)
			{
			case 0:
				return;
			case 1:
				goto IL_33;
			case 2:
				goto IL_8C;
			case 3:
				IL_A6:
				switch (other.KindCase)
				{
				case Value.KindOneofCase.NullValue:
					goto IL_33;
				case Value.KindOneofCase.NumberValue:
					goto IL_0D;
				case Value.KindOneofCase.StringValue:
					goto IL_E0;
				case Value.KindOneofCase.BoolValue:
					goto IL_20;
				case Value.KindOneofCase.StructValue:
					goto IL_D3;
				case Value.KindOneofCase.ListValue:
					goto IL_8C;
				default:
					arg_49_0 = 199445090;
					goto IL_44;
				}
				break;
			case 4:
				return;
			case 5:
				return;
			case 6:
				return;
			case 7:
				goto IL_D3;
			case 8:
				goto IL_E0;
			case 9:
				goto IL_20;
			case 11:
				return;
			case 12:
				goto IL_0D;
			case 13:
				goto IL_06;
			}
			return;
			IL_8C:
			this.ListValue = other.ListValue;
			arg_49_0 = 2123779936;
			goto IL_44;
			IL_D3:
			this.StructValue = other.StructValue;
			return;
			IL_E0:
			this.StringValue = other.StringValue;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_349:
				uint num;
				uint arg_2C1_0 = ((num = input.ReadTag()) != 0u) ? 2245878476u : 2326086732u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2C1_0 ^ 3787839810u)) % 27u)
					{
					case 0u:
						input.SkipLastField();
						arg_2C1_0 = 3640810675u;
						continue;
					case 1u:
						this.BoolValue = input.ReadBool();
						arg_2C1_0 = 3640810675u;
						continue;
					case 2u:
					{
						ListValue listValue;
						this.ListValue = listValue;
						arg_2C1_0 = (num2 * 1902871188u ^ 3831713071u);
						continue;
					}
					case 3u:
					{
						ListValue listValue;
						input.ReadMessage(listValue);
						arg_2C1_0 = 2667384409u;
						continue;
					}
					case 4u:
					{
						Struct @struct;
						@struct.MergeFrom(this.StructValue);
						arg_2C1_0 = (num2 * 3419195227u ^ 1452483453u);
						continue;
					}
					case 5u:
					{
						ListValue listValue = new ListValue();
						arg_2C1_0 = ((this.kindCase_ != Value.KindOneofCase.ListValue) ? 4016354824u : 2150149107u);
						continue;
					}
					case 6u:
						arg_2C1_0 = (((num != 8u) ? 1193115870u : 426980586u) ^ num2 * 2415847765u);
						continue;
					case 7u:
						arg_2C1_0 = (((num != 17u) ? 4044085145u : 3598724209u) ^ num2 * 2580795978u);
						continue;
					case 8u:
						goto IL_349;
					case 9u:
						arg_2C1_0 = (((num != 42u) ? 1065250534u : 448162672u) ^ num2 * 4061368535u);
						continue;
					case 10u:
					{
						Struct @struct;
						input.ReadMessage(@struct);
						this.StructValue = @struct;
						arg_2C1_0 = 3645759884u;
						continue;
					}
					case 11u:
						arg_2C1_0 = (((this.kindCase_ == Value.KindOneofCase.StructValue) ? 2595769177u : 4003554100u) ^ num2 * 4193559948u);
						continue;
					case 12u:
						this.StringValue = input.ReadString();
						arg_2C1_0 = 3640810675u;
						continue;
					case 13u:
						this.kindCase_ = Value.KindOneofCase.NullValue;
						arg_2C1_0 = (num2 * 2393321188u ^ 728842012u);
						continue;
					case 14u:
						arg_2C1_0 = (((num == 26u) ? 3654590192u : 3748014307u) ^ num2 * 1061369338u);
						continue;
					case 15u:
						arg_2C1_0 = ((num > 26u) ? 3973867417u : 2551855103u);
						continue;
					case 16u:
						arg_2C1_0 = (num2 * 316280825u ^ 171773677u);
						continue;
					case 18u:
						arg_2C1_0 = (num2 * 609281770u ^ 1872618855u);
						continue;
					case 19u:
						this.NumberValue = input.ReadDouble();
						arg_2C1_0 = 3640810675u;
						continue;
					case 20u:
						this.kind_ = input.ReadEnum();
						arg_2C1_0 = 2773977357u;
						continue;
					case 21u:
						arg_2C1_0 = (num2 * 3647329935u ^ 2155039330u);
						continue;
					case 22u:
					{
						ListValue listValue;
						listValue.MergeFrom(this.ListValue);
						arg_2C1_0 = (num2 * 661050338u ^ 1036621130u);
						continue;
					}
					case 23u:
						arg_2C1_0 = (((num == 50u) ? 3854850316u : 3088890603u) ^ num2 * 2762288670u);
						continue;
					case 24u:
						arg_2C1_0 = ((num != 32u) ? 2614328064u : 3757124447u);
						continue;
					case 25u:
						arg_2C1_0 = 2245878476u;
						continue;
					case 26u:
					{
						Struct @struct = new Struct();
						arg_2C1_0 = 2415793096u;
						continue;
					}
					}
					return;
				}
			}
		}

		public static Value ForString(string value)
		{
			Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			return new Value
			{
				StringValue = value
			};
		}

		public static Value ForNumber(double value)
		{
			return new Value
			{
				NumberValue = value
			};
		}

		public static Value ForBool(bool value)
		{
			return new Value
			{
				BoolValue = value
			};
		}

		public static Value ForNull()
		{
			return new Value
			{
				NullValue = NullValue.NULL_VALUE
			};
		}

		public static Value ForList(params Value[] values)
		{
			Preconditions.CheckNotNull<Value[]>(values, Module.smethod_35<string>(1960906968u));
			return new Value
			{
				ListValue = new ListValue
				{
					Values = 
					{
						values
					}
				}
			};
		}

		public static Value ForStruct(Struct value)
		{
			Preconditions.CheckNotNull<Struct>(value, Module.smethod_36<string>(1095253436u));
			return new Value
			{
				StructValue = value
			};
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}
	}
}
