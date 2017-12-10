using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class EntityTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.descriptor;
			}
		}

		static EntityTypesReflection()
		{
			EntityTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(EntityTypesReflection.smethod_1(EntityTypesReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(2034105131u),
				Module.smethod_36<string>(743907507u),
				Module.smethod_35<string>(3349147019u),
				Module.smethod_33<string>(389616488u),
				Module.smethod_36<string>(732167971u),
				Module.smethod_33<string>(1207772744u),
				Module.smethod_36<string>(1901388227u),
				Module.smethod_34<string>(2437465484u),
				Module.smethod_33<string>(491709496u),
				Module.smethod_37<string>(2221847079u),
				Module.smethod_35<string>(2383946763u)
			})), new FileDescriptor[]
			{
				FieldOptionsReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(EntityTypesReflection.smethod_2(typeof(EntityId).TypeHandle), EntityId.Parser, new string[]
				{
					Module.smethod_35<string>(5703631u),
					Module.smethod_35<string>(1698506485u)
				}, null, null, null),
				new GeneratedCodeInfo(EntityTypesReflection.smethod_2(typeof(Identity).TypeHandle), Identity.Parser, new string[]
				{
					Module.smethod_36<string>(4043002107u),
					Module.smethod_33<string>(1846560140u)
				}, null, null, null),
				new GeneratedCodeInfo(EntityTypesReflection.smethod_2(typeof(AccountInfo).TypeHandle), AccountInfo.Parser, new string[]
				{
					Module.smethod_33<string>(1520609105u),
					Module.smethod_37<string>(2923017512u),
					Module.smethod_36<string>(503400800u),
					Module.smethod_37<string>(1272656u),
					Module.smethod_34<string>(215450163u),
					Module.smethod_34<string>(94050184u)
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
