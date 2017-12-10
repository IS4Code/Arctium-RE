using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class RpcTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.descriptor;
			}
		}

		static RpcTypesReflection()
		{
			RpcTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(RpcTypesReflection.smethod_1(RpcTypesReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3862025699u),
				Module.smethod_33<string>(189163425u),
				Module.smethod_37<string>(3682925804u),
				Module.smethod_34<string>(3487079251u),
				Module.smethod_35<string>(1265756808u),
				Module.smethod_37<string>(1140958268u),
				Module.smethod_34<string>(1612347011u),
				Module.smethod_35<string>(1923277752u),
				Module.smethod_36<string>(1417096744u),
				Module.smethod_36<string>(4149190520u),
				Module.smethod_34<string>(112561219u),
				Module.smethod_37<string>(439758364u),
				Module.smethod_34<string>(1884404515u),
				Module.smethod_33<string>(4281356897u),
				Module.smethod_34<string>(1134511619u),
				Module.smethod_36<string>(688487896u),
				Module.smethod_33<string>(906638865u),
				Module.smethod_36<string>(1475794424u),
				Module.smethod_37<string>(702590444u)
			})), new FileDescriptor[]
			{
				MethodOptionsReflection.Descriptor,
				ServiceOptionsReflection.Descriptor,
				FieldOptionsReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(NO_RESPONSE).TypeHandle), NO_RESPONSE.Parser, null, null, null, null),
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(Address).TypeHandle), Address.Parser, new string[]
				{
					Module.smethod_35<string>(3839151959u),
					Module.smethod_36<string>(1620479514u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(ProcessId).TypeHandle), ProcessId.Parser, new string[]
				{
					Module.smethod_34<string>(46694345u),
					Module.smethod_33<string>(3463200641u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(ObjectAddress).TypeHandle), ObjectAddress.Parser, new string[]
				{
					Module.smethod_36<string>(4123806119u),
					Module.smethod_33<string>(3239342614u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(NoData).TypeHandle), NoData.Parser, null, null, null, null),
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(ErrorInfo).TypeHandle), ErrorInfo.Parser, new string[]
				{
					Module.smethod_36<string>(2830101776u),
					Module.smethod_33<string>(4108545374u),
					Module.smethod_34<string>(3179800227u),
					Module.smethod_36<string>(584204812u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcTypesReflection.smethod_2(typeof(Header).TypeHandle), Header.Parser, new string[]
				{
					Module.smethod_36<string>(3243956043u),
					Module.smethod_37<string>(3916462632u),
					Module.smethod_36<string>(1194885711u),
					Module.smethod_33<string>(3239342614u),
					Module.smethod_34<string>(1454131333u),
					Module.smethod_35<string>(2244350093u),
					Module.smethod_36<string>(4196148664u),
					Module.smethod_36<string>(998059079u),
					Module.smethod_36<string>(2974786866u),
					Module.smethod_33<string>(3731547835u),
					Module.smethod_37<string>(907067788u)
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
