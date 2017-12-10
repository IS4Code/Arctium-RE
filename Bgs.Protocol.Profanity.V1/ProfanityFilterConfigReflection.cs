using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Profanity.V1
{
	[DebuggerNonUserCode]
	public static class ProfanityFilterConfigReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ProfanityFilterConfigReflection.descriptor;
			}
		}

		static ProfanityFilterConfigReflection()
		{
			ProfanityFilterConfigReflection.descriptor = FileDescriptor.FromGeneratedCode(ProfanityFilterConfigReflection.smethod_1(ProfanityFilterConfigReflection.smethod_0(new string[]
			{
				Module.smethod_37<string>(1080393207u),
				Module.smethod_35<string>(1904141307u),
				Module.smethod_34<string>(3147973436u),
				Module.smethod_33<string>(2659669928u),
				Module.smethod_35<string>(1596461995u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ProfanityFilterConfigReflection.smethod_2(typeof(WordFilter).TypeHandle), WordFilter.Parser, new string[]
				{
					Module.smethod_37<string>(147837329u),
					Module.smethod_36<string>(2218130672u)
				}, null, null, null),
				new GeneratedCodeInfo(ProfanityFilterConfigReflection.smethod_2(typeof(WordFilters).TypeHandle), WordFilters.Parser, new string[]
				{
					Module.smethod_36<string>(2145788127u)
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
