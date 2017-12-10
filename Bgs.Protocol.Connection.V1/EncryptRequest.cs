using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class EncryptRequest : IMessage<EncryptRequest>, IEquatable<EncryptRequest>, IDeepCloneable<EncryptRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EncryptRequest.__c __9 = new EncryptRequest.__c();

			internal EncryptRequest cctor>b__19_0()
			{
				return new EncryptRequest();
			}
		}

		private static readonly MessageParser<EncryptRequest> _parser = new MessageParser<EncryptRequest>(new Func<EncryptRequest>(EncryptRequest.__c.__9.<.cctor>b__19_0));

		public static MessageParser<EncryptRequest> Parser
		{
			get
			{
				return EncryptRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncryptRequest.Descriptor;
			}
		}

		public EncryptRequest()
		{
		}

		public EncryptRequest(EncryptRequest other) : this()
		{
		}

		public EncryptRequest Clone()
		{
			return new EncryptRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EncryptRequest);
		}

		public bool Equals(EncryptRequest other)
		{
			return other != null;
		}

		public override int GetHashCode()
		{
			return 1;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
		}

		public int CalculateSize()
		{
			return 0;
		}

		public void MergeFrom(EncryptRequest other)
		{
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4D:
				int arg_27_0 = (input.ReadTag() == 0u) ? 1729650050 : 542676124;
				while (true)
				{
					switch ((arg_27_0 ^ 586479465) % 4)
					{
					case 0:
						goto IL_4D;
					case 1:
						input.SkipLastField();
						arg_27_0 = 1348997813;
						continue;
					case 2:
						arg_27_0 = 542676124;
						continue;
					}
					return;
				}
			}
		}
	}
}
