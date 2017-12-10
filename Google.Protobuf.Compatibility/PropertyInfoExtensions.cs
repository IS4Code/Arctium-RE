using System;
using System.Reflection;

namespace Google.Protobuf.Compatibility
{
	internal static class PropertyInfoExtensions
	{
		internal static MethodInfo GetGetMethod(this PropertyInfo target)
		{
			MethodInfo methodInfo = PropertyInfoExtensions.smethod_0(target);
			if (methodInfo != null)
			{
				while (true)
				{
					IL_54:
					uint arg_38_0 = 1494271457u;
					while (true)
					{
						uint num;
						switch ((num = (arg_38_0 ^ 484998251u)) % 4u)
						{
						case 0u:
							goto IL_54;
						case 2u:
							arg_38_0 = (((!PropertyInfoExtensions.smethod_1(methodInfo)) ? 3432170434u : 2262786992u) ^ num * 3783810197u);
							continue;
						case 3u:
							goto IL_5D;
						}
						return methodInfo;
					}
				}
				return methodInfo;
			}
			IL_5D:
			return null;
		}

		internal static MethodInfo GetSetMethod(this PropertyInfo target)
		{
			MethodInfo methodInfo = PropertyInfoExtensions.smethod_2(target);
			while (true)
			{
				IL_79:
				uint arg_59_0 = 2129891743u;
				while (true)
				{
					uint num;
					switch ((num = (arg_59_0 ^ 1115668176u)) % 5u)
					{
					case 1u:
						arg_59_0 = (((methodInfo == null) ? 1077691168u : 1214720016u) ^ num * 1832542328u);
						continue;
					case 2u:
						goto IL_79;
					case 3u:
						goto IL_82;
					case 4u:
						arg_59_0 = ((PropertyInfoExtensions.smethod_1(methodInfo) ? 289477862u : 1433665736u) ^ num * 1747856828u);
						continue;
					}
					return methodInfo;
				}
			}
			return methodInfo;
			IL_82:
			return null;
		}

		static MethodInfo smethod_0(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.GetMethod;
		}

		static bool smethod_1(MethodBase methodBase_0)
		{
			return methodBase_0.IsPublic;
		}

		static MethodInfo smethod_2(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.SetMethod;
		}
	}
}
