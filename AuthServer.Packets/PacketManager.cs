using AuthServer.AuthServer.Attributes;
using AuthServer.Network;
using Bgs.Protocol;
using Bgs.Protocol.Connection.V1;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AuthServer.Packets
{
	internal class PacketManager
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly PacketManager.__c __9 = new PacketManager.__c();

			public static Func<Type, bool> __9__1_0;

			public static Func<MethodInfo, bool> __9__1_1;

			internal bool <Initialize>b__1_0(Type t)
			{
				return t.GetCustomAttribute<BnetServiceAttribute>() != null;
			}

			internal bool <Initialize>b__1_1(MethodInfo m)
			{
				return m.GetCustomAttribute<BnetServiceBase.BnetMethodAttribute>() != null;
			}
		}

		private static Dictionary<BnetServiceHash, Dictionary<uint, Tuple<MethodInfo, Type>>> BnetHandlers = new Dictionary<BnetServiceHash, Dictionary<uint, Tuple<MethodInfo, Type>>>();

		public static void Initialize()
		{
			new ConnectRequest();
			IEnumerable<Type> arg_2F_0 = PacketManager.smethod_1(PacketManager.smethod_0());
			Func<Type, bool> arg_2F_1;
			if ((arg_2F_1 = PacketManager.__c.__9__1_0) == null)
			{
				arg_2F_1 = (PacketManager.__c.__9__1_0 = new Func<Type, bool>(PacketManager.__c.__9.<Initialize>b__1_0));
			}
			IEnumerator<Type> enumerator = arg_2F_0.Where(arg_2F_1).GetEnumerator();
			try
			{
				while (true)
				{
					IL_1FE:
					Dictionary<uint, Tuple<MethodInfo, Type>> dictionary;
					BnetServiceAttribute customAttribute2;
					if (PacketManager.smethod_5(enumerator))
					{
						Type current;
						while (true)
						{
							IL_7D:
							current = enumerator.Current;
							uint arg_60_0 = 3939181532u;
							while (true)
							{
								uint num;
								switch ((num = (arg_60_0 ^ 3675968825u)) % 4u)
								{
								case 0u:
									arg_60_0 = 2366066018u;
									continue;
								case 1u:
									dictionary = new Dictionary<uint, Tuple<MethodInfo, Type>>();
									arg_60_0 = (num * 501308084u ^ 1268659751u);
									continue;
								case 3u:
									goto IL_7D;
								}
								goto Block_4;
							}
						}
						IL_8B:
						IEnumerable<MethodInfo> arg_B0_0 = PacketManager.smethod_2(current);
						Func<MethodInfo, bool> arg_B0_1;
						if ((arg_B0_1 = PacketManager.__c.__9__1_1) == null)
						{
							arg_B0_1 = (PacketManager.__c.__9__1_1 = new Func<MethodInfo, bool>(PacketManager.__c.__9.<Initialize>b__1_1));
						}
						IEnumerator<MethodInfo> enumerator2 = arg_B0_0.Where(arg_B0_1).GetEnumerator();
						try
						{
							while (true)
							{
								IL_156:
								uint arg_126_0 = (!PacketManager.smethod_5(enumerator2)) ? 2192753665u : 2863704170u;
								while (true)
								{
									uint num;
									switch ((num = (arg_126_0 ^ 3675968825u)) % 5u)
									{
									case 1u:
									{
										MethodInfo current2 = enumerator2.Current;
										arg_126_0 = 2582712217u;
										continue;
									}
									case 2u:
										arg_126_0 = 2863704170u;
										continue;
									case 3u:
										goto IL_156;
									case 4u:
									{
										MethodInfo current2;
										BnetServiceBase.BnetMethodAttribute customAttribute = current2.GetCustomAttribute<BnetServiceBase.BnetMethodAttribute>();
										dictionary.Add(customAttribute.MethodId, Tuple.Create<MethodInfo, Type>(current2, PacketManager.smethod_4(PacketManager.smethod_3(current2)[1])));
										arg_126_0 = (num * 2219415123u ^ 1278772922u);
										continue;
									}
									}
									goto Block_10;
								}
							}
							Block_10:;
						}
						finally
						{
							if (enumerator2 != null)
							{
								while (true)
								{
									IL_19C:
									uint arg_183_0 = 3982012916u;
									while (true)
									{
										uint num;
										switch ((num = (arg_183_0 ^ 3675968825u)) % 3u)
										{
										case 0u:
											goto IL_19C;
										case 2u:
											PacketManager.smethod_6(enumerator2);
											arg_183_0 = (num * 1197318719u ^ 1041664316u);
											continue;
										}
										goto Block_14;
									}
								}
								Block_14:;
							}
						}
						customAttribute2 = current.GetCustomAttribute<BnetServiceAttribute>();
						goto IL_1F0;
						Block_4:
						goto IL_8B;
					}
					uint arg_1D3_0 = 2990972076u;
					while (true)
					{
						IL_1CE:
						uint num;
						switch ((num = (arg_1D3_0 ^ 3675968825u)) % 4u)
						{
						case 0u:
							goto IL_1FE;
						case 2u:
							goto IL_1F0;
						case 3u:
							PacketManager.BnetHandlers.Add(customAttribute2.Hash, dictionary);
							arg_1D3_0 = (num * 2817925832u ^ 2492262217u);
							continue;
						}
						goto Block_7;
					}
					IL_1F0:
					arg_1D3_0 = 3221093554u;
					goto IL_1CE;
				}
				Block_7:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_244:
						uint arg_22B_0 = 4219142732u;
						while (true)
						{
							uint num;
							switch ((num = (arg_22B_0 ^ 3675968825u)) % 3u)
							{
							case 0u:
								goto IL_244;
							case 2u:
								PacketManager.smethod_6(enumerator);
								arg_22B_0 = (num * 2380696322u ^ 4103158020u);
								continue;
							}
							goto Block_17;
						}
					}
					Block_17:;
				}
			}
		}

		public static void InvokeHandler(AuthSession session, Header header, byte[] mesageData)
		{
			Dictionary<uint, Tuple<MethodInfo, Type>> dictionary;
			if (PacketManager.BnetHandlers.TryGetValue((BnetServiceHash)header.ServiceHash, out dictionary))
			{
				goto IL_4D;
			}
			goto IL_15E;
			uint arg_116_0;
			while (true)
			{
				IL_111:
				uint num;
				switch ((num = (arg_116_0 ^ 2546600134u)) % 11u)
				{
				case 1u:
					return;
				case 2u:
				{
					Tuple<MethodInfo, Type> tuple;
					arg_116_0 = ((dictionary.TryGetValue(header.MethodId, out tuple) ? 1003190270u : 800285307u) ^ num * 1238219360u);
					continue;
				}
				case 3u:
				{
					Tuple<MethodInfo, Type> tuple;
					IMessage message;
					PacketManager.smethod_8(tuple.Item1, null, new object[]
					{
						session,
						message
					});
					arg_116_0 = (num * 2382358017u ^ 1800995334u);
					continue;
				}
				case 4u:
					goto IL_15E;
				case 5u:
					goto IL_181;
				case 6u:
					return;
				case 7u:
				{
					Tuple<MethodInfo, Type> tuple;
					IMessage message = PacketManager.smethod_7(tuple.Item2) as IMessage;
					message.MergeFrom(mesageData);
					arg_116_0 = (num * 1361450107u ^ 2957748103u);
					continue;
				}
				case 8u:
					Log.Message(LogType.Error, PacketManager.smethod_9(Module.smethod_33<string>(4182591896u), header.MethodId, (BnetServiceHash)header.ServiceHash), Array.Empty<object>());
					arg_116_0 = 3522289751u;
					continue;
				case 9u:
					goto IL_4D;
				case 10u:
					PacketManager.smethod_14(PacketManager.smethod_13(Module.smethod_34<string>(1555219727u), PacketManager.smethod_12(header)));
					arg_116_0 = 3581752722u;
					continue;
				}
				break;
			}
			return;
			IL_181:
			PacketManager.smethod_14(PacketManager.smethod_13(Module.smethod_33<string>(13122572u), PacketManager.smethod_12(header)));
			return;
			IL_4D:
			arg_116_0 = 3450652428u;
			goto IL_111;
			IL_15E:
			arg_116_0 = (PacketManager.smethod_11(PacketManager.smethod_10(typeof(BnetServiceHash).TypeHandle), header.ServiceHash) ? 4239861377u : 3878306067u);
			goto IL_111;
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

		static ParameterInfo[] smethod_3(MethodBase methodBase_0)
		{
			return methodBase_0.GetParameters();
		}

		static Type smethod_4(ParameterInfo parameterInfo_0)
		{
			return parameterInfo_0.ParameterType;
		}

		static bool smethod_5(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_6(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static object smethod_7(Type type_0)
		{
			return Activator.CreateInstance(type_0);
		}

		static object smethod_8(MethodBase methodBase_0, object object_0, object[] object_1)
		{
			return methodBase_0.Invoke(object_0, object_1);
		}

		static string smethod_9(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		static Type smethod_10(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_11(Type type_0, object object_0)
		{
			return Enum.IsDefined(type_0, object_0);
		}

		static string smethod_12(object object_0)
		{
			return object_0.ToString();
		}

		static string smethod_13(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static void smethod_14(string string_0)
		{
			Console.WriteLine(string_0);
		}
	}
}
