using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class TimestampReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return TimestampReflection.descriptor;
			}
		}

		static TimestampReflection()
		{
			TimestampReflection.descriptor = FileDescriptor.FromGeneratedCode(TimestampReflection.smethod_1(TimestampReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3623858696u),
				Module.smethod_34<string>(3998805144u),
				Module.smethod_33<string>(1036669444u),
				Module.smethod_36<string>(3823394062u),
				Module.smethod_33<string>(2207006083u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(TimestampReflection.smethod_2(typeof(Timestamp).TypeHandle), Timestamp.Parser, new string[]
				{
					Module.smethod_36<string>(2358247488u),
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
