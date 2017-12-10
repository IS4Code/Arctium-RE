using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public static class AccountServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.descriptor;
			}
		}

		static AccountServiceReflection()
		{
			AccountServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(AccountServiceReflection.smethod_1(AccountServiceReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(1032837814u),
				Module.smethod_37<string>(493957689u),
				Module.smethod_36<string>(2352141404u),
				Module.smethod_35<string>(2233017333u),
				Module.smethod_33<string>(316774566u),
				Module.smethod_33<string>(3691492598u),
				Module.smethod_35<string>(2890538277u),
				Module.smethod_34<string>(685165078u),
				Module.smethod_33<string>(2975429350u),
				Module.smethod_33<string>(2055180086u),
				Module.smethod_36<string>(73546285u),
				Module.smethod_34<string>(3480346582u),
				Module.smethod_36<string>(1624680269u),
				Module.smethod_34<string>(2730453686u),
				Module.smethod_37<string>(3386525177u),
				Module.smethod_33<string>(2259366102u),
				Module.smethod_36<string>(3581207053u),
				Module.smethod_34<string>(1230667894u),
				Module.smethod_35<string>(3590221541u),
				Module.smethod_36<string>(3569467517u),
				Module.smethod_35<string>(3940063173u),
				Module.smethod_36<string>(443720477u),
				Module.smethod_37<string>(2889802617u),
				Module.smethod_36<string>(1231027005u),
				Module.smethod_37<string>(4087725081u),
				Module.smethod_33<string>(4099864630u),
				Module.smethod_33<string>(1543302854u),
				Module.smethod_37<string>(27591337u),
				Module.smethod_36<string>(1148850253u),
				Module.smethod_37<string>(1225513801u),
				Module.smethod_33<string>(2145975558u),
				Module.smethod_34<string>(163990u),
				Module.smethod_37<string>(3971958681u),
				Module.smethod_36<string>(1542503517u),
				Module.smethod_35<string>(4171427813u),
				Module.smethod_37<string>(3825836073u),
				Module.smethod_33<string>(2350161574u),
				Module.smethod_36<string>(4262857757u),
				Module.smethod_37<string>(2277313657u),
				Module.smethod_37<string>(1926713705u),
				Module.smethod_35<string>(1891185669u),
				Module.smethod_33<string>(4088567094u),
				Module.smethod_35<string>(3206227557u),
				Module.smethod_35<string>(4213590133u),
				Module.smethod_37<string>(2569558873u),
				Module.smethod_37<string>(2218958921u),
				Module.smethod_33<string>(4190660102u),
				Module.smethod_33<string>(4292753110u),
				Module.smethod_33<string>(1736191334u),
				Module.smethod_35<string>(2898548245u),
				Module.smethod_37<string>(1868358969u),
				Module.smethod_37<string>(524313897u),
				Module.smethod_37<string>(2072836313u),
				Module.smethod_37<string>(1722236361u),
				Module.smethod_37<string>(3270758777u),
				Module.smethod_34<string>(3886351126u),
				Module.smethod_36<string>(4251118221u),
				Module.smethod_37<string>(4118081289u),
				Module.smethod_36<string>(1125371181u),
				Module.smethod_36<string>(1184068861u),
				Module.smethod_33<string>(1533417510u),
				Module.smethod_34<string>(4158408630u),
				Module.smethod_33<string>(2351573766u),
				Module.smethod_33<string>(2453666774u),
				Module.smethod_34<string>(3783462182u),
				Module.smethod_36<string>(14848605u),
				Module.smethod_35<string>(3737261541u),
				Module.smethod_34<string>(1908729942u),
				Module.smethod_33<string>(2555759782u),
				Module.smethod_35<string>(1764698709u),
				Module.smethod_33<string>(3373916038u),
				Module.smethod_36<string>(3522509373u),
				Module.smethod_36<string>(1959635853u),
				Module.smethod_37<string>(1137745929u),
				Module.smethod_35<string>(2772061285u),
				Module.smethod_33<string>(1839696534u),
				Module.smethod_37<string>(582668633u),
				Module.smethod_33<string>(2657852790u),
				Module.smethod_37<string>(1780591097u),
				Module.smethod_37<string>(1429991145u),
				Module.smethod_37<string>(2978513561u),
				Module.smethod_37<string>(2627913609u),
				Module.smethod_35<string>(1806861029u),
				Module.smethod_35<string>(2814223605u),
				Module.smethod_36<string>(766936525u),
				Module.smethod_34<string>(3749628470u),
				Module.smethod_34<string>(4124574918u),
				Module.smethod_37<string>(933268585u),
				Module.smethod_34<string>(3374682022u),
				Module.smethod_35<string>(1499181717u),
				Module.smethod_37<string>(3679713465u),
				Module.smethod_33<string>(3473184662u),
				Module.smethod_34<string>(101665126u),
				Module.smethod_34<string>(3271793078u),
				Module.smethod_34<string>(3646739526u),
				Module.smethod_33<string>(1836872150u),
				Module.smethod_36<string>(1865719565u),
				Module.smethod_36<string>(302846045u),
				Module.smethod_33<string>(98466630u),
				Module.smethod_37<string>(3504649257u),
				Module.smethod_33<string>(1938965158u),
				Module.smethod_36<string>(3023200285u),
				Module.smethod_37<string>(1956126841u),
				Module.smethod_37<string>(1605526889u),
				Module.smethod_36<string>(2247633293u),
				Module.smethod_35<string>(437113749u),
				Module.smethod_36<string>(3416853549u),
				Module.smethod_36<string>(2235893757u),
				Module.smethod_33<string>(2961307430u),
				Module.smethod_36<string>(3405114013u),
				Module.smethod_37<string>(3446294521u),
				Module.smethod_35<string>(2451838901u),
				Module.smethod_35<string>(1794317957u),
				Module.smethod_34<string>(67831414u),
				Module.smethod_34<string>(442777862u),
				Module.smethod_36<string>(2617807485u),
				Module.smethod_37<string>(1751649497u),
				Module.smethod_35<string>(1136797013u),
				Module.smethod_37<string>(2949571961u),
				Module.smethod_33<string>(608931670u),
				Module.smethod_34<string>(2488066470u),
				Module.smethod_35<string>(2801680533u),
				Module.smethod_36<string>(4180681005u),
				Module.smethod_35<string>(2283189621u),
				Module.smethod_35<string>(1625668677u),
				Module.smethod_35<string>(3598231509u),
				Module.smethod_37<string>(465959161u),
				Module.smethod_37<string>(115359209u),
				Module.smethod_37<string>(1663881625u),
				Module.smethod_33<string>(2860626614u),
				Module.smethod_33<string>(304064838u),
				Module.smethod_33<string>(406157846u),
				Module.smethod_37<string>(3066281433u),
				Module.smethod_33<string>(1224314102u),
				Module.smethod_37<string>(4264203897u),
				Module.smethod_34<string>(2930680342u),
				Module.smethod_34<string>(3305626790u),
				Module.smethod_37<string>(816559113u),
				Module.smethod_37<string>(2365081529u),
				Module.smethod_33<string>(1428500118u),
				Module.smethod_33<string>(3166905638u),
				Module.smethod_33<string>(2246656374u),
				Module.smethod_36<string>(314585581u),
				Module.smethod_37<string>(1108804329u),
				Module.smethod_34<string>(306055206u),
				Module.smethod_33<string>(610343862u),
				Module.smethod_37<string>(3855249209u),
				Module.smethod_37<string>(2511204137u),
				Module.smethod_35<string>(3025035205u),
				Module.smethod_37<string>(3709126601u),
				Module.smethod_34<string>(2351343814u),
				Module.smethod_33<string>(814529878u),
				Module.smethod_34<string>(1601450918u),
				Module.smethod_35<string>(2367514261u),
				Module.smethod_36<string>(2653026093u),
				Module.smethod_37<string>(669964969u),
				Module.smethod_36<string>(2964502605u),
				Module.smethod_35<string>(605763029u)
			})), new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetAccountRequest).TypeHandle), GetAccountRequest.Parser, new string[]
				{
					Module.smethod_35<string>(3851488748u),
					Module.smethod_35<string>(1249324306u),
					Module.smethod_35<string>(857603673u),
					Module.smethod_37<string>(494664993u),
					Module.smethod_33<string>(3294319425u),
					Module.smethod_34<string>(348834879u),
					Module.smethod_37<string>(231715029u),
					Module.smethod_35<string>(437963706u),
					Module.smethod_37<string>(3387203010u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetAccountResponse).TypeHandle), GetAccountResponse.Parser, new string[]
				{
					Module.smethod_34<string>(3827836034u),
					Module.smethod_36<string>(94729931u),
					Module.smethod_33<string>(2222145487u),
					Module.smethod_36<string>(503400800u),
					Module.smethod_37<string>(1110425234u),
					Module.smethod_33<string>(1165801692u),
					Module.smethod_36<string>(1578254714u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(CreateGameAccountRequest).TypeHandle), CreateGameAccountRequest.Parser, new string[]
				{
					Module.smethod_36<string>(1722939804u),
					Module.smethod_36<string>(1013076684u),
					Module.smethod_35<string>(2043171339u),
					Module.smethod_34<string>(602381348u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(CacheExpireRequest).TypeHandle), CacheExpireRequest.Parser, new string[]
				{
					Module.smethod_36<string>(1722939804u),
					Module.smethod_35<string>(60202740u),
					Module.smethod_37<string>(936421982u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(CredentialUpdateRequest).TypeHandle), CredentialUpdateRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1878925916u),
					Module.smethod_37<string>(3854689260u),
					Module.smethod_33<string>(1332055878u),
					Module.smethod_34<string>(326103631u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(CredentialUpdateResponse).TypeHandle), CredentialUpdateResponse.Parser, null, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(AccountFlagUpdateRequest).TypeHandle), AccountFlagUpdateRequest.Parser, new string[]
				{
					Module.smethod_36<string>(1722939804u),
					Module.smethod_34<string>(326103631u),
					Module.smethod_35<string>(3823569414u),
					Module.smethod_37<string>(3942339248u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GameAccountFlagUpdateRequest).TypeHandle), GameAccountFlagUpdateRequest.Parser, new string[]
				{
					Module.smethod_34<string>(4081382503u),
					Module.smethod_33<string>(1006104843u),
					Module.smethod_37<string>(3942339248u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(SubscriptionUpdateRequest).TypeHandle), SubscriptionUpdateRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2859718045u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(SubscriptionUpdateResponse).TypeHandle), SubscriptionUpdateResponse.Parser, new string[]
				{
					Module.smethod_35<string>(3851488748u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(IsIgrAddressRequest).TypeHandle), IsIgrAddressRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1725213771u),
					Module.smethod_33<string>(3438383485u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(AccountServiceRegion).TypeHandle), AccountServiceRegion.Parser, new string[]
				{
					Module.smethod_35<string>(4021477587u),
					Module.smethod_33<string>(1549356568u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(AccountServiceConfig).TypeHandle), AccountServiceConfig.Parser, new string[]
				{
					Module.smethod_34<string>(326103631u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetAccountStateRequest).TypeHandle), GetAccountStateRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3081156634u),
					Module.smethod_37<string>(700380119u),
					Module.smethod_34<string>(326103631u),
					Module.smethod_35<string>(1556926582u),
					Module.smethod_37<string>(1838680594u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetAccountStateResponse).TypeHandle), GetAccountStateResponse.Parser, new string[]
				{
					Module.smethod_37<string>(3328553564u),
					Module.smethod_37<string>(1838680594u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetGameAccountStateRequest).TypeHandle), GetGameAccountStateRequest.Parser, new string[]
				{
					Module.smethod_34<string>(750206468u),
					Module.smethod_36<string>(1993931775u),
					Module.smethod_33<string>(2909155003u),
					Module.smethod_35<string>(2004846238u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetGameAccountStateResponse).TypeHandle), GetGameAccountStateResponse.Parser, new string[]
				{
					Module.smethod_35<string>(1252157496u),
					Module.smethod_37<string>(1838680594u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetLicensesRequest).TypeHandle), GetLicensesRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3091348247u),
					Module.smethod_35<string>(2228767548u),
					Module.smethod_36<string>(3615585510u),
					Module.smethod_33<string>(1868750266u),
					Module.smethod_34<string>(3421418748u),
					Module.smethod_37<string>(3182637253u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetLicensesResponse).TypeHandle), GetLicensesResponse.Parser, new string[]
				{
					Module.smethod_35<string>(2162935679u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetGameSessionInfoRequest).TypeHandle), GetGameSessionInfoRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1666543649u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetGameSessionInfoResponse).TypeHandle), GetGameSessionInfoResponse.Parser, new string[]
				{
					Module.smethod_37<string>(1312721724u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetGameTimeRemainingInfoRequest).TypeHandle), GetGameTimeRemainingInfoRequest.Parser, new string[]
				{
					Module.smethod_35<string>(2481947751u),
					Module.smethod_33<string>(542756000u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetGameTimeRemainingInfoResponse).TypeHandle), GetGameTimeRemainingInfoResponse.Parser, new string[]
				{
					Module.smethod_36<string>(148326748u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetCAISInfoRequest).TypeHandle), GetCAISInfoRequest.Parser, new string[]
				{
					Module.smethod_36<string>(1294600521u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetCAISInfoResponse).TypeHandle), GetCAISInfoResponse.Parser, new string[]
				{
					Module.smethod_35<string>(424004039u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(ForwardCacheExpireRequest).TypeHandle), ForwardCacheExpireRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3081156634u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetAuthorizedDataRequest).TypeHandle), GetAuthorizedDataRequest.Parser, new string[]
				{
					Module.smethod_34<string>(3169466458u),
					Module.smethod_35<string>(3417889114u),
					Module.smethod_36<string>(388525893u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GetAuthorizedDataResponse).TypeHandle), GetAuthorizedDataResponse.Parser, new string[]
				{
					Module.smethod_35<string>(874396530u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(AccountStateNotification).TypeHandle), AccountStateNotification.Parser, new string[]
				{
					Module.smethod_36<string>(3760270600u),
					Module.smethod_37<string>(3971516616u),
					Module.smethod_34<string>(2675333323u),
					Module.smethod_33<string>(456295781u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GameAccountStateNotification).TypeHandle), GameAccountStateNotification.Parser, new string[]
				{
					Module.smethod_37<string>(1838651123u),
					Module.smethod_36<string>(2880420524u),
					Module.smethod_33<string>(3549551945u),
					Module.smethod_35<string>(1067565316u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GameAccountNotification).TypeHandle), GameAccountNotification.Parser, new string[]
				{
					Module.smethod_36<string>(1204802453u),
					Module.smethod_37<string>(3971516616u),
					Module.smethod_36<string>(3563443968u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountServiceReflection.smethod_2(typeof(GameAccountSessionNotification).TypeHandle), GameAccountSessionNotification.Parser, new string[]
				{
					Module.smethod_35<string>(60202740u),
					Module.smethod_37<string>(1312721724u)
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
