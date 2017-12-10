using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeExternalRequest : IMessage<ChallengeExternalRequest>, IEquatable<ChallengeExternalRequest>, IDeepCloneable<ChallengeExternalRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeExternalRequest.__c __9 = new ChallengeExternalRequest.__c();

			internal ChallengeExternalRequest cctor>b__34_0()
			{
				return new ChallengeExternalRequest();
			}
		}

		private static readonly MessageParser<ChallengeExternalRequest> _parser = new MessageParser<ChallengeExternalRequest>(new Func<ChallengeExternalRequest>(ChallengeExternalRequest.__c.__9.<.cctor>b__34_0));

		public const int RequestTokenFieldNumber = 1;

		private string requestToken_ = "";

		public const int PayloadTypeFieldNumber = 2;

		private string payloadType_ = "";

		public const int PayloadFieldNumber = 3;

		private ByteString payload_ = ByteString.Empty;

		public static MessageParser<ChallengeExternalRequest> Parser
		{
			get
			{
				return ChallengeExternalRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeExternalRequest.Descriptor;
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

		public string PayloadType
		{
			get
			{
				return this.payloadType_;
			}
			set
			{
				this.payloadType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public ByteString Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ChallengeExternalRequest()
		{
		}

		public ChallengeExternalRequest(ChallengeExternalRequest other) : this()
		{
			this.requestToken_ = other.requestToken_;
			this.payloadType_ = other.payloadType_;
			this.payload_ = other.payload_;
		}

		public ChallengeExternalRequest Clone()
		{
			return new ChallengeExternalRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeExternalRequest);
		}

		public bool Equals(ChallengeExternalRequest other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ 1695910302) % 11)
				{
				case 0:
					arg_A6_0 = ((!(this.Payload != other.Payload)) ? 1519198458 : 625326582);
					continue;
				case 1:
					return false;
				case 3:
					goto IL_70;
				case 4:
					arg_A6_0 = (ChallengeExternalRequest.smethod_0(this.PayloadType, other.PayloadType) ? 1201012305 : 1992792721);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					goto IL_EC;
				case 9:
					arg_A6_0 = (ChallengeExternalRequest.smethod_0(this.RequestToken, other.RequestToken) ? 1315697662 : 1505883054);
					continue;
				case 10:
					return true;
				}
				break;
			}
			return true;
			IL_70:
			arg_A6_0 = 1221291662;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other == this) ? 2037068233 : 1295539271);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_10A:
				uint arg_DE_0 = 103090759u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_DE_0 ^ 509881569u)) % 8u)
					{
					case 0u:
						num ^= ChallengeExternalRequest.smethod_2(this.RequestToken);
						arg_DE_0 = (num2 * 2813084955u ^ 1546608302u);
						continue;
					case 1u:
						num ^= ChallengeExternalRequest.smethod_2(this.PayloadType);
						arg_DE_0 = (num2 * 3775705742u ^ 38729699u);
						continue;
					case 3u:
						goto IL_10A;
					case 4u:
						arg_DE_0 = ((this.Payload.Length == 0) ? 1165224939u : 1411168868u);
						continue;
					case 5u:
						num ^= ChallengeExternalRequest.smethod_2(this.Payload);
						arg_DE_0 = (num2 * 3911931272u ^ 2853368899u);
						continue;
					case 6u:
						arg_DE_0 = (((ChallengeExternalRequest.smethod_1(this.RequestToken) == 0) ? 2013647004u : 770163971u) ^ num2 * 1711997567u);
						continue;
					case 7u:
						arg_DE_0 = ((ChallengeExternalRequest.smethod_1(this.PayloadType) != 0) ? 723734128u : 1034127757u);
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
			if (ChallengeExternalRequest.smethod_1(this.RequestToken) != 0)
			{
				goto IL_63;
			}
			goto IL_11C;
			uint arg_DC_0;
			while (true)
			{
				IL_D7:
				uint num;
				switch ((num = (arg_DC_0 ^ 2462102150u)) % 9u)
				{
				case 0u:
					output.WriteString(this.PayloadType);
					arg_DC_0 = (num * 4286194588u ^ 3240584954u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_DC_0 = (num * 1105868492u ^ 2968398076u);
					continue;
				case 3u:
					goto IL_11C;
				case 4u:
					arg_DC_0 = ((this.Payload.Length == 0) ? 2458781918u : 3844947984u);
					continue;
				case 5u:
					output.WriteRawTag(18);
					arg_DC_0 = (num * 878246125u ^ 2200378580u);
					continue;
				case 6u:
					goto IL_63;
				case 7u:
					output.WriteRawTag(26);
					output.WriteBytes(this.Payload);
					arg_DC_0 = (num * 3069875685u ^ 3255387888u);
					continue;
				case 8u:
					output.WriteString(this.RequestToken);
					arg_DC_0 = (num * 4009652249u ^ 2485387475u);
					continue;
				}
				break;
			}
			return;
			IL_63:
			arg_DC_0 = 3757452087u;
			goto IL_D7;
			IL_11C:
			arg_DC_0 = ((ChallengeExternalRequest.smethod_1(this.PayloadType) == 0) ? 3238427694u : 3806665971u);
			goto IL_D7;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_113:
				uint arg_E7_0 = 1979219713u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E7_0 ^ 1696789871u)) % 8u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.PayloadType);
						arg_E7_0 = (num2 * 50614569u ^ 965450504u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
						arg_E7_0 = (num2 * 3546594442u ^ 1235847903u);
						continue;
					case 3u:
						goto IL_113;
					case 4u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.RequestToken);
						arg_E7_0 = (num2 * 1141837711u ^ 4092122646u);
						continue;
					case 5u:
						arg_E7_0 = ((ChallengeExternalRequest.smethod_1(this.PayloadType) != 0) ? 1913222607u : 1705091752u);
						continue;
					case 6u:
						arg_E7_0 = (((ChallengeExternalRequest.smethod_1(this.RequestToken) != 0) ? 3271781957u : 3859358852u) ^ num2 * 3971099137u);
						continue;
					case 7u:
						arg_E7_0 = ((this.Payload.Length == 0) ? 1006945157u : 146706982u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChallengeExternalRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_105;
			uint arg_C5_0;
			while (true)
			{
				IL_C0:
				uint num;
				switch ((num = (arg_C5_0 ^ 3570964083u)) % 9u)
				{
				case 0u:
					this.Payload = other.Payload;
					arg_C5_0 = (num * 3188902421u ^ 3230562706u);
					continue;
				case 1u:
					goto IL_105;
				case 2u:
					arg_C5_0 = ((ChallengeExternalRequest.smethod_1(other.PayloadType) == 0) ? 3911114294u : 3825926423u);
					continue;
				case 3u:
					this.RequestToken = other.RequestToken;
					arg_C5_0 = (num * 725965706u ^ 2722436065u);
					continue;
				case 4u:
					arg_C5_0 = ((other.Payload.Length == 0) ? 2510022756u : 3925091309u);
					continue;
				case 5u:
					return;
				case 6u:
					this.PayloadType = other.PayloadType;
					arg_C5_0 = (num * 2260112763u ^ 2092969786u);
					continue;
				case 7u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_C5_0 = 3669477583u;
			goto IL_C0;
			IL_105:
			arg_C5_0 = ((ChallengeExternalRequest.smethod_1(other.RequestToken) != 0) ? 2305347568u : 4034249343u);
			goto IL_C0;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14E:
				uint num;
				uint arg_102_0 = ((num = input.ReadTag()) != 0u) ? 3500654313u : 3222165756u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_102_0 ^ 3528836428u)) % 12u)
					{
					case 0u:
						this.Payload = input.ReadBytes();
						arg_102_0 = 3817786284u;
						continue;
					case 1u:
						arg_102_0 = ((num == 10u) ? 2356274110u : 4221718145u);
						continue;
					case 2u:
						this.RequestToken = input.ReadString();
						arg_102_0 = 2906630127u;
						continue;
					case 3u:
						this.PayloadType = input.ReadString();
						arg_102_0 = 3670636303u;
						continue;
					case 5u:
						arg_102_0 = (((num != 18u) ? 976939095u : 2041464394u) ^ num2 * 3566441477u);
						continue;
					case 6u:
						arg_102_0 = 3500654313u;
						continue;
					case 7u:
						arg_102_0 = (num2 * 3038429617u ^ 1929840895u);
						continue;
					case 8u:
						goto IL_14E;
					case 9u:
						input.SkipLastField();
						arg_102_0 = (num2 * 1718633076u ^ 3838185576u);
						continue;
					case 10u:
						arg_102_0 = (((num != 26u) ? 1442711103u : 1598577750u) ^ num2 * 2362987127u);
						continue;
					case 11u:
						arg_102_0 = (num2 * 4092972414u ^ 3856062614u);
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
