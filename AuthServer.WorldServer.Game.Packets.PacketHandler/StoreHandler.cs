using AuthServer.Network;
using Framework.Constants.Net;
using Framework.Network.Packets;
using System;

namespace AuthServer.WorldServer.Game.Packets.PacketHandler
{
	public class StoreHandler
	{
		public static void HandleEnableStore(ref WorldClass session)
		{
			PacketWriter writer = new PacketWriter(ServerMessage.FeatureSystemStatusGlueScreen, true);
			BitPack expr_36 = new BitPack(writer, 0uL, 0uL, 0uL, 0uL);
			expr_36.Write<bool>(false);
			expr_36.Write<bool>(true);
			expr_36.Write<bool>(true);
			expr_36.Write<bool>(true);
			expr_36.Flush();
			while (true)
			{
				IL_124:
				uint arg_FF_0 = 2305664110u;
				while (true)
				{
					uint num;
					switch ((num = (arg_FF_0 ^ 2963858355u)) % 6u)
					{
					case 0u:
					{
						PacketWriter packetWriter = new PacketWriter(ServerMessage.DistributionList, true);
						arg_FF_0 = (num * 3917242240u ^ 3814418484u);
						continue;
					}
					case 2u:
						goto IL_124;
					case 3u:
						session.Send(ref writer);
						arg_FF_0 = (num * 3817472932u ^ 2280512839u);
						continue;
					case 4u:
					{
						PacketWriter packetWriter;
						session.Send(ref packetWriter);
						arg_FF_0 = (num * 468649160u ^ 1910400638u);
						continue;
					}
					case 5u:
					{
						PacketWriter packetWriter;
						BitPack expr_87 = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						expr_87.Write<int>(0, 19);
						expr_87.Flush();
						packetWriter.WriteUInt32(0u);
						arg_FF_0 = (num * 2615517037u ^ 2430575216u);
						continue;
					}
					}
					return;
				}
			}
		}
	}
}
