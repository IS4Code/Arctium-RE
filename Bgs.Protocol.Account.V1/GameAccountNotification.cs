using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountNotification : IMessage<GameAccountNotification>, IEquatable<GameAccountNotification>, IDeepCloneable<GameAccountNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountNotification.__c __9 = new GameAccountNotification.__c();

			internal GameAccountNotification cctor>b__34_0()
			{
				return new GameAccountNotification();
			}
		}

		private static readonly MessageParser<GameAccountNotification> _parser = new MessageParser<GameAccountNotification>(new Func<GameAccountNotification>(GameAccountNotification.__c.__9.<.cctor>b__34_0));

		public const int GameAccountsFieldNumber = 1;

		private static readonly FieldCodec<GameAccountList> _repeated_gameAccounts_codec = FieldCodec.ForMessage<GameAccountList>(10u, GameAccountList.Parser);

		private readonly RepeatedField<GameAccountList> gameAccounts_ = new RepeatedField<GameAccountList>();

		public const int SubscriberIdFieldNumber = 2;

		private ulong subscriberId_;

		public const int AccountTagsFieldNumber = 3;

		private AccountFieldTags accountTags_;

		public static MessageParser<GameAccountNotification> Parser
		{
			get
			{
				return GameAccountNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[30];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountNotification.Descriptor;
			}
		}

		public RepeatedField<GameAccountList> GameAccounts
		{
			get
			{
				return this.gameAccounts_;
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

		public GameAccountNotification()
		{
		}

		public GameAccountNotification(GameAccountNotification other) : this()
		{
			while (true)
			{
				IL_8C:
				uint arg_6C_0 = 3156026932u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6C_0 ^ 3355392972u)) % 5u)
					{
					case 0u:
						this.AccountTags = ((other.accountTags_ != null) ? other.AccountTags.Clone() : null);
						arg_6C_0 = 2567910298u;
						continue;
					case 1u:
						this.gameAccounts_ = other.gameAccounts_.Clone();
						arg_6C_0 = (num * 2786717402u ^ 4256522247u);
						continue;
					case 2u:
						goto IL_8C;
					case 4u:
						this.subscriberId_ = other.subscriberId_;
						arg_6C_0 = (num * 2741200037u ^ 276837260u);
						continue;
					}
					return;
				}
			}
		}

		public GameAccountNotification Clone()
		{
			return new GameAccountNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountNotification);
		}

		public bool Equals(GameAccountNotification other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ 1441644622) % 11)
				{
				case 0:
					goto IL_E7;
				case 1:
					arg_A1_0 = ((this.SubscriberId != other.SubscriberId) ? 1345436352 : 1341206777);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					arg_A1_0 = ((!this.gameAccounts_.Equals(other.gameAccounts_)) ? 2028828355 : 535982198);
					continue;
				case 7:
					goto IL_44;
				case 9:
					arg_A1_0 = ((!GameAccountNotification.smethod_0(this.AccountTags, other.AccountTags)) ? 530250395 : 1021263032);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_44:
			arg_A1_0 = 1622529318;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other == this) ? 998950542 : 1302423683);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ GameAccountNotification.smethod_1(this.gameAccounts_);
			while (true)
			{
				IL_C3:
				uint arg_9F_0 = 195535321u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9F_0 ^ 1696632677u)) % 6u)
					{
					case 0u:
						goto IL_C3;
					case 1u:
						num ^= this.SubscriberId.GetHashCode();
						arg_9F_0 = (num2 * 2538937218u ^ 3117959356u);
						continue;
					case 2u:
						arg_9F_0 = (((this.SubscriberId == 0uL) ? 441672430u : 911834778u) ^ num2 * 2473003287u);
						continue;
					case 3u:
						num ^= this.AccountTags.GetHashCode();
						arg_9F_0 = (num2 * 3446521120u ^ 2415370261u);
						continue;
					case 5u:
						arg_9F_0 = ((this.accountTags_ != null) ? 256186630u : 337068917u);
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
			this.gameAccounts_.WriteTo(output, GameAccountNotification._repeated_gameAccounts_codec);
			while (true)
			{
				IL_F6:
				uint arg_CA_0 = 2427893373u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CA_0 ^ 2548232563u)) % 8u)
					{
					case 0u:
						output.WriteRawTag(16);
						arg_CA_0 = (num * 822328998u ^ 3288494458u);
						continue;
					case 1u:
						output.WriteUInt64(this.SubscriberId);
						arg_CA_0 = (num * 4210450285u ^ 3573259050u);
						continue;
					case 2u:
						goto IL_F6;
					case 4u:
						arg_CA_0 = ((this.accountTags_ != null) ? 3073229388u : 3185945304u);
						continue;
					case 5u:
						output.WriteMessage(this.AccountTags);
						arg_CA_0 = (num * 2438641065u ^ 4242631901u);
						continue;
					case 6u:
						arg_CA_0 = (((this.SubscriberId == 0uL) ? 1291212133u : 275388577u) ^ num * 2651095043u);
						continue;
					case 7u:
						output.WriteRawTag(26);
						arg_CA_0 = (num * 4115463995u ^ 2224189195u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + this.gameAccounts_.CalculateSize(GameAccountNotification._repeated_gameAccounts_codec);
			while (true)
			{
				IL_C9:
				uint arg_A5_0 = 3619736014u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A5_0 ^ 3646794951u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
						arg_A5_0 = (num2 * 2285208111u ^ 137759434u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
						arg_A5_0 = (num2 * 2830483450u ^ 1397184197u);
						continue;
					case 2u:
						arg_A5_0 = ((this.accountTags_ != null) ? 3104892331u : 2296600606u);
						continue;
					case 4u:
						goto IL_C9;
					case 5u:
						arg_A5_0 = (((this.SubscriberId == 0uL) ? 4153716145u : 3421973330u) ^ num2 * 4157751666u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountNotification other)
		{
			if (other == null)
			{
				goto IL_B2;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 2067291274u)) % 9u)
				{
				case 0u:
					goto IL_B2;
				case 1u:
					this.accountTags_ = new AccountFieldTags();
					arg_BC_0 = (num * 4028128559u ^ 4198986258u);
					continue;
				case 2u:
					goto IL_FC;
				case 3u:
					this.AccountTags.MergeFrom(other.AccountTags);
					arg_BC_0 = 26662401u;
					continue;
				case 4u:
					arg_BC_0 = ((other.accountTags_ == null) ? 26662401u : 1354610101u);
					continue;
				case 5u:
					this.SubscriberId = other.SubscriberId;
					arg_BC_0 = (num * 2553063922u ^ 3597816647u);
					continue;
				case 7u:
					arg_BC_0 = (((this.accountTags_ == null) ? 3678852372u : 2634547152u) ^ num * 3753448436u);
					continue;
				case 8u:
					return;
				}
				break;
			}
			return;
			IL_B2:
			arg_BC_0 = 1542320813u;
			goto IL_B7;
			IL_FC:
			this.gameAccounts_.Add(other.gameAccounts_);
			arg_BC_0 = ((other.SubscriberId == 0uL) ? 1393249771u : 1327145228u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_19F:
				uint num;
				uint arg_14B_0 = ((num = input.ReadTag()) != 0u) ? 3448790845u : 3544170873u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_14B_0 ^ 2937366410u)) % 14u)
					{
					case 0u:
						input.SkipLastField();
						arg_14B_0 = (num2 * 1544542036u ^ 1790475515u);
						continue;
					case 1u:
						arg_14B_0 = (((num != 16u) ? 3561439285u : 2223309890u) ^ num2 * 2426810141u);
						continue;
					case 2u:
						this.accountTags_ = new AccountFieldTags();
						arg_14B_0 = (num2 * 346672283u ^ 4072811624u);
						continue;
					case 3u:
						this.SubscriberId = input.ReadUInt64();
						arg_14B_0 = 3951520604u;
						continue;
					case 4u:
						arg_14B_0 = ((this.accountTags_ == null) ? 4278473958u : 3964362252u);
						continue;
					case 5u:
						this.gameAccounts_.AddEntriesFrom(input, GameAccountNotification._repeated_gameAccounts_codec);
						arg_14B_0 = 2294389510u;
						continue;
					case 6u:
						arg_14B_0 = (num2 * 2098680788u ^ 1390741339u);
						continue;
					case 8u:
						input.ReadMessage(this.accountTags_);
						arg_14B_0 = 3387688035u;
						continue;
					case 9u:
						arg_14B_0 = 3448790845u;
						continue;
					case 10u:
						arg_14B_0 = (((num == 26u) ? 3507585906u : 3978436600u) ^ num2 * 4126197735u);
						continue;
					case 11u:
						arg_14B_0 = ((num != 10u) ? 3852267293u : 3533255191u);
						continue;
					case 12u:
						arg_14B_0 = (num2 * 1354973241u ^ 3316481871u);
						continue;
					case 13u:
						goto IL_19F;
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
