using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeAnsweredRequest : IMessage<ChallengeAnsweredRequest>, IEquatable<ChallengeAnsweredRequest>, IDeepCloneable<ChallengeAnsweredRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeAnsweredRequest.__c __9 = new ChallengeAnsweredRequest.__c();

			internal ChallengeAnsweredRequest cctor>b__34_0()
			{
				return new ChallengeAnsweredRequest();
			}
		}

		private static readonly MessageParser<ChallengeAnsweredRequest> _parser = new MessageParser<ChallengeAnsweredRequest>(new Func<ChallengeAnsweredRequest>(ChallengeAnsweredRequest.__c.__9.<.cctor>b__34_0));

		public const int AnswerFieldNumber = 1;

		private string answer_ = "";

		public const int DataFieldNumber = 2;

		private ByteString data_ = ByteString.Empty;

		public const int IdFieldNumber = 3;

		private uint id_;

		public static MessageParser<ChallengeAnsweredRequest> Parser
		{
			get
			{
				return ChallengeAnsweredRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeAnsweredRequest.Descriptor;
			}
		}

		public string Answer
		{
			get
			{
				return this.answer_;
			}
			set
			{
				this.answer_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public uint Id
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

		public ChallengeAnsweredRequest()
		{
		}

		public ChallengeAnsweredRequest(ChallengeAnsweredRequest other) : this()
		{
			this.answer_ = other.answer_;
			this.data_ = other.data_;
			this.id_ = other.id_;
		}

		public ChallengeAnsweredRequest Clone()
		{
			return new ChallengeAnsweredRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeAnsweredRequest);
		}

		public bool Equals(ChallengeAnsweredRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ 2013607477) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_A1_0 = ((this.Id == other.Id) ? 1334747664 : 1591618882);
					continue;
				case 3:
					return false;
				case 4:
					arg_A1_0 = ((!ChallengeAnsweredRequest.smethod_0(this.Answer, other.Answer)) ? 604173205 : 1384555402);
					continue;
				case 6:
					goto IL_E7;
				case 7:
					return false;
				case 8:
					return true;
				case 9:
					arg_A1_0 = ((!(this.Data != other.Data)) ? 1108449149 : 825880546);
					continue;
				case 10:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_A1_0 = 781344912;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other != this) ? 1938051258 : 278448106);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ ChallengeAnsweredRequest.smethod_1(this.Answer);
			while (true)
			{
				IL_C8:
				uint arg_A4_0 = 1276586674u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A4_0 ^ 126333373u)) % 6u)
					{
					case 0u:
						goto IL_C8;
					case 1u:
						arg_A4_0 = ((this.Id != 0u) ? 1612663377u : 91719667u);
						continue;
					case 3u:
						num ^= ChallengeAnsweredRequest.smethod_1(this.Data);
						arg_A4_0 = (num2 * 4221747396u ^ 522637354u);
						continue;
					case 4u:
						num ^= this.Id.GetHashCode();
						arg_A4_0 = (num2 * 2296352533u ^ 3283024303u);
						continue;
					case 5u:
						arg_A4_0 = (((this.Data.Length != 0) ? 1022166241u : 547082219u) ^ num2 * 1636392267u);
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
			output.WriteString(this.Answer);
			while (true)
			{
				IL_E8:
				uint arg_C0_0 = 3460301839u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C0_0 ^ 2994952642u)) % 7u)
					{
					case 0u:
						output.WriteUInt32(this.Id);
						arg_C0_0 = (num * 2360905336u ^ 2292279376u);
						continue;
					case 1u:
						output.WriteRawTag(18);
						output.WriteBytes(this.Data);
						arg_C0_0 = (num * 1754295071u ^ 3609546951u);
						continue;
					case 3u:
						goto IL_E8;
					case 4u:
						output.WriteRawTag(24);
						arg_C0_0 = (num * 3489346009u ^ 745601404u);
						continue;
					case 5u:
						arg_C0_0 = ((this.Id == 0u) ? 2502594168u : 4019615199u);
						continue;
					case 6u:
						arg_C0_0 = (((this.Data.Length == 0) ? 945632044u : 410498231u) ^ num * 183227806u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeStringSize(this.Answer));
			if (this.Data.Length != 0)
			{
				goto IL_31;
			}
			goto IL_A5;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num2;
				switch ((num2 = (arg_79_0 ^ 1513400426u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
					arg_79_0 = (num2 * 131805875u ^ 3451800742u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
					arg_79_0 = (num2 * 1522600327u ^ 1283415835u);
					continue;
				case 3u:
					goto IL_31;
				case 4u:
					goto IL_A5;
				}
				break;
			}
			return num;
			IL_31:
			arg_79_0 = 1317462509u;
			goto IL_74;
			IL_A5:
			arg_79_0 = ((this.Id == 0u) ? 1304157405u : 114786272u);
			goto IL_74;
		}

		public void MergeFrom(ChallengeAnsweredRequest other)
		{
			if (other == null)
			{
				goto IL_36;
			}
			goto IL_FD;
			uint arg_BD_0;
			while (true)
			{
				IL_B8:
				uint num;
				switch ((num = (arg_BD_0 ^ 2482896263u)) % 9u)
				{
				case 1u:
					return;
				case 2u:
					arg_BD_0 = ((other.Id == 0u) ? 2244010945u : 3317921244u);
					continue;
				case 3u:
					this.Id = other.Id;
					arg_BD_0 = (num * 2075303047u ^ 2610411580u);
					continue;
				case 4u:
					this.Answer = other.Answer;
					arg_BD_0 = (num * 458266466u ^ 3194020199u);
					continue;
				case 5u:
					arg_BD_0 = ((other.Data.Length == 0) ? 2271333857u : 2250151958u);
					continue;
				case 6u:
					goto IL_FD;
				case 7u:
					goto IL_36;
				case 8u:
					this.Data = other.Data;
					arg_BD_0 = (num * 1783104841u ^ 3472492216u);
					continue;
				}
				break;
			}
			return;
			IL_36:
			arg_BD_0 = 2685011236u;
			goto IL_B8;
			IL_FD:
			arg_BD_0 = ((ChallengeAnsweredRequest.smethod_2(other.Answer) == 0) ? 3324869627u : 3806541353u);
			goto IL_B8;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_151:
				uint num;
				uint arg_105_0 = ((num = input.ReadTag()) != 0u) ? 313608526u : 512146575u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_105_0 ^ 1295199956u)) % 12u)
					{
					case 0u:
						this.Data = input.ReadBytes();
						arg_105_0 = 1450349118u;
						continue;
					case 1u:
						goto IL_151;
					case 2u:
						arg_105_0 = ((num != 10u) ? 1439386266u : 32728963u);
						continue;
					case 4u:
						arg_105_0 = (((num != 24u) ? 534326781u : 940122512u) ^ num2 * 1930759454u);
						continue;
					case 5u:
						arg_105_0 = (num2 * 2839322027u ^ 2371802198u);
						continue;
					case 6u:
						arg_105_0 = (((num == 18u) ? 1262070304u : 829182112u) ^ num2 * 2794482212u);
						continue;
					case 7u:
						arg_105_0 = 313608526u;
						continue;
					case 8u:
						this.Id = input.ReadUInt32();
						arg_105_0 = 43155097u;
						continue;
					case 9u:
						input.SkipLastField();
						arg_105_0 = (num2 * 2791204856u ^ 405198913u);
						continue;
					case 10u:
						arg_105_0 = (num2 * 308458390u ^ 3080860037u);
						continue;
					case 11u:
						this.Answer = input.ReadString();
						arg_105_0 = 43155097u;
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
