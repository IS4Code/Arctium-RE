using AuthServer.AuthServer.Attributes;
using AuthServer.Network;
using Bgs.Protocol;
using Bgs.Protocol.Connection.V1;
using Framework.Constants.Net;
using Framework.Misc;
using System;

namespace AuthServer.AuthServer.Packets.BnetHandlers
{
	[BnetService(BnetServiceHash.ConnectionService)]
	public class ConnectionService : BnetServiceBase
	{
		[BnetServiceBase.BnetMethodAttribute(1u)]
		public static void HandleConnectRequest(AuthSession session, ConnectRequest connectRequest)
		{
			ConnectResponse connectResponse = new ConnectResponse();
			connectResponse.ClientId = connectRequest.ClientId;
			while (true)
			{
				IL_A7:
				uint arg_87_0 = 1290205775u;
				while (true)
				{
					uint num;
					switch ((num = (arg_87_0 ^ 1312768759u)) % 5u)
					{
					case 0u:
						goto IL_A7;
					case 1u:
						session.Send(connectResponse);
						arg_87_0 = (num * 574413053u ^ 864330634u);
						continue;
					case 2u:
						connectResponse.UseBindlessRpc = connectRequest.UseBindlessRpc;
						connectResponse.ServerTime = (ulong)Helper.GetUnixTime();
						arg_87_0 = (num * 4270193364u ^ 2934099669u);
						continue;
					case 4u:
						connectResponse.ServerId = new ProcessId
						{
							Epoch = Helper.GetUnixTime(),
							Label = 1337u
						};
						arg_87_0 = (num * 2896876827u ^ 2777880345u);
						continue;
					}
					return;
				}
			}
		}

		[BnetServiceBase.BnetMethodAttribute(7u)]
		public static void HandleDisconnectRequest(AuthSession session, DisconnectRequest disconnectRequest)
		{
			session.Send(new DisconnectNotification
			{
				ErrorCode = disconnectRequest.ErrorCode
			}, 1698982289u, 4u);
		}
	}
}
