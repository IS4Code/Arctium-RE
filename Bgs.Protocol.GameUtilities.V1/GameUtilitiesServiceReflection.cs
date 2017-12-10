using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public static class GameUtilitiesServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.descriptor;
			}
		}

		static GameUtilitiesServiceReflection()
		{
			GameUtilitiesServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(GameUtilitiesServiceReflection.smethod_1(GameUtilitiesServiceReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(761365721u),
				Module.smethod_35<string>(3892930358u),
				Module.smethod_37<string>(3154491370u),
				Module.smethod_36<string>(1712265446u),
				Module.smethod_37<string>(3358968714u),
				Module.smethod_35<string>(1262846582u),
				Module.smethod_34<string>(2806654329u),
				Module.smethod_36<string>(3668792230u),
				Module.smethod_34<string>(2056761433u),
				Module.smethod_34<string>(931922089u),
				Module.smethod_33<string>(4267432331u),
				Module.smethod_36<string>(2094179174u),
				Module.smethod_34<string>(556975641u),
				Module.smethod_37<string>(203569146u),
				Module.smethod_35<string>(3935092678u),
				Module.smethod_37<string>(1401491610u),
				Module.smethod_35<string>(4284934310u),
				Module.smethod_37<string>(2599414074u),
				Module.smethod_34<string>(2602264249u),
				Module.smethod_35<string>(2312371478u),
				Module.smethod_35<string>(1654850534u),
				Module.smethod_37<string>(4001813882u),
				Module.smethod_34<string>(1102478457u),
				Module.smethod_37<string>(904769050u),
				Module.smethod_37<string>(2453291466u),
				Module.smethod_36<string>(1306872646u),
				Module.smethod_34<string>(3897659961u),
				Module.smethod_33<string>(2530439003u),
				Module.smethod_33<string>(4268844523u),
				Module.smethod_37<string>(1518201082u),
				Module.smethod_36<string>(3704010838u),
				Module.smethod_35<string>(2143722198u),
				Module.smethod_37<string>(4264645962u),
				Module.smethod_33<string>(1712282747u),
				Module.smethod_34<string>(3419824569u),
				Module.smethod_34<string>(2294985225u),
				Module.smethod_34<string>(2669931673u),
				Module.smethod_37<string>(1021478522u),
				Module.smethod_33<string>(1814375755u),
				Module.smethod_33<string>(1916468763u),
				Module.smethod_37<string>(3767923402u),
				Module.smethod_35<string>(2493563830u),
				Module.smethod_33<string>(178063243u),
				Module.smethod_36<string>(566524262u),
				Module.smethod_33<string>(2018561771u),
				Module.smethod_34<string>(2840488041u),
				Module.smethod_33<string>(2836718027u),
				Module.smethod_35<string>(213321686u),
				Module.smethod_35<string>(3850768038u),
				Module.smethod_37<string>(612523834u),
				Module.smethod_34<string>(1715648697u),
				Module.smethod_37<string>(817001178u),
				Module.smethod_36<string>(3680531766u),
				Module.smethod_36<string>(2117658246u),
				Module.smethod_35<string>(2535726150u),
				Module.smethod_35<string>(3543088726u),
				Module.smethod_33<string>(1404591531u),
				Module.smethod_36<string>(4074185030u),
				Module.smethod_35<string>(4200609670u),
				Module.smethod_34<string>(1609984137u),
				Module.smethod_34<string>(1984930585u),
				Module.smethod_33<string>(1087014971u),
				Module.smethod_34<string>(1235037689u),
				Module.smethod_34<string>(110198345u),
				Module.smethod_36<string>(484347510u),
				Module.smethod_34<string>(3655272745u),
				Module.smethod_37<string>(1548557290u),
				Module.smethod_35<string>(2058264282u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				ContentHandleTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				GameUtilitiesTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(ClientRequest).TypeHandle), ClientRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1418463188u),
					Module.smethod_35<string>(2370270415u),
					Module.smethod_37<string>(1053101983u),
					Module.smethod_36<string>(1993931775u),
					Module.smethod_37<string>(700380119u),
					Module.smethod_37<string>(204512218u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(ClientResponse).TypeHandle), ClientResponse.Parser, new string[]
				{
					Module.smethod_37<string>(1754272416u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(ServerRequest).TypeHandle), ServerRequest.Parser, new string[]
				{
					Module.smethod_37<string>(1754272416u),
					Module.smethod_34<string>(3421418748u),
					Module.smethod_34<string>(4183239592u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(ServerResponse).TypeHandle), ServerResponse.Parser, new string[]
				{
					Module.smethod_35<string>(1418463188u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(PresenceChannelCreatedRequest).TypeHandle), PresenceChannelCreatedRequest.Parser, new string[]
				{
					Module.smethod_37<string>(1783715023u),
					Module.smethod_36<string>(1993931775u),
					Module.smethod_36<string>(4043002107u),
					Module.smethod_35<string>(2370270415u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GetPlayerVariablesRequest).TypeHandle), GetPlayerVariablesRequest.Parser, new string[]
				{
					Module.smethod_34<string>(3186589685u),
					Module.smethod_34<string>(4183239592u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GetPlayerVariablesResponse).TypeHandle), GetPlayerVariablesResponse.Parser, new string[]
				{
					Module.smethod_34<string>(3186589685u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GameAccountOnlineNotification).TypeHandle), GameAccountOnlineNotification.Parser, new string[]
				{
					Module.smethod_33<string>(1846560140u),
					Module.smethod_36<string>(4123806119u),
					Module.smethod_33<string>(3138256852u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GameAccountOfflineNotification).TypeHandle), GameAccountOfflineNotification.Parser, new string[]
				{
					Module.smethod_34<string>(1031416304u),
					Module.smethod_37<string>(585674675u),
					Module.smethod_36<string>(544950519u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GetAchievementsFileRequest).TypeHandle), GetAchievementsFileRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3022041924u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GetAchievementsFileResponse).TypeHandle), GetAchievementsFileResponse.Parser, new string[]
				{
					Module.smethod_33<string>(2703655472u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GetAllValuesForAttributeRequest).TypeHandle), GetAllValuesForAttributeRequest.Parser, new string[]
				{
					Module.smethod_37<string>(934948432u),
					Module.smethod_33<string>(2714350708u),
					Module.smethod_35<string>(2043171339u)
				}, null, null, null),
				new GeneratedCodeInfo(GameUtilitiesServiceReflection.smethod_2(typeof(GetAllValuesForAttributeResponse).TypeHandle), GetAllValuesForAttributeResponse.Parser, new string[]
				{
					Module.smethod_37<string>(2395820860u)
				}, null, null, null)
			}));
		}

		static string smethod_0(string[] string_0)
		{
			return string.Concat(string_0);
		}

		static byte[] smethod_1(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
