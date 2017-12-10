using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class PresenceChannelCreatedRequest : IMessage<PresenceChannelCreatedRequest>, IEquatable<PresenceChannelCreatedRequest>, IDeepCloneable<PresenceChannelCreatedRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly PresenceChannelCreatedRequest.__c __9 = new PresenceChannelCreatedRequest.__c();

			internal PresenceChannelCreatedRequest cctor>b__39_0()
			{
				return new PresenceChannelCreatedRequest();
			}
		}

		private static readonly MessageParser<PresenceChannelCreatedRequest> _parser = new MessageParser<PresenceChannelCreatedRequest>(new Func<PresenceChannelCreatedRequest>(PresenceChannelCreatedRequest.__c.__9.<.cctor>b__39_0));

		public const int IdFieldNumber = 1;

		private EntityId id_;

		public const int GameAccountIdFieldNumber = 3;

		private EntityId gameAccountId_;

		public const int AccountIdFieldNumber = 4;

		private EntityId accountId_;

		public const int HostFieldNumber = 5;

		private ProcessId host_;

		public static MessageParser<PresenceChannelCreatedRequest> Parser
		{
			get
			{
				return PresenceChannelCreatedRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceChannelCreatedRequest.Descriptor;
			}
		}

		public EntityId Id
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

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		public PresenceChannelCreatedRequest()
		{
		}

		public PresenceChannelCreatedRequest(PresenceChannelCreatedRequest other) : this()
		{
			while (true)
			{
				IL_87:
				int arg_6D_0 = 1723882276;
				while (true)
				{
					switch ((arg_6D_0 ^ 1081353690) % 4)
					{
					case 0:
						goto IL_87;
					case 1:
						this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
						this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
						arg_6D_0 = 564671969;
						continue;
					case 2:
						this.Id = ((other.id_ != null) ? other.Id.Clone() : null);
						arg_6D_0 = 166790615;
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
		}

		public PresenceChannelCreatedRequest Clone()
		{
			return new PresenceChannelCreatedRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceChannelCreatedRequest);
		}

		public bool Equals(PresenceChannelCreatedRequest other)
		{
			if (other == null)
			{
				goto IL_A2;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ -1742615320) % 13)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_D8_0 = ((!PresenceChannelCreatedRequest.smethod_0(this.AccountId, other.AccountId)) ? -1798812259 : -1184253844);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_126;
				case 7:
					goto IL_A2;
				case 8:
					arg_D8_0 = (PresenceChannelCreatedRequest.smethod_0(this.Host, other.Host) ? -52304356 : -1130213654);
					continue;
				case 9:
					arg_D8_0 = (PresenceChannelCreatedRequest.smethod_0(this.GameAccountId, other.GameAccountId) ? -1021153772 : -1776389165);
					continue;
				case 10:
					return true;
				case 12:
					arg_D8_0 = (PresenceChannelCreatedRequest.smethod_0(this.Id, other.Id) ? -93281259 : -7963197);
					continue;
				}
				break;
			}
			return true;
			IL_A2:
			arg_D8_0 = -1052162524;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other == this) ? -1228581207 : -479778745);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_123:
				uint arg_F2_0 = 2557997559u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F2_0 ^ 2649250334u)) % 9u)
					{
					case 0u:
						num ^= PresenceChannelCreatedRequest.smethod_1(this.GameAccountId);
						arg_F2_0 = (num2 * 3270511122u ^ 502747650u);
						continue;
					case 1u:
						num ^= PresenceChannelCreatedRequest.smethod_1(this.Id);
						arg_F2_0 = (num2 * 445812814u ^ 3664574582u);
						continue;
					case 2u:
						arg_F2_0 = (((this.gameAccountId_ == null) ? 3795488262u : 3860110175u) ^ num2 * 2770508379u);
						continue;
					case 3u:
						goto IL_123;
					case 4u:
						arg_F2_0 = ((this.host_ == null) ? 2671459297u : 3988013515u);
						continue;
					case 5u:
						num ^= PresenceChannelCreatedRequest.smethod_1(this.AccountId);
						arg_F2_0 = (num2 * 1089867835u ^ 3012362229u);
						continue;
					case 6u:
						num ^= PresenceChannelCreatedRequest.smethod_1(this.Host);
						arg_F2_0 = (num2 * 615299163u ^ 1424082774u);
						continue;
					case 8u:
						arg_F2_0 = ((this.accountId_ != null) ? 3651663819u : 2959384546u);
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
			output.WriteMessage(this.Id);
			if (this.gameAccountId_ != null)
			{
				goto IL_4B;
			}
			goto IL_115;
			uint arg_DA_0;
			while (true)
			{
				IL_D5:
				uint num;
				switch ((num = (arg_DA_0 ^ 3525295497u)) % 8u)
				{
				case 1u:
					goto IL_115;
				case 2u:
					output.WriteRawTag(34);
					output.WriteMessage(this.AccountId);
					arg_DA_0 = (num * 1132864022u ^ 3390397622u);
					continue;
				case 3u:
					arg_DA_0 = ((this.host_ == null) ? 2351877841u : 2750606302u);
					continue;
				case 4u:
					output.WriteRawTag(26);
					output.WriteMessage(this.GameAccountId);
					arg_DA_0 = (num * 2140615824u ^ 873431936u);
					continue;
				case 5u:
					output.WriteMessage(this.Host);
					arg_DA_0 = (num * 3399465123u ^ 3463045750u);
					continue;
				case 6u:
					goto IL_4B;
				case 7u:
					output.WriteRawTag(42);
					arg_DA_0 = (num * 1719053753u ^ 2320071291u);
					continue;
				}
				break;
			}
			return;
			IL_4B:
			arg_DA_0 = 4284864749u;
			goto IL_D5;
			IL_115:
			arg_DA_0 = ((this.accountId_ != null) ? 2238440419u : 3893587370u);
			goto IL_D5;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_12B:
				uint arg_FA_0 = 2510911161u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_FA_0 ^ 3872126243u)) % 9u)
					{
					case 1u:
						arg_FA_0 = (((this.gameAccountId_ != null) ? 3060939973u : 2978272734u) ^ num2 * 1000265853u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_FA_0 = (num2 * 3645685764u ^ 1540327923u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
						arg_FA_0 = (num2 * 1526802588u ^ 2075798782u);
						continue;
					case 4u:
						arg_FA_0 = ((this.accountId_ == null) ? 3083290480u : 3052972207u);
						continue;
					case 5u:
						goto IL_12B;
					case 6u:
						arg_FA_0 = ((this.host_ == null) ? 3394170010u : 2558954680u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_FA_0 = (num2 * 3545917586u ^ 792952488u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_FA_0 = (num2 * 921002204u ^ 3684388270u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(PresenceChannelCreatedRequest other)
		{
			if (other == null)
			{
				goto IL_7D;
			}
			goto IL_27A;
			uint arg_212_0;
			while (true)
			{
				IL_20D:
				uint num;
				switch ((num = (arg_212_0 ^ 3014507787u)) % 19u)
				{
				case 0u:
					this.Id.MergeFrom(other.Id);
					arg_212_0 = 3612707020u;
					continue;
				case 1u:
					this.accountId_ = new EntityId();
					arg_212_0 = (num * 1232018632u ^ 1922882743u);
					continue;
				case 2u:
					this.Host.MergeFrom(other.Host);
					arg_212_0 = 4144961176u;
					continue;
				case 3u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_212_0 = 2251447432u;
					continue;
				case 4u:
					arg_212_0 = (((this.accountId_ != null) ? 2770628951u : 2426403559u) ^ num * 2628410556u);
					continue;
				case 5u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_212_0 = 3726061319u;
					continue;
				case 6u:
					arg_212_0 = (((this.host_ != null) ? 1983394942u : 1302573932u) ^ num * 3467087804u);
					continue;
				case 7u:
					return;
				case 9u:
					this.host_ = new ProcessId();
					arg_212_0 = (num * 3312370650u ^ 146849248u);
					continue;
				case 10u:
					this.gameAccountId_ = new EntityId();
					arg_212_0 = (num * 3354767364u ^ 2851281192u);
					continue;
				case 11u:
					arg_212_0 = (((this.gameAccountId_ != null) ? 2209079546u : 2753206936u) ^ num * 1314478306u);
					continue;
				case 12u:
					arg_212_0 = (((this.id_ == null) ? 1725663877u : 579340920u) ^ num * 2955077289u);
					continue;
				case 13u:
					arg_212_0 = ((other.gameAccountId_ != null) ? 2466578296u : 3726061319u);
					continue;
				case 14u:
					goto IL_7D;
				case 15u:
					goto IL_27A;
				case 16u:
					arg_212_0 = ((other.host_ == null) ? 4144961176u : 3508013801u);
					continue;
				case 17u:
					arg_212_0 = ((other.accountId_ != null) ? 2742223531u : 2251447432u);
					continue;
				case 18u:
					this.id_ = new EntityId();
					arg_212_0 = (num * 1190907243u ^ 2818225020u);
					continue;
				}
				break;
			}
			return;
			IL_7D:
			arg_212_0 = 4126255496u;
			goto IL_20D;
			IL_27A:
			arg_212_0 = ((other.id_ != null) ? 4193847428u : 3612707020u);
			goto IL_20D;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2D9:
				uint num;
				uint arg_261_0 = ((num = input.ReadTag()) == 0u) ? 2064680850u : 1254662997u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_261_0 ^ 49846219u)) % 23u)
					{
					case 0u:
						this.gameAccountId_ = new EntityId();
						arg_261_0 = (num2 * 2859010130u ^ 349037434u);
						continue;
					case 1u:
						input.ReadMessage(this.id_);
						arg_261_0 = 1374975441u;
						continue;
					case 2u:
						arg_261_0 = (((num == 26u) ? 3461260169u : 2412224920u) ^ num2 * 3222096354u);
						continue;
					case 3u:
						arg_261_0 = ((this.host_ == null) ? 1713754928u : 304610389u);
						continue;
					case 4u:
						input.ReadMessage(this.accountId_);
						arg_261_0 = 1374975441u;
						continue;
					case 5u:
						arg_261_0 = ((this.id_ != null) ? 952301539u : 1119369028u);
						continue;
					case 6u:
						this.id_ = new EntityId();
						arg_261_0 = (num2 * 1824720713u ^ 2407286308u);
						continue;
					case 7u:
						arg_261_0 = ((this.gameAccountId_ != null) ? 702705326u : 1737771793u);
						continue;
					case 8u:
						arg_261_0 = (((num != 10u) ? 2970473006u : 3681044282u) ^ num2 * 3201731268u);
						continue;
					case 9u:
						arg_261_0 = ((num == 34u) ? 341456123u : 1225963646u);
						continue;
					case 10u:
						arg_261_0 = (num2 * 810160077u ^ 3205966340u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_261_0 = 1992059903u;
						continue;
					case 12u:
						input.ReadMessage(this.gameAccountId_);
						arg_261_0 = 1374975441u;
						continue;
					case 13u:
						arg_261_0 = ((this.accountId_ == null) ? 1375252648u : 884902299u);
						continue;
					case 14u:
						arg_261_0 = (((num == 42u) ? 2374239991u : 3442676957u) ^ num2 * 2805290284u);
						continue;
					case 15u:
						this.host_ = new ProcessId();
						arg_261_0 = (num2 * 1294527744u ^ 221487957u);
						continue;
					case 16u:
						arg_261_0 = 1254662997u;
						continue;
					case 17u:
						goto IL_2D9;
					case 19u:
						this.accountId_ = new EntityId();
						arg_261_0 = (num2 * 2170635981u ^ 1708725724u);
						continue;
					case 20u:
						input.ReadMessage(this.host_);
						arg_261_0 = 1374975441u;
						continue;
					case 21u:
						arg_261_0 = (num2 * 2849248576u ^ 3104515281u);
						continue;
					case 22u:
						arg_261_0 = ((num > 26u) ? 2040316503u : 744694743u);
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
