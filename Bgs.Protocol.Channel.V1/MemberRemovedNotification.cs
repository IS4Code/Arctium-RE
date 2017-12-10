using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class MemberRemovedNotification : IMessage<MemberRemovedNotification>, IEquatable<MemberRemovedNotification>, IDeepCloneable<MemberRemovedNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MemberRemovedNotification.__c __9 = new MemberRemovedNotification.__c();

			internal MemberRemovedNotification cctor>b__44_0()
			{
				return new MemberRemovedNotification();
			}
		}

		private static readonly MessageParser<MemberRemovedNotification> _parser = new MessageParser<MemberRemovedNotification>(new Func<MemberRemovedNotification>(MemberRemovedNotification.__c.__9.<.cctor>b__44_0));

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

		public static MessageParser<MemberRemovedNotification> Parser
		{
			get
			{
				return MemberRemovedNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRemovedNotification.Descriptor;
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

		public MemberRemovedNotification()
		{
		}

		public MemberRemovedNotification(MemberRemovedNotification other) : this()
		{
			while (true)
			{
				IL_D2:
				uint arg_AE_0 = 2504272384u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AE_0 ^ 3770397819u)) % 6u)
					{
					case 0u:
						this.reason_ = other.reason_;
						arg_AE_0 = (num * 327395331u ^ 557669525u);
						continue;
					case 1u:
						this.MemberId = ((other.memberId_ != null) ? other.MemberId.Clone() : null);
						arg_AE_0 = 2873140595u;
						continue;
					case 2u:
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
						arg_AE_0 = 2789885817u;
						continue;
					case 3u:
						goto IL_D2;
					case 5u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_AE_0 = 3112303738u;
						continue;
					}
					return;
				}
			}
		}

		public MemberRemovedNotification Clone()
		{
			return new MemberRemovedNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRemovedNotification);
		}

		public bool Equals(MemberRemovedNotification other)
		{
			if (other == null)
			{
				goto IL_F8;
			}
			goto IL_158;
			int arg_102_0;
			while (true)
			{
				IL_FD:
				switch ((arg_102_0 ^ 1522280374) % 15)
				{
				case 0:
					goto IL_F8;
				case 1:
					arg_102_0 = ((!MemberRemovedNotification.smethod_0(this.AgentId, other.AgentId)) ? 1061705716 : 107823115);
					continue;
				case 2:
					arg_102_0 = ((!MemberRemovedNotification.smethod_0(this.Subscriber, other.Subscriber)) ? 958227093 : 232387758);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					return false;
				case 8:
					arg_102_0 = ((!MemberRemovedNotification.smethod_0(this.MemberId, other.MemberId)) ? 1934098534 : 889591628);
					continue;
				case 9:
					goto IL_158;
				case 10:
					arg_102_0 = ((this.Reason == other.Reason) ? 284618078 : 789803828);
					continue;
				case 11:
					return false;
				case 12:
					arg_102_0 = ((!MemberRemovedNotification.smethod_0(this.ChannelId, other.ChannelId)) ? 93923933 : 235616317);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_F8:
			arg_102_0 = 361346480;
			goto IL_FD;
			IL_158:
			arg_102_0 = ((other != this) ? 245292449 : 1521011635);
			goto IL_FD;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_15C:
				uint arg_127_0 = 3014014675u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_127_0 ^ 3990723824u)) % 10u)
					{
					case 0u:
						num ^= MemberRemovedNotification.smethod_1(this.AgentId);
						arg_127_0 = (num2 * 3263203318u ^ 3195585113u);
						continue;
					case 1u:
						arg_127_0 = ((this.channelId_ == null) ? 4174843671u : 3018631727u);
						continue;
					case 2u:
						num ^= this.Reason.GetHashCode();
						arg_127_0 = (num2 * 1197124972u ^ 1828065023u);
						continue;
					case 3u:
						num ^= MemberRemovedNotification.smethod_1(this.MemberId);
						arg_127_0 = ((this.Reason != 0u) ? 2276400802u : 3049417319u);
						continue;
					case 4u:
						goto IL_15C;
					case 5u:
						num ^= this.ChannelId.GetHashCode();
						arg_127_0 = (num2 * 4109373220u ^ 3873818443u);
						continue;
					case 6u:
						num ^= this.Subscriber.GetHashCode();
						arg_127_0 = (num2 * 1964828135u ^ 748585832u);
						continue;
					case 7u:
						arg_127_0 = (((this.agentId_ != null) ? 3063267493u : 2590540910u) ^ num2 * 3058504881u);
						continue;
					case 9u:
						arg_127_0 = ((this.subscriber_ != null) ? 3713950918u : 2224801234u);
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
			if (this.agentId_ != null)
			{
				goto IL_45;
			}
			goto IL_1B0;
			uint arg_16B_0;
			while (true)
			{
				IL_166:
				uint num;
				switch ((num = (arg_16B_0 ^ 3279305448u)) % 14u)
				{
				case 0u:
					output.WriteRawTag(42);
					arg_16B_0 = (num * 2400961921u ^ 2857604568u);
					continue;
				case 1u:
					goto IL_1B0;
				case 2u:
					output.WriteMessage(this.MemberId);
					arg_16B_0 = (num * 3502027523u ^ 3624806527u);
					continue;
				case 3u:
					output.WriteMessage(this.AgentId);
					arg_16B_0 = (num * 170854364u ^ 2283596435u);
					continue;
				case 4u:
					arg_16B_0 = ((this.subscriber_ == null) ? 4001468008u : 2331108190u);
					continue;
				case 5u:
					arg_16B_0 = (((this.Reason == 0u) ? 3058078898u : 3803936442u) ^ num * 2001056607u);
					continue;
				case 6u:
					output.WriteMessage(this.Subscriber);
					arg_16B_0 = (num * 4175127420u ^ 629690496u);
					continue;
				case 7u:
					output.WriteRawTag(34);
					output.WriteMessage(this.ChannelId);
					arg_16B_0 = (num * 601385855u ^ 374398609u);
					continue;
				case 9u:
					arg_16B_0 = ((this.channelId_ == null) ? 2847606794u : 4209862669u);
					continue;
				case 10u:
					output.WriteRawTag(10);
					arg_16B_0 = (num * 2663712724u ^ 761397771u);
					continue;
				case 11u:
					goto IL_45;
				case 12u:
					output.WriteUInt32(this.Reason);
					arg_16B_0 = (num * 4098222369u ^ 2898264875u);
					continue;
				case 13u:
					output.WriteRawTag(24);
					arg_16B_0 = (num * 3763786899u ^ 2884136961u);
					continue;
				}
				break;
			}
			return;
			IL_45:
			arg_16B_0 = 4225435054u;
			goto IL_166;
			IL_1B0:
			output.WriteRawTag(18);
			arg_16B_0 = 2348254220u;
			goto IL_166;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_179:
				uint arg_140_0 = 1655425227u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_140_0 ^ 389503796u)) % 11u)
					{
					case 0u:
						goto IL_179;
					case 1u:
						arg_140_0 = (((this.agentId_ != null) ? 3086249054u : 3730191658u) ^ num2 * 3186913476u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_140_0 = (num2 * 1711231218u ^ 3673451354u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
						arg_140_0 = (num2 * 2570103633u ^ 2069187624u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
						arg_140_0 = (num2 * 2249533756u ^ 2649742037u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
						arg_140_0 = 805743583u;
						continue;
					case 7u:
						arg_140_0 = (((this.Reason == 0u) ? 1297292551u : 1704918555u) ^ num2 * 3754888333u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_140_0 = (num2 * 1658280204u ^ 70004757u);
						continue;
					case 9u:
						arg_140_0 = ((this.channelId_ == null) ? 1913039965u : 1285479346u);
						continue;
					case 10u:
						arg_140_0 = ((this.subscriber_ != null) ? 1661786790u : 1329797869u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(MemberRemovedNotification other)
		{
			if (other == null)
			{
				goto IL_1DF;
			}
			goto IL_2C4;
			uint arg_254_0;
			while (true)
			{
				IL_24F:
				uint num;
				switch ((num = (arg_254_0 ^ 260824695u)) % 21u)
				{
				case 0u:
					this.MemberId.MergeFrom(other.MemberId);
					arg_254_0 = 1297981803u;
					continue;
				case 1u:
					arg_254_0 = ((other.subscriber_ == null) ? 2106276739u : 1218851798u);
					continue;
				case 2u:
					goto IL_2C4;
				case 3u:
					this.agentId_ = new EntityId();
					arg_254_0 = (num * 407575369u ^ 2462956544u);
					continue;
				case 4u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_254_0 = 1285890174u;
					continue;
				case 5u:
					goto IL_1DF;
				case 6u:
					arg_254_0 = (((this.channelId_ == null) ? 1281702833u : 225400893u) ^ num * 4241968528u);
					continue;
				case 7u:
					this.channelId_ = new ChannelId();
					arg_254_0 = (num * 4061626318u ^ 127807577u);
					continue;
				case 8u:
					this.Reason = other.Reason;
					arg_254_0 = (num * 3550527524u ^ 1795425076u);
					continue;
				case 9u:
					arg_254_0 = ((other.memberId_ == null) ? 1297981803u : 640693915u);
					continue;
				case 10u:
					arg_254_0 = (((this.subscriber_ == null) ? 730577020u : 1127617455u) ^ num * 1440280998u);
					continue;
				case 11u:
					arg_254_0 = (((this.agentId_ == null) ? 2774122336u : 3682623687u) ^ num * 1641247371u);
					continue;
				case 12u:
					this.memberId_ = new EntityId();
					arg_254_0 = (num * 1067174194u ^ 3320396879u);
					continue;
				case 13u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_254_0 = 1361379246u;
					continue;
				case 15u:
					arg_254_0 = ((other.Reason != 0u) ? 2072200785u : 1175840364u);
					continue;
				case 16u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_254_0 = 2106276739u;
					continue;
				case 17u:
					arg_254_0 = ((other.channelId_ != null) ? 1438487218u : 1285890174u);
					continue;
				case 18u:
					arg_254_0 = (((this.memberId_ != null) ? 2554877447u : 2455242091u) ^ num * 3202540364u);
					continue;
				case 19u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_254_0 = (num * 1154171792u ^ 433709209u);
					continue;
				case 20u:
					return;
				}
				break;
			}
			return;
			IL_1DF:
			arg_254_0 = 1245520607u;
			goto IL_24F;
			IL_2C4:
			arg_254_0 = ((other.agentId_ == null) ? 1361379246u : 1563237428u);
			goto IL_24F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_336:
				uint num;
				uint arg_2B2_0 = ((num = input.ReadTag()) == 0u) ? 3450627796u : 3407350645u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2B2_0 ^ 2440066659u)) % 26u)
					{
					case 0u:
						arg_2B2_0 = ((this.memberId_ != null) ? 3004692867u : 2783210342u);
						continue;
					case 1u:
						arg_2B2_0 = ((this.channelId_ == null) ? 2925942482u : 2371999662u);
						continue;
					case 2u:
						arg_2B2_0 = ((num > 18u) ? 4128773144u : 2726264325u);
						continue;
					case 3u:
						arg_2B2_0 = ((num == 24u) ? 4227609601u : 3310828511u);
						continue;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_2B2_0 = 2843532596u;
						continue;
					case 5u:
						arg_2B2_0 = ((this.agentId_ == null) ? 2149782884u : 4201311749u);
						continue;
					case 6u:
						arg_2B2_0 = (((num == 18u) ? 2635557481u : 3999046745u) ^ num2 * 129880019u);
						continue;
					case 7u:
						this.agentId_ = new EntityId();
						arg_2B2_0 = (num2 * 180623919u ^ 1205013068u);
						continue;
					case 8u:
						input.ReadMessage(this.memberId_);
						arg_2B2_0 = 2321041102u;
						continue;
					case 9u:
						this.channelId_ = new ChannelId();
						arg_2B2_0 = (num2 * 3720862469u ^ 3533494747u);
						continue;
					case 10u:
						arg_2B2_0 = (((num == 10u) ? 55111916u : 1188276849u) ^ num2 * 1829712379u);
						continue;
					case 11u:
						goto IL_336;
					case 12u:
						input.SkipLastField();
						arg_2B2_0 = 2321041102u;
						continue;
					case 14u:
						arg_2B2_0 = (num2 * 935950610u ^ 997021277u);
						continue;
					case 15u:
						arg_2B2_0 = (num2 * 3156516006u ^ 2256820388u);
						continue;
					case 16u:
						arg_2B2_0 = (((num != 34u) ? 2811026285u : 3023789280u) ^ num2 * 2201127861u);
						continue;
					case 17u:
						input.ReadMessage(this.channelId_);
						arg_2B2_0 = 2321041102u;
						continue;
					case 18u:
						arg_2B2_0 = (((num != 42u) ? 4127676379u : 2679667509u) ^ num2 * 1826657961u);
						continue;
					case 19u:
						input.ReadMessage(this.subscriber_);
						arg_2B2_0 = 2321041102u;
						continue;
					case 20u:
						arg_2B2_0 = ((this.subscriber_ != null) ? 3450151862u : 2546955826u);
						continue;
					case 21u:
						this.memberId_ = new EntityId();
						arg_2B2_0 = (num2 * 538845782u ^ 4012216365u);
						continue;
					case 22u:
						this.Reason = input.ReadUInt32();
						arg_2B2_0 = 4186814347u;
						continue;
					case 23u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_2B2_0 = (num2 * 426519665u ^ 338439287u);
						continue;
					case 24u:
						arg_2B2_0 = (num2 * 3473672916u ^ 13624046u);
						continue;
					case 25u:
						arg_2B2_0 = 3407350645u;
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
