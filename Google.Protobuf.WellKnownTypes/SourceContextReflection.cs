using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class SourceContextReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return SourceContextReflection.descriptor;
			}
		}

		static SourceContextReflection()
		{
			SourceContextReflection.descriptor = FileDescriptor.FromGeneratedCode(SourceContextReflection.smethod_1(SourceContextReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(3432122179u),
				Module.smethod_35<string>(1807633950u),
				Module.smethod_33<string>(1388849827u),
				Module.smethod_35<string>(1289143038u),
				Module.smethod_34<string>(2130243249u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(SourceContextReflection.smethod_2(typeof(SourceContext).TypeHandle), SourceContext.Parser, new string[]
				{
					Module.smethod_35<string>(2212464293u)
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
