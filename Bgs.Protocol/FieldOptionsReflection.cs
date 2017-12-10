using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class FieldOptionsReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.descriptor;
			}
		}

		static FieldOptionsReflection()
		{
			FieldOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(FieldOptionsReflection.smethod_1(FieldOptionsReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(1360912256u),
				Module.smethod_33<string>(3099317776u),
				Module.smethod_34<string>(3545387972u),
				Module.smethod_33<string>(644849008u),
				Module.smethod_33<string>(4019567040u)
			})), new FileDescriptor[]
			{
				FileDescriptor.DescriptorProtoFileDescriptor
			}, new GeneratedCodeInfo(new Type[]
			{
				FieldOptionsReflection.smethod_2(typeof(LogOption).TypeHandle)
			}, null));
		}

		static string smethod_0(string[] string_0)
		{
			return string.Concat(string_0);
		}

		static byte[] smethod_1(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
