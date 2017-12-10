using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeAnsweredResponse : IMessage<ChallengeAnsweredResponse>, IEquatable<ChallengeAnsweredResponse>, IDeepCloneable<ChallengeAnsweredResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeAnsweredResponse.__c __9 = new ChallengeAnsweredResponse.__c();

			internal ChallengeAnsweredResponse cctor>b__34_0()
			{
				return new ChallengeAnsweredResponse();
			}
		}

		private static readonly MessageParser<ChallengeAnsweredResponse> _parser = new MessageParser<ChallengeAnsweredResponse>(new Func<ChallengeAnsweredResponse>(ChallengeAnsweredResponse.__c.__9.<.cctor>b__34_0));

		public const int DataFieldNumber = 1;

		private ByteString data_ = ByteString.Empty;

		public const int DoRetryFieldNumber = 2;

		private bool doRetry_;

		public const int RecordNotFoundFieldNumber = 3;

		private bool recordNotFound_;

		public static MessageParser<ChallengeAnsweredResponse> Parser
		{
			get
			{
				return ChallengeAnsweredResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeAnsweredResponse.Descriptor;
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
				this.data_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public bool DoRetry
		{
			get
			{
				return this.doRetry_;
			}
			set
			{
				this.doRetry_ = value;
			}
		}

		public bool RecordNotFound
		{
			get
			{
				return this.recordNotFound_;
			}
			set
			{
				this.recordNotFound_ = value;
			}
		}

		public ChallengeAnsweredResponse()
		{
		}

		public ChallengeAnsweredResponse(ChallengeAnsweredResponse other) : this()
		{
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 3393470137u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4D_0 ^ 4054376914u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						this.recordNotFound_ = other.recordNotFound_;
						arg_4D_0 = (num * 944333340u ^ 2797693732u);
						continue;
					case 3u:
						this.data_ = other.data_;
						this.doRetry_ = other.doRetry_;
						arg_4D_0 = (num * 1013678656u ^ 800097251u);
						continue;
					}
					return;
				}
			}
		}

		public ChallengeAnsweredResponse Clone()
		{
			return new ChallengeAnsweredResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeAnsweredResponse);
		}

		public bool Equals(ChallengeAnsweredResponse other)
		{
			if (other == null)
			{
				goto IL_92;
			}
			goto IL_E2;
			int arg_9C_0;
			while (true)
			{
				IL_97:
				switch ((arg_9C_0 ^ 1445842356) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					goto IL_92;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_9C_0 = ((this.Data != other.Data) ? 1900513050 : 1734213367);
					continue;
				case 7:
					arg_9C_0 = ((this.RecordNotFound != other.RecordNotFound) ? 1021738380 : 1585967627);
					continue;
				case 8:
					goto IL_E2;
				case 9:
					return true;
				case 10:
					arg_9C_0 = ((this.DoRetry != other.DoRetry) ? 2083838454 : 114641297);
					continue;
				}
				break;
			}
			return true;
			IL_92:
			arg_9C_0 = 1400224851;
			goto IL_97;
			IL_E2:
			arg_9C_0 = ((other == this) ? 1159741514 : 1966804990);
			goto IL_97;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data.Length != 0)
			{
				goto IL_62;
			}
			goto IL_E3;
			uint arg_AC_0;
			while (true)
			{
				IL_A7:
				uint num2;
				switch ((num2 = (arg_AC_0 ^ 2560264832u)) % 7u)
				{
				case 0u:
					num ^= this.DoRetry.GetHashCode();
					arg_AC_0 = (num2 * 1687540986u ^ 3451330812u);
					continue;
				case 2u:
					num ^= this.RecordNotFound.GetHashCode();
					arg_AC_0 = (num2 * 2676635953u ^ 637023954u);
					continue;
				case 3u:
					goto IL_62;
				case 4u:
					arg_AC_0 = ((!this.RecordNotFound) ? 3564766171u : 2663270873u);
					continue;
				case 5u:
					num ^= ChallengeAnsweredResponse.smethod_0(this.Data);
					arg_AC_0 = (num2 * 1736629555u ^ 417808301u);
					continue;
				case 6u:
					goto IL_E3;
				}
				break;
			}
			return num;
			IL_62:
			arg_AC_0 = 2253925554u;
			goto IL_A7;
			IL_E3:
			arg_AC_0 = (this.DoRetry ? 2408075789u : 2356813134u);
			goto IL_A7;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Data.Length != 0)
			{
				goto IL_C1;
			}
			goto IL_106;
			uint arg_CB_0;
			while (true)
			{
				IL_C6:
				uint num;
				switch ((num = (arg_CB_0 ^ 2722735510u)) % 8u)
				{
				case 0u:
					goto IL_C1;
				case 1u:
					goto IL_106;
				case 3u:
					output.WriteBool(this.DoRetry);
					arg_CB_0 = (num * 282569275u ^ 2521740147u);
					continue;
				case 4u:
					arg_CB_0 = (this.RecordNotFound ? 3506627736u : 2912725164u);
					continue;
				case 5u:
					output.WriteRawTag(10);
					output.WriteBytes(this.Data);
					arg_CB_0 = (num * 4250811345u ^ 3080094154u);
					continue;
				case 6u:
					output.WriteRawTag(24);
					output.WriteBool(this.RecordNotFound);
					arg_CB_0 = (num * 2562968716u ^ 1328812804u);
					continue;
				case 7u:
					output.WriteRawTag(16);
					arg_CB_0 = (num * 4270468542u ^ 131673751u);
					continue;
				}
				break;
			}
			return;
			IL_C1:
			arg_CB_0 = 4092160627u;
			goto IL_C6;
			IL_106:
			arg_CB_0 = ((!this.DoRetry) ? 3869945858u : 2206413289u);
			goto IL_C6;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_EE:
				uint arg_C2_0 = 868266105u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C2_0 ^ 619060295u)) % 8u)
					{
					case 0u:
						goto IL_EE;
					case 1u:
						arg_C2_0 = ((!this.RecordNotFound) ? 538217050u : 1681869704u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
						arg_C2_0 = (num2 * 2518846796u ^ 1907442660u);
						continue;
					case 3u:
						arg_C2_0 = ((!this.DoRetry) ? 818299182u : 466538555u);
						continue;
					case 4u:
						num += 2;
						arg_C2_0 = (num2 * 4060477802u ^ 1022559862u);
						continue;
					case 6u:
						arg_C2_0 = (((this.Data.Length != 0) ? 3438932111u : 2188479990u) ^ num2 * 3167851931u);
						continue;
					case 7u:
						num += 2;
						arg_C2_0 = (num2 * 570498362u ^ 99343804u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChallengeAnsweredResponse other)
		{
			if (other == null)
			{
				goto IL_33;
			}
			goto IL_F5;
			uint arg_B5_0;
			while (true)
			{
				IL_B0:
				uint num;
				switch ((num = (arg_B5_0 ^ 3182566679u)) % 9u)
				{
				case 1u:
					return;
				case 2u:
					arg_B5_0 = ((!other.RecordNotFound) ? 2580426635u : 3106800373u);
					continue;
				case 3u:
					goto IL_F5;
				case 4u:
					arg_B5_0 = ((!other.DoRetry) ? 3611510989u : 4080597303u);
					continue;
				case 5u:
					this.Data = other.Data;
					arg_B5_0 = (num * 1594680232u ^ 3416666749u);
					continue;
				case 6u:
					this.RecordNotFound = other.RecordNotFound;
					arg_B5_0 = (num * 3593041253u ^ 2861756833u);
					continue;
				case 7u:
					goto IL_33;
				case 8u:
					this.DoRetry = other.DoRetry;
					arg_B5_0 = (num * 3576265773u ^ 3913994605u);
					continue;
				}
				break;
			}
			return;
			IL_33:
			arg_B5_0 = 3434105346u;
			goto IL_B0;
			IL_F5:
			arg_B5_0 = ((other.Data.Length == 0) ? 3176146973u : 3949601163u);
			goto IL_B0;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14B:
				uint num;
				uint arg_FF_0 = ((num = input.ReadTag()) != 0u) ? 2280525769u : 2479021777u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_FF_0 ^ 3187733918u)) % 12u)
					{
					case 0u:
						arg_FF_0 = (num2 * 1839250332u ^ 553178723u);
						continue;
					case 1u:
						goto IL_14B;
					case 2u:
						this.DoRetry = input.ReadBool();
						arg_FF_0 = 2865322776u;
						continue;
					case 3u:
						this.RecordNotFound = input.ReadBool();
						arg_FF_0 = 2454431251u;
						continue;
					case 4u:
						arg_FF_0 = (((num != 24u) ? 3399289662u : 2860740189u) ^ num2 * 2355856800u);
						continue;
					case 5u:
						this.Data = input.ReadBytes();
						arg_FF_0 = 3274817050u;
						continue;
					case 6u:
						arg_FF_0 = 2280525769u;
						continue;
					case 8u:
						input.SkipLastField();
						arg_FF_0 = (num2 * 4017259650u ^ 2560986451u);
						continue;
					case 9u:
						arg_FF_0 = (((num != 16u) ? 774438640u : 2144650030u) ^ num2 * 255296614u);
						continue;
					case 10u:
						arg_FF_0 = (num2 * 83866992u ^ 844152499u);
						continue;
					case 11u:
						arg_FF_0 = ((num == 10u) ? 2747873907u : 2361592599u);
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
