using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class BlockedPlayerRemovedNotification : IMessage<BlockedPlayerRemovedNotification>, IEquatable<BlockedPlayerRemovedNotification>, IDeepCloneable<BlockedPlayerRemovedNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BlockedPlayerRemovedNotification.__c __9 = new BlockedPlayerRemovedNotification.__c();

			internal BlockedPlayerRemovedNotification cctor>b__34_0()
			{
				return new BlockedPlayerRemovedNotification();
			}
		}

		private static readonly MessageParser<BlockedPlayerRemovedNotification> _parser = new MessageParser<BlockedPlayerRemovedNotification>(new Func<BlockedPlayerRemovedNotification>(BlockedPlayerRemovedNotification.__c.__9.<.cctor>b__34_0));

		public const int PlayerFieldNumber = 1;

		private BlockedPlayer player_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int AccountIdFieldNumber = 3;

		private EntityId accountId_;

		public static MessageParser<BlockedPlayerRemovedNotification> Parser
		{
			get
			{
				return BlockedPlayerRemovedNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayerRemovedNotification.Descriptor;
			}
		}

		public BlockedPlayer Player
		{
			get
			{
				return this.player_;
			}
			set
			{
				this.player_ = value;
			}
		}

		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		public BlockedPlayerRemovedNotification()
		{
		}

		public BlockedPlayerRemovedNotification(BlockedPlayerRemovedNotification other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = -6442439;
				while (true)
				{
					switch ((arg_2E_0 ^ -1476596059) % 3)
					{
					case 1:
						this.Player = ((other.player_ != null) ? other.Player.Clone() : null);
						arg_2E_0 = -1650730472;
						continue;
					case 2:
						goto IL_44;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
		}

		public BlockedPlayerRemovedNotification Clone()
		{
			return new BlockedPlayerRemovedNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayerRemovedNotification);
		}

		public bool Equals(BlockedPlayerRemovedNotification other)
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
				switch ((arg_A6_0 ^ 290756307) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 3:
					arg_A6_0 = ((!BlockedPlayerRemovedNotification.smethod_0(this.AccountId, other.AccountId)) ? 2066736026 : 356196399);
					continue;
				case 4:
					return false;
				case 5:
					goto IL_EC;
				case 6:
					arg_A6_0 = (BlockedPlayerRemovedNotification.smethod_0(this.GameAccountId, other.GameAccountId) ? 898538429 : 613555783);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_44;
				case 9:
					return true;
				case 10:
					arg_A6_0 = ((!BlockedPlayerRemovedNotification.smethod_0(this.Player, other.Player)) ? 925570421 : 1517273943);
					continue;
				}
				break;
			}
			return true;
			IL_44:
			arg_A6_0 = 1502132542;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other == this) ? 216454718 : 69699196);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D6:
				uint arg_AE_0 = 1113288499u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 1443939704u)) % 7u)
					{
					case 0u:
						arg_AE_0 = (((this.gameAccountId_ != null) ? 2808328779u : 3381956253u) ^ num2 * 226137995u);
						continue;
					case 1u:
						num ^= BlockedPlayerRemovedNotification.smethod_1(this.Player);
						arg_AE_0 = (num2 * 2564533346u ^ 2532381099u);
						continue;
					case 2u:
						arg_AE_0 = ((this.accountId_ != null) ? 1350938264u : 1263271889u);
						continue;
					case 4u:
						num ^= BlockedPlayerRemovedNotification.smethod_1(this.AccountId);
						arg_AE_0 = (num2 * 1444076739u ^ 151934065u);
						continue;
					case 5u:
						goto IL_D6;
					case 6u:
						num ^= BlockedPlayerRemovedNotification.smethod_1(this.GameAccountId);
						arg_AE_0 = (num2 * 1572740395u ^ 1335730950u);
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
			output.WriteRawTag(10);
			while (true)
			{
				IL_FC:
				uint arg_D0_0 = 2862579353u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D0_0 ^ 2793558059u)) % 8u)
					{
					case 0u:
						arg_D0_0 = ((this.accountId_ == null) ? 4250239706u : 3172256221u);
						continue;
					case 2u:
						output.WriteMessage(this.Player);
						arg_D0_0 = (((this.gameAccountId_ == null) ? 1004631031u : 1626200u) ^ num * 2542243474u);
						continue;
					case 3u:
						goto IL_FC;
					case 4u:
						output.WriteMessage(this.AccountId);
						arg_D0_0 = (num * 3794167475u ^ 3835643342u);
						continue;
					case 5u:
						output.WriteMessage(this.GameAccountId);
						arg_D0_0 = (num * 3528244768u ^ 3920144851u);
						continue;
					case 6u:
						output.WriteRawTag(26);
						arg_D0_0 = (num * 1599518671u ^ 1978597725u);
						continue;
					case 7u:
						output.WriteRawTag(18);
						arg_D0_0 = (num * 3167873085u ^ 1430564093u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_DC:
				uint arg_B4_0 = 3209644916u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B4_0 ^ 4064919801u)) % 7u)
					{
					case 0u:
						arg_B4_0 = ((this.accountId_ != null) ? 3103729290u : 3289230137u);
						continue;
					case 1u:
						arg_B4_0 = (((this.gameAccountId_ != null) ? 1552014286u : 1697314184u) ^ num2 * 2363505428u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Player);
						arg_B4_0 = (num2 * 3770790101u ^ 2699352353u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_B4_0 = (num2 * 133976725u ^ 3564461526u);
						continue;
					case 4u:
						goto IL_DC;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_B4_0 = (num2 * 3998528909u ^ 3737570587u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(BlockedPlayerRemovedNotification other)
		{
			if (other == null)
			{
				goto IL_140;
			}
			goto IL_1E5;
			uint arg_18D_0;
			while (true)
			{
				IL_188:
				uint num;
				switch ((num = (arg_18D_0 ^ 3394629446u)) % 15u)
				{
				case 0u:
					arg_18D_0 = (((this.player_ != null) ? 679812720u : 1432355595u) ^ num * 3069612295u);
					continue;
				case 1u:
					this.gameAccountId_ = new EntityId();
					arg_18D_0 = (num * 2601573597u ^ 1551165891u);
					continue;
				case 2u:
					goto IL_140;
				case 3u:
					arg_18D_0 = ((other.accountId_ != null) ? 3027780819u : 2669408531u);
					continue;
				case 4u:
					arg_18D_0 = ((other.gameAccountId_ != null) ? 2674450773u : 3934163274u);
					continue;
				case 5u:
					this.player_ = new BlockedPlayer();
					arg_18D_0 = (num * 2378722047u ^ 3535847107u);
					continue;
				case 6u:
					return;
				case 7u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_18D_0 = 3934163274u;
					continue;
				case 9u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_18D_0 = 2669408531u;
					continue;
				case 10u:
					goto IL_1E5;
				case 11u:
					arg_18D_0 = (((this.accountId_ != null) ? 2865736665u : 2365401049u) ^ num * 1917479494u);
					continue;
				case 12u:
					this.Player.MergeFrom(other.Player);
					arg_18D_0 = 3927820830u;
					continue;
				case 13u:
					this.accountId_ = new EntityId();
					arg_18D_0 = (num * 3007757985u ^ 508055974u);
					continue;
				case 14u:
					arg_18D_0 = (((this.gameAccountId_ == null) ? 3077647249u : 2863482468u) ^ num * 3763258889u);
					continue;
				}
				break;
			}
			return;
			IL_140:
			arg_18D_0 = 4215168376u;
			goto IL_188;
			IL_1E5:
			arg_18D_0 = ((other.player_ != null) ? 2254606324u : 3927820830u);
			goto IL_188;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_213:
				uint num;
				uint arg_1B3_0 = ((num = input.ReadTag()) != 0u) ? 2154834528u : 2686598537u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1B3_0 ^ 2398330567u)) % 17u)
					{
					case 0u:
						input.ReadMessage(this.gameAccountId_);
						arg_1B3_0 = 2681830552u;
						continue;
					case 1u:
						input.ReadMessage(this.player_);
						arg_1B3_0 = 2610752549u;
						continue;
					case 2u:
						arg_1B3_0 = 2154834528u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_1B3_0 = (num2 * 4153155727u ^ 3688042513u);
						continue;
					case 5u:
						arg_1B3_0 = ((this.accountId_ != null) ? 4206119667u : 2683215864u);
						continue;
					case 6u:
						goto IL_213;
					case 7u:
						arg_1B3_0 = (((num == 26u) ? 2344330355u : 3893667979u) ^ num2 * 195417261u);
						continue;
					case 8u:
						this.accountId_ = new EntityId();
						arg_1B3_0 = (num2 * 1385392728u ^ 857590107u);
						continue;
					case 9u:
						input.ReadMessage(this.accountId_);
						arg_1B3_0 = 2681830552u;
						continue;
					case 10u:
						arg_1B3_0 = (((num == 18u) ? 471054748u : 1992869692u) ^ num2 * 2727074516u);
						continue;
					case 11u:
						arg_1B3_0 = ((this.gameAccountId_ == null) ? 3395605551u : 2769987294u);
						continue;
					case 12u:
						arg_1B3_0 = ((this.player_ == null) ? 3381107773u : 2319717403u);
						continue;
					case 13u:
						arg_1B3_0 = (num2 * 3952882533u ^ 3209307570u);
						continue;
					case 14u:
						this.player_ = new BlockedPlayer();
						arg_1B3_0 = (num2 * 3457080517u ^ 2395289209u);
						continue;
					case 15u:
						this.gameAccountId_ = new EntityId();
						arg_1B3_0 = (num2 * 4026545485u ^ 3508087062u);
						continue;
					case 16u:
						arg_1B3_0 = ((num != 10u) ? 2334070464u : 2424822141u);
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
