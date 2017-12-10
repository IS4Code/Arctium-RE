using AuthServer.Game.Entities;
using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Movement;
using Framework.Constants.Net;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.IO;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class MoveHandler : Manager
	{
		private static int spellctr;

		[Opcode2(ClientMessage.MoveFallLand, "17930"), Opcode2(ClientMessage.MoveStartForward, "17930"), Opcode2(ClientMessage.MoveStop, "17930"), Opcode2(ClientMessage.MoveStopTurn, "17930"), Opcode2(ClientMessage.MoveJump, "17930"), Opcode2(ClientMessage.MoveStartTurnLeft, "17930"), Opcode2(ClientMessage.MoveStartTurnRight, "17930"), Opcode2(ClientMessage.MoveStartSwim, "17930"), Opcode2(ClientMessage.MoveStartBackward, "17930"), Opcode2(ClientMessage.MoveStopSwim, "17930"), Opcode2(ClientMessage.MoveHeartbeat, "17930")]
		public static void HandleMoveStartForward(ref PacketReader packet, WorldClass2 session)
		{
			ObjectMovementValues objectMovementValues = new ObjectMovementValues();
			while (true)
			{
				IL_3FC:
				uint arg_37E_0 = 9147451u;
				while (true)
				{
					uint num;
					switch ((num = (arg_37E_0 ^ 841707322u)) % 28u)
					{
					case 0u:
						goto IL_3FC;
					case 1u:
					{
						BitUnpack bitUnpack;
						bitUnpack.GetBit();
						bitUnpack.GetBit();
						bitUnpack.GetBit();
						arg_37E_0 = (num * 164979708u ^ 2503844216u);
						continue;
					}
					case 2u:
					{
						Character character;
						Vector4 vector;
						Manager.ObjectMgr.SetPosition(ref character, vector, false);
						arg_37E_0 = (num * 3277358720u ^ 4180822621u);
						continue;
					}
					case 3u:
					{
						int num2;
						num2++;
						arg_37E_0 = (num * 1248225183u ^ 893813217u);
						continue;
					}
					case 4u:
						arg_37E_0 = ((session != null) ? 942183456u : 788475741u);
						continue;
					case 5u:
					{
						packet.Read<float>();
						packet.Read<float>();
						uint num3 = MoveHandler.smethod_0(packet);
						arg_37E_0 = (num * 738142989u ^ 123470571u);
						continue;
					}
					case 6u:
						packet.Read<uint>();
						arg_37E_0 = 605456785u;
						continue;
					case 7u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.MovementFlags = (MovementFlag)bitUnpack.GetBits<uint>(30);
						arg_37E_0 = (num * 567317250u ^ 216306339u);
						continue;
					}
					case 8u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.IsTransport = bitUnpack.GetBit();
						arg_37E_0 = (num * 1358480096u ^ 3472073799u);
						continue;
					}
					case 9u:
						packet.ReadSmartGuid();
						arg_37E_0 = (num * 1064059932u ^ 4173751561u);
						continue;
					case 10u:
					{
						Character character = session.Character;
						arg_37E_0 = (num * 4254926009u ^ 2349002053u);
						continue;
					}
					case 11u:
						objectMovementValues.Time = MoveHandler.smethod_0(packet);
						arg_37E_0 = (num * 1758499987u ^ 1415707915u);
						continue;
					case 12u:
						MoveHandler.smethod_0(packet);
						arg_37E_0 = (num * 2976330070u ^ 3154843192u);
						continue;
					case 13u:
					{
						Character character;
						arg_37E_0 = (((character == null) ? 295908821u : 538868416u) ^ num * 4149343592u);
						continue;
					}
					case 14u:
					{
						int num2;
						uint num3;
						arg_37E_0 = (((long)num2 >= (long)((ulong)num3)) ? 815086337u : 1127044852u);
						continue;
					}
					case 15u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.MovementFlags2 = (MovementFlag2)bitUnpack.GetBits<uint>(18);
						arg_37E_0 = (num * 1605246375u ^ 272331799u);
						continue;
					}
					case 16u:
						objectMovementValues.FallTime = packet.Read<uint>();
						objectMovementValues.JumpVelocity = packet.Read<float>();
						arg_37E_0 = (num * 3691623988u ^ 973384501u);
						continue;
					case 17u:
					{
						BitUnpack bitUnpack = new BitUnpack(packet);
						arg_37E_0 = (num * 3008517940u ^ 1638105723u);
						continue;
					}
					case 18u:
					{
						int num2 = 0;
						arg_37E_0 = (num * 3853871540u ^ 809052057u);
						continue;
					}
					case 19u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.HasJumpData = bitUnpack.GetBit();
						arg_37E_0 = (num * 1640032596u ^ 1265380340u);
						continue;
					}
					case 20u:
					{
						Vector4 vector = new Vector4
						{
							X = packet.Read<float>(),
							Y = packet.Read<float>(),
							Z = packet.Read<float>(),
							O = packet.Read<float>()
						};
						arg_37E_0 = (num * 1655057484u ^ 2313516287u);
						continue;
					}
					case 21u:
						objectMovementValues.CurrentSpeed = packet.Read<float>();
						arg_37E_0 = (num * 55900818u ^ 653765200u);
						continue;
					case 22u:
						arg_37E_0 = (((!objectMovementValues.IsFallingOrJumping) ? 1263911074u : 764650170u) ^ num * 743526344u);
						continue;
					case 23u:
						arg_37E_0 = (num * 3887360177u ^ 1013715343u);
						continue;
					case 24u:
						objectMovementValues.Sin = packet.Read<float>();
						objectMovementValues.Cos = packet.Read<float>();
						arg_37E_0 = (num * 1914487889u ^ 1823127267u);
						continue;
					case 25u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.IsFallingOrJumping = bitUnpack.GetBit();
						arg_37E_0 = (num * 449423416u ^ 3401972167u);
						continue;
					}
					case 26u:
						arg_37E_0 = ((objectMovementValues.HasJumpData ? 732155638u : 1159085886u) ^ num * 3311180246u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleMoveFallLand(ref PacketReader packet, WorldClass2 session)
		{
			ObjectMovementValues objectMovementValues = new ObjectMovementValues();
			while (true)
			{
				IL_11E0:
				uint arg_1012_0 = 2336754510u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1012_0 ^ 4122098701u)) % 112u)
					{
					case 0u:
					{
						int num2;
						byte[] array;
						arg_1012_0 = ((num2 >= array.Length) ? 3857558977u : 2952361748u);
						continue;
					}
					case 1u:
					{
						string string_ = Module.smethod_36<string>(4018457857u);
						arg_1012_0 = (num * 2632199611u ^ 1442968080u);
						continue;
					}
					case 2u:
					{
						PacketWriter packetWriter;
						byte[] array2;
						packetWriter.WriteBytes(array2, 0);
						arg_1012_0 = (num * 1568873463u ^ 79425833u);
						continue;
					}
					case 3u:
					{
						BitUnpack bitUnpack = new BitUnpack(packet);
						arg_1012_0 = (num * 1302032123u ^ 171453246u);
						continue;
					}
					case 4u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						arg_1012_0 = (num * 1629476114u ^ 4122705212u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						arg_1012_0 = (num * 3489177227u ^ 3720173095u);
						continue;
					}
					case 6u:
						objectMovementValues.CurrentSpeed = packet.Read<float>();
						arg_1012_0 = (num * 2889272145u ^ 3575978696u);
						continue;
					case 7u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_2 = Module.smethod_35<string>(2722945237u);
						arg_1012_0 = (num * 499606485u ^ 4026661745u);
						continue;
					}
					case 8u:
					{
						BitUnpack bitUnpack;
						bitUnpack.GetBit();
						arg_1012_0 = (num * 3162029451u ^ 2237198493u);
						continue;
					}
					case 9u:
					{
						byte[] array;
						int num3;
						arg_1012_0 = ((num3 < array.Length) ? 4289373511u : 2912122745u);
						continue;
					}
					case 10u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						arg_1012_0 = (num * 1793778379u ^ 1664217850u);
						continue;
					}
					case 11u:
						arg_1012_0 = (num * 2832184775u ^ 4136422482u);
						continue;
					case 12u:
					{
						int num4;
						num4++;
						arg_1012_0 = (num * 2447411836u ^ 4090304689u);
						continue;
					}
					case 13u:
						packet.Read<float>();
						arg_1012_0 = (num * 4280011957u ^ 2589750139u);
						continue;
					case 14u:
					{
						string string_;
						byte[] array2;
						int num5;
						array2[num5] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_, num5 * 2, 2), 16);
						num5++;
						arg_1012_0 = 2649301814u;
						continue;
					}
					case 15u:
					{
						PacketWriter packetWriter2 = new PacketWriter(ServerMessage.SpellStart, true);
						arg_1012_0 = (num * 2111439755u ^ 2212406335u);
						continue;
					}
					case 16u:
					{
						int num3;
						num3++;
						arg_1012_0 = (num * 3656972534u ^ 3161512884u);
						continue;
					}
					case 17u:
					{
						string string_2;
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						arg_1012_0 = (num * 3870232643u ^ 3145346707u);
						continue;
					}
					case 18u:
						packet.ReadSmartGuid();
						arg_1012_0 = (num * 1916170578u ^ 1690304407u);
						continue;
					case 19u:
					{
						PacketWriter packetWriter2 = new PacketWriter(ServerMessage.AuraUpdate, true);
						arg_1012_0 = (num * 1016438456u ^ 3379166815u);
						continue;
					}
					case 20u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.HasJumpData = bitUnpack.GetBit();
						arg_1012_0 = (num * 3750381933u ^ 3881909850u);
						continue;
					}
					case 21u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteUInt8(0);
						session.Send(ref packetWriter2);
						packetWriter2 = new PacketWriter(ServerMessage.GrmlTest, true);
						arg_1012_0 = (num * 1107293623u ^ 2871251063u);
						continue;
					}
					case 22u:
						arg_1012_0 = (((!objectMovementValues.IsFallingOrJumping) ? 1552573738u : 1144092785u) ^ num * 2627426854u);
						continue;
					case 23u:
					{
						int num6 = 0;
						arg_1012_0 = (num * 1017282037u ^ 786531606u);
						continue;
					}
					case 24u:
						arg_1012_0 = (num * 4000018646u ^ 875439089u);
						continue;
					case 25u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						arg_1012_0 = (num * 277068281u ^ 157280349u);
						continue;
					}
					case 26u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_2 = Module.smethod_36<string>(3387575955u);
						arg_1012_0 = (num * 504050403u ^ 2959272050u);
						continue;
					}
					case 27u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 2657349543u ^ 4268771366u);
						continue;
					}
					case 28u:
					{
						int num7;
						num7++;
						arg_1012_0 = (num * 2614890331u ^ 691882918u);
						continue;
					}
					case 29u:
						objectMovementValues.Sin = packet.Read<float>();
						objectMovementValues.Cos = packet.Read<float>();
						arg_1012_0 = (num * 3797978359u ^ 2708092048u);
						continue;
					case 30u:
						objectMovementValues.Time = MoveHandler.smethod_0(packet);
						arg_1012_0 = (num * 2969124810u ^ 3448081740u);
						continue;
					case 31u:
					{
						byte[] array;
						string string_2;
						int num8;
						array[num8] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num8 * 2, 2), 16);
						num8++;
						arg_1012_0 = 2236419567u;
						continue;
					}
					case 32u:
						arg_1012_0 = ((MoveHandler.smethod_1(objectMovementValues.MovementFlags2, MovementFlag2.Unknown16) ? 3121037322u : 3636738892u) ^ num * 2368365862u);
						continue;
					case 33u:
					{
						string string_2 = Module.smethod_37<string>(2425440293u);
						arg_1012_0 = (num * 816400999u ^ 502086756u);
						continue;
					}
					case 34u:
					{
						int num2;
						num2++;
						arg_1012_0 = (num * 1363230260u ^ 406403157u);
						continue;
					}
					case 35u:
					{
						byte[] array;
						string string_2;
						int num9;
						array[num9] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num9 * 2, 2), 16);
						arg_1012_0 = 2915863927u;
						continue;
					}
					case 36u:
					{
						int num3 = 0;
						arg_1012_0 = (num * 2374651997u ^ 2616132722u);
						continue;
					}
					case 37u:
						packet.Read<uint>();
						arg_1012_0 = 3391268158u;
						continue;
					case 38u:
					{
						int num10;
						num10++;
						arg_1012_0 = (num * 2291014852u ^ 3725635463u);
						continue;
					}
					case 39u:
						goto IL_11E0;
					case 40u:
					{
						byte[] array;
						int num6;
						arg_1012_0 = ((num6 >= array.Length) ? 4189404378u : 4283844403u);
						continue;
					}
					case 41u:
					{
						string string_2 = Module.smethod_34<string>(3747977502u);
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						arg_1012_0 = (num * 2448105467u ^ 3493948812u);
						continue;
					}
					case 42u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_1012_0 = (num * 1992944536u ^ 3732619161u);
						continue;
					}
					case 43u:
					{
						Character character;
						Vector4 vector;
						Manager.ObjectMgr.SetPosition(ref character, vector, true);
						arg_1012_0 = (num * 4176983257u ^ 3486592258u);
						continue;
					}
					case 44u:
					{
						Character character = session.Character;
						arg_1012_0 = (num * 1392165433u ^ 2240045972u);
						continue;
					}
					case 45u:
					{
						string string_2 = Module.smethod_36<string>(293769454u);
						arg_1012_0 = (num * 837599323u ^ 3818307748u);
						continue;
					}
					case 46u:
					{
						PacketWriter packetWriter2;
						session.Send(ref packetWriter2);
						arg_1012_0 = (num * 1720660934u ^ 3285508074u);
						continue;
					}
					case 47u:
					{
						byte[] array;
						int num7;
						arg_1012_0 = ((num7 >= array.Length) ? 2790756016u : 3327162994u);
						continue;
					}
					case 48u:
					{
						MoveHandler.spellctr++;
						PacketWriter packetWriter2 = new PacketWriter(ServerMessage.AuraUpdate, true);
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_2 = Module.smethod_36<string>(2829036598u);
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						int num2 = 0;
						arg_1012_0 = (num * 469679657u ^ 2409827885u);
						continue;
					}
					case 49u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						arg_1012_0 = (num * 419245542u ^ 2830609471u);
						continue;
					}
					case 50u:
					{
						byte[] array;
						int num8;
						arg_1012_0 = ((num8 < array.Length) ? 2378279122u : 3866535620u);
						continue;
					}
					case 51u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						arg_1012_0 = (num * 2366108229u ^ 991962892u);
						continue;
					}
					case 52u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 3034763150u ^ 1900141793u);
						continue;
					}
					case 53u:
					{
						int num11 = 0;
						arg_1012_0 = (num * 413538065u ^ 12682669u);
						continue;
					}
					case 54u:
					{
						PacketWriter packetWriter2;
						session.Send(ref packetWriter2);
						packetWriter2 = new PacketWriter(ServerMessage.SpellStart, true);
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_2 = Module.smethod_34<string>(605512917u);
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						arg_1012_0 = (num * 3338675610u ^ 3844615013u);
						continue;
					}
					case 55u:
						arg_1012_0 = (((MoveHandler.spellctr == 0) ? 516618262u : 163229031u) ^ num * 485470333u);
						continue;
					case 56u:
					{
						int num11;
						uint num12;
						arg_1012_0 = (((long)num11 < (long)((ulong)num12)) ? 3164335592u : 3952697459u);
						continue;
					}
					case 57u:
					{
						PacketWriter packetWriter2;
						session.Send(ref packetWriter2);
						arg_1012_0 = (num * 785425877u ^ 708953562u);
						continue;
					}
					case 58u:
					{
						byte[] array;
						string string_2;
						int num3;
						array[num3] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num3 * 2, 2), 16);
						arg_1012_0 = 3433174237u;
						continue;
					}
					case 59u:
					{
						PacketWriter packetWriter2;
						session.Send(ref packetWriter2);
						packetWriter2 = new PacketWriter(ServerMessage.SpellGo, true);
						arg_1012_0 = (num * 3991410625u ^ 3029799724u);
						continue;
					}
					case 60u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 2619996098u ^ 1132407971u);
						continue;
					}
					case 61u:
					{
						int num9 = 0;
						arg_1012_0 = (num * 4293632955u ^ 750714003u);
						continue;
					}
					case 62u:
					{
						byte[] array;
						string string_2;
						int num10;
						array[num10] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num10 * 2, 2), 16);
						arg_1012_0 = 4153468651u;
						continue;
					}
					case 63u:
					{
						byte[] array;
						string string_2;
						int num7;
						array[num7] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num7 * 2, 2), 16);
						arg_1012_0 = 2201826977u;
						continue;
					}
					case 64u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 3432058493u ^ 3274529654u);
						continue;
					}
					case 65u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.GrmlTest, true);
						new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						arg_1012_0 = 3311789980u;
						continue;
					}
					case 66u:
					{
						byte[] array;
						int num10;
						arg_1012_0 = ((num10 < array.Length) ? 3050507043u : 3424909216u);
						continue;
					}
					case 67u:
						arg_1012_0 = (((!objectMovementValues.HasJumpData) ? 4047015286u : 2482364648u) ^ num * 4086087272u);
						continue;
					case 68u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						arg_1012_0 = (num * 2342515193u ^ 1341456034u);
						continue;
					}
					case 69u:
						arg_1012_0 = (num * 1323917650u ^ 2108082831u);
						continue;
					case 70u:
					{
						string string_2;
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						arg_1012_0 = (num * 3640748560u ^ 359448986u);
						continue;
					}
					case 71u:
					{
						uint num12 = MoveHandler.smethod_0(packet);
						MoveHandler.smethod_0(packet);
						arg_1012_0 = (num * 3054379898u ^ 4122879870u);
						continue;
					}
					case 72u:
					{
						PacketWriter packetWriter2;
						session.Send(ref packetWriter2);
						arg_1012_0 = (num * 624014124u ^ 3289838210u);
						continue;
					}
					case 73u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 3910756805u ^ 746169568u);
						continue;
					}
					case 74u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 2010014894u ^ 3955064260u);
						continue;
					}
					case 75u:
						arg_1012_0 = (num * 811067946u ^ 434479610u);
						continue;
					case 77u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 673980217u ^ 1576262665u);
						continue;
					}
					case 78u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.MovementFlags = (MovementFlag)bitUnpack.GetBits<uint>(30);
						arg_1012_0 = (num * 1981152365u ^ 2871270316u);
						continue;
					}
					case 79u:
					{
						string string_2;
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						arg_1012_0 = (num * 4283533296u ^ 341240386u);
						continue;
					}
					case 80u:
					{
						byte[] array;
						string string_2;
						int num4;
						array[num4] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num4 * 2, 2), 16);
						arg_1012_0 = 2680975553u;
						continue;
					}
					case 81u:
					{
						byte[] array;
						int num9;
						arg_1012_0 = ((num9 < array.Length) ? 4129258318u : 2467455789u);
						continue;
					}
					case 82u:
					{
						int num10 = 0;
						arg_1012_0 = (num * 2919940822u ^ 2867559882u);
						continue;
					}
					case 83u:
					{
						int num11;
						num11++;
						arg_1012_0 = (num * 997022664u ^ 3972334061u);
						continue;
					}
					case 84u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.IsTransport = bitUnpack.GetBit();
						objectMovementValues.IsFallingOrJumping = bitUnpack.GetBit();
						bitUnpack.GetBit();
						arg_1012_0 = 3046157925u;
						continue;
					}
					case 85u:
					{
						int num4 = 0;
						arg_1012_0 = (num * 1347780055u ^ 887381830u);
						continue;
					}
					case 86u:
					{
						string string_;
						byte[] array2 = new byte[MoveHandler.smethod_2(string_) / 2];
						int num5 = 0;
						arg_1012_0 = (num * 596619402u ^ 2813980074u);
						continue;
					}
					case 87u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 3291488334u ^ 3010157740u);
						continue;
					}
					case 88u:
					{
						BitUnpack bitUnpack;
						bitUnpack.GetBit();
						arg_1012_0 = (num * 1677305565u ^ 2991707587u);
						continue;
					}
					case 89u:
					{
						int num2;
						byte[] array;
						string string_2;
						array[num2] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num2 * 2, 2), 16);
						arg_1012_0 = 3430763295u;
						continue;
					}
					case 90u:
					{
						PacketWriter packetWriter2 = new PacketWriter(ServerMessage.SpellGo, true);
						arg_1012_0 = (num * 346050326u ^ 1455995504u);
						continue;
					}
					case 91u:
					{
						byte[] array2;
						int num5;
						arg_1012_0 = ((num5 >= array2.Length) ? 4248501135u : 2860852787u);
						continue;
					}
					case 92u:
					{
						byte[] array;
						int num4;
						arg_1012_0 = ((num4 >= array.Length) ? 2208847647u : 3496442733u);
						continue;
					}
					case 93u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 2406109233u ^ 159031336u);
						continue;
					}
					case 94u:
					{
						string string_2;
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						arg_1012_0 = (num * 1809620320u ^ 1536581736u);
						continue;
					}
					case 95u:
					{
						string string_2;
						byte[] array = new byte[MoveHandler.smethod_2(string_2) / 2];
						int num8 = 0;
						arg_1012_0 = (num * 1708446177u ^ 1933454512u);
						continue;
					}
					case 96u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_1012_0 = (num * 1770549920u ^ 3005483001u);
						continue;
					}
					case 97u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_2 = Module.smethod_33<string>(559198681u);
						arg_1012_0 = (num * 4155217033u ^ 4128134427u);
						continue;
					}
					case 98u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						session.Send(ref packetWriter2);
						arg_1012_0 = (num * 4191279278u ^ 3036821589u);
						continue;
					}
					case 99u:
						arg_1012_0 = ((session == null) ? 3343846529u : 2645954049u);
						continue;
					case 100u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						packetWriter2.WriteUInt8(0);
						session.Send(ref packetWriter2);
						packetWriter2 = new PacketWriter(ServerMessage.KnockBack, true);
						arg_1012_0 = (num * 630111994u ^ 42021488u);
						continue;
					}
					case 101u:
					{
						Character character;
						arg_1012_0 = (((character != null) ? 2050939632u : 1325872583u) ^ num * 1474414318u);
						continue;
					}
					case 102u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						arg_1012_0 = (num * 162247791u ^ 2184900669u);
						continue;
					}
					case 103u:
					{
						BitUnpack bitUnpack;
						objectMovementValues.MovementFlags2 = (MovementFlag2)bitUnpack.GetBits<uint>(18);
						arg_1012_0 = (num * 821092190u ^ 257935887u);
						continue;
					}
					case 104u:
						objectMovementValues.FallTime = packet.Read<uint>();
						objectMovementValues.JumpVelocity = packet.Read<float>();
						arg_1012_0 = (num * 3835120285u ^ 3498885089u);
						continue;
					case 105u:
						packet.Read<float>();
						arg_1012_0 = (num * 2463597082u ^ 1670507402u);
						continue;
					case 106u:
					{
						int num9;
						num9++;
						arg_1012_0 = (num * 3953413923u ^ 1778203714u);
						continue;
					}
					case 107u:
					{
						int num6;
						num6++;
						arg_1012_0 = (num * 3459487084u ^ 3107853137u);
						continue;
					}
					case 108u:
					{
						byte[] array;
						PacketWriter packetWriter2;
						packetWriter2.WriteBytes(array, 0);
						arg_1012_0 = (num * 1501487652u ^ 2779420721u);
						continue;
					}
					case 109u:
					{
						Vector4 vector = new Vector4
						{
							X = packet.Read<float>(),
							Y = packet.Read<float>(),
							Z = packet.Read<float>(),
							O = packet.Read<float>()
						};
						arg_1012_0 = (num * 2969712791u ^ 3705721935u);
						continue;
					}
					case 110u:
					{
						byte[] array;
						string string_2;
						int num6;
						array[num6] = MoveHandler.smethod_4(MoveHandler.smethod_3(string_2, num6 * 2, 2), 16);
						arg_1012_0 = 2822122534u;
						continue;
					}
					case 111u:
					{
						int num7 = 0;
						arg_1012_0 = (num * 4069042922u ^ 3635515476u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleMoveUpdate(ulong guid, ObjectMovementValues movementValues, Vector4 vector, uint index)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveUpdate, true);
			while (true)
			{
				IL_376:
				uint arg_310_0 = 1709358439u;
				while (true)
				{
					uint num;
					switch ((num = (arg_310_0 ^ 1535379137u)) % 22u)
					{
					case 0u:
						arg_310_0 = ((movementValues.IsFallingOrJumping ? 157493612u : 187883487u) ^ num * 3936920555u);
						continue;
					case 1u:
						packetWriter.WriteFloat(vector.Y);
						packetWriter.WriteFloat(vector.Z);
						arg_310_0 = (num * 3294803525u ^ 1203899079u);
						continue;
					case 2u:
					{
						WorldClass session;
						arg_310_0 = (((session != null) ? 2713376691u : 4067625320u) ^ num * 892598214u);
						continue;
					}
					case 3u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						arg_310_0 = (num * 2565185380u ^ 2783446850u);
						continue;
					}
					case 4u:
					{
						BitPack bitPack;
						bitPack.Write<uint>((uint)movementValues.MovementFlags, 30);
						bitPack.Write<uint>((uint)movementValues.MovementFlags2, 15);
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(movementValues.IsFallingOrJumping);
						arg_310_0 = (num * 1354628250u ^ 3208723184u);
						continue;
					}
					case 5u:
						packetWriter.WriteFloat(movementValues.Sin);
						arg_310_0 = (num * 2518508666u ^ 1798548196u);
						continue;
					case 6u:
					{
						WorldClass session = Manager.WorldMgr.GetSession(guid);
						arg_310_0 = 1324365997u;
						continue;
					}
					case 7u:
						packetWriter.WriteUInt32(movementValues.FallTime);
						packetWriter.WriteFloat(movementValues.JumpVelocity);
						arg_310_0 = (num * 1888565882u ^ 2253619585u);
						continue;
					case 8u:
					{
						BitPack bitPack = new BitPack(packetWriter, guid, 0uL, 0uL, 0uL);
						packetWriter.WriteSmartGuid(guid, GuidType.Player);
						arg_310_0 = (num * 3522993941u ^ 1336476174u);
						continue;
					}
					case 9u:
						packetWriter.WriteFloat(vector.O);
						arg_310_0 = (num * 383189249u ^ 3164380569u);
						continue;
					case 10u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(movementValues.HasJumpData);
						arg_310_0 = (num * 2405180942u ^ 2970168480u);
						continue;
					}
					case 11u:
						packetWriter.WriteUInt32(movementValues.Time);
						packetWriter.WriteFloat(vector.X);
						arg_310_0 = (num * 3253059658u ^ 3764035222u);
						continue;
					case 12u:
						packetWriter.WriteFloat(0f);
						packetWriter.WriteUInt32(0u);
						arg_310_0 = (num * 273422727u ^ 2635527047u);
						continue;
					case 13u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_310_0 = (num * 1976622339u ^ 4043511489u);
						continue;
					}
					case 14u:
						goto IL_376;
					case 16u:
						arg_310_0 = (((!movementValues.HasJumpData) ? 2185053323u : 2231335773u) ^ num * 2295440723u);
						continue;
					case 17u:
						packetWriter.WriteFloat(movementValues.Cos);
						packetWriter.WriteFloat(movementValues.CurrentSpeed);
						arg_310_0 = (num * 3373174205u ^ 114751702u);
						continue;
					case 18u:
						packetWriter.WriteUInt32(0u);
						arg_310_0 = (num * 2618583045u ^ 3915754039u);
						continue;
					case 19u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0);
						bitPack.Write<int>(0);
						bitPack.Flush();
						arg_310_0 = (num * 3980437445u ^ 2468575432u);
						continue;
					}
					case 20u:
					{
						WorldClass session;
						Character character = session.Character;
						Manager.ObjectMgr.SetPosition(ref character, vector, false);
						session.Send(ref packetWriter);
						arg_310_0 = (num * 3533119749u ^ 2863587842u);
						continue;
					}
					case 21u:
						packetWriter.WriteFloat(0f);
						arg_310_0 = (num * 2103012468u ^ 3513773539u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleMoveSetWalkSpeed(ref WorldClass2 session, float speed = 2.5f)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveSetWalkSpeed, true);
			packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
			packetWriter.WriteUInt32(0u);
			while (true)
			{
				IL_59:
				uint arg_41_0 = 2501174224u;
				while (true)
				{
					uint num;
					switch ((num = (arg_41_0 ^ 3911917471u)) % 3u)
					{
					case 0u:
						goto IL_59;
					case 2u:
						packetWriter.WriteFloat(speed);
						arg_41_0 = (num * 2431358989u ^ 4152468385u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}

		public static void HandleMoveSetRunSpeed(ref WorldClass2 session, float speed = 7f)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveSetRunSpeed, true);
			while (true)
			{
				IL_9E:
				uint arg_7A_0 = 2976821047u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7A_0 ^ 2875931154u)) % 6u)
					{
					case 1u:
						packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_7A_0 = (num * 3950447154u ^ 1624550072u);
						continue;
					case 2u:
						packetWriter.WriteUInt32(0u);
						arg_7A_0 = (num * 3667540534u ^ 2335423744u);
						continue;
					case 3u:
						goto IL_9E;
					case 4u:
						packetWriter.WriteFloat(speed);
						arg_7A_0 = (num * 2986492733u ^ 3278978211u);
						continue;
					case 5u:
						session.Send(ref packetWriter);
						arg_7A_0 = (num * 1334163219u ^ 1579331567u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleMoveSetSwimSpeed(ref WorldClass2 session, float speed = 4.72222f)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveSetSwimSpeed, true);
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 77726750u;
				while (true)
				{
					uint num;
					switch ((num = (arg_50_0 ^ 272458268u)) % 4u)
					{
					case 1u:
						packetWriter.WriteFloat(speed);
						arg_50_0 = (num * 3449230205u ^ 4075664677u);
						continue;
					case 2u:
						packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						packetWriter.WriteUInt32(0u);
						arg_50_0 = (num * 1251771344u ^ 684545813u);
						continue;
					case 3u:
						goto IL_6C;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}

		public static void HandleMoveSetFlightSpeed(ref WorldClass2 session, float speed = 7f)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveSetFlightSpeed, true);
			packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
			while (true)
			{
				IL_75:
				uint arg_59_0 = 327570804u;
				while (true)
				{
					uint num;
					switch ((num = (arg_59_0 ^ 1398495645u)) % 4u)
					{
					case 0u:
						packetWriter.WriteFloat(speed);
						session.Send(ref packetWriter);
						arg_59_0 = (num * 2532511205u ^ 2036369727u);
						continue;
					case 1u:
						packetWriter.WriteUInt32(0u);
						arg_59_0 = (num * 2157390107u ^ 2040566234u);
						continue;
					case 3u:
						goto IL_75;
					}
					return;
				}
			}
		}

		public static void HandleMoveSetCanFly(ref WorldClass2 session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveSetCanFly, true);
			while (true)
			{
				IL_66:
				uint arg_4E_0 = 2228814122u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4E_0 ^ 3126726555u)) % 3u)
					{
					case 1u:
						new BitPack(packetWriter, session.Character.Guid, 0uL, 0uL, 0uL);
						arg_4E_0 = (num * 707221193u ^ 347925818u);
						continue;
					case 2u:
						goto IL_66;
					}
					goto Block_1;
				}
			}
			Block_1:
			packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
			packetWriter.WriteUInt32(0u);
			session.Send(ref packetWriter);
		}

		public static void HandleMoveUnsetCanFly(ref WorldClass2 session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveUnsetCanFly, true);
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 2557055423u;
				while (true)
				{
					uint num;
					switch ((num = (arg_52_0 ^ 3141659397u)) % 4u)
					{
					case 0u:
						goto IL_6E;
					case 1u:
						packetWriter.WriteUInt32(0u);
						session.Send(ref packetWriter);
						arg_52_0 = (num * 1246506569u ^ 3302854207u);
						continue;
					case 2u:
						packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_52_0 = (num * 986494822u ^ 246738284u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleMoveTeleport(ref WorldClass2 session, Vector4 vector)
		{
			bool flag = false;
			bool flag2 = false;
			PacketWriter packetWriter = new PacketWriter(ServerMessage.MoveTeleport, true);
			while (true)
			{
				IL_168:
				uint arg_13C_0 = 3241315517u;
				while (true)
				{
					uint num;
					switch ((num = (arg_13C_0 ^ 2710365947u)) % 8u)
					{
					case 0u:
						arg_13C_0 = ((!flag2) ? 4150708586u : 3338585470u);
						continue;
					case 1u:
						session.Send(ref packetWriter);
						arg_13C_0 = 3057069039u;
						continue;
					case 2u:
						packetWriter.WriteUInt64(0uL);
						arg_13C_0 = (num * 2787996010u ^ 810478047u);
						continue;
					case 3u:
						arg_13C_0 = (((!flag) ? 3326981106u : 3591763416u) ^ num * 3870844803u);
						continue;
					case 5u:
						packetWriter.WriteUInt8(0);
						arg_13C_0 = (num * 283861271u ^ 2192268441u);
						continue;
					case 6u:
					{
						BitPack arg_90_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteFloat(vector.X);
						packetWriter.WriteFloat(vector.Y);
						packetWriter.WriteFloat(vector.Z);
						packetWriter.WriteFloat(vector.O);
						packetWriter.WriteUInt8(0);
						arg_90_0.Write<bool>(flag);
						arg_90_0.Write<bool>(flag2);
						arg_90_0.Flush();
						arg_13C_0 = (num * 4217508530u ^ 476089492u);
						continue;
					}
					case 7u:
						goto IL_168;
					}
					return;
				}
			}
		}

		public static void HandleTransferPending(ref WorldClass2 session, uint mapId)
		{
			bool bit = false;
			while (true)
			{
				IL_8A:
				uint arg_72_0 = 4005644020u;
				while (true)
				{
					uint num;
					switch ((num = (arg_72_0 ^ 2679496220u)) % 3u)
					{
					case 0u:
						goto IL_8A;
					case 1u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.TransferPending, true);
						BitPack arg_44_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						packetWriter.WriteUInt32(mapId);
						arg_44_0.Write<bool>(false);
						arg_44_0.Write<bool>(bit);
						arg_44_0.Flush();
						session.Send(ref packetWriter);
						arg_72_0 = (num * 3882105345u ^ 1487298396u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleNewWorld(ref WorldClass2 session, Vector4 vector, uint mapId)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.NewWorld, true);
			while (true)
			{
				IL_108:
				uint arg_DC_0 = 3458489361u;
				while (true)
				{
					uint num;
					switch ((num = (arg_DC_0 ^ 3194201389u)) % 8u)
					{
					case 0u:
						packetWriter.WriteFloat(vector.X);
						packetWriter.WriteFloat(vector.Y);
						arg_DC_0 = (num * 723470497u ^ 3706238830u);
						continue;
					case 2u:
						goto IL_108;
					case 3u:
						packetWriter.WriteFloat(vector.Z);
						packetWriter.WriteFloat(vector.O);
						arg_DC_0 = (num * 386012771u ^ 1203923379u);
						continue;
					case 4u:
						packetWriter.WriteUInt32(mapId);
						arg_DC_0 = (num * 3527963227u ^ 4149576153u);
						continue;
					case 5u:
						packetWriter.WriteFloat(vector.Z);
						arg_DC_0 = (num * 3499751588u ^ 2567987087u);
						continue;
					case 6u:
						session.Send(ref packetWriter);
						arg_DC_0 = (num * 1150008196u ^ 2895725124u);
						continue;
					case 7u:
						packetWriter.WriteUInt32(0u);
						packetWriter.WriteFloat(vector.X);
						packetWriter.WriteFloat(vector.Y);
						arg_DC_0 = (num * 3734634920u ^ 356212256u);
						continue;
					}
					return;
				}
			}
		}

		static uint smethod_0(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt32();
		}

		static bool smethod_1(Enum enum_0, Enum enum_1)
		{
			return enum_0.HasFlag(enum_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_3(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		static byte smethod_4(string string_0, int int_0)
		{
			return Convert.ToByte(string_0, int_0);
		}
	}
}
