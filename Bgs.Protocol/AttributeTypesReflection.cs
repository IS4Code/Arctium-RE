using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class AttributeTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.descriptor;
			}
		}

		static AttributeTypesReflection()
		{
			AttributeTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(AttributeTypesReflection.smethod_1(AttributeTypesReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3133832196u),
				Module.smethod_37<string>(3946141007u),
				Module.smethod_33<string>(332921216u),
				Module.smethod_36<string>(3361351403u),
				Module.smethod_37<string>(498496223u),
				Module.smethod_36<string>(4148657931u),
				Module.smethod_34<string>(884153508u),
				Module.smethod_33<string>(435014224u),
				Module.smethod_36<string>(2897260923u),
				Module.smethod_33<string>(3509102000u),
				Module.smethod_33<string>(2588852736u),
				Module.smethod_37<string>(3302824303u),
				Module.smethod_35<string>(1180582211u),
				Module.smethod_34<string>(34147284u),
				Module.smethod_34<string>(3204275236u)
			})), new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(AttributeTypesReflection.smethod_2(typeof(Variant).TypeHandle), Variant.Parser, new string[]
				{
					Module.smethod_37<string>(2367881274u),
					Module.smethod_36<string>(1655698122u),
					Module.smethod_36<string>(20482057u),
					Module.smethod_36<string>(82457806u),
					Module.smethod_37<string>(673265721u),
					Module.smethod_36<string>(4118622721u),
					Module.smethod_35<string>(802821245u),
					Module.smethod_34<string>(1572342954u),
					Module.smethod_34<string>(353766998u)
				}, null, null, null),
				new GeneratedCodeInfo(AttributeTypesReflection.smethod_2(typeof(Attribute).TypeHandle), Attribute.Parser, new string[]
				{
					Module.smethod_34<string>(2643656114u),
					Module.smethod_35<string>(1515047581u)
				}, null, null, null),
				new GeneratedCodeInfo(AttributeTypesReflection.smethod_2(typeof(AttributeFilter).TypeHandle), AttributeFilter.Parser, new string[]
				{
					Module.smethod_33<string>(3118989787u),
					Module.smethod_36<string>(3548343828u)
				}, null, new Type[]
				{
					AttributeTypesReflection.smethod_2(typeof(AttributeFilter.Types.Operation).TypeHandle)
				}, null)
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
