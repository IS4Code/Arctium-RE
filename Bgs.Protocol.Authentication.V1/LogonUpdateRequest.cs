using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class LogonUpdateRequest : IMessage<LogonUpdateRequest>, IEquatable<LogonUpdateRequest>, IDeepCloneable<LogonUpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly LogonUpdateRequest.__c __9 = new LogonUpdateRequest.__c();

			internal LogonUpdateRequest cctor>b__24_0()
			{
				return new LogonUpdateRequest();
			}
		}

		private static readonly MessageParser<LogonUpdateRequest> _parser = new MessageParser<LogonUpdateRequest>(new Func<LogonUpdateRequest>(LogonUpdateRequest.__c.__9.<.cctor>b__24_0));

		public const int ErrorCodeFieldNumber = 1;

		private uint errorCode_;

		public static MessageParser<LogonUpdateRequest> Parser
		{
			get
			{
				return LogonUpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonUpdateRequest.Descriptor;
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

		public LogonUpdateRequest()
		{
		}

		public LogonUpdateRequest(LogonUpdateRequest other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 4233209226u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 2416552629u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 1u:
						this.errorCode_ = other.errorCode_;
						arg_26_0 = (num * 2786371169u ^ 2210251445u);
						continue;
					}
					return;
				}
			}
		}

		public LogonUpdateRequest Clone()
		{
			return new LogonUpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as LogonUpdateRequest);
		}

		public bool Equals(LogonUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ 753742142) % 7)
				{
				case 0:
					goto IL_75;
				case 1:
					arg_43_0 = ((this.ErrorCode != other.ErrorCode) ? 86275331 : 862464303);
					continue;
				case 2:
					goto IL_12;
				case 3:
					return true;
				case 5:
					return false;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = 148031786;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? 1674377952 : 88515785);
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
				uint arg_27_0 = 1136781083u;
				while (true)
				{
					uint num;
					switch ((num = (arg_27_0 ^ 322525344u)) % 3u)
					{
					case 1u:
						output.WriteUInt32(this.ErrorCode);
						arg_27_0 = (num * 534097979u ^ 3638565549u);
						continue;
					case 2u:
						goto IL_3F;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode));
		}

		public void MergeFrom(LogonUpdateRequest other)
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
				switch ((num = (arg_37_0 ^ 4075795228u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					this.ErrorCode = other.ErrorCode;
					arg_37_0 = (num * 1021223748u ^ 2410260469u);
					continue;
				case 2u:
					goto IL_63;
				case 3u:
					return;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 2165230882u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.ErrorCode != 0u) ? 3996121206u : 3735888349u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_95:
				uint num;
				uint arg_62_0 = ((num = input.ReadTag()) == 0u) ? 1399580622u : 989310458u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 377934633u)) % 6u)
					{
					case 0u:
						arg_62_0 = 989310458u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_62_0 = (num2 * 2999342772u ^ 1970452062u);
						continue;
					case 3u:
						goto IL_95;
					case 4u:
						this.ErrorCode = input.ReadUInt32();
						arg_62_0 = 296288718u;
						continue;
					case 5u:
						arg_62_0 = ((num == 8u) ? 483797821u : 641542877u);
						continue;
					}
					return;
				}
			}
		}
	}
}
