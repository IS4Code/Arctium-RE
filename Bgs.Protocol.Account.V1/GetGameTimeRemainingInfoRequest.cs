using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetGameTimeRemainingInfoRequest : IMessage<GetGameTimeRemainingInfoRequest>, IEquatable<GetGameTimeRemainingInfoRequest>, IDeepCloneable<GetGameTimeRemainingInfoRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetGameTimeRemainingInfoRequest.__c __9 = new GetGameTimeRemainingInfoRequest.__c();

			internal GetGameTimeRemainingInfoRequest cctor>b__29_0()
			{
				return new GetGameTimeRemainingInfoRequest();
			}
		}

		private static readonly MessageParser<GetGameTimeRemainingInfoRequest> _parser = new MessageParser<GetGameTimeRemainingInfoRequest>(new Func<GetGameTimeRemainingInfoRequest>(GetGameTimeRemainingInfoRequest.__c.__9.<.cctor>b__29_0));

		public const int GameAccountIdFieldNumber = 1;

		private EntityId gameAccountId_;

		public const int AccountIdFieldNumber = 2;

		private EntityId accountId_;

		public static MessageParser<GetGameTimeRemainingInfoRequest> Parser
		{
			get
			{
				return GetGameTimeRemainingInfoRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[21];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameTimeRemainingInfoRequest.Descriptor;
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

		public GetGameTimeRemainingInfoRequest()
		{
		}

		public GetGameTimeRemainingInfoRequest(GetGameTimeRemainingInfoRequest other) : this()
		{
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
		}

		public GetGameTimeRemainingInfoRequest Clone()
		{
			return new GetGameTimeRemainingInfoRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameTimeRemainingInfoRequest);
		}

		public bool Equals(GetGameTimeRemainingInfoRequest other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -1517058990) % 9)
				{
				case 0:
					return false;
				case 1:
					goto IL_B5;
				case 2:
					return false;
				case 3:
					arg_77_0 = ((!GetGameTimeRemainingInfoRequest.smethod_0(this.AccountId, other.AccountId)) ? -978301388 : -1994741518);
					continue;
				case 4:
					goto IL_41;
				case 5:
					return true;
				case 6:
					return false;
				case 8:
					arg_77_0 = (GetGameTimeRemainingInfoRequest.smethod_0(this.GameAccountId, other.GameAccountId) ? -808644376 : -2021966820);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_77_0 = -2015329889;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -743007050 : -42957657);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B2:
				uint arg_8E_0 = 1381888284u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8E_0 ^ 1145162271u)) % 6u)
					{
					case 0u:
						goto IL_B2;
					case 1u:
						arg_8E_0 = (((this.gameAccountId_ == null) ? 3663141773u : 3267568540u) ^ num2 * 1538832382u);
						continue;
					case 3u:
						num ^= GetGameTimeRemainingInfoRequest.smethod_1(this.GameAccountId);
						arg_8E_0 = (num2 * 569055248u ^ 488469991u);
						continue;
					case 4u:
						arg_8E_0 = ((this.accountId_ == null) ? 49524989u : 820983600u);
						continue;
					case 5u:
						num ^= GetGameTimeRemainingInfoRequest.smethod_1(this.AccountId);
						arg_8E_0 = (num2 * 527934718u ^ 1129963615u);
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
			if (this.gameAccountId_ != null)
			{
				goto IL_60;
			}
			goto IL_96;
			uint arg_6A_0;
			while (true)
			{
				IL_65:
				uint num;
				switch ((num = (arg_6A_0 ^ 759228003u)) % 5u)
				{
				case 0u:
					goto IL_60;
				case 2u:
					goto IL_96;
				case 3u:
					output.WriteRawTag(18);
					output.WriteMessage(this.AccountId);
					arg_6A_0 = (num * 1100974186u ^ 4064306056u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					output.WriteMessage(this.GameAccountId);
					arg_6A_0 = (num * 1011080418u ^ 2760688178u);
					continue;
				}
				break;
			}
			return;
			IL_60:
			arg_6A_0 = 2053200718u;
			goto IL_65;
			IL_96:
			arg_6A_0 = ((this.accountId_ != null) ? 2112735944u : 1659123014u);
			goto IL_65;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 1738476822u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 2089167117u)) % 6u)
					{
					case 0u:
						goto IL_B6;
					case 1u:
						arg_92_0 = (((this.gameAccountId_ != null) ? 699359674u : 1481475333u) ^ num2 * 4277952093u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_92_0 = (num2 * 2021288086u ^ 3517502106u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_92_0 = (num2 * 1071429732u ^ 1863189449u);
						continue;
					case 5u:
						arg_92_0 = ((this.accountId_ == null) ? 1780621493u : 762082490u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetGameTimeRemainingInfoRequest other)
		{
			if (other == null)
			{
				goto IL_8F;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 3437735838u)) % 11u)
				{
				case 1u:
					arg_105_0 = (((this.accountId_ == null) ? 399400020u : 1903696825u) ^ num * 3388732586u);
					continue;
				case 2u:
					arg_105_0 = (((this.gameAccountId_ != null) ? 4115069245u : 3879778918u) ^ num * 668875594u);
					continue;
				case 3u:
					this.accountId_ = new EntityId();
					arg_105_0 = (num * 320870621u ^ 1201506515u);
					continue;
				case 4u:
					goto IL_8F;
				case 5u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_105_0 = 3753284106u;
					continue;
				case 6u:
					this.gameAccountId_ = new EntityId();
					arg_105_0 = (num * 4105074833u ^ 3929834117u);
					continue;
				case 7u:
					goto IL_14D;
				case 8u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_105_0 = 3832924732u;
					continue;
				case 9u:
					return;
				case 10u:
					arg_105_0 = ((other.accountId_ != null) ? 2499070675u : 3753284106u);
					continue;
				}
				break;
			}
			return;
			IL_8F:
			arg_105_0 = 3213498114u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.gameAccountId_ == null) ? 3832924732u : 3219385976u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) == 0u) ? 3311766440u : 4184912952u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 3416525215u)) % 14u)
					{
					case 0u:
						arg_145_0 = 4184912952u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_145_0 = (num2 * 116751891u ^ 1139354191u);
						continue;
					case 2u:
						this.gameAccountId_ = new EntityId();
						arg_145_0 = (num2 * 3449235869u ^ 3719633007u);
						continue;
					case 3u:
						arg_145_0 = ((this.gameAccountId_ != null) ? 3572878971u : 2803639739u);
						continue;
					case 4u:
						arg_145_0 = ((this.accountId_ == null) ? 3462671831u : 3602344126u);
						continue;
					case 5u:
						input.ReadMessage(this.accountId_);
						arg_145_0 = 3062920101u;
						continue;
					case 6u:
						input.ReadMessage(this.gameAccountId_);
						arg_145_0 = 2828758492u;
						continue;
					case 7u:
						arg_145_0 = (num2 * 2074479364u ^ 3079954961u);
						continue;
					case 8u:
						arg_145_0 = (((num != 18u) ? 3928668132u : 3219919795u) ^ num2 * 4130342853u);
						continue;
					case 10u:
						this.accountId_ = new EntityId();
						arg_145_0 = (num2 * 2595496630u ^ 3099341710u);
						continue;
					case 11u:
						arg_145_0 = ((num != 10u) ? 4247090651u : 4025045030u);
						continue;
					case 12u:
						goto IL_199;
					case 13u:
						arg_145_0 = (num2 * 3229272188u ^ 375823313u);
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
