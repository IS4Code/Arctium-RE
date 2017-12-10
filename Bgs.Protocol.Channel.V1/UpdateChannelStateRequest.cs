using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class UpdateChannelStateRequest : IMessage<UpdateChannelStateRequest>, IEquatable<UpdateChannelStateRequest>, IDeepCloneable<UpdateChannelStateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateChannelStateRequest.__c __9 = new UpdateChannelStateRequest.__c();

			internal UpdateChannelStateRequest cctor>b__29_0()
			{
				return new UpdateChannelStateRequest();
			}
		}

		private static readonly MessageParser<UpdateChannelStateRequest> _parser = new MessageParser<UpdateChannelStateRequest>(new Func<UpdateChannelStateRequest>(UpdateChannelStateRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int StateChangeFieldNumber = 2;

		private ChannelState stateChange_;

		public static MessageParser<UpdateChannelStateRequest> Parser
		{
			get
			{
				return UpdateChannelStateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateChannelStateRequest.Descriptor;
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

		public UpdateChannelStateRequest()
		{
		}

		public UpdateChannelStateRequest(UpdateChannelStateRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.StateChange = ((other.stateChange_ != null) ? other.StateChange.Clone() : null);
		}

		public UpdateChannelStateRequest Clone()
		{
			return new UpdateChannelStateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateChannelStateRequest);
		}

		public bool Equals(UpdateChannelStateRequest other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 1681943319) % 9)
				{
				case 0:
					goto IL_B5;
				case 1:
					return false;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					goto IL_6D;
				case 6:
					arg_77_0 = ((!UpdateChannelStateRequest.smethod_0(this.StateChange, other.StateChange)) ? 249755790 : 813194476);
					continue;
				case 7:
					return false;
				case 8:
					arg_77_0 = ((!UpdateChannelStateRequest.smethod_0(this.AgentId, other.AgentId)) ? 413430495 : 2035742093);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 1555078173;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 1730069376 : 1855602883);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_29;
			}
			goto IL_4F;
			uint arg_33_0;
			while (true)
			{
				IL_2E:
				uint num2;
				switch ((num2 = (arg_33_0 ^ 706254530u)) % 4u)
				{
				case 0u:
					goto IL_29;
				case 1u:
					num ^= UpdateChannelStateRequest.smethod_1(this.AgentId);
					arg_33_0 = (num2 * 3602720319u ^ 3868761782u);
					continue;
				case 3u:
					goto IL_4F;
				}
				break;
			}
			return num;
			IL_29:
			arg_33_0 = 685926663u;
			goto IL_2E;
			IL_4F:
			num ^= UpdateChannelStateRequest.smethod_1(this.StateChange);
			arg_33_0 = 1776258796u;
			goto IL_2E;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_08;
			}
			goto IL_83;
			uint arg_5F_0;
			while (true)
			{
				IL_5A:
				uint num;
				switch ((num = (arg_5F_0 ^ 1107313464u)) % 6u)
				{
				case 1u:
					output.WriteMessage(this.StateChange);
					arg_5F_0 = (num * 3918776426u ^ 2067353922u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_5F_0 = (num * 1959480156u ^ 2134354956u);
					continue;
				case 3u:
					goto IL_83;
				case 4u:
					output.WriteMessage(this.AgentId);
					arg_5F_0 = (num * 1192338562u ^ 2335006013u);
					continue;
				case 5u:
					goto IL_08;
				}
				break;
			}
			return;
			IL_08:
			arg_5F_0 = 29689570u;
			goto IL_5A;
			IL_83:
			output.WriteRawTag(18);
			arg_5F_0 = 121745973u;
			goto IL_5A;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_89:
				uint arg_69_0 = 3348303196u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_69_0 ^ 3263655705u)) % 5u)
					{
					case 0u:
						goto IL_89;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.StateChange);
						arg_69_0 = 3297555913u;
						continue;
					case 2u:
						arg_69_0 = (((this.agentId_ == null) ? 3822655513u : 3933738768u) ^ num2 * 3314874941u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_69_0 = (num2 * 3939517333u ^ 1775150512u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UpdateChannelStateRequest other)
		{
			if (other == null)
			{
				goto IL_C9;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 3907021353u)) % 11u)
				{
				case 0u:
					this.stateChange_ = new ChannelState();
					arg_105_0 = (num * 3870817261u ^ 2465983244u);
					continue;
				case 1u:
					this.StateChange.MergeFrom(other.StateChange);
					arg_105_0 = 4173495461u;
					continue;
				case 2u:
					goto IL_C9;
				case 3u:
					arg_105_0 = ((other.stateChange_ != null) ? 2320109507u : 4173495461u);
					continue;
				case 4u:
					goto IL_14D;
				case 5u:
					arg_105_0 = (((this.stateChange_ != null) ? 780831461u : 1163386980u) ^ num * 720174191u);
					continue;
				case 6u:
					return;
				case 7u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_105_0 = 2840675756u;
					continue;
				case 8u:
					this.agentId_ = new EntityId();
					arg_105_0 = (num * 4167579291u ^ 3097430373u);
					continue;
				case 10u:
					arg_105_0 = (((this.agentId_ == null) ? 3695877262u : 3234078410u) ^ num * 1510610179u);
					continue;
				}
				break;
			}
			return;
			IL_C9:
			arg_105_0 = 3925112538u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.agentId_ == null) ? 2840675756u : 3544201528u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_183:
				uint num;
				uint arg_133_0 = ((num = input.ReadTag()) != 0u) ? 3435356681u : 3634287023u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_133_0 ^ 3225479728u)) % 13u)
					{
					case 0u:
						arg_133_0 = 3435356681u;
						continue;
					case 1u:
						this.stateChange_ = new ChannelState();
						arg_133_0 = (num2 * 1461606854u ^ 577107048u);
						continue;
					case 3u:
						arg_133_0 = ((this.agentId_ != null) ? 2219842068u : 3174485647u);
						continue;
					case 4u:
						arg_133_0 = (((num != 18u) ? 1386048217u : 1775404250u) ^ num2 * 1651130454u);
						continue;
					case 5u:
						input.ReadMessage(this.stateChange_);
						arg_133_0 = 4246699404u;
						continue;
					case 6u:
						this.agentId_ = new EntityId();
						arg_133_0 = (num2 * 2283840704u ^ 1549136212u);
						continue;
					case 7u:
						arg_133_0 = (num2 * 3175832254u ^ 2060522730u);
						continue;
					case 8u:
						goto IL_183;
					case 9u:
						arg_133_0 = ((num == 10u) ? 3178824278u : 3909017054u);
						continue;
					case 10u:
						arg_133_0 = ((this.stateChange_ != null) ? 2642851582u : 3657163849u);
						continue;
					case 11u:
						input.ReadMessage(this.agentId_);
						arg_133_0 = 4246699404u;
						continue;
					case 12u:
						input.SkipLastField();
						arg_133_0 = (num2 * 2314427981u ^ 3084184740u);
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
