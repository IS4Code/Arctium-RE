using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class FileDescriptorProto : IMessage, IMessage<FileDescriptorProto>, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FileDescriptorProto.__c __9 = new FileDescriptorProto.__c();

			internal FileDescriptorProto cctor>b__79_0()
			{
				return new FileDescriptorProto();
			}
		}

		private static readonly MessageParser<FileDescriptorProto> _parser = new MessageParser<FileDescriptorProto>(new Func<FileDescriptorProto>(FileDescriptorProto.__c.__9.<.cctor>b__79_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int PackageFieldNumber = 2;

		private string package_ = "";

		public const int DependencyFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_dependency_codec = FieldCodec.ForString(26u);

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

		public const int SyntaxFieldNumber = 12;

		private string syntax_ = "";

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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
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

		public string Syntax
		{
			get
			{
				return this.syntax_;
			}
			set
			{
				this.syntax_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public FileDescriptorProto()
		{
		}

		public FileDescriptorProto(FileDescriptorProto other) : this()
		{
			while (true)
			{
				IL_154:
				uint arg_123_0 = 3575929238u;
				while (true)
				{
					uint num;
					switch ((num = (arg_123_0 ^ 2184623750u)) % 9u)
					{
					case 0u:
						goto IL_154;
					case 1u:
						this.dependency_ = other.dependency_.Clone();
						arg_123_0 = (num * 1388212647u ^ 3763579264u);
						continue;
					case 3u:
						this.enumType_ = other.enumType_.Clone();
						this.service_ = other.service_.Clone();
						arg_123_0 = (num * 3065078095u ^ 2127772231u);
						continue;
					case 4u:
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_123_0 = 3807456888u;
						continue;
					case 5u:
						this.publicDependency_ = other.publicDependency_.Clone();
						arg_123_0 = (num * 1524559630u ^ 3399945333u);
						continue;
					case 6u:
						this.name_ = other.name_;
						this.package_ = other.package_;
						arg_123_0 = (num * 1873401823u ^ 673299681u);
						continue;
					case 7u:
						this.weakDependency_ = other.weakDependency_.Clone();
						this.messageType_ = other.messageType_.Clone();
						arg_123_0 = (num * 2598007098u ^ 2368810627u);
						continue;
					case 8u:
						this.extension_ = other.extension_.Clone();
						arg_123_0 = (num * 1383762144u ^ 2356962222u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.SourceCodeInfo = ((other.sourceCodeInfo_ != null) ? other.SourceCodeInfo.Clone() : null);
			this.syntax_ = other.syntax_;
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
				goto IL_193;
			}
			goto IL_2E1;
			int arg_253_0;
			while (true)
			{
				IL_24E:
				switch ((arg_253_0 ^ 1423993945) % 29)
				{
				case 0:
					arg_253_0 = (this.messageType_.Equals(other.messageType_) ? 250297761 : 1816271783);
					continue;
				case 1:
					return true;
				case 2:
					arg_253_0 = ((!this.extension_.Equals(other.extension_)) ? 863250447 : 1678889957);
					continue;
				case 3:
					arg_253_0 = (this.service_.Equals(other.service_) ? 105404568 : 1059399591);
					continue;
				case 4:
					arg_253_0 = (this.enumType_.Equals(other.enumType_) ? 391392919 : 269614242);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_193;
				case 8:
					arg_253_0 = (this.weakDependency_.Equals(other.weakDependency_) ? 470890988 : 649668332);
					continue;
				case 9:
					arg_253_0 = (this.publicDependency_.Equals(other.publicDependency_) ? 1245894391 : 153445290);
					continue;
				case 10:
					return false;
				case 11:
					arg_253_0 = (FileDescriptorProto.smethod_0(this.Name, other.Name) ? 2000780036 : 1855336936);
					continue;
				case 12:
					arg_253_0 = ((!FileDescriptorProto.smethod_1(this.Options, other.Options)) ? 560506800 : 643090032);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					arg_253_0 = (FileDescriptorProto.smethod_0(this.Syntax, other.Syntax) ? 456655127 : 1603943830);
					continue;
				case 17:
					return false;
				case 18:
					return false;
				case 19:
					return false;
				case 20:
					goto IL_2E1;
				case 21:
					arg_253_0 = (this.dependency_.Equals(other.dependency_) ? 2042391476 : 1284745999);
					continue;
				case 22:
					return false;
				case 23:
					arg_253_0 = (FileDescriptorProto.smethod_0(this.Package, other.Package) ? 1416359973 : 1475563243);
					continue;
				case 24:
					return false;
				case 25:
					return false;
				case 26:
					arg_253_0 = (FileDescriptorProto.smethod_1(this.SourceCodeInfo, other.SourceCodeInfo) ? 733905757 : 627971778);
					continue;
				case 28:
					return false;
				}
				break;
			}
			return true;
			IL_193:
			arg_253_0 = 1362730375;
			goto IL_24E;
			IL_2E1:
			arg_253_0 = ((other == this) ? 136794140 : 532375342);
			goto IL_24E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_247:
				uint arg_1FE_0 = 2063206840u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1FE_0 ^ 628707035u)) % 15u)
					{
					case 0u:
						num ^= FileDescriptorProto.smethod_3(this.Package);
						arg_1FE_0 = (num2 * 683899996u ^ 4051133618u);
						continue;
					case 2u:
						num ^= FileDescriptorProto.smethod_3(this.enumType_);
						arg_1FE_0 = (num2 * 3604887501u ^ 2860327677u);
						continue;
					case 3u:
						arg_1FE_0 = ((FileDescriptorProto.smethod_2(this.Syntax) != 0) ? 1011365958u : 2078100017u);
						continue;
					case 4u:
						num ^= FileDescriptorProto.smethod_3(this.Syntax);
						arg_1FE_0 = (num2 * 2326690851u ^ 3694135622u);
						continue;
					case 5u:
						num ^= FileDescriptorProto.smethod_3(this.SourceCodeInfo);
						arg_1FE_0 = (num2 * 1372958930u ^ 2114007303u);
						continue;
					case 6u:
						arg_1FE_0 = (((FileDescriptorProto.smethod_2(this.Name) == 0) ? 2310777205u : 3682993566u) ^ num2 * 757379244u);
						continue;
					case 7u:
						num ^= FileDescriptorProto.smethod_3(this.service_);
						num ^= FileDescriptorProto.smethod_3(this.extension_);
						arg_1FE_0 = (((this.options_ == null) ? 2696068965u : 4021405452u) ^ num2 * 3053807802u);
						continue;
					case 8u:
						goto IL_247;
					case 9u:
						num ^= FileDescriptorProto.smethod_3(this.dependency_);
						arg_1FE_0 = 1353690902u;
						continue;
					case 10u:
						num ^= FileDescriptorProto.smethod_3(this.Name);
						arg_1FE_0 = (num2 * 1967288003u ^ 3230173170u);
						continue;
					case 11u:
						num ^= FileDescriptorProto.smethod_3(this.publicDependency_);
						num ^= FileDescriptorProto.smethod_3(this.weakDependency_);
						num ^= FileDescriptorProto.smethod_3(this.messageType_);
						arg_1FE_0 = (num2 * 2963645360u ^ 488714282u);
						continue;
					case 12u:
						arg_1FE_0 = ((FileDescriptorProto.smethod_2(this.Package) == 0) ? 1063633222u : 1831663184u);
						continue;
					case 13u:
						arg_1FE_0 = ((this.sourceCodeInfo_ == null) ? 695427623u : 1268475339u);
						continue;
					case 14u:
						num ^= FileDescriptorProto.smethod_3(this.Options);
						arg_1FE_0 = (num2 * 1395976384u ^ 3790287643u);
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
				goto IL_142;
			}
			goto IL_2D7;
			uint arg_26B_0;
			while (true)
			{
				IL_266:
				uint num;
				switch ((num = (arg_26B_0 ^ 2141970552u)) % 20u)
				{
				case 0u:
					output.WriteString(this.Syntax);
					arg_26B_0 = (num * 891968062u ^ 488854514u);
					continue;
				case 1u:
					output.WriteMessage(this.SourceCodeInfo);
					arg_26B_0 = (num * 549984498u ^ 4165275474u);
					continue;
				case 2u:
					output.WriteString(this.Name);
					arg_26B_0 = (num * 2346760264u ^ 87056129u);
					continue;
				case 3u:
					output.WriteRawTag(66);
					output.WriteMessage(this.Options);
					arg_26B_0 = (num * 618613826u ^ 4148186224u);
					continue;
				case 4u:
					this.dependency_.WriteTo(output, FileDescriptorProto._repeated_dependency_codec);
					arg_26B_0 = 765621259u;
					continue;
				case 5u:
					output.WriteRawTag(74);
					arg_26B_0 = (num * 647892067u ^ 2343897654u);
					continue;
				case 7u:
					this.weakDependency_.WriteTo(output, FileDescriptorProto._repeated_weakDependency_codec);
					arg_26B_0 = (((FileDescriptorProto.smethod_2(this.Syntax) != 0) ? 1706845051u : 1717899730u) ^ num * 1046609600u);
					continue;
				case 8u:
					this.enumType_.WriteTo(output, FileDescriptorProto._repeated_enumType_codec);
					this.service_.WriteTo(output, FileDescriptorProto._repeated_service_codec);
					arg_26B_0 = (num * 2780825842u ^ 2841685598u);
					continue;
				case 9u:
					goto IL_142;
				case 10u:
					output.WriteRawTag(18);
					arg_26B_0 = (num * 1998727022u ^ 980438927u);
					continue;
				case 11u:
					output.WriteRawTag(98);
					arg_26B_0 = (num * 4080617821u ^ 3007854463u);
					continue;
				case 12u:
					this.publicDependency_.WriteTo(output, FileDescriptorProto._repeated_publicDependency_codec);
					arg_26B_0 = 333743959u;
					continue;
				case 13u:
					output.WriteRawTag(10);
					arg_26B_0 = (num * 3777853415u ^ 4084976273u);
					continue;
				case 14u:
					arg_26B_0 = ((this.sourceCodeInfo_ == null) ? 160479688u : 914677297u);
					continue;
				case 15u:
					output.WriteString(this.Package);
					arg_26B_0 = (num * 2326637175u ^ 1527913553u);
					continue;
				case 16u:
					arg_26B_0 = (((this.options_ == null) ? 671890806u : 459397835u) ^ num * 3363857649u);
					continue;
				case 17u:
					goto IL_2D7;
				case 18u:
					this.extension_.WriteTo(output, FileDescriptorProto._repeated_extension_codec);
					arg_26B_0 = (num * 1542808062u ^ 1370167292u);
					continue;
				case 19u:
					this.messageType_.WriteTo(output, FileDescriptorProto._repeated_messageType_codec);
					arg_26B_0 = (num * 1124482291u ^ 3682725413u);
					continue;
				}
				break;
			}
			return;
			IL_142:
			arg_26B_0 = 1453753241u;
			goto IL_266;
			IL_2D7:
			arg_26B_0 = ((FileDescriptorProto.smethod_2(this.Package) != 0) ? 2144773326u : 1467215348u);
			goto IL_266;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_28D:
				uint arg_240_0 = 2678321268u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_240_0 ^ 2998008459u)) % 16u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SourceCodeInfo);
						arg_240_0 = (num2 * 1998575584u ^ 614984952u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Package);
						arg_240_0 = (num2 * 2515148190u ^ 2062787730u);
						continue;
					case 2u:
						num += this.service_.CalculateSize(FileDescriptorProto._repeated_service_codec);
						num += this.extension_.CalculateSize(FileDescriptorProto._repeated_extension_codec);
						arg_240_0 = (num2 * 3405254182u ^ 3686798669u);
						continue;
					case 3u:
						arg_240_0 = ((FileDescriptorProto.smethod_2(this.Syntax) == 0) ? 3652579202u : 2718604455u);
						continue;
					case 4u:
						num += this.weakDependency_.CalculateSize(FileDescriptorProto._repeated_weakDependency_codec);
						num += this.messageType_.CalculateSize(FileDescriptorProto._repeated_messageType_codec);
						num += this.enumType_.CalculateSize(FileDescriptorProto._repeated_enumType_codec);
						arg_240_0 = (num2 * 836152376u ^ 2323224697u);
						continue;
					case 5u:
						num += this.publicDependency_.CalculateSize(FileDescriptorProto._repeated_publicDependency_codec);
						arg_240_0 = (num2 * 4003264926u ^ 1020558761u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_240_0 = (num2 * 311541268u ^ 1633113885u);
						continue;
					case 7u:
						num += this.dependency_.CalculateSize(FileDescriptorProto._repeated_dependency_codec);
						arg_240_0 = 2974179902u;
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_240_0 = (num2 * 3433867051u ^ 969402542u);
						continue;
					case 10u:
						arg_240_0 = (((this.options_ != null) ? 3345198335u : 2913778775u) ^ num2 * 2339025109u);
						continue;
					case 11u:
						goto IL_28D;
					case 12u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Syntax);
						arg_240_0 = (num2 * 73868573u ^ 520552830u);
						continue;
					case 13u:
						arg_240_0 = ((FileDescriptorProto.smethod_2(this.Package) == 0) ? 2531598476u : 2461569610u);
						continue;
					case 14u:
						arg_240_0 = ((this.sourceCodeInfo_ != null) ? 2695163259u : 3677908728u);
						continue;
					case 15u:
						arg_240_0 = (((FileDescriptorProto.smethod_2(this.Name) != 0) ? 1607429488u : 1695531333u) ^ num2 * 1923024413u);
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
				goto IL_252;
			}
			goto IL_307;
			uint arg_297_0;
			while (true)
			{
				IL_292:
				uint num;
				switch ((num = (arg_297_0 ^ 3747012698u)) % 21u)
				{
				case 0u:
					this.Package = other.Package;
					arg_297_0 = (num * 2891496509u ^ 2689437845u);
					continue;
				case 2u:
					this.weakDependency_.Add(other.weakDependency_);
					arg_297_0 = (num * 1590212279u ^ 230515261u);
					continue;
				case 3u:
					goto IL_252;
				case 4u:
					this.enumType_.Add(other.enumType_);
					this.service_.Add(other.service_);
					this.extension_.Add(other.extension_);
					arg_297_0 = (num * 3763304133u ^ 3764563442u);
					continue;
				case 5u:
					this.options_ = new FileOptions();
					arg_297_0 = (num * 2806335943u ^ 1327564284u);
					continue;
				case 6u:
					this.Name = other.Name;
					arg_297_0 = (num * 359145698u ^ 2448152882u);
					continue;
				case 7u:
					arg_297_0 = ((FileDescriptorProto.smethod_2(other.Syntax) != 0) ? 3547840750u : 2187627440u);
					continue;
				case 8u:
					this.Syntax = other.Syntax;
					arg_297_0 = (num * 732106943u ^ 2939825660u);
					continue;
				case 9u:
					goto IL_307;
				case 10u:
					arg_297_0 = (((other.options_ != null) ? 2909039613u : 2893597917u) ^ num * 3080653002u);
					continue;
				case 11u:
					arg_297_0 = (((this.sourceCodeInfo_ == null) ? 3833044371u : 3043259062u) ^ num * 1788227699u);
					continue;
				case 12u:
					this.messageType_.Add(other.messageType_);
					arg_297_0 = (num * 3665581954u ^ 1357302765u);
					continue;
				case 13u:
					this.SourceCodeInfo.MergeFrom(other.SourceCodeInfo);
					arg_297_0 = 2725563441u;
					continue;
				case 14u:
					return;
				case 15u:
					arg_297_0 = ((FileDescriptorProto.smethod_2(other.Package) != 0) ? 2558204566u : 2685338121u);
					continue;
				case 16u:
					arg_297_0 = (((this.options_ != null) ? 3467117287u : 3402127853u) ^ num * 458057237u);
					continue;
				case 17u:
					this.sourceCodeInfo_ = new SourceCodeInfo();
					arg_297_0 = (num * 534316533u ^ 3815259915u);
					continue;
				case 18u:
					this.dependency_.Add(other.dependency_);
					this.publicDependency_.Add(other.publicDependency_);
					arg_297_0 = 3488571248u;
					continue;
				case 19u:
					this.Options.MergeFrom(other.Options);
					arg_297_0 = 2149137111u;
					continue;
				case 20u:
					arg_297_0 = ((other.sourceCodeInfo_ != null) ? 3096650730u : 2725563441u);
					continue;
				}
				break;
			}
			return;
			IL_252:
			arg_297_0 = 3007324796u;
			goto IL_292;
			IL_307:
			arg_297_0 = ((FileDescriptorProto.smethod_2(other.Name) != 0) ? 2972218799u : 4075608952u);
			goto IL_292;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_614:
				uint num;
				uint arg_53C_0 = ((num = input.ReadTag()) != 0u) ? 2426693751u : 2746740417u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_53C_0 ^ 2796671478u)) % 47u)
					{
					case 0u:
						arg_53C_0 = (((num != 26u) ? 3234518167u : 4080755734u) ^ num2 * 3763736491u);
						continue;
					case 1u:
						arg_53C_0 = ((num > 88u) ? 3934412663u : 4174775471u);
						continue;
					case 2u:
						arg_53C_0 = (((num != 58u) ? 3480500766u : 2963671683u) ^ num2 * 105112105u);
						continue;
					case 3u:
						arg_53C_0 = (num2 * 2352432553u ^ 530834772u);
						continue;
					case 4u:
						this.messageType_.AddEntriesFrom(input, FileDescriptorProto._repeated_messageType_codec);
						arg_53C_0 = 2625973319u;
						continue;
					case 5u:
						arg_53C_0 = (((num == 66u) ? 2399266528u : 2990888610u) ^ num2 * 49967855u);
						continue;
					case 6u:
						this.sourceCodeInfo_ = new SourceCodeInfo();
						arg_53C_0 = (num2 * 1680181953u ^ 2199333464u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_53C_0 = 2625973319u;
						continue;
					case 8u:
						arg_53C_0 = (num2 * 1929843402u ^ 1009531716u);
						continue;
					case 9u:
						goto IL_614;
					case 10u:
						arg_53C_0 = (num2 * 523290572u ^ 871966656u);
						continue;
					case 11u:
						this.weakDependency_.AddEntriesFrom(input, FileDescriptorProto._repeated_weakDependency_codec);
						arg_53C_0 = 3078703021u;
						continue;
					case 12u:
						arg_53C_0 = (((num != 42u) ? 3663485356u : 2547820296u) ^ num2 * 1098197768u);
						continue;
					case 13u:
						arg_53C_0 = 2426693751u;
						continue;
					case 14u:
						arg_53C_0 = (((num == 80u) ? 3388393731u : 3850663134u) ^ num2 * 2853416292u);
						continue;
					case 15u:
						arg_53C_0 = (num2 * 1690967044u ^ 2760031920u);
						continue;
					case 16u:
						input.ReadMessage(this.sourceCodeInfo_);
						arg_53C_0 = 2625973319u;
						continue;
					case 17u:
						arg_53C_0 = (num2 * 100914873u ^ 459393050u);
						continue;
					case 18u:
						arg_53C_0 = (((num <= 26u) ? 1624393110u : 1659306327u) ^ num2 * 1272127782u);
						continue;
					case 19u:
						arg_53C_0 = (((num != 18u) ? 3725914569u : 3273919117u) ^ num2 * 3961008691u);
						continue;
					case 20u:
						arg_53C_0 = ((this.options_ == null) ? 3094926438u : 3448572962u);
						continue;
					case 21u:
						this.enumType_.AddEntriesFrom(input, FileDescriptorProto._repeated_enumType_codec);
						arg_53C_0 = 3557833011u;
						continue;
					case 22u:
						arg_53C_0 = ((this.sourceCodeInfo_ == null) ? 2904150378u : 3818891204u);
						continue;
					case 23u:
						arg_53C_0 = ((num == 50u) ? 2935341907u : 2742497708u);
						continue;
					case 24u:
						arg_53C_0 = (((num != 82u) ? 1523011975u : 1280503552u) ^ num2 * 1167527151u);
						continue;
					case 25u:
						this.Syntax = input.ReadString();
						arg_53C_0 = 2625973319u;
						continue;
					case 26u:
						this.options_ = new FileOptions();
						arg_53C_0 = (num2 * 4112195377u ^ 1876659378u);
						continue;
					case 27u:
						this.Package = input.ReadString();
						arg_53C_0 = 2625973319u;
						continue;
					case 28u:
						arg_53C_0 = (((num != 74u) ? 1641478123u : 520753610u) ^ num2 * 161714108u);
						continue;
					case 29u:
						arg_53C_0 = (((num != 34u) ? 2293718899u : 4294795246u) ^ num2 * 404660977u);
						continue;
					case 30u:
						arg_53C_0 = (num2 * 224820281u ^ 1464024683u);
						continue;
					case 31u:
						arg_53C_0 = (num2 * 763365213u ^ 2164902010u);
						continue;
					case 32u:
						arg_53C_0 = (((num == 10u) ? 1652832291u : 796519026u) ^ num2 * 2092453958u);
						continue;
					case 33u:
						arg_53C_0 = (num2 * 3564613589u ^ 1403965428u);
						continue;
					case 34u:
						this.Name = input.ReadString();
						arg_53C_0 = 2625973319u;
						continue;
					case 35u:
						arg_53C_0 = ((num > 58u) ? 2727037027u : 3484348619u);
						continue;
					case 36u:
						this.publicDependency_.AddEntriesFrom(input, FileDescriptorProto._repeated_publicDependency_codec);
						arg_53C_0 = 2773543546u;
						continue;
					case 37u:
						input.ReadMessage(this.options_);
						arg_53C_0 = 2625973319u;
						continue;
					case 38u:
						arg_53C_0 = ((num <= 42u) ? 3701563203u : 3646822911u);
						continue;
					case 40u:
						arg_53C_0 = (((num != 98u) ? 332180504u : 305955724u) ^ num2 * 3633178782u);
						continue;
					case 41u:
						this.dependency_.AddEntriesFrom(input, FileDescriptorProto._repeated_dependency_codec);
						arg_53C_0 = 2625973319u;
						continue;
					case 42u:
						arg_53C_0 = (((num != 88u) ? 566040478u : 718732372u) ^ num2 * 2981097676u);
						continue;
					case 43u:
						arg_53C_0 = ((num > 80u) ? 2235219671u : 3494151182u);
						continue;
					case 44u:
						this.service_.AddEntriesFrom(input, FileDescriptorProto._repeated_service_codec);
						arg_53C_0 = 2625973319u;
						continue;
					case 45u:
						arg_53C_0 = ((num != 90u) ? 3818832610u : 3854914844u);
						continue;
					case 46u:
						this.extension_.AddEntriesFrom(input, FileDescriptorProto._repeated_extension_codec);
						arg_53C_0 = 2625973319u;
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
				IL_100:
				uint arg_D8_0 = 3941137493u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D8_0 ^ 2214840476u)) % 7u)
					{
					case 0u:
						FileDescriptorProto._repeated_enumType_codec = FieldCodec.ForMessage<EnumDescriptorProto>(42u, EnumDescriptorProto.Parser);
						arg_D8_0 = (num * 1592216465u ^ 2792509350u);
						continue;
					case 1u:
						FileDescriptorProto._repeated_weakDependency_codec = FieldCodec.ForInt32(88u);
						arg_D8_0 = (num * 1061256043u ^ 3239522193u);
						continue;
					case 2u:
						FileDescriptorProto._repeated_publicDependency_codec = FieldCodec.ForInt32(80u);
						arg_D8_0 = (num * 2285483405u ^ 757075284u);
						continue;
					case 3u:
						goto IL_100;
					case 5u:
						FileDescriptorProto._repeated_service_codec = FieldCodec.ForMessage<ServiceDescriptorProto>(50u, ServiceDescriptorProto.Parser);
						FileDescriptorProto._repeated_extension_codec = FieldCodec.ForMessage<FieldDescriptorProto>(58u, FieldDescriptorProto.Parser);
						arg_D8_0 = (num * 3611654478u ^ 784137409u);
						continue;
					case 6u:
						FileDescriptorProto._repeated_messageType_codec = FieldCodec.ForMessage<DescriptorProto>(34u, DescriptorProto.Parser);
						arg_D8_0 = (num * 2039997192u ^ 3630502781u);
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
