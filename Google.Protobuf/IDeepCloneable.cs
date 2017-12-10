using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public interface IDeepCloneable<T>
	{
		T Clone();
	}
}
