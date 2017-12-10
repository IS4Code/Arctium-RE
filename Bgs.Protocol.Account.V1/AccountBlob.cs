using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountBlob : IMessage<AccountBlob>, IEquatable<AccountBlob>, IDeepCloneable<AccountBlob>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountBlob.__c __9 = new AccountBlob.__c();

			internal AccountBlob cctor>b__119_0()
			{
				return new AccountBlob();
			}
		}

		private static readonly MessageParser<AccountBlob> _parser = new MessageParser<AccountBlob>(new Func<AccountBlob>(AccountBlob.__c.__9.<.cctor>b__119_0));

		public const int IdFieldNumber = 2;

		private uint id_;

		public const int RegionFieldNumber = 3;

		private uint region_;

		public const int EmailFieldNumber = 4;

		private static readonly FieldCodec<string> _repeated_email_codec;

		private readonly RepeatedField<string> email_ = new RepeatedField<string>();

		public const int FlagsFieldNumber = 5;

		private ulong flags_;

		public const int SecureReleaseFieldNumber = 6;

		private ulong secureRelease_;

		public const int WhitelistStartFieldNumber = 7;

		private ulong whitelistStart_;

		public const int WhitelistEndFieldNumber = 8;

		private ulong whitelistEnd_;

		public const int FullNameFieldNumber = 10;

		private string fullName_ = "";

		public const int LicensesFieldNumber = 20;

		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec;

		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		public const int CredentialsFieldNumber = 21;

		private static readonly FieldCodec<AccountCredential> _repeated_credentials_codec;

		private readonly RepeatedField<AccountCredential> credentials_ = new RepeatedField<AccountCredential>();

		public const int AccountLinksFieldNumber = 22;

		private static readonly FieldCodec<GameAccountLink> _repeated_accountLinks_codec;

		private readonly RepeatedField<GameAccountLink> accountLinks_ = new RepeatedField<GameAccountLink>();

		public const int BattleTagFieldNumber = 23;

		private string battleTag_ = "";

		public const int DefaultCurrencyFieldNumber = 25;

		private uint defaultCurrency_;

		public const int LegalRegionFieldNumber = 26;

		private uint legalRegion_;

		public const int LegalLocaleFieldNumber = 27;

		private uint legalLocale_;

		public const int CacheExpirationFieldNumber = 30;

		private ulong cacheExpiration_;

		public const int ParentalControlInfoFieldNumber = 31;

		private ParentalControlInfo parentalControlInfo_;

		public const int CountryFieldNumber = 32;

		private string country_ = "";

		public const int PreferredRegionFieldNumber = 33;

		private uint preferredRegion_;

		public const int IdentityCheckStatusFieldNumber = 34;

		private IdentityVerificationStatus identityCheckStatus_;

		public static MessageParser<AccountBlob> Parser
		{
			get
			{
				return AccountBlob._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountBlob.Descriptor;
			}
		}

		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		public uint Region
		{
			get
			{
				return this.region_;
			}
			set
			{
				this.region_ = value;
			}
		}

		public RepeatedField<string> Email
		{
			get
			{
				return this.email_;
			}
		}

		public ulong Flags
		{
			get
			{
				return this.flags_;
			}
			set
			{
				this.flags_ = value;
			}
		}

		public ulong SecureRelease
		{
			get
			{
				return this.secureRelease_;
			}
			set
			{
				this.secureRelease_ = value;
			}
		}

		public ulong WhitelistStart
		{
			get
			{
				return this.whitelistStart_;
			}
			set
			{
				this.whitelistStart_ = value;
			}
		}

		public ulong WhitelistEnd
		{
			get
			{
				return this.whitelistEnd_;
			}
			set
			{
				this.whitelistEnd_ = value;
			}
		}

		public string FullName
		{
			get
			{
				return this.fullName_;
			}
			set
			{
				this.fullName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		public RepeatedField<AccountCredential> Credentials
		{
			get
			{
				return this.credentials_;
			}
		}

		public RepeatedField<GameAccountLink> AccountLinks
		{
			get
			{
				return this.accountLinks_;
			}
		}

		public string BattleTag
		{
			get
			{
				return this.battleTag_;
			}
			set
			{
				this.battleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public uint DefaultCurrency
		{
			get
			{
				return this.defaultCurrency_;
			}
			set
			{
				this.defaultCurrency_ = value;
			}
		}

		public uint LegalRegion
		{
			get
			{
				return this.legalRegion_;
			}
			set
			{
				this.legalRegion_ = value;
			}
		}

		public uint LegalLocale
		{
			get
			{
				return this.legalLocale_;
			}
			set
			{
				this.legalLocale_ = value;
			}
		}

		public ulong CacheExpiration
		{
			get
			{
				return this.cacheExpiration_;
			}
			set
			{
				this.cacheExpiration_ = value;
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

		public string Country
		{
			get
			{
				return this.country_;
			}
			set
			{
				this.country_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public uint PreferredRegion
		{
			get
			{
				return this.preferredRegion_;
			}
			set
			{
				this.preferredRegion_ = value;
			}
		}

		public IdentityVerificationStatus IdentityCheckStatus
		{
			get
			{
				return this.identityCheckStatus_;
			}
			set
			{
				this.identityCheckStatus_ = value;
			}
		}

		public AccountBlob()
		{
		}

		public AccountBlob(AccountBlob other) : this()
		{
			this.id_ = other.id_;
			this.region_ = other.region_;
			this.email_ = other.email_.Clone();
			this.flags_ = other.flags_;
			this.secureRelease_ = other.secureRelease_;
			this.whitelistStart_ = other.whitelistStart_;
			this.whitelistEnd_ = other.whitelistEnd_;
			this.fullName_ = other.fullName_;
			this.licenses_ = other.licenses_.Clone();
			this.credentials_ = other.credentials_.Clone();
			this.accountLinks_ = other.accountLinks_.Clone();
			this.battleTag_ = other.battleTag_;
			this.defaultCurrency_ = other.defaultCurrency_;
			this.legalRegion_ = other.legalRegion_;
			this.legalLocale_ = other.legalLocale_;
			this.cacheExpiration_ = other.cacheExpiration_;
			this.ParentalControlInfo = ((other.parentalControlInfo_ != null) ? other.ParentalControlInfo.Clone() : null);
			this.country_ = other.country_;
			this.preferredRegion_ = other.preferredRegion_;
			this.identityCheckStatus_ = other.identityCheckStatus_;
		}

		public AccountBlob Clone()
		{
			return new AccountBlob(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountBlob);
		}

		public bool Equals(AccountBlob other)
		{
			if (other == null)
			{
				goto IL_126;
			}
			goto IL_45A;
			int arg_38C_0;
			while (true)
			{
				IL_387:
				switch ((arg_38C_0 ^ -1200363076) % 45)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_38C_0 = ((this.Id == other.Id) ? -1224329605 : -2135525418);
					continue;
				case 3:
					arg_38C_0 = ((this.CacheExpiration == other.CacheExpiration) ? -1906932394 : -388874448);
					continue;
				case 4:
					arg_38C_0 = (this.licenses_.Equals(other.licenses_) ? -1675547373 : -36645230);
					continue;
				case 5:
					return false;
				case 6:
					arg_38C_0 = (this.accountLinks_.Equals(other.accountLinks_) ? -441978422 : -1021279662);
					continue;
				case 7:
					arg_38C_0 = ((this.WhitelistStart != other.WhitelistStart) ? -1048489659 : -178944273);
					continue;
				case 8:
					arg_38C_0 = ((this.Flags == other.Flags) ? -1544877537 : -1288032780);
					continue;
				case 9:
					return false;
				case 10:
					arg_38C_0 = ((this.LegalLocale == other.LegalLocale) ? -863119542 : -1101436065);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					arg_38C_0 = ((this.PreferredRegion == other.PreferredRegion) ? -1254682528 : -1625296951);
					continue;
				case 18:
					arg_38C_0 = ((this.DefaultCurrency != other.DefaultCurrency) ? -1612172993 : -946934837);
					continue;
				case 19:
					goto IL_45A;
				case 20:
					return false;
				case 21:
					arg_38C_0 = (this.email_.Equals(other.email_) ? -1436423900 : -354559710);
					continue;
				case 22:
					return false;
				case 23:
					return false;
				case 24:
					arg_38C_0 = ((this.WhitelistEnd == other.WhitelistEnd) ? -1027978882 : -1840272812);
					continue;
				case 25:
					return false;
				case 26:
					return false;
				case 27:
					arg_38C_0 = ((!AccountBlob.smethod_0(this.BattleTag, other.BattleTag)) ? -2014487546 : -957232459);
					continue;
				case 28:
					return false;
				case 29:
					arg_38C_0 = ((this.SecureRelease != other.SecureRelease) ? -935020111 : -949578423);
					continue;
				case 30:
					return false;
				case 31:
					return false;
				case 32:
					arg_38C_0 = ((!AccountBlob.smethod_0(this.FullName, other.FullName)) ? -2021096718 : -1727984967);
					continue;
				case 33:
					return true;
				case 34:
					return false;
				case 35:
					goto IL_126;
				case 36:
					arg_38C_0 = ((this.LegalRegion == other.LegalRegion) ? -1731393479 : -1016004849);
					continue;
				case 37:
					return false;
				case 38:
					arg_38C_0 = ((!AccountBlob.smethod_0(this.Country, other.Country)) ? -24387461 : -1229440748);
					continue;
				case 39:
					arg_38C_0 = (this.credentials_.Equals(other.credentials_) ? -2142429148 : -59460220);
					continue;
				case 40:
					arg_38C_0 = ((this.IdentityCheckStatus == other.IdentityCheckStatus) ? -1815148769 : -1520131431);
					continue;
				case 41:
					return false;
				case 42:
					return false;
				case 43:
					arg_38C_0 = (AccountBlob.smethod_1(this.ParentalControlInfo, other.ParentalControlInfo) ? -1077205561 : -984855479);
					continue;
				case 44:
					arg_38C_0 = ((this.Region != other.Region) ? -628427914 : -908751700);
					continue;
				}
				break;
			}
			return true;
			IL_126:
			arg_38C_0 = -1525201819;
			goto IL_387;
			IL_45A:
			arg_38C_0 = ((other != this) ? -1021896462 : -1211617331);
			goto IL_387;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ this.Id.GetHashCode();
			while (true)
			{
				IL_4C7:
				uint arg_441_0 = 3013042398u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_441_0 ^ 2692387657u)) % 30u)
					{
					case 0u:
						num ^= this.LegalLocale.GetHashCode();
						arg_441_0 = (num2 * 4129555494u ^ 2263006275u);
						continue;
					case 1u:
						num ^= this.ParentalControlInfo.GetHashCode();
						arg_441_0 = (num2 * 1536706005u ^ 1252606332u);
						continue;
					case 2u:
						num ^= this.LegalRegion.GetHashCode();
						arg_441_0 = (num2 * 63119484u ^ 3653923676u);
						continue;
					case 3u:
						arg_441_0 = ((this.DefaultCurrency != 0u) ? 3304593763u : 3642868005u);
						continue;
					case 4u:
						arg_441_0 = ((this.Country.Length == 0) ? 3750640948u : 3488255385u);
						continue;
					case 5u:
						num ^= this.Region.GetHashCode();
						arg_441_0 = (num2 * 1399015272u ^ 3031052914u);
						continue;
					case 6u:
						num ^= this.BattleTag.GetHashCode();
						arg_441_0 = (num2 * 615033u ^ 3970595212u);
						continue;
					case 7u:
						num ^= this.IdentityCheckStatus.GetHashCode();
						arg_441_0 = (num2 * 560866675u ^ 54204086u);
						continue;
					case 8u:
						arg_441_0 = ((this.parentalControlInfo_ != null) ? 2951652006u : 3355686823u);
						continue;
					case 9u:
						num ^= this.email_.GetHashCode();
						arg_441_0 = (((this.Flags == 0uL) ? 2528408619u : 4177192849u) ^ num2 * 1480440034u);
						continue;
					case 10u:
						num ^= this.PreferredRegion.GetHashCode();
						arg_441_0 = (num2 * 1479898820u ^ 3858666224u);
						continue;
					case 11u:
						arg_441_0 = (((this.BattleTag.Length != 0) ? 2564967559u : 3600297426u) ^ num2 * 2838145952u);
						continue;
					case 12u:
						arg_441_0 = ((this.LegalRegion != 0u) ? 2418711957u : 2549924300u);
						continue;
					case 13u:
						num ^= this.CacheExpiration.GetHashCode();
						arg_441_0 = (num2 * 4149524530u ^ 4022336105u);
						continue;
					case 15u:
						goto IL_4C7;
					case 16u:
						arg_441_0 = ((this.SecureRelease != 0uL) ? 2201882540u : 3973403390u);
						continue;
					case 17u:
						num ^= this.WhitelistStart.GetHashCode();
						arg_441_0 = (num2 * 1007312207u ^ 3612367670u);
						continue;
					case 18u:
						num ^= this.FullName.GetHashCode();
						num ^= this.licenses_.GetHashCode();
						num ^= this.credentials_.GetHashCode();
						num ^= this.accountLinks_.GetHashCode();
						arg_441_0 = 2523989514u;
						continue;
					case 19u:
						arg_441_0 = ((this.IdentityCheckStatus == IdentityVerificationStatus.IDENT_NO_DATA) ? 2813061045u : 4289278328u);
						continue;
					case 20u:
						num ^= this.DefaultCurrency.GetHashCode();
						arg_441_0 = (num2 * 1236212886u ^ 1097747897u);
						continue;
					case 21u:
						num ^= this.WhitelistEnd.GetHashCode();
						arg_441_0 = (num2 * 3187394532u ^ 3087869811u);
						continue;
					case 22u:
						arg_441_0 = ((this.WhitelistEnd == 0uL) ? 2426573527u : 3321438648u);
						continue;
					case 23u:
						num ^= this.SecureRelease.GetHashCode();
						arg_441_0 = (num2 * 719687330u ^ 2812156948u);
						continue;
					case 24u:
						num ^= this.Flags.GetHashCode();
						arg_441_0 = (num2 * 2088716105u ^ 3390050403u);
						continue;
					case 25u:
						arg_441_0 = ((this.PreferredRegion != 0u) ? 3130627783u : 3577423432u);
						continue;
					case 26u:
						arg_441_0 = ((this.CacheExpiration != 0uL) ? 3328261502u : 4262753495u);
						continue;
					case 27u:
						arg_441_0 = ((this.WhitelistStart != 0uL) ? 2342837154u : 3759375539u);
						continue;
					case 28u:
						num ^= this.Country.GetHashCode();
						arg_441_0 = (num2 * 4107922145u ^ 4155181540u);
						continue;
					case 29u:
						arg_441_0 = ((this.LegalLocale == 0u) ? 3451370835u : 4105362705u);
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
			output.WriteRawTag(21);
			output.WriteFixed32(this.Id);
			output.WriteRawTag(24);
			output.WriteUInt32(this.Region);
			this.email_.WriteTo(output, AccountBlob._repeated_email_codec);
			if (this.Flags != 0uL)
			{
				goto IL_2E1;
			}
			goto IL_5EC;
			uint arg_530_0;
			while (true)
			{
				IL_52B:
				uint num;
				switch ((num = (arg_530_0 ^ 2108070602u)) % 40u)
				{
				case 0u:
					output.WriteUInt64(this.SecureRelease);
					arg_530_0 = (num * 4193309314u ^ 2085740271u);
					continue;
				case 1u:
					output.WriteFixed32(this.LegalLocale);
					arg_530_0 = (num * 165178996u ^ 3730388844u);
					continue;
				case 2u:
					arg_530_0 = ((this.CacheExpiration == 0uL) ? 1852818854u : 1438425611u);
					continue;
				case 3u:
					output.WriteRawTag(144, 2);
					arg_530_0 = (num * 582318648u ^ 3529828865u);
					continue;
				case 4u:
					output.WriteRawTag(250, 1);
					arg_530_0 = (num * 4248877239u ^ 4021264781u);
					continue;
				case 5u:
					output.WriteUInt32(this.PreferredRegion);
					arg_530_0 = (num * 1661660477u ^ 1728764517u);
					continue;
				case 6u:
					this.licenses_.WriteTo(output, AccountBlob._repeated_licenses_codec);
					arg_530_0 = (num * 1584457161u ^ 532659334u);
					continue;
				case 7u:
					output.WriteUInt32(this.LegalRegion);
					arg_530_0 = (num * 715448001u ^ 3095664973u);
					continue;
				case 8u:
					arg_530_0 = ((this.LegalLocale == 0u) ? 968414296u : 1227913398u);
					continue;
				case 9u:
					arg_530_0 = ((this.LegalRegion == 0u) ? 1737326786u : 1862340865u);
					continue;
				case 10u:
					this.credentials_.WriteTo(output, AccountBlob._repeated_credentials_codec);
					this.accountLinks_.WriteTo(output, AccountBlob._repeated_accountLinks_codec);
					arg_530_0 = (num * 2496588039u ^ 4283565913u);
					continue;
				case 11u:
					arg_530_0 = ((this.PreferredRegion == 0u) ? 1694235428u : 1695999931u);
					continue;
				case 12u:
					output.WriteRawTag(221, 1);
					arg_530_0 = (num * 3932620193u ^ 1168114631u);
					continue;
				case 13u:
					output.WriteString(this.BattleTag);
					arg_530_0 = (num * 3229949352u ^ 3705927300u);
					continue;
				case 14u:
					arg_530_0 = ((this.DefaultCurrency == 0u) ? 1977134003u : 453084140u);
					continue;
				case 15u:
					output.WriteRawTag(82);
					arg_530_0 = 2144564558u;
					continue;
				case 16u:
					output.WriteRawTag(64);
					output.WriteUInt64(this.WhitelistEnd);
					arg_530_0 = (num * 1839653871u ^ 1819331381u);
					continue;
				case 17u:
					output.WriteRawTag(186, 1);
					arg_530_0 = (num * 3971581908u ^ 680090763u);
					continue;
				case 18u:
					goto IL_2E1;
				case 19u:
					output.WriteMessage(this.ParentalControlInfo);
					arg_530_0 = (num * 1197537811u ^ 1779921785u);
					continue;
				case 20u:
					output.WriteString(this.FullName);
					arg_530_0 = (num * 4144066561u ^ 4022890768u);
					continue;
				case 21u:
					arg_530_0 = (((AccountBlob.smethod_2(this.BattleTag) != 0) ? 879167140u : 406073723u) ^ num * 979258467u);
					continue;
				case 22u:
					output.WriteRawTag(205, 1);
					arg_530_0 = (num * 3279266959u ^ 2285703695u);
					continue;
				case 23u:
					output.WriteFixed32(this.DefaultCurrency);
					arg_530_0 = (num * 2756607320u ^ 619925787u);
					continue;
				case 24u:
					arg_530_0 = ((this.WhitelistEnd != 0uL) ? 552194u : 600793229u);
					continue;
				case 25u:
					output.WriteRawTag(240, 1);
					output.WriteUInt64(this.CacheExpiration);
					arg_530_0 = (num * 1782097197u ^ 688364363u);
					continue;
				case 26u:
					arg_530_0 = ((AccountBlob.smethod_2(this.Country) == 0) ? 1465850089u : 1380437703u);
					continue;
				case 27u:
					output.WriteRawTag(208, 1);
					arg_530_0 = (num * 4092575799u ^ 2743143960u);
					continue;
				case 28u:
					arg_530_0 = ((this.parentalControlInfo_ != null) ? 996244942u : 298115832u);
					continue;
				case 29u:
					output.WriteRawTag(130, 2);
					arg_530_0 = (num * 1471558463u ^ 3285439751u);
					continue;
				case 30u:
					output.WriteString(this.Country);
					arg_530_0 = (num * 3471803105u ^ 2801654999u);
					continue;
				case 31u:
					output.WriteRawTag(40);
					output.WriteUInt64(this.Flags);
					arg_530_0 = (num * 995920683u ^ 1365906559u);
					continue;
				case 32u:
					goto IL_5EC;
				case 33u:
					output.WriteRawTag(136, 2);
					arg_530_0 = (num * 1695184860u ^ 2513191555u);
					continue;
				case 35u:
					output.WriteEnum((int)this.IdentityCheckStatus);
					arg_530_0 = (num * 888260791u ^ 3238881069u);
					continue;
				case 36u:
					output.WriteRawTag(56);
					output.WriteUInt64(this.WhitelistStart);
					arg_530_0 = (num * 676620552u ^ 2708334810u);
					continue;
				case 37u:
					arg_530_0 = ((this.WhitelistStart != 0uL) ? 1791830750u : 1816681594u);
					continue;
				case 38u:
					arg_530_0 = ((this.IdentityCheckStatus == IdentityVerificationStatus.IDENT_NO_DATA) ? 1960504488u : 1582505761u);
					continue;
				case 39u:
					output.WriteRawTag(48);
					arg_530_0 = (num * 1954710947u ^ 958009839u);
					continue;
				}
				break;
			}
			return;
			IL_2E1:
			arg_530_0 = 1212849925u;
			goto IL_52B;
			IL_5EC:
			arg_530_0 = ((this.SecureRelease != 0uL) ? 597141645u : 233135311u);
			goto IL_52B;
		}

		public int CalculateSize()
		{
			int num = 5 + (1 + CodedOutputStream.ComputeUInt32Size(this.Region));
			while (true)
			{
				IL_4C6:
				uint arg_439_0 = 2586985534u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_439_0 ^ 2479996908u)) % 32u)
					{
					case 1u:
						arg_439_0 = ((this.IdentityCheckStatus != IdentityVerificationStatus.IDENT_NO_DATA) ? 2388018248u : 3253577100u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.WhitelistStart);
						arg_439_0 = (num2 * 1012759862u ^ 1506626390u);
						continue;
					case 3u:
						arg_439_0 = ((this.parentalControlInfo_ != null) ? 2230530134u : 2863318896u);
						continue;
					case 4u:
						num += 2 + CodedOutputStream.ComputeEnumSize((int)this.IdentityCheckStatus);
						arg_439_0 = (num2 * 1368035566u ^ 3180173300u);
						continue;
					case 5u:
						arg_439_0 = (((this.Flags == 0uL) ? 2833088456u : 3827372976u) ^ num2 * 441562959u);
						continue;
					case 6u:
						arg_439_0 = ((this.PreferredRegion == 0u) ? 2858008717u : 3815465972u);
						continue;
					case 7u:
						arg_439_0 = (((AccountBlob.smethod_2(this.BattleTag) != 0) ? 645578461u : 107531690u) ^ num2 * 351364397u);
						continue;
					case 8u:
						arg_439_0 = ((this.CacheExpiration == 0uL) ? 3278811215u : 3963415047u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.FullName);
						arg_439_0 = 2283709912u;
						continue;
					case 10u:
						num += 2 + CodedOutputStream.ComputeStringSize(this.BattleTag);
						arg_439_0 = (num2 * 965533798u ^ 2491497197u);
						continue;
					case 11u:
						num += 2 + CodedOutputStream.ComputeUInt64Size(this.CacheExpiration);
						arg_439_0 = (num2 * 576704445u ^ 2978530096u);
						continue;
					case 12u:
						num += 2 + CodedOutputStream.ComputeUInt32Size(this.LegalRegion);
						arg_439_0 = (num2 * 776224124u ^ 1210237891u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.SecureRelease);
						arg_439_0 = (num2 * 2045493574u ^ 1232801497u);
						continue;
					case 14u:
						num += 6;
						arg_439_0 = (num2 * 493643189u ^ 1046470394u);
						continue;
					case 15u:
						arg_439_0 = ((this.SecureRelease == 0uL) ? 3251228119u : 3296709153u);
						continue;
					case 16u:
						arg_439_0 = ((this.LegalRegion == 0u) ? 2228933011u : 4091443200u);
						continue;
					case 17u:
						num += 6;
						arg_439_0 = (num2 * 1798352552u ^ 3258662764u);
						continue;
					case 18u:
						num += this.email_.CalculateSize(AccountBlob._repeated_email_codec);
						arg_439_0 = (num2 * 1912409789u ^ 3599210403u);
						continue;
					case 19u:
						goto IL_4C6;
					case 20u:
						num += this.licenses_.CalculateSize(AccountBlob._repeated_licenses_codec);
						num += this.credentials_.CalculateSize(AccountBlob._repeated_credentials_codec);
						arg_439_0 = (num2 * 3383253008u ^ 194502649u);
						continue;
					case 21u:
						num += this.accountLinks_.CalculateSize(AccountBlob._repeated_accountLinks_codec);
						arg_439_0 = (num2 * 2207609729u ^ 1066901694u);
						continue;
					case 22u:
						arg_439_0 = ((this.WhitelistEnd != 0uL) ? 2502726450u : 3485561317u);
						continue;
					case 23u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Flags);
						arg_439_0 = (num2 * 4055168615u ^ 3078961346u);
						continue;
					case 24u:
						num += 2 + CodedOutputStream.ComputeUInt32Size(this.PreferredRegion);
						arg_439_0 = (num2 * 979331368u ^ 4097440589u);
						continue;
					case 25u:
						num += 2 + CodedOutputStream.ComputeStringSize(this.Country);
						arg_439_0 = (num2 * 4214138158u ^ 1365694612u);
						continue;
					case 26u:
						num += 2 + CodedOutputStream.ComputeMessageSize(this.ParentalControlInfo);
						arg_439_0 = (num2 * 2084528723u ^ 2606041662u);
						continue;
					case 27u:
						arg_439_0 = ((this.WhitelistStart != 0uL) ? 2954447502u : 2432948218u);
						continue;
					case 28u:
						arg_439_0 = ((AccountBlob.smethod_2(this.Country) != 0) ? 2808782005u : 3842010730u);
						continue;
					case 29u:
						arg_439_0 = ((this.DefaultCurrency != 0u) ? 3431390690u : 3892315932u);
						continue;
					case 30u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.WhitelistEnd);
						arg_439_0 = (num2 * 4045630914u ^ 4153538521u);
						continue;
					case 31u:
						arg_439_0 = ((this.LegalLocale == 0u) ? 3276112452u : 3281202557u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountBlob other)
		{
			if (other == null)
			{
				goto IL_3EC;
			}
			goto IL_5A3;
			uint arg_4E7_0;
			while (true)
			{
				IL_4E2:
				uint num;
				switch ((num = (arg_4E7_0 ^ 2257876603u)) % 40u)
				{
				case 1u:
					arg_4E7_0 = ((other.DefaultCurrency == 0u) ? 2917202775u : 2317320035u);
					continue;
				case 2u:
					arg_4E7_0 = ((other.LegalLocale != 0u) ? 3083109604u : 4290611965u);
					continue;
				case 3u:
					this.credentials_.Add(other.credentials_);
					this.accountLinks_.Add(other.accountLinks_);
					arg_4E7_0 = (num * 2924246068u ^ 125797649u);
					continue;
				case 4u:
					arg_4E7_0 = ((other.LegalRegion == 0u) ? 4027006329u : 3549087151u);
					continue;
				case 5u:
					this.PreferredRegion = other.PreferredRegion;
					arg_4E7_0 = (num * 1478443890u ^ 3629155688u);
					continue;
				case 6u:
					this.CacheExpiration = other.CacheExpiration;
					arg_4E7_0 = (num * 1918971440u ^ 3826515962u);
					continue;
				case 7u:
					this.Region = other.Region;
					arg_4E7_0 = (num * 782541317u ^ 2857488765u);
					continue;
				case 8u:
					goto IL_3EC;
				case 9u:
					arg_4E7_0 = ((other.parentalControlInfo_ == null) ? 3703161361u : 3772514809u);
					continue;
				case 10u:
					this.parentalControlInfo_ = new ParentalControlInfo();
					arg_4E7_0 = (num * 1966243218u ^ 3933245077u);
					continue;
				case 11u:
					goto IL_5A3;
				case 12u:
					this.WhitelistStart = other.WhitelistStart;
					arg_4E7_0 = (num * 3316956899u ^ 825204272u);
					continue;
				case 13u:
					this.Id = other.Id;
					arg_4E7_0 = (num * 2559438516u ^ 3650627793u);
					continue;
				case 14u:
					return;
				case 15u:
					this.LegalLocale = other.LegalLocale;
					arg_4E7_0 = (num * 1167446752u ^ 1624781789u);
					continue;
				case 16u:
					this.SecureRelease = other.SecureRelease;
					arg_4E7_0 = (num * 2135733403u ^ 2657295966u);
					continue;
				case 17u:
					this.IdentityCheckStatus = other.IdentityCheckStatus;
					arg_4E7_0 = (num * 2109049666u ^ 1682099513u);
					continue;
				case 18u:
					arg_4E7_0 = (((this.parentalControlInfo_ == null) ? 1244954915u : 447977523u) ^ num * 1796629513u);
					continue;
				case 19u:
					arg_4E7_0 = ((AccountBlob.smethod_2(other.FullName) == 0) ? 3579231578u : 2779584252u);
					continue;
				case 20u:
					this.Country = other.Country;
					arg_4E7_0 = (num * 1610441641u ^ 909347714u);
					continue;
				case 21u:
					this.email_.Add(other.email_);
					arg_4E7_0 = 4267867608u;
					continue;
				case 22u:
					arg_4E7_0 = ((other.Region != 0u) ? 2252726572u : 2445857742u);
					continue;
				case 23u:
					this.FullName = other.FullName;
					arg_4E7_0 = (num * 3046059931u ^ 4018767847u);
					continue;
				case 24u:
					this.DefaultCurrency = other.DefaultCurrency;
					arg_4E7_0 = (num * 3068565789u ^ 308258031u);
					continue;
				case 25u:
					arg_4E7_0 = ((other.IdentityCheckStatus != IdentityVerificationStatus.IDENT_NO_DATA) ? 3720274266u : 4229704891u);
					continue;
				case 26u:
					arg_4E7_0 = ((AccountBlob.smethod_2(other.Country) == 0) ? 3389605758u : 2750985447u);
					continue;
				case 27u:
					this.Flags = other.Flags;
					arg_4E7_0 = (num * 2795973611u ^ 4149065661u);
					continue;
				case 28u:
					this.WhitelistEnd = other.WhitelistEnd;
					arg_4E7_0 = (num * 3048899101u ^ 12348484u);
					continue;
				case 29u:
					arg_4E7_0 = ((other.WhitelistStart == 0uL) ? 3596566444u : 3860494543u);
					continue;
				case 30u:
					arg_4E7_0 = (((AccountBlob.smethod_2(other.BattleTag) == 0) ? 1287040860u : 21497725u) ^ num * 1087480325u);
					continue;
				case 31u:
					arg_4E7_0 = ((other.WhitelistEnd != 0uL) ? 2923954087u : 3245095336u);
					continue;
				case 32u:
					this.BattleTag = other.BattleTag;
					arg_4E7_0 = (num * 688436156u ^ 3975583346u);
					continue;
				case 33u:
					this.licenses_.Add(other.licenses_);
					arg_4E7_0 = 3303751288u;
					continue;
				case 34u:
					this.ParentalControlInfo.MergeFrom(other.ParentalControlInfo);
					arg_4E7_0 = 3703161361u;
					continue;
				case 35u:
					arg_4E7_0 = (((other.Flags == 0uL) ? 850578877u : 1833324825u) ^ num * 2092312091u);
					continue;
				case 36u:
					this.LegalRegion = other.LegalRegion;
					arg_4E7_0 = (num * 4108815753u ^ 985742605u);
					continue;
				case 37u:
					arg_4E7_0 = ((other.PreferredRegion != 0u) ? 2476936726u : 3694895842u);
					continue;
				case 38u:
					arg_4E7_0 = ((other.CacheExpiration == 0uL) ? 3787547738u : 2190834693u);
					continue;
				case 39u:
					arg_4E7_0 = ((other.SecureRelease == 0uL) ? 2511933694u : 2835051419u);
					continue;
				}
				break;
			}
			return;
			IL_3EC:
			arg_4E7_0 = 2508800765u;
			goto IL_4E2;
			IL_5A3:
			arg_4E7_0 = ((other.Id == 0u) ? 2681835445u : 4277770790u);
			goto IL_4E2;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_8ED:
				uint num;
				uint arg_7B5_0 = ((num = input.ReadTag()) != 0u) ? 677988587u : 1283028288u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_7B5_0 ^ 653189166u)) % 71u)
					{
					case 0u:
						arg_7B5_0 = (num2 * 4005665647u ^ 292372736u);
						continue;
					case 1u:
						arg_7B5_0 = (num2 * 4125696264u ^ 1956577003u);
						continue;
					case 2u:
						arg_7B5_0 = ((num != 258u) ? 432192018u : 2109937584u);
						continue;
					case 3u:
						arg_7B5_0 = (((num != 240u) ? 1920431645u : 1027086478u) ^ num2 * 604119955u);
						continue;
					case 4u:
						this.Country = input.ReadString();
						arg_7B5_0 = 266938499u;
						continue;
					case 5u:
						arg_7B5_0 = (num2 * 3536275336u ^ 797030683u);
						continue;
					case 6u:
						arg_7B5_0 = (((num != 178u) ? 1363539740u : 1323402117u) ^ num2 * 3937015283u);
						continue;
					case 7u:
						this.LegalLocale = input.ReadFixed32();
						arg_7B5_0 = 1447686481u;
						continue;
					case 8u:
						arg_7B5_0 = (((num == 21u) ? 3746931269u : 2751926442u) ^ num2 * 3270842631u);
						continue;
					case 9u:
						arg_7B5_0 = (((num == 64u) ? 2601607421u : 2436258632u) ^ num2 * 4166373361u);
						continue;
					case 10u:
						arg_7B5_0 = (((num == 48u) ? 2730433142u : 3995067469u) ^ num2 * 2861382568u);
						continue;
					case 11u:
						arg_7B5_0 = (((num == 56u) ? 3160804643u : 2394630891u) ^ num2 * 1334567021u);
						continue;
					case 12u:
						arg_7B5_0 = ((num == 34u) ? 1817839762u : 1574209600u);
						continue;
					case 13u:
						arg_7B5_0 = (num2 * 3421839786u ^ 2179388154u);
						continue;
					case 14u:
						arg_7B5_0 = (num2 * 2524073229u ^ 3975862695u);
						continue;
					case 15u:
						this.email_.AddEntriesFrom(input, AccountBlob._repeated_email_codec);
						arg_7B5_0 = 1444184159u;
						continue;
					case 16u:
						this.Flags = input.ReadUInt64();
						arg_7B5_0 = 885991983u;
						continue;
					case 17u:
						arg_7B5_0 = ((num <= 221u) ? 377404523u : 959358014u);
						continue;
					case 18u:
						this.parentalControlInfo_ = new ParentalControlInfo();
						arg_7B5_0 = (num2 * 2831009679u ^ 803742785u);
						continue;
					case 19u:
						input.SkipLastField();
						arg_7B5_0 = 1034668596u;
						continue;
					case 20u:
						arg_7B5_0 = (((num <= 48u) ? 404694740u : 1166440698u) ^ num2 * 1151404941u);
						continue;
					case 21u:
						this.credentials_.AddEntriesFrom(input, AccountBlob._repeated_credentials_codec);
						arg_7B5_0 = 266938499u;
						continue;
					case 22u:
						arg_7B5_0 = (num2 * 951978210u ^ 1366331967u);
						continue;
					case 23u:
						arg_7B5_0 = (num2 * 2011186747u ^ 4005801961u);
						continue;
					case 24u:
						this.SecureRelease = input.ReadUInt64();
						arg_7B5_0 = 19312291u;
						continue;
					case 25u:
						goto IL_8ED;
					case 26u:
						this.LegalRegion = input.ReadUInt32();
						arg_7B5_0 = 1662702887u;
						continue;
					case 27u:
						arg_7B5_0 = (((num == 186u) ? 466023720u : 1332519938u) ^ num2 * 926216021u);
						continue;
					case 28u:
						arg_7B5_0 = ((num != 82u) ? 943538802u : 1794738774u);
						continue;
					case 29u:
						arg_7B5_0 = (((num == 272u) ? 3226554247u : 3384188482u) ^ num2 * 816051610u);
						continue;
					case 30u:
						this.CacheExpiration = input.ReadUInt64();
						arg_7B5_0 = 266938499u;
						continue;
					case 31u:
						arg_7B5_0 = (((num != 250u) ? 3113159555u : 2599039583u) ^ num2 * 794490137u);
						continue;
					case 32u:
						arg_7B5_0 = (num2 * 3847837040u ^ 1239064051u);
						continue;
					case 33u:
						arg_7B5_0 = (((num != 40u) ? 1089033372u : 359144922u) ^ num2 * 3817832883u);
						continue;
					case 34u:
						this.BattleTag = input.ReadString();
						arg_7B5_0 = 198019600u;
						continue;
					case 35u:
						arg_7B5_0 = (num2 * 2690306397u ^ 3616398386u);
						continue;
					case 36u:
						this.WhitelistStart = input.ReadUInt64();
						arg_7B5_0 = 266938499u;
						continue;
					case 37u:
						arg_7B5_0 = (((num != 170u) ? 3365945056u : 2926894261u) ^ num2 * 1800269956u);
						continue;
					case 38u:
						arg_7B5_0 = (num2 * 1974482376u ^ 4049184683u);
						continue;
					case 39u:
						arg_7B5_0 = (((num == 221u) ? 839068795u : 995291215u) ^ num2 * 1245397509u);
						continue;
					case 40u:
						this.Id = input.ReadFixed32();
						arg_7B5_0 = 266938499u;
						continue;
					case 41u:
						arg_7B5_0 = (num2 * 3145374836u ^ 2519890960u);
						continue;
					case 42u:
						this.licenses_.AddEntriesFrom(input, AccountBlob._repeated_licenses_codec);
						arg_7B5_0 = 266938499u;
						continue;
					case 43u:
						this.DefaultCurrency = input.ReadFixed32();
						arg_7B5_0 = 647706883u;
						continue;
					case 44u:
						arg_7B5_0 = 677988587u;
						continue;
					case 45u:
						arg_7B5_0 = (num2 * 808934399u ^ 604158466u);
						continue;
					case 46u:
						this.PreferredRegion = input.ReadUInt32();
						arg_7B5_0 = 266938499u;
						continue;
					case 47u:
						arg_7B5_0 = ((num <= 170u) ? 940452801u : 1338507524u);
						continue;
					case 48u:
						arg_7B5_0 = (((num != 264u) ? 3351247855u : 2765290755u) ^ num2 * 1790980987u);
						continue;
					case 49u:
						this.identityCheckStatus_ = (IdentityVerificationStatus)input.ReadEnum();
						arg_7B5_0 = 266938499u;
						continue;
					case 50u:
						arg_7B5_0 = ((num == 205u) ? 605493805u : 316414775u);
						continue;
					case 51u:
						arg_7B5_0 = ((this.parentalControlInfo_ == null) ? 1832162028u : 412929055u);
						continue;
					case 52u:
						this.Region = input.ReadUInt32();
						arg_7B5_0 = 1907615988u;
						continue;
					case 53u:
						this.WhitelistEnd = input.ReadUInt64();
						arg_7B5_0 = 266938499u;
						continue;
					case 55u:
						arg_7B5_0 = (num2 * 3809673221u ^ 3115252225u);
						continue;
					case 56u:
						arg_7B5_0 = (num2 * 4065449095u ^ 1313752852u);
						continue;
					case 57u:
						input.ReadMessage(this.parentalControlInfo_);
						arg_7B5_0 = 1705782605u;
						continue;
					case 58u:
						arg_7B5_0 = (((num > 24u) ? 2629029466u : 2196036255u) ^ num2 * 1769018342u);
						continue;
					case 59u:
						arg_7B5_0 = (((num != 162u) ? 232133427u : 903525731u) ^ num2 * 820660308u);
						continue;
					case 60u:
						arg_7B5_0 = ((num > 250u) ? 1314438145u : 903193417u);
						continue;
					case 61u:
						arg_7B5_0 = ((num > 64u) ? 758145650u : 109493358u);
						continue;
					case 62u:
						arg_7B5_0 = (num2 * 4004749684u ^ 3377073556u);
						continue;
					case 63u:
						this.accountLinks_.AddEntriesFrom(input, AccountBlob._repeated_accountLinks_codec);
						arg_7B5_0 = 266938499u;
						continue;
					case 64u:
						arg_7B5_0 = (num2 * 1870454922u ^ 4102119001u);
						continue;
					case 65u:
						arg_7B5_0 = (num2 * 757364291u ^ 1610409357u);
						continue;
					case 66u:
						arg_7B5_0 = (num2 * 1490404867u ^ 855602457u);
						continue;
					case 67u:
						this.FullName = input.ReadString();
						arg_7B5_0 = 2138398979u;
						continue;
					case 68u:
						arg_7B5_0 = (((num != 208u) ? 2439470716u : 4061821416u) ^ num2 * 1112780186u);
						continue;
					case 69u:
						arg_7B5_0 = (((num != 24u) ? 606888309u : 177229193u) ^ num2 * 3363091259u);
						continue;
					case 70u:
						arg_7B5_0 = (((num <= 186u) ? 28031554u : 28735085u) ^ num2 * 2110572577u);
						continue;
					}
					return;
				}
			}
		}

		static AccountBlob()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_A4:
				uint arg_88_0 = 2744619014u;
				while (true)
				{
					uint num;
					switch ((num = (arg_88_0 ^ 3484196077u)) % 4u)
					{
					case 0u:
						goto IL_A4;
					case 2u:
						AccountBlob._repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(162u, AccountLicense.Parser);
						AccountBlob._repeated_credentials_codec = FieldCodec.ForMessage<AccountCredential>(170u, AccountCredential.Parser);
						AccountBlob._repeated_accountLinks_codec = FieldCodec.ForMessage<GameAccountLink>(178u, GameAccountLink.Parser);
						arg_88_0 = (num * 2806614836u ^ 2582780192u);
						continue;
					case 3u:
						AccountBlob._repeated_email_codec = FieldCodec.ForString(34u);
						arg_88_0 = (num * 3336864263u ^ 3924187742u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
