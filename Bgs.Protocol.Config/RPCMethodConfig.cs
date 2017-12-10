using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Config
{
	[DebuggerNonUserCode]
	public sealed class RPCMethodConfig : IMessage<RPCMethodConfig>, IEquatable<RPCMethodConfig>, IDeepCloneable<RPCMethodConfig>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RPCMethodConfig.__c __9 = new RPCMethodConfig.__c();

			internal RPCMethodConfig cctor>b__94_0()
			{
				return new RPCMethodConfig();
			}
		}

		private static readonly MessageParser<RPCMethodConfig> _parser = new MessageParser<RPCMethodConfig>(new Func<RPCMethodConfig>(RPCMethodConfig.__c.__9.<.cctor>b__94_0));

		public const int ServiceNameFieldNumber = 1;

		private string serviceName_ = "";

		public const int MethodNameFieldNumber = 2;

		private string methodName_ = "";

		public const int FixedCallCostFieldNumber = 3;

		private uint fixedCallCost_;

		public const int FixedPacketSizeFieldNumber = 4;

		private uint fixedPacketSize_;

		public const int VariableMultiplierFieldNumber = 5;

		private float variableMultiplier_;

		public const int MultiplierFieldNumber = 6;

		private float multiplier_;

		public const int RateLimitCountFieldNumber = 7;

		private uint rateLimitCount_;

		public const int RateLimitSecondsFieldNumber = 8;

		private uint rateLimitSeconds_;

		public const int MaxPacketSizeFieldNumber = 9;

		private uint maxPacketSize_;

		public const int MaxEncodedSizeFieldNumber = 10;

		private uint maxEncodedSize_;

		public const int TimeoutFieldNumber = 11;

		private float timeout_;

		public const int CapBalanceFieldNumber = 12;

		private uint capBalance_;

		public const int IncomePerSecondFieldNumber = 13;

		private float incomePerSecond_;

		public const int ServiceHashFieldNumber = 14;

		private uint serviceHash_;

		public const int MethodIdFieldNumber = 15;

		private uint methodId_;

		public static MessageParser<RPCMethodConfig> Parser
		{
			get
			{
				return RPCMethodConfig._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RPCMethodConfig.Descriptor;
			}
		}

		[Obsolete]
		public string ServiceName
		{
			get
			{
				return this.serviceName_;
			}
			set
			{
				this.serviceName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		[Obsolete]
		public string MethodName
		{
			get
			{
				return this.methodName_;
			}
			set
			{
				this.methodName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public uint FixedCallCost
		{
			get
			{
				return this.fixedCallCost_;
			}
			set
			{
				this.fixedCallCost_ = value;
			}
		}

		public uint FixedPacketSize
		{
			get
			{
				return this.fixedPacketSize_;
			}
			set
			{
				this.fixedPacketSize_ = value;
			}
		}

		public float VariableMultiplier
		{
			get
			{
				return this.variableMultiplier_;
			}
			set
			{
				this.variableMultiplier_ = value;
			}
		}

		public float Multiplier
		{
			get
			{
				return this.multiplier_;
			}
			set
			{
				this.multiplier_ = value;
			}
		}

		public uint RateLimitCount
		{
			get
			{
				return this.rateLimitCount_;
			}
			set
			{
				this.rateLimitCount_ = value;
			}
		}

		public uint RateLimitSeconds
		{
			get
			{
				return this.rateLimitSeconds_;
			}
			set
			{
				this.rateLimitSeconds_ = value;
			}
		}

		public uint MaxPacketSize
		{
			get
			{
				return this.maxPacketSize_;
			}
			set
			{
				this.maxPacketSize_ = value;
			}
		}

		public uint MaxEncodedSize
		{
			get
			{
				return this.maxEncodedSize_;
			}
			set
			{
				this.maxEncodedSize_ = value;
			}
		}

		public float Timeout
		{
			get
			{
				return this.timeout_;
			}
			set
			{
				this.timeout_ = value;
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

		public float IncomePerSecond
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

		public uint ServiceHash
		{
			get
			{
				return this.serviceHash_;
			}
			set
			{
				this.serviceHash_ = value;
			}
		}

		public uint MethodId
		{
			get
			{
				return this.methodId_;
			}
			set
			{
				this.methodId_ = value;
			}
		}

		public RPCMethodConfig()
		{
		}

		public RPCMethodConfig(RPCMethodConfig other) : this()
		{
			this.serviceName_ = other.serviceName_;
			this.methodName_ = other.methodName_;
			this.fixedCallCost_ = other.fixedCallCost_;
			this.fixedPacketSize_ = other.fixedPacketSize_;
			this.variableMultiplier_ = other.variableMultiplier_;
			this.multiplier_ = other.multiplier_;
			this.rateLimitCount_ = other.rateLimitCount_;
			this.rateLimitSeconds_ = other.rateLimitSeconds_;
			this.maxPacketSize_ = other.maxPacketSize_;
			this.maxEncodedSize_ = other.maxEncodedSize_;
			this.timeout_ = other.timeout_;
			this.capBalance_ = other.capBalance_;
			this.incomePerSecond_ = other.incomePerSecond_;
			this.serviceHash_ = other.serviceHash_;
			this.methodId_ = other.methodId_;
		}

		public RPCMethodConfig Clone()
		{
			return new RPCMethodConfig(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RPCMethodConfig);
		}

		public bool Equals(RPCMethodConfig other)
		{
			if (other == null)
			{
				goto IL_21A;
			}
			goto IL_33F;
			int arg_299_0;
			while (true)
			{
				IL_294:
				switch ((arg_299_0 ^ 184413560) % 35)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_299_0 = ((this.MethodId != other.MethodId) ? 1940326008 : 1980684143);
					continue;
				case 3:
					arg_299_0 = ((this.FixedCallCost != other.FixedCallCost) ? 1890326019 : 872704766);
					continue;
				case 4:
					arg_299_0 = ((this.Multiplier != other.Multiplier) ? 422330255 : 1283969997);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_21A;
				case 7:
					return false;
				case 8:
					arg_299_0 = ((this.Timeout == other.Timeout) ? 740158499 : 934139434);
					continue;
				case 9:
					arg_299_0 = ((this.MaxPacketSize != other.MaxPacketSize) ? 1212403822 : 1136512711);
					continue;
				case 10:
					return false;
				case 11:
					goto IL_33F;
				case 12:
					arg_299_0 = ((this.RateLimitSeconds != other.RateLimitSeconds) ? 1567693638 : 180891234);
					continue;
				case 13:
					return true;
				case 14:
					arg_299_0 = ((this.CapBalance == other.CapBalance) ? 503052163 : 1801048094);
					continue;
				case 15:
					arg_299_0 = ((this.RateLimitCount != other.RateLimitCount) ? 624643505 : 1214735702);
					continue;
				case 16:
					return false;
				case 17:
					arg_299_0 = ((!RPCMethodConfig.smethod_0(this.ServiceName, other.ServiceName)) ? 1188079298 : 1711522194);
					continue;
				case 19:
					return false;
				case 20:
					return false;
				case 21:
					return false;
				case 22:
					arg_299_0 = ((!RPCMethodConfig.smethod_0(this.MethodName, other.MethodName)) ? 465165515 : 1890224426);
					continue;
				case 23:
					return false;
				case 24:
					return false;
				case 25:
					return false;
				case 26:
					arg_299_0 = ((this.IncomePerSecond != other.IncomePerSecond) ? 1645845321 : 90964425);
					continue;
				case 27:
					return false;
				case 28:
					arg_299_0 = ((this.MaxEncodedSize == other.MaxEncodedSize) ? 484054945 : 1853992316);
					continue;
				case 29:
					return false;
				case 30:
					arg_299_0 = ((this.FixedPacketSize != other.FixedPacketSize) ? 528026848 : 110516560);
					continue;
				case 31:
					return false;
				case 32:
					return false;
				case 33:
					arg_299_0 = ((this.ServiceHash == other.ServiceHash) ? 1337427279 : 1650095437);
					continue;
				case 34:
					arg_299_0 = ((this.VariableMultiplier != other.VariableMultiplier) ? 1797974646 : 2132494485);
					continue;
				}
				break;
			}
			return true;
			IL_21A:
			arg_299_0 = 1219762024;
			goto IL_294;
			IL_33F:
			arg_299_0 = ((other != this) ? 869579258 : 1951734565);
			goto IL_294;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_4D4:
				uint arg_447_0 = 3082297313u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_447_0 ^ 3937406578u)) % 32u)
					{
					case 0u:
						arg_447_0 = ((this.CapBalance == 0u) ? 2987233611u : 4187411203u);
						continue;
					case 1u:
						num ^= this.RateLimitCount.GetHashCode();
						arg_447_0 = (num2 * 1870000508u ^ 1929156685u);
						continue;
					case 2u:
						arg_447_0 = ((this.Timeout != 0f) ? 2711066873u : 3747434162u);
						continue;
					case 3u:
						arg_447_0 = ((this.RateLimitSeconds != 0u) ? 3832522464u : 4112230557u);
						continue;
					case 4u:
						arg_447_0 = ((this.MethodId == 0u) ? 2198232386u : 4086635932u);
						continue;
					case 5u:
						arg_447_0 = ((RPCMethodConfig.smethod_1(this.MethodName) != 0) ? 4190276964u : 3160176276u);
						continue;
					case 6u:
						arg_447_0 = ((this.FixedCallCost == 0u) ? 2676124201u : 4122338587u);
						continue;
					case 7u:
						goto IL_4D4;
					case 8u:
						num ^= RPCMethodConfig.smethod_2(this.ServiceName);
						arg_447_0 = (num2 * 3294136410u ^ 3715061831u);
						continue;
					case 9u:
						num ^= this.FixedCallCost.GetHashCode();
						arg_447_0 = (num2 * 786698523u ^ 2923931450u);
						continue;
					case 10u:
						num ^= this.FixedPacketSize.GetHashCode();
						arg_447_0 = (num2 * 192953940u ^ 3936626797u);
						continue;
					case 11u:
						num ^= this.Timeout.GetHashCode();
						arg_447_0 = (num2 * 383461813u ^ 3932159477u);
						continue;
					case 12u:
						num ^= this.Multiplier.GetHashCode();
						arg_447_0 = (num2 * 3026068847u ^ 3158609982u);
						continue;
					case 13u:
						num ^= this.MaxEncodedSize.GetHashCode();
						arg_447_0 = (num2 * 3577601118u ^ 2319864694u);
						continue;
					case 14u:
						num ^= this.MethodId.GetHashCode();
						arg_447_0 = (num2 * 1335917678u ^ 693339398u);
						continue;
					case 15u:
						arg_447_0 = ((this.MaxPacketSize == 0u) ? 2465697134u : 2302800488u);
						continue;
					case 17u:
						num ^= this.CapBalance.GetHashCode();
						arg_447_0 = (num2 * 4100021989u ^ 2968061278u);
						continue;
					case 18u:
						num ^= this.RateLimitSeconds.GetHashCode();
						arg_447_0 = (num2 * 10074389u ^ 1836580199u);
						continue;
					case 19u:
						arg_447_0 = (((RPCMethodConfig.smethod_1(this.ServiceName) != 0) ? 4036672256u : 3024308557u) ^ num2 * 1982033726u);
						continue;
					case 20u:
						arg_447_0 = ((this.ServiceHash == 0u) ? 2207649942u : 3802113999u);
						continue;
					case 21u:
						num ^= this.IncomePerSecond.GetHashCode();
						arg_447_0 = (num2 * 938139832u ^ 3283931902u);
						continue;
					case 22u:
						num ^= RPCMethodConfig.smethod_2(this.MethodName);
						arg_447_0 = (num2 * 1054385334u ^ 2712616752u);
						continue;
					case 23u:
						arg_447_0 = ((this.VariableMultiplier == 0f) ? 2174743469u : 2604929260u);
						continue;
					case 24u:
						arg_447_0 = ((this.RateLimitCount != 0u) ? 4032401875u : 3472390833u);
						continue;
					case 25u:
						arg_447_0 = ((this.IncomePerSecond == 0f) ? 3691402726u : 2183281511u);
						continue;
					case 26u:
						num ^= this.MaxPacketSize.GetHashCode();
						arg_447_0 = (num2 * 2353561492u ^ 1639000166u);
						continue;
					case 27u:
						arg_447_0 = ((this.FixedPacketSize == 0u) ? 2173371173u : 4290690424u);
						continue;
					case 28u:
						arg_447_0 = ((this.MaxEncodedSize != 0u) ? 4203177439u : 2757584624u);
						continue;
					case 29u:
						num ^= this.ServiceHash.GetHashCode();
						arg_447_0 = (num2 * 46800918u ^ 2447648424u);
						continue;
					case 30u:
						num ^= this.VariableMultiplier.GetHashCode();
						arg_447_0 = (num2 * 234267977u ^ 3383976611u);
						continue;
					case 31u:
						arg_447_0 = ((this.Multiplier == 0f) ? 4287632010u : 3474430206u);
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
			if (RPCMethodConfig.smethod_1(this.ServiceName) != 0)
			{
				goto IL_19C;
			}
			goto IL_5B9;
			uint arg_4F9_0;
			while (true)
			{
				IL_4F4:
				uint num;
				switch ((num = (arg_4F9_0 ^ 2884151322u)) % 41u)
				{
				case 0u:
					output.WriteRawTag(45);
					arg_4F9_0 = (num * 3361635207u ^ 1922580364u);
					continue;
				case 1u:
					output.WriteRawTag(18);
					output.WriteString(this.MethodName);
					arg_4F9_0 = (num * 2609882363u ^ 642811503u);
					continue;
				case 2u:
					output.WriteUInt32(this.RateLimitSeconds);
					arg_4F9_0 = (num * 2745150538u ^ 3810756879u);
					continue;
				case 3u:
					output.WriteRawTag(32);
					output.WriteUInt32(this.FixedPacketSize);
					arg_4F9_0 = (num * 3774119299u ^ 3207935295u);
					continue;
				case 4u:
					arg_4F9_0 = ((this.RateLimitSeconds == 0u) ? 3528529815u : 3483132615u);
					continue;
				case 5u:
					output.WriteFloat(this.Multiplier);
					arg_4F9_0 = (num * 466857150u ^ 1506041959u);
					continue;
				case 6u:
					output.WriteRawTag(112);
					output.WriteUInt32(this.ServiceHash);
					arg_4F9_0 = (num * 547764102u ^ 1097471791u);
					continue;
				case 8u:
					arg_4F9_0 = ((this.Timeout == 0f) ? 2340770204u : 3025394305u);
					continue;
				case 9u:
					output.WriteRawTag(56);
					arg_4F9_0 = (num * 3082440026u ^ 2656129602u);
					continue;
				case 10u:
					output.WriteUInt32(this.FixedCallCost);
					arg_4F9_0 = (num * 2026963474u ^ 1304787663u);
					continue;
				case 11u:
					arg_4F9_0 = ((this.ServiceHash == 0u) ? 2352635853u : 2483320737u);
					continue;
				case 12u:
					output.WriteRawTag(24);
					arg_4F9_0 = (num * 3125315484u ^ 4010179375u);
					continue;
				case 13u:
					arg_4F9_0 = ((this.RateLimitCount != 0u) ? 2984696233u : 3072844194u);
					continue;
				case 14u:
					arg_4F9_0 = ((this.CapBalance == 0u) ? 2366860448u : 2356540585u);
					continue;
				case 15u:
					arg_4F9_0 = ((this.IncomePerSecond != 0f) ? 3820001485u : 2888522784u);
					continue;
				case 16u:
					output.WriteUInt32(this.MaxEncodedSize);
					arg_4F9_0 = (num * 3342363908u ^ 1662015828u);
					continue;
				case 17u:
					output.WriteUInt32(this.MethodId);
					arg_4F9_0 = (num * 3862895317u ^ 4065945582u);
					continue;
				case 18u:
					arg_4F9_0 = ((this.FixedCallCost != 0u) ? 3561345584u : 3053868261u);
					continue;
				case 19u:
					arg_4F9_0 = ((this.MaxPacketSize != 0u) ? 3802397573u : 3333692791u);
					continue;
				case 20u:
					arg_4F9_0 = ((this.FixedPacketSize != 0u) ? 3971580404u : 3924598773u);
					continue;
				case 21u:
					output.WriteRawTag(53);
					arg_4F9_0 = (num * 2183887650u ^ 2700597397u);
					continue;
				case 22u:
					output.WriteRawTag(72);
					output.WriteUInt32(this.MaxPacketSize);
					arg_4F9_0 = (num * 1970891385u ^ 3235201360u);
					continue;
				case 23u:
					arg_4F9_0 = ((this.Multiplier != 0f) ? 3835324213u : 2295479609u);
					continue;
				case 24u:
					output.WriteRawTag(120);
					arg_4F9_0 = (num * 1221027870u ^ 3425799889u);
					continue;
				case 25u:
					output.WriteRawTag(64);
					arg_4F9_0 = (num * 2674284349u ^ 96275439u);
					continue;
				case 26u:
					output.WriteUInt32(this.RateLimitCount);
					arg_4F9_0 = (num * 4155376429u ^ 1595962204u);
					continue;
				case 27u:
					goto IL_19C;
				case 28u:
					output.WriteRawTag(109);
					arg_4F9_0 = (num * 1747518030u ^ 326154487u);
					continue;
				case 29u:
					output.WriteRawTag(80);
					arg_4F9_0 = (num * 2337199568u ^ 3148242829u);
					continue;
				case 30u:
					arg_4F9_0 = ((this.MaxEncodedSize == 0u) ? 3279767688u : 3217059664u);
					continue;
				case 31u:
					arg_4F9_0 = ((this.VariableMultiplier == 0f) ? 3855555639u : 3282687643u);
					continue;
				case 32u:
					output.WriteRawTag(93);
					output.WriteFloat(this.Timeout);
					arg_4F9_0 = (num * 2120380095u ^ 3941222969u);
					continue;
				case 33u:
					output.WriteRawTag(10);
					arg_4F9_0 = (num * 512795664u ^ 2016891545u);
					continue;
				case 34u:
					goto IL_5B9;
				case 35u:
					output.WriteString(this.ServiceName);
					arg_4F9_0 = (num * 1011690890u ^ 4064232930u);
					continue;
				case 36u:
					output.WriteUInt32(this.CapBalance);
					arg_4F9_0 = (num * 1034160297u ^ 634651785u);
					continue;
				case 37u:
					arg_4F9_0 = ((this.MethodId != 0u) ? 3169018404u : 2763489813u);
					continue;
				case 38u:
					output.WriteFloat(this.IncomePerSecond);
					arg_4F9_0 = (num * 1843235934u ^ 660300514u);
					continue;
				case 39u:
					output.WriteRawTag(96);
					arg_4F9_0 = (num * 2704216688u ^ 375660491u);
					continue;
				case 40u:
					output.WriteFloat(this.VariableMultiplier);
					arg_4F9_0 = (num * 2213951421u ^ 2576464954u);
					continue;
				}
				break;
			}
			return;
			IL_19C:
			arg_4F9_0 = 2556489580u;
			goto IL_4F4;
			IL_5B9:
			arg_4F9_0 = ((RPCMethodConfig.smethod_1(this.MethodName) != 0) ? 2680580103u : 3662378496u);
			goto IL_4F4;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_49B:
				uint arg_40E_0 = 3188715502u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_40E_0 ^ 2210734307u)) % 32u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.FixedPacketSize);
						arg_40E_0 = (num2 * 3295031233u ^ 888621127u);
						continue;
					case 1u:
						arg_40E_0 = ((this.Multiplier == 0f) ? 2668620721u : 2809944115u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.ServiceName);
						arg_40E_0 = (num2 * 811112049u ^ 3281296927u);
						continue;
					case 4u:
						arg_40E_0 = ((this.VariableMultiplier == 0f) ? 4242799490u : 2455654329u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.MethodName);
						arg_40E_0 = (num2 * 3088150001u ^ 1309016033u);
						continue;
					case 6u:
						arg_40E_0 = ((this.MaxPacketSize == 0u) ? 2784870212u : 2229202907u);
						continue;
					case 7u:
						arg_40E_0 = ((this.MaxEncodedSize != 0u) ? 3141281502u : 3033021146u);
						continue;
					case 8u:
						arg_40E_0 = ((this.IncomePerSecond != 0f) ? 2606467670u : 3189239167u);
						continue;
					case 9u:
						arg_40E_0 = ((this.CapBalance != 0u) ? 2357388072u : 2504351531u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MethodId);
						arg_40E_0 = (num2 * 253418307u ^ 2784217982u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CapBalance);
						arg_40E_0 = (num2 * 2657169262u ^ 2734045457u);
						continue;
					case 12u:
						arg_40E_0 = ((this.FixedPacketSize == 0u) ? 3281321831u : 3622330307u);
						continue;
					case 13u:
						arg_40E_0 = (((RPCMethodConfig.smethod_1(this.ServiceName) != 0) ? 2892459515u : 3376108135u) ^ num2 * 3329316546u);
						continue;
					case 14u:
						num += 5;
						arg_40E_0 = (num2 * 1449917446u ^ 4188284926u);
						continue;
					case 15u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RateLimitSeconds);
						arg_40E_0 = (num2 * 628935846u ^ 2315996543u);
						continue;
					case 16u:
						num += 5;
						arg_40E_0 = (num2 * 2135311588u ^ 2905158385u);
						continue;
					case 17u:
						arg_40E_0 = ((this.MethodId != 0u) ? 2978172681u : 3624121152u);
						continue;
					case 18u:
						arg_40E_0 = ((this.RateLimitCount == 0u) ? 4083727216u : 2610563836u);
						continue;
					case 19u:
						arg_40E_0 = ((this.RateLimitSeconds == 0u) ? 3170637829u : 2838710348u);
						continue;
					case 20u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceHash);
						arg_40E_0 = (num2 * 581578713u ^ 374235494u);
						continue;
					case 21u:
						num += 5;
						arg_40E_0 = (num2 * 4026931011u ^ 3708624160u);
						continue;
					case 22u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.FixedCallCost);
						arg_40E_0 = (num2 * 1625576255u ^ 3062923717u);
						continue;
					case 23u:
						arg_40E_0 = ((this.FixedCallCost == 0u) ? 3670334447u : 3786997173u);
						continue;
					case 24u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPacketSize);
						arg_40E_0 = (num2 * 3771219273u ^ 787730876u);
						continue;
					case 25u:
						arg_40E_0 = ((this.Timeout == 0f) ? 2998349674u : 3637532045u);
						continue;
					case 26u:
						num += 5;
						arg_40E_0 = (num2 * 712593049u ^ 3149857608u);
						continue;
					case 27u:
						goto IL_49B;
					case 28u:
						arg_40E_0 = ((this.ServiceHash != 0u) ? 2650654487u : 2526283954u);
						continue;
					case 29u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxEncodedSize);
						arg_40E_0 = (num2 * 3343525219u ^ 2317221965u);
						continue;
					case 30u:
						arg_40E_0 = ((RPCMethodConfig.smethod_1(this.MethodName) != 0) ? 4128959750u : 3365251700u);
						continue;
					case 31u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RateLimitCount);
						arg_40E_0 = (num2 * 3261247506u ^ 854392158u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(RPCMethodConfig other)
		{
			if (other == null)
			{
				goto IL_1F8;
			}
			goto IL_48C;
			uint arg_3EC_0;
			while (true)
			{
				IL_3E7:
				uint num;
				switch ((num = (arg_3EC_0 ^ 3865448963u)) % 33u)
				{
				case 0u:
					arg_3EC_0 = ((other.ServiceHash != 0u) ? 2500212125u : 2845083153u);
					continue;
				case 1u:
					this.FixedPacketSize = other.FixedPacketSize;
					arg_3EC_0 = (num * 3684449863u ^ 1978574976u);
					continue;
				case 2u:
					arg_3EC_0 = ((other.RateLimitCount != 0u) ? 2331194866u : 3130562369u);
					continue;
				case 3u:
					this.FixedCallCost = other.FixedCallCost;
					arg_3EC_0 = (num * 1064884203u ^ 1507015799u);
					continue;
				case 4u:
					this.VariableMultiplier = other.VariableMultiplier;
					arg_3EC_0 = (num * 2020249893u ^ 2453453197u);
					continue;
				case 5u:
					arg_3EC_0 = ((other.MaxEncodedSize == 0u) ? 3692652214u : 3936894358u);
					continue;
				case 6u:
					this.RateLimitCount = other.RateLimitCount;
					arg_3EC_0 = (num * 2843935852u ^ 373754605u);
					continue;
				case 7u:
					this.MethodId = other.MethodId;
					arg_3EC_0 = (num * 3516021251u ^ 1967479148u);
					continue;
				case 8u:
					return;
				case 9u:
					this.ServiceHash = other.ServiceHash;
					arg_3EC_0 = (num * 1111169119u ^ 408618419u);
					continue;
				case 10u:
					arg_3EC_0 = ((other.MethodId == 0u) ? 2958162873u : 3686372932u);
					continue;
				case 11u:
					goto IL_48C;
				case 12u:
					arg_3EC_0 = ((other.CapBalance != 0u) ? 2172770124u : 2238684934u);
					continue;
				case 13u:
					arg_3EC_0 = ((other.VariableMultiplier != 0f) ? 4288393565u : 2988466971u);
					continue;
				case 14u:
					arg_3EC_0 = ((other.IncomePerSecond == 0f) ? 3607050081u : 3988192245u);
					continue;
				case 15u:
					this.MaxEncodedSize = other.MaxEncodedSize;
					arg_3EC_0 = (num * 3367294105u ^ 2675749563u);
					continue;
				case 16u:
					this.MethodName = other.MethodName;
					arg_3EC_0 = (num * 2716809932u ^ 1445508710u);
					continue;
				case 18u:
					goto IL_1F8;
				case 19u:
					this.CapBalance = other.CapBalance;
					arg_3EC_0 = (num * 938468046u ^ 3810401428u);
					continue;
				case 20u:
					arg_3EC_0 = ((other.FixedCallCost != 0u) ? 4033319807u : 4103224483u);
					continue;
				case 21u:
					arg_3EC_0 = ((other.FixedPacketSize == 0u) ? 2363335762u : 2420500893u);
					continue;
				case 22u:
					this.MaxPacketSize = other.MaxPacketSize;
					arg_3EC_0 = (num * 1464198670u ^ 1655503240u);
					continue;
				case 23u:
					this.IncomePerSecond = other.IncomePerSecond;
					arg_3EC_0 = (num * 2155894550u ^ 680100421u);
					continue;
				case 24u:
					this.Timeout = other.Timeout;
					arg_3EC_0 = (num * 1274749684u ^ 638464935u);
					continue;
				case 25u:
					this.ServiceName = other.ServiceName;
					arg_3EC_0 = (num * 2923499561u ^ 3399253135u);
					continue;
				case 26u:
					arg_3EC_0 = ((other.Timeout != 0f) ? 3920554416u : 3497041723u);
					continue;
				case 27u:
					arg_3EC_0 = ((other.Multiplier == 0f) ? 3639429922u : 3714719199u);
					continue;
				case 28u:
					arg_3EC_0 = ((other.MaxPacketSize == 0u) ? 2404259482u : 2810699500u);
					continue;
				case 29u:
					arg_3EC_0 = ((RPCMethodConfig.smethod_1(other.MethodName) != 0) ? 2844757279u : 2507379766u);
					continue;
				case 30u:
					this.Multiplier = other.Multiplier;
					arg_3EC_0 = (num * 828800172u ^ 698121458u);
					continue;
				case 31u:
					this.RateLimitSeconds = other.RateLimitSeconds;
					arg_3EC_0 = (num * 14551771u ^ 861447725u);
					continue;
				case 32u:
					arg_3EC_0 = ((other.RateLimitSeconds != 0u) ? 3445270622u : 3417942434u);
					continue;
				}
				break;
			}
			return;
			IL_1F8:
			arg_3EC_0 = 2910388137u;
			goto IL_3E7;
			IL_48C:
			arg_3EC_0 = ((RPCMethodConfig.smethod_1(other.ServiceName) == 0) ? 3116490053u : 3244512953u);
			goto IL_3E7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_696:
				uint num;
				uint arg_59E_0 = ((num = input.ReadTag()) != 0u) ? 412083484u : 1718839264u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_59E_0 ^ 612323707u)) % 55u)
					{
					case 0u:
						this.MaxPacketSize = input.ReadUInt32();
						arg_59E_0 = 1073623282u;
						continue;
					case 1u:
						arg_59E_0 = (((num != 45u) ? 1874332766u : 249776093u) ^ num2 * 2910952289u);
						continue;
					case 2u:
						arg_59E_0 = (num2 * 3188785114u ^ 960787075u);
						continue;
					case 3u:
						goto IL_696;
					case 4u:
						this.MaxEncodedSize = input.ReadUInt32();
						arg_59E_0 = 1092547775u;
						continue;
					case 5u:
						arg_59E_0 = (((num != 64u) ? 3066122621u : 3742221160u) ^ num2 * 1943991981u);
						continue;
					case 6u:
						arg_59E_0 = (num2 * 4246676405u ^ 2522299346u);
						continue;
					case 8u:
						arg_59E_0 = (num2 * 1726530364u ^ 2403605839u);
						continue;
					case 9u:
						input.SkipLastField();
						arg_59E_0 = 1562421727u;
						continue;
					case 10u:
						arg_59E_0 = (((num == 24u) ? 909975940u : 1273616375u) ^ num2 * 3437737042u);
						continue;
					case 11u:
						arg_59E_0 = (num2 * 2839183259u ^ 654220212u);
						continue;
					case 12u:
						this.Multiplier = input.ReadFloat();
						arg_59E_0 = 1430019082u;
						continue;
					case 13u:
						this.VariableMultiplier = input.ReadFloat();
						arg_59E_0 = 833592230u;
						continue;
					case 14u:
						this.ServiceHash = input.ReadUInt32();
						arg_59E_0 = 1562421727u;
						continue;
					case 15u:
						this.IncomePerSecond = input.ReadFloat();
						arg_59E_0 = 1562421727u;
						continue;
					case 16u:
						arg_59E_0 = ((num == 112u) ? 232097734u : 660004738u);
						continue;
					case 17u:
						this.RateLimitSeconds = input.ReadUInt32();
						arg_59E_0 = 372519143u;
						continue;
					case 18u:
						arg_59E_0 = (((num == 56u) ? 3052081304u : 2682846044u) ^ num2 * 647225749u);
						continue;
					case 19u:
						this.ServiceName = input.ReadString();
						arg_59E_0 = 709194717u;
						continue;
					case 20u:
						arg_59E_0 = ((num != 80u) ? 89841618u : 1626988991u);
						continue;
					case 21u:
						arg_59E_0 = (num2 * 354632334u ^ 3824588897u);
						continue;
					case 22u:
						this.FixedPacketSize = input.ReadUInt32();
						arg_59E_0 = 254118530u;
						continue;
					case 23u:
						arg_59E_0 = ((num > 56u) ? 630634720u : 580030312u);
						continue;
					case 24u:
						arg_59E_0 = (num2 * 2767127520u ^ 1017893421u);
						continue;
					case 25u:
						arg_59E_0 = (((num == 120u) ? 1970471568u : 579883472u) ^ num2 * 3426012549u);
						continue;
					case 26u:
						arg_59E_0 = (((num != 93u) ? 145640062u : 1067611525u) ^ num2 * 1711195847u);
						continue;
					case 27u:
						this.MethodId = input.ReadUInt32();
						arg_59E_0 = 1562421727u;
						continue;
					case 28u:
						arg_59E_0 = (num2 * 4147607477u ^ 2081787704u);
						continue;
					case 29u:
						arg_59E_0 = (num2 * 4043435743u ^ 3574450203u);
						continue;
					case 30u:
						arg_59E_0 = (num2 * 2202082633u ^ 60488910u);
						continue;
					case 31u:
						arg_59E_0 = ((num > 109u) ? 1604695433u : 746026755u);
						continue;
					case 32u:
						arg_59E_0 = (num2 * 3465983904u ^ 3391122687u);
						continue;
					case 33u:
						arg_59E_0 = 412083484u;
						continue;
					case 34u:
						arg_59E_0 = (num2 * 75428561u ^ 3837998299u);
						continue;
					case 35u:
						this.Timeout = input.ReadFloat();
						arg_59E_0 = 1562421727u;
						continue;
					case 36u:
						arg_59E_0 = (((num == 32u) ? 4037604629u : 4290623424u) ^ num2 * 1923216338u);
						continue;
					case 37u:
						arg_59E_0 = (num2 * 3058600995u ^ 3573921239u);
						continue;
					case 38u:
						arg_59E_0 = (((num != 18u) ? 1718598033u : 319864765u) ^ num2 * 298092794u);
						continue;
					case 39u:
						arg_59E_0 = (((num == 10u) ? 64198276u : 1947901687u) ^ num2 * 272035960u);
						continue;
					case 40u:
						arg_59E_0 = (num2 * 2918096555u ^ 1994560015u);
						continue;
					case 41u:
						arg_59E_0 = ((num != 53u) ? 517361070u : 2023350433u);
						continue;
					case 42u:
						arg_59E_0 = (num2 * 1106835318u ^ 1313231869u);
						continue;
					case 43u:
						this.RateLimitCount = input.ReadUInt32();
						arg_59E_0 = 1562421727u;
						continue;
					case 44u:
						arg_59E_0 = (num2 * 660239291u ^ 3956136121u);
						continue;
					case 45u:
						this.MethodName = input.ReadString();
						arg_59E_0 = 1562421727u;
						continue;
					case 46u:
						arg_59E_0 = ((num > 45u) ? 1437660217u : 569785377u);
						continue;
					case 47u:
						arg_59E_0 = (((num == 72u) ? 142576350u : 776214128u) ^ num2 * 3057973929u);
						continue;
					case 48u:
						arg_59E_0 = (((num <= 72u) ? 1968421289u : 1610878108u) ^ num2 * 3207283124u);
						continue;
					case 49u:
						arg_59E_0 = (((num != 96u) ? 4065603819u : 2768297895u) ^ num2 * 1631633579u);
						continue;
					case 50u:
						this.FixedCallCost = input.ReadUInt32();
						arg_59E_0 = 75839401u;
						continue;
					case 51u:
						arg_59E_0 = (((num != 109u) ? 2339872997u : 3676273728u) ^ num2 * 3518558709u);
						continue;
					case 52u:
						arg_59E_0 = ((num > 93u) ? 237678934u : 2026461418u);
						continue;
					case 53u:
						this.CapBalance = input.ReadUInt32();
						arg_59E_0 = 1044077776u;
						continue;
					case 54u:
						arg_59E_0 = (((num <= 24u) ? 1236006052u : 645109971u) ^ num2 * 875830576u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
