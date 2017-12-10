using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FileDescriptorProto.__c __9 = new FileDescriptorProto.__c();

			internal FileDescriptorProto cctor>b__74_0()
			{
				return new FileDescriptorProto();
			}
		}

		private static readonly MessageParser<FileDescriptorProto> _parser = new MessageParser<FileDescriptorProto>(new Func<FileDescriptorProto>(FileDescriptorProto.__c.__9.<.cctor>b__74_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int PackageFieldNumber = 2;

		private string package_ = "";

		public const int DependencyFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_dependency_codec;

		private readonly RepeatedField<string> dependency_ = new RepeatedField<string>();

		public const int PublicDependencyFieldNumber = 10;

		private static readonly FieldCodec<int> _repeated_publicDependency_codec;

		private readonly RepeatedField<int> publicDependency_ = new RepeatedField<int>();

		public const int WeakDependencyFieldNumber = 11;

		private static readonly FieldCodec<int> _repeated_weakDependency_codec;

		private readonly RepeatedField<int> weakDependency_ = new RepeatedField<int>();

		public const int MessageTypeFieldNumber = 4;

		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec;

		private readonly RepeatedField<DescriptorProto> messageType_ = new RepeatedField<DescriptorProto>();

		public const int EnumTypeFieldNumber = 5;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		private readonly RepeatedField<EnumDescriptorProto> enumType_ = new RepeatedField<EnumDescriptorProto>();

		public const int ServiceFieldNumber = 6;

		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec;

		private readonly RepeatedField<ServiceDescriptorProto> service_ = new RepeatedField<ServiceDescriptorProto>();

		public const int ExtensionFieldNumber = 7;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		private readonly RepeatedField<FieldDescriptorProto> extension_ = new RepeatedField<FieldDescriptorProto>();

		public const int OptionsFieldNumber = 8;

		private FileOptions options_;

		public const int SourceCodeInfoFieldNumber = 9;

		private SourceCodeInfo sourceCodeInfo_;

		public static MessageParser<FileDescriptorProto> Parser
		{
			get
			{
				return FileDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FileDescriptorProto.Descriptor;
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

		public string Package
		{
			get
			{
				return this.package_;
			}
			set
			{
				this.package_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public RepeatedField<string> Dependency
		{
			get
			{
				return this.dependency_;
			}
		}

		public RepeatedField<int> PublicDependency
		{
			get
			{
				return this.publicDependency_;
			}
		}

		public RepeatedField<int> WeakDependency
		{
			get
			{
				return this.weakDependency_;
			}
		}

		public RepeatedField<DescriptorProto> MessageType
		{
			get
			{
				return this.messageType_;
			}
		}

		public RepeatedField<EnumDescriptorProto> EnumType
		{
			get
			{
				return this.enumType_;
			}
		}

		public RepeatedField<ServiceDescriptorProto> Service
		{
			get
			{
				return this.service_;
			}
		}

		public RepeatedField<FieldDescriptorProto> Extension
		{
			get
			{
				return this.extension_;
			}
		}

		public FileOptions Options
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

		public SourceCodeInfo SourceCodeInfo
		{
			get
			{
				return this.sourceCodeInfo_;
			}
			set
			{
				this.sourceCodeInfo_ = value;
			}
		}

		public FileDescriptorProto()
		{
		}

		public FileDescriptorProto(FileDescriptorProto other) : this()
		{
			while (true)
			{
				IL_12A:
				uint arg_102_0 = 1159649500u;
				while (true)
				{
					uint num;
					switch ((num = (arg_102_0 ^ 861622790u)) % 7u)
					{
					case 1u:
						this.dependency_ = other.dependency_.Clone();
						this.publicDependency_ = other.publicDependency_.Clone();
						this.weakDependency_ = other.weakDependency_.Clone();
						arg_102_0 = (num * 3679537218u ^ 239356936u);
						continue;
					case 2u:
						this.service_ = other.service_.Clone();
						this.extension_ = other.extension_.Clone();
						arg_102_0 = (num * 1943923596u ^ 2687447603u);
						continue;
					case 3u:
						goto IL_12A;
					case 4u:
						this.name_ = other.name_;
						this.package_ = other.package_;
						arg_102_0 = (num * 3796356432u ^ 3389554338u);
						continue;
					case 5u:
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_102_0 = 337033237u;
						continue;
					case 6u:
						this.messageType_ = other.messageType_.Clone();
						this.enumType_ = other.enumType_.Clone();
						arg_102_0 = (num * 4174476796u ^ 3847723413u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.SourceCodeInfo = ((other.sourceCodeInfo_ != null) ? other.SourceCodeInfo.Clone() : null);
		}

		public FileDescriptorProto Clone()
		{
			return new FileDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FileDescriptorProto);
		}

		public bool Equals(FileDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_1BF;
			}
			goto IL_2A7;
			int arg_221_0;
			while (true)
			{
				IL_21C:
				switch ((arg_221_0 ^ 587137197) % 27)
				{
				case 0:
					goto IL_2A7;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_221_0 = (FileDescriptorProto.smethod_0(this.Package, other.Package) ? 2130303461 : 530621622);
					continue;
				case 5:
					arg_221_0 = (this.dependency_.Equals(other.dependency_) ? 1777619640 : 108117857);
					continue;
				case 6:
					goto IL_1BF;
				case 7:
					arg_221_0 = ((!this.service_.Equals(other.service_)) ? 1203896993 : 117124938);
					continue;
				case 8:
					arg_221_0 = ((!FileDescriptorProto.smethod_1(this.SourceCodeInfo, other.SourceCodeInfo)) ? 202826021 : 107487525);
					continue;
				case 9:
					return false;
				case 10:
					arg_221_0 = (this.messageType_.Equals(other.messageType_) ? 1439197775 : 711155173);
					continue;
				case 12:
					return false;
				case 13:
					arg_221_0 = ((!FileDescriptorProto.smethod_0(this.Name, other.Name)) ? 1191823997 : 1834821549);
					continue;
				case 14:
					return true;
				case 15:
					arg_221_0 = (this.extension_.Equals(other.extension_) ? 1687769176 : 1170445460);
					continue;
				case 16:
					return false;
				case 17:
					return false;
				case 18:
					return false;
				case 19:
					return false;
				case 20:
					arg_221_0 = ((!this.enumType_.Equals(other.enumType_)) ? 1051128832 : 756901707);
					continue;
				case 21:
					return false;
				case 22:
					return false;
				case 23:
					return false;
				case 24:
					arg_221_0 = (this.publicDependency_.Equals(other.publicDependency_) ? 2115353941 : 1026157369);
					continue;
				case 25:
					arg_221_0 = (this.weakDependency_.Equals(other.weakDependency_) ? 495712014 : 1997472659);
					continue;
				case 26:
					arg_221_0 = ((!FileDescriptorProto.smethod_1(this.Options, other.Options)) ? 1228220173 : 1233367884);
					continue;
				}
				break;
			}
			return true;
			IL_1BF:
			arg_221_0 = 2085234017;
			goto IL_21C;
			IL_2A7:
			arg_221_0 = ((other != this) ? 698064523 : 1728653465);
			goto IL_21C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_20C:
				uint arg_1C7_0 = 2530293563u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1C7_0 ^ 2237650805u)) % 14u)
					{
					case 0u:
						arg_1C7_0 = ((FileDescriptorProto.smethod_2(this.Package) != 0) ? 3327628879u : 3633790251u);
						continue;
					case 1u:
						num ^= FileDescriptorProto.smethod_3(this.Options);
						arg_1C7_0 = (num2 * 973864773u ^ 3788561491u);
						continue;
					case 2u:
						num ^= FileDescriptorProto.smethod_3(this.Package);
						arg_1C7_0 = (num2 * 3398495056u ^ 595827979u);
						continue;
					case 3u:
						num ^= FileDescriptorProto.smethod_3(this.messageType_);
						arg_1C7_0 = (num2 * 649671753u ^ 3891382125u);
						continue;
					case 4u:
						num ^= FileDescriptorProto.smethod_3(this.dependency_);
						arg_1C7_0 = 3425330200u;
						continue;
					case 5u:
						num ^= FileDescriptorProto.smethod_3(this.publicDependency_);
						num ^= FileDescriptorProto.smethod_3(this.weakDependency_);
						arg_1C7_0 = (num2 * 1758952827u ^ 92495843u);
						continue;
					case 6u:
						num ^= FileDescriptorProto.smethod_3(this.Name);
						arg_1C7_0 = (num2 * 2174069675u ^ 2451220345u);
						continue;
					case 7u:
						num ^= FileDescriptorProto.smethod_3(this.SourceCodeInfo);
						arg_1C7_0 = (num2 * 4070363204u ^ 80556398u);
						continue;
					case 8u:
						goto IL_20C;
					case 10u:
						arg_1C7_0 = (((FileDescriptorProto.smethod_2(this.Name) != 0) ? 2378788775u : 2814928643u) ^ num2 * 2714580801u);
						continue;
					case 11u:
						num ^= FileDescriptorProto.smethod_3(this.enumType_);
						num ^= FileDescriptorProto.smethod_3(this.service_);
						arg_1C7_0 = (num2 * 1610927152u ^ 2287970395u);
						continue;
					case 12u:
						num ^= FileDescriptorProto.smethod_3(this.extension_);
						arg_1C7_0 = (((this.options_ == null) ? 821033220u : 1666774366u) ^ num2 * 169519440u);
						continue;
					case 13u:
						arg_1C7_0 = ((this.sourceCodeInfo_ != null) ? 3626666466u : 2529616242u);
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
			if (FileDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_183;
			}
			goto IL_249;
			uint arg_1ED_0;
			while (true)
			{
				IL_1E8:
				uint num;
				switch ((num = (arg_1ED_0 ^ 2187894432u)) % 16u)
				{
				case 0u:
					goto IL_249;
				case 1u:
					output.WriteRawTag(18);
					arg_1ED_0 = (num * 1769270230u ^ 128386545u);
					continue;
				case 2u:
					this.dependency_.WriteTo(output, FileDescriptorProto._repeated_dependency_codec);
					arg_1ED_0 = 2543550051u;
					continue;
				case 3u:
					this.messageType_.WriteTo(output, FileDescriptorProto._repeated_messageType_codec);
					this.enumType_.WriteTo(output, FileDescriptorProto._repeated_enumType_codec);
					arg_1ED_0 = (num * 3324310854u ^ 1654701194u);
					continue;
				case 5u:
					goto IL_183;
				case 6u:
					output.WriteRawTag(66);
					arg_1ED_0 = (num * 3513006574u ^ 2481030285u);
					continue;
				case 7u:
					output.WriteString(this.Package);
					arg_1ED_0 = (num * 1572967512u ^ 2415323866u);
					continue;
				case 8u:
					this.service_.WriteTo(output, FileDescriptorProto._repeated_service_codec);
					this.extension_.WriteTo(output, FileDescriptorProto._repeated_extension_codec);
					arg_1ED_0 = (num * 605398820u ^ 1968448511u);
					continue;
				case 9u:
					output.WriteMessage(this.Options);
					arg_1ED_0 = (num * 3238075679u ^ 2785820684u);
					continue;
				case 10u:
					output.WriteMessage(this.SourceCodeInfo);
					arg_1ED_0 = (num * 766729216u ^ 4082854302u);
					continue;
				case 11u:
					arg_1ED_0 = ((this.sourceCodeInfo_ != null) ? 3415545613u : 3216617886u);
					continue;
				case 12u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_1ED_0 = (num * 1739272872u ^ 1534330816u);
					continue;
				case 13u:
					output.WriteRawTag(74);
					arg_1ED_0 = (num * 1458571590u ^ 2339886292u);
					continue;
				case 14u:
					this.publicDependency_.WriteTo(output, FileDescriptorProto._repeated_publicDependency_codec);
					this.weakDependency_.WriteTo(output, FileDescriptorProto._repeated_weakDependency_codec);
					arg_1ED_0 = 2668660532u;
					continue;
				case 15u:
					arg_1ED_0 = (((this.options_ == null) ? 209065358u : 1095862083u) ^ num * 894343003u);
					continue;
				}
				break;
			}
			return;
			IL_183:
			arg_1ED_0 = 2872958188u;
			goto IL_1E8;
			IL_249:
			arg_1ED_0 = ((FileDescriptorProto.smethod_2(this.Package) == 0) ? 3021169842u : 2166362593u);
			goto IL_1E8;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_266:
				uint arg_219_0 = 3757758151u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_219_0 ^ 2437134478u)) % 16u)
					{
					case 0u:
						num += this.weakDependency_.CalculateSize(FileDescriptorProto._repeated_weakDependency_codec);
						arg_219_0 = (num2 * 1737609828u ^ 761167382u);
						continue;
					case 1u:
						arg_219_0 = ((FileDescriptorProto.smethod_2(this.Package) != 0) ? 2471128969u : 3396719587u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_219_0 = (num2 * 805893682u ^ 4086295762u);
						continue;
					case 4u:
						goto IL_266;
					case 5u:
						num += this.extension_.CalculateSize(FileDescriptorProto._repeated_extension_codec);
						arg_219_0 = (num2 * 1756933642u ^ 1663463744u);
						continue;
					case 6u:
						num += this.enumType_.CalculateSize(FileDescriptorProto._repeated_enumType_codec);
						num += this.service_.CalculateSize(FileDescriptorProto._repeated_service_codec);
						arg_219_0 = (num2 * 3464633545u ^ 1186641149u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Package);
						arg_219_0 = (num2 * 869296033u ^ 2450644868u);
						continue;
					case 8u:
						num += this.messageType_.CalculateSize(FileDescriptorProto._repeated_messageType_codec);
						arg_219_0 = (num2 * 264751948u ^ 1242418552u);
						continue;
					case 9u:
						arg_219_0 = (((FileDescriptorProto.smethod_2(this.Name) == 0) ? 2748170766u : 2387357088u) ^ num2 * 84187497u);
						continue;
					case 10u:
						arg_219_0 = ((this.sourceCodeInfo_ == null) ? 3356183580u : 2265685264u);
						continue;
					case 11u:
						num += this.publicDependency_.CalculateSize(FileDescriptorProto._repeated_publicDependency_codec);
						arg_219_0 = (num2 * 364415987u ^ 2788687919u);
						continue;
					case 12u:
						arg_219_0 = (((this.options_ != null) ? 2430690257u : 2280397496u) ^ num2 * 1334933833u);
						continue;
					case 13u:
						num += this.dependency_.CalculateSize(FileDescriptorProto._repeated_dependency_codec);
						arg_219_0 = 2259280645u;
						continue;
					case 14u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SourceCodeInfo);
						arg_219_0 = (num2 * 1609848454u ^ 2868218024u);
						continue;
					case 15u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_219_0 = (num2 * 2625995735u ^ 459553206u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FileDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_214;
			}
			goto IL_29C;
			uint arg_238_0;
			while (true)
			{
				IL_233:
				uint num;
				switch ((num = (arg_238_0 ^ 764909073u)) % 18u)
				{
				case 0u:
					this.options_ = new FileOptions();
					arg_238_0 = (num * 3220841844u ^ 2181669831u);
					continue;
				case 2u:
					goto IL_214;
				case 3u:
					this.sourceCodeInfo_ = new SourceCodeInfo();
					arg_238_0 = (num * 1860850083u ^ 1218319837u);
					continue;
				case 4u:
					arg_238_0 = (((this.options_ == null) ? 2698478509u : 4292187703u) ^ num * 692266544u);
					continue;
				case 5u:
					this.dependency_.Add(other.dependency_);
					arg_238_0 = 694200155u;
					continue;
				case 6u:
					this.Options.MergeFrom(other.Options);
					arg_238_0 = 1816496994u;
					continue;
				case 7u:
					arg_238_0 = ((FileDescriptorProto.smethod_2(other.Package) == 0) ? 995894450u : 1146394111u);
					continue;
				case 8u:
					return;
				case 9u:
					goto IL_29C;
				case 10u:
					this.Package = other.Package;
					arg_238_0 = (num * 4171115928u ^ 721620962u);
					continue;
				case 11u:
					arg_238_0 = ((other.sourceCodeInfo_ == null) ? 652165012u : 1712211908u);
					continue;
				case 12u:
					this.Name = other.Name;
					arg_238_0 = (num * 3464727324u ^ 3965781134u);
					continue;
				case 13u:
					this.SourceCodeInfo.MergeFrom(other.SourceCodeInfo);
					arg_238_0 = 652165012u;
					continue;
				case 14u:
					this.publicDependency_.Add(other.publicDependency_);
					this.weakDependency_.Add(other.weakDependency_);
					arg_238_0 = (num * 2209115872u ^ 2409077920u);
					continue;
				case 15u:
					this.messageType_.Add(other.messageType_);
					this.enumType_.Add(other.enumType_);
					arg_238_0 = (num * 1670917312u ^ 3018588943u);
					continue;
				case 16u:
					this.service_.Add(other.service_);
					this.extension_.Add(other.extension_);
					arg_238_0 = (((other.options_ == null) ? 3773798696u : 3585226863u) ^ num * 1572248875u);
					continue;
				case 17u:
					arg_238_0 = (((this.sourceCodeInfo_ != null) ? 679567055u : 804216353u) ^ num * 3179753165u);
					continue;
				}
				break;
			}
			return;
			IL_214:
			arg_238_0 = 962617511u;
			goto IL_233;
			IL_29C:
			arg_238_0 = ((FileDescriptorProto.smethod_2(other.Name) == 0) ? 1295480606u : 916586989u);
			goto IL_233;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_5EA:
				uint num;
				uint arg_512_0 = ((num = input.ReadTag()) != 0u) ? 1069499499u : 312510853u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_512_0 ^ 1478275423u)) % 47u)
					{
					case 0u:
						arg_512_0 = (((num == 58u) ? 3210956217u : 3845661273u) ^ num2 * 3383179500u);
						continue;
					case 1u:
						arg_512_0 = ((num == 88u) ? 409465715u : 428599862u);
						continue;
					case 2u:
						this.extension_.AddEntriesFrom(input, FileDescriptorProto._repeated_extension_codec);
						arg_512_0 = 1368449963u;
						continue;
					case 3u:
						this.sourceCodeInfo_ = new SourceCodeInfo();
						arg_512_0 = (num2 * 606652195u ^ 1300013120u);
						continue;
					case 4u:
						arg_512_0 = (((num == 50u) ? 1342808885u : 2145403300u) ^ num2 * 2197478583u);
						continue;
					case 5u:
						this.Name = input.ReadString();
						arg_512_0 = 539371738u;
						continue;
					case 6u:
						input.ReadMessage(this.options_);
						arg_512_0 = 466862560u;
						continue;
					case 7u:
						arg_512_0 = 1069499499u;
						continue;
					case 8u:
						arg_512_0 = (((num != 10u) ? 2079042903u : 332659387u) ^ num2 * 1563502215u);
						continue;
					case 9u:
						arg_512_0 = (num2 * 3913726958u ^ 2729906196u);
						continue;
					case 10u:
						input.SkipLastField();
						arg_512_0 = 491792708u;
						continue;
					case 11u:
						arg_512_0 = (num2 * 2128194187u ^ 105784687u);
						continue;
					case 12u:
						this.weakDependency_.AddEntriesFrom(input, FileDescriptorProto._repeated_weakDependency_codec);
						arg_512_0 = 539371738u;
						continue;
					case 13u:
						this.publicDependency_.AddEntriesFrom(input, FileDescriptorProto._repeated_publicDependency_codec);
						arg_512_0 = 704954453u;
						continue;
					case 14u:
						this.service_.AddEntriesFrom(input, FileDescriptorProto._repeated_service_codec);
						arg_512_0 = 258891895u;
						continue;
					case 15u:
						arg_512_0 = ((num <= 82u) ? 1048204831u : 2134457618u);
						continue;
					case 16u:
						this.enumType_.AddEntriesFrom(input, FileDescriptorProto._repeated_enumType_codec);
						arg_512_0 = 539371738u;
						continue;
					case 17u:
						arg_512_0 = (((num == 42u) ? 2328656472u : 4119551682u) ^ num2 * 1537228965u);
						continue;
					case 18u:
						arg_512_0 = ((num > 50u) ? 1531413913u : 1148483821u);
						continue;
					case 19u:
						input.ReadMessage(this.sourceCodeInfo_);
						arg_512_0 = 539371738u;
						continue;
					case 20u:
						arg_512_0 = ((num > 74u) ? 943112168u : 779630111u);
						continue;
					case 21u:
						arg_512_0 = (num2 * 1509983542u ^ 1288472364u);
						continue;
					case 22u:
						this.messageType_.AddEntriesFrom(input, FileDescriptorProto._repeated_messageType_codec);
						arg_512_0 = 2320462u;
						continue;
					case 23u:
						arg_512_0 = (((num == 90u) ? 607603030u : 1704921963u) ^ num2 * 1478016349u);
						continue;
					case 24u:
						goto IL_5EA;
					case 25u:
						arg_512_0 = (num2 * 3051847227u ^ 583495907u);
						continue;
					case 26u:
						arg_512_0 = ((this.options_ != null) ? 1401457218u : 2029100803u);
						continue;
					case 27u:
						arg_512_0 = ((this.sourceCodeInfo_ == null) ? 379028396u : 1592163449u);
						continue;
					case 28u:
						arg_512_0 = (num2 * 981101358u ^ 1362847210u);
						continue;
					case 29u:
						arg_512_0 = (((num <= 26u) ? 3747324621u : 3044593695u) ^ num2 * 2905017001u);
						continue;
					case 30u:
						this.options_ = new FileOptions();
						arg_512_0 = (num2 * 1079761321u ^ 270212350u);
						continue;
					case 31u:
						arg_512_0 = (num2 * 3682835335u ^ 128561711u);
						continue;
					case 32u:
						arg_512_0 = (((num == 74u) ? 1054013984u : 2089078168u) ^ num2 * 1296281720u);
						continue;
					case 33u:
						arg_512_0 = ((num == 34u) ? 1930286380u : 60179543u);
						continue;
					case 34u:
						arg_512_0 = (num2 * 3248666282u ^ 1568719716u);
						continue;
					case 35u:
						arg_512_0 = (num2 * 4283468544u ^ 2930132698u);
						continue;
					case 36u:
						arg_512_0 = (num2 * 837569406u ^ 632842868u);
						continue;
					case 37u:
						arg_512_0 = (((num != 18u) ? 3543572441u : 3770395692u) ^ num2 * 2557400466u);
						continue;
					case 39u:
						arg_512_0 = (num2 * 1383629141u ^ 3420608478u);
						continue;
					case 40u:
						arg_512_0 = (((num != 66u) ? 1697492263u : 1883239607u) ^ num2 * 1032412225u);
						continue;
					case 41u:
						arg_512_0 = (((num != 26u) ? 2429039872u : 3501304900u) ^ num2 * 2377458010u);
						continue;
					case 42u:
						arg_512_0 = (((num == 82u) ? 2329328990u : 4267129133u) ^ num2 * 2610317229u);
						continue;
					case 43u:
						arg_512_0 = (num2 * 279686107u ^ 1978742598u);
						continue;
					case 44u:
						this.Package = input.ReadString();
						arg_512_0 = 539371738u;
						continue;
					case 45u:
						this.dependency_.AddEntriesFrom(input, FileDescriptorProto._repeated_dependency_codec);
						arg_512_0 = 1301769014u;
						continue;
					case 46u:
						arg_512_0 = (((num == 80u) ? 3643569453u : 3413953600u) ^ num2 * 4178554775u);
						continue;
					}
					return;
				}
			}
		}

		static FileDescriptorProto()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_ED:
				uint arg_C9_0 = 1528781333u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C9_0 ^ 2037266516u)) % 6u)
					{
					case 0u:
						FileDescriptorProto._repeated_messageType_codec = FieldCodec.ForMessage<DescriptorProto>(34u, DescriptorProto.Parser);
						arg_C9_0 = (num * 2968748525u ^ 361389642u);
						continue;
					case 1u:
						FileDescriptorProto._repeated_dependency_codec = FieldCodec.ForString(26u);
						FileDescriptorProto._repeated_publicDependency_codec = FieldCodec.ForInt32(80u);
						FileDescriptorProto._repeated_weakDependency_codec = FieldCodec.ForInt32(88u);
						arg_C9_0 = (num * 1417093308u ^ 2065169176u);
						continue;
					case 2u:
						FileDescriptorProto._repeated_enumType_codec = FieldCodec.ForMessage<EnumDescriptorProto>(42u, EnumDescriptorProto.Parser);
						FileDescriptorProto._repeated_service_codec = FieldCodec.ForMessage<ServiceDescriptorProto>(50u, ServiceDescriptorProto.Parser);
						arg_C9_0 = (num * 1155017405u ^ 3014883625u);
						continue;
					case 3u:
						goto IL_ED;
					case 5u:
						FileDescriptorProto._repeated_extension_codec = FieldCodec.ForMessage<FieldDescriptorProto>(58u, FieldDescriptorProto.Parser);
						arg_C9_0 = (num * 833583586u ^ 1864289640u);
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
