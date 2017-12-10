using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class UpdateChannelStateNotification : IMessage<UpdateChannelStateNotification>, IEquatable<UpdateChannelStateNotification>, IDeepCloneable<UpdateChannelStateNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateChannelStateNotification.__c __9 = new UpdateChannelStateNotification.__c();

			internal UpdateChannelStateNotification cctor>b__39_0()
			{
				return new UpdateChannelStateNotification();
			}
		}

		private static readonly MessageParser<UpdateChannelStateNotification> _parser = new MessageParser<UpdateChannelStateNotification>(new Func<UpdateChannelStateNotification>(UpdateChannelStateNotification.__c.__9.<.cctor>b__39_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int StateChangeFieldNumber = 2;

		private ChannelState stateChange_;

		public const int ChannelIdFieldNumber = 3;

		private ChannelId channelId_;

		public const int SubscriberFieldNumber = 4;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public static MessageParser<UpdateChannelStateNotification> Parser
		{
			get
			{
				return UpdateChannelStateNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateChannelStateNotification.Descriptor;
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

		public ChannelState StateChange
		{
			get
			{
				return this.stateChange_;
			}
			set
			{
				this.stateChange_ = value;
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

		public UpdateChannelStateNotification()
		{
		}

		public UpdateChannelStateNotification(UpdateChannelStateNotification other) : this()
		{
			while (true)
			{
				IL_B1:
				int arg_93_0 = -582971106;
				while (true)
				{
					switch ((arg_93_0 ^ -592326298) % 5)
					{
					case 0:
						goto IL_B1;
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_93_0 = -461147441;
						continue;
					case 2:
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
						arg_93_0 = -524352020;
						continue;
					case 3:
						this.StateChange = ((other.stateChange_ != null) ? other.StateChange.Clone() : null);
						arg_93_0 = -1417812937;
						continue;
					}
					return;
				}
			}
		}

		public UpdateChannelStateNotification Clone()
		{
			return new UpdateChannelStateNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateChannelStateNotification);
		}

		public bool Equals(UpdateChannelStateNotification other)
		{
			if (other == null)
			{
				goto IL_CE;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ -1642326095) % 13)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					goto IL_CE;
				case 4:
					arg_D8_0 = ((!UpdateChannelStateNotification.smethod_0(this.StateChange, other.StateChange)) ? -2088751989 : -1950595263);
					continue;
				case 5:
					arg_D8_0 = (UpdateChannelStateNotification.smethod_0(this.ChannelId, other.ChannelId) ? -1312037880 : -1308376503);
					continue;
				case 6:
					goto IL_126;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_D8_0 = (UpdateChannelStateNotification.smethod_0(this.Subscriber, other.Subscriber) ? -1616244250 : -1032091748);
					continue;
				case 10:
					return false;
				case 11:
					arg_D8_0 = ((!UpdateChannelStateNotification.smethod_0(this.AgentId, other.AgentId)) ? -1708889696 : -1436284152);
					continue;
				}
				break;
			}
			return true;
			IL_CE:
			arg_D8_0 = -1390436414;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other == this) ? -103018446 : -828632907);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_120:
				uint arg_EF_0 = 855157566u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_EF_0 ^ 1080531338u)) % 9u)
					{
					case 0u:
						arg_EF_0 = ((this.subscriber_ == null) ? 522212852u : 1395477771u);
						continue;
					case 1u:
						num ^= UpdateChannelStateNotification.smethod_1(this.StateChange);
						arg_EF_0 = 668166058u;
						continue;
					case 2u:
						num ^= UpdateChannelStateNotification.smethod_1(this.Subscriber);
						arg_EF_0 = (num2 * 1754909990u ^ 763334098u);
						continue;
					case 3u:
						num ^= UpdateChannelStateNotification.smethod_1(this.AgentId);
						arg_EF_0 = (num2 * 3106679633u ^ 2882877849u);
						continue;
					case 5u:
						arg_EF_0 = (((this.agentId_ != null) ? 3822290783u : 4101554076u) ^ num2 * 3148348987u);
						continue;
					case 6u:
						goto IL_120;
					case 7u:
						num ^= UpdateChannelStateNotification.smethod_1(this.ChannelId);
						arg_EF_0 = (num2 * 3756065025u ^ 2572837892u);
						continue;
					case 8u:
						arg_EF_0 = (((this.channelId_ != null) ? 1057683203u : 1548607885u) ^ num2 * 4059417353u);
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
				goto IL_C1;
			}
			goto IL_11F;
			uint arg_EE_0;
			while (true)
			{
				IL_E9:
				uint num;
				switch ((num = (arg_EE_0 ^ 2255582124u)) % 9u)
				{
				case 1u:
					output.WriteRawTag(26);
					output.WriteMessage(this.ChannelId);
					arg_EE_0 = (num * 4068615681u ^ 2265688861u);
					continue;
				case 2u:
					goto IL_C1;
				case 3u:
					goto IL_11F;
				case 4u:
					output.WriteRawTag(34);
					output.WriteMessage(this.Subscriber);
					arg_EE_0 = (num * 1749753191u ^ 2334915074u);
					continue;
				case 5u:
					arg_EE_0 = (((this.channelId_ != null) ? 671538890u : 1563902587u) ^ num * 1841861416u);
					continue;
				case 6u:
					output.WriteMessage(this.StateChange);
					arg_EE_0 = (num * 294584427u ^ 3979352210u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_EE_0 = (num * 303622308u ^ 965635156u);
					continue;
				case 8u:
					arg_EE_0 = ((this.subscriber_ == null) ? 4260806033u : 2299219801u);
					continue;
				}
				break;
			}
			return;
			IL_C1:
			arg_EE_0 = 2998725446u;
			goto IL_E9;
			IL_11F:
			output.WriteRawTag(18);
			arg_EE_0 = 4291148252u;
			goto IL_E9;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_3E;
			}
			goto IL_DE;
			uint arg_A7_0;
			while (true)
			{
				IL_A2:
				uint num2;
				switch ((num2 = (arg_A7_0 ^ 4036211738u)) % 7u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
					arg_A7_0 = (num2 * 3759254122u ^ 3443716230u);
					continue;
				case 2u:
					arg_A7_0 = ((this.subscriber_ != null) ? 3090607654u : 2203599366u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
					arg_A7_0 = (num2 * 2675870517u ^ 4237951082u);
					continue;
				case 4u:
					goto IL_3E;
				case 5u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_A7_0 = (num2 * 4020850134u ^ 2559137712u);
					continue;
				case 6u:
					goto IL_DE;
				}
				break;
			}
			return num;
			IL_3E:
			arg_A7_0 = 3615064650u;
			goto IL_A2;
			IL_DE:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.StateChange);
			arg_A7_0 = ((this.channelId_ != null) ? 4235645512u : 4112654706u);
			goto IL_A2;
		}

		public void MergeFrom(UpdateChannelStateNotification other)
		{
			if (other == null)
			{
				goto IL_72;
			}
			goto IL_27D;
			uint arg_215_0;
			while (true)
			{
				IL_210:
				uint num;
				switch ((num = (arg_215_0 ^ 1349634352u)) % 19u)
				{
				case 0u:
					arg_215_0 = (((this.subscriber_ == null) ? 1340546501u : 1197859411u) ^ num * 3998993658u);
					continue;
				case 1u:
					this.stateChange_ = new ChannelState();
					arg_215_0 = (num * 2396870813u ^ 2738058873u);
					continue;
				case 2u:
					this.agentId_ = new EntityId();
					arg_215_0 = (num * 2081181368u ^ 1208200076u);
					continue;
				case 3u:
					arg_215_0 = (((this.agentId_ != null) ? 935468187u : 1542549582u) ^ num * 3413966261u);
					continue;
				case 4u:
					arg_215_0 = ((other.subscriber_ != null) ? 1307756674u : 318337879u);
					continue;
				case 5u:
					arg_215_0 = (((this.channelId_ == null) ? 4280661599u : 2319493417u) ^ num * 3084488781u);
					continue;
				case 6u:
					goto IL_27D;
				case 7u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_215_0 = 318337879u;
					continue;
				case 8u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_215_0 = 974495083u;
					continue;
				case 9u:
					arg_215_0 = ((other.channelId_ != null) ? 580864589u : 1971261310u);
					continue;
				case 10u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_215_0 = (num * 2071727217u ^ 985434134u);
					continue;
				case 11u:
					arg_215_0 = (((this.stateChange_ == null) ? 1973106836u : 2088311241u) ^ num * 3079521685u);
					continue;
				case 13u:
					return;
				case 14u:
					this.channelId_ = new ChannelId();
					arg_215_0 = (num * 3857057902u ^ 660231684u);
					continue;
				case 15u:
					goto IL_72;
				case 16u:
					this.StateChange.MergeFrom(other.StateChange);
					arg_215_0 = 1966632969u;
					continue;
				case 17u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_215_0 = 1971261310u;
					continue;
				case 18u:
					arg_215_0 = ((other.stateChange_ == null) ? 1966632969u : 698295085u);
					continue;
				}
				break;
			}
			return;
			IL_72:
			arg_215_0 = 1058296515u;
			goto IL_210;
			IL_27D:
			arg_215_0 = ((other.agentId_ == null) ? 974495083u : 1372638947u);
			goto IL_210;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2D9:
				uint num;
				uint arg_261_0 = ((num = input.ReadTag()) != 0u) ? 3874509795u : 2422499713u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_261_0 ^ 2553552371u)) % 23u)
					{
					case 0u:
						this.stateChange_ = new ChannelState();
						arg_261_0 = (num2 * 2412476100u ^ 2964052126u);
						continue;
					case 1u:
						arg_261_0 = (((num != 34u) ? 4117814922u : 2503797537u) ^ num2 * 417295782u);
						continue;
					case 2u:
						arg_261_0 = (((num == 18u) ? 3994176271u : 2550750671u) ^ num2 * 196233152u);
						continue;
					case 3u:
						this.channelId_ = new ChannelId();
						arg_261_0 = (num2 * 3293738469u ^ 3096300803u);
						continue;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_261_0 = 3835294388u;
						continue;
					case 5u:
						this.agentId_ = new EntityId();
						arg_261_0 = (num2 * 135864003u ^ 1893303729u);
						continue;
					case 6u:
						arg_261_0 = (num2 * 3604934645u ^ 359271750u);
						continue;
					case 7u:
						arg_261_0 = (((num != 10u) ? 4195890818u : 3726926509u) ^ num2 * 2596800732u);
						continue;
					case 8u:
						arg_261_0 = (num2 * 3455331912u ^ 229131196u);
						continue;
					case 9u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_261_0 = (num2 * 2913214433u ^ 3284148085u);
						continue;
					case 10u:
						input.ReadMessage(this.channelId_);
						arg_261_0 = 3835294388u;
						continue;
					case 11u:
						arg_261_0 = ((num <= 18u) ? 3896628548u : 4190975167u);
						continue;
					case 12u:
						goto IL_2D9;
					case 13u:
						input.SkipLastField();
						arg_261_0 = 2617156714u;
						continue;
					case 14u:
						arg_261_0 = ((this.agentId_ == null) ? 3232005457u : 2445742807u);
						continue;
					case 15u:
						arg_261_0 = ((this.subscriber_ != null) ? 3332533689u : 2550948287u);
						continue;
					case 16u:
						arg_261_0 = ((this.channelId_ != null) ? 4284758205u : 2264358677u);
						continue;
					case 17u:
						input.ReadMessage(this.stateChange_);
						arg_261_0 = 3835294388u;
						continue;
					case 19u:
						arg_261_0 = 3874509795u;
						continue;
					case 20u:
						input.ReadMessage(this.subscriber_);
						arg_261_0 = 3835294388u;
						continue;
					case 21u:
						arg_261_0 = ((this.stateChange_ != null) ? 3362445402u : 3992172402u);
						continue;
					case 22u:
						arg_261_0 = ((num == 26u) ? 4047767074u : 4244893731u);
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
