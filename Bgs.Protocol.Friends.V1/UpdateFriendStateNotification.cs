using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class UpdateFriendStateNotification : IMessage<UpdateFriendStateNotification>, IEquatable<UpdateFriendStateNotification>, IDeepCloneable<UpdateFriendStateNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateFriendStateNotification.__c __9 = new UpdateFriendStateNotification.__c();

			internal UpdateFriendStateNotification cctor>b__39_0()
			{
				return new UpdateFriendStateNotification();
			}
		}

		private static readonly MessageParser<UpdateFriendStateNotification> _parser = new MessageParser<UpdateFriendStateNotification>(new Func<UpdateFriendStateNotification>(UpdateFriendStateNotification.__c.__9.<.cctor>b__39_0));

		public const int ChangedFriendFieldNumber = 1;

		private Friend changedFriend_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int PeerFieldNumber = 4;

		private ProcessId peer_;

		public const int AccountIdFieldNumber = 5;

		private EntityId accountId_;

		public static MessageParser<UpdateFriendStateNotification> Parser
		{
			get
			{
				return UpdateFriendStateNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFriendStateNotification.Descriptor;
			}
		}

		public Friend ChangedFriend
		{
			get
			{
				return this.changedFriend_;
			}
			set
			{
				this.changedFriend_ = value;
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

		public UpdateFriendStateNotification()
		{
		}

		public UpdateFriendStateNotification(UpdateFriendStateNotification other) : this()
		{
			while (true)
			{
				IL_6B:
				int arg_51_0 = -139268008;
				while (true)
				{
					switch ((arg_51_0 ^ -1451164650) % 4)
					{
					case 1:
						this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
						arg_51_0 = -1399925870;
						continue;
					case 2:
						this.ChangedFriend = ((other.changedFriend_ != null) ? other.ChangedFriend.Clone() : null);
						arg_51_0 = -753740985;
						continue;
					case 3:
						goto IL_6B;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.Peer = ((other.peer_ != null) ? other.Peer.Clone() : null);
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
		}

		public UpdateFriendStateNotification Clone()
		{
			return new UpdateFriendStateNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFriendStateNotification);
		}

		public bool Equals(UpdateFriendStateNotification other)
		{
			if (other == null)
			{
				goto IL_73;
			}
			goto IL_123;
			int arg_D5_0;
			while (true)
			{
				IL_D0:
				switch ((arg_D5_0 ^ -1085619997) % 13)
				{
				case 0:
					arg_D5_0 = (UpdateFriendStateNotification.smethod_0(this.GameAccountId, other.GameAccountId) ? -791431416 : -781464941);
					continue;
				case 1:
					arg_D5_0 = ((!UpdateFriendStateNotification.smethod_0(this.ChangedFriend, other.ChangedFriend)) ? -1807932563 : -139535307);
					continue;
				case 2:
					goto IL_73;
				case 3:
					arg_D5_0 = ((!UpdateFriendStateNotification.smethod_0(this.AccountId, other.AccountId)) ? -1188941452 : -924918663);
					continue;
				case 4:
					arg_D5_0 = ((!UpdateFriendStateNotification.smethod_0(this.Peer, other.Peer)) ? -1011223301 : -1677160622);
					continue;
				case 5:
					return true;
				case 6:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_123;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					return false;
				}
				break;
			}
			return true;
			IL_73:
			arg_D5_0 = -237383512;
			goto IL_D0;
			IL_123:
			arg_D5_0 = ((other != this) ? -728256779 : -947963814);
			goto IL_D0;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ UpdateFriendStateNotification.smethod_1(this.ChangedFriend);
			while (true)
			{
				IL_109:
				uint arg_DD_0 = 1284239996u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_DD_0 ^ 298754314u)) % 8u)
					{
					case 1u:
						arg_DD_0 = ((this.peer_ != null) ? 850595361u : 1058281216u);
						continue;
					case 2u:
						arg_DD_0 = ((this.accountId_ != null) ? 868535062u : 1817318986u);
						continue;
					case 3u:
						num ^= UpdateFriendStateNotification.smethod_1(this.Peer);
						arg_DD_0 = (num2 * 2532963146u ^ 494494830u);
						continue;
					case 4u:
						num ^= UpdateFriendStateNotification.smethod_1(this.AccountId);
						arg_DD_0 = (num2 * 576312118u ^ 858874786u);
						continue;
					case 5u:
						num ^= UpdateFriendStateNotification.smethod_1(this.GameAccountId);
						arg_DD_0 = (num2 * 1254327224u ^ 2221699827u);
						continue;
					case 6u:
						arg_DD_0 = (((this.gameAccountId_ != null) ? 3742435513u : 2263311293u) ^ num2 * 1459025425u);
						continue;
					case 7u:
						goto IL_109;
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
			output.WriteMessage(this.ChangedFriend);
			if (this.gameAccountId_ != null)
			{
				goto IL_89;
			}
			goto IL_112;
			uint arg_D7_0;
			while (true)
			{
				IL_D2:
				uint num;
				switch ((num = (arg_D7_0 ^ 3681995227u)) % 8u)
				{
				case 0u:
					arg_D7_0 = ((this.accountId_ != null) ? 3172986590u : 3598630061u);
					continue;
				case 1u:
					output.WriteRawTag(18);
					output.WriteMessage(this.GameAccountId);
					arg_D7_0 = (num * 1880031972u ^ 3455557299u);
					continue;
				case 2u:
					goto IL_89;
				case 3u:
					output.WriteMessage(this.Peer);
					arg_D7_0 = (num * 3276955200u ^ 2123957611u);
					continue;
				case 4u:
					goto IL_112;
				case 5u:
					output.WriteRawTag(42);
					output.WriteMessage(this.AccountId);
					arg_D7_0 = (num * 2859461471u ^ 326937974u);
					continue;
				case 7u:
					output.WriteRawTag(34);
					arg_D7_0 = (num * 1190405781u ^ 2227197019u);
					continue;
				}
				break;
			}
			return;
			IL_89:
			arg_D7_0 = 3202019682u;
			goto IL_D2;
			IL_112:
			arg_D7_0 = ((this.peer_ != null) ? 2195160172u : 3907657643u);
			goto IL_D2;
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.ChangedFriend));
			if (this.gameAccountId_ != null)
			{
				goto IL_4E;
			}
			goto IL_EE;
			uint arg_B7_0;
			while (true)
			{
				IL_B2:
				uint num2;
				switch ((num2 = (arg_B7_0 ^ 2256901548u)) % 7u)
				{
				case 0u:
					arg_B7_0 = ((this.accountId_ != null) ? 3264585250u : 2733094275u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
					arg_B7_0 = (num2 * 2864088273u ^ 179667070u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Peer);
					arg_B7_0 = (num2 * 3944377437u ^ 1836170553u);
					continue;
				case 4u:
					goto IL_4E;
				case 5u:
					goto IL_EE;
				case 6u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
					arg_B7_0 = (num2 * 1387679600u ^ 3480114595u);
					continue;
				}
				break;
			}
			return num;
			IL_4E:
			arg_B7_0 = 2725573748u;
			goto IL_B2;
			IL_EE:
			arg_B7_0 = ((this.peer_ != null) ? 3006046135u : 4078678774u);
			goto IL_B2;
		}

		public void MergeFrom(UpdateFriendStateNotification other)
		{
			if (other == null)
			{
				goto IL_85;
			}
			goto IL_27A;
			uint arg_212_0;
			while (true)
			{
				IL_20D:
				uint num;
				switch ((num = (arg_212_0 ^ 122305835u)) % 19u)
				{
				case 0u:
					this.ChangedFriend.MergeFrom(other.ChangedFriend);
					arg_212_0 = 1861919389u;
					continue;
				case 1u:
					goto IL_27A;
				case 2u:
					arg_212_0 = ((other.peer_ != null) ? 162877250u : 2058197277u);
					continue;
				case 3u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_212_0 = 1764019045u;
					continue;
				case 4u:
					this.accountId_ = new EntityId();
					arg_212_0 = (num * 3992233538u ^ 1811096856u);
					continue;
				case 5u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_212_0 = 43099640u;
					continue;
				case 6u:
					this.Peer.MergeFrom(other.Peer);
					arg_212_0 = 2058197277u;
					continue;
				case 7u:
					arg_212_0 = ((other.accountId_ == null) ? 43099640u : 1928803790u);
					continue;
				case 8u:
					this.gameAccountId_ = new EntityId();
					arg_212_0 = (num * 2304348887u ^ 3488209691u);
					continue;
				case 9u:
					arg_212_0 = (((this.changedFriend_ == null) ? 3448445839u : 2936041071u) ^ num * 3389537938u);
					continue;
				case 10u:
					this.changedFriend_ = new Friend();
					arg_212_0 = (num * 1859423297u ^ 462564683u);
					continue;
				case 12u:
					arg_212_0 = (((this.gameAccountId_ == null) ? 351575500u : 1144492362u) ^ num * 3729856524u);
					continue;
				case 13u:
					arg_212_0 = (((this.accountId_ != null) ? 2509514963u : 2515705882u) ^ num * 2767784411u);
					continue;
				case 14u:
					goto IL_85;
				case 15u:
					arg_212_0 = (((this.peer_ != null) ? 2590617234u : 3997248349u) ^ num * 1617445597u);
					continue;
				case 16u:
					return;
				case 17u:
					arg_212_0 = ((other.gameAccountId_ != null) ? 5372370u : 1764019045u);
					continue;
				case 18u:
					this.peer_ = new ProcessId();
					arg_212_0 = (num * 3672190708u ^ 3979987755u);
					continue;
				}
				break;
			}
			return;
			IL_85:
			arg_212_0 = 652981447u;
			goto IL_20D;
			IL_27A:
			arg_212_0 = ((other.changedFriend_ == null) ? 1861919389u : 560693748u);
			goto IL_20D;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2EF:
				uint num;
				uint arg_273_0 = ((num = input.ReadTag()) != 0u) ? 2246708989u : 3090205800u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_273_0 ^ 3036017196u)) % 24u)
					{
					case 0u:
						this.changedFriend_ = new Friend();
						arg_273_0 = (num2 * 133736145u ^ 3179220910u);
						continue;
					case 1u:
						arg_273_0 = ((num <= 18u) ? 3204383655u : 3023450161u);
						continue;
					case 2u:
						input.ReadMessage(this.accountId_);
						arg_273_0 = 4049538497u;
						continue;
					case 3u:
						this.accountId_ = new EntityId();
						arg_273_0 = (num2 * 289716316u ^ 2082549018u);
						continue;
					case 4u:
						arg_273_0 = ((this.gameAccountId_ == null) ? 3390590978u : 3239599208u);
						continue;
					case 5u:
						goto IL_2EF;
					case 6u:
						arg_273_0 = (num2 * 1667602742u ^ 4044958933u);
						continue;
					case 7u:
						arg_273_0 = ((this.accountId_ != null) ? 3264421646u : 4148774383u);
						continue;
					case 8u:
						input.ReadMessage(this.peer_);
						arg_273_0 = 4049538497u;
						continue;
					case 9u:
						arg_273_0 = 2246708989u;
						continue;
					case 10u:
						input.ReadMessage(this.changedFriend_);
						arg_273_0 = 4049538497u;
						continue;
					case 11u:
						arg_273_0 = ((this.peer_ == null) ? 4007125228u : 2418715188u);
						continue;
					case 13u:
						arg_273_0 = ((num != 34u) ? 2749549717u : 2932767287u);
						continue;
					case 14u:
						input.SkipLastField();
						arg_273_0 = 3895511826u;
						continue;
					case 15u:
						arg_273_0 = (num2 * 2075965448u ^ 3781338978u);
						continue;
					case 16u:
						this.peer_ = new ProcessId();
						arg_273_0 = (num2 * 414131001u ^ 458016500u);
						continue;
					case 17u:
						arg_273_0 = (((num == 42u) ? 3870327733u : 3971352612u) ^ num2 * 2794030190u);
						continue;
					case 18u:
						arg_273_0 = ((this.changedFriend_ == null) ? 2563365596u : 3847619678u);
						continue;
					case 19u:
						arg_273_0 = (((num == 10u) ? 3641989858u : 3802949567u) ^ num2 * 3123929516u);
						continue;
					case 20u:
						input.ReadMessage(this.gameAccountId_);
						arg_273_0 = 3799696705u;
						continue;
					case 21u:
						arg_273_0 = (num2 * 3054751840u ^ 2626376993u);
						continue;
					case 22u:
						this.gameAccountId_ = new EntityId();
						arg_273_0 = (num2 * 2638596349u ^ 3270208286u);
						continue;
					case 23u:
						arg_273_0 = (((num != 18u) ? 3397272068u : 2549385167u) ^ num2 * 3820783497u);
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
