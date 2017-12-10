using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscribeResponse.__c __9 = new SubscribeResponse.__c();

			internal SubscribeResponse cctor>b__54_0()
			{
				return new SubscribeResponse();
			}
		}

		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(new Func<SubscribeResponse>(SubscribeResponse.__c.__9.<.cctor>b__54_0));

		public const int MaxFriendsFieldNumber = 1;

		private uint maxFriends_;

		public const int MaxReceivedInvitationsFieldNumber = 2;

		private uint maxReceivedInvitations_;

		public const int MaxSentInvitationsFieldNumber = 3;

		private uint maxSentInvitations_;

		public const int RoleFieldNumber = 4;

		private static readonly FieldCodec<Role> _repeated_role_codec;

		private readonly RepeatedField<Role> role_ = new RepeatedField<Role>();

		public const int FriendsFieldNumber = 5;

		private static readonly FieldCodec<Friend> _repeated_friends_codec;

		private readonly RepeatedField<Friend> friends_ = new RepeatedField<Friend>();

		public const int SentInvitationsFieldNumber = 6;

		private static readonly FieldCodec<Invitation> _repeated_sentInvitations_codec;

		private readonly RepeatedField<Invitation> sentInvitations_ = new RepeatedField<Invitation>();

		public const int ReceivedInvitationsFieldNumber = 7;

		private static readonly FieldCodec<Invitation> _repeated_receivedInvitations_codec;

		private readonly RepeatedField<Invitation> receivedInvitations_ = new RepeatedField<Invitation>();

		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		public uint MaxFriends
		{
			get
			{
				return this.maxFriends_;
			}
			set
			{
				this.maxFriends_ = value;
			}
		}

		public uint MaxReceivedInvitations
		{
			get
			{
				return this.maxReceivedInvitations_;
			}
			set
			{
				this.maxReceivedInvitations_ = value;
			}
		}

		public uint MaxSentInvitations
		{
			get
			{
				return this.maxSentInvitations_;
			}
			set
			{
				this.maxSentInvitations_ = value;
			}
		}

		public RepeatedField<Role> Role
		{
			get
			{
				return this.role_;
			}
		}

		public RepeatedField<Friend> Friends
		{
			get
			{
				return this.friends_;
			}
		}

		public RepeatedField<Invitation> SentInvitations
		{
			get
			{
				return this.sentInvitations_;
			}
		}

		public RepeatedField<Invitation> ReceivedInvitations
		{
			get
			{
				return this.receivedInvitations_;
			}
		}

		public SubscribeResponse()
		{
		}

		public SubscribeResponse(SubscribeResponse other) : this()
		{
			while (true)
			{
				IL_FF:
				uint arg_D3_0 = 3584512415u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D3_0 ^ 2282524930u)) % 8u)
					{
					case 1u:
						this.role_ = other.role_.Clone();
						arg_D3_0 = (num * 132247182u ^ 1245157122u);
						continue;
					case 2u:
						this.receivedInvitations_ = other.receivedInvitations_.Clone();
						arg_D3_0 = (num * 2056307136u ^ 2641458386u);
						continue;
					case 3u:
						this.sentInvitations_ = other.sentInvitations_.Clone();
						arg_D3_0 = (num * 3260475558u ^ 444535890u);
						continue;
					case 4u:
						goto IL_FF;
					case 5u:
						this.maxFriends_ = other.maxFriends_;
						arg_D3_0 = (num * 758522041u ^ 2360585560u);
						continue;
					case 6u:
						this.friends_ = other.friends_.Clone();
						arg_D3_0 = (num * 613721820u ^ 3293575905u);
						continue;
					case 7u:
						this.maxReceivedInvitations_ = other.maxReceivedInvitations_;
						this.maxSentInvitations_ = other.maxSentInvitations_;
						arg_D3_0 = (num * 2830848764u ^ 536033423u);
						continue;
					}
					return;
				}
			}
		}

		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		public bool Equals(SubscribeResponse other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_1BC;
			int arg_156_0;
			while (true)
			{
				IL_151:
				switch ((arg_156_0 ^ -1240186688) % 19)
				{
				case 0:
					arg_156_0 = ((!this.sentInvitations_.Equals(other.sentInvitations_)) ? -661707746 : -1085958667);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_156_0 = ((!this.friends_.Equals(other.friends_)) ? -102362351 : -1837563698);
					continue;
				case 4:
					return false;
				case 5:
					arg_156_0 = (this.role_.Equals(other.role_) ? -163297781 : -112412912);
					continue;
				case 6:
					arg_156_0 = (this.receivedInvitations_.Equals(other.receivedInvitations_) ? -2068305712 : -1257212931);
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
					return true;
				case 12:
					arg_156_0 = ((this.MaxReceivedInvitations == other.MaxReceivedInvitations) ? -1513696353 : -2137119602);
					continue;
				case 13:
					return false;
				case 14:
					goto IL_6C;
				case 16:
					goto IL_1BC;
				case 17:
					arg_156_0 = ((this.MaxSentInvitations == other.MaxSentInvitations) ? -1469556255 : -354072313);
					continue;
				case 18:
					arg_156_0 = ((this.MaxFriends == other.MaxFriends) ? -1771171313 : -1466906389);
					continue;
				}
				break;
			}
			return true;
			IL_6C:
			arg_156_0 = -1128236096;
			goto IL_151;
			IL_1BC:
			arg_156_0 = ((other == this) ? -765337666 : -1422271461);
			goto IL_151;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_145:
				uint arg_110_0 = 770297391u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_110_0 ^ 681567681u)) % 10u)
					{
					case 0u:
						goto IL_145;
					case 1u:
						num ^= this.role_.GetHashCode();
						arg_110_0 = 1967323968u;
						continue;
					case 2u:
						arg_110_0 = ((this.MaxSentInvitations == 0u) ? 1479099886u : 1638730612u);
						continue;
					case 3u:
						num ^= this.friends_.GetHashCode();
						arg_110_0 = (num2 * 2491802148u ^ 2752874861u);
						continue;
					case 4u:
						arg_110_0 = (((this.MaxFriends == 0u) ? 4226170423u : 3486281312u) ^ num2 * 3677288335u);
						continue;
					case 5u:
						num ^= this.MaxReceivedInvitations.GetHashCode();
						arg_110_0 = (num2 * 2731327931u ^ 1482270952u);
						continue;
					case 6u:
						arg_110_0 = ((this.MaxReceivedInvitations == 0u) ? 1729546025u : 697871218u);
						continue;
					case 7u:
						num ^= this.MaxSentInvitations.GetHashCode();
						arg_110_0 = (num2 * 2106976479u ^ 1680060997u);
						continue;
					case 9u:
						num ^= this.MaxFriends.GetHashCode();
						arg_110_0 = (num2 * 3381588695u ^ 928648816u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			num ^= this.sentInvitations_.GetHashCode();
			return num ^ this.receivedInvitations_.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.MaxFriends != 0u)
			{
				goto IL_D3;
			}
			goto IL_16E;
			uint arg_126_0;
			while (true)
			{
				IL_121:
				uint num;
				switch ((num = (arg_126_0 ^ 2371016073u)) % 11u)
				{
				case 0u:
					goto IL_16E;
				case 1u:
					this.friends_.WriteTo(output, SubscribeResponse._repeated_friends_codec);
					this.sentInvitations_.WriteTo(output, SubscribeResponse._repeated_sentInvitations_codec);
					arg_126_0 = (num * 3309869807u ^ 3477276356u);
					continue;
				case 2u:
					this.role_.WriteTo(output, SubscribeResponse._repeated_role_codec);
					arg_126_0 = 3729266820u;
					continue;
				case 3u:
					goto IL_D3;
				case 5u:
					output.WriteRawTag(8);
					arg_126_0 = (num * 633348929u ^ 521134062u);
					continue;
				case 6u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.MaxSentInvitations);
					arg_126_0 = (num * 869942304u ^ 356946308u);
					continue;
				case 7u:
					arg_126_0 = ((this.MaxSentInvitations != 0u) ? 3968607542u : 2519745124u);
					continue;
				case 8u:
					output.WriteUInt32(this.MaxReceivedInvitations);
					arg_126_0 = (num * 4082082970u ^ 1864406721u);
					continue;
				case 9u:
					output.WriteRawTag(16);
					arg_126_0 = (num * 2172380600u ^ 1994033571u);
					continue;
				case 10u:
					output.WriteUInt32(this.MaxFriends);
					arg_126_0 = (num * 2535414251u ^ 2559435476u);
					continue;
				}
				break;
			}
			this.receivedInvitations_.WriteTo(output, SubscribeResponse._repeated_receivedInvitations_codec);
			return;
			IL_D3:
			arg_126_0 = 4181202368u;
			goto IL_121;
			IL_16E:
			arg_126_0 = ((this.MaxReceivedInvitations == 0u) ? 4151180997u : 2313563893u);
			goto IL_121;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxFriends != 0u)
			{
				goto IL_5E;
			}
			goto IL_155;
			uint arg_111_0;
			while (true)
			{
				IL_10C:
				uint num2;
				switch ((num2 = (arg_111_0 ^ 2153784225u)) % 10u)
				{
				case 0u:
					arg_111_0 = ((this.MaxSentInvitations == 0u) ? 3903773293u : 3804954760u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxFriends);
					arg_111_0 = (num2 * 1273035955u ^ 1427474376u);
					continue;
				case 2u:
					num += this.sentInvitations_.CalculateSize(SubscribeResponse._repeated_sentInvitations_codec);
					arg_111_0 = (num2 * 488677549u ^ 1011124788u);
					continue;
				case 3u:
					num += this.friends_.CalculateSize(SubscribeResponse._repeated_friends_codec);
					arg_111_0 = (num2 * 2919195349u ^ 1751619118u);
					continue;
				case 4u:
					goto IL_155;
				case 5u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxSentInvitations);
					arg_111_0 = (num2 * 3920001858u ^ 792140287u);
					continue;
				case 6u:
					goto IL_5E;
				case 7u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxReceivedInvitations);
					arg_111_0 = (num2 * 1902258947u ^ 1125207528u);
					continue;
				case 8u:
					num += this.role_.CalculateSize(SubscribeResponse._repeated_role_codec);
					arg_111_0 = 3683524076u;
					continue;
				}
				break;
			}
			return num + this.receivedInvitations_.CalculateSize(SubscribeResponse._repeated_receivedInvitations_codec);
			IL_5E:
			arg_111_0 = 2989020200u;
			goto IL_10C;
			IL_155:
			arg_111_0 = ((this.MaxReceivedInvitations != 0u) ? 3686759066u : 2283911513u);
			goto IL_10C;
		}

		public void MergeFrom(SubscribeResponse other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_152;
			uint arg_10A_0;
			while (true)
			{
				IL_105:
				uint num;
				switch ((num = (arg_10A_0 ^ 1599954736u)) % 11u)
				{
				case 1u:
					arg_10A_0 = ((other.MaxReceivedInvitations == 0u) ? 1235285163u : 1686288112u);
					continue;
				case 2u:
					this.MaxSentInvitations = other.MaxSentInvitations;
					arg_10A_0 = (num * 674973541u ^ 1358917585u);
					continue;
				case 3u:
					this.MaxReceivedInvitations = other.MaxReceivedInvitations;
					arg_10A_0 = (num * 3791680912u ^ 3395864747u);
					continue;
				case 4u:
					this.friends_.Add(other.friends_);
					this.sentInvitations_.Add(other.sentInvitations_);
					arg_10A_0 = (num * 263194770u ^ 2004665933u);
					continue;
				case 5u:
					this.role_.Add(other.role_);
					arg_10A_0 = 462658864u;
					continue;
				case 6u:
					this.MaxFriends = other.MaxFriends;
					arg_10A_0 = (num * 3568081422u ^ 3505254487u);
					continue;
				case 7u:
					goto IL_3C;
				case 8u:
					arg_10A_0 = ((other.MaxSentInvitations != 0u) ? 1302248492u : 575025629u);
					continue;
				case 9u:
					return;
				case 10u:
					goto IL_152;
				}
				break;
			}
			this.receivedInvitations_.Add(other.receivedInvitations_);
			return;
			IL_3C:
			arg_10A_0 = 174480859u;
			goto IL_105;
			IL_152:
			arg_10A_0 = ((other.MaxFriends != 0u) ? 1020068084u : 601674991u);
			goto IL_105;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_32A:
				uint num;
				uint arg_2A2_0 = ((num = input.ReadTag()) == 0u) ? 3933796239u : 3662104285u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2A2_0 ^ 2690910311u)) % 27u)
					{
					case 0u:
						this.MaxSentInvitations = input.ReadUInt32();
						arg_2A2_0 = 3665186450u;
						continue;
					case 2u:
						this.friends_.AddEntriesFrom(input, SubscribeResponse._repeated_friends_codec);
						arg_2A2_0 = 4198914313u;
						continue;
					case 3u:
						this.MaxFriends = input.ReadUInt32();
						arg_2A2_0 = 3418466325u;
						continue;
					case 4u:
						arg_2A2_0 = (num2 * 3358338042u ^ 3462516585u);
						continue;
					case 5u:
						arg_2A2_0 = ((num <= 42u) ? 2289982910u : 3035844902u);
						continue;
					case 6u:
						goto IL_32A;
					case 7u:
						arg_2A2_0 = (num2 * 4204469743u ^ 2950527125u);
						continue;
					case 8u:
						this.receivedInvitations_.AddEntriesFrom(input, SubscribeResponse._repeated_receivedInvitations_codec);
						arg_2A2_0 = 4198914313u;
						continue;
					case 9u:
						this.role_.AddEntriesFrom(input, SubscribeResponse._repeated_role_codec);
						arg_2A2_0 = 2657868867u;
						continue;
					case 10u:
						arg_2A2_0 = (num2 * 605748011u ^ 3038570180u);
						continue;
					case 11u:
						arg_2A2_0 = (((num == 24u) ? 2577919741u : 4231834133u) ^ num2 * 1809929950u);
						continue;
					case 12u:
						arg_2A2_0 = (((num == 16u) ? 2153381980u : 4092976481u) ^ num2 * 2631475800u);
						continue;
					case 13u:
						this.MaxReceivedInvitations = input.ReadUInt32();
						arg_2A2_0 = 4198914313u;
						continue;
					case 14u:
						arg_2A2_0 = (((num == 34u) ? 3481065387u : 2541484252u) ^ num2 * 2430137821u);
						continue;
					case 15u:
						arg_2A2_0 = (num2 * 152635439u ^ 2185305270u);
						continue;
					case 16u:
						input.SkipLastField();
						arg_2A2_0 = 3992497942u;
						continue;
					case 17u:
						arg_2A2_0 = (num2 * 3471503868u ^ 2600085285u);
						continue;
					case 18u:
						arg_2A2_0 = (num2 * 1957232401u ^ 3924257947u);
						continue;
					case 19u:
						arg_2A2_0 = ((num > 24u) ? 3275295433u : 4084618772u);
						continue;
					case 20u:
						arg_2A2_0 = (((num == 58u) ? 863162346u : 1290016214u) ^ num2 * 2720830260u);
						continue;
					case 21u:
						arg_2A2_0 = (num2 * 2004459726u ^ 1574197880u);
						continue;
					case 22u:
						arg_2A2_0 = ((num == 50u) ? 3852916711u : 3923369215u);
						continue;
					case 23u:
						arg_2A2_0 = 3662104285u;
						continue;
					case 24u:
						arg_2A2_0 = (((num == 42u) ? 2289987071u : 2173855296u) ^ num2 * 653794789u);
						continue;
					case 25u:
						arg_2A2_0 = (((num == 8u) ? 2866374861u : 3613268148u) ^ num2 * 3651973384u);
						continue;
					case 26u:
						this.sentInvitations_.AddEntriesFrom(input, SubscribeResponse._repeated_sentInvitations_codec);
						arg_2A2_0 = 3119009431u;
						continue;
					}
					return;
				}
			}
		}

		static SubscribeResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_8C:
				uint arg_70_0 = 1444800572u;
				while (true)
				{
					uint num;
					switch ((num = (arg_70_0 ^ 318744889u)) % 4u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
						SubscribeResponse._repeated_role_codec = FieldCodec.ForMessage<Role>(34u, Bgs.Protocol.Role.Parser);
						SubscribeResponse._repeated_friends_codec = FieldCodec.ForMessage<Friend>(42u, Friend.Parser);
						arg_70_0 = (num * 541726256u ^ 3247950670u);
						continue;
					case 3u:
						SubscribeResponse._repeated_sentInvitations_codec = FieldCodec.ForMessage<Invitation>(50u, Invitation.Parser);
						arg_70_0 = (num * 3868157226u ^ 1373032533u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			SubscribeResponse._repeated_receivedInvitations_codec = FieldCodec.ForMessage<Invitation>(58u, Invitation.Parser);
		}
	}
}
