using AuthServer.Game.Entities;
using AuthServer.Game.PacketHandler;
using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class MiscHandler : Manager
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MiscHandler.__c __9 = new MiscHandler.__c();

			public static Func<ActionButton, ActionButton> __9__8_1;

			public static Func<ActionButton, ulong> __9__9_2;

			internal ActionButton <HandleSetActionButton>b__8_1(ActionButton button)
			{
				return button;
			}

			internal ulong <HandleUpdateActionButtons>b__9_2(ActionButton action)
			{
				return action.Action;
			}
		}

		public static void HandleMessageOfTheDay(ref WorldClass session)
		{
			BitPack BitPack;
			PacketWriter motd;
			while (true)
			{
				IL_11C:
				uint arg_100_0 = 2532151388u;
				while (true)
				{
					uint num;
					switch ((num = (arg_100_0 ^ 4222714851u)) % 4u)
					{
					case 0u:
						goto IL_11C;
					case 1u:
					{
						BitPack = new BitPack(motd, 0uL, 0uL, 0uL, 0uL);
						List<string> expr_68 = new List<string>();
						expr_68.Add(Module.smethod_36<string>(267012313u));
						expr_68.Add(Module.smethod_36<string>(2985461224u));
						expr_68.Add(Module.smethod_35<string>(1897341651u));
						expr_68.Add(Module.smethod_36<string>(542737628u));
						expr_68.Add(Module.smethod_35<string>(750099086u));
						BitPack.Write<uint>(5u, 4);
						BitPack.Flush();
						expr_68.ForEach(delegate(string m)
						{
							BitPack.Write<int>(MiscHandler.__c__DisplayClass0_0.smethod_1(MiscHandler.__c__DisplayClass0_0.smethod_0(), m).Length, 7);
							BitPack.Flush();
							motd.WriteString(m, true);
						});
						session.Send(ref motd);
						arg_100_0 = (num * 4223574615u ^ 1369034726u);
						continue;
					}
					case 3u:
						motd = new PacketWriter(ServerMessage.MOTD, true);
						arg_100_0 = (num * 988909312u ^ 3628506202u);
						continue;
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.Ping, "17930")]
		public static void HandlePong(ref PacketReader packet, WorldClass session)
		{
			uint data = packet.Read<uint>();
			packet.Read<uint>();
			while (true)
			{
				IL_4D:
				uint arg_35_0 = 1104434895u;
				while (true)
				{
					uint num;
					switch ((num = (arg_35_0 ^ 1516962984u)) % 3u)
					{
					case 0u:
						goto IL_4D;
					case 1u:
						new PacketWriter(ServerMessage.Pong, true).WriteUInt32(data);
						arg_35_0 = (num * 1473635169u ^ 3334520623u);
						continue;
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.LogDisconnect, "17930")]
		public static void HandleDisconnectReason(ref PacketReader packet, WorldClass session)
		{
			Character character = session.Character;
			while (true)
			{
				IL_DB:
				uint arg_B7_0 = 154570481u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B7_0 ^ 1197683504u)) % 6u)
					{
					case 0u:
					{
						CharacterHandler.chatRunning = false;
						uint num2;
						Log.Message(LogType.Debug, Module.smethod_35<string>(484298775u), new object[]
						{
							(session.Account != null) ? session.Account.Id : -1,
							num2
						});
						arg_B7_0 = 1267271075u;
						continue;
					}
					case 1u:
						arg_B7_0 = (((character == null) ? 2990011730u : 3260705302u) ^ num * 3241964330u);
						continue;
					case 2u:
						Manager.WorldMgr.DeleteSession(character.Guid);
						arg_B7_0 = (num * 529485196u ^ 2508084816u);
						continue;
					case 4u:
						goto IL_DB;
					case 5u:
					{
						uint num2 = packet.Read<uint>();
						arg_B7_0 = (num * 963827472u ^ 1761491573u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void HandleCacheVersion(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.CacheVersion, true);
			while (true)
			{
				IL_48:
				uint arg_30_0 = 575565698u;
				while (true)
				{
					uint num;
					switch ((num = (arg_30_0 ^ 945065969u)) % 3u)
					{
					case 0u:
						goto IL_48;
					case 1u:
						packetWriter.WriteUInt32(0u);
						session.Send(ref packetWriter);
						arg_30_0 = (num * 2866656945u ^ 272808339u);
						continue;
					}
					return;
				}
			}
		}

		[Opcode(ClientMessage.LoadingScreenNotify, "17930")]
		public static void HandleLoadingScreenNotify(ref PacketReader packet, WorldClass session)
		{
		}

		[Opcode(ClientMessage.ViolenceLevel, "17930")]
		public static void HandleViolenceLevel(ref PacketReader packet, WorldClass session)
		{
			byte b = packet.Read<byte>();
			Log.Message(LogType.Debug, Module.smethod_34<string>(473366427u), new object[]
			{
				session.Account.Name,
				session.Account.Id,
				(ViolenceLevel)b
			});
		}

		[Opcode(ClientMessage.ChatMessageYell, "17930")]
		public static void HandleActivePlayer(ref PacketReader packet, WorldClass session)
		{
			packet.Read<byte>();
			Log.Message(LogType.Debug, Module.smethod_35<string>(1351781362u), new object[]
			{
				session.Character.Name,
				session.Character.Guid
			});
		}

		[Opcode2(ClientMessage.CliSetSelection, "17930")]
		public static void HandleSetSelection(ref PacketReader packet, WorldClass2 session)
		{
			ulong num = packet.ReadSmartGuid();
			ulong num2 = num;
			if (session.Character != null)
			{
				while (true)
				{
					IL_102:
					uint arg_D6_0 = 3744153441u;
					while (true)
					{
						uint num3;
						switch ((num3 = (arg_D6_0 ^ 2889169456u)) % 8u)
						{
						case 0u:
							goto IL_109;
						case 1u:
						{
							WorldClass session2 = Manager.WorldMgr.GetSession(session.Character.Guid);
							arg_D6_0 = (num3 * 2616728126u ^ 4099375192u);
							continue;
						}
						case 2u:
							goto IL_102;
						case 4u:
						{
							WorldClass session2;
							session2.Character.TargetGuid = num;
							arg_D6_0 = (num3 * 177931843u ^ 3339308577u);
							continue;
						}
						case 5u:
							arg_D6_0 = ((num2 == 0uL) ? 2175149112u : 3071540255u);
							continue;
						case 6u:
						{
							WorldClass session2;
							arg_D6_0 = (((session2 != null) ? 3933082510u : 3865277495u) ^ num3 * 2745653647u);
							continue;
						}
						case 7u:
							Log.Message(LogType.Debug, Module.smethod_34<string>(3202474686u), new object[]
							{
								session.Character.Guid,
								num2
							});
							arg_D6_0 = 3481464427u;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				return;
				IL_109:
				Log.Message(LogType.Debug, Module.smethod_35<string>(3044584216u), new object[]
				{
					session.Character.Guid
				});
				return;
			}
		}

		[Opcode(ClientMessage.SetActionButton, "17930")]
		public static void HandleSetActionButton(ref PacketReader packet, WorldClass session)
		{
			byte slotId;
			Character pChar;
			while (true)
			{
				IL_1F8:
				uint arg_1C2_0 = 3416576573u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1C2_0 ^ 2720966948u)) % 10u)
					{
					case 0u:
					{
						IEnumerable<ActionButton> arg_1AD_0 = from button in pChar.ActionButtons
						where button.SlotId == slotId && button.SpecGroup == pChar.ActiveSpecGroup
						select button;
						Func<ActionButton, ActionButton> arg_1AD_1;
						if ((arg_1AD_1 = MiscHandler.__c.__9__8_1) == null)
						{
							arg_1AD_1 = (MiscHandler.__c.__9__8_1 = new Func<ActionButton, ActionButton>(MiscHandler.__c.__9.<HandleSetActionButton>b__8_1));
						}
						ActionButton actionButton = arg_1AD_0.Select(arg_1AD_1).First<ActionButton>();
						arg_1C2_0 = 2264271340u;
						continue;
					}
					case 1u:
					{
						pChar = session.Character;
						ulong num2 = MiscHandler.smethod_0(packet);
						slotId = packet.Read<byte>();
						arg_1C2_0 = (num * 2927243228u ^ 704355889u);
						continue;
					}
					case 2u:
					{
						ActionButton actionButton;
						Manager.ActionMgr.RemoveActionButton(pChar, actionButton, true);
						arg_1C2_0 = (num * 3148430814u ^ 1163004694u);
						continue;
					}
					case 3u:
					{
						ulong num2;
						arg_1C2_0 = (((num2 == 0uL) ? 3729634153u : 2755760364u) ^ num * 1363198925u);
						continue;
					}
					case 4u:
					{
						ulong num2;
						Log.Message(LogType.Debug, Module.smethod_34<string>(3296211298u), new object[]
						{
							pChar.Guid,
							num2,
							slotId
						});
						arg_1C2_0 = (num * 674155338u ^ 2319681788u);
						continue;
					}
					case 5u:
					{
						ulong num2;
						ActionButton actionButton2 = new ActionButton
						{
							Action = num2,
							SlotId = slotId,
							SpecGroup = pChar.ActiveSpecGroup
						};
						arg_1C2_0 = 3937332115u;
						continue;
					}
					case 6u:
						return;
					case 8u:
						goto IL_1F8;
					case 9u:
					{
						ActionButton actionButton2;
						Manager.ActionMgr.AddActionButton(pChar, actionButton2, true);
						ulong num2;
						Log.Message(LogType.Debug, Module.smethod_35<string>(288580118u), new object[]
						{
							pChar.Guid,
							num2,
							slotId
						});
						arg_1C2_0 = (num * 1057463084u ^ 755692747u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:;
		}

		public static void HandleUpdateActionButtons(ref WorldClass session)
		{
			Character character = session.Character;
			while (true)
			{
				IL_27B:
				uint arg_225_0 = 127831531u;
				while (true)
				{
					uint num;
					switch ((num = (arg_225_0 ^ 338001762u)) % 18u)
					{
					case 0u:
						goto IL_27B;
					case 1u:
					{
						List<ActionButton> actionButtons = Manager.ActionMgr.GetActionButtons(character, character.ActiveSpecGroup);
						arg_225_0 = (num * 576267386u ^ 3161605306u);
						continue;
					}
					case 2u:
					{
						int num2 = 0;
						arg_225_0 = (num * 3320335652u ^ 2935521973u);
						continue;
					}
					case 3u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.UpdateActionButtons, true);
						byte[][] array = new byte[132][];
						arg_225_0 = (num * 1697180382u ^ 3540906221u);
						continue;
					}
					case 4u:
						arg_225_0 = (num * 3445858557u ^ 1768122451u);
						continue;
					case 5u:
					{
						int num2;
						arg_225_0 = ((num2 < 132) ? 723471770u : 669238764u);
						continue;
					}
					case 6u:
					{
						int j;
						__c__DisplayClass9_.i = j + 1;
						arg_225_0 = (num * 4243037527u ^ 1089304061u);
						continue;
					}
					case 8u:
					{
						int num2;
						PacketWriter packetWriter;
						byte[][] array;
						packetWriter.WriteBytes(array[num2], 0);
						num2++;
						arg_225_0 = 538466035u;
						continue;
					}
					case 9u:
						arg_225_0 = ((__c__DisplayClass9_.i >= 132) ? 962183052u : 1222740348u);
						continue;
					case 10u:
					{
						PacketWriter packetWriter;
						packetWriter.WriteInt8(0);
						arg_225_0 = (num * 3472248785u ^ 461839786u);
						continue;
					}
					case 11u:
						arg_225_0 = (num * 3217738793u ^ 4077141236u);
						continue;
					case 12u:
					{
						List<ActionButton> actionButtons;
						arg_225_0 = (actionButtons.Any((ActionButton action) => (int)action.SlotId == __c__DisplayClass9_.i) ? 83130917u : 1891720325u);
						continue;
					}
					case 13u:
					{
						byte[][] array;
						byte[][] arg_BD_0 = array;
						int arg_BD_1 = __c__DisplayClass9_.i;
						List<ActionButton> actionButtons;
						IEnumerable<ActionButton> arg_AE_0 = from action in actionButtons
						where (int)action.SlotId == __c__DisplayClass9_.i
						select action;
						Func<ActionButton, ulong> arg_AE_1;
						if ((arg_AE_1 = MiscHandler.__c.__9__9_2) == null)
						{
							arg_AE_1 = (MiscHandler.__c.__9__9_2 = new Func<ActionButton, ulong>(MiscHandler.__c.__9.<HandleUpdateActionButtons>b__9_2));
						}
						arg_BD_0[arg_BD_1] = MiscHandler.smethod_1(arg_AE_0.Select(arg_AE_1).First<ulong>());
						arg_225_0 = 225251452u;
						continue;
					}
					case 14u:
						__c__DisplayClass9_.i = 0;
						arg_225_0 = (num * 487897016u ^ 1426422671u);
						continue;
					case 15u:
					{
						byte[][] array;
						array[__c__DisplayClass9_.i] = new byte[8];
						arg_225_0 = 700578037u;
						continue;
					}
					case 16u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_225_0 = (num * 4100072258u ^ 2656812529u);
						continue;
					}
					case 17u:
					{
						int j = __c__DisplayClass9_.i;
						arg_225_0 = 549749676u;
						continue;
					}
					}
					return;
				}
			}
		}

		static ulong smethod_0(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt64();
		}

		static byte[] smethod_1(ulong ulong_0)
		{
			return BitConverter.GetBytes(ulong_0);
		}
	}
}
