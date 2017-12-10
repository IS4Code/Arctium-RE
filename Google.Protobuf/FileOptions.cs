using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class FileOptions : IMessage<FileOptions>, IEquatable<FileOptions>, IDeepCloneable<FileOptions>, IMessage
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

			internal FileOptions cctor>b__80_0()
			{
				return new FileOptions();
			}
		}

		private static readonly MessageParser<FileOptions> _parser = new MessageParser<FileOptions>(new Func<FileOptions>(FileOptions.__c.__9.<.cctor>b__80_0));

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

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

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
				this.javaPackage_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
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
				this.javaOuterClassname_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
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
				this.goPackage_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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
			this.javaPackage_ = other.javaPackage_;
			this.javaOuterClassname_ = other.javaOuterClassname_;
			this.javaMultipleFiles_ = other.javaMultipleFiles_;
			this.javaGenerateEqualsAndHash_ = other.javaGenerateEqualsAndHash_;
			this.javaStringCheckUtf8_ = other.javaStringCheckUtf8_;
			this.optimizeFor_ = other.optimizeFor_;
			this.goPackage_ = other.goPackage_;
			this.ccGenericServices_ = other.ccGenericServices_;
			this.javaGenericServices_ = other.javaGenericServices_;
			this.pyGenericServices_ = other.pyGenericServices_;
			this.deprecated_ = other.deprecated_;
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
				goto IL_18;
			}
			goto IL_2B3;
			int arg_225_0;
			while (true)
			{
				IL_220:
				switch ((arg_225_0 ^ 1485745076) % 29)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_225_0 = ((this.JavaStringCheckUtf8 != other.JavaStringCheckUtf8) ? 1839108915 : 1184970245);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_225_0 = ((this.OptimizeFor != other.OptimizeFor) ? 405351963 : 1868213832);
					continue;
				case 9:
					arg_225_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? 1579890951 : 1507574572);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_225_0 = ((this.CcGenericServices != other.CcGenericServices) ? 1274446639 : 1629596019);
					continue;
				case 14:
					arg_225_0 = ((this.JavaGenerateEqualsAndHash != other.JavaGenerateEqualsAndHash) ? 1207009032 : 1729225393);
					continue;
				case 15:
					arg_225_0 = (FileOptions.smethod_0(this.GoPackage, other.GoPackage) ? 1647226238 : 213992040);
					continue;
				case 16:
					arg_225_0 = ((this.JavaMultipleFiles == other.JavaMultipleFiles) ? 1186531242 : 563523432);
					continue;
				case 17:
					arg_225_0 = ((this.Deprecated != other.Deprecated) ? 180989460 : 440965460);
					continue;
				case 18:
					return true;
				case 19:
					return false;
				case 20:
					arg_225_0 = ((this.JavaGenericServices != other.JavaGenericServices) ? 2088386930 : 471416026);
					continue;
				case 21:
					arg_225_0 = (FileOptions.smethod_0(this.JavaPackage, other.JavaPackage) ? 2003644490 : 1674991711);
					continue;
				case 22:
					arg_225_0 = (FileOptions.smethod_0(this.JavaOuterClassname, other.JavaOuterClassname) ? 1522612394 : 583346868);
					continue;
				case 23:
					return false;
				case 24:
					arg_225_0 = ((this.PyGenericServices != other.PyGenericServices) ? 410946571 : 1049500272);
					continue;
				case 25:
					return false;
				case 26:
					return false;
				case 27:
					goto IL_2B3;
				case 28:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_225_0 = 131402220;
			goto IL_220;
			IL_2B3:
			arg_225_0 = ((other != this) ? 674534373 : 423788006);
			goto IL_220;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_38D:
				uint arg_320_0 = 663101929u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_320_0 ^ 1809467605u)) % 24u)
					{
					case 1u:
						arg_320_0 = ((!this.PyGenericServices) ? 1911295761u : 256869942u);
						continue;
					case 2u:
						arg_320_0 = (this.JavaGenerateEqualsAndHash ? 450896799u : 1664469786u);
						continue;
					case 3u:
						num ^= this.CcGenericServices.GetHashCode();
						arg_320_0 = (num2 * 1372394439u ^ 2336727723u);
						continue;
					case 4u:
						num ^= this.JavaMultipleFiles.GetHashCode();
						arg_320_0 = (num2 * 3270017000u ^ 3043712871u);
						continue;
					case 5u:
						arg_320_0 = ((!this.CcGenericServices) ? 1916106262u : 770212750u);
						continue;
					case 6u:
						arg_320_0 = ((FileOptions.smethod_1(this.JavaOuterClassname) == 0) ? 1417646901u : 37859019u);
						continue;
					case 7u:
						goto IL_38D;
					case 8u:
						arg_320_0 = ((!this.JavaMultipleFiles) ? 1336307271u : 198677793u);
						continue;
					case 9u:
						num ^= this.JavaStringCheckUtf8.GetHashCode();
						arg_320_0 = (num2 * 2491936501u ^ 2545123181u);
						continue;
					case 10u:
						num ^= this.JavaGenerateEqualsAndHash.GetHashCode();
						arg_320_0 = (num2 * 4226992357u ^ 2217869864u);
						continue;
					case 11u:
						arg_320_0 = (this.JavaGenericServices ? 2081305093u : 1054298524u);
						continue;
					case 12u:
						arg_320_0 = (((FileOptions.smethod_1(this.JavaPackage) != 0) ? 3367770252u : 4239152783u) ^ num2 * 979792843u);
						continue;
					case 13u:
						num ^= FileOptions.smethod_2(this.JavaPackage);
						arg_320_0 = (num2 * 1840929975u ^ 2558978192u);
						continue;
					case 14u:
						num ^= this.GoPackage.GetHashCode();
						arg_320_0 = (num2 * 2782481432u ^ 849127840u);
						continue;
					case 15u:
						arg_320_0 = ((!this.JavaStringCheckUtf8) ? 748281944u : 1457983380u);
						continue;
					case 16u:
						num ^= this.JavaGenericServices.GetHashCode();
						arg_320_0 = (num2 * 1783500264u ^ 3506212124u);
						continue;
					case 17u:
						num ^= this.OptimizeFor.GetHashCode();
						arg_320_0 = (num2 * 4019971165u ^ 274145042u);
						continue;
					case 18u:
						arg_320_0 = ((this.GoPackage.Length == 0) ? 1204068336u : 1442442555u);
						continue;
					case 19u:
						num ^= this.PyGenericServices.GetHashCode();
						arg_320_0 = (num2 * 480397157u ^ 2328730526u);
						continue;
					case 20u:
						arg_320_0 = ((!this.Deprecated) ? 441050397u : 1372792194u);
						continue;
					case 21u:
						arg_320_0 = ((this.OptimizeFor == FileOptions.Types.OptimizeMode.SPEED) ? 556066215u : 892257004u);
						continue;
					case 22u:
						num ^= FileOptions.smethod_2(this.JavaOuterClassname);
						arg_320_0 = (num2 * 3397399645u ^ 2535400403u);
						continue;
					case 23u:
						num ^= this.Deprecated.GetHashCode();
						arg_320_0 = (num2 * 2313165723u ^ 1192527280u);
						continue;
					}
					goto Block_12;
				}
			}
			Block_12:
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
				goto IL_1F2;
			}
			goto IL_423;
			uint arg_393_0;
			while (true)
			{
				IL_38E:
				uint num;
				switch ((num = (arg_393_0 ^ 570702566u)) % 29u)
				{
				case 0u:
					arg_393_0 = (this.Deprecated ? 500571351u : 1992830527u);
					continue;
				case 1u:
					output.WriteBool(this.JavaGenericServices);
					arg_393_0 = (num * 353747402u ^ 3668218137u);
					continue;
				case 2u:
					output.WriteRawTag(66);
					arg_393_0 = (num * 866613098u ^ 1963733649u);
					continue;
				case 3u:
					output.WriteRawTag(160, 1);
					output.WriteBool(this.JavaGenerateEqualsAndHash);
					arg_393_0 = (num * 3071447459u ^ 3269539545u);
					continue;
				case 4u:
					output.WriteString(this.JavaPackage);
					arg_393_0 = (num * 4142894039u ^ 4076690698u);
					continue;
				case 5u:
					output.WriteBool(this.CcGenericServices);
					arg_393_0 = (num * 1720445809u ^ 3433311488u);
					continue;
				case 6u:
					output.WriteRawTag(144, 1);
					output.WriteBool(this.PyGenericServices);
					arg_393_0 = (num * 4281892466u ^ 3509885412u);
					continue;
				case 7u:
					arg_393_0 = ((FileOptions.smethod_1(this.GoPackage) == 0) ? 277246880u : 1260726361u);
					continue;
				case 8u:
					output.WriteString(this.JavaOuterClassname);
					arg_393_0 = (num * 182106993u ^ 291733277u);
					continue;
				case 9u:
					output.WriteRawTag(72);
					output.WriteEnum((int)this.OptimizeFor);
					arg_393_0 = (num * 2357675256u ^ 4108565505u);
					continue;
				case 10u:
					output.WriteRawTag(90);
					output.WriteString(this.GoPackage);
					arg_393_0 = (num * 2322583823u ^ 1351187345u);
					continue;
				case 11u:
					arg_393_0 = ((!this.CcGenericServices) ? 688927969u : 806970755u);
					continue;
				case 13u:
					goto IL_423;
				case 14u:
					goto IL_1F2;
				case 15u:
					output.WriteRawTag(128, 1);
					arg_393_0 = (num * 218227789u ^ 975168246u);
					continue;
				case 16u:
					output.WriteRawTag(136, 1);
					arg_393_0 = (num * 3670029748u ^ 987867287u);
					continue;
				case 17u:
					output.WriteBool(this.Deprecated);
					arg_393_0 = (num * 2887058263u ^ 2972615618u);
					continue;
				case 18u:
					output.WriteRawTag(184, 1);
					arg_393_0 = (num * 4278035380u ^ 315297625u);
					continue;
				case 19u:
					arg_393_0 = ((!this.JavaGenericServices) ? 474710427u : 881570165u);
					continue;
				case 20u:
					arg_393_0 = (this.JavaMultipleFiles ? 856730085u : 677061062u);
					continue;
				case 21u:
					output.WriteRawTag(80);
					arg_393_0 = (num * 4177951085u ^ 238180474u);
					continue;
				case 22u:
					output.WriteRawTag(10);
					arg_393_0 = (num * 3324015853u ^ 1718232752u);
					continue;
				case 23u:
					output.WriteRawTag(216, 1);
					output.WriteBool(this.JavaStringCheckUtf8);
					arg_393_0 = (num * 2473351331u ^ 2705569410u);
					continue;
				case 24u:
					arg_393_0 = (this.JavaStringCheckUtf8 ? 362690355u : 569880605u);
					continue;
				case 25u:
					output.WriteBool(this.JavaMultipleFiles);
					arg_393_0 = (num * 3167780863u ^ 3190636515u);
					continue;
				case 26u:
					arg_393_0 = ((!this.JavaGenerateEqualsAndHash) ? 267170122u : 1473629111u);
					continue;
				case 27u:
					arg_393_0 = ((!this.PyGenericServices) ? 1901388844u : 1349740770u);
					continue;
				case 28u:
					arg_393_0 = ((this.OptimizeFor != FileOptions.Types.OptimizeMode.SPEED) ? 483188043u : 210165657u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.WriteTo(output, FileOptions._repeated_uninterpretedOption_codec);
			return;
			IL_1F2:
			arg_393_0 = 121246149u;
			goto IL_38E;
			IL_423:
			arg_393_0 = ((FileOptions.smethod_1(this.JavaOuterClassname) != 0) ? 506695166u : 905451658u);
			goto IL_38E;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (FileOptions.smethod_1(this.JavaPackage) != 0)
			{
				goto IL_2A1;
			}
			goto IL_327;
			uint arg_2AB_0;
			while (true)
			{
				IL_2A6:
				uint num2;
				switch ((num2 = (arg_2AB_0 ^ 2694537478u)) % 24u)
				{
				case 0u:
					goto IL_2A1;
				case 1u:
					arg_2AB_0 = ((this.OptimizeFor != FileOptions.Types.OptimizeMode.SPEED) ? 3696450696u : 3563950619u);
					continue;
				case 2u:
					num += 3;
					arg_2AB_0 = (num2 * 157684125u ^ 60679546u);
					continue;
				case 3u:
					num += 2;
					arg_2AB_0 = (num2 * 1576405620u ^ 3061067611u);
					continue;
				case 4u:
					num += 3;
					arg_2AB_0 = (num2 * 1402994608u ^ 3001192921u);
					continue;
				case 5u:
					arg_2AB_0 = (this.Deprecated ? 3702917300u : 2304196944u);
					continue;
				case 6u:
					num += this.uninterpretedOption_.CalculateSize(FileOptions._repeated_uninterpretedOption_codec);
					arg_2AB_0 = 3613268849u;
					continue;
				case 7u:
					num += 3;
					arg_2AB_0 = (num2 * 1401666183u ^ 3139899326u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.JavaPackage);
					arg_2AB_0 = (num2 * 2070894749u ^ 2577282973u);
					continue;
				case 9u:
					arg_2AB_0 = ((!this.JavaGenerateEqualsAndHash) ? 2149697689u : 2226407802u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.GoPackage);
					arg_2AB_0 = (num2 * 240316018u ^ 1626478185u);
					continue;
				case 11u:
					goto IL_327;
				case 12u:
					num += 3;
					arg_2AB_0 = (num2 * 1703077986u ^ 4173627059u);
					continue;
				case 13u:
					arg_2AB_0 = ((FileOptions.smethod_1(this.GoPackage) != 0) ? 3789882100u : 2319805357u);
					continue;
				case 14u:
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OptimizeFor);
					arg_2AB_0 = (num2 * 2983144822u ^ 2124269423u);
					continue;
				case 15u:
					arg_2AB_0 = ((!this.JavaStringCheckUtf8) ? 2959043935u : 4282790586u);
					continue;
				case 16u:
					arg_2AB_0 = (this.JavaMultipleFiles ? 3069284069u : 3867262855u);
					continue;
				case 17u:
					arg_2AB_0 = ((!this.PyGenericServices) ? 2736306803u : 3462122960u);
					continue;
				case 18u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.JavaOuterClassname);
					arg_2AB_0 = (num2 * 1954627956u ^ 847378462u);
					continue;
				case 19u:
					arg_2AB_0 = ((!this.CcGenericServices) ? 3811513163u : 3753620154u);
					continue;
				case 20u:
					num += 3;
					arg_2AB_0 = (num2 * 1932993627u ^ 344481419u);
					continue;
				case 21u:
					arg_2AB_0 = ((!this.JavaGenericServices) ? 2650498367u : 3717017009u);
					continue;
				case 22u:
					num += 3;
					arg_2AB_0 = (num2 * 2467378091u ^ 440446593u);
					continue;
				}
				break;
			}
			return num;
			IL_2A1:
			arg_2AB_0 = 2685813646u;
			goto IL_2A6;
			IL_327:
			arg_2AB_0 = ((FileOptions.smethod_1(this.JavaOuterClassname) != 0) ? 3372609924u : 3935143158u);
			goto IL_2A6;
		}

		public void MergeFrom(FileOptions other)
		{
			if (other == null)
			{
				goto IL_150;
			}
			goto IL_378;
			uint arg_2F4_0;
			while (true)
			{
				IL_2EF:
				uint num;
				switch ((num = (arg_2F4_0 ^ 1306314829u)) % 26u)
				{
				case 0u:
					arg_2F4_0 = ((other.OptimizeFor != FileOptions.Types.OptimizeMode.SPEED) ? 1761700176u : 1453384122u);
					continue;
				case 1u:
					arg_2F4_0 = ((FileOptions.smethod_1(other.GoPackage) == 0) ? 821125819u : 158596034u);
					continue;
				case 3u:
					arg_2F4_0 = (other.JavaGenerateEqualsAndHash ? 1077693214u : 2076898711u);
					continue;
				case 4u:
					this.CcGenericServices = other.CcGenericServices;
					arg_2F4_0 = (num * 3061461600u ^ 125383318u);
					continue;
				case 5u:
					arg_2F4_0 = ((FileOptions.smethod_1(other.JavaOuterClassname) == 0) ? 1936310734u : 12584239u);
					continue;
				case 6u:
					arg_2F4_0 = ((!other.Deprecated) ? 346587617u : 1488164171u);
					continue;
				case 7u:
					this.JavaGenericServices = other.JavaGenericServices;
					arg_2F4_0 = (num * 3013904442u ^ 4257192610u);
					continue;
				case 8u:
					arg_2F4_0 = (other.CcGenericServices ? 1810921293u : 325882518u);
					continue;
				case 9u:
					this.JavaPackage = other.JavaPackage;
					arg_2F4_0 = (num * 942289745u ^ 270884665u);
					continue;
				case 10u:
					return;
				case 11u:
					arg_2F4_0 = (other.JavaMultipleFiles ? 1787768190u : 1938119644u);
					continue;
				case 12u:
					goto IL_378;
				case 13u:
					arg_2F4_0 = (other.JavaGenericServices ? 700289514u : 1410637172u);
					continue;
				case 14u:
					this.Deprecated = other.Deprecated;
					arg_2F4_0 = (num * 3842631511u ^ 2086110955u);
					continue;
				case 15u:
					goto IL_150;
				case 16u:
					arg_2F4_0 = (other.JavaStringCheckUtf8 ? 1175950165u : 1892489271u);
					continue;
				case 17u:
					arg_2F4_0 = (other.PyGenericServices ? 711881575u : 1493636733u);
					continue;
				case 18u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_2F4_0 = 847983459u;
					continue;
				case 19u:
					this.OptimizeFor = other.OptimizeFor;
					arg_2F4_0 = (num * 1830875565u ^ 1571998755u);
					continue;
				case 20u:
					this.JavaStringCheckUtf8 = other.JavaStringCheckUtf8;
					arg_2F4_0 = (num * 3193660614u ^ 2963852455u);
					continue;
				case 21u:
					this.JavaMultipleFiles = other.JavaMultipleFiles;
					arg_2F4_0 = (num * 3061238674u ^ 2946462666u);
					continue;
				case 22u:
					this.PyGenericServices = other.PyGenericServices;
					arg_2F4_0 = (num * 2747858583u ^ 804718523u);
					continue;
				case 23u:
					this.JavaGenerateEqualsAndHash = other.JavaGenerateEqualsAndHash;
					arg_2F4_0 = (num * 3157914541u ^ 3574693248u);
					continue;
				case 24u:
					this.JavaOuterClassname = other.JavaOuterClassname;
					arg_2F4_0 = (num * 3364620172u ^ 2778480214u);
					continue;
				case 25u:
					this.GoPackage = other.GoPackage;
					arg_2F4_0 = (num * 4021159322u ^ 2036968893u);
					continue;
				}
				break;
			}
			return;
			IL_150:
			arg_2F4_0 = 792409951u;
			goto IL_2EF;
			IL_378:
			arg_2F4_0 = ((FileOptions.smethod_1(other.JavaPackage) != 0) ? 1655194654u : 2035789946u);
			goto IL_2EF;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4DB:
				uint num;
				uint arg_423_0 = ((num = input.ReadTag()) == 0u) ? 4043474749u : 3412207831u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_423_0 ^ 2763291837u)) % 39u)
					{
					case 0u:
						arg_423_0 = (((num == 144u) ? 2241766172u : 3079463944u) ^ num2 * 938291523u);
						continue;
					case 1u:
						this.GoPackage = input.ReadString();
						arg_423_0 = 3434536071u;
						continue;
					case 2u:
						this.optimizeFor_ = (FileOptions.Types.OptimizeMode)input.ReadEnum();
						arg_423_0 = 3444911032u;
						continue;
					case 3u:
						arg_423_0 = (((num <= 72u) ? 806106712u : 1953307803u) ^ num2 * 2273446466u);
						continue;
					case 4u:
						arg_423_0 = (((num != 7994u) ? 4164234963u : 2282210433u) ^ num2 * 2259624047u);
						continue;
					case 5u:
						arg_423_0 = (((num != 90u) ? 1372268570u : 1958917276u) ^ num2 * 450106348u);
						continue;
					case 6u:
						this.CcGenericServices = input.ReadBool();
						arg_423_0 = 4143237926u;
						continue;
					case 7u:
						arg_423_0 = ((num == 184u) ? 2292087258u : 2411371357u);
						continue;
					case 8u:
						arg_423_0 = (num2 * 2695896875u ^ 3378898000u);
						continue;
					case 9u:
						goto IL_4DB;
					case 10u:
						this.JavaGenerateEqualsAndHash = input.ReadBool();
						arg_423_0 = 4129633089u;
						continue;
					case 11u:
						arg_423_0 = (((num == 128u) ? 2429442293u : 2735098950u) ^ num2 * 1599851914u);
						continue;
					case 12u:
						arg_423_0 = (((num == 72u) ? 3506030535u : 2569305374u) ^ num2 * 3922030571u);
						continue;
					case 13u:
						input.SkipLastField();
						arg_423_0 = 3169861217u;
						continue;
					case 14u:
						this.uninterpretedOption_.AddEntriesFrom(input, FileOptions._repeated_uninterpretedOption_codec);
						arg_423_0 = 3434536071u;
						continue;
					case 15u:
						arg_423_0 = (num2 * 3643451977u ^ 2135159867u);
						continue;
					case 16u:
						arg_423_0 = (((num != 136u) ? 1830092195u : 1362167681u) ^ num2 * 1737402218u);
						continue;
					case 17u:
						arg_423_0 = (num2 * 1127398467u ^ 4172562725u);
						continue;
					case 18u:
						arg_423_0 = (num2 * 1273422301u ^ 926690525u);
						continue;
					case 19u:
						this.PyGenericServices = input.ReadBool();
						arg_423_0 = 3434536071u;
						continue;
					case 20u:
						arg_423_0 = ((num == 80u) ? 3908305269u : 2214903548u);
						continue;
					case 21u:
						arg_423_0 = (((num != 10u) ? 206524314u : 1893366698u) ^ num2 * 1088182868u);
						continue;
					case 22u:
						arg_423_0 = (num2 * 2517231981u ^ 4289454968u);
						continue;
					case 23u:
						arg_423_0 = 3412207831u;
						continue;
					case 24u:
						arg_423_0 = (num2 * 3455673022u ^ 1277495695u);
						continue;
					case 25u:
						arg_423_0 = (((num == 66u) ? 2063737596u : 579344230u) ^ num2 * 4240865289u);
						continue;
					case 26u:
						arg_423_0 = ((num <= 160u) ? 3451932250u : 2399423149u);
						continue;
					case 27u:
						this.JavaGenericServices = input.ReadBool();
						arg_423_0 = 3434536071u;
						continue;
					case 29u:
						arg_423_0 = ((num <= 128u) ? 3909762411u : 3988271493u);
						continue;
					case 30u:
						arg_423_0 = (num2 * 4114320067u ^ 4074368436u);
						continue;
					case 31u:
						this.JavaPackage = input.ReadString();
						arg_423_0 = 3434536071u;
						continue;
					case 32u:
						this.Deprecated = input.ReadBool();
						arg_423_0 = 3434536071u;
						continue;
					case 33u:
						this.JavaMultipleFiles = input.ReadBool();
						arg_423_0 = 3434536071u;
						continue;
					case 34u:
						arg_423_0 = (num2 * 3307228200u ^ 1652584367u);
						continue;
					case 35u:
						arg_423_0 = (((num == 216u) ? 2496218907u : 3339873724u) ^ num2 * 3148012058u);
						continue;
					case 36u:
						this.JavaStringCheckUtf8 = input.ReadBool();
						arg_423_0 = 4088775644u;
						continue;
					case 37u:
						arg_423_0 = (((num == 160u) ? 387237504u : 1407463669u) ^ num2 * 223130896u);
						continue;
					case 38u:
						this.JavaOuterClassname = input.ReadString();
						arg_423_0 = 3434536071u;
						continue;
					}
					return;
				}
			}
		}

		static FileOptions()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_5A:
				uint arg_42_0 = 3333105537u;
				while (true)
				{
					uint num;
					switch ((num = (arg_42_0 ^ 3443901100u)) % 3u)
					{
					case 0u:
						goto IL_5A;
					case 1u:
						FileOptions._repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);
						arg_42_0 = (num * 4081440776u ^ 3617123222u);
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
