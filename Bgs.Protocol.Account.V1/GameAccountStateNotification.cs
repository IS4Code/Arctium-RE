using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountStateNotification : IMessage<GameAccountStateNotification>, IEquatable<GameAccountStateNotification>, IDeepCloneable<GameAccountStateNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountStateNotification.__c __9 = new GameAccountStateNotification.__c();

			internal GameAccountStateNotification cctor>b__39_0()
			{
				return new GameAccountStateNotification();
			}
		}

		private static readonly MessageParser<GameAccountStateNotification> _parser = new MessageParser<GameAccountStateNotification>(new Func<GameAccountStateNotification>(GameAccountStateNotification.__c.__9.<.cctor>b__39_0));

		public const int GameAccountStateFieldNumber = 1;

		private GameAccountState gameAccountState_;

		public const int SubscriberIdFieldNumber = 2;

		private ulong subscriberId_;

		public const int GameAccountTagsFieldNumber = 3;

		private GameAccountFieldTags gameAccountTags_;

		public const int SubscriptionCompletedFieldNumber = 4;

		private bool subscriptionCompleted_;

		public static MessageParser<GameAccountStateNotification> Parser
		{
			get
			{
				return GameAccountStateNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[29];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountStateNotification.Descriptor;
			}
		}

		public GameAccountState GameAccountState
		{
			get
			{
				return this.gameAccountState_;
			}
			set
			{
				this.gameAccountState_ = value;
			}
		}

		public ulong SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		public GameAccountFieldTags GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
			set
			{
				this.gameAccountTags_ = value;
			}
		}

		public bool SubscriptionCompleted
		{
			get
			{
				return this.subscriptionCompleted_;
			}
			set
			{
				this.subscriptionCompleted_ = value;
			}
		}

		public GameAccountStateNotification()
		{
		}

		public GameAccountStateNotification(GameAccountStateNotification other) : this()
		{
			this.GameAccountState = ((other.gameAccountState_ != null) ? other.GameAccountState.Clone() : null);
			this.subscriberId_ = other.subscriberId_;
			this.GameAccountTags = ((other.gameAccountTags_ != null) ? other.GameAccountTags.Clone() : null);
			this.subscriptionCompleted_ = other.subscriptionCompleted_;
		}

		public GameAccountStateNotification Clone()
		{
			return new GameAccountStateNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountStateNotification);
		}

		public bool Equals(GameAccountStateNotification other)
		{
			if (other == null)
			{
				goto IL_C4;
			}
			goto IL_11C;
			int arg_CE_0;
			while (true)
			{
				IL_C9:
				switch ((arg_CE_0 ^ 2019780341) % 13)
				{
				case 0:
					goto IL_C4;
				case 2:
					goto IL_11C;
				case 3:
					arg_CE_0 = ((this.SubscriberId != other.SubscriberId) ? 202190920 : 141529842);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_CE_0 = (GameAccountStateNotification.smethod_0(this.GameAccountState, other.GameAccountState) ? 1665396040 : 205668611);
					continue;
				case 8:
					return false;
				case 9:
					return true;
				case 10:
					return false;
				case 11:
					arg_CE_0 = ((!GameAccountStateNotification.smethod_0(this.GameAccountTags, other.GameAccountTags)) ? 1106733478 : 711829773);
					continue;
				case 12:
					arg_CE_0 = ((this.SubscriptionCompleted == other.SubscriptionCompleted) ? 1621340534 : 343749639);
					continue;
				}
				break;
			}
			return true;
			IL_C4:
			arg_CE_0 = 1526030904;
			goto IL_C9;
			IL_11C:
			arg_CE_0 = ((other == this) ? 1109872461 : 229470820);
			goto IL_C9;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_151:
				uint arg_11C_0 = 2228453846u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_11C_0 ^ 3607754221u)) % 10u)
					{
					case 0u:
						arg_11C_0 = (this.SubscriptionCompleted ? 3591398875u : 2891556666u);
						continue;
					case 1u:
						arg_11C_0 = (((this.gameAccountState_ != null) ? 537711360u : 1162464199u) ^ num2 * 528312338u);
						continue;
					case 2u:
						arg_11C_0 = ((this.SubscriberId == 0uL) ? 2164869745u : 4197346024u);
						continue;
					case 3u:
						num ^= this.SubscriberId.GetHashCode();
						arg_11C_0 = (num2 * 2817239887u ^ 570434554u);
						continue;
					case 4u:
						num ^= this.SubscriptionCompleted.GetHashCode();
						arg_11C_0 = (num2 * 3858909993u ^ 3801763228u);
						continue;
					case 6u:
						num ^= this.GameAccountTags.GetHashCode();
						arg_11C_0 = (num2 * 17938849u ^ 3104917437u);
						continue;
					case 7u:
						num ^= GameAccountStateNotification.smethod_1(this.GameAccountState);
						arg_11C_0 = (num2 * 3934631209u ^ 4192999010u);
						continue;
					case 8u:
						arg_11C_0 = ((this.gameAccountTags_ != null) ? 2688713013u : 2435699813u);
						continue;
					case 9u:
						goto IL_151;
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
			if (this.gameAccountState_ != null)
			{
				goto IL_CE;
			}
			goto IL_154;
			uint arg_110_0;
			while (true)
			{
				IL_10B:
				uint num;
				switch ((num = (arg_110_0 ^ 1241605511u)) % 10u)
				{
				case 0u:
					output.WriteRawTag(16);
					arg_110_0 = (num * 1671716445u ^ 2411111626u);
					continue;
				case 1u:
					arg_110_0 = ((this.gameAccountTags_ != null) ? 413994709u : 1109826850u);
					continue;
				case 2u:
					goto IL_154;
				case 3u:
					goto IL_CE;
				case 5u:
					arg_110_0 = (this.SubscriptionCompleted ? 719794329u : 355924311u);
					continue;
				case 6u:
					output.WriteRawTag(32);
					output.WriteBool(this.SubscriptionCompleted);
					arg_110_0 = (num * 547529455u ^ 3235154517u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					output.WriteMessage(this.GameAccountState);
					arg_110_0 = (num * 203990745u ^ 2467248170u);
					continue;
				case 8u:
					output.WriteRawTag(26);
					output.WriteMessage(this.GameAccountTags);
					arg_110_0 = (num * 1927723908u ^ 3235815786u);
					continue;
				case 9u:
					output.WriteUInt64(this.SubscriberId);
					arg_110_0 = (num * 1950738047u ^ 3798793831u);
					continue;
				}
				break;
			}
			return;
			IL_CE:
			arg_110_0 = 652785328u;
			goto IL_10B;
			IL_154:
			arg_110_0 = ((this.SubscriberId == 0uL) ? 358916320u : 247271363u);
			goto IL_10B;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_144:
				uint arg_10F_0 = 1756231839u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10F_0 ^ 681372566u)) % 10u)
					{
					case 0u:
						num += 2;
						arg_10F_0 = (num2 * 3095695318u ^ 4244378566u);
						continue;
					case 1u:
						arg_10F_0 = (((this.gameAccountState_ == null) ? 1381444138u : 2102799125u) ^ num2 * 3874815752u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountState);
						arg_10F_0 = (num2 * 1115537334u ^ 3610610224u);
						continue;
					case 4u:
						arg_10F_0 = ((this.SubscriberId != 0uL) ? 1396398121u : 1669875130u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
						arg_10F_0 = (num2 * 2215539635u ^ 2147171895u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountTags);
						arg_10F_0 = (num2 * 3164420065u ^ 716954625u);
						continue;
					case 7u:
						goto IL_144;
					case 8u:
						arg_10F_0 = ((this.gameAccountTags_ != null) ? 994961398u : 1107254369u);
						continue;
					case 9u:
						arg_10F_0 = (this.SubscriptionCompleted ? 35278434u : 1240340030u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountStateNotification other)
		{
			if (other == null)
			{
				goto IL_17F;
			}
			goto IL_1E1;
			uint arg_189_0;
			while (true)
			{
				IL_184:
				uint num;
				switch ((num = (arg_189_0 ^ 3196062235u)) % 15u)
				{
				case 0u:
					goto IL_17F;
				case 1u:
					return;
				case 2u:
					arg_189_0 = ((other.gameAccountTags_ == null) ? 3542311875u : 2342865837u);
					continue;
				case 3u:
					this.GameAccountTags.MergeFrom(other.GameAccountTags);
					arg_189_0 = 3542311875u;
					continue;
				case 4u:
					arg_189_0 = (((this.gameAccountState_ == null) ? 985048290u : 1660849120u) ^ num * 2484227954u);
					continue;
				case 5u:
					this.gameAccountTags_ = new GameAccountFieldTags();
					arg_189_0 = (num * 1928569070u ^ 2722676706u);
					continue;
				case 6u:
					this.GameAccountState.MergeFrom(other.GameAccountState);
					arg_189_0 = 3921216275u;
					continue;
				case 7u:
					arg_189_0 = (((this.gameAccountTags_ != null) ? 2998484570u : 3267552964u) ^ num * 2643196409u);
					continue;
				case 8u:
					arg_189_0 = (other.SubscriptionCompleted ? 3148364989u : 3446128461u);
					continue;
				case 9u:
					this.gameAccountState_ = new GameAccountState();
					arg_189_0 = (num * 85069794u ^ 2149958908u);
					continue;
				case 10u:
					this.SubscriptionCompleted = other.SubscriptionCompleted;
					arg_189_0 = (num * 853276136u ^ 2577914685u);
					continue;
				case 11u:
					arg_189_0 = ((other.SubscriberId == 0uL) ? 4079583387u : 3335534246u);
					continue;
				case 12u:
					goto IL_1E1;
				case 14u:
					this.SubscriberId = other.SubscriberId;
					arg_189_0 = (num * 3778289079u ^ 2022265984u);
					continue;
				}
				break;
			}
			return;
			IL_17F:
			arg_189_0 = 2316078064u;
			goto IL_184;
			IL_1E1:
			arg_189_0 = ((other.gameAccountState_ == null) ? 3921216275u : 2302302878u);
			goto IL_184;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_260:
				uint num;
				uint arg_1F4_0 = ((num = input.ReadTag()) != 0u) ? 3933879847u : 3777983546u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F4_0 ^ 2477989152u)) % 20u)
					{
					case 0u:
						arg_1F4_0 = ((num != 26u) ? 3251606729u : 3712284843u);
						continue;
					case 1u:
						arg_1F4_0 = (((num == 32u) ? 2695708221u : 2877945691u) ^ num2 * 46065128u);
						continue;
					case 2u:
						arg_1F4_0 = ((this.gameAccountState_ == null) ? 3860056348u : 2647689540u);
						continue;
					case 3u:
						arg_1F4_0 = ((this.gameAccountTags_ != null) ? 2489480958u : 3407915904u);
						continue;
					case 4u:
						this.gameAccountState_ = new GameAccountState();
						arg_1F4_0 = (num2 * 3567518279u ^ 442752480u);
						continue;
					case 5u:
						arg_1F4_0 = (((num == 10u) ? 3625046907u : 3380045613u) ^ num2 * 505577821u);
						continue;
					case 7u:
						arg_1F4_0 = (num2 * 973521616u ^ 1258486566u);
						continue;
					case 8u:
						arg_1F4_0 = (((num != 16u) ? 1133375141u : 1063813015u) ^ num2 * 2650024592u);
						continue;
					case 9u:
						this.SubscriptionCompleted = input.ReadBool();
						arg_1F4_0 = 3217203094u;
						continue;
					case 10u:
						input.ReadMessage(this.gameAccountTags_);
						arg_1F4_0 = 3291938378u;
						continue;
					case 11u:
						this.SubscriberId = input.ReadUInt64();
						arg_1F4_0 = 4039389815u;
						continue;
					case 12u:
						this.gameAccountTags_ = new GameAccountFieldTags();
						arg_1F4_0 = (num2 * 1061684731u ^ 3959904286u);
						continue;
					case 13u:
						arg_1F4_0 = (num2 * 3953691312u ^ 3021610499u);
						continue;
					case 14u:
						goto IL_260;
					case 15u:
						input.SkipLastField();
						arg_1F4_0 = 3217203094u;
						continue;
					case 16u:
						input.ReadMessage(this.gameAccountState_);
						arg_1F4_0 = 3217203094u;
						continue;
					case 17u:
						arg_1F4_0 = 3933879847u;
						continue;
					case 18u:
						arg_1F4_0 = (num2 * 737521011u ^ 2173129992u);
						continue;
					case 19u:
						arg_1F4_0 = ((num <= 16u) ? 2391131269u : 2577128648u);
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
