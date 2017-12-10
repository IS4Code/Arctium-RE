using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class MemberAddedNotification : IMessage<MemberAddedNotification>, IEquatable<MemberAddedNotification>, IDeepCloneable<MemberAddedNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MemberAddedNotification.__c __9 = new MemberAddedNotification.__c();

			internal MemberAddedNotification cctor>b__34_0()
			{
				return new MemberAddedNotification();
			}
		}

		private static readonly MessageParser<MemberAddedNotification> _parser = new MessageParser<MemberAddedNotification>(new Func<MemberAddedNotification>(MemberAddedNotification.__c.__9.<.cctor>b__34_0));

		public const int MemberFieldNumber = 1;

		private Member member_;

		public const int ChannelIdFieldNumber = 2;

		private ChannelId channelId_;

		public const int SubscriberFieldNumber = 3;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public static MessageParser<MemberAddedNotification> Parser
		{
			get
			{
				return MemberAddedNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAddedNotification.Descriptor;
			}
		}

		public Member Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
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

		public MemberAddedNotification()
		{
		}

		public MemberAddedNotification(MemberAddedNotification other) : this()
		{
			this.Member = ((other.member_ != null) ? other.Member.Clone() : null);
			this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
			this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
		}

		public MemberAddedNotification Clone()
		{
			return new MemberAddedNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAddedNotification);
		}

		public bool Equals(MemberAddedNotification other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ 1533611482) % 11)
				{
				case 0:
					arg_A9_0 = (MemberAddedNotification.smethod_0(this.Subscriber, other.Subscriber) ? 46133594 : 707468399);
					continue;
				case 1:
					arg_A9_0 = ((!MemberAddedNotification.smethod_0(this.ChannelId, other.ChannelId)) ? 557997668 : 1425387198);
					continue;
				case 2:
					arg_A9_0 = ((!MemberAddedNotification.smethod_0(this.Member, other.Member)) ? 618990945 : 1765819806);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_EF;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					goto IL_18;
				case 9:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_A9_0 = 1775740181;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other != this) ? 252285046 : 1769004587);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D3:
				uint arg_AB_0 = 2077789464u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AB_0 ^ 1174281642u)) % 7u)
					{
					case 0u:
						num ^= MemberAddedNotification.smethod_1(this.Subscriber);
						arg_AB_0 = (num2 * 718853340u ^ 3692257163u);
						continue;
					case 2u:
						num ^= MemberAddedNotification.smethod_1(this.ChannelId);
						arg_AB_0 = (num2 * 1757864615u ^ 58965338u);
						continue;
					case 3u:
						num ^= MemberAddedNotification.smethod_1(this.Member);
						arg_AB_0 = (num2 * 2868112783u ^ 3331570128u);
						continue;
					case 4u:
						arg_AB_0 = ((this.subscriber_ != null) ? 1858209540u : 547117571u);
						continue;
					case 5u:
						goto IL_D3;
					case 6u:
						arg_AB_0 = (((this.channelId_ != null) ? 4069526385u : 2607438247u) ^ num2 * 3202859645u);
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
			output.WriteRawTag(10);
			output.WriteMessage(this.Member);
			while (true)
			{
				IL_D0:
				uint arg_AC_0 = 3513504741u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AC_0 ^ 2895812550u)) % 6u)
					{
					case 0u:
						output.WriteRawTag(26);
						output.WriteMessage(this.Subscriber);
						arg_AC_0 = (num * 921948124u ^ 1290254u);
						continue;
					case 1u:
						arg_AC_0 = (((this.channelId_ == null) ? 608910251u : 1868802766u) ^ num * 4229159804u);
						continue;
					case 2u:
						output.WriteRawTag(18);
						output.WriteMessage(this.ChannelId);
						arg_AC_0 = (num * 1848568900u ^ 771360943u);
						continue;
					case 3u:
						goto IL_D0;
					case 5u:
						arg_AC_0 = ((this.subscriber_ == null) ? 3541223782u : 4055719472u);
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
				IL_DC:
				uint arg_B4_0 = 3640397830u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B4_0 ^ 3945076312u)) % 7u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
						arg_B4_0 = (num2 * 1712964770u ^ 3089516395u);
						continue;
					case 2u:
						goto IL_DC;
					case 3u:
						arg_B4_0 = ((this.subscriber_ != null) ? 4037542319u : 4045404783u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
						arg_B4_0 = (num2 * 166281661u ^ 1477481012u);
						continue;
					case 5u:
						arg_B4_0 = (((this.channelId_ != null) ? 3232400555u : 2788419020u) ^ num2 * 878493235u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_B4_0 = (num2 * 2012999360u ^ 998359281u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(MemberAddedNotification other)
		{
			if (other == null)
			{
				goto IL_C3;
			}
			goto IL_1E5;
			uint arg_18D_0;
			while (true)
			{
				IL_188:
				uint num;
				switch ((num = (arg_18D_0 ^ 1319591666u)) % 15u)
				{
				case 0u:
					this.member_ = new Member();
					arg_18D_0 = (num * 513765745u ^ 3953961151u);
					continue;
				case 1u:
					this.Member.MergeFrom(other.Member);
					arg_18D_0 = 1414945342u;
					continue;
				case 2u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_18D_0 = 50737661u;
					continue;
				case 3u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_18D_0 = (num * 3105225569u ^ 2495558334u);
					continue;
				case 4u:
					arg_18D_0 = ((other.subscriber_ == null) ? 1883164846u : 1195098748u);
					continue;
				case 5u:
					this.channelId_ = new ChannelId();
					arg_18D_0 = (num * 1040430986u ^ 3696425375u);
					continue;
				case 6u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_18D_0 = 1883164846u;
					continue;
				case 7u:
					goto IL_C3;
				case 8u:
					arg_18D_0 = (((this.member_ != null) ? 3763478407u : 3622071546u) ^ num * 2214325143u);
					continue;
				case 9u:
					return;
				case 10u:
					arg_18D_0 = ((other.channelId_ == null) ? 50737661u : 537036923u);
					continue;
				case 11u:
					arg_18D_0 = (((this.channelId_ == null) ? 3546628651u : 4273215806u) ^ num * 4213991145u);
					continue;
				case 12u:
					goto IL_1E5;
				case 13u:
					arg_18D_0 = (((this.subscriber_ != null) ? 1657776720u : 2045810268u) ^ num * 67586844u);
					continue;
				}
				break;
			}
			return;
			IL_C3:
			arg_18D_0 = 1691933054u;
			goto IL_188;
			IL_1E5:
			arg_18D_0 = ((other.member_ == null) ? 1414945342u : 1619126985u);
			goto IL_188;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_213:
				uint num;
				uint arg_1B3_0 = ((num = input.ReadTag()) != 0u) ? 3468496682u : 3907821269u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1B3_0 ^ 3897418749u)) % 17u)
					{
					case 0u:
						arg_1B3_0 = (num2 * 3927589285u ^ 1072216709u);
						continue;
					case 1u:
						input.ReadMessage(this.member_);
						arg_1B3_0 = 4069411431u;
						continue;
					case 2u:
						arg_1B3_0 = (((num != 18u) ? 2877221832u : 2816599336u) ^ num2 * 1884852145u);
						continue;
					case 4u:
						arg_1B3_0 = ((this.channelId_ != null) ? 3330168374u : 4040116913u);
						continue;
					case 5u:
						input.ReadMessage(this.channelId_);
						arg_1B3_0 = 3560493255u;
						continue;
					case 6u:
						input.ReadMessage(this.subscriber_);
						arg_1B3_0 = 3560493255u;
						continue;
					case 7u:
						arg_1B3_0 = ((this.subscriber_ == null) ? 2554994584u : 2788412162u);
						continue;
					case 8u:
						this.channelId_ = new ChannelId();
						arg_1B3_0 = (num2 * 3197043908u ^ 240949254u);
						continue;
					case 9u:
						arg_1B3_0 = 3468496682u;
						continue;
					case 10u:
						arg_1B3_0 = ((this.member_ == null) ? 4020427349u : 4212407390u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_1B3_0 = (num2 * 992035768u ^ 2361158591u);
						continue;
					case 12u:
						this.member_ = new Member();
						arg_1B3_0 = (num2 * 1947066124u ^ 887895998u);
						continue;
					case 13u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_1B3_0 = (num2 * 644874501u ^ 73898491u);
						continue;
					case 14u:
						goto IL_213;
					case 15u:
						arg_1B3_0 = ((num != 10u) ? 2890022853u : 2933749913u);
						continue;
					case 16u:
						arg_1B3_0 = (((num == 26u) ? 2707673094u : 2470552871u) ^ num2 * 3998649631u);
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
