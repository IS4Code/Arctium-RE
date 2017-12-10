using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class DurationReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return DurationReflection.descriptor;
			}
		}

		static DurationReflection()
		{
			DurationReflection.descriptor = FileDescriptor.FromGeneratedCode(DurationReflection.smethod_1(DurationReflection.smethod_0(new string[]
			{
				Module.smethod_37<string>(1135240894u),
				Module.smethod_35<string>(3024674850u),
				Module.smethod_34<string>(843999869u),
				Module.smethod_33<string>(1975178527u),
				Module.smethod_33<string>(3713584047u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(DurationReflection.smethod_2(typeof(Duration).TypeHandle), Duration.Parser, new string[]
				{
					Module.smethod_37<string>(4261522036u),
					Module.smethod_36<string>(2285904943u)
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
