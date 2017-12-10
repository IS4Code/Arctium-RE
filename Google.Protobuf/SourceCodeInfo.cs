using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			[DebuggerNonUserCode]
			internal sealed class Location : IMessage<SourceCodeInfo.Types.Location>, IEquatable<SourceCodeInfo.Types.Location>, IDeepCloneable<SourceCodeInfo.Types.Location>, IMessage
			{
				[CompilerGenerated]
				[Serializable]
				private sealed class __c
				{
					public static readonly SourceCodeInfo.Types.Location.__c __9 = new SourceCodeInfo.Types.Location.__c();

					internal SourceCodeInfo.Types.Location cctor>b__39_0()
					{
						return new SourceCodeInfo.Types.Location();
					}
				}

				private static readonly MessageParser<SourceCodeInfo.Types.Location> _parser = new MessageParser<SourceCodeInfo.Types.Location>(new Func<SourceCodeInfo.Types.Location>(SourceCodeInfo.Types.Location.__c.__9.<.cctor>b__39_0));

				public const int PathFieldNumber = 1;

				private static readonly FieldCodec<int> _repeated_path_codec = FieldCodec.ForInt32(10u);

				private readonly RepeatedField<int> path_ = new RepeatedField<int>();

				public const int SpanFieldNumber = 2;

				private static readonly FieldCodec<int> _repeated_span_codec = FieldCodec.ForInt32(18u);

				private readonly RepeatedField<int> span_ = new RepeatedField<int>();

				public const int LeadingCommentsFieldNumber = 3;

				private string leadingComments_ = "";

				public const int TrailingCommentsFieldNumber = 4;

				private string trailingComments_ = "";

				public static MessageParser<SourceCodeInfo.Types.Location> Parser
				{
					get
					{
						return SourceCodeInfo.Types.Location._parser;
					}
				}

				public static MessageDescriptor Descriptor
				{
					get
					{
						return SourceCodeInfo.Descriptor.NestedTypes[0];
					}
				}

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return SourceCodeInfo.Types.Location.Descriptor;
					}
				}

				public RepeatedField<int> Path
				{
					get
					{
						return this.path_;
					}
				}

				public RepeatedField<int> Span
				{
					get
					{
						return this.span_;
					}
				}

				public string LeadingComments
				{
					get
					{
						return this.leadingComments_;
					}
					set
					{
						this.leadingComments_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
					}
				}

				public string TrailingComments
				{
					get
					{
						return this.trailingComments_;
					}
					set
					{
						this.trailingComments_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
					}
				}

				public Location()
				{
				}

				public Location(SourceCodeInfo.Types.Location other) : this()
				{
					this.path_ = other.path_.Clone();
					this.span_ = other.span_.Clone();
					this.leadingComments_ = other.leadingComments_;
					this.trailingComments_ = other.trailingComments_;
				}

				public SourceCodeInfo.Types.Location Clone()
				{
					return new SourceCodeInfo.Types.Location(this);
				}

				public override bool Equals(object other)
				{
					return this.Equals(other as SourceCodeInfo.Types.Location);
				}

				public bool Equals(SourceCodeInfo.Types.Location other)
				{
					if (other == null)
					{
						goto IL_73;
					}
					goto IL_123;
					int arg_D5_0;
					while (true)
					{
						IL_D0:
						switch ((arg_D5_0 ^ -412922413) % 13)
						{
						case 1:
							return false;
						case 2:
							return false;
						case 3:
							arg_D5_0 = (SourceCodeInfo.Types.Location.smethod_0(this.LeadingComments, other.LeadingComments) ? -1823415606 : -2096372320);
							continue;
						case 4:
							goto IL_123;
						case 5:
							return false;
						case 6:
							arg_D5_0 = (this.path_.Equals(other.path_) ? -1963338242 : -309609019);
							continue;
						case 7:
							goto IL_73;
						case 8:
							arg_D5_0 = (this.span_.Equals(other.span_) ? -1253329141 : -1506828496);
							continue;
						case 9:
							return false;
						case 10:
							return false;
						case 11:
							arg_D5_0 = ((!SourceCodeInfo.Types.Location.smethod_0(this.TrailingComments, other.TrailingComments)) ? -1984696017 : -1866059674);
							continue;
						case 12:
							return true;
						}
						break;
					}
					return true;
					IL_73:
					arg_D5_0 = -2017480143;
					goto IL_D0;
					IL_123:
					arg_D5_0 = ((other != this) ? -235532001 : -1635374671);
					goto IL_D0;
				}

				public override int GetHashCode()
				{
					int num = 1 ^ SourceCodeInfo.Types.Location.smethod_1(this.path_);
					num ^= SourceCodeInfo.Types.Location.smethod_1(this.span_);
					while (true)
					{
						IL_D8:
						uint arg_B4_0 = 3225757323u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_B4_0 ^ 2232217509u)) % 6u)
							{
							case 1u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.LeadingComments);
								arg_B4_0 = (num2 * 331770645u ^ 1953872266u);
								continue;
							case 2u:
								arg_B4_0 = (((SourceCodeInfo.Types.Location.smethod_2(this.LeadingComments) == 0) ? 3895934629u : 2226522654u) ^ num2 * 1665030939u);
								continue;
							case 3u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.TrailingComments);
								arg_B4_0 = (num2 * 3589001151u ^ 1210425136u);
								continue;
							case 4u:
								arg_B4_0 = ((SourceCodeInfo.Types.Location.smethod_2(this.TrailingComments) != 0) ? 4053307708u : 3636376599u);
								continue;
							case 5u:
								goto IL_D8;
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
					this.path_.WriteTo(output, SourceCodeInfo.Types.Location._repeated_path_codec);
					while (true)
					{
						IL_128:
						uint arg_F7_0 = 4016646306u;
						while (true)
						{
							uint num;
							switch ((num = (arg_F7_0 ^ 2834536074u)) % 9u)
							{
							case 0u:
								output.WriteString(this.LeadingComments);
								arg_F7_0 = (num * 2728556441u ^ 4094913141u);
								continue;
							case 2u:
								arg_F7_0 = (((SourceCodeInfo.Types.Location.smethod_2(this.LeadingComments) != 0) ? 3435165636u : 4179773490u) ^ num * 435143793u);
								continue;
							case 3u:
								output.WriteString(this.TrailingComments);
								arg_F7_0 = (num * 3459587754u ^ 780050995u);
								continue;
							case 4u:
								output.WriteRawTag(26);
								arg_F7_0 = (num * 851861346u ^ 1153944790u);
								continue;
							case 5u:
								this.span_.WriteTo(output, SourceCodeInfo.Types.Location._repeated_span_codec);
								arg_F7_0 = (num * 2092002766u ^ 2793290631u);
								continue;
							case 6u:
								goto IL_128;
							case 7u:
								output.WriteRawTag(34);
								arg_F7_0 = (num * 1109870101u ^ 632310986u);
								continue;
							case 8u:
								arg_F7_0 = ((SourceCodeInfo.Types.Location.smethod_2(this.TrailingComments) != 0) ? 4208085521u : 3982652469u);
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
						IL_112:
						uint arg_E6_0 = 2855421691u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_E6_0 ^ 3011765341u)) % 8u)
							{
							case 0u:
								arg_E6_0 = ((SourceCodeInfo.Types.Location.smethod_2(this.TrailingComments) != 0) ? 3837652857u : 2296864130u);
								continue;
							case 1u:
								num += this.span_.CalculateSize(SourceCodeInfo.Types.Location._repeated_span_codec);
								arg_E6_0 = (num2 * 3238230227u ^ 3199817187u);
								continue;
							case 2u:
								num += 1 + CodedOutputStream.ComputeStringSize(this.LeadingComments);
								arg_E6_0 = (num2 * 2100283546u ^ 2284655521u);
								continue;
							case 3u:
								goto IL_112;
							case 4u:
								num += 1 + CodedOutputStream.ComputeStringSize(this.TrailingComments);
								arg_E6_0 = (num2 * 3108093966u ^ 2902771322u);
								continue;
							case 5u:
								arg_E6_0 = (((SourceCodeInfo.Types.Location.smethod_2(this.LeadingComments) != 0) ? 794356788u : 484304294u) ^ num2 * 3629793151u);
								continue;
							case 6u:
								num += this.path_.CalculateSize(SourceCodeInfo.Types.Location._repeated_path_codec);
								arg_E6_0 = (num2 * 797016928u ^ 1136514700u);
								continue;
							}
							return num;
						}
					}
					return num;
				}

				public void MergeFrom(SourceCodeInfo.Types.Location other)
				{
					if (other == null)
					{
						goto IL_71;
					}
					goto IL_B2;
					uint arg_7B_0;
					while (true)
					{
						IL_76:
						uint num;
						switch ((num = (arg_7B_0 ^ 2655529239u)) % 7u)
						{
						case 0u:
							goto IL_71;
						case 1u:
							goto IL_B2;
						case 2u:
							this.LeadingComments = other.LeadingComments;
							arg_7B_0 = (num * 909486776u ^ 1094130646u);
							continue;
						case 3u:
							this.TrailingComments = other.TrailingComments;
							arg_7B_0 = (num * 2445252415u ^ 1636155262u);
							continue;
						case 4u:
							return;
						case 5u:
							arg_7B_0 = ((SourceCodeInfo.Types.Location.smethod_2(other.TrailingComments) == 0) ? 3822791731u : 4057200484u);
							continue;
						}
						break;
					}
					return;
					IL_71:
					arg_7B_0 = 2646651881u;
					goto IL_76;
					IL_B2:
					this.path_.Add(other.path_);
					this.span_.Add(other.span_);
					arg_7B_0 = ((SourceCodeInfo.Types.Location.smethod_2(other.LeadingComments) != 0) ? 4049535965u : 4090887910u);
					goto IL_76;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_22B:
						uint num;
						uint arg_1C7_0 = ((num = input.ReadTag()) != 0u) ? 3338900507u : 3490427704u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_1C7_0 ^ 3575757851u)) % 18u)
							{
							case 0u:
								arg_1C7_0 = (num2 * 4161478824u ^ 2103420624u);
								continue;
							case 1u:
								this.path_.AddEntriesFrom(input, SourceCodeInfo.Types.Location._repeated_path_codec);
								arg_1C7_0 = 2227857680u;
								continue;
							case 2u:
								arg_1C7_0 = ((num <= 16u) ? 2859386605u : 4283208004u);
								continue;
							case 3u:
								arg_1C7_0 = (((num != 34u) ? 1520889365u : 1267782305u) ^ num2 * 2173165572u);
								continue;
							case 4u:
								this.TrailingComments = input.ReadString();
								arg_1C7_0 = 2227857680u;
								continue;
							case 5u:
								arg_1C7_0 = 3338900507u;
								continue;
							case 6u:
								arg_1C7_0 = (num2 * 2358789655u ^ 2159803823u);
								continue;
							case 8u:
								input.SkipLastField();
								arg_1C7_0 = 2183611349u;
								continue;
							case 9u:
								arg_1C7_0 = ((num == 18u) ? 2447739934u : 2669850999u);
								continue;
							case 10u:
								arg_1C7_0 = (((num != 8u) ? 3280687541u : 3841024010u) ^ num2 * 3329312757u);
								continue;
							case 11u:
								this.LeadingComments = input.ReadString();
								arg_1C7_0 = 2227857680u;
								continue;
							case 12u:
								arg_1C7_0 = (((num != 26u) ? 3138895318u : 3479952318u) ^ num2 * 1481422129u);
								continue;
							case 13u:
								arg_1C7_0 = (((num != 16u) ? 278902393u : 1407783438u) ^ num2 * 615822576u);
								continue;
							case 14u:
								arg_1C7_0 = (num2 * 255842685u ^ 4130925702u);
								continue;
							case 15u:
								goto IL_22B;
							case 16u:
								arg_1C7_0 = (((num != 10u) ? 1246054996u : 1063320292u) ^ num2 * 84701410u);
								continue;
							case 17u:
								this.span_.AddEntriesFrom(input, SourceCodeInfo.Types.Location._repeated_span_codec);
								arg_1C7_0 = 3200795651u;
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

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SourceCodeInfo.__c __9 = new SourceCodeInfo.__c();

			internal SourceCodeInfo cctor>b__25_0()
			{
				return new SourceCodeInfo();
			}
		}

		private static readonly MessageParser<SourceCodeInfo> _parser = new MessageParser<SourceCodeInfo>(new Func<SourceCodeInfo>(SourceCodeInfo.__c.__9.<.cctor>b__25_0));

		public const int LocationFieldNumber = 1;

		private static readonly FieldCodec<SourceCodeInfo.Types.Location> _repeated_location_codec = FieldCodec.ForMessage<SourceCodeInfo.Types.Location>(10u, SourceCodeInfo.Types.Location.Parser);

		private readonly RepeatedField<SourceCodeInfo.Types.Location> location_ = new RepeatedField<SourceCodeInfo.Types.Location>();

		public static MessageParser<SourceCodeInfo> Parser
		{
			get
			{
				return SourceCodeInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[17];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SourceCodeInfo.Descriptor;
			}
		}

		public RepeatedField<SourceCodeInfo.Types.Location> Location
		{
			get
			{
				return this.location_;
			}
		}

		public SourceCodeInfo()
		{
		}

		public SourceCodeInfo(SourceCodeInfo other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 4077766922u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 4205492862u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 2u:
						this.location_ = other.location_.Clone();
						arg_2B_0 = (num * 2197352714u ^ 2080953939u);
						continue;
					}
					return;
				}
			}
		}

		public SourceCodeInfo Clone()
		{
			return new SourceCodeInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SourceCodeInfo);
		}

		public bool Equals(SourceCodeInfo other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 1480823065) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					arg_48_0 = ((!this.location_.Equals(other.location_)) ? 959853688 : 67165120);
					continue;
				case 2:
					return true;
				case 3:
					return false;
				case 5:
					goto IL_7A;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 1924418814;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 758850387 : 872156750);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ SourceCodeInfo.smethod_0(this.location_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.location_.WriteTo(output, SourceCodeInfo._repeated_location_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.location_.CalculateSize(SourceCodeInfo._repeated_location_codec);
		}

		public void MergeFrom(SourceCodeInfo other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 460009694;
			IL_08:
			switch ((arg_0D_0 ^ 216567484) % 4)
			{
			case 0:
				goto IL_03;
			case 2:
				return;
			case 3:
				IL_27:
				this.location_.Add(other.location_);
				arg_0D_0 = 61140661;
				goto IL_08;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) == 0u) ? 462393682u : 1313306455u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 2120489703u)) % 6u)
					{
					case 0u:
						goto IL_9B;
					case 1u:
						this.location_.AddEntriesFrom(input, SourceCodeInfo._repeated_location_codec);
						arg_68_0 = 685738763u;
						continue;
					case 2u:
						arg_68_0 = ((num != 10u) ? 1848805924u : 1014496126u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_68_0 = (num2 * 1599018398u ^ 279305297u);
						continue;
					case 4u:
						arg_68_0 = 1313306455u;
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
