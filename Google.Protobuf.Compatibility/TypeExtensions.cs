using System;
using System.Reflection;

namespace Google.Protobuf.Compatibility
{
	internal static class TypeExtensions
	{
		internal static bool IsValueType(this Type target)
		{
			return TypeExtensions.smethod_1(TypeExtensions.smethod_0(target));
		}

		internal static bool IsAssignableFrom(this Type target, Type c)
		{
			return TypeExtensions.smethod_2(TypeExtensions.smethod_0(target), TypeExtensions.smethod_0(c));
		}

		internal static PropertyInfo GetProperty(this Type target, string name)
		{
			while (true)
			{
				IL_173:
				uint arg_127_0 = (target != null) ? 3462574241u : 2188921634u;
				while (true)
				{
					uint num;
					switch ((num = (arg_127_0 ^ 3380171852u)) % 12u)
					{
					case 0u:
					{
						PropertyInfo propertyInfo;
						arg_127_0 = ((!TypeExtensions.smethod_7(propertyInfo)) ? 3618814751u : 2973301651u);
						continue;
					}
					case 1u:
					{
						TypeInfo typeInfo = TypeExtensions.smethod_0(target);
						arg_127_0 = 3231725208u;
						continue;
					}
					case 2u:
						arg_127_0 = 3462574241u;
						continue;
					case 3u:
					{
						TypeInfo typeInfo;
						target = TypeExtensions.smethod_9(typeInfo);
						arg_127_0 = 2243421325u;
						continue;
					}
					case 4u:
					{
						PropertyInfo propertyInfo;
						return propertyInfo;
					}
					case 5u:
					{
						PropertyInfo propertyInfo;
						arg_127_0 = (((propertyInfo != null) ? 3875040517u : 4036738732u) ^ num * 4172870815u);
						continue;
					}
					case 6u:
					{
						PropertyInfo propertyInfo;
						arg_127_0 = (((!TypeExtensions.smethod_4(propertyInfo)) ? 2465284096u : 3240594463u) ^ num * 3716117260u);
						continue;
					}
					case 7u:
					{
						PropertyInfo propertyInfo;
						arg_127_0 = ((TypeExtensions.smethod_6(TypeExtensions.smethod_8(propertyInfo)) ? 1083058896u : 547771499u) ^ num * 1931570956u);
						continue;
					}
					case 8u:
					{
						TypeInfo typeInfo;
						PropertyInfo propertyInfo = TypeExtensions.smethod_3(typeInfo, name);
						arg_127_0 = (num * 1158742807u ^ 2567007021u);
						continue;
					}
					case 9u:
						goto IL_173;
					case 11u:
					{
						PropertyInfo propertyInfo;
						arg_127_0 = ((TypeExtensions.smethod_6(TypeExtensions.smethod_5(propertyInfo)) ? 3951386411u : 3282301751u) ^ num * 2213342445u);
						continue;
					}
					}
					goto Block_6;
				}
			}
			Block_6:
			return null;
		}

		internal static MethodInfo GetMethod(this Type target, string name)
		{
			while (true)
			{
				IL_CA:
				uint arg_8F_0 = (target == null) ? 2521468880u : 2181048316u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8F_0 ^ 2469246798u)) % 8u)
					{
					case 0u:
						arg_8F_0 = 2181048316u;
						continue;
					case 1u:
					{
						TypeInfo typeInfo;
						target = TypeExtensions.smethod_9(typeInfo);
						arg_8F_0 = 4021995645u;
						continue;
					}
					case 2u:
					{
						TypeInfo typeInfo = TypeExtensions.smethod_0(target);
						MethodInfo methodInfo = TypeExtensions.smethod_10(typeInfo, name);
						arg_8F_0 = 2376643290u;
						continue;
					}
					case 3u:
						goto IL_CA;
					case 4u:
					{
						MethodInfo methodInfo;
						arg_8F_0 = (((methodInfo != null) ? 1298327965u : 61772627u) ^ num * 1060594473u);
						continue;
					}
					case 5u:
					{
						MethodInfo methodInfo;
						return methodInfo;
					}
					case 7u:
					{
						MethodInfo methodInfo;
						arg_8F_0 = (((!TypeExtensions.smethod_6(methodInfo)) ? 2160196137u : 4256106933u) ^ num * 185674498u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			return null;
		}

		static TypeInfo smethod_0(Type type_0)
		{
			return type_0.GetTypeInfo();
		}

		static bool smethod_1(Type type_0)
		{
			return type_0.IsValueType;
		}

		static bool smethod_2(TypeInfo typeInfo_0, TypeInfo typeInfo_1)
		{
			return typeInfo_0.IsAssignableFrom(typeInfo_1);
		}

		static PropertyInfo smethod_3(TypeInfo typeInfo_0, string string_0)
		{
			return typeInfo_0.GetDeclaredProperty(string_0);
		}

		static bool smethod_4(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.CanRead;
		}

		static MethodInfo smethod_5(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.GetMethod;
		}

		static bool smethod_6(MethodBase methodBase_0)
		{
			return methodBase_0.IsPublic;
		}

		static bool smethod_7(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.CanWrite;
		}

		static MethodInfo smethod_8(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.SetMethod;
		}

		static Type smethod_9(Type type_0)
		{
			return type_0.BaseType;
		}

		static MethodInfo smethod_10(TypeInfo typeInfo_0, string string_0)
		{
			return typeInfo_0.GetDeclaredMethod(string_0);
		}
	}
}
