using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class ConnectRequest : IMessage<ConnectRequest>, IEquatable<ConnectRequest>, IDeepCloneable<ConnectRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ConnectRequest.__c __9 = new ConnectRequest.__c();

			internal ConnectRequest cctor>b__34_0()
			{
				return new ConnectRequest();
			}
		}

		private static readonly MessageParser<ConnectRequest> _parser = new MessageParser<ConnectRequest>(new Func<ConnectRequest>(ConnectRequest.__c.__9.<.cctor>b__34_0));

		public const int ClientIdFieldNumber = 1;

		private ProcessId clientId_;

		public const int BindRequestFieldNumber = 2;

		private BindRequest bindRequest_;

		public const int UseBindlessRpcFieldNumber = 3;

		private bool useBindlessRpc_;

		public static MessageParser<ConnectRequest> Parser
		{
			get
			{
				return ConnectRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectRequest.Descriptor;
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

		public BindRequest BindRequest
		{
			get
			{
				return this.bindRequest_;
			}
			set
			{
				this.bindRequest_ = value;
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

		public ConnectRequest()
		{
		}

		public ConnectRequest(ConnectRequest other) : this()
		{
			while (true)
			{
				IL_6B:
				int arg_51_0 = 974275983;
				while (true)
				{
					switch ((arg_51_0 ^ 1649380609) % 4)
					{
					case 0:
						goto IL_6B;
					case 1:
						this.BindRequest = ((other.bindRequest_ != null) ? other.BindRequest.Clone() : null);
						arg_51_0 = 1594688222;
						continue;
					case 2:
						this.ClientId = ((other.clientId_ != null) ? other.ClientId.Clone() : null);
						arg_51_0 = 1676444796;
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.useBindlessRpc_ = other.useBindlessRpc_;
		}

		public ConnectRequest Clone()
		{
			return new ConnectRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectRequest);
		}

		public bool Equals(ConnectRequest other)
		{
			if (other == null)
			{
				goto IL_3F;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ -1010291281) % 11)
				{
				case 0:
					return false;
				case 1:
					arg_A1_0 = (ConnectRequest.smethod_0(this.ClientId, other.ClientId) ? -1624537076 : -1341276263);
					continue;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					arg_A1_0 = ((!ConnectRequest.smethod_0(this.BindRequest, other.BindRequest)) ? -828072472 : -146396006);
					continue;
				case 5:
					goto IL_E7;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_3F;
				case 10:
					arg_A1_0 = ((this.UseBindlessRpc == other.UseBindlessRpc) ? -36175415 : -2044522125);
					continue;
				}
				break;
			}
			return true;
			IL_3F:
			arg_A1_0 = -206111548;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other == this) ? -1961699776 : -2096867863);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_101:
				uint arg_D5_0 = 2744260730u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_D5_0 ^ 2856068951u)) % 8u)
					{
					case 0u:
						goto IL_101;
					case 1u:
						num ^= ConnectRequest.smethod_1(this.ClientId);
						arg_D5_0 = (num2 * 3477154649u ^ 2618185112u);
						continue;
					case 2u:
						num ^= ConnectRequest.smethod_1(this.BindRequest);
						arg_D5_0 = (num2 * 3460489670u ^ 13017039u);
						continue;
					case 4u:
						arg_D5_0 = (this.UseBindlessRpc ? 4007491472u : 3059152500u);
						continue;
					case 5u:
						arg_D5_0 = (((this.clientId_ == null) ? 884979453u : 433912218u) ^ num2 * 2123788196u);
						continue;
					case 6u:
						arg_D5_0 = ((this.bindRequest_ == null) ? 4114987555u : 2828428869u);
						continue;
					case 7u:
						num ^= this.UseBindlessRpc.GetHashCode();
						arg_D5_0 = (num2 * 84725548u ^ 84426048u);
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
			if (this.clientId_ != null)
			{
				goto IL_3E;
			}
			goto IL_E8;
			uint arg_B1_0;
			while (true)
			{
				IL_AC:
				uint num;
				switch ((num = (arg_B1_0 ^ 3534117116u)) % 7u)
				{
				case 0u:
					output.WriteRawTag(24);
					output.WriteBool(this.UseBindlessRpc);
					arg_B1_0 = (num * 2787811467u ^ 1695285745u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					output.WriteMessage(this.ClientId);
					arg_B1_0 = (num * 4230749695u ^ 1365074559u);
					continue;
				case 2u:
					output.WriteRawTag(18);
					output.WriteMessage(this.BindRequest);
					arg_B1_0 = (num * 2610819149u ^ 1698328204u);
					continue;
				case 3u:
					goto IL_3E;
				case 4u:
					arg_B1_0 = (this.UseBindlessRpc ? 3238857668u : 3694472857u);
					continue;
				case 5u:
					goto IL_E8;
				}
				break;
			}
			return;
			IL_3E:
			arg_B1_0 = 3993472570u;
			goto IL_AC;
			IL_E8:
			arg_B1_0 = ((this.bindRequest_ == null) ? 3136060425u : 3226722277u);
			goto IL_AC;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_F5:
				uint arg_C9_0 = 3595148154u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C9_0 ^ 3199973804u)) % 8u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.BindRequest);
						arg_C9_0 = (num2 * 2277659983u ^ 2589349913u);
						continue;
					case 1u:
						num += 2;
						arg_C9_0 = (num2 * 2532710041u ^ 3587581951u);
						continue;
					case 3u:
						arg_C9_0 = ((this.bindRequest_ != null) ? 3819679604u : 3714751665u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientId);
						arg_C9_0 = (num2 * 3389745774u ^ 1905562591u);
						continue;
					case 5u:
						arg_C9_0 = ((!this.UseBindlessRpc) ? 3678631742u : 2453820869u);
						continue;
					case 6u:
						arg_C9_0 = (((this.clientId_ != null) ? 3768983612u : 4287487611u) ^ num2 * 973834210u);
						continue;
					case 7u:
						goto IL_F5;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ConnectRequest other)
		{
			if (other == null)
			{
				goto IL_A6;
			}
			goto IL_197;
			uint arg_147_0;
			while (true)
			{
				IL_142:
				uint num;
				switch ((num = (arg_147_0 ^ 3106712805u)) % 13u)
				{
				case 0u:
					goto IL_197;
				case 1u:
					return;
				case 2u:
					this.ClientId.MergeFrom(other.ClientId);
					arg_147_0 = 2221389944u;
					continue;
				case 3u:
					arg_147_0 = ((!other.UseBindlessRpc) ? 3997822109u : 2378936070u);
					continue;
				case 4u:
					this.BindRequest.MergeFrom(other.BindRequest);
					arg_147_0 = 3130869119u;
					continue;
				case 5u:
					arg_147_0 = (((this.bindRequest_ == null) ? 2468135459u : 2705724859u) ^ num * 860489117u);
					continue;
				case 6u:
					this.bindRequest_ = new BindRequest();
					arg_147_0 = (num * 1485037067u ^ 1712956727u);
					continue;
				case 8u:
					goto IL_A6;
				case 9u:
					this.clientId_ = new ProcessId();
					arg_147_0 = (num * 1077431259u ^ 85333283u);
					continue;
				case 10u:
					arg_147_0 = (((this.clientId_ == null) ? 919371740u : 1715507902u) ^ num * 1656500431u);
					continue;
				case 11u:
					this.UseBindlessRpc = other.UseBindlessRpc;
					arg_147_0 = (num * 3660935869u ^ 3826128906u);
					continue;
				case 12u:
					arg_147_0 = ((other.bindRequest_ == null) ? 3130869119u : 3200117558u);
					continue;
				}
				break;
			}
			return;
			IL_A6:
			arg_147_0 = 2639365409u;
			goto IL_142;
			IL_197:
			arg_147_0 = ((other.clientId_ != null) ? 2373019336u : 2221389944u);
			goto IL_142;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1F0:
				uint num;
				uint arg_190_0 = ((num = input.ReadTag()) != 0u) ? 1371810289u : 752352594u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_190_0 ^ 306906795u)) % 17u)
					{
					case 0u:
						arg_190_0 = 1371810289u;
						continue;
					case 1u:
						arg_190_0 = (num2 * 1515340795u ^ 230630611u);
						continue;
					case 2u:
						arg_190_0 = (num2 * 3233260783u ^ 1950446096u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_190_0 = (num2 * 2223825229u ^ 917704656u);
						continue;
					case 5u:
						this.clientId_ = new ProcessId();
						arg_190_0 = (num2 * 2739254603u ^ 1620559402u);
						continue;
					case 6u:
						arg_190_0 = (num2 * 1185139482u ^ 1563886363u);
						continue;
					case 7u:
						arg_190_0 = ((num == 10u) ? 1020026748u : 226027239u);
						continue;
					case 8u:
						arg_190_0 = (((num != 18u) ? 2190378563u : 3621681721u) ^ num2 * 2181607462u);
						continue;
					case 9u:
						arg_190_0 = ((this.clientId_ == null) ? 1116751169u : 1673826724u);
						continue;
					case 10u:
						goto IL_1F0;
					case 11u:
						arg_190_0 = (((num == 24u) ? 4086085689u : 3341415962u) ^ num2 * 802951963u);
						continue;
					case 12u:
						input.ReadMessage(this.bindRequest_);
						arg_190_0 = 1955026354u;
						continue;
					case 13u:
						arg_190_0 = ((this.bindRequest_ == null) ? 22822262u : 2100341830u);
						continue;
					case 14u:
						input.ReadMessage(this.clientId_);
						arg_190_0 = 1596127524u;
						continue;
					case 15u:
						this.UseBindlessRpc = input.ReadBool();
						arg_190_0 = 1755791505u;
						continue;
					case 16u:
						this.bindRequest_ = new BindRequest();
						arg_190_0 = (num2 * 1139545627u ^ 1952768521u);
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
