using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class BlockedPlayerAddedNotification : IMessage<BlockedPlayerAddedNotification>, IEquatable<BlockedPlayerAddedNotification>, IDeepCloneable<BlockedPlayerAddedNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BlockedPlayerAddedNotification.__c __9 = new BlockedPlayerAddedNotification.__c();

			internal BlockedPlayerAddedNotification cctor>b__34_0()
			{
				return new BlockedPlayerAddedNotification();
			}
		}

		private static readonly MessageParser<BlockedPlayerAddedNotification> _parser = new MessageParser<BlockedPlayerAddedNotification>(new Func<BlockedPlayerAddedNotification>(BlockedPlayerAddedNotification.__c.__9.<.cctor>b__34_0));

		public const int PlayerFieldNumber = 1;

		private BlockedPlayer player_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int AccountIdFieldNumber = 3;

		private EntityId accountId_;

		public static MessageParser<BlockedPlayerAddedNotification> Parser
		{
			get
			{
				return BlockedPlayerAddedNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayerAddedNotification.Descriptor;
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

		public BlockedPlayerAddedNotification()
		{
		}

		public BlockedPlayerAddedNotification(BlockedPlayerAddedNotification other) : this()
		{
			this.Player = ((other.player_ != null) ? other.Player.Clone() : null);
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
		}

		public BlockedPlayerAddedNotification Clone()
		{
			return new BlockedPlayerAddedNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayerAddedNotification);
		}

		public bool Equals(BlockedPlayerAddedNotification other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -1829719428) % 11)
				{
				case 0:
					return false;
				case 1:
					goto IL_EC;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_A6_0 = ((!BlockedPlayerAddedNotification.smethod_0(this.GameAccountId, other.GameAccountId)) ? -282750759 : -1947654323);
					continue;
				case 7:
					goto IL_70;
				case 8:
					arg_A6_0 = ((!BlockedPlayerAddedNotification.smethod_0(this.Player, other.Player)) ? -1614210817 : -1997356152);
					continue;
				case 9:
					return false;
				case 10:
					arg_A6_0 = (BlockedPlayerAddedNotification.smethod_0(this.AccountId, other.AccountId) ? -1860034592 : -2141513606);
					continue;
				}
				break;
			}
			return true;
			IL_70:
			arg_A6_0 = -413568622;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other == this) ? -438897008 : -674022903);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ BlockedPlayerAddedNotification.smethod_1(this.Player);
			while (true)
			{
				IL_C0:
				uint arg_9C_0 = 2264420631u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9C_0 ^ 4271407101u)) % 6u)
					{
					case 1u:
						num ^= BlockedPlayerAddedNotification.smethod_1(this.GameAccountId);
						arg_9C_0 = (num2 * 150948445u ^ 747780425u);
						continue;
					case 2u:
						num ^= BlockedPlayerAddedNotification.smethod_1(this.AccountId);
						arg_9C_0 = (num2 * 1425721867u ^ 2338393931u);
						continue;
					case 3u:
						arg_9C_0 = ((this.accountId_ != null) ? 3725870133u : 2246274771u);
						continue;
					case 4u:
						arg_9C_0 = (((this.gameAccountId_ != null) ? 3008333910u : 2427071478u) ^ num2 * 3695629764u);
						continue;
					case 5u:
						goto IL_C0;
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
			output.WriteMessage(this.Player);
			if (this.gameAccountId_ != null)
			{
				goto IL_83;
			}
			goto IL_C0;
			uint arg_8D_0;
			while (true)
			{
				IL_88:
				uint num;
				switch ((num = (arg_8D_0 ^ 2594301750u)) % 6u)
				{
				case 0u:
					goto IL_83;
				case 1u:
					output.WriteRawTag(18);
					output.WriteMessage(this.GameAccountId);
					arg_8D_0 = (num * 3710385886u ^ 501674843u);
					continue;
				case 2u:
					output.WriteRawTag(26);
					arg_8D_0 = (num * 3152042166u ^ 2496973622u);
					continue;
				case 3u:
					goto IL_C0;
				case 4u:
					output.WriteMessage(this.AccountId);
					arg_8D_0 = (num * 2767186268u ^ 2142069279u);
					continue;
				}
				break;
			}
			return;
			IL_83:
			arg_8D_0 = 3240107729u;
			goto IL_88;
			IL_C0:
			arg_8D_0 = ((this.accountId_ != null) ? 2250697026u : 4234385727u);
			goto IL_88;
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Player));
			while (true)
			{
				IL_C6:
				uint arg_A2_0 = 3355409258u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A2_0 ^ 3745935717u)) % 6u)
					{
					case 0u:
						goto IL_C6;
					case 1u:
						arg_A2_0 = ((this.accountId_ != null) ? 3133882463u : 2480493132u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_A2_0 = (num2 * 162274558u ^ 1913860950u);
						continue;
					case 3u:
						arg_A2_0 = (((this.gameAccountId_ == null) ? 2855812298u : 3777356337u) ^ num2 * 2181811444u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_A2_0 = (num2 * 4232093242u ^ 520593768u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(BlockedPlayerAddedNotification other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_1E2;
			uint arg_18A_0;
			while (true)
			{
				IL_185:
				uint num;
				switch ((num = (arg_18A_0 ^ 3311281883u)) % 15u)
				{
				case 0u:
					arg_18A_0 = ((other.gameAccountId_ == null) ? 2488145157u : 2594352238u);
					continue;
				case 1u:
					this.Player.MergeFrom(other.Player);
					arg_18A_0 = 2157857340u;
					continue;
				case 2u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_18A_0 = 2882580192u;
					continue;
				case 3u:
					this.accountId_ = new EntityId();
					arg_18A_0 = (num * 428321640u ^ 2716146264u);
					continue;
				case 4u:
					arg_18A_0 = (((this.accountId_ != null) ? 1684062053u : 194734833u) ^ num * 875409371u);
					continue;
				case 5u:
					this.player_ = new BlockedPlayer();
					arg_18A_0 = (num * 2049656497u ^ 2558978052u);
					continue;
				case 6u:
					arg_18A_0 = (((this.gameAccountId_ == null) ? 1558454510u : 1564469125u) ^ num * 1265072092u);
					continue;
				case 7u:
					arg_18A_0 = (((this.player_ == null) ? 1511026328u : 1961958983u) ^ num * 2241657763u);
					continue;
				case 8u:
					return;
				case 9u:
					this.gameAccountId_ = new EntityId();
					arg_18A_0 = (num * 2176033812u ^ 3938739069u);
					continue;
				case 10u:
					arg_18A_0 = ((other.accountId_ == null) ? 2882580192u : 3594538788u);
					continue;
				case 11u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_18A_0 = 2488145157u;
					continue;
				case 13u:
					goto IL_1E2;
				case 14u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_18A_0 = 4099404715u;
			goto IL_185;
			IL_1E2:
			arg_18A_0 = ((other.player_ == null) ? 2157857340u : 2286259866u);
			goto IL_185;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_23F:
				uint num;
				uint arg_1D7_0 = ((num = input.ReadTag()) != 0u) ? 1696312352u : 1568484582u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1D7_0 ^ 1939437971u)) % 19u)
					{
					case 0u:
						arg_1D7_0 = ((this.player_ != null) ? 445460461u : 1515840615u);
						continue;
					case 1u:
						arg_1D7_0 = (num2 * 258772027u ^ 2400400646u);
						continue;
					case 2u:
						this.accountId_ = new EntityId();
						arg_1D7_0 = (num2 * 949890502u ^ 2986560127u);
						continue;
					case 3u:
						input.ReadMessage(this.accountId_);
						arg_1D7_0 = 36935511u;
						continue;
					case 4u:
						arg_1D7_0 = 1696312352u;
						continue;
					case 5u:
						arg_1D7_0 = ((this.gameAccountId_ == null) ? 197518309u : 1497438882u);
						continue;
					case 6u:
						input.ReadMessage(this.player_);
						arg_1D7_0 = 1741876658u;
						continue;
					case 8u:
						goto IL_23F;
					case 9u:
						input.SkipLastField();
						arg_1D7_0 = (num2 * 3271302739u ^ 3331490805u);
						continue;
					case 10u:
						arg_1D7_0 = ((this.accountId_ != null) ? 1113149409u : 617203126u);
						continue;
					case 11u:
						this.gameAccountId_ = new EntityId();
						arg_1D7_0 = (num2 * 2628251530u ^ 1482192702u);
						continue;
					case 12u:
						arg_1D7_0 = ((num != 10u) ? 1561242606u : 1806123807u);
						continue;
					case 13u:
						arg_1D7_0 = (num2 * 3938570514u ^ 4063683769u);
						continue;
					case 14u:
						arg_1D7_0 = (((num != 18u) ? 293985523u : 409350101u) ^ num2 * 4111916209u);
						continue;
					case 15u:
						input.ReadMessage(this.gameAccountId_);
						arg_1D7_0 = 1029281772u;
						continue;
					case 16u:
						this.player_ = new BlockedPlayer();
						arg_1D7_0 = (num2 * 655952582u ^ 1937022293u);
						continue;
					case 17u:
						arg_1D7_0 = (((num != 26u) ? 652693782u : 118706141u) ^ num2 * 1666474698u);
						continue;
					case 18u:
						arg_1D7_0 = (num2 * 2166034866u ^ 1676523685u);
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
