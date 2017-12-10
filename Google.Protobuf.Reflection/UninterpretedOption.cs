using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class UninterpretedOption : IMessage, IMessage<UninterpretedOption>, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			[DebuggerNonUserCode]
			internal sealed class NamePart : IMessage, IMessage<UninterpretedOption.Types.NamePart>, IEquatable<UninterpretedOption.Types.NamePart>, IDeepCloneable<UninterpretedOption.Types.NamePart>
			{
				[CompilerGenerated]
				[Serializable]
				private sealed class __c
				{
					public static readonly UninterpretedOption.Types.NamePart.__c __9 = new UninterpretedOption.Types.NamePart.__c();

					internal UninterpretedOption.Types.NamePart cctor>b__29_0()
					{
						return new UninterpretedOption.Types.NamePart();
					}
				}

				private static readonly MessageParser<UninterpretedOption.Types.NamePart> _parser = new MessageParser<UninterpretedOption.Types.NamePart>(new Func<UninterpretedOption.Types.NamePart>(UninterpretedOption.Types.NamePart.__c.__9.<.cctor>b__29_0));

				public const int NamePart_FieldNumber = 1;

				private string namePart_ = "";

				public const int IsExtensionFieldNumber = 2;

				private bool isExtension_;

				public static MessageParser<UninterpretedOption.Types.NamePart> Parser
				{
					get
					{
						return UninterpretedOption.Types.NamePart._parser;
					}
				}

				public static MessageDescriptor Descriptor
				{
					get
					{
						return UninterpretedOption.Descriptor.NestedTypes[0];
					}
				}

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return UninterpretedOption.Types.NamePart.Descriptor;
					}
				}

				public string NamePart_
				{
					get
					{
						return this.namePart_;
					}
					set
					{
						this.namePart_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
					}
				}

				public bool IsExtension
				{
					get
					{
						return this.isExtension_;
					}
					set
					{
						this.isExtension_ = value;
					}
				}

				public NamePart()
				{
				}

				public NamePart(UninterpretedOption.Types.NamePart other) : this()
				{
					this.namePart_ = other.namePart_;
					this.isExtension_ = other.isExtension_;
				}

				public UninterpretedOption.Types.NamePart Clone()
				{
					return new UninterpretedOption.Types.NamePart(this);
				}

				public override bool Equals(object other)
				{
					return this.Equals(other as UninterpretedOption.Types.NamePart);
				}

				public bool Equals(UninterpretedOption.Types.NamePart other)
				{
					if (other == null)
					{
						goto IL_68;
					}
					goto IL_B0;
					int arg_72_0;
					while (true)
					{
						IL_6D:
						switch ((arg_72_0 ^ -387377425) % 9)
						{
						case 0:
							goto IL_68;
						case 1:
							arg_72_0 = ((this.IsExtension == other.IsExtension) ? -1924029948 : -558966760);
							continue;
						case 2:
							return false;
						case 3:
							return false;
						case 5:
							arg_72_0 = (UninterpretedOption.Types.NamePart.smethod_0(this.NamePart_, other.NamePart_) ? -231889770 : -1226820563);
							continue;
						case 6:
							goto IL_B0;
						case 7:
							return true;
						case 8:
							return false;
						}
						break;
					}
					return true;
					IL_68:
					arg_72_0 = -946491953;
					goto IL_6D;
					IL_B0:
					arg_72_0 = ((other != this) ? -926915111 : -695832613);
					goto IL_6D;
				}

				public override int GetHashCode()
				{
					int num = 1;
					while (true)
					{
						IL_BA:
						uint arg_96_0 = 2757507798u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_96_0 ^ 3604878020u)) % 6u)
							{
							case 0u:
								goto IL_BA;
							case 2u:
								arg_96_0 = (((UninterpretedOption.Types.NamePart.smethod_1(this.NamePart_) == 0) ? 2197391559u : 2654516929u) ^ num2 * 428343585u);
								continue;
							case 3u:
								arg_96_0 = (this.IsExtension ? 3140710962u : 2608754689u);
								continue;
							case 4u:
								num ^= this.IsExtension.GetHashCode();
								arg_96_0 = (num2 * 1695460233u ^ 608126375u);
								continue;
							case 5u:
								num ^= UninterpretedOption.Types.NamePart.smethod_2(this.NamePart_);
								arg_96_0 = (num2 * 1320429554u ^ 2484467627u);
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
					if (UninterpretedOption.Types.NamePart.smethod_1(this.NamePart_) != 0)
					{
						goto IL_1F;
					}
					goto IL_B1;
					uint arg_7E_0;
					while (true)
					{
						IL_79:
						uint num;
						switch ((num = (arg_7E_0 ^ 2121512560u)) % 6u)
						{
						case 1u:
							output.WriteBool(this.IsExtension);
							arg_7E_0 = (num * 2312313601u ^ 1848014173u);
							continue;
						case 2u:
							output.WriteRawTag(10);
							output.WriteString(this.NamePart_);
							arg_7E_0 = (num * 1441882936u ^ 4187912202u);
							continue;
						case 3u:
							output.WriteRawTag(16);
							arg_7E_0 = (num * 2353443943u ^ 716406136u);
							continue;
						case 4u:
							goto IL_B1;
						case 5u:
							goto IL_1F;
						}
						break;
					}
					return;
					IL_1F:
					arg_7E_0 = 1827467696u;
					goto IL_79;
					IL_B1:
					arg_7E_0 = ((!this.IsExtension) ? 1766977438u : 463120781u);
					goto IL_79;
				}

				public int CalculateSize()
				{
					int num = 0;
					if (UninterpretedOption.Types.NamePart.smethod_1(this.NamePart_) != 0)
					{
						goto IL_1E;
					}
					goto IL_86;
					uint arg_5A_0;
					while (true)
					{
						IL_55:
						uint num2;
						switch ((num2 = (arg_5A_0 ^ 1538023466u)) % 5u)
						{
						case 0u:
							num += 2;
							arg_5A_0 = (num2 * 3231778262u ^ 3907978887u);
							continue;
						case 2u:
							num += 1 + CodedOutputStream.ComputeStringSize(this.NamePart_);
							arg_5A_0 = (num2 * 2779338625u ^ 3645742931u);
							continue;
						case 3u:
							goto IL_1E;
						case 4u:
							goto IL_86;
						}
						break;
					}
					return num;
					IL_1E:
					arg_5A_0 = 1319632464u;
					goto IL_55;
					IL_86:
					arg_5A_0 = (this.IsExtension ? 790433979u : 1717102769u);
					goto IL_55;
				}

				public void MergeFrom(UninterpretedOption.Types.NamePart other)
				{
					if (other == null)
					{
						goto IL_30;
					}
					goto IL_AD;
					uint arg_76_0;
					while (true)
					{
						IL_71:
						uint num;
						switch ((num = (arg_76_0 ^ 1063401130u)) % 7u)
						{
						case 0u:
							arg_76_0 = (other.IsExtension ? 1947955674u : 1206957398u);
							continue;
						case 1u:
							goto IL_AD;
						case 2u:
							this.NamePart_ = other.NamePart_;
							arg_76_0 = (num * 3632324618u ^ 915883135u);
							continue;
						case 3u:
							return;
						case 4u:
							goto IL_30;
						case 6u:
							this.IsExtension = other.IsExtension;
							arg_76_0 = (num * 985427199u ^ 1774312902u);
							continue;
						}
						break;
					}
					return;
					IL_30:
					arg_76_0 = 1913370298u;
					goto IL_71;
					IL_AD:
					arg_76_0 = ((UninterpretedOption.Types.NamePart.smethod_1(other.NamePart_) == 0) ? 1192051667u : 881970420u);
					goto IL_71;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_EE:
						uint num;
						uint arg_AE_0 = ((num = input.ReadTag()) == 0u) ? 2315126112u : 2343597663u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_AE_0 ^ 2222133674u)) % 9u)
							{
							case 0u:
								arg_AE_0 = (((num == 16u) ? 2243065476u : 2494122898u) ^ num2 * 2151440464u);
								continue;
							case 1u:
								this.NamePart_ = input.ReadString();
								arg_AE_0 = 2991866976u;
								continue;
							case 2u:
								arg_AE_0 = 2343597663u;
								continue;
							case 3u:
								arg_AE_0 = ((num == 10u) ? 3702260229u : 2436237105u);
								continue;
							case 5u:
								arg_AE_0 = (num2 * 2126258113u ^ 2965097581u);
								continue;
							case 6u:
								goto IL_EE;
							case 7u:
								this.IsExtension = input.ReadBool();
								arg_AE_0 = 3017338663u;
								continue;
							case 8u:
								input.SkipLastField();
								arg_AE_0 = (num2 * 1762041467u ^ 2694344639u);
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

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UninterpretedOption.__c __9 = new UninterpretedOption.__c();

			internal UninterpretedOption cctor>b__55_0()
			{
				return new UninterpretedOption();
			}
		}

		private static readonly MessageParser<UninterpretedOption> _parser = new MessageParser<UninterpretedOption>(new Func<UninterpretedOption>(UninterpretedOption.__c.__9.<.cctor>b__55_0));

		public const int NameFieldNumber = 2;

		private static readonly FieldCodec<UninterpretedOption.Types.NamePart> _repeated_name_codec = FieldCodec.ForMessage<UninterpretedOption.Types.NamePart>(18u, UninterpretedOption.Types.NamePart.Parser);

		private readonly RepeatedField<UninterpretedOption.Types.NamePart> name_ = new RepeatedField<UninterpretedOption.Types.NamePart>();

		public const int IdentifierValueFieldNumber = 3;

		private string identifierValue_ = "";

		public const int PositiveIntValueFieldNumber = 4;

		private ulong positiveIntValue_;

		public const int NegativeIntValueFieldNumber = 5;

		private long negativeIntValue_;

		public const int DoubleValueFieldNumber = 6;

		private double doubleValue_;

		public const int StringValueFieldNumber = 7;

		private ByteString stringValue_ = ByteString.Empty;

		public const int AggregateValueFieldNumber = 8;

		private string aggregateValue_ = "";

		public static MessageParser<UninterpretedOption> Parser
		{
			get
			{
				return UninterpretedOption._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[16];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UninterpretedOption.Descriptor;
			}
		}

		public RepeatedField<UninterpretedOption.Types.NamePart> Name
		{
			get
			{
				return this.name_;
			}
		}

		public string IdentifierValue
		{
			get
			{
				return this.identifierValue_;
			}
			set
			{
				this.identifierValue_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public ulong PositiveIntValue
		{
			get
			{
				return this.positiveIntValue_;
			}
			set
			{
				this.positiveIntValue_ = value;
			}
		}

		public long NegativeIntValue
		{
			get
			{
				return this.negativeIntValue_;
			}
			set
			{
				this.negativeIntValue_ = value;
			}
		}

		public double DoubleValue
		{
			get
			{
				return this.doubleValue_;
			}
			set
			{
				this.doubleValue_ = value;
			}
		}

		public ByteString StringValue
		{
			get
			{
				return this.stringValue_;
			}
			set
			{
				this.stringValue_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public string AggregateValue
		{
			get
			{
				return this.aggregateValue_;
			}
			set
			{
				this.aggregateValue_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public UninterpretedOption()
		{
		}

		public UninterpretedOption(UninterpretedOption other) : this()
		{
			this.name_ = other.name_.Clone();
			this.identifierValue_ = other.identifierValue_;
			this.positiveIntValue_ = other.positiveIntValue_;
			this.negativeIntValue_ = other.negativeIntValue_;
			this.doubleValue_ = other.doubleValue_;
			this.stringValue_ = other.stringValue_;
			this.aggregateValue_ = other.aggregateValue_;
		}

		public UninterpretedOption Clone()
		{
			return new UninterpretedOption(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UninterpretedOption);
		}

		public bool Equals(UninterpretedOption other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_1B9;
			int arg_153_0;
			while (true)
			{
				IL_14E:
				switch ((arg_153_0 ^ -1898478881) % 19)
				{
				case 0:
					return false;
				case 1:
					arg_153_0 = ((this.DoubleValue != other.DoubleValue) ? -1114262047 : -1043013492);
					continue;
				case 2:
					arg_153_0 = ((this.NegativeIntValue == other.NegativeIntValue) ? -719700109 : -1250198844);
					continue;
				case 3:
					return false;
				case 4:
					arg_153_0 = (this.name_.Equals(other.name_) ? -598763971 : -2075656817);
					continue;
				case 5:
					return false;
				case 6:
					arg_153_0 = ((!UninterpretedOption.smethod_0(this.AggregateValue, other.AggregateValue)) ? -319127823 : -646292632);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return true;
				case 11:
					arg_153_0 = ((!UninterpretedOption.smethod_0(this.IdentifierValue, other.IdentifierValue)) ? -456383069 : -1168122025);
					continue;
				case 12:
					goto IL_1B9;
				case 13:
					arg_153_0 = ((this.StringValue != other.StringValue) ? -367181639 : -760871999);
					continue;
				case 15:
					arg_153_0 = ((this.PositiveIntValue != other.PositiveIntValue) ? -1293120456 : -1745167732);
					continue;
				case 16:
					goto IL_18;
				case 17:
					return false;
				case 18:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_153_0 = -1964918242;
			goto IL_14E;
			IL_1B9:
			arg_153_0 = ((other != this) ? -1513863999 : -1675879403);
			goto IL_14E;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ UninterpretedOption.smethod_1(this.name_);
			if (UninterpretedOption.smethod_2(this.IdentifierValue) != 0)
			{
				goto IL_157;
			}
			goto IL_1F6;
			uint arg_1A5_0;
			while (true)
			{
				IL_1A0:
				uint num2;
				switch ((num2 = (arg_1A5_0 ^ 1471386423u)) % 13u)
				{
				case 0u:
					num ^= this.StringValue.GetHashCode();
					arg_1A5_0 = (num2 * 2635928400u ^ 1472312191u);
					continue;
				case 1u:
					arg_1A5_0 = ((this.StringValue.Length != 0) ? 263983095u : 2021822335u);
					continue;
				case 2u:
					goto IL_157;
				case 3u:
					num ^= UninterpretedOption.smethod_1(this.IdentifierValue);
					arg_1A5_0 = (num2 * 114123192u ^ 3311244205u);
					continue;
				case 5u:
					num ^= this.DoubleValue.GetHashCode();
					arg_1A5_0 = (num2 * 523201385u ^ 4204010881u);
					continue;
				case 6u:
					num ^= this.AggregateValue.GetHashCode();
					arg_1A5_0 = (num2 * 768494929u ^ 595913813u);
					continue;
				case 7u:
					arg_1A5_0 = ((this.DoubleValue != 0.0) ? 1644131232u : 380905326u);
					continue;
				case 8u:
					num ^= this.NegativeIntValue.GetHashCode();
					arg_1A5_0 = (num2 * 1105725156u ^ 1625615404u);
					continue;
				case 9u:
					goto IL_1F6;
				case 10u:
					num ^= this.PositiveIntValue.GetHashCode();
					arg_1A5_0 = (num2 * 2911162369u ^ 4156391037u);
					continue;
				case 11u:
					arg_1A5_0 = ((this.AggregateValue.Length == 0) ? 398527082u : 713311672u);
					continue;
				case 12u:
					arg_1A5_0 = ((this.NegativeIntValue == 0L) ? 149113652u : 786219457u);
					continue;
				}
				break;
			}
			return num;
			IL_157:
			arg_1A5_0 = 2121931240u;
			goto IL_1A0;
			IL_1F6:
			arg_1A5_0 = ((this.PositiveIntValue == 0uL) ? 1770888205u : 868643143u);
			goto IL_1A0;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.name_.WriteTo(output, UninterpretedOption._repeated_name_codec);
			if (UninterpretedOption.smethod_2(this.IdentifierValue) != 0)
			{
				goto IL_1E4;
			}
			goto IL_24A;
			uint arg_1EE_0;
			while (true)
			{
				IL_1E9:
				uint num;
				switch ((num = (arg_1EE_0 ^ 3353602000u)) % 16u)
				{
				case 0u:
					goto IL_1E4;
				case 1u:
					output.WriteRawTag(58);
					output.WriteBytes(this.StringValue);
					arg_1EE_0 = (num * 1270872983u ^ 1675727205u);
					continue;
				case 2u:
					arg_1EE_0 = ((UninterpretedOption.smethod_2(this.AggregateValue) == 0) ? 3485309582u : 2843637411u);
					continue;
				case 3u:
					output.WriteRawTag(66);
					arg_1EE_0 = (num * 1409716013u ^ 2003871742u);
					continue;
				case 4u:
					output.WriteRawTag(40);
					arg_1EE_0 = (num * 3612335603u ^ 1096599427u);
					continue;
				case 5u:
					output.WriteRawTag(26);
					output.WriteString(this.IdentifierValue);
					arg_1EE_0 = (num * 783832359u ^ 3303056229u);
					continue;
				case 6u:
					goto IL_24A;
				case 7u:
					output.WriteRawTag(49);
					output.WriteDouble(this.DoubleValue);
					arg_1EE_0 = (num * 1458798818u ^ 91796836u);
					continue;
				case 8u:
					arg_1EE_0 = ((this.NegativeIntValue != 0L) ? 3747080900u : 3857385805u);
					continue;
				case 9u:
					output.WriteString(this.AggregateValue);
					arg_1EE_0 = (num * 1717775482u ^ 2458294628u);
					continue;
				case 10u:
					arg_1EE_0 = ((this.StringValue.Length != 0) ? 4228664673u : 3895044098u);
					continue;
				case 11u:
					output.WriteRawTag(32);
					arg_1EE_0 = (num * 3199078986u ^ 559762818u);
					continue;
				case 12u:
					output.WriteUInt64(this.PositiveIntValue);
					arg_1EE_0 = (num * 2074717875u ^ 687604236u);
					continue;
				case 13u:
					arg_1EE_0 = ((this.DoubleValue != 0.0) ? 3599415575u : 3661012682u);
					continue;
				case 15u:
					output.WriteInt64(this.NegativeIntValue);
					arg_1EE_0 = (num * 4090056853u ^ 975056790u);
					continue;
				}
				break;
			}
			return;
			IL_1E4:
			arg_1EE_0 = 2290998005u;
			goto IL_1E9;
			IL_24A:
			arg_1EE_0 = ((this.PositiveIntValue != 0uL) ? 4100760075u : 3892625560u);
			goto IL_1E9;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_20C:
				uint arg_1C7_0 = 3573377312u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1C7_0 ^ 2563561832u)) % 14u)
					{
					case 0u:
						goto IL_20C;
					case 1u:
						arg_1C7_0 = ((this.PositiveIntValue == 0uL) ? 2744214612u : 3067328808u);
						continue;
					case 2u:
						num += 9;
						arg_1C7_0 = (num2 * 1593157841u ^ 1820327932u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeInt64Size(this.NegativeIntValue);
						arg_1C7_0 = (num2 * 3629075329u ^ 197636271u);
						continue;
					case 4u:
						arg_1C7_0 = ((this.NegativeIntValue != 0L) ? 2387966751u : 4219144792u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.AggregateValue);
						arg_1C7_0 = (num2 * 1518332463u ^ 1005572386u);
						continue;
					case 6u:
						arg_1C7_0 = ((this.DoubleValue != 0.0) ? 3719673736u : 2839116572u);
						continue;
					case 8u:
						arg_1C7_0 = ((this.StringValue.Length == 0) ? 2456539889u : 2520728333u);
						continue;
					case 9u:
						arg_1C7_0 = ((UninterpretedOption.smethod_2(this.AggregateValue) == 0) ? 2875075741u : 3973400601u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.PositiveIntValue);
						arg_1C7_0 = (num2 * 3527929012u ^ 790350164u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.IdentifierValue);
						arg_1C7_0 = (num2 * 3414525837u ^ 2030403628u);
						continue;
					case 12u:
						num += this.name_.CalculateSize(UninterpretedOption._repeated_name_codec);
						arg_1C7_0 = (((UninterpretedOption.smethod_2(this.IdentifierValue) != 0) ? 1461327427u : 1198030371u) ^ num2 * 3756354571u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.StringValue);
						arg_1C7_0 = (num2 * 301592588u ^ 1728921165u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UninterpretedOption other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_202;
			uint arg_1B5_0;
			while (true)
			{
				IL_1B0:
				uint num;
				switch ((num = (arg_1B5_0 ^ 3217751514u)) % 16u)
				{
				case 0u:
					arg_1B5_0 = ((UninterpretedOption.smethod_2(other.AggregateValue) != 0) ? 2954870371u : 3654617390u);
					continue;
				case 1u:
					arg_1B5_0 = ((other.NegativeIntValue == 0L) ? 2954744721u : 3877526870u);
					continue;
				case 2u:
					this.StringValue = other.StringValue;
					arg_1B5_0 = (num * 2013966298u ^ 594627950u);
					continue;
				case 3u:
					arg_1B5_0 = ((other.PositiveIntValue != 0uL) ? 3935205296u : 4139002939u);
					continue;
				case 5u:
					goto IL_202;
				case 6u:
					arg_1B5_0 = (((UninterpretedOption.smethod_2(other.IdentifierValue) != 0) ? 4027164174u : 3426168483u) ^ num * 3441922295u);
					continue;
				case 7u:
					arg_1B5_0 = ((other.StringValue.Length != 0) ? 3688989080u : 4076708698u);
					continue;
				case 8u:
					return;
				case 9u:
					this.AggregateValue = other.AggregateValue;
					arg_1B5_0 = (num * 856254986u ^ 4046796308u);
					continue;
				case 10u:
					this.PositiveIntValue = other.PositiveIntValue;
					arg_1B5_0 = (num * 55571900u ^ 3711384547u);
					continue;
				case 11u:
					arg_1B5_0 = ((other.DoubleValue != 0.0) ? 3047943701u : 2473951261u);
					continue;
				case 12u:
					this.NegativeIntValue = other.NegativeIntValue;
					arg_1B5_0 = (num * 2666092736u ^ 2382977681u);
					continue;
				case 13u:
					goto IL_44;
				case 14u:
					this.IdentifierValue = other.IdentifierValue;
					arg_1B5_0 = (num * 2702451000u ^ 2483031433u);
					continue;
				case 15u:
					this.DoubleValue = other.DoubleValue;
					arg_1B5_0 = (num * 1670844473u ^ 2407979274u);
					continue;
				}
				break;
			}
			return;
			IL_44:
			arg_1B5_0 = 3271834082u;
			goto IL_1B0;
			IL_202:
			this.name_.Add(other.name_);
			arg_1B5_0 = 4102085068u;
			goto IL_1B0;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_319:
				uint num;
				uint arg_291_0 = ((num = input.ReadTag()) != 0u) ? 3358286792u : 2798079972u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_291_0 ^ 2230918100u)) % 27u)
					{
					case 0u:
						this.name_.AddEntriesFrom(input, UninterpretedOption._repeated_name_codec);
						arg_291_0 = 2747637701u;
						continue;
					case 1u:
						arg_291_0 = (num2 * 2106945574u ^ 226609565u);
						continue;
					case 2u:
						arg_291_0 = 3358286792u;
						continue;
					case 3u:
						arg_291_0 = (((num != 66u) ? 1236466050u : 649635830u) ^ num2 * 2490679908u);
						continue;
					case 4u:
						arg_291_0 = (num2 * 968916906u ^ 439408098u);
						continue;
					case 5u:
						goto IL_319;
					case 6u:
						arg_291_0 = (num2 * 126475410u ^ 460746281u);
						continue;
					case 7u:
						arg_291_0 = (num2 * 2203256876u ^ 18455810u);
						continue;
					case 8u:
						arg_291_0 = ((num <= 49u) ? 3000852880u : 3727408651u);
						continue;
					case 9u:
						input.SkipLastField();
						arg_291_0 = 2283388528u;
						continue;
					case 10u:
						arg_291_0 = (((num == 26u) ? 1104046777u : 1937214778u) ^ num2 * 1053962089u);
						continue;
					case 11u:
						arg_291_0 = ((num <= 32u) ? 2278311856u : 3417877030u);
						continue;
					case 12u:
						this.StringValue = input.ReadBytes();
						arg_291_0 = 3253795520u;
						continue;
					case 13u:
						arg_291_0 = ((num == 58u) ? 2572916332u : 4204126310u);
						continue;
					case 14u:
						arg_291_0 = (num2 * 1760079775u ^ 4063884632u);
						continue;
					case 15u:
						this.IdentifierValue = input.ReadString();
						arg_291_0 = 2243696535u;
						continue;
					case 16u:
						arg_291_0 = (((num != 40u) ? 648468008u : 917066248u) ^ num2 * 3168981259u);
						continue;
					case 17u:
						arg_291_0 = (((num == 49u) ? 3366740880u : 3423857824u) ^ num2 * 2486916405u);
						continue;
					case 18u:
						this.PositiveIntValue = input.ReadUInt64();
						arg_291_0 = 3303494290u;
						continue;
					case 19u:
						this.AggregateValue = input.ReadString();
						arg_291_0 = 2747637701u;
						continue;
					case 20u:
						this.NegativeIntValue = input.ReadInt64();
						arg_291_0 = 3456677568u;
						continue;
					case 21u:
						this.DoubleValue = input.ReadDouble();
						arg_291_0 = 2747637701u;
						continue;
					case 22u:
						arg_291_0 = (((num == 32u) ? 2925049734u : 3463009156u) ^ num2 * 2587174938u);
						continue;
					case 23u:
						arg_291_0 = (((num == 18u) ? 1261413842u : 1224866501u) ^ num2 * 526183744u);
						continue;
					case 25u:
						arg_291_0 = (num2 * 1803301455u ^ 634900201u);
						continue;
					case 26u:
						arg_291_0 = (num2 * 2852073018u ^ 1918830925u);
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
