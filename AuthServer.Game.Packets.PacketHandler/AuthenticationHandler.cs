using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Net;
using Framework.Cryptography.WoW;
using Framework.Database.Auth.Entities;
using Framework.Misc;
using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class AuthenticationHandler : Manager
	{
		private static byte[] clientSeed;

		private static byte[] serverSeed;

		private static byte[] sessionKey = new byte[40];

		private static byte[] arr1;

		private static byte[] arr2;

		private static byte[] sha2_3_grml;

		private static byte[] addondataaaa;

		public static WorldClass2 session2;

		private static int[] payloadOrder;

		public static void HandleAuthChallenge(ref PacketReader packet, WorldClass session)
		{
			session.initiated = true;
			while (true)
			{
				IL_145:
				uint arg_10C_0 = 2459053777u;
				while (true)
				{
					uint num;
					switch ((num = (arg_10C_0 ^ 4291803379u)) % 11u)
					{
					case 0u:
						arg_10C_0 = (num * 3870351961u ^ 1505659660u);
						continue;
					case 1u:
					{
						int num2;
						arg_10C_0 = ((num2 < 8) ? 3540268399u : 3313807745u);
						continue;
					}
					case 2u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteBytes(Globals.ServerSalt, 0);
						packetWriter.WriteUInt8(1);
						arg_10C_0 = (num * 732999107u ^ 2252234520u);
						continue;
					}
					case 3u:
					{
						int num2 = 0;
						arg_10C_0 = (num * 1996418291u ^ 1021293114u);
						continue;
					}
					case 4u:
					{
						Manager.WorldMgr.Sessions2.Clear();
						PacketWriter packetWriter = new PacketWriter(ServerMessage.AuthChallenge, false);
						arg_10C_0 = (num * 1186221898u ^ 2702994982u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_10C_0 = (num * 1648681476u ^ 2372259125u);
						continue;
					}
					case 6u:
						Globals.ServerSalt = new byte[0].GenerateRandomKey(16);
						arg_10C_0 = (num * 1231038991u ^ 850751506u);
						continue;
					case 7u:
						Manager.WorldMgr.Sessions.Clear();
						arg_10C_0 = (num * 2198824245u ^ 80213818u);
						continue;
					case 8u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						int num2;
						num2++;
						arg_10C_0 = 3003786868u;
						continue;
					}
					case 9u:
						goto IL_145;
					}
					return;
				}
			}
		}

		public static void HandleAuthChallenge(ref PacketReader packet, WorldClass2 session)
		{
			session.initiated = true;
			PacketWriter packetWriter;
			while (true)
			{
				IL_B5:
				uint arg_91_0 = 678710099u;
				while (true)
				{
					uint num;
					switch ((num = (arg_91_0 ^ 1840759029u)) % 6u)
					{
					case 1u:
						AuthenticationHandler.smethod_0(packetWriter, AuthenticationHandler.clientSeed = new byte[16]);
						AuthenticationHandler.smethod_0(packetWriter, AuthenticationHandler.serverSeed = new byte[16]);
						arg_91_0 = (num * 1123221691u ^ 983032136u);
						continue;
					case 2u:
						packetWriter = new PacketWriter(ServerMessage.AuthChallenge, false);
						arg_91_0 = (num * 2546250082u ^ 4201805034u);
						continue;
					case 3u:
						goto IL_B5;
					case 4u:
						AuthenticationHandler.smethod_0(packetWriter, new byte[16]);
						arg_91_0 = (num * 1487317018u ^ 3313288268u);
						continue;
					case 5u:
						packetWriter.WriteUInt8(1);
						arg_91_0 = (num * 320817430u ^ 2502966289u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}

		[Opcode(ClientMessage.AuthSession, "18125")]
		public static void HandleAuthResponse(ref PacketReader packet, WorldClass session)
		{
			BitUnpack arg_28_0 = new BitUnpack(packet);
			packet.Skip(23);
			Globals.ClientSalt = packet.ReadBytes(16u);
			packet.ReadBytes(24u);
			arg_28_0.GetBit();
			packet.ReadBytes(AuthenticationHandler.smethod_1(packet));
			while (true)
			{
				IL_921:
				uint arg_82F_0 = 2017539580u;
				while (true)
				{
					uint num;
					switch ((num = (arg_82F_0 ^ 973532324u)) % 57u)
					{
					case 0u:
						TimeHandler.HandleSetTimezoneInformation(ref session);
						arg_82F_0 = (num * 3644867839u ^ 4102176202u);
						continue;
					case 1u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 3925958146u ^ 429357566u);
						continue;
					}
					case 2u:
					{
						BitPack bitPack;
						bitPack.Flush();
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 3843609867u ^ 274333066u);
						continue;
					}
					case 3u:
					{
						PacketWriter packetWriter;
						byte[,] array;
						int num2;
						packetWriter.WriteUInt8(array[num2, 1]);
						arg_82F_0 = (num * 2139226297u ^ 222787957u);
						continue;
					}
					case 4u:
					{
						int num3 = 0;
						arg_82F_0 = (num * 1275993637u ^ 3289780354u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						BitPack bitPack;
						bool flag;
						bitPack.Write<bool>(flag);
						bool bit;
						bitPack.Write<bool>(bit);
						bitPack.Flush();
						arg_82F_0 = (num * 190331667u ^ 3544293151u);
						continue;
					}
					case 6u:
					{
						PacketWriter packetWriter;
						int num3;
						byte[,] array2;
						packetWriter.WriteUInt8(array2[num3, 0]);
						arg_82F_0 = 979003297u;
						continue;
					}
					case 7u:
					{
						SHA256Managed hashAlgorithm_;
						byte[] array3;
						AuthenticationHandler.smethod_4(hashAlgorithm_, array3, array3.Length >> 1, array3.Length - (array3.Length >> 1));
						SHA256Managed hashAlgorithm_2;
						SHA256Managed hashAlgorithm_3;
						AuthenticationHandler.smethod_3(hashAlgorithm_2, AuthenticationHandler.smethod_5(hashAlgorithm_3), 0, 32, AuthenticationHandler.smethod_5(hashAlgorithm_3), 0);
						arg_82F_0 = (num * 4247721102u ^ 2164875264u);
						continue;
					}
					case 8u:
						goto IL_921;
					case 9u:
					{
						int num3;
						byte[,] array2;
						arg_82F_0 = ((num3 < AuthenticationHandler.smethod_9(array2) / 2) ? 942732371u : 402681424u);
						continue;
					}
					case 10u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 1272726928u ^ 3573012072u);
						continue;
					}
					case 11u:
					{
						int num4;
						arg_82F_0 = ((num4 != 32) ? 1613600137u : 94715230u);
						continue;
					}
					case 12u:
					{
						SHA256Managed hashAlgorithm_;
						SHA256Managed hashAlgorithm_2;
						AuthenticationHandler.smethod_4(hashAlgorithm_2, AuthenticationHandler.smethod_5(hashAlgorithm_), 0, 32);
						AuthenticationHandler.sha2_3_grml = AuthenticationHandler.smethod_5(hashAlgorithm_2);
						int num4 = 0;
						int num5 = 0;
						arg_82F_0 = (num * 1594528258u ^ 4035022218u);
						continue;
					}
					case 13u:
						arg_82F_0 = (num * 3592674904u ^ 3437742173u);
						continue;
					case 14u:
						AuthenticationHandler.HandleConnectTo(session, 3724, 1, null);
						arg_82F_0 = (num * 4096365546u ^ 2720471261u);
						continue;
					case 15u:
					{
						bool bit = false;
						PacketWriter packetWriter = new PacketWriter(ServerMessage.AuthResponse, true);
						arg_82F_0 = (num * 1668503324u ^ 4008787019u);
						continue;
					}
					case 16u:
					{
						int num4;
						arg_82F_0 = ((num4 < 40) ? 1976385685u : 1159001732u);
						continue;
					}
					case 17u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 3445906520u ^ 4063066220u);
						continue;
					}
					case 18u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						arg_82F_0 = (num * 621848300u ^ 3406194050u);
						continue;
					}
					case 19u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 3867729530u ^ 1908424397u);
						continue;
					}
					case 20u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 1394835192u ^ 145004486u);
						continue;
					}
					case 21u:
					{
						PacketWriter packetWriter;
						byte[,] array2;
						packetWriter.WriteInt32(AuthenticationHandler.smethod_9(array2) / 2);
						byte[,] array;
						packetWriter.WriteInt32(AuthenticationHandler.smethod_9(array) / 2);
						arg_82F_0 = (num * 3125389306u ^ 6579303u);
						continue;
					}
					case 22u:
					{
						byte[,] array;
						int num2;
						arg_82F_0 = ((num2 < AuthenticationHandler.smethod_9(array) / 2) ? 248887578u : 276684735u);
						continue;
					}
					case 23u:
					{
						int num4;
						num4++;
						int num5;
						num5++;
						arg_82F_0 = (num * 2780937424u ^ 1515612061u);
						continue;
					}
					case 24u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 192068700u ^ 4062459581u);
						continue;
					}
					case 25u:
					{
						byte[,] expr_4C2 = new byte[12, 2];
						AuthenticationHandler.smethod_8(expr_4C2, fieldof(<PrivateImplementationDetails>.struct7_0).FieldHandle);
						byte[,] array = expr_4C2;
						byte[,] expr_4D7 = new byte[19, 2];
						AuthenticationHandler.smethod_8(expr_4D7, fieldof(<PrivateImplementationDetails>.B1151C6C80B16E10C2CAD0E6524E20DB89985020).FieldHandle);
						byte[,] array2 = expr_4D7;
						arg_82F_0 = (num * 775829900u ^ 1086551519u);
						continue;
					}
					case 26u:
						Manager.WorldMgr.SendHotfixes(session);
						arg_82F_0 = (num * 2297567052u ^ 3529457580u);
						continue;
					case 27u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_82F_0 = (num * 2838081966u ^ 1401284309u);
						continue;
					}
					case 28u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_82F_0 = (num * 1276988104u ^ 1332711413u);
						continue;
					}
					case 29u:
						new PacketWriter(ServerMessage.EnableCrypt, false);
						session.Account = new Account
						{
							Id = 1,
							Email = Module.smethod_35<string>(2737471542u),
							PasswordVerifier = Module.smethod_36<string>(1789483827u),
							Salt = Module.smethod_36<string>(2533110280u),
							IP = "",
							SessionKey = "",
							SecurityFlags = 0,
							OS = Module.smethod_36<string>(2605452825u),
							Expansion = 5,
							IsOnline = false
						};
						arg_82F_0 = (num * 3099364030u ^ 778753807u);
						continue;
					case 30u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(6);
						arg_82F_0 = (num * 960037049u ^ 4251590658u);
						continue;
					}
					case 31u:
					{
						int num3;
						num3++;
						arg_82F_0 = (num * 2647826660u ^ 3081572510u);
						continue;
					}
					case 32u:
					{
						int num5 = 0;
						arg_82F_0 = (num * 2855624283u ^ 1934999727u);
						continue;
					}
					case 33u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_82F_0 = 394845639u;
						continue;
					}
					case 34u:
					{
						PacketWriter packetWriter;
						BitPack bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						arg_82F_0 = (num * 3839928679u ^ 2674270183u);
						continue;
					}
					case 35u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_82F_0 = (num * 1275983207u ^ 2624941272u);
						continue;
					}
					case 36u:
						new PacketWriter(ServerMessage.SuspendComms, true).WriteUInt32(20u);
						arg_82F_0 = (num * 3412051023u ^ 3748987744u);
						continue;
					case 37u:
					{
						PacketWriter packetWriter;
						byte[,] array;
						int num2;
						packetWriter.WriteUInt8(array[num2, 0]);
						arg_82F_0 = 1152594217u;
						continue;
					}
					case 38u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_82F_0 = (num * 1357121348u ^ 1027085582u);
						continue;
					}
					case 39u:
					{
						SHA256Managed hashAlgorithm_2 = AuthenticationHandler.smethod_6();
						byte[] array3;
						SHA256Managed hashAlgorithm_3;
						AuthenticationHandler.smethod_4(hashAlgorithm_3, array3, 0, array3.Length >> 1);
						arg_82F_0 = (num * 3349724847u ^ 3826309419u);
						continue;
					}
					case 40u:
					{
						bool flag = true;
						arg_82F_0 = (num * 2469044217u ^ 389509509u);
						continue;
					}
					case 41u:
					{
						int num4;
						int num5;
						AuthenticationHandler.sessionKey[num4] = AuthenticationHandler.sha2_3_grml[num5];
						arg_82F_0 = 121248238u;
						continue;
					}
					case 42u:
					{
						SHA256Managed hashAlgorithm_2;
						AuthenticationHandler.sha2_3_grml = AuthenticationHandler.smethod_5(hashAlgorithm_2);
						arg_82F_0 = (num * 3186781206u ^ 568291510u);
						continue;
					}
					case 43u:
					{
						SHA256Managed hashAlgorithm_2;
						AuthenticationHandler.smethod_7(hashAlgorithm_2);
						SHA256Managed hashAlgorithm_3;
						AuthenticationHandler.smethod_3(hashAlgorithm_2, AuthenticationHandler.smethod_5(hashAlgorithm_3), 0, 32, AuthenticationHandler.smethod_5(hashAlgorithm_3), 0);
						arg_82F_0 = (num * 273351295u ^ 2423198895u);
						continue;
					}
					case 44u:
					{
						PacketWriter packetWriter;
						int num3;
						byte[,] array2;
						packetWriter.WriteUInt8(array2[num3, 1]);
						arg_82F_0 = (num * 3258273611u ^ 1239887723u);
						continue;
					}
					case 46u:
					{
						HMACSHA256 expr_182 = AuthenticationHandler.smethod_2(Globals.SessionKey);
						AuthenticationHandler.smethod_3(expr_182, Globals.ServerSalt, 0, Globals.ServerSalt.Length, Globals.ServerSalt, 0);
						AuthenticationHandler.smethod_3(expr_182, Globals.ClientSalt, 0, Globals.ClientSalt.Length, Globals.ClientSalt, 0);
						AuthenticationHandler.smethod_4(expr_182, AuthenticationHandler.arr1, 0, AuthenticationHandler.arr1.Length);
						byte[] array3 = AuthenticationHandler.smethod_5(expr_182);
						SHA256Managed hashAlgorithm_3 = AuthenticationHandler.smethod_6();
						SHA256Managed hashAlgorithm_ = AuthenticationHandler.smethod_6();
						arg_82F_0 = (num * 1844584669u ^ 1891453460u);
						continue;
					}
					case 47u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt32(0u);
						arg_82F_0 = (num * 1008232628u ^ 30771472u);
						continue;
					}
					case 48u:
					{
						int num2 = 0;
						arg_82F_0 = (num * 1707978014u ^ 2368748458u);
						continue;
					}
					case 49u:
					{
						SHA256Managed hashAlgorithm_2;
						AuthenticationHandler.smethod_3(hashAlgorithm_2, AuthenticationHandler.sha2_3_grml, 0, 32, AuthenticationHandler.sha2_3_grml, 0);
						SHA256Managed hashAlgorithm_;
						AuthenticationHandler.smethod_4(hashAlgorithm_2, AuthenticationHandler.smethod_5(hashAlgorithm_), 0, 32);
						arg_82F_0 = (num * 1428097193u ^ 1748239185u);
						continue;
					}
					case 50u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_82F_0 = (num * 2377469058u ^ 4212942142u);
						continue;
					}
					case 51u:
					{
						SHA256Managed hashAlgorithm_2;
						AuthenticationHandler.smethod_3(hashAlgorithm_2, AuthenticationHandler.sha2_3_grml, 0, 32, AuthenticationHandler.sha2_3_grml, 0);
						arg_82F_0 = (num * 116417243u ^ 3699589835u);
						continue;
					}
					case 52u:
					{
						bool flag;
						arg_82F_0 = (((!flag) ? 1888186652u : 1737280166u) ^ num * 1515350310u);
						continue;
					}
					case 53u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteUInt8(6);
						arg_82F_0 = (num * 200448416u ^ 3957963237u);
						continue;
					}
					case 54u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_82F_0 = (num * 2761573231u ^ 325309565u);
						continue;
					}
					case 55u:
						arg_82F_0 = (num * 1571901877u ^ 4021021157u);
						continue;
					case 56u:
					{
						int num2;
						num2++;
						arg_82F_0 = (num * 3035465689u ^ 1114317311u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleConnectTo(WorldClass session, ushort port = 3724, byte conn = 0, WorldClass2 session2 = null)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.ConnectTo, true);
			while (true)
			{
				IL_65:
				uint arg_48_0 = 1189851645u;
				while (true)
				{
					uint num;
					switch ((num = (arg_48_0 ^ 117810876u)) % 4u)
					{
					case 0u:
						goto IL_65;
					case 1u:
						packetWriter.WriteUInt64(12330219965770517405uL);
						arg_48_0 = (num * 886289363u ^ 1599573856u);
						continue;
					case 3u:
						packetWriter.WriteUInt32(14u);
						arg_48_0 = (num * 798883457u ^ 2791294625u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			RsaCrypt rsaCrypt = new RsaCrypt();
			try
			{
				rsaCrypt.InitializeEncryption<byte[]>(RsaStore.D, RsaStore.P, RsaStore.Q, RsaStore.DP, RsaStore.DQ, RsaStore.InverseQ, false);
				while (true)
				{
					IL_53C:
					uint arg_4A2_0 = 1950399364u;
					while (true)
					{
						uint num;
						switch ((num = (arg_4A2_0 ^ 117810876u)) % 35u)
						{
						case 0u:
						{
							byte[] array;
							int num2;
							array[num2] = (byte)AuthenticationHandler.payloadOrder[num2];
							arg_4A2_0 = 778837338u;
							continue;
						}
						case 1u:
						{
							byte[] array2;
							array2[10] = 0;
							array2[11] = 0;
							arg_4A2_0 = (num * 3426925493u ^ 1622493560u);
							continue;
						}
						case 2u:
						{
							byte[] array2;
							array2[18] = 0;
							arg_4A2_0 = (num * 3672511218u ^ 2614652434u);
							continue;
						}
						case 3u:
						{
							byte[] array2;
							array2[0] = 67;
							arg_4A2_0 = (num * 70935332u ^ 306833328u);
							continue;
						}
						case 4u:
						{
							byte[] array2;
							byte[] array3;
							array2[22] = array3[1];
							arg_4A2_0 = (num * 3674763274u ^ 3649142947u);
							continue;
						}
						case 5u:
						{
							byte[] array2;
							array2[13] = 0;
							array2[14] = 0;
							arg_4A2_0 = (num * 788135060u ^ 2778562157u);
							continue;
						}
						case 6u:
							goto IL_53C;
						case 7u:
						{
							byte[] array2;
							array2[1] = 253;
							array2[2] = 184;
							arg_4A2_0 = (num * 4034181865u ^ 116591846u);
							continue;
						}
						case 8u:
						{
							byte[] array2;
							array2[15] = 0;
							array2[16] = 0;
							arg_4A2_0 = (num * 1808574983u ^ 3232411455u);
							continue;
						}
						case 9u:
						{
							byte[] array2 = new byte[255];
							arg_4A2_0 = (num * 3052653591u ^ 3793484446u);
							continue;
						}
						case 10u:
							arg_4A2_0 = (num * 566048763u ^ 581218626u);
							continue;
						case 11u:
						{
							byte[] array2;
							array2[233] = 42;
							arg_4A2_0 = (num * 3199619518u ^ 4104188893u);
							continue;
						}
						case 12u:
						{
							byte[] array2;
							array2[5] = 127;
							arg_4A2_0 = (num * 534924131u ^ 1301694869u);
							continue;
						}
						case 13u:
						{
							byte[] array2;
							array2[20] = 0;
							byte[] array3 = AuthenticationHandler.smethod_10(port);
							array2[21] = array3[0];
							arg_4A2_0 = (num * 1558897694u ^ 577623817u);
							continue;
						}
						case 14u:
						{
							byte[] array2;
							array2[6] = 0;
							arg_4A2_0 = (num * 1594444616u ^ 3121916550u);
							continue;
						}
						case 15u:
						{
							byte[] array2;
							AuthenticationHandler.smethod_13(new byte[0].GenerateRandomKey(20), 0, array2, 234, 20);
							arg_4A2_0 = (num * 1673846917u ^ 3902196868u);
							continue;
						}
						case 16u:
						{
							byte[] expr_2B6 = new byte[32];
							AuthenticationHandler.smethod_8(expr_2B6, fieldof(<PrivateImplementationDetails>.struct8_0).FieldHandle);
							byte[] array2;
							AuthenticationHandler.smethod_13(expr_2B6, 0, array2, 93, 32);
							AuthenticationHandler.smethod_13(new byte[108], 0, array2, 125, 108);
							arg_4A2_0 = (num * 3680003173u ^ 2041052791u);
							continue;
						}
						case 17u:
						{
							byte[] array2;
							Array arg_297_0 = rsaCrypt.Encrypt<byte[]>(array2, false);
							byte[] array4 = new byte[256];
							AuthenticationHandler.smethod_14(arg_297_0, array4, 256);
							arg_4A2_0 = (num * 2289352343u ^ 161977499u);
							continue;
						}
						case 18u:
						{
							int num2;
							num2++;
							arg_4A2_0 = 1213188245u;
							continue;
						}
						case 19u:
						{
							rsaCrypt.InitializeDecryption<byte[]>(RsaStore.Exponent, RsaStore.Modulus, false);
							byte[] array = new byte[AuthenticationHandler.payloadOrder.Length];
							arg_4A2_0 = (num * 163108824u ^ 2004099280u);
							continue;
						}
						case 20u:
						{
							byte[] array2;
							array2[7] = 0;
							arg_4A2_0 = (num * 669897089u ^ 3823184314u);
							continue;
						}
						case 21u:
						{
							int num2 = 0;
							arg_4A2_0 = (num * 1178352322u ^ 2056709069u);
							continue;
						}
						case 22u:
						{
							string string_ = Module.smethod_35<string>(848950031u);
							arg_4A2_0 = (num * 560797187u ^ 1592203457u);
							continue;
						}
						case 23u:
							packetWriter.WriteUInt8(conn);
							arg_4A2_0 = (num * 264353632u ^ 1806577887u);
							continue;
						case 24u:
						{
							int num2;
							arg_4A2_0 = ((AuthenticationHandler.payloadOrder[num2] <= 16) ? 423310451u : 557178527u);
							continue;
						}
						case 25u:
						{
							byte[] array2;
							array2[3] = 34;
							array2[4] = 1;
							arg_4A2_0 = (num * 4152105185u ^ 2192753377u);
							continue;
						}
						case 26u:
						{
							byte[] array;
							int num2;
							array[num2] = (byte)(AuthenticationHandler.payloadOrder[num2] - 3);
							arg_4A2_0 = (num * 3507665298u ^ 2968893570u);
							continue;
						}
						case 27u:
						{
							byte[] array2;
							array2[12] = 0;
							arg_4A2_0 = (num * 618037152u ^ 1046649983u);
							continue;
						}
						case 28u:
						{
							byte[] array2;
							array2[19] = 0;
							arg_4A2_0 = (num * 1680293565u ^ 2487070996u);
							continue;
						}
						case 29u:
						{
							int num2;
							arg_4A2_0 = ((num2 >= AuthenticationHandler.payloadOrder.Length) ? 858439922u : 70439534u);
							continue;
						}
						case 30u:
						{
							byte[] array4;
							AuthenticationHandler.smethod_0(packetWriter, array4);
							arg_4A2_0 = (num * 216092153u ^ 2688375690u);
							continue;
						}
						case 31u:
						{
							byte[] array2;
							array2[8] = 1;
							array2[9] = 0;
							arg_4A2_0 = (num * 3445269463u ^ 748842564u);
							continue;
						}
						case 33u:
						{
							byte[] array2;
							array2[17] = 0;
							arg_4A2_0 = (num * 40612712u ^ 3030126910u);
							continue;
						}
						case 34u:
						{
							byte[] array2;
							string string_;
							AuthenticationHandler.smethod_13(AuthenticationHandler.smethod_12(AuthenticationHandler.smethod_11(), string_), 0, array2, 23, 71);
							arg_4A2_0 = (num * 376848159u ^ 536405427u);
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
				if (rsaCrypt != null)
				{
					while (true)
					{
						IL_57F:
						uint arg_566_0 = 461746135u;
						while (true)
						{
							uint num;
							switch ((num = (arg_566_0 ^ 117810876u)) % 3u)
							{
							case 0u:
								goto IL_57F;
							case 2u:
								AuthenticationHandler.smethod_15(rsaCrypt);
								arg_566_0 = (num * 3554924306u ^ 496472224u);
								continue;
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
			}
			if (session2 == null)
			{
				goto IL_5B1;
			}
			IL_58A:
			int arg_594_0 = 202372283;
			IL_58F:
			switch ((arg_594_0 ^ 117810876) % 4)
			{
			case 0:
				IL_5B1:
				session.Send(ref packetWriter);
				arg_594_0 = 910700601;
				goto IL_58F;
			case 2:
				goto IL_58A;
			case 3:
				session2.Send(ref packetWriter);
				return;
			}
		}

		[Opcode2(ClientMessage.AuthContinuedSession, "18125")]
		public static void HandleAuthContinuedSession(ref PacketReader packet, WorldClass2 session)
		{
			AuthenticationHandler.session2 = session;
			Manager.WorldMgr.Sessions.SingleOrDefault<KeyValuePair<ulong, WorldClass>>();
			while (true)
			{
				IL_1B7:
				uint arg_17D_0 = 2389353796u;
				while (true)
				{
					uint num;
					switch ((num = (arg_17D_0 ^ 2381408322u)) % 11u)
					{
					case 0u:
						goto IL_1B7;
					case 1u:
					{
						SHA1Managed expr_127 = AuthenticationHandler.smethod_18();
						byte[] array;
						AuthenticationHandler.smethod_3(expr_127, array, 0, array.Length, array, 0);
						byte[] array2;
						AuthenticationHandler.smethod_3(expr_127, array2, 0, 40, array2, 0);
						byte[] byte_;
						AuthenticationHandler.smethod_4(expr_127, byte_, 0, 4);
						AuthenticationHandler.smethod_5(expr_127);
						new PacketWriter(ServerMessage.EnableCrypt, false);
						PacketWriter packetWriter = new PacketWriter(ServerMessage.ResumeComms, true);
						arg_17D_0 = (num * 3949002163u ^ 3941582883u);
						continue;
					}
					case 2u:
					{
						PacketWriter packetWriter;
						AuthenticationHandler.session2.Send(ref packetWriter);
						arg_17D_0 = (num * 3904375768u ^ 568160447u);
						continue;
					}
					case 3u:
						packet.Read<ulong>();
						packet.ReadBytes(20u);
						arg_17D_0 = (((AuthenticationHandler.session2 != null) ? 2852424687u : 3500428177u) ^ num * 109821150u);
						continue;
					case 4u:
					{
						byte[] array2 = AuthenticationHandler.sessionKey;
						arg_17D_0 = (num * 2163954332u ^ 1605872583u);
						continue;
					}
					case 5u:
						return;
					case 6u:
					{
						byte[] byte_ = AuthenticationHandler.smethod_17(2549515048u);
						arg_17D_0 = (num * 4131246918u ^ 2980239949u);
						continue;
					}
					case 7u:
						packet.Read<ulong>();
						arg_17D_0 = (num * 3561050817u ^ 404291365u);
						continue;
					case 8u:
						arg_17D_0 = ((Manager.WorldMgr.AddSession2(0uL, ref AuthenticationHandler.session2) ? 213636815u : 1576825925u) ^ num * 3435104658u);
						continue;
					case 9u:
					{
						byte[] array = AuthenticationHandler.smethod_12(AuthenticationHandler.smethod_16(), Module.smethod_34<string>(1006528553u));
						arg_17D_0 = 2341857576u;
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:;
		}

		[Opcode(ClientMessage.test, "18125")]
		public static void Handletest(ref PacketReader packet, WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.ResumeComms, true);
			while (true)
			{
				IL_68:
				int arg_52_0 = 2086761285;
				while (true)
				{
					switch ((arg_52_0 ^ 716606170) % 3)
					{
					case 1:
					{
						session.Send(ref packetWriter);
						WorldClass2 expr_3E = Manager.WorldMgr.GetSession2((session.Character != null) ? session.Character.Guid : 0uL);
						if (expr_3E != null)
						{
							expr_3E.Send(ref packetWriter);
							arg_52_0 = 92366913;
							continue;
						}
						return;
					}
					case 2:
						goto IL_68;
					}
					return;
				}
			}
		}

		static AuthenticationHandler()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_A2:
				uint arg_86_0 = 3334137405u;
				while (true)
				{
					uint num;
					switch ((num = (arg_86_0 ^ 3525105984u)) % 4u)
					{
					case 1u:
					{
						byte[] expr_64 = new byte[16];
						AuthenticationHandler.smethod_8(expr_64, fieldof(<PrivateImplementationDetails>.B89B07A7120C696B7638B957EE29199B2C4A146A).FieldHandle);
						AuthenticationHandler.arr1 = expr_64;
						arg_86_0 = (num * 352440107u ^ 4230735368u);
						continue;
					}
					case 2u:
						goto IL_A2;
					case 3u:
					{
						byte[] expr_18 = new byte[16];
						AuthenticationHandler.smethod_8(expr_18, fieldof(<PrivateImplementationDetails>.B61E96F0A5A28CB929D5953E560D8CCDFE79E0B6).FieldHandle);
						AuthenticationHandler.arr2 = expr_18;
						AuthenticationHandler.sha2_3_grml = new byte[32];
						int[] expr_3E = new int[255];
						AuthenticationHandler.smethod_8(expr_3E, fieldof(<PrivateImplementationDetails>.E2BEDB04AA573B9D0F901152C9A76F86FDF602D7).FieldHandle);
						AuthenticationHandler.payloadOrder = expr_3E;
						arg_86_0 = (num * 3984794667u ^ 1911801665u);
						continue;
					}
					}
					return;
				}
			}
		}

		static void smethod_0(BinaryWriter binaryWriter_0, byte[] byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static uint smethod_1(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt32();
		}

		static HMACSHA256 smethod_2(byte[] byte_0)
		{
			return new HMACSHA256(byte_0);
		}

		static int smethod_3(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
		{
			return hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
		}

		static byte[] smethod_4(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
		{
			return hashAlgorithm_0.TransformFinalBlock(byte_0, int_0, int_1);
		}

		static byte[] smethod_5(HashAlgorithm hashAlgorithm_0)
		{
			return hashAlgorithm_0.Hash;
		}

		static SHA256Managed smethod_6()
		{
			return new SHA256Managed();
		}

		static void smethod_7(HashAlgorithm hashAlgorithm_0)
		{
			hashAlgorithm_0.Initialize();
		}

		static void smethod_8(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		static int smethod_9(Array array_0)
		{
			return array_0.Length;
		}

		static byte[] smethod_10(ushort ushort_0)
		{
			return BitConverter.GetBytes(ushort_0);
		}

		static Encoding smethod_11()
		{
			return Encoding.ASCII;
		}

		static byte[] smethod_12(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static void smethod_13(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Array.Copy(array_0, int_0, array_1, int_1, int_2);
		}

		static void smethod_14(Array array_0, Array array_1, int int_0)
		{
			Array.Copy(array_0, array_1, int_0);
		}

		static void smethod_15(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static Encoding smethod_16()
		{
			return Encoding.UTF8;
		}

		static byte[] smethod_17(uint uint_0)
		{
			return BitConverter.GetBytes(uint_0);
		}

		static SHA1Managed smethod_18()
		{
			return new SHA1Managed();
		}
	}
}
