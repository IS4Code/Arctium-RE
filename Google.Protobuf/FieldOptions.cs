using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class FieldOptions : IMessage<FieldOptions>, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum CType
			{
				STRING,
				CORD,
				STRING_PIECE
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldOptions.__c __9 = new FieldOptions.__c();

			internal FieldOptions cctor>b__55_0()
			{
				return new FieldOptions();
			}
		}

		private static readonly MessageParser<FieldOptions> _parser = new MessageParser<FieldOptions>(new Func<FieldOptions>(FieldOptions.__c.__9.<.cctor>b__55_0));

		public const int CtypeFieldNumber = 1;

		private FieldOptions.Types.CType ctype_;

		public const int PackedFieldNumber = 2;

		private bool packed_;

		public const int LazyFieldNumber = 5;

		private bool lazy_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int ExperimentalMapKeyFieldNumber = 9;

		private string experimentalMapKey_ = "";

		public const int WeakFieldNumber = 10;

		private bool weak_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<FieldOptions> Parser
		{
			get
			{
				return FieldOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldOptions.Descriptor;
			}
		}

		public FieldOptions.Types.CType Ctype
		{
			get
			{
				return this.ctype_;
			}
			set
			{
				this.ctype_ = value;
			}
		}

		public bool Packed
		{
			get
			{
				return this.packed_;
			}
			set
			{
				this.packed_ = value;
			}
		}

		public bool Lazy
		{
			get
			{
				return this.lazy_;
			}
			set
			{
				this.lazy_ = value;
			}
		}

		public bool Deprecated
		{
			get
			{
				return this.deprecated_;
			}
			set
			{
				this.deprecated_ = value;
			}
		}

		public string ExperimentalMapKey
		{
			get
			{
				return this.experimentalMapKey_;
			}
			set
			{
				this.experimentalMapKey_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public bool Weak
		{
			get
			{
				return this.weak_;
			}
			set
			{
				this.weak_ = value;
			}
		}

		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return this.uninterpretedOption_;
			}
		}

		public FieldOptions()
		{
		}

		public FieldOptions(FieldOptions other) : this()
		{
			this.ctype_ = other.ctype_;
			this.packed_ = other.packed_;
			this.lazy_ = other.lazy_;
			this.deprecated_ = other.deprecated_;
			this.experimentalMapKey_ = other.experimentalMapKey_;
			this.weak_ = other.weak_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		public FieldOptions Clone()
		{
			return new FieldOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FieldOptions);
		}

		public bool Equals(FieldOptions other)
		{
			if (other == null)
			{
				goto IL_C5;
			}
			goto IL_1AF;
			int arg_149_0;
			while (true)
			{
				IL_144:
				switch ((arg_149_0 ^ -2081981996) % 19)
				{
				case 0:
					return false;
				case 1:
					arg_149_0 = ((this.Weak != other.Weak) ? -1624195903 : -1516080663);
					continue;
				case 2:
					return false;
				case 3:
					arg_149_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? -285863892 : -1422631950);
					continue;
				case 4:
					goto IL_1AF;
				case 5:
					arg_149_0 = ((this.Ctype == other.Ctype) ? -1076663946 : -1430799109);
					continue;
				case 6:
					return false;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					goto IL_C5;
				case 12:
					arg_149_0 = ((this.Deprecated != other.Deprecated) ? -1740793617 : -1672757937);
					continue;
				case 13:
					arg_149_0 = ((!FieldOptions.smethod_0(this.ExperimentalMapKey, other.ExperimentalMapKey)) ? -1499774146 : -1991919803);
					continue;
				case 14:
					arg_149_0 = ((this.Lazy == other.Lazy) ? -1550292027 : -1170957898);
					continue;
				case 15:
					return false;
				case 16:
					return true;
				case 17:
					arg_149_0 = ((this.Packed == other.Packed) ? -58660157 : -420098853);
					continue;
				case 18:
					return false;
				}
				break;
			}
			return true;
			IL_C5:
			arg_149_0 = -677489670;
			goto IL_144;
			IL_1AF:
			arg_149_0 = ((other == this) ? -934889759 : -179741925);
			goto IL_144;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Ctype != FieldOptions.Types.CType.STRING)
			{
				goto IL_42;
			}
			goto IL_1F3;
			uint arg_19F_0;
			while (true)
			{
				IL_19A:
				uint num2;
				switch ((num2 = (arg_19F_0 ^ 1635394032u)) % 14u)
				{
				case 0u:
					arg_19F_0 = ((this.ExperimentalMapKey.Length == 0) ? 184298873u : 481575190u);
					continue;
				case 1u:
					num ^= this.Weak.GetHashCode();
					arg_19F_0 = (num2 * 625208540u ^ 3973553274u);
					continue;
				case 2u:
					num ^= this.uninterpretedOption_.GetHashCode();
					arg_19F_0 = 366976864u;
					continue;
				case 3u:
					num ^= this.Ctype.GetHashCode();
					arg_19F_0 = (num2 * 2396430427u ^ 1711029178u);
					continue;
				case 4u:
					arg_19F_0 = ((!this.Deprecated) ? 2069827542u : 1655531018u);
					continue;
				case 5u:
					arg_19F_0 = (this.Lazy ? 1339691257u : 1010292248u);
					continue;
				case 7u:
					arg_19F_0 = (this.Weak ? 496256393u : 117407622u);
					continue;
				case 8u:
					num ^= this.Deprecated.GetHashCode();
					arg_19F_0 = (num2 * 2040904305u ^ 3509282444u);
					continue;
				case 9u:
					goto IL_1F3;
				case 10u:
					num ^= this.ExperimentalMapKey.GetHashCode();
					arg_19F_0 = (num2 * 3588129380u ^ 1572505761u);
					continue;
				case 11u:
					num ^= this.Lazy.GetHashCode();
					arg_19F_0 = (num2 * 1822338429u ^ 685691005u);
					continue;
				case 12u:
					goto IL_42;
				case 13u:
					num ^= this.Packed.GetHashCode();
					arg_19F_0 = (num2 * 3709731284u ^ 97221323u);
					continue;
				}
				break;
			}
			return num;
			IL_42:
			arg_19F_0 = 1449295193u;
			goto IL_19A;
			IL_1F3:
			arg_19F_0 = ((!this.Packed) ? 659097359u : 544055933u);
			goto IL_19A;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Ctype != FieldOptions.Types.CType.STRING)
			{
				goto IL_187;
			}
			goto IL_225;
			uint arg_1C9_0;
			while (true)
			{
				IL_1C4:
				uint num;
				switch ((num = (arg_1C9_0 ^ 863886030u)) % 16u)
				{
				case 0u:
					output.WriteRawTag(16);
					arg_1C9_0 = (num * 994478485u ^ 3312583665u);
					continue;
				case 1u:
					arg_1C9_0 = (this.Lazy ? 1911454118u : 1895812200u);
					continue;
				case 2u:
					goto IL_187;
				case 4u:
					output.WriteRawTag(80);
					arg_1C9_0 = (num * 1126458327u ^ 418410940u);
					continue;
				case 5u:
					output.WriteString(this.ExperimentalMapKey);
					arg_1C9_0 = (num * 3286835643u ^ 918681486u);
					continue;
				case 6u:
					arg_1C9_0 = ((FieldOptions.smethod_1(this.ExperimentalMapKey) != 0) ? 1272059399u : 2057655225u);
					continue;
				case 7u:
					arg_1C9_0 = (this.Weak ? 1507435994u : 45885853u);
					continue;
				case 8u:
					output.WriteRawTag(40);
					output.WriteBool(this.Lazy);
					arg_1C9_0 = (num * 74977264u ^ 960726504u);
					continue;
				case 9u:
					output.WriteRawTag(74);
					arg_1C9_0 = (num * 2122960463u ^ 2043026300u);
					continue;
				case 10u:
					goto IL_225;
				case 11u:
					output.WriteRawTag(24);
					output.WriteBool(this.Deprecated);
					arg_1C9_0 = (num * 2838871883u ^ 1638364166u);
					continue;
				case 12u:
					output.WriteRawTag(8);
					output.WriteEnum((int)this.Ctype);
					arg_1C9_0 = (num * 410367379u ^ 494124656u);
					continue;
				case 13u:
					arg_1C9_0 = (this.Deprecated ? 337478581u : 1154779151u);
					continue;
				case 14u:
					output.WriteBool(this.Weak);
					arg_1C9_0 = (num * 632737079u ^ 73410895u);
					continue;
				case 15u:
					output.WriteBool(this.Packed);
					arg_1C9_0 = (num * 2611132010u ^ 4038272565u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.WriteTo(output, FieldOptions._repeated_uninterpretedOption_codec);
			return;
			IL_187:
			arg_1C9_0 = 188898482u;
			goto IL_1C4;
			IL_225:
			arg_1C9_0 = ((!this.Packed) ? 332610051u : 1242162366u);
			goto IL_1C4;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Ctype != FieldOptions.Types.CType.STRING)
			{
				goto IL_1F;
			}
			goto IL_19E;
			uint arg_14E_0;
			while (true)
			{
				IL_149:
				uint num2;
				switch ((num2 = (arg_14E_0 ^ 1482057869u)) % 13u)
				{
				case 0u:
					num += 2;
					arg_14E_0 = (num2 * 2070661106u ^ 3544074930u);
					continue;
				case 1u:
					arg_14E_0 = (this.Weak ? 361390456u : 303529010u);
					continue;
				case 2u:
					arg_14E_0 = (this.Lazy ? 1524584354u : 2105476475u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Ctype);
					arg_14E_0 = (num2 * 2734677416u ^ 2614767472u);
					continue;
				case 5u:
					num += 2;
					arg_14E_0 = (num2 * 999873067u ^ 741384094u);
					continue;
				case 6u:
					goto IL_19E;
				case 7u:
					num += 2;
					arg_14E_0 = (num2 * 2064834805u ^ 534487565u);
					continue;
				case 8u:
					arg_14E_0 = ((FieldOptions.smethod_1(this.ExperimentalMapKey) != 0) ? 1145229147u : 1950561738u);
					continue;
				case 9u:
					arg_14E_0 = ((!this.Deprecated) ? 1795057744u : 1463742388u);
					continue;
				case 10u:
					num += 2;
					arg_14E_0 = (num2 * 1949422672u ^ 1794145442u);
					continue;
				case 11u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.ExperimentalMapKey);
					arg_14E_0 = (num2 * 3862603115u ^ 587735480u);
					continue;
				case 12u:
					goto IL_1F;
				}
				break;
			}
			return num + this.uninterpretedOption_.CalculateSize(FieldOptions._repeated_uninterpretedOption_codec);
			IL_1F:
			arg_14E_0 = 940748341u;
			goto IL_149;
			IL_19E:
			arg_14E_0 = (this.Packed ? 807218384u : 918056716u);
			goto IL_149;
		}

		public void MergeFrom(FieldOptions other)
		{
			if (other == null)
			{
				goto IL_DA;
			}
			goto IL_1DE;
			uint arg_186_0;
			while (true)
			{
				IL_181:
				uint num;
				switch ((num = (arg_186_0 ^ 265537020u)) % 15u)
				{
				case 1u:
					this.Lazy = other.Lazy;
					arg_186_0 = (num * 571856102u ^ 463007511u);
					continue;
				case 2u:
					arg_186_0 = ((!other.Weak) ? 261904649u : 1031832185u);
					continue;
				case 3u:
					arg_186_0 = ((!other.Deprecated) ? 1596833648u : 1089431719u);
					continue;
				case 4u:
					arg_186_0 = ((!other.Packed) ? 1185526608u : 1209017526u);
					continue;
				case 5u:
					arg_186_0 = ((!other.Lazy) ? 617866511u : 953180728u);
					continue;
				case 6u:
					goto IL_DA;
				case 7u:
					this.Weak = other.Weak;
					arg_186_0 = (num * 719969276u ^ 3182064869u);
					continue;
				case 8u:
					this.Ctype = other.Ctype;
					arg_186_0 = (num * 4212773894u ^ 131129401u);
					continue;
				case 9u:
					return;
				case 10u:
					this.Packed = other.Packed;
					arg_186_0 = (num * 4168551260u ^ 3637549000u);
					continue;
				case 11u:
					arg_186_0 = ((FieldOptions.smethod_1(other.ExperimentalMapKey) != 0) ? 1439642696u : 1545933656u);
					continue;
				case 12u:
					goto IL_1DE;
				case 13u:
					this.Deprecated = other.Deprecated;
					arg_186_0 = (num * 1376997245u ^ 852296991u);
					continue;
				case 14u:
					this.ExperimentalMapKey = other.ExperimentalMapKey;
					arg_186_0 = (num * 1899562375u ^ 120253108u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.Add(other.uninterpretedOption_);
			return;
			IL_DA:
			arg_186_0 = 1279948480u;
			goto IL_181;
			IL_1DE:
			arg_186_0 = ((other.Ctype == FieldOptions.Types.CType.STRING) ? 1899655613u : 1129020522u);
			goto IL_181;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_337:
				uint num;
				uint arg_2AB_0 = ((num = input.ReadTag()) != 0u) ? 4072422265u : 4205096718u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2AB_0 ^ 3967929765u)) % 28u)
					{
					case 0u:
						arg_2AB_0 = ((num <= 74u) ? 2256470969u : 2428349656u);
						continue;
					case 1u:
						arg_2AB_0 = ((num != 80u) ? 3564815358u : 3472362930u);
						continue;
					case 2u:
						this.ctype_ = (FieldOptions.Types.CType)input.ReadEnum();
						arg_2AB_0 = 2196347841u;
						continue;
					case 3u:
						this.Weak = input.ReadBool();
						arg_2AB_0 = 3944921740u;
						continue;
					case 4u:
						arg_2AB_0 = (num2 * 1210399168u ^ 34791820u);
						continue;
					case 5u:
						this.Lazy = input.ReadBool();
						arg_2AB_0 = 2312849466u;
						continue;
					case 6u:
						arg_2AB_0 = 4072422265u;
						continue;
					case 7u:
						this.ExperimentalMapKey = input.ReadString();
						arg_2AB_0 = 2181167536u;
						continue;
					case 8u:
						this.Deprecated = input.ReadBool();
						arg_2AB_0 = 4186049952u;
						continue;
					case 9u:
						arg_2AB_0 = (num2 * 3418006702u ^ 3239251434u);
						continue;
					case 10u:
						this.uninterpretedOption_.AddEntriesFrom(input, FieldOptions._repeated_uninterpretedOption_codec);
						arg_2AB_0 = 3944921740u;
						continue;
					case 11u:
						input.SkipLastField();
						arg_2AB_0 = 2339846874u;
						continue;
					case 12u:
						arg_2AB_0 = ((num <= 24u) ? 3322358875u : 3848514133u);
						continue;
					case 13u:
						this.Packed = input.ReadBool();
						arg_2AB_0 = 2350076945u;
						continue;
					case 14u:
						arg_2AB_0 = (((num == 16u) ? 3926986880u : 3137521652u) ^ num2 * 3951413028u);
						continue;
					case 16u:
						arg_2AB_0 = (((num == 74u) ? 44233326u : 704905275u) ^ num2 * 2711955004u);
						continue;
					case 17u:
						goto IL_337;
					case 18u:
						arg_2AB_0 = (num2 * 1424169486u ^ 1736934022u);
						continue;
					case 19u:
						arg_2AB_0 = (((num != 7994u) ? 1885537397u : 1328348536u) ^ num2 * 1439000277u);
						continue;
					case 20u:
						arg_2AB_0 = (num2 * 3984474796u ^ 3333777852u);
						continue;
					case 21u:
						arg_2AB_0 = (num2 * 4111821529u ^ 4124536129u);
						continue;
					case 22u:
						arg_2AB_0 = (((num == 8u) ? 3131066525u : 4067338281u) ^ num2 * 2448977067u);
						continue;
					case 23u:
						arg_2AB_0 = (num2 * 2856092636u ^ 4219737256u);
						continue;
					case 24u:
						arg_2AB_0 = (((num == 40u) ? 3188864196u : 3557209125u) ^ num2 * 2867859933u);
						continue;
					case 25u:
						arg_2AB_0 = (((num == 24u) ? 2056454415u : 301604229u) ^ num2 * 4248544986u);
						continue;
					case 26u:
						arg_2AB_0 = (num2 * 3053427591u ^ 1954947076u);
						continue;
					case 27u:
						arg_2AB_0 = (num2 * 1333235743u ^ 3022660813u);
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
	}
}
