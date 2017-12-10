using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscribeResponse.__c __9 = new SubscribeResponse.__c();

			internal SubscribeResponse cctor>b__34_0()
			{
				return new SubscribeResponse();
			}
		}

		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(new Func<SubscribeResponse>(SubscribeResponse.__c.__9.<.cctor>b__34_0));

		public const int BlockedPlayersFieldNumber = 1;

		private static readonly FieldCodec<BlockedPlayer> _repeated_blockedPlayers_codec = FieldCodec.ForMessage<BlockedPlayer>(10u, BlockedPlayer.Parser);

		private readonly RepeatedField<BlockedPlayer> blockedPlayers_ = new RepeatedField<BlockedPlayer>();

		public const int RecentPlayersFieldNumber = 2;

		private static readonly FieldCodec<RecentPlayer> _repeated_recentPlayers_codec;

		private readonly RepeatedField<RecentPlayer> recentPlayers_ = new RepeatedField<RecentPlayer>();

		public const int RoleFieldNumber = 3;

		private static readonly FieldCodec<Role> _repeated_role_codec;

		private readonly RepeatedField<Role> role_ = new RepeatedField<Role>();

		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		public RepeatedField<BlockedPlayer> BlockedPlayers
		{
			get
			{
				return this.blockedPlayers_;
			}
		}

		public RepeatedField<RecentPlayer> RecentPlayers
		{
			get
			{
				return this.recentPlayers_;
			}
		}

		public RepeatedField<Role> Role
		{
			get
			{
				return this.role_;
			}
		}

		public SubscribeResponse()
		{
		}

		public SubscribeResponse(SubscribeResponse other) : this()
		{
			this.blockedPlayers_ = other.blockedPlayers_.Clone();
			this.recentPlayers_ = other.recentPlayers_.Clone();
			this.role_ = other.role_.Clone();
		}

		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		public bool Equals(SubscribeResponse other)
		{
			if (other == null)
			{
				goto IL_9F;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ -1643437934) % 11)
				{
				case 0:
					goto IL_9F;
				case 1:
					return false;
				case 2:
					arg_A9_0 = ((!this.recentPlayers_.Equals(other.recentPlayers_)) ? -66871126 : -1082490760);
					continue;
				case 3:
					return false;
				case 4:
					arg_A9_0 = (this.role_.Equals(other.role_) ? -774995713 : -1718351696);
					continue;
				case 5:
					arg_A9_0 = ((!this.blockedPlayers_.Equals(other.blockedPlayers_)) ? -1233563154 : -1598978711);
					continue;
				case 6:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_EF;
				case 10:
					return true;
				}
				break;
			}
			return true;
			IL_9F:
			arg_A9_0 = -1368990422;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other == this) ? -1591529965 : -343425537);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			return 1 ^ SubscribeResponse.smethod_0(this.blockedPlayers_) ^ SubscribeResponse.smethod_0(this.recentPlayers_) ^ SubscribeResponse.smethod_0(this.role_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.blockedPlayers_.WriteTo(output, SubscribeResponse._repeated_blockedPlayers_codec);
			while (true)
			{
				IL_5F:
				uint arg_47_0 = 2504005688u;
				while (true)
				{
					uint num;
					switch ((num = (arg_47_0 ^ 3592398713u)) % 3u)
					{
					case 1u:
						this.recentPlayers_.WriteTo(output, SubscribeResponse._repeated_recentPlayers_codec);
						this.role_.WriteTo(output, SubscribeResponse._repeated_role_codec);
						arg_47_0 = (num * 1409422884u ^ 733465862u);
						continue;
					case 2u:
						goto IL_5F;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + this.blockedPlayers_.CalculateSize(SubscribeResponse._repeated_blockedPlayers_codec) + this.recentPlayers_.CalculateSize(SubscribeResponse._repeated_recentPlayers_codec) + this.role_.CalculateSize(SubscribeResponse._repeated_role_codec);
		}

		public void MergeFrom(SubscribeResponse other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 704622137;
			IL_08:
			switch ((arg_0D_0 ^ 1631873067) % 4)
			{
			case 1:
				IL_27:
				this.blockedPlayers_.Add(other.blockedPlayers_);
				this.recentPlayers_.Add(other.recentPlayers_);
				this.role_.Add(other.role_);
				arg_0D_0 = 1343234911;
				goto IL_08;
			case 2:
				return;
			case 3:
				goto IL_03;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_131:
				uint num;
				uint arg_ED_0 = ((num = input.ReadTag()) == 0u) ? 1127506188u : 2030087239u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_ED_0 ^ 2138132074u)) % 10u)
					{
					case 0u:
						arg_ED_0 = 2030087239u;
						continue;
					case 1u:
						this.recentPlayers_.AddEntriesFrom(input, SubscribeResponse._repeated_recentPlayers_codec);
						arg_ED_0 = 1431335323u;
						continue;
					case 2u:
						arg_ED_0 = (((num != 18u) ? 2948985567u : 2663062287u) ^ num2 * 1561344161u);
						continue;
					case 3u:
						this.role_.AddEntriesFrom(input, SubscribeResponse._repeated_role_codec);
						arg_ED_0 = 1431335323u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_ED_0 = (num2 * 3220669149u ^ 1788806673u);
						continue;
					case 5u:
						arg_ED_0 = ((num == 10u) ? 1174096352u : 224295372u);
						continue;
					case 6u:
						this.blockedPlayers_.AddEntriesFrom(input, SubscribeResponse._repeated_blockedPlayers_codec);
						arg_ED_0 = 1431335323u;
						continue;
					case 7u:
						arg_ED_0 = (((num != 26u) ? 2108639587u : 1963587096u) ^ num2 * 3604676249u);
						continue;
					case 9u:
						goto IL_131;
					}
					return;
				}
			}
		}

		static SubscribeResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_68:
				uint arg_50_0 = 411105064u;
				while (true)
				{
					uint num;
					switch ((num = (arg_50_0 ^ 886660111u)) % 3u)
					{
					case 0u:
						goto IL_68;
					case 1u:
						SubscribeResponse._repeated_recentPlayers_codec = FieldCodec.ForMessage<RecentPlayer>(18u, RecentPlayer.Parser);
						arg_50_0 = (num * 714837179u ^ 1917105064u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			SubscribeResponse._repeated_role_codec = FieldCodec.ForMessage<Role>(26u, Bgs.Protocol.Role.Parser);
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
