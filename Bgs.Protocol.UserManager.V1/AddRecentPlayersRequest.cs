using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class AddRecentPlayersRequest : IMessage<AddRecentPlayersRequest>, IEquatable<AddRecentPlayersRequest>, IDeepCloneable<AddRecentPlayersRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AddRecentPlayersRequest.__c __9 = new AddRecentPlayersRequest.__c();

			internal AddRecentPlayersRequest cctor>b__34_0()
			{
				return new AddRecentPlayersRequest();
			}
		}

		private static readonly MessageParser<AddRecentPlayersRequest> _parser = new MessageParser<AddRecentPlayersRequest>(new Func<AddRecentPlayersRequest>(AddRecentPlayersRequest.__c.__9.<.cctor>b__34_0));

		public const int PlayersFieldNumber = 1;

		private static readonly FieldCodec<RecentPlayer> _repeated_players_codec = FieldCodec.ForMessage<RecentPlayer>(10u, RecentPlayer.Parser);

		private readonly RepeatedField<RecentPlayer> players_ = new RepeatedField<RecentPlayer>();

		public const int AgentIdFieldNumber = 2;

		private EntityId agentId_;

		public const int ProgramFieldNumber = 3;

		private uint program_;

		public static MessageParser<AddRecentPlayersRequest> Parser
		{
			get
			{
				return AddRecentPlayersRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRecentPlayersRequest.Descriptor;
			}
		}

		public RepeatedField<RecentPlayer> Players
		{
			get
			{
				return this.players_;
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

		public AddRecentPlayersRequest()
		{
		}

		public AddRecentPlayersRequest(AddRecentPlayersRequest other) : this()
		{
			while (true)
			{
				IL_61:
				int arg_4B_0 = -1862826100;
				while (true)
				{
					switch ((arg_4B_0 ^ -229538509) % 3)
					{
					case 0:
						goto IL_61;
					case 1:
						this.players_ = other.players_.Clone();
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.program_ = other.program_;
						arg_4B_0 = -81493516;
						continue;
					}
					return;
				}
			}
		}

		public AddRecentPlayersRequest Clone()
		{
			return new AddRecentPlayersRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AddRecentPlayersRequest);
		}

		public bool Equals(AddRecentPlayersRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ 1244565634) % 11)
				{
				case 0:
					return true;
				case 1:
					arg_A1_0 = (AddRecentPlayersRequest.smethod_0(this.AgentId, other.AgentId) ? 374918447 : 625258820);
					continue;
				case 2:
					return false;
				case 3:
					arg_A1_0 = (this.players_.Equals(other.players_) ? 659806800 : 1840469600);
					continue;
				case 5:
					arg_A1_0 = ((this.Program == other.Program) ? 410645956 : 694031068);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_18;
				case 10:
					goto IL_E7;
				}
				break;
			}
			return true;
			IL_18:
			arg_A1_0 = 1988394152;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other == this) ? 1386220773 : 1412891252);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D9:
				uint arg_B1_0 = 3511023526u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B1_0 ^ 4234212759u)) % 7u)
					{
					case 1u:
						num ^= AddRecentPlayersRequest.smethod_1(this.players_);
						arg_B1_0 = (num2 * 2212542789u ^ 1563033295u);
						continue;
					case 2u:
						arg_B1_0 = ((this.Program != 0u) ? 3417493917u : 4055450430u);
						continue;
					case 3u:
						num ^= AddRecentPlayersRequest.smethod_1(this.AgentId);
						arg_B1_0 = (num2 * 1389711091u ^ 294259279u);
						continue;
					case 4u:
						goto IL_D9;
					case 5u:
						arg_B1_0 = (((this.agentId_ != null) ? 3381990442u : 2363631296u) ^ num2 * 337412794u);
						continue;
					case 6u:
						num ^= this.Program.GetHashCode();
						arg_B1_0 = (num2 * 679071610u ^ 4021944826u);
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
			this.players_.WriteTo(output, AddRecentPlayersRequest._repeated_players_codec);
			if (this.agentId_ != null)
			{
				goto IL_80;
			}
			goto IL_BD;
			uint arg_8A_0;
			while (true)
			{
				IL_85:
				uint num;
				switch ((num = (arg_8A_0 ^ 164052016u)) % 6u)
				{
				case 0u:
					goto IL_80;
				case 1u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.Program);
					arg_8A_0 = (num * 804416669u ^ 3271784244u);
					continue;
				case 2u:
					output.WriteRawTag(18);
					arg_8A_0 = (num * 2944478650u ^ 3214826165u);
					continue;
				case 4u:
					goto IL_BD;
				case 5u:
					output.WriteMessage(this.AgentId);
					arg_8A_0 = (num * 3771279480u ^ 853936338u);
					continue;
				}
				break;
			}
			return;
			IL_80:
			arg_8A_0 = 687153604u;
			goto IL_85;
			IL_BD:
			arg_8A_0 = ((this.Program == 0u) ? 377516573u : 579680973u);
			goto IL_85;
		}

		public int CalculateSize()
		{
			int num = 0 + this.players_.CalculateSize(AddRecentPlayersRequest._repeated_players_codec);
			if (this.agentId_ != null)
			{
				goto IL_6D;
			}
			goto IL_A3;
			uint arg_77_0;
			while (true)
			{
				IL_72:
				uint num2;
				switch ((num2 = (arg_77_0 ^ 2913737550u)) % 5u)
				{
				case 0u:
					goto IL_6D;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_77_0 = (num2 * 3849734585u ^ 520322527u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
					arg_77_0 = (num2 * 863564624u ^ 438691995u);
					continue;
				case 3u:
					goto IL_A3;
				}
				break;
			}
			return num;
			IL_6D:
			arg_77_0 = 2332034558u;
			goto IL_72;
			IL_A3:
			arg_77_0 = ((this.Program == 0u) ? 2249067067u : 3151643532u);
			goto IL_72;
		}

		public void MergeFrom(AddRecentPlayersRequest other)
		{
			if (other == null)
			{
				goto IL_50;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 4109838186u)) % 9u)
				{
				case 0u:
					goto IL_FC;
				case 1u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BC_0 = 2389118531u;
					continue;
				case 2u:
					arg_BC_0 = (((this.agentId_ == null) ? 72122479u : 845959918u) ^ num * 1775497148u);
					continue;
				case 3u:
					arg_BC_0 = ((other.Program == 0u) ? 4002151957u : 3033511504u);
					continue;
				case 4u:
					goto IL_50;
				case 5u:
					this.Program = other.Program;
					arg_BC_0 = (num * 2338915298u ^ 2229673249u);
					continue;
				case 6u:
					this.agentId_ = new EntityId();
					arg_BC_0 = (num * 2439848796u ^ 2220157882u);
					continue;
				case 7u:
					return;
				}
				break;
			}
			return;
			IL_50:
			arg_BC_0 = 3479396433u;
			goto IL_B7;
			IL_FC:
			this.players_.Add(other.players_);
			arg_BC_0 = ((other.agentId_ != null) ? 3122257048u : 2389118531u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_186:
				uint num;
				uint arg_136_0 = ((num = input.ReadTag()) == 0u) ? 127054563u : 1898119716u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_136_0 ^ 939287956u)) % 13u)
					{
					case 0u:
						arg_136_0 = (((num != 24u) ? 343018566u : 1407810462u) ^ num2 * 487081726u);
						continue;
					case 2u:
						input.ReadMessage(this.agentId_);
						arg_136_0 = 2012828571u;
						continue;
					case 3u:
						this.agentId_ = new EntityId();
						arg_136_0 = (num2 * 1994550817u ^ 1289225992u);
						continue;
					case 4u:
						arg_136_0 = (num2 * 2307993506u ^ 4134890529u);
						continue;
					case 5u:
						this.Program = input.ReadUInt32();
						arg_136_0 = 2012828571u;
						continue;
					case 6u:
						arg_136_0 = (((num != 18u) ? 3778690768u : 4197641877u) ^ num2 * 2780636166u);
						continue;
					case 7u:
						arg_136_0 = 1898119716u;
						continue;
					case 8u:
						goto IL_186;
					case 9u:
						arg_136_0 = ((num == 10u) ? 1602142100u : 869435362u);
						continue;
					case 10u:
						input.SkipLastField();
						arg_136_0 = (num2 * 2047820262u ^ 3341804917u);
						continue;
					case 11u:
						arg_136_0 = ((this.agentId_ == null) ? 836450040u : 1385836516u);
						continue;
					case 12u:
						this.players_.AddEntriesFrom(input, AddRecentPlayersRequest._repeated_players_codec);
						arg_136_0 = 2012828571u;
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
