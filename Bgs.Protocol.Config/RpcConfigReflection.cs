using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Config
{
	[DebuggerNonUserCode]
	public static class RpcConfigReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.descriptor;
			}
		}

		static RpcConfigReflection()
		{
			RpcConfigReflection.descriptor = FileDescriptor.FromGeneratedCode(RpcConfigReflection.smethod_1(RpcConfigReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3423012927u),
				Module.smethod_34<string>(3797959375u),
				Module.smethod_34<string>(2673120031u),
				Module.smethod_37<string>(320809096u),
				Module.smethod_33<string>(2742090925u),
				Module.smethod_36<string>(2287195148u),
				Module.smethod_37<string>(174686488u),
				Module.smethod_34<string>(1548280687u),
				Module.smethod_37<string>(1372608952u),
				Module.smethod_35<string>(911305036u),
				Module.smethod_33<string>(1923934669u),
				Module.smethod_34<string>(48494895u),
				Module.smethod_37<string>(466931704u),
				Module.smethod_37<string>(2015454120u),
				Module.smethod_34<string>(2468729951u),
				Module.smethod_34<string>(2843676399u),
				Module.smethod_36<string>(1893541884u),
				Module.smethod_37<string>(116331752u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(RpcConfigReflection.smethod_2(typeof(RPCMethodConfig).TypeHandle), RPCMethodConfig.Parser, new string[]
				{
					Module.smethod_34<string>(902870914u),
					Module.smethod_34<string>(1184080750u),
					Module.smethod_33<string>(114810634u),
					Module.smethod_37<string>(496168014u),
					Module.smethod_37<string>(3651655995u),
					Module.smethod_36<string>(4014954761u),
					Module.smethod_36<string>(3135104685u),
					Module.smethod_33<string>(172414475u),
					Module.smethod_36<string>(2793592963u),
					Module.smethod_37<string>(4265176440u),
					Module.smethod_36<string>(998059079u),
					Module.smethod_37<string>(379252245u),
					Module.smethod_34<string>(3604315806u),
					Module.smethod_33<string>(3565293649u),
					Module.smethod_34<string>(3461010063u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcConfigReflection.smethod_2(typeof(RPCMeterConfig).TypeHandle), RPCMeterConfig.Parser, new string[]
				{
					Module.smethod_37<string>(4209061500u),
					Module.smethod_36<string>(588098005u),
					Module.smethod_34<string>(2413403217u),
					Module.smethod_36<string>(2637168337u),
					Module.smethod_37<string>(1197338447u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcConfigReflection.smethod_2(typeof(ProtocolAlias).TypeHandle), ProtocolAlias.Parser, new string[]
				{
					Module.smethod_33<string>(3099416453u),
					Module.smethod_35<string>(2394429566u)
				}, null, null, null),
				new GeneratedCodeInfo(RpcConfigReflection.smethod_2(typeof(ServiceAliases).TypeHandle), ServiceAliases.Parser, new string[]
				{
					Module.smethod_34<string>(3670389051u)
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
