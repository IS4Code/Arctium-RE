using Google.Protobuf.Compatibility;
using System;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal abstract class FieldAccessorBase : IFieldAccessor
	{
		private readonly Func<IMessage, object> getValueDelegate;

		private readonly FieldDescriptor descriptor;

		public FieldDescriptor Descriptor
		{
			get
			{
				return this.descriptor;
			}
		}

		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor)
		{
			while (true)
			{
				IL_4A:
				uint arg_32_0 = 603488631u;
				while (true)
				{
					uint num;
					switch ((num = (arg_32_0 ^ 755106210u)) % 3u)
					{
					case 0u:
						goto IL_4A;
					case 2u:
						this.descriptor = descriptor;
						this.getValueDelegate = ReflectionUtil.CreateFuncIMessageObject(property.GetGetMethod());
						arg_32_0 = (num * 2587189340u ^ 1876080986u);
						continue;
					}
					return;
				}
			}
		}

		public object GetValue(IMessage message)
		{
			return this.getValueDelegate(message);
		}

		public abstract void Clear(IMessage message);

		public abstract void SetValue(IMessage message, object value);
	}
}
