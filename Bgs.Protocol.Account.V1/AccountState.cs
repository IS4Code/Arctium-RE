using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountState : IMessage<AccountState>, IEquatable<AccountState>, IDeepCloneable<AccountState>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountState.__c __9 = new AccountState.__c();

			internal AccountState cctor>b__49_0()
			{
				return new AccountState();
			}
		}

		private static readonly MessageParser<AccountState> _parser = new MessageParser<AccountState>(new Func<AccountState>(AccountState.__c.__9.<.cctor>b__49_0));

		public const int AccountLevelInfoFieldNumber = 1;

		private AccountLevelInfo accountLevelInfo_;

		public const int PrivacyInfoFieldNumber = 2;

		private PrivacyInfo privacyInfo_;

		public const int ParentalControlInfoFieldNumber = 3;

		private ParentalControlInfo parentalControlInfo_;

		public const int GameLevelInfoFieldNumber = 5;

		private static readonly FieldCodec<GameLevelInfo> _repeated_gameLevelInfo_codec;

		private readonly RepeatedField<GameLevelInfo> gameLevelInfo_ = new RepeatedField<GameLevelInfo>();

		public const int GameStatusFieldNumber = 6;

		private static readonly FieldCodec<GameStatus> _repeated_gameStatus_codec;

		private readonly RepeatedField<GameStatus> gameStatus_ = new RepeatedField<GameStatus>();

		public const int GameAccountsFieldNumber = 7;

		private static readonly FieldCodec<GameAccountList> _repeated_gameAccounts_codec;

		private readonly RepeatedField<GameAccountList> gameAccounts_ = new RepeatedField<GameAccountList>();

		public static MessageParser<AccountState> Parser
		{
			get
			{
				return AccountState._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[31];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountState.Descriptor;
			}
		}

		public AccountLevelInfo AccountLevelInfo
		{
			get
			{
				return this.accountLevelInfo_;
			}
			set
			{
				this.accountLevelInfo_ = value;
			}
		}

		public PrivacyInfo PrivacyInfo
		{
			get
			{
				return this.privacyInfo_;
			}
			set
			{
				this.privacyInfo_ = value;
			}
		}

		public ParentalControlInfo ParentalControlInfo
		{
			get
			{
				return this.parentalControlInfo_;
			}
			set
			{
				this.parentalControlInfo_ = value;
			}
		}

		public RepeatedField<GameLevelInfo> GameLevelInfo
		{
			get
			{
				return this.gameLevelInfo_;
			}
		}

		public RepeatedField<GameStatus> GameStatus
		{
			get
			{
				return this.gameStatus_;
			}
		}

		public RepeatedField<GameAccountList> GameAccounts
		{
			get
			{
				return this.gameAccounts_;
			}
		}

		public AccountState()
		{
		}

		public AccountState(AccountState other) : this()
		{
			while (true)
			{
				IL_E8:
				uint arg_C4_0 = 4095098660u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C4_0 ^ 4159821463u)) % 6u)
					{
					case 1u:
						this.AccountLevelInfo = ((other.accountLevelInfo_ != null) ? other.AccountLevelInfo.Clone() : null);
						arg_C4_0 = 4169425263u;
						continue;
					case 2u:
						this.PrivacyInfo = ((other.privacyInfo_ != null) ? other.PrivacyInfo.Clone() : null);
						this.ParentalControlInfo = ((other.parentalControlInfo_ != null) ? other.ParentalControlInfo.Clone() : null);
						arg_C4_0 = 2690478482u;
						continue;
					case 3u:
						this.gameAccounts_ = other.gameAccounts_.Clone();
						arg_C4_0 = (num * 3433705317u ^ 498004968u);
						continue;
					case 4u:
						goto IL_E8;
					case 5u:
						this.gameLevelInfo_ = other.gameLevelInfo_.Clone();
						this.gameStatus_ = other.gameStatus_.Clone();
						arg_C4_0 = (num * 435919684u ^ 2661650398u);
						continue;
					}
					return;
				}
			}
		}

		public AccountState Clone()
		{
			return new AccountState(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountState);
		}

		public bool Equals(AccountState other)
		{
			if (other == null)
			{
				goto IL_12C;
			}
			goto IL_194;
			int arg_136_0;
			while (true)
			{
				IL_131:
				switch ((arg_136_0 ^ 2060701848) % 17)
				{
				case 0:
					goto IL_12C;
				case 1:
					arg_136_0 = (this.gameLevelInfo_.Equals(other.gameLevelInfo_) ? 489614141 : 1456679652);
					continue;
				case 2:
					arg_136_0 = (this.gameStatus_.Equals(other.gameStatus_) ? 48586301 : 1369175565);
					continue;
				case 3:
					goto IL_194;
				case 4:
					arg_136_0 = (AccountState.smethod_0(this.PrivacyInfo, other.PrivacyInfo) ? 496124364 : 293523278);
					continue;
				case 5:
					arg_136_0 = (this.gameAccounts_.Equals(other.gameAccounts_) ? 704366730 : 2104000184);
					continue;
				case 6:
					arg_136_0 = (AccountState.smethod_0(this.ParentalControlInfo, other.ParentalControlInfo) ? 628970351 : 1381704038);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					return false;
				case 13:
					return false;
				case 14:
					return true;
				case 15:
					return false;
				case 16:
					arg_136_0 = ((!AccountState.smethod_0(this.AccountLevelInfo, other.AccountLevelInfo)) ? 363456967 : 1843060692);
					continue;
				}
				break;
			}
			return true;
			IL_12C:
			arg_136_0 = 772330075;
			goto IL_131;
			IL_194:
			arg_136_0 = ((other != this) ? 1686527314 : 889907864);
			goto IL_131;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.accountLevelInfo_ != null)
			{
				goto IL_1F;
			}
			goto IL_13D;
			uint arg_F9_0;
			while (true)
			{
				IL_F4:
				uint num2;
				switch ((num2 = (arg_F9_0 ^ 858300733u)) % 10u)
				{
				case 0u:
					num ^= AccountState.smethod_1(this.gameLevelInfo_);
					arg_F9_0 = 1343093066u;
					continue;
				case 1u:
					num ^= AccountState.smethod_1(this.AccountLevelInfo);
					arg_F9_0 = (num2 * 133391469u ^ 1491579659u);
					continue;
				case 2u:
					num ^= AccountState.smethod_1(this.gameAccounts_);
					arg_F9_0 = (num2 * 2543171533u ^ 1795449150u);
					continue;
				case 3u:
					num ^= AccountState.smethod_1(this.gameStatus_);
					arg_F9_0 = (num2 * 2537353669u ^ 1856999276u);
					continue;
				case 4u:
					arg_F9_0 = ((this.parentalControlInfo_ != null) ? 1588277138u : 571001273u);
					continue;
				case 6u:
					num ^= AccountState.smethod_1(this.PrivacyInfo);
					arg_F9_0 = (num2 * 928517509u ^ 2494542291u);
					continue;
				case 7u:
					num ^= AccountState.smethod_1(this.ParentalControlInfo);
					arg_F9_0 = (num2 * 3944224817u ^ 1929281222u);
					continue;
				case 8u:
					goto IL_1F;
				case 9u:
					goto IL_13D;
				}
				break;
			}
			return num;
			IL_1F:
			arg_F9_0 = 1772175260u;
			goto IL_F4;
			IL_13D:
			arg_F9_0 = ((this.privacyInfo_ == null) ? 381349801u : 1983461775u);
			goto IL_F4;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountLevelInfo_ != null)
			{
				goto IL_13E;
			}
			goto IL_198;
			uint arg_148_0;
			while (true)
			{
				IL_143:
				uint num;
				switch ((num = (arg_148_0 ^ 1019179035u)) % 13u)
				{
				case 0u:
					goto IL_13E;
				case 1u:
					output.WriteRawTag(10);
					arg_148_0 = (num * 3474309694u ^ 108147650u);
					continue;
				case 3u:
					this.gameStatus_.WriteTo(output, AccountState._repeated_gameStatus_codec);
					arg_148_0 = (num * 4182054683u ^ 3847171073u);
					continue;
				case 4u:
					output.WriteMessage(this.ParentalControlInfo);
					arg_148_0 = (num * 3644494079u ^ 818843887u);
					continue;
				case 5u:
					arg_148_0 = ((this.parentalControlInfo_ != null) ? 374672398u : 409284353u);
					continue;
				case 6u:
					goto IL_198;
				case 7u:
					output.WriteMessage(this.PrivacyInfo);
					arg_148_0 = (num * 1978443294u ^ 3712316602u);
					continue;
				case 8u:
					output.WriteMessage(this.AccountLevelInfo);
					arg_148_0 = (num * 1081399314u ^ 4221118931u);
					continue;
				case 9u:
					output.WriteRawTag(26);
					arg_148_0 = (num * 3562696388u ^ 3934323741u);
					continue;
				case 10u:
					output.WriteRawTag(18);
					arg_148_0 = (num * 468144005u ^ 3688701138u);
					continue;
				case 11u:
					this.gameLevelInfo_.WriteTo(output, AccountState._repeated_gameLevelInfo_codec);
					arg_148_0 = 603307683u;
					continue;
				case 12u:
					this.gameAccounts_.WriteTo(output, AccountState._repeated_gameAccounts_codec);
					arg_148_0 = (num * 2067362358u ^ 3602184260u);
					continue;
				}
				break;
			}
			return;
			IL_13E:
			arg_148_0 = 767897673u;
			goto IL_143;
			IL_198:
			arg_148_0 = ((this.privacyInfo_ == null) ? 1217343074u : 496861346u);
			goto IL_143;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_178:
				uint arg_13F_0 = 3948166717u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_13F_0 ^ 2851058918u)) % 11u)
					{
					case 0u:
						num += this.gameAccounts_.CalculateSize(AccountState._repeated_gameAccounts_codec);
						arg_13F_0 = (num2 * 4005963251u ^ 1043624097u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountLevelInfo);
						arg_13F_0 = (num2 * 1148545510u ^ 3011934177u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ParentalControlInfo);
						arg_13F_0 = (num2 * 3946096677u ^ 3080580877u);
						continue;
					case 4u:
						num += this.gameStatus_.CalculateSize(AccountState._repeated_gameStatus_codec);
						arg_13F_0 = (num2 * 3905641022u ^ 2491584407u);
						continue;
					case 5u:
						arg_13F_0 = ((this.parentalControlInfo_ != null) ? 2621622236u : 2364168303u);
						continue;
					case 6u:
						arg_13F_0 = (((this.accountLevelInfo_ != null) ? 4042825362u : 3972615586u) ^ num2 * 2746292831u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.PrivacyInfo);
						arg_13F_0 = (num2 * 2179950553u ^ 830731462u);
						continue;
					case 8u:
						num += this.gameLevelInfo_.CalculateSize(AccountState._repeated_gameLevelInfo_codec);
						arg_13F_0 = 3672012604u;
						continue;
					case 9u:
						goto IL_178;
					case 10u:
						arg_13F_0 = ((this.privacyInfo_ == null) ? 3440404892u : 3232836876u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountState other)
		{
			if (other == null)
			{
				goto IL_194;
			}
			goto IL_239;
			uint arg_1D9_0;
			while (true)
			{
				IL_1D4:
				uint num;
				switch ((num = (arg_1D9_0 ^ 1155377202u)) % 17u)
				{
				case 0u:
					this.privacyInfo_ = new PrivacyInfo();
					arg_1D9_0 = (num * 923275810u ^ 3351838457u);
					continue;
				case 1u:
					arg_1D9_0 = ((other.privacyInfo_ == null) ? 613495036u : 961247606u);
					continue;
				case 2u:
					goto IL_194;
				case 3u:
					arg_1D9_0 = ((other.parentalControlInfo_ == null) ? 1158445590u : 855401552u);
					continue;
				case 4u:
					this.accountLevelInfo_ = new AccountLevelInfo();
					arg_1D9_0 = (num * 2759583294u ^ 2410301205u);
					continue;
				case 6u:
					this.gameStatus_.Add(other.gameStatus_);
					this.gameAccounts_.Add(other.gameAccounts_);
					arg_1D9_0 = (num * 1894520436u ^ 2876902055u);
					continue;
				case 7u:
					goto IL_239;
				case 8u:
					arg_1D9_0 = (((this.privacyInfo_ != null) ? 1179354353u : 1082142622u) ^ num * 3430276012u);
					continue;
				case 9u:
					this.PrivacyInfo.MergeFrom(other.PrivacyInfo);
					arg_1D9_0 = 613495036u;
					continue;
				case 10u:
					arg_1D9_0 = (((this.accountLevelInfo_ != null) ? 3937761095u : 2876663576u) ^ num * 1648162826u);
					continue;
				case 11u:
					arg_1D9_0 = (((this.parentalControlInfo_ == null) ? 3091897255u : 2705505050u) ^ num * 3657814059u);
					continue;
				case 12u:
					return;
				case 13u:
					this.ParentalControlInfo.MergeFrom(other.ParentalControlInfo);
					arg_1D9_0 = 1158445590u;
					continue;
				case 14u:
					this.gameLevelInfo_.Add(other.gameLevelInfo_);
					arg_1D9_0 = 98381713u;
					continue;
				case 15u:
					this.parentalControlInfo_ = new ParentalControlInfo();
					arg_1D9_0 = (num * 367187660u ^ 550323592u);
					continue;
				case 16u:
					this.AccountLevelInfo.MergeFrom(other.AccountLevelInfo);
					arg_1D9_0 = 1899855211u;
					continue;
				}
				break;
			}
			return;
			IL_194:
			arg_1D9_0 = 599605446u;
			goto IL_1D4;
			IL_239:
			arg_1D9_0 = ((other.accountLevelInfo_ == null) ? 1899855211u : 2102098927u);
			goto IL_1D4;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_343:
				uint num;
				uint arg_2BF_0 = ((num = input.ReadTag()) == 0u) ? 85920499u : 1118167655u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2BF_0 ^ 1619666317u)) % 26u)
					{
					case 0u:
						this.privacyInfo_ = new PrivacyInfo();
						arg_2BF_0 = (num2 * 493338640u ^ 4187704633u);
						continue;
					case 1u:
						arg_2BF_0 = (((num == 18u) ? 352501504u : 1352202853u) ^ num2 * 2987258808u);
						continue;
					case 2u:
						goto IL_343;
					case 3u:
						this.accountLevelInfo_ = new AccountLevelInfo();
						arg_2BF_0 = (num2 * 1573213724u ^ 1325384074u);
						continue;
					case 4u:
						arg_2BF_0 = (((num == 10u) ? 1691212778u : 1060895560u) ^ num2 * 1789704072u);
						continue;
					case 5u:
						arg_2BF_0 = ((this.accountLevelInfo_ != null) ? 1150686030u : 7821194u);
						continue;
					case 6u:
						arg_2BF_0 = (((num == 50u) ? 3904078924u : 2216681928u) ^ num2 * 2304428609u);
						continue;
					case 7u:
						this.parentalControlInfo_ = new ParentalControlInfo();
						arg_2BF_0 = (num2 * 1819338085u ^ 3538897381u);
						continue;
					case 8u:
						arg_2BF_0 = 1118167655u;
						continue;
					case 9u:
						input.SkipLastField();
						arg_2BF_0 = 1370929021u;
						continue;
					case 10u:
						arg_2BF_0 = (num2 * 3475401536u ^ 210612096u);
						continue;
					case 11u:
						arg_2BF_0 = ((this.privacyInfo_ != null) ? 229752825u : 1525381793u);
						continue;
					case 12u:
						arg_2BF_0 = ((num != 42u) ? 1190092665u : 2116225456u);
						continue;
					case 13u:
						arg_2BF_0 = ((this.parentalControlInfo_ == null) ? 2073960718u : 114409290u);
						continue;
					case 14u:
						this.gameAccounts_.AddEntriesFrom(input, AccountState._repeated_gameAccounts_codec);
						arg_2BF_0 = 1370929021u;
						continue;
					case 15u:
						arg_2BF_0 = (((num != 58u) ? 2053296849u : 1868243464u) ^ num2 * 2030782625u);
						continue;
					case 16u:
						arg_2BF_0 = ((num > 26u) ? 502229495u : 609128027u);
						continue;
					case 17u:
						arg_2BF_0 = (num2 * 3199965241u ^ 2108701834u);
						continue;
					case 19u:
						this.gameLevelInfo_.AddEntriesFrom(input, AccountState._repeated_gameLevelInfo_codec);
						arg_2BF_0 = 1370929021u;
						continue;
					case 20u:
						input.ReadMessage(this.privacyInfo_);
						arg_2BF_0 = 773406754u;
						continue;
					case 21u:
						input.ReadMessage(this.accountLevelInfo_);
						arg_2BF_0 = 1370929021u;
						continue;
					case 22u:
						arg_2BF_0 = (((num != 26u) ? 3908113249u : 3429724500u) ^ num2 * 3201137396u);
						continue;
					case 23u:
						input.ReadMessage(this.parentalControlInfo_);
						arg_2BF_0 = 1538787105u;
						continue;
					case 24u:
						arg_2BF_0 = (num2 * 1756578868u ^ 605949325u);
						continue;
					case 25u:
						this.gameStatus_.AddEntriesFrom(input, AccountState._repeated_gameStatus_codec);
						arg_2BF_0 = 1370929021u;
						continue;
					}
					return;
				}
			}
		}

		static AccountState()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_8C:
				uint arg_70_0 = 2762582830u;
				while (true)
				{
					uint num;
					switch ((num = (arg_70_0 ^ 3434660607u)) % 4u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
						AccountState._repeated_gameLevelInfo_codec = FieldCodec.ForMessage<GameLevelInfo>(42u, Bgs.Protocol.Account.V1.GameLevelInfo.Parser);
						AccountState._repeated_gameStatus_codec = FieldCodec.ForMessage<GameStatus>(50u, Bgs.Protocol.Account.V1.GameStatus.Parser);
						arg_70_0 = (num * 2588780232u ^ 3050507101u);
						continue;
					case 2u:
						AccountState._repeated_gameAccounts_codec = FieldCodec.ForMessage<GameAccountList>(58u, GameAccountList.Parser);
						arg_70_0 = (num * 1726540113u ^ 1814928050u);
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
