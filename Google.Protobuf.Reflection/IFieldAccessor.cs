using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public interface IFieldAccessor
	{
		FieldDescriptor Descriptor
		{
			get;
		}

		void Clear(IMessage message);

		object GetValue(IMessage message);

		void SetValue(IMessage message, object value);
	}
}
