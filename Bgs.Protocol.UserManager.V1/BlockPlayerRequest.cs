using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class BlockPlayerRequest : IMessage<BlockPlayerRequest>, IEquatable<BlockPlayerRequest>, IDeepCloneable<BlockPlayerRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BlockPlayerRequest.__c __9 = new BlockPlayerRequest.__c();

			internal BlockPlayerRequest cctor>b__34_0()
			{
				return new BlockPlayerRequest();
			}
		}

		private static readonly MessageParser<BlockPlayerRequest> _parser = new MessageParser<BlockPlayerRequest>(new Func<BlockPlayerRequest>(BlockPlayerRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int RoleFieldNumber = 3;

		private uint role_;

		public static MessageParser<BlockPlayerRequest> Parser
		{
			get
			{
				return BlockPlayerRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerRequest.Descriptor;
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

		public uint Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		public BlockPlayerRequest()
		{
		}

		public BlockPlayerRequest(BlockPlayerRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
			this.role_ = other.role_;
		}

		public BlockPlayerRequest Clone()
		{
			return new BlockPlayerRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerRequest);
		}

		public bool Equals(BlockPlayerRequest other)
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
				switch ((arg_A4_0 ^ 1753505809) % 11)
				{
				case 0:
					goto IL_9A;
				case 1:
					return false;
				case 3:
					goto IL_EA;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_A4_0 = ((!BlockPlayerRequest.smethod_0(this.TargetId, other.TargetId)) ? 636131386 : 174501307);
					continue;
				case 8:
					arg_A4_0 = ((!BlockPlayerRequest.smethod_0(this.AgentId, other.AgentId)) ? 850816351 : 1094753121);
					continue;
				case 9:
					arg_A4_0 = ((this.Role != other.Role) ? 1342000158 : 1383478453);
					continue;
				case 10:
					return true;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = 1343805689;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other == this) ? 887754127 : 2035226501);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_C3:
				uint arg_9F_0 = 4094351029u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9F_0 ^ 2345737771u)) % 6u)
					{
					case 0u:
						goto IL_C3;
					case 1u:
						num ^= BlockPlayerRequest.smethod_1(this.AgentId);
						arg_9F_0 = (num2 * 3190853153u ^ 3389760901u);
						continue;
					case 2u:
						arg_9F_0 = (((this.agentId_ != null) ? 3889054368u : 3821063790u) ^ num2 * 342501023u);
						continue;
					case 4u:
						num ^= this.Role.GetHashCode();
						arg_9F_0 = (num2 * 55733820u ^ 2422720590u);
						continue;
					case 5u:
						num ^= BlockPlayerRequest.smethod_1(this.TargetId);
						arg_9F_0 = ((this.Role != 0u) ? 2789697781u : 2467596358u);
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
				goto IL_1A;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 2951151578u)) % 7u)
				{
				case 0u:
					output.WriteRawTag(24);
					arg_88_0 = (num * 2370403513u ^ 1744669602u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_88_0 = (num * 547637763u ^ 3526781927u);
					continue;
				case 2u:
					output.WriteMessage(this.AgentId);
					arg_88_0 = (num * 3405917161u ^ 2562478544u);
					continue;
				case 3u:
					goto IL_BF;
				case 4u:
					output.WriteUInt32(this.Role);
					arg_88_0 = (num * 678869454u ^ 287951380u);
					continue;
				case 5u:
					goto IL_1A;
				}
				break;
			}
			return;
			IL_1A:
			arg_88_0 = 2202569035u;
			goto IL_83;
			IL_BF:
			output.WriteRawTag(18);
			output.WriteMessage(this.TargetId);
			arg_88_0 = ((this.Role == 0u) ? 3369837810u : 4175645967u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_3B;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 3198271240u)) % 5u)
				{
				case 0u:
					goto IL_90;
				case 1u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Role);
					arg_64_0 = (num2 * 957960704u ^ 619359941u);
					continue;
				case 2u:
					goto IL_3B;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_64_0 = (num2 * 3541752243u ^ 630721529u);
					continue;
				}
				break;
			}
			return num;
			IL_3B:
			arg_64_0 = 2231367339u;
			goto IL_5F;
			IL_90:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			arg_64_0 = ((this.Role == 0u) ? 2728806085u : 2703546460u);
			goto IL_5F;
		}

		public void MergeFrom(BlockPlayerRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_194;
			uint arg_144_0;
			while (true)
			{
				IL_13F:
				uint num;
				switch ((num = (arg_144_0 ^ 63297788u)) % 13u)
				{
				case 0u:
					goto IL_194;
				case 1u:
					this.targetId_ = new EntityId();
					arg_144_0 = (num * 106352405u ^ 238230404u);
					continue;
				case 2u:
					this.Role = other.Role;
					arg_144_0 = (num * 156142235u ^ 607593007u);
					continue;
				case 3u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_144_0 = 1165542181u;
					continue;
				case 5u:
					arg_144_0 = ((other.Role != 0u) ? 213234559u : 1809355902u);
					continue;
				case 6u:
					arg_144_0 = (((this.targetId_ == null) ? 4168382957u : 4047503905u) ^ num * 3927165783u);
					continue;
				case 7u:
					arg_144_0 = ((other.targetId_ != null) ? 1505818934u : 1165542181u);
					continue;
				case 8u:
					arg_144_0 = (((this.agentId_ != null) ? 1203856628u : 778278600u) ^ num * 1146978903u);
					continue;
				case 9u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_144_0 = 2002319659u;
					continue;
				case 10u:
					return;
				case 11u:
					this.agentId_ = new EntityId();
					arg_144_0 = (num * 1577662211u ^ 228338114u);
					continue;
				case 12u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_144_0 = 1186313025u;
			goto IL_13F;
			IL_194:
			arg_144_0 = ((other.agentId_ == null) ? 2002319659u : 2035635631u);
			goto IL_13F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1D0:
				uint num;
				uint arg_178_0 = ((num = input.ReadTag()) != 0u) ? 4101443890u : 4046772019u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_178_0 ^ 2259886453u)) % 15u)
					{
					case 1u:
						arg_178_0 = (((num == 24u) ? 2442498287u : 3806788788u) ^ num2 * 1797531592u);
						continue;
					case 2u:
						this.agentId_ = new EntityId();
						arg_178_0 = (num2 * 2831909177u ^ 4184217701u);
						continue;
					case 3u:
						arg_178_0 = ((this.targetId_ != null) ? 3005186690u : 2520838329u);
						continue;
					case 4u:
						arg_178_0 = (((num == 18u) ? 775325560u : 855551950u) ^ num2 * 2672481410u);
						continue;
					case 5u:
						input.ReadMessage(this.targetId_);
						arg_178_0 = 4060227092u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_178_0 = (num2 * 2880381674u ^ 811564078u);
						continue;
					case 7u:
						goto IL_1D0;
					case 8u:
						this.Role = input.ReadUInt32();
						arg_178_0 = 4060227092u;
						continue;
					case 9u:
						arg_178_0 = ((num != 10u) ? 4143138184u : 3878435998u);
						continue;
					case 10u:
						arg_178_0 = ((this.agentId_ != null) ? 2499596536u : 3707828208u);
						continue;
					case 11u:
						arg_178_0 = (num2 * 3492598426u ^ 3502039540u);
						continue;
					case 12u:
						this.targetId_ = new EntityId();
						arg_178_0 = (num2 * 1051312624u ^ 779418050u);
						continue;
					case 13u:
						arg_178_0 = 4101443890u;
						continue;
					case 14u:
						input.ReadMessage(this.agentId_);
						arg_178_0 = 2380815045u;
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
