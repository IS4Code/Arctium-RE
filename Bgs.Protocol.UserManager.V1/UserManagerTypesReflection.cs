using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public static class UserManagerTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return UserManagerTypesReflection.descriptor;
			}
		}

		static UserManagerTypesReflection()
		{
			UserManagerTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(UserManagerTypesReflection.smethod_1(UserManagerTypesReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(840090106u),
				Module.smethod_36<string>(1055466554u),
				Module.smethod_37<string>(1606086838u),
				Module.smethod_37<string>(3154609254u),
				Module.smethod_36<string>(279899562u),
				Module.smethod_35<string>(1847452682u),
				Module.smethod_34<string>(1144076693u),
				Module.smethod_37<string>(1255486886u),
				Module.smethod_33<string>(2806252103u),
				Module.smethod_37<string>(3125667654u),
				Module.smethod_33<string>(3624408359u)
			})), new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(UserManagerTypesReflection.smethod_2(typeof(RecentPlayer).TypeHandle), RecentPlayer.Parser, new string[]
				{
					Module.smethod_36<string>(1294600521u),
					Module.smethod_36<string>(2505595523u),
					Module.smethod_33<string>(4276310429u),
					Module.smethod_37<string>(2628974565u),
					Module.smethod_36<string>(94729931u),
					Module.smethod_34<string>(3638149518u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerTypesReflection.smethod_2(typeof(BlockedPlayer).TypeHandle), BlockedPlayer.Parser, new string[]
				{
					Module.smethod_35<string>(915065219u),
					Module.smethod_36<string>(2649665489u),
					Module.smethod_35<string>(2560812294u),
					Module.smethod_37<string>(759059036u)
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
