using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class UninterpretedOption : IMessage<UninterpretedOption>, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			[DebuggerNonUserCode]
			internal sealed class NamePart : IMessage<UninterpretedOption.Types.NamePart>, IEquatable<UninterpretedOption.Types.NamePart>, IDeepCloneable<UninterpretedOption.Types.NamePart>, IMessage
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
						this.namePart_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
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
					while (true)
					{
						IL_4A:
						uint arg_32_0 = 1976136540u;
						while (true)
						{
							uint num;
							switch ((num = (arg_32_0 ^ 1244293618u)) % 3u)
							{
							case 1u:
								this.namePart_ = other.namePart_;
								this.isExtension_ = other.isExtension_;
								arg_32_0 = (num * 174545309u ^ 3078420831u);
								continue;
							case 2u:
								goto IL_4A;
							}
							return;
						}
					}
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
						switch ((arg_72_0 ^ -240707439) % 9)
						{
						case 0:
							goto IL_68;
						case 1:
							goto IL_B0;
						case 3:
							return false;
						case 4:
							arg_72_0 = (UninterpretedOption.Types.NamePart.smethod_0(this.NamePart_, other.NamePart_) ? -1834379511 : -1962306246);
							continue;
						case 5:
							arg_72_0 = ((this.IsExtension != other.IsExtension) ? -2107856207 : -2113627448);
							continue;
						case 6:
							return false;
						case 7:
							return true;
						case 8:
							return false;
						}
						break;
					}
					return true;
					IL_68:
					arg_72_0 = -2057427097;
					goto IL_6D;
					IL_B0:
					arg_72_0 = ((other != this) ? -73274671 : -1398805737);
					goto IL_6D;
				}

				public override int GetHashCode()
				{
					int num = 1;
					while (true)
					{
						IL_BA:
						uint arg_96_0 = 959739975u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_96_0 ^ 385134369u)) % 6u)
							{
							case 0u:
								arg_96_0 = ((!this.IsExtension) ? 237862345u : 1796776040u);
								continue;
							case 1u:
								num ^= UninterpretedOption.Types.NamePart.smethod_2(this.NamePart_);
								arg_96_0 = (num2 * 4137849973u ^ 669922486u);
								continue;
							case 3u:
								goto IL_BA;
							case 4u:
								arg_96_0 = (((UninterpretedOption.Types.NamePart.smethod_1(this.NamePart_) != 0) ? 4078877212u : 3369056007u) ^ num2 * 3572206844u);
								continue;
							case 5u:
								num ^= this.IsExtension.GetHashCode();
								arg_96_0 = (num2 * 3813706059u ^ 3020682922u);
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
						goto IL_65;
					}
					goto IL_9B;
					uint arg_6F_0;
					while (true)
					{
						IL_6A:
						uint num;
						switch ((num = (arg_6F_0 ^ 2196724152u)) % 5u)
						{
						case 0u:
							goto IL_65;
						case 1u:
							goto IL_9B;
						case 2u:
							output.WriteRawTag(10);
							output.WriteString(this.NamePart_);
							arg_6F_0 = (num * 3710217040u ^ 1616946663u);
							continue;
						case 4u:
							output.WriteRawTag(16);
							output.WriteBool(this.IsExtension);
							arg_6F_0 = (num * 4058525509u ^ 2603311045u);
							continue;
						}
						break;
					}
					return;
					IL_65:
					arg_6F_0 = 2475431821u;
					goto IL_6A;
					IL_9B:
					arg_6F_0 = ((!this.IsExtension) ? 4134694002u : 2434990451u);
					goto IL_6A;
				}

				public int CalculateSize()
				{
					int num = 0;
					while (true)
					{
						IL_AF:
						uint arg_8B_0 = 403354018u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_8B_0 ^ 377619743u)) % 6u)
							{
							case 0u:
								num += 1 + CodedOutputStream.ComputeStringSize(this.NamePart_);
								arg_8B_0 = (num2 * 2029000374u ^ 2222356071u);
								continue;
							case 1u:
								num += 2;
								arg_8B_0 = (num2 * 3772960006u ^ 939535701u);
								continue;
							case 3u:
								arg_8B_0 = (((UninterpretedOption.Types.NamePart.smethod_1(this.NamePart_) != 0) ? 3301955599u : 2853213553u) ^ num2 * 2186196082u);
								continue;
							case 4u:
								arg_8B_0 = (this.IsExtension ? 1955293006u : 1131743155u);
								continue;
							case 5u:
								goto IL_AF;
							}
							return num;
						}
					}
					return num;
				}

				public void MergeFrom(UninterpretedOption.Types.NamePart other)
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
						switch ((num = (arg_76_0 ^ 1416098489u)) % 7u)
						{
						case 0u:
							goto IL_6C;
						case 1u:
							this.NamePart_ = other.NamePart_;
							arg_76_0 = (num * 2321349572u ^ 2355579013u);
							continue;
						case 2u:
							arg_76_0 = (other.IsExtension ? 928139474u : 1542708421u);
							continue;
						case 4u:
							goto IL_AD;
						case 5u:
							return;
						case 6u:
							this.IsExtension = other.IsExtension;
							arg_76_0 = (num * 1891066871u ^ 3382239992u);
							continue;
						}
						break;
					}
					return;
					IL_6C:
					arg_76_0 = 1273922672u;
					goto IL_71;
					IL_AD:
					arg_76_0 = ((UninterpretedOption.Types.NamePart.smethod_1(other.NamePart_) == 0) ? 77492941u : 480561419u);
					goto IL_71;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_F1:
						uint num;
						uint arg_B1_0 = ((num = input.ReadTag()) == 0u) ? 892360258u : 1848098736u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_B1_0 ^ 1527141277u)) % 9u)
							{
							case 0u:
								goto IL_F1;
							case 1u:
								arg_B1_0 = (((num != 16u) ? 2248849807u : 3227524151u) ^ num2 * 3730220176u);
								continue;
							case 3u:
								input.SkipLastField();
								arg_B1_0 = (num2 * 783818891u ^ 1987640322u);
								continue;
							case 4u:
								arg_B1_0 = ((num == 10u) ? 319223136u : 559492368u);
								continue;
							case 5u:
								arg_B1_0 = (num2 * 1269553354u ^ 293555476u);
								continue;
							case 6u:
								this.IsExtension = input.ReadBool();
								arg_B1_0 = 894606036u;
								continue;
							case 7u:
								arg_B1_0 = 1848098736u;
								continue;
							case 8u:
								this.NamePart_ = input.ReadString();
								arg_B1_0 = 55025149u;
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
				this.stringValue_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
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
				goto IL_CF;
			}
			goto IL_1B9;
			int arg_153_0;
			while (true)
			{
				IL_14E:
				switch ((arg_153_0 ^ -834992521) % 19)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					arg_153_0 = (this.name_.Equals(other.name_) ? -716817409 : -459473560);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_1B9;
				case 5:
					arg_153_0 = ((this.NegativeIntValue != other.NegativeIntValue) ? -101271841 : -1090118429);
					continue;
				case 6:
					arg_153_0 = ((this.PositiveIntValue == other.PositiveIntValue) ? -1071094369 : -1579270622);
					continue;
				case 8:
					return false;
				case 9:
					goto IL_CF;
				case 10:
					return false;
				case 11:
					arg_153_0 = (UninterpretedOption.smethod_0(this.AggregateValue, other.AggregateValue) ? -875588453 : -109048776);
					continue;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_153_0 = ((this.DoubleValue == other.DoubleValue) ? -890760204 : -2113171391);
					continue;
				case 16:
					arg_153_0 = ((this.StringValue != other.StringValue) ? -827684070 : -1768414627);
					continue;
				case 17:
					arg_153_0 = (UninterpretedOption.smethod_0(this.IdentifierValue, other.IdentifierValue) ? -1691479859 : -2043032386);
					continue;
				case 18:
					return false;
				}
				break;
			}
			return true;
			IL_CF:
			arg_153_0 = -900911114;
			goto IL_14E;
			IL_1B9:
			arg_153_0 = ((other == this) ? -1601259013 : -327653292);
			goto IL_14E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_217:
				uint arg_1D1_0 = 121226271u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1D1_0 ^ 244279038u)) % 14u)
					{
					case 1u:
						num ^= this.DoubleValue.GetHashCode();
						arg_1D1_0 = (num2 * 776969096u ^ 2519889091u);
						continue;
					case 2u:
						num ^= this.StringValue.GetHashCode();
						arg_1D1_0 = (num2 * 2837066749u ^ 1960850103u);
						continue;
					case 3u:
						arg_1D1_0 = ((this.NegativeIntValue == 0L) ? 821405000u : 1979321526u);
						continue;
					case 4u:
						num ^= this.PositiveIntValue.GetHashCode();
						arg_1D1_0 = (num2 * 893887503u ^ 3315099723u);
						continue;
					case 5u:
						arg_1D1_0 = ((this.AggregateValue.Length == 0) ? 413621592u : 330055364u);
						continue;
					case 6u:
						num ^= this.NegativeIntValue.GetHashCode();
						arg_1D1_0 = (num2 * 4204302716u ^ 2284316584u);
						continue;
					case 7u:
						num ^= UninterpretedOption.smethod_1(this.name_);
						arg_1D1_0 = (((UninterpretedOption.smethod_2(this.IdentifierValue) == 0) ? 3871978092u : 3694688619u) ^ num2 * 1625987624u);
						continue;
					case 8u:
						arg_1D1_0 = ((this.DoubleValue == 0.0) ? 1445490331u : 440232581u);
						continue;
					case 9u:
						arg_1D1_0 = ((this.StringValue.Length != 0) ? 2093910176u : 634486353u);
						continue;
					case 10u:
						arg_1D1_0 = ((this.PositiveIntValue == 0uL) ? 1506716075u : 834053854u);
						continue;
					case 11u:
						num ^= UninterpretedOption.smethod_1(this.IdentifierValue);
						arg_1D1_0 = (num2 * 349163088u ^ 1084198484u);
						continue;
					case 12u:
						num ^= this.AggregateValue.GetHashCode();
						arg_1D1_0 = (num2 * 555592377u ^ 3876853938u);
						continue;
					case 13u:
						goto IL_217;
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
			this.name_.WriteTo(output, UninterpretedOption._repeated_name_codec);
			while (true)
			{
				IL_270:
				uint arg_21F_0 = 2883184069u;
				while (true)
				{
					uint num;
					switch ((num = (arg_21F_0 ^ 2736303845u)) % 17u)
					{
					case 0u:
						arg_21F_0 = ((this.DoubleValue != 0.0) ? 2821627370u : 2464924987u);
						continue;
					case 1u:
						output.WriteString(this.IdentifierValue);
						arg_21F_0 = (num * 291130951u ^ 3693618500u);
						continue;
					case 2u:
						arg_21F_0 = (((UninterpretedOption.smethod_2(this.IdentifierValue) == 0) ? 875533667u : 1072263362u) ^ num * 1307995088u);
						continue;
					case 3u:
						arg_21F_0 = ((this.NegativeIntValue == 0L) ? 2593223181u : 4138770505u);
						continue;
					case 4u:
						output.WriteInt64(this.NegativeIntValue);
						arg_21F_0 = (num * 832241709u ^ 2389480842u);
						continue;
					case 5u:
						arg_21F_0 = ((UninterpretedOption.smethod_2(this.AggregateValue) != 0) ? 4066801087u : 4095490131u);
						continue;
					case 6u:
						output.WriteRawTag(66);
						output.WriteString(this.AggregateValue);
						arg_21F_0 = (num * 2464653385u ^ 1013380345u);
						continue;
					case 7u:
						output.WriteRawTag(26);
						arg_21F_0 = (num * 1346208650u ^ 370350530u);
						continue;
					case 8u:
						goto IL_270;
					case 9u:
						arg_21F_0 = ((this.StringValue.Length != 0) ? 2940965836u : 2250707955u);
						continue;
					case 10u:
						output.WriteRawTag(58);
						output.WriteBytes(this.StringValue);
						arg_21F_0 = (num * 1250981475u ^ 3847659304u);
						continue;
					case 11u:
						arg_21F_0 = ((this.PositiveIntValue == 0uL) ? 2645913297u : 2487333369u);
						continue;
					case 12u:
						output.WriteRawTag(49);
						arg_21F_0 = (num * 3230928854u ^ 3180593629u);
						continue;
					case 13u:
						output.WriteDouble(this.DoubleValue);
						arg_21F_0 = (num * 4019196058u ^ 2498563631u);
						continue;
					case 14u:
						output.WriteRawTag(40);
						arg_21F_0 = (num * 482647286u ^ 1581229230u);
						continue;
					case 16u:
						output.WriteRawTag(32);
						output.WriteUInt64(this.PositiveIntValue);
						arg_21F_0 = (num * 1519271072u ^ 154365777u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_222:
				uint arg_1D9_0 = 578665296u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1D9_0 ^ 231602063u)) % 15u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.IdentifierValue);
						arg_1D9_0 = (num2 * 4035234943u ^ 285999405u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.AggregateValue);
						arg_1D9_0 = (num2 * 4144756620u ^ 2778803321u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeInt64Size(this.NegativeIntValue);
						arg_1D9_0 = (num2 * 64268559u ^ 3737586771u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.StringValue);
						arg_1D9_0 = (num2 * 2944482510u ^ 2917640795u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.PositiveIntValue);
						arg_1D9_0 = (num2 * 2938771356u ^ 2411354165u);
						continue;
					case 6u:
						arg_1D9_0 = ((this.PositiveIntValue == 0uL) ? 1898059413u : 1937800599u);
						continue;
					case 7u:
						arg_1D9_0 = (((UninterpretedOption.smethod_2(this.IdentifierValue) == 0) ? 10929562u : 1701400390u) ^ num2 * 51591668u);
						continue;
					case 8u:
						num += 9;
						arg_1D9_0 = (num2 * 1744169153u ^ 329813791u);
						continue;
					case 9u:
						arg_1D9_0 = ((this.DoubleValue == 0.0) ? 455624757u : 1609498661u);
						continue;
					case 10u:
						goto IL_222;
					case 11u:
						arg_1D9_0 = ((UninterpretedOption.smethod_2(this.AggregateValue) == 0) ? 1779326305u : 1858957837u);
						continue;
					case 12u:
						num += this.name_.CalculateSize(UninterpretedOption._repeated_name_codec);
						arg_1D9_0 = (num2 * 3100982234u ^ 1087078854u);
						continue;
					case 13u:
						arg_1D9_0 = ((this.StringValue.Length != 0) ? 428527378u : 1901522957u);
						continue;
					case 14u:
						arg_1D9_0 = ((this.NegativeIntValue == 0L) ? 1046893493u : 1549218357u);
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
				goto IL_11E;
			}
			goto IL_1EC;
			uint arg_194_0;
			while (true)
			{
				IL_18F:
				uint num;
				switch ((num = (arg_194_0 ^ 1114628224u)) % 15u)
				{
				case 0u:
					arg_194_0 = ((other.DoubleValue != 0.0) ? 196026589u : 874501992u);
					continue;
				case 1u:
					arg_194_0 = ((other.NegativeIntValue != 0L) ? 540814357u : 484298769u);
					continue;
				case 2u:
					goto IL_1EC;
				case 3u:
					arg_194_0 = ((other.PositiveIntValue == 0uL) ? 2145573994u : 1965684533u);
					continue;
				case 4u:
					goto IL_11E;
				case 5u:
					return;
				case 7u:
					arg_194_0 = ((other.StringValue.Length == 0) ? 934436712u : 1705208154u);
					continue;
				case 8u:
					this.IdentifierValue = other.IdentifierValue;
					arg_194_0 = (num * 3822444702u ^ 3364505849u);
					continue;
				case 9u:
					this.NegativeIntValue = other.NegativeIntValue;
					arg_194_0 = (num * 1620854470u ^ 2639341871u);
					continue;
				case 10u:
					this.DoubleValue = other.DoubleValue;
					arg_194_0 = (num * 1581583582u ^ 3374578638u);
					continue;
				case 11u:
					arg_194_0 = ((UninterpretedOption.smethod_2(other.AggregateValue) != 0) ? 2141422802u : 996453827u);
					continue;
				case 12u:
					this.AggregateValue = other.AggregateValue;
					arg_194_0 = (num * 778111481u ^ 822269953u);
					continue;
				case 13u:
					this.StringValue = other.StringValue;
					arg_194_0 = (num * 3755830634u ^ 1327937836u);
					continue;
				case 14u:
					this.PositiveIntValue = other.PositiveIntValue;
					arg_194_0 = (num * 234271797u ^ 3439259667u);
					continue;
				}
				break;
			}
			return;
			IL_11E:
			arg_194_0 = 46404277u;
			goto IL_18F;
			IL_1EC:
			this.name_.Add(other.name_);
			arg_194_0 = ((UninterpretedOption.smethod_2(other.IdentifierValue) != 0) ? 148807602u : 1542981669u);
			goto IL_18F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_30C:
				uint num;
				uint arg_288_0 = ((num = input.ReadTag()) == 0u) ? 1039855931u : 394491425u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_288_0 ^ 1351805455u)) % 26u)
					{
					case 0u:
						arg_288_0 = (((num != 49u) ? 3700557491u : 2381149507u) ^ num2 * 375902157u);
						continue;
					case 1u:
						arg_288_0 = ((num == 58u) ? 780404763u : 1967098733u);
						continue;
					case 2u:
						arg_288_0 = (num2 * 452455246u ^ 2824570707u);
						continue;
					case 3u:
						arg_288_0 = (num2 * 3373773775u ^ 2667582046u);
						continue;
					case 4u:
						arg_288_0 = (((num != 32u) ? 2176476268u : 4162572642u) ^ num2 * 4214996109u);
						continue;
					case 5u:
						arg_288_0 = (((num == 18u) ? 2057634904u : 1649392682u) ^ num2 * 2774073496u);
						continue;
					case 6u:
						arg_288_0 = (((num == 66u) ? 1591726240u : 456071525u) ^ num2 * 1003622303u);
						continue;
					case 7u:
						arg_288_0 = (num2 * 347462769u ^ 3634713218u);
						continue;
					case 8u:
						goto IL_30C;
					case 9u:
						this.IdentifierValue = input.ReadString();
						arg_288_0 = 1799065335u;
						continue;
					case 10u:
						this.StringValue = input.ReadBytes();
						arg_288_0 = 1140899485u;
						continue;
					case 11u:
						this.NegativeIntValue = input.ReadInt64();
						arg_288_0 = 1140899485u;
						continue;
					case 12u:
						arg_288_0 = ((num <= 32u) ? 1364864830u : 981608400u);
						continue;
					case 13u:
						arg_288_0 = 394491425u;
						continue;
					case 15u:
						this.AggregateValue = input.ReadString();
						arg_288_0 = 1140899485u;
						continue;
					case 16u:
						arg_288_0 = (num2 * 541097602u ^ 1381973641u);
						continue;
					case 17u:
						arg_288_0 = (num2 * 1824646663u ^ 3376562u);
						continue;
					case 18u:
						arg_288_0 = (((num == 40u) ? 684374924u : 1431234719u) ^ num2 * 520530304u);
						continue;
					case 19u:
						arg_288_0 = (((num == 26u) ? 119248795u : 1514334238u) ^ num2 * 3152538239u);
						continue;
					case 20u:
						input.SkipLastField();
						arg_288_0 = 758259094u;
						continue;
					case 21u:
						this.PositiveIntValue = input.ReadUInt64();
						arg_288_0 = 1017646469u;
						continue;
					case 22u:
						this.DoubleValue = input.ReadDouble();
						arg_288_0 = 1140899485u;
						continue;
					case 23u:
						this.name_.AddEntriesFrom(input, UninterpretedOption._repeated_name_codec);
						arg_288_0 = 478788290u;
						continue;
					case 24u:
						arg_288_0 = (num2 * 2786412026u ^ 1207684269u);
						continue;
					case 25u:
						arg_288_0 = ((num <= 49u) ? 1682679617u : 460636926u);
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
