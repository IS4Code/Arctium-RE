using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class FieldMaskReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldMaskReflection.descriptor;
			}
		}

		static FieldMaskReflection()
		{
			FieldMaskReflection.descriptor = FileDescriptor.FromGeneratedCode(FieldMaskReflection.smethod_1(FieldMaskReflection.smethod_0(Module.smethod_35<string>(800271374u), Module.smethod_37<string>(3472613202u), Module.smethod_37<string>(3122013250u), Module.smethod_36<string>(4158349646u))), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(FieldMaskReflection.smethod_2(typeof(FieldMask).TypeHandle), FieldMask.Parser, new string[]
				{
					Module.smethod_36<string>(618748339u)
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
