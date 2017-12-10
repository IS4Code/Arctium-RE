using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class ClientRequest : IMessage<ClientRequest>, IEquatable<ClientRequest>, IDeepCloneable<ClientRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ClientRequest.__c __9 = new ClientRequest.__c();

			internal ClientRequest cctor>b__49_0()
			{
				return new ClientRequest();
			}
		}

		private static readonly MessageParser<ClientRequest> _parser = new MessageParser<ClientRequest>(new Func<ClientRequest>(ClientRequest.__c.__9.<.cctor>b__49_0));

		public const int AttributeFieldNumber = 1;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int HostFieldNumber = 2;

		private ProcessId host_;

		public const int AccountIdFieldNumber = 3;

		private EntityId accountId_;

		public const int GameAccountIdFieldNumber = 4;

		private EntityId gameAccountId_;

		public const int ProgramFieldNumber = 5;

		private uint program_;

		public const int ClientInfoFieldNumber = 6;

		private ClientInfo clientInfo_;

		public static MessageParser<ClientRequest> Parser
		{
			get
			{
				return ClientRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientRequest.Descriptor;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
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

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public ClientInfo ClientInfo
		{
			get
			{
				return this.clientInfo_;
			}
			set
			{
				this.clientInfo_ = value;
			}
		}

		public ClientRequest()
		{
		}

		public ClientRequest(ClientRequest other) : this()
		{
			this.attribute_ = other.attribute_.Clone();
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.program_ = other.program_;
			this.ClientInfo = ((other.clientInfo_ != null) ? other.ClientInfo.Clone() : null);
		}

		public ClientRequest Clone()
		{
			return new ClientRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ClientRequest);
		}

		public bool Equals(ClientRequest other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_18F;
			int arg_131_0;
			while (true)
			{
				IL_12C:
				switch ((arg_131_0 ^ 2065632182) % 17)
				{
				case 0:
					goto IL_18F;
				case 1:
					return false;
				case 2:
					arg_131_0 = (ClientRequest.smethod_0(this.Host, other.Host) ? 1693669460 : 2056580681);
					continue;
				case 3:
					return false;
				case 4:
					arg_131_0 = (ClientRequest.smethod_0(this.ClientInfo, other.ClientInfo) ? 1076623634 : 1816253848);
					continue;
				case 5:
					return true;
				case 6:
					arg_131_0 = ((!ClientRequest.smethod_0(this.GameAccountId, other.GameAccountId)) ? 1096434502 : 951808211);
					continue;
				case 8:
					arg_131_0 = (this.attribute_.Equals(other.attribute_) ? 375775418 : 1275826742);
					continue;
				case 9:
					return false;
				case 10:
					goto IL_71;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_131_0 = ((this.Program != other.Program) ? 328843442 : 97430758);
					continue;
				case 14:
					return false;
				case 15:
					arg_131_0 = (ClientRequest.smethod_0(this.AccountId, other.AccountId) ? 1425371528 : 894397152);
					continue;
				case 16:
					return false;
				}
				break;
			}
			return true;
			IL_71:
			arg_131_0 = 1303724693;
			goto IL_12C;
			IL_18F:
			arg_131_0 = ((other != this) ? 1872128339 : 827885944);
			goto IL_12C;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ ClientRequest.smethod_1(this.attribute_);
			while (true)
			{
				IL_1A8:
				uint arg_16B_0 = 125185246u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_16B_0 ^ 286268547u)) % 12u)
					{
					case 0u:
						arg_16B_0 = ((this.Program == 0u) ? 1954299074u : 2074503147u);
						continue;
					case 1u:
						arg_16B_0 = (((this.host_ != null) ? 2233798353u : 4264539022u) ^ num2 * 4037523415u);
						continue;
					case 2u:
						arg_16B_0 = ((this.gameAccountId_ == null) ? 1922961771u : 48645464u);
						continue;
					case 3u:
						num ^= ClientRequest.smethod_1(this.GameAccountId);
						arg_16B_0 = (num2 * 3002012066u ^ 1439659773u);
						continue;
					case 4u:
						goto IL_1A8;
					case 5u:
						num ^= ClientRequest.smethod_1(this.Host);
						arg_16B_0 = (num2 * 2868212681u ^ 1513819588u);
						continue;
					case 6u:
						arg_16B_0 = ((this.accountId_ != null) ? 1306192253u : 1144437309u);
						continue;
					case 8u:
						num ^= this.Program.GetHashCode();
						arg_16B_0 = (num2 * 3053217815u ^ 3466291866u);
						continue;
					case 9u:
						arg_16B_0 = ((this.clientInfo_ == null) ? 1155082240u : 660416512u);
						continue;
					case 10u:
						num ^= ClientRequest.smethod_1(this.AccountId);
						arg_16B_0 = (num2 * 1804306161u ^ 378024483u);
						continue;
					case 11u:
						num ^= this.ClientInfo.GetHashCode();
						arg_16B_0 = (num2 * 2596084163u ^ 1031791305u);
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
			this.attribute_.WriteTo(output, ClientRequest._repeated_attribute_codec);
			while (true)
			{
				IL_206:
				uint arg_1BD_0 = 4026238796u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1BD_0 ^ 3987017948u)) % 15u)
					{
					case 0u:
						output.WriteMessage(this.GameAccountId);
						arg_1BD_0 = (num * 1734913269u ^ 1796538986u);
						continue;
					case 1u:
						arg_1BD_0 = (((this.host_ == null) ? 155361125u : 2018662703u) ^ num * 938927656u);
						continue;
					case 2u:
						arg_1BD_0 = ((this.accountId_ == null) ? 4178047655u : 3063690978u);
						continue;
					case 3u:
						output.WriteRawTag(50);
						output.WriteMessage(this.ClientInfo);
						arg_1BD_0 = (num * 3233512433u ^ 210935663u);
						continue;
					case 5u:
						goto IL_206;
					case 6u:
						arg_1BD_0 = ((this.gameAccountId_ == null) ? 3008754337u : 3684295105u);
						continue;
					case 7u:
						output.WriteRawTag(18);
						output.WriteMessage(this.Host);
						arg_1BD_0 = (num * 2205070507u ^ 477299764u);
						continue;
					case 8u:
						output.WriteRawTag(26);
						arg_1BD_0 = (num * 3316671661u ^ 531994782u);
						continue;
					case 9u:
						output.WriteRawTag(34);
						arg_1BD_0 = (num * 2513673420u ^ 1134121343u);
						continue;
					case 10u:
						arg_1BD_0 = ((this.Program != 0u) ? 2889723263u : 4123078517u);
						continue;
					case 11u:
						arg_1BD_0 = ((this.clientInfo_ != null) ? 2680037572u : 2443792887u);
						continue;
					case 12u:
						output.WriteFixed32(this.Program);
						arg_1BD_0 = (num * 3944539892u ^ 2077028669u);
						continue;
					case 13u:
						output.WriteMessage(this.AccountId);
						arg_1BD_0 = (num * 374548430u ^ 905106271u);
						continue;
					case 14u:
						output.WriteRawTag(45);
						arg_1BD_0 = (num * 1360247931u ^ 2520316023u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + this.attribute_.CalculateSize(ClientRequest._repeated_attribute_codec);
			if (this.host_ != null)
			{
				goto IL_DD;
			}
			goto IL_182;
			uint arg_13A_0;
			while (true)
			{
				IL_135:
				uint num2;
				switch ((num2 = (arg_13A_0 ^ 4186034230u)) % 11u)
				{
				case 0u:
					arg_13A_0 = ((this.clientInfo_ != null) ? 3937587503u : 4022434633u);
					continue;
				case 1u:
					num += 5;
					arg_13A_0 = (num2 * 2171812951u ^ 1666412169u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
					arg_13A_0 = (num2 * 1539496444u ^ 2906351284u);
					continue;
				case 3u:
					goto IL_DD;
				case 4u:
					arg_13A_0 = ((this.gameAccountId_ == null) ? 2445544244u : 4287129291u);
					continue;
				case 5u:
					goto IL_182;
				case 7u:
					arg_13A_0 = ((this.Program != 0u) ? 3715256877u : 3442730404u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
					arg_13A_0 = (num2 * 3198662407u ^ 3503935711u);
					continue;
				case 9u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
					arg_13A_0 = (num2 * 2383994806u ^ 946218824u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientInfo);
					arg_13A_0 = (num2 * 14416726u ^ 2321127983u);
					continue;
				}
				break;
			}
			return num;
			IL_DD:
			arg_13A_0 = 3331221513u;
			goto IL_135;
			IL_182:
			arg_13A_0 = ((this.accountId_ != null) ? 3031600584u : 2692985532u);
			goto IL_135;
		}

		public void MergeFrom(ClientRequest other)
		{
			if (other == null)
			{
				goto IL_266;
			}
			goto IL_2D5;
			uint arg_270_0;
			while (true)
			{
				IL_26B:
				uint num;
				switch ((num = (arg_270_0 ^ 1962833610u)) % 22u)
				{
				case 0u:
					goto IL_2D5;
				case 1u:
					return;
				case 2u:
					goto IL_266;
				case 3u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_270_0 = 255607263u;
					continue;
				case 4u:
					this.gameAccountId_ = new EntityId();
					arg_270_0 = (num * 3636711999u ^ 3946242157u);
					continue;
				case 5u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_270_0 = 684000152u;
					continue;
				case 6u:
					arg_270_0 = (((this.clientInfo_ == null) ? 1930223235u : 940540130u) ^ num * 2490024621u);
					continue;
				case 7u:
					arg_270_0 = (((this.accountId_ == null) ? 1549696149u : 1451605105u) ^ num * 1687542274u);
					continue;
				case 8u:
					arg_270_0 = (((other.host_ != null) ? 1542009091u : 1485319839u) ^ num * 2859550627u);
					continue;
				case 9u:
					this.clientInfo_ = new ClientInfo();
					arg_270_0 = (num * 3829761585u ^ 956329499u);
					continue;
				case 11u:
					arg_270_0 = (((this.host_ == null) ? 256107058u : 1822069155u) ^ num * 3229157225u);
					continue;
				case 12u:
					this.ClientInfo.MergeFrom(other.ClientInfo);
					arg_270_0 = 1128577518u;
					continue;
				case 13u:
					this.host_ = new ProcessId();
					arg_270_0 = (num * 545056616u ^ 888284740u);
					continue;
				case 14u:
					this.Host.MergeFrom(other.Host);
					arg_270_0 = 1366800945u;
					continue;
				case 15u:
					arg_270_0 = ((other.accountId_ == null) ? 684000152u : 1866179667u);
					continue;
				case 16u:
					arg_270_0 = ((other.gameAccountId_ != null) ? 408680768u : 255607263u);
					continue;
				case 17u:
					arg_270_0 = ((other.Program == 0u) ? 2006580511u : 1012632056u);
					continue;
				case 18u:
					arg_270_0 = (((this.gameAccountId_ == null) ? 2468072218u : 2686286017u) ^ num * 1468632009u);
					continue;
				case 19u:
					this.accountId_ = new EntityId();
					arg_270_0 = (num * 3213930627u ^ 2449540484u);
					continue;
				case 20u:
					this.Program = other.Program;
					arg_270_0 = (num * 3408259938u ^ 3465636411u);
					continue;
				case 21u:
					arg_270_0 = ((other.clientInfo_ == null) ? 1128577518u : 1625663934u);
					continue;
				}
				break;
			}
			return;
			IL_266:
			arg_270_0 = 1158198131u;
			goto IL_26B;
			IL_2D5:
			this.attribute_.Add(other.attribute_);
			arg_270_0 = 905424304u;
			goto IL_26B;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_382:
				uint num;
				uint arg_2F6_0 = ((num = input.ReadTag()) != 0u) ? 1018420974u : 1145137856u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2F6_0 ^ 2131153726u)) % 28u)
					{
					case 0u:
						this.Program = input.ReadFixed32();
						arg_2F6_0 = 821959432u;
						continue;
					case 1u:
						arg_2F6_0 = ((this.accountId_ == null) ? 573907615u : 912343481u);
						continue;
					case 2u:
						arg_2F6_0 = ((this.clientInfo_ != null) ? 1548277972u : 357212971u);
						continue;
					case 3u:
						arg_2F6_0 = (((num == 26u) ? 1638662321u : 1809965253u) ^ num2 * 3842325770u);
						continue;
					case 4u:
						this.host_ = new ProcessId();
						arg_2F6_0 = (num2 * 3663172404u ^ 2316285285u);
						continue;
					case 5u:
						arg_2F6_0 = ((this.gameAccountId_ == null) ? 22664864u : 1380170550u);
						continue;
					case 6u:
						arg_2F6_0 = 1018420974u;
						continue;
					case 7u:
						arg_2F6_0 = ((this.host_ == null) ? 27583998u : 1940712037u);
						continue;
					case 8u:
						arg_2F6_0 = (((num == 45u) ? 2052486402u : 1285907529u) ^ num2 * 3539309320u);
						continue;
					case 9u:
						arg_2F6_0 = (num2 * 400267071u ^ 935075409u);
						continue;
					case 10u:
						this.attribute_.AddEntriesFrom(input, ClientRequest._repeated_attribute_codec);
						arg_2F6_0 = 1859252069u;
						continue;
					case 11u:
						input.ReadMessage(this.accountId_);
						arg_2F6_0 = 322599171u;
						continue;
					case 12u:
						input.ReadMessage(this.gameAccountId_);
						arg_2F6_0 = 821959432u;
						continue;
					case 13u:
						this.clientInfo_ = new ClientInfo();
						arg_2F6_0 = (num2 * 2287470232u ^ 3413365420u);
						continue;
					case 14u:
						input.ReadMessage(this.clientInfo_);
						arg_2F6_0 = 821959432u;
						continue;
					case 15u:
						arg_2F6_0 = (num2 * 3914159248u ^ 2478887992u);
						continue;
					case 16u:
						arg_2F6_0 = (((num == 10u) ? 2765161772u : 3856990977u) ^ num2 * 3494822973u);
						continue;
					case 17u:
						arg_2F6_0 = (num2 * 3589014832u ^ 454100856u);
						continue;
					case 18u:
						this.gameAccountId_ = new EntityId();
						arg_2F6_0 = (num2 * 3056105221u ^ 2321823008u);
						continue;
					case 19u:
						arg_2F6_0 = (((num == 18u) ? 2820674274u : 3107429770u) ^ num2 * 2582593593u);
						continue;
					case 20u:
						input.SkipLastField();
						arg_2F6_0 = 821959432u;
						continue;
					case 21u:
						arg_2F6_0 = ((num != 34u) ? 1792741310u : 1206418651u);
						continue;
					case 22u:
						goto IL_382;
					case 23u:
						arg_2F6_0 = (((num == 50u) ? 2036535309u : 1470539571u) ^ num2 * 4021369079u);
						continue;
					case 24u:
						arg_2F6_0 = ((num <= 26u) ? 782937010u : 1215771699u);
						continue;
					case 25u:
						this.accountId_ = new EntityId();
						arg_2F6_0 = (num2 * 3982763252u ^ 2768351437u);
						continue;
					case 27u:
						input.ReadMessage(this.host_);
						arg_2F6_0 = 821959432u;
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
