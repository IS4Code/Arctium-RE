using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public enum FieldType
	{
		Double,
		Float,
		Int64,
		UInt64,
		Int32,
		Fixed64,
		Fixed32,
		Bool,
		String,
		Group,
		Message,
		Bytes,
		UInt32,
		SFixed32,
		SFixed64,
		SInt32,
		SInt64,
		Enum
	}
}
