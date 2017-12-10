using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class Identity : IMessage<Identity>, IEquatable<Identity>, IDeepCloneable<Identity>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Identity.__c __9 = new Identity.__c();

			internal Identity cctor>b__34_0()
			{
				return new Identity();
			}
		}

		private static readonly MessageParser<Identity> _parser = new MessageParser<Identity>(new Func<Identity>(Identity.__c.__9.<.cctor>b__34_0));

		public const int AccountFieldNumber = 1;

		private AccountId account_;

		public const int GameAccountFieldNumber = 2;

		private GameAccountHandle gameAccount_;

		public const int ProcessFieldNumber = 3;

		private ProcessId process_;

		public static MessageParser<Identity> Parser
		{
			get
			{
				return Identity._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Identity.Descriptor;
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

		public ProcessId Process
		{
			get
			{
				return this.process_;
			}
			set
			{
				this.process_ = value;
			}
		}

		public Identity()
		{
		}

		public Identity(Identity other) : this()
		{
			while (true)
			{
				IL_87:
				int arg_6D_0 = -2136154793;
				while (true)
				{
					switch ((arg_6D_0 ^ -688484900) % 4)
					{
					case 0:
						goto IL_87;
					case 1:
						this.GameAccount = ((other.gameAccount_ != null) ? other.GameAccount.Clone() : null);
						this.Process = ((other.process_ != null) ? other.Process.Clone() : null);
						arg_6D_0 = -272762666;
						continue;
					case 3:
						this.Account = ((other.account_ != null) ? other.Account.Clone() : null);
						arg_6D_0 = -1163524115;
						continue;
					}
					return;
				}
			}
		}

		public Identity Clone()
		{
			return new Identity(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Identity);
		}

		public bool Equals(Identity other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ -2015358824) % 11)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_A9_0 = ((!Identity.smethod_0(this.Account, other.Account)) ? -2045615498 : -732525157);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_A9_0 = (Identity.smethod_0(this.Process, other.Process) ? -1926700879 : -570978331);
					continue;
				case 8:
					arg_A9_0 = ((!Identity.smethod_0(this.GameAccount, other.GameAccount)) ? -1963452861 : -392442474);
					continue;
				case 9:
					goto IL_EF;
				case 10:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_A9_0 = -1208722666;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other != this) ? -1020240109 : -972073099);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.account_ != null)
			{
				goto IL_73;
			}
			goto IL_D5;
			uint arg_9E_0;
			while (true)
			{
				IL_99:
				uint num2;
				switch ((num2 = (arg_9E_0 ^ 755699365u)) % 7u)
				{
				case 0u:
					arg_9E_0 = ((this.process_ == null) ? 1185614062u : 1573268212u);
					continue;
				case 2u:
					goto IL_D5;
				case 3u:
					goto IL_73;
				case 4u:
					num ^= Identity.smethod_1(this.GameAccount);
					arg_9E_0 = (num2 * 1504218401u ^ 4037256661u);
					continue;
				case 5u:
					num ^= Identity.smethod_1(this.Process);
					arg_9E_0 = (num2 * 4177593427u ^ 4073587373u);
					continue;
				case 6u:
					num ^= Identity.smethod_1(this.Account);
					arg_9E_0 = (num2 * 2838774171u ^ 3122355491u);
					continue;
				}
				break;
			}
			return num;
			IL_73:
			arg_9E_0 = 1951983386u;
			goto IL_99;
			IL_D5:
			arg_9E_0 = ((this.gameAccount_ == null) ? 1320755070u : 160443630u);
			goto IL_99;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.account_ != null)
			{
				goto IL_40;
			}
			goto IL_FB;
			uint arg_C0_0;
			while (true)
			{
				IL_BB:
				uint num;
				switch ((num = (arg_C0_0 ^ 2027548793u)) % 8u)
				{
				case 0u:
					output.WriteRawTag(26);
					arg_C0_0 = (num * 2213692137u ^ 2677396187u);
					continue;
				case 1u:
					output.WriteRawTag(18);
					output.WriteMessage(this.GameAccount);
					arg_C0_0 = (num * 1847217930u ^ 1043792942u);
					continue;
				case 2u:
					output.WriteMessage(this.Process);
					arg_C0_0 = (num * 687141282u ^ 3090639262u);
					continue;
				case 4u:
					goto IL_FB;
				case 5u:
					arg_C0_0 = ((this.process_ != null) ? 236065369u : 1630095322u);
					continue;
				case 6u:
					goto IL_40;
				case 7u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Account);
					arg_C0_0 = (num * 139845040u ^ 2357367005u);
					continue;
				}
				break;
			}
			return;
			IL_40:
			arg_C0_0 = 1877036022u;
			goto IL_BB;
			IL_FB:
			arg_C0_0 = ((this.gameAccount_ != null) ? 112798208u : 1061870484u);
			goto IL_BB;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_104:
				uint arg_D8_0 = 1236654924u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_D8_0 ^ 1964195679u)) % 8u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
						arg_D8_0 = (num2 * 461019566u ^ 1778512011u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
						arg_D8_0 = (num2 * 3618175669u ^ 2629333020u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Process);
						arg_D8_0 = (num2 * 1439381249u ^ 3870770568u);
						continue;
					case 3u:
						arg_D8_0 = (((this.account_ != null) ? 54982951u : 1731874435u) ^ num2 * 1363038072u);
						continue;
					case 4u:
						arg_D8_0 = ((this.gameAccount_ != null) ? 1441083502u : 726591417u);
						continue;
					case 6u:
						arg_D8_0 = ((this.process_ != null) ? 1093706749u : 1073164074u);
						continue;
					case 7u:
						goto IL_104;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Identity other)
		{
			if (other == null)
			{
				goto IL_EA;
			}
			goto IL_1E5;
			uint arg_18D_0;
			while (true)
			{
				IL_188:
				uint num;
				switch ((num = (arg_18D_0 ^ 268859054u)) % 15u)
				{
				case 0u:
					this.process_ = new ProcessId();
					arg_18D_0 = (num * 3831907367u ^ 2722688819u);
					continue;
				case 1u:
					this.account_ = new AccountId();
					arg_18D_0 = (num * 3949577039u ^ 2252433245u);
					continue;
				case 2u:
					this.Process.MergeFrom(other.Process);
					arg_18D_0 = 1949670003u;
					continue;
				case 3u:
					arg_18D_0 = (((this.process_ != null) ? 1753107231u : 573597476u) ^ num * 895975477u);
					continue;
				case 4u:
					goto IL_1E5;
				case 5u:
					arg_18D_0 = ((other.process_ != null) ? 632898099u : 1949670003u);
					continue;
				case 6u:
					goto IL_EA;
				case 7u:
					arg_18D_0 = ((other.gameAccount_ == null) ? 163248446u : 516365208u);
					continue;
				case 9u:
					return;
				case 10u:
					arg_18D_0 = (((this.gameAccount_ != null) ? 2417037975u : 3468617793u) ^ num * 718598460u);
					continue;
				case 11u:
					this.GameAccount.MergeFrom(other.GameAccount);
					arg_18D_0 = 163248446u;
					continue;
				case 12u:
					this.Account.MergeFrom(other.Account);
					arg_18D_0 = 661219109u;
					continue;
				case 13u:
					arg_18D_0 = (((this.account_ == null) ? 554581499u : 2083116336u) ^ num * 3670622239u);
					continue;
				case 14u:
					this.gameAccount_ = new GameAccountHandle();
					arg_18D_0 = (num * 3470925735u ^ 629812078u);
					continue;
				}
				break;
			}
			return;
			IL_EA:
			arg_18D_0 = 195646830u;
			goto IL_188;
			IL_1E5:
			arg_18D_0 = ((other.account_ != null) ? 1505532313u : 661219109u);
			goto IL_188;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_22C:
				uint num;
				uint arg_1C8_0 = ((num = input.ReadTag()) == 0u) ? 2588361256u : 3118244112u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1C8_0 ^ 3075276928u)) % 18u)
					{
					case 0u:
						arg_1C8_0 = ((this.gameAccount_ != null) ? 3466711917u : 4224067106u);
						continue;
					case 1u:
						input.ReadMessage(this.gameAccount_);
						arg_1C8_0 = 3143067899u;
						continue;
					case 2u:
						arg_1C8_0 = ((this.account_ == null) ? 3250739740u : 2762324184u);
						continue;
					case 3u:
						input.ReadMessage(this.process_);
						arg_1C8_0 = 4212170719u;
						continue;
					case 4u:
						this.gameAccount_ = new GameAccountHandle();
						arg_1C8_0 = (num2 * 3359293953u ^ 3726916047u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_1C8_0 = (num2 * 4051944129u ^ 4251560506u);
						continue;
					case 6u:
						this.account_ = new AccountId();
						arg_1C8_0 = (num2 * 2235358791u ^ 3728789916u);
						continue;
					case 7u:
						arg_1C8_0 = 3118244112u;
						continue;
					case 8u:
						arg_1C8_0 = ((num != 10u) ? 3152485406u : 3337708560u);
						continue;
					case 9u:
						goto IL_22C;
					case 10u:
						input.ReadMessage(this.account_);
						arg_1C8_0 = 3933861599u;
						continue;
					case 11u:
						arg_1C8_0 = (((num == 26u) ? 3395622382u : 4048389913u) ^ num2 * 1323166980u);
						continue;
					case 12u:
						arg_1C8_0 = ((this.process_ == null) ? 3267536183u : 2828445625u);
						continue;
					case 13u:
						arg_1C8_0 = (num2 * 4071273670u ^ 1854002429u);
						continue;
					case 14u:
						arg_1C8_0 = (((num != 18u) ? 1527373527u : 1477567392u) ^ num2 * 866403204u);
						continue;
					case 15u:
						arg_1C8_0 = (num2 * 3552554176u ^ 1613825183u);
						continue;
					case 17u:
						this.process_ = new ProcessId();
						arg_1C8_0 = (num2 * 3559321122u ^ 3872949239u);
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
