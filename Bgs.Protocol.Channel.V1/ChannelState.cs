using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class ChannelState : IMessage<ChannelState>, IEquatable<ChannelState>, IDeepCloneable<ChannelState>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum PrivacyLevel
			{
				NONE,
				PRIVACY_LEVEL_OPEN,
				PRIVACY_LEVEL_OPEN_INVITATION_AND_FRIEND,
				PRIVACY_LEVEL_OPEN_INVITATION,
				PRIVACY_LEVEL_CLOSED
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChannelState.__c __9 = new ChannelState.__c();

			internal ChannelState cctor>b__90_0()
			{
				return new ChannelState();
			}
		}

		private static readonly MessageParser<ChannelState> _parser = new MessageParser<ChannelState>(new Func<ChannelState>(ChannelState.__c.__9.<.cctor>b__90_0));

		public const int MaxMembersFieldNumber = 1;

		private uint maxMembers_;

		public const int MinMembersFieldNumber = 2;

		private uint minMembers_;

		public const int AttributeFieldNumber = 3;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int InvitationFieldNumber = 4;

		private static readonly FieldCodec<Invitation> _repeated_invitation_codec;

		private readonly RepeatedField<Invitation> invitation_ = new RepeatedField<Invitation>();

		public const int MaxInvitationsFieldNumber = 5;

		private uint maxInvitations_;

		public const int ReasonFieldNumber = 6;

		private uint reason_;

		public const int PrivacyLevelFieldNumber = 7;

		private ChannelState.Types.PrivacyLevel privacyLevel_;

		public const int NameFieldNumber = 8;

		private string name_ = "";

		public const int DelegateNameFieldNumber = 9;

		private string delegateName_ = "";

		public const int ChannelTypeFieldNumber = 10;

		private string channelType_ = "";

		public const int ProgramFieldNumber = 11;

		private uint program_;

		public const int AllowOfflineMembersFieldNumber = 12;

		private bool allowOfflineMembers_;

		public const int SubscribeToPresenceFieldNumber = 13;

		private bool subscribeToPresence_;

		public const int DestroyOnFounderLeaveFieldNumber = 14;

		private bool destroyOnFounderLeave_;

		public static MessageParser<ChannelState> Parser
		{
			get
			{
				return ChannelState._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelState.Descriptor;
			}
		}

		public uint MaxMembers
		{
			get
			{
				return this.maxMembers_;
			}
			set
			{
				this.maxMembers_ = value;
			}
		}

		public uint MinMembers
		{
			get
			{
				return this.minMembers_;
			}
			set
			{
				this.minMembers_ = value;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public RepeatedField<Invitation> Invitation
		{
			get
			{
				return this.invitation_;
			}
		}

		public uint MaxInvitations
		{
			get
			{
				return this.maxInvitations_;
			}
			set
			{
				this.maxInvitations_ = value;
			}
		}

		public uint Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		public ChannelState.Types.PrivacyLevel PrivacyLevel
		{
			get
			{
				return this.privacyLevel_;
			}
			set
			{
				this.privacyLevel_ = value;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string DelegateName
		{
			get
			{
				return this.delegateName_;
			}
			set
			{
				this.delegateName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public string ChannelType
		{
			get
			{
				return this.channelType_;
			}
			set
			{
				this.channelType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
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

		public bool AllowOfflineMembers
		{
			get
			{
				return this.allowOfflineMembers_;
			}
			set
			{
				this.allowOfflineMembers_ = value;
			}
		}

		public bool SubscribeToPresence
		{
			get
			{
				return this.subscribeToPresence_;
			}
			set
			{
				this.subscribeToPresence_ = value;
			}
		}

		public bool DestroyOnFounderLeave
		{
			get
			{
				return this.destroyOnFounderLeave_;
			}
			set
			{
				this.destroyOnFounderLeave_ = value;
			}
		}

		public ChannelState()
		{
		}

		public ChannelState(ChannelState other) : this()
		{
			this.maxMembers_ = other.maxMembers_;
			this.minMembers_ = other.minMembers_;
			this.attribute_ = other.attribute_.Clone();
			this.invitation_ = other.invitation_.Clone();
			this.maxInvitations_ = other.maxInvitations_;
			this.reason_ = other.reason_;
			this.privacyLevel_ = other.privacyLevel_;
			this.name_ = other.name_;
			this.delegateName_ = other.delegateName_;
			this.channelType_ = other.channelType_;
			this.program_ = other.program_;
			this.allowOfflineMembers_ = other.allowOfflineMembers_;
			this.subscribeToPresence_ = other.subscribeToPresence_;
			this.destroyOnFounderLeave_ = other.destroyOnFounderLeave_;
		}

		public ChannelState Clone()
		{
			return new ChannelState(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelState);
		}

		public bool Equals(ChannelState other)
		{
			if (other == null)
			{
				goto IL_274;
			}
			goto IL_31C;
			int arg_27E_0;
			while (true)
			{
				IL_279:
				switch ((arg_27E_0 ^ 983009610) % 33)
				{
				case 0:
					goto IL_274;
				case 1:
					arg_27E_0 = ((this.DestroyOnFounderLeave != other.DestroyOnFounderLeave) ? 2087773962 : 1225408122);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_27E_0 = ((this.MaxInvitations != other.MaxInvitations) ? 1579945811 : 1761378684);
					continue;
				case 5:
					arg_27E_0 = ((this.Program == other.Program) ? 1572850154 : 1147624128);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return true;
				case 9:
					return false;
				case 10:
					return false;
				case 12:
					arg_27E_0 = ((!this.attribute_.Equals(other.attribute_)) ? 417384277 : 1653307004);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_27E_0 = (ChannelState.smethod_0(this.ChannelType, other.ChannelType) ? 261079218 : 334673294);
					continue;
				case 16:
					arg_27E_0 = ((this.MinMembers != other.MinMembers) ? 637679815 : 1642901761);
					continue;
				case 17:
					arg_27E_0 = ((this.PrivacyLevel == other.PrivacyLevel) ? 581036697 : 635137934);
					continue;
				case 18:
					arg_27E_0 = ((this.SubscribeToPresence != other.SubscribeToPresence) ? 971636959 : 770685264);
					continue;
				case 19:
					return false;
				case 20:
					return false;
				case 21:
					arg_27E_0 = ((!ChannelState.smethod_0(this.DelegateName, other.DelegateName)) ? 1040829083 : 1106545803);
					continue;
				case 22:
					return false;
				case 23:
					return false;
				case 24:
					return false;
				case 25:
					arg_27E_0 = (ChannelState.smethod_0(this.Name, other.Name) ? 1615176884 : 1221953630);
					continue;
				case 26:
					arg_27E_0 = (this.invitation_.Equals(other.invitation_) ? 596243089 : 1643615237);
					continue;
				case 27:
					return false;
				case 28:
					arg_27E_0 = ((this.AllowOfflineMembers == other.AllowOfflineMembers) ? 427355199 : 1641362163);
					continue;
				case 29:
					arg_27E_0 = ((this.MaxMembers != other.MaxMembers) ? 107195872 : 1410737933);
					continue;
				case 30:
					return false;
				case 31:
					goto IL_31C;
				case 32:
					arg_27E_0 = ((this.Reason == other.Reason) ? 1728439146 : 1408391749);
					continue;
				}
				break;
			}
			return true;
			IL_274:
			arg_27E_0 = 1070178264;
			goto IL_279;
			IL_31C:
			arg_27E_0 = ((other != this) ? 1831189131 : 1582004344);
			goto IL_279;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_430:
				uint arg_3B2_0 = 448713372u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3B2_0 ^ 1592648795u)) % 28u)
					{
					case 0u:
						arg_3B2_0 = ((this.ChannelType.Length != 0) ? 1276156829u : 362184038u);
						continue;
					case 1u:
						num ^= this.MinMembers.GetHashCode();
						arg_3B2_0 = (num2 * 4167873605u ^ 791879837u);
						continue;
					case 2u:
						arg_3B2_0 = ((!this.SubscribeToPresence) ? 1185913090u : 1003902215u);
						continue;
					case 3u:
						num ^= this.attribute_.GetHashCode();
						arg_3B2_0 = 1588206879u;
						continue;
					case 4u:
						num ^= this.SubscribeToPresence.GetHashCode();
						arg_3B2_0 = (num2 * 2143620003u ^ 1673754774u);
						continue;
					case 5u:
						arg_3B2_0 = ((!this.AllowOfflineMembers) ? 1680185373u : 616051794u);
						continue;
					case 6u:
						goto IL_430;
					case 7u:
						arg_3B2_0 = ((this.DelegateName.Length != 0) ? 237652410u : 1280049503u);
						continue;
					case 8u:
						num ^= this.Name.GetHashCode();
						arg_3B2_0 = (num2 * 2075495364u ^ 2429178156u);
						continue;
					case 9u:
						num ^= this.DelegateName.GetHashCode();
						arg_3B2_0 = (num2 * 130374347u ^ 2060515892u);
						continue;
					case 10u:
						num ^= this.MaxInvitations.GetHashCode();
						arg_3B2_0 = (num2 * 516579266u ^ 2371157161u);
						continue;
					case 11u:
						arg_3B2_0 = ((this.Name.Length != 0) ? 958969043u : 1295634700u);
						continue;
					case 12u:
						num ^= this.MaxMembers.GetHashCode();
						arg_3B2_0 = (num2 * 800594101u ^ 48453180u);
						continue;
					case 13u:
						num ^= this.AllowOfflineMembers.GetHashCode();
						arg_3B2_0 = (num2 * 1629284222u ^ 2866092915u);
						continue;
					case 14u:
						arg_3B2_0 = ((this.PrivacyLevel == ChannelState.Types.PrivacyLevel.NONE) ? 366803448u : 2137781863u);
						continue;
					case 16u:
						num ^= this.invitation_.GetHashCode();
						arg_3B2_0 = (num2 * 3379332212u ^ 4242719232u);
						continue;
					case 17u:
						arg_3B2_0 = ((!this.DestroyOnFounderLeave) ? 160008356u : 1509066163u);
						continue;
					case 18u:
						num ^= this.Program.GetHashCode();
						arg_3B2_0 = (num2 * 1589944475u ^ 1336134328u);
						continue;
					case 19u:
						arg_3B2_0 = (((this.MaxMembers == 0u) ? 2313997987u : 3226166036u) ^ num2 * 1912930581u);
						continue;
					case 20u:
						num ^= this.PrivacyLevel.GetHashCode();
						arg_3B2_0 = (num2 * 186882310u ^ 3923947664u);
						continue;
					case 21u:
						arg_3B2_0 = ((this.Program == 0u) ? 61380722u : 182001573u);
						continue;
					case 22u:
						arg_3B2_0 = ((this.Reason == 0u) ? 483006989u : 226561946u);
						continue;
					case 23u:
						arg_3B2_0 = (((this.MaxInvitations != 0u) ? 3643547900u : 4091918876u) ^ num2 * 121693083u);
						continue;
					case 24u:
						num ^= this.DestroyOnFounderLeave.GetHashCode();
						arg_3B2_0 = (num2 * 3391965033u ^ 3964078220u);
						continue;
					case 25u:
						num ^= this.Reason.GetHashCode();
						arg_3B2_0 = (num2 * 1422614395u ^ 3658940086u);
						continue;
					case 26u:
						num ^= this.ChannelType.GetHashCode();
						arg_3B2_0 = (num2 * 735332133u ^ 178068728u);
						continue;
					case 27u:
						arg_3B2_0 = ((this.MinMembers == 0u) ? 711459592u : 858082122u);
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
			if (this.MaxMembers != 0u)
			{
				goto IL_84;
			}
			goto IL_495;
			uint arg_3F9_0;
			while (true)
			{
				IL_3F4:
				uint num;
				switch ((num = (arg_3F9_0 ^ 1360226264u)) % 32u)
				{
				case 0u:
					arg_3F9_0 = (this.DestroyOnFounderLeave ? 831371793u : 1859043545u);
					continue;
				case 2u:
					output.WriteRawTag(74);
					arg_3F9_0 = (num * 1643230646u ^ 3602672687u);
					continue;
				case 3u:
					arg_3F9_0 = (this.AllowOfflineMembers ? 2079197264u : 1123055093u);
					continue;
				case 4u:
					arg_3F9_0 = ((ChannelState.smethod_1(this.ChannelType) != 0) ? 50788297u : 1602525150u);
					continue;
				case 5u:
					output.WriteRawTag(16);
					output.WriteUInt32(this.MinMembers);
					arg_3F9_0 = (num * 2797237824u ^ 4207688903u);
					continue;
				case 6u:
					arg_3F9_0 = ((this.Program == 0u) ? 1867091995u : 1660453806u);
					continue;
				case 7u:
					output.WriteRawTag(56);
					arg_3F9_0 = (num * 4203002461u ^ 490904956u);
					continue;
				case 8u:
					output.WriteRawTag(96);
					arg_3F9_0 = (num * 2418338104u ^ 633350959u);
					continue;
				case 9u:
					output.WriteRawTag(112);
					arg_3F9_0 = (num * 1982005786u ^ 375331522u);
					continue;
				case 10u:
					arg_3F9_0 = ((this.Reason != 0u) ? 49814565u : 88519604u);
					continue;
				case 11u:
					output.WriteBool(this.SubscribeToPresence);
					arg_3F9_0 = (num * 3889453034u ^ 1804712630u);
					continue;
				case 12u:
					arg_3F9_0 = ((this.PrivacyLevel == ChannelState.Types.PrivacyLevel.NONE) ? 475036715u : 1644667679u);
					continue;
				case 13u:
					arg_3F9_0 = (this.SubscribeToPresence ? 2122586976u : 480507512u);
					continue;
				case 14u:
					output.WriteString(this.ChannelType);
					arg_3F9_0 = (num * 2838236788u ^ 859808262u);
					continue;
				case 15u:
					output.WriteEnum((int)this.PrivacyLevel);
					arg_3F9_0 = (num * 50929022u ^ 3163210889u);
					continue;
				case 16u:
					output.WriteBool(this.DestroyOnFounderLeave);
					arg_3F9_0 = (num * 1196937048u ^ 1539223129u);
					continue;
				case 17u:
					output.WriteRawTag(82);
					arg_3F9_0 = (num * 3848789396u ^ 1791218018u);
					continue;
				case 18u:
					output.WriteRawTag(40);
					output.WriteUInt32(this.MaxInvitations);
					arg_3F9_0 = (num * 3800031165u ^ 1086958808u);
					continue;
				case 19u:
					arg_3F9_0 = ((ChannelState.smethod_1(this.Name) == 0) ? 1892912909u : 942337190u);
					continue;
				case 20u:
					this.invitation_.WriteTo(output, ChannelState._repeated_invitation_codec);
					arg_3F9_0 = (((this.MaxInvitations == 0u) ? 3470271514u : 3590518210u) ^ num * 3499065114u);
					continue;
				case 21u:
					arg_3F9_0 = ((ChannelState.smethod_1(this.DelegateName) != 0) ? 1270866778u : 1977290236u);
					continue;
				case 22u:
					output.WriteRawTag(93);
					output.WriteFixed32(this.Program);
					arg_3F9_0 = (num * 580398978u ^ 2441231863u);
					continue;
				case 23u:
					output.WriteBool(this.AllowOfflineMembers);
					arg_3F9_0 = (num * 2412640745u ^ 3728838650u);
					continue;
				case 24u:
					output.WriteRawTag(104);
					arg_3F9_0 = (num * 1009231673u ^ 3178618955u);
					continue;
				case 25u:
					goto IL_495;
				case 26u:
					output.WriteRawTag(8);
					output.WriteUInt32(this.MaxMembers);
					arg_3F9_0 = (num * 3862516516u ^ 481125801u);
					continue;
				case 27u:
					output.WriteString(this.DelegateName);
					arg_3F9_0 = (num * 1704668432u ^ 3385693516u);
					continue;
				case 28u:
					goto IL_84;
				case 29u:
					output.WriteRawTag(48);
					output.WriteUInt32(this.Reason);
					arg_3F9_0 = (num * 3435013883u ^ 3679890619u);
					continue;
				case 30u:
					output.WriteRawTag(66);
					output.WriteString(this.Name);
					arg_3F9_0 = (num * 3530364040u ^ 1456373245u);
					continue;
				case 31u:
					this.attribute_.WriteTo(output, ChannelState._repeated_attribute_codec);
					arg_3F9_0 = 561881452u;
					continue;
				}
				break;
			}
			return;
			IL_84:
			arg_3F9_0 = 141114498u;
			goto IL_3F4;
			IL_495:
			arg_3F9_0 = ((this.MinMembers == 0u) ? 769340295u : 971056349u);
			goto IL_3F4;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_3DE:
				uint arg_365_0 = 1443195449u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_365_0 ^ 1858431049u)) % 27u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.DelegateName);
						arg_365_0 = (num2 * 3571166690u ^ 3691660175u);
						continue;
					case 2u:
						arg_365_0 = ((this.MinMembers == 0u) ? 1618862722u : 1135960244u);
						continue;
					case 3u:
						arg_365_0 = ((ChannelState.smethod_1(this.Name) != 0) ? 1199456088u : 195286549u);
						continue;
					case 4u:
						arg_365_0 = ((this.PrivacyLevel != ChannelState.Types.PrivacyLevel.NONE) ? 220222364u : 1878864589u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_365_0 = (num2 * 1100426486u ^ 4070588483u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxInvitations);
						arg_365_0 = (num2 * 4265146383u ^ 2820432835u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
						arg_365_0 = (num2 * 2573616096u ^ 1672432049u);
						continue;
					case 8u:
						goto IL_3DE;
					case 9u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
						arg_365_0 = (num2 * 2574501097u ^ 4108106256u);
						continue;
					case 10u:
						num += 5;
						arg_365_0 = (num2 * 875129769u ^ 3455518753u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxMembers);
						arg_365_0 = (num2 * 100807387u ^ 601605268u);
						continue;
					case 12u:
						arg_365_0 = ((ChannelState.smethod_1(this.ChannelType) == 0) ? 186470626u : 818996877u);
						continue;
					case 13u:
						num += 2;
						arg_365_0 = (num2 * 295547762u ^ 2893019423u);
						continue;
					case 14u:
						arg_365_0 = (this.AllowOfflineMembers ? 2111637610u : 939845983u);
						continue;
					case 15u:
						num += this.invitation_.CalculateSize(ChannelState._repeated_invitation_codec);
						arg_365_0 = (((this.MaxInvitations == 0u) ? 3729278620u : 4031685592u) ^ num2 * 560157716u);
						continue;
					case 16u:
						arg_365_0 = ((this.Reason == 0u) ? 1594800017u : 1205695398u);
						continue;
					case 17u:
						arg_365_0 = (((this.MaxMembers == 0u) ? 3107107182u : 3645919175u) ^ num2 * 976254578u);
						continue;
					case 18u:
						arg_365_0 = (this.DestroyOnFounderLeave ? 2007503011u : 597788001u);
						continue;
					case 19u:
						arg_365_0 = ((this.Program != 0u) ? 717283889u : 137861401u);
						continue;
					case 20u:
						arg_365_0 = ((ChannelState.smethod_1(this.DelegateName) != 0) ? 154666798u : 1999351905u);
						continue;
					case 21u:
						num += 2;
						arg_365_0 = (num2 * 3152193468u ^ 1686603755u);
						continue;
					case 22u:
						arg_365_0 = (this.SubscribeToPresence ? 2142471807u : 818687763u);
						continue;
					case 23u:
						num += this.attribute_.CalculateSize(ChannelState._repeated_attribute_codec);
						arg_365_0 = 2076121554u;
						continue;
					case 24u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelType);
						arg_365_0 = (num2 * 3544029680u ^ 2887887650u);
						continue;
					case 25u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinMembers);
						arg_365_0 = (num2 * 2768036268u ^ 2353366142u);
						continue;
					case 26u:
						num += 2;
						arg_365_0 = (num2 * 2597461069u ^ 2965074691u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChannelState other)
		{
			if (other == null)
			{
				goto IL_232;
			}
			goto IL_3F2;
			uint arg_362_0;
			while (true)
			{
				IL_35D:
				uint num;
				switch ((num = (arg_362_0 ^ 1155922278u)) % 29u)
				{
				case 0u:
					arg_362_0 = ((!other.AllowOfflineMembers) ? 1300710262u : 2144413263u);
					continue;
				case 1u:
					arg_362_0 = ((other.Program == 0u) ? 1183055139u : 1508506733u);
					continue;
				case 2u:
					arg_362_0 = ((other.Reason != 0u) ? 94810869u : 352138629u);
					continue;
				case 3u:
					this.MaxInvitations = other.MaxInvitations;
					arg_362_0 = (num * 4283710677u ^ 4239040579u);
					continue;
				case 4u:
					this.PrivacyLevel = other.PrivacyLevel;
					arg_362_0 = (num * 1028149320u ^ 2798380415u);
					continue;
				case 5u:
					arg_362_0 = ((!other.SubscribeToPresence) ? 40118684u : 1779533638u);
					continue;
				case 6u:
					this.MinMembers = other.MinMembers;
					arg_362_0 = (num * 2950868703u ^ 3268574190u);
					continue;
				case 7u:
					arg_362_0 = ((!other.DestroyOnFounderLeave) ? 1913687264u : 955355846u);
					continue;
				case 8u:
					arg_362_0 = ((other.MinMembers != 0u) ? 1432739455u : 915765033u);
					continue;
				case 9u:
					goto IL_232;
				case 10u:
					arg_362_0 = ((ChannelState.smethod_1(other.Name) != 0) ? 645091481u : 1188302669u);
					continue;
				case 11u:
					arg_362_0 = (((other.MaxInvitations != 0u) ? 2342665547u : 3976766274u) ^ num * 37227225u);
					continue;
				case 12u:
					this.attribute_.Add(other.attribute_);
					arg_362_0 = 2035103237u;
					continue;
				case 13u:
					this.SubscribeToPresence = other.SubscribeToPresence;
					arg_362_0 = (num * 899203881u ^ 1180613308u);
					continue;
				case 14u:
					this.AllowOfflineMembers = other.AllowOfflineMembers;
					arg_362_0 = (num * 1557216786u ^ 2847661460u);
					continue;
				case 15u:
					arg_362_0 = ((other.PrivacyLevel == ChannelState.Types.PrivacyLevel.NONE) ? 979563631u : 2038798580u);
					continue;
				case 16u:
					this.Name = other.Name;
					arg_362_0 = (num * 2341106919u ^ 363134548u);
					continue;
				case 17u:
					this.ChannelType = other.ChannelType;
					arg_362_0 = (num * 1475626796u ^ 2291729458u);
					continue;
				case 18u:
					this.invitation_.Add(other.invitation_);
					arg_362_0 = (num * 1121354080u ^ 28163694u);
					continue;
				case 19u:
					this.DelegateName = other.DelegateName;
					arg_362_0 = (num * 2728625271u ^ 8364114u);
					continue;
				case 20u:
					arg_362_0 = ((ChannelState.smethod_1(other.DelegateName) != 0) ? 1655025425u : 1346186499u);
					continue;
				case 21u:
					this.Reason = other.Reason;
					arg_362_0 = (num * 1311345153u ^ 2021047318u);
					continue;
				case 22u:
					this.MaxMembers = other.MaxMembers;
					arg_362_0 = (num * 1599075166u ^ 1205324973u);
					continue;
				case 23u:
					goto IL_3F2;
				case 24u:
					this.DestroyOnFounderLeave = other.DestroyOnFounderLeave;
					arg_362_0 = (num * 2498238644u ^ 1130504288u);
					continue;
				case 25u:
					this.Program = other.Program;
					arg_362_0 = (num * 338357012u ^ 3151790335u);
					continue;
				case 27u:
					arg_362_0 = ((ChannelState.smethod_1(other.ChannelType) == 0) ? 1163917162u : 1470585508u);
					continue;
				case 28u:
					return;
				}
				break;
			}
			return;
			IL_232:
			arg_362_0 = 2050479472u;
			goto IL_35D;
			IL_3F2:
			arg_362_0 = ((other.MaxMembers != 0u) ? 1558531539u : 762504667u);
			goto IL_35D;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_5C8:
				uint num;
				uint arg_4F0_0 = ((num = input.ReadTag()) == 0u) ? 3148916480u : 3244761465u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F0_0 ^ 3974336230u)) % 47u)
					{
					case 0u:
						this.ChannelType = input.ReadString();
						arg_4F0_0 = 3239519432u;
						continue;
					case 1u:
						arg_4F0_0 = (((num > 26u) ? 3870413635u : 3327549208u) ^ num2 * 2894448183u);
						continue;
					case 2u:
						arg_4F0_0 = ((num > 56u) ? 3090792975u : 3258297746u);
						continue;
					case 3u:
						arg_4F0_0 = ((num > 40u) ? 3683046052u : 2237605987u);
						continue;
					case 4u:
						arg_4F0_0 = (num2 * 537028337u ^ 3095366423u);
						continue;
					case 5u:
						arg_4F0_0 = (num2 * 4221577898u ^ 363082760u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_4F0_0 = 3239519432u;
						continue;
					case 7u:
						arg_4F0_0 = (num2 * 3580462446u ^ 3508121784u);
						continue;
					case 8u:
						arg_4F0_0 = (num2 * 2022511790u ^ 1845908976u);
						continue;
					case 9u:
						arg_4F0_0 = (((num != 26u) ? 1949482591u : 961921563u) ^ num2 * 743446607u);
						continue;
					case 10u:
						arg_4F0_0 = (((num == 96u) ? 3035200906u : 2740195379u) ^ num2 * 1975796381u);
						continue;
					case 11u:
						arg_4F0_0 = 3244761465u;
						continue;
					case 12u:
						arg_4F0_0 = (((num != 8u) ? 2061109408u : 1963517400u) ^ num2 * 3076842329u);
						continue;
					case 13u:
						this.AllowOfflineMembers = input.ReadBool();
						arg_4F0_0 = 2420697094u;
						continue;
					case 14u:
						goto IL_5C8;
					case 15u:
						arg_4F0_0 = (((num != 16u) ? 3476238628u : 4260091737u) ^ num2 * 4116392147u);
						continue;
					case 16u:
						this.MaxMembers = input.ReadUInt32();
						arg_4F0_0 = 2857315625u;
						continue;
					case 17u:
						arg_4F0_0 = (((num == 112u) ? 784377876u : 1809420486u) ^ num2 * 3069668260u);
						continue;
					case 18u:
						this.MinMembers = input.ReadUInt32();
						arg_4F0_0 = 3630711055u;
						continue;
					case 19u:
						this.privacyLevel_ = (ChannelState.Types.PrivacyLevel)input.ReadEnum();
						arg_4F0_0 = 4041829410u;
						continue;
					case 20u:
						this.SubscribeToPresence = input.ReadBool();
						arg_4F0_0 = 3239519432u;
						continue;
					case 21u:
						arg_4F0_0 = (num2 * 3914646396u ^ 1818733474u);
						continue;
					case 22u:
						arg_4F0_0 = (((num == 34u) ? 1152325133u : 2102432038u) ^ num2 * 3062844065u);
						continue;
					case 23u:
						arg_4F0_0 = (num2 * 3615714167u ^ 1157236025u);
						continue;
					case 24u:
						arg_4F0_0 = (((num != 40u) ? 595078775u : 1136098687u) ^ num2 * 2709138911u);
						continue;
					case 25u:
						arg_4F0_0 = ((num != 48u) ? 4280302978u : 3165785425u);
						continue;
					case 26u:
						arg_4F0_0 = ((num > 96u) ? 4082152903u : 2310495601u);
						continue;
					case 27u:
						this.MaxInvitations = input.ReadUInt32();
						arg_4F0_0 = 3239519432u;
						continue;
					case 28u:
						arg_4F0_0 = (((num == 56u) ? 171502817u : 1939545711u) ^ num2 * 4035145839u);
						continue;
					case 29u:
						arg_4F0_0 = (((num != 74u) ? 811739994u : 1266304181u) ^ num2 * 4179486380u);
						continue;
					case 30u:
						arg_4F0_0 = (((num == 82u) ? 744785590u : 719290108u) ^ num2 * 2665727112u);
						continue;
					case 31u:
						arg_4F0_0 = (((num == 66u) ? 1005700630u : 355459434u) ^ num2 * 2751076109u);
						continue;
					case 32u:
						arg_4F0_0 = (num2 * 875272772u ^ 826018626u);
						continue;
					case 34u:
						arg_4F0_0 = (num2 * 1338637227u ^ 3869095924u);
						continue;
					case 35u:
						this.attribute_.AddEntriesFrom(input, ChannelState._repeated_attribute_codec);
						arg_4F0_0 = 3239519432u;
						continue;
					case 36u:
						this.invitation_.AddEntriesFrom(input, ChannelState._repeated_invitation_codec);
						arg_4F0_0 = 3239519432u;
						continue;
					case 37u:
						arg_4F0_0 = (num2 * 529432293u ^ 1185257869u);
						continue;
					case 38u:
						this.Program = input.ReadFixed32();
						arg_4F0_0 = 3239519432u;
						continue;
					case 39u:
						this.DelegateName = input.ReadString();
						arg_4F0_0 = 3239519432u;
						continue;
					case 40u:
						this.Reason = input.ReadUInt32();
						arg_4F0_0 = 2757910894u;
						continue;
					case 41u:
						this.Name = input.ReadString();
						arg_4F0_0 = 3239519432u;
						continue;
					case 42u:
						arg_4F0_0 = (num2 * 4006010161u ^ 3965965393u);
						continue;
					case 43u:
						this.DestroyOnFounderLeave = input.ReadBool();
						arg_4F0_0 = 3239519432u;
						continue;
					case 44u:
						arg_4F0_0 = ((num != 104u) ? 2207980097u : 3926088169u);
						continue;
					case 45u:
						arg_4F0_0 = (((num != 93u) ? 2388472758u : 2526088688u) ^ num2 * 2727925281u);
						continue;
					case 46u:
						arg_4F0_0 = ((num <= 82u) ? 2174009263u : 2669700338u);
						continue;
					}
					return;
				}
			}
		}

		static ChannelState()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 1108157751u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5F_0 ^ 1476560614u)) % 4u)
					{
					case 0u:
						goto IL_7B;
					case 1u:
						ChannelState._repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(26u, Bgs.Protocol.Attribute.Parser);
						arg_5F_0 = (num * 3647256347u ^ 575056611u);
						continue;
					case 2u:
						ChannelState._repeated_invitation_codec = FieldCodec.ForMessage<Invitation>(34u, Bgs.Protocol.Invitation.Parser);
						arg_5F_0 = (num * 1773206092u ^ 4124402533u);
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
