using AuthServer.AuthServer.Attributes;
using AuthServer.Network;
using Bgs.Protocol.Account.V1;
using Framework.Constants.Net;
using System;

namespace AuthServer.AuthServer.Packets.BnetHandlers
{
	[BnetService(BnetServiceHash.AccountService)]
	public class AccountService : BnetServiceBase
	{
		[BnetServiceBase.BnetMethodAttribute(30u)]
		public static void HandleGetAccountStateRequest(AuthSession session, GetAccountStateRequest getAccountStateRequest)
		{
			GetAccountStateResponse getAccountStateResponse = new GetAccountStateResponse();
			while (true)
			{
				IL_6C:
				uint arg_54_0 = 2075659893u;
				while (true)
				{
					uint num;
					switch ((num = (arg_54_0 ^ 1809695806u)) % 3u)
					{
					case 0u:
						goto IL_6C;
					case 1u:
						getAccountStateResponse.State = new AccountState
						{
							PrivacyInfo = new PrivacyInfo
							{
								IsHiddenFromFriendFinder = true,
								IsUsingRid = true
							}
						};
						getAccountStateResponse.Tags = new AccountFieldTags
						{
							PrivacyInfoTag = 3620373325u
						};
						arg_54_0 = (num * 1819771145u ^ 3782781945u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			session.Send(getAccountStateResponse);
		}

		[BnetServiceBase.BnetMethodAttribute(31u)]
		public static void HandleGetGameAccountStateRequest(AuthSession session, GetGameAccountStateRequest getGameAccountStateRequest)
		{
			GetGameAccountStateResponse getGameAccountStateResponse = new GetGameAccountStateResponse();
			while (true)
			{
				IL_B4:
				uint arg_98_0 = 2765505756u;
				while (true)
				{
					uint num;
					switch ((num = (arg_98_0 ^ 3049173021u)) % 4u)
					{
					case 0u:
						goto IL_B4;
					case 1u:
						getGameAccountStateResponse.State = new GameAccountState
						{
							GameLevelInfo = new GameLevelInfo
							{
								Program = 5730135u,
								Name = Module.smethod_35<string>(3787279757u)
							},
							GameStatus = new GameStatus
							{
								Program = 5730135u
							}
						};
						arg_98_0 = (num * 2239678423u ^ 1144755469u);
						continue;
					case 3u:
						getGameAccountStateResponse.State.GameLevelInfo.Licenses.Add(new AccountLicense
						{
							Id = 250u
						});
						arg_98_0 = (num * 1730719577u ^ 2890598956u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			getGameAccountStateResponse.Tags = new GameAccountFieldTags
			{
				GameLevelInfoTag = 4140539163u,
				GameStatusTag = 2562154393u
			};
			session.Send(getGameAccountStateResponse);
		}
	}
}
