using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class ServiceOptionsReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ServiceOptionsReflection.descriptor;
			}
		}

		static ServiceOptionsReflection()
		{
			ServiceOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(ServiceOptionsReflection.smethod_1(ServiceOptionsReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3527083308u),
				Module.smethod_34<string>(3902029756u),
				Module.smethod_37<string>(1520647175u),
				Module.smethod_36<string>(3834435939u),
				Module.smethod_33<string>(2638487048u),
				Module.smethod_36<string>(708688899u),
				Module.smethod_35<string>(495708571u)
			})), new FileDescriptor[]
			{
				FileDescriptor.DescriptorProtoFileDescriptor
			}, new GeneratedCodeInfo(null, null));
		}

		static string smethod_0(string[] string_0)
		{
			return string.Concat(string_0);
		}

		static byte[] smethod_1(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}
	}
}
