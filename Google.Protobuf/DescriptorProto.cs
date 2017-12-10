using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class DescriptorProto : IMessage<DescriptorProto>, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			[DebuggerNonUserCode]
			internal sealed class ExtensionRange : IMessage<DescriptorProto.Types.ExtensionRange>, IEquatable<DescriptorProto.Types.ExtensionRange>, IDeepCloneable<DescriptorProto.Types.ExtensionRange>, IMessage
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
						IL_4A:
						uint arg_32_0 = 3580077551u;
						while (true)
						{
							uint num;
							switch ((num = (arg_32_0 ^ 3312480114u)) % 3u)
							{
							case 1u:
								this.start_ = other.start_;
								this.end_ = other.end_;
								arg_32_0 = (num * 1984968941u ^ 1916133270u);
								continue;
							case 2u:
								goto IL_4A;
							}
							return;
						}
					}
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
						switch ((arg_6D_0 ^ -820746025) % 9)
						{
						case 0:
							goto IL_AB;
						case 1:
							return false;
						case 2:
							goto IL_63;
						case 3:
							return false;
						case 4:
							arg_6D_0 = ((this.End != other.End) ? -2146257056 : -925492087);
							continue;
						case 5:
							return true;
						case 7:
							arg_6D_0 = ((this.Start != other.Start) ? -1885684364 : -555266228);
							continue;
						case 8:
							return false;
						}
						break;
					}
					return true;
					IL_63:
					arg_6D_0 = -1725424017;
					goto IL_68;
					IL_AB:
					arg_6D_0 = ((other != this) ? -2086901594 : -844595038);
					goto IL_68;
				}

				public override int GetHashCode()
				{
					int num = 1;
					while (true)
					{
						IL_B8:
						uint arg_94_0 = 2780518959u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_94_0 ^ 3191626884u)) % 6u)
							{
							case 0u:
								goto IL_B8;
							case 1u:
								num ^= this.Start.GetHashCode();
								arg_94_0 = (num2 * 3585920570u ^ 1697210827u);
								continue;
							case 3u:
								arg_94_0 = (((this.Start == 0) ? 1953183978u : 2063074806u) ^ num2 * 2669491809u);
								continue;
							case 4u:
								num ^= this.End.GetHashCode();
								arg_94_0 = (num2 * 1056975766u ^ 3249388444u);
								continue;
							case 5u:
								arg_94_0 = ((this.End == 0) ? 3688196304u : 3319735478u);
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
					if (this.Start != 0)
					{
						goto IL_4C;
					}
					goto IL_BE;
					uint arg_87_0;
					while (true)
					{
						IL_82:
						uint num;
						switch ((num = (arg_87_0 ^ 2558673973u)) % 7u)
						{
						case 0u:
							output.WriteInt32(this.End);
							arg_87_0 = (num * 1078497601u ^ 1175681491u);
							continue;
						case 1u:
							output.WriteRawTag(8);
							arg_87_0 = (num * 4244478541u ^ 2774833388u);
							continue;
						case 2u:
							goto IL_4C;
						case 3u:
							output.WriteInt32(this.Start);
							arg_87_0 = (num * 4044301929u ^ 1626924624u);
							continue;
						case 4u:
							goto IL_BE;
						case 5u:
							output.WriteRawTag(16);
							arg_87_0 = (num * 3296568415u ^ 3865425179u);
							continue;
						}
						break;
					}
					return;
					IL_4C:
					arg_87_0 = 3640988978u;
					goto IL_82;
					IL_BE:
					arg_87_0 = ((this.End == 0) ? 4091317099u : 2946072095u);
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
						switch ((num2 = (arg_64_0 ^ 2294297653u)) % 5u)
						{
						case 0u:
							goto IL_5A;
						case 1u:
							num += 1 + CodedOutputStream.ComputeInt32Size(this.Start);
							arg_64_0 = (num2 * 2965579311u ^ 3280985325u);
							continue;
						case 3u:
							num += 1 + CodedOutputStream.ComputeInt32Size(this.End);
							arg_64_0 = (num2 * 1126898946u ^ 1656968638u);
							continue;
						case 4u:
							goto IL_90;
						}
						break;
					}
					return num;
					IL_5A:
					arg_64_0 = 3483054291u;
					goto IL_5F;
					IL_90:
					arg_64_0 = ((this.End == 0) ? 3136078798u : 4250872589u);
					goto IL_5F;
				}

				public void MergeFrom(DescriptorProto.Types.ExtensionRange other)
				{
					if (other == null)
					{
						goto IL_51;
					}
					goto IL_AD;
					uint arg_76_0;
					while (true)
					{
						IL_71:
						uint num;
						switch ((num = (arg_76_0 ^ 257236096u)) % 7u)
						{
						case 1u:
							return;
						case 2u:
							goto IL_AD;
						case 3u:
							this.End = other.End;
							arg_76_0 = (num * 3476656831u ^ 4046810049u);
							continue;
						case 4u:
							goto IL_51;
						case 5u:
							this.Start = other.Start;
							arg_76_0 = (num * 1047509236u ^ 2053535008u);
							continue;
						case 6u:
							arg_76_0 = ((other.End != 0) ? 1588774565u : 580169818u);
							continue;
						}
						break;
					}
					return;
					IL_51:
					arg_76_0 = 1835440376u;
					goto IL_71;
					IL_AD:
					arg_76_0 = ((other.Start == 0) ? 241999244u : 1284826119u);
					goto IL_71;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_D9:
						uint num;
						uint arg_9E_0 = ((num = input.ReadTag()) != 0u) ? 123760098u : 340881777u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_9E_0 ^ 2069247364u)) % 8u)
							{
							case 0u:
								input.SkipLastField();
								arg_9E_0 = (num2 * 3109966835u ^ 1634015013u);
								continue;
							case 1u:
								goto IL_D9;
							case 2u:
								this.End = input.ReadInt32();
								arg_9E_0 = 651504541u;
								continue;
							case 3u:
								this.Start = input.ReadInt32();
								arg_9E_0 = 651504541u;
								continue;
							case 4u:
								arg_9E_0 = (((num == 16u) ? 3653100894u : 3502071340u) ^ num2 * 176730384u);
								continue;
							case 6u:
								arg_9E_0 = ((num != 8u) ? 730284952u : 1349205327u);
								continue;
							case 7u:
								arg_9E_0 = 123760098u;
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

			internal DescriptorProto cctor>b__60_0()
			{
				return new DescriptorProto();
			}
		}

		private static readonly MessageParser<DescriptorProto> _parser = new MessageParser<DescriptorProto>(new Func<DescriptorProto>(DescriptorProto.__c.__9.<.cctor>b__60_0));

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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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

		public DescriptorProto()
		{
		}

		public DescriptorProto(DescriptorProto other) : this()
		{
			this.name_ = other.name_;
			this.field_ = other.field_.Clone();
			this.extension_ = other.extension_.Clone();
			this.nestedType_ = other.nestedType_.Clone();
			this.enumType_ = other.enumType_.Clone();
			this.extensionRange_ = other.extensionRange_.Clone();
			this.oneofDecl_ = other.oneofDecl_.Clone();
			this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
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
				goto IL_76;
			}
			goto IL_202;
			int arg_194_0;
			while (true)
			{
				IL_18F:
				switch ((arg_194_0 ^ 1272619472) % 21)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_194_0 = ((!this.oneofDecl_.Equals(other.oneofDecl_)) ? 2078274049 : 264309249);
					continue;
				case 3:
					return true;
				case 4:
					arg_194_0 = ((!DescriptorProto.smethod_0(this.Name, other.Name)) ? 2048948999 : 1170699933);
					continue;
				case 5:
					goto IL_202;
				case 6:
					return false;
				case 7:
					arg_194_0 = ((!DescriptorProto.smethod_1(this.Options, other.Options)) ? 635457826 : 982849708);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					arg_194_0 = (this.extension_.Equals(other.extension_) ? 856943527 : 464817879);
					continue;
				case 11:
					return false;
				case 12:
					arg_194_0 = (this.field_.Equals(other.field_) ? 179850000 : 172238156);
					continue;
				case 13:
					arg_194_0 = (this.nestedType_.Equals(other.nestedType_) ? 503460632 : 562814912);
					continue;
				case 14:
					return false;
				case 16:
					goto IL_76;
				case 17:
					arg_194_0 = (this.extensionRange_.Equals(other.extensionRange_) ? 1738494431 : 1855341069);
					continue;
				case 18:
					return false;
				case 19:
					return false;
				case 20:
					arg_194_0 = ((!this.enumType_.Equals(other.enumType_)) ? 1331457126 : 1980584694);
					continue;
				}
				break;
			}
			return true;
			IL_76:
			arg_194_0 = 561646862;
			goto IL_18F;
			IL_202:
			arg_194_0 = ((other == this) ? 1937704644 : 550600715);
			goto IL_18F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_14E:
				uint arg_11D_0 = 292611357u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_11D_0 ^ 1644907272u)) % 9u)
					{
					case 0u:
						num ^= DescriptorProto.smethod_3(this.Name);
						arg_11D_0 = (num2 * 2419318705u ^ 873704460u);
						continue;
					case 1u:
						arg_11D_0 = (((DescriptorProto.smethod_2(this.Name) != 0) ? 591439680u : 1724063796u) ^ num2 * 2402713777u);
						continue;
					case 2u:
						arg_11D_0 = (((this.options_ == null) ? 2910234623u : 3011106858u) ^ num2 * 2878395464u);
						continue;
					case 3u:
						num ^= DescriptorProto.smethod_3(this.enumType_);
						num ^= DescriptorProto.smethod_3(this.extensionRange_);
						arg_11D_0 = (num2 * 3607733367u ^ 3396166285u);
						continue;
					case 4u:
						num ^= DescriptorProto.smethod_3(this.oneofDecl_);
						arg_11D_0 = (num2 * 2905326813u ^ 2300092912u);
						continue;
					case 5u:
						goto IL_14E;
					case 7u:
						num ^= DescriptorProto.smethod_3(this.field_);
						num ^= DescriptorProto.smethod_3(this.extension_);
						num ^= DescriptorProto.smethod_3(this.nestedType_);
						arg_11D_0 = 1024545617u;
						continue;
					case 8u:
						num ^= DescriptorProto.smethod_3(this.Options);
						arg_11D_0 = (num2 * 2167445785u ^ 259142541u);
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
			if (DescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_9D;
			}
			goto IL_125;
			uint arg_F9_0;
			while (true)
			{
				IL_F4:
				uint num;
				switch ((num = (arg_F9_0 ^ 1380886249u)) % 8u)
				{
				case 0u:
					output.WriteRawTag(58);
					arg_F9_0 = (num * 3903705093u ^ 2606529127u);
					continue;
				case 2u:
					this.oneofDecl_.WriteTo(output, DescriptorProto._repeated_oneofDecl_codec);
					arg_F9_0 = 1298599872u;
					continue;
				case 3u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_F9_0 = (num * 4273463212u ^ 891032528u);
					continue;
				case 4u:
					goto IL_9D;
				case 5u:
					goto IL_125;
				case 6u:
					output.WriteMessage(this.Options);
					arg_F9_0 = (num * 4011476582u ^ 2911732887u);
					continue;
				case 7u:
					this.nestedType_.WriteTo(output, DescriptorProto._repeated_nestedType_codec);
					this.enumType_.WriteTo(output, DescriptorProto._repeated_enumType_codec);
					this.extensionRange_.WriteTo(output, DescriptorProto._repeated_extensionRange_codec);
					this.extension_.WriteTo(output, DescriptorProto._repeated_extension_codec);
					arg_F9_0 = (((this.options_ == null) ? 2913162548u : 4289190750u) ^ num * 2185416361u);
					continue;
				}
				break;
			}
			return;
			IL_9D:
			arg_F9_0 = 1892936346u;
			goto IL_F4;
			IL_125:
			this.field_.WriteTo(output, DescriptorProto._repeated_field_codec);
			arg_F9_0 = 1763663670u;
			goto IL_F4;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (DescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_9A;
			}
			goto IL_14B;
			uint arg_11A_0;
			while (true)
			{
				IL_115:
				uint num2;
				switch ((num2 = (arg_11A_0 ^ 234700641u)) % 9u)
				{
				case 0u:
					num += this.nestedType_.CalculateSize(DescriptorProto._repeated_nestedType_codec);
					num += this.enumType_.CalculateSize(DescriptorProto._repeated_enumType_codec);
					arg_11A_0 = (num2 * 901751045u ^ 3233857168u);
					continue;
				case 1u:
					goto IL_14B;
				case 2u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_11A_0 = (num2 * 3706851503u ^ 1544335696u);
					continue;
				case 3u:
					num += this.extensionRange_.CalculateSize(DescriptorProto._repeated_extensionRange_codec);
					arg_11A_0 = (num2 * 2379446004u ^ 1129849892u);
					continue;
				case 4u:
					goto IL_9A;
				case 5u:
					num += this.oneofDecl_.CalculateSize(DescriptorProto._repeated_oneofDecl_codec);
					arg_11A_0 = (((this.options_ != null) ? 1913281033u : 2117958754u) ^ num2 * 2556608639u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
					arg_11A_0 = (num2 * 2234966633u ^ 1446791266u);
					continue;
				case 8u:
					num += this.extension_.CalculateSize(DescriptorProto._repeated_extension_codec);
					arg_11A_0 = (num2 * 3297273507u ^ 1521020661u);
					continue;
				}
				break;
			}
			return num;
			IL_9A:
			arg_11A_0 = 184420792u;
			goto IL_115;
			IL_14B:
			num += this.field_.CalculateSize(DescriptorProto._repeated_field_codec);
			arg_11A_0 = 521291075u;
			goto IL_115;
		}

		public void MergeFrom(DescriptorProto other)
		{
			if (other == null)
			{
				goto IL_163;
			}
			goto IL_1BD;
			uint arg_16D_0;
			while (true)
			{
				IL_168:
				uint num;
				switch ((num = (arg_16D_0 ^ 2347292674u)) % 13u)
				{
				case 0u:
					goto IL_163;
				case 1u:
					this.field_.Add(other.field_);
					arg_16D_0 = 3873166709u;
					continue;
				case 2u:
					return;
				case 3u:
					this.Options.MergeFrom(other.Options);
					arg_16D_0 = 2682599840u;
					continue;
				case 4u:
					this.extension_.Add(other.extension_);
					this.nestedType_.Add(other.nestedType_);
					this.enumType_.Add(other.enumType_);
					arg_16D_0 = (num * 4293805498u ^ 2383043474u);
					continue;
				case 5u:
					goto IL_1BD;
				case 6u:
					this.options_ = new MessageOptions();
					arg_16D_0 = (num * 955065949u ^ 1423452240u);
					continue;
				case 7u:
					this.oneofDecl_.Add(other.oneofDecl_);
					arg_16D_0 = (num * 2178831324u ^ 3500342588u);
					continue;
				case 8u:
					arg_16D_0 = (((this.options_ != null) ? 3835910596u : 2750712974u) ^ num * 2596314786u);
					continue;
				case 9u:
					this.extensionRange_.Add(other.extensionRange_);
					arg_16D_0 = (num * 1160625397u ^ 2906773108u);
					continue;
				case 11u:
					this.Name = other.Name;
					arg_16D_0 = (num * 4016300485u ^ 2180500426u);
					continue;
				case 12u:
					arg_16D_0 = (((other.options_ != null) ? 1212144423u : 1032667466u) ^ num * 834638491u);
					continue;
				}
				break;
			}
			return;
			IL_163:
			arg_16D_0 = 4152115582u;
			goto IL_168;
			IL_1BD:
			arg_16D_0 = ((DescriptorProto.smethod_2(other.Name) == 0) ? 2867657384u : 2324993016u);
			goto IL_168;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3F0:
				uint num;
				uint arg_354_0 = ((num = input.ReadTag()) == 0u) ? 153875435u : 1126066364u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_354_0 ^ 1430567159u)) % 32u)
					{
					case 0u:
						arg_354_0 = (((num == 18u) ? 4081539266u : 2394529891u) ^ num2 * 1086135964u);
						continue;
					case 1u:
						arg_354_0 = (num2 * 3202435107u ^ 3693961353u);
						continue;
					case 2u:
						arg_354_0 = (num2 * 3153139116u ^ 3190717522u);
						continue;
					case 3u:
						this.oneofDecl_.AddEntriesFrom(input, DescriptorProto._repeated_oneofDecl_codec);
						arg_354_0 = 1350218506u;
						continue;
					case 4u:
						arg_354_0 = (((num == 34u) ? 4032918355u : 2766907753u) ^ num2 * 3010484411u);
						continue;
					case 5u:
						arg_354_0 = ((num <= 50u) ? 1141702476u : 1833242052u);
						continue;
					case 6u:
						arg_354_0 = (num2 * 2900007877u ^ 773551060u);
						continue;
					case 7u:
						this.options_ = new MessageOptions();
						arg_354_0 = (num2 * 3650175264u ^ 3384080457u);
						continue;
					case 8u:
						this.enumType_.AddEntriesFrom(input, DescriptorProto._repeated_enumType_codec);
						arg_354_0 = 1350218506u;
						continue;
					case 9u:
						arg_354_0 = (((num <= 18u) ? 3809506346u : 3830788666u) ^ num2 * 4014580463u);
						continue;
					case 10u:
						arg_354_0 = ((num == 26u) ? 1657650744u : 743455059u);
						continue;
					case 11u:
						arg_354_0 = ((num > 34u) ? 1305109234u : 247982718u);
						continue;
					case 12u:
						arg_354_0 = ((this.options_ == null) ? 991437328u : 319552425u);
						continue;
					case 13u:
						arg_354_0 = 1126066364u;
						continue;
					case 14u:
						arg_354_0 = (num2 * 162509203u ^ 2280292773u);
						continue;
					case 15u:
						this.nestedType_.AddEntriesFrom(input, DescriptorProto._repeated_nestedType_codec);
						arg_354_0 = 992452198u;
						continue;
					case 16u:
						this.extension_.AddEntriesFrom(input, DescriptorProto._repeated_extension_codec);
						arg_354_0 = 1350218506u;
						continue;
					case 17u:
						arg_354_0 = (num2 * 1380787067u ^ 4093438369u);
						continue;
					case 18u:
						arg_354_0 = (num2 * 1492148555u ^ 3637361129u);
						continue;
					case 19u:
						arg_354_0 = ((num == 58u) ? 2133348123u : 1136668008u);
						continue;
					case 20u:
						arg_354_0 = (num2 * 465234465u ^ 4059377147u);
						continue;
					case 21u:
						this.field_.AddEntriesFrom(input, DescriptorProto._repeated_field_codec);
						arg_354_0 = 1350218506u;
						continue;
					case 22u:
						this.Name = input.ReadString();
						arg_354_0 = 575898613u;
						continue;
					case 23u:
						arg_354_0 = (((num != 50u) ? 4241886121u : 2703732791u) ^ num2 * 2260641776u);
						continue;
					case 24u:
						input.SkipLastField();
						arg_354_0 = 1047393750u;
						continue;
					case 25u:
						this.extensionRange_.AddEntriesFrom(input, DescriptorProto._repeated_extensionRange_codec);
						arg_354_0 = 545303985u;
						continue;
					case 26u:
						arg_354_0 = (((num == 10u) ? 3331026663u : 2423119537u) ^ num2 * 1676932671u);
						continue;
					case 27u:
						arg_354_0 = (((num == 42u) ? 2314717108u : 4060626842u) ^ num2 * 3222330574u);
						continue;
					case 29u:
						goto IL_3F0;
					case 30u:
						input.ReadMessage(this.options_);
						arg_354_0 = 1350218506u;
						continue;
					case 31u:
						arg_354_0 = (((num != 66u) ? 2439413431u : 4026632812u) ^ num2 * 1449125032u);
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
				IL_D5:
				uint arg_B5_0 = 772929701u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B5_0 ^ 933086600u)) % 5u)
					{
					case 0u:
						DescriptorProto._repeated_nestedType_codec = FieldCodec.ForMessage<DescriptorProto>(26u, DescriptorProto.Parser);
						DescriptorProto._repeated_enumType_codec = FieldCodec.ForMessage<EnumDescriptorProto>(34u, EnumDescriptorProto.Parser);
						DescriptorProto._repeated_extensionRange_codec = FieldCodec.ForMessage<DescriptorProto.Types.ExtensionRange>(42u, DescriptorProto.Types.ExtensionRange.Parser);
						DescriptorProto._repeated_oneofDecl_codec = FieldCodec.ForMessage<OneofDescriptorProto>(66u, OneofDescriptorProto.Parser);
						arg_B5_0 = (num * 1929235804u ^ 711273320u);
						continue;
					case 1u:
						DescriptorProto._repeated_field_codec = FieldCodec.ForMessage<FieldDescriptorProto>(18u, FieldDescriptorProto.Parser);
						arg_B5_0 = (num * 1947074557u ^ 1771611389u);
						continue;
					case 3u:
						goto IL_D5;
					case 4u:
						DescriptorProto._repeated_extension_codec = FieldCodec.ForMessage<FieldDescriptorProto>(50u, FieldDescriptorProto.Parser);
						arg_B5_0 = (num * 3318703956u ^ 1455410250u);
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
