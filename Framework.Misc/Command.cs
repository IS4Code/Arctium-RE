using Framework.Constants.Misc;
using Framework.Logging;
using System;
using System.Globalization;

namespace Framework.Misc
{
	public class Command
	{
		public static T Read<T>(string[] args, int index)
		{
			try
			{
				return (T)((object)Command.smethod_3(args[index], Command.smethod_0(typeof(T).TypeHandle), Command.smethod_2(Command.smethod_1(Module.smethod_35<string>(1267173403u)))));
			}
			catch
			{
				while (true)
				{
					IL_76:
					uint arg_3A_0 = 890358424u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3A_0 ^ 1357817321u)) % 3u)
						{
						case 1u:
							Log.Message(LogType.Error, Module.smethod_36<string>(1444018955u), Array.Empty<object>());
							arg_3A_0 = (num * 2803661342u ^ 3561087243u);
							continue;
						case 2u:
							goto IL_76;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			return default(T);
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static CultureInfo smethod_1(string string_0)
		{
			return CultureInfo.GetCultureInfo(string_0);
		}

		static NumberFormatInfo smethod_2(CultureInfo cultureInfo_0)
		{
			return cultureInfo_0.NumberFormat;
		}

		static object smethod_3(object object_0, Type type_0, IFormatProvider iformatProvider_0)
		{
			return Convert.ChangeType(object_0, type_0, iformatProvider_0);
		}
	}
}
