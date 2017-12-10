using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class StructReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return StructReflection.descriptor;
			}
		}

		static StructReflection()
		{
			StructReflection.descriptor = FileDescriptor.FromGeneratedCode(StructReflection.smethod_1(StructReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(217101131u),
				Module.smethod_33<string>(2961001161u),
				Module.smethod_35<string>(3079946880u),
				Module.smethod_33<string>(3779157417u),
				Module.smethod_37<string>(1281186676u),
				Module.smethod_37<string>(4232108900u),
				Module.smethod_34<string>(2262389739u),
				Module.smethod_36<string>(55025584u),
				Module.smethod_35<string>(1764904992u),
				Module.smethod_36<string>(842332112u),
				Module.smethod_37<string>(3881508948u),
				Module.smethod_33<string>(506532393u),
				Module.smethod_34<string>(12711051u),
				Module.smethod_37<string>(4150146815u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(new System.Type[]
			{
				StructReflection.smethod_2(typeof(NullValue).TypeHandle)
			}, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(StructReflection.smethod_2(typeof(Struct).TypeHandle), Struct.Parser, new string[]
				{
					Module.smethod_33<string>(2347030921u)
				}, null, null, new GeneratedCodeInfo[1]),
				new GeneratedCodeInfo(StructReflection.smethod_2(typeof(Value).TypeHandle), Value.Parser, new string[]
				{
					Module.smethod_36<string>(3490343807u),
					Module.smethod_35<string>(1317345691u),
					Module.smethod_35<string>(2760291134u),
					Module.smethod_37<string>(2367881274u),
					Module.smethod_35<string>(1569186335u),
					Module.smethod_34<string>(359994132u)
				}, new string[]
				{
					Module.smethod_34<string>(641203968u)
				}, null, null),
				new GeneratedCodeInfo(StructReflection.smethod_2(typeof(ListValue).TypeHandle), ListValue.Parser, new string[]
				{
					Module.smethod_37<string>(1836352385u)
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
