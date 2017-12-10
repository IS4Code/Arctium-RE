using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class LogonRequest : IMessage<LogonRequest>, IEquatable<LogonRequest>, IDeepCloneable<LogonRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly LogonRequest.__c __9 = new LogonRequest.__c();

			internal LogonRequest cctor>b__89_0()
			{
				return new LogonRequest();
			}
		}

		private static readonly MessageParser<LogonRequest> _parser = new MessageParser<LogonRequest>(new Func<LogonRequest>(LogonRequest.__c.__9.<.cctor>b__89_0));

		public const int ProgramFieldNumber = 1;

		private string program_ = "";

		public const int PlatformFieldNumber = 2;

		private string platform_ = "";

		public const int LocaleFieldNumber = 3;

		private string locale_ = "";

		public const int EmailFieldNumber = 4;

		private string email_ = "";

		public const int VersionFieldNumber = 5;

		private string version_ = "";

		public const int ApplicationVersionFieldNumber = 6;

		private int applicationVersion_;

		public const int PublicComputerFieldNumber = 7;

		private bool publicComputer_;

		public const int SsoIdFieldNumber = 8;

		private ByteString ssoId_ = ByteString.Empty;

		public const int DisconnectOnCookieFailFieldNumber = 9;

		private bool disconnectOnCookieFail_;

		public const int AllowLogonQueueNotificationsFieldNumber = 10;

		private bool allowLogonQueueNotifications_;

		public const int WebClientVerificationFieldNumber = 11;

		private bool webClientVerification_;

		public const int CachedWebCredentialsFieldNumber = 12;

		private ByteString cachedWebCredentials_ = ByteString.Empty;

		public const int EnableCookieFieldNumber = 13;

		private bool enableCookie_;

		public const int UserAgentFieldNumber = 14;

		private string userAgent_ = "";

		public static MessageParser<LogonRequest> Parser
		{
			get
			{
				return LogonRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonRequest.Descriptor;
			}
		}

		public string Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string Locale
		{
			get
			{
				return this.locale_;
			}
			set
			{
				this.locale_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
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
				this.email_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public int ApplicationVersion
		{
			get
			{
				return this.applicationVersion_;
			}
			set
			{
				this.applicationVersion_ = value;
			}
		}

		public bool PublicComputer
		{
			get
			{
				return this.publicComputer_;
			}
			set
			{
				this.publicComputer_ = value;
			}
		}

		public ByteString SsoId
		{
			get
			{
				return this.ssoId_;
			}
			set
			{
				this.ssoId_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public bool DisconnectOnCookieFail
		{
			get
			{
				return this.disconnectOnCookieFail_;
			}
			set
			{
				this.disconnectOnCookieFail_ = value;
			}
		}

		public bool AllowLogonQueueNotifications
		{
			get
			{
				return this.allowLogonQueueNotifications_;
			}
			set
			{
				this.allowLogonQueueNotifications_ = value;
			}
		}

		public bool WebClientVerification
		{
			get
			{
				return this.webClientVerification_;
			}
			set
			{
				this.webClientVerification_ = value;
			}
		}

		public ByteString CachedWebCredentials
		{
			get
			{
				return this.cachedWebCredentials_;
			}
			set
			{
				this.cachedWebCredentials_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool EnableCookie
		{
			get
			{
				return this.enableCookie_;
			}
			set
			{
				this.enableCookie_ = value;
			}
		}

		public string UserAgent
		{
			get
			{
				return this.userAgent_;
			}
			set
			{
				this.userAgent_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public LogonRequest()
		{
		}

		public LogonRequest(LogonRequest other) : this()
		{
			this.program_ = other.program_;
			this.platform_ = other.platform_;
			this.locale_ = other.locale_;
			this.email_ = other.email_;
			this.version_ = other.version_;
			this.applicationVersion_ = other.applicationVersion_;
			this.publicComputer_ = other.publicComputer_;
			this.ssoId_ = other.ssoId_;
			this.disconnectOnCookieFail_ = other.disconnectOnCookieFail_;
			this.allowLogonQueueNotifications_ = other.allowLogonQueueNotifications_;
			this.webClientVerification_ = other.webClientVerification_;
			this.cachedWebCredentials_ = other.cachedWebCredentials_;
			this.enableCookie_ = other.enableCookie_;
			this.userAgent_ = other.userAgent_;
		}

		public LogonRequest Clone()
		{
			return new LogonRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as LogonRequest);
		}

		public bool Equals(LogonRequest other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_32B;
			int arg_28D_0;
			while (true)
			{
				IL_288:
				switch ((arg_28D_0 ^ -624451415) % 33)
				{
				case 0:
					arg_28D_0 = ((this.WebClientVerification == other.WebClientVerification) ? -353878660 : -1864779478);
					continue;
				case 1:
					arg_28D_0 = ((this.ApplicationVersion != other.ApplicationVersion) ? -1030451853 : -258771384);
					continue;
				case 2:
					arg_28D_0 = ((this.EnableCookie != other.EnableCookie) ? -1704431050 : -501403937);
					continue;
				case 3:
					arg_28D_0 = ((!LogonRequest.smethod_0(this.UserAgent, other.UserAgent)) ? -591818468 : -1358269044);
					continue;
				case 4:
					arg_28D_0 = ((!(this.SsoId != other.SsoId)) ? -637904810 : -1736154970);
					continue;
				case 5:
					arg_28D_0 = (LogonRequest.smethod_0(this.Email, other.Email) ? -1137417963 : -1008167692);
					continue;
				case 6:
					arg_28D_0 = ((!LogonRequest.smethod_0(this.Locale, other.Locale)) ? -435315410 : -2060443906);
					continue;
				case 7:
					arg_28D_0 = ((this.PublicComputer == other.PublicComputer) ? -1374669678 : -1504192134);
					continue;
				case 8:
					goto IL_32B;
				case 9:
					arg_28D_0 = (LogonRequest.smethod_0(this.Platform, other.Platform) ? -2060040324 : -955429483);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_28D_0 = ((this.DisconnectOnCookieFail != other.DisconnectOnCookieFail) ? -958646142 : -1505910930);
					continue;
				case 13:
					return false;
				case 14:
					arg_28D_0 = (LogonRequest.smethod_0(this.Program, other.Program) ? -146508907 : -90196792);
					continue;
				case 15:
					return false;
				case 16:
					arg_28D_0 = ((!LogonRequest.smethod_0(this.Version, other.Version)) ? -1202206414 : -1882836376);
					continue;
				case 17:
					return false;
				case 18:
					return false;
				case 19:
					goto IL_71;
				case 20:
					return false;
				case 21:
					return false;
				case 22:
					return false;
				case 23:
					return true;
				case 24:
					arg_28D_0 = ((this.AllowLogonQueueNotifications != other.AllowLogonQueueNotifications) ? -29951448 : -1774023606);
					continue;
				case 25:
					return false;
				case 26:
					return false;
				case 27:
					arg_28D_0 = ((!(this.CachedWebCredentials != other.CachedWebCredentials)) ? -1969595501 : -1266888876);
					continue;
				case 28:
					return false;
				case 30:
					return false;
				case 31:
					return false;
				case 32:
					return false;
				}
				break;
			}
			return true;
			IL_71:
			arg_28D_0 = -15379332;
			goto IL_288;
			IL_32B:
			arg_28D_0 = ((other == this) ? -2146521164 : -1223100167);
			goto IL_288;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (LogonRequest.smethod_1(this.Program) != 0)
			{
				goto IL_281;
			}
			goto IL_455;
			uint arg_3C5_0;
			while (true)
			{
				IL_3C0:
				uint num2;
				switch ((num2 = (arg_3C5_0 ^ 4274907584u)) % 29u)
				{
				case 0u:
					arg_3C5_0 = (this.EnableCookie ? 2209659900u : 3057852752u);
					continue;
				case 1u:
					num ^= LogonRequest.smethod_2(this.Email);
					arg_3C5_0 = (num2 * 1385320006u ^ 1591686055u);
					continue;
				case 2u:
					num ^= this.AllowLogonQueueNotifications.GetHashCode();
					arg_3C5_0 = (num2 * 276360317u ^ 3021235159u);
					continue;
				case 3u:
					num ^= LogonRequest.smethod_2(this.Platform);
					arg_3C5_0 = (num2 * 3883172438u ^ 1734514181u);
					continue;
				case 4u:
					arg_3C5_0 = ((LogonRequest.smethod_1(this.Locale) == 0) ? 3544159768u : 2974693986u);
					continue;
				case 5u:
					arg_3C5_0 = (this.AllowLogonQueueNotifications ? 2639383172u : 4018899939u);
					continue;
				case 6u:
					arg_3C5_0 = ((LogonRequest.smethod_1(this.Email) != 0) ? 3587599993u : 2294040881u);
					continue;
				case 7u:
					num ^= this.SsoId.GetHashCode();
					arg_3C5_0 = (num2 * 129551555u ^ 530497536u);
					continue;
				case 8u:
					arg_3C5_0 = ((this.SsoId.Length == 0) ? 2393722678u : 2313449810u);
					continue;
				case 9u:
					goto IL_281;
				case 10u:
					arg_3C5_0 = ((this.ApplicationVersion == 0) ? 2420401895u : 3695984682u);
					continue;
				case 11u:
					arg_3C5_0 = (this.WebClientVerification ? 3367259008u : 4171697669u);
					continue;
				case 12u:
					num ^= this.UserAgent.GetHashCode();
					arg_3C5_0 = (num2 * 564731163u ^ 2098669655u);
					continue;
				case 13u:
					num ^= this.EnableCookie.GetHashCode();
					arg_3C5_0 = (num2 * 29123883u ^ 648109380u);
					continue;
				case 14u:
					arg_3C5_0 = ((this.CachedWebCredentials.Length == 0) ? 3057888431u : 4109558594u);
					continue;
				case 15u:
					arg_3C5_0 = ((LogonRequest.smethod_1(this.Version) == 0) ? 2644340678u : 4087937896u);
					continue;
				case 16u:
					arg_3C5_0 = ((this.UserAgent.Length != 0) ? 3626327906u : 2537207105u);
					continue;
				case 17u:
					num ^= this.ApplicationVersion.GetHashCode();
					arg_3C5_0 = (num2 * 1964770727u ^ 37424961u);
					continue;
				case 18u:
					num ^= LogonRequest.smethod_2(this.Locale);
					arg_3C5_0 = (num2 * 394351375u ^ 1271364198u);
					continue;
				case 19u:
					arg_3C5_0 = ((!this.PublicComputer) ? 3091421971u : 3202183215u);
					continue;
				case 20u:
					goto IL_455;
				case 21u:
					num ^= LogonRequest.smethod_2(this.Version);
					arg_3C5_0 = (num2 * 2608728721u ^ 4063710958u);
					continue;
				case 22u:
					num ^= this.DisconnectOnCookieFail.GetHashCode();
					arg_3C5_0 = (num2 * 1220219704u ^ 1356250362u);
					continue;
				case 23u:
					num ^= this.PublicComputer.GetHashCode();
					arg_3C5_0 = (num2 * 1113759175u ^ 1049518298u);
					continue;
				case 24u:
					num ^= this.WebClientVerification.GetHashCode();
					arg_3C5_0 = (num2 * 1145498210u ^ 2667156101u);
					continue;
				case 25u:
					arg_3C5_0 = (this.DisconnectOnCookieFail ? 2887504392u : 2696042298u);
					continue;
				case 26u:
					num ^= LogonRequest.smethod_2(this.Program);
					arg_3C5_0 = (num2 * 3029002064u ^ 3791947398u);
					continue;
				case 28u:
					num ^= this.CachedWebCredentials.GetHashCode();
					arg_3C5_0 = (num2 * 2176089512u ^ 3500930047u);
					continue;
				}
				break;
			}
			return num;
			IL_281:
			arg_3C5_0 = 3290500878u;
			goto IL_3C0;
			IL_455:
			arg_3C5_0 = ((LogonRequest.smethod_1(this.Platform) != 0) ? 3618536814u : 3199129713u);
			goto IL_3C0;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (LogonRequest.smethod_1(this.Program) != 0)
			{
				goto IL_49A;
			}
			goto IL_558;
			uint arg_4A4_0;
			while (true)
			{
				IL_49F:
				uint num;
				switch ((num = (arg_4A4_0 ^ 551742756u)) % 38u)
				{
				case 0u:
					goto IL_49A;
				case 1u:
					arg_4A4_0 = ((!this.EnableCookie) ? 2113981662u : 386258971u);
					continue;
				case 2u:
					output.WriteString(this.Platform);
					arg_4A4_0 = (num * 3766197311u ^ 1615202062u);
					continue;
				case 3u:
					output.WriteRawTag(98);
					arg_4A4_0 = (num * 1168921667u ^ 3342890475u);
					continue;
				case 4u:
					arg_4A4_0 = (this.AllowLogonQueueNotifications ? 1184087411u : 1988075115u);
					continue;
				case 5u:
					output.WriteRawTag(26);
					output.WriteString(this.Locale);
					arg_4A4_0 = (num * 1746083287u ^ 3268132534u);
					continue;
				case 6u:
					arg_4A4_0 = (this.DisconnectOnCookieFail ? 1955983995u : 769054282u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					output.WriteString(this.Program);
					arg_4A4_0 = (num * 2858193803u ^ 3678218205u);
					continue;
				case 8u:
					output.WriteRawTag(42);
					output.WriteString(this.Version);
					arg_4A4_0 = (num * 2940775595u ^ 1029533728u);
					continue;
				case 9u:
					output.WriteRawTag(104);
					arg_4A4_0 = (num * 2148026300u ^ 1943758644u);
					continue;
				case 10u:
					output.WriteRawTag(114);
					arg_4A4_0 = (num * 695238446u ^ 2556537128u);
					continue;
				case 11u:
					arg_4A4_0 = (this.PublicComputer ? 1713071853u : 679089981u);
					continue;
				case 12u:
					output.WriteRawTag(34);
					arg_4A4_0 = (num * 87125895u ^ 2961465305u);
					continue;
				case 13u:
					arg_4A4_0 = ((this.SsoId.Length == 0) ? 2076049822u : 1535486430u);
					continue;
				case 14u:
					output.WriteBool(this.EnableCookie);
					arg_4A4_0 = (num * 2800021785u ^ 221790698u);
					continue;
				case 15u:
					output.WriteRawTag(80);
					arg_4A4_0 = (num * 4216925864u ^ 3049821537u);
					continue;
				case 16u:
					output.WriteString(this.UserAgent);
					arg_4A4_0 = (num * 3805668281u ^ 4122465780u);
					continue;
				case 17u:
					output.WriteRawTag(88);
					arg_4A4_0 = (num * 295366989u ^ 242132432u);
					continue;
				case 18u:
					output.WriteBytes(this.CachedWebCredentials);
					arg_4A4_0 = (num * 1137512744u ^ 1615381031u);
					continue;
				case 19u:
					arg_4A4_0 = ((LogonRequest.smethod_1(this.Email) != 0) ? 762225298u : 13726793u);
					continue;
				case 20u:
					arg_4A4_0 = ((LogonRequest.smethod_1(this.Locale) == 0) ? 826289281u : 1751125893u);
					continue;
				case 21u:
					arg_4A4_0 = ((this.CachedWebCredentials.Length != 0) ? 1234955303u : 1420278999u);
					continue;
				case 22u:
					goto IL_558;
				case 23u:
					output.WriteBool(this.PublicComputer);
					arg_4A4_0 = (num * 365761376u ^ 1829959581u);
					continue;
				case 25u:
					output.WriteBool(this.AllowLogonQueueNotifications);
					arg_4A4_0 = (num * 383173599u ^ 3086236520u);
					continue;
				case 26u:
					output.WriteRawTag(18);
					arg_4A4_0 = (num * 1396190342u ^ 373718400u);
					continue;
				case 27u:
					arg_4A4_0 = ((LogonRequest.smethod_1(this.Version) != 0) ? 270831956u : 1122840304u);
					continue;
				case 28u:
					output.WriteRawTag(48);
					arg_4A4_0 = (num * 605244989u ^ 1541056270u);
					continue;
				case 29u:
					output.WriteString(this.Email);
					arg_4A4_0 = (num * 533436969u ^ 1513685846u);
					continue;
				case 30u:
					arg_4A4_0 = ((this.ApplicationVersion == 0) ? 669740287u : 1910244154u);
					continue;
				case 31u:
					arg_4A4_0 = ((!this.WebClientVerification) ? 1705799969u : 902962751u);
					continue;
				case 32u:
					output.WriteInt32(this.ApplicationVersion);
					arg_4A4_0 = (num * 991911570u ^ 1778817063u);
					continue;
				case 33u:
					output.WriteRawTag(56);
					arg_4A4_0 = (num * 2179831287u ^ 1525468692u);
					continue;
				case 34u:
					output.WriteRawTag(66);
					output.WriteBytes(this.SsoId);
					arg_4A4_0 = (num * 4292429565u ^ 3563816588u);
					continue;
				case 35u:
					output.WriteBool(this.WebClientVerification);
					arg_4A4_0 = (num * 3053403724u ^ 622573285u);
					continue;
				case 36u:
					arg_4A4_0 = ((LogonRequest.smethod_1(this.UserAgent) != 0) ? 793732044u : 130392360u);
					continue;
				case 37u:
					output.WriteRawTag(72);
					output.WriteBool(this.DisconnectOnCookieFail);
					arg_4A4_0 = (num * 1631592045u ^ 4008946489u);
					continue;
				}
				break;
			}
			return;
			IL_49A:
			arg_4A4_0 = 947973875u;
			goto IL_49F;
			IL_558:
			arg_4A4_0 = ((LogonRequest.smethod_1(this.Platform) != 0) ? 822527472u : 282087338u);
			goto IL_49F;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_448:
				uint arg_3C3_0 = 835489097u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3C3_0 ^ 1073333089u)) % 30u)
					{
					case 0u:
						arg_3C3_0 = ((LogonRequest.smethod_1(this.Locale) != 0) ? 1682846710u : 1375466767u);
						continue;
					case 1u:
						arg_3C3_0 = ((!this.AllowLogonQueueNotifications) ? 1734522112u : 84415537u);
						continue;
					case 2u:
						num += 2;
						arg_3C3_0 = (num2 * 228148763u ^ 4283351000u);
						continue;
					case 3u:
						arg_3C3_0 = ((this.CachedWebCredentials.Length == 0) ? 2007374073u : 1984595259u);
						continue;
					case 4u:
						arg_3C3_0 = ((this.SsoId.Length == 0) ? 1083234918u : 1506231760u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Locale);
						arg_3C3_0 = (num2 * 2547495170u ^ 1432534305u);
						continue;
					case 6u:
						arg_3C3_0 = ((LogonRequest.smethod_1(this.Email) != 0) ? 935517770u : 592690942u);
						continue;
					case 7u:
						arg_3C3_0 = ((LogonRequest.smethod_1(this.Platform) != 0) ? 1676855956u : 1952137697u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
						arg_3C3_0 = (num2 * 3957165519u ^ 2958375817u);
						continue;
					case 9u:
						arg_3C3_0 = (this.DisconnectOnCookieFail ? 1963824673u : 354075160u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.ApplicationVersion);
						arg_3C3_0 = (num2 * 1606888652u ^ 1237266930u);
						continue;
					case 11u:
						num += 2;
						arg_3C3_0 = (num2 * 4112265570u ^ 1286277208u);
						continue;
					case 12u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Program);
						arg_3C3_0 = (num2 * 2620516617u ^ 2997328208u);
						continue;
					case 13u:
						num += 2;
						arg_3C3_0 = (num2 * 1738582862u ^ 3498452591u);
						continue;
					case 14u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.UserAgent);
						arg_3C3_0 = (num2 * 1432016956u ^ 3357586970u);
						continue;
					case 16u:
						arg_3C3_0 = ((LogonRequest.smethod_1(this.UserAgent) == 0) ? 80842130u : 707024799u);
						continue;
					case 17u:
						arg_3C3_0 = ((LogonRequest.smethod_1(this.Version) != 0) ? 1118784359u : 1095004499u);
						continue;
					case 18u:
						arg_3C3_0 = ((this.ApplicationVersion != 0) ? 1794576771u : 1443091946u);
						continue;
					case 19u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
						arg_3C3_0 = (num2 * 2333523838u ^ 568250068u);
						continue;
					case 20u:
						arg_3C3_0 = (((LogonRequest.smethod_1(this.Program) != 0) ? 3180012199u : 2483911046u) ^ num2 * 2096727127u);
						continue;
					case 21u:
						arg_3C3_0 = (this.PublicComputer ? 840006018u : 68727877u);
						continue;
					case 22u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.CachedWebCredentials);
						arg_3C3_0 = (num2 * 1048721411u ^ 3986136055u);
						continue;
					case 23u:
						arg_3C3_0 = ((!this.WebClientVerification) ? 781176022u : 569682710u);
						continue;
					case 24u:
						num += 2;
						arg_3C3_0 = (num2 * 794839526u ^ 1053816032u);
						continue;
					case 25u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.SsoId);
						arg_3C3_0 = (num2 * 596802020u ^ 3789243586u);
						continue;
					case 26u:
						num += 2;
						arg_3C3_0 = (num2 * 1777775339u ^ 1561356697u);
						continue;
					case 27u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Platform);
						arg_3C3_0 = (num2 * 1499882127u ^ 3166902330u);
						continue;
					case 28u:
						arg_3C3_0 = ((!this.EnableCookie) ? 884220617u : 739389073u);
						continue;
					case 29u:
						goto IL_448;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(LogonRequest other)
		{
			if (other == null)
			{
				goto IL_5F;
			}
			goto IL_449;
			uint arg_3B1_0;
			while (true)
			{
				IL_3AC:
				uint num;
				switch ((num = (arg_3B1_0 ^ 45632921u)) % 31u)
				{
				case 0u:
					arg_3B1_0 = (other.PublicComputer ? 923119839u : 1599375736u);
					continue;
				case 1u:
					this.Version = other.Version;
					arg_3B1_0 = (num * 2046754500u ^ 831183556u);
					continue;
				case 2u:
					arg_3B1_0 = ((other.SsoId.Length == 0) ? 2040341273u : 1405205536u);
					continue;
				case 3u:
					this.PublicComputer = other.PublicComputer;
					arg_3B1_0 = (num * 2119225334u ^ 2171105852u);
					continue;
				case 4u:
					arg_3B1_0 = ((!other.EnableCookie) ? 692042171u : 797282795u);
					continue;
				case 5u:
					this.DisconnectOnCookieFail = other.DisconnectOnCookieFail;
					arg_3B1_0 = (num * 2948458062u ^ 1337742618u);
					continue;
				case 6u:
					goto IL_449;
				case 7u:
					arg_3B1_0 = (other.AllowLogonQueueNotifications ? 1138519231u : 255472494u);
					continue;
				case 8u:
					this.CachedWebCredentials = other.CachedWebCredentials;
					arg_3B1_0 = (num * 2934873551u ^ 4012844435u);
					continue;
				case 9u:
					arg_3B1_0 = ((LogonRequest.smethod_1(other.Platform) == 0) ? 2014633234u : 65354482u);
					continue;
				case 10u:
					arg_3B1_0 = ((other.CachedWebCredentials.Length != 0) ? 1093494867u : 1690129861u);
					continue;
				case 11u:
					arg_3B1_0 = ((LogonRequest.smethod_1(other.Email) != 0) ? 997307212u : 1120076108u);
					continue;
				case 12u:
					arg_3B1_0 = (other.DisconnectOnCookieFail ? 1586963951u : 953516782u);
					continue;
				case 13u:
					return;
				case 14u:
					arg_3B1_0 = ((LogonRequest.smethod_1(other.Version) == 0) ? 388390152u : 1923147130u);
					continue;
				case 15u:
					this.Program = other.Program;
					arg_3B1_0 = (num * 3331833768u ^ 4122650447u);
					continue;
				case 16u:
					this.UserAgent = other.UserAgent;
					arg_3B1_0 = (num * 3991172970u ^ 1750818535u);
					continue;
				case 17u:
					this.Locale = other.Locale;
					arg_3B1_0 = (num * 1461839585u ^ 2540913784u);
					continue;
				case 18u:
					arg_3B1_0 = (other.WebClientVerification ? 610639228u : 1399930228u);
					continue;
				case 19u:
					this.EnableCookie = other.EnableCookie;
					arg_3B1_0 = (num * 2601060676u ^ 3725535731u);
					continue;
				case 21u:
					this.Platform = other.Platform;
					arg_3B1_0 = (num * 1774630340u ^ 416598526u);
					continue;
				case 22u:
					arg_3B1_0 = ((LogonRequest.smethod_1(other.Locale) == 0) ? 323424413u : 648408860u);
					continue;
				case 23u:
					this.AllowLogonQueueNotifications = other.AllowLogonQueueNotifications;
					arg_3B1_0 = (num * 2566362415u ^ 3681353876u);
					continue;
				case 24u:
					this.SsoId = other.SsoId;
					arg_3B1_0 = (num * 3541005920u ^ 509724793u);
					continue;
				case 25u:
					this.Email = other.Email;
					arg_3B1_0 = (num * 1776963073u ^ 1407444377u);
					continue;
				case 26u:
					arg_3B1_0 = ((other.ApplicationVersion != 0) ? 2017837360u : 1849349608u);
					continue;
				case 27u:
					this.ApplicationVersion = other.ApplicationVersion;
					arg_3B1_0 = (num * 2659670447u ^ 3663871343u);
					continue;
				case 28u:
					goto IL_5F;
				case 29u:
					this.WebClientVerification = other.WebClientVerification;
					arg_3B1_0 = (num * 2778882127u ^ 2780982239u);
					continue;
				case 30u:
					arg_3B1_0 = ((LogonRequest.smethod_1(other.UserAgent) == 0) ? 1158754629u : 1253259444u);
					continue;
				}
				break;
			}
			return;
			IL_5F:
			arg_3B1_0 = 860163139u;
			goto IL_3AC;
			IL_449:
			arg_3B1_0 = ((LogonRequest.smethod_1(other.Program) == 0) ? 956815311u : 1637201481u);
			goto IL_3AC;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_5FE:
				uint num;
				uint arg_51A_0 = ((num = input.ReadTag()) == 0u) ? 2806874945u : 2563765579u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_51A_0 ^ 2477557800u)) % 50u)
					{
					case 0u:
						this.PublicComputer = input.ReadBool();
						arg_51A_0 = 2324673480u;
						continue;
					case 1u:
						this.DisconnectOnCookieFail = input.ReadBool();
						arg_51A_0 = 2870668129u;
						continue;
					case 2u:
						this.Program = input.ReadString();
						arg_51A_0 = 3796214575u;
						continue;
					case 4u:
						arg_51A_0 = (((num == 72u) ? 2169694357u : 3732286631u) ^ num2 * 1964943086u);
						continue;
					case 5u:
						this.Locale = input.ReadString();
						arg_51A_0 = 2870668129u;
						continue;
					case 6u:
						this.SsoId = input.ReadBytes();
						arg_51A_0 = 2870668129u;
						continue;
					case 7u:
						arg_51A_0 = 2563765579u;
						continue;
					case 8u:
						this.ApplicationVersion = input.ReadInt32();
						arg_51A_0 = 2870668129u;
						continue;
					case 9u:
						arg_51A_0 = (((num != 80u) ? 2283742039u : 3331775815u) ^ num2 * 727158905u);
						continue;
					case 10u:
						arg_51A_0 = (((num == 42u) ? 3697760929u : 4239558633u) ^ num2 * 1868295782u);
						continue;
					case 11u:
						arg_51A_0 = (num2 * 253245460u ^ 4065464301u);
						continue;
					case 12u:
						input.SkipLastField();
						arg_51A_0 = 4028836251u;
						continue;
					case 13u:
						arg_51A_0 = (num2 * 4096632714u ^ 3967500602u);
						continue;
					case 14u:
						arg_51A_0 = (((num != 10u) ? 387449027u : 525461210u) ^ num2 * 2606574189u);
						continue;
					case 15u:
						goto IL_5FE;
					case 16u:
						arg_51A_0 = (num2 * 1707378045u ^ 609759040u);
						continue;
					case 17u:
						arg_51A_0 = (((num != 56u) ? 1412970047u : 374204389u) ^ num2 * 2576843055u);
						continue;
					case 18u:
						arg_51A_0 = (num2 * 3892803957u ^ 2182300654u);
						continue;
					case 19u:
						arg_51A_0 = ((num <= 98u) ? 3611251904u : 2612344609u);
						continue;
					case 20u:
						arg_51A_0 = (((num != 98u) ? 2404678744u : 3621986436u) ^ num2 * 4030314015u);
						continue;
					case 21u:
						arg_51A_0 = (num2 * 2827799656u ^ 1321316489u);
						continue;
					case 22u:
						this.Platform = input.ReadString();
						arg_51A_0 = 2917010841u;
						continue;
					case 23u:
						arg_51A_0 = (((num != 18u) ? 2221279314u : 3271214906u) ^ num2 * 2957171284u);
						continue;
					case 24u:
						this.AllowLogonQueueNotifications = input.ReadBool();
						arg_51A_0 = 2870668129u;
						continue;
					case 25u:
						arg_51A_0 = (((num > 26u) ? 1321181962u : 2020891856u) ^ num2 * 300399088u);
						continue;
					case 26u:
						arg_51A_0 = (num2 * 3280196461u ^ 813514608u);
						continue;
					case 27u:
						arg_51A_0 = (num2 * 2055232640u ^ 645383905u);
						continue;
					case 28u:
						arg_51A_0 = (((num != 114u) ? 4152711456u : 4130663585u) ^ num2 * 1774416940u);
						continue;
					case 29u:
						arg_51A_0 = (num2 * 2349516996u ^ 1665039053u);
						continue;
					case 30u:
						arg_51A_0 = (((num != 26u) ? 549294485u : 545159959u) ^ num2 * 1956346141u);
						continue;
					case 31u:
						arg_51A_0 = (num2 * 3834766207u ^ 1154589780u);
						continue;
					case 32u:
						arg_51A_0 = (((num == 88u) ? 2877457731u : 2902116216u) ^ num2 * 1928957040u);
						continue;
					case 33u:
						arg_51A_0 = ((num == 104u) ? 3151043620u : 3294957476u);
						continue;
					case 34u:
						arg_51A_0 = (((num != 66u) ? 3353732628u : 3033916600u) ^ num2 * 3694139700u);
						continue;
					case 35u:
						arg_51A_0 = (((num != 34u) ? 3253302790u : 2345559006u) ^ num2 * 3423809394u);
						continue;
					case 36u:
						this.Email = input.ReadString();
						arg_51A_0 = 2870668129u;
						continue;
					case 37u:
						this.Version = input.ReadString();
						arg_51A_0 = 3350093667u;
						continue;
					case 38u:
						arg_51A_0 = (num2 * 1333008647u ^ 3377817665u);
						continue;
					case 39u:
						arg_51A_0 = ((num <= 56u) ? 2554724371u : 2206722191u);
						continue;
					case 40u:
						this.EnableCookie = input.ReadBool();
						arg_51A_0 = 2406207519u;
						continue;
					case 41u:
						this.WebClientVerification = input.ReadBool();
						arg_51A_0 = 3212105075u;
						continue;
					case 42u:
						this.CachedWebCredentials = input.ReadBytes();
						arg_51A_0 = 2866468436u;
						continue;
					case 43u:
						arg_51A_0 = (num2 * 2981317732u ^ 879888988u);
						continue;
					case 44u:
						arg_51A_0 = ((num != 48u) ? 3744730423u : 3475540428u);
						continue;
					case 45u:
						arg_51A_0 = (num2 * 259521295u ^ 4138201944u);
						continue;
					case 46u:
						arg_51A_0 = ((num <= 42u) ? 2815725063u : 3476254602u);
						continue;
					case 47u:
						arg_51A_0 = ((num <= 80u) ? 2927941584u : 3378536197u);
						continue;
					case 48u:
						arg_51A_0 = (num2 * 495117516u ^ 2523615665u);
						continue;
					case 49u:
						this.UserAgent = input.ReadString();
						arg_51A_0 = 2870668129u;
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

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
