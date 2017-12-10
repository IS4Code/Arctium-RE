using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum Type
			{
				TYPE_DOUBLE = 1,
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

			internal enum Label
			{
				LABEL_OPTIONAL = 1,
				LABEL_REQUIRED,
				LABEL_REPEATED
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldDescriptorProto.__c __9 = new FieldDescriptorProto.__c();

			internal FieldDescriptorProto cctor>b__65_0()
			{
				return new FieldDescriptorProto();
			}
		}

		private static readonly MessageParser<FieldDescriptorProto> _parser = new MessageParser<FieldDescriptorProto>(new Func<FieldDescriptorProto>(FieldDescriptorProto.__c.__9.<.cctor>b__65_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int NumberFieldNumber = 3;

		private int number_;

		public const int LabelFieldNumber = 4;

		private FieldDescriptorProto.Types.Label label_ = FieldDescriptorProto.Types.Label.LABEL_OPTIONAL;

		public const int TypeFieldNumber = 5;

		private FieldDescriptorProto.Types.Type type_ = FieldDescriptorProto.Types.Type.TYPE_DOUBLE;

		public const int TypeNameFieldNumber = 6;

		private string typeName_ = "";

		public const int ExtendeeFieldNumber = 2;

		private string extendee_ = "";

		public const int DefaultValueFieldNumber = 7;

		private string defaultValue_ = "";

		public const int OneofIndexFieldNumber = 9;

		private int oneofIndex_;

		public const int OptionsFieldNumber = 8;

		private FieldOptions options_;

		public static MessageParser<FieldDescriptorProto> Parser
		{
			get
			{
				return FieldDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldDescriptorProto.Descriptor;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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

		public FieldDescriptorProto.Types.Label Label
		{
			get
			{
				return this.label_;
			}
			set
			{
				this.label_ = value;
			}
		}

		public FieldDescriptorProto.Types.Type Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		public string TypeName
		{
			get
			{
				return this.typeName_;
			}
			set
			{
				this.typeName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public string Extendee
		{
			get
			{
				return this.extendee_;
			}
			set
			{
				this.extendee_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string DefaultValue
		{
			get
			{
				return this.defaultValue_;
			}
			set
			{
				this.defaultValue_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
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

		public FieldOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		public FieldDescriptorProto()
		{
		}

		public FieldDescriptorProto(FieldDescriptorProto other) : this()
		{
			while (true)
			{
				IL_CE:
				uint arg_AA_0 = 3495722090u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AA_0 ^ 4136359401u)) % 6u)
					{
					case 0u:
						this.defaultValue_ = other.defaultValue_;
						arg_AA_0 = (num * 727439590u ^ 547493252u);
						continue;
					case 1u:
						this.name_ = other.name_;
						this.number_ = other.number_;
						this.label_ = other.label_;
						this.type_ = other.type_;
						this.typeName_ = other.typeName_;
						arg_AA_0 = (num * 2526669789u ^ 2011841231u);
						continue;
					case 3u:
						this.oneofIndex_ = other.oneofIndex_;
						arg_AA_0 = (num * 701689815u ^ 3736150998u);
						continue;
					case 4u:
						goto IL_CE;
					case 5u:
						this.extendee_ = other.extendee_;
						arg_AA_0 = (num * 2800583940u ^ 2862547733u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		public FieldDescriptorProto Clone()
		{
			return new FieldDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FieldDescriptorProto);
		}

		public bool Equals(FieldDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_F7;
			}
			goto IL_225;
			int arg_1AF_0;
			while (true)
			{
				IL_1AA:
				switch ((arg_1AF_0 ^ -1622397744) % 23)
				{
				case 0:
					arg_1AF_0 = (FieldDescriptorProto.smethod_0(this.TypeName, other.TypeName) ? -1588278525 : -1669847641);
					continue;
				case 1:
					return false;
				case 2:
					arg_1AF_0 = ((!FieldDescriptorProto.smethod_1(this.Options, other.Options)) ? -2130499834 : -1879899377);
					continue;
				case 3:
					arg_1AF_0 = ((this.Number == other.Number) ? -83737870 : -826171158);
					continue;
				case 4:
					return false;
				case 5:
					arg_1AF_0 = (FieldDescriptorProto.smethod_0(this.Extendee, other.Extendee) ? -701486193 : -1332776066);
					continue;
				case 6:
					return false;
				case 7:
					goto IL_225;
				case 9:
					goto IL_F7;
				case 10:
					arg_1AF_0 = (FieldDescriptorProto.smethod_0(this.DefaultValue, other.DefaultValue) ? -182826777 : -2064151855);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_1AF_0 = ((this.OneofIndex == other.OneofIndex) ? -633631952 : -1573973499);
					continue;
				case 14:
					return true;
				case 15:
					return false;
				case 16:
					return false;
				case 17:
					arg_1AF_0 = ((this.Label != other.Label) ? -1475958035 : -1977579195);
					continue;
				case 18:
					arg_1AF_0 = ((!FieldDescriptorProto.smethod_0(this.Name, other.Name)) ? -1377582192 : -718931617);
					continue;
				case 19:
					return false;
				case 20:
					return false;
				case 21:
					arg_1AF_0 = ((this.Type != other.Type) ? -721293243 : -745577575);
					continue;
				case 22:
					return false;
				}
				break;
			}
			return true;
			IL_F7:
			arg_1AF_0 = -1259080098;
			goto IL_1AA;
			IL_225:
			arg_1AF_0 = ((other != this) ? -1049348044 : -478465409);
			goto IL_1AA;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_300:
				uint arg_2A2_0 = 1042007764u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2A2_0 ^ 1687145303u)) % 20u)
					{
					case 0u:
						num ^= this.Extendee.GetHashCode();
						arg_2A2_0 = (num2 * 559711469u ^ 1237746307u);
						continue;
					case 1u:
						arg_2A2_0 = ((this.OneofIndex == 0) ? 470482876u : 678777066u);
						continue;
					case 2u:
						arg_2A2_0 = ((this.Extendee.Length == 0) ? 1541302743u : 77474163u);
						continue;
					case 4u:
						arg_2A2_0 = ((this.DefaultValue.Length == 0) ? 1049242278u : 1869468517u);
						continue;
					case 5u:
						num ^= this.OneofIndex.GetHashCode();
						arg_2A2_0 = (num2 * 1743822204u ^ 454862640u);
						continue;
					case 6u:
						num ^= this.DefaultValue.GetHashCode();
						arg_2A2_0 = (num2 * 2935737612u ^ 1853163262u);
						continue;
					case 7u:
						arg_2A2_0 = (((FieldDescriptorProto.smethod_2(this.Name) == 0) ? 3141306381u : 3607710378u) ^ num2 * 3323050049u);
						continue;
					case 8u:
						arg_2A2_0 = ((this.Type == FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 139389796u : 762177033u);
						continue;
					case 9u:
						num ^= this.Number.GetHashCode();
						arg_2A2_0 = (num2 * 1223856361u ^ 3505663484u);
						continue;
					case 10u:
						num ^= FieldDescriptorProto.smethod_3(this.Name);
						arg_2A2_0 = (num2 * 4046342376u ^ 3094014590u);
						continue;
					case 11u:
						num ^= this.TypeName.GetHashCode();
						arg_2A2_0 = (num2 * 1485197506u ^ 4034822367u);
						continue;
					case 12u:
						goto IL_300;
					case 13u:
						arg_2A2_0 = ((this.Number == 0) ? 516548853u : 41301110u);
						continue;
					case 14u:
						arg_2A2_0 = ((this.Label != FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 975109019u : 1815656407u);
						continue;
					case 15u:
						arg_2A2_0 = ((this.options_ == null) ? 1649426560u : 1729853586u);
						continue;
					case 16u:
						num ^= this.Label.GetHashCode();
						arg_2A2_0 = (num2 * 3256192452u ^ 2617053159u);
						continue;
					case 17u:
						num ^= this.Options.GetHashCode();
						arg_2A2_0 = (num2 * 2526896112u ^ 1438638896u);
						continue;
					case 18u:
						num ^= this.Type.GetHashCode();
						arg_2A2_0 = (num2 * 4272640808u ^ 2040036308u);
						continue;
					case 19u:
						arg_2A2_0 = ((this.TypeName.Length != 0) ? 893089060u : 1859175417u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (FieldDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_2CE;
			}
			goto IL_354;
			uint arg_2D8_0;
			while (true)
			{
				IL_2D3:
				uint num;
				switch ((num = (arg_2D8_0 ^ 2654911979u)) % 24u)
				{
				case 0u:
					goto IL_2CE;
				case 2u:
					output.WriteString(this.Name);
					arg_2D8_0 = (num * 1090973606u ^ 2578323898u);
					continue;
				case 3u:
					output.WriteRawTag(10);
					arg_2D8_0 = (num * 356762882u ^ 840372207u);
					continue;
				case 4u:
					arg_2D8_0 = ((FieldDescriptorProto.smethod_2(this.DefaultValue) != 0) ? 2264023597u : 3538513726u);
					continue;
				case 5u:
					goto IL_354;
				case 6u:
					output.WriteRawTag(58);
					arg_2D8_0 = (num * 3772257912u ^ 4116347004u);
					continue;
				case 7u:
					output.WriteRawTag(18);
					output.WriteString(this.Extendee);
					arg_2D8_0 = (num * 1641625848u ^ 3081768349u);
					continue;
				case 8u:
					arg_2D8_0 = ((this.OneofIndex != 0) ? 2534251784u : 2351138802u);
					continue;
				case 9u:
					output.WriteRawTag(40);
					output.WriteEnum((int)this.Type);
					arg_2D8_0 = (num * 388707033u ^ 4024155842u);
					continue;
				case 10u:
					arg_2D8_0 = ((this.Label == FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 2561270455u : 3653259040u);
					continue;
				case 11u:
					output.WriteRawTag(32);
					arg_2D8_0 = (num * 1568356473u ^ 2468499510u);
					continue;
				case 12u:
					output.WriteRawTag(24);
					output.WriteInt32(this.Number);
					arg_2D8_0 = (num * 3002378881u ^ 3452892133u);
					continue;
				case 13u:
					output.WriteMessage(this.Options);
					arg_2D8_0 = (num * 4089909008u ^ 1626944707u);
					continue;
				case 14u:
					output.WriteEnum((int)this.Label);
					arg_2D8_0 = (num * 544542563u ^ 1939303805u);
					continue;
				case 15u:
					output.WriteString(this.TypeName);
					arg_2D8_0 = (num * 2320695448u ^ 6533167u);
					continue;
				case 16u:
					arg_2D8_0 = ((FieldDescriptorProto.smethod_2(this.TypeName) != 0) ? 3888320041u : 2977943943u);
					continue;
				case 17u:
					output.WriteRawTag(66);
					arg_2D8_0 = (num * 2656055471u ^ 2964384009u);
					continue;
				case 18u:
					output.WriteRawTag(50);
					arg_2D8_0 = (num * 4114172877u ^ 2002243110u);
					continue;
				case 19u:
					output.WriteRawTag(72);
					output.WriteInt32(this.OneofIndex);
					arg_2D8_0 = (num * 2007126477u ^ 1406971701u);
					continue;
				case 20u:
					arg_2D8_0 = ((this.Type != FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 4244843834u : 3494391275u);
					continue;
				case 21u:
					arg_2D8_0 = ((this.options_ == null) ? 2370754323u : 3121958954u);
					continue;
				case 22u:
					arg_2D8_0 = ((this.Number == 0) ? 3419538649u : 2279881943u);
					continue;
				case 23u:
					output.WriteString(this.DefaultValue);
					arg_2D8_0 = (num * 3805742371u ^ 2649947275u);
					continue;
				}
				break;
			}
			return;
			IL_2CE:
			arg_2D8_0 = 2761876080u;
			goto IL_2D3;
			IL_354:
			arg_2D8_0 = ((FieldDescriptorProto.smethod_2(this.Extendee) != 0) ? 2714903636u : 3607999637u);
			goto IL_2D3;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_2EF:
				uint arg_292_0 = 1717134165u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_292_0 ^ 1822414387u)) % 20u)
					{
					case 0u:
						arg_292_0 = ((this.Label == FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 1820834766u : 1788049198u);
						continue;
					case 1u:
						arg_292_0 = ((this.Type != FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 2108327095u : 2122989184u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.TypeName);
						arg_292_0 = (num2 * 3141468137u ^ 1770209572u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.DefaultValue);
						arg_292_0 = (num2 * 1198267931u ^ 3867602126u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
						arg_292_0 = (num2 * 4221754734u ^ 1848071736u);
						continue;
					case 5u:
						arg_292_0 = ((FieldDescriptorProto.smethod_2(this.Extendee) == 0) ? 2084365091u : 251443633u);
						continue;
					case 6u:
						arg_292_0 = (((FieldDescriptorProto.smethod_2(this.Name) != 0) ? 3004628138u : 2232602096u) ^ num2 * 1399021168u);
						continue;
					case 7u:
						arg_292_0 = ((this.Number != 0) ? 1204374333u : 1804471859u);
						continue;
					case 8u:
						arg_292_0 = ((FieldDescriptorProto.smethod_2(this.DefaultValue) == 0) ? 1625955191u : 769611912u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_292_0 = (num2 * 720127665u ^ 1127980173u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Number);
						arg_292_0 = (num2 * 3523838351u ^ 3079522017u);
						continue;
					case 11u:
						goto IL_2EF;
					case 12u:
						arg_292_0 = ((this.OneofIndex == 0) ? 1059096065u : 601380895u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Label);
						arg_292_0 = (num2 * 3873018697u ^ 4113900427u);
						continue;
					case 14u:
						arg_292_0 = ((this.options_ != null) ? 1437342934u : 274627288u);
						continue;
					case 15u:
						arg_292_0 = ((FieldDescriptorProto.smethod_2(this.TypeName) == 0) ? 1103163722u : 1666682893u);
						continue;
					case 16u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.OneofIndex);
						arg_292_0 = (num2 * 3045107280u ^ 1638691777u);
						continue;
					case 17u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_292_0 = (num2 * 2525613873u ^ 2223498937u);
						continue;
					case 18u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Extendee);
						arg_292_0 = (num2 * 2421323180u ^ 408270459u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FieldDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_291;
			}
			goto IL_313;
			uint arg_29B_0;
			while (true)
			{
				IL_296:
				uint num;
				switch ((num = (arg_29B_0 ^ 1692232318u)) % 23u)
				{
				case 0u:
					goto IL_291;
				case 1u:
					this.options_ = new FieldOptions();
					arg_29B_0 = (num * 1676539491u ^ 1248991392u);
					continue;
				case 2u:
					return;
				case 3u:
					this.Type = other.Type;
					arg_29B_0 = (num * 3489454326u ^ 1098551002u);
					continue;
				case 5u:
					goto IL_313;
				case 6u:
					this.Extendee = other.Extendee;
					arg_29B_0 = (num * 219868750u ^ 476057491u);
					continue;
				case 7u:
					arg_29B_0 = ((other.options_ == null) ? 2117490333u : 988271012u);
					continue;
				case 8u:
					this.Name = other.Name;
					arg_29B_0 = (num * 1099355687u ^ 2182322379u);
					continue;
				case 9u:
					arg_29B_0 = ((FieldDescriptorProto.smethod_2(other.Extendee) == 0) ? 1491146313u : 1855614389u);
					continue;
				case 10u:
					this.Label = other.Label;
					arg_29B_0 = (num * 1619309152u ^ 389660420u);
					continue;
				case 11u:
					arg_29B_0 = ((FieldDescriptorProto.smethod_2(other.DefaultValue) == 0) ? 1255108530u : 667136825u);
					continue;
				case 12u:
					this.TypeName = other.TypeName;
					arg_29B_0 = (num * 3873783883u ^ 1289609883u);
					continue;
				case 13u:
					arg_29B_0 = ((other.OneofIndex != 0) ? 1423884120u : 650533986u);
					continue;
				case 14u:
					arg_29B_0 = ((other.Number == 0) ? 29358953u : 736100088u);
					continue;
				case 15u:
					this.Number = other.Number;
					arg_29B_0 = (num * 2291314465u ^ 3606529071u);
					continue;
				case 16u:
					arg_29B_0 = ((FieldDescriptorProto.smethod_2(other.TypeName) != 0) ? 410816195u : 728998340u);
					continue;
				case 17u:
					arg_29B_0 = ((other.Type != FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 788693067u : 2089371700u);
					continue;
				case 18u:
					this.DefaultValue = other.DefaultValue;
					arg_29B_0 = (num * 2436322802u ^ 3695286188u);
					continue;
				case 19u:
					arg_29B_0 = ((other.Label != FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 2055096108u : 130399684u);
					continue;
				case 20u:
					this.Options.MergeFrom(other.Options);
					arg_29B_0 = 2117490333u;
					continue;
				case 21u:
					arg_29B_0 = (((this.options_ == null) ? 2796661310u : 3803316964u) ^ num * 1660307691u);
					continue;
				case 22u:
					this.OneofIndex = other.OneofIndex;
					arg_29B_0 = (num * 4208245659u ^ 1488620640u);
					continue;
				}
				break;
			}
			return;
			IL_291:
			arg_29B_0 = 204970326u;
			goto IL_296;
			IL_313:
			arg_29B_0 = ((FieldDescriptorProto.smethod_2(other.Name) == 0) ? 508496318u : 1468707709u);
			goto IL_296;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_45B:
				uint num;
				uint arg_3AB_0 = ((num = input.ReadTag()) != 0u) ? 3083637205u : 2297115887u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3AB_0 ^ 4265884089u)) % 37u)
					{
					case 0u:
						input.SkipLastField();
						arg_3AB_0 = 3793434704u;
						continue;
					case 1u:
						arg_3AB_0 = (((num <= 18u) ? 1059971053u : 1250557203u) ^ num2 * 475347613u);
						continue;
					case 2u:
						arg_3AB_0 = (((num == 66u) ? 948839437u : 552905335u) ^ num2 * 3550252832u);
						continue;
					case 3u:
						arg_3AB_0 = (num2 * 4197813960u ^ 3066215096u);
						continue;
					case 4u:
						arg_3AB_0 = ((num <= 32u) ? 3510918080u : 3927341126u);
						continue;
					case 5u:
						arg_3AB_0 = (((num == 50u) ? 607870256u : 137571647u) ^ num2 * 3725399803u);
						continue;
					case 6u:
						arg_3AB_0 = (((num == 10u) ? 1050810155u : 941131383u) ^ num2 * 1395531931u);
						continue;
					case 7u:
						arg_3AB_0 = 3083637205u;
						continue;
					case 8u:
						this.TypeName = input.ReadString();
						arg_3AB_0 = 4293611761u;
						continue;
					case 9u:
						arg_3AB_0 = (num2 * 3316312161u ^ 3606598133u);
						continue;
					case 10u:
						arg_3AB_0 = (num2 * 3549595609u ^ 3009285720u);
						continue;
					case 11u:
						this.label_ = (FieldDescriptorProto.Types.Label)input.ReadEnum();
						arg_3AB_0 = 3793434704u;
						continue;
					case 12u:
						this.Extendee = input.ReadString();
						arg_3AB_0 = 3980376678u;
						continue;
					case 13u:
						this.options_ = new FieldOptions();
						arg_3AB_0 = (num2 * 1115240657u ^ 902243122u);
						continue;
					case 14u:
						arg_3AB_0 = (num2 * 2347729671u ^ 382331701u);
						continue;
					case 15u:
						this.DefaultValue = input.ReadString();
						arg_3AB_0 = 3180455324u;
						continue;
					case 16u:
						arg_3AB_0 = (num2 * 1507523521u ^ 1020405369u);
						continue;
					case 17u:
						arg_3AB_0 = (num2 * 3123187652u ^ 708329452u);
						continue;
					case 18u:
						input.ReadMessage(this.options_);
						arg_3AB_0 = 3577480290u;
						continue;
					case 19u:
						arg_3AB_0 = (((num != 18u) ? 2169788284u : 4255585107u) ^ num2 * 3320180281u);
						continue;
					case 20u:
						arg_3AB_0 = (num2 * 1919660750u ^ 819729712u);
						continue;
					case 21u:
						this.Name = input.ReadString();
						arg_3AB_0 = 3982157264u;
						continue;
					case 22u:
						this.type_ = (FieldDescriptorProto.Types.Type)input.ReadEnum();
						arg_3AB_0 = 2156777084u;
						continue;
					case 23u:
						arg_3AB_0 = (num2 * 469916326u ^ 3828687061u);
						continue;
					case 24u:
						arg_3AB_0 = ((this.options_ != null) ? 4185848358u : 4233704813u);
						continue;
					case 25u:
						this.OneofIndex = input.ReadInt32();
						arg_3AB_0 = 3793434704u;
						continue;
					case 26u:
						arg_3AB_0 = ((num == 24u) ? 3976188531u : 2894799950u);
						continue;
					case 28u:
						this.Number = input.ReadInt32();
						arg_3AB_0 = 3901926505u;
						continue;
					case 29u:
						arg_3AB_0 = (num2 * 2127264126u ^ 4077440154u);
						continue;
					case 30u:
						arg_3AB_0 = (num2 * 3670086857u ^ 4141354147u);
						continue;
					case 31u:
						arg_3AB_0 = (((num == 32u) ? 3696776724u : 2434516015u) ^ num2 * 4039540325u);
						continue;
					case 32u:
						arg_3AB_0 = (((num != 40u) ? 751317535u : 1767536385u) ^ num2 * 3035032442u);
						continue;
					case 33u:
						goto IL_45B;
					case 34u:
						arg_3AB_0 = ((num != 58u) ? 4078304983u : 3781511861u);
						continue;
					case 35u:
						arg_3AB_0 = (((num == 72u) ? 4016869542u : 4003749555u) ^ num2 * 3452124052u);
						continue;
					case 36u:
						arg_3AB_0 = ((num > 50u) ? 2909842990u : 2898209816u);
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

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_3(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
