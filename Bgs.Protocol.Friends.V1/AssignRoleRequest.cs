using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class AssignRoleRequest : IMessage<AssignRoleRequest>, IEquatable<AssignRoleRequest>, IDeepCloneable<AssignRoleRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AssignRoleRequest.__c __9 = new AssignRoleRequest.__c();

			internal AssignRoleRequest cctor>b__34_0()
			{
				return new AssignRoleRequest();
			}
		}

		private static readonly MessageParser<AssignRoleRequest> _parser = new MessageParser<AssignRoleRequest>(new Func<AssignRoleRequest>(AssignRoleRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int RoleFieldNumber = 3;

		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(26u);

		private readonly RepeatedField<int> role_ = new RepeatedField<int>();

		public static MessageParser<AssignRoleRequest> Parser
		{
			get
			{
				return AssignRoleRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssignRoleRequest.Descriptor;
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

		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		public AssignRoleRequest()
		{
		}

		public AssignRoleRequest(AssignRoleRequest other) : this()
		{
			while (true)
			{
				IL_7C:
				int arg_62_0 = -38583686;
				while (true)
				{
					switch ((arg_62_0 ^ -1389250321) % 4)
					{
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_62_0 = -1538920843;
						continue;
					case 2:
						this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
						this.role_ = other.role_.Clone();
						arg_62_0 = -347571025;
						continue;
					case 3:
						goto IL_7C;
					}
					return;
				}
			}
		}

		public AssignRoleRequest Clone()
		{
			return new AssignRoleRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AssignRoleRequest);
		}

		public bool Equals(AssignRoleRequest other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -1754112119) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 3:
					goto IL_EC;
				case 4:
					arg_A6_0 = ((!AssignRoleRequest.smethod_0(this.TargetId, other.TargetId)) ? -924450524 : -1176821777);
					continue;
				case 5:
					return false;
				case 6:
					arg_A6_0 = ((!AssignRoleRequest.smethod_0(this.AgentId, other.AgentId)) ? -1214100625 : -1950712585);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_44;
				case 9:
					return true;
				case 10:
					arg_A6_0 = (this.role_.Equals(other.role_) ? -66700678 : -1828099843);
					continue;
				}
				break;
			}
			return true;
			IL_44:
			arg_A6_0 = -623905768;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? -399511263 : -1920077070);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_46;
			}
			goto IL_70;
			uint arg_50_0;
			while (true)
			{
				IL_4B:
				uint num2;
				switch ((num2 = (arg_50_0 ^ 4193908999u)) % 5u)
				{
				case 0u:
					goto IL_46;
				case 1u:
					goto IL_70;
				case 2u:
					num ^= AssignRoleRequest.smethod_1(this.AgentId);
					arg_50_0 = (num2 * 3405343784u ^ 3607705824u);
					continue;
				case 3u:
					num ^= AssignRoleRequest.smethod_1(this.role_);
					arg_50_0 = (num2 * 1730011359u ^ 2940278307u);
					continue;
				}
				break;
			}
			return num;
			IL_46:
			arg_50_0 = 2503758317u;
			goto IL_4B;
			IL_70:
			num ^= AssignRoleRequest.smethod_1(this.TargetId);
			arg_50_0 = 2171463855u;
			goto IL_4B;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_50;
			}
			goto IL_99;
			uint arg_75_0;
			while (true)
			{
				IL_70:
				uint num;
				switch ((num = (arg_75_0 ^ 860974840u)) % 6u)
				{
				case 0u:
					output.WriteMessage(this.TargetId);
					arg_75_0 = (num * 4246566853u ^ 2124308887u);
					continue;
				case 2u:
					goto IL_50;
				case 3u:
					this.role_.WriteTo(output, AssignRoleRequest._repeated_role_codec);
					arg_75_0 = (num * 560525455u ^ 1578277980u);
					continue;
				case 4u:
					goto IL_99;
				case 5u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_75_0 = (num * 4215318086u ^ 523508928u);
					continue;
				}
				break;
			}
			return;
			IL_50:
			arg_75_0 = 623123925u;
			goto IL_70;
			IL_99:
			output.WriteRawTag(18);
			arg_75_0 = 2140448646u;
			goto IL_70;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_2E;
			}
			goto IL_77;
			uint arg_57_0;
			while (true)
			{
				IL_52:
				uint num2;
				switch ((num2 = (arg_57_0 ^ 1709030642u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_57_0 = (num2 * 2381877094u ^ 1133649803u);
					continue;
				case 2u:
					goto IL_77;
				case 3u:
					goto IL_2E;
				case 4u:
					num += this.role_.CalculateSize(AssignRoleRequest._repeated_role_codec);
					arg_57_0 = (num2 * 612445524u ^ 1550390990u);
					continue;
				}
				break;
			}
			return num;
			IL_2E:
			arg_57_0 = 2123009825u;
			goto IL_52;
			IL_77:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			arg_57_0 = 1895622001u;
			goto IL_52;
		}

		public void MergeFrom(AssignRoleRequest other)
		{
			if (other == null)
			{
				goto IL_E1;
			}
			goto IL_169;
			uint arg_11D_0;
			while (true)
			{
				IL_118:
				uint num;
				switch ((num = (arg_11D_0 ^ 1406225327u)) % 12u)
				{
				case 0u:
					this.agentId_ = new EntityId();
					arg_11D_0 = (num * 1465556970u ^ 2957033886u);
					continue;
				case 1u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_11D_0 = 533626530u;
					continue;
				case 2u:
					return;
				case 4u:
					goto IL_E1;
				case 5u:
					arg_11D_0 = ((other.targetId_ != null) ? 399205180u : 1511187153u);
					continue;
				case 6u:
					this.targetId_ = new EntityId();
					arg_11D_0 = (num * 3000422935u ^ 3324428933u);
					continue;
				case 7u:
					goto IL_169;
				case 8u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_11D_0 = 1511187153u;
					continue;
				case 9u:
					arg_11D_0 = (((this.agentId_ != null) ? 2730019673u : 2211265288u) ^ num * 4211950431u);
					continue;
				case 10u:
					this.role_.Add(other.role_);
					arg_11D_0 = 57319704u;
					continue;
				case 11u:
					arg_11D_0 = (((this.targetId_ == null) ? 2018765665u : 403373479u) ^ num * 1658161932u);
					continue;
				}
				break;
			}
			return;
			IL_E1:
			arg_11D_0 = 1138459305u;
			goto IL_118;
			IL_169:
			arg_11D_0 = ((other.agentId_ != null) ? 735968630u : 533626530u);
			goto IL_118;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_242:
				uint num;
				uint arg_1DA_0 = ((num = input.ReadTag()) == 0u) ? 3187898155u : 3254713875u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1DA_0 ^ 3269582126u)) % 19u)
					{
					case 0u:
						arg_1DA_0 = (num2 * 3163753099u ^ 419506992u);
						continue;
					case 1u:
						arg_1DA_0 = ((num <= 18u) ? 4125114369u : 3134761968u);
						continue;
					case 2u:
						this.targetId_ = new EntityId();
						arg_1DA_0 = (num2 * 4185401340u ^ 2224966766u);
						continue;
					case 3u:
						input.ReadMessage(this.targetId_);
						arg_1DA_0 = 3727607042u;
						continue;
					case 4u:
						arg_1DA_0 = (num2 * 2497721420u ^ 2485832161u);
						continue;
					case 5u:
						arg_1DA_0 = 3254713875u;
						continue;
					case 6u:
						this.agentId_ = new EntityId();
						arg_1DA_0 = (num2 * 2168209061u ^ 2574309932u);
						continue;
					case 7u:
						arg_1DA_0 = (((num == 10u) ? 2223198646u : 2630330299u) ^ num2 * 1541929934u);
						continue;
					case 8u:
						arg_1DA_0 = (((num != 26u) ? 353330001u : 60302847u) ^ num2 * 3113755608u);
						continue;
					case 9u:
						goto IL_242;
					case 10u:
						this.role_.AddEntriesFrom(input, AssignRoleRequest._repeated_role_codec);
						arg_1DA_0 = 3727607042u;
						continue;
					case 11u:
						arg_1DA_0 = ((this.targetId_ != null) ? 2469245962u : 3654671049u);
						continue;
					case 12u:
						input.SkipLastField();
						arg_1DA_0 = 2652424184u;
						continue;
					case 13u:
						arg_1DA_0 = (num2 * 684524304u ^ 1994000594u);
						continue;
					case 14u:
						arg_1DA_0 = ((this.agentId_ != null) ? 4090467736u : 2336279434u);
						continue;
					case 15u:
						arg_1DA_0 = ((num == 24u) ? 3880180559u : 3065127820u);
						continue;
					case 16u:
						input.ReadMessage(this.agentId_);
						arg_1DA_0 = 2573399363u;
						continue;
					case 17u:
						arg_1DA_0 = (((num == 18u) ? 3452386802u : 4006608366u) ^ num2 * 3687451200u);
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
