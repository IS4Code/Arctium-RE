using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public static class ChallengeServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.descriptor;
			}
		}

		static ChallengeServiceReflection()
		{
			ChallengeServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(ChallengeServiceReflection.smethod_1(ChallengeServiceReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(3847734877u),
				Module.smethod_33<string>(1953995647u),
				Module.smethod_35<string>(1574079794u),
				Module.smethod_36<string>(1710135090u),
				Module.smethod_34<string>(2347949085u),
				Module.smethod_34<string>(1223109741u),
				Module.smethod_36<string>(934568098u),
				Module.smethod_36<string>(3666661874u),
				Module.smethod_37<string>(3124017278u),
				Module.smethod_33<string>(2976337919u),
				Module.smethod_35<string>(608879538u),
				Module.smethod_34<string>(3268398349u),
				Module.smethod_37<string>(2218340030u),
				Module.smethod_33<string>(1340025407u),
				Module.smethod_35<string>(2273763058u),
				Module.smethod_33<string>(2158181663u),
				Module.smethod_34<string>(2143559005u),
				Module.smethod_34<string>(1018719661u),
				Module.smethod_34<string>(1393666109u),
				Module.smethod_36<string>(2473962546u),
				Module.smethod_33<string>(2260274671u),
				Module.smethod_37<string>(1371017518u),
				Module.smethod_35<string>(1308562802u),
				Module.smethod_33<string>(3180523935u),
				Module.smethod_33<string>(623962159u),
				Module.smethod_37<string>(786527086u),
				Module.smethod_33<string>(2875657103u),
				Module.smethod_37<string>(1984449550u),
				Module.smethod_35<string>(3420155666u),
				Module.smethod_37<string>(3182372014u),
				Module.smethod_36<string>(3319966754u),
				Module.smethod_35<string>(1447592834u),
				Module.smethod_35<string>(790071890u),
				Module.smethod_36<string>(3308227218u),
				Module.smethod_37<string>(1838326942u),
				Module.smethod_37<string>(1487726990u),
				Module.smethod_34<string>(1461333533u),
				Module.smethod_37<string>(2685649454u),
				Module.smethod_35<string>(2804797042u),
				Module.smethod_33<string>(1341437599u),
				Module.smethod_33<string>(3079843119u),
				Module.smethod_33<string>(3181936127u),
				Module.smethod_34<string>(3506622141u),
				Module.smethod_35<string>(2147276098u),
				Module.smethod_35<string>(1489755154u),
				Module.smethod_34<string>(1631889901u),
				Module.smethod_35<string>(1839596786u),
				Module.smethod_36<string>(2520920690u),
				Module.smethod_33<string>(4102185391u),
				Module.smethod_37<string>(1283249646u),
				Module.smethod_37<string>(2831772062u),
				Module.smethod_36<string>(946307634u),
				Module.smethod_33<string>(2465872879u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(Challenge).TypeHandle), Challenge.Parser, new string[]
				{
					Module.smethod_37<string>(147837329u),
					Module.smethod_35<string>(2273479739u),
					Module.smethod_33<string>(2567965887u),
					Module.smethod_33<string>(2024714162u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengePickedRequest).TypeHandle), ChallengePickedRequest.Parser, new string[]
				{
					Module.smethod_35<string>(2315358740u),
					Module.smethod_37<string>(1783715023u),
					Module.smethod_35<string>(3224720328u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengePickedResponse).TypeHandle), ChallengePickedResponse.Parser, new string[]
				{
					Module.smethod_34<string>(3302232061u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeAnsweredRequest).TypeHandle), ChallengeAnsweredRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2567965887u),
					Module.smethod_37<string>(932649694u),
					Module.smethod_35<string>(4021477587u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeAnsweredResponse).TypeHandle), ChallengeAnsweredResponse.Parser, new string[]
				{
					Module.smethod_37<string>(932649694u),
					Module.smethod_33<string>(3654469337u),
					Module.smethod_37<string>(4088137675u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeCancelledRequest).TypeHandle), ChallengeCancelledRequest.Parser, new string[]
				{
					Module.smethod_35<string>(4021477587u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(SendChallengeToUserRequest).TypeHandle), SendChallengeToUserRequest.Parser, new string[]
				{
					Module.smethod_33<string>(228704801u),
					Module.smethod_35<string>(2481947751u),
					Module.smethod_37<string>(2364315283u),
					Module.smethod_34<string>(1080216740u),
					Module.smethod_35<string>(3685312303u),
					Module.smethod_35<string>(2827745881u),
					Module.smethod_35<string>(2370270415u),
					Module.smethod_36<string>(4043002107u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(SendChallengeToUserResponse).TypeHandle), SendChallengeToUserResponse.Parser, new string[]
				{
					Module.smethod_33<string>(3097905584u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeUserRequest).TypeHandle), ChallengeUserRequest.Parser, new string[]
				{
					Module.smethod_36<string>(926106631u),
					Module.smethod_33<string>(2625569728u),
					Module.smethod_37<string>(1783715023u),
					Module.smethod_37<string>(2042922170u),
					Module.smethod_37<string>(2628974565u),
					Module.smethod_37<string>(965451995u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeResultRequest).TypeHandle), ChallengeResultRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3097905584u),
					Module.smethod_36<string>(2557121941u),
					Module.smethod_34<string>(3462041918u),
					Module.smethod_37<string>(3679094574u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeExternalRequest).TypeHandle), ChallengeExternalRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3603422833u),
					Module.smethod_37<string>(1400135944u),
					Module.smethod_33<string>(1161970062u)
				}, null, null, null),
				new GeneratedCodeInfo(ChallengeServiceReflection.smethod_2(typeof(ChallengeExternalResult).TypeHandle), ChallengeExternalResult.Parser, new string[]
				{
					Module.smethod_33<string>(3603422833u),
					Module.smethod_36<string>(2364496064u)
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
