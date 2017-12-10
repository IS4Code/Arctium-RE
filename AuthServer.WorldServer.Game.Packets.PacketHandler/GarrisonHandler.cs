using AuthServer.Network;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace AuthServer.WorldServer.Game.Packets.PacketHandler
{
	internal class GarrisonHandler
	{
		public static void HandleGarrisonArchitectShow(ref WorldClass session)
		{
			PacketWriter writer = new PacketWriter(ServerMessage.GarrisonArchitectShow, true);
			while (true)
			{
				IL_DF:
				uint arg_BB_0 = 519852802u;
				while (true)
				{
					uint num;
					switch ((num = (arg_BB_0 ^ 2020681083u)) % 6u)
					{
					case 0u:
					{
						BitPack bitPack;
						BitPack arg_9B_0 = bitPack;
						byte[] expr_90 = new byte[8];
						GarrisonHandler.smethod_0(expr_90, fieldof(<PrivateImplementationDetails>.A6356C34D834F1378076C055107CCAC50CB8FD29).FieldHandle);
						arg_9B_0.WriteGuidBytes(expr_90);
						session.Send(ref writer);
						arg_BB_0 = (num * 633679243u ^ 2700141092u);
						continue;
					}
					case 2u:
					{
						BitPack bitPack;
						BitPack arg_75_0 = bitPack;
						byte[] expr_6A = new byte[8];
						GarrisonHandler.smethod_0(expr_6A, fieldof(<PrivateImplementationDetails>.B5D22AB939F65E39BB62E1597149F6799F44E90B).FieldHandle);
						arg_75_0.WriteGuidMask(expr_6A);
						arg_BB_0 = (num * 3489683734u ^ 862438344u);
						continue;
					}
					case 3u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_BB_0 = (num * 2364201028u ^ 2081367199u);
						continue;
					}
					case 4u:
						goto IL_DF;
					case 5u:
					{
						BitPack bitPack = new BitPack(writer, session.Character.Guid, 0uL, 0uL, 0uL);
						arg_BB_0 = (num * 3788217399u ^ 2705928972u);
						continue;
					}
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.GetGarrisonInfo, "17930")]
		public static void HandleGetGarrisonInfo(ref PacketReader packet, WorldClass session)
		{
			GarrisonHandler.HandleGetGarrisonInfoResult(ref session, false);
		}

		[Opcode(ClientMessage.UpgradeGarrison, "17930")]
		public static void HandleUpgradeGarrison(ref PacketReader packet, WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.GarrisonUpgradeResult, true);
			while (true)
			{
				IL_AF:
				uint arg_8F_0 = 4193328415u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8F_0 ^ 3693211980u)) % 5u)
					{
					case 0u:
						GarrisonHandler.smethod_1(packetWriter, 2);
						GarrisonHandler.smethod_1(packetWriter, 2);
						arg_8F_0 = (num * 888375759u ^ 4118426997u);
						continue;
					case 2u:
						goto IL_AF;
					case 3u:
						session.Send(ref packetWriter);
						arg_8F_0 = (num * 1459184172u ^ 711672708u);
						continue;
					case 4u:
					{
						BitPack expr_3D = new BitPack(packetWriter, session.Character.Guid, 0uL, 0uL, 0uL);
						expr_3D.Write<int>(1);
						expr_3D.Flush();
						arg_8F_0 = (num * 1902694356u ^ 1637576038u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleGetGarrisonInfoResult(ref WorldClass session, bool sendFollower = false)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.GetGarrisonInfoResult, true);
			while (true)
			{
				IL_562:
				uint arg_4C5_0 = 3561853899u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4C5_0 ^ 2830501285u)) % 36u)
					{
					case 0u:
						GarrisonHandler.smethod_1(packetWriter, 32);
						GarrisonHandler.smethod_1(packetWriter, 40);
						arg_4C5_0 = (num * 825722682u ^ 121559643u);
						continue;
					case 1u:
						GarrisonHandler.smethod_1(packetWriter, 10);
						GarrisonHandler.smethod_1(packetWriter, 30);
						arg_4C5_0 = (num * 961562074u ^ 2501287071u);
						continue;
					case 2u:
						GarrisonHandler.smethod_1(packetWriter, 1);
						arg_4C5_0 = (num * 4032344731u ^ 1067531926u);
						continue;
					case 3u:
						GarrisonHandler.smethod_1(packetWriter, 79376);
						arg_4C5_0 = (num * 4136917369u ^ 2773565368u);
						continue;
					case 4u:
						GarrisonHandler.smethod_1(packetWriter, 100);
						arg_4C5_0 = (num * 149461949u ^ 2307757127u);
						continue;
					case 5u:
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						GarrisonHandler.smethod_1(packetWriter, 7);
						arg_4C5_0 = (num * 17051684u ^ 728896212u);
						continue;
					case 6u:
						GarrisonHandler.smethod_1(packetWriter, 100);
						arg_4C5_0 = (num * 4045292107u ^ 287597023u);
						continue;
					case 7u:
						GarrisonHandler.smethod_1(packetWriter, 2);
						arg_4C5_0 = (num * 2151162458u ^ 1542205032u);
						continue;
					case 8u:
						GarrisonHandler.smethod_3(packetWriter, session.Character.Faction);
						GarrisonHandler.smethod_1(packetWriter, 8);
						GarrisonHandler.smethod_1(packetWriter, 3);
						session.Send(ref packetWriter);
						arg_4C5_0 = (num * 910955810u ^ 2809289210u);
						continue;
					case 9u:
						GarrisonHandler.smethod_1(packetWriter, 90);
						arg_4C5_0 = (num * 2327499916u ^ 236408667u);
						continue;
					case 10u:
						GarrisonHandler.smethod_1(packetWriter, 5);
						arg_4C5_0 = (num * 2606565209u ^ 2979529350u);
						continue;
					case 11u:
						GarrisonHandler.smethod_1(packetWriter, 2);
						GarrisonHandler.smethod_1(packetWriter, 200);
						arg_4C5_0 = (num * 77438082u ^ 1956769023u);
						continue;
					case 12u:
						GarrisonHandler.smethod_1(packetWriter, 1);
						GarrisonHandler.smethod_1(packetWriter, 14);
						GarrisonHandler.smethod_1(packetWriter, 15);
						arg_4C5_0 = (num * 4061237938u ^ 4062143700u);
						continue;
					case 13u:
						GarrisonHandler.smethod_1(packetWriter, 450);
						arg_4C5_0 = (num * 3690551919u ^ 1841607985u);
						continue;
					case 14u:
						GarrisonHandler.smethod_1(packetWriter, 6);
						GarrisonHandler.smethod_1(packetWriter, 4);
						GarrisonHandler.smethod_1(packetWriter, 7);
						GarrisonHandler.smethod_1(packetWriter, 18);
						arg_4C5_0 = (num * 2127045538u ^ 836825253u);
						continue;
					case 15u:
						GarrisonHandler.smethod_1(packetWriter, 100);
						GarrisonHandler.smethod_2(packetWriter, 6uL);
						arg_4C5_0 = (num * 4068629923u ^ 1039405337u);
						continue;
					case 16u:
						GarrisonHandler.smethod_1(packetWriter, 78009);
						arg_4C5_0 = (num * 3019492862u ^ 1788859454u);
						continue;
					case 17u:
						GarrisonHandler.smethod_1(packetWriter, 5);
						arg_4C5_0 = (num * 1098062784u ^ 3567512997u);
						continue;
					case 18u:
						GarrisonHandler.smethod_1(packetWriter, 0);
						GarrisonHandler.smethod_1(packetWriter, 100);
						arg_4C5_0 = (num * 1085281412u ^ 2566269497u);
						continue;
					case 20u:
						GarrisonHandler.smethod_1(packetWriter, 7);
						arg_4C5_0 = (num * 857096085u ^ 2760092355u);
						continue;
					case 21u:
						GarrisonHandler.smethod_1(packetWriter, 1);
						arg_4C5_0 = (num * 634702657u ^ 1687870474u);
						continue;
					case 22u:
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						arg_4C5_0 = (num * 1888837307u ^ 145682651u);
						continue;
					case 23u:
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						GarrisonHandler.smethod_2(packetWriter, 7uL);
						arg_4C5_0 = (num * 1093247655u ^ 1346875589u);
						continue;
					case 24u:
						GarrisonHandler.smethod_2(packetWriter, 18uL);
						arg_4C5_0 = (num * 3497617775u ^ 2338852855u);
						continue;
					case 25u:
						GarrisonHandler.smethod_1(packetWriter, 0);
						arg_4C5_0 = (num * 2645098000u ^ 2487509600u);
						continue;
					case 26u:
					{
						BitPack expr_142 = new BitPack(packetWriter, session.Character.Guid, 0uL, 0uL, 0uL);
						expr_142.Write<int>(0, 19);
						expr_142.Write<int>(2, 19);
						expr_142.Write<int>(0, 22);
						expr_142.Write<int>(0, 19);
						expr_142.Write<int>(2, 18);
						expr_142.Write<int>(2, 22);
						expr_142.Write<int>(3, 22);
						expr_142.Flush();
						GarrisonHandler.smethod_1(packetWriter, 6);
						arg_4C5_0 = (num * 1643873379u ^ 3047625204u);
						continue;
					}
					case 27u:
						goto IL_562;
					case 28u:
						GarrisonHandler.smethod_2(packetWriter, 2uL);
						arg_4C5_0 = (num * 3009439549u ^ 962137315u);
						continue;
					case 29u:
						GarrisonHandler.smethod_1(packetWriter, 0);
						arg_4C5_0 = (num * 532258800u ^ 3210186917u);
						continue;
					case 30u:
						GarrisonHandler.smethod_1(packetWriter, 0);
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						GarrisonHandler.smethod_1(packetWriter, 2);
						GarrisonHandler.smethod_1(packetWriter, 0);
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						arg_4C5_0 = (num * 2179556401u ^ 563014784u);
						continue;
					case 31u:
						GarrisonHandler.smethod_1(packetWriter, 9999999);
						arg_4C5_0 = (num * 3285096176u ^ 2094535865u);
						continue;
					case 32u:
						GarrisonHandler.smethod_1(packetWriter, 100);
						arg_4C5_0 = (num * 3963403881u ^ 3293912424u);
						continue;
					case 33u:
						GarrisonHandler.smethod_1(packetWriter, 0);
						arg_4C5_0 = (num * 170033010u ^ 1448757196u);
						continue;
					case 34u:
						GarrisonHandler.smethod_1(packetWriter, 2);
						arg_4C5_0 = (num * 1417663002u ^ 325535084u);
						continue;
					case 35u:
						GarrisonHandler.smethod_1(packetWriter, 0);
						arg_4C5_0 = (num * 801168964u ^ 3012279010u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleGarrisonOpenMissionNPC(ref WorldClass session)
		{
			PacketWriter writer = new PacketWriter(ServerMessage.GarrisonOpenMissionNPC, true);
			while (true)
			{
				IL_C3:
				uint arg_A3_0 = 2714239886u;
				while (true)
				{
					uint num;
					switch ((num = (arg_A3_0 ^ 2392012593u)) % 5u)
					{
					case 0u:
						goto IL_C3;
					case 1u:
					{
						BitPack bitPack = new BitPack(writer, session.Character.Guid, 0uL, 0uL, 0uL);
						arg_A3_0 = (num * 2983679983u ^ 607895734u);
						continue;
					}
					case 2u:
					{
						BitPack bitPack;
						BitPack arg_49_0 = bitPack;
						byte[] expr_3E = new byte[8];
						GarrisonHandler.smethod_0(expr_3E, fieldof(<PrivateImplementationDetails>.CDC007DD9FFBE9A681CA63B649C577839F6F7283).FieldHandle);
						arg_49_0.WriteGuidMask(expr_3E);
						bitPack.Flush();
						arg_A3_0 = (num * 2707350706u ^ 1297577509u);
						continue;
					}
					case 3u:
					{
						BitPack bitPack;
						BitPack arg_23_0 = bitPack;
						byte[] expr_18 = new byte[8];
						GarrisonHandler.smethod_0(expr_18, fieldof(<PrivateImplementationDetails>.long_1).FieldHandle);
						arg_23_0.WriteGuidBytes(expr_18);
						arg_A3_0 = (num * 39461106u ^ 4123022775u);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref writer);
		}

		public static void HandleOpenShipmentNPCFromGossip(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.OpenShipmentNPCFromGossip, true);
			while (true)
			{
				IL_E6:
				uint arg_C2_0 = 1706632547u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C2_0 ^ 826624662u)) % 6u)
					{
					case 0u:
						goto IL_E6;
					case 2u:
					{
						BitPack bitPack;
						BitPack arg_A4_0 = bitPack;
						byte[] expr_99 = new byte[8];
						GarrisonHandler.smethod_0(expr_99, fieldof(<PrivateImplementationDetails>.D1CC183912176D7A58FD0DEA46BB48CBE1A343D4).FieldHandle);
						arg_A4_0.WriteGuidBytes(expr_99);
						GarrisonHandler.smethod_1(packetWriter, 1);
						arg_C2_0 = (num * 56463787u ^ 4222683955u);
						continue;
					}
					case 3u:
						session.Send(ref packetWriter);
						arg_C2_0 = (num * 3027281237u ^ 365100312u);
						continue;
					case 4u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_C2_0 = (num * 3682290592u ^ 368987776u);
						continue;
					}
					case 5u:
					{
						BitPack bitPack = new BitPack(packetWriter, session.Character.Guid, 0uL, 0uL, 0uL);
						BitPack arg_51_0 = bitPack;
						byte[] expr_46 = new byte[8];
						GarrisonHandler.smethod_0(expr_46, fieldof(<PrivateImplementationDetails>.long_0).FieldHandle);
						arg_51_0.WriteGuidMask(expr_46);
						arg_C2_0 = (num * 3076292236u ^ 1337455236u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleGarrisonAddMissionResult(ref WorldClass session)
		{
			PacketWriter binaryWriter_ = new PacketWriter(ServerMessage.GarrisonAddMissionResult, true);
			while (true)
			{
				IL_11F:
				uint arg_EA_0 = 2812564501u;
				while (true)
				{
					uint num;
					switch ((num = (arg_EA_0 ^ 2389566991u)) % 10u)
					{
					case 0u:
						GarrisonHandler.smethod_1(binaryWriter_, 1);
						arg_EA_0 = (num * 1624367509u ^ 2968768183u);
						continue;
					case 2u:
						session.Send(ref binaryWriter_);
						arg_EA_0 = (num * 1335241701u ^ 3614886240u);
						continue;
					case 3u:
						goto IL_11F;
					case 4u:
						GarrisonHandler.smethod_1(binaryWriter_, 9999999);
						arg_EA_0 = (num * 3413545384u ^ 3876579938u);
						continue;
					case 5u:
						GarrisonHandler.smethod_1(binaryWriter_, 0);
						arg_EA_0 = (num * 3099256018u ^ 276318819u);
						continue;
					case 6u:
						GarrisonHandler.smethod_1(binaryWriter_, 0);
						GarrisonHandler.smethod_1(binaryWriter_, 2);
						arg_EA_0 = (num * 3947976649u ^ 468107334u);
						continue;
					case 7u:
						GarrisonHandler.smethod_1(binaryWriter_, 9999999);
						arg_EA_0 = (num * 2757309549u ^ 2406265062u);
						continue;
					case 8u:
						GarrisonHandler.smethod_1(binaryWriter_, 9999999);
						GarrisonHandler.smethod_1(binaryWriter_, 9999999);
						arg_EA_0 = (num * 3081306777u ^ 4082432338u);
						continue;
					case 9u:
						GarrisonHandler.smethod_1(binaryWriter_, 2);
						arg_EA_0 = (num * 1341176448u ^ 362941049u);
						continue;
					}
					return;
				}
			}
		}

		static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		static void smethod_1(BinaryWriter binaryWriter_0, int int_0)
		{
			binaryWriter_0.Write(int_0);
		}

		static void smethod_2(BinaryWriter binaryWriter_0, ulong ulong_0)
		{
			binaryWriter_0.Write(ulong_0);
		}

		static void smethod_3(BinaryWriter binaryWriter_0, uint uint_0)
		{
			binaryWriter_0.Write(uint_0);
		}
	}
}
