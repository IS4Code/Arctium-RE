using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeExternalResult : IMessage<ChallengeExternalResult>, IEquatable<ChallengeExternalResult>, IDeepCloneable<ChallengeExternalResult>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeExternalResult.__c __9 = new ChallengeExternalResult.__c();

			internal ChallengeExternalResult cctor>b__29_0()
			{
				return new ChallengeExternalResult();
			}
		}

		private static readonly MessageParser<ChallengeExternalResult> _parser = new MessageParser<ChallengeExternalResult>(new Func<ChallengeExternalResult>(ChallengeExternalResult.__c.__9.<.cctor>b__29_0));

		public const int RequestTokenFieldNumber = 1;

		private string requestToken_ = "";

		public const int PassedFieldNumber = 2;

		private bool passed_;

		public static MessageParser<ChallengeExternalResult> Parser
		{
			get
			{
				return ChallengeExternalResult._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeExternalResult.Descriptor;
			}
		}

		public string RequestToken
		{
			get
			{
				return this.requestToken_;
			}
			set
			{
				this.requestToken_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool Passed
		{
			get
			{
				return this.passed_;
			}
			set
			{
				this.passed_ = value;
			}
		}

		public ChallengeExternalResult()
		{
		}

		public ChallengeExternalResult(ChallengeExternalResult other) : this()
		{
			this.requestToken_ = other.requestToken_;
			this.passed_ = other.passed_;
		}

		public ChallengeExternalResult Clone()
		{
			return new ChallengeExternalResult(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeExternalResult);
		}

		public bool Equals(ChallengeExternalResult other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1736779809) % 9)
				{
				case 0:
					arg_72_0 = ((this.Passed == other.Passed) ? 631195009 : 100968951);
					continue;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_72_0 = (ChallengeExternalResult.smethod_0(this.RequestToken, other.RequestToken) ? 1517230309 : 1772593890);
					continue;
				case 5:
					goto IL_15;
				case 6:
					goto IL_B0;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1551251772;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 414656068 : 100006971);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_BA:
				uint arg_96_0 = 1867990815u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_96_0 ^ 1209707900u)) % 6u)
					{
					case 0u:
						goto IL_BA;
					case 1u:
						num ^= ChallengeExternalResult.smethod_2(this.RequestToken);
						arg_96_0 = (num2 * 3491061128u ^ 301417564u);
						continue;
					case 2u:
						arg_96_0 = ((!this.Passed) ? 27374356u : 1953295109u);
						continue;
					case 3u:
						num ^= this.Passed.GetHashCode();
						arg_96_0 = (num2 * 110587716u ^ 3204029488u);
						continue;
					case 5u:
						arg_96_0 = (((ChallengeExternalResult.smethod_1(this.RequestToken) == 0) ? 434395157u : 1635059252u) ^ num2 * 426999243u);
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
			if (ChallengeExternalResult.smethod_1(this.RequestToken) != 0)
			{
				goto IL_83;
			}
			goto IL_C4;
			uint arg_8D_0;
			while (true)
			{
				IL_88:
				uint num;
				switch ((num = (arg_8D_0 ^ 3700803820u)) % 7u)
				{
				case 0u:
					goto IL_83;
				case 1u:
					goto IL_C4;
				case 2u:
					output.WriteRawTag(10);
					arg_8D_0 = (num * 2630738541u ^ 3729658465u);
					continue;
				case 3u:
					output.WriteBool(this.Passed);
					arg_8D_0 = (num * 4229154226u ^ 3864909939u);
					continue;
				case 4u:
					output.WriteString(this.RequestToken);
					arg_8D_0 = (num * 1021619704u ^ 2435020358u);
					continue;
				case 5u:
					output.WriteRawTag(16);
					arg_8D_0 = (num * 2739174128u ^ 1063777147u);
					continue;
				}
				break;
			}
			return;
			IL_83:
			arg_8D_0 = 3819463126u;
			goto IL_88;
			IL_C4:
			arg_8D_0 = ((!this.Passed) ? 3324826797u : 2284290451u);
			goto IL_88;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (ChallengeExternalResult.smethod_1(this.RequestToken) != 0)
			{
				goto IL_50;
			}
			goto IL_86;
			uint arg_5A_0;
			while (true)
			{
				IL_55:
				uint num2;
				switch ((num2 = (arg_5A_0 ^ 2612068117u)) % 5u)
				{
				case 0u:
					goto IL_50;
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.RequestToken);
					arg_5A_0 = (num2 * 150773621u ^ 944416126u);
					continue;
				case 3u:
					num += 2;
					arg_5A_0 = (num2 * 907853986u ^ 677217055u);
					continue;
				case 4u:
					goto IL_86;
				}
				break;
			}
			return num;
			IL_50:
			arg_5A_0 = 3328291943u;
			goto IL_55;
			IL_86:
			arg_5A_0 = (this.Passed ? 4151618712u : 3691977765u);
			goto IL_55;
		}

		public void MergeFrom(ChallengeExternalResult other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 2047171486u)) % 7u)
				{
				case 0u:
					goto IL_AD;
				case 1u:
					arg_76_0 = (other.Passed ? 1672600061u : 1172567497u);
					continue;
				case 2u:
					this.RequestToken = other.RequestToken;
					arg_76_0 = (num * 3515561671u ^ 1258290283u);
					continue;
				case 3u:
					this.Passed = other.Passed;
					arg_76_0 = (num * 532902980u ^ 2828241797u);
					continue;
				case 5u:
					goto IL_15;
				case 6u:
					return;
				}
				break;
			}
			return;
			IL_15:
			arg_76_0 = 250113534u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((ChallengeExternalResult.smethod_1(other.RequestToken) == 0) ? 1171983891u : 178059862u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_104:
				uint num;
				uint arg_C0_0 = ((num = input.ReadTag()) != 0u) ? 3794272228u : 3471296918u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C0_0 ^ 3710357137u)) % 10u)
					{
					case 0u:
						arg_C0_0 = (num2 * 2335262239u ^ 1685367487u);
						continue;
					case 1u:
						this.RequestToken = input.ReadString();
						arg_C0_0 = 4170483315u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_C0_0 = (num2 * 3540358583u ^ 2490817279u);
						continue;
					case 3u:
						arg_C0_0 = ((num != 10u) ? 2528659538u : 2547324822u);
						continue;
					case 4u:
						goto IL_104;
					case 5u:
						this.Passed = input.ReadBool();
						arg_C0_0 = 2317972961u;
						continue;
					case 6u:
						arg_C0_0 = (num2 * 2981683289u ^ 2122691441u);
						continue;
					case 7u:
						arg_C0_0 = (((num == 16u) ? 2960526226u : 2876125189u) ^ num2 * 90949922u);
						continue;
					case 8u:
						arg_C0_0 = 3794272228u;
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
