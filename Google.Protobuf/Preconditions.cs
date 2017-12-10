using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public static class Preconditions
	{
		public static T CheckNotNull<T>(T value, string name) where T : class
		{
			if (value == null)
			{
				throw Preconditions.smethod_0(name);
			}
			return value;
		}

		internal static T CheckNotNullUnconstrained<T>(T value, string name)
		{
			if (value == null)
			{
				throw Preconditions.smethod_0(name);
			}
			return value;
		}

		static ArgumentNullException smethod_0(string string_0)
		{
			return new ArgumentNullException(string_0);
		}
	}
}
