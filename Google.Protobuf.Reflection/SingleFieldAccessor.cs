using Google.Protobuf.Compatibility;
using System;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class SingleFieldAccessor : FieldAccessorBase
	{
		private readonly Action<IMessage, object> setValueDelegate;

		private readonly Action<IMessage> clearDelegate;

		internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) : base(property, descriptor)
		{
			while (true)
			{
				IL_10F:
				uint arg_E3_0 = 1941025569u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E3_0 ^ 199827664u)) % 8u)
					{
					case 1u:
						arg_E3_0 = (num * 3210510662u ^ 4032699640u);
						continue;
					case 2u:
						goto IL_10F;
					case 3u:
						goto IL_116;
					case 4u:
					{
						Type type;
						__c__DisplayClass2_.defaultValue = ((descriptor.FieldType == FieldType.Message) ? null : ((type == SingleFieldAccessor.smethod_3(typeof(string).TypeHandle)) ? "" : ((type == SingleFieldAccessor.smethod_3(typeof(ByteString).TypeHandle)) ? ByteString.Empty : SingleFieldAccessor.smethod_4(type))));
						this.clearDelegate = delegate(IMessage message)
						{
							__c__DisplayClass2_.__4__this.SetValue(message, __c__DisplayClass2_.defaultValue);
						};
						arg_E3_0 = 1884219440u;
						continue;
					}
					case 5u:
						this.setValueDelegate = ReflectionUtil.CreateActionIMessageObject(property.GetSetMethod());
						arg_E3_0 = 2064311039u;
						continue;
					case 6u:
						__c__DisplayClass2_.__4__this = this;
						arg_E3_0 = ((SingleFieldAccessor.smethod_0(property) ? 2142081437u : 1483086867u) ^ num * 2346426732u);
						continue;
					case 7u:
					{
						Type type = SingleFieldAccessor.smethod_2(property);
						arg_E3_0 = (num * 1124000945u ^ 3750043923u);
						continue;
					}
					}
					goto Block_5;
				}
			}
			Block_5:
			return;
			IL_116:
			throw SingleFieldAccessor.smethod_1(Module.smethod_35<string>(1200568613u));
		}

		public override void Clear(IMessage message)
		{
			this.clearDelegate(message);
		}

		public override void SetValue(IMessage message, object value)
		{
			this.setValueDelegate(message, value);
		}

		static bool smethod_0(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.CanWrite;
		}

		static ArgumentException smethod_1(string string_0)
		{
			return new ArgumentException(string_0);
		}

		static Type smethod_2(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.PropertyType;
		}

		static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static object smethod_4(Type type_0)
		{
			return Activator.CreateInstance(type_0);
		}
	}
}
