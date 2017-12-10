using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class CredentialUpdateResponse : IMessage<CredentialUpdateResponse>, IEquatable<CredentialUpdateResponse>, IDeepCloneable<CredentialUpdateResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CredentialUpdateResponse.__c __9 = new CredentialUpdateResponse.__c();

			internal CredentialUpdateResponse cctor>b__19_0()
			{
				return new CredentialUpdateResponse();
			}
		}

		private static readonly MessageParser<CredentialUpdateResponse> _parser = new MessageParser<CredentialUpdateResponse>(new Func<CredentialUpdateResponse>(CredentialUpdateResponse.__c.__9.<.cctor>b__19_0));

		public static MessageParser<CredentialUpdateResponse> Parser
		{
			get
			{
				return CredentialUpdateResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CredentialUpdateResponse.Descriptor;
			}
		}

		public CredentialUpdateResponse()
		{
		}

		public CredentialUpdateResponse(CredentialUpdateResponse other) : this()
		{
		}

		public CredentialUpdateResponse Clone()
		{
			return new CredentialUpdateResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as CredentialUpdateResponse);
		}

		public bool Equals(CredentialUpdateResponse other)
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

		public void MergeFrom(CredentialUpdateResponse other)
		{
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4D:
				int arg_27_0 = (input.ReadTag() == 0u) ? 584742882 : 1961906649;
				while (true)
				{
					switch ((arg_27_0 ^ 620734972) % 4)
					{
					case 0:
						goto IL_4D;
					case 1:
						input.SkipLastField();
						arg_27_0 = 1831403312;
						continue;
					case 3:
						arg_27_0 = 1961906649;
						continue;
					}
					return;
				}
			}
		}
	}
}
