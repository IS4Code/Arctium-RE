using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountFlagUpdateRequest : IMessage<GameAccountFlagUpdateRequest>, IEquatable<GameAccountFlagUpdateRequest>, IDeepCloneable<GameAccountFlagUpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountFlagUpdateRequest.__c __9 = new GameAccountFlagUpdateRequest.__c();

			internal GameAccountFlagUpdateRequest cctor>b__34_0()
			{
				return new GameAccountFlagUpdateRequest();
			}
		}

		private static readonly MessageParser<GameAccountFlagUpdateRequest> _parser = new MessageParser<GameAccountFlagUpdateRequest>(new Func<GameAccountFlagUpdateRequest>(GameAccountFlagUpdateRequest.__c.__9.<.cctor>b__34_0));

		public const int GameAccountFieldNumber = 1;

		private GameAccountHandle gameAccount_;

		public const int FlagFieldNumber = 2;

		private ulong flag_;

		public const int ActiveFieldNumber = 3;

		private bool active_;

		public static MessageParser<GameAccountFlagUpdateRequest> Parser
		{
			get
			{
				return GameAccountFlagUpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountFlagUpdateRequest.Descriptor;
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

		public ulong Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		public bool Active
		{
			get
			{
				return this.active_;
			}
			set
			{
				this.active_ = value;
			}
		}

		public GameAccountFlagUpdateRequest()
		{
		}

		public GameAccountFlagUpdateRequest(GameAccountFlagUpdateRequest other) : this()
		{
			while (true)
			{
				IL_84:
				uint arg_64_0 = 232710139u;
				while (true)
				{
					uint num;
					switch ((num = (arg_64_0 ^ 1849351568u)) % 5u)
					{
					case 0u:
						this.active_ = other.active_;
						arg_64_0 = (num * 3392496901u ^ 3150541431u);
						continue;
					case 1u:
						this.GameAccount = ((other.gameAccount_ != null) ? other.GameAccount.Clone() : null);
						arg_64_0 = 841616630u;
						continue;
					case 3u:
						goto IL_84;
					case 4u:
						this.flag_ = other.flag_;
						arg_64_0 = (num * 959532731u ^ 274883880u);
						continue;
					}
					return;
				}
			}
		}

		public GameAccountFlagUpdateRequest Clone()
		{
			return new GameAccountFlagUpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountFlagUpdateRequest);
		}

		public bool Equals(GameAccountFlagUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_DF;
			int arg_99_0;
			while (true)
			{
				IL_94:
				switch ((arg_99_0 ^ 1024303389) % 11)
				{
				case 0:
					return false;
				case 1:
					arg_99_0 = ((this.Flag == other.Flag) ? 1758189477 : 1645788151);
					continue;
				case 2:
					arg_99_0 = (GameAccountFlagUpdateRequest.smethod_0(this.GameAccount, other.GameAccount) ? 1137960772 : 1884982423);
					continue;
				case 3:
					goto IL_3C;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					arg_99_0 = ((this.Active != other.Active) ? 1121313275 : 470969805);
					continue;
				case 7:
					goto IL_DF;
				case 8:
					return false;
				case 9:
					return false;
				}
				break;
			}
			return true;
			IL_3C:
			arg_99_0 = 812182422;
			goto IL_94;
			IL_DF:
			arg_99_0 = ((other == this) ? 1933236167 : 1066318831);
			goto IL_94;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameAccount_ != null)
			{
				goto IL_60;
			}
			goto IL_DE;
			uint arg_A7_0;
			while (true)
			{
				IL_A2:
				uint num2;
				switch ((num2 = (arg_A7_0 ^ 1510758189u)) % 7u)
				{
				case 0u:
					goto IL_DE;
				case 1u:
					num ^= GameAccountFlagUpdateRequest.smethod_1(this.GameAccount);
					arg_A7_0 = (num2 * 3511196660u ^ 2683279472u);
					continue;
				case 3u:
					num ^= this.Active.GetHashCode();
					arg_A7_0 = (num2 * 2186350870u ^ 1250420631u);
					continue;
				case 4u:
					goto IL_60;
				case 5u:
					arg_A7_0 = (this.Active ? 1196571718u : 1419620773u);
					continue;
				case 6u:
					num ^= this.Flag.GetHashCode();
					arg_A7_0 = (num2 * 1646502817u ^ 326922998u);
					continue;
				}
				break;
			}
			return num;
			IL_60:
			arg_A7_0 = 734792101u;
			goto IL_A2;
			IL_DE:
			arg_A7_0 = ((this.Flag != 0uL) ? 1337043803u : 1193319104u);
			goto IL_A2;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.gameAccount_ != null)
			{
				goto IL_94;
			}
			goto IL_12B;
			uint arg_E7_0;
			while (true)
			{
				IL_E2:
				uint num;
				switch ((num = (arg_E7_0 ^ 3451841113u)) % 10u)
				{
				case 1u:
					output.WriteMessage(this.GameAccount);
					arg_E7_0 = (num * 453969823u ^ 2925075025u);
					continue;
				case 2u:
					output.WriteRawTag(24);
					arg_E7_0 = (num * 4216045026u ^ 903581521u);
					continue;
				case 3u:
					goto IL_12B;
				case 4u:
					output.WriteRawTag(16);
					arg_E7_0 = (num * 592974661u ^ 2551942064u);
					continue;
				case 5u:
					goto IL_94;
				case 6u:
					arg_E7_0 = ((!this.Active) ? 3229437103u : 3310104755u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					arg_E7_0 = (num * 3441878743u ^ 3533854207u);
					continue;
				case 8u:
					output.WriteBool(this.Active);
					arg_E7_0 = (num * 1363019176u ^ 1198872271u);
					continue;
				case 9u:
					output.WriteUInt64(this.Flag);
					arg_E7_0 = (num * 3718498653u ^ 904263736u);
					continue;
				}
				break;
			}
			return;
			IL_94:
			arg_E7_0 = 2896694932u;
			goto IL_E2;
			IL_12B:
			arg_E7_0 = ((this.Flag == 0uL) ? 3595188913u : 2313855549u);
			goto IL_E2;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.gameAccount_ != null)
			{
				goto IL_1C;
			}
			goto IL_CF;
			uint arg_98_0;
			while (true)
			{
				IL_93:
				uint num2;
				switch ((num2 = (arg_98_0 ^ 2282269506u)) % 7u)
				{
				case 1u:
					goto IL_CF;
				case 2u:
					num += 2;
					arg_98_0 = (num2 * 1468057062u ^ 128121934u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.Flag);
					arg_98_0 = (num2 * 3586508655u ^ 3542874728u);
					continue;
				case 4u:
					arg_98_0 = ((!this.Active) ? 3361908944u : 2798498167u);
					continue;
				case 5u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
					arg_98_0 = (num2 * 2878546704u ^ 2452518618u);
					continue;
				case 6u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_98_0 = 2347956235u;
			goto IL_93;
			IL_CF:
			arg_98_0 = ((this.Flag == 0uL) ? 2571264387u : 2345008647u);
			goto IL_93;
		}

		public void MergeFrom(GameAccountFlagUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_9E;
			}
			goto IL_146;
			uint arg_FE_0;
			while (true)
			{
				IL_F9:
				uint num;
				switch ((num = (arg_FE_0 ^ 3544901368u)) % 11u)
				{
				case 0u:
					this.gameAccount_ = new GameAccountHandle();
					arg_FE_0 = (num * 3284961756u ^ 2193906736u);
					continue;
				case 1u:
					arg_FE_0 = ((other.Flag == 0uL) ? 2336555005u : 3716110189u);
					continue;
				case 2u:
					this.Active = other.Active;
					arg_FE_0 = (num * 876477254u ^ 2261224251u);
					continue;
				case 3u:
					goto IL_146;
				case 5u:
					goto IL_9E;
				case 6u:
					this.Flag = other.Flag;
					arg_FE_0 = (num * 1543871646u ^ 168270347u);
					continue;
				case 7u:
					return;
				case 8u:
					arg_FE_0 = ((!other.Active) ? 2757938829u : 3551416209u);
					continue;
				case 9u:
					arg_FE_0 = (((this.gameAccount_ != null) ? 631724514u : 1531737962u) ^ num * 1921902007u);
					continue;
				case 10u:
					this.GameAccount.MergeFrom(other.GameAccount);
					arg_FE_0 = 2230339405u;
					continue;
				}
				break;
			}
			return;
			IL_9E:
			arg_FE_0 = 2996649526u;
			goto IL_F9;
			IL_146:
			arg_FE_0 = ((other.gameAccount_ == null) ? 2230339405u : 2365440326u);
			goto IL_F9;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1AD:
				uint num;
				uint arg_155_0 = ((num = input.ReadTag()) != 0u) ? 4109539017u : 3126617874u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_155_0 ^ 2455477670u)) % 15u)
					{
					case 0u:
						arg_155_0 = ((this.gameAccount_ == null) ? 3304954850u : 3719546429u);
						continue;
					case 1u:
						this.Flag = input.ReadUInt64();
						arg_155_0 = 3683683376u;
						continue;
					case 2u:
						input.ReadMessage(this.gameAccount_);
						arg_155_0 = 2254335498u;
						continue;
					case 3u:
						arg_155_0 = ((num != 10u) ? 3267291071u : 2813212605u);
						continue;
					case 4u:
						goto IL_1AD;
					case 5u:
						arg_155_0 = (num2 * 1913955844u ^ 1813138742u);
						continue;
					case 6u:
						arg_155_0 = (((num != 16u) ? 3572261148u : 2941438137u) ^ num2 * 3740903631u);
						continue;
					case 7u:
						this.Active = input.ReadBool();
						arg_155_0 = 2711296902u;
						continue;
					case 8u:
						arg_155_0 = (num2 * 2344796193u ^ 932372432u);
						continue;
					case 9u:
						arg_155_0 = 4109539017u;
						continue;
					case 10u:
						arg_155_0 = (((num == 24u) ? 1416889608u : 2094368934u) ^ num2 * 1635397196u);
						continue;
					case 11u:
						this.gameAccount_ = new GameAccountHandle();
						arg_155_0 = (num2 * 2458271045u ^ 610673257u);
						continue;
					case 13u:
						input.SkipLastField();
						arg_155_0 = (num2 * 2951776026u ^ 4284399685u);
						continue;
					case 14u:
						arg_155_0 = (num2 * 484465798u ^ 138533988u);
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
