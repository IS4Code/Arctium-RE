using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class InvalidProtocolBufferException : IOException
	{
		internal InvalidProtocolBufferException(string message) : base(message)
		{
		}

		internal static InvalidProtocolBufferException MoreDataAvailable()
		{
			return new InvalidProtocolBufferException(Module.smethod_35<string>(2463454980u));
		}

		internal static InvalidProtocolBufferException TruncatedMessage()
		{
			return new InvalidProtocolBufferException(Module.smethod_36<string>(2692670483u));
		}

		internal static InvalidProtocolBufferException NegativeSize()
		{
			return new InvalidProtocolBufferException(Module.smethod_34<string>(1852015400u));
		}

		internal static InvalidProtocolBufferException MalformedVarint()
		{
			return new InvalidProtocolBufferException(Module.smethod_33<string>(1505469701u));
		}

		internal static InvalidProtocolBufferException InvalidTag()
		{
			return new InvalidProtocolBufferException(Module.smethod_34<string>(3109001234u));
		}

		internal static InvalidProtocolBufferException InvalidEndTag()
		{
			return new InvalidProtocolBufferException(Module.smethod_37<string>(2712675439u));
		}

		internal static InvalidProtocolBufferException RecursionLimitExceeded()
		{
			return new InvalidProtocolBufferException(Module.smethod_35<string>(3932619843u));
		}

		internal static InvalidProtocolBufferException JsonRecursionLimitExceeded()
		{
			return new InvalidProtocolBufferException(Module.smethod_36<string>(3560781023u));
		}

		internal static InvalidProtocolBufferException SizeLimitExceeded()
		{
			return new InvalidProtocolBufferException(Module.smethod_34<string>(3334884336u));
		}

		internal static InvalidProtocolBufferException InvalidMessageStreamTag()
		{
			return new InvalidProtocolBufferException(Module.smethod_35<string>(15413513u));
		}
	}
}
