using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class FriendNotification : IMessage<FriendNotification>, IEquatable<FriendNotification>, IDeepCloneable<FriendNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FriendNotification.__c __9 = new FriendNotification.__c();

			internal FriendNotification cctor>b__39_0()
			{
				return new FriendNotification();
			}
		}

		private static readonly MessageParser<FriendNotification> _parser = new MessageParser<FriendNotification>(new Func<FriendNotification>(FriendNotification.__c.__9.<.cctor>b__39_0));

		public const int TargetFieldNumber = 1;

		private Friend target_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int PeerFieldNumber = 4;

		private ProcessId peer_;

		public const int AccountIdFieldNumber = 5;

		private EntityId accountId_;

		public static MessageParser<FriendNotification> Parser
		{
			get
			{
				return FriendNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendNotification.Descriptor;
			}
		}

		public Friend Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
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

		public FriendNotification()
		{
		}

		public FriendNotification(FriendNotification other) : this()
		{
			while (true)
			{
				IL_87:
				int arg_6D_0 = -1189893890;
				while (true)
				{
					switch ((arg_6D_0 ^ -1450849592) % 4)
					{
					case 1:
						this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
						this.Peer = ((other.peer_ != null) ? other.Peer.Clone() : null);
						arg_6D_0 = -1270553572;
						continue;
					case 2:
						this.Target = ((other.target_ != null) ? other.Target.Clone() : null);
						arg_6D_0 = -275890399;
						continue;
					case 3:
						goto IL_87;
					}
					goto Block_4;
				}
			}
			Block_4:
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
		}

		public FriendNotification Clone()
		{
			return new FriendNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FriendNotification);
		}

		public bool Equals(FriendNotification other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ 204720826) % 13)
				{
				case 0:
					arg_D8_0 = ((!FriendNotification.smethod_0(this.Target, other.Target)) ? 1612218500 : 1408068689);
					continue;
				case 1:
					arg_D8_0 = (FriendNotification.smethod_0(this.AccountId, other.AccountId) ? 538682760 : 1264114879);
					continue;
				case 2:
					goto IL_126;
				case 3:
					return false;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					arg_D8_0 = (FriendNotification.smethod_0(this.GameAccountId, other.GameAccountId) ? 1211580391 : 1389786251);
					continue;
				case 8:
					goto IL_47;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_D8_0 = ((!FriendNotification.smethod_0(this.Peer, other.Peer)) ? 50740884 : 371185108);
					continue;
				}
				break;
			}
			return true;
			IL_47:
			arg_D8_0 = 114617611;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other == this) ? 1998739350 : 1068160860);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_10C:
				uint arg_E0_0 = 2210318860u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E0_0 ^ 4120494901u)) % 8u)
					{
					case 0u:
						goto IL_10C;
					case 1u:
						num ^= FriendNotification.smethod_1(this.Target);
						arg_E0_0 = (((this.gameAccountId_ == null) ? 192820963u : 391600503u) ^ num2 * 3495619437u);
						continue;
					case 2u:
						num ^= FriendNotification.smethod_1(this.AccountId);
						arg_E0_0 = (num2 * 1076127531u ^ 1986842142u);
						continue;
					case 3u:
						arg_E0_0 = ((this.peer_ == null) ? 3405830961u : 2492742955u);
						continue;
					case 4u:
						arg_E0_0 = ((this.accountId_ == null) ? 3133689704u : 2674149975u);
						continue;
					case 6u:
						num ^= FriendNotification.smethod_1(this.Peer);
						arg_E0_0 = (num2 * 3168177456u ^ 2544562321u);
						continue;
					case 7u:
						num ^= FriendNotification.smethod_1(this.GameAccountId);
						arg_E0_0 = (num2 * 1216118163u ^ 341765027u);
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
			output.WriteMessage(this.Target);
			while (true)
			{
				IL_136:
				uint arg_105_0 = 1100977615u;
				while (true)
				{
					uint num;
					switch ((num = (arg_105_0 ^ 1803390469u)) % 9u)
					{
					case 0u:
						arg_105_0 = ((this.accountId_ != null) ? 384239093u : 1353665125u);
						continue;
					case 1u:
						output.WriteRawTag(42);
						arg_105_0 = (num * 2782614605u ^ 2281173428u);
						continue;
					case 2u:
						output.WriteRawTag(18);
						output.WriteMessage(this.GameAccountId);
						arg_105_0 = (num * 1227322916u ^ 635336395u);
						continue;
					case 3u:
						output.WriteMessage(this.AccountId);
						arg_105_0 = (num * 2381807740u ^ 129389593u);
						continue;
					case 4u:
						goto IL_136;
					case 5u:
						output.WriteRawTag(34);
						output.WriteMessage(this.Peer);
						arg_105_0 = (num * 3960662804u ^ 799930978u);
						continue;
					case 7u:
						arg_105_0 = ((this.peer_ == null) ? 912104290u : 707245381u);
						continue;
					case 8u:
						arg_105_0 = (((this.gameAccountId_ == null) ? 1428442305u : 380087574u) ^ num * 962436547u);
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
				IL_128:
				uint arg_F7_0 = 1846293657u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F7_0 ^ 429275080u)) % 9u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Peer);
						arg_F7_0 = (num2 * 2500305463u ^ 1171814668u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_F7_0 = (num2 * 2798440434u ^ 2295742804u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
						arg_F7_0 = (num2 * 3703043190u ^ 4287279535u);
						continue;
					case 4u:
						arg_F7_0 = ((this.accountId_ == null) ? 2037364691u : 176341165u);
						continue;
					case 5u:
						arg_F7_0 = ((this.peer_ != null) ? 1439407965u : 1144584975u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_F7_0 = (num2 * 3727442426u ^ 1774815857u);
						continue;
					case 7u:
						goto IL_128;
					case 8u:
						arg_F7_0 = (((this.gameAccountId_ != null) ? 1777235383u : 510915369u) ^ num2 * 3848273265u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FriendNotification other)
		{
			if (other == null)
			{
				goto IL_CF;
			}
			goto IL_27D;
			uint arg_215_0;
			while (true)
			{
				IL_210:
				uint num;
				switch ((num = (arg_215_0 ^ 39854597u)) % 19u)
				{
				case 0u:
					this.Peer.MergeFrom(other.Peer);
					arg_215_0 = 1926237731u;
					continue;
				case 1u:
					this.peer_ = new ProcessId();
					arg_215_0 = (num * 566698422u ^ 1091469466u);
					continue;
				case 2u:
					goto IL_27D;
				case 3u:
					this.accountId_ = new EntityId();
					arg_215_0 = (num * 52561197u ^ 3538500004u);
					continue;
				case 4u:
					this.gameAccountId_ = new EntityId();
					arg_215_0 = (num * 2550592252u ^ 1643501359u);
					continue;
				case 5u:
					return;
				case 6u:
					arg_215_0 = ((other.gameAccountId_ != null) ? 1662794178u : 1373946436u);
					continue;
				case 7u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_215_0 = 1083214556u;
					continue;
				case 8u:
					arg_215_0 = ((other.accountId_ == null) ? 1083214556u : 2002928149u);
					continue;
				case 10u:
					arg_215_0 = (((this.target_ != null) ? 1506996376u : 1980417826u) ^ num * 3842904461u);
					continue;
				case 11u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_215_0 = 1373946436u;
					continue;
				case 12u:
					arg_215_0 = (((this.gameAccountId_ != null) ? 2693600057u : 2373255114u) ^ num * 3770391286u);
					continue;
				case 13u:
					goto IL_CF;
				case 14u:
					arg_215_0 = (((this.peer_ != null) ? 1116783111u : 1920937857u) ^ num * 1630107839u);
					continue;
				case 15u:
					this.Target.MergeFrom(other.Target);
					arg_215_0 = 755464344u;
					continue;
				case 16u:
					arg_215_0 = ((other.peer_ == null) ? 1926237731u : 24495604u);
					continue;
				case 17u:
					this.target_ = new Friend();
					arg_215_0 = (num * 2030359942u ^ 3789269156u);
					continue;
				case 18u:
					arg_215_0 = (((this.accountId_ == null) ? 1372701024u : 1775102053u) ^ num * 3968829036u);
					continue;
				}
				break;
			}
			return;
			IL_CF:
			arg_215_0 = 1376270715u;
			goto IL_210;
			IL_27D:
			arg_215_0 = ((other.target_ != null) ? 34450351u : 755464344u);
			goto IL_210;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2EC:
				uint num;
				uint arg_270_0 = ((num = input.ReadTag()) != 0u) ? 3924786099u : 4285519856u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_270_0 ^ 3678019464u)) % 24u)
					{
					case 1u:
						goto IL_2EC;
					case 2u:
						arg_270_0 = 3924786099u;
						continue;
					case 3u:
						arg_270_0 = (((num != 42u) ? 2804384076u : 2661828391u) ^ num2 * 2297221441u);
						continue;
					case 4u:
						arg_270_0 = (num2 * 343969902u ^ 467206441u);
						continue;
					case 5u:
						this.target_ = new Friend();
						arg_270_0 = (num2 * 3613358298u ^ 2565377846u);
						continue;
					case 6u:
						input.ReadMessage(this.accountId_);
						arg_270_0 = 2778287729u;
						continue;
					case 7u:
						arg_270_0 = ((this.gameAccountId_ != null) ? 4017300059u : 3764778654u);
						continue;
					case 8u:
						this.accountId_ = new EntityId();
						arg_270_0 = (num2 * 1244163945u ^ 682681886u);
						continue;
					case 9u:
						input.ReadMessage(this.peer_);
						arg_270_0 = 2199072712u;
						continue;
					case 10u:
						arg_270_0 = (((num != 10u) ? 3631512103u : 2683872603u) ^ num2 * 896531403u);
						continue;
					case 11u:
						arg_270_0 = ((num <= 18u) ? 2845092714u : 3521839742u);
						continue;
					case 12u:
						arg_270_0 = ((this.accountId_ == null) ? 3638422976u : 4292833686u);
						continue;
					case 13u:
						arg_270_0 = ((this.peer_ == null) ? 3789906730u : 3226155649u);
						continue;
					case 14u:
						arg_270_0 = ((num == 34u) ? 2386014885u : 4222234419u);
						continue;
					case 15u:
						arg_270_0 = (num2 * 4264815057u ^ 2673366720u);
						continue;
					case 16u:
						arg_270_0 = (num2 * 3220574060u ^ 489510257u);
						continue;
					case 17u:
						arg_270_0 = (((num == 18u) ? 3343821244u : 3920118524u) ^ num2 * 2700964523u);
						continue;
					case 18u:
						this.peer_ = new ProcessId();
						arg_270_0 = (num2 * 3227243586u ^ 3458298693u);
						continue;
					case 19u:
						input.ReadMessage(this.gameAccountId_);
						arg_270_0 = 2778287729u;
						continue;
					case 20u:
						input.ReadMessage(this.target_);
						arg_270_0 = 2778287729u;
						continue;
					case 21u:
						arg_270_0 = ((this.target_ != null) ? 3745745332u : 4202867245u);
						continue;
					case 22u:
						this.gameAccountId_ = new EntityId();
						arg_270_0 = (num2 * 4254069233u ^ 3463512557u);
						continue;
					case 23u:
						input.SkipLastField();
						arg_270_0 = 2898343996u;
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
