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
	public sealed class UpdateMemberStateNotification : IMessage<UpdateMemberStateNotification>, IEquatable<UpdateMemberStateNotification>, IDeepCloneable<UpdateMemberStateNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateMemberStateNotification.__c __9 = new UpdateMemberStateNotification.__c();

			internal UpdateMemberStateNotification cctor>b__44_0()
			{
				return new UpdateMemberStateNotification();
			}
		}

		private static readonly MessageParser<UpdateMemberStateNotification> _parser = new MessageParser<UpdateMemberStateNotification>(new Func<UpdateMemberStateNotification>(UpdateMemberStateNotification.__c.__9.<.cctor>b__44_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int StateChangeFieldNumber = 2;

		private static readonly FieldCodec<Member> _repeated_stateChange_codec = FieldCodec.ForMessage<Member>(18u, Member.Parser);

		private readonly RepeatedField<Member> stateChange_ = new RepeatedField<Member>();

		public const int RemovedRoleFieldNumber = 3;

		private static readonly FieldCodec<uint> _repeated_removedRole_codec = FieldCodec.ForUInt32(26u);

		private readonly RepeatedField<uint> removedRole_ = new RepeatedField<uint>();

		public const int ChannelIdFieldNumber = 4;

		private ChannelId channelId_;

		public const int SubscriberFieldNumber = 5;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public static MessageParser<UpdateMemberStateNotification> Parser
		{
			get
			{
				return UpdateMemberStateNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMemberStateNotification.Descriptor;
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

		public RepeatedField<Member> StateChange
		{
			get
			{
				return this.stateChange_;
			}
		}

		public RepeatedField<uint> RemovedRole
		{
			get
			{
				return this.removedRole_;
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

		public UpdateMemberStateNotification()
		{
		}

		public UpdateMemberStateNotification(UpdateMemberStateNotification other) : this()
		{
			while (true)
			{
				IL_A5:
				uint arg_85_0 = 2155922120u;
				while (true)
				{
					uint num;
					switch ((num = (arg_85_0 ^ 4224366541u)) % 5u)
					{
					case 0u:
						goto IL_A5;
					case 1u:
						this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
						arg_85_0 = 2347134806u;
						continue;
					case 3u:
						this.removedRole_ = other.removedRole_.Clone();
						arg_85_0 = (num * 1389563123u ^ 846737169u);
						continue;
					case 4u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.stateChange_ = other.stateChange_.Clone();
						arg_85_0 = 2358331013u;
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
		}

		public UpdateMemberStateNotification Clone()
		{
			return new UpdateMemberStateNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMemberStateNotification);
		}

		public bool Equals(UpdateMemberStateNotification other)
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
				switch ((arg_107_0 ^ 1547878738) % 15)
				{
				case 0:
					return false;
				case 1:
					goto IL_15D;
				case 2:
					arg_107_0 = (this.stateChange_.Equals(other.stateChange_) ? 837464946 : 688645962);
					continue;
				case 3:
					arg_107_0 = (this.removedRole_.Equals(other.removedRole_) ? 1133939901 : 67485430);
					continue;
				case 4:
					arg_107_0 = ((!UpdateMemberStateNotification.smethod_0(this.ChannelId, other.ChannelId)) ? 193049714 : 1166556471);
					continue;
				case 5:
					arg_107_0 = ((!UpdateMemberStateNotification.smethod_0(this.AgentId, other.AgentId)) ? 577344707 : 1002717907);
					continue;
				case 6:
					return false;
				case 8:
					goto IL_47;
				case 9:
					return false;
				case 10:
					arg_107_0 = (UpdateMemberStateNotification.smethod_0(this.Subscriber, other.Subscriber) ? 1600490383 : 1231481732);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return true;
				}
				break;
			}
			return true;
			IL_47:
			arg_107_0 = 1924647573;
			goto IL_102;
			IL_15D:
			arg_107_0 = ((other != this) ? 1854318873 : 1330206149);
			goto IL_102;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_97;
			}
			goto IL_D8;
			uint arg_A1_0;
			while (true)
			{
				IL_9C:
				uint num2;
				switch ((num2 = (arg_A1_0 ^ 4114379538u)) % 7u)
				{
				case 0u:
					goto IL_97;
				case 1u:
					num ^= UpdateMemberStateNotification.smethod_1(this.Subscriber);
					arg_A1_0 = (num2 * 3677193049u ^ 2202261084u);
					continue;
				case 2u:
					num ^= UpdateMemberStateNotification.smethod_1(this.AgentId);
					arg_A1_0 = (num2 * 1789034262u ^ 1983548406u);
					continue;
				case 3u:
					goto IL_D8;
				case 4u:
					num ^= UpdateMemberStateNotification.smethod_1(this.ChannelId);
					arg_A1_0 = (num2 * 2065928323u ^ 1754720455u);
					continue;
				case 5u:
					arg_A1_0 = ((this.subscriber_ != null) ? 2930467252u : 3967663082u);
					continue;
				}
				break;
			}
			return num;
			IL_97:
			arg_A1_0 = 4268409653u;
			goto IL_9C;
			IL_D8:
			num ^= UpdateMemberStateNotification.smethod_1(this.stateChange_);
			num ^= UpdateMemberStateNotification.smethod_1(this.removedRole_);
			arg_A1_0 = ((this.channelId_ != null) ? 2197051314u : 2842842407u);
			goto IL_9C;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_54;
			}
			goto IL_160;
			uint arg_123_0;
			while (true)
			{
				IL_11E:
				uint num;
				switch ((num = (arg_123_0 ^ 3971209753u)) % 12u)
				{
				case 0u:
					output.WriteMessage(this.ChannelId);
					arg_123_0 = (num * 2845704604u ^ 4210474791u);
					continue;
				case 1u:
					output.WriteMessage(this.Subscriber);
					arg_123_0 = (num * 365755258u ^ 4265004637u);
					continue;
				case 2u:
					output.WriteRawTag(34);
					arg_123_0 = (num * 2801960818u ^ 2103325161u);
					continue;
				case 3u:
					output.WriteRawTag(42);
					arg_123_0 = (num * 2260172983u ^ 1998285937u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					arg_123_0 = (num * 2525382236u ^ 4200358097u);
					continue;
				case 5u:
					arg_123_0 = (((this.channelId_ == null) ? 2149023154u : 4188661242u) ^ num * 1415447713u);
					continue;
				case 7u:
					goto IL_160;
				case 8u:
					output.WriteMessage(this.AgentId);
					arg_123_0 = (num * 313646284u ^ 695575506u);
					continue;
				case 9u:
					goto IL_54;
				case 10u:
					arg_123_0 = ((this.subscriber_ != null) ? 2552836622u : 3314455735u);
					continue;
				case 11u:
					this.removedRole_.WriteTo(output, UpdateMemberStateNotification._repeated_removedRole_codec);
					arg_123_0 = (num * 3686590603u ^ 1621278469u);
					continue;
				}
				break;
			}
			return;
			IL_54:
			arg_123_0 = 2671957825u;
			goto IL_11E;
			IL_160:
			this.stateChange_.WriteTo(output, UpdateMemberStateNotification._repeated_stateChange_codec);
			arg_123_0 = 4181015186u;
			goto IL_11E;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_12D:
				uint arg_101_0 = 3595103087u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_101_0 ^ 2347773906u)) % 8u)
					{
					case 0u:
						num += this.stateChange_.CalculateSize(UpdateMemberStateNotification._repeated_stateChange_codec);
						num += this.removedRole_.CalculateSize(UpdateMemberStateNotification._repeated_removedRole_codec);
						arg_101_0 = ((this.channelId_ != null) ? 3040614406u : 3969441696u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
						arg_101_0 = (num2 * 2097013371u ^ 3870425074u);
						continue;
					case 2u:
						arg_101_0 = ((this.subscriber_ == null) ? 2195970793u : 4183702067u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_101_0 = (num2 * 1098599031u ^ 863364140u);
						continue;
					case 5u:
						arg_101_0 = (((this.agentId_ != null) ? 1913368235u : 211983445u) ^ num2 * 2428859011u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_101_0 = (num2 * 2600652638u ^ 3800859974u);
						continue;
					case 7u:
						goto IL_12D;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UpdateMemberStateNotification other)
		{
			if (other == null)
			{
				goto IL_E2;
			}
			goto IL_20A;
			uint arg_1B2_0;
			while (true)
			{
				IL_1AD:
				uint num;
				switch ((num = (arg_1B2_0 ^ 3184958617u)) % 15u)
				{
				case 0u:
					arg_1B2_0 = (((this.channelId_ != null) ? 3326561877u : 3258649586u) ^ num * 1493382148u);
					continue;
				case 1u:
					arg_1B2_0 = ((other.subscriber_ == null) ? 3638200566u : 3505857797u);
					continue;
				case 2u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_1B2_0 = 2783351259u;
					continue;
				case 3u:
					arg_1B2_0 = (((this.subscriber_ != null) ? 1800339654u : 423538025u) ^ num * 2560712119u);
					continue;
				case 5u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_1B2_0 = 2939520357u;
					continue;
				case 6u:
					this.channelId_ = new ChannelId();
					arg_1B2_0 = (num * 1195280328u ^ 2427563993u);
					continue;
				case 7u:
					goto IL_20A;
				case 8u:
					goto IL_E2;
				case 9u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_1B2_0 = 3638200566u;
					continue;
				case 10u:
					arg_1B2_0 = (((this.agentId_ == null) ? 3538976330u : 3340813506u) ^ num * 2291483656u);
					continue;
				case 11u:
					return;
				case 12u:
					this.stateChange_.Add(other.stateChange_);
					this.removedRole_.Add(other.removedRole_);
					arg_1B2_0 = ((other.channelId_ != null) ? 4207762996u : 2783351259u);
					continue;
				case 13u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_1B2_0 = (num * 3111519374u ^ 503132186u);
					continue;
				case 14u:
					this.agentId_ = new EntityId();
					arg_1B2_0 = (num * 1957591726u ^ 4082357920u);
					continue;
				}
				break;
			}
			return;
			IL_E2:
			arg_1B2_0 = 2754770374u;
			goto IL_1AD;
			IL_20A:
			arg_1B2_0 = ((other.agentId_ == null) ? 2939520357u : 2916836938u);
			goto IL_1AD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_324:
				uint num;
				uint arg_2A4_0 = ((num = input.ReadTag()) == 0u) ? 3373349260u : 3262704705u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2A4_0 ^ 2248115575u)) % 25u)
					{
					case 0u:
						arg_2A4_0 = (((num == 18u) ? 2399427570u : 4141470442u) ^ num2 * 2499365022u);
						continue;
					case 1u:
						input.ReadMessage(this.subscriber_);
						arg_2A4_0 = 4115854121u;
						continue;
					case 2u:
						arg_2A4_0 = ((num != 26u) ? 3582314748u : 2565578017u);
						continue;
					case 3u:
						arg_2A4_0 = 3262704705u;
						continue;
					case 4u:
						arg_2A4_0 = (((num != 24u) ? 1652629392u : 6847910u) ^ num2 * 3410658217u);
						continue;
					case 5u:
						arg_2A4_0 = ((num <= 24u) ? 2482663312u : 4052944787u);
						continue;
					case 6u:
						input.ReadMessage(this.channelId_);
						arg_2A4_0 = 4048263346u;
						continue;
					case 7u:
						arg_2A4_0 = (num2 * 2642880907u ^ 1327580638u);
						continue;
					case 8u:
						arg_2A4_0 = (num2 * 1486358784u ^ 833171497u);
						continue;
					case 9u:
						input.ReadMessage(this.agentId_);
						arg_2A4_0 = 2888987932u;
						continue;
					case 10u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_2A4_0 = (num2 * 2392867893u ^ 2956448509u);
						continue;
					case 11u:
						arg_2A4_0 = ((this.agentId_ != null) ? 3778397272u : 2279546109u);
						continue;
					case 12u:
						this.channelId_ = new ChannelId();
						arg_2A4_0 = (num2 * 1337298334u ^ 2031341976u);
						continue;
					case 14u:
						this.removedRole_.AddEntriesFrom(input, UpdateMemberStateNotification._repeated_removedRole_codec);
						arg_2A4_0 = 4115854121u;
						continue;
					case 15u:
						this.agentId_ = new EntityId();
						arg_2A4_0 = (num2 * 35633968u ^ 13587384u);
						continue;
					case 16u:
						this.stateChange_.AddEntriesFrom(input, UpdateMemberStateNotification._repeated_stateChange_codec);
						arg_2A4_0 = 4115854121u;
						continue;
					case 17u:
						arg_2A4_0 = (((num == 10u) ? 3405187356u : 4065688603u) ^ num2 * 812807373u);
						continue;
					case 18u:
						arg_2A4_0 = (num2 * 1873072235u ^ 4011443397u);
						continue;
					case 19u:
						input.SkipLastField();
						arg_2A4_0 = 4115854121u;
						continue;
					case 20u:
						arg_2A4_0 = ((this.subscriber_ == null) ? 3264938124u : 3262233098u);
						continue;
					case 21u:
						arg_2A4_0 = ((this.channelId_ != null) ? 2970478512u : 2949152219u);
						continue;
					case 22u:
						goto IL_324;
					case 23u:
						arg_2A4_0 = (((num != 34u) ? 152758423u : 826413558u) ^ num2 * 3372063668u);
						continue;
					case 24u:
						arg_2A4_0 = (((num != 42u) ? 3709098453u : 4275072519u) ^ num2 * 1334612500u);
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
