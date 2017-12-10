using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountStateNotification : IMessage<AccountStateNotification>, IEquatable<AccountStateNotification>, IDeepCloneable<AccountStateNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountStateNotification.__c __9 = new AccountStateNotification.__c();

			internal AccountStateNotification cctor>b__39_0()
			{
				return new AccountStateNotification();
			}
		}

		private static readonly MessageParser<AccountStateNotification> _parser = new MessageParser<AccountStateNotification>(new Func<AccountStateNotification>(AccountStateNotification.__c.__9.<.cctor>b__39_0));

		public const int AccountStateFieldNumber = 1;

		private AccountState accountState_;

		public const int SubscriberIdFieldNumber = 2;

		private ulong subscriberId_;

		public const int AccountTagsFieldNumber = 3;

		private AccountFieldTags accountTags_;

		public const int SubscriptionCompletedFieldNumber = 4;

		private bool subscriptionCompleted_;

		public static MessageParser<AccountStateNotification> Parser
		{
			get
			{
				return AccountStateNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[28];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountStateNotification.Descriptor;
			}
		}

		public AccountState AccountState
		{
			get
			{
				return this.accountState_;
			}
			set
			{
				this.accountState_ = value;
			}
		}

		public ulong SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		public AccountFieldTags AccountTags
		{
			get
			{
				return this.accountTags_;
			}
			set
			{
				this.accountTags_ = value;
			}
		}

		public bool SubscriptionCompleted
		{
			get
			{
				return this.subscriptionCompleted_;
			}
			set
			{
				this.subscriptionCompleted_ = value;
			}
		}

		public AccountStateNotification()
		{
		}

		public AccountStateNotification(AccountStateNotification other) : this()
		{
			this.AccountState = ((other.accountState_ != null) ? other.AccountState.Clone() : null);
			this.subscriberId_ = other.subscriberId_;
			this.AccountTags = ((other.accountTags_ != null) ? other.AccountTags.Clone() : null);
			this.subscriptionCompleted_ = other.subscriptionCompleted_;
		}

		public AccountStateNotification Clone()
		{
			return new AccountStateNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountStateNotification);
		}

		public bool Equals(AccountStateNotification other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_119;
			int arg_CB_0;
			while (true)
			{
				IL_C6:
				switch ((arg_CB_0 ^ 1452135408) % 13)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 3:
					arg_CB_0 = ((this.SubscriptionCompleted == other.SubscriptionCompleted) ? 1742642543 : 581831702);
					continue;
				case 4:
					goto IL_9A;
				case 5:
					return false;
				case 6:
					arg_CB_0 = ((this.SubscriberId != other.SubscriberId) ? 756797795 : 582408559);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_119;
				case 9:
					arg_CB_0 = ((!AccountStateNotification.smethod_0(this.AccountTags, other.AccountTags)) ? 994499204 : 284106692);
					continue;
				case 10:
					return false;
				case 11:
					return true;
				case 12:
					arg_CB_0 = (AccountStateNotification.smethod_0(this.AccountState, other.AccountState) ? 370643992 : 196404214);
					continue;
				}
				break;
			}
			return true;
			IL_9A:
			arg_CB_0 = 288825684;
			goto IL_C6;
			IL_119:
			arg_CB_0 = ((other != this) ? 1262514694 : 2058962405);
			goto IL_C6;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.accountState_ != null)
			{
				goto IL_A7;
			}
			goto IL_12E;
			uint arg_EE_0;
			while (true)
			{
				IL_E9:
				uint num2;
				switch ((num2 = (arg_EE_0 ^ 3945840594u)) % 9u)
				{
				case 0u:
					num ^= this.SubscriptionCompleted.GetHashCode();
					arg_EE_0 = (num2 * 4169425603u ^ 3608974799u);
					continue;
				case 1u:
					num ^= this.AccountTags.GetHashCode();
					arg_EE_0 = (num2 * 717553154u ^ 3279084773u);
					continue;
				case 2u:
					goto IL_A7;
				case 3u:
					arg_EE_0 = ((this.accountTags_ == null) ? 3281005981u : 4049636206u);
					continue;
				case 4u:
					num ^= this.SubscriberId.GetHashCode();
					arg_EE_0 = (num2 * 582009716u ^ 2379800686u);
					continue;
				case 5u:
					arg_EE_0 = ((!this.SubscriptionCompleted) ? 3581878932u : 3782303835u);
					continue;
				case 6u:
					num ^= AccountStateNotification.smethod_1(this.AccountState);
					arg_EE_0 = (num2 * 1776695801u ^ 2295715884u);
					continue;
				case 7u:
					goto IL_12E;
				}
				break;
			}
			return num;
			IL_A7:
			arg_EE_0 = 2856262181u;
			goto IL_E9;
			IL_12E:
			arg_EE_0 = ((this.SubscriberId != 0uL) ? 3660406937u : 4059541138u);
			goto IL_E9;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountState_ != null)
			{
				goto IL_37;
			}
			goto IL_167;
			uint arg_11F_0;
			while (true)
			{
				IL_11A:
				uint num;
				switch ((num = (arg_11F_0 ^ 1513452570u)) % 11u)
				{
				case 0u:
					output.WriteRawTag(26);
					arg_11F_0 = (num * 279821300u ^ 1174708322u);
					continue;
				case 1u:
					output.WriteRawTag(32);
					output.WriteBool(this.SubscriptionCompleted);
					arg_11F_0 = (num * 457200737u ^ 364285202u);
					continue;
				case 2u:
					output.WriteMessage(this.AccountTags);
					arg_11F_0 = (num * 1880528597u ^ 2917843365u);
					continue;
				case 3u:
					arg_11F_0 = ((!this.SubscriptionCompleted) ? 1570147826u : 1131469050u);
					continue;
				case 4u:
					output.WriteUInt64(this.SubscriberId);
					arg_11F_0 = (num * 2189331606u ^ 4174522102u);
					continue;
				case 5u:
					arg_11F_0 = ((this.accountTags_ != null) ? 412086990u : 1266604333u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AccountState);
					arg_11F_0 = (num * 637165977u ^ 1083121398u);
					continue;
				case 8u:
					goto IL_37;
				case 9u:
					goto IL_167;
				case 10u:
					output.WriteRawTag(16);
					arg_11F_0 = (num * 2848001928u ^ 500124522u);
					continue;
				}
				break;
			}
			return;
			IL_37:
			arg_11F_0 = 1772919711u;
			goto IL_11A;
			IL_167:
			arg_11F_0 = ((this.SubscriberId != 0uL) ? 52608084u : 1607794422u);
			goto IL_11A;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_144:
				uint arg_10F_0 = 1949496358u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10F_0 ^ 2093775157u)) % 10u)
					{
					case 0u:
						num += 2;
						arg_10F_0 = (num2 * 2136309919u ^ 3254634235u);
						continue;
					case 1u:
						arg_10F_0 = ((this.SubscriberId == 0uL) ? 745903250u : 1549691912u);
						continue;
					case 3u:
						arg_10F_0 = (this.SubscriptionCompleted ? 1332256519u : 48250869u);
						continue;
					case 4u:
						goto IL_144;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
						arg_10F_0 = (num2 * 921164637u ^ 4180832955u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountState);
						arg_10F_0 = (num2 * 2231214604u ^ 3891119536u);
						continue;
					case 7u:
						arg_10F_0 = (((this.accountState_ != null) ? 3298709450u : 2214602119u) ^ num2 * 1292714157u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
						arg_10F_0 = (num2 * 3426270503u ^ 808338192u);
						continue;
					case 9u:
						arg_10F_0 = ((this.accountTags_ != null) ? 777673975u : 2030156190u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountStateNotification other)
		{
			if (other == null)
			{
				goto IL_17C;
			}
			goto IL_1DE;
			uint arg_186_0;
			while (true)
			{
				IL_181:
				uint num;
				switch ((num = (arg_186_0 ^ 2075045109u)) % 15u)
				{
				case 0u:
					goto IL_17C;
				case 1u:
					this.SubscriberId = other.SubscriberId;
					arg_186_0 = (num * 1010108156u ^ 53522516u);
					continue;
				case 2u:
					arg_186_0 = (((this.accountState_ == null) ? 2028768150u : 468603605u) ^ num * 3483307593u);
					continue;
				case 3u:
					this.AccountTags.MergeFrom(other.AccountTags);
					arg_186_0 = 1668156851u;
					continue;
				case 4u:
					goto IL_1DE;
				case 5u:
					this.accountState_ = new AccountState();
					arg_186_0 = (num * 2523573847u ^ 581465600u);
					continue;
				case 6u:
					return;
				case 7u:
					arg_186_0 = ((other.accountTags_ != null) ? 1376422712u : 1668156851u);
					continue;
				case 8u:
					arg_186_0 = ((other.SubscriberId == 0uL) ? 770216484u : 689212049u);
					continue;
				case 9u:
					this.SubscriptionCompleted = other.SubscriptionCompleted;
					arg_186_0 = (num * 3648249310u ^ 2631901457u);
					continue;
				case 10u:
					this.accountTags_ = new AccountFieldTags();
					arg_186_0 = (num * 1000350336u ^ 2676707039u);
					continue;
				case 12u:
					arg_186_0 = (other.SubscriptionCompleted ? 325231383u : 602832621u);
					continue;
				case 13u:
					this.AccountState.MergeFrom(other.AccountState);
					arg_186_0 = 1258050909u;
					continue;
				case 14u:
					arg_186_0 = (((this.accountTags_ != null) ? 409758817u : 1680933831u) ^ num * 3028481462u);
					continue;
				}
				break;
			}
			return;
			IL_17C:
			arg_186_0 = 631106623u;
			goto IL_181;
			IL_1DE:
			arg_186_0 = ((other.accountState_ == null) ? 1258050909u : 1197228611u);
			goto IL_181;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_241:
				uint num;
				uint arg_1D9_0 = ((num = input.ReadTag()) == 0u) ? 223718952u : 707723924u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1D9_0 ^ 786966814u)) % 19u)
					{
					case 0u:
						arg_1D9_0 = 707723924u;
						continue;
					case 1u:
						arg_1D9_0 = (((num != 16u) ? 2868602504u : 3686041317u) ^ num2 * 4265199524u);
						continue;
					case 2u:
						input.ReadMessage(this.accountTags_);
						arg_1D9_0 = 1537448205u;
						continue;
					case 3u:
						this.SubscriberId = input.ReadUInt64();
						arg_1D9_0 = 565011238u;
						continue;
					case 4u:
						arg_1D9_0 = (num2 * 326853759u ^ 3805914699u);
						continue;
					case 5u:
						arg_1D9_0 = ((num == 26u) ? 1726827363u : 1726415958u);
						continue;
					case 6u:
						arg_1D9_0 = ((this.accountState_ == null) ? 1504343701u : 554284367u);
						continue;
					case 7u:
						arg_1D9_0 = (((num == 10u) ? 1070549462u : 593823753u) ^ num2 * 3415855201u);
						continue;
					case 9u:
						arg_1D9_0 = ((num <= 16u) ? 45972526u : 593337091u);
						continue;
					case 10u:
						this.accountState_ = new AccountState();
						arg_1D9_0 = (num2 * 3969661894u ^ 3339148237u);
						continue;
					case 11u:
						arg_1D9_0 = (((num == 32u) ? 4273302797u : 2662990140u) ^ num2 * 1929849425u);
						continue;
					case 12u:
						this.accountTags_ = new AccountFieldTags();
						arg_1D9_0 = (num2 * 3728087481u ^ 2892175646u);
						continue;
					case 13u:
						goto IL_241;
					case 14u:
						arg_1D9_0 = (num2 * 3290339208u ^ 2738424996u);
						continue;
					case 15u:
						this.SubscriptionCompleted = input.ReadBool();
						arg_1D9_0 = 565011238u;
						continue;
					case 16u:
						arg_1D9_0 = ((this.accountTags_ == null) ? 1571736044u : 626993660u);
						continue;
					case 17u:
						input.ReadMessage(this.accountState_);
						arg_1D9_0 = 565011238u;
						continue;
					case 18u:
						input.SkipLastField();
						arg_1D9_0 = 565011238u;
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
