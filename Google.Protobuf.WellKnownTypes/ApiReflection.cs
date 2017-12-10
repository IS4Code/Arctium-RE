using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class ApiReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ApiReflection.descriptor;
			}
		}

		static ApiReflection()
		{
			ApiReflection.descriptor = FileDescriptor.FromGeneratedCode(ApiReflection.smethod_1(ApiReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(2378405414u),
				Module.smethod_34<string>(4020298166u),
				Module.smethod_35<string>(2646630565u),
				Module.smethod_37<string>(2303897577u),
				Module.smethod_36<string>(1377392397u),
				Module.smethod_36<string>(4109486173u),
				Module.smethod_34<string>(2895458822u),
				Module.smethod_34<string>(1770619478u),
				Module.smethod_34<string>(2145565926u),
				Module.smethod_35<string>(2338951253u),
				Module.smethod_34<string>(1395673030u),
				Module.smethod_37<string>(1807175017u),
				Module.smethod_34<string>(645780134u),
				Module.smethod_34<string>(3815908086u),
				Module.smethod_35<string>(3346313829u),
				Module.smethod_36<string>(1747566589u)
			})), new FileDescriptor[]
			{
				SourceContextReflection.Descriptor,
				TypeReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ApiReflection.smethod_2(typeof(Api).TypeHandle), Api.Parser, new string[]
				{
					Module.smethod_33<string>(1982348402u),
					Module.smethod_33<string>(3119285818u),
					Module.smethod_35<string>(1556926582u),
					Module.smethod_33<string>(3069454152u),
					Module.smethod_37<string>(3501849512u),
					Module.smethod_35<string>(310549753u),
					Module.smethod_35<string>(1485711652u)
				}, null, null, null),
				new GeneratedCodeInfo(ApiReflection.smethod_2(typeof(Method).TypeHandle), Method.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_33<string>(345423352u),
					Module.smethod_37<string>(3151249560u),
					Module.smethod_34<string>(2222385682u),
					Module.smethod_34<string>(1406419541u),
					Module.smethod_36<string>(1842157958u),
					Module.smethod_34<string>(430643543u)
				}, null, null, null),
				new GeneratedCodeInfo(ApiReflection.smethod_2(typeof(Mixin).TypeHandle), Mixin.Parser, new string[]
				{
					Module.smethod_33<string>(1982348402u),
					Module.smethod_33<string>(837628573u)
				}, null, null, null)
			}));
		}

		static string smethod_0(string[] string_0)
		{
			return string.Concat(string_0);
		}

		static byte[] smethod_1(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}

		static System.Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
