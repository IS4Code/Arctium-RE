using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountLevelInfo : IMessage<AccountLevelInfo>, IEquatable<AccountLevelInfo>, IDeepCloneable<AccountLevelInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountLevelInfo.__c __9 = new AccountLevelInfo.__c();

			internal AccountLevelInfo cctor>b__74_0()
			{
				return new AccountLevelInfo();
			}
		}

		private static readonly MessageParser<AccountLevelInfo> _parser = new MessageParser<AccountLevelInfo>(new Func<AccountLevelInfo>(AccountLevelInfo.__c.__9.<.cctor>b__74_0));

		public const int LicensesFieldNumber = 3;

		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec;

		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		public const int DefaultCurrencyFieldNumber = 4;

		private uint defaultCurrency_;

		public const int CountryFieldNumber = 5;

		private string country_ = "";

		public const int PreferredRegionFieldNumber = 6;

		private uint preferredRegion_;

		public const int FullNameFieldNumber = 7;

		private string fullName_ = "";

		public const int BattleTagFieldNumber = 8;

		private string battleTag_ = "";

		public const int MutedFieldNumber = 9;

		private bool muted_;

		public const int ManualReviewFieldNumber = 10;

		private bool manualReview_;

		public const int AccountPaidAnyFieldNumber = 11;

		private bool accountPaidAny_;

		public const int IdentityCheckStatusFieldNumber = 12;

		private IdentityVerificationStatus identityCheckStatus_;

		public const int EmailFieldNumber = 13;

		private string email_ = "";

		public static MessageParser<AccountLevelInfo> Parser
		{
			get
			{
				return AccountLevelInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[18];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountLevelInfo.Descriptor;
			}
		}

		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
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

		public string Country
		{
			get
			{
				return this.country_;
			}
			set
			{
				this.country_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
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

		public string FullName
		{
			get
			{
				return this.fullName_;
			}
			set
			{
				this.fullName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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
				this.battleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public bool Muted
		{
			get
			{
				return this.muted_;
			}
			set
			{
				this.muted_ = value;
			}
		}

		public bool ManualReview
		{
			get
			{
				return this.manualReview_;
			}
			set
			{
				this.manualReview_ = value;
			}
		}

		public bool AccountPaidAny
		{
			get
			{
				return this.accountPaidAny_;
			}
			set
			{
				this.accountPaidAny_ = value;
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

		public string Email
		{
			get
			{
				return this.email_;
			}
			set
			{
				this.email_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public AccountLevelInfo()
		{
		}

		public AccountLevelInfo(AccountLevelInfo other) : this()
		{
			while (true)
			{
				IL_126:
				uint arg_FA_0 = 2133868732u;
				while (true)
				{
					uint num;
					switch ((num = (arg_FA_0 ^ 973291341u)) % 8u)
					{
					case 0u:
						this.defaultCurrency_ = other.defaultCurrency_;
						this.country_ = other.country_;
						this.preferredRegion_ = other.preferredRegion_;
						this.fullName_ = other.fullName_;
						arg_FA_0 = (num * 380203362u ^ 3677914152u);
						continue;
					case 1u:
						this.licenses_ = other.licenses_.Clone();
						arg_FA_0 = (num * 2244943882u ^ 2202727455u);
						continue;
					case 2u:
						this.muted_ = other.muted_;
						this.manualReview_ = other.manualReview_;
						arg_FA_0 = (num * 2857336166u ^ 2326466405u);
						continue;
					case 4u:
						this.accountPaidAny_ = other.accountPaidAny_;
						arg_FA_0 = (num * 2062832376u ^ 2882767458u);
						continue;
					case 5u:
						this.battleTag_ = other.battleTag_;
						arg_FA_0 = (num * 2414220908u ^ 400497955u);
						continue;
					case 6u:
						goto IL_126;
					case 7u:
						this.identityCheckStatus_ = other.identityCheckStatus_;
						this.email_ = other.email_;
						arg_FA_0 = (num * 766078153u ^ 4039406769u);
						continue;
					}
					return;
				}
			}
		}

		public AccountLevelInfo Clone()
		{
			return new AccountLevelInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountLevelInfo);
		}

		public bool Equals(AccountLevelInfo other)
		{
			if (other == null)
			{
				goto IL_C8;
			}
			goto IL_289;
			int arg_203_0;
			while (true)
			{
				IL_1FE:
				switch ((arg_203_0 ^ -781233351) % 27)
				{
				case 0:
					arg_203_0 = ((!AccountLevelInfo.smethod_0(this.Country, other.Country)) ? -1782879865 : -1591729317);
					continue;
				case 1:
					arg_203_0 = (AccountLevelInfo.smethod_0(this.BattleTag, other.BattleTag) ? -1200911610 : -768580493);
					continue;
				case 2:
					return false;
				case 3:
					arg_203_0 = ((this.PreferredRegion != other.PreferredRegion) ? -378217023 : -1312555324);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_203_0 = ((!AccountLevelInfo.smethod_0(this.Email, other.Email)) ? -534739402 : -906543525);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_203_0 = ((this.DefaultCurrency == other.DefaultCurrency) ? -307719332 : -1197213946);
					continue;
				case 14:
					return false;
				case 15:
					arg_203_0 = ((this.AccountPaidAny == other.AccountPaidAny) ? -1513567802 : -483513830);
					continue;
				case 16:
					arg_203_0 = ((!this.licenses_.Equals(other.licenses_)) ? -3916259 : -69917665);
					continue;
				case 17:
					goto IL_C8;
				case 18:
					return false;
				case 19:
					goto IL_289;
				case 21:
					return false;
				case 22:
					arg_203_0 = ((!AccountLevelInfo.smethod_0(this.FullName, other.FullName)) ? -1400154228 : -33101720);
					continue;
				case 23:
					arg_203_0 = ((this.IdentityCheckStatus == other.IdentityCheckStatus) ? -422899652 : -513771142);
					continue;
				case 24:
					arg_203_0 = ((this.ManualReview == other.ManualReview) ? -2036037191 : -2037951264);
					continue;
				case 25:
					return false;
				case 26:
					arg_203_0 = ((this.Muted != other.Muted) ? -564935307 : -1011341407);
					continue;
				}
				break;
			}
			return true;
			IL_C8:
			arg_203_0 = -1264456410;
			goto IL_1FE;
			IL_289:
			arg_203_0 = ((other == this) ? -744922958 : -917604816);
			goto IL_1FE;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ AccountLevelInfo.smethod_1(this.licenses_);
			if (this.DefaultCurrency != 0u)
			{
				goto IL_E6;
			}
			goto IL_333;
			uint arg_2C2_0;
			while (true)
			{
				IL_2BD:
				uint num2;
				switch ((num2 = (arg_2C2_0 ^ 1664839643u)) % 21u)
				{
				case 0u:
					goto IL_333;
				case 1u:
					arg_2C2_0 = ((this.IdentityCheckStatus == IdentityVerificationStatus.IDENT_NO_DATA) ? 1035366487u : 831186676u);
					continue;
				case 2u:
					num ^= this.IdentityCheckStatus.GetHashCode();
					arg_2C2_0 = (num2 * 4276140811u ^ 3661646418u);
					continue;
				case 3u:
					arg_2C2_0 = ((this.FullName.Length == 0) ? 1596648021u : 1539472502u);
					continue;
				case 4u:
					arg_2C2_0 = ((this.PreferredRegion != 0u) ? 1589733349u : 1881158414u);
					continue;
				case 5u:
					num ^= this.FullName.GetHashCode();
					arg_2C2_0 = (num2 * 662013861u ^ 902824916u);
					continue;
				case 6u:
					num ^= this.Email.GetHashCode();
					arg_2C2_0 = (num2 * 1771023189u ^ 2244463996u);
					continue;
				case 7u:
					num ^= this.AccountPaidAny.GetHashCode();
					arg_2C2_0 = (num2 * 4288676547u ^ 2110615391u);
					continue;
				case 8u:
					num ^= this.DefaultCurrency.GetHashCode();
					arg_2C2_0 = (num2 * 1679275032u ^ 516793898u);
					continue;
				case 10u:
					arg_2C2_0 = ((this.Email.Length != 0) ? 195160958u : 852790453u);
					continue;
				case 11u:
					num ^= this.BattleTag.GetHashCode();
					arg_2C2_0 = (num2 * 2385658734u ^ 1084980959u);
					continue;
				case 12u:
					arg_2C2_0 = (this.ManualReview ? 1380106523u : 1167657382u);
					continue;
				case 13u:
					arg_2C2_0 = ((!this.AccountPaidAny) ? 1244920030u : 764329904u);
					continue;
				case 14u:
					arg_2C2_0 = (this.Muted ? 1994703422u : 522609903u);
					continue;
				case 15u:
					goto IL_E6;
				case 16u:
					num ^= this.Muted.GetHashCode();
					arg_2C2_0 = (num2 * 3600989476u ^ 2967921115u);
					continue;
				case 17u:
					num ^= this.ManualReview.GetHashCode();
					arg_2C2_0 = (num2 * 3279678374u ^ 3137902886u);
					continue;
				case 18u:
					num ^= this.PreferredRegion.GetHashCode();
					arg_2C2_0 = (num2 * 2471521234u ^ 4123828178u);
					continue;
				case 19u:
					arg_2C2_0 = ((this.BattleTag.Length != 0) ? 47137646u : 1599334937u);
					continue;
				case 20u:
					num ^= this.Country.GetHashCode();
					arg_2C2_0 = (num2 * 781300108u ^ 1816857094u);
					continue;
				}
				break;
			}
			return num;
			IL_E6:
			arg_2C2_0 = 1944299170u;
			goto IL_2BD;
			IL_333:
			arg_2C2_0 = ((this.Country.Length == 0) ? 1301091558u : 91927859u);
			goto IL_2BD;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.licenses_.WriteTo(output, AccountLevelInfo._repeated_licenses_codec);
			if (this.DefaultCurrency != 0u)
			{
				goto IL_247;
			}
			goto IL_3B8;
			uint arg_334_0;
			while (true)
			{
				IL_32F:
				uint num;
				switch ((num = (arg_334_0 ^ 2566696005u)) % 26u)
				{
				case 0u:
					output.WriteRawTag(42);
					output.WriteString(this.Country);
					arg_334_0 = (num * 3988988997u ^ 1445247679u);
					continue;
				case 1u:
					output.WriteBool(this.AccountPaidAny);
					arg_334_0 = (num * 1004326155u ^ 205781198u);
					continue;
				case 2u:
					output.WriteUInt32(this.PreferredRegion);
					arg_334_0 = (num * 4029841407u ^ 1913095571u);
					continue;
				case 3u:
					output.WriteRawTag(72);
					output.WriteBool(this.Muted);
					arg_334_0 = (num * 2539986752u ^ 540998569u);
					continue;
				case 4u:
					arg_334_0 = ((AccountLevelInfo.smethod_2(this.BattleTag) != 0) ? 3174529621u : 3776649775u);
					continue;
				case 5u:
					output.WriteRawTag(37);
					arg_334_0 = (num * 3070597156u ^ 1795496907u);
					continue;
				case 6u:
					arg_334_0 = ((this.PreferredRegion == 0u) ? 4283282979u : 2560453485u);
					continue;
				case 7u:
					goto IL_247;
				case 8u:
					arg_334_0 = ((AccountLevelInfo.smethod_2(this.FullName) == 0) ? 3492058721u : 4010655210u);
					continue;
				case 9u:
					output.WriteRawTag(80);
					arg_334_0 = (num * 2962532506u ^ 2692470588u);
					continue;
				case 10u:
					arg_334_0 = (this.Muted ? 3400222792u : 4270419433u);
					continue;
				case 11u:
					arg_334_0 = (this.AccountPaidAny ? 2991295954u : 2583695037u);
					continue;
				case 12u:
					output.WriteRawTag(106);
					output.WriteString(this.Email);
					arg_334_0 = (num * 2789732332u ^ 337215767u);
					continue;
				case 13u:
					output.WriteRawTag(58);
					arg_334_0 = (num * 233867463u ^ 1411519417u);
					continue;
				case 14u:
					output.WriteRawTag(66);
					output.WriteString(this.BattleTag);
					arg_334_0 = (num * 1425689721u ^ 1302329279u);
					continue;
				case 15u:
					goto IL_3B8;
				case 16u:
					output.WriteRawTag(48);
					arg_334_0 = (num * 1993773271u ^ 3843400333u);
					continue;
				case 17u:
					output.WriteBool(this.ManualReview);
					arg_334_0 = (num * 2746764005u ^ 804187903u);
					continue;
				case 19u:
					arg_334_0 = ((AccountLevelInfo.smethod_2(this.Email) == 0) ? 3289578775u : 3962028357u);
					continue;
				case 20u:
					arg_334_0 = ((this.IdentityCheckStatus != IdentityVerificationStatus.IDENT_NO_DATA) ? 3552001340u : 3034742676u);
					continue;
				case 21u:
					output.WriteString(this.FullName);
					arg_334_0 = (num * 1499005067u ^ 1977240422u);
					continue;
				case 22u:
					arg_334_0 = (this.ManualReview ? 3829211036u : 3270887584u);
					continue;
				case 23u:
					output.WriteRawTag(96);
					output.WriteEnum((int)this.IdentityCheckStatus);
					arg_334_0 = (num * 2764691742u ^ 701096634u);
					continue;
				case 24u:
					output.WriteFixed32(this.DefaultCurrency);
					arg_334_0 = (num * 1028586845u ^ 3982187352u);
					continue;
				case 25u:
					output.WriteRawTag(88);
					arg_334_0 = (num * 1150973278u ^ 1754839310u);
					continue;
				}
				break;
			}
			return;
			IL_247:
			arg_334_0 = 3997912046u;
			goto IL_32F;
			IL_3B8:
			arg_334_0 = ((AccountLevelInfo.smethod_2(this.Country) != 0) ? 2253905785u : 3845834131u);
			goto IL_32F;
		}

		public int CalculateSize()
		{
			int num = 0 + this.licenses_.CalculateSize(AccountLevelInfo._repeated_licenses_codec);
			while (true)
			{
				IL_31B:
				uint arg_2B6_0 = 750391156u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2B6_0 ^ 1792579531u)) % 22u)
					{
					case 0u:
						arg_2B6_0 = ((!this.ManualReview) ? 366059586u : 391262942u);
						continue;
					case 1u:
						arg_2B6_0 = ((AccountLevelInfo.smethod_2(this.FullName) == 0) ? 1989211116u : 1003112414u);
						continue;
					case 2u:
						arg_2B6_0 = ((AccountLevelInfo.smethod_2(this.Country) != 0) ? 1316519296u : 1801137929u);
						continue;
					case 3u:
						num += 2;
						arg_2B6_0 = (num2 * 742479131u ^ 2167650360u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.IdentityCheckStatus);
						arg_2B6_0 = (num2 * 4162235536u ^ 2219960173u);
						continue;
					case 5u:
						arg_2B6_0 = ((AccountLevelInfo.smethod_2(this.BattleTag) != 0) ? 1650758687u : 121427487u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
						arg_2B6_0 = (num2 * 2847546548u ^ 2006529807u);
						continue;
					case 7u:
						num += 2;
						arg_2B6_0 = (num2 * 1787396189u ^ 3992246499u);
						continue;
					case 8u:
						arg_2B6_0 = ((this.IdentityCheckStatus != IdentityVerificationStatus.IDENT_NO_DATA) ? 493228693u : 1720437645u);
						continue;
					case 9u:
						arg_2B6_0 = (((this.DefaultCurrency == 0u) ? 564430804u : 1075690564u) ^ num2 * 2041642983u);
						continue;
					case 10u:
						num += 5;
						arg_2B6_0 = (num2 * 1695391135u ^ 2802439783u);
						continue;
					case 11u:
						goto IL_31B;
					case 12u:
						arg_2B6_0 = (this.Muted ? 668634396u : 394956693u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.FullName);
						arg_2B6_0 = (num2 * 3707303997u ^ 1576476397u);
						continue;
					case 14u:
						num += 2;
						arg_2B6_0 = (num2 * 276098336u ^ 3588854121u);
						continue;
					case 15u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
						arg_2B6_0 = (num2 * 1229554670u ^ 4209588874u);
						continue;
					case 16u:
						arg_2B6_0 = ((this.PreferredRegion == 0u) ? 585764742u : 996044319u);
						continue;
					case 17u:
						arg_2B6_0 = ((!this.AccountPaidAny) ? 1649207977u : 907077861u);
						continue;
					case 18u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.PreferredRegion);
						arg_2B6_0 = (num2 * 4287221848u ^ 2906402662u);
						continue;
					case 20u:
						arg_2B6_0 = ((AccountLevelInfo.smethod_2(this.Email) == 0) ? 1631648032u : 341495896u);
						continue;
					case 21u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Country);
						arg_2B6_0 = (num2 * 2590734004u ^ 2468831669u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountLevelInfo other)
		{
			if (other == null)
			{
				goto IL_128;
			}
			goto IL_315;
			uint arg_29D_0;
			while (true)
			{
				IL_298:
				uint num;
				switch ((num = (arg_29D_0 ^ 3314702777u)) % 23u)
				{
				case 0u:
					this.Muted = other.Muted;
					arg_29D_0 = (num * 2732854696u ^ 308847747u);
					continue;
				case 1u:
					return;
				case 2u:
					arg_29D_0 = (other.AccountPaidAny ? 3661255754u : 2269982428u);
					continue;
				case 3u:
					this.PreferredRegion = other.PreferredRegion;
					arg_29D_0 = (num * 3202793535u ^ 1375277235u);
					continue;
				case 4u:
					this.Email = other.Email;
					arg_29D_0 = (num * 3286311336u ^ 2265454726u);
					continue;
				case 5u:
					arg_29D_0 = ((AccountLevelInfo.smethod_2(other.Country) != 0) ? 2545336102u : 3854177288u);
					continue;
				case 6u:
					this.Country = other.Country;
					arg_29D_0 = (num * 1285538532u ^ 1977153428u);
					continue;
				case 7u:
					arg_29D_0 = ((AccountLevelInfo.smethod_2(other.FullName) == 0) ? 3079871281u : 3861447842u);
					continue;
				case 8u:
					arg_29D_0 = ((AccountLevelInfo.smethod_2(other.Email) == 0) ? 4182256558u : 3585435336u);
					continue;
				case 9u:
					this.AccountPaidAny = other.AccountPaidAny;
					arg_29D_0 = (num * 181375199u ^ 1744107633u);
					continue;
				case 10u:
					arg_29D_0 = ((!other.Muted) ? 3925193299u : 2973621771u);
					continue;
				case 11u:
					this.BattleTag = other.BattleTag;
					arg_29D_0 = (num * 3028340383u ^ 1770859456u);
					continue;
				case 12u:
					goto IL_128;
				case 13u:
					this.FullName = other.FullName;
					arg_29D_0 = (num * 3200240992u ^ 1197838865u);
					continue;
				case 15u:
					arg_29D_0 = ((other.IdentityCheckStatus != IdentityVerificationStatus.IDENT_NO_DATA) ? 2220756511u : 2295517784u);
					continue;
				case 16u:
					this.IdentityCheckStatus = other.IdentityCheckStatus;
					arg_29D_0 = (num * 123658108u ^ 278584368u);
					continue;
				case 17u:
					arg_29D_0 = ((AccountLevelInfo.smethod_2(other.BattleTag) == 0) ? 2935886320u : 2955501161u);
					continue;
				case 18u:
					arg_29D_0 = ((!other.ManualReview) ? 3713600210u : 4094590231u);
					continue;
				case 19u:
					this.ManualReview = other.ManualReview;
					arg_29D_0 = (num * 915357782u ^ 965269670u);
					continue;
				case 20u:
					this.DefaultCurrency = other.DefaultCurrency;
					arg_29D_0 = (num * 852577616u ^ 401322282u);
					continue;
				case 21u:
					goto IL_315;
				case 22u:
					arg_29D_0 = ((other.PreferredRegion == 0u) ? 2641434285u : 2957003739u);
					continue;
				}
				break;
			}
			return;
			IL_128:
			arg_29D_0 = 3689521652u;
			goto IL_298;
			IL_315:
			this.licenses_.Add(other.licenses_);
			arg_29D_0 = ((other.DefaultCurrency == 0u) ? 2642336378u : 3369202648u);
			goto IL_298;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_48C:
				uint num;
				uint arg_3D8_0 = ((num = input.ReadTag()) == 0u) ? 1928709294u : 1267001088u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3D8_0 ^ 1258752266u)) % 38u)
					{
					case 0u:
						this.Email = input.ReadString();
						arg_3D8_0 = 602145337u;
						continue;
					case 1u:
						arg_3D8_0 = ((num == 88u) ? 2074344266u : 1215346897u);
						continue;
					case 2u:
						arg_3D8_0 = (num2 * 4194898813u ^ 3781856029u);
						continue;
					case 3u:
						arg_3D8_0 = (((num != 26u) ? 1248229920u : 1221377777u) ^ num2 * 1607718105u);
						continue;
					case 4u:
						arg_3D8_0 = (num2 * 1274558833u ^ 2120020303u);
						continue;
					case 5u:
						this.FullName = input.ReadString();
						arg_3D8_0 = 671606904u;
						continue;
					case 6u:
						this.DefaultCurrency = input.ReadFixed32();
						arg_3D8_0 = 1150986238u;
						continue;
					case 7u:
						arg_3D8_0 = (((num == 66u) ? 1865446929u : 1623192361u) ^ num2 * 861012009u);
						continue;
					case 9u:
						this.ManualReview = input.ReadBool();
						arg_3D8_0 = 602145337u;
						continue;
					case 10u:
						this.Muted = input.ReadBool();
						arg_3D8_0 = 738989280u;
						continue;
					case 11u:
						arg_3D8_0 = (((num > 37u) ? 2186786834u : 3503449859u) ^ num2 * 3976234952u);
						continue;
					case 12u:
						arg_3D8_0 = (((num == 106u) ? 991663548u : 1666732995u) ^ num2 * 2028124512u);
						continue;
					case 13u:
						arg_3D8_0 = (num2 * 1725541289u ^ 1353637998u);
						continue;
					case 14u:
						arg_3D8_0 = ((num > 58u) ? 1815689027u : 1404593461u);
						continue;
					case 15u:
						arg_3D8_0 = (((num == 96u) ? 2491170430u : 2760707907u) ^ num2 * 3963145173u);
						continue;
					case 16u:
						this.AccountPaidAny = input.ReadBool();
						arg_3D8_0 = 846157532u;
						continue;
					case 17u:
						arg_3D8_0 = ((num > 80u) ? 683727089u : 1017350159u);
						continue;
					case 18u:
						arg_3D8_0 = ((num == 42u) ? 281464862u : 199707514u);
						continue;
					case 19u:
						arg_3D8_0 = (num2 * 3511810550u ^ 99511643u);
						continue;
					case 20u:
						arg_3D8_0 = (num2 * 1543879833u ^ 330594075u);
						continue;
					case 21u:
						arg_3D8_0 = (num2 * 3964556297u ^ 954709292u);
						continue;
					case 22u:
						this.Country = input.ReadString();
						arg_3D8_0 = 602145337u;
						continue;
					case 23u:
						arg_3D8_0 = (((num == 80u) ? 1254315168u : 1565435516u) ^ num2 * 3195951831u);
						continue;
					case 24u:
						this.licenses_.AddEntriesFrom(input, AccountLevelInfo._repeated_licenses_codec);
						arg_3D8_0 = 1628427509u;
						continue;
					case 25u:
						input.SkipLastField();
						arg_3D8_0 = 1959423817u;
						continue;
					case 26u:
						arg_3D8_0 = (num2 * 3725564116u ^ 154156403u);
						continue;
					case 27u:
						this.PreferredRegion = input.ReadUInt32();
						arg_3D8_0 = 602145337u;
						continue;
					case 28u:
						this.BattleTag = input.ReadString();
						arg_3D8_0 = 602145337u;
						continue;
					case 29u:
						arg_3D8_0 = (((num != 37u) ? 1676098291u : 1503022590u) ^ num2 * 172276680u);
						continue;
					case 30u:
						arg_3D8_0 = (((num == 58u) ? 1658493093u : 288680054u) ^ num2 * 2587183244u);
						continue;
					case 31u:
						this.identityCheckStatus_ = (IdentityVerificationStatus)input.ReadEnum();
						arg_3D8_0 = 602145337u;
						continue;
					case 32u:
						arg_3D8_0 = (((num != 48u) ? 2792946014u : 3164003955u) ^ num2 * 1914004496u);
						continue;
					case 33u:
						arg_3D8_0 = (num2 * 2953447043u ^ 707985376u);
						continue;
					case 34u:
						arg_3D8_0 = (((num == 72u) ? 1278589212u : 46949333u) ^ num2 * 2138091652u);
						continue;
					case 35u:
						arg_3D8_0 = 1267001088u;
						continue;
					case 36u:
						arg_3D8_0 = (num2 * 3241303602u ^ 1430241677u);
						continue;
					case 37u:
						goto IL_48C;
					}
					return;
				}
			}
		}

		static AccountLevelInfo()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 4133404150u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2471241398u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 2u:
						AccountLevelInfo._repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(26u, AccountLicense.Parser);
						arg_3F_0 = (num * 378406172u ^ 2338433229u);
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
