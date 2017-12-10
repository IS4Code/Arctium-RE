using Framework.Constants.Misc;
using Framework.Logging;
using System;

namespace AuthServer.Configuration
{
	internal class AuthConfig
	{
		public static LogType LogLevel;

		public static string BindIP;

		public static int BindPort;

		public static void ReadConfig()
		{
			AuthConfig.LogLevel = (LogType.Init | LogType.Normal | LogType.Error | LogType.Debug);
			AuthConfig.BindIP = Module.smethod_33<string>(3600904718u);
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 2311101738u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2816298131u)) % 3u)
					{
					case 1u:
						AuthConfig.BindPort = 8000;
						Log.Initialize(AuthConfig.LogLevel, null);
						arg_3F_0 = (num * 1545441423u ^ 1051495048u);
						continue;
					case 2u:
						goto IL_57;
					}
					return;
				}
			}
		}
	}
}
