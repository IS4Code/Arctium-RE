using Framework.Logging.IO;
using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Framework.Logging
{
	public class PacketLog
	{
		private static LogWriter logger;

		public static void Initialize(string directory, string file)
		{
			PacketLog.logger = new LogWriter(directory, file);
		}

		[AsyncStateMachine(typeof(PacketLog.<Write>d__2__))]
		public static void Write<T>(ushort value, byte[] data, EndPoint remote)
		{
			PacketLog.<Write>d__2<T> <Write>d__;
			<Write>d__.value = value;
			while (true)
			{
				IL_91:
				uint arg_71_0 = 3218656159u;
				while (true)
				{
					uint num;
					switch ((num = (arg_71_0 ^ 2588396673u)) % 5u)
					{
					case 0u:
						<Write>d__.remote = remote;
						<Write>d__.__t__builder = AsyncVoidMethodBuilder.Create();
						arg_71_0 = (num * 2538819616u ^ 1917197710u);
						continue;
					case 1u:
					{
						<Write>d__.__1__state = -1;
						AsyncVoidMethodBuilder __t__builder = <Write>d__.__t__builder;
						__t__builder.Start<PacketLog.<Write>d__2<T>>(ref <Write>d__);
						arg_71_0 = (num * 3802955501u ^ 3942881345u);
						continue;
					}
					case 2u:
						goto IL_91;
					case 3u:
						<Write>d__.data = data;
						arg_71_0 = (num * 1036221128u ^ 448973626u);
						continue;
					}
					return;
				}
			}
		}
	}
}
