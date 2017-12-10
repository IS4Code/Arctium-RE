using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Resources.V1
{
	[DebuggerNonUserCode]
	public static class ResourceServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.descriptor;
			}
		}

		static ResourceServiceReflection()
		{
			ResourceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(ResourceServiceReflection.smethod_1(ResourceServiceReflection.smethod_0(new string[]
			{
				Module.smethod_36<string>(1757318261u),
				Module.smethod_37<string>(3038047137u),
				Module.smethod_34<string>(2104530014u),
				Module.smethod_33<string>(1571754286u),
				Module.smethod_36<string>(3713845045u),
				Module.smethod_37<string>(1138924769u),
				Module.smethod_36<string>(2209669205u),
				Module.smethod_36<string>(646795685u)
			})), new FileDescriptor[]
			{
				ContentHandleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ResourceServiceReflection.smethod_2(typeof(ContentHandleRequest).TypeHandle), ContentHandleRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2505595523u),
					Module.smethod_33<string>(3612705877u),
					Module.smethod_37<string>(4031315431u)
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
