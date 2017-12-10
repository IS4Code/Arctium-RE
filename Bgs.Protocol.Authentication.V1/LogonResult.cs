using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class LogonResult : IMessage<LogonResult>, IEquatable<LogonResult>, IDeepCloneable<LogonResult>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly LogonResult.__c __9 = new LogonResult.__c();

			internal LogonResult cctor>b__69_0()
			{
				return new LogonResult();
			}
		}

		private static readonly MessageParser<LogonResult> _parser = new MessageParser<LogonResult>(new Func<LogonResult>(LogonResult.__c.__9.<.cctor>b__69_0));

		public const int ErrorCodeFieldNumber = 1;

		private uint errorCode_;

		public const int AccountIdFieldNumber = 2;

		private EntityId accountId_;

		public const int GameAccountIdFieldNumber = 3;

		private static readonly FieldCodec<EntityId> _repeated_gameAccountId_codec;

		private readonly RepeatedField<EntityId> gameAccountId_ = new RepeatedField<EntityId>();

		public const int EmailFieldNumber = 4;

		private string email_ = "";

		public const int AvailableRegionFieldNumber = 5;

		private static readonly FieldCodec<uint> _repeated_availableRegion_codec;

		private readonly RepeatedField<uint> availableRegion_ = new RepeatedField<uint>();

		public const int ConnectedRegionFieldNumber = 6;

		private uint connectedRegion_;

		public const int BattleTagFieldNumber = 7;

		private string battleTag_ = "";

		public const int GeoipCountryFieldNumber = 8;

		private string geoipCountry_ = "";

		public const int SessionKeyFieldNumber = 9;

		private ByteString sessionKey_ = ByteString.Empty;

		public const int RestrictedModeFieldNumber = 10;

		private bool restrictedMode_;

		public static MessageParser<LogonResult> Parser
		{
			get
			{
				return LogonResult._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonResult.Descriptor;
			}
		}

		public uint ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
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

		public RepeatedField<EntityId> GameAccountId
		{
			get
			{
				return this.gameAccountId_;
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

		public RepeatedField<uint> AvailableRegion
		{
			get
			{
				return this.availableRegion_;
			}
		}

		public uint ConnectedRegion
		{
			get
			{
				return this.connectedRegion_;
			}
			set
			{
				this.connectedRegion_ = value;
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

		public string GeoipCountry
		{
			get
			{
				return this.geoipCountry_;
			}
			set
			{
				this.geoipCountry_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_;
			}
			set
			{
				this.sessionKey_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public bool RestrictedMode
		{
			get
			{
				return this.restrictedMode_;
			}
			set
			{
				this.restrictedMode_ = value;
			}
		}

		public LogonResult()
		{
		}

		public LogonResult(LogonResult other) : this()
		{
			while (true)
			{
				IL_109:
				uint arg_DD_0 = 2656345294u;
				while (true)
				{
					uint num;
					switch ((num = (arg_DD_0 ^ 2937911303u)) % 8u)
					{
					case 0u:
						this.connectedRegion_ = other.connectedRegion_;
						arg_DD_0 = (num * 1879634561u ^ 2345160893u);
						continue;
					case 1u:
						this.errorCode_ = other.errorCode_;
						arg_DD_0 = (num * 4071658454u ^ 2921794690u);
						continue;
					case 2u:
						this.battleTag_ = other.battleTag_;
						this.geoipCountry_ = other.geoipCountry_;
						arg_DD_0 = (num * 159657533u ^ 1001780849u);
						continue;
					case 3u:
						this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
						arg_DD_0 = 3027974273u;
						continue;
					case 5u:
						goto IL_109;
					case 6u:
						this.gameAccountId_ = other.gameAccountId_.Clone();
						arg_DD_0 = (num * 24133105u ^ 3954953750u);
						continue;
					case 7u:
						this.email_ = other.email_;
						this.availableRegion_ = other.availableRegion_.Clone();
						arg_DD_0 = (num * 242279011u ^ 3728303674u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.sessionKey_ = other.sessionKey_;
			this.restrictedMode_ = other.restrictedMode_;
		}

		public LogonResult Clone()
		{
			return new LogonResult(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as LogonResult);
		}

		public bool Equals(LogonResult other)
		{
			if (other == null)
			{
				goto IL_D7;
			}
			goto IL_261;
			int arg_1E3_0;
			while (true)
			{
				IL_1DE:
				switch ((arg_1E3_0 ^ -1712411415) % 25)
				{
				case 0:
					arg_1E3_0 = ((!(this.SessionKey != other.SessionKey)) ? -67584741 : -1908013620);
					continue;
				case 1:
					return false;
				case 3:
					return false;
				case 4:
					arg_1E3_0 = ((this.RestrictedMode != other.RestrictedMode) ? -824332055 : -61473198);
					continue;
				case 5:
					return false;
				case 6:
					arg_1E3_0 = (LogonResult.smethod_1(this.BattleTag, other.BattleTag) ? -57823125 : -942453634);
					continue;
				case 7:
					return false;
				case 8:
					arg_1E3_0 = ((this.ErrorCode != other.ErrorCode) ? -25452810 : -1232309767);
					continue;
				case 9:
					arg_1E3_0 = (this.availableRegion_.Equals(other.availableRegion_) ? -304321448 : -543263712);
					continue;
				case 10:
					arg_1E3_0 = ((this.ConnectedRegion != other.ConnectedRegion) ? -860836687 : -1479022463);
					continue;
				case 11:
					return true;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					goto IL_D7;
				case 16:
					arg_1E3_0 = (this.gameAccountId_.Equals(other.gameAccountId_) ? -1987449712 : -1848520566);
					continue;
				case 17:
					return false;
				case 18:
					return false;
				case 19:
					arg_1E3_0 = (LogonResult.smethod_1(this.Email, other.Email) ? -200634760 : -1510655246);
					continue;
				case 20:
					arg_1E3_0 = ((!LogonResult.smethod_1(this.GeoipCountry, other.GeoipCountry)) ? -301275178 : -969204290);
					continue;
				case 21:
					return false;
				case 22:
					arg_1E3_0 = ((!LogonResult.smethod_0(this.AccountId, other.AccountId)) ? -1455721418 : -898992129);
					continue;
				case 23:
					goto IL_261;
				case 24:
					return false;
				}
				break;
			}
			return true;
			IL_D7:
			arg_1E3_0 = -513915358;
			goto IL_1DE;
			IL_261:
			arg_1E3_0 = ((other == this) ? -1817118660 : -1562897735);
			goto IL_1DE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_289:
				uint arg_238_0 = 2611091133u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_238_0 ^ 2455853135u)) % 17u)
					{
					case 0u:
						num ^= this.Email.GetHashCode();
						arg_238_0 = (num2 * 1593602672u ^ 530332312u);
						continue;
					case 1u:
						num ^= this.SessionKey.GetHashCode();
						arg_238_0 = (num2 * 3946331421u ^ 244254375u);
						continue;
					case 2u:
						goto IL_289;
					case 3u:
						num ^= this.RestrictedMode.GetHashCode();
						arg_238_0 = (num2 * 1662842416u ^ 1861108663u);
						continue;
					case 5u:
						arg_238_0 = ((this.BattleTag.Length != 0) ? 2870892781u : 2200441046u);
						continue;
					case 6u:
						num ^= this.BattleTag.GetHashCode();
						arg_238_0 = (num2 * 3240484606u ^ 3838905450u);
						continue;
					case 7u:
						num ^= this.availableRegion_.GetHashCode();
						arg_238_0 = ((this.ConnectedRegion != 0u) ? 3580544234u : 3181989962u);
						continue;
					case 8u:
						num ^= this.gameAccountId_.GetHashCode();
						arg_238_0 = ((this.Email.Length == 0) ? 2789202024u : 3576475126u);
						continue;
					case 9u:
						arg_238_0 = ((this.GeoipCountry.Length != 0) ? 2306659965u : 2250782442u);
						continue;
					case 10u:
						num ^= this.GeoipCountry.GetHashCode();
						arg_238_0 = (num2 * 3575759507u ^ 1610923100u);
						continue;
					case 11u:
						arg_238_0 = ((this.SessionKey.Length != 0) ? 2171047880u : 3576075244u);
						continue;
					case 12u:
						num ^= this.ConnectedRegion.GetHashCode();
						arg_238_0 = (num2 * 65946709u ^ 2171963011u);
						continue;
					case 13u:
						num ^= this.AccountId.GetHashCode();
						arg_238_0 = (num2 * 854068324u ^ 1182720352u);
						continue;
					case 14u:
						num ^= this.ErrorCode.GetHashCode();
						arg_238_0 = (num2 * 2756751042u ^ 654011663u);
						continue;
					case 15u:
						arg_238_0 = ((!this.RestrictedMode) ? 3152468759u : 3710236449u);
						continue;
					case 16u:
						arg_238_0 = (((this.accountId_ == null) ? 2164354512u : 3213748185u) ^ num2 * 3783344562u);
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
			output.WriteRawTag(8);
			output.WriteUInt32(this.ErrorCode);
			if (this.accountId_ != null)
			{
				goto IL_148;
			}
			goto IL_301;
			uint arg_28D_0;
			while (true)
			{
				IL_288:
				uint num;
				switch ((num = (arg_28D_0 ^ 54218022u)) % 22u)
				{
				case 0u:
					output.WriteRawTag(58);
					arg_28D_0 = (num * 2236862510u ^ 794672973u);
					continue;
				case 1u:
					output.WriteRawTag(66);
					arg_28D_0 = (num * 2100745797u ^ 1022260398u);
					continue;
				case 2u:
					arg_28D_0 = (this.RestrictedMode ? 833056810u : 787011216u);
					continue;
				case 3u:
					arg_28D_0 = (((this.ConnectedRegion == 0u) ? 2251395430u : 3315765789u) ^ num * 4033531203u);
					continue;
				case 4u:
					output.WriteRawTag(18);
					output.WriteMessage(this.AccountId);
					arg_28D_0 = (num * 570875430u ^ 4257957290u);
					continue;
				case 5u:
					output.WriteString(this.GeoipCountry);
					arg_28D_0 = (num * 3861040104u ^ 3702905464u);
					continue;
				case 6u:
					output.WriteBytes(this.SessionKey);
					arg_28D_0 = (num * 774802195u ^ 3824666454u);
					continue;
				case 7u:
					output.WriteBool(this.RestrictedMode);
					arg_28D_0 = (num * 2332776329u ^ 2092346073u);
					continue;
				case 8u:
					output.WriteRawTag(74);
					arg_28D_0 = (num * 2532135182u ^ 2476961898u);
					continue;
				case 9u:
					arg_28D_0 = ((LogonResult.smethod_2(this.GeoipCountry) != 0) ? 455493491u : 1715536016u);
					continue;
				case 11u:
					goto IL_148;
				case 12u:
					output.WriteRawTag(80);
					arg_28D_0 = (num * 1579501697u ^ 4199637227u);
					continue;
				case 13u:
					arg_28D_0 = ((LogonResult.smethod_2(this.BattleTag) == 0) ? 1858200609u : 2137559968u);
					continue;
				case 14u:
					arg_28D_0 = ((this.SessionKey.Length == 0) ? 2060820186u : 406866874u);
					continue;
				case 15u:
					output.WriteString(this.Email);
					arg_28D_0 = (num * 3632893437u ^ 2508902862u);
					continue;
				case 16u:
					output.WriteRawTag(48);
					arg_28D_0 = (num * 2342332393u ^ 3810939757u);
					continue;
				case 17u:
					output.WriteUInt32(this.ConnectedRegion);
					arg_28D_0 = (num * 3826780078u ^ 3681592697u);
					continue;
				case 18u:
					output.WriteRawTag(34);
					arg_28D_0 = (num * 1289884364u ^ 2403577299u);
					continue;
				case 19u:
					this.availableRegion_.WriteTo(output, LogonResult._repeated_availableRegion_codec);
					arg_28D_0 = 2041936893u;
					continue;
				case 20u:
					goto IL_301;
				case 21u:
					output.WriteString(this.BattleTag);
					arg_28D_0 = (num * 362167266u ^ 1966585151u);
					continue;
				}
				break;
			}
			return;
			IL_148:
			arg_28D_0 = 990203072u;
			goto IL_288;
			IL_301:
			this.gameAccountId_.WriteTo(output, LogonResult._repeated_gameAccountId_codec);
			arg_28D_0 = ((LogonResult.smethod_2(this.Email) == 0) ? 950819263u : 1913272658u);
			goto IL_288;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_291:
				uint arg_240_0 = 3744649728u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_240_0 ^ 3122401839u)) % 17u)
					{
					case 1u:
						arg_240_0 = ((this.SessionKey.Length == 0) ? 4211162998u : 2227651273u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
						arg_240_0 = (num2 * 1336245311u ^ 3593701166u);
						continue;
					case 3u:
						arg_240_0 = ((LogonResult.smethod_2(this.GeoipCountry) != 0) ? 2331491522u : 2745061080u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConnectedRegion);
						arg_240_0 = (num2 * 3309616568u ^ 149511541u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
						arg_240_0 = (num2 * 1830583973u ^ 3797181507u);
						continue;
					case 6u:
						arg_240_0 = (((this.ConnectedRegion != 0u) ? 2473230284u : 2950969001u) ^ num2 * 2530498183u);
						continue;
					case 7u:
						arg_240_0 = (this.RestrictedMode ? 4224205726u : 3175073643u);
						continue;
					case 8u:
						num += 2;
						arg_240_0 = (num2 * 2441964404u ^ 1827223647u);
						continue;
					case 9u:
						num += this.gameAccountId_.CalculateSize(LogonResult._repeated_gameAccountId_codec);
						arg_240_0 = ((LogonResult.smethod_2(this.Email) != 0) ? 3981870582u : 2767650121u);
						continue;
					case 10u:
						num += this.availableRegion_.CalculateSize(LogonResult._repeated_availableRegion_codec);
						arg_240_0 = 2742678307u;
						continue;
					case 11u:
						goto IL_291;
					case 12u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
						arg_240_0 = (((this.accountId_ == null) ? 37075551u : 597074860u) ^ num2 * 4071181199u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
						arg_240_0 = (num2 * 2647941721u ^ 548279424u);
						continue;
					case 14u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.GeoipCountry);
						arg_240_0 = (num2 * 81661870u ^ 3613951694u);
						continue;
					case 15u:
						arg_240_0 = ((LogonResult.smethod_2(this.BattleTag) == 0) ? 3441368875u : 3368733543u);
						continue;
					case 16u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_240_0 = (num2 * 3358043513u ^ 4000716460u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(LogonResult other)
		{
			if (other == null)
			{
				goto IL_29B;
			}
			goto IL_31D;
			uint arg_2A5_0;
			while (true)
			{
				IL_2A0:
				uint num;
				switch ((num = (arg_2A5_0 ^ 4157629640u)) % 23u)
				{
				case 0u:
					goto IL_29B;
				case 1u:
					return;
				case 2u:
					goto IL_31D;
				case 3u:
					arg_2A5_0 = ((LogonResult.smethod_2(other.BattleTag) != 0) ? 2249356349u : 3062345094u);
					continue;
				case 4u:
					this.GeoipCountry = other.GeoipCountry;
					arg_2A5_0 = (num * 1553243588u ^ 1773893837u);
					continue;
				case 5u:
					arg_2A5_0 = (other.RestrictedMode ? 4242257222u : 2465691387u);
					continue;
				case 6u:
					arg_2A5_0 = (((other.ConnectedRegion != 0u) ? 2811432812u : 3775641821u) ^ num * 2114504872u);
					continue;
				case 7u:
					this.BattleTag = other.BattleTag;
					arg_2A5_0 = (num * 3480789633u ^ 2581215475u);
					continue;
				case 8u:
					this.ConnectedRegion = other.ConnectedRegion;
					arg_2A5_0 = (num * 3175961466u ^ 2118666381u);
					continue;
				case 10u:
					arg_2A5_0 = (((this.accountId_ == null) ? 4049523727u : 2971727912u) ^ num * 3872610211u);
					continue;
				case 11u:
					arg_2A5_0 = ((other.SessionKey.Length == 0) ? 2881419796u : 3633593735u);
					continue;
				case 12u:
					this.Email = other.Email;
					arg_2A5_0 = (num * 3317560004u ^ 3097421970u);
					continue;
				case 13u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_2A5_0 = 2567952570u;
					continue;
				case 14u:
					this.availableRegion_.Add(other.availableRegion_);
					arg_2A5_0 = 3190260081u;
					continue;
				case 15u:
					this.RestrictedMode = other.RestrictedMode;
					arg_2A5_0 = (num * 3217903479u ^ 438849017u);
					continue;
				case 16u:
					arg_2A5_0 = (((LogonResult.smethod_2(other.Email) != 0) ? 3626120742u : 3809775335u) ^ num * 1245554397u);
					continue;
				case 17u:
					this.accountId_ = new EntityId();
					arg_2A5_0 = (num * 1156807718u ^ 94325072u);
					continue;
				case 18u:
					this.ErrorCode = other.ErrorCode;
					arg_2A5_0 = (num * 1483441727u ^ 1586331597u);
					continue;
				case 19u:
					this.SessionKey = other.SessionKey;
					arg_2A5_0 = (num * 4230498276u ^ 1849854280u);
					continue;
				case 20u:
					this.gameAccountId_.Add(other.gameAccountId_);
					arg_2A5_0 = 2765936501u;
					continue;
				case 21u:
					arg_2A5_0 = ((other.accountId_ == null) ? 2567952570u : 2931516530u);
					continue;
				case 22u:
					arg_2A5_0 = ((LogonResult.smethod_2(other.GeoipCountry) != 0) ? 2619093486u : 3541698517u);
					continue;
				}
				break;
			}
			return;
			IL_29B:
			arg_2A5_0 = 2784740459u;
			goto IL_2A0;
			IL_31D:
			arg_2A5_0 = ((other.ErrorCode != 0u) ? 2466058392u : 2416705661u);
			goto IL_2A0;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4D2:
				uint num;
				uint arg_416_0 = ((num = input.ReadTag()) == 0u) ? 1100098469u : 348859844u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_416_0 ^ 763073532u)) % 40u)
					{
					case 0u:
						arg_416_0 = (num2 * 2172617672u ^ 1843346550u);
						continue;
					case 1u:
						arg_416_0 = (num2 * 1615349396u ^ 4000277435u);
						continue;
					case 2u:
						arg_416_0 = ((this.accountId_ != null) ? 191091038u : 50140917u);
						continue;
					case 3u:
						this.availableRegion_.AddEntriesFrom(input, LogonResult._repeated_availableRegion_codec);
						arg_416_0 = 2128203194u;
						continue;
					case 4u:
						arg_416_0 = 348859844u;
						continue;
					case 5u:
						arg_416_0 = (num2 * 3177817960u ^ 1646510142u);
						continue;
					case 6u:
						arg_416_0 = (((num == 40u) ? 62587635u : 1518673041u) ^ num2 * 736965534u);
						continue;
					case 7u:
						arg_416_0 = (((num != 74u) ? 1666167250u : 347964368u) ^ num2 * 1484523772u);
						continue;
					case 8u:
						this.SessionKey = input.ReadBytes();
						arg_416_0 = 1889314523u;
						continue;
					case 10u:
						input.ReadMessage(this.accountId_);
						arg_416_0 = 797892441u;
						continue;
					case 11u:
						arg_416_0 = (((num <= 18u) ? 634959937u : 406427596u) ^ num2 * 2661949978u);
						continue;
					case 12u:
						arg_416_0 = ((num != 66u) ? 1882444987u : 62564513u);
						continue;
					case 13u:
						arg_416_0 = (num2 * 2534992932u ^ 1292624642u);
						continue;
					case 14u:
						arg_416_0 = (num2 * 2294553100u ^ 2220001150u);
						continue;
					case 15u:
						arg_416_0 = ((num > 58u) ? 1345554976u : 1186711664u);
						continue;
					case 16u:
						this.gameAccountId_.AddEntriesFrom(input, LogonResult._repeated_gameAccountId_codec);
						arg_416_0 = 816570932u;
						continue;
					case 17u:
						arg_416_0 = (num2 * 72923673u ^ 3567812494u);
						continue;
					case 18u:
						goto IL_4D2;
					case 19u:
						arg_416_0 = (num2 * 1956827662u ^ 2915586412u);
						continue;
					case 20u:
						arg_416_0 = (((num == 42u) ? 373265915u : 1943485447u) ^ num2 * 2462064977u);
						continue;
					case 21u:
						this.GeoipCountry = input.ReadString();
						arg_416_0 = 1117061174u;
						continue;
					case 22u:
						this.ConnectedRegion = input.ReadUInt32();
						arg_416_0 = 1117061174u;
						continue;
					case 23u:
						this.BattleTag = input.ReadString();
						arg_416_0 = 1398842455u;
						continue;
					case 24u:
						arg_416_0 = ((num <= 40u) ? 1344002911u : 956248963u);
						continue;
					case 25u:
						arg_416_0 = (((num != 58u) ? 1320429733u : 1559597311u) ^ num2 * 538027436u);
						continue;
					case 26u:
						arg_416_0 = (((num != 80u) ? 2055708235u : 745805162u) ^ num2 * 204015802u);
						continue;
					case 27u:
						arg_416_0 = (((num != 8u) ? 1606380354u : 114979748u) ^ num2 * 1928502728u);
						continue;
					case 28u:
						arg_416_0 = (((num == 34u) ? 3023450408u : 3513588770u) ^ num2 * 251142920u);
						continue;
					case 29u:
						arg_416_0 = (num2 * 286512771u ^ 1957359377u);
						continue;
					case 30u:
						arg_416_0 = ((num != 26u) ? 656680768u : 1348806636u);
						continue;
					case 31u:
						arg_416_0 = (num2 * 664201682u ^ 3463518408u);
						continue;
					case 32u:
						this.ErrorCode = input.ReadUInt32();
						arg_416_0 = 1202999409u;
						continue;
					case 33u:
						this.accountId_ = new EntityId();
						arg_416_0 = (num2 * 1410375303u ^ 1375233249u);
						continue;
					case 34u:
						this.RestrictedMode = input.ReadBool();
						arg_416_0 = 1117061174u;
						continue;
					case 35u:
						input.SkipLastField();
						arg_416_0 = 151720729u;
						continue;
					case 36u:
						this.Email = input.ReadString();
						arg_416_0 = 1117061174u;
						continue;
					case 37u:
						arg_416_0 = (num2 * 765013543u ^ 3054420412u);
						continue;
					case 38u:
						arg_416_0 = (((num == 18u) ? 3281916378u : 3882881113u) ^ num2 * 3267745042u);
						continue;
					case 39u:
						arg_416_0 = (((num == 48u) ? 308857601u : 1824859654u) ^ num2 * 1537564117u);
						continue;
					}
					return;
				}
			}
		}

		static LogonResult()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_76:
				uint arg_5A_0 = 832497899u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 1555164529u)) % 4u)
					{
					case 0u:
						goto IL_76;
					case 1u:
						LogonResult._repeated_availableRegion_codec = FieldCodec.ForUInt32(42u);
						arg_5A_0 = (num * 207475120u ^ 270425986u);
						continue;
					case 2u:
						LogonResult._repeated_gameAccountId_codec = FieldCodec.ForMessage<EntityId>(26u, EntityId.Parser);
						arg_5A_0 = (num * 597253937u ^ 2806366930u);
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

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
