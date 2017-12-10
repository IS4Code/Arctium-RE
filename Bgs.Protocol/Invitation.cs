using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Invitation : IMessage<Invitation>, IEquatable<Invitation>, IDeepCloneable<Invitation>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Invitation.__c __9 = new Invitation.__c();

			internal Invitation cctor>b__59_0()
			{
				return new Invitation();
			}
		}

		private static readonly MessageParser<Invitation> _parser = new MessageParser<Invitation>(new Func<Invitation>(Invitation.__c.__9.<.cctor>b__59_0));

		public const int IdFieldNumber = 1;

		private ulong id_;

		public const int InviterIdentityFieldNumber = 2;

		private Identity inviterIdentity_;

		public const int InviteeIdentityFieldNumber = 3;

		private Identity inviteeIdentity_;

		public const int InviterNameFieldNumber = 4;

		private string inviterName_ = "";

		public const int InviteeNameFieldNumber = 5;

		private string inviteeName_ = "";

		public const int InvitationMessageFieldNumber = 6;

		private string invitationMessage_ = "";

		public const int CreationTimeFieldNumber = 7;

		private ulong creationTime_;

		public const int ExpirationTimeFieldNumber = 8;

		private ulong expirationTime_;

		public static MessageParser<Invitation> Parser
		{
			get
			{
				return Invitation._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Invitation.Descriptor;
			}
		}

		public ulong Id
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

		public Identity InviterIdentity
		{
			get
			{
				return this.inviterIdentity_;
			}
			set
			{
				this.inviterIdentity_ = value;
			}
		}

		public Identity InviteeIdentity
		{
			get
			{
				return this.inviteeIdentity_;
			}
			set
			{
				this.inviteeIdentity_ = value;
			}
		}

		public string InviterName
		{
			get
			{
				return this.inviterName_;
			}
			set
			{
				this.inviterName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string InviteeName
		{
			get
			{
				return this.inviteeName_;
			}
			set
			{
				this.inviteeName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public string InvitationMessage
		{
			get
			{
				return this.invitationMessage_;
			}
			set
			{
				this.invitationMessage_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public ulong CreationTime
		{
			get
			{
				return this.creationTime_;
			}
			set
			{
				this.creationTime_ = value;
			}
		}

		public ulong ExpirationTime
		{
			get
			{
				return this.expirationTime_;
			}
			set
			{
				this.expirationTime_ = value;
			}
		}

		public Invitation()
		{
		}

		public Invitation(Invitation other) : this()
		{
			while (true)
			{
				IL_F4:
				uint arg_CC_0 = 3368733936u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CC_0 ^ 2687013655u)) % 7u)
					{
					case 0u:
						this.creationTime_ = other.creationTime_;
						arg_CC_0 = (num * 73398191u ^ 2372653017u);
						continue;
					case 2u:
						this.invitationMessage_ = other.invitationMessage_;
						arg_CC_0 = (num * 901828807u ^ 2507602456u);
						continue;
					case 3u:
						this.InviteeIdentity = ((other.inviteeIdentity_ != null) ? other.InviteeIdentity.Clone() : null);
						this.inviterName_ = other.inviterName_;
						this.inviteeName_ = other.inviteeName_;
						arg_CC_0 = 2517381316u;
						continue;
					case 4u:
						goto IL_F4;
					case 5u:
						this.id_ = other.id_;
						this.InviterIdentity = ((other.inviterIdentity_ != null) ? other.InviterIdentity.Clone() : null);
						arg_CC_0 = 3448492590u;
						continue;
					case 6u:
						this.expirationTime_ = other.expirationTime_;
						arg_CC_0 = (num * 654861472u ^ 316785139u);
						continue;
					}
					return;
				}
			}
		}

		public Invitation Clone()
		{
			return new Invitation(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Invitation);
		}

		public bool Equals(Invitation other)
		{
			if (other == null)
			{
				goto IL_17B;
			}
			goto IL_1F3;
			int arg_185_0;
			while (true)
			{
				IL_180:
				switch ((arg_185_0 ^ 54782606) % 21)
				{
				case 0:
					goto IL_17B;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					arg_185_0 = ((!Invitation.smethod_0(this.InviteeIdentity, other.InviteeIdentity)) ? 132574845 : 176445693);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_185_0 = ((this.CreationTime == other.CreationTime) ? 283666770 : 44452698);
					continue;
				case 8:
					return false;
				case 9:
					arg_185_0 = (Invitation.smethod_1(this.InviterName, other.InviterName) ? 1660927796 : 1931144290);
					continue;
				case 10:
					arg_185_0 = ((!Invitation.smethod_0(this.InviterIdentity, other.InviterIdentity)) ? 879309745 : 629122309);
					continue;
				case 11:
					arg_185_0 = ((!Invitation.smethod_1(this.InviteeName, other.InviteeName)) ? 384647121 : 835534920);
					continue;
				case 12:
					return false;
				case 13:
					arg_185_0 = ((this.ExpirationTime != other.ExpirationTime) ? 653818421 : 1315321443);
					continue;
				case 14:
					arg_185_0 = (Invitation.smethod_1(this.InvitationMessage, other.InvitationMessage) ? 1382813114 : 1025171282);
					continue;
				case 15:
					return false;
				case 16:
					return false;
				case 17:
					goto IL_1F3;
				case 18:
					arg_185_0 = ((this.Id != other.Id) ? 890798202 : 41871490);
					continue;
				case 19:
					return false;
				case 20:
					return false;
				}
				break;
			}
			return true;
			IL_17B:
			arg_185_0 = 483550535;
			goto IL_180;
			IL_1F3:
			arg_185_0 = ((other != this) ? 1728337702 : 438332444);
			goto IL_180;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0uL)
			{
				goto IL_AF;
			}
			goto IL_1D6;
			uint arg_186_0;
			while (true)
			{
				IL_181:
				uint num2;
				switch ((num2 = (arg_186_0 ^ 1895223327u)) % 13u)
				{
				case 0u:
					num ^= this.InviteeName.GetHashCode();
					arg_186_0 = (num2 * 552263203u ^ 1355919074u);
					continue;
				case 2u:
					num ^= this.CreationTime.GetHashCode();
					arg_186_0 = (num2 * 1324074850u ^ 3591428752u);
					continue;
				case 3u:
					arg_186_0 = ((this.InviteeName.Length == 0) ? 1366008021u : 644677314u);
					continue;
				case 4u:
					goto IL_1D6;
				case 5u:
					arg_186_0 = ((this.ExpirationTime == 0uL) ? 1355199036u : 1770540573u);
					continue;
				case 6u:
					num ^= this.Id.GetHashCode();
					arg_186_0 = (num2 * 334445259u ^ 1126945736u);
					continue;
				case 7u:
					num ^= this.ExpirationTime.GetHashCode();
					arg_186_0 = (num2 * 4064805956u ^ 1147974324u);
					continue;
				case 8u:
					goto IL_AF;
				case 9u:
					num ^= this.InviterName.GetHashCode();
					arg_186_0 = (num2 * 139717015u ^ 4204937540u);
					continue;
				case 10u:
					arg_186_0 = ((this.CreationTime != 0uL) ? 1056872876u : 1473741078u);
					continue;
				case 11u:
					arg_186_0 = ((this.InvitationMessage.Length == 0) ? 1760974667u : 986782549u);
					continue;
				case 12u:
					num ^= this.InvitationMessage.GetHashCode();
					arg_186_0 = (num2 * 1369252061u ^ 2094262697u);
					continue;
				}
				break;
			}
			return num;
			IL_AF:
			arg_186_0 = 724233383u;
			goto IL_181;
			IL_1D6:
			num ^= this.InviterIdentity.GetHashCode();
			num ^= this.InviteeIdentity.GetHashCode();
			arg_186_0 = ((this.InviterName.Length == 0) ? 1458561681u : 929055596u);
			goto IL_181;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Id != 0uL)
			{
				goto IL_1FB;
			}
			goto IL_2B9;
			uint arg_258_0;
			while (true)
			{
				IL_253:
				uint num;
				switch ((num = (arg_258_0 ^ 3510684873u)) % 21u)
				{
				case 0u:
					output.WriteString(this.InvitationMessage);
					arg_258_0 = (num * 3929959948u ^ 2260070866u);
					continue;
				case 1u:
					arg_258_0 = ((this.CreationTime != 0uL) ? 2580219740u : 3719311843u);
					continue;
				case 2u:
					output.WriteRawTag(56);
					arg_258_0 = (num * 2281649942u ^ 484308282u);
					continue;
				case 3u:
					goto IL_1FB;
				case 4u:
					output.WriteRawTag(42);
					output.WriteString(this.InviteeName);
					arg_258_0 = (num * 926654138u ^ 954032714u);
					continue;
				case 5u:
					arg_258_0 = ((Invitation.smethod_2(this.InviteeName) != 0) ? 3679866376u : 3931405424u);
					continue;
				case 6u:
					output.WriteRawTag(50);
					arg_258_0 = (num * 1613914295u ^ 2537708903u);
					continue;
				case 7u:
					arg_258_0 = (((Invitation.smethod_2(this.InviterName) == 0) ? 3825044584u : 2752713479u) ^ num * 241753776u);
					continue;
				case 8u:
					arg_258_0 = ((Invitation.smethod_2(this.InvitationMessage) == 0) ? 3015638422u : 3672318458u);
					continue;
				case 9u:
					output.WriteRawTag(26);
					arg_258_0 = (num * 2006558531u ^ 2169108969u);
					continue;
				case 11u:
					output.WriteUInt64(this.ExpirationTime);
					arg_258_0 = (num * 2330285748u ^ 2088692830u);
					continue;
				case 12u:
					goto IL_2B9;
				case 13u:
					arg_258_0 = ((this.ExpirationTime == 0uL) ? 3396513530u : 3481020135u);
					continue;
				case 14u:
					output.WriteRawTag(9);
					arg_258_0 = (num * 3718169875u ^ 2982320365u);
					continue;
				case 15u:
					output.WriteRawTag(34);
					output.WriteString(this.InviterName);
					arg_258_0 = (num * 1312519798u ^ 2704358508u);
					continue;
				case 16u:
					output.WriteUInt64(this.CreationTime);
					arg_258_0 = (num * 3233969359u ^ 3435441328u);
					continue;
				case 17u:
					output.WriteMessage(this.InviterIdentity);
					arg_258_0 = (num * 4266212696u ^ 4158779317u);
					continue;
				case 18u:
					output.WriteFixed64(this.Id);
					arg_258_0 = (num * 2644174274u ^ 2308137227u);
					continue;
				case 19u:
					output.WriteRawTag(64);
					arg_258_0 = (num * 172584452u ^ 3563523612u);
					continue;
				case 20u:
					output.WriteMessage(this.InviteeIdentity);
					arg_258_0 = (num * 750041473u ^ 3422542546u);
					continue;
				}
				break;
			}
			return;
			IL_1FB:
			arg_258_0 = 2401963482u;
			goto IL_253;
			IL_2B9:
			output.WriteRawTag(18);
			arg_258_0 = 4092848872u;
			goto IL_253;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0uL)
			{
				goto IL_EC;
			}
			goto IL_1CE;
			uint arg_17E_0;
			while (true)
			{
				IL_179:
				uint num2;
				switch ((num2 = (arg_17E_0 ^ 3536212555u)) % 13u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
					arg_17E_0 = (num2 * 3027300053u ^ 3287304706u);
					continue;
				case 1u:
					arg_17E_0 = ((this.ExpirationTime != 0uL) ? 4104858193u : 3601403071u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
					arg_17E_0 = (num2 * 2008366449u ^ 3673897413u);
					continue;
				case 3u:
					arg_17E_0 = ((Invitation.smethod_2(this.InvitationMessage) == 0) ? 3814946107u : 3195855019u);
					continue;
				case 4u:
					goto IL_EC;
				case 5u:
					arg_17E_0 = ((Invitation.smethod_2(this.InviteeName) != 0) ? 3998743112u : 2161511637u);
					continue;
				case 6u:
					arg_17E_0 = ((this.CreationTime == 0uL) ? 2783852980u : 2482317717u);
					continue;
				case 7u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviterName);
					arg_17E_0 = (num2 * 3066082169u ^ 3722603954u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviteeName);
					arg_17E_0 = (num2 * 903004598u ^ 3497769463u);
					continue;
				case 9u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InvitationMessage);
					arg_17E_0 = (num2 * 1122191099u ^ 3891647643u);
					continue;
				case 11u:
					num += 9;
					arg_17E_0 = (num2 * 1173378719u ^ 2181760301u);
					continue;
				case 12u:
					goto IL_1CE;
				}
				break;
			}
			return num;
			IL_EC:
			arg_17E_0 = 3843308850u;
			goto IL_179;
			IL_1CE:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.InviterIdentity);
			num += 1 + CodedOutputStream.ComputeMessageSize(this.InviteeIdentity);
			arg_17E_0 = ((Invitation.smethod_2(this.InviterName) == 0) ? 2203309217u : 3536049056u);
			goto IL_179;
		}

		public void MergeFrom(Invitation other)
		{
			if (other == null)
			{
				goto IL_1F6;
			}
			goto IL_318;
			uint arg_2A0_0;
			while (true)
			{
				IL_29B:
				uint num;
				switch ((num = (arg_2A0_0 ^ 370080683u)) % 23u)
				{
				case 0u:
					this.InviterIdentity.MergeFrom(other.InviterIdentity);
					arg_2A0_0 = 2127012864u;
					continue;
				case 1u:
					this.ExpirationTime = other.ExpirationTime;
					arg_2A0_0 = (num * 1782234623u ^ 2070407178u);
					continue;
				case 2u:
					this.CreationTime = other.CreationTime;
					arg_2A0_0 = (num * 90973012u ^ 1727664039u);
					continue;
				case 3u:
					arg_2A0_0 = (((this.inviterIdentity_ == null) ? 3899623766u : 2602491914u) ^ num * 323029515u);
					continue;
				case 4u:
					arg_2A0_0 = ((Invitation.smethod_2(other.InviterName) != 0) ? 671145922u : 1694266536u);
					continue;
				case 5u:
					goto IL_1F6;
				case 7u:
					arg_2A0_0 = ((Invitation.smethod_2(other.InviteeName) != 0) ? 1800667564u : 1992291752u);
					continue;
				case 8u:
					this.inviteeIdentity_ = new Identity();
					arg_2A0_0 = (num * 3659367352u ^ 2881501315u);
					continue;
				case 9u:
					this.inviterIdentity_ = new Identity();
					arg_2A0_0 = (num * 154039771u ^ 4262360941u);
					continue;
				case 10u:
					arg_2A0_0 = ((other.CreationTime != 0uL) ? 645296085u : 436206847u);
					continue;
				case 11u:
					arg_2A0_0 = ((other.ExpirationTime != 0uL) ? 1180700833u : 488728828u);
					continue;
				case 12u:
					this.InviterName = other.InviterName;
					arg_2A0_0 = (num * 103779340u ^ 2904970308u);
					continue;
				case 13u:
					arg_2A0_0 = ((other.inviteeIdentity_ == null) ? 2074223812u : 1721294856u);
					continue;
				case 14u:
					goto IL_318;
				case 15u:
					return;
				case 16u:
					arg_2A0_0 = ((other.inviterIdentity_ == null) ? 2127012864u : 748526413u);
					continue;
				case 17u:
					this.InviteeIdentity.MergeFrom(other.InviteeIdentity);
					arg_2A0_0 = 2074223812u;
					continue;
				case 18u:
					arg_2A0_0 = (((this.inviteeIdentity_ != null) ? 3828127553u : 2265679357u) ^ num * 1091420918u);
					continue;
				case 19u:
					this.Id = other.Id;
					arg_2A0_0 = (num * 1942002201u ^ 1997449377u);
					continue;
				case 20u:
					this.InviteeName = other.InviteeName;
					arg_2A0_0 = (num * 357191779u ^ 3085505821u);
					continue;
				case 21u:
					arg_2A0_0 = ((Invitation.smethod_2(other.InvitationMessage) == 0) ? 773409561u : 150274545u);
					continue;
				case 22u:
					this.InvitationMessage = other.InvitationMessage;
					arg_2A0_0 = (num * 554024972u ^ 3276568353u);
					continue;
				}
				break;
			}
			return;
			IL_1F6:
			arg_2A0_0 = 1593328176u;
			goto IL_29B;
			IL_318:
			arg_2A0_0 = ((other.Id == 0uL) ? 1200532503u : 592320141u);
			goto IL_29B;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_402:
				uint num;
				uint arg_362_0 = ((num = input.ReadTag()) != 0u) ? 2274254786u : 2625044519u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_362_0 ^ 3529736419u)) % 33u)
					{
					case 0u:
						arg_362_0 = ((this.inviterIdentity_ == null) ? 3330333706u : 2498467037u);
						continue;
					case 1u:
						arg_362_0 = (num2 * 2181127679u ^ 1519733500u);
						continue;
					case 2u:
						this.CreationTime = input.ReadUInt64();
						arg_362_0 = 2448045609u;
						continue;
					case 3u:
						arg_362_0 = (num2 * 1756287682u ^ 4222261401u);
						continue;
					case 4u:
						arg_362_0 = (num2 * 638982336u ^ 396340077u);
						continue;
					case 5u:
						arg_362_0 = (((num == 18u) ? 3418098292u : 3239727105u) ^ num2 * 3855750199u);
						continue;
					case 6u:
						arg_362_0 = (num2 * 2251500114u ^ 2562261465u);
						continue;
					case 7u:
						input.ReadMessage(this.inviteeIdentity_);
						arg_362_0 = 3899691593u;
						continue;
					case 8u:
						goto IL_402;
					case 9u:
						arg_362_0 = 2274254786u;
						continue;
					case 10u:
						arg_362_0 = (((num != 34u) ? 3789743322u : 2209346366u) ^ num2 * 4263292234u);
						continue;
					case 11u:
						arg_362_0 = (((num != 42u) ? 2990198601u : 3834036184u) ^ num2 * 960790604u);
						continue;
					case 12u:
						arg_362_0 = (num2 * 1453175822u ^ 3203943267u);
						continue;
					case 13u:
						input.SkipLastField();
						arg_362_0 = 4176392557u;
						continue;
					case 14u:
						this.InviteeName = input.ReadString();
						arg_362_0 = 4176392557u;
						continue;
					case 15u:
						this.InvitationMessage = input.ReadString();
						arg_362_0 = 4176392557u;
						continue;
					case 16u:
						arg_362_0 = ((num <= 50u) ? 2375441553u : 4209111589u);
						continue;
					case 18u:
						arg_362_0 = (((num == 64u) ? 3369739727u : 2350430655u) ^ num2 * 1356460946u);
						continue;
					case 19u:
						arg_362_0 = (((num <= 18u) ? 1327922205u : 56919390u) ^ num2 * 2268859138u);
						continue;
					case 20u:
						this.ExpirationTime = input.ReadUInt64();
						arg_362_0 = 4176392557u;
						continue;
					case 21u:
						arg_362_0 = ((this.inviteeIdentity_ != null) ? 2588326723u : 2480750117u);
						continue;
					case 22u:
						arg_362_0 = (((num != 50u) ? 2914870800u : 3075947315u) ^ num2 * 1215964930u);
						continue;
					case 23u:
						this.inviterIdentity_ = new Identity();
						arg_362_0 = (num2 * 3666864912u ^ 3226281293u);
						continue;
					case 24u:
						input.ReadMessage(this.inviterIdentity_);
						arg_362_0 = 4176392557u;
						continue;
					case 25u:
						arg_362_0 = (num2 * 1725313192u ^ 4274958077u);
						continue;
					case 26u:
						arg_362_0 = ((num > 34u) ? 3434203796u : 3058361567u);
						continue;
					case 27u:
						arg_362_0 = (((num == 9u) ? 2540091302u : 4033386295u) ^ num2 * 2764341436u);
						continue;
					case 28u:
						this.Id = input.ReadFixed64();
						arg_362_0 = 4176392557u;
						continue;
					case 29u:
						arg_362_0 = ((num != 56u) ? 3285001166u : 3558737611u);
						continue;
					case 30u:
						arg_362_0 = ((num == 26u) ? 4073556215u : 2486553761u);
						continue;
					case 31u:
						this.inviteeIdentity_ = new Identity();
						arg_362_0 = (num2 * 1193399668u ^ 2598999291u);
						continue;
					case 32u:
						this.InviterName = input.ReadString();
						arg_362_0 = 2627252891u;
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
