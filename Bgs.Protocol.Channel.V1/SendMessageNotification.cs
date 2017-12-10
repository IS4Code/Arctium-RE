using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class SendMessageNotification : IMessage<SendMessageNotification>, IEquatable<SendMessageNotification>, IDeepCloneable<SendMessageNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendMessageNotification.__c __9 = new SendMessageNotification.__c();

			internal SendMessageNotification cctor>b__49_0()
			{
				return new SendMessageNotification();
			}
		}

		private static readonly MessageParser<SendMessageNotification> _parser = new MessageParser<SendMessageNotification>(new Func<SendMessageNotification>(SendMessageNotification.__c.__9.<.cctor>b__49_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int MessageFieldNumber = 2;

		private Message message_;

		public const int RequiredPrivilegesFieldNumber = 3;

		private ulong requiredPrivileges_;

		public const int IdentityFieldNumber = 4;

		private string identity_ = "";

		public const int ChannelIdFieldNumber = 5;

		private ChannelId channelId_;

		public const int SubscriberFieldNumber = 6;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public static MessageParser<SendMessageNotification> Parser
		{
			get
			{
				return SendMessageNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageNotification.Descriptor;
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

		public Message Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		public ulong RequiredPrivileges
		{
			get
			{
				return this.requiredPrivileges_;
			}
			set
			{
				this.requiredPrivileges_ = value;
			}
		}

		public string Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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

		public SendMessageNotification()
		{
		}

		public SendMessageNotification(SendMessageNotification other) : this()
		{
			while (true)
			{
				IL_CA:
				uint arg_A6_0 = 2949938776u;
				while (true)
				{
					uint num;
					switch ((num = (arg_A6_0 ^ 2386836935u)) % 6u)
					{
					case 0u:
						this.identity_ = other.identity_;
						arg_A6_0 = (num * 2360223203u ^ 4213567853u);
						continue;
					case 1u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.Message = ((other.message_ != null) ? other.Message.Clone() : null);
						arg_A6_0 = 2579089506u;
						continue;
					case 2u:
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						arg_A6_0 = 2281390182u;
						continue;
					case 4u:
						goto IL_CA;
					case 5u:
						this.requiredPrivileges_ = other.requiredPrivileges_;
						arg_A6_0 = (num * 3314484689u ^ 475774018u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
		}

		public SendMessageNotification Clone()
		{
			return new SendMessageNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageNotification);
		}

		public bool Equals(SendMessageNotification other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_18C;
			int arg_12E_0;
			while (true)
			{
				IL_129:
				switch ((arg_12E_0 ^ 1405928482) % 17)
				{
				case 0:
					return false;
				case 1:
					arg_12E_0 = ((!SendMessageNotification.smethod_0(this.AgentId, other.AgentId)) ? 1402405254 : 382703837);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return false;
				case 6:
					arg_12E_0 = (SendMessageNotification.smethod_0(this.ChannelId, other.ChannelId) ? 1448964536 : 1595085169);
					continue;
				case 7:
					arg_12E_0 = ((this.RequiredPrivileges != other.RequiredPrivileges) ? 874952389 : 524606008);
					continue;
				case 8:
					goto IL_18C;
				case 9:
					arg_12E_0 = (SendMessageNotification.smethod_0(this.Subscriber, other.Subscriber) ? 2038870150 : 601789551);
					continue;
				case 10:
					return false;
				case 11:
					arg_12E_0 = (SendMessageNotification.smethod_0(this.Message, other.Message) ? 1169366844 : 870283214);
					continue;
				case 12:
					return true;
				case 13:
					arg_12E_0 = (SendMessageNotification.smethod_1(this.Identity, other.Identity) ? 167336296 : 2056344283);
					continue;
				case 14:
					goto IL_18;
				case 15:
					return false;
				case 16:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_12E_0 = 2081969738;
			goto IL_129;
			IL_18C:
			arg_12E_0 = ((other == this) ? 703557770 : 178250320);
			goto IL_129;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_86;
			}
			goto IL_179;
			uint arg_131_0;
			while (true)
			{
				IL_12C:
				uint num2;
				switch ((num2 = (arg_131_0 ^ 2718267739u)) % 11u)
				{
				case 0u:
					arg_131_0 = ((this.subscriber_ == null) ? 2474490393u : 3462542633u);
					continue;
				case 1u:
					num ^= this.Identity.GetHashCode();
					arg_131_0 = (num2 * 1335119942u ^ 1995936952u);
					continue;
				case 2u:
					arg_131_0 = ((this.Identity.Length == 0) ? 3580256658u : 4128086204u);
					continue;
				case 3u:
					goto IL_179;
				case 4u:
					num ^= this.ChannelId.GetHashCode();
					arg_131_0 = (num2 * 183387728u ^ 1854034263u);
					continue;
				case 5u:
					num ^= this.Subscriber.GetHashCode();
					arg_131_0 = (num2 * 4187692082u ^ 821222493u);
					continue;
				case 6u:
					goto IL_86;
				case 8u:
					num ^= this.RequiredPrivileges.GetHashCode();
					arg_131_0 = (num2 * 2200072523u ^ 3224666874u);
					continue;
				case 9u:
					num ^= SendMessageNotification.smethod_2(this.AgentId);
					arg_131_0 = (num2 * 2975028775u ^ 1199447075u);
					continue;
				case 10u:
					arg_131_0 = ((this.channelId_ != null) ? 3390663622u : 3411078727u);
					continue;
				}
				break;
			}
			return num;
			IL_86:
			arg_131_0 = 3161904002u;
			goto IL_12C;
			IL_179:
			num ^= SendMessageNotification.smethod_2(this.Message);
			arg_131_0 = ((this.RequiredPrivileges != 0uL) ? 2178938013u : 3755175416u);
			goto IL_12C;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_176;
			}
			goto IL_1D4;
			uint arg_180_0;
			while (true)
			{
				IL_17B:
				uint num;
				switch ((num = (arg_180_0 ^ 3148151958u)) % 14u)
				{
				case 0u:
					goto IL_176;
				case 1u:
					arg_180_0 = ((this.channelId_ == null) ? 3751534054u : 4159611096u);
					continue;
				case 2u:
					output.WriteMessage(this.Subscriber);
					arg_180_0 = (num * 1850481393u ^ 2065812190u);
					continue;
				case 3u:
					output.WriteRawTag(24);
					output.WriteUInt64(this.RequiredPrivileges);
					arg_180_0 = (num * 3943047113u ^ 3986694914u);
					continue;
				case 4u:
					output.WriteString(this.Identity);
					arg_180_0 = (num * 573566848u ^ 1309751189u);
					continue;
				case 5u:
					arg_180_0 = ((SendMessageNotification.smethod_3(this.Identity) != 0) ? 2599399877u : 2583665557u);
					continue;
				case 6u:
					output.WriteMessage(this.AgentId);
					arg_180_0 = (num * 2474477767u ^ 1155690589u);
					continue;
				case 7u:
					output.WriteRawTag(34);
					arg_180_0 = (num * 3285022423u ^ 1813816203u);
					continue;
				case 8u:
					arg_180_0 = ((this.subscriber_ == null) ? 2605113330u : 4096126875u);
					continue;
				case 9u:
					goto IL_1D4;
				case 11u:
					output.WriteRawTag(10);
					arg_180_0 = (num * 786165733u ^ 2907964995u);
					continue;
				case 12u:
					output.WriteRawTag(42);
					output.WriteMessage(this.ChannelId);
					arg_180_0 = (num * 705810672u ^ 41432262u);
					continue;
				case 13u:
					output.WriteRawTag(50);
					arg_180_0 = (num * 1660004225u ^ 3239954423u);
					continue;
				}
				break;
			}
			return;
			IL_176:
			arg_180_0 = 3467045247u;
			goto IL_17B;
			IL_1D4:
			output.WriteRawTag(18);
			output.WriteMessage(this.Message);
			arg_180_0 = ((this.RequiredPrivileges == 0uL) ? 3841332815u : 3889508339u);
			goto IL_17B;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1CC:
				uint arg_18B_0 = 3561305828u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_18B_0 ^ 3849662867u)) % 13u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_18B_0 = (num2 * 4240702393u ^ 2552705408u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Identity);
						arg_18B_0 = (num2 * 1901174488u ^ 2701458195u);
						continue;
					case 2u:
						arg_18B_0 = ((SendMessageNotification.smethod_3(this.Identity) != 0) ? 2193364233u : 3825407715u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_18B_0 = (num2 * 1764129045u ^ 3881764205u);
						continue;
					case 4u:
						goto IL_1CC;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.RequiredPrivileges);
						arg_18B_0 = (num2 * 2257363106u ^ 1309778077u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
						arg_18B_0 = 3545614010u;
						continue;
					case 8u:
						arg_18B_0 = ((this.subscriber_ == null) ? 3878653283u : 3833073372u);
						continue;
					case 9u:
						arg_18B_0 = (((this.RequiredPrivileges == 0uL) ? 4234144296u : 3989144913u) ^ num2 * 1864201591u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
						arg_18B_0 = (num2 * 1477825527u ^ 2942222170u);
						continue;
					case 11u:
						arg_18B_0 = (((this.agentId_ == null) ? 2104322365u : 2070042158u) ^ num2 * 3434211979u);
						continue;
					case 12u:
						arg_18B_0 = ((this.channelId_ == null) ? 3587227644u : 4165227294u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(SendMessageNotification other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_313;
			uint arg_29B_0;
			while (true)
			{
				IL_296:
				uint num;
				switch ((num = (arg_29B_0 ^ 2596052667u)) % 23u)
				{
				case 0u:
					this.agentId_ = new EntityId();
					arg_29B_0 = (num * 1680651311u ^ 249637217u);
					continue;
				case 1u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_29B_0 = 3256724406u;
					continue;
				case 2u:
					arg_29B_0 = ((other.RequiredPrivileges != 0uL) ? 3844002965u : 3410786909u);
					continue;
				case 3u:
					this.RequiredPrivileges = other.RequiredPrivileges;
					arg_29B_0 = (num * 3916104912u ^ 3614607165u);
					continue;
				case 4u:
					arg_29B_0 = (((this.subscriber_ == null) ? 378452872u : 1201400331u) ^ num * 3261287054u);
					continue;
				case 5u:
					arg_29B_0 = (((this.agentId_ == null) ? 1384185499u : 1462731905u) ^ num * 2549688988u);
					continue;
				case 6u:
					arg_29B_0 = ((other.subscriber_ != null) ? 2596373027u : 3492747679u);
					continue;
				case 7u:
					this.channelId_ = new ChannelId();
					arg_29B_0 = (num * 4273866428u ^ 2878315161u);
					continue;
				case 8u:
					return;
				case 9u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_29B_0 = 3492747679u;
					continue;
				case 10u:
					this.Message.MergeFrom(other.Message);
					arg_29B_0 = 3666815063u;
					continue;
				case 11u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_29B_0 = 3194540893u;
					continue;
				case 12u:
					goto IL_313;
				case 14u:
					arg_29B_0 = (((this.message_ != null) ? 911985727u : 1298555542u) ^ num * 3033106669u);
					continue;
				case 15u:
					this.Identity = other.Identity;
					arg_29B_0 = (num * 804802855u ^ 3641261191u);
					continue;
				case 16u:
					arg_29B_0 = (((this.channelId_ == null) ? 2122630548u : 363013861u) ^ num * 1946899084u);
					continue;
				case 17u:
					arg_29B_0 = ((SendMessageNotification.smethod_3(other.Identity) == 0) ? 3887292447u : 3791680275u);
					continue;
				case 18u:
					arg_29B_0 = ((other.message_ == null) ? 3666815063u : 3160971821u);
					continue;
				case 19u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_29B_0 = (num * 2078162707u ^ 3753478402u);
					continue;
				case 20u:
					arg_29B_0 = ((other.channelId_ != null) ? 3526892921u : 3194540893u);
					continue;
				case 21u:
					this.message_ = new Message();
					arg_29B_0 = (num * 1542510036u ^ 3586769629u);
					continue;
				case 22u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_29B_0 = 3837003499u;
			goto IL_296;
			IL_313:
			arg_29B_0 = ((other.agentId_ == null) ? 3256724406u : 3851797275u);
			goto IL_296;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_37A:
				uint num;
				uint arg_2EE_0 = ((num = input.ReadTag()) != 0u) ? 1360092066u : 458567445u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2EE_0 ^ 612373155u)) % 28u)
					{
					case 0u:
						arg_2EE_0 = (num2 * 605435755u ^ 1536315760u);
						continue;
					case 1u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_2EE_0 = (num2 * 1540154845u ^ 2485216283u);
						continue;
					case 2u:
						this.RequiredPrivileges = input.ReadUInt64();
						arg_2EE_0 = 1453806574u;
						continue;
					case 3u:
						arg_2EE_0 = ((num != 34u) ? 266516172u : 1548885400u);
						continue;
					case 4u:
						arg_2EE_0 = (num2 * 3735117353u ^ 178317570u);
						continue;
					case 5u:
						arg_2EE_0 = ((this.message_ != null) ? 2123807428u : 922970677u);
						continue;
					case 6u:
						this.channelId_ = new ChannelId();
						arg_2EE_0 = (num2 * 3220389830u ^ 1008845252u);
						continue;
					case 7u:
						arg_2EE_0 = (((num != 18u) ? 4091524686u : 3116080599u) ^ num2 * 2783140243u);
						continue;
					case 8u:
						arg_2EE_0 = (((num == 10u) ? 2886253311u : 4139427116u) ^ num2 * 25661407u);
						continue;
					case 9u:
						arg_2EE_0 = (((num == 50u) ? 1612792393u : 393835700u) ^ num2 * 340784308u);
						continue;
					case 10u:
						arg_2EE_0 = ((this.subscriber_ == null) ? 1924574634u : 1081119710u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_2EE_0 = 1453806574u;
						continue;
					case 12u:
						arg_2EE_0 = ((this.agentId_ != null) ? 1125554859u : 1407898661u);
						continue;
					case 13u:
						arg_2EE_0 = (num2 * 613127549u ^ 4151077939u);
						continue;
					case 14u:
						arg_2EE_0 = 1360092066u;
						continue;
					case 15u:
						this.Identity = input.ReadString();
						arg_2EE_0 = 1956969391u;
						continue;
					case 16u:
						arg_2EE_0 = (((num == 24u) ? 143177605u : 1797150099u) ^ num2 * 46997548u);
						continue;
					case 17u:
						input.ReadMessage(this.subscriber_);
						arg_2EE_0 = 1453806574u;
						continue;
					case 18u:
						this.agentId_ = new EntityId();
						arg_2EE_0 = (num2 * 3593723837u ^ 4267954245u);
						continue;
					case 19u:
						arg_2EE_0 = (((num == 42u) ? 1090887721u : 2024777232u) ^ num2 * 3559829458u);
						continue;
					case 20u:
						arg_2EE_0 = ((this.channelId_ == null) ? 751960045u : 938245520u);
						continue;
					case 21u:
						arg_2EE_0 = ((num > 24u) ? 737136368u : 166211935u);
						continue;
					case 22u:
						this.message_ = new Message();
						arg_2EE_0 = (num2 * 4192734231u ^ 1727031230u);
						continue;
					case 23u:
						input.ReadMessage(this.channelId_);
						arg_2EE_0 = 1480782658u;
						continue;
					case 24u:
						input.ReadMessage(this.agentId_);
						arg_2EE_0 = 1453806574u;
						continue;
					case 25u:
						goto IL_37A;
					case 27u:
						input.ReadMessage(this.message_);
						arg_2EE_0 = 1453806574u;
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
