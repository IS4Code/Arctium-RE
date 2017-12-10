using Framework.Constants.Misc;
using Framework.Logging.IO;
using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Framework.Logging
{
	public class Log
	{
		private static LogType logLevel;

		private static BlockingCollection<Tuple<ConsoleColor, string>> logQueue = new BlockingCollection<Tuple<ConsoleColor, string>>();

		[AsyncStateMachine(typeof(Log.<Initialize>d__2))]
		public static void Initialize(LogType logLevel, LogWriter fileLogger = null)
		{
			Log.<Initialize>d__2 <Initialize>d__;
			<Initialize>d__.logLevel = logLevel;
			while (true)
			{
				IL_86:
				uint arg_66_0 = 3113489483u;
				while (true)
				{
					uint num;
					switch ((num = (arg_66_0 ^ 2308665641u)) % 5u)
					{
					case 0u:
					{
						AsyncVoidMethodBuilder __t__builder = <Initialize>d__.__t__builder;
						__t__builder.Start<Log.<Initialize>d__2>(ref <Initialize>d__);
						arg_66_0 = (num * 877270842u ^ 1481472347u);
						continue;
					}
					case 1u:
						<Initialize>d__.__t__builder = AsyncVoidMethodBuilder.Create();
						<Initialize>d__.__1__state = -1;
						arg_66_0 = (num * 1487676232u ^ 233386490u);
						continue;
					case 2u:
						<Initialize>d__.fileLogger = fileLogger;
						arg_66_0 = (num * 1678750232u ^ 2273318913u);
						continue;
					case 3u:
						goto IL_86;
					}
					return;
				}
			}
		}

		public static void Message()
		{
			Log.SetLogger(LogType.None, "", Array.Empty<object>());
		}

		public static void Message(LogType type, string text, params object[] args)
		{
			Log.SetLogger(type, text, args);
		}

		public static void Wait()
		{
			Log.smethod_0(true);
		}

		private static void SetLogger(LogType type, string text, params object[] args)
		{
			if (type <= LogType.Debug)
			{
				goto IL_AE;
			}
			goto IL_344;
			uint arg_2BC_0;
			ConsoleColor item;
			while (true)
			{
				IL_2B7:
				uint num;
				switch ((num = (arg_2BC_0 ^ 3480863151u)) % 27u)
				{
				case 0u:
					goto IL_2AF;
				case 1u:
					switch (type)
					{
					case LogType.Init:
						goto IL_E1;
					case LogType.Normal:
						goto IL_1DC;
					case LogType.Init | LogType.Normal:
						goto IL_130;
					case LogType.Error:
						goto IL_2AF;
					default:
						arg_2BC_0 = (num * 29380560u ^ 2609463449u);
						continue;
					}
					break;
				case 2u:
					text = Log.smethod_1(text, 0, Module.smethod_33<string>(3824555153u));
					arg_2BC_0 = (num * 1488785168u ^ 3003896097u);
					continue;
				case 3u:
					arg_2BC_0 = (num * 630349490u ^ 3410984367u);
					continue;
				case 4u:
					arg_2BC_0 = (num * 388368878u ^ 2199012548u);
					continue;
				case 5u:
					arg_2BC_0 = ((type.Equals(LogType.None) ? 3622719623u : 2395694699u) ^ num * 5683277u);
					continue;
				case 6u:
					arg_2BC_0 = (((type != LogType.Database) ? 4270553469u : 2963259474u) ^ num * 1067508702u);
					continue;
				case 7u:
					goto IL_1DC;
				case 8u:
					Log.logQueue.Add(Tuple.Create<ConsoleColor, string>(item, string.Format(Module.smethod_36<string>(626677217u) + DateTime.Now.ToLongTimeString() + Module.smethod_34<string>(3776110400u) + text, args)));
					arg_2BC_0 = 2298070045u;
					continue;
				case 9u:
					item = ConsoleColor.DarkRed;
					text = Log.smethod_1(text, 0, Module.smethod_35<string>(1595689074u));
					arg_2BC_0 = 2724106417u;
					continue;
				case 10u:
					arg_2BC_0 = (((!type.Equals(LogType.Init)) ? 1098694891u : 96357387u) ^ num * 1151934750u);
					continue;
				case 11u:
					goto IL_130;
				case 12u:
					goto IL_344;
				case 14u:
					item = ConsoleColor.DarkMagenta;
					arg_2BC_0 = 3189801514u;
					continue;
				case 15u:
					arg_2BC_0 = (num * 1506391283u ^ 2025020885u);
					continue;
				case 16u:
					arg_2BC_0 = (num * 240639445u ^ 1830147619u);
					continue;
				case 17u:
					arg_2BC_0 = (num * 3830279919u ^ 1878717959u);
					continue;
				case 18u:
					goto IL_E1;
				case 19u:
					arg_2BC_0 = (((type == LogType.Info) ? 2377804597u : 2424405559u) ^ num * 590112295u);
					continue;
				case 20u:
					goto IL_34F;
				case 21u:
					goto IL_AE;
				case 22u:
					arg_2BC_0 = (((Log.logLevel & type) == type) ? 3227681998u : 2298070045u);
					continue;
				case 23u:
					arg_2BC_0 = (num * 3845934040u ^ 687909629u);
					continue;
				case 24u:
					arg_2BC_0 = (((type == LogType.Debug) ? 2261310422u : 3671839948u) ^ num * 3869338176u);
					continue;
				case 25u:
					text = Log.smethod_1(text, 0, Module.smethod_37<string>(1982887587u));
					arg_2BC_0 = (num * 86982953u ^ 1438082591u);
					continue;
				case 26u:
					item = ConsoleColor.Yellow;
					arg_2BC_0 = 2600121813u;
					continue;
				}
				break;
				IL_E1:
				item = ConsoleColor.Cyan;
				arg_2BC_0 = 2243607472u;
				continue;
				IL_130:
				item = ConsoleColor.White;
				arg_2BC_0 = 2600121813u;
				continue;
				IL_1DC:
				item = ConsoleColor.Green;
				arg_2BC_0 = 4005755379u;
				continue;
				IL_2AF:
				item = ConsoleColor.Red;
				arg_2BC_0 = 3949059349u;
			}
			return;
			IL_34F:
			Log.logQueue.Add(Tuple.Create<ConsoleColor, string>(item, Log.smethod_2(text, args)));
			return;
			IL_AE:
			arg_2BC_0 = 3215317051u;
			goto IL_2B7;
			IL_344:
			arg_2BC_0 = ((type != LogType.Packet) ? 3442451454u : 3418615233u);
			goto IL_2B7;
		}

		static ConsoleKeyInfo smethod_0(bool bool_0)
		{
			return Console.ReadKey(bool_0);
		}

		static string smethod_1(string string_0, int int_0, string string_1)
		{
			return string_0.Insert(int_0, string_1);
		}

		static string smethod_2(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}
	}
}
