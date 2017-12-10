using System;
using System.Collections;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class MapFieldAccessor : FieldAccessorBase
	{
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) : base(property, descriptor)
		{
		}

		public override void Clear(IMessage message)
		{
			MapFieldAccessor.smethod_0((IDictionary)base.GetValue(message));
		}

		public override void SetValue(IMessage message, object value)
		{
			throw MapFieldAccessor.smethod_1(Module.smethod_37<string>(1983005471u));
		}

		static void smethod_0(IDictionary idictionary_0)
		{
			idictionary_0.Clear();
		}

		static InvalidOperationException smethod_1(string string_0)
		{
			return new InvalidOperationException(string_0);
		}
	}
}
