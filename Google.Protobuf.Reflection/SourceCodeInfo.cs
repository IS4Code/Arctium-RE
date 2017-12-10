using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class SourceCodeInfo : IMessage, IMessage<SourceCodeInfo>, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			[DebuggerNonUserCode]
			internal sealed class Location : IMessage, IMessage<SourceCodeInfo.Types.Location>, IEquatable<SourceCodeInfo.Types.Location>, IDeepCloneable<SourceCodeInfo.Types.Location>
			{
				[CompilerGenerated]
				[Serializable]
				private sealed class __c
				{
					public static readonly SourceCodeInfo.Types.Location.__c __9 = new SourceCodeInfo.Types.Location.__c();

					internal SourceCodeInfo.Types.Location cctor>b__44_0()
					{
						return new SourceCodeInfo.Types.Location();
					}
				}

				private static readonly MessageParser<SourceCodeInfo.Types.Location> _parser = new MessageParser<SourceCodeInfo.Types.Location>(new Func<SourceCodeInfo.Types.Location>(SourceCodeInfo.Types.Location.__c.__9.<.cctor>b__44_0));

				public const int PathFieldNumber = 1;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_ = new RepeatedField<int>();

				public const int SpanFieldNumber = 2;

				private static readonly FieldCodec<int> _repeated_span_codec;

				private readonly RepeatedField<int> span_ = new RepeatedField<int>();

				public const int LeadingCommentsFieldNumber = 3;

				private string leadingComments_ = "";

				public const int TrailingCommentsFieldNumber = 4;

				private string trailingComments_ = "";

				public const int LeadingDetachedCommentsFieldNumber = 6;

				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec;

				private readonly RepeatedField<string> leadingDetachedComments_ = new RepeatedField<string>();

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
						this.leadingComments_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
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
						this.trailingComments_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
					}
				}

				public RepeatedField<string> LeadingDetachedComments
				{
					get
					{
						return this.leadingDetachedComments_;
					}
				}

				public Location()
				{
				}

				public Location(SourceCodeInfo.Types.Location other) : this()
				{
					while (true)
					{
						IL_73:
						uint arg_57_0 = 3153497530u;
						while (true)
						{
							uint num;
							switch ((num = (arg_57_0 ^ 3289435179u)) % 4u)
							{
							case 0u:
								goto IL_73;
							case 1u:
								this.path_ = other.path_.Clone();
								this.span_ = other.span_.Clone();
								arg_57_0 = (num * 2096723653u ^ 658396857u);
								continue;
							case 3u:
								this.leadingComments_ = other.leadingComments_;
								arg_57_0 = (num * 931419334u ^ 4195484543u);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					this.trailingComments_ = other.trailingComments_;
					this.leadingDetachedComments_ = other.leadingDetachedComments_.Clone();
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
						goto IL_47;
					}
					goto IL_15D;
					int arg_107_0;
					while (true)
					{
						IL_102:
						switch ((arg_107_0 ^ 1099651523) % 15)
						{
						case 0:
							return false;
						case 1:
							return false;
						case 2:
							return true;
						case 3:
							return false;
						case 4:
							arg_107_0 = ((!this.path_.Equals(other.path_)) ? 542846911 : 311291481);
							continue;
						case 5:
							arg_107_0 = ((!SourceCodeInfo.Types.Location.smethod_0(this.TrailingComments, other.TrailingComments)) ? 2065850950 : 1609226087);
							continue;
						case 6:
							arg_107_0 = (this.span_.Equals(other.span_) ? 772020775 : 243829541);
							continue;
						case 7:
							return false;
						case 9:
							arg_107_0 = (SourceCodeInfo.Types.Location.smethod_0(this.LeadingComments, other.LeadingComments) ? 1091448227 : 208943912);
							continue;
						case 10:
							goto IL_47;
						case 11:
							goto IL_15D;
						case 12:
							return false;
						case 13:
							return false;
						case 14:
							arg_107_0 = ((!this.leadingDetachedComments_.Equals(other.leadingDetachedComments_)) ? 872150582 : 1291470615);
							continue;
						}
						break;
					}
					return true;
					IL_47:
					arg_107_0 = 521157702;
					goto IL_102;
					IL_15D:
					arg_107_0 = ((other == this) ? 273226328 : 1065212888);
					goto IL_102;
				}

				public override int GetHashCode()
				{
					int num = 1;
					while (true)
					{
						IL_11E:
						uint arg_ED_0 = 654438229u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_ED_0 ^ 153121532u)) % 9u)
							{
							case 0u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.leadingDetachedComments_);
								arg_ED_0 = 431439889u;
								continue;
							case 1u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.TrailingComments);
								arg_ED_0 = (num2 * 3407997320u ^ 4289998114u);
								continue;
							case 2u:
								arg_ED_0 = (((SourceCodeInfo.Types.Location.smethod_2(this.LeadingComments) != 0) ? 2557086200u : 2721721143u) ^ num2 * 327053999u);
								continue;
							case 3u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.path_);
								arg_ED_0 = (num2 * 513971317u ^ 91723982u);
								continue;
							case 4u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.LeadingComments);
								arg_ED_0 = (num2 * 3721583087u ^ 1120960189u);
								continue;
							case 5u:
								goto IL_11E;
							case 6u:
								num ^= SourceCodeInfo.Types.Location.smethod_1(this.span_);
								arg_ED_0 = (num2 * 89226662u ^ 3840611997u);
								continue;
							case 8u:
								arg_ED_0 = ((SourceCodeInfo.Types.Location.smethod_2(this.TrailingComments) == 0) ? 540392546u : 727603284u);
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
					this.path_.WriteTo(output, SourceCodeInfo.Types.Location._repeated_path_codec);
					this.span_.WriteTo(output, SourceCodeInfo.Types.Location._repeated_span_codec);
					if (SourceCodeInfo.Types.Location.smethod_2(this.LeadingComments) != 0)
					{
						goto IL_64;
					}
					goto IL_DC;
					uint arg_A9_0;
					while (true)
					{
						IL_A4:
						uint num;
						switch ((num = (arg_A9_0 ^ 2318686640u)) % 6u)
						{
						case 0u:
							this.leadingDetachedComments_.WriteTo(output, SourceCodeInfo.Types.Location._repeated_leadingDetachedComments_codec);
							arg_A9_0 = 2710623849u;
							continue;
						case 1u:
							output.WriteRawTag(26);
							output.WriteString(this.LeadingComments);
							arg_A9_0 = (num * 1409609262u ^ 2327915758u);
							continue;
						case 2u:
							goto IL_64;
						case 4u:
							goto IL_DC;
						case 5u:
							output.WriteRawTag(34);
							output.WriteString(this.TrailingComments);
							arg_A9_0 = (num * 2709206731u ^ 2005781299u);
							continue;
						}
						break;
					}
					return;
					IL_64:
					arg_A9_0 = 2152764343u;
					goto IL_A4;
					IL_DC:
					arg_A9_0 = ((SourceCodeInfo.Types.Location.smethod_2(this.TrailingComments) == 0) ? 2774488476u : 2675248797u);
					goto IL_A4;
				}

				public int CalculateSize()
				{
					int num = 0;
					while (true)
					{
						IL_112:
						uint arg_E6_0 = 3523705712u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_E6_0 ^ 3089949609u)) % 8u)
							{
							case 0u:
								goto IL_112;
							case 1u:
								num += this.path_.CalculateSize(SourceCodeInfo.Types.Location._repeated_path_codec);
								arg_E6_0 = (num2 * 2271461720u ^ 2144918575u);
								continue;
							case 3u:
								num += 1 + CodedOutputStream.ComputeStringSize(this.TrailingComments);
								arg_E6_0 = (num2 * 1150603920u ^ 4113252179u);
								continue;
							case 4u:
								arg_E6_0 = (((SourceCodeInfo.Types.Location.smethod_2(this.LeadingComments) != 0) ? 2475093608u : 4121376746u) ^ num2 * 1363156795u);
								continue;
							case 5u:
								num += 1 + CodedOutputStream.ComputeStringSize(this.LeadingComments);
								arg_E6_0 = (num2 * 1965598942u ^ 1997466504u);
								continue;
							case 6u:
								num += this.span_.CalculateSize(SourceCodeInfo.Types.Location._repeated_span_codec);
								arg_E6_0 = (num2 * 2570412302u ^ 387008177u);
								continue;
							case 7u:
								arg_E6_0 = ((SourceCodeInfo.Types.Location.smethod_2(this.TrailingComments) != 0) ? 3349412114u : 2980270179u);
								continue;
							}
							goto Block_3;
						}
					}
					Block_3:
					return num + this.leadingDetachedComments_.CalculateSize(SourceCodeInfo.Types.Location._repeated_leadingDetachedComments_codec);
				}

				public void MergeFrom(SourceCodeInfo.Types.Location other)
				{
					if (other == null)
					{
						goto IL_3E;
					}
					goto IL_E8;
					uint arg_B7_0;
					while (true)
					{
						IL_B2:
						uint num;
						switch ((num = (arg_B7_0 ^ 1503518762u)) % 9u)
						{
						case 0u:
							arg_B7_0 = (((SourceCodeInfo.Types.Location.smethod_2(other.LeadingComments) != 0) ? 2026406776u : 517504125u) ^ num * 3536642534u);
							continue;
						case 1u:
							arg_B7_0 = ((SourceCodeInfo.Types.Location.smethod_2(other.TrailingComments) != 0) ? 1832893644u : 34458745u);
							continue;
						case 2u:
							this.TrailingComments = other.TrailingComments;
							arg_B7_0 = (num * 4116098684u ^ 788569873u);
							continue;
						case 3u:
							goto IL_E8;
						case 4u:
							goto IL_3E;
						case 5u:
							return;
						case 6u:
							this.LeadingComments = other.LeadingComments;
							arg_B7_0 = (num * 79346819u ^ 562585227u);
							continue;
						case 8u:
							this.leadingDetachedComments_.Add(other.leadingDetachedComments_);
							arg_B7_0 = 1893843889u;
							continue;
						}
						break;
					}
					return;
					IL_3E:
					arg_B7_0 = 574794882u;
					goto IL_B2;
					IL_E8:
					this.path_.Add(other.path_);
					this.span_.Add(other.span_);
					arg_B7_0 = 2146525738u;
					goto IL_B2;
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_2E1:
						uint num;
						uint arg_265_0 = ((num = input.ReadTag()) == 0u) ? 1483763457u : 1479001340u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_265_0 ^ 107348929u)) % 24u)
							{
							case 0u:
								arg_265_0 = ((num != 34u) ? 79836670u : 1505574110u);
								continue;
							case 1u:
								arg_265_0 = (((num != 26u) ? 3034790919u : 3782532919u) ^ num2 * 3794944720u);
								continue;
							case 2u:
								arg_265_0 = (num2 * 3436949538u ^ 1539315321u);
								continue;
							case 3u:
								arg_265_0 = (num2 * 1943314891u ^ 4211913218u);
								continue;
							case 4u:
								arg_265_0 = (((num != 8u) ? 2110742302u : 97112772u) ^ num2 * 223217767u);
								continue;
							case 5u:
								arg_265_0 = ((num <= 16u) ? 299304101u : 473983375u);
								continue;
							case 6u:
								this.LeadingComments = input.ReadString();
								arg_265_0 = 1899788459u;
								continue;
							case 7u:
								arg_265_0 = (((num == 50u) ? 1754901085u : 1306296549u) ^ num2 * 3982955352u);
								continue;
							case 9u:
								this.path_.AddEntriesFrom(input, SourceCodeInfo.Types.Location._repeated_path_codec);
								arg_265_0 = 890139260u;
								continue;
							case 10u:
								arg_265_0 = 1479001340u;
								continue;
							case 11u:
								arg_265_0 = (((num == 10u) ? 2564194827u : 2221768939u) ^ num2 * 3362498737u);
								continue;
							case 12u:
								input.SkipLastField();
								arg_265_0 = 1315759386u;
								continue;
							case 13u:
								arg_265_0 = (num2 * 1292842976u ^ 2681886923u);
								continue;
							case 14u:
								arg_265_0 = ((num <= 26u) ? 1269126566u : 1718077737u);
								continue;
							case 15u:
								this.TrailingComments = input.ReadString();
								arg_265_0 = 1077808276u;
								continue;
							case 16u:
								this.span_.AddEntriesFrom(input, SourceCodeInfo.Types.Location._repeated_span_codec);
								arg_265_0 = 686456162u;
								continue;
							case 17u:
								arg_265_0 = (((num != 16u) ? 2552558833u : 3550599379u) ^ num2 * 3198891354u);
								continue;
							case 18u:
								goto IL_2E1;
							case 19u:
								arg_265_0 = (num2 * 679341760u ^ 2777545963u);
								continue;
							case 20u:
								this.leadingDetachedComments_.AddEntriesFrom(input, SourceCodeInfo.Types.Location._repeated_leadingDetachedComments_codec);
								arg_265_0 = 1899788459u;
								continue;
							case 21u:
								arg_265_0 = (num2 * 2009467264u ^ 3530809131u);
								continue;
							case 22u:
								arg_265_0 = (num2 * 212837685u ^ 1746765123u);
								continue;
							case 23u:
								arg_265_0 = (((num == 18u) ? 572319557u : 1257503828u) ^ num2 * 22004932u);
								continue;
							}
							return;
						}
					}
				}

				static Location()
				{
					// Note: this type is marked as 'beforefieldinit'.
					while (true)
					{
						IL_7D:
						uint arg_61_0 = 3312851954u;
						while (true)
						{
							uint num;
							switch ((num = (arg_61_0 ^ 3421084927u)) % 4u)
							{
							case 0u:
								SourceCodeInfo.Types.Location._repeated_span_codec = FieldCodec.ForInt32(18u);
								SourceCodeInfo.Types.Location._repeated_leadingDetachedComments_codec = FieldCodec.ForString(50u);
								arg_61_0 = (num * 3524145418u ^ 1786628465u);
								continue;
							case 1u:
								SourceCodeInfo.Types.Location._repeated_path_codec = FieldCodec.ForInt32(10u);
								arg_61_0 = (num * 3025576672u ^ 2268289631u);
								continue;
							case 3u:
								goto IL_7D;
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
			this.location_ = other.location_.Clone();
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
				switch ((arg_48_0 ^ -532956177) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return true;
				case 2:
					arg_48_0 = (this.location_.Equals(other.location_) ? -1929615000 : -1746326698);
					continue;
				case 3:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_7A;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1621297987;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1440105885 : -1820910294);
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
			int arg_0D_0 = -1087798744;
			IL_08:
			switch ((arg_0D_0 ^ -1945718335) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				return;
			case 3:
				IL_27:
				this.location_.Add(other.location_);
				arg_0D_0 = -2129871437;
				goto IL_08;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) == 0u) ? 876340576u : 74489794u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 445779342u)) % 7u)
					{
					case 0u:
						input.SkipLastField();
						arg_77_0 = (num2 * 3223753206u ^ 369690539u);
						continue;
					case 1u:
						arg_77_0 = ((num != 10u) ? 649945809u : 1536851786u);
						continue;
					case 2u:
						arg_77_0 = 74489794u;
						continue;
					case 4u:
						goto IL_AE;
					case 5u:
						this.location_.AddEntriesFrom(input, SourceCodeInfo._repeated_location_codec);
						arg_77_0 = 60810056u;
						continue;
					case 6u:
						arg_77_0 = (num2 * 1441373103u ^ 2985009577u);
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
