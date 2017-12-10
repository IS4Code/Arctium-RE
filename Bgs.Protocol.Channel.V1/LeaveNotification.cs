using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class LeaveNotification : IMessage<LeaveNotification>, IEquatable<LeaveNotification>, IDeepCloneable<LeaveNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly LeaveNotification.__c __9 = new LeaveNotification.__c();

			internal LeaveNotification cctor>b__44_0()
			{
				return new LeaveNotification();
			}
		}

		private static readonly MessageParser<LeaveNotification> _parser = new MessageParser<LeaveNotification>(new Func<LeaveNotification>(LeaveNotification.__c.__9.<.cctor>b__44_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int MemberIdFieldNumber = 2;

		private EntityId memberId_;

		public const int ReasonFieldNumber = 3;

		private uint reason_;

		public const int ChannelIdFieldNumber = 4;

		private ChannelId channelId_;

		public const int SubscriberFieldNumber = 5;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public static MessageParser<LeaveNotification> Parser
		{
			get
			{
				return LeaveNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveNotification.Descriptor;
			}
		}

		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		public EntityId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		public uint Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		public ChannelId ChannelId
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

		public Bgs.Protocol.Account.V1.Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		public LeaveNotification()
		{
		}

		public LeaveNotification(LeaveNotification other) : this()
		{
			while (true)
			{
				IL_C8:
				int arg_A6_0 = -2131597562;
				while (true)
				{
					switch ((arg_A6_0 ^ -2038069895) % 6)
					{
					case 0:
						this.MemberId = ((other.memberId_ != null) ? other.MemberId.Clone() : null);
						arg_A6_0 = -1314028671;
						continue;
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_A6_0 = -1925753351;
						continue;
					case 2:
						this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
						arg_A6_0 = -462345586;
						continue;
					case 3:
						goto IL_C8;
					case 4:
						this.reason_ = other.reason_;
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						arg_A6_0 = -2092851805;
						continue;
					}
					return;
				}
			}
		}

		public LeaveNotification Clone()
		{
			return new LeaveNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveNotification);
		}

		public bool Equals(LeaveNotification other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_155;
			int arg_FF_0;
			while (true)
			{
				IL_FA:
				switch ((arg_FF_0 ^ -1024718954) % 15)
				{
				case 0:
					arg_FF_0 = ((!LeaveNotification.smethod_0(this.AgentId, other.AgentId)) ? -696247086 : -833977564);
					continue;
				case 1:
					return true;
				case 2:
					arg_FF_0 = ((!LeaveNotification.smethod_0(this.Subscriber, other.Subscriber)) ? -1458925010 : -908884005);
					continue;
				case 3:
					return false;
				case 4:
					arg_FF_0 = ((this.Reason != other.Reason) ? -430775041 : -1808059196);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_155;
				case 8:
					arg_FF_0 = (LeaveNotification.smethod_0(this.MemberId, other.MemberId) ? -859468552 : -1462851410);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					goto IL_47;
				case 13:
					return false;
				case 14:
					arg_FF_0 = ((!LeaveNotification.smethod_0(this.ChannelId, other.ChannelId)) ? -92571736 : -1020751325);
					continue;
				}
				break;
			}
			return true;
			IL_47:
			arg_FF_0 = -199228688;
			goto IL_FA;
			IL_155:
			arg_FF_0 = ((other != this) ? -1287680191 : -1879529422);
			goto IL_FA;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_3F;
			}
			goto IL_128;
			uint arg_E8_0;
			while (true)
			{
				IL_E3:
				uint num2;
				switch ((num2 = (arg_E8_0 ^ 4018721227u)) % 9u)
				{
				case 0u:
					goto IL_128;
				case 2u:
					num ^= this.Reason.GetHashCode();
					arg_E8_0 = (num2 * 3682628921u ^ 2656269481u);
					continue;
				case 3u:
					num ^= this.ChannelId.GetHashCode();
					arg_E8_0 = (num2 * 1531567378u ^ 3473647565u);
					continue;
				case 4u:
					num ^= this.Subscriber.GetHashCode();
					arg_E8_0 = (num2 * 1290088291u ^ 2831419735u);
					continue;
				case 5u:
					arg_E8_0 = ((this.channelId_ != null) ? 3629259890u : 4072115151u);
					continue;
				case 6u:
					arg_E8_0 = ((this.subscriber_ != null) ? 3145085484u : 3033039362u);
					continue;
				case 7u:
					goto IL_3F;
				case 8u:
					num ^= LeaveNotification.smethod_1(this.AgentId);
					arg_E8_0 = (num2 * 2349912966u ^ 3887902432u);
					continue;
				}
				break;
			}
			return num;
			IL_3F:
			arg_E8_0 = 2945992420u;
			goto IL_E3;
			IL_128:
			num ^= LeaveNotification.smethod_1(this.MemberId);
			arg_E8_0 = ((this.Reason != 0u) ? 3718366458u : 3943065664u);
			goto IL_E3;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_33;
			}
			goto IL_17B;
			uint arg_13E_0;
			while (true)
			{
				IL_139:
				uint num;
				switch ((num = (arg_13E_0 ^ 3969855229u)) % 12u)
				{
				case 0u:
					arg_13E_0 = ((this.subscriber_ != null) ? 3838989181u : 2688047768u);
					continue;
				case 2u:
					goto IL_17B;
				case 3u:
					arg_13E_0 = (((this.Reason == 0u) ? 3525690767u : 3026373953u) ^ num * 1149726133u);
					continue;
				case 4u:
					output.WriteRawTag(34);
					arg_13E_0 = (num * 4124936485u ^ 3898367966u);
					continue;
				case 5u:
					arg_13E_0 = ((this.channelId_ != null) ? 3230470921u : 3508754449u);
					continue;
				case 6u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_13E_0 = (num * 398525475u ^ 3948070165u);
					continue;
				case 7u:
					output.WriteMessage(this.ChannelId);
					arg_13E_0 = (num * 431474684u ^ 2061683317u);
					continue;
				case 8u:
					output.WriteRawTag(42);
					arg_13E_0 = (num * 1476241964u ^ 2974082784u);
					continue;
				case 9u:
					output.WriteMessage(this.Subscriber);
					arg_13E_0 = (num * 2670310468u ^ 3382511916u);
					continue;
				case 10u:
					goto IL_33;
				case 11u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.Reason);
					arg_13E_0 = (num * 1435839448u ^ 1393891400u);
					continue;
				}
				break;
			}
			return;
			IL_33:
			arg_13E_0 = 3320257167u;
			goto IL_139;
			IL_17B:
			output.WriteRawTag(18);
			output.WriteMessage(this.MemberId);
			arg_13E_0 = 2548266766u;
			goto IL_139;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_43;
			}
			goto IL_12D;
			uint arg_ED_0;
			while (true)
			{
				IL_E8:
				uint num2;
				switch ((num2 = (arg_ED_0 ^ 1529832422u)) % 9u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
					arg_ED_0 = (num2 * 3518886635u ^ 1748270291u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_ED_0 = (num2 * 1016684426u ^ 3568457091u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
					arg_ED_0 = (num2 * 1184871865u ^ 2679190430u);
					continue;
				case 3u:
					arg_ED_0 = ((this.channelId_ != null) ? 1107795710u : 581794267u);
					continue;
				case 5u:
					goto IL_12D;
				case 6u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
					arg_ED_0 = (num2 * 1067292615u ^ 2659865491u);
					continue;
				case 7u:
					goto IL_43;
				case 8u:
					arg_ED_0 = ((this.subscriber_ != null) ? 203857351u : 1289079111u);
					continue;
				}
				break;
			}
			return num;
			IL_43:
			arg_ED_0 = 1532905109u;
			goto IL_E8;
			IL_12D:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			arg_ED_0 = ((this.Reason != 0u) ? 1281607953u : 1768014994u);
			goto IL_E8;
		}

		public void MergeFrom(LeaveNotification other)
		{
			if (other == null)
			{
				goto IL_14E;
			}
			goto IL_2C7;
			uint arg_257_0;
			while (true)
			{
				IL_252:
				uint num;
				switch ((num = (arg_257_0 ^ 2044909962u)) % 21u)
				{
				case 0u:
					goto IL_2C7;
				case 1u:
					return;
				case 2u:
					arg_257_0 = ((other.subscriber_ != null) ? 914083538u : 896192819u);
					continue;
				case 3u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_257_0 = 560952459u;
					continue;
				case 4u:
					this.memberId_ = new EntityId();
					arg_257_0 = (num * 1888509296u ^ 2651473166u);
					continue;
				case 5u:
					this.agentId_ = new EntityId();
					arg_257_0 = (num * 3789539619u ^ 200498880u);
					continue;
				case 6u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_257_0 = (num * 1523070835u ^ 3018189818u);
					continue;
				case 7u:
					arg_257_0 = ((other.channelId_ != null) ? 190717884u : 1064345419u);
					continue;
				case 8u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_257_0 = 896192819u;
					continue;
				case 9u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_257_0 = 1064345419u;
					continue;
				case 10u:
					this.MemberId.MergeFrom(other.MemberId);
					arg_257_0 = 591904459u;
					continue;
				case 11u:
					goto IL_14E;
				case 13u:
					arg_257_0 = ((other.memberId_ != null) ? 1356957918u : 591904459u);
					continue;
				case 14u:
					arg_257_0 = (((this.memberId_ != null) ? 294339198u : 39771948u) ^ num * 156959460u);
					continue;
				case 15u:
					arg_257_0 = ((other.Reason == 0u) ? 1007533402u : 645832459u);
					continue;
				case 16u:
					this.channelId_ = new ChannelId();
					arg_257_0 = (num * 2913453878u ^ 2506771283u);
					continue;
				case 17u:
					arg_257_0 = (((this.agentId_ == null) ? 2964207752u : 4258668930u) ^ num * 973744462u);
					continue;
				case 18u:
					this.Reason = other.Reason;
					arg_257_0 = (num * 3343134552u ^ 3017823746u);
					continue;
				case 19u:
					arg_257_0 = (((this.subscriber_ == null) ? 1536319397u : 558783207u) ^ num * 1211454320u);
					continue;
				case 20u:
					arg_257_0 = (((this.channelId_ != null) ? 591259761u : 242575982u) ^ num * 2265017309u);
					continue;
				}
				break;
			}
			return;
			IL_14E:
			arg_257_0 = 986824397u;
			goto IL_252;
			IL_2C7:
			arg_257_0 = ((other.agentId_ != null) ? 774873101u : 560952459u);
			goto IL_252;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_343:
				uint num;
				uint arg_2BB_0 = ((num = input.ReadTag()) != 0u) ? 1807555473u : 798058883u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2BB_0 ^ 1488104382u)) % 27u)
					{
					case 0u:
						input.ReadMessage(this.channelId_);
						arg_2BB_0 = 1375448379u;
						continue;
					case 1u:
						arg_2BB_0 = (num2 * 3856869677u ^ 1881284333u);
						continue;
					case 2u:
						arg_2BB_0 = (num2 * 532654443u ^ 1549406783u);
						continue;
					case 3u:
						this.agentId_ = new EntityId();
						arg_2BB_0 = (num2 * 1228480900u ^ 375809091u);
						continue;
					case 4u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_2BB_0 = (num2 * 955540676u ^ 1652095451u);
						continue;
					case 5u:
						arg_2BB_0 = (num2 * 3341591257u ^ 3319727346u);
						continue;
					case 6u:
						arg_2BB_0 = 1807555473u;
						continue;
					case 7u:
						arg_2BB_0 = ((num <= 18u) ? 109282762u : 480730486u);
						continue;
					case 8u:
						arg_2BB_0 = (num2 * 895980490u ^ 2706414962u);
						continue;
					case 9u:
						this.Reason = input.ReadUInt32();
						arg_2BB_0 = 1398052008u;
						continue;
					case 10u:
						this.channelId_ = new ChannelId();
						arg_2BB_0 = (num2 * 1757271917u ^ 116830088u);
						continue;
					case 11u:
						arg_2BB_0 = (((num == 18u) ? 2691115399u : 3125519638u) ^ num2 * 708472605u);
						continue;
					case 12u:
						input.ReadMessage(this.memberId_);
						arg_2BB_0 = 1397052887u;
						continue;
					case 13u:
						arg_2BB_0 = ((num != 24u) ? 765964240u : 1530056921u);
						continue;
					case 14u:
						arg_2BB_0 = ((this.channelId_ == null) ? 56530322u : 1421853492u);
						continue;
					case 15u:
						input.SkipLastField();
						arg_2BB_0 = 1398052008u;
						continue;
					case 16u:
						this.memberId_ = new EntityId();
						arg_2BB_0 = (num2 * 3833922686u ^ 3542089768u);
						continue;
					case 17u:
						input.ReadMessage(this.agentId_);
						arg_2BB_0 = 1731088327u;
						continue;
					case 18u:
						arg_2BB_0 = ((this.agentId_ == null) ? 1300684709u : 694172847u);
						continue;
					case 19u:
						input.ReadMessage(this.subscriber_);
						arg_2BB_0 = 1398052008u;
						continue;
					case 20u:
						arg_2BB_0 = ((this.subscriber_ != null) ? 2138765083u : 1511487758u);
						continue;
					case 21u:
						arg_2BB_0 = (((num != 34u) ? 497109154u : 222848379u) ^ num2 * 3579212646u);
						continue;
					case 23u:
						goto IL_343;
					case 24u:
						arg_2BB_0 = (((num == 42u) ? 2395803501u : 2599741162u) ^ num2 * 2838873756u);
						continue;
					case 25u:
						arg_2BB_0 = ((this.memberId_ == null) ? 1443726870u : 1144461464u);
						continue;
					case 26u:
						arg_2BB_0 = (((num == 10u) ? 3832926357u : 2458999754u) ^ num2 * 3378984349u);
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
