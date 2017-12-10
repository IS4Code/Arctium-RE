using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class UnsubscribeMemberRequest : IMessage<UnsubscribeMemberRequest>, IEquatable<UnsubscribeMemberRequest>, IDeepCloneable<UnsubscribeMemberRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UnsubscribeMemberRequest.__c __9 = new UnsubscribeMemberRequest.__c();

			internal UnsubscribeMemberRequest cctor>b__29_0()
			{
				return new UnsubscribeMemberRequest();
			}
		}

		private static readonly MessageParser<UnsubscribeMemberRequest> _parser = new MessageParser<UnsubscribeMemberRequest>(new Func<UnsubscribeMemberRequest>(UnsubscribeMemberRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int MemberIdFieldNumber = 2;

		private EntityId memberId_;

		public static MessageParser<UnsubscribeMemberRequest> Parser
		{
			get
			{
				return UnsubscribeMemberRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeMemberRequest.Descriptor;
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

		public UnsubscribeMemberRequest()
		{
		}

		public UnsubscribeMemberRequest(UnsubscribeMemberRequest other) : this()
		{
			while (true)
			{
				IL_60:
				int arg_4A_0 = 927234250;
				while (true)
				{
					switch ((arg_4A_0 ^ 1296988755) % 3)
					{
					case 0:
						goto IL_60;
					case 2:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.MemberId = ((other.memberId_ != null) ? other.MemberId.Clone() : null);
						arg_4A_0 = 1183172801;
						continue;
					}
					return;
				}
			}
		}

		public UnsubscribeMemberRequest Clone()
		{
			return new UnsubscribeMemberRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeMemberRequest);
		}

		public bool Equals(UnsubscribeMemberRequest other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -167940682) % 9)
				{
				case 0:
					goto IL_B5;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_77_0 = (UnsubscribeMemberRequest.smethod_0(this.MemberId, other.MemberId) ? -1143885313 : -1557719991);
					continue;
				case 4:
					return true;
				case 5:
					goto IL_41;
				case 6:
					return false;
				case 8:
					arg_77_0 = (UnsubscribeMemberRequest.smethod_0(this.AgentId, other.AgentId) ? -1712009215 : -478247914);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_77_0 = -1854773971;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -1910488493 : -1040158353);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_0A;
			}
			goto IL_4D;
			uint arg_31_0;
			while (true)
			{
				IL_2C:
				uint num2;
				switch ((num2 = (arg_31_0 ^ 2008617987u)) % 4u)
				{
				case 1u:
					num ^= UnsubscribeMemberRequest.smethod_1(this.AgentId);
					arg_31_0 = (num2 * 3801673916u ^ 1021183549u);
					continue;
				case 2u:
					goto IL_4D;
				case 3u:
					goto IL_0A;
				}
				break;
			}
			return num;
			IL_0A:
			arg_31_0 = 459383774u;
			goto IL_2C;
			IL_4D:
			num ^= UnsubscribeMemberRequest.smethod_1(this.MemberId);
			arg_31_0 = 1520428503u;
			goto IL_2C;
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
			goto IL_70;
			uint arg_50_0;
			while (true)
			{
				IL_4B:
				uint num;
				switch ((num = (arg_50_0 ^ 2730290041u)) % 5u)
				{
				case 1u:
					goto IL_70;
				case 2u:
					output.WriteMessage(this.MemberId);
					arg_50_0 = (num * 1364834161u ^ 448406429u);
					continue;
				case 3u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_50_0 = (num * 1402643247u ^ 3570306290u);
					continue;
				case 4u:
					goto IL_08;
				}
				break;
			}
			return;
			IL_08:
			arg_50_0 = 2779991768u;
			goto IL_4B;
			IL_70:
			output.WriteRawTag(18);
			arg_50_0 = 2510420361u;
			goto IL_4B;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 4155351295u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 3627325577u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 2u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
							arg_2E_0 = (num2 * 178729500u ^ 683332688u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num + (1 + CodedOutputStream.ComputeMessageSize(this.MemberId));
		}

		public void MergeFrom(UnsubscribeMemberRequest other)
		{
			if (other == null)
			{
				goto IL_C6;
			}
			goto IL_14A;
			uint arg_102_0;
			while (true)
			{
				IL_FD:
				uint num;
				switch ((num = (arg_102_0 ^ 736849994u)) % 11u)
				{
				case 0u:
					this.MemberId.MergeFrom(other.MemberId);
					arg_102_0 = 1494610465u;
					continue;
				case 1u:
					this.agentId_ = new EntityId();
					arg_102_0 = (num * 322099242u ^ 2406101210u);
					continue;
				case 2u:
					return;
				case 3u:
					goto IL_C6;
				case 4u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_102_0 = 1789680115u;
					continue;
				case 5u:
					arg_102_0 = (((this.memberId_ == null) ? 2815840589u : 3423585763u) ^ num * 1677484102u);
					continue;
				case 6u:
					goto IL_14A;
				case 7u:
					arg_102_0 = ((other.memberId_ != null) ? 1764684826u : 1494610465u);
					continue;
				case 8u:
					this.memberId_ = new EntityId();
					arg_102_0 = (num * 2648341358u ^ 3331022913u);
					continue;
				case 10u:
					arg_102_0 = (((this.agentId_ == null) ? 2092300854u : 2124800224u) ^ num * 2149964762u);
					continue;
				}
				break;
			}
			return;
			IL_C6:
			arg_102_0 = 1420114060u;
			goto IL_FD;
			IL_14A:
			arg_102_0 = ((other.agentId_ == null) ? 1789680115u : 1823781193u);
			goto IL_FD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_19C:
				uint num;
				uint arg_148_0 = ((num = input.ReadTag()) != 0u) ? 4032039184u : 3257110963u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_148_0 ^ 3556166456u)) % 14u)
					{
					case 0u:
						goto IL_19C;
					case 1u:
						this.memberId_ = new EntityId();
						arg_148_0 = (num2 * 3816633015u ^ 1976673646u);
						continue;
					case 2u:
						input.ReadMessage(this.agentId_);
						arg_148_0 = 2839644897u;
						continue;
					case 3u:
						this.agentId_ = new EntityId();
						arg_148_0 = (num2 * 2112691217u ^ 2987813055u);
						continue;
					case 4u:
						arg_148_0 = ((this.memberId_ == null) ? 4170964641u : 4197906225u);
						continue;
					case 5u:
						arg_148_0 = ((this.agentId_ != null) ? 2802879180u : 3619103099u);
						continue;
					case 6u:
						arg_148_0 = ((num != 10u) ? 2264490788u : 3622954537u);
						continue;
					case 7u:
						arg_148_0 = (num2 * 3073349746u ^ 503761842u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_148_0 = (num2 * 2788732171u ^ 4115953975u);
						continue;
					case 9u:
						input.ReadMessage(this.memberId_);
						arg_148_0 = 4089805472u;
						continue;
					case 10u:
						arg_148_0 = (((num == 18u) ? 399208752u : 1796363182u) ^ num2 * 4205383733u);
						continue;
					case 12u:
						arg_148_0 = 4032039184u;
						continue;
					case 13u:
						arg_148_0 = (num2 * 3165721795u ^ 1577084651u);
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
