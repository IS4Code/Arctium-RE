using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class RoleTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return RoleTypesReflection.descriptor;
			}
		}

		static RoleTypesReflection()
		{
			RoleTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(RoleTypesReflection.smethod_1(RoleTypesReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(752087161u),
				Module.smethod_36<string>(2019316176u),
				Module.smethod_37<string>(1170135636u),
				Module.smethod_33<string>(1672336425u),
				Module.smethod_34<string>(2004210315u),
				Module.smethod_37<string>(3010903268u),
				Module.smethod_33<string>(956273177u),
				Module.smethod_33<string>(36023913u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(RoleTypesReflection.smethod_2(typeof(Role).TypeHandle), Role.Parser, new string[]
				{
					Module.smethod_34<string>(4055669268u),
					Module.smethod_37<string>(2134609685u),
					Module.smethod_35<string>(2496757375u),
					Module.smethod_34<string>(1601600500u),
					Module.smethod_36<string>(2296946820u),
					Module.smethod_35<string>(1587395787u),
					Module.smethod_35<string>(286313566u),
					Module.smethod_37<string>(1754272416u),
					Module.smethod_34<string>(476761156u),
					Module.smethod_34<string>(757970992u)
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
