using Google.Protobuf.Compatibility;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class OneofAccessor
	{
		private readonly Func<IMessage, int> caseDelegate;

		private readonly Action<IMessage> clearDelegate;

		private OneofDescriptor descriptor;

		public OneofDescriptor Descriptor
		{
			get
			{
				return this.descriptor;
			}
		}

		internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor)
		{
			if (!OneofAccessor.smethod_0(caseProperty))
			{
				throw OneofAccessor.smethod_1(Module.smethod_33<string>(966859498u));
			}
			this.descriptor = descriptor;
			this.caseDelegate = ReflectionUtil.CreateFuncIMessageT<int>(caseProperty.GetGetMethod());
			this.descriptor = descriptor;
			this.clearDelegate = ReflectionUtil.CreateActionIMessage(clearMethod);
		}

		public void Clear(IMessage message)
		{
			this.clearDelegate(message);
		}

		public FieldDescriptor GetCaseFieldDescriptor(IMessage message)
		{
			int num = this.caseDelegate(message);
			while (true)
			{
				IL_53:
				uint arg_37_0 = 2025652677u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_37_0 ^ 1631287048u)) % 4u)
					{
					case 0u:
						goto IL_5A;
					case 1u:
						arg_37_0 = (((num <= 0) ? 2583119640u : 2655008038u) ^ num2 * 2894021082u);
						continue;
					case 3u:
						goto IL_53;
					}
					goto Block_2;
				}
			}
			Block_2:
			goto IL_6C;
			IL_5A:
			return this.descriptor.ContainingType.FindFieldByNumber(num);
			IL_6C:
			return null;
		}

		static bool smethod_0(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.CanRead;
		}

		static ArgumentException smethod_1(string string_0)
		{
			return new ArgumentException(string_0);
		}
	}
}
