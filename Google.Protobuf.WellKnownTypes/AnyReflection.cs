using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class AnyReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return AnyReflection.descriptor;
			}
		}

		static AnyReflection()
		{
			AnyReflection.descriptor = FileDescriptor.FromGeneratedCode(AnyReflection.smethod_1(AnyReflection.smethod_0(Module.smethod_36<string>(3424557400u), Module.smethod_33<string>(3013459857u), Module.smethod_34<string>(1019132403u), Module.smethod_37<string>(1923796076u))), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(AnyReflection.smethod_2(typeof(Any).TypeHandle), Any.Parser, new string[]
				{
					Module.smethod_35<string>(2589658621u),
					Module.smethod_36<string>(994248421u)
				}, null, null, null)
			}));
		}

		static string smethod_0(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
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
