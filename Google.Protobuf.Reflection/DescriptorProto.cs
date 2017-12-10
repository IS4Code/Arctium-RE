using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class DescriptorProto : IMessage, IMessage<DescriptorProto>, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			[DebuggerNonUserCode]
			internal sealed class ExtensionRange : IMessage, IMessage<DescriptorProto.Types.ExtensionRange>, IEquatable<DescriptorProto.Types.ExtensionRange>, IDeepCloneable<DescriptorProto.Types.ExtensionRange>
			{
				[CompilerGenerated]
				[Serializable]
				private sealed class __c
				{
					public static readonly DescriptorProto.Types.ExtensionRange.__c __9 = new DescriptorProto.Types.ExtensionRange.__c();

					internal DescriptorProto.Types.ExtensionRange cctor>b__29_0()
					{
						return new DescriptorProto.Types.ExtensionRange();
					}
				}

				private static readonly MessageParser<DescriptorProto.Types.ExtensionRange> _parser = new MessageParser<DescriptorProto.Types.ExtensionRange>(new Func<DescriptorProto.Types.ExtensionRange>(DescriptorProto.Types.ExtensionRange.__c.__9.<.cctor>b__29_0));

				public const int StartFieldNumber = 1;

				private int start_;

				public const int EndFieldNumber = 2;

				private int end_;

				public static MessageParser<DescriptorProto.Types.ExtensionRange> Parser
				{
					get
					{
						return DescriptorProto.Types.ExtensionRange._parser;
					}
				}

				public static MessageDescriptor Descriptor
				{
					get
					{
						return DescriptorProto.Descriptor.NestedTypes[0];
					}
				}

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return DescriptorProto.Types.ExtensionRange.Descriptor;
					}
				}

				public int Start
				{
					get
					{
						return this.start_;
					}
					set
					{
						this.start_ = value;
					}
				}

				public int End
				{
					get
					{
						return this.end_;
					}
					set
					{
						this.end_ = value;
					}
				}

				public ExtensionRange()
				{
				}

				public ExtensionRange(DescriptorProto.Types.ExtensionRange other) : this()
				{
					while (true)
					{
						IL_3E:
						uint arg_26_0 = 1739467784u;
						while (true)
						{
							uint num;
							switch ((num = (arg_26_0 ^ 1029643218u)) % 3u)
							{
							case 1u:
								this.start_ = other.start_;
								arg_26_0 = (num * 1597733706u ^ 3794671579u);
								continue;
							case 2u:
								goto IL_3E;
							}
							goto Block_1;
						}
					}
					Block_1:
					this.end_ = other.end_;
				}

				public DescriptorProto.Types.ExtensionRange Clone()
				{
					return new DescriptorProto.Types.ExtensionRange(this);
				}

				public override bool Equals(object other)
				{
					return this.Equals(other as DescriptorProto.Types.ExtensionRange);
				}

				public bool Equals(DescriptorProto.Types.ExtensionRange other)
				{
					if (other == null)
					{
						goto IL_63;
					}
					goto IL_AB;
					int arg_6D_0;
					while (true)
					{
						IL_68:
						switch ((arg_6D_0 ^ -555295860) % 9)
						{
						case 0:
							goto IL_AB;
						case 1:
							return false;
						case 2:
							goto IL_63;
						case 3:
							arg_6D_0 = ((this.End == other.End) ? -88631878 : -1752866596);
							continue;
						case 4:
							return true;
						case 5:
							arg_6D_0 = ((this.Start == other.Start) ? -1784332466 : -1254257531);
							continue;
						case 7:
							return false;
						case 8:
							return false;
						}
						break;
					}
					return true;
					IL_63:
					arg_6D_0 = -1838970218;
					goto IL_68;
					IL_AB:
					arg_6D_0 = ((other == this) ? -1276844413 : -858093);
					goto IL_68;
				}

				public override int GetHashCode()
				{
					int num = 1;
					if (this.Start != 0)
					{
						goto IL_5C;
					}
					goto IL_92;
					uint arg_66_0;
					while (true)
					{
						IL_61:
						uint num2;
						switch ((num2 = (arg_66_0 ^ 3891607265u)) % 5u)
						{
						case 0u:
							goto IL_5C;
						case 1u:
							goto IL_92;
						case 2u:
							num ^= this.Start.GetHashCode();
							arg_66_0 = (num2 * 143938963u ^ 2530580921u);
							continue;
						case 3u:
							num ^= this.End.GetHashCode();
							arg_66_0 = (num2 * 3047187721u ^ 2585560445u);
							continue;
						}
						break;
					}
					return num;
					IL_5C:
					arg_66_0 = 3121468707u;
					goto IL_61;
					IL_92:
					arg_66_0 = ((this.End == 0) ? 4239489920u : 3602230708u);
					goto IL_61;
				}

				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				public void WriteTo(CodedOutputStream output)
				{
					if (this.Start != 0)
					{
						goto IL_62;
					}
					goto IL_BE;
					uint arg_87_0;
					while (true)
					{
						IL_82:
						uint num;
						switch ((num = (arg_87_0 ^ 1268967390u)) % 7u)
						{
						case 0u:
							output.WriteInt32(this.Start);
							arg_87_0 = (num * 395492775u ^ 321963370u);
							continue;
						case 1u:
							goto IL_BE;
						case 2u:
							goto IL_62;
						case 3u:
							output.WriteRawTag(16);
							arg_87_0 = (num * 1844482449u ^ 3374624320u);
							continue;
						case 4u:
							output.WriteInt32(this.End);
							arg_87_0 = (num * 638235529u ^ 523656415u);
							continue;
						case 5u:
							output.WriteRawTag(8);
							arg_87_0 = (num * 2576226262u ^ 2233547870u);
							continue;
						}
						break;
					}
					return;
					IL_62:
					arg_87_0 = 340378728u;
					goto IL_82;
					IL_BE:
					arg_87_0 = ((this.End == 0) ? 1244121103u : 616134704u);
					goto IL_82;
				}

				public int CalculateSize()
				{
					int num = 0;
					if (this.Start != 0)
					{
						goto IL_5A;
					}
					goto IL_90;
					uint arg_64_0;
					while (true)
					{
						IL_5F:
						uint num2;
						switch ((num2 = (arg_64_0 ^ 2617099699u)) % 5u)
						{
						case 0u:
							goto IL_5A;
						case 1u:
							num += 1 + CodedOutputStream.ComputeInt32Size(this.Start);
							arg_64_0 = (num2 * 2561356762u ^ 3054201345u);
							continue;
						case 2u:
							goto IL_90;
						case 4u:
							num += 1 + CodedOutputStream.ComputeInt32Size(this.End);
							arg_64_0 = (num2 * 4181058202u ^ 3439186715u);
							continue;
						}
						break;
					}
					return num;
					IL_5A:
					arg_64_0 = 4142319015u;
					goto IL_5F;
					IL_90:
					arg_64_0 = ((this.End == 0) ? 2429466311u : 4041564693u);
					goto IL_5F;
				}

				public void MergeFrom(DescriptorProto.Types.ExtensionRange other)
				{
					if (other == null)
					{
						goto IL_6C;
					}
					goto IL_AD;
					uint arg_76_0;
					while (true)
					{
						IL_71:
						uint num;
						switch ((num = (arg_76_0 ^ 1494162224u)) % 7u)
						{
						case 0u:
							goto IL_6C;
						case 1u:
							this.Start = other.Start;
							arg_76_0 = (num * 3494911442u ^ 3549775055u);
							continue;
						case 3u:
							return;
						case 4u:
							goto IL_AD;
						case 5u:
							arg_76_0 = ((other.End != 0) ? 1740853993u : 1644290467u);
							continue;
						case 6u:
							this.End = other.End;
							arg_76_0 = (num * 283787251u ^ 2423365208u);
							continue;
						}
						break;
					}
					return;
					IL_6C:
					arg_76_0 = 1990796354u;
					goto IL_71;
					IL_AD:
					arg_76_0 = ((other.Start == 0) ? 1205716805u : 1641804109u);
					goto IL_71;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_103:
						uint num;
						uint arg_BF_0 = ((num = input.ReadTag()) == 0u) ? 691541922u : 205673736u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_BF_0 ^ 868539954u)) % 10u)
							{
							case 0u:
								arg_BF_0 = 205673736u;
								continue;
							case 1u:
								arg_BF_0 = (((num != 16u) ? 2049909693u : 1102000127u) ^ num2 * 4186359012u);
								continue;
							case 2u:
								goto IL_103;
							case 3u:
								arg_BF_0 = (num2 * 872738242u ^ 4202466298u);
								continue;
							case 4u:
								arg_BF_0 = ((num != 8u) ? 176650789u : 317259902u);
								continue;
							case 5u:
								input.SkipLastField();
								arg_BF_0 = (num2 * 2072505220u ^ 1643582543u);
								continue;
							case 6u:
								this.Start = input.ReadInt32();
								arg_BF_0 = 2094360391u;
								continue;
							case 7u:
								this.End = input.ReadInt32();
								arg_BF_0 = 126832720u;
								continue;
							case 9u:
								arg_BF_0 = (num2 * 4035856329u ^ 3349648681u);
								continue;
							}
							return;
						}
					}
				}
			}

			[DebuggerNonUserCode]
			internal sealed class ReservedRange : IMessage, IMessage<DescriptorProto.Types.ReservedRange>, IEquatable<DescriptorProto.Types.ReservedRange>, IDeepCloneable<DescriptorProto.Types.ReservedRange>
			{
				[CompilerGenerated]
				[Serializable]
				private sealed class __c
				{
					public static readonly DescriptorProto.Types.ReservedRange.__c __9 = new DescriptorProto.Types.ReservedRange.__c();

					internal DescriptorProto.Types.ReservedRange cctor>b__29_0()
					{
						return new DescriptorProto.Types.ReservedRange();
					}
				}

				private static readonly MessageParser<DescriptorProto.Types.ReservedRange> _parser = new MessageParser<DescriptorProto.Types.ReservedRange>(new Func<DescriptorProto.Types.ReservedRange>(DescriptorProto.Types.ReservedRange.__c.__9.<.cctor>b__29_0));

				public const int StartFieldNumber = 1;

				private int start_;

				public const int EndFieldNumber = 2;

				private int end_;

				public static MessageParser<DescriptorProto.Types.ReservedRange> Parser
				{
					get
					{
						return DescriptorProto.Types.ReservedRange._parser;
					}
				}

				public static MessageDescriptor Descriptor
				{
					get
					{
						return DescriptorProto.Descriptor.NestedTypes[1];
					}
				}

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return DescriptorProto.Types.ReservedRange.Descriptor;
					}
				}

				public int Start
				{
					get
					{
						return this.start_;
					}
					set
					{
						this.start_ = value;
					}
				}

				public int End
				{
					get
					{
						return this.end_;
					}
					set
					{
						this.end_ = value;
					}
				}

				public ReservedRange()
				{
				}

				public ReservedRange(DescriptorProto.Types.ReservedRange other) : this()
				{
					while (true)
					{
						IL_3E:
						uint arg_26_0 = 1504036284u;
						while (true)
						{
							uint num;
							switch ((num = (arg_26_0 ^ 2074449701u)) % 3u)
							{
							case 0u:
								goto IL_3E;
							case 2u:
								this.start_ = other.start_;
								arg_26_0 = (num * 1859820189u ^ 63783001u);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					this.end_ = other.end_;
				}

				public DescriptorProto.Types.ReservedRange Clone()
				{
					return new DescriptorProto.Types.ReservedRange(this);
				}

				public override bool Equals(object other)
				{
					return this.Equals(other as DescriptorProto.Types.ReservedRange);
				}

				public bool Equals(DescriptorProto.Types.ReservedRange other)
				{
					if (other == null)
					{
						goto IL_15;
					}
					goto IL_AB;
					int arg_6D_0;
					while (true)
					{
						IL_68:
						switch ((arg_6D_0 ^ 868207482) % 9)
						{
						case 0:
							arg_6D_0 = ((this.Start != other.Start) ? 1446644057 : 1833418626);
							continue;
						case 1:
							goto IL_AB;
						case 2:
							return false;
						case 3:
							return false;
						case 4:
							arg_6D_0 = ((this.End != other.End) ? 2137828727 : 656776948);
							continue;
						case 6:
							return true;
						case 7:
							return false;
						case 8:
							goto IL_15;
						}
						break;
					}
					return true;
					IL_15:
					arg_6D_0 = 134045798;
					goto IL_68;
					IL_AB:
					arg_6D_0 = ((other == this) ? 1556229286 : 1601241376);
					goto IL_68;
				}

				public override int GetHashCode()
				{
					int num = 1;
					if (this.Start != 0)
					{
						goto IL_3C;
					}
					goto IL_92;
					uint arg_66_0;
					while (true)
					{
						IL_61:
						uint num2;
						switch ((num2 = (arg_66_0 ^ 1407222453u)) % 5u)
						{
						case 0u:
							num ^= this.End.GetHashCode();
							arg_66_0 = (num2 * 2922600868u ^ 1195797937u);
							continue;
						case 2u:
							goto IL_3C;
						case 3u:
							goto IL_92;
						case 4u:
							num ^= this.Start.GetHashCode();
							arg_66_0 = (num2 * 2458470846u ^ 1934501257u);
							continue;
						}
						break;
					}
					return num;
					IL_3C:
					arg_66_0 = 310522343u;
					goto IL_61;
					IL_92:
					arg_66_0 = ((this.End == 0) ? 2049451777u : 293248377u);
					goto IL_61;
				}

				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				public void WriteTo(CodedOutputStream output)
				{
					if (this.Start != 0)
					{
						goto IL_1A;
					}
					goto IL_AB;
					uint arg_78_0;
					while (true)
					{
						IL_73:
						uint num;
						switch ((num = (arg_78_0 ^ 3099900897u)) % 6u)
						{
						case 0u:
							goto IL_AB;
						case 1u:
							output.WriteRawTag(16);
							output.WriteInt32(this.End);
							arg_78_0 = (num * 4120538908u ^ 2429316942u);
							continue;
						case 2u:
							output.WriteRawTag(8);
							arg_78_0 = (num * 1659929610u ^ 2609415049u);
							continue;
						case 4u:
							output.WriteInt32(this.Start);
							arg_78_0 = (num * 3757644112u ^ 4104468977u);
							continue;
						case 5u:
							goto IL_1A;
						}
						break;
					}
					return;
					IL_1A:
					arg_78_0 = 3614876171u;
					goto IL_73;
					IL_AB:
					arg_78_0 = ((this.End == 0) ? 2781806098u : 2439555344u);
					goto IL_73;
				}

				public int CalculateSize()
				{
					int num = 0;
					while (true)
					{
						IL_B6:
						uint arg_92_0 = 896737828u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_92_0 ^ 111735421u)) % 6u)
							{
							case 1u:
								arg_92_0 = ((this.End != 0) ? 1064325326u : 1322373821u);
								continue;
							case 2u:
								goto IL_B6;
							case 3u:
								arg_92_0 = (((this.Start != 0) ? 681299985u : 828487736u) ^ num2 * 396265936u);
								continue;
							case 4u:
								num += 1 + CodedOutputStream.ComputeInt32Size(this.Start);
								arg_92_0 = (num2 * 1971898209u ^ 4099601620u);
								continue;
							case 5u:
								num += 1 + CodedOutputStream.ComputeInt32Size(this.End);
								arg_92_0 = (num2 * 3399532082u ^ 1277260363u);
								continue;
							}
							return num;
						}
					}
					return num;
				}

				public void MergeFrom(DescriptorProto.Types.ReservedRange other)
				{
					if (other == null)
					{
						goto IL_15;
					}
					goto IL_AD;
					uint arg_76_0;
					while (true)
					{
						IL_71:
						uint num;
						switch ((num = (arg_76_0 ^ 1372738807u)) % 7u)
						{
						case 0u:
							this.Start = other.Start;
							arg_76_0 = (num * 2076763065u ^ 3639838766u);
							continue;
						case 1u:
							return;
						case 2u:
							goto IL_AD;
						case 4u:
							this.End = other.End;
							arg_76_0 = (num * 965331336u ^ 1461406159u);
							continue;
						case 5u:
							arg_76_0 = ((other.End != 0) ? 2137583160u : 683511095u);
							continue;
						case 6u:
							goto IL_15;
						}
						break;
					}
					return;
					IL_15:
					arg_76_0 = 857955314u;
					goto IL_71;
					IL_AD:
					arg_76_0 = ((other.Start != 0) ? 1011948201u : 757298112u);
					goto IL_71;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_ED:
						uint num;
						uint arg_AD_0 = ((num = input.ReadTag()) == 0u) ? 3320721624u : 3447309381u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_AD_0 ^ 4227868972u)) % 9u)
							{
							case 0u:
								this.Start = input.ReadInt32();
								arg_AD_0 = 3494756918u;
								continue;
							case 1u:
								arg_AD_0 = (num2 * 1022882729u ^ 3440160805u);
								continue;
							case 2u:
								input.SkipLastField();
								arg_AD_0 = (num2 * 3650429013u ^ 1028085712u);
								continue;
							case 3u:
								goto IL_ED;
							case 4u:
								arg_AD_0 = 3447309381u;
								continue;
							case 5u:
								arg_AD_0 = ((num != 8u) ? 2404422357u : 2148825140u);
								continue;
							case 7u:
								arg_AD_0 = (((num != 16u) ? 3420300013u : 2656986637u) ^ num2 * 1548837938u);
								continue;
							case 8u:
								this.End = input.ReadInt32();
								arg_AD_0 = 4003680783u;
								continue;
							}
							return;
						}
					}
				}
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly DescriptorProto.__c __9 = new DescriptorProto.__c();

			internal DescriptorProto cctor>b__70_0()
			{
				return new DescriptorProto();
			}
		}

		private static readonly MessageParser<DescriptorProto> _parser = new MessageParser<DescriptorProto>(new Func<DescriptorProto>(DescriptorProto.__c.__9.<.cctor>b__70_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int FieldFieldNumber = 2;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec;

		private readonly RepeatedField<FieldDescriptorProto> field_ = new RepeatedField<FieldDescriptorProto>();

		public const int ExtensionFieldNumber = 6;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		private readonly RepeatedField<FieldDescriptorProto> extension_ = new RepeatedField<FieldDescriptorProto>();

		public const int NestedTypeFieldNumber = 3;

		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec;

		private readonly RepeatedField<DescriptorProto> nestedType_ = new RepeatedField<DescriptorProto>();

		public const int EnumTypeFieldNumber = 4;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		private readonly RepeatedField<EnumDescriptorProto> enumType_ = new RepeatedField<EnumDescriptorProto>();

		public const int ExtensionRangeFieldNumber = 5;

		private static readonly FieldCodec<DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec;

		private readonly RepeatedField<DescriptorProto.Types.ExtensionRange> extensionRange_ = new RepeatedField<DescriptorProto.Types.ExtensionRange>();

		public const int OneofDeclFieldNumber = 8;

		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec;

		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_ = new RepeatedField<OneofDescriptorProto>();

		public const int OptionsFieldNumber = 7;

		private MessageOptions options_;

		public const int ReservedRangeFieldNumber = 9;

		private static readonly FieldCodec<DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec;

		private readonly RepeatedField<DescriptorProto.Types.ReservedRange> reservedRange_ = new RepeatedField<DescriptorProto.Types.ReservedRange>();

		public const int ReservedNameFieldNumber = 10;

		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		private readonly RepeatedField<string> reservedName_ = new RepeatedField<string>();

		public static MessageParser<DescriptorProto> Parser
		{
			get
			{
				return DescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DescriptorProto.Descriptor;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public RepeatedField<FieldDescriptorProto> Field
		{
			get
			{
				return this.field_;
			}
		}

		public RepeatedField<FieldDescriptorProto> Extension
		{
			get
			{
				return this.extension_;
			}
		}

		public RepeatedField<DescriptorProto> NestedType
		{
			get
			{
				return this.nestedType_;
			}
		}

		public RepeatedField<EnumDescriptorProto> EnumType
		{
			get
			{
				return this.enumType_;
			}
		}

		public RepeatedField<DescriptorProto.Types.ExtensionRange> ExtensionRange
		{
			get
			{
				return this.extensionRange_;
			}
		}

		public RepeatedField<OneofDescriptorProto> OneofDecl
		{
			get
			{
				return this.oneofDecl_;
			}
		}

		public MessageOptions Options
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

		public RepeatedField<DescriptorProto.Types.ReservedRange> ReservedRange
		{
			get
			{
				return this.reservedRange_;
			}
		}

		public RepeatedField<string> ReservedName
		{
			get
			{
				return this.reservedName_;
			}
		}

		public DescriptorProto()
		{
		}

		public DescriptorProto(DescriptorProto other) : this()
		{
			while (true)
			{
				IL_16F:
				uint arg_13A_0 = 3737671997u;
				while (true)
				{
					uint num;
					switch ((num = (arg_13A_0 ^ 2786279119u)) % 10u)
					{
					case 0u:
						this.extensionRange_ = other.extensionRange_.Clone();
						this.oneofDecl_ = other.oneofDecl_.Clone();
						arg_13A_0 = (num * 1426891333u ^ 713787488u);
						continue;
					case 1u:
						this.enumType_ = other.enumType_.Clone();
						arg_13A_0 = (num * 559222720u ^ 1786004353u);
						continue;
					case 2u:
						this.nestedType_ = other.nestedType_.Clone();
						arg_13A_0 = (num * 2915151401u ^ 2420237946u);
						continue;
					case 3u:
						this.reservedRange_ = other.reservedRange_.Clone();
						arg_13A_0 = (num * 2114701566u ^ 1811555524u);
						continue;
					case 4u:
						this.name_ = other.name_;
						this.field_ = other.field_.Clone();
						arg_13A_0 = (num * 1953943978u ^ 508941505u);
						continue;
					case 5u:
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_13A_0 = 4148131276u;
						continue;
					case 7u:
						this.reservedName_ = other.reservedName_.Clone();
						arg_13A_0 = (num * 648981813u ^ 2260134944u);
						continue;
					case 8u:
						this.extension_ = other.extension_.Clone();
						arg_13A_0 = (num * 668153040u ^ 2807106685u);
						continue;
					case 9u:
						goto IL_16F;
					}
					return;
				}
			}
		}

		public DescriptorProto Clone()
		{
			return new DescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as DescriptorProto);
		}

		public bool Equals(DescriptorProto other)
		{
			if (other == null)
			{
				goto IL_1E8;
			}
			goto IL_270;
			int arg_1F2_0;
			while (true)
			{
				IL_1ED:
				switch ((arg_1F2_0 ^ -13444949) % 25)
				{
				case 0:
					goto IL_1E8;
				case 1:
					return false;
				case 3:
					arg_1F2_0 = (this.nestedType_.Equals(other.nestedType_) ? -353159325 : -1408254852);
					continue;
				case 4:
					goto IL_270;
				case 5:
					arg_1F2_0 = ((!DescriptorProto.smethod_0(this.Name, other.Name)) ? -1412534110 : -2056085986);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_1F2_0 = ((!this.field_.Equals(other.field_)) ? -156160738 : -2022672407);
					continue;
				case 9:
					return true;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_1F2_0 = ((!this.extension_.Equals(other.extension_)) ? -1587793142 : -265113774);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_1F2_0 = ((!this.reservedName_.Equals(other.reservedName_)) ? -1849367812 : -1783867394);
					continue;
				case 16:
					arg_1F2_0 = (this.oneofDecl_.Equals(other.oneofDecl_) ? -143251309 : -1414010705);
					continue;
				case 17:
					return false;
				case 18:
					arg_1F2_0 = (this.enumType_.Equals(other.enumType_) ? -1465930270 : -800022172);
					continue;
				case 19:
					arg_1F2_0 = ((!this.reservedRange_.Equals(other.reservedRange_)) ? -1088876042 : -1819593568);
					continue;
				case 20:
					arg_1F2_0 = ((!this.extensionRange_.Equals(other.extensionRange_)) ? -1932542572 : -759641179);
					continue;
				case 21:
					return false;
				case 22:
					arg_1F2_0 = ((!DescriptorProto.smethod_1(this.Options, other.Options)) ? -1638814308 : -286414215);
					continue;
				case 23:
					return false;
				case 24:
					return false;
				}
				break;
			}
			return true;
			IL_1E8:
			arg_1F2_0 = -1759673879;
			goto IL_1ED;
			IL_270:
			arg_1F2_0 = ((other == this) ? -775247756 : -876351615);
			goto IL_1ED;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_164:
				uint arg_12F_0 = 2387537914u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_12F_0 ^ 2397943059u)) % 10u)
					{
					case 0u:
						num ^= DescriptorProto.smethod_3(this.field_);
						arg_12F_0 = 2520580176u;
						continue;
					case 1u:
						arg_12F_0 = (((DescriptorProto.smethod_2(this.Name) != 0) ? 1224643848u : 1074282747u) ^ num2 * 3698746314u);
						continue;
					case 2u:
						arg_12F_0 = (((this.options_ == null) ? 1690788017u : 57501650u) ^ num2 * 4209557736u);
						continue;
					case 3u:
						goto IL_164;
					case 4u:
						num ^= DescriptorProto.smethod_3(this.oneofDecl_);
						arg_12F_0 = (num2 * 3601486886u ^ 2538200169u);
						continue;
					case 5u:
						num ^= DescriptorProto.smethod_3(this.extension_);
						arg_12F_0 = (num2 * 374613136u ^ 700422539u);
						continue;
					case 7u:
						num ^= DescriptorProto.smethod_3(this.Name);
						arg_12F_0 = (num2 * 1660191895u ^ 3558513142u);
						continue;
					case 8u:
						num ^= DescriptorProto.smethod_3(this.nestedType_);
						num ^= DescriptorProto.smethod_3(this.enumType_);
						num ^= DescriptorProto.smethod_3(this.extensionRange_);
						arg_12F_0 = (num2 * 677873243u ^ 2855109465u);
						continue;
					case 9u:
						num ^= DescriptorProto.smethod_3(this.Options);
						arg_12F_0 = (num2 * 3943070392u ^ 3523316345u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			num ^= DescriptorProto.smethod_3(this.reservedRange_);
			return num ^ DescriptorProto.smethod_3(this.reservedName_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (DescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_DE;
			}
			goto IL_17C;
			uint arg_143_0;
			while (true)
			{
				IL_13E:
				uint num;
				switch ((num = (arg_143_0 ^ 2203887120u)) % 11u)
				{
				case 0u:
					arg_143_0 = (((this.options_ != null) ? 1111936241u : 1359058969u) ^ num * 2958987195u);
					continue;
				case 1u:
					output.WriteMessage(this.Options);
					arg_143_0 = (num * 2076001967u ^ 34687644u);
					continue;
				case 2u:
					output.WriteRawTag(58);
					arg_143_0 = (num * 1400042682u ^ 1370014920u);
					continue;
				case 3u:
					goto IL_DE;
				case 4u:
					this.extension_.WriteTo(output, DescriptorProto._repeated_extension_codec);
					arg_143_0 = (num * 2552293976u ^ 367891599u);
					continue;
				case 5u:
					this.reservedRange_.WriteTo(output, DescriptorProto._repeated_reservedRange_codec);
					arg_143_0 = (num * 3363857388u ^ 502170472u);
					continue;
				case 6u:
					this.nestedType_.WriteTo(output, DescriptorProto._repeated_nestedType_codec);
					this.enumType_.WriteTo(output, DescriptorProto._repeated_enumType_codec);
					this.extensionRange_.WriteTo(output, DescriptorProto._repeated_extensionRange_codec);
					arg_143_0 = (num * 2406257607u ^ 4156160412u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_143_0 = (num * 2196176410u ^ 939245272u);
					continue;
				case 8u:
					this.oneofDecl_.WriteTo(output, DescriptorProto._repeated_oneofDecl_codec);
					arg_143_0 = 2979185796u;
					continue;
				case 10u:
					goto IL_17C;
				}
				break;
			}
			this.reservedName_.WriteTo(output, DescriptorProto._repeated_reservedName_codec);
			return;
			IL_DE:
			arg_143_0 = 3837893268u;
			goto IL_13E;
			IL_17C:
			this.field_.WriteTo(output, DescriptorProto._repeated_field_codec);
			arg_143_0 = 3357667102u;
			goto IL_13E;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (DescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_AD;
			}
			goto IL_159;
			uint arg_128_0;
			while (true)
			{
				IL_123:
				uint num2;
				switch ((num2 = (arg_128_0 ^ 1643899310u)) % 9u)
				{
				case 0u:
					arg_128_0 = (((this.options_ == null) ? 1253809631u : 1887571869u) ^ num2 * 1893566793u);
					continue;
				case 2u:
					num += this.extension_.CalculateSize(DescriptorProto._repeated_extension_codec);
					num += this.nestedType_.CalculateSize(DescriptorProto._repeated_nestedType_codec);
					num += this.enumType_.CalculateSize(DescriptorProto._repeated_enumType_codec);
					arg_128_0 = (num2 * 2211218012u ^ 1952878928u);
					continue;
				case 3u:
					goto IL_AD;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
					arg_128_0 = (num2 * 708983735u ^ 726272458u);
					continue;
				case 5u:
					num += this.extensionRange_.CalculateSize(DescriptorProto._repeated_extensionRange_codec);
					num += this.oneofDecl_.CalculateSize(DescriptorProto._repeated_oneofDecl_codec);
					arg_128_0 = (num2 * 3112164580u ^ 4135329366u);
					continue;
				case 6u:
					goto IL_159;
				case 7u:
					num += this.reservedRange_.CalculateSize(DescriptorProto._repeated_reservedRange_codec);
					arg_128_0 = 144729181u;
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_128_0 = (num2 * 3680429301u ^ 102458601u);
					continue;
				}
				break;
			}
			return num + this.reservedName_.CalculateSize(DescriptorProto._repeated_reservedName_codec);
			IL_AD:
			arg_128_0 = 1548641655u;
			goto IL_123;
			IL_159:
			num += this.field_.CalculateSize(DescriptorProto._repeated_field_codec);
			arg_128_0 = 697977197u;
			goto IL_123;
		}

		public void MergeFrom(DescriptorProto other)
		{
			if (other == null)
			{
				goto IL_C8;
			}
			goto IL_21C;
			uint arg_1C0_0;
			while (true)
			{
				IL_1BB:
				uint num;
				switch ((num = (arg_1C0_0 ^ 3915493789u)) % 16u)
				{
				case 0u:
					this.oneofDecl_.Add(other.oneofDecl_);
					arg_1C0_0 = (num * 13623282u ^ 1340552521u);
					continue;
				case 1u:
					goto IL_21C;
				case 2u:
					arg_1C0_0 = (((this.options_ == null) ? 1258400576u : 1058104754u) ^ num * 4284462880u);
					continue;
				case 3u:
					this.extensionRange_.Add(other.extensionRange_);
					arg_1C0_0 = (num * 3486938875u ^ 1516595884u);
					continue;
				case 4u:
					arg_1C0_0 = (((other.options_ != null) ? 1266426187u : 1793881135u) ^ num * 43656649u);
					continue;
				case 5u:
					this.field_.Add(other.field_);
					arg_1C0_0 = 3311910545u;
					continue;
				case 6u:
					this.reservedRange_.Add(other.reservedRange_);
					arg_1C0_0 = 2682857223u;
					continue;
				case 7u:
					this.enumType_.Add(other.enumType_);
					arg_1C0_0 = (num * 616861944u ^ 2823835670u);
					continue;
				case 8u:
					goto IL_C8;
				case 9u:
					this.Name = other.Name;
					arg_1C0_0 = (num * 2802454334u ^ 431911590u);
					continue;
				case 10u:
					this.reservedName_.Add(other.reservedName_);
					arg_1C0_0 = (num * 4081544135u ^ 3249970512u);
					continue;
				case 12u:
					this.extension_.Add(other.extension_);
					this.nestedType_.Add(other.nestedType_);
					arg_1C0_0 = (num * 3436774974u ^ 2247095042u);
					continue;
				case 13u:
					this.options_ = new MessageOptions();
					arg_1C0_0 = (num * 1116099728u ^ 3506084770u);
					continue;
				case 14u:
					return;
				case 15u:
					this.Options.MergeFrom(other.Options);
					arg_1C0_0 = 2558415451u;
					continue;
				}
				break;
			}
			return;
			IL_C8:
			arg_1C0_0 = 2443984611u;
			goto IL_1BB;
			IL_21C:
			arg_1C0_0 = ((DescriptorProto.smethod_2(other.Name) == 0) ? 3309215592u : 3420477988u);
			goto IL_1BB;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4C7:
				uint num;
				uint arg_40F_0 = ((num = input.ReadTag()) != 0u) ? 409487760u : 1015295542u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_40F_0 ^ 398292297u)) % 39u)
					{
					case 0u:
						arg_40F_0 = ((num == 66u) ? 1121199748u : 233340508u);
						continue;
					case 1u:
						this.reservedRange_.AddEntriesFrom(input, DescriptorProto._repeated_reservedRange_codec);
						arg_40F_0 = 1634119795u;
						continue;
					case 2u:
						arg_40F_0 = ((num == 26u) ? 2134431617u : 1463871134u);
						continue;
					case 4u:
						this.options_ = new MessageOptions();
						arg_40F_0 = (num2 * 915210700u ^ 3130450510u);
						continue;
					case 5u:
						goto IL_4C7;
					case 6u:
						arg_40F_0 = (num2 * 1027170764u ^ 1456887935u);
						continue;
					case 7u:
						arg_40F_0 = ((num > 42u) ? 834867009u : 1903098882u);
						continue;
					case 8u:
						arg_40F_0 = (((num != 10u) ? 2526953912u : 3014714427u) ^ num2 * 836508119u);
						continue;
					case 9u:
						arg_40F_0 = (num2 * 3558257500u ^ 156646595u);
						continue;
					case 10u:
						arg_40F_0 = ((this.options_ != null) ? 2147225322u : 1951846330u);
						continue;
					case 11u:
						arg_40F_0 = (((num == 74u) ? 755341932u : 885041801u) ^ num2 * 3990539562u);
						continue;
					case 12u:
						arg_40F_0 = (num2 * 1736596172u ^ 2039505311u);
						continue;
					case 13u:
						this.oneofDecl_.AddEntriesFrom(input, DescriptorProto._repeated_oneofDecl_codec);
						arg_40F_0 = 347103625u;
						continue;
					case 14u:
						arg_40F_0 = (((num == 18u) ? 3627191998u : 2641144805u) ^ num2 * 361776240u);
						continue;
					case 15u:
						arg_40F_0 = (((num > 18u) ? 3192232106u : 3517302928u) ^ num2 * 438208700u);
						continue;
					case 16u:
						this.enumType_.AddEntriesFrom(input, DescriptorProto._repeated_enumType_codec);
						arg_40F_0 = 426014743u;
						continue;
					case 17u:
						arg_40F_0 = (((num != 42u) ? 3565152621u : 2444123715u) ^ num2 * 3807718048u);
						continue;
					case 18u:
						this.field_.AddEntriesFrom(input, DescriptorProto._repeated_field_codec);
						arg_40F_0 = 1749832799u;
						continue;
					case 19u:
						arg_40F_0 = (num2 * 3467395013u ^ 2730783669u);
						continue;
					case 20u:
						this.Name = input.ReadString();
						arg_40F_0 = 130494874u;
						continue;
					case 21u:
						this.extension_.AddEntriesFrom(input, DescriptorProto._repeated_extension_codec);
						arg_40F_0 = 426014743u;
						continue;
					case 22u:
						arg_40F_0 = (num2 * 1285189599u ^ 1666188596u);
						continue;
					case 23u:
						arg_40F_0 = 409487760u;
						continue;
					case 24u:
						arg_40F_0 = (num2 * 379803861u ^ 2787130327u);
						continue;
					case 25u:
						this.extensionRange_.AddEntriesFrom(input, DescriptorProto._repeated_extensionRange_codec);
						arg_40F_0 = 438713382u;
						continue;
					case 26u:
						this.reservedName_.AddEntriesFrom(input, DescriptorProto._repeated_reservedName_codec);
						arg_40F_0 = 426014743u;
						continue;
					case 27u:
						arg_40F_0 = ((num > 58u) ? 956065016u : 1063231596u);
						continue;
					case 28u:
						arg_40F_0 = (num2 * 3814297419u ^ 3395830288u);
						continue;
					case 29u:
						this.nestedType_.AddEntriesFrom(input, DescriptorProto._repeated_nestedType_codec);
						arg_40F_0 = 1867896759u;
						continue;
					case 30u:
						arg_40F_0 = (num2 * 2371190266u ^ 2585492136u);
						continue;
					case 31u:
						arg_40F_0 = (num2 * 2521033165u ^ 3688501372u);
						continue;
					case 32u:
						input.SkipLastField();
						arg_40F_0 = 1845758972u;
						continue;
					case 33u:
						arg_40F_0 = (((num == 50u) ? 2340288310u : 3921155832u) ^ num2 * 2971252505u);
						continue;
					case 34u:
						arg_40F_0 = (((num == 34u) ? 1117987169u : 698760861u) ^ num2 * 3045455260u);
						continue;
					case 35u:
						input.ReadMessage(this.options_);
						arg_40F_0 = 426014743u;
						continue;
					case 36u:
						arg_40F_0 = (((num == 58u) ? 4105672045u : 3881325873u) ^ num2 * 571056719u);
						continue;
					case 37u:
						arg_40F_0 = (num2 * 2543368684u ^ 3477377347u);
						continue;
					case 38u:
						arg_40F_0 = (((num != 82u) ? 2972497918u : 3890191386u) ^ num2 * 1505327063u);
						continue;
					}
					return;
				}
			}
		}

		static DescriptorProto()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_12E:
				uint arg_102_0 = 914933774u;
				while (true)
				{
					uint num;
					switch ((num = (arg_102_0 ^ 424027527u)) % 8u)
					{
					case 0u:
						DescriptorProto._repeated_reservedName_codec = FieldCodec.ForString(82u);
						arg_102_0 = (num * 1359367408u ^ 1865633553u);
						continue;
					case 1u:
						DescriptorProto._repeated_field_codec = FieldCodec.ForMessage<FieldDescriptorProto>(18u, FieldDescriptorProto.Parser);
						arg_102_0 = (num * 2109606014u ^ 2093563732u);
						continue;
					case 2u:
						goto IL_12E;
					case 3u:
						DescriptorProto._repeated_reservedRange_codec = FieldCodec.ForMessage<DescriptorProto.Types.ReservedRange>(74u, DescriptorProto.Types.ReservedRange.Parser);
						arg_102_0 = (num * 2377833491u ^ 1525932254u);
						continue;
					case 4u:
						DescriptorProto._repeated_oneofDecl_codec = FieldCodec.ForMessage<OneofDescriptorProto>(66u, OneofDescriptorProto.Parser);
						arg_102_0 = (num * 3096480944u ^ 4055953380u);
						continue;
					case 5u:
						DescriptorProto._repeated_extension_codec = FieldCodec.ForMessage<FieldDescriptorProto>(50u, FieldDescriptorProto.Parser);
						DescriptorProto._repeated_nestedType_codec = FieldCodec.ForMessage<DescriptorProto>(26u, DescriptorProto.Parser);
						DescriptorProto._repeated_enumType_codec = FieldCodec.ForMessage<EnumDescriptorProto>(34u, EnumDescriptorProto.Parser);
						arg_102_0 = (num * 1052581341u ^ 287246001u);
						continue;
					case 7u:
						DescriptorProto._repeated_extensionRange_codec = FieldCodec.ForMessage<DescriptorProto.Types.ExtensionRange>(42u, DescriptorProto.Types.ExtensionRange.Parser);
						arg_102_0 = (num * 610251679u ^ 1004358850u);
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
