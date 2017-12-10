using AuthServer.Network;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Network.Packets;
using System;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class TimeHandler : Manager
	{
		public static void HandleReadyForAccountDataTimes(ref PacketReader packet, WorldClass session)
		{
			Log.Message(LogType.Error, Module.smethod_34<string>(1602781937u), Array.Empty<object>());
		}

		public static void HandleReadyForAccountDataTimes(ref PacketReader packet, WorldClass2 session)
		{
			Log.Message(LogType.Error, Module.smethod_37<string>(3535683298u), Array.Empty<object>());
		}

		[Opcode(ClientMessage.UITimeRequest, "18156")]
		public static void HandleUITimeRequest(ref PacketReader packet, WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.UITime, true);
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 3377425253u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 2768198855u)) % 3u)
					{
					case 1u:
						packetWriter.WriteUnixTime();
						arg_26_0 = (num * 827853117u ^ 2877711444u);
						continue;
					case 2u:
						goto IL_3E;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(ref packetWriter);
		}

		public static void HandleLoginSetTimeSpeed(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.LoginSetTimeSpeed, true);
			packetWriter.WritePackedTime();
			while (true)
			{
				IL_66:
				uint arg_4E_0 = 1798748320u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4E_0 ^ 458044892u)) % 3u)
					{
					case 0u:
						goto IL_66;
					case 2u:
						packetWriter.WritePackedTime();
						packetWriter.WriteFloat(0.01666667f);
						packetWriter.WriteInt32(0);
						packetWriter.WriteInt32(0);
						session.Send(ref packetWriter);
						arg_4E_0 = (num * 3161907175u ^ 1843293902u);
						continue;
					}
					return;
				}
			}
		}

		public static void HandleSetTimezoneInformation(ref WorldClass session)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.SetTimeZoneInformation, true);
			while (true)
			{
				IL_CE:
				uint arg_AE_0 = 935220141u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AE_0 ^ 259876853u)) % 5u)
					{
					case 0u:
					{
						string text;
						packetWriter.WriteString(text, true);
						arg_AE_0 = (num * 2656952854u ^ 2225828889u);
						continue;
					}
					case 1u:
					{
						BitPack arg_66_0 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						string text = Module.smethod_34<string>(1790255161u);
						arg_66_0.Write<int>(TimeHandler.smethod_0(text), 7);
						arg_66_0.Write<int>(TimeHandler.smethod_0(text), 7);
						arg_66_0.Flush();
						arg_AE_0 = (num * 1324747197u ^ 2173534419u);
						continue;
					}
					case 3u:
						goto IL_CE;
					case 4u:
					{
						string text;
						packetWriter.WriteString(text, true);
						session.Send(ref packetWriter);
						arg_AE_0 = (num * 3452712060u ^ 2771268710u);
						continue;
					}
					}
					return;
				}
			}
		}

		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}
	}
}
