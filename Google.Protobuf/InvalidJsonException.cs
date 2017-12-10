using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class InvalidJsonException : IOException
	{
		internal InvalidJsonException(string message) : base(message)
		{
		}
	}
}
