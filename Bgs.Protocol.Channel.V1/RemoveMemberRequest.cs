using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class RemoveMemberRequest : IMessage<RemoveMemberRequest>, IEquatable<RemoveMemberRequest>, IDeepCloneable<RemoveMemberRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RemoveMemberRequest.__c __9 = new RemoveMemberRequest.__c();

			internal RemoveMemberRequest cctor>b__34_0()
			{
				return new RemoveMemberRequest();
			}
		}

		private static readonly MessageParser<RemoveMemberRequest> _parser = new MessageParser<RemoveMemberRequest>(new Func<RemoveMemberRequest>(RemoveMemberRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int MemberIdFieldNumber = 2;

		private EntityId memberId_;

		public const int ReasonFieldNumber = 3;

		private uint reason_;

		public static MessageParser<RemoveMemberRequest> Parser
		{
			get
			{
				return RemoveMemberRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveMemberRequest.Descriptor;
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

		public RemoveMemberRequest()
		{
		}

		public RemoveMemberRequest(RemoveMemberRequest other) : this()
		{
			while (true)
			{
				IL_77:
				int arg_5D_0 = -775358406;
				while (true)
				{
					switch ((arg_5D_0 ^ -1128387905) % 4)
					{
					case 0:
						this.MemberId = ((other.memberId_ != null) ? other.MemberId.Clone() : null);
						this.reason_ = other.reason_;
						arg_5D_0 = -1133166151;
						continue;
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_5D_0 = -1253212473;
						continue;
					case 3:
						goto IL_77;
					}
					return;
				}
			}
		}

		public RemoveMemberRequest Clone()
		{
			return new RemoveMemberRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveMemberRequest);
		}

		public bool Equals(RemoveMemberRequest other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ -113129912) % 11)
				{
				case 0:
					goto IL_9A;
				case 1:
					arg_A4_0 = (RemoveMemberRequest.smethod_0(this.MemberId, other.MemberId) ? -1447737326 : -1635386962);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_EA;
				case 5:
					arg_A4_0 = (RemoveMemberRequest.smethod_0(this.AgentId, other.AgentId) ? -369719527 : -1254492741);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					return true;
				case 10:
					arg_A4_0 = ((this.Reason == other.Reason) ? -761499454 : -306112842);
					continue;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = -488406932;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other == this) ? -1739421207 : -770257573);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_39;
			}
			goto IL_8F;
			uint arg_63_0;
			while (true)
			{
				IL_5E:
				uint num2;
				switch ((num2 = (arg_63_0 ^ 2854120568u)) % 5u)
				{
				case 0u:
					goto IL_8F;
				case 1u:
					num ^= this.Reason.GetHashCode();
					arg_63_0 = (num2 * 1376517231u ^ 2573064409u);
					continue;
				case 2u:
					goto IL_39;
				case 4u:
					num ^= RemoveMemberRequest.smethod_1(this.AgentId);
					arg_63_0 = (num2 * 2828979892u ^ 1257322049u);
					continue;
				}
				break;
			}
			return num;
			IL_39:
			arg_63_0 = 2870722080u;
			goto IL_5E;
			IL_8F:
			num ^= RemoveMemberRequest.smethod_1(this.MemberId);
			arg_63_0 = ((this.Reason != 0u) ? 3245698775u : 2362619192u);
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
				goto IL_9D;
			}
			goto IL_D3;
			uint arg_A7_0;
			while (true)
			{
				IL_A2:
				uint num;
				switch ((num = (arg_A7_0 ^ 3063819976u)) % 8u)
				{
				case 0u:
					goto IL_9D;
				case 1u:
					output.WriteUInt32(this.Reason);
					arg_A7_0 = (num * 172167645u ^ 4086699694u);
					continue;
				case 2u:
					output.WriteRawTag(24);
					arg_A7_0 = (num * 4055225164u ^ 2773748745u);
					continue;
				case 4u:
					output.WriteMessage(this.AgentId);
					arg_A7_0 = (num * 1918590036u ^ 1955767750u);
					continue;
				case 5u:
					output.WriteRawTag(10);
					arg_A7_0 = (num * 285140908u ^ 1114540736u);
					continue;
				case 6u:
					goto IL_D3;
				case 7u:
					arg_A7_0 = (((this.Reason == 0u) ? 1584505460u : 2139588253u) ^ num * 3561627953u);
					continue;
				}
				break;
			}
			return;
			IL_9D:
			arg_A7_0 = 4055245069u;
			goto IL_A2;
			IL_D3:
			output.WriteRawTag(18);
			output.WriteMessage(this.MemberId);
			arg_A7_0 = 3513833623u;
			goto IL_A2;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_0D;
			}
			goto IL_A2;
			uint arg_7E_0;
			while (true)
			{
				IL_79:
				uint num2;
				switch ((num2 = (arg_7E_0 ^ 2719086463u)) % 6u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
					arg_7E_0 = (num2 * 1752654629u ^ 1639826336u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_7E_0 = (num2 * 843092511u ^ 3055538294u);
					continue;
				case 2u:
					goto IL_A2;
				case 4u:
					arg_7E_0 = (((this.Reason == 0u) ? 3156784130u : 2504380037u) ^ num2 * 285206758u);
					continue;
				case 5u:
					goto IL_0D;
				}
				break;
			}
			return num;
			IL_0D:
			arg_7E_0 = 3180048742u;
			goto IL_79;
			IL_A2:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			arg_7E_0 = 2923074271u;
			goto IL_79;
		}

		public void MergeFrom(RemoveMemberRequest other)
		{
			if (other == null)
			{
				goto IL_50;
			}
			goto IL_194;
			uint arg_144_0;
			while (true)
			{
				IL_13F:
				uint num;
				switch ((num = (arg_144_0 ^ 4213797422u)) % 13u)
				{
				case 0u:
					goto IL_194;
				case 1u:
					arg_144_0 = (((this.memberId_ == null) ? 2346733417u : 3110664986u) ^ num * 1460421713u);
					continue;
				case 2u:
					arg_144_0 = ((other.Reason == 0u) ? 2813796315u : 3825197754u);
					continue;
				case 3u:
					this.agentId_ = new EntityId();
					arg_144_0 = (num * 1090942264u ^ 1057377217u);
					continue;
				case 4u:
					this.Reason = other.Reason;
					arg_144_0 = (num * 1586344112u ^ 937048603u);
					continue;
				case 5u:
					arg_144_0 = ((other.memberId_ != null) ? 4253489080u : 3182075870u);
					continue;
				case 6u:
					this.MemberId.MergeFrom(other.MemberId);
					arg_144_0 = 3182075870u;
					continue;
				case 7u:
					return;
				case 8u:
					arg_144_0 = (((this.agentId_ == null) ? 2985472287u : 2221974812u) ^ num * 4014064727u);
					continue;
				case 9u:
					goto IL_50;
				case 10u:
					this.memberId_ = new EntityId();
					arg_144_0 = (num * 2628479695u ^ 2005174259u);
					continue;
				case 12u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_144_0 = 3574650703u;
					continue;
				}
				break;
			}
			return;
			IL_50:
			arg_144_0 = 2819978919u;
			goto IL_13F;
			IL_194:
			arg_144_0 = ((other.agentId_ == null) ? 3574650703u : 3360100709u);
			goto IL_13F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1E0:
				uint num;
				uint arg_184_0 = ((num = input.ReadTag()) == 0u) ? 3730349553u : 3898346080u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_184_0 ^ 3180849407u)) % 16u)
					{
					case 0u:
						input.ReadMessage(this.memberId_);
						arg_184_0 = 4002857474u;
						continue;
					case 1u:
						arg_184_0 = (((num != 24u) ? 37202877u : 134123920u) ^ num2 * 2860089739u);
						continue;
					case 2u:
						input.ReadMessage(this.agentId_);
						arg_184_0 = 4099097045u;
						continue;
					case 3u:
						arg_184_0 = ((this.agentId_ == null) ? 2321990921u : 2653730893u);
						continue;
					case 4u:
						this.Reason = input.ReadUInt32();
						arg_184_0 = 4099097045u;
						continue;
					case 5u:
						arg_184_0 = (((num != 18u) ? 560339527u : 1988380266u) ^ num2 * 2625444949u);
						continue;
					case 6u:
						this.agentId_ = new EntityId();
						arg_184_0 = (num2 * 3898371771u ^ 1836646143u);
						continue;
					case 7u:
						this.memberId_ = new EntityId();
						arg_184_0 = (num2 * 639540716u ^ 1620239163u);
						continue;
					case 8u:
						arg_184_0 = (num2 * 181902592u ^ 4226431445u);
						continue;
					case 9u:
						input.SkipLastField();
						arg_184_0 = (num2 * 1172646784u ^ 1357940391u);
						continue;
					case 10u:
						goto IL_1E0;
					case 11u:
						arg_184_0 = 3898346080u;
						continue;
					case 12u:
						arg_184_0 = ((this.memberId_ == null) ? 2904916456u : 3910082319u);
						continue;
					case 13u:
						arg_184_0 = (num2 * 7571392u ^ 3663849749u);
						continue;
					case 15u:
						arg_184_0 = ((num != 10u) ? 3385003802u : 3856190748u);
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
