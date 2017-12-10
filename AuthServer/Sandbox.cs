using AuthServer.Configuration;
using AuthServer.Game.Entities;
using AuthServer.Game.Chat;
using AuthServer.Managers;
using AuthServer.Network;
using AuthServer.Packets;
using AuthServer.WorldServer.Game.Packets;
using AuthServer.WorldServer.Managers;
using Bgs.Protocol.Connection.V1;
using Framework.Constants.Misc;
using Framework.Logging;
using Framework.Misc;
using Framework.Serialization;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace AuthServer
{
	internal class Sandbox
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Sandbox.__c __9 = new Sandbox.__c();

			public static ThreadStart __9__1_0;

			public static ThreadStart __9__1_1;

			public static ThreadStart __9__1_3;

			public static ThreadStart __9__1_2;

			internal void <Main>b__1_0()
			{
				new Server(AuthConfig.BindIP, 8000, false);
				AuthServer.Packets.PacketManager.Initialize();
				while (true)
				{
					IL_47:
					uint arg_2F_0 = 5108531u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2F_0 ^ 1907576337u)) % 3u)
						{
						case 0u:
							goto IL_47;
						case 2u:
							AuthServer.Managers.Manager.Initialize();
							arg_2F_0 = (num * 1653129125u ^ 1942729776u);
							continue;
						}
						goto Block_1;
					}
				}
				while (true)
				{
					IL_4E:
					Sandbox.__c.smethod_0(5);
				}
				Block_1:
				goto IL_4E;
			}

			internal void <Main>b__1_1()
			{
				new Server(AuthConfig.BindIP, 8001, true);
				while (true)
				{
					Sandbox.__c.smethod_0(5);
				}
			}

			internal void <Main>b__1_2()
			{
				AuthServer.WorldServer.Managers.Manager.Initialize();
				WorldClass.world = new WorldNetwork();
				while (true)
				{
					IL_22D:
					uint arg_1E8_0 = 3352817744u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1E8_0 ^ 2174237086u)) % 14u)
						{
						case 0u:
							Log.Message(LogType.Info, Module.smethod_36<string>(3199210790u), Array.Empty<object>());
							arg_1E8_0 = (num * 293830216u ^ 3785111977u);
							continue;
						case 1u:
							arg_1E8_0 = (num * 1159999155u ^ 2715109765u);
							continue;
						case 3u:
							Log.Message(LogType.Info, Module.smethod_33<string>(3408924807u), Array.Empty<object>());
							arg_1E8_0 = (num * 2188278457u ^ 3075230937u);
							continue;
						case 4u:
							WorldClass.world.AcceptConnectionThread();
							arg_1E8_0 = (num * 1988231028u ^ 1363700904u);
							continue;
						case 5u:
							goto IL_22D;
						case 6u:
							arg_1E8_0 = ((WorldClass.world.Start(Module.smethod_35<string>(78051837u), 8085) ? 4111792120u : 2412095149u) ^ num * 2486324963u);
							continue;
						case 7u:
							Log.Message(LogType.Info, Module.smethod_33<string>(264622139u), Array.Empty<object>());
							arg_1E8_0 = (num * 4255687717u ^ 170489561u);
							continue;
						case 8u:
							Log.Message(LogType.Info, Module.smethod_34<string>(290469369u), Array.Empty<object>());
							arg_1E8_0 = (num * 2824688434u ^ 3191605882u);
							continue;
						case 9u:
							Log.Message(LogType.Info, Module.smethod_33<string>(967570713u), Array.Empty<object>());
							arg_1E8_0 = (num * 3591803169u ^ 1592472184u);
							continue;
						case 10u:
						{
							ThreadStart arg_AB_0;
							if ((arg_AB_0 = Sandbox.__c.__9__1_3) == null)
							{
								arg_AB_0 = (Sandbox.__c.__9__1_3 = new ThreadStart(Sandbox.__c.__9.<Main>b__1_3));
							}
							Sandbox.__c.smethod_2(Sandbox.__c.smethod_1(arg_AB_0));
							arg_1E8_0 = 3635468527u;
							continue;
						}
						case 11u:
							Log.Message(LogType.Error, Module.smethod_36<string>(2638766104u), Array.Empty<object>());
							arg_1E8_0 = 2534700142u;
							continue;
						case 12u:
							AuthServer.WorldServer.Game.Packets.PacketManager.DefineOpcodeHandler();
							ChatCommandParser.DefineChatCommands();
							arg_1E8_0 = (num * 3339465046u ^ 1488328179u);
							continue;
						case 13u:
							Log.Message(LogType.Normal, Module.smethod_37<string>(3623392228u), Array.Empty<object>());
							Log.Message(LogType.Info, Module.smethod_37<string>(2659212889u), Array.Empty<object>());
							arg_1E8_0 = (num * 2429953406u ^ 1192654773u);
							continue;
						}
						return;
					}
				}
			}

			internal void <Main>b__1_3()
			{
				WorldClass2.world = new WorldNetwork();
				while (true)
				{
					IL_DA:
					uint arg_AE_0 = 3787839266u;
					while (true)
					{
						uint num;
						switch ((num = (arg_AE_0 ^ 3818991086u)) % 8u)
						{
						case 0u:
							Log.Message(LogType.Error, Module.smethod_36<string>(2638766104u), Array.Empty<object>());
							arg_AE_0 = 2821928925u;
							continue;
						case 1u:
							WorldClass2.world.AcceptConnectionThread2();
							arg_AE_0 = (num * 2867472236u ^ 24152677u);
							continue;
						case 2u:
							ChatCommandParser.DefineChatCommands2();
							arg_AE_0 = (num * 2966987160u ^ 772862995u);
							continue;
						case 4u:
							arg_AE_0 = ((WorldClass2.world.Start(Module.smethod_33<string>(3600904718u), 3724) ? 4080538975u : 2924591654u) ^ num * 1703302812u);
							continue;
						case 5u:
							return;
						case 6u:
							goto IL_DA;
						case 7u:
							AuthServer.WorldServer.Game.Packets.PacketManager.DefineOpcodeHandler2();
							arg_AE_0 = (num * 3421968766u ^ 2603198422u);
							continue;
						}
						return;
					}
				}
			}

			static void smethod_0(int int_0)
			{
				Thread.Sleep(int_0);
			}

			static Thread smethod_1(ThreadStart threadStart_0)
			{
				return new Thread(threadStart_0);
			}

			static void smethod_2(Thread thread_0)
			{
				thread_0.Start();
			}
		}

		public static uint StartTime;

		public static void Main(string[] args)
		{
			Sandbox.smethod_1(Sandbox.smethod_0());
			while (true)
			{
				IL_371:
				uint arg_311_0 = 1708240695u;
				while (true)
				{
					uint num;
					switch ((num = (arg_311_0 ^ 2105863856u)) % 20u)
					{
					case 0u:
						Log.Message(LogType.Init, Module.smethod_37<string>(1637150350u), Array.Empty<object>());
						arg_311_0 = (num * 1471496522u ^ 1690010414u);
						continue;
					case 1u:
						Log.Message(LogType.Init, Module.smethod_35<string>(609652459u), Array.Empty<object>());
						arg_311_0 = (num * 4061345325u ^ 1360549289u);
						continue;
					case 2u:
						Log.Message(LogType.Init, Module.smethod_37<string>(1403407225u), Array.Empty<object>());
						Log.Message();
						arg_311_0 = (num * 2004520375u ^ 3273204487u);
						continue;
					case 3u:
						Log.Message(LogType.Error, Module.smethod_35<string>(4093259155u), Array.Empty<object>());
						Log.Message(LogType.Normal, Module.smethod_35<string>(3057977245u), Array.Empty<object>());
						arg_311_0 = (num * 2349762838u ^ 2034718379u);
						continue;
					case 4u:
						Log.Message(LogType.Init, Module.smethod_37<string>(848270987u), Array.Empty<object>());
						arg_311_0 = (num * 3772370626u ^ 3471602137u);
						continue;
					case 5u:
					{
						ThreadStart arg_229_0;
						if ((arg_229_0 = Sandbox.__c.__9__1_0) == null)
						{
							arg_229_0 = (Sandbox.__c.__9__1_0 = new ThreadStart(Sandbox.__c.__9.<Main>b__1_0));
						}
						Sandbox.smethod_7(Sandbox.smethod_6(arg_229_0));
						arg_311_0 = 1664077542u;
						continue;
					}
					case 7u:
					{
						ThreadStart arg_1F6_0;
						if ((arg_1F6_0 = Sandbox.__c.__9__1_2) == null)
						{
							arg_1F6_0 = (Sandbox.__c.__9__1_2 = new ThreadStart(Sandbox.__c.__9.<Main>b__1_2));
						}
						Sandbox.smethod_7(Sandbox.smethod_6(arg_1F6_0));
						arg_311_0 = 1361824293u;
						continue;
					}
					case 8u:
						Sandbox.smethod_5(5000);
						arg_311_0 = (num * 990183502u ^ 3401419919u);
						continue;
					case 9u:
						arg_311_0 = ((Sandbox.smethod_8(Module.smethod_34<string>(2772407875u)) ? 1364857755u : 87273350u) ^ num * 4016381820u);
						continue;
					case 10u:
						goto IL_371;
					case 11u:
					{
						string string_ = Json.CreateString<List<Character>>(Serializator.Get<Character>(Sandbox.smethod_9(Helper.DataDirectory(), Module.smethod_33<string>(2623051613u))));
						Sandbox.smethod_10(Module.smethod_37<string>(234721071u), string_);
						Sandbox.smethod_11(Module.smethod_37<string>(1841686636u));
						arg_311_0 = (num * 142752336u ^ 2054263962u);
						continue;
					}
					case 12u:
						Sandbox.smethod_3(Sandbox.smethod_2(Module.smethod_36<string>(3052620371u)));
						arg_311_0 = (num * 1503141282u ^ 4077129067u);
						continue;
					case 14u:
					{
						ThreadStart arg_EC_0;
						if ((arg_EC_0 = Sandbox.__c.__9__1_1) == null)
						{
							arg_EC_0 = (Sandbox.__c.__9__1_1 = new ThreadStart(Sandbox.__c.__9.<Main>b__1_1));
						}
						Sandbox.smethod_7(Sandbox.smethod_6(arg_EC_0));
						arg_311_0 = 1522564795u;
						continue;
					}
					case 15u:
						Sandbox.smethod_4(Sandbox.smethod_2(Module.smethod_33<string>(2028753384u)));
						arg_311_0 = (num * 622432704u ^ 3549537790u);
						continue;
					case 16u:
						Log.Message();
						Log.Message(LogType.Error, Module.smethod_36<string>(1831258573u), Array.Empty<object>());
						Log.Message();
						arg_311_0 = (num * 3302199861u ^ 357139032u);
						continue;
					case 17u:
						Log.Message(LogType.Info, Module.smethod_37<string>(3565509028u), Array.Empty<object>());
						arg_311_0 = (num * 3493419402u ^ 3084770070u);
						continue;
					case 18u:
						AuthConfig.ReadConfig();
						Helper.PrintHeader(Module.smethod_36<string>(734380862u));
						arg_311_0 = (num * 1757761741u ^ 908751518u);
						continue;
					case 19u:
					{
						FileDescriptor arg_15_0 = ConnectionServiceReflection.Descriptor;
						arg_311_0 = (num * 2838421996u ^ 2086787572u);
						continue;
					}
					}
					Sandbox.smethod_5(5);
					arg_311_0 = 431780641u;
				}
			}
		}

		static Assembly smethod_0()
		{
			return Assembly.GetExecutingAssembly();
		}

		static string[] smethod_1(Assembly assembly_0)
		{
			return assembly_0.GetManifestResourceNames();
		}

		static CultureInfo smethod_2(string string_0)
		{
			return CultureInfo.GetCultureInfo(string_0);
		}

		static void smethod_3(CultureInfo cultureInfo_0)
		{
			CultureInfo.DefaultThreadCurrentCulture = cultureInfo_0;
		}

		static void smethod_4(CultureInfo cultureInfo_0)
		{
			CultureInfo.DefaultThreadCurrentUICulture = cultureInfo_0;
		}

		static void smethod_5(int int_0)
		{
			Thread.Sleep(int_0);
		}

		static Thread smethod_6(ThreadStart threadStart_0)
		{
			return new Thread(threadStart_0);
		}

		static void smethod_7(Thread thread_0)
		{
			thread_0.Start();
		}

		static bool smethod_8(string string_0)
		{
			return File.Exists(string_0);
		}

		static string smethod_9(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static void smethod_10(string string_0, string string_1)
		{
			File.WriteAllText(string_0, string_1);
		}

		static void smethod_11(string string_0)
		{
			File.Delete(string_0);
		}
	}
}
