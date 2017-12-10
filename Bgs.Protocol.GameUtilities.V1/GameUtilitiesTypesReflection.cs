using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public static class GameUtilitiesTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesTypesReflection.descriptor;
			}
		}

		static GameUtilitiesTypesReflection()
		{
			GameUtilitiesTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(GameUtilitiesTypesReflection.smethod_1(GameUtilitiesTypesReflection.smethod_0(new string[]
			{
				Module.smethod_37<string>(2454264009u),
				Module.smethod_35<string>(906488613u),
				Module.smethod_35<string>(1913851189u),
				Module.smethod_35<string>(1256330245u),
				Module.smethod_34<string>(1846613750u),
				Module.smethod_33<string>(2537401286u),
				Module.smethod_35<string>(3578734709u),
				Module.smethod_37<string>(64345u),
				Module.smethod_35<string>(598809301u),
				Module.smethod_34<string>(2062519036u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(GameUtilitiesTypesReflection.smethod_2(typeof(PlayerVariables).TypeHandle), PlayerVariables.Parser, new string[]
				{
					Module.smethod_34<string>(215450163u),
					Module.smethod_35<string>(4236255653u),
					Module.smethod_35<string>(1418463188u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesTypesReflection.smethod_2(typeof(ClientInfo).TypeHandle), ClientInfo.Parser, new string[]
				{
					Module.smethod_34<string>(1725213771u),
					Module.smethod_36<string>(388525893u)
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
