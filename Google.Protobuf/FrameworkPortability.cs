using System;
using System.Text.RegularExpressions;

namespace Google.Protobuf
{
	internal static class FrameworkPortability
	{
		internal static readonly RegexOptions CompiledRegexWhereAvailable;

		static FrameworkPortability()
		{
			// Note: this type is marked as 'beforefieldinit'.
			RegexOptions arg_3B_0;
			if (FrameworkPortability.smethod_1(FrameworkPortability.smethod_0(typeof(RegexOptions).TypeHandle), 8))
			{
				arg_3B_0 = RegexOptions.Compiled;
				goto IL_3B;
			}
			IL_1A:
			int arg_24_0 = -1246723805;
			IL_1F:
			switch ((arg_24_0 ^ -1681007982) % 3)
			{
			case 1:
				arg_3B_0 = RegexOptions.None;
				goto IL_3B;
			case 2:
				goto IL_1A;
			}
			return;
			IL_3B:
			FrameworkPortability.CompiledRegexWhereAvailable = arg_3B_0;
			arg_24_0 = -519226386;
			goto IL_1F;
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_1(Type type_0, object object_0)
		{
			return Enum.IsDefined(type_0, object_0);
		}
	}
}
