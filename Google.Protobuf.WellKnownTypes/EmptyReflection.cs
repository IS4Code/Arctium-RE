using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class EmptyReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return EmptyReflection.descriptor;
			}
		}

		static EmptyReflection()
		{
			EmptyReflection.descriptor = FileDescriptor.FromGeneratedCode(EmptyReflection.smethod_1(EmptyReflection.smethod_0(Module.smethod_37<string>(2070213394u), Module.smethod_35<string>(3780196782u), Module.smethod_35<string>(3122675838u), Module.smethod_33<string>(255339095u))), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(EmptyReflection.smethod_2(typeof(Empty).TypeHandle), Empty.Parser, null, null, null, null)
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
