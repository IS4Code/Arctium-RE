using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class ClearRecentPlayersRequest : IMessage<ClearRecentPlayersRequest>, IEquatable<ClearRecentPlayersRequest>, IDeepCloneable<ClearRecentPlayersRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ClearRecentPlayersRequest.__c __9 = new ClearRecentPlayersRequest.__c();

			internal ClearRecentPlayersRequest cctor>b__29_0()
			{
				return new ClearRecentPlayersRequest();
			}
		}

		private static readonly MessageParser<ClearRecentPlayersRequest> _parser = new MessageParser<ClearRecentPlayersRequest>(new Func<ClearRecentPlayersRequest>(ClearRecentPlayersRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int ProgramFieldNumber = 2;

		private uint program_;

		public static MessageParser<ClearRecentPlayersRequest> Parser
		{
			get
			{
				return ClearRecentPlayersRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearRecentPlayersRequest.Descriptor;
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

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public ClearRecentPlayersRequest()
		{
		}

		public ClearRecentPlayersRequest(ClearRecentPlayersRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.program_ = other.program_;
		}

		public ClearRecentPlayersRequest Clone()
		{
			return new ClearRecentPlayersRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ClearRecentPlayersRequest);
		}

		public bool Equals(ClearRecentPlayersRequest other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 748845754) % 9)
				{
				case 0:
					arg_72_0 = ((this.Program == other.Program) ? 591391368 : 985474973);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 4:
					return false;
				case 5:
					arg_72_0 = (ClearRecentPlayersRequest.smethod_0(this.AgentId, other.AgentId) ? 1943420574 : 1451277237);
					continue;
				case 6:
					goto IL_B0;
				case 7:
					goto IL_15;
				case 8:
					return true;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1828746358;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 1304190205 : 1584535417);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B5:
				uint arg_91_0 = 597871833u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_91_0 ^ 1030944233u)) % 6u)
					{
					case 0u:
						goto IL_B5;
					case 1u:
						num ^= ClearRecentPlayersRequest.smethod_1(this.AgentId);
						arg_91_0 = (num2 * 3018240934u ^ 17502428u);
						continue;
					case 3u:
						num ^= this.Program.GetHashCode();
						arg_91_0 = (num2 * 1037390454u ^ 3946709141u);
						continue;
					case 4u:
						arg_91_0 = (((this.agentId_ != null) ? 2292147860u : 2830396898u) ^ num2 * 1598286115u);
						continue;
					case 5u:
						arg_91_0 = ((this.Program != 0u) ? 991076550u : 905269567u);
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
				goto IL_31;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 164211479u)) % 7u)
				{
				case 0u:
					output.WriteUInt32(this.Program);
					arg_88_0 = (num * 1156221316u ^ 875679789u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_88_0 = (num * 3544004047u ^ 4232123549u);
					continue;
				case 2u:
					output.WriteMessage(this.AgentId);
					arg_88_0 = (num * 260085712u ^ 3608184552u);
					continue;
				case 3u:
					goto IL_BF;
				case 5u:
					goto IL_31;
				case 6u:
					output.WriteRawTag(16);
					arg_88_0 = (num * 1531831259u ^ 3656550375u);
					continue;
				}
				break;
			}
			return;
			IL_31:
			arg_88_0 = 1520380915u;
			goto IL_83;
			IL_BF:
			arg_88_0 = ((this.Program == 0u) ? 1320999013u : 521885329u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 2042261754u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 1924088770u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_92_0 = (num2 * 3751271564u ^ 723943466u);
						continue;
					case 2u:
						arg_92_0 = ((this.Program == 0u) ? 1239570069u : 1060919691u);
						continue;
					case 3u:
						goto IL_B6;
					case 4u:
						arg_92_0 = (((this.agentId_ != null) ? 2566735222u : 3204073194u) ^ num2 * 3714342994u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
						arg_92_0 = (num2 * 2858228757u ^ 865367400u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ClearRecentPlayersRequest other)
		{
			if (other == null)
			{
				goto IL_9D;
			}
			goto IL_FF;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 263505804u)) % 9u)
				{
				case 0u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BF_0 = 663701328u;
					continue;
				case 2u:
					goto IL_9D;
				case 3u:
					this.agentId_ = new EntityId();
					arg_BF_0 = (num * 2664145013u ^ 3000308724u);
					continue;
				case 4u:
					return;
				case 5u:
					goto IL_FF;
				case 6u:
					arg_BF_0 = ((other.Program == 0u) ? 1624365777u : 361202041u);
					continue;
				case 7u:
					arg_BF_0 = (((this.agentId_ == null) ? 1350635889u : 1286024253u) ^ num * 35132881u);
					continue;
				case 8u:
					this.Program = other.Program;
					arg_BF_0 = (num * 3578763297u ^ 4052305732u);
					continue;
				}
				break;
			}
			return;
			IL_9D:
			arg_BF_0 = 1317028304u;
			goto IL_BA;
			IL_FF:
			arg_BF_0 = ((other.agentId_ == null) ? 663701328u : 1173245326u);
			goto IL_BA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13A:
				uint num;
				uint arg_F2_0 = ((num = input.ReadTag()) == 0u) ? 2737167952u : 4281465108u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F2_0 ^ 3890161303u)) % 11u)
					{
					case 0u:
						arg_F2_0 = 4281465108u;
						continue;
					case 1u:
						arg_F2_0 = ((this.agentId_ != null) ? 3833943132u : 2260638917u);
						continue;
					case 3u:
						this.Program = input.ReadUInt32();
						arg_F2_0 = 3996638629u;
						continue;
					case 4u:
						arg_F2_0 = ((num == 10u) ? 3626667199u : 3781183690u);
						continue;
					case 5u:
						arg_F2_0 = (((num != 16u) ? 3847689829u : 3146855879u) ^ num2 * 2582375872u);
						continue;
					case 6u:
						input.ReadMessage(this.agentId_);
						arg_F2_0 = 4084983106u;
						continue;
					case 7u:
						this.agentId_ = new EntityId();
						arg_F2_0 = (num2 * 48063015u ^ 1485148706u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_F2_0 = (num2 * 1470343769u ^ 756342471u);
						continue;
					case 9u:
						arg_F2_0 = (num2 * 2070404822u ^ 2876684203u);
						continue;
					case 10u:
						goto IL_13A;
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
