using Framework.Constants.Misc;
using Framework.Logging;
using System;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Framework.Misc
{
	public class Helper
	{
		private static IFormatProvider enUSNumber = Helper.smethod_14(Helper.smethod_13(Module.smethod_37<string>(760620999u)));

		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		public static void PrintHeader(string serverName)
		{
			Log.Message(LogType.Init, Module.smethod_34<string>(4028062690u), Array.Empty<object>());
			StringBuilder stringBuilder;
			int num2;
			while (true)
			{
				IL_1A5:
				uint arg_179_0 = 3834617095u;
				while (true)
				{
					uint num;
					switch ((num = (arg_179_0 ^ 2922890101u)) % 8u)
					{
					case 0u:
						Helper.smethod_3(stringBuilder, num2, serverName);
						arg_179_0 = (num * 1067961754u ^ 3795369450u);
						continue;
					case 1u:
						Log.Message(LogType.Init, Module.smethod_36<string>(2386377369u), Array.Empty<object>());
						arg_179_0 = (num * 3483953559u ^ 3788356934u);
						continue;
					case 2u:
						Log.Message(LogType.Init, Module.smethod_37<string>(3560646313u), Array.Empty<object>());
						Log.Message(LogType.Init, Module.smethod_33<string>(252208442u), Array.Empty<object>());
						Log.Message(LogType.Init, Module.smethod_33<string>(2425215342u), Array.Empty<object>());
						Log.Message(LogType.Init, Module.smethod_36<string>(1020330481u), Array.Empty<object>());
						Log.Message(LogType.Init, Module.smethod_33<string>(2374168838u), Array.Empty<object>());
						arg_179_0 = (num * 2920292180u ^ 3670365708u);
						continue;
					case 3u:
						goto IL_1A5;
					case 4u:
						Log.Message(LogType.Init, Module.smethod_35<string>(98604877u), Array.Empty<object>());
						Log.Message(LogType.Init, Module.smethod_36<string>(244763489u), Array.Empty<object>());
						Log.Message(LogType.Init, Module.smethod_33<string>(3294418102u), Array.Empty<object>());
						Log.Message(LogType.Init, "", Array.Empty<object>());
						stringBuilder = Helper.smethod_0();
						arg_179_0 = (num * 2030026200u ^ 1834791672u);
						continue;
					case 5u:
						Helper.smethod_1(stringBuilder, Module.smethod_34<string>(3362754074u));
						arg_179_0 = (num * 2752327162u ^ 1617791001u);
						continue;
					case 6u:
						num2 = (42 - Helper.smethod_2(serverName)) / 2;
						arg_179_0 = (num * 3682183340u ^ 1631012693u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			Helper.smethod_4(stringBuilder, num2 + Helper.smethod_2(serverName), Helper.smethod_2(serverName));
			Log.Message(LogType.Init, Helper.smethod_5(stringBuilder), Array.Empty<object>());
			Log.Message(LogType.Init, Helper.smethod_6(Module.smethod_34<string>(3831437134u), Module.smethod_34<string>(539909203u)), Array.Empty<object>());
			Log.Message();
			Log.Message(LogType.Normal, Helper.smethod_6(Module.smethod_37<string>(3063923753u), serverName), Array.Empty<object>());
			Log.Message();
		}

		public static float ParseFloat(string data)
		{
			return float.Parse(data, Helper.enUSNumber);
		}

		public static long GetCurrentUnixTimestampMillis()
		{
			return (long)(DateTime.UtcNow - Helper.UnixEpoch).TotalMilliseconds;
		}

		public static uint GetUnixTime()
		{
			DateTime d = new DateTime(1970, 1, 1);
			return (uint)(DateTime.Now - d).TotalSeconds;
		}

		public static uint GetUnixTime2()
		{
			DateTime d = new DateTime(1970, 1, 1);
			return (uint)(DateTime.Now - d).Milliseconds;
		}

		public static string DataDirectory()
		{
			string string_ = Helper.smethod_9(Helper.smethod_8(Helper.smethod_7()));
			return Helper.smethod_12(Helper.smethod_12(Helper.smethod_10(Helper.smethod_7()), Helper.smethod_11(string_, Module.smethod_35<string>(980047131u)), ""), Helper.smethod_11(string_, Module.smethod_37<string>(1603051325u)), "");
		}

		static StringBuilder smethod_0()
		{
			return new StringBuilder();
		}

		static StringBuilder smethod_1(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.Append(string_0);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static StringBuilder smethod_3(StringBuilder stringBuilder_0, int int_0, string string_0)
		{
			return stringBuilder_0.Insert(int_0, string_0);
		}

		static StringBuilder smethod_4(StringBuilder stringBuilder_0, int int_0, int int_1)
		{
			return stringBuilder_0.Remove(int_0, int_1);
		}

		static string smethod_5(object object_0)
		{
			return object_0.ToString();
		}

		static string smethod_6(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static Assembly smethod_7()
		{
			return Assembly.GetExecutingAssembly();
		}

		static AssemblyName smethod_8(Assembly assembly_0)
		{
			return assembly_0.GetName();
		}

		static string smethod_9(AssemblyName assemblyName_0)
		{
			return assemblyName_0.Name;
		}

		static string smethod_10(Assembly assembly_0)
		{
			return assembly_0.Location;
		}

		static string smethod_11(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static string smethod_12(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static CultureInfo smethod_13(string string_0)
		{
			return new CultureInfo(string_0);
		}

		static NumberFormatInfo smethod_14(CultureInfo cultureInfo_0)
		{
			return cultureInfo_0.NumberFormat;
		}
	}
}
