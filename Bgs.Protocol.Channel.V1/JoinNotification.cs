using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class JoinNotification : IMessage<JoinNotification>, IEquatable<JoinNotification>, IDeepCloneable<JoinNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly JoinNotification.__c __9 = new JoinNotification.__c();

			internal JoinNotification cctor>b__44_0()
			{
				return new JoinNotification();
			}
		}

		private static readonly MessageParser<JoinNotification> _parser = new MessageParser<JoinNotification>(new Func<JoinNotification>(JoinNotification.__c.__9.<.cctor>b__44_0));

		public const int SelfFieldNumber = 1;

		private Member self_;

		public const int MemberFieldNumber = 2;

		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(18u, Bgs.Protocol.Channel.V1.Member.Parser);

		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();

		public const int ChannelStateFieldNumber = 3;

		private ChannelState channelState_;

		public const int ChannelIdFieldNumber = 4;

		private ChannelId channelId_;

		public const int SubscriberFieldNumber = 5;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public static MessageParser<JoinNotification> Parser
		{
			get
			{
				return JoinNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinNotification.Descriptor;
			}
		}

		public Member Self
		{
			get
			{
				return this.self_;
			}
			set
			{
				this.self_ = value;
			}
		}

		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		public ChannelState ChannelState
		{
			get
			{
				return this.channelState_;
			}
			set
			{
				this.channelState_ = value;
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

		public JoinNotification()
		{
		}

		public JoinNotification(JoinNotification other) : this()
		{
			while (true)
			{
				IL_A6:
				int arg_88_0 = 155475711;
				while (true)
				{
					switch ((arg_88_0 ^ 1710848916) % 5)
					{
					case 0:
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						arg_88_0 = 1302284228;
						continue;
					case 1:
						this.Self = ((other.self_ != null) ? other.Self.Clone() : null);
						arg_88_0 = 2052822402;
						continue;
					case 3:
						this.member_ = other.member_.Clone();
						this.ChannelState = ((other.channelState_ != null) ? other.ChannelState.Clone() : null);
						arg_88_0 = 1364736024;
						continue;
					case 4:
						goto IL_A6;
					}
					goto Block_4;
				}
			}
			Block_4:
			this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
		}

		public JoinNotification Clone()
		{
			return new JoinNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as JoinNotification);
		}

		public bool Equals(JoinNotification other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_15D;
			int arg_107_0;
			while (true)
			{
				IL_102:
				switch ((arg_107_0 ^ -1549038174) % 15)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_107_0 = (JoinNotification.smethod_0(this.ChannelState, other.ChannelState) ? -1060850936 : -77579085);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_15D;
				case 7:
					arg_107_0 = ((!JoinNotification.smethod_0(this.ChannelId, other.ChannelId)) ? -294433230 : -1805586349);
					continue;
				case 8:
					arg_107_0 = ((!this.member_.Equals(other.member_)) ? -1079020462 : -1048152554);
					continue;
				case 9:
					arg_107_0 = ((!JoinNotification.smethod_0(this.Subscriber, other.Subscriber)) ? -1244135762 : -1708523741);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_107_0 = ((!JoinNotification.smethod_0(this.Self, other.Self)) ? -1390049533 : -2090584941);
					continue;
				case 14:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_107_0 = -1103753556;
			goto IL_102;
			IL_15D:
			arg_107_0 = ((other == this) ? -312435435 : -1603333652);
			goto IL_102;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_147:
				uint arg_112_0 = 1196014562u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_112_0 ^ 1038841753u)) % 10u)
					{
					case 0u:
						num ^= JoinNotification.smethod_1(this.ChannelState);
						arg_112_0 = (num2 * 3622824492u ^ 4262099742u);
						continue;
					case 1u:
						arg_112_0 = (((this.self_ == null) ? 986148825u : 459456329u) ^ num2 * 4119938644u);
						continue;
					case 2u:
						num ^= JoinNotification.smethod_1(this.ChannelId);
						arg_112_0 = (num2 * 500014509u ^ 3456394053u);
						continue;
					case 3u:
						arg_112_0 = (((this.channelId_ != null) ? 75411137u : 1027408669u) ^ num2 * 2498048680u);
						continue;
					case 4u:
						num ^= JoinNotification.smethod_1(this.member_);
						arg_112_0 = 274195681u;
						continue;
					case 5u:
						goto IL_147;
					case 6u:
						arg_112_0 = ((this.subscriber_ == null) ? 733298866u : 1387931954u);
						continue;
					case 7u:
						num ^= JoinNotification.smethod_1(this.Subscriber);
						arg_112_0 = (num2 * 3438565132u ^ 1984810422u);
						continue;
					case 8u:
						num ^= JoinNotification.smethod_1(this.Self);
						arg_112_0 = (num2 * 2789855439u ^ 3170667185u);
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
			if (this.self_ != null)
			{
				goto IL_D3;
			}
			goto IL_150;
			uint arg_117_0;
			while (true)
			{
				IL_112:
				uint num;
				switch ((num = (arg_117_0 ^ 3326760883u)) % 11u)
				{
				case 1u:
					output.WriteRawTag(10);
					arg_117_0 = (num * 1785579266u ^ 1943458597u);
					continue;
				case 2u:
					goto IL_150;
				case 3u:
					output.WriteRawTag(34);
					output.WriteMessage(this.ChannelId);
					arg_117_0 = (num * 556378969u ^ 164048001u);
					continue;
				case 4u:
					goto IL_D3;
				case 5u:
					output.WriteRawTag(26);
					arg_117_0 = (num * 786608534u ^ 3093557601u);
					continue;
				case 6u:
					output.WriteMessage(this.ChannelState);
					arg_117_0 = (num * 514541817u ^ 1900625099u);
					continue;
				case 7u:
					output.WriteMessage(this.Self);
					arg_117_0 = (num * 3090618168u ^ 1425016765u);
					continue;
				case 8u:
					arg_117_0 = (((this.channelId_ == null) ? 1365355162u : 1101737680u) ^ num * 926971881u);
					continue;
				case 9u:
					output.WriteRawTag(42);
					output.WriteMessage(this.Subscriber);
					arg_117_0 = (num * 2180017454u ^ 3758445297u);
					continue;
				case 10u:
					arg_117_0 = ((this.subscriber_ != null) ? 2341585662u : 2704526887u);
					continue;
				}
				break;
			}
			return;
			IL_D3:
			arg_117_0 = 2774418451u;
			goto IL_112;
			IL_150:
			this.member_.WriteTo(output, JoinNotification._repeated_member_codec);
			arg_117_0 = 2368233418u;
			goto IL_112;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_151:
				uint arg_11C_0 = 2149499537u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_11C_0 ^ 3215541389u)) % 10u)
					{
					case 0u:
						arg_11C_0 = (((this.channelId_ == null) ? 2104529400u : 632347240u) ^ num2 * 2564724000u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Self);
						arg_11C_0 = (num2 * 910067266u ^ 1975817172u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
						arg_11C_0 = (num2 * 2773256191u ^ 1672997067u);
						continue;
					case 3u:
						num += this.member_.CalculateSize(JoinNotification._repeated_member_codec);
						arg_11C_0 = 3856655189u;
						continue;
					case 5u:
						arg_11C_0 = ((this.subscriber_ == null) ? 3364953875u : 2695302309u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelState);
						arg_11C_0 = (num2 * 2958174862u ^ 1279652715u);
						continue;
					case 7u:
						goto IL_151;
					case 8u:
						arg_11C_0 = (((this.self_ != null) ? 3129140898u : 2708834742u) ^ num2 * 3682280035u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_11C_0 = (num2 * 3488961715u ^ 2033041127u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(JoinNotification other)
		{
			if (other == null)
			{
				goto IL_22B;
			}
			goto IL_2A1;
			uint arg_235_0;
			while (true)
			{
				IL_230:
				uint num;
				switch ((num = (arg_235_0 ^ 398983827u)) % 20u)
				{
				case 0u:
					goto IL_22B;
				case 1u:
					this.Self.MergeFrom(other.Self);
					arg_235_0 = 1123012984u;
					continue;
				case 2u:
					arg_235_0 = ((other.channelId_ == null) ? 1112317717u : 2129151048u);
					continue;
				case 3u:
					goto IL_2A1;
				case 4u:
					this.ChannelState.MergeFrom(other.ChannelState);
					arg_235_0 = 41333313u;
					continue;
				case 5u:
					arg_235_0 = (((other.channelState_ != null) ? 3999770446u : 2326952003u) ^ num * 2121122394u);
					continue;
				case 6u:
					this.channelId_ = new ChannelId();
					arg_235_0 = (num * 549487511u ^ 2546156302u);
					continue;
				case 7u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_235_0 = 1112317717u;
					continue;
				case 8u:
					arg_235_0 = (((this.self_ == null) ? 2062122142u : 211969334u) ^ num * 826006715u);
					continue;
				case 9u:
					this.self_ = new Member();
					arg_235_0 = (num * 2521191379u ^ 4071531553u);
					continue;
				case 10u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_235_0 = 870072067u;
					continue;
				case 11u:
					arg_235_0 = (((this.channelId_ != null) ? 4232517213u : 2253657228u) ^ num * 2564460895u);
					continue;
				case 12u:
					this.channelState_ = new ChannelState();
					arg_235_0 = (num * 213089147u ^ 2085688151u);
					continue;
				case 13u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_235_0 = (num * 2869136515u ^ 3085997770u);
					continue;
				case 14u:
					arg_235_0 = (((this.subscriber_ != null) ? 3330447129u : 3860977490u) ^ num * 1507544436u);
					continue;
				case 15u:
					this.member_.Add(other.member_);
					arg_235_0 = 655633718u;
					continue;
				case 17u:
					return;
				case 18u:
					arg_235_0 = ((other.subscriber_ != null) ? 1831356537u : 870072067u);
					continue;
				case 19u:
					arg_235_0 = (((this.channelState_ != null) ? 3363802260u : 3985490744u) ^ num * 4060238249u);
					continue;
				}
				break;
			}
			return;
			IL_22B:
			arg_235_0 = 1550463434u;
			goto IL_230;
			IL_2A1:
			arg_235_0 = ((other.self_ != null) ? 596758539u : 1123012984u);
			goto IL_230;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_33B:
				uint num;
				uint arg_2B7_0 = ((num = input.ReadTag()) == 0u) ? 222585841u : 1295462297u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2B7_0 ^ 1754820894u)) % 26u)
					{
					case 0u:
						arg_2B7_0 = (((num == 18u) ? 586646432u : 1937926713u) ^ num2 * 161043003u);
						continue;
					case 1u:
						arg_2B7_0 = ((this.self_ == null) ? 1890708235u : 143638857u);
						continue;
					case 2u:
						this.channelState_ = new ChannelState();
						arg_2B7_0 = (num2 * 586734842u ^ 2628775630u);
						continue;
					case 3u:
						input.ReadMessage(this.self_);
						arg_2B7_0 = 80370824u;
						continue;
					case 4u:
						goto IL_33B;
					case 6u:
						this.member_.AddEntriesFrom(input, JoinNotification._repeated_member_codec);
						arg_2B7_0 = 112192548u;
						continue;
					case 7u:
						this.self_ = new Member();
						arg_2B7_0 = (num2 * 2332232657u ^ 2958783340u);
						continue;
					case 8u:
						arg_2B7_0 = ((this.channelId_ != null) ? 182339691u : 1764827838u);
						continue;
					case 9u:
						arg_2B7_0 = ((num > 18u) ? 1885404627u : 1684843694u);
						continue;
					case 10u:
						arg_2B7_0 = (((num == 10u) ? 4270897551u : 2193510584u) ^ num2 * 371895723u);
						continue;
					case 11u:
						arg_2B7_0 = 1295462297u;
						continue;
					case 12u:
						arg_2B7_0 = (num2 * 1971918224u ^ 2576555588u);
						continue;
					case 13u:
						arg_2B7_0 = (((num != 42u) ? 3397044895u : 3141093216u) ^ num2 * 790413344u);
						continue;
					case 14u:
						input.ReadMessage(this.channelState_);
						arg_2B7_0 = 1479770589u;
						continue;
					case 15u:
						input.ReadMessage(this.channelId_);
						arg_2B7_0 = 112192548u;
						continue;
					case 16u:
						arg_2B7_0 = (((num == 34u) ? 502428738u : 1670056433u) ^ num2 * 797805719u);
						continue;
					case 17u:
						arg_2B7_0 = (num2 * 1676468572u ^ 4286973232u);
						continue;
					case 18u:
						arg_2B7_0 = ((this.subscriber_ == null) ? 1611333220u : 56786519u);
						continue;
					case 19u:
						arg_2B7_0 = (num2 * 4053255332u ^ 167083531u);
						continue;
					case 20u:
						arg_2B7_0 = ((this.channelState_ != null) ? 331012414u : 508265542u);
						continue;
					case 21u:
						input.SkipLastField();
						arg_2B7_0 = 112192548u;
						continue;
					case 22u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_2B7_0 = (num2 * 458088492u ^ 3205437103u);
						continue;
					case 23u:
						arg_2B7_0 = ((num == 26u) ? 392282724u : 1170409270u);
						continue;
					case 24u:
						this.channelId_ = new ChannelId();
						arg_2B7_0 = (num2 * 1470752091u ^ 2839581067u);
						continue;
					case 25u:
						input.ReadMessage(this.subscriber_);
						arg_2B7_0 = 112192548u;
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
