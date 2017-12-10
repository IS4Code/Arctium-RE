using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class DisconnectRequest : IMessage<DisconnectRequest>, IEquatable<DisconnectRequest>, IDeepCloneable<DisconnectRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly DisconnectRequest.__c __9 = new DisconnectRequest.__c();

			internal DisconnectRequest cctor>b__24_0()
			{
				return new DisconnectRequest();
			}
		}

		private static readonly MessageParser<DisconnectRequest> _parser = new MessageParser<DisconnectRequest>(new Func<DisconnectRequest>(DisconnectRequest.__c.__9.<.cctor>b__24_0));

		public const int ErrorCodeFieldNumber = 1;

		private uint errorCode_;

		public static MessageParser<DisconnectRequest> Parser
		{
			get
			{
				return DisconnectRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisconnectRequest.Descriptor;
			}
		}

		public uint ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		public DisconnectRequest()
		{
		}

		public DisconnectRequest(DisconnectRequest other) : this()
		{
			this.errorCode_ = other.errorCode_;
		}

		public DisconnectRequest Clone()
		{
			return new DisconnectRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as DisconnectRequest);
		}

		public bool Equals(DisconnectRequest other)
		{
			if (other == null)
			{
				goto IL_39;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ 846911889) % 7)
				{
				case 0:
					goto IL_39;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					goto IL_75;
				case 6:
					arg_43_0 = ((this.ErrorCode == other.ErrorCode) ? 1046055578 : 1142339315);
					continue;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = 552822906;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? 1480612640 : 345484948);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.ErrorCode.GetHashCode();
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
				IL_3F:
				uint arg_27_0 = 1945642718u;
				while (true)
				{
					uint num;
					switch ((num = (arg_27_0 ^ 169963591u)) % 3u)
					{
					case 0u:
						goto IL_3F;
					case 1u:
						output.WriteUInt32(this.ErrorCode);
						arg_27_0 = (num * 3921587424u ^ 1129781225u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode));
		}

		public void MergeFrom(DisconnectRequest other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 1562442400u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					goto IL_63;
				case 2u:
					return;
				case 4u:
					this.ErrorCode = other.ErrorCode;
					arg_37_0 = (num * 3169906241u ^ 4167406657u);
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1822491181u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.ErrorCode == 0u) ? 1013786257u : 1230726256u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A8:
				uint num;
				uint arg_71_0 = ((num = input.ReadTag()) == 0u) ? 2012297740u : 404532366u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_71_0 ^ 1049630140u)) % 7u)
					{
					case 0u:
						arg_71_0 = 404532366u;
						continue;
					case 2u:
						arg_71_0 = ((num != 8u) ? 146743553u : 464673405u);
						continue;
					case 3u:
						goto IL_A8;
					case 4u:
						arg_71_0 = (num2 * 3442553522u ^ 3277749837u);
						continue;
					case 5u:
						this.ErrorCode = input.ReadUInt32();
						arg_71_0 = 1298900303u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_71_0 = (num2 * 2843920508u ^ 2155900505u);
						continue;
					}
					return;
				}
			}
		}
	}
}
