using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Config
{
	[DebuggerNonUserCode]
	public sealed class RPCMeterConfig : IMessage<RPCMeterConfig>, IEquatable<RPCMeterConfig>, IDeepCloneable<RPCMeterConfig>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RPCMeterConfig.__c __9 = new RPCMeterConfig.__c();

			internal RPCMeterConfig cctor>b__44_0()
			{
				return new RPCMeterConfig();
			}
		}

		private static readonly MessageParser<RPCMeterConfig> _parser = new MessageParser<RPCMeterConfig>(new Func<RPCMeterConfig>(RPCMeterConfig.__c.__9.<.cctor>b__44_0));

		public const int MethodFieldNumber = 1;

		private static readonly FieldCodec<RPCMethodConfig> _repeated_method_codec;

		private readonly RepeatedField<RPCMethodConfig> method_ = new RepeatedField<RPCMethodConfig>();

		public const int IncomePerSecondFieldNumber = 2;

		private uint incomePerSecond_;

		public const int InitialBalanceFieldNumber = 3;

		private uint initialBalance_;

		public const int CapBalanceFieldNumber = 4;

		private uint capBalance_;

		public const int StartupPeriodFieldNumber = 5;

		private float startupPeriod_;

		public static MessageParser<RPCMeterConfig> Parser
		{
			get
			{
				return RPCMeterConfig._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RPCMeterConfig.Descriptor;
			}
		}

		public RepeatedField<RPCMethodConfig> Method
		{
			get
			{
				return this.method_;
			}
		}

		public uint IncomePerSecond
		{
			get
			{
				return this.incomePerSecond_;
			}
			set
			{
				this.incomePerSecond_ = value;
			}
		}

		public uint InitialBalance
		{
			get
			{
				return this.initialBalance_;
			}
			set
			{
				this.initialBalance_ = value;
			}
		}

		public uint CapBalance
		{
			get
			{
				return this.capBalance_;
			}
			set
			{
				this.capBalance_ = value;
			}
		}

		public float StartupPeriod
		{
			get
			{
				return this.startupPeriod_;
			}
			set
			{
				this.startupPeriod_ = value;
			}
		}

		public RPCMeterConfig()
		{
		}

		public RPCMeterConfig(RPCMeterConfig other) : this()
		{
			while (true)
			{
				IL_7A:
				uint arg_5E_0 = 2578826414u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5E_0 ^ 3722312116u)) % 4u)
					{
					case 0u:
						goto IL_7A;
					case 2u:
						this.method_ = other.method_.Clone();
						arg_5E_0 = (num * 2891572958u ^ 137931275u);
						continue;
					case 3u:
						this.incomePerSecond_ = other.incomePerSecond_;
						this.initialBalance_ = other.initialBalance_;
						this.capBalance_ = other.capBalance_;
						arg_5E_0 = (num * 854752895u ^ 1583635436u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.startupPeriod_ = other.startupPeriod_;
		}

		public RPCMeterConfig Clone()
		{
			return new RPCMeterConfig(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RPCMeterConfig);
		}

		public bool Equals(RPCMeterConfig other)
		{
			if (other == null)
			{
				goto IL_98;
			}
			goto IL_146;
			int arg_F0_0;
			while (true)
			{
				IL_EB:
				switch ((arg_F0_0 ^ 1688334249) % 15)
				{
				case 0:
					arg_F0_0 = ((this.InitialBalance == other.InitialBalance) ? 390098876 : 999748883);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_F0_0 = ((this.StartupPeriod == other.StartupPeriod) ? 10505267 : 1032044307);
					continue;
				case 5:
					goto IL_98;
				case 6:
					arg_F0_0 = ((this.IncomePerSecond == other.IncomePerSecond) ? 2038216547 : 644256818);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_F0_0 = ((this.CapBalance != other.CapBalance) ? 302230513 : 116988619);
					continue;
				case 10:
					goto IL_146;
				case 11:
					return true;
				case 12:
					arg_F0_0 = (this.method_.Equals(other.method_) ? 301108216 : 791381753);
					continue;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_98:
			arg_F0_0 = 496386684;
			goto IL_EB;
			IL_146:
			arg_F0_0 = ((other == this) ? 1737799138 : 394189334);
			goto IL_EB;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ RPCMeterConfig.smethod_0(this.method_);
			while (true)
			{
				IL_16A:
				uint arg_135_0 = 1052430560u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_135_0 ^ 1163529799u)) % 10u)
					{
					case 1u:
						arg_135_0 = (((this.IncomePerSecond == 0u) ? 1951839132u : 1962415719u) ^ num2 * 2882211435u);
						continue;
					case 2u:
						arg_135_0 = ((this.StartupPeriod == 0f) ? 1558069511u : 1801060398u);
						continue;
					case 3u:
						arg_135_0 = ((this.CapBalance == 0u) ? 963726355u : 1156117777u);
						continue;
					case 4u:
						goto IL_16A;
					case 5u:
						num ^= this.StartupPeriod.GetHashCode();
						arg_135_0 = (num2 * 2635843949u ^ 3619148466u);
						continue;
					case 6u:
						num ^= this.CapBalance.GetHashCode();
						arg_135_0 = (num2 * 1075804795u ^ 895414849u);
						continue;
					case 7u:
						num ^= this.IncomePerSecond.GetHashCode();
						arg_135_0 = (num2 * 3795388469u ^ 4124546112u);
						continue;
					case 8u:
						arg_135_0 = ((this.InitialBalance != 0u) ? 2064891506u : 167788752u);
						continue;
					case 9u:
						num ^= this.InitialBalance.GetHashCode();
						arg_135_0 = (num2 * 4294609835u ^ 1990671031u);
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
			this.method_.WriteTo(output, RPCMeterConfig._repeated_method_codec);
			while (true)
			{
				IL_1A3:
				uint arg_166_0 = 1333377318u;
				while (true)
				{
					uint num;
					switch ((num = (arg_166_0 ^ 597997360u)) % 12u)
					{
					case 0u:
						arg_166_0 = ((this.InitialBalance == 0u) ? 499486653u : 1310726572u);
						continue;
					case 1u:
						output.WriteRawTag(32);
						arg_166_0 = (num * 522113231u ^ 3889755070u);
						continue;
					case 2u:
						arg_166_0 = (((this.IncomePerSecond != 0u) ? 1765629824u : 2067176046u) ^ num * 2723197415u);
						continue;
					case 3u:
						goto IL_1A3;
					case 4u:
						output.WriteRawTag(24);
						output.WriteUInt32(this.InitialBalance);
						arg_166_0 = (num * 3488937359u ^ 2771212953u);
						continue;
					case 5u:
						arg_166_0 = ((this.CapBalance != 0u) ? 1743189125u : 1086415274u);
						continue;
					case 6u:
						output.WriteRawTag(16);
						output.WriteUInt32(this.IncomePerSecond);
						arg_166_0 = (num * 3661362704u ^ 2577687316u);
						continue;
					case 8u:
						output.WriteFloat(this.StartupPeriod);
						arg_166_0 = (num * 1840586503u ^ 1727679927u);
						continue;
					case 9u:
						output.WriteUInt32(this.CapBalance);
						arg_166_0 = (num * 1445661512u ^ 3447266114u);
						continue;
					case 10u:
						arg_166_0 = ((this.StartupPeriod != 0f) ? 1575057383u : 827179671u);
						continue;
					case 11u:
						output.WriteRawTag(45);
						arg_166_0 = (num * 4136678150u ^ 3618726618u);
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
				IL_175:
				uint arg_13C_0 = 2016739239u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_13C_0 ^ 725896283u)) % 11u)
					{
					case 0u:
						arg_13C_0 = ((this.StartupPeriod == 0f) ? 402995745u : 596491352u);
						continue;
					case 1u:
						num += this.method_.CalculateSize(RPCMeterConfig._repeated_method_codec);
						arg_13C_0 = (num2 * 4135867793u ^ 3835198383u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.InitialBalance);
						arg_13C_0 = (num2 * 2232036700u ^ 1952523884u);
						continue;
					case 3u:
						arg_13C_0 = (((this.IncomePerSecond != 0u) ? 4119260048u : 3486124219u) ^ num2 * 1864114193u);
						continue;
					case 4u:
						arg_13C_0 = ((this.InitialBalance == 0u) ? 1592555804u : 1833719263u);
						continue;
					case 5u:
						goto IL_175;
					case 6u:
						arg_13C_0 = ((this.CapBalance != 0u) ? 1983416091u : 1852139680u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.IncomePerSecond);
						arg_13C_0 = (num2 * 1967391490u ^ 1218354549u);
						continue;
					case 9u:
						num += 5;
						arg_13C_0 = (num2 * 4037485016u ^ 3426934697u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CapBalance);
						arg_13C_0 = (num2 * 817728135u ^ 3472541280u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(RPCMeterConfig other)
		{
			if (other == null)
			{
				goto IL_26;
			}
			goto IL_158;
			uint arg_11B_0;
			while (true)
			{
				IL_116:
				uint num;
				switch ((num = (arg_11B_0 ^ 496466141u)) % 12u)
				{
				case 0u:
					this.CapBalance = other.CapBalance;
					arg_11B_0 = (num * 1230496058u ^ 851076195u);
					continue;
				case 1u:
					arg_11B_0 = ((other.InitialBalance != 0u) ? 425567942u : 303095906u);
					continue;
				case 2u:
					arg_11B_0 = ((other.StartupPeriod == 0f) ? 423546011u : 254282629u);
					continue;
				case 3u:
					return;
				case 4u:
					this.StartupPeriod = other.StartupPeriod;
					arg_11B_0 = (num * 1375253155u ^ 3127340435u);
					continue;
				case 5u:
					arg_11B_0 = (((other.IncomePerSecond == 0u) ? 2413130625u : 2251114096u) ^ num * 3803037813u);
					continue;
				case 7u:
					arg_11B_0 = ((other.CapBalance == 0u) ? 2134895683u : 1795069837u);
					continue;
				case 8u:
					this.IncomePerSecond = other.IncomePerSecond;
					arg_11B_0 = (num * 1591333419u ^ 405411964u);
					continue;
				case 9u:
					goto IL_158;
				case 10u:
					goto IL_26;
				case 11u:
					this.InitialBalance = other.InitialBalance;
					arg_11B_0 = (num * 653589978u ^ 1475162524u);
					continue;
				}
				break;
			}
			return;
			IL_26:
			arg_11B_0 = 141638786u;
			goto IL_116;
			IL_158:
			this.method_.Add(other.method_);
			arg_11B_0 = 1223588268u;
			goto IL_116;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_259:
				uint num;
				uint arg_1E9_0 = ((num = input.ReadTag()) == 0u) ? 3385299684u : 3871052133u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1E9_0 ^ 3295332274u)) % 21u)
					{
					case 0u:
						this.InitialBalance = input.ReadUInt32();
						arg_1E9_0 = 3822153306u;
						continue;
					case 1u:
						arg_1E9_0 = (num2 * 49434523u ^ 2688118764u);
						continue;
					case 2u:
						arg_1E9_0 = ((num != 24u) ? 3758006521u : 3225586364u);
						continue;
					case 3u:
						arg_1E9_0 = (((num == 10u) ? 3415969199u : 2343944072u) ^ num2 * 2696633915u);
						continue;
					case 4u:
						arg_1E9_0 = (((num != 16u) ? 1858706996u : 117608996u) ^ num2 * 2029877209u);
						continue;
					case 5u:
						arg_1E9_0 = (((num != 32u) ? 968007412u : 434497921u) ^ num2 * 3064593234u);
						continue;
					case 6u:
						arg_1E9_0 = (num2 * 764588774u ^ 1328886873u);
						continue;
					case 7u:
						this.StartupPeriod = input.ReadFloat();
						arg_1E9_0 = 2648807253u;
						continue;
					case 8u:
						goto IL_259;
					case 9u:
						input.SkipLastField();
						arg_1E9_0 = 3662182736u;
						continue;
					case 10u:
						arg_1E9_0 = ((num > 16u) ? 3549269606u : 3067280891u);
						continue;
					case 11u:
						arg_1E9_0 = (num2 * 311052518u ^ 400589325u);
						continue;
					case 12u:
						arg_1E9_0 = (num2 * 3240426239u ^ 966482253u);
						continue;
					case 13u:
						arg_1E9_0 = (((num != 45u) ? 2035394971u : 211302189u) ^ num2 * 905176672u);
						continue;
					case 14u:
						arg_1E9_0 = (num2 * 3943773180u ^ 3748566655u);
						continue;
					case 16u:
						this.method_.AddEntriesFrom(input, RPCMeterConfig._repeated_method_codec);
						arg_1E9_0 = 2814231224u;
						continue;
					case 17u:
						this.CapBalance = input.ReadUInt32();
						arg_1E9_0 = 4218496905u;
						continue;
					case 18u:
						arg_1E9_0 = 3871052133u;
						continue;
					case 19u:
						this.IncomePerSecond = input.ReadUInt32();
						arg_1E9_0 = 2450525206u;
						continue;
					case 20u:
						arg_1E9_0 = (num2 * 1535555739u ^ 2917837403u);
						continue;
					}
					return;
				}
			}
		}

		static RPCMeterConfig()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 2868421256u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2373402144u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 2u:
						RPCMeterConfig._repeated_method_codec = FieldCodec.ForMessage<RPCMethodConfig>(10u, RPCMethodConfig.Parser);
						arg_3F_0 = (num * 334432441u ^ 1666815779u);
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
