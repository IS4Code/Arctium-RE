using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class MethodOptionsReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return MethodOptionsReflection.descriptor;
			}
		}

		static MethodOptionsReflection()
		{
			MethodOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(MethodOptionsReflection.smethod_1(MethodOptionsReflection.smethod_0(Module.smethod_33<string>(3366252778u), Module.smethod_33<string>(3468345786u), Module.smethod_35<string>(2930357009u), Module.smethod_37<string>(3040051165u))), new FileDescriptor[]
			{
				FileDescriptor.DescriptorProtoFileDescriptor
			}, new GeneratedCodeInfo(null, null));
		}

		static string smethod_0(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
		}

		static byte[] smethod_1(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}
	}
}
