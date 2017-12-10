using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameLevelInfo : IMessage<GameLevelInfo>, IEquatable<GameLevelInfo>, IDeepCloneable<GameLevelInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameLevelInfo.__c __9 = new GameLevelInfo.__c();

			internal GameLevelInfo cctor>b__59_0()
			{
				return new GameLevelInfo();
			}
		}

		private static readonly MessageParser<GameLevelInfo> _parser = new MessageParser<GameLevelInfo>(new Func<GameLevelInfo>(GameLevelInfo.__c.__9.<.cctor>b__59_0));

		public const int IsTrialFieldNumber = 4;

		private bool isTrial_;

		public const int IsLifetimeFieldNumber = 5;

		private bool isLifetime_;

		public const int IsRestrictedFieldNumber = 6;

		private bool isRestricted_;

		public const int IsBetaFieldNumber = 7;

		private bool isBeta_;

		public const int NameFieldNumber = 8;

		private string name_ = "";

		public const int ProgramFieldNumber = 9;

		private uint program_;

		public const int LicensesFieldNumber = 10;

		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(82u, AccountLicense.Parser);

		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		public const int RealmPermissionsFieldNumber = 11;

		private uint realmPermissions_;

		public static MessageParser<GameLevelInfo> Parser
		{
			get
			{
				return GameLevelInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[21];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameLevelInfo.Descriptor;
			}
		}

		public bool IsTrial
		{
			get
			{
				return this.isTrial_;
			}
			set
			{
				this.isTrial_ = value;
			}
		}

		public bool IsLifetime
		{
			get
			{
				return this.isLifetime_;
			}
			set
			{
				this.isLifetime_ = value;
			}
		}

		public bool IsRestricted
		{
			get
			{
				return this.isRestricted_;
			}
			set
			{
				this.isRestricted_ = value;
			}
		}

		public bool IsBeta
		{
			get
			{
				return this.isBeta_;
			}
			set
			{
				this.isBeta_ = value;
			}
		}

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		public uint RealmPermissions
		{
			get
			{
				return this.realmPermissions_;
			}
			set
			{
				this.realmPermissions_ = value;
			}
		}

		public GameLevelInfo()
		{
		}

		public GameLevelInfo(GameLevelInfo other) : this()
		{
			while (true)
			{
				IL_FC:
				uint arg_D0_0 = 3831877765u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D0_0 ^ 4040861540u)) % 8u)
					{
					case 0u:
						this.name_ = other.name_;
						arg_D0_0 = (num * 629451537u ^ 2582145168u);
						continue;
					case 1u:
						this.isTrial_ = other.isTrial_;
						arg_D0_0 = (num * 3482620950u ^ 165051613u);
						continue;
					case 2u:
						this.realmPermissions_ = other.realmPermissions_;
						arg_D0_0 = (num * 3136489934u ^ 4184198203u);
						continue;
					case 4u:
						this.program_ = other.program_;
						this.licenses_ = other.licenses_.Clone();
						arg_D0_0 = (num * 336958238u ^ 629760782u);
						continue;
					case 5u:
						goto IL_FC;
					case 6u:
						this.isBeta_ = other.isBeta_;
						arg_D0_0 = (num * 2462275809u ^ 3140594930u);
						continue;
					case 7u:
						this.isLifetime_ = other.isLifetime_;
						this.isRestricted_ = other.isRestricted_;
						arg_D0_0 = (num * 3553319540u ^ 3439735814u);
						continue;
					}
					return;
				}
			}
		}

		public GameLevelInfo Clone()
		{
			return new GameLevelInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameLevelInfo);
		}

		public bool Equals(GameLevelInfo other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_1E1;
			int arg_173_0;
			while (true)
			{
				IL_16E:
				switch ((arg_173_0 ^ 1885273414) % 21)
				{
				case 0:
					return false;
				case 1:
					arg_173_0 = ((this.IsTrial != other.IsTrial) ? 1929535328 : 1436553055);
					continue;
				case 2:
					arg_173_0 = ((this.Program == other.Program) ? 586656442 : 1236646568);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_1E1;
				case 5:
					arg_173_0 = ((!this.licenses_.Equals(other.licenses_)) ? 320192463 : 1570765094);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				case 10:
					arg_173_0 = ((this.IsRestricted == other.IsRestricted) ? 363057693 : 486955750);
					continue;
				case 11:
					arg_173_0 = ((this.RealmPermissions != other.RealmPermissions) ? 801146190 : 1435694157);
					continue;
				case 12:
					arg_173_0 = ((this.IsLifetime == other.IsLifetime) ? 7781599 : 1361527440);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					goto IL_71;
				case 16:
					arg_173_0 = (GameLevelInfo.smethod_0(this.Name, other.Name) ? 1840480526 : 1428925604);
					continue;
				case 17:
					return true;
				case 18:
					arg_173_0 = ((this.IsBeta != other.IsBeta) ? 1640520411 : 1842856770);
					continue;
				case 19:
					return false;
				case 20:
					return false;
				}
				break;
			}
			return true;
			IL_71:
			arg_173_0 = 1423133991;
			goto IL_16E;
			IL_1E1:
			arg_173_0 = ((other != this) ? 895815161 : 772916769);
			goto IL_16E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_251:
				uint arg_204_0 = 1514311322u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_204_0 ^ 1192711919u)) % 16u)
					{
					case 1u:
						arg_204_0 = ((this.Program == 0u) ? 975294224u : 2109345699u);
						continue;
					case 2u:
						num ^= this.IsBeta.GetHashCode();
						arg_204_0 = (num2 * 1796321651u ^ 2497012432u);
						continue;
					case 3u:
						num ^= this.IsLifetime.GetHashCode();
						arg_204_0 = (num2 * 3195525221u ^ 76565194u);
						continue;
					case 4u:
						num ^= this.IsTrial.GetHashCode();
						arg_204_0 = (num2 * 2372427828u ^ 750647593u);
						continue;
					case 5u:
						arg_204_0 = ((this.IsTrial ? 433821864u : 2000797626u) ^ num2 * 527510743u);
						continue;
					case 6u:
						arg_204_0 = ((!this.IsLifetime) ? 576702597u : 1643013196u);
						continue;
					case 7u:
						num ^= this.IsRestricted.GetHashCode();
						arg_204_0 = (num2 * 822307818u ^ 3029801332u);
						continue;
					case 8u:
						num ^= this.RealmPermissions.GetHashCode();
						arg_204_0 = (num2 * 1159865544u ^ 840838671u);
						continue;
					case 9u:
						arg_204_0 = ((this.Name.Length != 0) ? 836413588u : 299392030u);
						continue;
					case 10u:
						arg_204_0 = (this.IsRestricted ? 1231649288u : 223969618u);
						continue;
					case 11u:
						num ^= this.Name.GetHashCode();
						arg_204_0 = (num2 * 47910941u ^ 4021215217u);
						continue;
					case 12u:
						num ^= this.Program.GetHashCode();
						arg_204_0 = (num2 * 4022285138u ^ 3525669192u);
						continue;
					case 13u:
						arg_204_0 = (this.IsBeta ? 445969037u : 1939470550u);
						continue;
					case 14u:
						goto IL_251;
					case 15u:
						num ^= this.licenses_.GetHashCode();
						arg_204_0 = ((this.RealmPermissions == 0u) ? 1346653903u : 1605629239u);
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
			if (this.IsTrial)
			{
				goto IL_140;
			}
			goto IL_2CE;
			uint arg_25E_0;
			while (true)
			{
				IL_259:
				uint num;
				switch ((num = (arg_25E_0 ^ 3440882718u)) % 21u)
				{
				case 0u:
					arg_25E_0 = ((this.Program == 0u) ? 2804488601u : 3148684920u);
					continue;
				case 1u:
					arg_25E_0 = (this.IsBeta ? 3394815495u : 3510433595u);
					continue;
				case 2u:
					output.WriteBool(this.IsLifetime);
					arg_25E_0 = (num * 3050977698u ^ 3555153569u);
					continue;
				case 4u:
					output.WriteRawTag(88);
					arg_25E_0 = (num * 2607830190u ^ 2208922337u);
					continue;
				case 5u:
					output.WriteRawTag(48);
					output.WriteBool(this.IsRestricted);
					arg_25E_0 = (num * 1026163644u ^ 1132447768u);
					continue;
				case 6u:
					output.WriteString(this.Name);
					arg_25E_0 = (num * 2937931835u ^ 4059396027u);
					continue;
				case 7u:
					arg_25E_0 = (this.IsRestricted ? 2857334382u : 3333018200u);
					continue;
				case 8u:
					output.WriteUInt32(this.RealmPermissions);
					arg_25E_0 = (num * 1391018436u ^ 1460608401u);
					continue;
				case 9u:
					output.WriteRawTag(56);
					arg_25E_0 = (num * 3784511816u ^ 175143161u);
					continue;
				case 10u:
					goto IL_140;
				case 11u:
					arg_25E_0 = (((this.RealmPermissions == 0u) ? 660484212u : 1170352680u) ^ num * 230675669u);
					continue;
				case 12u:
					output.WriteRawTag(77);
					arg_25E_0 = (num * 1339186921u ^ 1836624007u);
					continue;
				case 13u:
					arg_25E_0 = ((GameLevelInfo.smethod_1(this.Name) == 0) ? 2568343022u : 4216682362u);
					continue;
				case 14u:
					this.licenses_.WriteTo(output, GameLevelInfo._repeated_licenses_codec);
					arg_25E_0 = 3677392531u;
					continue;
				case 15u:
					output.WriteRawTag(32);
					output.WriteBool(this.IsTrial);
					arg_25E_0 = (num * 2025186370u ^ 1030100403u);
					continue;
				case 16u:
					output.WriteRawTag(66);
					arg_25E_0 = (num * 451297976u ^ 359329105u);
					continue;
				case 17u:
					output.WriteBool(this.IsBeta);
					arg_25E_0 = (num * 1236928264u ^ 3425961795u);
					continue;
				case 18u:
					output.WriteRawTag(40);
					arg_25E_0 = (num * 1996593269u ^ 3781118624u);
					continue;
				case 19u:
					output.WriteFixed32(this.Program);
					arg_25E_0 = (num * 2838270209u ^ 3425520854u);
					continue;
				case 20u:
					goto IL_2CE;
				}
				break;
			}
			return;
			IL_140:
			arg_25E_0 = 2897302583u;
			goto IL_259;
			IL_2CE:
			arg_25E_0 = ((!this.IsLifetime) ? 3967527765u : 2670695754u);
			goto IL_259;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_22C:
				uint arg_1DB_0 = 2915159696u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1DB_0 ^ 3658811585u)) % 17u)
					{
					case 0u:
						goto IL_22C;
					case 1u:
						num += 5;
						arg_1DB_0 = (num2 * 1860022777u ^ 2061989508u);
						continue;
					case 2u:
						arg_1DB_0 = ((this.Program == 0u) ? 2800268383u : 2925942962u);
						continue;
					case 3u:
						num += 2;
						arg_1DB_0 = (num2 * 770439470u ^ 2696629813u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_1DB_0 = (num2 * 2419362954u ^ 2769857831u);
						continue;
					case 5u:
						arg_1DB_0 = (this.IsBeta ? 3249126575u : 3931878117u);
						continue;
					case 6u:
						arg_1DB_0 = (((this.RealmPermissions != 0u) ? 3275249579u : 3150859119u) ^ num2 * 3509259514u);
						continue;
					case 7u:
						num += 2;
						arg_1DB_0 = (num2 * 1648846009u ^ 1669041820u);
						continue;
					case 8u:
						arg_1DB_0 = ((GameLevelInfo.smethod_1(this.Name) == 0) ? 4059558661u : 4133945500u);
						continue;
					case 9u:
						num += this.licenses_.CalculateSize(GameLevelInfo._repeated_licenses_codec);
						arg_1DB_0 = 2921510807u;
						continue;
					case 10u:
						num += 2;
						arg_1DB_0 = (num2 * 3077631954u ^ 2621598605u);
						continue;
					case 12u:
						num += 2;
						arg_1DB_0 = (num2 * 1390390217u ^ 3520763579u);
						continue;
					case 13u:
						arg_1DB_0 = (this.IsLifetime ? 2939682914u : 3927124283u);
						continue;
					case 14u:
						arg_1DB_0 = ((!this.IsRestricted) ? 2502908725u : 3289518401u);
						continue;
					case 15u:
						arg_1DB_0 = (((!this.IsTrial) ? 8696296u : 658784229u) ^ num2 * 1026913538u);
						continue;
					case 16u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RealmPermissions);
						arg_1DB_0 = (num2 * 2625588845u ^ 2380493645u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameLevelInfo other)
		{
			if (other == null)
			{
				goto IL_134;
			}
			goto IL_239;
			uint arg_1D9_0;
			while (true)
			{
				IL_1D4:
				uint num;
				switch ((num = (arg_1D9_0 ^ 1462976142u)) % 17u)
				{
				case 0u:
					this.IsBeta = other.IsBeta;
					arg_1D9_0 = (num * 4154856037u ^ 4048222044u);
					continue;
				case 1u:
					arg_1D9_0 = ((GameLevelInfo.smethod_1(other.Name) == 0) ? 1599393483u : 1088842023u);
					continue;
				case 2u:
					this.Program = other.Program;
					arg_1D9_0 = (num * 1015017599u ^ 1349614454u);
					continue;
				case 3u:
					return;
				case 4u:
					this.RealmPermissions = other.RealmPermissions;
					arg_1D9_0 = (num * 163652205u ^ 1666757550u);
					continue;
				case 5u:
					arg_1D9_0 = ((!other.IsBeta) ? 1897512264u : 695568394u);
					continue;
				case 6u:
					goto IL_134;
				case 7u:
					this.licenses_.Add(other.licenses_);
					arg_1D9_0 = ((other.RealmPermissions == 0u) ? 1514046289u : 266543893u);
					continue;
				case 8u:
					this.IsLifetime = other.IsLifetime;
					arg_1D9_0 = (num * 3718689920u ^ 3927979769u);
					continue;
				case 9u:
					arg_1D9_0 = (other.IsRestricted ? 497849999u : 975880541u);
					continue;
				case 10u:
					arg_1D9_0 = (other.IsLifetime ? 583594299u : 376514681u);
					continue;
				case 11u:
					this.IsRestricted = other.IsRestricted;
					arg_1D9_0 = (num * 1934369830u ^ 3770013051u);
					continue;
				case 12u:
					arg_1D9_0 = ((other.Program != 0u) ? 2047221714u : 154449874u);
					continue;
				case 14u:
					this.IsTrial = other.IsTrial;
					arg_1D9_0 = (num * 3189358853u ^ 2936748929u);
					continue;
				case 15u:
					goto IL_239;
				case 16u:
					this.Name = other.Name;
					arg_1D9_0 = (num * 2628343277u ^ 2658831038u);
					continue;
				}
				break;
			}
			return;
			IL_134:
			arg_1D9_0 = 162682407u;
			goto IL_1D4;
			IL_239:
			arg_1D9_0 = (other.IsTrial ? 669076817u : 523590106u);
			goto IL_1D4;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3A4:
				uint num;
				uint arg_30C_0 = ((num = input.ReadTag()) != 0u) ? 3888080640u : 2939104691u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_30C_0 ^ 3578606165u)) % 31u)
					{
					case 0u:
						arg_30C_0 = (((num == 56u) ? 1563531086u : 1702289719u) ^ num2 * 3491373918u);
						continue;
					case 1u:
						this.Name = input.ReadString();
						arg_30C_0 = 2981099641u;
						continue;
					case 2u:
						arg_30C_0 = (num2 * 763200544u ^ 1019065860u);
						continue;
					case 3u:
						arg_30C_0 = ((num > 56u) ? 2193133336u : 2670541086u);
						continue;
					case 4u:
						arg_30C_0 = (((num != 40u) ? 1109181010u : 1693130014u) ^ num2 * 2491283931u);
						continue;
					case 5u:
						arg_30C_0 = (((num != 88u) ? 4122467846u : 3179901995u) ^ num2 * 1198545295u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_30C_0 = 2869794797u;
						continue;
					case 7u:
						arg_30C_0 = (num2 * 107773621u ^ 2347211285u);
						continue;
					case 8u:
						this.IsRestricted = input.ReadBool();
						arg_30C_0 = 2255245523u;
						continue;
					case 9u:
						arg_30C_0 = ((num != 82u) ? 4270703819u : 2404501259u);
						continue;
					case 10u:
						this.IsLifetime = input.ReadBool();
						arg_30C_0 = 3910746666u;
						continue;
					case 11u:
						arg_30C_0 = (num2 * 2983940867u ^ 2829260512u);
						continue;
					case 12u:
						arg_30C_0 = (num2 * 3221824298u ^ 337455535u);
						continue;
					case 13u:
						arg_30C_0 = (((num == 77u) ? 1135781216u : 1140749143u) ^ num2 * 3835847040u);
						continue;
					case 14u:
						this.IsTrial = input.ReadBool();
						arg_30C_0 = 3860906601u;
						continue;
					case 15u:
						arg_30C_0 = 3888080640u;
						continue;
					case 16u:
						this.licenses_.AddEntriesFrom(input, GameLevelInfo._repeated_licenses_codec);
						arg_30C_0 = 2981099641u;
						continue;
					case 17u:
						arg_30C_0 = ((num == 48u) ? 3883475998u : 3847481698u);
						continue;
					case 18u:
						arg_30C_0 = (num2 * 1520717367u ^ 4087809715u);
						continue;
					case 19u:
						this.RealmPermissions = input.ReadUInt32();
						arg_30C_0 = 2981099641u;
						continue;
					case 20u:
						arg_30C_0 = (((num > 40u) ? 2633313427u : 4032593125u) ^ num2 * 2927928898u);
						continue;
					case 21u:
						arg_30C_0 = (num2 * 3590906839u ^ 3914509809u);
						continue;
					case 23u:
						goto IL_3A4;
					case 24u:
						arg_30C_0 = (num2 * 747292950u ^ 3357728771u);
						continue;
					case 25u:
						arg_30C_0 = (((num == 32u) ? 2618108464u : 4089132162u) ^ num2 * 1226681553u);
						continue;
					case 26u:
						arg_30C_0 = (num2 * 3886128596u ^ 2643262468u);
						continue;
					case 27u:
						arg_30C_0 = (((num == 66u) ? 1820319622u : 1796425916u) ^ num2 * 508609638u);
						continue;
					case 28u:
						this.Program = input.ReadFixed32();
						arg_30C_0 = 2442031362u;
						continue;
					case 29u:
						this.IsBeta = input.ReadBool();
						arg_30C_0 = 2981099641u;
						continue;
					case 30u:
						arg_30C_0 = ((num <= 77u) ? 2598026719u : 3843962785u);
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
	}
}
