using AuthServer.Game.Entities;
using AuthServer.Game.WorldEntities;
using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Net;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class SpellHandler : Manager
	{
		public static int activeSpell;

		public static void HandleSendKnownSpells(ref WorldClass session)
		{
			Character expr_0D = session.Character;
			int count = expr_0D.SpellList.Count;
			PacketWriter writer = new PacketWriter(ServerMessage.SendKnownSpells, true);
			BitPack expr_59 = new BitPack(writer, 0uL, 0uL, 0uL, 0uL);
			expr_59.Write<int>(1);
			expr_59.Flush();
			writer.WriteInt32(count + Manager.WorldMgr.MountSpells.Count);
			writer.WriteInt32(0);
			expr_0D.SpellList.ForEach(delegate(PlayerSpell spell)
			{
				writer.WriteUInt32(spell.SpellId);
			});
			using (Dictionary<string, Tuple<uint, uint>>.Enumerator enumerator = Manager.WorldMgr.MountSpells.GetEnumerator())
			{
				while (true)
				{
					IL_119:
					int arg_F3_0 = (!enumerator.MoveNext()) ? 1173552564 : 1226217017;
					while (true)
					{
						switch ((arg_F3_0 ^ 1858704064) % 4)
						{
						case 1:
						{
							KeyValuePair<string, Tuple<uint, uint>> current = enumerator.Current;
							writer.WriteUInt32(current.Value.Item2);
							arg_F3_0 = 665194343;
							continue;
						}
						case 2:
							arg_F3_0 = 1226217017;
							continue;
						case 3:
							goto IL_119;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			session.Send(ref writer);
		}

		[Opcode2(ClientMessage.CancelAura, "17930")]
		public static void HandleCancelAura(ref PacketReader packet, WorldClass2 session)
		{
			packet.Read<int>();
			while (true)
			{
				IL_A4:
				uint arg_80_0 = 1946445704u;
				while (true)
				{
					uint num;
					switch ((num = (arg_80_0 ^ 148890857u)) % 6u)
					{
					case 0u:
					{
						WorldClass session2;
						SpellHandler.AuraUpdate(session2, 0u);
						arg_80_0 = (num * 714797375u ^ 3424544470u);
						continue;
					}
					case 1u:
					{
						WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_80_0 = (num * 537338206u ^ 3231834507u);
						continue;
					}
					case 2u:
						goto IL_A4;
					case 4u:
					{
						WorldClass session2;
						ObjectHandler.HandleUpdateObjectValues(ref session2, false);
						arg_80_0 = (num * 392399052u ^ 1410114410u);
						continue;
					}
					case 5u:
					{
						WorldClass session2;
						session2.Character.SetUpdateField<int>(107, 0, 0);
						arg_80_0 = (num * 1872475184u ^ 4096526783u);
						continue;
					}
					}
					return;
				}
			}
		}

		[Opcode2(ClientMessage.CastSpell, "17930")]
		public static void HandleCastSpell(ref PacketReader packet, WorldClass2 session)
		{
			SmartGuid castId = packet.ReadGuid();
			packet.Read<int>();
			WorldClass session2;
			bool flag;
			int num2;
			while (true)
			{
				IL_A5:
				uint arg_80_0 = 88971970u;
				while (true)
				{
					uint num;
					switch ((num = (arg_80_0 ^ 899281459u)) % 6u)
					{
					case 0u:
						session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
						arg_80_0 = (num * 2285706345u ^ 946484535u);
						continue;
					case 2u:
						flag = false;
						arg_80_0 = (num * 2596192904u ^ 1190916770u);
						continue;
					case 3u:
						num2 = packet.Read<int>();
						arg_80_0 = (num * 1794880723u ^ 3422198762u);
						continue;
					case 4u:
						goto IL_A5;
					case 5u:
						packet.Read<int>();
						arg_80_0 = (num * 1876448829u ^ 2032187839u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			uint key = 0u;
			using (Dictionary<string, Tuple<uint, uint>>.Enumerator enumerator = Manager.WorldMgr.MountSpells.GetEnumerator())
			{
				while (true)
				{
					IL_178:
					uint arg_140_0 = enumerator.MoveNext() ? 1710289446u : 1398974958u;
					while (true)
					{
						uint num;
						switch ((num = (arg_140_0 ^ 899281459u)) % 7u)
						{
						case 0u:
						{
							KeyValuePair<string, Tuple<uint, uint>> current;
							arg_140_0 = ((((ulong)current.Value.Item2 != (ulong)((long)num2)) ? 2858814123u : 2326435399u) ^ num * 1448571402u);
							continue;
						}
						case 2u:
							goto IL_178;
						case 3u:
						{
							KeyValuePair<string, Tuple<uint, uint>> current = enumerator.Current;
							arg_140_0 = 407543239u;
							continue;
						}
						case 4u:
						{
							KeyValuePair<string, Tuple<uint, uint>> current;
							key = current.Value.Item1;
							flag = true;
							arg_140_0 = (num * 3736795090u ^ 2499053439u);
							continue;
						}
						case 5u:
							arg_140_0 = 1710289446u;
							continue;
						}
						goto Block_8;
					}
				}
				Block_8:;
			}
			if (flag)
			{
				goto IL_21A;
			}
			goto IL_2AA;
			uint arg_270_0;
			while (true)
			{
				IL_26B:
				uint num;
				switch ((num = (arg_270_0 ^ 899281459u)) % 11u)
				{
				case 0u:
					goto IL_2B9;
				case 1u:
					SpellHandler.activeSpell = num2;
					arg_270_0 = 1254900537u;
					continue;
				case 2u:
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_270_0 = (num * 491903829u ^ 962464016u);
					continue;
				case 3u:
					session.Character.SetUpdateField<int>(107, 0, 0);
					ObjectHandler.HandleUpdateObjectValues(ref session2, false);
					arg_270_0 = (num * 848114486u ^ 2321693018u);
					continue;
				case 4u:
					goto IL_21A;
				case 5u:
					session.Character.SetUpdateField<uint>(107, Manager.WorldMgr.MountDisplays[key], 0);
					arg_270_0 = (num * 1207556804u ^ 358871447u);
					continue;
				case 6u:
					goto IL_2AA;
				case 7u:
					goto IL_2C0;
				case 8u:
					arg_270_0 = (((SpellHandler.activeSpell != 0) ? 3488354535u : 2713727219u) ^ num * 1240849208u);
					continue;
				case 9u:
					MoveHandler.HandleMoveSetRunSpeed(ref session, 7f);
					arg_270_0 = (num * 4147973084u ^ 1878138665u);
					continue;
				}
				break;
			}
			return;
			IL_2B9:
			SpellHandler.activeSpell = 0;
			return;
			IL_2C0:
			MoveHandler.HandleMoveSetRunSpeed(ref session, 14f);
			return;
			IL_21A:
			arg_270_0 = 979607853u;
			goto IL_26B;
			IL_2AA:
			SpellHandler.CastSpell(session2, num2, castId);
			arg_270_0 = 1740439945u;
			goto IL_26B;
		}

		public static void AuraUpdate(WorldClass session, uint spellId)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.AuraUpdate, true);
			while (true)
			{
				IL_295:
				uint arg_238_0 = 286789388u;
				while (true)
				{
					uint num;
					switch ((num = (arg_238_0 ^ 29430773u)) % 20u)
					{
					case 0u:
						goto IL_295;
					case 1u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_238_0 = (num * 1084832233u ^ 416632889u);
						continue;
					}
					case 2u:
					{
						BitPack bitPack;
						bitPack.Flush();
						packetWriter.WriteUInt8(0);
						bitPack.Write<bool>(spellId > 0u);
						arg_238_0 = (num * 1794565636u ^ 1221188297u);
						continue;
					}
					case 3u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_238_0 = (num * 1128489096u ^ 1329149150u);
						continue;
					}
					case 4u:
						packetWriter.WriteUInt32(66297u);
						arg_238_0 = (num * 3718534684u ^ 3686368565u);
						continue;
					case 5u:
					{
						BitPack bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						bitPack.Write<bool>(false);
						arg_238_0 = (num * 3197727365u ^ 2704851610u);
						continue;
					}
					case 6u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_238_0 = (num * 2529490252u ^ 685696646u);
						continue;
					}
					case 7u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						bitPack.Write<bool>(false);
						arg_238_0 = (num * 3135531796u ^ 638967796u);
						continue;
					}
					case 8u:
						packetWriter.WriteUInt8(11);
						packetWriter.WriteUInt32(1u);
						arg_238_0 = (num * 4002804814u ^ 3175510560u);
						continue;
					case 9u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0, 6);
						arg_238_0 = (num * 503314913u ^ 3530691890u);
						continue;
					}
					case 10u:
					{
						BitPack bitPack;
						bitPack.Write<int>(1, 9);
						arg_238_0 = (num * 1869515548u ^ 2159229279u);
						continue;
					}
					case 11u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_238_0 = (num * 535335051u ^ 2590371091u);
						continue;
					}
					case 12u:
					{
						BitPack bitPack;
						bitPack.Flush();
						arg_238_0 = (((spellId != 0u) ? 949461760u : 1330977442u) ^ num * 325329682u);
						continue;
					}
					case 13u:
						packetWriter.WriteSmartGuid(0uL, GuidType.Player);
						arg_238_0 = (num * 4291735998u ^ 746703605u);
						continue;
					case 14u:
					{
						BitPack bitPack;
						bitPack.Write<int>(0, 6);
						arg_238_0 = (num * 3686269022u ^ 3907984467u);
						continue;
					}
					case 15u:
						packetWriter.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_238_0 = 187220561u;
						continue;
					case 17u:
						packetWriter.WriteUInt16(0);
						arg_238_0 = (num * 3623536493u ^ 1614412583u);
						continue;
					case 18u:
						packetWriter.WriteUInt32(spellId);
						arg_238_0 = (num * 3937256259u ^ 1673177203u);
						continue;
					case 19u:
						packetWriter.WriteUInt8(0);
						arg_238_0 = (num * 2025498952u ^ 3036305262u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			session.Send(ref packetWriter);
		}

		public static void CastShit(WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.UnknownMount, true);
			while (true)
			{
				IL_3CA:
				uint arg_35C_0 = 2603575655u;
				while (true)
				{
					uint num;
					switch ((num = (arg_35C_0 ^ 2266727687u)) % 24u)
					{
					case 0u:
					{
						PacketWriter packetWriter2;
						byte[] array;
						packetWriter2.WriteBytes(array, 0);
						arg_35C_0 = (num * 3941501788u ^ 642226778u);
						continue;
					}
					case 1u:
					{
						byte[] array;
						int num2;
						arg_35C_0 = ((num2 >= array.Length) ? 2998360569u : 4101988280u);
						continue;
					}
					case 2u:
					{
						int num3;
						num3++;
						arg_35C_0 = (num * 3230039935u ^ 752066653u);
						continue;
					}
					case 3u:
					{
						PacketWriter packetWriter2;
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_ = Module.smethod_37<string>(2746803935u);
						byte[] array = new byte[SpellHandler.smethod_0(string_) / 2];
						arg_35C_0 = (num * 2650947370u ^ 869267186u);
						continue;
					}
					case 4u:
					{
						byte[] array;
						int num3;
						string string_;
						array[num3] = SpellHandler.smethod_2(SpellHandler.smethod_1(string_, num3 * 2, 2), 16);
						arg_35C_0 = 2513803173u;
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter2 = new PacketWriter(ServerMessage.SpellGo, true);
						arg_35C_0 = (num * 3385895038u ^ 3977190338u);
						continue;
					}
					case 6u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						byte[] array;
						packetWriter2.WriteBytes(array, 0);
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_35C_0 = (num * 645349454u ^ 2094935330u);
						continue;
					}
					case 7u:
						arg_35C_0 = (num * 814766979u ^ 1627543835u);
						continue;
					case 8u:
						session.Send(ref packetWriter);
						arg_35C_0 = (num * 386530094u ^ 408343786u);
						continue;
					case 9u:
					{
						byte[] array;
						string string_;
						int num4;
						array[num4] = SpellHandler.smethod_2(SpellHandler.smethod_1(string_, num4 * 2, 2), 16);
						num4++;
						arg_35C_0 = 2248897803u;
						continue;
					}
					case 10u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_35C_0 = (num * 673255875u ^ 680462305u);
						continue;
					}
					case 11u:
						arg_35C_0 = (num * 1746793927u ^ 774125646u);
						continue;
					case 12u:
					{
						byte[] array;
						int num3;
						arg_35C_0 = ((num3 >= array.Length) ? 2500590081u : 3815223811u);
						continue;
					}
					case 13u:
					{
						PacketWriter packetWriter2 = new PacketWriter(ServerMessage.SpellStart, true);
						new BitPack(packetWriter2, 0uL, 0uL, 0uL, 0uL);
						string string_ = Module.smethod_35<string>(1869705636u);
						byte[] array = new byte[SpellHandler.smethod_0(string_) / 2];
						int num4 = 0;
						arg_35C_0 = (num * 3637525854u ^ 2731629069u);
						continue;
					}
					case 14u:
					{
						byte[] array;
						packetWriter.WriteBytes(array, 0);
						arg_35C_0 = (num * 3176727326u ^ 1608014963u);
						continue;
					}
					case 15u:
					{
						byte[] array;
						int num2;
						string string_;
						array[num2] = SpellHandler.smethod_2(SpellHandler.smethod_1(string_, num2 * 2, 2), 16);
						num2++;
						arg_35C_0 = 4222645102u;
						continue;
					}
					case 16u:
					{
						string string_ = Module.smethod_37<string>(1724181447u);
						arg_35C_0 = (num * 1899220956u ^ 3503518101u);
						continue;
					}
					case 17u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteUInt8(0);
						arg_35C_0 = (num * 317972108u ^ 2094842830u);
						continue;
					}
					case 18u:
					{
						string string_;
						byte[] array = new byte[SpellHandler.smethod_0(string_) / 2];
						int num3 = 0;
						arg_35C_0 = (num * 486794978u ^ 1577748392u);
						continue;
					}
					case 19u:
					{
						int num2 = 0;
						arg_35C_0 = (num * 2886695706u ^ 4258145214u);
						continue;
					}
					case 20u:
					{
						byte[] array;
						int num4;
						arg_35C_0 = ((num4 < array.Length) ? 3789216542u : 2803619793u);
						continue;
					}
					case 22u:
					{
						PacketWriter packetWriter2;
						packetWriter2.WriteSmartGuid(session.Character.Guid, GuidType.Player);
						arg_35C_0 = (num * 3760716457u ^ 3787656715u);
						continue;
					}
					case 23u:
						goto IL_3CA;
					}
					return;
				}
			}
		}

		[AsyncStateMachine(typeof(SpellHandler.<CastSpell>d__6))]
		public static void CastSpell(WorldClass session, int spellId, SmartGuid castId)
		{
			SpellHandler.<CastSpell>d__6 <CastSpell>d__;
			<CastSpell>d__.session = session;
			AsyncVoidMethodBuilder __t__builder;
			while (true)
			{
				IL_85:
				uint arg_65_0 = 2282171839u;
				while (true)
				{
					uint num;
					switch ((num = (arg_65_0 ^ 3822533412u)) % 5u)
					{
					case 0u:
						goto IL_85;
					case 2u:
						<CastSpell>d__.spellId = spellId;
						arg_65_0 = (num * 1840100614u ^ 778084457u);
						continue;
					case 3u:
						__t__builder = <CastSpell>d__.__t__builder;
						arg_65_0 = (num * 3444476317u ^ 1160958368u);
						continue;
					case 4u:
						<CastSpell>d__.castId = castId;
						<CastSpell>d__.__t__builder = AsyncVoidMethodBuilder.Create();
						<CastSpell>d__.__1__state = -1;
						arg_65_0 = (num * 3355532363u ^ 1849549973u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			__t__builder.Start<SpellHandler.<CastSpell>d__6>(ref <CastSpell>d__);
		}

		public static void WriteCastData(ref PacketWriter writer, WorldClass session, ref BitPack BitPack, int spellId, SmartGuid castId, uint castTime = 1500u)
		{
			writer.WriteSmartGuid(session.Character.Guid, GuidType.Player);
			writer.WriteSmartGuid(session.Character.Guid, GuidType.Player);
			while (true)
			{
				IL_37D:
				uint arg_308_0 = 3838886486u;
				while (true)
				{
					uint num;
					switch ((num = (arg_308_0 ^ 4140424076u)) % 26u)
					{
					case 0u:
						BitPack.Write<int>(0, 25);
						BitPack.Write<bool>(false);
						arg_308_0 = (num * 1586089532u ^ 4077363843u);
						continue;
					case 1u:
						BitPack.Write<int>(0, 16);
						BitPack.Write<int>(0, 16);
						arg_308_0 = (num * 186755342u ^ 2841960031u);
						continue;
					case 2u:
						writer.WriteSmartGuid(castId);
						arg_308_0 = (num * 2241734600u ^ 2232724254u);
						continue;
					case 3u:
						BitPack.Write<bool>(false);
						arg_308_0 = (num * 228909168u ^ 3535531349u);
						continue;
					case 4u:
						writer.WriteSmartGuid(0uL, GuidType.Player);
						arg_308_0 = (num * 1717643167u ^ 1687754918u);
						continue;
					case 5u:
						BitPack.Write<bool>(false);
						BitPack.Write<bool>(false);
						arg_308_0 = (num * 3554873396u ^ 1551941179u);
						continue;
					case 7u:
						writer.WriteInt32(0);
						arg_308_0 = (num * 3985010016u ^ 3189089925u);
						continue;
					case 8u:
						writer.WriteUInt32(castTime);
						arg_308_0 = 3877726258u;
						continue;
					case 9u:
						BitPack.Write<int>(0, 9);
						arg_308_0 = (num * 3044735342u ^ 3261654741u);
						continue;
					case 10u:
						writer.WriteInt32(spellId);
						arg_308_0 = (num * 3284054643u ^ 4096881426u);
						continue;
					case 11u:
						BitPack.Write<bool>(false);
						BitPack.Flush();
						arg_308_0 = (num * 3987973u ^ 1663004115u);
						continue;
					case 12u:
						writer.WriteUInt32(66297u);
						arg_308_0 = (((castTime == 0u) ? 298507407u : 935392841u) ^ num * 2052695850u);
						continue;
					case 13u:
						writer.WriteInt32(0);
						arg_308_0 = 2222930688u;
						continue;
					case 14u:
						BitPack.Write<int>(0, 22);
						BitPack.Write<int>(0, 16);
						arg_308_0 = (num * 939684174u ^ 4220231639u);
						continue;
					case 15u:
						writer.WriteInt32(0);
						arg_308_0 = (num * 2971885772u ^ 386800913u);
						continue;
					case 16u:
						writer.WriteSmartGuid(castId);
						arg_308_0 = (num * 3491712652u ^ 1488517812u);
						continue;
					case 17u:
						BitPack.Write<bool>(false);
						BitPack.Write<int>(0, 7);
						arg_308_0 = (num * 3523674949u ^ 645708779u);
						continue;
					case 18u:
						writer.WriteInt32(0);
						arg_308_0 = (num * 3410065786u ^ 1420364251u);
						continue;
					case 19u:
						writer.WriteInt32(0);
						arg_308_0 = (num * 2306076363u ^ 2743430445u);
						continue;
					case 20u:
						arg_308_0 = (num * 3671674926u ^ 2045424404u);
						continue;
					case 21u:
						goto IL_37D;
					case 22u:
						writer.WriteInt32(0);
						writer.WriteUInt8(0);
						writer.WriteUInt8(0);
						arg_308_0 = (num * 4101113442u ^ 279876037u);
						continue;
					case 23u:
						writer.WriteFloat(0f);
						arg_308_0 = (num * 692139264u ^ 1378314312u);
						continue;
					case 24u:
						writer.WriteSmartGuid(session.Character.TargetGuid, GuidType.Player);
						arg_308_0 = (num * 1794509063u ^ 1223018578u);
						continue;
					case 25u:
						writer.WriteInt32(0);
						writer.WriteInt32(0);
						writer.WriteUInt8(0);
						arg_308_0 = (num * 1707563810u ^ 276352896u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			writer.WriteSmartGuid(0uL, GuidType.Player);
		}

		public static void HandleLearnedSpells(ref WorldClass session, List<uint> newSpells)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.LearnedSpells, true);
			BitPack bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
			while (true)
			{
				IL_1D4:
				uint arg_18A_0 = 2505692412u;
				while (true)
				{
					uint num;
					switch ((num = (arg_18A_0 ^ 2887819410u)) % 15u)
					{
					case 0u:
						goto IL_1D4;
					case 1u:
					{
						int num2;
						packetWriter.WriteUInt32(newSpells[num2]);
						arg_18A_0 = 2251992918u;
						continue;
					}
					case 2u:
						bitPack.Flush();
						arg_18A_0 = (num * 52899486u ^ 4007865338u);
						continue;
					case 3u:
					{
						int num3;
						packetWriter.WriteUInt32(newSpells[num3]);
						arg_18A_0 = 3612900750u;
						continue;
					}
					case 4u:
						bitPack.Write<int>(0);
						arg_18A_0 = (num * 1080477016u ^ 750266935u);
						continue;
					case 5u:
						session.Send(ref packetWriter);
						arg_18A_0 = (num * 4018288143u ^ 397696686u);
						continue;
					case 6u:
					{
						packetWriter.WriteInt32(newSpells.Count);
						int num3 = 0;
						arg_18A_0 = (num * 684424722u ^ 2788232179u);
						continue;
					}
					case 7u:
					{
						int num2 = 0;
						arg_18A_0 = (num * 376977033u ^ 4112279232u);
						continue;
					}
					case 8u:
					{
						int num2;
						arg_18A_0 = ((num2 >= newSpells.Count) ? 3941076199u : 3047045530u);
						continue;
					}
					case 9u:
					{
						int num2;
						num2++;
						arg_18A_0 = (num * 3578151209u ^ 560733840u);
						continue;
					}
					case 10u:
						arg_18A_0 = (num * 501077822u ^ 4198579483u);
						continue;
					case 11u:
					{
						int num3;
						arg_18A_0 = ((num3 < newSpells.Count) ? 2543727289u : 3126670086u);
						continue;
					}
					case 12u:
					{
						int num3;
						num3++;
						arg_18A_0 = (num * 1419794369u ^ 795664741u);
						continue;
					}
					case 14u:
						packetWriter.WriteInt32(newSpells.Count);
						arg_18A_0 = (num * 1610544683u ^ 32591431u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleUnlearnedSpells(ref WorldClass session, List<uint> oldSpells)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.UnlearnedSpells, true);
			while (true)
			{
				IL_FB:
				uint arg_CF_0 = 2203798513u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CF_0 ^ 2282107082u)) % 8u)
					{
					case 0u:
					{
						int num2;
						num2++;
						arg_CF_0 = (num * 2717838124u ^ 101302792u);
						continue;
					}
					case 1u:
						arg_CF_0 = (num * 1380131711u ^ 3037237943u);
						continue;
					case 2u:
					{
						int num2;
						arg_CF_0 = ((num2 < oldSpells.Count) ? 3342807749u : 2253144055u);
						continue;
					}
					case 3u:
					{
						BitPack expr_66 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						expr_66.Write<int>(oldSpells.Count, 22);
						expr_66.Flush();
						arg_CF_0 = (num * 48424762u ^ 3562694784u);
						continue;
					}
					case 4u:
					{
						int num2 = 0;
						arg_CF_0 = (num * 1234660541u ^ 2769672847u);
						continue;
					}
					case 6u:
						goto IL_FB;
					case 7u:
					{
						int num2;
						packetWriter.WriteUInt32(oldSpells[num2]);
						arg_CF_0 = 2402715770u;
						continue;
					}
					}
					goto Block_2;
				}
			}
			Block_2:
			session.Send(ref packetWriter);
		}

		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_1(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		static byte smethod_2(string string_0, int int_0)
		{
			return Convert.ToByte(string_0, int_0);
		}
	}
}
