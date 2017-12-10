using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Header : IMessage<Header>, IEquatable<Header>, IDeepCloneable<Header>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Header.__c __9 = new Header.__c();

			internal Header cctor>b__74_0()
			{
				return new Header();
			}
		}

		private static readonly MessageParser<Header> _parser = new MessageParser<Header>(new Func<Header>(Header.__c.__9.<.cctor>b__74_0));

		public const int ServiceIdFieldNumber = 1;

		private uint serviceId_;

		public const int MethodIdFieldNumber = 2;

		private uint methodId_;

		public const int TokenFieldNumber = 3;

		private uint token_;

		public const int ObjectIdFieldNumber = 4;

		private ulong objectId_;

		public const int SizeFieldNumber = 5;

		private uint size_;

		public const int StatusFieldNumber = 6;

		private uint status_;

		public const int ErrorFieldNumber = 7;

		private static readonly FieldCodec<ErrorInfo> _repeated_error_codec = FieldCodec.ForMessage<ErrorInfo>(58u, ErrorInfo.Parser);

		private readonly RepeatedField<ErrorInfo> error_ = new RepeatedField<ErrorInfo>();

		public const int TimeoutFieldNumber = 8;

		private ulong timeout_;

		public const int IsResponseFieldNumber = 9;

		private bool isResponse_;

		public const int ForwardTargetsFieldNumber = 10;

		private static readonly FieldCodec<ProcessId> _repeated_forwardTargets_codec = FieldCodec.ForMessage<ProcessId>(82u, ProcessId.Parser);

		private readonly RepeatedField<ProcessId> forwardTargets_ = new RepeatedField<ProcessId>();

		public const int ServiceHashFieldNumber = 11;

		private uint serviceHash_;

		public static MessageParser<Header> Parser
		{
			get
			{
				return Header._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Header.Descriptor;
			}
		}

		public uint ServiceId
		{
			get
			{
				return this.serviceId_;
			}
			set
			{
				this.serviceId_ = value;
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

		public uint Token
		{
			get
			{
				return this.token_;
			}
			set
			{
				this.token_ = value;
			}
		}

		public ulong ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		public uint Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		public uint Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		public RepeatedField<ErrorInfo> Error
		{
			get
			{
				return this.error_;
			}
		}

		public ulong Timeout
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

		public bool IsResponse
		{
			get
			{
				return this.isResponse_;
			}
			set
			{
				this.isResponse_ = value;
			}
		}

		public RepeatedField<ProcessId> ForwardTargets
		{
			get
			{
				return this.forwardTargets_;
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

		public Header()
		{
		}

		public Header(Header other) : this()
		{
			this.serviceId_ = other.serviceId_;
			this.methodId_ = other.methodId_;
			this.token_ = other.token_;
			this.objectId_ = other.objectId_;
			this.size_ = other.size_;
			this.status_ = other.status_;
			this.error_ = other.error_.Clone();
			this.timeout_ = other.timeout_;
			this.isResponse_ = other.isResponse_;
			this.forwardTargets_ = other.forwardTargets_.Clone();
			this.serviceHash_ = other.serviceHash_;
		}

		public Header Clone()
		{
			return new Header(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Header);
		}

		public bool Equals(Header other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_277;
			int arg_1F1_0;
			while (true)
			{
				IL_1EC:
				switch ((arg_1F1_0 ^ 835977110) % 27)
				{
				case 0:
					arg_1F1_0 = ((this.ServiceId == other.ServiceId) ? 1473572423 : 1397514939);
					continue;
				case 1:
					arg_1F1_0 = ((this.Token != other.Token) ? 957622925 : 142015174);
					continue;
				case 2:
					arg_1F1_0 = ((this.ServiceHash == other.ServiceHash) ? 1556651742 : 672325852);
					continue;
				case 3:
					return false;
				case 4:
					arg_1F1_0 = ((this.Timeout == other.Timeout) ? 1214989409 : 1341437749);
					continue;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					arg_1F1_0 = ((this.ObjectId == other.ObjectId) ? 413607046 : 1301858163);
					continue;
				case 8:
					arg_1F1_0 = ((this.Size != other.Size) ? 343707450 : 1962889827);
					continue;
				case 9:
					arg_1F1_0 = ((this.Status != other.Status) ? 1663950880 : 1695505832);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_1F1_0 = ((!this.error_.Equals(other.error_)) ? 465570426 : 926234115);
					continue;
				case 13:
					return false;
				case 14:
					arg_1F1_0 = ((this.MethodId == other.MethodId) ? 546678672 : 210890965);
					continue;
				case 15:
					arg_1F1_0 = (this.forwardTargets_.Equals(other.forwardTargets_) ? 624764737 : 1320222962);
					continue;
				case 16:
					return false;
				case 17:
					goto IL_277;
				case 18:
					return false;
				case 19:
					arg_1F1_0 = ((this.IsResponse == other.IsResponse) ? 792871347 : 1968818502);
					continue;
				case 21:
					return false;
				case 22:
					return false;
				case 23:
					goto IL_18;
				case 24:
					return false;
				case 25:
					return false;
				case 26:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_1F1_0 = 309514385;
			goto IL_1EC;
			IL_277:
			arg_1F1_0 = ((other == this) ? 761468446 : 1363330045);
			goto IL_1EC;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ this.ServiceId.GetHashCode();
			if (this.MethodId != 0u)
			{
				goto IL_17B;
			}
			goto IL_282;
			uint arg_230_0;
			while (true)
			{
				IL_22B:
				uint num2;
				switch ((num2 = (arg_230_0 ^ 1761463747u)) % 17u)
				{
				case 0u:
					num ^= this.Status.GetHashCode();
					arg_230_0 = (num2 * 388279359u ^ 846492851u);
					continue;
				case 1u:
					num ^= this.MethodId.GetHashCode();
					arg_230_0 = (num2 * 1390496085u ^ 3553063500u);
					continue;
				case 2u:
					arg_230_0 = ((this.Size == 0u) ? 905381066u : 2091190091u);
					continue;
				case 3u:
					arg_230_0 = (this.IsResponse ? 874495610u : 1786853419u);
					continue;
				case 4u:
					num ^= this.Size.GetHashCode();
					arg_230_0 = (num2 * 3657136974u ^ 2185365946u);
					continue;
				case 5u:
					goto IL_17B;
				case 6u:
					num ^= this.IsResponse.GetHashCode();
					arg_230_0 = (num2 * 2624026767u ^ 1051550844u);
					continue;
				case 7u:
					arg_230_0 = ((this.Status == 0u) ? 650318841u : 1509270517u);
					continue;
				case 8u:
					num ^= this.forwardTargets_.GetHashCode();
					arg_230_0 = 834861364u;
					continue;
				case 9u:
					arg_230_0 = (((this.ServiceHash == 0u) ? 2822970706u : 2669170615u) ^ num2 * 2179165277u);
					continue;
				case 10u:
					arg_230_0 = (((this.ObjectId != 0uL) ? 3533380903u : 3445017442u) ^ num2 * 696668744u);
					continue;
				case 11u:
					goto IL_282;
				case 12u:
					num ^= this.error_.GetHashCode();
					arg_230_0 = ((this.Timeout == 0uL) ? 2003363121u : 1037982495u);
					continue;
				case 13u:
					num ^= this.ObjectId.GetHashCode();
					arg_230_0 = (num2 * 3350871265u ^ 894827270u);
					continue;
				case 14u:
					num ^= this.Timeout.GetHashCode();
					arg_230_0 = (num2 * 577460675u ^ 149586085u);
					continue;
				case 16u:
					num ^= this.ServiceHash.GetHashCode();
					arg_230_0 = (num2 * 3473681108u ^ 2317726085u);
					continue;
				}
				break;
			}
			return num;
			IL_17B:
			arg_230_0 = 830784483u;
			goto IL_22B;
			IL_282:
			num ^= this.Token.GetHashCode();
			arg_230_0 = 381652572u;
			goto IL_22B;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(8);
			while (true)
			{
				IL_34D:
				uint arg_2E0_0 = 3237246026u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2E0_0 ^ 3733632412u)) % 24u)
					{
					case 0u:
						output.WriteUInt64(this.ObjectId);
						arg_2E0_0 = (num * 1078891772u ^ 3760580697u);
						continue;
					case 1u:
						arg_2E0_0 = (((this.ObjectId == 0uL) ? 794207374u : 327957586u) ^ num * 1282524839u);
						continue;
					case 2u:
						output.WriteRawTag(64);
						arg_2E0_0 = (num * 4285703750u ^ 1830507895u);
						continue;
					case 3u:
						arg_2E0_0 = ((this.Status == 0u) ? 2253889185u : 3528723712u);
						continue;
					case 4u:
						output.WriteRawTag(48);
						arg_2E0_0 = (num * 118453463u ^ 786250316u);
						continue;
					case 5u:
						this.error_.WriteTo(output, Header._repeated_error_codec);
						arg_2E0_0 = 3435959436u;
						continue;
					case 6u:
						arg_2E0_0 = (this.IsResponse ? 2427909861u : 2735404171u);
						continue;
					case 7u:
						arg_2E0_0 = (((this.ServiceHash != 0u) ? 1018677594u : 1783153831u) ^ num * 70875757u);
						continue;
					case 8u:
						arg_2E0_0 = (((this.Timeout != 0uL) ? 2398112718u : 2415332434u) ^ num * 1516901048u);
						continue;
					case 9u:
						output.WriteRawTag(32);
						arg_2E0_0 = (num * 562087974u ^ 4144123170u);
						continue;
					case 10u:
						output.WriteUInt32(this.Size);
						arg_2E0_0 = (num * 4184675981u ^ 2653603341u);
						continue;
					case 11u:
						output.WriteRawTag(24);
						arg_2E0_0 = 2277452704u;
						continue;
					case 12u:
						output.WriteUInt32(this.Token);
						arg_2E0_0 = (num * 671578154u ^ 3127511477u);
						continue;
					case 13u:
						output.WriteRawTag(93);
						output.WriteFixed32(this.ServiceHash);
						arg_2E0_0 = (num * 1614713578u ^ 1849845238u);
						continue;
					case 14u:
						output.WriteUInt32(this.ServiceId);
						arg_2E0_0 = (((this.MethodId != 0u) ? 2631843366u : 3475919427u) ^ num * 470730806u);
						continue;
					case 15u:
						output.WriteUInt64(this.Timeout);
						arg_2E0_0 = (num * 2255670280u ^ 510058474u);
						continue;
					case 17u:
						output.WriteRawTag(72);
						output.WriteBool(this.IsResponse);
						arg_2E0_0 = (num * 1036782798u ^ 3256419285u);
						continue;
					case 18u:
						goto IL_34D;
					case 19u:
						output.WriteRawTag(40);
						arg_2E0_0 = (num * 3227456148u ^ 2072048498u);
						continue;
					case 20u:
						output.WriteUInt32(this.Status);
						arg_2E0_0 = (num * 3276872634u ^ 1570447529u);
						continue;
					case 21u:
						arg_2E0_0 = ((this.Size == 0u) ? 3855264007u : 2422296407u);
						continue;
					case 22u:
						output.WriteRawTag(16);
						output.WriteUInt32(this.MethodId);
						arg_2E0_0 = (num * 2419523506u ^ 1977368251u);
						continue;
					case 23u:
						this.forwardTargets_.WriteTo(output, Header._repeated_forwardTargets_codec);
						arg_2E0_0 = 3250518899u;
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
				IL_281:
				uint arg_230_0 = 39713502u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_230_0 ^ 620036951u)) % 17u)
					{
					case 1u:
						arg_230_0 = (this.IsResponse ? 2088358406u : 46548860u);
						continue;
					case 2u:
						arg_230_0 = ((this.Size != 0u) ? 467121794u : 65388016u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MethodId);
						arg_230_0 = (num2 * 3496149728u ^ 4193955242u);
						continue;
					case 4u:
						arg_230_0 = ((this.Status == 0u) ? 1717321748u : 1449104776u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
						arg_230_0 = (num2 * 618507040u ^ 2516326359u);
						continue;
					case 6u:
						goto IL_281;
					case 7u:
						num += 5;
						arg_230_0 = (num2 * 941016515u ^ 870254654u);
						continue;
					case 8u:
						num += 2;
						arg_230_0 = (num2 * 335134042u ^ 2954175494u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Timeout);
						arg_230_0 = (num2 * 602821029u ^ 2081749824u);
						continue;
					case 10u:
						arg_230_0 = (((this.ObjectId != 0uL) ? 92337772u : 34357350u) ^ num2 * 268620199u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
						arg_230_0 = (num2 * 1497102400u ^ 1601109972u);
						continue;
					case 12u:
						num += this.error_.CalculateSize(Header._repeated_error_codec);
						arg_230_0 = ((this.Timeout != 0uL) ? 778862727u : 521289296u);
						continue;
					case 13u:
						num += this.forwardTargets_.CalculateSize(Header._repeated_forwardTargets_codec);
						arg_230_0 = ((this.ServiceHash == 0u) ? 911796049u : 1506761650u);
						continue;
					case 14u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceId);
						arg_230_0 = (((this.MethodId != 0u) ? 1980989029u : 111085239u) ^ num2 * 3969476629u);
						continue;
					case 15u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Size);
						arg_230_0 = (num2 * 3138876406u ^ 868865118u);
						continue;
					case 16u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Token);
						arg_230_0 = 167577840u;
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Header other)
		{
			if (other == null)
			{
				goto IL_EC;
			}
			goto IL_2DC;
			uint arg_26C_0;
			while (true)
			{
				IL_267:
				uint num;
				switch ((num = (arg_26C_0 ^ 3520855341u)) % 21u)
				{
				case 0u:
					this.forwardTargets_.Add(other.forwardTargets_);
					arg_26C_0 = ((other.ServiceHash != 0u) ? 4156457913u : 2931621814u);
					continue;
				case 1u:
					this.Timeout = other.Timeout;
					arg_26C_0 = (num * 1158433750u ^ 1081217253u);
					continue;
				case 2u:
					goto IL_2DC;
				case 3u:
					arg_26C_0 = ((other.Token == 0u) ? 3497177965u : 3553652908u);
					continue;
				case 4u:
					this.ObjectId = other.ObjectId;
					arg_26C_0 = (num * 4261744410u ^ 3936457795u);
					continue;
				case 5u:
					arg_26C_0 = ((other.Size == 0u) ? 2819585702u : 2719536534u);
					continue;
				case 7u:
					arg_26C_0 = ((!other.IsResponse) ? 4220567087u : 3310645614u);
					continue;
				case 8u:
					arg_26C_0 = ((other.Status == 0u) ? 2916542674u : 3402776913u);
					continue;
				case 9u:
					this.MethodId = other.MethodId;
					arg_26C_0 = (num * 2773288841u ^ 589514948u);
					continue;
				case 10u:
					this.Token = other.Token;
					arg_26C_0 = (num * 3043182469u ^ 3796957288u);
					continue;
				case 11u:
					return;
				case 12u:
					this.Size = other.Size;
					arg_26C_0 = (num * 1299235297u ^ 1493479933u);
					continue;
				case 13u:
					arg_26C_0 = ((other.MethodId == 0u) ? 3964147250u : 2622918379u);
					continue;
				case 14u:
					goto IL_EC;
				case 15u:
					arg_26C_0 = ((other.ObjectId == 0uL) ? 4147299861u : 3909956794u);
					continue;
				case 16u:
					this.IsResponse = other.IsResponse;
					arg_26C_0 = (num * 1567705496u ^ 2673728743u);
					continue;
				case 17u:
					this.ServiceHash = other.ServiceHash;
					arg_26C_0 = (num * 609602925u ^ 3624638130u);
					continue;
				case 18u:
					this.Status = other.Status;
					arg_26C_0 = (num * 3824877483u ^ 1787724294u);
					continue;
				case 19u:
					this.ServiceId = other.ServiceId;
					arg_26C_0 = (num * 2927358265u ^ 2586377024u);
					continue;
				case 20u:
					this.error_.Add(other.error_);
					arg_26C_0 = ((other.Timeout == 0uL) ? 2832013815u : 2604688246u);
					continue;
				}
				break;
			}
			return;
			IL_EC:
			arg_26C_0 = 3635414551u;
			goto IL_267;
			IL_2DC:
			arg_26C_0 = ((other.ServiceId == 0u) ? 3547158705u : 2207145300u);
			goto IL_267;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4BF:
				uint num;
				uint arg_403_0 = ((num = input.ReadTag()) == 0u) ? 462781708u : 1200789082u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_403_0 ^ 1448827902u)) % 40u)
					{
					case 0u:
						this.ObjectId = input.ReadUInt64();
						arg_403_0 = 1383181675u;
						continue;
					case 1u:
						arg_403_0 = (num2 * 2484676307u ^ 1371559099u);
						continue;
					case 2u:
						this.error_.AddEntriesFrom(input, Header._repeated_error_codec);
						arg_403_0 = 1967183198u;
						continue;
					case 3u:
						arg_403_0 = (((num != 64u) ? 2844860896u : 3774118563u) ^ num2 * 967557145u);
						continue;
					case 4u:
						arg_403_0 = (((num != 40u) ? 1966472171u : 1324681925u) ^ num2 * 4032843651u);
						continue;
					case 5u:
						arg_403_0 = (num2 * 23153884u ^ 495608180u);
						continue;
					case 6u:
						arg_403_0 = (num2 * 3926757050u ^ 1598772967u);
						continue;
					case 7u:
						arg_403_0 = 1200789082u;
						continue;
					case 8u:
						arg_403_0 = (num2 * 2992131565u ^ 4231612683u);
						continue;
					case 9u:
						this.Status = input.ReadUInt32();
						arg_403_0 = 2041214852u;
						continue;
					case 10u:
						arg_403_0 = (((num != 58u) ? 590152259u : 1280333690u) ^ num2 * 3692790735u);
						continue;
					case 11u:
						this.Token = input.ReadUInt32();
						arg_403_0 = 790605184u;
						continue;
					case 12u:
						arg_403_0 = ((num <= 40u) ? 771893375u : 1368362984u);
						continue;
					case 13u:
						arg_403_0 = (((num != 16u) ? 3485072914u : 2397607450u) ^ num2 * 1858191383u);
						continue;
					case 14u:
						this.Timeout = input.ReadUInt64();
						arg_403_0 = 1383181675u;
						continue;
					case 15u:
						arg_403_0 = ((num == 24u) ? 675734261u : 1192643854u);
						continue;
					case 16u:
						arg_403_0 = (((num == 32u) ? 948735814u : 1924135474u) ^ num2 * 1455062780u);
						continue;
					case 17u:
						arg_403_0 = (num2 * 1748195292u ^ 431786263u);
						continue;
					case 19u:
						this.IsResponse = input.ReadBool();
						arg_403_0 = 1743807954u;
						continue;
					case 20u:
						arg_403_0 = (num2 * 4040615382u ^ 263601107u);
						continue;
					case 21u:
						goto IL_4BF;
					case 22u:
						arg_403_0 = (((num == 8u) ? 248175451u : 177214451u) ^ num2 * 1371567836u);
						continue;
					case 23u:
						this.Size = input.ReadUInt32();
						arg_403_0 = 1383181675u;
						continue;
					case 24u:
						arg_403_0 = (num2 * 3534616873u ^ 1563613899u);
						continue;
					case 25u:
						this.ServiceHash = input.ReadFixed32();
						arg_403_0 = 1383181675u;
						continue;
					case 26u:
						arg_403_0 = (((num == 82u) ? 3140376123u : 3613182253u) ^ num2 * 326042668u);
						continue;
					case 27u:
						arg_403_0 = (((num == 93u) ? 552047522u : 956173301u) ^ num2 * 3054799335u);
						continue;
					case 28u:
						arg_403_0 = (num2 * 2808625113u ^ 3040108615u);
						continue;
					case 29u:
						this.ServiceId = input.ReadUInt32();
						arg_403_0 = 118843626u;
						continue;
					case 30u:
						input.SkipLastField();
						arg_403_0 = 132966375u;
						continue;
					case 31u:
						this.MethodId = input.ReadUInt32();
						arg_403_0 = 287552030u;
						continue;
					case 32u:
						arg_403_0 = (((num != 48u) ? 1661250628u : 464447071u) ^ num2 * 3956194542u);
						continue;
					case 33u:
						arg_403_0 = (((num <= 16u) ? 2685026202u : 3339153443u) ^ num2 * 1034237922u);
						continue;
					case 34u:
						arg_403_0 = (num2 * 3123328711u ^ 1101980605u);
						continue;
					case 35u:
						arg_403_0 = ((num == 72u) ? 675648757u : 266295628u);
						continue;
					case 36u:
						arg_403_0 = (num2 * 1869574487u ^ 3536200095u);
						continue;
					case 37u:
						this.forwardTargets_.AddEntriesFrom(input, Header._repeated_forwardTargets_codec);
						arg_403_0 = 1376591090u;
						continue;
					case 38u:
						arg_403_0 = ((num > 64u) ? 2127364693u : 1603517254u);
						continue;
					case 39u:
						arg_403_0 = (num2 * 1903617701u ^ 3937168195u);
						continue;
					}
					return;
				}
			}
		}
	}
}
