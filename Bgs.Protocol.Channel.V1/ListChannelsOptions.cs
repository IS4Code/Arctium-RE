using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class ListChannelsOptions : IMessage<ListChannelsOptions>, IEquatable<ListChannelsOptions>, IDeepCloneable<ListChannelsOptions>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ListChannelsOptions.__c __9 = new ListChannelsOptions.__c();

			internal ListChannelsOptions cctor>b__59_0()
			{
				return new ListChannelsOptions();
			}
		}

		private static readonly MessageParser<ListChannelsOptions> _parser = new MessageParser<ListChannelsOptions>(new Func<ListChannelsOptions>(ListChannelsOptions.__c.__9.<.cctor>b__59_0));

		public const int StartIndexFieldNumber = 1;

		private uint startIndex_;

		public const int MaxResultsFieldNumber = 2;

		private uint maxResults_;

		public const int NameFieldNumber = 3;

		private string name_ = "";

		public const int ProgramFieldNumber = 4;

		private uint program_;

		public const int LocaleFieldNumber = 5;

		private uint locale_;

		public const int CapacityFullFieldNumber = 6;

		private uint capacityFull_;

		public const int AttributeFilterFieldNumber = 7;

		private AttributeFilter attributeFilter_;

		public const int ChannelTypeFieldNumber = 8;

		private string channelType_ = "";

		public static MessageParser<ListChannelsOptions> Parser
		{
			get
			{
				return ListChannelsOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListChannelsOptions.Descriptor;
			}
		}

		public uint StartIndex
		{
			get
			{
				return this.startIndex_;
			}
			set
			{
				this.startIndex_ = value;
			}
		}

		public uint MaxResults
		{
			get
			{
				return this.maxResults_;
			}
			set
			{
				this.maxResults_ = value;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public uint Locale
		{
			get
			{
				return this.locale_;
			}
			set
			{
				this.locale_ = value;
			}
		}

		public uint CapacityFull
		{
			get
			{
				return this.capacityFull_;
			}
			set
			{
				this.capacityFull_ = value;
			}
		}

		public AttributeFilter AttributeFilter
		{
			get
			{
				return this.attributeFilter_;
			}
			set
			{
				this.attributeFilter_ = value;
			}
		}

		public string ChannelType
		{
			get
			{
				return this.channelType_;
			}
			set
			{
				this.channelType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public ListChannelsOptions()
		{
		}

		public ListChannelsOptions(ListChannelsOptions other) : this()
		{
			while (true)
			{
				IL_B7:
				uint arg_97_0 = 3325570453u;
				while (true)
				{
					uint num;
					switch ((num = (arg_97_0 ^ 2644902632u)) % 5u)
					{
					case 0u:
						this.capacityFull_ = other.capacityFull_;
						this.AttributeFilter = ((other.attributeFilter_ != null) ? other.AttributeFilter.Clone() : null);
						arg_97_0 = 3787716722u;
						continue;
					case 1u:
						this.startIndex_ = other.startIndex_;
						this.maxResults_ = other.maxResults_;
						this.name_ = other.name_;
						arg_97_0 = (num * 1008692473u ^ 1456313509u);
						continue;
					case 2u:
						this.program_ = other.program_;
						this.locale_ = other.locale_;
						arg_97_0 = (num * 2526046404u ^ 4176921743u);
						continue;
					case 3u:
						goto IL_B7;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.channelType_ = other.channelType_;
		}

		public ListChannelsOptions Clone()
		{
			return new ListChannelsOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ListChannelsOptions);
		}

		public bool Equals(ListChannelsOptions other)
		{
			if (other == null)
			{
				goto IL_120;
			}
			goto IL_1E6;
			int arg_178_0;
			while (true)
			{
				IL_173:
				switch ((arg_178_0 ^ -943803855) % 21)
				{
				case 0:
					return true;
				case 1:
					arg_178_0 = ((this.Program != other.Program) ? -2021084905 : -1126683269);
					continue;
				case 2:
					arg_178_0 = ((this.MaxResults != other.MaxResults) ? -1604307183 : -723244386);
					continue;
				case 3:
					goto IL_120;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_178_0 = ((this.CapacityFull != other.CapacityFull) ? -1641926169 : -2127954822);
					continue;
				case 7:
					goto IL_1E6;
				case 8:
					arg_178_0 = ((this.Locale == other.Locale) ? -131929152 : -1679363161);
					continue;
				case 9:
					return false;
				case 11:
					arg_178_0 = (ListChannelsOptions.smethod_0(this.ChannelType, other.ChannelType) ? -652720936 : -615261505);
					continue;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					arg_178_0 = ((this.StartIndex == other.StartIndex) ? -1723999604 : -383912141);
					continue;
				case 15:
					return false;
				case 16:
					arg_178_0 = (ListChannelsOptions.smethod_0(this.Name, other.Name) ? -1989645911 : -2039723548);
					continue;
				case 17:
					arg_178_0 = (ListChannelsOptions.smethod_1(this.AttributeFilter, other.AttributeFilter) ? -96227881 : -1698424902);
					continue;
				case 18:
					return false;
				case 19:
					return false;
				case 20:
					return false;
				}
				break;
			}
			return true;
			IL_120:
			arg_178_0 = -1008614805;
			goto IL_173;
			IL_1E6:
			arg_178_0 = ((other == this) ? -148893023 : -1618358983);
			goto IL_173;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartIndex != 0u)
			{
				goto IL_14F;
			}
			goto IL_236;
			uint arg_1DE_0;
			while (true)
			{
				IL_1D9:
				uint num2;
				switch ((num2 = (arg_1DE_0 ^ 1064501087u)) % 15u)
				{
				case 0u:
					arg_1DE_0 = ((this.CapacityFull == 0u) ? 391078355u : 830643332u);
					continue;
				case 1u:
					arg_1DE_0 = ((this.Program != 0u) ? 1740851690u : 1053956632u);
					continue;
				case 2u:
					num ^= this.CapacityFull.GetHashCode();
					arg_1DE_0 = (num2 * 3656263155u ^ 1920470578u);
					continue;
				case 3u:
					num ^= this.MaxResults.GetHashCode();
					arg_1DE_0 = (num2 * 1584179355u ^ 4008184443u);
					continue;
				case 4u:
					goto IL_14F;
				case 5u:
					num ^= this.StartIndex.GetHashCode();
					arg_1DE_0 = (num2 * 1890413766u ^ 1408143051u);
					continue;
				case 6u:
					num ^= this.Name.GetHashCode();
					arg_1DE_0 = (num2 * 70363042u ^ 3974991090u);
					continue;
				case 8u:
					goto IL_236;
				case 9u:
					num ^= this.AttributeFilter.GetHashCode();
					arg_1DE_0 = ((this.ChannelType.Length != 0) ? 1599177317u : 1647880629u);
					continue;
				case 10u:
					arg_1DE_0 = ((this.Name.Length == 0) ? 1745103666u : 1631654591u);
					continue;
				case 11u:
					arg_1DE_0 = ((this.Locale != 0u) ? 1364503252u : 1738662947u);
					continue;
				case 12u:
					num ^= this.Locale.GetHashCode();
					arg_1DE_0 = (num2 * 1549355789u ^ 3824481580u);
					continue;
				case 13u:
					num ^= this.Program.GetHashCode();
					arg_1DE_0 = (num2 * 2781385531u ^ 3717533871u);
					continue;
				case 14u:
					num ^= this.ChannelType.GetHashCode();
					arg_1DE_0 = (num2 * 4185499116u ^ 2028960461u);
					continue;
				}
				break;
			}
			return num;
			IL_14F:
			arg_1DE_0 = 37207508u;
			goto IL_1D9;
			IL_236:
			arg_1DE_0 = ((this.MaxResults != 0u) ? 205425522u : 711710020u);
			goto IL_1D9;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.StartIndex != 0u)
			{
				goto IL_234;
			}
			goto IL_2A6;
			uint arg_23E_0;
			while (true)
			{
				IL_239:
				uint num;
				switch ((num = (arg_23E_0 ^ 4060144007u)) % 19u)
				{
				case 0u:
					goto IL_234;
				case 1u:
					output.WriteRawTag(58);
					arg_23E_0 = 2375956189u;
					continue;
				case 2u:
					output.WriteRawTag(16);
					output.WriteUInt32(this.MaxResults);
					arg_23E_0 = (num * 2090578025u ^ 2899257598u);
					continue;
				case 3u:
					output.WriteRawTag(66);
					arg_23E_0 = (num * 2949946763u ^ 619420464u);
					continue;
				case 4u:
					arg_23E_0 = ((this.Program == 0u) ? 2254195981u : 3889924566u);
					continue;
				case 5u:
					output.WriteRawTag(45);
					output.WriteFixed32(this.Locale);
					arg_23E_0 = (num * 3011122707u ^ 4140584205u);
					continue;
				case 7u:
					output.WriteString(this.ChannelType);
					arg_23E_0 = (num * 1471882319u ^ 2440105804u);
					continue;
				case 8u:
					output.WriteRawTag(26);
					output.WriteString(this.Name);
					arg_23E_0 = (num * 441301596u ^ 923459440u);
					continue;
				case 9u:
					output.WriteRawTag(48);
					arg_23E_0 = (num * 2318753882u ^ 3449675381u);
					continue;
				case 10u:
					goto IL_2A6;
				case 11u:
					output.WriteFixed32(this.Program);
					arg_23E_0 = (num * 1339226718u ^ 3055921497u);
					continue;
				case 12u:
					output.WriteRawTag(8);
					output.WriteUInt32(this.StartIndex);
					arg_23E_0 = (num * 1525315782u ^ 2540018246u);
					continue;
				case 13u:
					arg_23E_0 = ((this.Locale != 0u) ? 3116777540u : 3613298292u);
					continue;
				case 14u:
					arg_23E_0 = ((this.CapacityFull != 0u) ? 3110722040u : 3150627041u);
					continue;
				case 15u:
					arg_23E_0 = ((ListChannelsOptions.smethod_2(this.Name) != 0) ? 3880387252u : 2740546340u);
					continue;
				case 16u:
					output.WriteUInt32(this.CapacityFull);
					arg_23E_0 = (num * 3209139751u ^ 845592877u);
					continue;
				case 17u:
					output.WriteRawTag(37);
					arg_23E_0 = (num * 2628151050u ^ 3239592539u);
					continue;
				case 18u:
					output.WriteMessage(this.AttributeFilter);
					arg_23E_0 = (((ListChannelsOptions.smethod_2(this.ChannelType) != 0) ? 2693576053u : 4168565283u) ^ num * 172807682u);
					continue;
				}
				break;
			}
			return;
			IL_234:
			arg_23E_0 = 3140255784u;
			goto IL_239;
			IL_2A6:
			arg_23E_0 = ((this.MaxResults != 0u) ? 3357757792u : 3469768257u);
			goto IL_239;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_255:
				uint arg_204_0 = 4075893891u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_204_0 ^ 3487218876u)) % 17u)
					{
					case 0u:
						arg_204_0 = ((this.Locale == 0u) ? 2199617314u : 2855692288u);
						continue;
					case 1u:
						arg_204_0 = (((ListChannelsOptions.smethod_2(this.ChannelType) != 0) ? 2030392519u : 1152532521u) ^ num2 * 182011302u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelType);
						arg_204_0 = (num2 * 3254713230u ^ 3067181377u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_204_0 = (num2 * 598277745u ^ 1858877272u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.StartIndex);
						arg_204_0 = (num2 * 1176717702u ^ 1149230182u);
						continue;
					case 6u:
						num += 5;
						arg_204_0 = (num2 * 974566898u ^ 795441818u);
						continue;
					case 7u:
						goto IL_255;
					case 8u:
						num += 5;
						arg_204_0 = (num2 * 2674188975u ^ 1405295104u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxResults);
						arg_204_0 = (num2 * 2373208270u ^ 2518526108u);
						continue;
					case 10u:
						arg_204_0 = ((this.CapacityFull != 0u) ? 3306789954u : 2865211491u);
						continue;
					case 11u:
						arg_204_0 = ((this.Program == 0u) ? 2545103035u : 2470778633u);
						continue;
					case 12u:
						arg_204_0 = ((ListChannelsOptions.smethod_2(this.Name) == 0) ? 2158510260u : 3722541072u);
						continue;
					case 13u:
						arg_204_0 = ((this.MaxResults != 0u) ? 3938021451u : 2231225950u);
						continue;
					case 14u:
						arg_204_0 = (((this.StartIndex == 0u) ? 1686377021u : 1983313889u) ^ num2 * 4119093113u);
						continue;
					case 15u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CapacityFull);
						arg_204_0 = (num2 * 2596663229u ^ 3885356517u);
						continue;
					case 16u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AttributeFilter);
						arg_204_0 = 2198724353u;
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ListChannelsOptions other)
		{
			if (other == null)
			{
				goto IL_9F;
			}
			goto IL_2C8;
			uint arg_258_0;
			while (true)
			{
				IL_253:
				uint num;
				switch ((num = (arg_258_0 ^ 4105045435u)) % 21u)
				{
				case 0u:
					arg_258_0 = ((ListChannelsOptions.smethod_2(other.ChannelType) == 0) ? 2355860090u : 3114016056u);
					continue;
				case 1u:
					this.AttributeFilter.MergeFrom(other.AttributeFilter);
					arg_258_0 = 4212222669u;
					continue;
				case 2u:
					arg_258_0 = (((this.attributeFilter_ != null) ? 679618758u : 294125222u) ^ num * 2024246580u);
					continue;
				case 3u:
					arg_258_0 = ((other.Program != 0u) ? 2825710528u : 3713110160u);
					continue;
				case 4u:
					this.CapacityFull = other.CapacityFull;
					arg_258_0 = (num * 1719051169u ^ 2756419611u);
					continue;
				case 5u:
					goto IL_2C8;
				case 6u:
					this.attributeFilter_ = new AttributeFilter();
					arg_258_0 = (num * 3668562634u ^ 2631529624u);
					continue;
				case 7u:
					arg_258_0 = ((other.attributeFilter_ != null) ? 3264778934u : 4212222669u);
					continue;
				case 8u:
					this.Program = other.Program;
					arg_258_0 = (num * 3810557539u ^ 1819497217u);
					continue;
				case 9u:
					arg_258_0 = ((ListChannelsOptions.smethod_2(other.Name) == 0) ? 3506446620u : 2618466495u);
					continue;
				case 10u:
					return;
				case 11u:
					this.MaxResults = other.MaxResults;
					arg_258_0 = (num * 3368549554u ^ 188982307u);
					continue;
				case 12u:
					this.ChannelType = other.ChannelType;
					arg_258_0 = (num * 810682312u ^ 2611947810u);
					continue;
				case 13u:
					this.Locale = other.Locale;
					arg_258_0 = (num * 3718110149u ^ 4038999092u);
					continue;
				case 14u:
					arg_258_0 = ((other.Locale != 0u) ? 3194552601u : 2378767006u);
					continue;
				case 15u:
					goto IL_9F;
				case 17u:
					this.Name = other.Name;
					arg_258_0 = (num * 1475222873u ^ 1560212344u);
					continue;
				case 18u:
					this.StartIndex = other.StartIndex;
					arg_258_0 = (num * 3645300672u ^ 2746318202u);
					continue;
				case 19u:
					arg_258_0 = ((other.CapacityFull != 0u) ? 2705785204u : 3008262964u);
					continue;
				case 20u:
					arg_258_0 = ((other.MaxResults == 0u) ? 3605418415u : 3495784845u);
					continue;
				}
				break;
			}
			return;
			IL_9F:
			arg_258_0 = 3472454790u;
			goto IL_253;
			IL_2C8:
			arg_258_0 = ((other.StartIndex == 0u) ? 3897635770u : 3008556542u);
			goto IL_253;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3F7:
				uint num;
				uint arg_353_0 = ((num = input.ReadTag()) != 0u) ? 153474601u : 2012332127u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_353_0 ^ 1144375476u)) % 34u)
					{
					case 0u:
						this.CapacityFull = input.ReadUInt32();
						arg_353_0 = 551806783u;
						continue;
					case 1u:
						this.StartIndex = input.ReadUInt32();
						arg_353_0 = 712001555u;
						continue;
					case 2u:
						arg_353_0 = (num2 * 4147591553u ^ 675607262u);
						continue;
					case 3u:
						arg_353_0 = (((num != 45u) ? 2052657265u : 1496770542u) ^ num2 * 710135660u);
						continue;
					case 4u:
						this.Program = input.ReadFixed32();
						arg_353_0 = 711955894u;
						continue;
					case 5u:
						input.ReadMessage(this.attributeFilter_);
						arg_353_0 = 338811344u;
						continue;
					case 6u:
						arg_353_0 = (num2 * 2403907790u ^ 303144524u);
						continue;
					case 7u:
						arg_353_0 = (num2 * 2559375546u ^ 1568729902u);
						continue;
					case 8u:
						arg_353_0 = (num2 * 396764355u ^ 2753171277u);
						continue;
					case 9u:
						arg_353_0 = (num2 * 1779498436u ^ 138330527u);
						continue;
					case 10u:
						arg_353_0 = (num2 * 3390951969u ^ 2907225388u);
						continue;
					case 11u:
						arg_353_0 = (((num == 48u) ? 2405043671u : 3445429060u) ^ num2 * 2112564979u);
						continue;
					case 12u:
						arg_353_0 = (((num <= 16u) ? 1946999411u : 2041388189u) ^ num2 * 2883204430u);
						continue;
					case 13u:
						arg_353_0 = ((num != 26u) ? 1755297881u : 1247327042u);
						continue;
					case 14u:
						goto IL_3F7;
					case 15u:
						arg_353_0 = (num2 * 1038584718u ^ 3710439538u);
						continue;
					case 16u:
						this.Name = input.ReadString();
						arg_353_0 = 338811344u;
						continue;
					case 17u:
						input.SkipLastField();
						arg_353_0 = 2089301448u;
						continue;
					case 18u:
						arg_353_0 = (num2 * 2875762275u ^ 1086819762u);
						continue;
					case 19u:
						arg_353_0 = (((num != 37u) ? 2348312541u : 2538647386u) ^ num2 * 2229741636u);
						continue;
					case 20u:
						this.MaxResults = input.ReadUInt32();
						arg_353_0 = 1419060738u;
						continue;
					case 21u:
						arg_353_0 = (((num != 66u) ? 5331762u : 1050419436u) ^ num2 * 4099860081u);
						continue;
					case 22u:
						arg_353_0 = ((num == 58u) ? 239127930u : 392277509u);
						continue;
					case 23u:
						this.attributeFilter_ = new AttributeFilter();
						arg_353_0 = (num2 * 2843077579u ^ 807775310u);
						continue;
					case 24u:
						arg_353_0 = (((num != 16u) ? 2208785782u : 3011456522u) ^ num2 * 428797899u);
						continue;
					case 25u:
						arg_353_0 = ((num > 37u) ? 1603168644u : 140072164u);
						continue;
					case 26u:
						arg_353_0 = 153474601u;
						continue;
					case 27u:
						this.ChannelType = input.ReadString();
						arg_353_0 = 338811344u;
						continue;
					case 28u:
						arg_353_0 = ((this.attributeFilter_ != null) ? 1004299399u : 254606223u);
						continue;
					case 29u:
						arg_353_0 = (((num != 8u) ? 666076826u : 1917107179u) ^ num2 * 617388890u);
						continue;
					case 30u:
						this.Locale = input.ReadFixed32();
						arg_353_0 = 1168297658u;
						continue;
					case 32u:
						arg_353_0 = ((num <= 48u) ? 1525965403u : 632180082u);
						continue;
					case 33u:
						arg_353_0 = (num2 * 1489257006u ^ 2144728357u);
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
	}
}
