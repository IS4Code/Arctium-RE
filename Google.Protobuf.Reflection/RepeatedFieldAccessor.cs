using System;
using System.Collections;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class RepeatedFieldAccessor : FieldAccessorBase
	{
		internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) : base(property, descriptor)
		{
		}

		public override void Clear(IMessage message)
		{
			RepeatedFieldAccessor.smethod_0((IList)base.GetValue(message));
		}

		public override void SetValue(IMessage message, object value)
		{
			throw RepeatedFieldAccessor.smethod_1(Module.smethod_37<string>(171503620u));
		}

		static void smethod_0(IList ilist_0)
		{
			ilist_0.Clear();
		}

		static InvalidOperationException smethod_1(string string_0)
		{
			return new InvalidOperationException(string_0);
		}
	}
}
