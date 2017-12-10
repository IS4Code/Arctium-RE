using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountFlagUpdateRequest : IMessage<AccountFlagUpdateRequest>, IEquatable<AccountFlagUpdateRequest>, IDeepCloneable<AccountFlagUpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountFlagUpdateRequest.__c __9 = new AccountFlagUpdateRequest.__c();

			internal AccountFlagUpdateRequest cctor>b__39_0()
			{
				return new AccountFlagUpdateRequest();
			}
		}

		private static readonly MessageParser<AccountFlagUpdateRequest> _parser = new MessageParser<AccountFlagUpdateRequest>(new Func<AccountFlagUpdateRequest>(AccountFlagUpdateRequest.__c.__9.<.cctor>b__39_0));

		public const int AccountFieldNumber = 1;

		private AccountId account_;

		public const int RegionFieldNumber = 2;

		private uint region_;

		public const int FlagFieldNumber = 3;

		private ulong flag_;

		public const int ActiveFieldNumber = 4;

		private bool active_;

		public static MessageParser<AccountFlagUpdateRequest> Parser
		{
			get
			{
				return AccountFlagUpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountFlagUpdateRequest.Descriptor;
			}
		}

		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		public uint Region
		{
			get
			{
				return this.region_;
			}
			set
			{
				this.region_ = value;
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

		public AccountFlagUpdateRequest()
		{
		}

		public AccountFlagUpdateRequest(AccountFlagUpdateRequest other) : this()
		{
			while (true)
			{
				IL_93:
				uint arg_73_0 = 3505851735u;
				while (true)
				{
					uint num;
					switch ((num = (arg_73_0 ^ 2173516452u)) % 5u)
					{
					case 1u:
						this.Account = ((other.account_ != null) ? other.Account.Clone() : null);
						arg_73_0 = 3473187749u;
						continue;
					case 2u:
						goto IL_93;
					case 3u:
						this.active_ = other.active_;
						arg_73_0 = (num * 2164335488u ^ 670741320u);
						continue;
					case 4u:
						this.region_ = other.region_;
						this.flag_ = other.flag_;
						arg_73_0 = (num * 2683136703u ^ 1475538293u);
						continue;
					}
					return;
				}
			}
		}

		public AccountFlagUpdateRequest Clone()
		{
			return new AccountFlagUpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountFlagUpdateRequest);
		}

		public bool Equals(AccountFlagUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_3F;
			}
			goto IL_111;
			int arg_C3_0;
			while (true)
			{
				IL_BE:
				switch ((arg_C3_0 ^ -575957748) % 13)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					arg_C3_0 = (AccountFlagUpdateRequest.smethod_0(this.Account, other.Account) ? -1183915219 : -1966650336);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_C3_0 = ((this.Region == other.Region) ? -1440334036 : -1332305623);
					continue;
				case 7:
					arg_C3_0 = ((this.Active == other.Active) ? -422759943 : -962536120);
					continue;
				case 8:
					goto IL_3F;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					arg_C3_0 = ((this.Flag == other.Flag) ? -475869761 : -2082154748);
					continue;
				case 12:
					goto IL_111;
				}
				break;
			}
			return true;
			IL_3F:
			arg_C3_0 = -844749741;
			goto IL_BE;
			IL_111:
			arg_C3_0 = ((other != this) ? -1288644683 : -862580257);
			goto IL_BE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_15A:
				uint arg_124_0 = 3347535218u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_124_0 ^ 2389512948u)) % 10u)
					{
					case 0u:
						num ^= this.Region.GetHashCode();
						arg_124_0 = (num2 * 3895069765u ^ 429655459u);
						continue;
					case 1u:
						arg_124_0 = ((this.Flag != 0uL) ? 2460463329u : 3587855399u);
						continue;
					case 2u:
						arg_124_0 = (((this.account_ != null) ? 1122654199u : 1855228670u) ^ num2 * 1341820986u);
						continue;
					case 3u:
						num ^= this.Flag.GetHashCode();
						arg_124_0 = (num2 * 2037057175u ^ 2999143492u);
						continue;
					case 4u:
						goto IL_15A;
					case 5u:
						arg_124_0 = (this.Active ? 3280175328u : 3314001495u);
						continue;
					case 6u:
						num ^= this.Active.GetHashCode();
						arg_124_0 = (num2 * 3211034415u ^ 1620253691u);
						continue;
					case 8u:
						arg_124_0 = ((this.Region != 0u) ? 2459698230u : 3162259433u);
						continue;
					case 9u:
						num ^= AccountFlagUpdateRequest.smethod_1(this.Account);
						arg_124_0 = (num2 * 3509559226u ^ 1538539172u);
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
			if (this.account_ != null)
			{
				goto IL_61;
			}
			goto IL_167;
			uint arg_11F_0;
			while (true)
			{
				IL_11A:
				uint num;
				switch ((num = (arg_11F_0 ^ 4072238118u)) % 11u)
				{
				case 0u:
					output.WriteUInt64(this.Flag);
					arg_11F_0 = (num * 1721909423u ^ 4183519380u);
					continue;
				case 1u:
					output.WriteRawTag(24);
					arg_11F_0 = (num * 3309271186u ^ 3045639420u);
					continue;
				case 2u:
					output.WriteRawTag(32);
					arg_11F_0 = (num * 1360824194u ^ 194968474u);
					continue;
				case 3u:
					arg_11F_0 = (this.Active ? 3625600576u : 3789083031u);
					continue;
				case 4u:
					arg_11F_0 = ((this.Flag == 0uL) ? 3915449238u : 4199599028u);
					continue;
				case 5u:
					output.WriteRawTag(16);
					output.WriteUInt32(this.Region);
					arg_11F_0 = (num * 3934054084u ^ 1421309542u);
					continue;
				case 6u:
					goto IL_61;
				case 8u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Account);
					arg_11F_0 = (num * 3999308497u ^ 4008823990u);
					continue;
				case 9u:
					goto IL_167;
				case 10u:
					output.WriteBool(this.Active);
					arg_11F_0 = (num * 3005111827u ^ 3643476935u);
					continue;
				}
				break;
			}
			return;
			IL_61:
			arg_11F_0 = 3297766292u;
			goto IL_11A;
			IL_167:
			arg_11F_0 = ((this.Region != 0u) ? 3849146160u : 2754598590u);
			goto IL_11A;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.account_ != null)
			{
				goto IL_D7;
			}
			goto IL_121;
			uint arg_E1_0;
			while (true)
			{
				IL_DC:
				uint num2;
				switch ((num2 = (arg_E1_0 ^ 1471297560u)) % 9u)
				{
				case 0u:
					goto IL_D7;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.Flag);
					arg_E1_0 = (num2 * 3014395799u ^ 2507740425u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
					arg_E1_0 = (num2 * 3153190719u ^ 684288502u);
					continue;
				case 4u:
					arg_E1_0 = ((!this.Active) ? 1999173132u : 1435531748u);
					continue;
				case 5u:
					num += 2;
					arg_E1_0 = (num2 * 1474407399u ^ 105916520u);
					continue;
				case 6u:
					arg_E1_0 = ((this.Flag != 0uL) ? 1873631420u : 86993333u);
					continue;
				case 7u:
					goto IL_121;
				case 8u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
					arg_E1_0 = (num2 * 2503540444u ^ 2098112528u);
					continue;
				}
				break;
			}
			return num;
			IL_D7:
			arg_E1_0 = 1444135521u;
			goto IL_DC;
			IL_121:
			arg_E1_0 = ((this.Region != 0u) ? 245821963u : 231616091u);
			goto IL_DC;
		}

		public void MergeFrom(AccountFlagUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_AD;
			}
			goto IL_193;
			uint arg_143_0;
			while (true)
			{
				IL_13E:
				uint num;
				switch ((num = (arg_143_0 ^ 3460488113u)) % 13u)
				{
				case 0u:
					this.account_ = new AccountId();
					arg_143_0 = (num * 1653056528u ^ 245461666u);
					continue;
				case 1u:
					this.Active = other.Active;
					arg_143_0 = (num * 1281244352u ^ 3458232405u);
					continue;
				case 2u:
					this.Account.MergeFrom(other.Account);
					arg_143_0 = 2677144922u;
					continue;
				case 3u:
					this.Region = other.Region;
					arg_143_0 = (num * 2381546538u ^ 2046976586u);
					continue;
				case 4u:
					arg_143_0 = ((other.Region != 0u) ? 2621612849u : 3921127242u);
					continue;
				case 5u:
					return;
				case 6u:
					goto IL_AD;
				case 7u:
					goto IL_193;
				case 8u:
					this.Flag = other.Flag;
					arg_143_0 = (num * 1969698741u ^ 3674743327u);
					continue;
				case 9u:
					arg_143_0 = ((other.Flag == 0uL) ? 4091104615u : 4071274281u);
					continue;
				case 10u:
					arg_143_0 = (other.Active ? 3000194138u : 3910235157u);
					continue;
				case 11u:
					arg_143_0 = (((this.account_ == null) ? 1133449653u : 1997096327u) ^ num * 610629025u);
					continue;
				}
				break;
			}
			return;
			IL_AD:
			arg_143_0 = 4134321808u;
			goto IL_13E;
			IL_193:
			arg_143_0 = ((other.account_ != null) ? 3372323236u : 2677144922u);
			goto IL_13E;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_227:
				uint num;
				uint arg_1BF_0 = ((num = input.ReadTag()) == 0u) ? 3797864600u : 3004187737u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1BF_0 ^ 3567355259u)) % 19u)
					{
					case 0u:
						arg_1BF_0 = (num2 * 3452126043u ^ 2518495955u);
						continue;
					case 1u:
						this.Flag = input.ReadUInt64();
						arg_1BF_0 = 3562704770u;
						continue;
					case 2u:
						arg_1BF_0 = (((num != 10u) ? 2248709315u : 4059553708u) ^ num2 * 2777934992u);
						continue;
					case 3u:
						arg_1BF_0 = ((num != 24u) ? 4230458334u : 3454192046u);
						continue;
					case 5u:
						this.Region = input.ReadUInt32();
						arg_1BF_0 = 2563542045u;
						continue;
					case 6u:
						goto IL_227;
					case 7u:
						arg_1BF_0 = (num2 * 3830653517u ^ 2047774680u);
						continue;
					case 8u:
						arg_1BF_0 = (num2 * 4262834686u ^ 687645359u);
						continue;
					case 9u:
						arg_1BF_0 = (((num == 32u) ? 4187410863u : 2998914817u) ^ num2 * 357518869u);
						continue;
					case 10u:
						this.account_ = new AccountId();
						arg_1BF_0 = (num2 * 3926504257u ^ 4002614201u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_1BF_0 = 3017635362u;
						continue;
					case 12u:
						arg_1BF_0 = (((num == 16u) ? 3464219440u : 2764898506u) ^ num2 * 3250693062u);
						continue;
					case 13u:
						arg_1BF_0 = ((this.account_ != null) ? 3452773124u : 3518146310u);
						continue;
					case 14u:
						arg_1BF_0 = ((num > 16u) ? 2444855376u : 2163590724u);
						continue;
					case 15u:
						this.Active = input.ReadBool();
						arg_1BF_0 = 2563542045u;
						continue;
					case 16u:
						arg_1BF_0 = 3004187737u;
						continue;
					case 17u:
						arg_1BF_0 = (num2 * 400908435u ^ 2093818086u);
						continue;
					case 18u:
						input.ReadMessage(this.account_);
						arg_1BF_0 = 2289824476u;
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
