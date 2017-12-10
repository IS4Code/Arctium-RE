using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UnsubscribeRequest.__c __9 = new UnsubscribeRequest.__c();

			internal UnsubscribeRequest cctor>b__34_0()
			{
				return new UnsubscribeRequest();
			}
		}

		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(new Func<UnsubscribeRequest>(UnsubscribeRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int EntityIdFieldNumber = 2;

		private EntityId entityId_;

		public const int ObjectIdFieldNumber = 3;

		private ulong objectId_;

		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
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

		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		public ulong ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		public UnsubscribeRequest()
		{
		}

		public UnsubscribeRequest(UnsubscribeRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
			this.objectId_ = other.objectId_;
		}

		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		public bool Equals(UnsubscribeRequest other)
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
				switch ((arg_A4_0 ^ -297057741) % 11)
				{
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					goto IL_EA;
				case 4:
					goto IL_9A;
				case 5:
					return false;
				case 6:
					arg_A4_0 = (UnsubscribeRequest.smethod_0(this.EntityId, other.EntityId) ? -487100874 : -1789862922);
					continue;
				case 7:
					return false;
				case 8:
					arg_A4_0 = ((this.ObjectId == other.ObjectId) ? -1514592352 : -1494697440);
					continue;
				case 9:
					arg_A4_0 = (UnsubscribeRequest.smethod_0(this.AgentId, other.AgentId) ? -759167526 : -1047879876);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = -1665299537;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other != this) ? -576449685 : -385584058);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_75;
			}
			goto IL_A3;
			uint arg_7F_0;
			while (true)
			{
				IL_7A:
				uint num2;
				switch ((num2 = (arg_7F_0 ^ 2976876417u)) % 6u)
				{
				case 0u:
					goto IL_75;
				case 2u:
					arg_7F_0 = (((this.ObjectId == 0uL) ? 2572990090u : 2750617208u) ^ num2 * 1178705154u);
					continue;
				case 3u:
					num ^= UnsubscribeRequest.smethod_1(this.AgentId);
					arg_7F_0 = (num2 * 3658001210u ^ 3381246495u);
					continue;
				case 4u:
					goto IL_A3;
				case 5u:
					num ^= this.ObjectId.GetHashCode();
					arg_7F_0 = (num2 * 1223653792u ^ 4248109930u);
					continue;
				}
				break;
			}
			return num;
			IL_75:
			arg_7F_0 = 2728367280u;
			goto IL_7A;
			IL_A3:
			num ^= UnsubscribeRequest.smethod_1(this.EntityId);
			arg_7F_0 = 3571785505u;
			goto IL_7A;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_30;
			}
			goto IL_BD;
			uint arg_95_0;
			while (true)
			{
				IL_90:
				uint num;
				switch ((num = (arg_95_0 ^ 1482561503u)) % 7u)
				{
				case 1u:
					arg_95_0 = (((this.ObjectId == 0uL) ? 403078570u : 1773658099u) ^ num * 1524540018u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_95_0 = (num * 958240040u ^ 1563050001u);
					continue;
				case 3u:
					goto IL_BD;
				case 4u:
					output.WriteMessage(this.AgentId);
					arg_95_0 = (num * 1955104700u ^ 81817494u);
					continue;
				case 5u:
					goto IL_30;
				case 6u:
					output.WriteRawTag(24);
					output.WriteUInt64(this.ObjectId);
					arg_95_0 = (num * 957455784u ^ 2880611894u);
					continue;
				}
				break;
			}
			return;
			IL_30:
			arg_95_0 = 2068963741u;
			goto IL_90;
			IL_BD:
			output.WriteRawTag(18);
			output.WriteMessage(this.EntityId);
			arg_95_0 = 1708013473u;
			goto IL_90;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_76;
			}
			goto IL_A4;
			uint arg_80_0;
			while (true)
			{
				IL_7B:
				uint num2;
				switch ((num2 = (arg_80_0 ^ 3255451378u)) % 6u)
				{
				case 0u:
					goto IL_76;
				case 1u:
					goto IL_A4;
				case 2u:
					arg_80_0 = (((this.ObjectId != 0uL) ? 756752044u : 1939989423u) ^ num2 * 4075344888u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
					arg_80_0 = (num2 * 655693283u ^ 2436674101u);
					continue;
				case 5u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_80_0 = (num2 * 3572975165u ^ 3200171510u);
					continue;
				}
				break;
			}
			return num;
			IL_76:
			arg_80_0 = 2537679229u;
			goto IL_7B;
			IL_A4:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			arg_80_0 = 3581548974u;
			goto IL_7B;
		}

		public void MergeFrom(UnsubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_68;
			}
			goto IL_194;
			uint arg_144_0;
			while (true)
			{
				IL_13F:
				uint num;
				switch ((num = (arg_144_0 ^ 2890068574u)) % 13u)
				{
				case 0u:
					goto IL_194;
				case 1u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_144_0 = 3748473497u;
					continue;
				case 2u:
					this.entityId_ = new EntityId();
					arg_144_0 = (num * 4048034410u ^ 3246903411u);
					continue;
				case 3u:
					this.agentId_ = new EntityId();
					arg_144_0 = (num * 3490675414u ^ 2343557021u);
					continue;
				case 4u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_144_0 = 3527683179u;
					continue;
				case 5u:
					arg_144_0 = (((this.agentId_ == null) ? 1685407384u : 1682110737u) ^ num * 2863813958u);
					continue;
				case 6u:
					this.ObjectId = other.ObjectId;
					arg_144_0 = (num * 3690316712u ^ 2875805661u);
					continue;
				case 7u:
					arg_144_0 = ((other.ObjectId != 0uL) ? 3046405916u : 4045141645u);
					continue;
				case 8u:
					goto IL_68;
				case 10u:
					return;
				case 11u:
					arg_144_0 = ((other.entityId_ != null) ? 3138606722u : 3748473497u);
					continue;
				case 12u:
					arg_144_0 = (((this.entityId_ != null) ? 4258360795u : 2680948216u) ^ num * 142237381u);
					continue;
				}
				break;
			}
			return;
			IL_68:
			arg_144_0 = 3193628816u;
			goto IL_13F;
			IL_194:
			arg_144_0 = ((other.agentId_ != null) ? 3835658842u : 3527683179u);
			goto IL_13F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1F6:
				uint num;
				uint arg_196_0 = ((num = input.ReadTag()) != 0u) ? 918844442u : 310153809u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_196_0 ^ 441713470u)) % 17u)
					{
					case 0u:
						goto IL_1F6;
					case 1u:
						this.ObjectId = input.ReadUInt64();
						arg_196_0 = 902375583u;
						continue;
					case 2u:
						input.ReadMessage(this.entityId_);
						arg_196_0 = 1028971051u;
						continue;
					case 3u:
						arg_196_0 = ((num == 10u) ? 1518337455u : 1741172028u);
						continue;
					case 4u:
						arg_196_0 = (((num == 24u) ? 1570321692u : 178521966u) ^ num2 * 3894695520u);
						continue;
					case 5u:
						arg_196_0 = (num2 * 3182350335u ^ 2741968500u);
						continue;
					case 6u:
						arg_196_0 = (((num != 18u) ? 1628571238u : 2089963446u) ^ num2 * 1868477333u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_196_0 = (num2 * 3438963096u ^ 909923539u);
						continue;
					case 8u:
						this.agentId_ = new EntityId();
						arg_196_0 = (num2 * 3490677710u ^ 522488564u);
						continue;
					case 9u:
						arg_196_0 = ((this.entityId_ == null) ? 1187142288u : 597136043u);
						continue;
					case 10u:
						input.ReadMessage(this.agentId_);
						arg_196_0 = 634351413u;
						continue;
					case 11u:
						arg_196_0 = 918844442u;
						continue;
					case 12u:
						this.entityId_ = new EntityId();
						arg_196_0 = (num2 * 3982581629u ^ 839436637u);
						continue;
					case 13u:
						arg_196_0 = ((this.agentId_ == null) ? 375546306u : 705302588u);
						continue;
					case 14u:
						arg_196_0 = (num2 * 4131857568u ^ 279657087u);
						continue;
					case 16u:
						arg_196_0 = (num2 * 3220105192u ^ 2552472919u);
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
