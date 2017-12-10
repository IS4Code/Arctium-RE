using AuthServer.AuthServer.Attributes;
using AuthServer.Network;
using Bgs.Protocol;
using Bgs.Protocol.Authentication.V1;
using Bgs.Protocol.Challenge.V1;
using Framework.Constants.Net;
using Framework.Misc;
using Google.Protobuf;
using System;

namespace AuthServer.AuthServer.Packets.BnetHandlers
{
	[BnetService(BnetServiceHash.AuthenticationServerService)]
	public class AuthenticationServerService : BnetServiceBase
	{
		[BnetServiceBase.BnetMethodAttribute(1u)]
		public static void HandleConnectRequest(AuthSession session, LogonRequest logonRequest)
		{
			if (logonRequest.WebClientVerification)
			{
				while (true)
				{
					IL_98:
					uint arg_78_0 = 2859478583u;
					while (true)
					{
						uint num;
						switch ((num = (arg_78_0 ^ 2148169041u)) % 5u)
						{
						case 0u:
							goto IL_98;
						case 2u:
						{
							ChallengeExternalRequest challengeExternalRequest = new ChallengeExternalRequest();
							challengeExternalRequest.PayloadType = Module.smethod_36<string>(573305427u);
							arg_78_0 = (num * 4022609958u ^ 1698604317u);
							continue;
						}
						case 3u:
						{
							ChallengeExternalRequest challengeExternalRequest;
							challengeExternalRequest.Payload = ByteString.CopyFromUtf8(Module.smethod_33<string>(4154950356u));
							arg_78_0 = (num * 836868245u ^ 2968312731u);
							continue;
						}
						case 4u:
						{
							ChallengeExternalRequest challengeExternalRequest;
							session.Send(challengeExternalRequest, 3151632159u, 3u);
							arg_78_0 = (num * 950688502u ^ 1062584357u);
							continue;
						}
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		[BnetServiceBase.BnetMethodAttribute(7u)]
		public static void HandleVerifyWebCredentialsRequest(AuthSession session, VerifyWebCredentialsRequest verifyWebCredentialsRequest)
		{
			if (AuthenticationServerService.smethod_0(verifyWebCredentialsRequest.WebCredentials.ToStringUtf8(), Module.smethod_35<string>(135873738u)))
			{
				goto IL_40;
			}
			goto IL_12A;
			uint arg_FE_0;
			while (true)
			{
				IL_F9:
				uint num;
				switch ((num = (arg_FE_0 ^ 2914461396u)) % 8u)
				{
				case 0u:
				{
					LogonResult logonResult;
					logonResult.AccountId = new EntityId
					{
						High = 72057594037927936uL,
						Low = 400392402uL
					};
					logonResult.GameAccountId.Add(new EntityId
					{
						High = 144115196671520599uL,
						Low = 53248613uL
					});
					arg_FE_0 = (num * 1282423581u ^ 3250166064u);
					continue;
				}
				case 2u:
				{
					LogonResult logonResult;
					session.Send(logonResult, 1898188341u, 5u);
					arg_FE_0 = (num * 2722318603u ^ 3294505385u);
					continue;
				}
				case 3u:
					return;
				case 4u:
				{
					LogonResult logonResult;
					logonResult.SessionKey = ByteString.CopyFromUtf8(new byte[0].GenerateRandomKey(64).ToHexString());
					arg_FE_0 = (num * 3298850102u ^ 2641972478u);
					continue;
				}
				case 5u:
					goto IL_12A;
				case 6u:
					goto IL_40;
				case 7u:
				{
					LogonResult logonResult = new LogonResult();
					logonResult.ErrorCode = 0u;
					arg_FE_0 = (num * 3066472018u ^ 3234139154u);
					continue;
				}
				}
				break;
			}
			return;
			IL_40:
			arg_FE_0 = 2502728195u;
			goto IL_F9;
			IL_12A:
			session.Dispose();
			arg_FE_0 = 3425304053u;
			goto IL_F9;
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}
}
