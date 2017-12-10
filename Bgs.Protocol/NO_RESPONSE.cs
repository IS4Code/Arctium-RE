using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class NO_RESPONSE : IMessage<NO_RESPONSE>, IEquatable<NO_RESPONSE>, IDeepCloneable<NO_RESPONSE>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly NO_RESPONSE.__c __9 = new NO_RESPONSE.__c();

			internal NO_RESPONSE cctor>b__19_0()
			{
				return new NO_RESPONSE();
			}
		}

		private static readonly MessageParser<NO_RESPONSE> _parser = new MessageParser<NO_RESPONSE>(new Func<NO_RESPONSE>(NO_RESPONSE.__c.__9.<.cctor>b__19_0));

		public static MessageParser<NO_RESPONSE> Parser
		{
			get
			{
				return NO_RESPONSE._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NO_RESPONSE.Descriptor;
			}
		}

		public NO_RESPONSE()
		{
		}

		public NO_RESPONSE(NO_RESPONSE other) : this()
		{
		}

		public NO_RESPONSE Clone()
		{
			return new NO_RESPONSE(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as NO_RESPONSE);
		}

		public bool Equals(NO_RESPONSE other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 1504404527;
			IL_08:
			switch ((arg_0D_0 ^ 1432572113) % 4)
			{
			case 0:
				goto IL_03;
			case 2:
				return false;
			case 3:
				IL_27:
				arg_0D_0 = 243796716;
				goto IL_08;
			}
			return true;
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

		public void MergeFrom(NO_RESPONSE other)
		{
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4D:
				int arg_27_0 = (input.ReadTag() != 0u) ? -1196816649 : -424471768;
				while (true)
				{
					switch ((arg_27_0 ^ -1361820811) % 4)
					{
					case 0:
						arg_27_0 = -1196816649;
						continue;
					case 2:
						input.SkipLastField();
						arg_27_0 = -1152677838;
						continue;
					case 3:
						goto IL_4D;
					}
					return;
				}
			}
		}
	}
}
