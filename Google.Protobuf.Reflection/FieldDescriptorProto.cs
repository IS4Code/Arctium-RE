using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class FieldDescriptorProto : IMessage, IMessage<FieldDescriptorProto>, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>
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

			internal FieldDescriptorProto cctor>b__70_0()
			{
				return new FieldDescriptorProto();
			}
		}

		private static readonly MessageParser<FieldDescriptorProto> _parser = new MessageParser<FieldDescriptorProto>(new Func<FieldDescriptorProto>(FieldDescriptorProto.__c.__9.<.cctor>b__70_0));

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

		public const int JsonNameFieldNumber = 10;

		private string jsonName_ = "";

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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
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
				this.typeName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
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
				this.extendee_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
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
				this.defaultValue_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
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

		public string JsonName
		{
			get
			{
				return this.jsonName_;
			}
			set
			{
				this.jsonName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
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
			while (true)
			{
				IL_7D:
				uint arg_65_0 = 2148063955u;
				while (true)
				{
					uint num;
					switch ((num = (arg_65_0 ^ 2784742453u)) % 3u)
					{
					case 0u:
						goto IL_7D;
					case 1u:
						this.OnConstruction();
						arg_65_0 = (num * 1763556460u ^ 3064805440u);
						continue;
					}
					return;
				}
			}
		}

		private void OnConstruction()
		{
			this.OneofIndex = -1;
		}

		public FieldDescriptorProto(FieldDescriptorProto other) : this()
		{
			this.name_ = other.name_;
			this.number_ = other.number_;
			this.label_ = other.label_;
			this.type_ = other.type_;
			this.typeName_ = other.typeName_;
			this.extendee_ = other.extendee_;
			this.defaultValue_ = other.defaultValue_;
			this.oneofIndex_ = other.oneofIndex_;
			this.jsonName_ = other.jsonName_;
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
				goto IL_9E;
			}
			goto IL_25C;
			int arg_1DE_0;
			while (true)
			{
				IL_1D9:
				switch ((arg_1DE_0 ^ -1535746256) % 25)
				{
				case 0:
					return false;
				case 1:
					arg_1DE_0 = ((this.Label != other.Label) ? -1784902040 : -138567075);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_1DE_0 = ((this.OneofIndex == other.OneofIndex) ? -1106147361 : -1946960307);
					continue;
				case 5:
					arg_1DE_0 = ((!FieldDescriptorProto.smethod_1(this.Options, other.Options)) ? -1713296620 : -603866968);
					continue;
				case 6:
					arg_1DE_0 = ((!FieldDescriptorProto.smethod_0(this.Extendee, other.Extendee)) ? -34183041 : -1434263572);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_1DE_0 = (FieldDescriptorProto.smethod_0(this.JsonName, other.JsonName) ? -388303921 : -1863779604);
					continue;
				case 10:
					arg_1DE_0 = ((!FieldDescriptorProto.smethod_0(this.Name, other.Name)) ? -84473239 : -1681219839);
					continue;
				case 11:
					arg_1DE_0 = (FieldDescriptorProto.smethod_0(this.TypeName, other.TypeName) ? -297335134 : -262434306);
					continue;
				case 12:
					goto IL_9E;
				case 13:
					arg_1DE_0 = ((this.Type == other.Type) ? -243887192 : -178624946);
					continue;
				case 14:
					goto IL_25C;
				case 15:
					return false;
				case 16:
					arg_1DE_0 = ((!FieldDescriptorProto.smethod_0(this.DefaultValue, other.DefaultValue)) ? -161884585 : -759004045);
					continue;
				case 18:
					return true;
				case 19:
					return false;
				case 20:
					return false;
				case 21:
					return false;
				case 22:
					arg_1DE_0 = ((this.Number == other.Number) ? -387782294 : -1702669360);
					continue;
				case 23:
					return false;
				case 24:
					return false;
				}
				break;
			}
			return true;
			IL_9E:
			arg_1DE_0 = -2061810536;
			goto IL_1D9;
			IL_25C:
			arg_1DE_0 = ((other == this) ? -847235380 : -2101735055);
			goto IL_1D9;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (FieldDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_1FE;
			}
			goto IL_331;
			uint arg_2C0_0;
			while (true)
			{
				IL_2BB:
				uint num2;
				switch ((num2 = (arg_2C0_0 ^ 4039995951u)) % 21u)
				{
				case 0u:
					num ^= this.Type.GetHashCode();
					arg_2C0_0 = (num2 * 2544801981u ^ 2747017242u);
					continue;
				case 1u:
					arg_2C0_0 = ((this.Extendee.Length == 0) ? 3432194599u : 3604502266u);
					continue;
				case 2u:
					arg_2C0_0 = ((this.DefaultValue.Length != 0) ? 2549318557u : 2911423173u);
					continue;
				case 3u:
					num ^= this.Options.GetHashCode();
					arg_2C0_0 = (num2 * 1465855176u ^ 1934216863u);
					continue;
				case 4u:
					arg_2C0_0 = ((this.OneofIndex != 0) ? 3051164232u : 2745102667u);
					continue;
				case 5u:
					goto IL_1FE;
				case 6u:
					num ^= this.Label.GetHashCode();
					arg_2C0_0 = (num2 * 1358107791u ^ 2183879306u);
					continue;
				case 8u:
					num ^= FieldDescriptorProto.smethod_3(this.Name);
					arg_2C0_0 = (num2 * 1985113078u ^ 226745858u);
					continue;
				case 9u:
					arg_2C0_0 = ((this.Label == FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 3940442121u : 4086468322u);
					continue;
				case 10u:
					num ^= this.JsonName.GetHashCode();
					arg_2C0_0 = (num2 * 1842066173u ^ 1938999457u);
					continue;
				case 11u:
					num ^= this.DefaultValue.GetHashCode();
					arg_2C0_0 = (num2 * 2816572269u ^ 316122127u);
					continue;
				case 12u:
					num ^= this.Number.GetHashCode();
					arg_2C0_0 = (num2 * 2733012613u ^ 2402309914u);
					continue;
				case 13u:
					num ^= this.TypeName.GetHashCode();
					arg_2C0_0 = (num2 * 650515170u ^ 2133990605u);
					continue;
				case 14u:
					num ^= this.OneofIndex.GetHashCode();
					arg_2C0_0 = (num2 * 1797946656u ^ 3701122731u);
					continue;
				case 15u:
					arg_2C0_0 = ((this.options_ != null) ? 2790140014u : 3423166551u);
					continue;
				case 16u:
					goto IL_331;
				case 17u:
					num ^= this.Extendee.GetHashCode();
					arg_2C0_0 = (num2 * 3156112082u ^ 2821075613u);
					continue;
				case 18u:
					arg_2C0_0 = ((this.TypeName.Length != 0) ? 2250387178u : 2902565671u);
					continue;
				case 19u:
					arg_2C0_0 = ((this.JsonName.Length != 0) ? 3947188092u : 2609617318u);
					continue;
				case 20u:
					arg_2C0_0 = ((this.Type == FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 3904446384u : 2563804125u);
					continue;
				}
				break;
			}
			return num;
			IL_1FE:
			arg_2C0_0 = 3542299782u;
			goto IL_2BB;
			IL_331:
			arg_2C0_0 = ((this.Number != 0) ? 3051112902u : 2547503383u);
			goto IL_2BB;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (FieldDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_241;
			}
			goto IL_3DA;
			uint arg_34E_0;
			while (true)
			{
				IL_349:
				uint num;
				switch ((num = (arg_34E_0 ^ 3711728245u)) % 28u)
				{
				case 0u:
					arg_34E_0 = ((this.Type != FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 3344220916u : 4062717749u);
					continue;
				case 1u:
					output.WriteString(this.TypeName);
					arg_34E_0 = (num * 1461530474u ^ 906673557u);
					continue;
				case 2u:
					output.WriteRawTag(24);
					arg_34E_0 = (num * 694434564u ^ 2698549046u);
					continue;
				case 3u:
					output.WriteRawTag(50);
					arg_34E_0 = (num * 2991707005u ^ 2313681143u);
					continue;
				case 4u:
					arg_34E_0 = ((this.options_ == null) ? 3512634484u : 2630882754u);
					continue;
				case 5u:
					output.WriteMessage(this.Options);
					arg_34E_0 = (num * 4004818973u ^ 2318404801u);
					continue;
				case 6u:
					goto IL_3DA;
				case 8u:
					output.WriteEnum((int)this.Type);
					arg_34E_0 = (num * 1005724324u ^ 1623169829u);
					continue;
				case 9u:
					output.WriteString(this.DefaultValue);
					arg_34E_0 = (num * 485746091u ^ 885934154u);
					continue;
				case 10u:
					output.WriteRawTag(32);
					arg_34E_0 = (num * 1043290128u ^ 1593029053u);
					continue;
				case 11u:
					goto IL_241;
				case 12u:
					arg_34E_0 = ((FieldDescriptorProto.smethod_2(this.TypeName) != 0) ? 2740920242u : 3433399151u);
					continue;
				case 13u:
					arg_34E_0 = ((this.Number != 0) ? 2720936323u : 3931059337u);
					continue;
				case 14u:
					output.WriteRawTag(82);
					output.WriteString(this.JsonName);
					arg_34E_0 = (num * 3191804709u ^ 3119111760u);
					continue;
				case 15u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_34E_0 = (num * 2103086976u ^ 2778336319u);
					continue;
				case 16u:
					arg_34E_0 = ((this.Label != FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 2875264551u : 2943626949u);
					continue;
				case 17u:
					arg_34E_0 = ((this.OneofIndex != 0) ? 4244740015u : 3232959594u);
					continue;
				case 18u:
					output.WriteRawTag(72);
					arg_34E_0 = (num * 1643148706u ^ 4063896945u);
					continue;
				case 19u:
					output.WriteInt32(this.Number);
					arg_34E_0 = (num * 1887599270u ^ 2263563787u);
					continue;
				case 20u:
					output.WriteEnum((int)this.Label);
					arg_34E_0 = (num * 1335185622u ^ 2393914165u);
					continue;
				case 21u:
					output.WriteRawTag(40);
					arg_34E_0 = (num * 1872078328u ^ 2298339049u);
					continue;
				case 22u:
					arg_34E_0 = ((FieldDescriptorProto.smethod_2(this.DefaultValue) != 0) ? 3046860884u : 2712391441u);
					continue;
				case 23u:
					output.WriteRawTag(66);
					arg_34E_0 = (num * 328699326u ^ 997790174u);
					continue;
				case 24u:
					output.WriteInt32(this.OneofIndex);
					arg_34E_0 = (num * 2297612326u ^ 2421994442u);
					continue;
				case 25u:
					output.WriteRawTag(58);
					arg_34E_0 = (num * 3171749231u ^ 3848349227u);
					continue;
				case 26u:
					output.WriteRawTag(18);
					output.WriteString(this.Extendee);
					arg_34E_0 = (num * 3606759021u ^ 2701088358u);
					continue;
				case 27u:
					arg_34E_0 = ((FieldDescriptorProto.smethod_2(this.JsonName) == 0) ? 4113223018u : 2404082759u);
					continue;
				}
				break;
			}
			return;
			IL_241:
			arg_34E_0 = 2165106486u;
			goto IL_349;
			IL_3DA:
			arg_34E_0 = ((FieldDescriptorProto.smethod_2(this.Extendee) == 0) ? 3577605116u : 4019585463u);
			goto IL_349;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_342:
				uint arg_2DD_0 = 3774015416u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2DD_0 ^ 4177676322u)) % 22u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Label);
						arg_2DD_0 = (num2 * 421678569u ^ 3600733590u);
						continue;
					case 1u:
						arg_2DD_0 = ((FieldDescriptorProto.smethod_2(this.TypeName) == 0) ? 4016154119u : 4268867403u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_2DD_0 = (num2 * 1689553535u ^ 182657865u);
						continue;
					case 3u:
						arg_2DD_0 = ((FieldDescriptorProto.smethod_2(this.Extendee) == 0) ? 2773250833u : 3222653858u);
						continue;
					case 4u:
						arg_2DD_0 = ((this.OneofIndex != 0) ? 2295039641u : 2418608551u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.JsonName);
						arg_2DD_0 = (num2 * 321066919u ^ 859899349u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.DefaultValue);
						arg_2DD_0 = (num2 * 1379927852u ^ 3122797396u);
						continue;
					case 8u:
						arg_2DD_0 = ((this.options_ == null) ? 2974286979u : 3257237030u);
						continue;
					case 9u:
						arg_2DD_0 = ((this.Number != 0) ? 2737414653u : 3152485347u);
						continue;
					case 10u:
						arg_2DD_0 = ((this.Type != FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 2377971186u : 3127795869u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.OneofIndex);
						arg_2DD_0 = (num2 * 707808933u ^ 3577098528u);
						continue;
					case 12u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Extendee);
						arg_2DD_0 = (num2 * 781975083u ^ 748709265u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.TypeName);
						arg_2DD_0 = (num2 * 33973161u ^ 2379237718u);
						continue;
					case 14u:
						goto IL_342;
					case 15u:
						arg_2DD_0 = ((FieldDescriptorProto.smethod_2(this.DefaultValue) == 0) ? 3423984772u : 2200440702u);
						continue;
					case 16u:
						arg_2DD_0 = (((FieldDescriptorProto.smethod_2(this.Name) != 0) ? 710245838u : 1920903005u) ^ num2 * 487132812u);
						continue;
					case 17u:
						arg_2DD_0 = ((this.Label != FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 2984542270u : 3312081130u);
						continue;
					case 18u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
						arg_2DD_0 = (num2 * 743107124u ^ 338743005u);
						continue;
					case 19u:
						arg_2DD_0 = ((FieldDescriptorProto.smethod_2(this.JsonName) != 0) ? 3001691527u : 3104449654u);
						continue;
					case 20u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_2DD_0 = (num2 * 2812836282u ^ 552412779u);
						continue;
					case 21u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Number);
						arg_2DD_0 = (num2 * 1348246531u ^ 919386750u);
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
				goto IL_2D8;
			}
			goto IL_362;
			uint arg_2E2_0;
			while (true)
			{
				IL_2DD:
				uint num;
				switch ((num = (arg_2E2_0 ^ 2374484747u)) % 25u)
				{
				case 0u:
					goto IL_2D8;
				case 1u:
					this.TypeName = other.TypeName;
					arg_2E2_0 = (num * 3566535236u ^ 129450778u);
					continue;
				case 2u:
					this.OneofIndex = other.OneofIndex;
					arg_2E2_0 = (num * 743044092u ^ 3093827994u);
					continue;
				case 3u:
					this.Type = other.Type;
					arg_2E2_0 = (num * 3195505839u ^ 3690373218u);
					continue;
				case 4u:
					arg_2E2_0 = ((FieldDescriptorProto.smethod_2(other.TypeName) == 0) ? 2365591174u : 3010466684u);
					continue;
				case 5u:
					this.JsonName = other.JsonName;
					arg_2E2_0 = (num * 4221385245u ^ 934156903u);
					continue;
				case 6u:
					arg_2E2_0 = ((FieldDescriptorProto.smethod_2(other.Extendee) != 0) ? 3836257807u : 3944558005u);
					continue;
				case 7u:
					this.Extendee = other.Extendee;
					arg_2E2_0 = (num * 2788269702u ^ 3623253421u);
					continue;
				case 8u:
					this.Number = other.Number;
					arg_2E2_0 = (num * 3674845492u ^ 2512164195u);
					continue;
				case 9u:
					arg_2E2_0 = ((other.Number == 0) ? 2332967887u : 3237512924u);
					continue;
				case 10u:
					arg_2E2_0 = ((other.options_ != null) ? 2343913497u : 2736460334u);
					continue;
				case 11u:
					this.options_ = new FieldOptions();
					arg_2E2_0 = (num * 1367859665u ^ 741748540u);
					continue;
				case 12u:
					arg_2E2_0 = ((other.OneofIndex != 0) ? 3623734052u : 4146313950u);
					continue;
				case 13u:
					return;
				case 14u:
					arg_2E2_0 = ((other.Type == FieldDescriptorProto.Types.Type.TYPE_DOUBLE) ? 3120372135u : 3429598912u);
					continue;
				case 15u:
					this.Options.MergeFrom(other.Options);
					arg_2E2_0 = 2736460334u;
					continue;
				case 16u:
					goto IL_362;
				case 17u:
					arg_2E2_0 = ((other.Label == FieldDescriptorProto.Types.Label.LABEL_OPTIONAL) ? 3781157021u : 3910515226u);
					continue;
				case 19u:
					arg_2E2_0 = ((FieldDescriptorProto.smethod_2(other.DefaultValue) == 0) ? 3348437862u : 2682441713u);
					continue;
				case 20u:
					arg_2E2_0 = ((FieldDescriptorProto.smethod_2(other.JsonName) != 0) ? 4201569389u : 2646454505u);
					continue;
				case 21u:
					this.DefaultValue = other.DefaultValue;
					arg_2E2_0 = (num * 3461118370u ^ 2866379602u);
					continue;
				case 22u:
					this.Name = other.Name;
					arg_2E2_0 = (num * 4132100803u ^ 3637734008u);
					continue;
				case 23u:
					arg_2E2_0 = (((this.options_ != null) ? 1921338571u : 2140789068u) ^ num * 413541895u);
					continue;
				case 24u:
					this.Label = other.Label;
					arg_2E2_0 = (num * 312888910u ^ 433451443u);
					continue;
				}
				break;
			}
			return;
			IL_2D8:
			arg_2E2_0 = 3016864292u;
			goto IL_2DD;
			IL_362:
			arg_2E2_0 = ((FieldDescriptorProto.smethod_2(other.Name) == 0) ? 3181690346u : 2309701133u);
			goto IL_2DD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_489:
				uint num;
				uint arg_3D5_0 = ((num = input.ReadTag()) == 0u) ? 1251283102u : 2003035552u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3D5_0 ^ 951053310u)) % 38u)
					{
					case 0u:
						arg_3D5_0 = ((num > 58u) ? 879138517u : 1210347673u);
						continue;
					case 1u:
						arg_3D5_0 = (((num != 10u) ? 2859550899u : 3752943317u) ^ num2 * 2279187692u);
						continue;
					case 2u:
						goto IL_489;
					case 3u:
						this.Name = input.ReadString();
						arg_3D5_0 = 2127783950u;
						continue;
					case 5u:
						this.options_ = new FieldOptions();
						arg_3D5_0 = (num2 * 1134712440u ^ 2434000627u);
						continue;
					case 6u:
						arg_3D5_0 = (num2 * 3912352093u ^ 3602392744u);
						continue;
					case 7u:
						arg_3D5_0 = (num2 * 2494665525u ^ 4080170679u);
						continue;
					case 8u:
						arg_3D5_0 = (num2 * 3939914713u ^ 23585891u);
						continue;
					case 9u:
						this.DefaultValue = input.ReadString();
						arg_3D5_0 = 125097945u;
						continue;
					case 10u:
						arg_3D5_0 = (num2 * 1420733787u ^ 803493491u);
						continue;
					case 11u:
						arg_3D5_0 = (((num != 58u) ? 919865892u : 113304953u) ^ num2 * 4051331292u);
						continue;
					case 12u:
						arg_3D5_0 = (((num == 82u) ? 2958136616u : 2212381861u) ^ num2 * 4078678413u);
						continue;
					case 13u:
						arg_3D5_0 = (((num == 50u) ? 2101612530u : 1650020530u) ^ num2 * 775000013u);
						continue;
					case 14u:
						this.JsonName = input.ReadString();
						arg_3D5_0 = 2127783950u;
						continue;
					case 15u:
						arg_3D5_0 = ((num != 66u) ? 1901701756u : 2123882824u);
						continue;
					case 16u:
						arg_3D5_0 = ((this.options_ == null) ? 1545148413u : 1615250843u);
						continue;
					case 17u:
						this.TypeName = input.ReadString();
						arg_3D5_0 = 1733151520u;
						continue;
					case 18u:
						arg_3D5_0 = (((num != 32u) ? 116667108u : 1034923518u) ^ num2 * 3212814227u);
						continue;
					case 19u:
						input.SkipLastField();
						arg_3D5_0 = 2127783950u;
						continue;
					case 20u:
						this.Number = input.ReadInt32();
						arg_3D5_0 = 2127783950u;
						continue;
					case 21u:
						arg_3D5_0 = (((num <= 18u) ? 1094608370u : 486755418u) ^ num2 * 3207938603u);
						continue;
					case 22u:
						arg_3D5_0 = (num2 * 1192474902u ^ 3066219390u);
						continue;
					case 23u:
						arg_3D5_0 = (num2 * 726716163u ^ 3437278354u);
						continue;
					case 24u:
						arg_3D5_0 = (((num != 72u) ? 3544705902u : 2816018012u) ^ num2 * 822796972u);
						continue;
					case 25u:
						arg_3D5_0 = (num2 * 3760504627u ^ 2665053387u);
						continue;
					case 26u:
						arg_3D5_0 = ((num <= 40u) ? 493953681u : 1288148930u);
						continue;
					case 27u:
						arg_3D5_0 = (num2 * 2025430693u ^ 3442948783u);
						continue;
					case 28u:
						arg_3D5_0 = 2003035552u;
						continue;
					case 29u:
						arg_3D5_0 = (((num != 18u) ? 4121145511u : 3174419143u) ^ num2 * 1230479852u);
						continue;
					case 30u:
						this.OneofIndex = input.ReadInt32();
						arg_3D5_0 = 1129239731u;
						continue;
					case 31u:
						this.type_ = (FieldDescriptorProto.Types.Type)input.ReadEnum();
						arg_3D5_0 = 1594556939u;
						continue;
					case 32u:
						arg_3D5_0 = (num2 * 1693697911u ^ 3760691052u);
						continue;
					case 33u:
						arg_3D5_0 = ((num == 24u) ? 1773035486u : 1057405000u);
						continue;
					case 34u:
						this.label_ = (FieldDescriptorProto.Types.Label)input.ReadEnum();
						arg_3D5_0 = 1350824912u;
						continue;
					case 35u:
						input.ReadMessage(this.options_);
						arg_3D5_0 = 2127783950u;
						continue;
					case 36u:
						arg_3D5_0 = (((num != 40u) ? 3508778908u : 2678337317u) ^ num2 * 3260241597u);
						continue;
					case 37u:
						this.Extendee = input.ReadString();
						arg_3D5_0 = 1242922966u;
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
