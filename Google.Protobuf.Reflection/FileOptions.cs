using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class FileOptions : IMessage, IMessage<FileOptions>, IEquatable<FileOptions>, IDeepCloneable<FileOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum OptimizeMode
			{
				SPEED = 1,
				CODE_SIZE,
				LITE_RUNTIME
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FileOptions.__c __9 = new FileOptions.__c();

			internal FileOptions cctor>b__100_0()
			{
				return new FileOptions();
			}
		}

		private static readonly MessageParser<FileOptions> _parser = new MessageParser<FileOptions>(new Func<FileOptions>(FileOptions.__c.__9.<.cctor>b__100_0));

		public const int JavaPackageFieldNumber = 1;

		private string javaPackage_ = "";

		public const int JavaOuterClassnameFieldNumber = 8;

		private string javaOuterClassname_ = "";

		public const int JavaMultipleFilesFieldNumber = 10;

		private bool javaMultipleFiles_;

		public const int JavaGenerateEqualsAndHashFieldNumber = 20;

		private bool javaGenerateEqualsAndHash_;

		public const int JavaStringCheckUtf8FieldNumber = 27;

		private bool javaStringCheckUtf8_;

		public const int OptimizeForFieldNumber = 9;

		private FileOptions.Types.OptimizeMode optimizeFor_ = FileOptions.Types.OptimizeMode.SPEED;

		public const int GoPackageFieldNumber = 11;

		private string goPackage_ = "";

		public const int CcGenericServicesFieldNumber = 16;

		private bool ccGenericServices_;

		public const int JavaGenericServicesFieldNumber = 17;

		private bool javaGenericServices_;

		public const int PyGenericServicesFieldNumber = 18;

		private bool pyGenericServices_;

		public const int DeprecatedFieldNumber = 23;

		private bool deprecated_;

		public const int CcEnableArenasFieldNumber = 31;

		private bool ccEnableArenas_;

		public const int ObjcClassPrefixFieldNumber = 36;

		private string objcClassPrefix_ = "";

		public const int CsharpNamespaceFieldNumber = 37;

		private string csharpNamespace_ = "";

		public const int JavananoUseDeprecatedPackageFieldNumber = 38;

		private bool javananoUseDeprecatedPackage_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<FileOptions> Parser
		{
			get
			{
				return FileOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FileOptions.Descriptor;
			}
		}

		public string JavaPackage
		{
			get
			{
				return this.javaPackage_;
			}
			set
			{
				this.javaPackage_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public string JavaOuterClassname
		{
			get
			{
				return this.javaOuterClassname_;
			}
			set
			{
				this.javaOuterClassname_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool JavaMultipleFiles
		{
			get
			{
				return this.javaMultipleFiles_;
			}
			set
			{
				this.javaMultipleFiles_ = value;
			}
		}

		public bool JavaGenerateEqualsAndHash
		{
			get
			{
				return this.javaGenerateEqualsAndHash_;
			}
			set
			{
				this.javaGenerateEqualsAndHash_ = value;
			}
		}

		public bool JavaStringCheckUtf8
		{
			get
			{
				return this.javaStringCheckUtf8_;
			}
			set
			{
				this.javaStringCheckUtf8_ = value;
			}
		}

		public FileOptions.Types.OptimizeMode OptimizeFor
		{
			get
			{
				return this.optimizeFor_;
			}
			set
			{
				this.optimizeFor_ = value;
			}
		}

		public string GoPackage
		{
			get
			{
				return this.goPackage_;
			}
			set
			{
				this.goPackage_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool CcGenericServices
		{
			get
			{
				return this.ccGenericServices_;
			}
			set
			{
				this.ccGenericServices_ = value;
			}
		}

		public bool JavaGenericServices
		{
			get
			{
				return this.javaGenericServices_;
			}
			set
			{
				this.javaGenericServices_ = value;
			}
		}

		public bool PyGenericServices
		{
			get
			{
				return this.pyGenericServices_;
			}
			set
			{
				this.pyGenericServices_ = value;
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

		public bool CcEnableArenas
		{
			get
			{
				return this.ccEnableArenas_;
			}
			set
			{
				this.ccEnableArenas_ = value;
			}
		}

		public string ObjcClassPrefix
		{
			get
			{
				return this.objcClassPrefix_;
			}
			set
			{
				this.objcClassPrefix_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string CsharpNamespace
		{
			get
			{
				return this.csharpNamespace_;
			}
			set
			{
				this.csharpNamespace_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool JavananoUseDeprecatedPackage
		{
			get
			{
				return this.javananoUseDeprecatedPackage_;
			}
			set
			{
				this.javananoUseDeprecatedPackage_ = value;
			}
		}

		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return this.uninterpretedOption_;
			}
		}

		public FileOptions()
		{
		}

		public FileOptions(FileOptions other) : this()
		{
			while (true)
			{
				IL_172:
				uint arg_13D_0 = 3699456920u;
				while (true)
				{
					uint num;
					switch ((num = (arg_13D_0 ^ 4011696056u)) % 10u)
					{
					case 0u:
						this.pyGenericServices_ = other.pyGenericServices_;
						this.deprecated_ = other.deprecated_;
						arg_13D_0 = (num * 2794081399u ^ 650885576u);
						continue;
					case 1u:
						this.objcClassPrefix_ = other.objcClassPrefix_;
						this.csharpNamespace_ = other.csharpNamespace_;
						arg_13D_0 = (num * 3269346598u ^ 2584151079u);
						continue;
					case 2u:
						this.javaStringCheckUtf8_ = other.javaStringCheckUtf8_;
						this.optimizeFor_ = other.optimizeFor_;
						this.goPackage_ = other.goPackage_;
						this.ccGenericServices_ = other.ccGenericServices_;
						this.javaGenericServices_ = other.javaGenericServices_;
						arg_13D_0 = (num * 3177611318u ^ 2395420344u);
						continue;
					case 4u:
						goto IL_172;
					case 5u:
						this.javaGenerateEqualsAndHash_ = other.javaGenerateEqualsAndHash_;
						arg_13D_0 = (num * 1490697446u ^ 3224510020u);
						continue;
					case 6u:
						this.ccEnableArenas_ = other.ccEnableArenas_;
						arg_13D_0 = (num * 2437929387u ^ 3889107739u);
						continue;
					case 7u:
						this.javaOuterClassname_ = other.javaOuterClassname_;
						arg_13D_0 = (num * 3969864483u ^ 2403448726u);
						continue;
					case 8u:
						this.javaPackage_ = other.javaPackage_;
						arg_13D_0 = (num * 4058541379u ^ 2307087451u);
						continue;
					case 9u:
						this.javaMultipleFiles_ = other.javaMultipleFiles_;
						arg_13D_0 = (num * 2310486444u ^ 26268829u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.javananoUseDeprecatedPackage_ = other.javananoUseDeprecatedPackage_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		public FileOptions Clone()
		{
			return new FileOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FileOptions);
		}

		public bool Equals(FileOptions other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_385;
			int arg_2D7_0;
			while (true)
			{
				IL_2D2:
				switch ((arg_2D7_0 ^ -14358945) % 37)
				{
				case 0:
					arg_2D7_0 = ((this.JavaGenericServices == other.JavaGenericServices) ? -1864428598 : -2105066054);
					continue;
				case 1:
					arg_2D7_0 = ((this.Deprecated == other.Deprecated) ? -1632895157 : -323340606);
					continue;
				case 2:
					arg_2D7_0 = (FileOptions.smethod_0(this.GoPackage, other.GoPackage) ? -2034242803 : -1069666560);
					continue;
				case 3:
					return false;
				case 5:
					return false;
				case 6:
					arg_2D7_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? -1491137352 : -7972449);
					continue;
				case 7:
					arg_2D7_0 = ((this.JavaMultipleFiles == other.JavaMultipleFiles) ? -1669724294 : -798085604);
					continue;
				case 8:
					arg_2D7_0 = ((this.PyGenericServices == other.PyGenericServices) ? -1103831699 : -1629784047);
					continue;
				case 9:
					arg_2D7_0 = ((this.JavaStringCheckUtf8 == other.JavaStringCheckUtf8) ? -1540564709 : -950726753);
					continue;
				case 10:
					arg_2D7_0 = ((this.OptimizeFor != other.OptimizeFor) ? -887641052 : -2103995888);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					arg_2D7_0 = ((this.JavaGenerateEqualsAndHash == other.JavaGenerateEqualsAndHash) ? -510593811 : -2131416989);
					continue;
				case 15:
					return false;
				case 16:
					return false;
				case 17:
					return false;
				case 18:
					arg_2D7_0 = ((!FileOptions.smethod_0(this.CsharpNamespace, other.CsharpNamespace)) ? -1742490141 : -1026194228);
					continue;
				case 19:
					arg_2D7_0 = ((this.CcEnableArenas != other.CcEnableArenas) ? -706770821 : -2076340971);
					continue;
				case 20:
					return false;
				case 21:
					return false;
				case 22:
					arg_2D7_0 = (FileOptions.smethod_0(this.JavaOuterClassname, other.JavaOuterClassname) ? -1334332757 : -1706121219);
					continue;
				case 23:
					arg_2D7_0 = ((this.CcGenericServices == other.CcGenericServices) ? -1219661411 : -1631780937);
					continue;
				case 24:
					arg_2D7_0 = (FileOptions.smethod_0(this.ObjcClassPrefix, other.ObjcClassPrefix) ? -688349786 : -1325123485);
					continue;
				case 25:
					return false;
				case 26:
					goto IL_71;
				case 27:
					arg_2D7_0 = ((!FileOptions.smethod_0(this.JavaPackage, other.JavaPackage)) ? -1854018957 : -344043150);
					continue;
				case 28:
					return false;
				case 29:
					return false;
				case 30:
					return true;
				case 31:
					return false;
				case 32:
					return false;
				case 33:
					arg_2D7_0 = ((this.JavananoUseDeprecatedPackage != other.JavananoUseDeprecatedPackage) ? -31574012 : -1024496936);
					continue;
				case 34:
					return false;
				case 35:
					return false;
				case 36:
					goto IL_385;
				}
				break;
			}
			return true;
			IL_71:
			arg_2D7_0 = -1253410400;
			goto IL_2D2;
			IL_385:
			arg_2D7_0 = ((other != this) ? -1584527349 : -247390548);
			goto IL_2D2;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_4CD:
				uint arg_440_0 = 3054931591u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_440_0 ^ 3727032411u)) % 32u)
					{
					case 0u:
						arg_440_0 = (this.Deprecated ? 3566793495u : 2868469955u);
						continue;
					case 1u:
						arg_440_0 = ((FileOptions.smethod_1(this.JavaOuterClassname) == 0) ? 3424890789u : 3054161553u);
						continue;
					case 2u:
						num ^= this.JavaMultipleFiles.GetHashCode();
						arg_440_0 = (num2 * 4118580042u ^ 1381998818u);
						continue;
					case 3u:
						arg_440_0 = ((this.ObjcClassPrefix.Length != 0) ? 3758972436u : 3749471590u);
						continue;
					case 4u:
						arg_440_0 = ((!this.JavaStringCheckUtf8) ? 2335695592u : 4084422397u);
						continue;
					case 5u:
						num ^= this.OptimizeFor.GetHashCode();
						arg_440_0 = (num2 * 168927034u ^ 1142916749u);
						continue;
					case 6u:
						num ^= this.JavaStringCheckUtf8.GetHashCode();
						arg_440_0 = (num2 * 1832672235u ^ 2067558026u);
						continue;
					case 7u:
						num ^= this.CsharpNamespace.GetHashCode();
						arg_440_0 = (num2 * 1345151362u ^ 1352282378u);
						continue;
					case 8u:
						num ^= FileOptions.smethod_2(this.JavaPackage);
						arg_440_0 = (num2 * 1769616302u ^ 774175850u);
						continue;
					case 9u:
						num ^= this.PyGenericServices.GetHashCode();
						arg_440_0 = (num2 * 87160363u ^ 1426080472u);
						continue;
					case 10u:
						num ^= FileOptions.smethod_2(this.JavaOuterClassname);
						arg_440_0 = (num2 * 1335565481u ^ 4204999935u);
						continue;
					case 11u:
						num ^= this.JavaGenericServices.GetHashCode();
						arg_440_0 = (num2 * 2691774918u ^ 3874858184u);
						continue;
					case 12u:
						num ^= this.Deprecated.GetHashCode();
						arg_440_0 = (num2 * 3499264190u ^ 1185518251u);
						continue;
					case 13u:
						arg_440_0 = ((!this.JavaGenerateEqualsAndHash) ? 3596614527u : 3287787874u);
						continue;
					case 14u:
						num ^= this.CcGenericServices.GetHashCode();
						arg_440_0 = (num2 * 2011528017u ^ 1592066510u);
						continue;
					case 15u:
						num ^= this.ObjcClassPrefix.GetHashCode();
						arg_440_0 = (num2 * 789489759u ^ 3996234295u);
						continue;
					case 16u:
						num ^= this.CcEnableArenas.GetHashCode();
						arg_440_0 = (num2 * 1708378246u ^ 1774077592u);
						continue;
					case 17u:
						arg_440_0 = ((!this.PyGenericServices) ? 3831788699u : 2943814674u);
						continue;
					case 18u:
						goto IL_4CD;
					case 19u:
						arg_440_0 = ((this.OptimizeFor == FileOptions.Types.OptimizeMode.SPEED) ? 4202198127u : 2686626494u);
						continue;
					case 20u:
						arg_440_0 = ((this.GoPackage.Length == 0) ? 2233822222u : 3900945953u);
						continue;
					case 21u:
						arg_440_0 = ((!this.CcGenericServices) ? 3643487712u : 3438487957u);
						continue;
					case 23u:
						num ^= this.JavananoUseDeprecatedPackage.GetHashCode();
						arg_440_0 = (num2 * 1922535752u ^ 3895202677u);
						continue;
					case 24u:
						arg_440_0 = ((!this.CcEnableArenas) ? 2447150072u : 3488967627u);
						continue;
					case 25u:
						num ^= this.JavaGenerateEqualsAndHash.GetHashCode();
						arg_440_0 = (num2 * 3151279314u ^ 1903370173u);
						continue;
					case 26u:
						num ^= this.GoPackage.GetHashCode();
						arg_440_0 = (num2 * 638072727u ^ 552057848u);
						continue;
					case 27u:
						arg_440_0 = (this.JavaGenericServices ? 2652333456u : 2458667722u);
						continue;
					case 28u:
						arg_440_0 = (((FileOptions.smethod_1(this.JavaPackage) == 0) ? 125268490u : 584386051u) ^ num2 * 996227132u);
						continue;
					case 29u:
						arg_440_0 = ((this.CsharpNamespace.Length != 0) ? 3719187452u : 3164700868u);
						continue;
					case 30u:
						arg_440_0 = ((!this.JavaMultipleFiles) ? 3116815158u : 4128404089u);
						continue;
					case 31u:
						arg_440_0 = (this.JavananoUseDeprecatedPackage ? 2653627276u : 3202598925u);
						continue;
					}
					goto Block_16;
				}
			}
			Block_16:
			return num ^ this.uninterpretedOption_.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (FileOptions.smethod_1(this.JavaPackage) != 0)
			{
				goto IL_449;
			}
			goto IL_5D3;
			uint arg_517_0;
			while (true)
			{
				IL_512:
				uint num;
				switch ((num = (arg_517_0 ^ 4107030139u)) % 40u)
				{
				case 0u:
					output.WriteRawTag(176, 2);
					output.WriteBool(this.JavananoUseDeprecatedPackage);
					arg_517_0 = (num * 3161429805u ^ 769857917u);
					continue;
				case 1u:
					output.WriteRawTag(72);
					arg_517_0 = (num * 3199340475u ^ 3358855179u);
					continue;
				case 2u:
					arg_517_0 = ((!this.JavaGenerateEqualsAndHash) ? 3981438951u : 2715206325u);
					continue;
				case 3u:
					goto IL_5D3;
				case 4u:
					output.WriteRawTag(66);
					output.WriteString(this.JavaOuterClassname);
					arg_517_0 = (num * 2016470747u ^ 156063458u);
					continue;
				case 5u:
					arg_517_0 = ((!this.JavaGenericServices) ? 2228571641u : 2895497377u);
					continue;
				case 6u:
					this.uninterpretedOption_.WriteTo(output, FileOptions._repeated_uninterpretedOption_codec);
					arg_517_0 = 3352685310u;
					continue;
				case 7u:
					goto IL_449;
				case 8u:
					arg_517_0 = ((FileOptions.smethod_1(this.CsharpNamespace) != 0) ? 2984480886u : 2958414994u);
					continue;
				case 9u:
					arg_517_0 = ((FileOptions.smethod_1(this.GoPackage) != 0) ? 2581130411u : 3318016216u);
					continue;
				case 10u:
					arg_517_0 = ((!this.PyGenericServices) ? 3776279609u : 3313781672u);
					continue;
				case 11u:
					arg_517_0 = (this.CcGenericServices ? 2736085129u : 2523978446u);
					continue;
				case 12u:
					output.WriteRawTag(10);
					output.WriteString(this.JavaPackage);
					arg_517_0 = (num * 2861689898u ^ 3175365696u);
					continue;
				case 14u:
					output.WriteString(this.ObjcClassPrefix);
					arg_517_0 = (num * 2401669990u ^ 2370131063u);
					continue;
				case 15u:
					arg_517_0 = ((!this.CcEnableArenas) ? 3881840821u : 3298108052u);
					continue;
				case 16u:
					output.WriteRawTag(184, 1);
					output.WriteBool(this.Deprecated);
					arg_517_0 = (num * 2888545465u ^ 3413407347u);
					continue;
				case 17u:
					output.WriteBool(this.JavaGenerateEqualsAndHash);
					arg_517_0 = (num * 4044386215u ^ 2653888368u);
					continue;
				case 18u:
					output.WriteRawTag(128, 1);
					output.WriteBool(this.CcGenericServices);
					arg_517_0 = (num * 1519610219u ^ 2506818536u);
					continue;
				case 19u:
					output.WriteEnum((int)this.OptimizeFor);
					arg_517_0 = (num * 1855625696u ^ 3446184612u);
					continue;
				case 20u:
					output.WriteBool(this.JavaGenericServices);
					arg_517_0 = (num * 4158766783u ^ 2662040365u);
					continue;
				case 21u:
					output.WriteRawTag(170, 2);
					arg_517_0 = (num * 4022688936u ^ 1557287844u);
					continue;
				case 22u:
					output.WriteRawTag(160, 1);
					arg_517_0 = (num * 4004576273u ^ 2614983236u);
					continue;
				case 23u:
					output.WriteString(this.CsharpNamespace);
					arg_517_0 = (num * 1982792960u ^ 2147641234u);
					continue;
				case 24u:
					output.WriteRawTag(90);
					arg_517_0 = (num * 3713449671u ^ 2766564274u);
					continue;
				case 25u:
					output.WriteString(this.GoPackage);
					arg_517_0 = (num * 206340982u ^ 2449856030u);
					continue;
				case 26u:
					output.WriteRawTag(216, 1);
					arg_517_0 = (num * 784962148u ^ 3190100920u);
					continue;
				case 27u:
					output.WriteRawTag(144, 1);
					output.WriteBool(this.PyGenericServices);
					arg_517_0 = (num * 1599128722u ^ 3211635311u);
					continue;
				case 28u:
					arg_517_0 = (this.Deprecated ? 3047388771u : 3282837291u);
					continue;
				case 29u:
					arg_517_0 = ((this.OptimizeFor != FileOptions.Types.OptimizeMode.SPEED) ? 3391902466u : 2829709572u);
					continue;
				case 30u:
					output.WriteBool(this.CcEnableArenas);
					arg_517_0 = (num * 3243846320u ^ 639611413u);
					continue;
				case 31u:
					arg_517_0 = (this.JavaMultipleFiles ? 2502895726u : 4192440202u);
					continue;
				case 32u:
					arg_517_0 = (this.JavaStringCheckUtf8 ? 3645898217u : 3613255868u);
					continue;
				case 33u:
					arg_517_0 = (this.JavananoUseDeprecatedPackage ? 4062101595u : 2840904413u);
					continue;
				case 34u:
					output.WriteRawTag(136, 1);
					arg_517_0 = (num * 3257727279u ^ 2015950929u);
					continue;
				case 35u:
					output.WriteBool(this.JavaStringCheckUtf8);
					arg_517_0 = (num * 479560116u ^ 3886776576u);
					continue;
				case 36u:
					output.WriteRawTag(162, 2);
					arg_517_0 = (num * 4068579550u ^ 2729370829u);
					continue;
				case 37u:
					output.WriteRawTag(80);
					output.WriteBool(this.JavaMultipleFiles);
					arg_517_0 = (num * 2005676695u ^ 1148116969u);
					continue;
				case 38u:
					arg_517_0 = ((FileOptions.smethod_1(this.ObjcClassPrefix) != 0) ? 2545001863u : 2347881155u);
					continue;
				case 39u:
					output.WriteRawTag(248, 1);
					arg_517_0 = (num * 475851229u ^ 4208822102u);
					continue;
				}
				break;
			}
			return;
			IL_449:
			arg_517_0 = 4196606559u;
			goto IL_512;
			IL_5D3:
			arg_517_0 = ((FileOptions.smethod_1(this.JavaOuterClassname) == 0) ? 3681032342u : 3528293863u);
			goto IL_512;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (FileOptions.smethod_1(this.JavaPackage) != 0)
			{
				goto IL_12C;
			}
			goto IL_436;
			uint arg_39E_0;
			while (true)
			{
				IL_399:
				uint num2;
				switch ((num2 = (arg_39E_0 ^ 472093227u)) % 31u)
				{
				case 0u:
					arg_39E_0 = (this.JavaGenerateEqualsAndHash ? 615646398u : 396854703u);
					continue;
				case 1u:
					arg_39E_0 = ((!this.CcGenericServices) ? 726072051u : 1783260077u);
					continue;
				case 2u:
					arg_39E_0 = ((FileOptions.smethod_1(this.ObjcClassPrefix) != 0) ? 325121962u : 1349641303u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OptimizeFor);
					arg_39E_0 = (num2 * 2706436363u ^ 3350373602u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.JavaOuterClassname);
					arg_39E_0 = (num2 * 1128461876u ^ 372865063u);
					continue;
				case 5u:
					arg_39E_0 = ((!this.Deprecated) ? 1372630663u : 1616277965u);
					continue;
				case 6u:
					num += 3;
					arg_39E_0 = (num2 * 1438036822u ^ 637349879u);
					continue;
				case 7u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.GoPackage);
					arg_39E_0 = (num2 * 165847461u ^ 3970159389u);
					continue;
				case 8u:
					num += 2;
					arg_39E_0 = (num2 * 2511576928u ^ 4260411188u);
					continue;
				case 9u:
					num += 2 + CodedOutputStream.ComputeStringSize(this.ObjcClassPrefix);
					arg_39E_0 = (num2 * 1653485560u ^ 2282416047u);
					continue;
				case 10u:
					arg_39E_0 = ((this.OptimizeFor != FileOptions.Types.OptimizeMode.SPEED) ? 1778577342u : 1233849989u);
					continue;
				case 11u:
					num += 3;
					arg_39E_0 = (num2 * 3019892277u ^ 3519001336u);
					continue;
				case 12u:
					arg_39E_0 = (this.JavaStringCheckUtf8 ? 1623827364u : 1321995875u);
					continue;
				case 13u:
					num += 3;
					arg_39E_0 = (num2 * 1447378001u ^ 2794094613u);
					continue;
				case 14u:
					arg_39E_0 = (this.CcEnableArenas ? 815255659u : 423982677u);
					continue;
				case 15u:
					num += 3;
					arg_39E_0 = (num2 * 311884859u ^ 4102959733u);
					continue;
				case 16u:
					num += 3;
					arg_39E_0 = (num2 * 3060332220u ^ 56645636u);
					continue;
				case 17u:
					num += 3;
					arg_39E_0 = (num2 * 2157314535u ^ 483927053u);
					continue;
				case 18u:
					arg_39E_0 = ((FileOptions.smethod_1(this.GoPackage) == 0) ? 338888092u : 1967095942u);
					continue;
				case 19u:
					arg_39E_0 = ((!this.JavaMultipleFiles) ? 474280980u : 944978640u);
					continue;
				case 20u:
					goto IL_12C;
				case 21u:
					num += 2 + CodedOutputStream.ComputeStringSize(this.CsharpNamespace);
					arg_39E_0 = (num2 * 2171900663u ^ 323579783u);
					continue;
				case 22u:
					arg_39E_0 = ((!this.JavaGenericServices) ? 315259017u : 825024105u);
					continue;
				case 24u:
					num += 3;
					arg_39E_0 = (num2 * 3526288216u ^ 3304089495u);
					continue;
				case 25u:
					arg_39E_0 = (this.JavananoUseDeprecatedPackage ? 867899814u : 615171850u);
					continue;
				case 26u:
					goto IL_436;
				case 27u:
					arg_39E_0 = (this.PyGenericServices ? 1238186814u : 321257832u);
					continue;
				case 28u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.JavaPackage);
					arg_39E_0 = (num2 * 2903031154u ^ 3938549496u);
					continue;
				case 29u:
					num += 3;
					arg_39E_0 = (num2 * 2765718040u ^ 4174435001u);
					continue;
				case 30u:
					arg_39E_0 = ((FileOptions.smethod_1(this.CsharpNamespace) == 0) ? 1528983486u : 147822692u);
					continue;
				}
				break;
			}
			return num + this.uninterpretedOption_.CalculateSize(FileOptions._repeated_uninterpretedOption_codec);
			IL_12C:
			arg_39E_0 = 655880409u;
			goto IL_399;
			IL_436:
			arg_39E_0 = ((FileOptions.smethod_1(this.JavaOuterClassname) == 0) ? 317340731u : 1513382856u);
			goto IL_399;
		}

		public void MergeFrom(FileOptions other)
		{
			if (other == null)
			{
				goto IL_2D6;
			}
			goto IL_4A7;
			uint arg_403_0;
			while (true)
			{
				IL_3FE:
				uint num;
				switch ((num = (arg_403_0 ^ 1487676515u)) % 34u)
				{
				case 0u:
					this.JavaGenericServices = other.JavaGenericServices;
					arg_403_0 = (num * 2123924742u ^ 1878923867u);
					continue;
				case 1u:
					arg_403_0 = ((FileOptions.smethod_1(other.ObjcClassPrefix) != 0) ? 2143321658u : 1224742496u);
					continue;
				case 2u:
					arg_403_0 = (other.CcGenericServices ? 1371818819u : 1562162610u);
					continue;
				case 3u:
					this.ObjcClassPrefix = other.ObjcClassPrefix;
					arg_403_0 = (num * 3839346914u ^ 3522977010u);
					continue;
				case 4u:
					this.CcEnableArenas = other.CcEnableArenas;
					arg_403_0 = (num * 3486379121u ^ 4240685430u);
					continue;
				case 5u:
					arg_403_0 = ((other.OptimizeFor != FileOptions.Types.OptimizeMode.SPEED) ? 2087821255u : 626856196u);
					continue;
				case 6u:
					arg_403_0 = ((!other.JavaGenerateEqualsAndHash) ? 318508805u : 209052651u);
					continue;
				case 7u:
					arg_403_0 = ((!other.JavaMultipleFiles) ? 1647476571u : 1170434223u);
					continue;
				case 8u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_403_0 = 133977349u;
					continue;
				case 9u:
					goto IL_2D6;
				case 10u:
					arg_403_0 = ((!other.JavaStringCheckUtf8) ? 905040586u : 1812757396u);
					continue;
				case 11u:
					this.JavananoUseDeprecatedPackage = other.JavananoUseDeprecatedPackage;
					arg_403_0 = (num * 1056757099u ^ 2045719862u);
					continue;
				case 12u:
					this.JavaMultipleFiles = other.JavaMultipleFiles;
					arg_403_0 = (num * 3483423202u ^ 2940610371u);
					continue;
				case 13u:
					goto IL_4A7;
				case 14u:
					return;
				case 15u:
					this.PyGenericServices = other.PyGenericServices;
					arg_403_0 = (num * 2991953393u ^ 972932842u);
					continue;
				case 17u:
					this.CsharpNamespace = other.CsharpNamespace;
					arg_403_0 = (num * 3892787552u ^ 2435128310u);
					continue;
				case 18u:
					this.CcGenericServices = other.CcGenericServices;
					arg_403_0 = (num * 104936879u ^ 1503208274u);
					continue;
				case 19u:
					this.Deprecated = other.Deprecated;
					arg_403_0 = (num * 1861593658u ^ 2904542668u);
					continue;
				case 20u:
					arg_403_0 = ((!other.Deprecated) ? 1159621286u : 1543506202u);
					continue;
				case 21u:
					arg_403_0 = ((FileOptions.smethod_1(other.CsharpNamespace) == 0) ? 1228692246u : 1759264086u);
					continue;
				case 22u:
					this.JavaPackage = other.JavaPackage;
					arg_403_0 = (num * 4071121228u ^ 950516163u);
					continue;
				case 23u:
					arg_403_0 = (other.CcEnableArenas ? 280095937u : 219635444u);
					continue;
				case 24u:
					this.JavaGenerateEqualsAndHash = other.JavaGenerateEqualsAndHash;
					arg_403_0 = (num * 1492082922u ^ 1395092821u);
					continue;
				case 25u:
					arg_403_0 = ((!other.JavaGenericServices) ? 1386330799u : 1466726429u);
					continue;
				case 26u:
					arg_403_0 = ((FileOptions.smethod_1(other.JavaOuterClassname) == 0) ? 1888652704u : 1559358443u);
					continue;
				case 27u:
					this.JavaStringCheckUtf8 = other.JavaStringCheckUtf8;
					arg_403_0 = (num * 3162683494u ^ 1773934240u);
					continue;
				case 28u:
					arg_403_0 = ((!other.PyGenericServices) ? 1040571133u : 522751716u);
					continue;
				case 29u:
					arg_403_0 = ((FileOptions.smethod_1(other.GoPackage) == 0) ? 436899511u : 1861513774u);
					continue;
				case 30u:
					this.OptimizeFor = other.OptimizeFor;
					arg_403_0 = (num * 3031516219u ^ 1409867720u);
					continue;
				case 31u:
					arg_403_0 = (other.JavananoUseDeprecatedPackage ? 2089620204u : 1793457651u);
					continue;
				case 32u:
					this.JavaOuterClassname = other.JavaOuterClassname;
					arg_403_0 = (num * 584165398u ^ 517707792u);
					continue;
				case 33u:
					this.GoPackage = other.GoPackage;
					arg_403_0 = (num * 3976170818u ^ 2265654893u);
					continue;
				}
				break;
			}
			return;
			IL_2D6:
			arg_403_0 = 1777097739u;
			goto IL_3FE;
			IL_4A7:
			arg_403_0 = ((FileOptions.smethod_1(other.JavaPackage) == 0) ? 1520336035u : 901945899u);
			goto IL_3FE;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_73D:
				uint num;
				uint arg_639_0 = ((num = input.ReadTag()) != 0u) ? 1481035171u : 814191124u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_639_0 ^ 1784681925u)) % 58u)
					{
					case 0u:
						arg_639_0 = (((num > 66u) ? 3383803868u : 3477052452u) ^ num2 * 1216562890u);
						continue;
					case 1u:
						arg_639_0 = ((num == 304u) ? 1007330992u : 1326497753u);
						continue;
					case 2u:
						this.JavaMultipleFiles = input.ReadBool();
						arg_639_0 = 1123045193u;
						continue;
					case 3u:
						arg_639_0 = (((num != 298u) ? 1495462905u : 1780156726u) ^ num2 * 2833675155u);
						continue;
					case 4u:
						this.PyGenericServices = input.ReadBool();
						arg_639_0 = 1067740429u;
						continue;
					case 5u:
						arg_639_0 = ((num == 72u) ? 1237628232u : 910516531u);
						continue;
					case 6u:
						this.JavaGenericServices = input.ReadBool();
						arg_639_0 = 552631142u;
						continue;
					case 7u:
						arg_639_0 = ((num != 136u) ? 623150843u : 1751698619u);
						continue;
					case 8u:
						this.JavaStringCheckUtf8 = input.ReadBool();
						arg_639_0 = 210145347u;
						continue;
					case 9u:
						arg_639_0 = (((num != 128u) ? 627892756u : 1063095069u) ^ num2 * 3054281725u);
						continue;
					case 10u:
						arg_639_0 = (((num == 66u) ? 3985808095u : 3333823721u) ^ num2 * 180666057u);
						continue;
					case 11u:
						this.uninterpretedOption_.AddEntriesFrom(input, FileOptions._repeated_uninterpretedOption_codec);
						arg_639_0 = 1123045193u;
						continue;
					case 12u:
						this.JavaPackage = input.ReadString();
						arg_639_0 = 1123045193u;
						continue;
					case 13u:
						arg_639_0 = 1481035171u;
						continue;
					case 14u:
						this.CcEnableArenas = input.ReadBool();
						arg_639_0 = 1123045193u;
						continue;
					case 15u:
						arg_639_0 = (num2 * 1812005063u ^ 2541931868u);
						continue;
					case 16u:
						this.Deprecated = input.ReadBool();
						arg_639_0 = 158782370u;
						continue;
					case 17u:
						arg_639_0 = (((num > 184u) ? 3443356420u : 3572745443u) ^ num2 * 4156099023u);
						continue;
					case 18u:
						arg_639_0 = (num2 * 3584752328u ^ 2290073100u);
						continue;
					case 19u:
						arg_639_0 = (num2 * 2518802504u ^ 4223181745u);
						continue;
					case 20u:
						arg_639_0 = ((num == 216u) ? 909938089u : 41988212u);
						continue;
					case 21u:
						arg_639_0 = ((num > 128u) ? 1080971906u : 1782486778u);
						continue;
					case 22u:
						arg_639_0 = (num2 * 553956444u ^ 1530898017u);
						continue;
					case 23u:
						this.optimizeFor_ = (FileOptions.Types.OptimizeMode)input.ReadEnum();
						arg_639_0 = 1598314374u;
						continue;
					case 24u:
						arg_639_0 = (((num != 80u) ? 4243281478u : 3097529415u) ^ num2 * 931298296u);
						continue;
					case 25u:
						this.JavananoUseDeprecatedPackage = input.ReadBool();
						arg_639_0 = 581918595u;
						continue;
					case 26u:
						arg_639_0 = (((num == 144u) ? 326403559u : 1063262617u) ^ num2 * 295100008u);
						continue;
					case 27u:
						arg_639_0 = (((num <= 80u) ? 788999598u : 1097371917u) ^ num2 * 2699762051u);
						continue;
					case 28u:
						arg_639_0 = (num2 * 614472465u ^ 161241864u);
						continue;
					case 29u:
						this.JavaGenerateEqualsAndHash = input.ReadBool();
						arg_639_0 = 1123045193u;
						continue;
					case 30u:
						goto IL_73D;
					case 31u:
						arg_639_0 = ((num <= 298u) ? 1531424296u : 1812757836u);
						continue;
					case 32u:
						arg_639_0 = ((num > 248u) ? 1412788794u : 744087158u);
						continue;
					case 34u:
						arg_639_0 = (num2 * 100212448u ^ 2149191100u);
						continue;
					case 35u:
						this.CcGenericServices = input.ReadBool();
						arg_639_0 = 898357315u;
						continue;
					case 36u:
						this.GoPackage = input.ReadString();
						arg_639_0 = 1798296425u;
						continue;
					case 37u:
						this.ObjcClassPrefix = input.ReadString();
						arg_639_0 = 1123045193u;
						continue;
					case 38u:
						arg_639_0 = (num2 * 3839640981u ^ 1604361143u);
						continue;
					case 39u:
						arg_639_0 = (((num == 290u) ? 965117616u : 582760072u) ^ num2 * 3394748258u);
						continue;
					case 40u:
						arg_639_0 = (num2 * 173670205u ^ 781073831u);
						continue;
					case 41u:
						arg_639_0 = (((num == 10u) ? 3369651389u : 3433400795u) ^ num2 * 2027187718u);
						continue;
					case 42u:
						this.JavaOuterClassname = input.ReadString();
						arg_639_0 = 1123045193u;
						continue;
					case 43u:
						arg_639_0 = (((num != 248u) ? 1370132130u : 1830808706u) ^ num2 * 4028253001u);
						continue;
					case 44u:
						arg_639_0 = ((num > 144u) ? 991719635u : 528198876u);
						continue;
					case 45u:
						arg_639_0 = (num2 * 244241819u ^ 1910339285u);
						continue;
					case 46u:
						arg_639_0 = (num2 * 750997511u ^ 2662883837u);
						continue;
					case 47u:
						arg_639_0 = (((num != 90u) ? 2447938451u : 3195576088u) ^ num2 * 1455388163u);
						continue;
					case 48u:
						arg_639_0 = (num2 * 1461000624u ^ 2857137596u);
						continue;
					case 49u:
						input.SkipLastField();
						arg_639_0 = 1123045193u;
						continue;
					case 50u:
						arg_639_0 = (((num == 7994u) ? 3552440826u : 2596849548u) ^ num2 * 1466361092u);
						continue;
					case 51u:
						arg_639_0 = (num2 * 2244766705u ^ 3157373349u);
						continue;
					case 52u:
						arg_639_0 = (num2 * 506482359u ^ 55511473u);
						continue;
					case 53u:
						arg_639_0 = (num2 * 3442224298u ^ 2734764919u);
						continue;
					case 54u:
						arg_639_0 = (((num != 184u) ? 769849608u : 464966367u) ^ num2 * 885462187u);
						continue;
					case 55u:
						arg_639_0 = (num2 * 697800785u ^ 1283018303u);
						continue;
					case 56u:
						this.CsharpNamespace = input.ReadString();
						arg_639_0 = 1123045193u;
						continue;
					case 57u:
						arg_639_0 = (((num == 160u) ? 3679819308u : 4196142373u) ^ num2 * 1342102198u);
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
