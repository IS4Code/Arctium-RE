using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public interface IDescriptor
	{
		string Name
		{
			get;
		}

		string FullName
		{
			get;
		}

		FileDescriptor File
		{
			get;
		}
	}
}
