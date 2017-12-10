using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class ConnectResponse : IMessage<ConnectResponse>, IEquatable<ConnectResponse>, IDeepCloneable<ConnectResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ConnectResponse.__c __9 = new ConnectResponse.__c();

			internal ConnectResponse cctor>b__59_0()
			{
				return new ConnectResponse();
			}
		}

		private static readonly MessageParser<ConnectResponse> _parser = new MessageParser<ConnectResponse>(new Func<ConnectResponse>(ConnectResponse.__c.__9.<.cctor>b__59_0));

		public const int ServerIdFieldNumber = 1;

		private ProcessId serverId_;

		public const int ClientIdFieldNumber = 2;

		private ProcessId clientId_;

		public const int BindResultFieldNumber = 3;

		private uint bindResult_;

		public const int BindResponseFieldNumber = 4;

		private BindResponse bindResponse_;

		public const int ContentHandleArrayFieldNumber = 5;

		private ConnectionMeteringContentHandles contentHandleArray_;

		public const int ServerTimeFieldNumber = 6;

		private ulong serverTime_;

		public const int UseBindlessRpcFieldNumber = 7;

		private bool useBindlessRpc_;

		public const int BinaryContentHandleArrayFieldNumber = 8;

		private ConnectionMeteringContentHandles binaryContentHandleArray_;

		public static MessageParser<ConnectResponse> Parser
		{
			get
			{
				return ConnectResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectResponse.Descriptor;
			}
		}

		public ProcessId ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		public ProcessId ClientId
		{
			get
			{
				return this.clientId_;
			}
			set
			{
				this.clientId_ = value;
			}
		}

		public uint BindResult
		{
			get
			{
				return this.bindResult_;
			}
			set
			{
				this.bindResult_ = value;
			}
		}

		public BindResponse BindResponse
		{
			get
			{
				return this.bindResponse_;
			}
			set
			{
				this.bindResponse_ = value;
			}
		}

		public ConnectionMeteringContentHandles ContentHandleArray
		{
			get
			{
				return this.contentHandleArray_;
			}
			set
			{
				this.contentHandleArray_ = value;
			}
		}

		public ulong ServerTime
		{
			get
			{
				return this.serverTime_;
			}
			set
			{
				this.serverTime_ = value;
			}
		}

		public bool UseBindlessRpc
		{
			get
			{
				return this.useBindlessRpc_;
			}
			set
			{
				this.useBindlessRpc_ = value;
			}
		}

		public ConnectionMeteringContentHandles BinaryContentHandleArray
		{
			get
			{
				return this.binaryContentHandleArray_;
			}
			set
			{
				this.binaryContentHandleArray_ = value;
			}
		}

		public ConnectResponse()
		{
		}

		public ConnectResponse(ConnectResponse other) : this()
		{
			this.ServerId = ((other.serverId_ != null) ? other.ServerId.Clone() : null);
			this.ClientId = ((other.clientId_ != null) ? other.ClientId.Clone() : null);
			this.bindResult_ = other.bindResult_;
			this.BindResponse = ((other.bindResponse_ != null) ? other.BindResponse.Clone() : null);
			this.ContentHandleArray = ((other.contentHandleArray_ != null) ? other.ContentHandleArray.Clone() : null);
			this.serverTime_ = other.serverTime_;
			this.useBindlessRpc_ = other.useBindlessRpc_;
			this.BinaryContentHandleArray = ((other.binaryContentHandleArray_ != null) ? other.BinaryContentHandleArray.Clone() : null);
		}

		public ConnectResponse Clone()
		{
			return new ConnectResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectResponse);
		}

		public bool Equals(ConnectResponse other)
		{
			if (other == null)
			{
				goto IL_125;
			}
			goto IL_1F0;
			int arg_182_0;
			while (true)
			{
				IL_17D:
				switch ((arg_182_0 ^ 1318224496) % 21)
				{
				case 0:
					arg_182_0 = ((!ConnectResponse.smethod_0(this.ClientId, other.ClientId)) ? 729928711 : 447793745);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_182_0 = ((this.BindResult != other.BindResult) ? 285442847 : 1209554759);
					continue;
				case 5:
					goto IL_1F0;
				case 6:
					goto IL_125;
				case 7:
					return false;
				case 8:
					arg_182_0 = ((this.UseBindlessRpc == other.UseBindlessRpc) ? 80277860 : 870853466);
					continue;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					arg_182_0 = ((!ConnectResponse.smethod_0(this.ServerId, other.ServerId)) ? 2022232747 : 1674356065);
					continue;
				case 12:
					return false;
				case 13:
					arg_182_0 = ((!ConnectResponse.smethod_0(this.BindResponse, other.BindResponse)) ? 723383813 : 1946188722);
					continue;
				case 14:
					arg_182_0 = (ConnectResponse.smethod_0(this.ContentHandleArray, other.ContentHandleArray) ? 1201413328 : 1455621694);
					continue;
				case 15:
					return false;
				case 17:
					arg_182_0 = ((this.ServerTime == other.ServerTime) ? 2136239711 : 1525322209);
					continue;
				case 18:
					return true;
				case 19:
					return false;
				case 20:
					arg_182_0 = ((!ConnectResponse.smethod_0(this.BinaryContentHandleArray, other.BinaryContentHandleArray)) ? 580824675 : 167330970);
					continue;
				}
				break;
			}
			return true;
			IL_125:
			arg_182_0 = 1740000512;
			goto IL_17D;
			IL_1F0:
			arg_182_0 = ((other != this) ? 1850212299 : 1635574018);
			goto IL_17D;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ ConnectResponse.smethod_1(this.ServerId);
			while (true)
			{
				IL_24F:
				uint arg_201_0 = 4204548226u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_201_0 ^ 3232874134u)) % 16u)
					{
					case 0u:
						arg_201_0 = ((this.bindResponse_ == null) ? 3137372903u : 4263648682u);
						continue;
					case 1u:
						arg_201_0 = ((this.contentHandleArray_ == null) ? 3087692593u : 3333885995u);
						continue;
					case 2u:
						num ^= this.UseBindlessRpc.GetHashCode();
						arg_201_0 = (num2 * 3560630770u ^ 2175167915u);
						continue;
					case 3u:
						arg_201_0 = (this.UseBindlessRpc ? 2180134516u : 3574037007u);
						continue;
					case 4u:
						arg_201_0 = (((this.clientId_ == null) ? 1362293880u : 13757061u) ^ num2 * 1990547770u);
						continue;
					case 5u:
						num ^= this.BinaryContentHandleArray.GetHashCode();
						arg_201_0 = (num2 * 825150998u ^ 3363724032u);
						continue;
					case 6u:
						arg_201_0 = ((this.BindResult == 0u) ? 2360284966u : 3822316092u);
						continue;
					case 7u:
						arg_201_0 = ((this.ServerTime != 0uL) ? 2341345897u : 2722828757u);
						continue;
					case 9u:
						arg_201_0 = ((this.binaryContentHandleArray_ == null) ? 3859734254u : 4153878995u);
						continue;
					case 10u:
						num ^= this.BindResult.GetHashCode();
						arg_201_0 = (num2 * 4110663427u ^ 4225811672u);
						continue;
					case 11u:
						num ^= ConnectResponse.smethod_1(this.ClientId);
						arg_201_0 = (num2 * 1432042725u ^ 3244908119u);
						continue;
					case 12u:
						num ^= this.BindResponse.GetHashCode();
						arg_201_0 = (num2 * 2222543029u ^ 3284249483u);
						continue;
					case 13u:
						num ^= this.ContentHandleArray.GetHashCode();
						arg_201_0 = (num2 * 3978577118u ^ 868468951u);
						continue;
					case 14u:
						goto IL_24F;
					case 15u:
						num ^= this.ServerTime.GetHashCode();
						arg_201_0 = (num2 * 1467618343u ^ 408362764u);
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
			while (true)
			{
				IL_2EC:
				uint arg_287_0 = 645432877u;
				while (true)
				{
					uint num;
					switch ((num = (arg_287_0 ^ 1272281201u)) % 22u)
					{
					case 0u:
						output.WriteRawTag(18);
						arg_287_0 = (num * 1761855565u ^ 486136730u);
						continue;
					case 1u:
						arg_287_0 = ((this.bindResponse_ == null) ? 1714917306u : 1865370520u);
						continue;
					case 2u:
						arg_287_0 = ((this.ServerTime == 0uL) ? 1030985863u : 109628753u);
						continue;
					case 3u:
						output.WriteRawTag(56);
						output.WriteBool(this.UseBindlessRpc);
						arg_287_0 = (num * 3900573780u ^ 787332181u);
						continue;
					case 4u:
						output.WriteRawTag(48);
						output.WriteUInt64(this.ServerTime);
						arg_287_0 = (num * 4056457816u ^ 3097959303u);
						continue;
					case 6u:
						output.WriteMessage(this.BinaryContentHandleArray);
						arg_287_0 = (num * 1408691408u ^ 2331176142u);
						continue;
					case 7u:
						output.WriteRawTag(66);
						arg_287_0 = (num * 1282964173u ^ 4278120550u);
						continue;
					case 8u:
						output.WriteMessage(this.ServerId);
						arg_287_0 = (num * 2998764321u ^ 3681560934u);
						continue;
					case 9u:
						arg_287_0 = (((this.clientId_ != null) ? 2634077527u : 3843204753u) ^ num * 351201398u);
						continue;
					case 10u:
						arg_287_0 = ((!this.UseBindlessRpc) ? 1480123449u : 1646234398u);
						continue;
					case 11u:
						output.WriteRawTag(34);
						arg_287_0 = (num * 3563278703u ^ 1060092212u);
						continue;
					case 12u:
						goto IL_2EC;
					case 13u:
						arg_287_0 = ((this.contentHandleArray_ == null) ? 764244057u : 1112117677u);
						continue;
					case 14u:
						output.WriteRawTag(42);
						arg_287_0 = (num * 811735379u ^ 1635034010u);
						continue;
					case 15u:
						output.WriteMessage(this.ContentHandleArray);
						arg_287_0 = (num * 1956159386u ^ 3334784447u);
						continue;
					case 16u:
						output.WriteMessage(this.BindResponse);
						arg_287_0 = (num * 1623084552u ^ 3271844266u);
						continue;
					case 17u:
						output.WriteRawTag(24);
						arg_287_0 = (num * 2169675946u ^ 3699870116u);
						continue;
					case 18u:
						arg_287_0 = ((this.binaryContentHandleArray_ == null) ? 942875950u : 1015943540u);
						continue;
					case 19u:
						output.WriteMessage(this.ClientId);
						arg_287_0 = (num * 461289918u ^ 2933185953u);
						continue;
					case 20u:
						arg_287_0 = ((this.BindResult == 0u) ? 1938655006u : 830097320u);
						continue;
					case 21u:
						output.WriteUInt32(this.BindResult);
						arg_287_0 = (num * 3296947620u ^ 1776510082u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.ServerId));
			if (this.clientId_ != null)
			{
				goto IL_1B9;
			}
			goto IL_21B;
			uint arg_1C3_0;
			while (true)
			{
				IL_1BE:
				uint num2;
				switch ((num2 = (arg_1C3_0 ^ 3791955157u)) % 15u)
				{
				case 0u:
					goto IL_1B9;
				case 1u:
					num += 2;
					arg_1C3_0 = (num2 * 2380382816u ^ 1553358268u);
					continue;
				case 2u:
					arg_1C3_0 = ((this.ServerTime != 0uL) ? 3508308971u : 2698460086u);
					continue;
				case 3u:
					arg_1C3_0 = ((this.bindResponse_ != null) ? 3958433110u : 2495748688u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ServerTime);
					arg_1C3_0 = (num2 * 582912912u ^ 2341603158u);
					continue;
				case 5u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.BindResult);
					arg_1C3_0 = (num2 * 4224892910u ^ 1678585955u);
					continue;
				case 6u:
					goto IL_21B;
				case 7u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientId);
					arg_1C3_0 = (num2 * 4093551327u ^ 2686556770u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.BinaryContentHandleArray);
					arg_1C3_0 = (num2 * 4144649271u ^ 542872738u);
					continue;
				case 9u:
					arg_1C3_0 = ((this.contentHandleArray_ != null) ? 3492971801u : 2784346952u);
					continue;
				case 10u:
					arg_1C3_0 = (this.UseBindlessRpc ? 3378108876u : 2403501788u);
					continue;
				case 11u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.ContentHandleArray);
					arg_1C3_0 = (num2 * 373644658u ^ 262925200u);
					continue;
				case 12u:
					arg_1C3_0 = ((this.binaryContentHandleArray_ != null) ? 3234260437u : 2673107874u);
					continue;
				case 14u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.BindResponse);
					arg_1C3_0 = (num2 * 3266554429u ^ 865042535u);
					continue;
				}
				break;
			}
			return num;
			IL_1B9:
			arg_1C3_0 = 3754357247u;
			goto IL_1BE;
			IL_21B:
			arg_1C3_0 = ((this.BindResult == 0u) ? 2990741201u : 3771029498u);
			goto IL_1BE;
		}

		public void MergeFrom(ConnectResponse other)
		{
			if (other == null)
			{
				goto IL_2BD;
			}
			goto IL_3F3;
			uint arg_363_0;
			while (true)
			{
				IL_35E:
				uint num;
				switch ((num = (arg_363_0 ^ 2782150612u)) % 29u)
				{
				case 0u:
					arg_363_0 = ((other.ServerTime != 0uL) ? 4004845303u : 3307781695u);
					continue;
				case 1u:
					this.contentHandleArray_ = new ConnectionMeteringContentHandles();
					arg_363_0 = (num * 3474839880u ^ 1686640285u);
					continue;
				case 2u:
					arg_363_0 = (((this.bindResponse_ != null) ? 3798175165u : 2688091483u) ^ num * 3746955508u);
					continue;
				case 3u:
					this.clientId_ = new ProcessId();
					arg_363_0 = (num * 3129218323u ^ 711262546u);
					continue;
				case 4u:
					this.BindResult = other.BindResult;
					arg_363_0 = (num * 3247299427u ^ 40460160u);
					continue;
				case 5u:
					goto IL_2BD;
				case 6u:
					arg_363_0 = ((other.clientId_ != null) ? 4081932844u : 4225330537u);
					continue;
				case 7u:
					arg_363_0 = ((other.contentHandleArray_ == null) ? 2180499315u : 3454686066u);
					continue;
				case 8u:
					arg_363_0 = (((this.contentHandleArray_ == null) ? 2920582551u : 4027478817u) ^ num * 2908513942u);
					continue;
				case 9u:
					arg_363_0 = ((!other.UseBindlessRpc) ? 3237884814u : 2907279431u);
					continue;
				case 10u:
					arg_363_0 = (((this.clientId_ != null) ? 1721500144u : 1929511106u) ^ num * 352045472u);
					continue;
				case 11u:
					this.binaryContentHandleArray_ = new ConnectionMeteringContentHandles();
					arg_363_0 = (num * 2737657680u ^ 554995590u);
					continue;
				case 12u:
					arg_363_0 = ((other.BindResult != 0u) ? 3326611312u : 2470331628u);
					continue;
				case 13u:
					this.ClientId.MergeFrom(other.ClientId);
					arg_363_0 = 4225330537u;
					continue;
				case 14u:
					this.ServerTime = other.ServerTime;
					arg_363_0 = (num * 4248313526u ^ 1436935901u);
					continue;
				case 15u:
					this.ContentHandleArray.MergeFrom(other.ContentHandleArray);
					arg_363_0 = 2180499315u;
					continue;
				case 16u:
					arg_363_0 = (((this.serverId_ != null) ? 4263904922u : 3503317118u) ^ num * 2811650730u);
					continue;
				case 17u:
					goto IL_3F3;
				case 18u:
					return;
				case 19u:
					arg_363_0 = (((this.binaryContentHandleArray_ == null) ? 2042919258u : 55491295u) ^ num * 530148065u);
					continue;
				case 20u:
					arg_363_0 = ((other.bindResponse_ != null) ? 3224476245u : 3036926837u);
					continue;
				case 21u:
					this.ServerId.MergeFrom(other.ServerId);
					arg_363_0 = 3116478756u;
					continue;
				case 22u:
					this.UseBindlessRpc = other.UseBindlessRpc;
					arg_363_0 = (num * 14635639u ^ 3026747611u);
					continue;
				case 23u:
					this.serverId_ = new ProcessId();
					arg_363_0 = (num * 3759469448u ^ 1490933116u);
					continue;
				case 24u:
					this.bindResponse_ = new BindResponse();
					arg_363_0 = (num * 1281953328u ^ 2751373913u);
					continue;
				case 25u:
					this.BindResponse.MergeFrom(other.BindResponse);
					arg_363_0 = 3036926837u;
					continue;
				case 26u:
					arg_363_0 = ((other.binaryContentHandleArray_ != null) ? 3419329885u : 3874914061u);
					continue;
				case 27u:
					this.BinaryContentHandleArray.MergeFrom(other.BinaryContentHandleArray);
					arg_363_0 = 3874914061u;
					continue;
				}
				break;
			}
			return;
			IL_2BD:
			arg_363_0 = 2210598140u;
			goto IL_35E;
			IL_3F3:
			arg_363_0 = ((other.serverId_ == null) ? 3116478756u : 2157262051u);
			goto IL_35E;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_522:
				uint num;
				uint arg_45E_0 = ((num = input.ReadTag()) == 0u) ? 2418578182u : 3120437627u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_45E_0 ^ 2482675237u)) % 42u)
					{
					case 0u:
						arg_45E_0 = (((num != 66u) ? 3910046646u : 2711930753u) ^ num2 * 2320556613u);
						continue;
					case 1u:
						this.ServerTime = input.ReadUInt64();
						arg_45E_0 = 2965623458u;
						continue;
					case 2u:
						arg_45E_0 = (((num != 18u) ? 1853795072u : 1832996189u) ^ num2 * 2268374739u);
						continue;
					case 3u:
						input.ReadMessage(this.serverId_);
						arg_45E_0 = 2732743234u;
						continue;
					case 4u:
						arg_45E_0 = ((this.bindResponse_ != null) ? 2398972302u : 3051169747u);
						continue;
					case 5u:
						input.ReadMessage(this.clientId_);
						arg_45E_0 = 2805825450u;
						continue;
					case 6u:
						arg_45E_0 = (((num == 10u) ? 99391440u : 29836323u) ^ num2 * 246343287u);
						continue;
					case 7u:
						input.ReadMessage(this.contentHandleArray_);
						arg_45E_0 = 3313286757u;
						continue;
					case 8u:
						arg_45E_0 = ((this.binaryContentHandleArray_ != null) ? 3329023022u : 3175981844u);
						continue;
					case 9u:
						input.ReadMessage(this.binaryContentHandleArray_);
						arg_45E_0 = 2965623458u;
						continue;
					case 10u:
						this.bindResponse_ = new BindResponse();
						arg_45E_0 = (num2 * 1230666243u ^ 1768882284u);
						continue;
					case 11u:
						arg_45E_0 = ((num > 48u) ? 2591990283u : 3004624348u);
						continue;
					case 12u:
						arg_45E_0 = (num2 * 1116963318u ^ 4267139046u);
						continue;
					case 13u:
						arg_45E_0 = (num2 * 1025630130u ^ 1876794660u);
						continue;
					case 14u:
						arg_45E_0 = (((num != 48u) ? 3262526884u : 2838145356u) ^ num2 * 3798794442u);
						continue;
					case 15u:
						this.BindResult = input.ReadUInt32();
						arg_45E_0 = 2401269859u;
						continue;
					case 16u:
						arg_45E_0 = ((this.contentHandleArray_ == null) ? 2231357695u : 2815685752u);
						continue;
					case 17u:
						this.UseBindlessRpc = input.ReadBool();
						arg_45E_0 = 2965623458u;
						continue;
					case 18u:
						arg_45E_0 = (num2 * 4156211647u ^ 666563932u);
						continue;
					case 19u:
						input.ReadMessage(this.bindResponse_);
						arg_45E_0 = 3209187345u;
						continue;
					case 20u:
						arg_45E_0 = (num2 * 2338828754u ^ 1264404938u);
						continue;
					case 21u:
						goto IL_522;
					case 22u:
						arg_45E_0 = ((num != 24u) ? 3779788303u : 3498018448u);
						continue;
					case 23u:
						arg_45E_0 = (((num == 42u) ? 3899138507u : 3248015087u) ^ num2 * 263499142u);
						continue;
					case 24u:
						this.contentHandleArray_ = new ConnectionMeteringContentHandles();
						arg_45E_0 = (num2 * 3389342373u ^ 1691480826u);
						continue;
					case 25u:
						arg_45E_0 = ((this.serverId_ != null) ? 2721171666u : 4093628274u);
						continue;
					case 26u:
						arg_45E_0 = ((num > 34u) ? 2619294252u : 2755286584u);
						continue;
					case 28u:
						arg_45E_0 = (num2 * 1619897105u ^ 2842769122u);
						continue;
					case 29u:
						arg_45E_0 = (((num <= 18u) ? 2062851886u : 792937794u) ^ num2 * 379563937u);
						continue;
					case 30u:
						arg_45E_0 = (num2 * 2662060290u ^ 2562310858u);
						continue;
					case 31u:
						input.SkipLastField();
						arg_45E_0 = 3775713713u;
						continue;
					case 32u:
						arg_45E_0 = ((this.clientId_ == null) ? 3431743965u : 3527271730u);
						continue;
					case 33u:
						this.binaryContentHandleArray_ = new ConnectionMeteringContentHandles();
						arg_45E_0 = (num2 * 1790684575u ^ 312001089u);
						continue;
					case 34u:
						arg_45E_0 = ((num != 56u) ? 4010809765u : 2243028052u);
						continue;
					case 35u:
						arg_45E_0 = (num2 * 3552996994u ^ 3641602436u);
						continue;
					case 36u:
						this.clientId_ = new ProcessId();
						arg_45E_0 = (num2 * 1230058455u ^ 2731631738u);
						continue;
					case 37u:
						arg_45E_0 = (num2 * 3771555177u ^ 2997658629u);
						continue;
					case 38u:
						arg_45E_0 = (((num != 34u) ? 2461634467u : 2705413377u) ^ num2 * 2508549672u);
						continue;
					case 39u:
						arg_45E_0 = (num2 * 3388986256u ^ 967543890u);
						continue;
					case 40u:
						arg_45E_0 = 3120437627u;
						continue;
					case 41u:
						this.serverId_ = new ProcessId();
						arg_45E_0 = (num2 * 1148813679u ^ 2086392683u);
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
