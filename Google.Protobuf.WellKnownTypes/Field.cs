using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Field : IMessage<Field>, IEquatable<Field>, IDeepCloneable<Field>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Kind
			{
				TYPE_UNKNOWN,
				TYPE_DOUBLE,
				TYPE_FLOAT,
				TYPE_INT64,
				TYPE_UINT64,
				TYPE_INT32,
				TYPE_FIXED64,
				TYPE_FIXED32,
				TYPE_BOOL,
				TYPE_STRING,
				TYPE_GROUP,
				TYPE_MESSAGE,
				TYPE_BYTES,
				TYPE_UINT32,
				TYPE_ENUM,
				TYPE_SFIXED32,
				TYPE_SFIXED64,
				TYPE_SINT32,
				TYPE_SINT64
			}

			public enum Cardinality
			{
				CARDINALITY_UNKNOWN,
				CARDINALITY_OPTIONAL,
				CARDINALITY_REQUIRED,
				CARDINALITY_REPEATED
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Field.__c __9 = new Field.__c();

			internal Field cctor>b__65_0()
			{
				return new Field();
			}
		}

		private static readonly MessageParser<Field> _parser = new MessageParser<Field>(new Func<Field>(Field.__c.__9.<.cctor>b__65_0));

		public const int KindFieldNumber = 1;

		private Field.Types.Kind kind_;

		public const int CardinalityFieldNumber = 2;

		private Field.Types.Cardinality cardinality_;

		public const int NumberFieldNumber = 3;

		private int number_;

		public const int NameFieldNumber = 4;

		private string name_ = "";

		public const int TypeUrlFieldNumber = 6;

		private string typeUrl_ = "";

		public const int OneofIndexFieldNumber = 7;

		private int oneofIndex_;

		public const int PackedFieldNumber = 8;

		private bool packed_;

		public const int OptionsFieldNumber = 9;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage<Option>(74u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int JsonNameFieldNumber = 10;

		private string jsonName_ = "";

		public static MessageParser<Field> Parser
		{
			get
			{
				return Field._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return TypeReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Field.Descriptor;
			}
		}

		public Field.Types.Kind Kind
		{
			get
			{
				return this.kind_;
			}
			set
			{
				this.kind_ = value;
			}
		}

		public Field.Types.Cardinality Cardinality
		{
			get
			{
				return this.cardinality_;
			}
			set
			{
				this.cardinality_ = value;
			}
		}

		public int Number
		{
			get
			{
				return this.number_;
			}
			set
			{
				this.number_ = value;
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

		public string TypeUrl
		{
			get
			{
				return this.typeUrl_;
			}
			set
			{
				this.typeUrl_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public int OneofIndex
		{
			get
			{
				return this.oneofIndex_;
			}
			set
			{
				this.oneofIndex_ = value;
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

		public RepeatedField<Option> Options
		{
			get
			{
				return this.options_;
			}
		}

		public string JsonName
		{
			get
			{
				return this.jsonName_;
			}
			set
			{
				this.jsonName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public Field()
		{
		}

		public Field(Field other) : this()
		{
			while (true)
			{
				IL_F2:
				uint arg_CA_0 = 1517558561u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CA_0 ^ 1362300322u)) % 7u)
					{
					case 0u:
						this.cardinality_ = other.cardinality_;
						arg_CA_0 = (num * 2353230547u ^ 2988512173u);
						continue;
					case 1u:
						this.kind_ = other.kind_;
						arg_CA_0 = (num * 3775475076u ^ 1856897534u);
						continue;
					case 3u:
						this.number_ = other.number_;
						this.name_ = other.name_;
						arg_CA_0 = (num * 863769094u ^ 3888169305u);
						continue;
					case 4u:
						this.jsonName_ = other.jsonName_;
						arg_CA_0 = (num * 1280363357u ^ 602833274u);
						continue;
					case 5u:
						this.typeUrl_ = other.typeUrl_;
						this.oneofIndex_ = other.oneofIndex_;
						this.packed_ = other.packed_;
						this.options_ = other.options_.Clone();
						arg_CA_0 = (num * 2669345575u ^ 4130885210u);
						continue;
					case 6u:
						goto IL_F2;
					}
					return;
				}
			}
		}

		public Field Clone()
		{
			return new Field(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Field);
		}

		public bool Equals(Field other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_21D;
			int arg_1A7_0;
			while (true)
			{
				IL_1A2:
				switch ((arg_1A7_0 ^ 862320423) % 23)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_1A7_0 = ((!this.options_.Equals(other.options_)) ? 1565439857 : 1824735849);
					continue;
				case 5:
					return false;
				case 7:
					arg_1A7_0 = ((this.Cardinality != other.Cardinality) ? 152634157 : 2016510882);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					arg_1A7_0 = (Field.smethod_0(this.JsonName, other.JsonName) ? 149449404 : 305840536);
					continue;
				case 12:
					arg_1A7_0 = (Field.smethod_0(this.Name, other.Name) ? 1638810999 : 1795277875);
					continue;
				case 13:
					arg_1A7_0 = ((this.Kind == other.Kind) ? 880033106 : 851271649);
					continue;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					goto IL_21D;
				case 17:
					arg_1A7_0 = ((this.OneofIndex != other.OneofIndex) ? 447273274 : 482087163);
					continue;
				case 18:
					arg_1A7_0 = ((this.Packed == other.Packed) ? 2099215414 : 251167455);
					continue;
				case 19:
					arg_1A7_0 = ((this.Number != other.Number) ? 1192303964 : 1562102392);
					continue;
				case 20:
					return false;
				case 21:
					goto IL_47;
				case 22:
					arg_1A7_0 = ((!Field.smethod_0(this.TypeUrl, other.TypeUrl)) ? 597904361 : 1713629756);
					continue;
				}
				break;
			}
			return true;
			IL_47:
			arg_1A7_0 = 934293685;
			goto IL_1A2;
			IL_21D:
			arg_1A7_0 = ((other != this) ? 390601170 : 788578966);
			goto IL_1A2;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Kind != Field.Types.Kind.TYPE_UNKNOWN)
			{
				goto IL_120;
			}
			goto IL_2B4;
			uint arg_24F_0;
			while (true)
			{
				IL_24A:
				uint num2;
				switch ((num2 = (arg_24F_0 ^ 772844474u)) % 18u)
				{
				case 0u:
					num ^= this.Number.GetHashCode();
					arg_24F_0 = (num2 * 1074728398u ^ 569637469u);
					continue;
				case 1u:
					arg_24F_0 = ((this.TypeUrl.Length == 0) ? 154006979u : 1177300085u);
					continue;
				case 2u:
					num ^= this.Name.GetHashCode();
					arg_24F_0 = (num2 * 823755890u ^ 1638479049u);
					continue;
				case 3u:
					num ^= this.Cardinality.GetHashCode();
					arg_24F_0 = (num2 * 2733477387u ^ 3066376356u);
					continue;
				case 5u:
					arg_24F_0 = ((this.Name.Length == 0) ? 584286629u : 2090275804u);
					continue;
				case 6u:
					num ^= this.OneofIndex.GetHashCode();
					arg_24F_0 = (num2 * 4105522207u ^ 310759563u);
					continue;
				case 7u:
					num ^= this.Packed.GetHashCode();
					arg_24F_0 = (num2 * 2742135704u ^ 2700444768u);
					continue;
				case 8u:
					goto IL_2B4;
				case 9u:
					arg_24F_0 = ((this.OneofIndex != 0) ? 69930116u : 993032201u);
					continue;
				case 10u:
					goto IL_120;
				case 11u:
					num ^= this.TypeUrl.GetHashCode();
					arg_24F_0 = (num2 * 2058176383u ^ 3854122354u);
					continue;
				case 12u:
					num ^= this.JsonName.GetHashCode();
					arg_24F_0 = (num2 * 18230168u ^ 1937529680u);
					continue;
				case 13u:
					arg_24F_0 = (((this.JsonName.Length == 0) ? 199708453u : 1263806287u) ^ num2 * 4185828209u);
					continue;
				case 14u:
					num ^= this.options_.GetHashCode();
					arg_24F_0 = 1302894847u;
					continue;
				case 15u:
					arg_24F_0 = ((this.Number != 0) ? 1212283814u : 164632789u);
					continue;
				case 16u:
					num ^= this.Kind.GetHashCode();
					arg_24F_0 = (num2 * 1768140344u ^ 604897786u);
					continue;
				case 17u:
					arg_24F_0 = (this.Packed ? 2077800805u : 1142992136u);
					continue;
				}
				break;
			}
			return num;
			IL_120:
			arg_24F_0 = 1179483330u;
			goto IL_24A;
			IL_2B4:
			arg_24F_0 = ((this.Cardinality == Field.Types.Cardinality.CARDINALITY_UNKNOWN) ? 979495705u : 105392621u);
			goto IL_24A;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Kind != Field.Types.Kind.TYPE_UNKNOWN)
			{
				goto IL_268;
			}
			goto IL_326;
			uint arg_2AE_0;
			while (true)
			{
				IL_2A9:
				uint num;
				switch ((num = (arg_2AE_0 ^ 4187353583u)) % 23u)
				{
				case 0u:
					arg_2AE_0 = ((this.Number == 0) ? 4023086830u : 3131276218u);
					continue;
				case 2u:
					output.WriteBool(this.Packed);
					arg_2AE_0 = (num * 1194861656u ^ 3578232760u);
					continue;
				case 3u:
					goto IL_268;
				case 4u:
					output.WriteRawTag(16);
					output.WriteEnum((int)this.Cardinality);
					arg_2AE_0 = (num * 1716742199u ^ 2702642270u);
					continue;
				case 5u:
					output.WriteInt32(this.Number);
					arg_2AE_0 = (num * 3822271554u ^ 3709543298u);
					continue;
				case 6u:
					output.WriteEnum((int)this.Kind);
					arg_2AE_0 = (num * 3389276479u ^ 1374602406u);
					continue;
				case 7u:
					output.WriteRawTag(64);
					arg_2AE_0 = (num * 3838947111u ^ 2348024253u);
					continue;
				case 8u:
					arg_2AE_0 = ((Field.smethod_1(this.TypeUrl) != 0) ? 2405903651u : 3134151895u);
					continue;
				case 9u:
					arg_2AE_0 = ((Field.smethod_1(this.Name) == 0) ? 2567204871u : 4079982196u);
					continue;
				case 10u:
					output.WriteRawTag(56);
					arg_2AE_0 = (num * 1354493129u ^ 2688935955u);
					continue;
				case 11u:
					output.WriteRawTag(24);
					arg_2AE_0 = (num * 2010446471u ^ 2136856266u);
					continue;
				case 12u:
					output.WriteString(this.TypeUrl);
					arg_2AE_0 = (num * 1642532057u ^ 3616961750u);
					continue;
				case 13u:
					output.WriteInt32(this.OneofIndex);
					arg_2AE_0 = (num * 3469563204u ^ 4221243004u);
					continue;
				case 14u:
					this.options_.WriteTo(output, Field._repeated_options_codec);
					arg_2AE_0 = 3289620358u;
					continue;
				case 15u:
					arg_2AE_0 = (this.Packed ? 3338660871u : 4161635528u);
					continue;
				case 16u:
					output.WriteRawTag(34);
					output.WriteString(this.Name);
					arg_2AE_0 = (num * 3019613346u ^ 3007949841u);
					continue;
				case 17u:
					goto IL_326;
				case 18u:
					output.WriteRawTag(50);
					arg_2AE_0 = (num * 485489413u ^ 2129770874u);
					continue;
				case 19u:
					output.WriteRawTag(82);
					output.WriteString(this.JsonName);
					arg_2AE_0 = (num * 939752162u ^ 339011202u);
					continue;
				case 20u:
					arg_2AE_0 = ((this.OneofIndex != 0) ? 3526964381u : 3203915012u);
					continue;
				case 21u:
					output.WriteRawTag(8);
					arg_2AE_0 = (num * 2373930637u ^ 3526912694u);
					continue;
				case 22u:
					arg_2AE_0 = (((Field.smethod_1(this.JsonName) != 0) ? 2070607807u : 926285105u) ^ num * 1128940713u);
					continue;
				}
				break;
			}
			return;
			IL_268:
			arg_2AE_0 = 2421072390u;
			goto IL_2A9;
			IL_326:
			arg_2AE_0 = ((this.Cardinality == Field.Types.Cardinality.CARDINALITY_UNKNOWN) ? 3609598086u : 4119266311u);
			goto IL_2A9;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_29E:
				uint arg_249_0 = 2302187739u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_249_0 ^ 4100832533u)) % 18u)
					{
					case 0u:
						num += 2;
						arg_249_0 = (num2 * 3872970157u ^ 1371870066u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Kind);
						arg_249_0 = (num2 * 215081968u ^ 1092779395u);
						continue;
					case 2u:
						arg_249_0 = ((this.Number == 0) ? 3034099478u : 3436145234u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.TypeUrl);
						arg_249_0 = (num2 * 2482652596u ^ 361138523u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Cardinality);
						arg_249_0 = (num2 * 2403885844u ^ 3683138043u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.OneofIndex);
						arg_249_0 = (num2 * 1757803174u ^ 2149060355u);
						continue;
					case 6u:
						goto IL_29E;
					case 7u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_249_0 = (num2 * 4027933145u ^ 3298080281u);
						continue;
					case 8u:
						arg_249_0 = ((this.Cardinality == Field.Types.Cardinality.CARDINALITY_UNKNOWN) ? 3184820723u : 2917736207u);
						continue;
					case 9u:
						num += this.options_.CalculateSize(Field._repeated_options_codec);
						arg_249_0 = ((Field.smethod_1(this.JsonName) != 0) ? 3894847655u : 4068816472u);
						continue;
					case 10u:
						arg_249_0 = ((this.OneofIndex != 0) ? 3053182544u : 2641139645u);
						continue;
					case 11u:
						arg_249_0 = ((Field.smethod_1(this.Name) != 0) ? 2988178818u : 2710323430u);
						continue;
					case 12u:
						arg_249_0 = (((this.Kind == Field.Types.Kind.TYPE_UNKNOWN) ? 1959722953u : 200632092u) ^ num2 * 4291149995u);
						continue;
					case 14u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.JsonName);
						arg_249_0 = (num2 * 2105409930u ^ 3517863340u);
						continue;
					case 15u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Number);
						arg_249_0 = (num2 * 1032054319u ^ 1937571615u);
						continue;
					case 16u:
						arg_249_0 = (this.Packed ? 3436958529u : 4197540278u);
						continue;
					case 17u:
						arg_249_0 = ((Field.smethod_1(this.TypeUrl) == 0) ? 2749171783u : 2564153622u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Field other)
		{
			if (other == null)
			{
				goto IL_17A;
			}
			goto IL_28D;
			uint arg_225_0;
			while (true)
			{
				IL_220:
				uint num;
				switch ((num = (arg_225_0 ^ 159975507u)) % 19u)
				{
				case 0u:
					arg_225_0 = ((!other.Packed) ? 1638566156u : 529462232u);
					continue;
				case 1u:
					arg_225_0 = ((Field.smethod_1(other.Name) != 0) ? 328082206u : 1034110526u);
					continue;
				case 2u:
					this.TypeUrl = other.TypeUrl;
					arg_225_0 = (num * 4013860908u ^ 1807190071u);
					continue;
				case 3u:
					this.Packed = other.Packed;
					arg_225_0 = (num * 311970328u ^ 509037060u);
					continue;
				case 4u:
					arg_225_0 = ((other.Cardinality == Field.Types.Cardinality.CARDINALITY_UNKNOWN) ? 1903277438u : 2119664568u);
					continue;
				case 5u:
					goto IL_17A;
				case 6u:
					this.Number = other.Number;
					arg_225_0 = (num * 422897170u ^ 938495572u);
					continue;
				case 7u:
					arg_225_0 = ((other.Number != 0) ? 951297082u : 1152006966u);
					continue;
				case 8u:
					return;
				case 9u:
					this.Cardinality = other.Cardinality;
					arg_225_0 = (num * 2205349523u ^ 1335205007u);
					continue;
				case 10u:
					this.Kind = other.Kind;
					arg_225_0 = (num * 1141709406u ^ 420197198u);
					continue;
				case 11u:
					goto IL_28D;
				case 12u:
					this.options_.Add(other.options_);
					arg_225_0 = ((Field.smethod_1(other.JsonName) == 0) ? 1996859116u : 609560575u);
					continue;
				case 13u:
					this.OneofIndex = other.OneofIndex;
					arg_225_0 = (num * 575899570u ^ 1396746159u);
					continue;
				case 15u:
					this.JsonName = other.JsonName;
					arg_225_0 = (num * 4265680425u ^ 2675993696u);
					continue;
				case 16u:
					this.Name = other.Name;
					arg_225_0 = (num * 1763396361u ^ 397169291u);
					continue;
				case 17u:
					arg_225_0 = ((Field.smethod_1(other.TypeUrl) != 0) ? 34404098u : 881099227u);
					continue;
				case 18u:
					arg_225_0 = ((other.OneofIndex != 0) ? 1140974654u : 1819834725u);
					continue;
				}
				break;
			}
			return;
			IL_17A:
			arg_225_0 = 1776423470u;
			goto IL_220;
			IL_28D:
			arg_225_0 = ((other.Kind != Field.Types.Kind.TYPE_UNKNOWN) ? 1729531258u : 1613085760u);
			goto IL_220;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3E4:
				uint num;
				uint arg_344_0 = ((num = input.ReadTag()) == 0u) ? 128222936u : 2125880398u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_344_0 ^ 397321064u)) % 33u)
					{
					case 0u:
						arg_344_0 = (num2 * 2652405769u ^ 2862387554u);
						continue;
					case 1u:
						arg_344_0 = (((num != 50u) ? 32590834u : 1677943041u) ^ num2 * 361693664u);
						continue;
					case 2u:
						arg_344_0 = (num2 * 1316915927u ^ 734233727u);
						continue;
					case 3u:
						this.JsonName = input.ReadString();
						arg_344_0 = 298561703u;
						continue;
					case 4u:
						this.Number = input.ReadInt32();
						arg_344_0 = 1177603456u;
						continue;
					case 5u:
						this.Name = input.ReadString();
						arg_344_0 = 298561703u;
						continue;
					case 6u:
						arg_344_0 = (((num != 74u) ? 1049430111u : 2054091466u) ^ num2 * 2433146805u);
						continue;
					case 7u:
						this.OneofIndex = input.ReadInt32();
						arg_344_0 = 2046666121u;
						continue;
					case 8u:
						arg_344_0 = (((num == 56u) ? 433162777u : 1717569462u) ^ num2 * 2884532970u);
						continue;
					case 9u:
						arg_344_0 = (((num == 16u) ? 3453497819u : 3587331032u) ^ num2 * 2533654899u);
						continue;
					case 10u:
						arg_344_0 = ((num != 24u) ? 620755320u : 541884249u);
						continue;
					case 11u:
						arg_344_0 = (num2 * 3196836177u ^ 3672424205u);
						continue;
					case 12u:
						arg_344_0 = (((num == 82u) ? 1214926017u : 747827853u) ^ num2 * 3724334124u);
						continue;
					case 13u:
						arg_344_0 = 2125880398u;
						continue;
					case 14u:
						this.TypeUrl = input.ReadString();
						arg_344_0 = 298561703u;
						continue;
					case 15u:
						goto IL_3E4;
					case 16u:
						arg_344_0 = (((num == 34u) ? 2564435485u : 4013905880u) ^ num2 * 4062172201u);
						continue;
					case 18u:
						arg_344_0 = (num2 * 738989470u ^ 294653761u);
						continue;
					case 19u:
						arg_344_0 = (((num == 8u) ? 935237436u : 1089981979u) ^ num2 * 2830034659u);
						continue;
					case 20u:
						this.Packed = input.ReadBool();
						arg_344_0 = 808100060u;
						continue;
					case 21u:
						arg_344_0 = (num2 * 831037159u ^ 2680414155u);
						continue;
					case 22u:
						arg_344_0 = (num2 * 855941679u ^ 2882999784u);
						continue;
					case 23u:
						arg_344_0 = (num2 * 2138289014u ^ 2542180949u);
						continue;
					case 24u:
						arg_344_0 = (((num <= 16u) ? 3483065239u : 3646119396u) ^ num2 * 3202748624u);
						continue;
					case 25u:
						this.cardinality_ = (Field.Types.Cardinality)input.ReadEnum();
						arg_344_0 = 915466677u;
						continue;
					case 26u:
						arg_344_0 = ((num <= 34u) ? 854408875u : 1175565923u);
						continue;
					case 27u:
						this.options_.AddEntriesFrom(input, Field._repeated_options_codec);
						arg_344_0 = 298561703u;
						continue;
					case 28u:
						this.kind_ = (Field.Types.Kind)input.ReadEnum();
						arg_344_0 = 1462317875u;
						continue;
					case 29u:
						arg_344_0 = ((num != 64u) ? 1985609691u : 708811358u);
						continue;
					case 30u:
						input.SkipLastField();
						arg_344_0 = 298561703u;
						continue;
					case 31u:
						arg_344_0 = ((num <= 56u) ? 1641989530u : 650805136u);
						continue;
					case 32u:
						arg_344_0 = (num2 * 4238148767u ^ 2860152459u);
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
