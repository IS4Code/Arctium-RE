using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class TypeReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return TypeReflection.descriptor;
			}
		}

		static TypeReflection()
		{
			TypeReflection.descriptor = FileDescriptor.FromGeneratedCode(TypeReflection.smethod_1(TypeReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3033775657u),
				Module.smethod_36<string>(489080854u),
				Module.smethod_37<string>(1661022938u),
				Module.smethod_33<string>(1030112107u),
				Module.smethod_34<string>(1533989865u),
				Module.smethod_35<string>(1527307334u),
				Module.smethod_37<string>(4056867866u),
				Module.smethod_35<string>(1877148966u),
				Module.smethod_37<string>(959823034u),
				Module.smethod_35<string>(3192190854u),
				Module.smethod_36<string>(2745344614u),
				Module.smethod_35<string>(1758671974u),
				Module.smethod_36<string>(3914564870u),
				Module.smethod_33<string>(814628555u),
				Module.smethod_35<string>(4081076438u),
				Module.smethod_34<string>(2178218201u),
				Module.smethod_34<string>(1053378857u),
				Module.smethod_34<string>(1428325305u),
				Module.smethod_37<string>(1048533978u),
				Module.smethod_34<string>(678432409u),
				Module.smethod_34<string>(3848560361u),
				Module.smethod_35<string>(2108513606u),
				Module.smethod_35<string>(3115876182u),
				Module.smethod_36<string>(3520911606u),
				Module.smethod_33<string>(2757220091u),
				Module.smethod_34<string>(2723721017u),
				Module.smethod_33<string>(302751323u),
				Module.smethod_36<string>(1946298550u),
				Module.smethod_37<string>(3736624122u),
				Module.smethod_35<string>(1143313350u),
				Module.smethod_34<string>(99095881u),
				Module.smethod_37<string>(2188101706u),
				Module.smethod_37<string>(1837501754u),
				Module.smethod_34<string>(4019116729u)
			})), new FileDescriptor[]
			{
				AnyReflection.Descriptor,
				SourceContextReflection.Descriptor
			}, new GeneratedCodeInfo(new System.Type[]
			{
				TypeReflection.smethod_2(typeof(Syntax).TypeHandle)
			}, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(TypeReflection.smethod_2(typeof(Type).TypeHandle), Type.Parser, new string[]
				{
					Module.smethod_34<string>(2643656114u),
					Module.smethod_36<string>(3562686352u),
					Module.smethod_34<string>(793662043u),
					Module.smethod_34<string>(796587241u),
					Module.smethod_36<string>(2844444300u),
					Module.smethod_35<string>(1485711652u)
				}, null, null, null),
				new GeneratedCodeInfo(TypeReflection.smethod_2(typeof(Field).TypeHandle), Field.Parser, new string[]
				{
					Module.smethod_34<string>(641203968u),
					Module.smethod_36<string>(4160254975u),
					Module.smethod_35<string>(3207850435u),
					Module.smethod_37<string>(2134609685u),
					Module.smethod_34<string>(3560767438u),
					Module.smethod_35<string>(4243132345u),
					Module.smethod_35<string>(1501087914u),
					Module.smethod_37<string>(819830394u),
					Module.smethod_34<string>(2078311244u)
				}, null, new System.Type[]
				{
					TypeReflection.smethod_2(typeof(Field.Types.Kind).TypeHandle),
					TypeReflection.smethod_2(typeof(Field.Types.Cardinality).TypeHandle)
				}, null),
				new GeneratedCodeInfo(TypeReflection.smethod_2(typeof(Enum).TypeHandle), Enum.Parser, new string[]
				{
					Module.smethod_33<string>(1982348402u),
					Module.smethod_33<string>(2194296355u),
					Module.smethod_34<string>(796587241u),
					Module.smethod_36<string>(2844444300u),
					Module.smethod_34<string>(430643543u)
				}, null, null, null),
				new GeneratedCodeInfo(TypeReflection.smethod_2(typeof(EnumValue).TypeHandle), EnumValue.Parser, new string[]
				{
					Module.smethod_36<string>(2649665489u),
					Module.smethod_34<string>(3338222276u),
					Module.smethod_34<string>(796587241u)
				}, null, null, null),
				new GeneratedCodeInfo(TypeReflection.smethod_2(typeof(Option).TypeHandle), Option.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_34<string>(1800026606u)
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

		static System.Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
