using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Network.Packets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace AuthServer.WorldServer.Game.Packets
{
	public class PacketManager : Manager
	{
		private delegate void HandlePacket(ref PacketReader packet, WorldClass session);

		private delegate void HandlePacket2(ref PacketReader packet, WorldClass2 session);

		private static Dictionary<ClientMessage, PacketManager.HandlePacket> OpcodeHandlers = new Dictionary<ClientMessage, PacketManager.HandlePacket>();

		private static Dictionary<ClientMessage, PacketManager.HandlePacket2> OpcodeHandlers2 = new Dictionary<ClientMessage, PacketManager.HandlePacket2>();

		public static void DefineOpcodeHandler()
		{
			Type[] array = PacketManager.smethod_1(PacketManager.smethod_0());
			while (true)
			{
				IL_1DB:
				uint arg_1B6_0 = 1781133873u;
				while (true)
				{
					uint num;
					int num2;
					uint arg_142_0;
					int num3;
					switch ((num = (arg_1B6_0 ^ 315123486u)) % 6u)
					{
					case 0u:
						goto IL_1DB;
					case 1u:
						num2 = 0;
						arg_1B6_0 = (num * 2433928120u ^ 2770631119u);
						continue;
					case 2u:
						goto IL_186;
					case 3u:
						IL_11E:
						if (num2 < array.Length)
						{
							goto IL_186;
						}
						arg_142_0 = 792245191u;
						break;
					case 4u:
						num3 = 0;
						goto IL_111;
					case 5u:
						goto IL_16A;
					default:
						goto IL_16A;
					}
					while (true)
					{
						IL_13D:
						switch ((num = (arg_142_0 ^ 315123486u)) % 5u)
						{
						case 1u:
							num2++;
							arg_142_0 = (num * 2650436441u ^ 3815917589u);
							continue;
						case 2u:
							goto IL_11E;
						case 3u:
							goto IL_111;
						case 4u:
							goto IL_163;
						}
						return;
					}
					IL_186:
					MethodInfo[] array2 = PacketManager.smethod_2(array[num2]);
					arg_1B6_0 = 2007019048u;
					continue;
					IL_111:
					if (num3 >= array2.Length)
					{
						arg_142_0 = 235062078u;
						goto IL_13D;
					}
					goto IL_16A;
					IL_163:
					arg_142_0 = 1841975739u;
					goto IL_13D;
					IL_16A:
					MethodInfo methodInfo = array2[num3];
					IEnumerator<OpcodeAttribute> enumerator = methodInfo.GetCustomAttributes<OpcodeAttribute>().GetEnumerator();
					try
					{
						while (true)
						{
							IL_BA:
							uint arg_8A_0 = PacketManager.smethod_5(enumerator) ? 2138237464u : 70193693u;
							while (true)
							{
								switch ((num = (arg_8A_0 ^ 315123486u)) % 5u)
								{
								case 0u:
									arg_8A_0 = 2138237464u;
									continue;
								case 1u:
									goto IL_BA;
								case 2u:
								{
									OpcodeAttribute current = enumerator.Current;
									arg_8A_0 = ((current == null) ? 314398218u : 1728240380u);
									continue;
								}
								case 4u:
								{
									OpcodeAttribute current;
									PacketManager.OpcodeHandlers[current.Opcode] = (PacketManager.HandlePacket)PacketManager.smethod_4(PacketManager.smethod_3(typeof(PacketManager.HandlePacket).TypeHandle), methodInfo);
									arg_8A_0 = (num * 3181307333u ^ 518397664u);
									continue;
								}
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_103:
								uint arg_EA_0 = 921856005u;
								while (true)
								{
									switch ((num = (arg_EA_0 ^ 315123486u)) % 3u)
									{
									case 0u:
										goto IL_103;
									case 1u:
										PacketManager.smethod_6(enumerator);
										arg_EA_0 = (num * 374831327u ^ 897885318u);
										continue;
									}
									goto Block_11;
								}
							}
							Block_11:;
						}
					}
					num3++;
					goto IL_163;
				}
			}
		}

		public static void DefineOpcodeHandler2()
		{
			Type[] array = PacketManager.smethod_1(PacketManager.smethod_0());
			int num = 0;
			while (true)
			{
				IL_1E0:
				int arg_1B8_0 = 720968842;
				while (true)
				{
					int num2;
					MethodInfo[] array2;
					MethodInfo methodInfo;
					uint arg_44_0;
					switch ((arg_1B8_0 ^ 187693299) % 6)
					{
					case 0:
						goto IL_83;
					case 1:
						num2 = 0;
						goto IL_34;
					case 2:
						goto IL_1E0;
					case 3:
						IL_70:
						methodInfo = array2[num2];
						arg_1B8_0 = 2134993717;
						continue;
					case 4:
						goto IL_9A;
					case 5:
						IL_68:
						if (num < array.Length)
						{
							goto IL_83;
						}
						arg_44_0 = 1169583308u;
						break;
					default:
						goto IL_9A;
					}
					while (true)
					{
						IL_3F:
						uint num3;
						switch ((num3 = (arg_44_0 ^ 187693299u)) % 5u)
						{
						case 0u:
							goto IL_68;
						case 1u:
							goto IL_34;
						case 3u:
							num++;
							arg_44_0 = (num3 * 2911205606u ^ 2944092559u);
							continue;
						case 4u:
							goto IL_19;
						}
						return;
					}
					IL_34:
					if (num2 >= array2.Length)
					{
						arg_44_0 = 953874035u;
						goto IL_3F;
					}
					goto IL_70;
					IL_19:
					arg_44_0 = 193044341u;
					goto IL_3F;
					IL_83:
					array2 = PacketManager.smethod_2(array[num]);
					arg_1B8_0 = 296719328;
					continue;
					IL_9A:
					IEnumerator<Opcode2Attribute> enumerator = methodInfo.GetCustomAttributes<Opcode2Attribute>().GetEnumerator();
					try
					{
						while (true)
						{
							IL_152:
							uint arg_122_0 = (!PacketManager.smethod_5(enumerator)) ? 862574067u : 741055446u;
							while (true)
							{
								uint num3;
								switch ((num3 = (arg_122_0 ^ 187693299u)) % 5u)
								{
								case 0u:
									arg_122_0 = 741055446u;
									continue;
								case 2u:
								{
									Opcode2Attribute current;
									PacketManager.OpcodeHandlers2[current.Opcode] = (PacketManager.HandlePacket2)PacketManager.smethod_4(PacketManager.smethod_3(typeof(PacketManager.HandlePacket2).TypeHandle), methodInfo);
									arg_122_0 = (num3 * 2220846814u ^ 4198299646u);
									continue;
								}
								case 3u:
									goto IL_152;
								case 4u:
								{
									Opcode2Attribute current = enumerator.Current;
									arg_122_0 = ((current != null) ? 1372132325u : 1481746154u);
									continue;
								}
								}
								goto Block_8;
							}
						}
						Block_8:;
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_19B:
								uint arg_182_0 = 1737012298u;
								while (true)
								{
									uint num3;
									switch ((num3 = (arg_182_0 ^ 187693299u)) % 3u)
									{
									case 0u:
										goto IL_19B;
									case 2u:
										PacketManager.smethod_6(enumerator);
										arg_182_0 = (num3 * 2286764410u ^ 2847179084u);
										continue;
									}
									goto Block_12;
								}
							}
							Block_12:;
						}
					}
					num2++;
					goto IL_19;
				}
			}
		}

		public static void InvokeHandler(ref PacketReader reader, WorldClass session)
		{
			if (session.Character != null)
			{
				goto IL_FC;
			}
			goto IL_141;
			uint arg_106_0;
			while (true)
			{
				IL_101:
				uint num;
				switch ((num = (arg_106_0 ^ 1262397601u)) % 8u)
				{
				case 0u:
					return;
				case 1u:
					goto IL_141;
				case 2u:
					goto IL_FC;
				case 3u:
					Log.Message(LogType.Packet, Module.smethod_36<string>(2220261028u), new object[]
					{
						reader.Opcode,
						reader.Opcode,
						reader.Size
					});
					arg_106_0 = (num * 2647540295u ^ 630824896u);
					continue;
				case 4u:
					PacketManager.OpcodeHandlers[reader.Opcode](ref reader, session);
					arg_106_0 = (num * 1262893278u ^ 2437559409u);
					continue;
				case 5u:
				{
					ulong guid = session.Character.Guid;
					arg_106_0 = (((!Manager.WorldMgr.Sessions.ContainsKey(guid)) ? 498647924u : 326667058u) ^ num * 2040140420u);
					continue;
				}
				case 7u:
				{
					ulong guid;
					Manager.WorldMgr.Sessions[guid] = session;
					arg_106_0 = (num * 3313987136u ^ 2713835520u);
					continue;
				}
				}
				break;
			}
			Log.Message(LogType.Packet, Module.smethod_33<string>(901997343u), new object[]
			{
				reader.Opcode,
				reader.Opcode,
				reader.Size
			});
			return;
			IL_FC:
			arg_106_0 = 2147221676u;
			goto IL_101;
			IL_141:
			arg_106_0 = ((!PacketManager.OpcodeHandlers.ContainsKey(reader.Opcode)) ? 415428095u : 1277703962u);
			goto IL_101;
		}

		public static void InvokeHandler(ref PacketReader reader, WorldClass2 session)
		{
			if (session.Character != null)
			{
				goto IL_1D;
			}
			goto IL_10D;
			uint arg_D2_0;
			while (true)
			{
				IL_CD:
				uint num;
				switch ((num = (arg_D2_0 ^ 4276270309u)) % 8u)
				{
				case 0u:
					goto IL_10D;
				case 1u:
					goto IL_125;
				case 2u:
					arg_D2_0 = (((!Manager.WorldMgr.Sessions2.ContainsKey(0uL)) ? 2237578483u : 3357433262u) ^ num * 65758199u);
					continue;
				case 4u:
					PacketManager.OpcodeHandlers2[reader.Opcode](ref reader, session);
					arg_D2_0 = (num * 2035814786u ^ 254308324u);
					continue;
				case 5u:
					Manager.WorldMgr.Sessions2[0uL] = session;
					arg_D2_0 = (num * 424709425u ^ 2091957032u);
					continue;
				case 6u:
				{
					ulong arg_32_0 = session.Character.Guid;
					arg_D2_0 = (num * 3958291579u ^ 1546637405u);
					continue;
				}
				case 7u:
					goto IL_1D;
				}
				break;
			}
			goto IL_16A;
			IL_125:
			Log.Message(LogType.Packet, Module.smethod_35<string>(1352914638u), new object[]
			{
				reader.Opcode,
				reader.Opcode,
				reader.Size
			});
			return;
			IL_16A:
			Log.Message(LogType.Packet, Module.smethod_36<string>(729730053u), new object[]
			{
				reader.Opcode,
				reader.Opcode,
				reader.Size
			});
			return;
			IL_1D:
			arg_D2_0 = 4043372643u;
			goto IL_CD;
			IL_10D:
			arg_D2_0 = ((!PacketManager.OpcodeHandlers2.ContainsKey(reader.Opcode)) ? 2674153982u : 3059807657u);
			goto IL_CD;
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

		static bool smethod_5(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_6(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}
}
