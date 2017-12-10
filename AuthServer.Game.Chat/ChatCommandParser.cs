using AuthServer.Network;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AuthServer.Game.Chat
{
	public class ChatCommandParser
	{
		public delegate void HandleChatCommand(string[] args, WorldClass session);

		public delegate void HandleChatCommand2(string[] args, WorldClass2 session);

		public static Dictionary<string, ChatCommandParser.HandleChatCommand> ChatCommands = new Dictionary<string, ChatCommandParser.HandleChatCommand>();

		public static Dictionary<string, ChatCommandParser.HandleChatCommand2> ChatCommands2 = new Dictionary<string, ChatCommandParser.HandleChatCommand2>();

		public static void DefineChatCommands()
		{
			Type[] array = ChatCommandParser.smethod_1(ChatCommandParser.smethod_0());
			while (true)
			{
				IL_199:
				uint arg_153_0 = 119212129u;
				while (true)
				{
					uint num;
					switch ((num = (arg_153_0 ^ 1007403371u)) % 14u)
					{
					case 0u:
					{
						int num2;
						num2++;
						arg_153_0 = (num * 1657331071u ^ 1067304519u);
						continue;
					}
					case 1u:
					{
						ChatCommandAttribute customAttribute;
						arg_153_0 = (((customAttribute == null) ? 4070733108u : 3064879351u) ^ num * 3658418241u);
						continue;
					}
					case 2u:
					{
						int num2 = 0;
						arg_153_0 = (num * 495928625u ^ 1398255286u);
						continue;
					}
					case 3u:
						goto IL_199;
					case 4u:
					{
						int num2;
						arg_153_0 = ((num2 >= array.Length) ? 1429089151u : 1598209142u);
						continue;
					}
					case 5u:
					{
						ChatCommandAttribute customAttribute;
						MethodInfo methodInfo;
						ChatCommandParser.ChatCommands[customAttribute.ChatCommand] = (ChatCommandParser.HandleChatCommand)ChatCommandParser.smethod_4(ChatCommandParser.smethod_3(typeof(ChatCommandParser.HandleChatCommand).TypeHandle), methodInfo);
						arg_153_0 = (num * 1483645737u ^ 228464464u);
						continue;
					}
					case 6u:
					{
						int num3;
						num3++;
						arg_153_0 = 157078335u;
						continue;
					}
					case 7u:
					{
						int num3;
						MethodInfo[] array2;
						MethodInfo methodInfo = array2[num3];
						arg_153_0 = 2129732795u;
						continue;
					}
					case 9u:
						arg_153_0 = (num * 589339086u ^ 1306721079u);
						continue;
					case 10u:
					{
						MethodInfo methodInfo;
						ChatCommandAttribute customAttribute = methodInfo.GetCustomAttribute<ChatCommandAttribute>();
						arg_153_0 = (num * 1854628135u ^ 2009594928u);
						continue;
					}
					case 11u:
					{
						int num2;
						MethodInfo[] array2 = ChatCommandParser.smethod_2(array[num2]);
						arg_153_0 = 1177256068u;
						continue;
					}
					case 12u:
					{
						int num3;
						MethodInfo[] array2;
						arg_153_0 = ((num3 >= array2.Length) ? 2047522213u : 1377158200u);
						continue;
					}
					case 13u:
					{
						int num3 = 0;
						arg_153_0 = (num * 1157137936u ^ 3914591183u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void ExecuteChatHandler(string chatCommand, WorldClass session)
		{
			string[] array = ChatCommandParser.smethod_5(chatCommand, new string[]
			{
				Module.smethod_34<string>(1210918633u)
			}, StringSplitOptions.None);
			string key = ChatCommandParser.smethod_6(array[0], 0, 1);
			while (true)
			{
				IL_9A:
				uint arg_7E_0 = 4290933796u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7E_0 ^ 3881183605u)) % 4u)
					{
					case 1u:
						arg_7E_0 = ((ChatCommandParser.ChatCommands.ContainsKey(key) ? 1983062844u : 1891696354u) ^ num * 4159093623u);
						continue;
					case 2u:
						ChatCommandParser.ChatCommands[key](array, session);
						arg_7E_0 = (num * 4266578640u ^ 2567288869u);
						continue;
					case 3u:
						goto IL_9A;
					}
					return;
				}
			}
		}

		public static void DefineChatCommands2()
		{
			Type[] array = ChatCommandParser.smethod_1(ChatCommandParser.smethod_0());
			int num = 0;
			while (true)
			{
				IL_15B:
				uint arg_112_0 = (num < array.Length) ? 341848731u : 817372657u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_112_0 ^ 654282741u)) % 11u)
					{
					case 0u:
						goto IL_15B;
					case 1u:
					{
						int num3;
						num3++;
						arg_112_0 = 1012403200u;
						continue;
					}
					case 2u:
						num++;
						arg_112_0 = (num2 * 2111411435u ^ 2583908411u);
						continue;
					case 4u:
					{
						MethodInfo[] array2 = ChatCommandParser.smethod_2(array[num]);
						int num3 = 0;
						arg_112_0 = 764609352u;
						continue;
					}
					case 5u:
					{
						int num3;
						MethodInfo[] array2;
						arg_112_0 = ((num3 >= array2.Length) ? 1096215134u : 710141588u);
						continue;
					}
					case 6u:
					{
						ChatCommand2Attribute customAttribute;
						MethodInfo methodInfo;
						ChatCommandParser.ChatCommands2[customAttribute.ChatCommand] = (ChatCommandParser.HandleChatCommand2)ChatCommandParser.smethod_4(ChatCommandParser.smethod_3(typeof(ChatCommandParser.HandleChatCommand2).TypeHandle), methodInfo);
						arg_112_0 = (num2 * 3328026769u ^ 1273914374u);
						continue;
					}
					case 7u:
					{
						int num3;
						MethodInfo[] array2;
						MethodInfo methodInfo = array2[num3];
						ChatCommand2Attribute customAttribute = methodInfo.GetCustomAttribute<ChatCommand2Attribute>();
						arg_112_0 = 1187497071u;
						continue;
					}
					case 8u:
						arg_112_0 = (num2 * 2651831975u ^ 3574536523u);
						continue;
					case 9u:
						arg_112_0 = 341848731u;
						continue;
					case 10u:
					{
						ChatCommand2Attribute customAttribute;
						arg_112_0 = (((customAttribute != null) ? 1045421015u : 2070827812u) ^ num2 * 1521676189u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void ExecuteChatHandler2(string chatCommand, WorldClass2 session)
		{
			string[] array = ChatCommandParser.smethod_5(chatCommand, new string[]
			{
				Module.smethod_36<string>(2793817990u)
			}, StringSplitOptions.None);
			string key = ChatCommandParser.smethod_6(array[0], 0, 1);
			if (ChatCommandParser.ChatCommands2.ContainsKey(key))
			{
				while (true)
				{
					IL_75:
					uint arg_5D_0 = 2930766986u;
					while (true)
					{
						uint num;
						switch ((num = (arg_5D_0 ^ 4278760877u)) % 3u)
						{
						case 0u:
							goto IL_75;
						case 1u:
							ChatCommandParser.ChatCommands2[key](array, session);
							arg_5D_0 = (num * 1871045308u ^ 4256713516u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public static bool CheckForCommand(string command)
		{
			string string_ = Module.smethod_35<string>(946384381u);
			while (true)
			{
				IL_56:
				uint arg_3A_0 = 792521532u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3A_0 ^ 949174889u)) % 4u)
					{
					case 1u:
						arg_3A_0 = ((ChatCommandParser.smethod_7(command, string_) ? 4096386730u : 3826576652u) ^ num * 466054857u);
						continue;
					case 2u:
						return true;
					case 3u:
						goto IL_56;
					}
					return false;
				}
			}
			return false;
		}

		static Assembly smethod_0()
		{
			return Assembly.GetExecutingAssembly();
		}

		static Type[] smethod_1(Assembly assembly_0)
		{
			return assembly_0.GetTypes();
		}

		static MethodInfo[] smethod_2(Type type_0)
		{
			return type_0.GetMethods();
		}

		static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static Delegate smethod_4(Type type_0, MethodInfo methodInfo_0)
		{
			return Delegate.CreateDelegate(type_0, methodInfo_0);
		}

		static string[] smethod_5(string string_0, string[] string_1, StringSplitOptions stringSplitOptions_0)
		{
			return string_0.Split(string_1, stringSplitOptions_0);
		}

		static string smethod_6(string string_0, int int_0, int int_1)
		{
			return string_0.Remove(int_0, int_1);
		}

		static bool smethod_7(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}
	}
}
