using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class FriendInvitationParams : IMessage<FriendInvitationParams>, IEquatable<FriendInvitationParams>, IDeepCloneable<FriendInvitationParams>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FriendInvitationParams.__c __9 = new FriendInvitationParams.__c();

			internal FriendInvitationParams cctor>b__59_0()
			{
				return new FriendInvitationParams();
			}
		}

		private static readonly MessageParser<FriendInvitationParams> _parser = new MessageParser<FriendInvitationParams>(new Func<FriendInvitationParams>(FriendInvitationParams.__c.__9.<.cctor>b__59_0));

		public const int TargetEmailFieldNumber = 1;

		private string targetEmail_ = "";

		public const int TargetBattleTagFieldNumber = 2;

		private string targetBattleTag_ = "";

		public const int InviterBattleTagFieldNumber = 3;

		private string inviterBattleTag_ = "";

		public const int InviterFullNameFieldNumber = 4;

		private string inviterFullName_ = "";

		public const int InviteeDisplayNameFieldNumber = 5;

		private string inviteeDisplayName_ = "";

		public const int RoleFieldNumber = 6;

		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(50u);

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public const int PreviousRoleDeprecatedFieldNumber = 7;

		private static readonly FieldCodec<uint> _repeated_previousRoleDeprecated_codec = FieldCodec.ForUInt32(58u);

		private readonly RepeatedField<uint> previousRoleDeprecated_ = new RepeatedField<uint>();

		public const int FriendParamsFieldNumber = 103;

		private FriendInvitationParams friendParams_;

		public static MessageParser<FriendInvitationParams> Parser
		{
			get
			{
				return FriendInvitationParams._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendInvitationParams.Descriptor;
			}
		}

		public string TargetEmail
		{
			get
			{
				return this.targetEmail_;
			}
			set
			{
				this.targetEmail_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public string TargetBattleTag
		{
			get
			{
				return this.targetBattleTag_;
			}
			set
			{
				this.targetBattleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string InviterBattleTag
		{
			get
			{
				return this.inviterBattleTag_;
			}
			set
			{
				this.inviterBattleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string InviterFullName
		{
			get
			{
				return this.inviterFullName_;
			}
			set
			{
				this.inviterFullName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public string InviteeDisplayName
		{
			get
			{
				return this.inviteeDisplayName_;
			}
			set
			{
				this.inviteeDisplayName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		[Obsolete]
		public RepeatedField<uint> PreviousRoleDeprecated
		{
			get
			{
				return this.previousRoleDeprecated_;
			}
		}

		public FriendInvitationParams FriendParams
		{
			get
			{
				return this.friendParams_;
			}
			set
			{
				this.friendParams_ = value;
			}
		}

		public FriendInvitationParams()
		{
		}

		public FriendInvitationParams(FriendInvitationParams other) : this()
		{
			while (true)
			{
				IL_109:
				uint arg_DD_0 = 2255238252u;
				while (true)
				{
					uint num;
					switch ((num = (arg_DD_0 ^ 2368817000u)) % 8u)
					{
					case 0u:
						goto IL_109;
					case 1u:
						this.inviterBattleTag_ = other.inviterBattleTag_;
						arg_DD_0 = (num * 3214299529u ^ 854123678u);
						continue;
					case 3u:
						this.targetBattleTag_ = other.targetBattleTag_;
						arg_DD_0 = (num * 4192292525u ^ 843622222u);
						continue;
					case 4u:
						this.targetEmail_ = other.targetEmail_;
						arg_DD_0 = (num * 210951744u ^ 1482506739u);
						continue;
					case 5u:
						this.FriendParams = ((other.friendParams_ != null) ? other.FriendParams.Clone() : null);
						arg_DD_0 = 2821262946u;
						continue;
					case 6u:
						this.inviteeDisplayName_ = other.inviteeDisplayName_;
						this.role_ = other.role_.Clone();
						this.previousRoleDeprecated_ = other.previousRoleDeprecated_.Clone();
						arg_DD_0 = (num * 4120346862u ^ 1583382625u);
						continue;
					case 7u:
						this.inviterFullName_ = other.inviterFullName_;
						arg_DD_0 = (num * 1417074464u ^ 4123635006u);
						continue;
					}
					return;
				}
			}
		}

		public FriendInvitationParams Clone()
		{
			return new FriendInvitationParams(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FriendInvitationParams);
		}

		public bool Equals(FriendInvitationParams other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_202;
			int arg_194_0;
			while (true)
			{
				IL_18F:
				switch ((arg_194_0 ^ 1175706165) % 21)
				{
				case 0:
					arg_194_0 = (FriendInvitationParams.smethod_0(this.TargetEmail, other.TargetEmail) ? 2141320275 : 1139399290);
					continue;
				case 1:
					arg_194_0 = (FriendInvitationParams.smethod_0(this.InviterBattleTag, other.InviterBattleTag) ? 85489346 : 1815050190);
					continue;
				case 2:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_194_0 = ((!FriendInvitationParams.smethod_0(this.InviteeDisplayName, other.InviteeDisplayName)) ? 273642046 : 736590512);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_202;
				case 10:
					arg_194_0 = ((!FriendInvitationParams.smethod_0(this.TargetBattleTag, other.TargetBattleTag)) ? 720002825 : 1787569953);
					continue;
				case 11:
					return false;
				case 12:
					arg_194_0 = (FriendInvitationParams.smethod_1(this.FriendParams, other.FriendParams) ? 1215755718 : 2110369704);
					continue;
				case 13:
					arg_194_0 = (FriendInvitationParams.smethod_0(this.InviterFullName, other.InviterFullName) ? 1096518041 : 794426857);
					continue;
				case 14:
					return false;
				case 15:
					arg_194_0 = (this.role_.Equals(other.role_) ? 815274554 : 1623681335);
					continue;
				case 16:
					return true;
				case 17:
					arg_194_0 = ((!this.previousRoleDeprecated_.Equals(other.previousRoleDeprecated_)) ? 281326030 : 492138051);
					continue;
				case 18:
					goto IL_18;
				case 19:
					return false;
				case 20:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_194_0 = 1679852057;
			goto IL_18F;
			IL_202:
			arg_194_0 = ((other != this) ? 814546190 : 2050183808);
			goto IL_18F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (FriendInvitationParams.smethod_2(this.TargetEmail) != 0)
			{
				goto IL_4D;
			}
			goto IL_1ED;
			uint arg_19D_0;
			while (true)
			{
				IL_198:
				uint num2;
				switch ((num2 = (arg_19D_0 ^ 3989111325u)) % 13u)
				{
				case 0u:
					num ^= FriendInvitationParams.smethod_3(this.TargetBattleTag);
					arg_19D_0 = (num2 * 3590332690u ^ 3493724683u);
					continue;
				case 1u:
					num ^= FriendInvitationParams.smethod_3(this.InviteeDisplayName);
					arg_19D_0 = (num2 * 2924253596u ^ 1500235760u);
					continue;
				case 2u:
					goto IL_1ED;
				case 3u:
					num ^= FriendInvitationParams.smethod_3(this.InviterBattleTag);
					arg_19D_0 = (num2 * 4141327424u ^ 3770721188u);
					continue;
				case 4u:
					arg_19D_0 = ((FriendInvitationParams.smethod_2(this.InviterFullName) != 0) ? 3173906465u : 3842003778u);
					continue;
				case 5u:
					num ^= FriendInvitationParams.smethod_3(this.InviterFullName);
					arg_19D_0 = (num2 * 188190018u ^ 1640487994u);
					continue;
				case 6u:
					arg_19D_0 = ((FriendInvitationParams.smethod_2(this.InviteeDisplayName) != 0) ? 3608851372u : 4226436908u);
					continue;
				case 8u:
					num ^= FriendInvitationParams.smethod_3(this.role_);
					num ^= FriendInvitationParams.smethod_3(this.previousRoleDeprecated_);
					arg_19D_0 = ((this.friendParams_ != null) ? 2922373390u : 4191303718u);
					continue;
				case 9u:
					num ^= FriendInvitationParams.smethod_3(this.TargetEmail);
					arg_19D_0 = (num2 * 3233752418u ^ 1741967521u);
					continue;
				case 10u:
					num ^= FriendInvitationParams.smethod_3(this.FriendParams);
					arg_19D_0 = (num2 * 3489485003u ^ 4046272567u);
					continue;
				case 11u:
					goto IL_4D;
				case 12u:
					arg_19D_0 = ((FriendInvitationParams.smethod_2(this.InviterBattleTag) == 0) ? 2309832484u : 2778574415u);
					continue;
				}
				break;
			}
			return num;
			IL_4D:
			arg_19D_0 = 2315770190u;
			goto IL_198;
			IL_1ED:
			arg_19D_0 = ((FriendInvitationParams.smethod_2(this.TargetBattleTag) != 0) ? 4027313200u : 3011415585u);
			goto IL_198;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (FriendInvitationParams.smethod_2(this.TargetEmail) != 0)
			{
				goto IL_22;
			}
			goto IL_271;
			uint arg_211_0;
			while (true)
			{
				IL_20C:
				uint num;
				switch ((num = (arg_211_0 ^ 3269060556u)) % 17u)
				{
				case 1u:
					output.WriteString(this.TargetEmail);
					arg_211_0 = (num * 3245396760u ^ 889194438u);
					continue;
				case 2u:
					this.role_.WriteTo(output, FriendInvitationParams._repeated_role_codec);
					arg_211_0 = 2785565825u;
					continue;
				case 3u:
					output.WriteRawTag(26);
					arg_211_0 = (num * 1011395629u ^ 665320106u);
					continue;
				case 4u:
					arg_211_0 = ((FriendInvitationParams.smethod_2(this.InviterBattleTag) == 0) ? 2342553067u : 4138643730u);
					continue;
				case 5u:
					output.WriteRawTag(42);
					output.WriteString(this.InviteeDisplayName);
					arg_211_0 = (num * 2971126182u ^ 3547355352u);
					continue;
				case 6u:
					output.WriteRawTag(186, 6);
					arg_211_0 = (num * 1600449145u ^ 1856797397u);
					continue;
				case 7u:
					output.WriteString(this.InviterBattleTag);
					arg_211_0 = (num * 1813342572u ^ 1049775467u);
					continue;
				case 8u:
					arg_211_0 = ((FriendInvitationParams.smethod_2(this.InviterFullName) == 0) ? 3782662459u : 3197591182u);
					continue;
				case 9u:
					arg_211_0 = ((FriendInvitationParams.smethod_2(this.InviteeDisplayName) == 0) ? 2666168356u : 2460945670u);
					continue;
				case 10u:
					output.WriteRawTag(10);
					arg_211_0 = (num * 1025200798u ^ 1421611565u);
					continue;
				case 11u:
					output.WriteRawTag(34);
					output.WriteString(this.InviterFullName);
					arg_211_0 = (num * 1769711113u ^ 2666370665u);
					continue;
				case 12u:
					this.previousRoleDeprecated_.WriteTo(output, FriendInvitationParams._repeated_previousRoleDeprecated_codec);
					arg_211_0 = (((this.friendParams_ == null) ? 226482572u : 1743902468u) ^ num * 2386056183u);
					continue;
				case 13u:
					output.WriteMessage(this.FriendParams);
					arg_211_0 = (num * 4281373831u ^ 3619136601u);
					continue;
				case 14u:
					goto IL_271;
				case 15u:
					output.WriteRawTag(18);
					output.WriteString(this.TargetBattleTag);
					arg_211_0 = (num * 328591779u ^ 2069100781u);
					continue;
				case 16u:
					goto IL_22;
				}
				break;
			}
			return;
			IL_22:
			arg_211_0 = 2855025521u;
			goto IL_20C;
			IL_271:
			arg_211_0 = ((FriendInvitationParams.smethod_2(this.TargetBattleTag) != 0) ? 3505347448u : 3759014513u);
			goto IL_20C;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (FriendInvitationParams.smethod_2(this.TargetEmail) != 0)
			{
				goto IL_124;
			}
			goto IL_235;
			uint arg_1DD_0;
			while (true)
			{
				IL_1D8:
				uint num2;
				switch ((num2 = (arg_1DD_0 ^ 727562242u)) % 15u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviterFullName);
					arg_1DD_0 = (num2 * 1086243656u ^ 3216930187u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.TargetBattleTag);
					arg_1DD_0 = (num2 * 2766512319u ^ 3727932363u);
					continue;
				case 3u:
					arg_1DD_0 = ((FriendInvitationParams.smethod_2(this.InviterFullName) != 0) ? 687272u : 1041676379u);
					continue;
				case 4u:
					num += 2 + CodedOutputStream.ComputeMessageSize(this.FriendParams);
					arg_1DD_0 = (num2 * 1753864383u ^ 2228110332u);
					continue;
				case 5u:
					arg_1DD_0 = ((FriendInvitationParams.smethod_2(this.InviteeDisplayName) != 0) ? 967203323u : 1116105295u);
					continue;
				case 6u:
					goto IL_124;
				case 7u:
					num += this.previousRoleDeprecated_.CalculateSize(FriendInvitationParams._repeated_previousRoleDeprecated_codec);
					arg_1DD_0 = (num2 * 1695451879u ^ 4276178044u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviteeDisplayName);
					arg_1DD_0 = (num2 * 20702446u ^ 1247195953u);
					continue;
				case 9u:
					arg_1DD_0 = ((FriendInvitationParams.smethod_2(this.InviterBattleTag) == 0) ? 340659389u : 104597575u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.TargetEmail);
					arg_1DD_0 = (num2 * 2293634479u ^ 512053801u);
					continue;
				case 11u:
					num += this.role_.CalculateSize(FriendInvitationParams._repeated_role_codec);
					arg_1DD_0 = 144266922u;
					continue;
				case 12u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviterBattleTag);
					arg_1DD_0 = (num2 * 24110972u ^ 3221530833u);
					continue;
				case 13u:
					goto IL_235;
				case 14u:
					arg_1DD_0 = (((this.friendParams_ != null) ? 1321111258u : 1785774168u) ^ num2 * 3389185841u);
					continue;
				}
				break;
			}
			return num;
			IL_124:
			arg_1DD_0 = 1799268225u;
			goto IL_1D8;
			IL_235:
			arg_1DD_0 = ((FriendInvitationParams.smethod_2(this.TargetBattleTag) != 0) ? 1619248506u : 468789059u);
			goto IL_1D8;
		}

		public void MergeFrom(FriendInvitationParams other)
		{
			if (other == null)
			{
				goto IL_15D;
			}
			goto IL_289;
			uint arg_221_0;
			while (true)
			{
				IL_21C:
				uint num;
				switch ((num = (arg_221_0 ^ 3302905434u)) % 19u)
				{
				case 0u:
					arg_221_0 = ((FriendInvitationParams.smethod_2(other.TargetBattleTag) == 0) ? 3316417408u : 3195953158u);
					continue;
				case 1u:
					this.FriendParams.MergeFrom(other.FriendParams);
					arg_221_0 = 2796204070u;
					continue;
				case 3u:
					this.role_.Add(other.role_);
					arg_221_0 = 3760559042u;
					continue;
				case 4u:
					this.InviterFullName = other.InviterFullName;
					arg_221_0 = (num * 3184389384u ^ 2693033320u);
					continue;
				case 5u:
					this.friendParams_ = new FriendInvitationParams();
					arg_221_0 = (num * 88014056u ^ 2458062253u);
					continue;
				case 6u:
					arg_221_0 = (((this.friendParams_ == null) ? 457790043u : 914328166u) ^ num * 366019385u);
					continue;
				case 7u:
					goto IL_289;
				case 8u:
					goto IL_15D;
				case 9u:
					this.TargetBattleTag = other.TargetBattleTag;
					arg_221_0 = (num * 2498957470u ^ 3191328584u);
					continue;
				case 10u:
					this.TargetEmail = other.TargetEmail;
					arg_221_0 = (num * 711730810u ^ 358553416u);
					continue;
				case 11u:
					arg_221_0 = (((other.friendParams_ != null) ? 201906113u : 371006350u) ^ num * 2813562266u);
					continue;
				case 12u:
					this.previousRoleDeprecated_.Add(other.previousRoleDeprecated_);
					arg_221_0 = (num * 191257306u ^ 3375529998u);
					continue;
				case 13u:
					arg_221_0 = ((FriendInvitationParams.smethod_2(other.InviteeDisplayName) != 0) ? 2973106760u : 3091903749u);
					continue;
				case 14u:
					arg_221_0 = ((FriendInvitationParams.smethod_2(other.InviterBattleTag) != 0) ? 2986202203u : 2339299982u);
					continue;
				case 15u:
					return;
				case 16u:
					arg_221_0 = ((FriendInvitationParams.smethod_2(other.InviterFullName) == 0) ? 2466686112u : 3751400131u);
					continue;
				case 17u:
					this.InviteeDisplayName = other.InviteeDisplayName;
					arg_221_0 = (num * 2340848922u ^ 3439023825u);
					continue;
				case 18u:
					this.InviterBattleTag = other.InviterBattleTag;
					arg_221_0 = (num * 2200939543u ^ 1238808729u);
					continue;
				}
				break;
			}
			return;
			IL_15D:
			arg_221_0 = 2187005870u;
			goto IL_21C;
			IL_289:
			arg_221_0 = ((FriendInvitationParams.smethod_2(other.TargetEmail) != 0) ? 4167100066u : 2358915448u);
			goto IL_21C;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_44C:
				uint num;
				uint arg_3A4_0 = ((num = input.ReadTag()) == 0u) ? 206374280u : 2054628544u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3A4_0 ^ 524765286u)) % 35u)
					{
					case 0u:
						arg_3A4_0 = 2054628544u;
						continue;
					case 1u:
						arg_3A4_0 = ((num <= 50u) ? 104493640u : 59807835u);
						continue;
					case 2u:
						arg_3A4_0 = ((num != 26u) ? 883388049u : 434417743u);
						continue;
					case 3u:
						this.TargetBattleTag = input.ReadString();
						arg_3A4_0 = 1374247454u;
						continue;
					case 5u:
						arg_3A4_0 = (num2 * 3305819265u ^ 523759572u);
						continue;
					case 6u:
						arg_3A4_0 = (((num != 10u) ? 3594263217u : 2922405909u) ^ num2 * 4265562731u);
						continue;
					case 7u:
						arg_3A4_0 = ((num != 56u) ? 496414743u : 1339154395u);
						continue;
					case 8u:
						arg_3A4_0 = (((num == 42u) ? 635976815u : 1869464573u) ^ num2 * 1271652621u);
						continue;
					case 9u:
						arg_3A4_0 = (((num > 18u) ? 2343221922u : 2720400756u) ^ num2 * 560725071u);
						continue;
					case 10u:
						arg_3A4_0 = ((this.friendParams_ != null) ? 269504788u : 31722538u);
						continue;
					case 11u:
						input.ReadMessage(this.friendParams_);
						arg_3A4_0 = 14581929u;
						continue;
					case 12u:
						arg_3A4_0 = (num2 * 3776950618u ^ 4072993863u);
						continue;
					case 13u:
						this.InviterFullName = input.ReadString();
						arg_3A4_0 = 1742362319u;
						continue;
					case 14u:
						arg_3A4_0 = (((num == 48u) ? 2229725959u : 2653305000u) ^ num2 * 394716768u);
						continue;
					case 15u:
						arg_3A4_0 = (((num == 826u) ? 114969049u : 842119137u) ^ num2 * 2803297186u);
						continue;
					case 16u:
						arg_3A4_0 = (num2 * 1164143711u ^ 1933978654u);
						continue;
					case 17u:
						arg_3A4_0 = (((num == 18u) ? 663458871u : 1015495037u) ^ num2 * 2295647848u);
						continue;
					case 18u:
						arg_3A4_0 = ((num > 42u) ? 395002725u : 1585366284u);
						continue;
					case 19u:
						arg_3A4_0 = (num2 * 3443473257u ^ 3364376217u);
						continue;
					case 20u:
						this.role_.AddEntriesFrom(input, FriendInvitationParams._repeated_role_codec);
						arg_3A4_0 = 14581929u;
						continue;
					case 21u:
						goto IL_44C;
					case 22u:
						arg_3A4_0 = (((num != 34u) ? 1151456998u : 492303359u) ^ num2 * 3611771621u);
						continue;
					case 23u:
						arg_3A4_0 = (num2 * 3390011310u ^ 2482167555u);
						continue;
					case 24u:
						input.SkipLastField();
						arg_3A4_0 = 1021582491u;
						continue;
					case 25u:
						this.previousRoleDeprecated_.AddEntriesFrom(input, FriendInvitationParams._repeated_previousRoleDeprecated_codec);
						arg_3A4_0 = 1225529429u;
						continue;
					case 26u:
						arg_3A4_0 = (num2 * 1587718082u ^ 765277505u);
						continue;
					case 27u:
						arg_3A4_0 = (((num == 58u) ? 1499132729u : 173924878u) ^ num2 * 1373174786u);
						continue;
					case 28u:
						this.InviterBattleTag = input.ReadString();
						arg_3A4_0 = 14581929u;
						continue;
					case 29u:
						this.TargetEmail = input.ReadString();
						arg_3A4_0 = 14581929u;
						continue;
					case 30u:
						arg_3A4_0 = (num2 * 1078052058u ^ 4127791769u);
						continue;
					case 31u:
						arg_3A4_0 = (((num == 50u) ? 1402063719u : 1173914748u) ^ num2 * 3679770864u);
						continue;
					case 32u:
						this.friendParams_ = new FriendInvitationParams();
						arg_3A4_0 = (num2 * 171481545u ^ 2595379896u);
						continue;
					case 33u:
						this.InviteeDisplayName = input.ReadString();
						arg_3A4_0 = 574526549u;
						continue;
					case 34u:
						arg_3A4_0 = (num2 * 3907211007u ^ 3528186792u);
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

		static int smethod_3(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
