using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class ContentHandleTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentHandleTypesReflection.descriptor;
			}
		}

		static ContentHandleTypesReflection()
		{
			ContentHandleTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(ContentHandleTypesReflection.smethod_1(ContentHandleTypesReflection.smethod_0(new string[]
			{
				Module.smethod_36<string>(4231367272u),
				Module.smethod_37<string>(468699964u),
				Module.smethod_37<string>(118100012u),
				Module.smethod_36<string>(3837714008u),
				Module.smethod_33<string>(2134579345u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ContentHandleTypesReflection.smethod_2(typeof(ContentHandle).TypeHandle), ContentHandle.Parser, new string[]
				{
					Module.smethod_36<string>(1013076684u),
					Module.smethod_33<string>(2895131760u),
					Module.smethod_34<string>(2332982361u),
					Module.smethod_36<string>(3941997092u)
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

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
