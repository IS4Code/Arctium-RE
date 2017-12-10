using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class DissolveRequest : IMessage<DissolveRequest>, IEquatable<DissolveRequest>, IDeepCloneable<DissolveRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly DissolveRequest.__c __9 = new DissolveRequest.__c();

			internal DissolveRequest cctor>b__29_0()
			{
				return new DissolveRequest();
			}
		}

		private static readonly MessageParser<DissolveRequest> _parser = new MessageParser<DissolveRequest>(new Func<DissolveRequest>(DissolveRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int ReasonFieldNumber = 2;

		private uint reason_;

		public static MessageParser<DissolveRequest> Parser
		{
			get
			{
				return DissolveRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveRequest.Descriptor;
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

		public DissolveRequest()
		{
		}

		public DissolveRequest(DissolveRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.reason_ = other.reason_;
		}

		public DissolveRequest Clone()
		{
			return new DissolveRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveRequest);
		}

		public bool Equals(DissolveRequest other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1579880465) % 9)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					goto IL_B0;
				case 5:
					arg_72_0 = ((this.Reason != other.Reason) ? 1525170306 : 1001986550);
					continue;
				case 6:
					goto IL_41;
				case 7:
					return false;
				case 8:
					arg_72_0 = ((!DissolveRequest.smethod_0(this.AgentId, other.AgentId)) ? 1899239413 : 958508155);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 385524770;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1901128102 : 2054407110);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_1C;
			}
			goto IL_8F;
			uint arg_63_0;
			while (true)
			{
				IL_5E:
				uint num2;
				switch ((num2 = (arg_63_0 ^ 3629984286u)) % 5u)
				{
				case 0u:
					goto IL_8F;
				case 1u:
					num ^= DissolveRequest.smethod_1(this.AgentId);
					arg_63_0 = (num2 * 3822796266u ^ 1906295796u);
					continue;
				case 3u:
					num ^= this.Reason.GetHashCode();
					arg_63_0 = (num2 * 3556028173u ^ 3700437593u);
					continue;
				case 4u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_63_0 = 3916760724u;
			goto IL_5E;
			IL_8F:
			arg_63_0 = ((this.Reason == 0u) ? 2947373103u : 4026166480u);
			goto IL_5E;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_1A;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 3965558708u)) % 6u)
				{
				case 1u:
					output.WriteRawTag(16);
					arg_79_0 = (num * 592720965u ^ 1913270614u);
					continue;
				case 2u:
					goto IL_AC;
				case 3u:
					output.WriteUInt32(this.Reason);
					arg_79_0 = (num * 471020074u ^ 1334289492u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_79_0 = (num * 1443791502u ^ 1422788992u);
					continue;
				case 5u:
					goto IL_1A;
				}
				break;
			}
			return;
			IL_1A:
			arg_79_0 = 3843694592u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.Reason != 0u) ? 3015829841u : 3660815034u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_5A;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 2314346165u)) % 5u)
				{
				case 0u:
					goto IL_5A;
				case 2u:
					goto IL_90;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
					arg_64_0 = (num2 * 2882107459u ^ 583861374u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_64_0 = (num2 * 2568015913u ^ 1875160756u);
					continue;
				}
				break;
			}
			return num;
			IL_5A:
			arg_64_0 = 4103054135u;
			goto IL_5F;
			IL_90:
			arg_64_0 = ((this.Reason == 0u) ? 2653047815u : 2919702566u);
			goto IL_5F;
		}

		public void MergeFrom(DissolveRequest other)
		{
			if (other == null)
			{
				goto IL_B5;
			}
			goto IL_FF;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 919496186u)) % 9u)
				{
				case 0u:
					goto IL_B5;
				case 1u:
					this.agentId_ = new EntityId();
					arg_BF_0 = (num * 1933927507u ^ 1506109935u);
					continue;
				case 2u:
					return;
				case 3u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BF_0 = 939057u;
					continue;
				case 4u:
					arg_BF_0 = (((this.agentId_ != null) ? 863646178u : 162307365u) ^ num * 1728041802u);
					continue;
				case 6u:
					arg_BF_0 = ((other.Reason == 0u) ? 1602789511u : 759616062u);
					continue;
				case 7u:
					goto IL_FF;
				case 8u:
					this.Reason = other.Reason;
					arg_BF_0 = (num * 2409011358u ^ 199060095u);
					continue;
				}
				break;
			}
			return;
			IL_B5:
			arg_BF_0 = 1703943730u;
			goto IL_BA;
			IL_FF:
			arg_BF_0 = ((other.agentId_ != null) ? 778214258u : 939057u);
			goto IL_BA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14D:
				uint num;
				uint arg_101_0 = ((num = input.ReadTag()) == 0u) ? 4021524952u : 4263727226u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_101_0 ^ 3759811609u)) % 12u)
					{
					case 0u:
						this.Reason = input.ReadUInt32();
						arg_101_0 = 2375964417u;
						continue;
					case 1u:
						input.ReadMessage(this.agentId_);
						arg_101_0 = 3837076934u;
						continue;
					case 2u:
						this.agentId_ = new EntityId();
						arg_101_0 = (num2 * 2526133622u ^ 2941761076u);
						continue;
					case 3u:
						arg_101_0 = (num2 * 522638497u ^ 3552949822u);
						continue;
					case 4u:
						goto IL_14D;
					case 5u:
						arg_101_0 = 4263727226u;
						continue;
					case 6u:
						arg_101_0 = (num2 * 934752216u ^ 1208109329u);
						continue;
					case 7u:
						arg_101_0 = ((num != 10u) ? 4253044477u : 2539055363u);
						continue;
					case 8u:
						arg_101_0 = (((num == 16u) ? 1329093537u : 65638770u) ^ num2 * 2139693604u);
						continue;
					case 10u:
						arg_101_0 = ((this.agentId_ == null) ? 4266554007u : 2826427712u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_101_0 = (num2 * 273105466u ^ 1627280993u);
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
