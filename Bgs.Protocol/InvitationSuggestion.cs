using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class InvitationSuggestion : IMessage<InvitationSuggestion>, IEquatable<InvitationSuggestion>, IDeepCloneable<InvitationSuggestion>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly InvitationSuggestion.__c __9 = new InvitationSuggestion.__c();

			internal InvitationSuggestion cctor>b__49_0()
			{
				return new InvitationSuggestion();
			}
		}

		private static readonly MessageParser<InvitationSuggestion> _parser = new MessageParser<InvitationSuggestion>(new Func<InvitationSuggestion>(InvitationSuggestion.__c.__9.<.cctor>b__49_0));

		public const int ChannelIdFieldNumber = 1;

		private EntityId channelId_;

		public const int SuggesterIdFieldNumber = 2;

		private EntityId suggesterId_;

		public const int SuggesteeIdFieldNumber = 3;

		private EntityId suggesteeId_;

		public const int SuggesterNameFieldNumber = 4;

		private string suggesterName_ = "";

		public const int SuggesteeNameFieldNumber = 5;

		private string suggesteeName_ = "";

		public const int SuggesterAccountIdFieldNumber = 6;

		private EntityId suggesterAccountId_;

		public static MessageParser<InvitationSuggestion> Parser
		{
			get
			{
				return InvitationSuggestion._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationSuggestion.Descriptor;
			}
		}

		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		public EntityId SuggesterId
		{
			get
			{
				return this.suggesterId_;
			}
			set
			{
				this.suggesterId_ = value;
			}
		}

		public EntityId SuggesteeId
		{
			get
			{
				return this.suggesteeId_;
			}
			set
			{
				this.suggesteeId_ = value;
			}
		}

		public string SuggesterName
		{
			get
			{
				return this.suggesterName_;
			}
			set
			{
				this.suggesterName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public string SuggesteeName
		{
			get
			{
				return this.suggesteeName_;
			}
			set
			{
				this.suggesteeName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public EntityId SuggesterAccountId
		{
			get
			{
				return this.suggesterAccountId_;
			}
			set
			{
				this.suggesterAccountId_ = value;
			}
		}

		public InvitationSuggestion()
		{
		}

		public InvitationSuggestion(InvitationSuggestion other) : this()
		{
			while (true)
			{
				IL_D3:
				uint arg_B3_0 = 923504551u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B3_0 ^ 101566266u)) % 5u)
					{
					case 0u:
						goto IL_D3;
					case 1u:
						this.suggesterName_ = other.suggesterName_;
						arg_B3_0 = (num * 831811723u ^ 3725736302u);
						continue;
					case 2u:
						this.suggesteeName_ = other.suggesteeName_;
						this.SuggesterAccountId = ((other.suggesterAccountId_ != null) ? other.SuggesterAccountId.Clone() : null);
						arg_B3_0 = 950075000u;
						continue;
					case 4u:
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						this.SuggesterId = ((other.suggesterId_ != null) ? other.SuggesterId.Clone() : null);
						this.SuggesteeId = ((other.suggesteeId_ != null) ? other.SuggesteeId.Clone() : null);
						arg_B3_0 = 1295009835u;
						continue;
					}
					return;
				}
			}
		}

		public InvitationSuggestion Clone()
		{
			return new InvitationSuggestion(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationSuggestion);
		}

		public bool Equals(InvitationSuggestion other)
		{
			if (other == null)
			{
				goto IL_12C;
			}
			goto IL_194;
			int arg_136_0;
			while (true)
			{
				IL_131:
				switch ((arg_136_0 ^ -1418549231) % 17)
				{
				case 0:
					goto IL_194;
				case 1:
					return false;
				case 2:
					goto IL_12C;
				case 3:
					arg_136_0 = ((!InvitationSuggestion.smethod_0(this.SuggesterAccountId, other.SuggesterAccountId)) ? -2136050683 : -218472277);
					continue;
				case 4:
					return false;
				case 5:
					arg_136_0 = (InvitationSuggestion.smethod_0(this.SuggesteeId, other.SuggesteeId) ? -895494629 : -1831385974);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_136_0 = (InvitationSuggestion.smethod_0(this.ChannelId, other.ChannelId) ? -1500949206 : -672596040);
					continue;
				case 9:
					arg_136_0 = (InvitationSuggestion.smethod_1(this.SuggesteeName, other.SuggesteeName) ? -847041342 : -1365576741);
					continue;
				case 10:
					return false;
				case 11:
					arg_136_0 = (InvitationSuggestion.smethod_1(this.SuggesterName, other.SuggesterName) ? -582847877 : -1568410003);
					continue;
				case 12:
					return true;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_136_0 = ((!InvitationSuggestion.smethod_0(this.SuggesterId, other.SuggesterId)) ? -357839470 : -1251426085);
					continue;
				}
				break;
			}
			return true;
			IL_12C:
			arg_136_0 = -1670833078;
			goto IL_131;
			IL_194:
			arg_136_0 = ((other == this) ? -471326322 : -679116353);
			goto IL_131;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.channelId_ != null)
			{
				goto IL_72;
			}
			goto IL_14E;
			uint arg_119_0;
			while (true)
			{
				IL_114:
				uint num2;
				switch ((num2 = (arg_119_0 ^ 1240381045u)) % 10u)
				{
				case 0u:
					num ^= InvitationSuggestion.smethod_2(this.SuggesteeName);
					arg_119_0 = (num2 * 2802701932u ^ 2138981979u);
					continue;
				case 1u:
					num ^= InvitationSuggestion.smethod_2(this.SuggesterName);
					arg_119_0 = (num2 * 667275016u ^ 3012329370u);
					continue;
				case 2u:
					num ^= InvitationSuggestion.smethod_2(this.ChannelId);
					arg_119_0 = (num2 * 4005828524u ^ 1597893404u);
					continue;
				case 3u:
					arg_119_0 = ((InvitationSuggestion.smethod_3(this.SuggesteeName) != 0) ? 711576341u : 1118397147u);
					continue;
				case 4u:
					num ^= InvitationSuggestion.smethod_2(this.SuggesterAccountId);
					arg_119_0 = (num2 * 2183770001u ^ 3120043821u);
					continue;
				case 5u:
					goto IL_72;
				case 7u:
					goto IL_14E;
				case 8u:
					arg_119_0 = ((this.suggesterAccountId_ == null) ? 859635899u : 1083255107u);
					continue;
				case 9u:
					num ^= InvitationSuggestion.smethod_2(this.SuggesteeId);
					arg_119_0 = (((InvitationSuggestion.smethod_3(this.SuggesterName) == 0) ? 1007220131u : 1353237551u) ^ num2 * 203152565u);
					continue;
				}
				break;
			}
			return num;
			IL_72:
			arg_119_0 = 1891852499u;
			goto IL_114;
			IL_14E:
			num ^= InvitationSuggestion.smethod_2(this.SuggesterId);
			arg_119_0 = 983592072u;
			goto IL_114;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.channelId_ != null)
			{
				goto IL_45;
			}
			goto IL_1E4;
			uint arg_19B_0;
			while (true)
			{
				IL_196:
				uint num;
				switch ((num = (arg_19B_0 ^ 1401088666u)) % 15u)
				{
				case 0u:
					arg_19B_0 = ((this.suggesterAccountId_ == null) ? 1156015397u : 1950123970u);
					continue;
				case 1u:
					output.WriteMessage(this.ChannelId);
					arg_19B_0 = (num * 2197614798u ^ 3753927412u);
					continue;
				case 2u:
					goto IL_1E4;
				case 3u:
					arg_19B_0 = (((InvitationSuggestion.smethod_3(this.SuggesterName) != 0) ? 3332444920u : 2403610705u) ^ num * 790011979u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					arg_19B_0 = (num * 464976099u ^ 4159653503u);
					continue;
				case 5u:
					arg_19B_0 = ((InvitationSuggestion.smethod_3(this.SuggesteeName) != 0) ? 2068816530u : 2142368912u);
					continue;
				case 6u:
					output.WriteRawTag(50);
					output.WriteMessage(this.SuggesterAccountId);
					arg_19B_0 = (num * 1932786831u ^ 3010384141u);
					continue;
				case 7u:
					output.WriteMessage(this.SuggesterId);
					arg_19B_0 = (num * 2408723726u ^ 801297002u);
					continue;
				case 9u:
					output.WriteString(this.SuggesterName);
					arg_19B_0 = (num * 3855396629u ^ 2363587688u);
					continue;
				case 10u:
					output.WriteRawTag(42);
					output.WriteString(this.SuggesteeName);
					arg_19B_0 = (num * 2599933363u ^ 3682726152u);
					continue;
				case 11u:
					output.WriteRawTag(26);
					arg_19B_0 = (num * 2736694029u ^ 2112272217u);
					continue;
				case 12u:
					goto IL_45;
				case 13u:
					output.WriteRawTag(34);
					arg_19B_0 = (num * 619878697u ^ 389352549u);
					continue;
				case 14u:
					output.WriteMessage(this.SuggesteeId);
					arg_19B_0 = (num * 4074381017u ^ 4097648481u);
					continue;
				}
				break;
			}
			return;
			IL_45:
			arg_19B_0 = 1161032975u;
			goto IL_196;
			IL_1E4:
			output.WriteRawTag(18);
			arg_19B_0 = 1445506212u;
			goto IL_196;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1A9:
				uint arg_16C_0 = 3179800592u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_16C_0 ^ 2174748983u)) % 12u)
					{
					case 0u:
						arg_16C_0 = ((this.suggesterAccountId_ != null) ? 2683967130u : 4215314621u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_16C_0 = (num2 * 2277467505u ^ 1106949385u);
						continue;
					case 3u:
						arg_16C_0 = (((this.channelId_ == null) ? 2290530223u : 4103572065u) ^ num2 * 728596625u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.SuggesterName);
						arg_16C_0 = (num2 * 3903464918u ^ 1181517770u);
						continue;
					case 5u:
						arg_16C_0 = ((InvitationSuggestion.smethod_3(this.SuggesteeName) == 0) ? 2489075263u : 3702853953u);
						continue;
					case 6u:
						arg_16C_0 = (((InvitationSuggestion.smethod_3(this.SuggesterName) == 0) ? 2376649406u : 2948832887u) ^ num2 * 604669518u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SuggesterId);
						arg_16C_0 = 3256908080u;
						continue;
					case 8u:
						goto IL_1A9;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SuggesterAccountId);
						arg_16C_0 = (num2 * 340963548u ^ 1340387345u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.SuggesteeName);
						arg_16C_0 = (num2 * 1022255053u ^ 1475356225u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SuggesteeId);
						arg_16C_0 = (num2 * 1170205037u ^ 2245506766u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(InvitationSuggestion other)
		{
			if (other == null)
			{
				goto IL_260;
			}
			goto IL_31B;
			uint arg_2A3_0;
			while (true)
			{
				IL_29E:
				uint num;
				switch ((num = (arg_2A3_0 ^ 1006691244u)) % 23u)
				{
				case 0u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_2A3_0 = 495137104u;
					continue;
				case 1u:
					arg_2A3_0 = ((other.suggesterAccountId_ == null) ? 1993422753u : 753686612u);
					continue;
				case 2u:
					goto IL_260;
				case 3u:
					arg_2A3_0 = (((this.suggesteeId_ == null) ? 1207044086u : 1967447391u) ^ num * 3364392259u);
					continue;
				case 4u:
					this.suggesterId_ = new EntityId();
					arg_2A3_0 = (num * 1045098435u ^ 2702039702u);
					continue;
				case 5u:
					this.SuggesteeId.MergeFrom(other.SuggesteeId);
					arg_2A3_0 = 830495254u;
					continue;
				case 6u:
					this.SuggesterId.MergeFrom(other.SuggesterId);
					arg_2A3_0 = 576429852u;
					continue;
				case 7u:
					arg_2A3_0 = (((this.suggesterAccountId_ != null) ? 1605997734u : 147686950u) ^ num * 735477218u);
					continue;
				case 8u:
					arg_2A3_0 = ((other.suggesterId_ != null) ? 1249187981u : 576429852u);
					continue;
				case 9u:
					arg_2A3_0 = (((this.channelId_ == null) ? 57425618u : 1186019633u) ^ num * 3921884949u);
					continue;
				case 10u:
					this.SuggesterAccountId.MergeFrom(other.SuggesterAccountId);
					arg_2A3_0 = 1993422753u;
					continue;
				case 11u:
					arg_2A3_0 = (((this.suggesterId_ == null) ? 1252001890u : 1533694474u) ^ num * 1628961321u);
					continue;
				case 12u:
					this.SuggesteeName = other.SuggesteeName;
					arg_2A3_0 = (num * 4287128908u ^ 1153866285u);
					continue;
				case 13u:
					arg_2A3_0 = ((InvitationSuggestion.smethod_3(other.SuggesterName) == 0) ? 1866213443u : 2081000305u);
					continue;
				case 14u:
					this.suggesteeId_ = new EntityId();
					arg_2A3_0 = (num * 102155408u ^ 612457071u);
					continue;
				case 15u:
					arg_2A3_0 = ((other.suggesteeId_ == null) ? 830495254u : 1760228764u);
					continue;
				case 16u:
					this.channelId_ = new EntityId();
					arg_2A3_0 = (num * 4109819045u ^ 470032875u);
					continue;
				case 17u:
					goto IL_31B;
				case 18u:
					arg_2A3_0 = ((InvitationSuggestion.smethod_3(other.SuggesteeName) != 0) ? 1903844745u : 148607441u);
					continue;
				case 19u:
					this.SuggesterName = other.SuggesterName;
					arg_2A3_0 = (num * 1478669548u ^ 3841861631u);
					continue;
				case 21u:
					return;
				case 22u:
					this.suggesterAccountId_ = new EntityId();
					arg_2A3_0 = (num * 1990182484u ^ 3168654430u);
					continue;
				}
				break;
			}
			return;
			IL_260:
			arg_2A3_0 = 1559605133u;
			goto IL_29E;
			IL_31B:
			arg_2A3_0 = ((other.channelId_ != null) ? 1957145519u : 495137104u);
			goto IL_29E;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3A6:
				uint num;
				uint arg_312_0 = ((num = input.ReadTag()) == 0u) ? 326491874u : 1160815361u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_312_0 ^ 235255381u)) % 30u)
					{
					case 0u:
						arg_312_0 = (num2 * 1361077101u ^ 171641408u);
						continue;
					case 1u:
						arg_312_0 = ((this.suggesterId_ == null) ? 2127596175u : 948717331u);
						continue;
					case 2u:
						arg_312_0 = (num2 * 1684155503u ^ 3253587660u);
						continue;
					case 3u:
						arg_312_0 = (num2 * 4043847144u ^ 3515403356u);
						continue;
					case 4u:
						arg_312_0 = ((this.channelId_ != null) ? 2120109861u : 1583921255u);
						continue;
					case 5u:
						this.suggesteeId_ = new EntityId();
						arg_312_0 = (num2 * 1791477655u ^ 2417178947u);
						continue;
					case 6u:
						input.ReadMessage(this.suggesterAccountId_);
						arg_312_0 = 1527009636u;
						continue;
					case 7u:
						input.SkipLastField();
						arg_312_0 = 1572889767u;
						continue;
					case 8u:
						arg_312_0 = ((num <= 26u) ? 731568461u : 1356056686u);
						continue;
					case 9u:
						input.ReadMessage(this.suggesteeId_);
						arg_312_0 = 1527009636u;
						continue;
					case 10u:
						arg_312_0 = (((num == 26u) ? 98268982u : 329403365u) ^ num2 * 3319886274u);
						continue;
					case 11u:
						arg_312_0 = ((this.suggesteeId_ == null) ? 1231135192u : 182470248u);
						continue;
					case 12u:
						arg_312_0 = (num2 * 4280375714u ^ 1404292672u);
						continue;
					case 13u:
						arg_312_0 = ((num != 34u) ? 520046364u : 1819704682u);
						continue;
					case 14u:
						arg_312_0 = (num2 * 914542339u ^ 1634846994u);
						continue;
					case 15u:
						arg_312_0 = 1160815361u;
						continue;
					case 16u:
						arg_312_0 = (((num == 10u) ? 2562448477u : 2765934402u) ^ num2 * 2585703342u);
						continue;
					case 17u:
						arg_312_0 = (((num == 18u) ? 386177064u : 770102681u) ^ num2 * 2932145240u);
						continue;
					case 18u:
						this.suggesterId_ = new EntityId();
						arg_312_0 = (num2 * 3321372159u ^ 2045773877u);
						continue;
					case 19u:
						this.SuggesteeName = input.ReadString();
						arg_312_0 = 350701709u;
						continue;
					case 20u:
						arg_312_0 = ((this.suggesterAccountId_ == null) ? 731701949u : 739221281u);
						continue;
					case 21u:
						goto IL_3A6;
					case 22u:
						input.ReadMessage(this.suggesterId_);
						arg_312_0 = 1318476390u;
						continue;
					case 24u:
						input.ReadMessage(this.channelId_);
						arg_312_0 = 1527009636u;
						continue;
					case 25u:
						arg_312_0 = (((num != 42u) ? 60968406u : 814787386u) ^ num2 * 632838744u);
						continue;
					case 26u:
						this.suggesterAccountId_ = new EntityId();
						arg_312_0 = (num2 * 1311257761u ^ 2464291529u);
						continue;
					case 27u:
						arg_312_0 = (((num == 50u) ? 3442620892u : 3389198585u) ^ num2 * 3760827891u);
						continue;
					case 28u:
						this.channelId_ = new EntityId();
						arg_312_0 = (num2 * 3982606531u ^ 3338084147u);
						continue;
					case 29u:
						this.SuggesterName = input.ReadString();
						arg_312_0 = 91172487u;
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
