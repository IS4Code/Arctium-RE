using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountBlob : IMessage<GameAccountBlob>, IEquatable<GameAccountBlob>, IDeepCloneable<GameAccountBlob>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountBlob.__c __9 = new GameAccountBlob.__c();

			internal GameAccountBlob cctor>b__99_0()
			{
				return new GameAccountBlob();
			}
		}

		private static readonly MessageParser<GameAccountBlob> _parser = new MessageParser<GameAccountBlob>(new Func<GameAccountBlob>(GameAccountBlob.__c.__9.<.cctor>b__99_0));

		public const int GameAccountFieldNumber = 1;

		private GameAccountHandle gameAccount_;

		public const int NameFieldNumber = 2;

		private string name_ = "";

		public const int RealmPermissionsFieldNumber = 3;

		private uint realmPermissions_;

		public const int StatusFieldNumber = 4;

		private uint status_;

		public const int FlagsFieldNumber = 5;

		private ulong flags_;

		public const int BillingFlagsFieldNumber = 6;

		private uint billingFlags_;

		public const int CacheExpirationFieldNumber = 7;

		private ulong cacheExpiration_;

		public const int SubscriptionExpirationFieldNumber = 10;

		private ulong subscriptionExpiration_;

		public const int UnitsRemainingFieldNumber = 11;

		private uint unitsRemaining_;

		public const int StatusExpirationFieldNumber = 12;

		private ulong statusExpiration_;

		public const int BoxLevelFieldNumber = 13;

		private uint boxLevel_;

		public const int BoxLevelExpirationFieldNumber = 14;

		private ulong boxLevelExpiration_;

		public const int LicensesFieldNumber = 20;

		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(162u, AccountLicense.Parser);

		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		public const int RafAccountFieldNumber = 21;

		private uint rafAccount_;

		public const int RafInfoFieldNumber = 22;

		private ByteString rafInfo_ = ByteString.Empty;

		public const int RafExpirationFieldNumber = 23;

		private ulong rafExpiration_;

		public static MessageParser<GameAccountBlob> Parser
		{
			get
			{
				return GameAccountBlob._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountBlob.Descriptor;
			}
		}

		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
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

		public uint Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
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

		public uint BillingFlags
		{
			get
			{
				return this.billingFlags_;
			}
			set
			{
				this.billingFlags_ = value;
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

		public ulong SubscriptionExpiration
		{
			get
			{
				return this.subscriptionExpiration_;
			}
			set
			{
				this.subscriptionExpiration_ = value;
			}
		}

		public uint UnitsRemaining
		{
			get
			{
				return this.unitsRemaining_;
			}
			set
			{
				this.unitsRemaining_ = value;
			}
		}

		public ulong StatusExpiration
		{
			get
			{
				return this.statusExpiration_;
			}
			set
			{
				this.statusExpiration_ = value;
			}
		}

		public uint BoxLevel
		{
			get
			{
				return this.boxLevel_;
			}
			set
			{
				this.boxLevel_ = value;
			}
		}

		public ulong BoxLevelExpiration
		{
			get
			{
				return this.boxLevelExpiration_;
			}
			set
			{
				this.boxLevelExpiration_ = value;
			}
		}

		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		public uint RafAccount
		{
			get
			{
				return this.rafAccount_;
			}
			set
			{
				this.rafAccount_ = value;
			}
		}

		public ByteString RafInfo
		{
			get
			{
				return this.rafInfo_;
			}
			set
			{
				this.rafInfo_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public ulong RafExpiration
		{
			get
			{
				return this.rafExpiration_;
			}
			set
			{
				this.rafExpiration_ = value;
			}
		}

		public GameAccountBlob()
		{
		}

		public GameAccountBlob(GameAccountBlob other) : this()
		{
			while (true)
			{
				IL_19E:
				uint arg_165_0 = 1336216402u;
				while (true)
				{
					uint num;
					switch ((num = (arg_165_0 ^ 645277058u)) % 11u)
					{
					case 0u:
						goto IL_19E;
					case 1u:
						this.realmPermissions_ = other.realmPermissions_;
						arg_165_0 = (num * 2749708486u ^ 227771262u);
						continue;
					case 2u:
						this.subscriptionExpiration_ = other.subscriptionExpiration_;
						arg_165_0 = (num * 2672525124u ^ 1580580244u);
						continue;
					case 3u:
						this.billingFlags_ = other.billingFlags_;
						arg_165_0 = (num * 3466906230u ^ 1231228552u);
						continue;
					case 4u:
						this.boxLevelExpiration_ = other.boxLevelExpiration_;
						this.licenses_ = other.licenses_.Clone();
						this.rafAccount_ = other.rafAccount_;
						this.rafInfo_ = other.rafInfo_;
						arg_165_0 = (num * 205321318u ^ 1406069299u);
						continue;
					case 5u:
						this.cacheExpiration_ = other.cacheExpiration_;
						arg_165_0 = (num * 982654866u ^ 4132017447u);
						continue;
					case 7u:
						this.unitsRemaining_ = other.unitsRemaining_;
						this.statusExpiration_ = other.statusExpiration_;
						this.boxLevel_ = other.boxLevel_;
						arg_165_0 = (num * 1067425065u ^ 672848744u);
						continue;
					case 8u:
						this.name_ = other.name_;
						arg_165_0 = (num * 2479277835u ^ 3293396377u);
						continue;
					case 9u:
						this.GameAccount = ((other.gameAccount_ != null) ? other.GameAccount.Clone() : null);
						arg_165_0 = 351213835u;
						continue;
					case 10u:
						this.status_ = other.status_;
						this.flags_ = other.flags_;
						arg_165_0 = (num * 2588551917u ^ 487794529u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.rafExpiration_ = other.rafExpiration_;
		}

		public GameAccountBlob Clone()
		{
			return new GameAccountBlob(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountBlob);
		}

		public bool Equals(GameAccountBlob other)
		{
			if (other == null)
			{
				goto IL_42;
			}
			goto IL_37B;
			int arg_2CD_0;
			while (true)
			{
				IL_2C8:
				switch ((arg_2CD_0 ^ -1918275844) % 37)
				{
				case 0:
					return false;
				case 1:
					arg_2CD_0 = ((this.SubscriptionExpiration == other.SubscriptionExpiration) ? -424681678 : -1623422209);
					continue;
				case 2:
					goto IL_37B;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_2CD_0 = ((this.CacheExpiration != other.CacheExpiration) ? -1635539345 : -929651137);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					arg_2CD_0 = ((!this.licenses_.Equals(other.licenses_)) ? -238772918 : -56464671);
					continue;
				case 11:
					arg_2CD_0 = ((this.RafExpiration != other.RafExpiration) ? -580528846 : -1161430988);
					continue;
				case 12:
					return false;
				case 13:
					return true;
				case 15:
					return false;
				case 16:
					arg_2CD_0 = ((this.BillingFlags == other.BillingFlags) ? -1929411403 : -300965944);
					continue;
				case 17:
					arg_2CD_0 = ((this.RealmPermissions != other.RealmPermissions) ? -1336731371 : -159675423);
					continue;
				case 18:
					arg_2CD_0 = ((this.RafInfo != other.RafInfo) ? -1213636515 : -1186255421);
					continue;
				case 19:
					arg_2CD_0 = ((this.StatusExpiration == other.StatusExpiration) ? -1059530699 : -257374088);
					continue;
				case 20:
					arg_2CD_0 = ((this.Status == other.Status) ? -1232203465 : -931005074);
					continue;
				case 21:
					return false;
				case 22:
					arg_2CD_0 = ((this.UnitsRemaining != other.UnitsRemaining) ? -408772685 : -1598527564);
					continue;
				case 23:
					arg_2CD_0 = ((this.Flags != other.Flags) ? -1898708551 : -1621961050);
					continue;
				case 24:
					return false;
				case 25:
					arg_2CD_0 = ((this.RafAccount == other.RafAccount) ? -980849534 : -97897371);
					continue;
				case 26:
					return false;
				case 27:
					arg_2CD_0 = ((this.BoxLevelExpiration != other.BoxLevelExpiration) ? -533247872 : -1660302540);
					continue;
				case 28:
					arg_2CD_0 = (GameAccountBlob.smethod_1(this.Name, other.Name) ? -1707839636 : -1314261898);
					continue;
				case 29:
					arg_2CD_0 = ((!GameAccountBlob.smethod_0(this.GameAccount, other.GameAccount)) ? -2119250339 : -538175281);
					continue;
				case 30:
					goto IL_42;
				case 31:
					return false;
				case 32:
					return false;
				case 33:
					return false;
				case 34:
					return false;
				case 35:
					return false;
				case 36:
					arg_2CD_0 = ((this.BoxLevel == other.BoxLevel) ? -653288169 : -1992478822);
					continue;
				}
				break;
			}
			return true;
			IL_42:
			arg_2CD_0 = -177903405;
			goto IL_2C8;
			IL_37B:
			arg_2CD_0 = ((other == this) ? -462832734 : -588185470);
			goto IL_2C8;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_465:
				uint arg_3E4_0 = 2437191017u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3E4_0 ^ 3252419345u)) % 29u)
					{
					case 0u:
						arg_3E4_0 = (((GameAccountBlob.smethod_3(this.Name) != 0) ? 325511349u : 182045834u) ^ num2 * 44859760u);
						continue;
					case 1u:
						num ^= this.StatusExpiration.GetHashCode();
						arg_3E4_0 = (num2 * 2025727745u ^ 2774070269u);
						continue;
					case 2u:
						num ^= this.BoxLevel.GetHashCode();
						arg_3E4_0 = (num2 * 1644375468u ^ 2638184037u);
						continue;
					case 3u:
						num ^= this.Status.GetHashCode();
						arg_3E4_0 = ((this.Flags == 0uL) ? 4119584964u : 2930658810u);
						continue;
					case 4u:
						num ^= this.Flags.GetHashCode();
						arg_3E4_0 = (num2 * 1550264650u ^ 3948175914u);
						continue;
					case 5u:
						num ^= this.BillingFlags.GetHashCode();
						arg_3E4_0 = (num2 * 3314773307u ^ 2715024032u);
						continue;
					case 6u:
						num ^= this.licenses_.GetHashCode();
						arg_3E4_0 = ((this.RafAccount == 0u) ? 3890266423u : 2815556668u);
						continue;
					case 7u:
						num ^= this.RafInfo.GetHashCode();
						arg_3E4_0 = (num2 * 3679877075u ^ 592227712u);
						continue;
					case 8u:
						num ^= this.RealmPermissions.GetHashCode();
						arg_3E4_0 = (num2 * 599919581u ^ 1515877077u);
						continue;
					case 9u:
						num ^= this.RafAccount.GetHashCode();
						arg_3E4_0 = (num2 * 2661073037u ^ 968061694u);
						continue;
					case 10u:
						arg_3E4_0 = ((this.StatusExpiration != 0uL) ? 2703034632u : 3010343652u);
						continue;
					case 11u:
						arg_3E4_0 = ((this.RafInfo.Length == 0) ? 3716114519u : 3234422908u);
						continue;
					case 12u:
						num ^= GameAccountBlob.smethod_2(this.GameAccount);
						arg_3E4_0 = (num2 * 424765219u ^ 159607351u);
						continue;
					case 13u:
						arg_3E4_0 = ((this.BoxLevel == 0u) ? 2601386293u : 2370859885u);
						continue;
					case 14u:
						num ^= this.CacheExpiration.GetHashCode();
						arg_3E4_0 = (num2 * 4247757499u ^ 618821226u);
						continue;
					case 15u:
						arg_3E4_0 = ((this.BillingFlags != 0u) ? 3328762200u : 3971012979u);
						continue;
					case 16u:
						arg_3E4_0 = ((this.UnitsRemaining != 0u) ? 3934358660u : 3420303938u);
						continue;
					case 17u:
						arg_3E4_0 = ((this.SubscriptionExpiration == 0uL) ? 3699345079u : 4289973681u);
						continue;
					case 18u:
						num ^= this.SubscriptionExpiration.GetHashCode();
						arg_3E4_0 = (num2 * 3554373445u ^ 1088003991u);
						continue;
					case 19u:
						arg_3E4_0 = ((this.RealmPermissions != 0u) ? 3160004623u : 4258064435u);
						continue;
					case 20u:
						num ^= this.BoxLevelExpiration.GetHashCode();
						arg_3E4_0 = (num2 * 437726541u ^ 4181319644u);
						continue;
					case 22u:
						arg_3E4_0 = ((this.RafExpiration != 0uL) ? 4071018947u : 3220587002u);
						continue;
					case 23u:
						arg_3E4_0 = ((this.CacheExpiration == 0uL) ? 3130378437u : 4016786828u);
						continue;
					case 24u:
						arg_3E4_0 = ((this.BoxLevelExpiration == 0uL) ? 3955694572u : 3267659745u);
						continue;
					case 25u:
						num ^= this.UnitsRemaining.GetHashCode();
						arg_3E4_0 = (num2 * 1343373274u ^ 3979136416u);
						continue;
					case 26u:
						goto IL_465;
					case 27u:
						num ^= this.RafExpiration.GetHashCode();
						arg_3E4_0 = (num2 * 3595066560u ^ 2410009722u);
						continue;
					case 28u:
						num ^= GameAccountBlob.smethod_2(this.Name);
						arg_3E4_0 = (num2 * 4061903283u ^ 1875396070u);
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
			output.WriteMessage(this.GameAccount);
			while (true)
			{
				IL_597:
				uint arg_4EA_0 = 2210339422u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4EA_0 ^ 2379822450u)) % 40u)
					{
					case 0u:
						output.WriteRawTag(88);
						output.WriteUInt32(this.UnitsRemaining);
						arg_4EA_0 = (num * 684102464u ^ 133467507u);
						continue;
					case 1u:
						output.WriteRawTag(18);
						arg_4EA_0 = (num * 882183597u ^ 1063240237u);
						continue;
					case 2u:
						output.WriteUInt32(this.BoxLevel);
						arg_4EA_0 = (num * 3015840235u ^ 1944971517u);
						continue;
					case 3u:
						output.WriteUInt64(this.RafExpiration);
						arg_4EA_0 = (num * 1348832057u ^ 4075274302u);
						continue;
					case 4u:
						output.WriteUInt32(this.RealmPermissions);
						arg_4EA_0 = (num * 3886942913u ^ 758991632u);
						continue;
					case 5u:
						output.WriteRawTag(178, 1);
						arg_4EA_0 = (num * 722859652u ^ 770360329u);
						continue;
					case 6u:
						arg_4EA_0 = ((this.BoxLevel == 0u) ? 3237171795u : 2523653810u);
						continue;
					case 7u:
						arg_4EA_0 = ((this.UnitsRemaining != 0u) ? 3147401434u : 2868014963u);
						continue;
					case 8u:
						output.WriteRawTag(104);
						arg_4EA_0 = (num * 768596512u ^ 1031699448u);
						continue;
					case 9u:
						output.WriteUInt32(this.Status);
						arg_4EA_0 = (num * 2568467289u ^ 2252714603u);
						continue;
					case 10u:
						arg_4EA_0 = ((this.SubscriptionExpiration != 0uL) ? 2807257124u : 3292825349u);
						continue;
					case 11u:
						output.WriteRawTag(112);
						output.WriteUInt64(this.BoxLevelExpiration);
						arg_4EA_0 = (num * 2288463022u ^ 1284189407u);
						continue;
					case 12u:
						arg_4EA_0 = (((GameAccountBlob.smethod_3(this.Name) == 0) ? 503914086u : 1527623711u) ^ num * 2008824259u);
						continue;
					case 13u:
						output.WriteUInt64(this.CacheExpiration);
						arg_4EA_0 = (num * 969581757u ^ 1309673601u);
						continue;
					case 14u:
						arg_4EA_0 = ((this.BillingFlags != 0u) ? 2922976031u : 3389997169u);
						continue;
					case 15u:
						output.WriteBytes(this.RafInfo);
						arg_4EA_0 = (num * 4095237611u ^ 2129061211u);
						continue;
					case 16u:
						arg_4EA_0 = (((this.Flags != 0uL) ? 2790203764u : 3414667508u) ^ num * 1707723964u);
						continue;
					case 17u:
						output.WriteUInt64(this.Flags);
						arg_4EA_0 = (num * 21872318u ^ 2197504602u);
						continue;
					case 18u:
						output.WriteRawTag(173, 1);
						output.WriteFixed32(this.RafAccount);
						arg_4EA_0 = (num * 4114091125u ^ 136467435u);
						continue;
					case 19u:
						arg_4EA_0 = ((this.RafInfo.Length != 0) ? 2687608119u : 2153417534u);
						continue;
					case 20u:
						arg_4EA_0 = ((this.RafExpiration == 0uL) ? 3063690717u : 3361254479u);
						continue;
					case 21u:
						output.WriteRawTag(48);
						arg_4EA_0 = (num * 4127250272u ^ 2975735738u);
						continue;
					case 22u:
						output.WriteRawTag(32);
						arg_4EA_0 = 3929465075u;
						continue;
					case 24u:
						arg_4EA_0 = ((this.RealmPermissions == 0u) ? 2930979004u : 4030734129u);
						continue;
					case 25u:
						arg_4EA_0 = ((this.BoxLevelExpiration != 0uL) ? 2239197705u : 3115423045u);
						continue;
					case 26u:
						output.WriteRawTag(96);
						arg_4EA_0 = (num * 2022982987u ^ 1247644464u);
						continue;
					case 27u:
						output.WriteRawTag(24);
						arg_4EA_0 = (num * 3680344976u ^ 4067795310u);
						continue;
					case 28u:
						output.WriteUInt64(this.StatusExpiration);
						arg_4EA_0 = (num * 3886186136u ^ 1780253036u);
						continue;
					case 29u:
						output.WriteRawTag(56);
						arg_4EA_0 = (num * 2454296346u ^ 4118970901u);
						continue;
					case 30u:
						output.WriteRawTag(80);
						arg_4EA_0 = (num * 334525057u ^ 1096212443u);
						continue;
					case 31u:
						this.licenses_.WriteTo(output, GameAccountBlob._repeated_licenses_codec);
						arg_4EA_0 = ((this.RafAccount != 0u) ? 2520726856u : 3742771561u);
						continue;
					case 32u:
						output.WriteUInt32(this.BillingFlags);
						arg_4EA_0 = (num * 3493003920u ^ 241907441u);
						continue;
					case 33u:
						arg_4EA_0 = ((this.StatusExpiration == 0uL) ? 2602586252u : 4271710960u);
						continue;
					case 34u:
						output.WriteString(this.Name);
						arg_4EA_0 = (num * 1605308227u ^ 134574620u);
						continue;
					case 35u:
						arg_4EA_0 = ((this.CacheExpiration != 0uL) ? 3150449191u : 2492193776u);
						continue;
					case 36u:
						goto IL_597;
					case 37u:
						output.WriteRawTag(184, 1);
						arg_4EA_0 = (num * 314500045u ^ 1667818576u);
						continue;
					case 38u:
						output.WriteRawTag(40);
						arg_4EA_0 = (num * 1877340736u ^ 379058299u);
						continue;
					case 39u:
						output.WriteUInt64(this.SubscriptionExpiration);
						arg_4EA_0 = (num * 2414618800u ^ 3274350677u);
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
				IL_484:
				uint arg_3FB_0 = 2495452090u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3FB_0 ^ 2827821370u)) % 31u)
					{
					case 0u:
						arg_3FB_0 = ((this.RafInfo.Length != 0) ? 3154598666u : 2466644756u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.BoxLevelExpiration);
						arg_3FB_0 = (num2 * 791571663u ^ 1430304471u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.BillingFlags);
						arg_3FB_0 = (num2 * 1150680087u ^ 2882673965u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
						arg_3FB_0 = (num2 * 1464299156u ^ 528871253u);
						continue;
					case 5u:
						goto IL_484;
					case 6u:
						arg_3FB_0 = ((this.SubscriptionExpiration != 0uL) ? 2343304485u : 3927162517u);
						continue;
					case 7u:
						num += this.licenses_.CalculateSize(GameAccountBlob._repeated_licenses_codec);
						arg_3FB_0 = 2969877113u;
						continue;
					case 8u:
						num += 2 + CodedOutputStream.ComputeBytesSize(this.RafInfo);
						arg_3FB_0 = (num2 * 1807601107u ^ 2221745796u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriptionExpiration);
						arg_3FB_0 = (num2 * 408138489u ^ 2448758450u);
						continue;
					case 10u:
						arg_3FB_0 = ((this.BillingFlags != 0u) ? 3250775633u : 3496813488u);
						continue;
					case 11u:
						arg_3FB_0 = ((this.CacheExpiration == 0uL) ? 3456695274u : 3881937257u);
						continue;
					case 12u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
						arg_3FB_0 = 2798173104u;
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RealmPermissions);
						arg_3FB_0 = (num2 * 2029966231u ^ 910951654u);
						continue;
					case 14u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Flags);
						arg_3FB_0 = (num2 * 1068650149u ^ 3075226383u);
						continue;
					case 15u:
						arg_3FB_0 = ((this.BoxLevel == 0u) ? 4257698740u : 2540040783u);
						continue;
					case 16u:
						num += 6;
						arg_3FB_0 = (num2 * 40375326u ^ 29300001u);
						continue;
					case 17u:
						arg_3FB_0 = ((this.StatusExpiration != 0uL) ? 2406778288u : 3702619495u);
						continue;
					case 18u:
						arg_3FB_0 = ((this.RealmPermissions == 0u) ? 2360747770u : 3964035966u);
						continue;
					case 19u:
						arg_3FB_0 = (((GameAccountBlob.smethod_3(this.Name) != 0) ? 1671181816u : 717483573u) ^ num2 * 611858445u);
						continue;
					case 20u:
						arg_3FB_0 = ((this.BoxLevelExpiration == 0uL) ? 4163419215u : 2256027858u);
						continue;
					case 21u:
						arg_3FB_0 = ((this.RafExpiration != 0uL) ? 4197527746u : 2327522379u);
						continue;
					case 22u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.BoxLevel);
						arg_3FB_0 = (num2 * 2362270080u ^ 2164087860u);
						continue;
					case 23u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnitsRemaining);
						arg_3FB_0 = (num2 * 607649u ^ 131146598u);
						continue;
					case 24u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.CacheExpiration);
						arg_3FB_0 = (num2 * 3854042521u ^ 1403511665u);
						continue;
					case 25u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_3FB_0 = (num2 * 1742848887u ^ 1129770113u);
						continue;
					case 26u:
						num += 2 + CodedOutputStream.ComputeUInt64Size(this.RafExpiration);
						arg_3FB_0 = (num2 * 2918544444u ^ 3962288747u);
						continue;
					case 27u:
						arg_3FB_0 = (((this.Flags != 0uL) ? 3313035333u : 2508583828u) ^ num2 * 350483083u);
						continue;
					case 28u:
						arg_3FB_0 = (((this.RafAccount != 0u) ? 3311561777u : 2302890308u) ^ num2 * 1889352787u);
						continue;
					case 29u:
						arg_3FB_0 = ((this.UnitsRemaining == 0u) ? 3493142614u : 3434476554u);
						continue;
					case 30u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.StatusExpiration);
						arg_3FB_0 = (num2 * 2199410282u ^ 2837774403u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountBlob other)
		{
			if (other == null)
			{
				goto IL_C3;
			}
			goto IL_4DC;
			uint arg_434_0;
			while (true)
			{
				IL_42F:
				uint num;
				switch ((num = (arg_434_0 ^ 3632683323u)) % 35u)
				{
				case 0u:
					this.BillingFlags = other.BillingFlags;
					arg_434_0 = (num * 1238845432u ^ 3753752346u);
					continue;
				case 1u:
					this.BoxLevel = other.BoxLevel;
					arg_434_0 = (num * 103175883u ^ 2722329810u);
					continue;
				case 2u:
					arg_434_0 = (((this.gameAccount_ == null) ? 1679898828u : 340616743u) ^ num * 2517224619u);
					continue;
				case 3u:
					arg_434_0 = ((other.BoxLevelExpiration == 0uL) ? 3389888440u : 2761258531u);
					continue;
				case 4u:
					this.gameAccount_ = new GameAccountHandle();
					arg_434_0 = (num * 1258069951u ^ 2374562088u);
					continue;
				case 5u:
					arg_434_0 = ((other.BillingFlags == 0u) ? 4148711282u : 2628334280u);
					continue;
				case 7u:
					arg_434_0 = ((other.RafExpiration == 0uL) ? 3739297513u : 2604182130u);
					continue;
				case 8u:
					this.RafExpiration = other.RafExpiration;
					arg_434_0 = (num * 1742414386u ^ 3371110571u);
					continue;
				case 9u:
					arg_434_0 = ((GameAccountBlob.smethod_3(other.Name) == 0) ? 2347136367u : 4198721837u);
					continue;
				case 10u:
					this.RafInfo = other.RafInfo;
					arg_434_0 = (num * 984558254u ^ 2524413886u);
					continue;
				case 11u:
					this.RealmPermissions = other.RealmPermissions;
					arg_434_0 = (num * 2742856505u ^ 3172710212u);
					continue;
				case 12u:
					arg_434_0 = ((other.RafInfo.Length != 0) ? 4215748323u : 4161538926u);
					continue;
				case 13u:
					this.Status = other.Status;
					arg_434_0 = (num * 3574943469u ^ 2544193581u);
					continue;
				case 14u:
					arg_434_0 = ((other.SubscriptionExpiration == 0uL) ? 2266270403u : 4011751681u);
					continue;
				case 15u:
					this.RafAccount = other.RafAccount;
					arg_434_0 = (num * 4198608799u ^ 1180229668u);
					continue;
				case 16u:
					this.StatusExpiration = other.StatusExpiration;
					arg_434_0 = (num * 250526570u ^ 2139164341u);
					continue;
				case 17u:
					arg_434_0 = ((other.RealmPermissions == 0u) ? 3654958848u : 4157837151u);
					continue;
				case 18u:
					arg_434_0 = ((other.CacheExpiration == 0uL) ? 3834405032u : 3158492355u);
					continue;
				case 19u:
					this.licenses_.Add(other.licenses_);
					arg_434_0 = ((other.RafAccount == 0u) ? 2465516651u : 4162641002u);
					continue;
				case 20u:
					this.GameAccount.MergeFrom(other.GameAccount);
					arg_434_0 = 3161549066u;
					continue;
				case 21u:
					arg_434_0 = ((other.StatusExpiration != 0uL) ? 2353155520u : 4032759387u);
					continue;
				case 22u:
					this.Flags = other.Flags;
					arg_434_0 = (num * 648912064u ^ 1686587408u);
					continue;
				case 23u:
					arg_434_0 = ((other.Flags == 0uL) ? 3719792912u : 2186654423u);
					continue;
				case 24u:
					this.BoxLevelExpiration = other.BoxLevelExpiration;
					arg_434_0 = (num * 2134308492u ^ 3938666136u);
					continue;
				case 25u:
					goto IL_4DC;
				case 26u:
					this.Name = other.Name;
					arg_434_0 = (num * 2484721987u ^ 576868013u);
					continue;
				case 27u:
					this.SubscriptionExpiration = other.SubscriptionExpiration;
					arg_434_0 = (num * 544199856u ^ 3950552355u);
					continue;
				case 28u:
					goto IL_C3;
				case 29u:
					arg_434_0 = ((other.Status == 0u) ? 3227647378u : 3590517984u);
					continue;
				case 30u:
					arg_434_0 = ((other.UnitsRemaining == 0u) ? 2931179381u : 3130939927u);
					continue;
				case 31u:
					this.CacheExpiration = other.CacheExpiration;
					arg_434_0 = (num * 1375076013u ^ 931049520u);
					continue;
				case 32u:
					return;
				case 33u:
					arg_434_0 = ((other.BoxLevel != 0u) ? 3113026895u : 2483696430u);
					continue;
				case 34u:
					this.UnitsRemaining = other.UnitsRemaining;
					arg_434_0 = (num * 3751879794u ^ 3480856301u);
					continue;
				}
				break;
			}
			return;
			IL_C3:
			arg_434_0 = 3205917378u;
			goto IL_42F;
			IL_4DC:
			arg_434_0 = ((other.gameAccount_ == null) ? 3161549066u : 3128081338u);
			goto IL_42F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_79E:
				uint num;
				uint arg_686_0 = ((num = input.ReadTag()) != 0u) ? 2109354807u : 482667087u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_686_0 ^ 1289224437u)) % 63u)
					{
					case 0u:
						arg_686_0 = (num2 * 3776465087u ^ 3375880516u);
						continue;
					case 1u:
						arg_686_0 = (((num != 96u) ? 1666949991u : 1328574504u) ^ num2 * 2714365222u);
						continue;
					case 2u:
						this.CacheExpiration = input.ReadUInt64();
						arg_686_0 = 1341866711u;
						continue;
					case 3u:
						this.UnitsRemaining = input.ReadUInt32();
						arg_686_0 = 1128125696u;
						continue;
					case 4u:
						arg_686_0 = (num2 * 2765366486u ^ 3447631356u);
						continue;
					case 5u:
						arg_686_0 = 2109354807u;
						continue;
					case 6u:
						arg_686_0 = (((num > 32u) ? 1427663151u : 593383971u) ^ num2 * 2567056816u);
						continue;
					case 7u:
						arg_686_0 = (num2 * 1336001305u ^ 3484783839u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_686_0 = 2136444943u;
						continue;
					case 9u:
						arg_686_0 = (num2 * 2111144418u ^ 1218200762u);
						continue;
					case 10u:
						this.licenses_.AddEntriesFrom(input, GameAccountBlob._repeated_licenses_codec);
						arg_686_0 = 1771206944u;
						continue;
					case 11u:
						this.RealmPermissions = input.ReadUInt32();
						arg_686_0 = 524845890u;
						continue;
					case 13u:
						arg_686_0 = (((num == 88u) ? 3231787841u : 2281576647u) ^ num2 * 2688643392u);
						continue;
					case 14u:
						this.BillingFlags = input.ReadUInt32();
						arg_686_0 = 1128125696u;
						continue;
					case 15u:
						arg_686_0 = (num2 * 3678928028u ^ 2461377880u);
						continue;
					case 16u:
						arg_686_0 = (((num == 18u) ? 3315941580u : 2178494316u) ^ num2 * 452183380u);
						continue;
					case 17u:
						arg_686_0 = (((num != 40u) ? 1683298214u : 768414246u) ^ num2 * 2280884613u);
						continue;
					case 18u:
						arg_686_0 = (num2 * 12844439u ^ 1075894078u);
						continue;
					case 19u:
						arg_686_0 = (((num == 80u) ? 3792013018u : 2607158156u) ^ num2 * 359272223u);
						continue;
					case 20u:
						arg_686_0 = ((num > 112u) ? 18714632u : 1149878301u);
						continue;
					case 21u:
						arg_686_0 = ((num != 56u) ? 1227177392u : 568979796u);
						continue;
					case 22u:
						arg_686_0 = (num2 * 3237446236u ^ 829858804u);
						continue;
					case 23u:
						arg_686_0 = (((num == 173u) ? 3817384847u : 3749722677u) ^ num2 * 228581333u);
						continue;
					case 24u:
						arg_686_0 = ((this.gameAccount_ == null) ? 691365746u : 799866396u);
						continue;
					case 25u:
						arg_686_0 = (((num == 184u) ? 1820689179u : 382293978u) ^ num2 * 3248810799u);
						continue;
					case 26u:
						arg_686_0 = ((num <= 173u) ? 705054882u : 1879396690u);
						continue;
					case 27u:
						arg_686_0 = (num2 * 2516910685u ^ 2851860247u);
						continue;
					case 28u:
						arg_686_0 = (num2 * 1455059326u ^ 235744982u);
						continue;
					case 29u:
						arg_686_0 = ((num > 48u) ? 1292402981u : 97534027u);
						continue;
					case 30u:
						this.gameAccount_ = new GameAccountHandle();
						arg_686_0 = (num2 * 4174451407u ^ 1188678197u);
						continue;
					case 31u:
						arg_686_0 = (num2 * 2116443828u ^ 1971535212u);
						continue;
					case 32u:
						arg_686_0 = (num2 * 3771572052u ^ 1441874020u);
						continue;
					case 33u:
						this.Status = input.ReadUInt32();
						arg_686_0 = 1128125696u;
						continue;
					case 34u:
						this.SubscriptionExpiration = input.ReadUInt64();
						arg_686_0 = 1002784499u;
						continue;
					case 35u:
						arg_686_0 = (((num == 32u) ? 2366972157u : 3965320142u) ^ num2 * 1807635236u);
						continue;
					case 36u:
						arg_686_0 = (((num > 96u) ? 1338250888u : 92204501u) ^ num2 * 3958592619u);
						continue;
					case 37u:
						arg_686_0 = (((num != 48u) ? 2262081387u : 2878339644u) ^ num2 * 3824457187u);
						continue;
					case 38u:
						arg_686_0 = (num2 * 3521313274u ^ 1712635922u);
						continue;
					case 39u:
						arg_686_0 = (((num != 112u) ? 3122710927u : 2655631231u) ^ num2 * 717171424u);
						continue;
					case 40u:
						this.BoxLevel = input.ReadUInt32();
						arg_686_0 = 2039177289u;
						continue;
					case 41u:
						arg_686_0 = (num2 * 1331128309u ^ 4274547234u);
						continue;
					case 42u:
						arg_686_0 = (num2 * 1038296856u ^ 733656112u);
						continue;
					case 43u:
						this.BoxLevelExpiration = input.ReadUInt64();
						arg_686_0 = 1669661344u;
						continue;
					case 44u:
						arg_686_0 = (((num > 18u) ? 3956289647u : 2371803989u) ^ num2 * 2249355222u);
						continue;
					case 45u:
						arg_686_0 = ((num != 104u) ? 2021349070u : 1987664969u);
						continue;
					case 46u:
						this.Flags = input.ReadUInt64();
						arg_686_0 = 341650574u;
						continue;
					case 47u:
						this.RafAccount = input.ReadFixed32();
						arg_686_0 = 1885809214u;
						continue;
					case 48u:
						arg_686_0 = ((num == 24u) ? 651139975u : 1136886138u);
						continue;
					case 49u:
						this.StatusExpiration = input.ReadUInt64();
						arg_686_0 = 1128125696u;
						continue;
					case 50u:
						arg_686_0 = (num2 * 835479378u ^ 2724791020u);
						continue;
					case 51u:
						goto IL_79E;
					case 52u:
						arg_686_0 = (num2 * 3136783791u ^ 3223019447u);
						continue;
					case 53u:
						arg_686_0 = (num2 * 1739244696u ^ 1464443768u);
						continue;
					case 54u:
						input.ReadMessage(this.gameAccount_);
						arg_686_0 = 1128125696u;
						continue;
					case 55u:
						arg_686_0 = ((num != 178u) ? 761755867u : 1333905492u);
						continue;
					case 56u:
						this.Name = input.ReadString();
						arg_686_0 = 1873735954u;
						continue;
					case 57u:
						this.RafInfo = input.ReadBytes();
						arg_686_0 = 63620696u;
						continue;
					case 58u:
						arg_686_0 = (num2 * 935423220u ^ 3226508348u);
						continue;
					case 59u:
						this.RafExpiration = input.ReadUInt64();
						arg_686_0 = 1128125696u;
						continue;
					case 60u:
						arg_686_0 = (((num == 162u) ? 2400692396u : 3447205955u) ^ num2 * 4257308607u);
						continue;
					case 61u:
						arg_686_0 = (((num == 10u) ? 3608275003u : 2488328687u) ^ num2 * 389305975u);
						continue;
					case 62u:
						arg_686_0 = ((num > 80u) ? 1347866646u : 1379103831u);
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

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
