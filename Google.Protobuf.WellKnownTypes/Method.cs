using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Method : IMessage<Method>, IEquatable<Method>, IDeepCloneable<Method>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Method.__c __9 = new Method.__c();

			internal Method cctor>b__54_0()
			{
				return new Method();
			}
		}

		private static readonly MessageParser<Method> _parser = new MessageParser<Method>(new Func<Method>(Method.__c.__9.<.cctor>b__54_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int RequestTypeUrlFieldNumber = 2;

		private string requestTypeUrl_ = "";

		public const int RequestStreamingFieldNumber = 3;

		private bool requestStreaming_;

		public const int ResponseTypeUrlFieldNumber = 4;

		private string responseTypeUrl_ = "";

		public const int ResponseStreamingFieldNumber = 5;

		private bool responseStreaming_;

		public const int OptionsFieldNumber = 6;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage<Option>(50u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int SyntaxFieldNumber = 7;

		private Syntax syntax_;

		public static MessageParser<Method> Parser
		{
			get
			{
				return Method._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ApiReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Method.Descriptor;
			}
		}

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string RequestTypeUrl
		{
			get
			{
				return this.requestTypeUrl_;
			}
			set
			{
				this.requestTypeUrl_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public bool RequestStreaming
		{
			get
			{
				return this.requestStreaming_;
			}
			set
			{
				this.requestStreaming_ = value;
			}
		}

		public string ResponseTypeUrl
		{
			get
			{
				return this.responseTypeUrl_;
			}
			set
			{
				this.responseTypeUrl_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public bool ResponseStreaming
		{
			get
			{
				return this.responseStreaming_;
			}
			set
			{
				this.responseStreaming_ = value;
			}
		}

		public RepeatedField<Option> Options
		{
			get
			{
				return this.options_;
			}
		}

		public Syntax Syntax
		{
			get
			{
				return this.syntax_;
			}
			set
			{
				this.syntax_ = value;
			}
		}

		public Method()
		{
		}

		public Method(Method other) : this()
		{
			while (true)
			{
				IL_DD:
				uint arg_B5_0 = 1655388041u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B5_0 ^ 1075633238u)) % 7u)
					{
					case 0u:
						this.responseStreaming_ = other.responseStreaming_;
						arg_B5_0 = (num * 2376748881u ^ 4100632361u);
						continue;
					case 2u:
						this.name_ = other.name_;
						this.requestTypeUrl_ = other.requestTypeUrl_;
						arg_B5_0 = (num * 1990173059u ^ 2489388168u);
						continue;
					case 3u:
						goto IL_DD;
					case 4u:
						this.requestStreaming_ = other.requestStreaming_;
						this.responseTypeUrl_ = other.responseTypeUrl_;
						arg_B5_0 = (num * 3024833448u ^ 500031394u);
						continue;
					case 5u:
						this.options_ = other.options_.Clone();
						arg_B5_0 = (num * 306354749u ^ 2902355063u);
						continue;
					case 6u:
						this.syntax_ = other.syntax_;
						arg_B5_0 = (num * 4031773114u ^ 846729464u);
						continue;
					}
					return;
				}
			}
		}

		public Method Clone()
		{
			return new Method(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Method);
		}

		public bool Equals(Method other)
		{
			if (other == null)
			{
				goto IL_14C;
			}
			goto IL_1BC;
			int arg_156_0;
			while (true)
			{
				IL_151:
				switch ((arg_156_0 ^ -608667169) % 19)
				{
				case 0:
					return false;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_14C;
				case 7:
					return false;
				case 8:
					arg_156_0 = (Method.smethod_0(this.ResponseTypeUrl, other.ResponseTypeUrl) ? -152054560 : -951428384);
					continue;
				case 9:
					arg_156_0 = ((this.RequestStreaming != other.RequestStreaming) ? -1193073493 : -1358078271);
					continue;
				case 10:
					arg_156_0 = ((!this.options_.Equals(other.options_)) ? -1392463818 : -666135256);
					continue;
				case 11:
					return false;
				case 12:
					arg_156_0 = ((!Method.smethod_0(this.Name, other.Name)) ? -996725682 : -1276945510);
					continue;
				case 13:
					arg_156_0 = ((!Method.smethod_0(this.RequestTypeUrl, other.RequestTypeUrl)) ? -1127445121 : -2128742441);
					continue;
				case 14:
					return false;
				case 15:
					goto IL_1BC;
				case 16:
					arg_156_0 = ((this.Syntax != other.Syntax) ? -1827599559 : -1443585483);
					continue;
				case 17:
					arg_156_0 = ((this.ResponseStreaming != other.ResponseStreaming) ? -1545041939 : -502444962);
					continue;
				case 18:
					return false;
				}
				break;
			}
			return true;
			IL_14C:
			arg_156_0 = -919405345;
			goto IL_151;
			IL_1BC:
			arg_156_0 = ((other == this) ? -1791899688 : -373825385);
			goto IL_151;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (Method.smethod_1(this.Name) != 0)
			{
				goto IL_133;
			}
			goto IL_1FD;
			uint arg_1A9_0;
			while (true)
			{
				IL_1A4:
				uint num2;
				switch ((num2 = (arg_1A9_0 ^ 915022964u)) % 14u)
				{
				case 0u:
					num ^= this.Syntax.GetHashCode();
					arg_1A9_0 = (num2 * 2186398745u ^ 3373051380u);
					continue;
				case 1u:
					num ^= Method.smethod_2(this.Name);
					arg_1A9_0 = (num2 * 2741219337u ^ 4035071899u);
					continue;
				case 2u:
					arg_1A9_0 = (((this.Syntax != Syntax.SYNTAX_PROTO2) ? 89957018u : 769992650u) ^ num2 * 418096207u);
					continue;
				case 3u:
					goto IL_133;
				case 4u:
					goto IL_1FD;
				case 5u:
					arg_1A9_0 = ((!this.ResponseStreaming) ? 1616709793u : 1547815166u);
					continue;
				case 6u:
					num ^= Method.smethod_2(this.RequestTypeUrl);
					arg_1A9_0 = (num2 * 3295999191u ^ 3553419961u);
					continue;
				case 7u:
					arg_1A9_0 = (this.RequestStreaming ? 120569591u : 338615288u);
					continue;
				case 9u:
					num ^= this.options_.GetHashCode();
					arg_1A9_0 = 2086856976u;
					continue;
				case 10u:
					arg_1A9_0 = ((this.ResponseTypeUrl.Length == 0) ? 1923350725u : 121618717u);
					continue;
				case 11u:
					num ^= this.ResponseTypeUrl.GetHashCode();
					arg_1A9_0 = (num2 * 2490490282u ^ 1938488447u);
					continue;
				case 12u:
					num ^= this.ResponseStreaming.GetHashCode();
					arg_1A9_0 = (num2 * 3200364136u ^ 3724209329u);
					continue;
				case 13u:
					num ^= this.RequestStreaming.GetHashCode();
					arg_1A9_0 = (num2 * 2782881776u ^ 665211944u);
					continue;
				}
				break;
			}
			return num;
			IL_133:
			arg_1A9_0 = 445887955u;
			goto IL_1A4;
			IL_1FD:
			arg_1A9_0 = ((Method.smethod_1(this.RequestTypeUrl) == 0) ? 1124144643u : 142932898u);
			goto IL_1A4;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (Method.smethod_1(this.Name) != 0)
			{
				goto IL_14A;
			}
			goto IL_255;
			uint arg_1F5_0;
			while (true)
			{
				IL_1F0:
				uint num;
				switch ((num = (arg_1F5_0 ^ 3596599515u)) % 17u)
				{
				case 0u:
					output.WriteRawTag(24);
					arg_1F5_0 = (num * 163138056u ^ 1964607829u);
					continue;
				case 1u:
					arg_1F5_0 = (((this.Syntax != Syntax.SYNTAX_PROTO2) ? 631936343u : 689480009u) ^ num * 2443122934u);
					continue;
				case 2u:
					arg_1F5_0 = ((Method.smethod_1(this.ResponseTypeUrl) != 0) ? 2715950721u : 3237243522u);
					continue;
				case 3u:
					output.WriteRawTag(56);
					arg_1F5_0 = (num * 1535244687u ^ 771323186u);
					continue;
				case 4u:
					arg_1F5_0 = ((!this.RequestStreaming) ? 4090535490u : 2281479782u);
					continue;
				case 5u:
					goto IL_14A;
				case 6u:
					output.WriteString(this.RequestTypeUrl);
					arg_1F5_0 = (num * 1098084192u ^ 3804475138u);
					continue;
				case 7u:
					goto IL_255;
				case 8u:
					output.WriteRawTag(34);
					output.WriteString(this.ResponseTypeUrl);
					arg_1F5_0 = (num * 2431347220u ^ 1970325898u);
					continue;
				case 9u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_1F5_0 = (num * 889759870u ^ 4097619786u);
					continue;
				case 10u:
					arg_1F5_0 = ((!this.ResponseStreaming) ? 2965941011u : 4201475576u);
					continue;
				case 11u:
					output.WriteRawTag(18);
					arg_1F5_0 = (num * 2395790886u ^ 3072862975u);
					continue;
				case 13u:
					output.WriteRawTag(40);
					output.WriteBool(this.ResponseStreaming);
					arg_1F5_0 = (num * 1630289624u ^ 628892827u);
					continue;
				case 14u:
					output.WriteBool(this.RequestStreaming);
					arg_1F5_0 = (num * 92481181u ^ 2240878284u);
					continue;
				case 15u:
					output.WriteEnum((int)this.Syntax);
					arg_1F5_0 = (num * 1856796438u ^ 4220384161u);
					continue;
				case 16u:
					this.options_.WriteTo(output, Method._repeated_options_codec);
					arg_1F5_0 = 4046556900u;
					continue;
				}
				break;
			}
			return;
			IL_14A:
			arg_1F5_0 = 2613719900u;
			goto IL_1F0;
			IL_255:
			arg_1F5_0 = ((Method.smethod_1(this.RequestTypeUrl) == 0) ? 3096110658u : 2698480196u);
			goto IL_1F0;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_20C:
				uint arg_1C3_0 = 3342661884u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1C3_0 ^ 3953078059u)) % 15u)
					{
					case 0u:
						arg_1C3_0 = ((!this.ResponseStreaming) ? 4064871149u : 3520295340u);
						continue;
					case 1u:
						num += 2;
						arg_1C3_0 = (num2 * 4152035984u ^ 430011954u);
						continue;
					case 2u:
						num += this.options_.CalculateSize(Method._repeated_options_codec);
						arg_1C3_0 = 4048585387u;
						continue;
					case 3u:
						num += 2;
						arg_1C3_0 = (num2 * 3192645165u ^ 1303373142u);
						continue;
					case 4u:
						arg_1C3_0 = ((Method.smethod_1(this.RequestTypeUrl) == 0) ? 3250470349u : 3767479568u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_1C3_0 = (num2 * 3384104670u ^ 564867084u);
						continue;
					case 6u:
						arg_1C3_0 = ((Method.smethod_1(this.ResponseTypeUrl) != 0) ? 2397109187u : 3935696130u);
						continue;
					case 7u:
						arg_1C3_0 = (((Method.smethod_1(this.Name) == 0) ? 3564187157u : 3498453501u) ^ num2 * 1694168817u);
						continue;
					case 8u:
						arg_1C3_0 = (this.RequestStreaming ? 3247751115u : 3429582898u);
						continue;
					case 9u:
						arg_1C3_0 = (((this.Syntax != Syntax.SYNTAX_PROTO2) ? 3681966347u : 3280955495u) ^ num2 * 1606614923u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Syntax);
						arg_1C3_0 = (num2 * 1955989442u ^ 2609316263u);
						continue;
					case 11u:
						goto IL_20C;
					case 12u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.ResponseTypeUrl);
						arg_1C3_0 = (num2 * 4131553279u ^ 2991709722u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.RequestTypeUrl);
						arg_1C3_0 = (num2 * 2582579048u ^ 2266741045u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Method other)
		{
			if (other == null)
			{
				goto IL_102;
			}
			goto IL_1F4;
			uint arg_19C_0;
			while (true)
			{
				IL_197:
				uint num;
				switch ((num = (arg_19C_0 ^ 2572470603u)) % 15u)
				{
				case 0u:
					this.RequestStreaming = other.RequestStreaming;
					arg_19C_0 = (num * 1098902433u ^ 3138832656u);
					continue;
				case 1u:
					this.ResponseStreaming = other.ResponseStreaming;
					arg_19C_0 = (num * 3396863956u ^ 872888258u);
					continue;
				case 2u:
					this.Syntax = other.Syntax;
					arg_19C_0 = (num * 1865237126u ^ 41633534u);
					continue;
				case 3u:
					this.Name = other.Name;
					arg_19C_0 = (num * 339038038u ^ 1404856477u);
					continue;
				case 4u:
					arg_19C_0 = (other.RequestStreaming ? 2811903944u : 2976284787u);
					continue;
				case 5u:
					return;
				case 6u:
					goto IL_102;
				case 7u:
					arg_19C_0 = (other.ResponseStreaming ? 2756674206u : 3280119974u);
					continue;
				case 8u:
					this.options_.Add(other.options_);
					arg_19C_0 = ((other.Syntax == Syntax.SYNTAX_PROTO2) ? 3680720780u : 3932391704u);
					continue;
				case 9u:
					arg_19C_0 = ((Method.smethod_1(other.ResponseTypeUrl) != 0) ? 3542908381u : 2306327693u);
					continue;
				case 10u:
					arg_19C_0 = ((Method.smethod_1(other.RequestTypeUrl) == 0) ? 3366401907u : 4282839734u);
					continue;
				case 11u:
					goto IL_1F4;
				case 12u:
					this.RequestTypeUrl = other.RequestTypeUrl;
					arg_19C_0 = (num * 856103932u ^ 3113651071u);
					continue;
				case 14u:
					this.ResponseTypeUrl = other.ResponseTypeUrl;
					arg_19C_0 = (num * 1013803510u ^ 2493172393u);
					continue;
				}
				break;
			}
			return;
			IL_102:
			arg_19C_0 = 3750802675u;
			goto IL_197;
			IL_1F4:
			arg_19C_0 = ((Method.smethod_1(other.Name) != 0) ? 3029288332u : 2329533255u);
			goto IL_197;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_31F:
				uint num;
				uint arg_297_0 = ((num = input.ReadTag()) != 0u) ? 3622966202u : 2583586026u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_297_0 ^ 3508315744u)) % 27u)
					{
					case 0u:
						this.Name = input.ReadString();
						arg_297_0 = 4128261398u;
						continue;
					case 1u:
						this.ResponseTypeUrl = input.ReadString();
						arg_297_0 = 3391611700u;
						continue;
					case 2u:
						arg_297_0 = (((num != 56u) ? 3578190483u : 3784706331u) ^ num2 * 4244431325u);
						continue;
					case 3u:
						arg_297_0 = (num2 * 1222239527u ^ 1974604126u);
						continue;
					case 4u:
						arg_297_0 = ((num > 24u) ? 3728767070u : 3070759091u);
						continue;
					case 5u:
						arg_297_0 = (((num == 40u) ? 2303632670u : 3900245222u) ^ num2 * 162681107u);
						continue;
					case 6u:
						goto IL_31F;
					case 7u:
						arg_297_0 = (num2 * 931255559u ^ 302906894u);
						continue;
					case 8u:
						arg_297_0 = ((num == 50u) ? 3045185506u : 2426001241u);
						continue;
					case 9u:
						arg_297_0 = (num2 * 1354684559u ^ 2262731017u);
						continue;
					case 10u:
						arg_297_0 = (num2 * 1792967101u ^ 2094375174u);
						continue;
					case 11u:
						arg_297_0 = (((num != 10u) ? 170233906u : 1724843715u) ^ num2 * 301496205u);
						continue;
					case 12u:
						arg_297_0 = (((num != 34u) ? 2291999500u : 3536390895u) ^ num2 * 3773012398u);
						continue;
					case 13u:
						arg_297_0 = 3622966202u;
						continue;
					case 14u:
						this.RequestStreaming = input.ReadBool();
						arg_297_0 = 3949944081u;
						continue;
					case 15u:
						arg_297_0 = (((num != 24u) ? 1697246885u : 439355649u) ^ num2 * 1896849825u);
						continue;
					case 16u:
						arg_297_0 = ((num > 40u) ? 2729776973u : 2734481911u);
						continue;
					case 17u:
						arg_297_0 = (num2 * 3507865927u ^ 2899536730u);
						continue;
					case 18u:
						this.ResponseStreaming = input.ReadBool();
						arg_297_0 = 3933329480u;
						continue;
					case 19u:
						input.SkipLastField();
						arg_297_0 = 4128261398u;
						continue;
					case 20u:
						this.RequestTypeUrl = input.ReadString();
						arg_297_0 = 2449252376u;
						continue;
					case 22u:
						arg_297_0 = (num2 * 848859750u ^ 2053161710u);
						continue;
					case 23u:
						this.syntax_ = (Syntax)input.ReadEnum();
						arg_297_0 = 4128261398u;
						continue;
					case 24u:
						arg_297_0 = (((num != 18u) ? 3439072729u : 3203818168u) ^ num2 * 98105178u);
						continue;
					case 25u:
						arg_297_0 = (num2 * 3565717536u ^ 2156947046u);
						continue;
					case 26u:
						this.options_.AddEntriesFrom(input, Method._repeated_options_codec);
						arg_297_0 = 3738266416u;
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
