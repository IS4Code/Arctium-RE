using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class InvitationNotification : IMessage<InvitationNotification>, IEquatable<InvitationNotification>, IDeepCloneable<InvitationNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly InvitationNotification.__c __9 = new InvitationNotification.__c();

			internal InvitationNotification cctor>b__44_0()
			{
				return new InvitationNotification();
			}
		}

		private static readonly MessageParser<InvitationNotification> _parser = new MessageParser<InvitationNotification>(new Func<InvitationNotification>(InvitationNotification.__c.__9.<.cctor>b__44_0));

		public const int InvitationFieldNumber = 1;

		private Invitation invitation_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int ReasonFieldNumber = 3;

		private uint reason_;

		public const int PeerFieldNumber = 4;

		private ProcessId peer_;

		public const int AccountIdFieldNumber = 5;

		private EntityId accountId_;

		public static MessageParser<InvitationNotification> Parser
		{
			get
			{
				return InvitationNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationNotification.Descriptor;
			}
		}

		public Invitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
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

		public ProcessId Peer
		{
			get
			{
				return this.peer_;
			}
			set
			{
				this.peer_ = value;
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

		public InvitationNotification()
		{
		}

		public InvitationNotification(InvitationNotification other) : this()
		{
			while (true)
			{
				IL_BD:
				int arg_9F_0 = -2022783255;
				while (true)
				{
					switch ((arg_9F_0 ^ -1008826508) % 5)
					{
					case 0:
						goto IL_BD;
					case 1:
						this.Invitation = ((other.invitation_ != null) ? other.Invitation.Clone() : null);
						arg_9F_0 = -954655531;
						continue;
					case 3:
						this.Peer = ((other.peer_ != null) ? other.Peer.Clone() : null);
						this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
						arg_9F_0 = -196738719;
						continue;
					case 4:
						this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
						this.reason_ = other.reason_;
						arg_9F_0 = -1177393705;
						continue;
					}
					return;
				}
			}
		}

		public InvitationNotification Clone()
		{
			return new InvitationNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationNotification);
		}

		public bool Equals(InvitationNotification other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_155;
			int arg_FF_0;
			while (true)
			{
				IL_FA:
				switch ((arg_FF_0 ^ 2138789292) % 15)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_FF_0 = (InvitationNotification.smethod_0(this.AccountId, other.AccountId) ? 669262489 : 319369256);
					continue;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_FF_0 = ((this.Reason == other.Reason) ? 1472161515 : 1902891812);
					continue;
				case 8:
					return false;
				case 9:
					arg_FF_0 = (InvitationNotification.smethod_0(this.GameAccountId, other.GameAccountId) ? 1001282734 : 1301010114);
					continue;
				case 10:
					arg_FF_0 = ((!InvitationNotification.smethod_0(this.Invitation, other.Invitation)) ? 371369642 : 911220909);
					continue;
				case 11:
					goto IL_47;
				case 12:
					goto IL_155;
				case 13:
					arg_FF_0 = (InvitationNotification.smethod_0(this.Peer, other.Peer) ? 2087937386 : 402830111);
					continue;
				}
				break;
			}
			return true;
			IL_47:
			arg_FF_0 = 560583704;
			goto IL_FA;
			IL_155:
			arg_FF_0 = ((other == this) ? 798626530 : 1611631638);
			goto IL_FA;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_15C:
				uint arg_127_0 = 3494544792u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_127_0 ^ 2923051544u)) % 10u)
					{
					case 0u:
						num ^= this.Reason.GetHashCode();
						arg_127_0 = (num2 * 985085103u ^ 3249862959u);
						continue;
					case 1u:
						num ^= InvitationNotification.smethod_1(this.GameAccountId);
						arg_127_0 = (num2 * 2103293858u ^ 2670807273u);
						continue;
					case 2u:
						num ^= InvitationNotification.smethod_1(this.Invitation);
						arg_127_0 = (((this.gameAccountId_ == null) ? 569066915u : 548516237u) ^ num2 * 1166781972u);
						continue;
					case 3u:
						goto IL_15C;
					case 5u:
						num ^= this.AccountId.GetHashCode();
						arg_127_0 = (num2 * 4038985833u ^ 2670794431u);
						continue;
					case 6u:
						num ^= this.Peer.GetHashCode();
						arg_127_0 = (num2 * 2168461839u ^ 1957097046u);
						continue;
					case 7u:
						arg_127_0 = ((this.peer_ != null) ? 2252729160u : 2316930534u);
						continue;
					case 8u:
						arg_127_0 = ((this.accountId_ != null) ? 4020072725u : 2494375658u);
						continue;
					case 9u:
						arg_127_0 = ((this.Reason == 0u) ? 2706342715u : 2153868852u);
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
			while (true)
			{
				IL_19E:
				uint arg_161_0 = 1321467718u;
				while (true)
				{
					uint num;
					switch ((num = (arg_161_0 ^ 1675359281u)) % 12u)
					{
					case 0u:
						goto IL_19E;
					case 2u:
						output.WriteRawTag(34);
						arg_161_0 = (num * 1439255143u ^ 3996432378u);
						continue;
					case 3u:
						output.WriteRawTag(18);
						output.WriteMessage(this.GameAccountId);
						arg_161_0 = (num * 714336052u ^ 733678295u);
						continue;
					case 4u:
						output.WriteMessage(this.AccountId);
						arg_161_0 = (num * 1263873261u ^ 1690114792u);
						continue;
					case 5u:
						output.WriteMessage(this.Peer);
						arg_161_0 = (num * 4075807369u ^ 2465694557u);
						continue;
					case 6u:
						arg_161_0 = ((this.Reason == 0u) ? 1294874319u : 892821394u);
						continue;
					case 7u:
						output.WriteMessage(this.Invitation);
						arg_161_0 = (((this.gameAccountId_ != null) ? 2965011375u : 3000674182u) ^ num * 1638823963u);
						continue;
					case 8u:
						output.WriteRawTag(42);
						arg_161_0 = (num * 876240156u ^ 2108752345u);
						continue;
					case 9u:
						arg_161_0 = ((this.accountId_ == null) ? 2095501536u : 1045258081u);
						continue;
					case 10u:
						arg_161_0 = ((this.peer_ == null) ? 881164740u : 283735207u);
						continue;
					case 11u:
						output.WriteRawTag(24);
						output.WriteUInt32(this.Reason);
						arg_161_0 = (num * 579481820u ^ 1918772955u);
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
				IL_179:
				uint arg_140_0 = 3154992189u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_140_0 ^ 4080235380u)) % 11u)
					{
					case 0u:
						arg_140_0 = ((this.Reason == 0u) ? 2905523037u : 4242491719u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
						arg_140_0 = (num2 * 4115079402u ^ 3210076364u);
						continue;
					case 2u:
						arg_140_0 = ((this.peer_ != null) ? 2421763726u : 2809565559u);
						continue;
					case 3u:
						arg_140_0 = (((this.gameAccountId_ != null) ? 1398622781u : 984565836u) ^ num2 * 458163355u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
						arg_140_0 = (num2 * 1047311089u ^ 2289075038u);
						continue;
					case 6u:
						arg_140_0 = ((this.accountId_ == null) ? 2527575516u : 2223002872u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_140_0 = (num2 * 451949552u ^ 2659298922u);
						continue;
					case 8u:
						goto IL_179;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Peer);
						arg_140_0 = (num2 * 3287137147u ^ 1111774313u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_140_0 = (num2 * 3955190714u ^ 1233224292u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(InvitationNotification other)
		{
			if (other == null)
			{
				goto IL_12B;
			}
			goto IL_2C7;
			uint arg_257_0;
			while (true)
			{
				IL_252:
				uint num;
				switch ((num = (arg_257_0 ^ 1696361140u)) % 21u)
				{
				case 0u:
					arg_257_0 = ((other.accountId_ != null) ? 1361144732u : 584462334u);
					continue;
				case 1u:
					arg_257_0 = (((this.accountId_ != null) ? 2378879741u : 4044540468u) ^ num * 2266102389u);
					continue;
				case 2u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_257_0 = 584462334u;
					continue;
				case 3u:
					this.invitation_ = new Invitation();
					arg_257_0 = (num * 3083430569u ^ 3626138167u);
					continue;
				case 4u:
					arg_257_0 = (((this.gameAccountId_ == null) ? 661652882u : 1120257346u) ^ num * 77518816u);
					continue;
				case 5u:
					arg_257_0 = ((other.peer_ != null) ? 340228627u : 1789908532u);
					continue;
				case 6u:
					goto IL_2C7;
				case 7u:
					this.Reason = other.Reason;
					arg_257_0 = (num * 1487654053u ^ 3243294394u);
					continue;
				case 8u:
					this.Invitation.MergeFrom(other.Invitation);
					arg_257_0 = 1290369090u;
					continue;
				case 9u:
					this.accountId_ = new EntityId();
					arg_257_0 = (num * 3604548419u ^ 1552446701u);
					continue;
				case 10u:
					goto IL_12B;
				case 11u:
					arg_257_0 = (((this.invitation_ == null) ? 3343503236u : 3729438927u) ^ num * 655709429u);
					continue;
				case 12u:
					this.Peer.MergeFrom(other.Peer);
					arg_257_0 = 1789908532u;
					continue;
				case 13u:
					this.gameAccountId_ = new EntityId();
					arg_257_0 = (num * 2889384813u ^ 3038332268u);
					continue;
				case 14u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_257_0 = 1506026240u;
					continue;
				case 15u:
					arg_257_0 = (((this.peer_ != null) ? 837547153u : 1719964256u) ^ num * 2627266138u);
					continue;
				case 16u:
					arg_257_0 = ((other.gameAccountId_ != null) ? 1761274406u : 1506026240u);
					continue;
				case 17u:
					this.peer_ = new ProcessId();
					arg_257_0 = (num * 2065862305u ^ 2380735877u);
					continue;
				case 18u:
					return;
				case 19u:
					arg_257_0 = ((other.Reason == 0u) ? 1831023527u : 1692145581u);
					continue;
				}
				break;
			}
			return;
			IL_12B:
			arg_257_0 = 592151719u;
			goto IL_252;
			IL_2C7:
			arg_257_0 = ((other.invitation_ != null) ? 1355132981u : 1290369090u);
			goto IL_252;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_35F:
				uint num;
				uint arg_2D3_0 = ((num = input.ReadTag()) != 0u) ? 2442028089u : 3092248823u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2D3_0 ^ 2775562176u)) % 28u)
					{
					case 0u:
						input.ReadMessage(this.gameAccountId_);
						arg_2D3_0 = 3706483926u;
						continue;
					case 1u:
						input.ReadMessage(this.peer_);
						arg_2D3_0 = 2571184176u;
						continue;
					case 2u:
						arg_2D3_0 = (num2 * 2931787538u ^ 1716418604u);
						continue;
					case 3u:
						arg_2D3_0 = (((num == 10u) ? 2572187635u : 3617332450u) ^ num2 * 1732622618u);
						continue;
					case 4u:
						this.Reason = input.ReadUInt32();
						arg_2D3_0 = 4005570976u;
						continue;
					case 5u:
						arg_2D3_0 = ((num != 24u) ? 3798624106u : 4144860056u);
						continue;
					case 6u:
						arg_2D3_0 = (num2 * 1640656770u ^ 1177032484u);
						continue;
					case 7u:
						arg_2D3_0 = ((this.gameAccountId_ == null) ? 3723090730u : 2240825188u);
						continue;
					case 8u:
						arg_2D3_0 = (((num != 18u) ? 4199111288u : 2191236659u) ^ num2 * 1634786543u);
						continue;
					case 9u:
						arg_2D3_0 = ((this.accountId_ == null) ? 4220320221u : 3635362530u);
						continue;
					case 10u:
						this.peer_ = new ProcessId();
						arg_2D3_0 = (num2 * 1756695434u ^ 3603196721u);
						continue;
					case 11u:
						arg_2D3_0 = ((this.peer_ == null) ? 4244662330u : 2960396789u);
						continue;
					case 12u:
						goto IL_35F;
					case 13u:
						arg_2D3_0 = ((num > 18u) ? 3031156745u : 4017112487u);
						continue;
					case 14u:
						arg_2D3_0 = (num2 * 3522167074u ^ 3835193924u);
						continue;
					case 15u:
						this.invitation_ = new Invitation();
						arg_2D3_0 = (num2 * 165037243u ^ 3215227446u);
						continue;
					case 16u:
						arg_2D3_0 = (num2 * 4236077472u ^ 973732149u);
						continue;
					case 17u:
						arg_2D3_0 = ((this.invitation_ != null) ? 3566325351u : 3731281827u);
						continue;
					case 18u:
						this.gameAccountId_ = new EntityId();
						arg_2D3_0 = (num2 * 1463070194u ^ 3919925328u);
						continue;
					case 19u:
						input.ReadMessage(this.invitation_);
						arg_2D3_0 = 3229207570u;
						continue;
					case 20u:
						arg_2D3_0 = (num2 * 2392044101u ^ 1951781392u);
						continue;
					case 21u:
						this.accountId_ = new EntityId();
						arg_2D3_0 = (num2 * 197224881u ^ 564190703u);
						continue;
					case 22u:
						input.ReadMessage(this.accountId_);
						arg_2D3_0 = 4005570976u;
						continue;
					case 24u:
						arg_2D3_0 = (((num != 42u) ? 1158460549u : 937552609u) ^ num2 * 1650451228u);
						continue;
					case 25u:
						input.SkipLastField();
						arg_2D3_0 = 4256180226u;
						continue;
					case 26u:
						arg_2D3_0 = (((num == 34u) ? 712327123u : 472679456u) ^ num2 * 3546440306u);
						continue;
					case 27u:
						arg_2D3_0 = 2442028089u;
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
