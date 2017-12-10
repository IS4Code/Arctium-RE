using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public static class AccountTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.descriptor;
			}
		}

		static AccountTypesReflection()
		{
			AccountTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(AccountTypesReflection.smethod_1(AccountTypesReflection.smethod_0(new string[]
			{
				Module.smethod_36<string>(1887825897u),
				Module.smethod_34<string>(1015737674u),
				Module.smethod_34<string>(1884610886u),
				Module.smethod_35<string>(396084705u),
				Module.smethod_33<string>(2788999530u),
				Module.smethod_37<string>(202537661u),
				Module.smethod_34<string>(3810919178u),
				Module.smethod_37<string>(1400460125u),
				Module.smethod_33<string>(1152687018u),
				Module.smethod_34<string>(1936186938u),
				Module.smethod_35<string>(1753288913u),
				Module.smethod_37<string>(3796305053u),
				Module.smethod_35<string>(3068330801u),
				Module.smethod_36<string>(695126569u),
				Module.smethod_35<string>(3418172433u),
				Module.smethod_36<string>(1864346825u),
				Module.smethod_34<string>(61454698u),
				Module.smethod_35<string>(1445609601u),
				Module.smethod_37<string>(3650182445u),
				Module.smethod_34<string>(2481689754u),
				Module.smethod_34<string>(2856636202u),
				Module.smethod_33<string>(1052006202u),
				Module.smethod_34<string>(333512202u),
				Module.smethod_37<string>(2715092061u),
				Module.smethod_37<string>(4263614477u),
				Module.smethod_33<string>(3710660986u),
				Module.smethod_35<string>(3249523153u),
				Module.smethod_37<string>(815969693u),
				Module.smethod_34<string>(2378800810u),
				Module.smethod_37<string>(1020447037u),
				Module.smethod_36<string>(1135737977u),
				Module.smethod_34<string>(504068570u),
				Module.smethod_35<string>(1934481265u),
				Module.smethod_33<string>(438035962u),
				Module.smethod_35<string>(2284322897u),
				Module.smethod_33<string>(1256192218u),
				Module.smethod_35<string>(3599364785u),
				Module.smethod_34<string>(2549357178u),
				Module.smethod_33<string>(540128970u),
				Module.smethod_34<string>(1799464282u),
				Module.smethod_37<string>(962092301u),
				Module.smethod_37<string>(611492349u),
				Module.smethod_36<string>(3474178489u),
				Module.smethod_34<string>(299678490u),
				Module.smethod_36<string>(348431449u),
				Module.smethod_34<string>(3844752890u),
				Module.smethod_35<string>(2984006161u),
				Module.smethod_33<string>(642221978u),
				Module.smethod_37<string>(465369741u),
				Module.smethod_37<string>(114769789u),
				Module.smethod_37<string>(1663292205u),
				Module.smethod_33<string>(3300876762u),
				Module.smethod_34<string>(1970020650u),
				Module.smethod_33<string>(435211578u),
				Module.smethod_36<string>(1041821689u),
				Module.smethod_37<string>(85828189u),
				Module.smethod_33<string>(2991773354u),
				Module.smethod_37<string>(1283750653u),
				Module.smethod_34<string>(2242078154u),
				Module.smethod_37<string>(2481673117u),
				Module.smethod_36<string>(4167568729u),
				Module.smethod_37<string>(2686150461u),
				Module.smethod_36<string>(1423735417u),
				Module.smethod_34<string>(3912420314u),
				Module.smethod_37<string>(1137628045u),
				Module.smethod_36<string>(648168425u),
				Module.smethod_34<string>(3537473866u),
				Module.smethod_35<string>(1264417249u),
				Module.smethod_37<string>(3533472973u),
				Module.smethod_35<string>(1614258881u),
				Module.smethod_37<string>(1429873261u),
				Module.smethod_36<string>(242775625u),
				Module.smethod_36<string>(2974869401u),
				Module.smethod_37<string>(2277195773u),
				Module.smethod_37<string>(3825718189u),
				Module.smethod_37<string>(3475118237u),
				Module.smethod_37<string>(728673357u),
				Module.smethod_37<string>(3679595581u),
				Module.smethod_35<string>(4286504977u),
				Module.smethod_37<string>(582550749u),
				Module.smethod_34<string>(2583190890u),
				Module.smethod_37<string>(1780473213u),
				Module.smethod_35<string>(1656421201u),
				Module.smethod_37<string>(2978395677u),
				Module.smethod_37<string>(231950797u),
				Module.smethod_35<string>(3110493121u),
				Module.smethod_35<string>(2452972177u),
				Module.smethod_33<string>(1458966042u),
				Module.smethod_37<string>(3942427661u),
				Module.smethod_37<string>(3591827709u),
				Module.smethod_37<string>(845382829u),
				Module.smethod_35<string>(1795451233u),
				Module.smethod_33<string>(1561059050u),
				Module.smethod_36<string>(1458954025u),
				Module.smethod_34<string>(4150644106u),
				Module.smethod_37<string>(1897182685u),
				Module.smethod_33<string>(4219713834u),
				Module.smethod_34<string>(2275911866u),
				Module.smethod_36<string>(1852607289u),
				Module.smethod_33<string>(844995802u),
				Module.smethod_35<string>(172730033u),
				Module.smethod_33<string>(2685494330u),
				Module.smethod_36<string>(277994233u),
				Module.smethod_35<string>(2495134497u),
				Module.smethod_34<string>(401179626u),
				Module.smethod_35<string>(2844976129u),
				Module.smethod_35<string>(2187455185u),
				Module.smethod_36<string>(671647497u),
				Module.smethod_37<string>(3036750413u),
				Module.smethod_37<string>(1692705341u),
				Module.smethod_36<string>(659907961u),
				Module.smethod_33<string>(231025562u),
				Module.smethod_34<string>(1696575338u),
				Module.smethod_33<string>(2071524090u),
				Module.smethod_33<string>(3809929610u),
				Module.smethod_35<string>(3194817761u),
				Module.smethod_36<string>(3785655001u),
				Module.smethod_36<string>(4019688105u),
				Module.smethod_36<string>(2456814585u),
				Module.smethod_35<string>(4084759585u),
				Module.smethod_34<string>(2715750122u),
				Module.smethod_37<string>(521838333u),
				Module.smethod_33<string>(765497866u),
				Module.smethod_33<string>(4140215898u),
				Module.smethod_36<string>(1287594329u),
				Module.smethod_37<string>(1924238141u),
				Module.smethod_36<string>(2838728313u),
				Module.smethod_34<string>(3636199386u),
				Module.smethod_37<string>(375715725u),
				Module.smethod_36<string>(2063161321u),
				Module.smethod_37<string>(1573638189u),
				Module.smethod_36<string>(3232381577u),
				Module.smethod_34<string>(2511360042u),
				Module.smethod_35<string>(839317185u),
				Module.smethod_33<string>(151527626u),
				Module.smethod_37<string>(317360989u),
				Module.smethod_34<string>(1011574250u),
				Module.smethod_33<string>(1071776890u),
				Module.smethod_35<string>(1846679761u),
				Module.smethod_37<string>(2713205917u),
				Module.smethod_33<string>(3628338666u),
				Module.smethod_33<string>(3730431674u),
				Module.smethod_36<string>(3602555769u),
				Module.smethod_36<string>(2039682249u),
				Module.smethod_33<string>(1992026154u),
				Module.smethod_35<string>(1539000449u)
			})), new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(new Type[]
			{
				AccountTypesReflection.smethod_2(typeof(IdentityVerificationStatus).TypeHandle)
			}, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountId).TypeHandle), AccountId.Parser, new string[]
				{
					Module.smethod_33<string>(3097905584u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountLicense).TypeHandle), AccountLicense.Parser, new string[]
				{
					Module.smethod_34<string>(4055669268u),
					Module.smethod_37<string>(2567083309u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountCredential).TypeHandle), AccountCredential.Parser, new string[]
				{
					Module.smethod_34<string>(4055669268u),
					Module.smethod_36<string>(170740642u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountBlob).TypeHandle), AccountBlob.Parser, new string[]
				{
					Module.smethod_33<string>(3097905584u),
					Module.smethod_35<string>(4244548940u),
					Module.smethod_34<string>(3653059453u),
					Module.smethod_36<string>(3044016412u),
					Module.smethod_35<string>(2979962659u),
					Module.smethod_36<string>(1677969524u),
					Module.smethod_34<string>(432237722u),
					Module.smethod_33<string>(624772051u),
					Module.smethod_36<string>(2371584791u),
					Module.smethod_37<string>(930910905u),
					Module.smethod_33<string>(3781478178u),
					Module.smethod_34<string>(27976939u),
					Module.smethod_37<string>(2304133345u),
					Module.smethod_37<string>(1252304018u),
					Module.smethod_33<string>(543052031u),
					Module.smethod_36<string>(1881352294u),
					Module.smethod_35<string>(4075410058u),
					Module.smethod_37<string>(3998601543u),
					Module.smethod_34<string>(1106905041u),
					Module.smethod_36<string>(2636718283u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountBlobList).TypeHandle), AccountBlobList.Parser, new string[]
				{
					Module.smethod_34<string>(3827836034u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountHandle).TypeHandle), GameAccountHandle.Parser, new string[]
				{
					Module.smethod_33<string>(3097905584u),
					Module.smethod_36<string>(2505595523u),
					Module.smethod_34<string>(326103631u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountLink).TypeHandle), GameAccountLink.Parser, new string[]
				{
					Module.smethod_35<string>(60202740u),
					Module.smethod_34<string>(2643656114u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountBlob).TypeHandle), GameAccountBlob.Parser, new string[]
				{
					Module.smethod_36<string>(356892916u),
					Module.smethod_35<string>(3235769769u),
					Module.smethod_33<string>(3236715584u),
					Module.smethod_34<string>(2176360862u),
					Module.smethod_37<string>(434217816u),
					Module.smethod_33<string>(3042009966u),
					Module.smethod_34<string>(919431817u),
					Module.smethod_35<string>(1678030481u),
					Module.smethod_35<string>(782628560u),
					Module.smethod_33<string>(2121760702u),
					Module.smethod_34<string>(357012145u),
					Module.smethod_36<string>(2781403373u),
					Module.smethod_33<string>(4190255156u),
					Module.smethod_36<string>(1756868207u),
					Module.smethod_35<string>(1300269515u),
					Module.smethod_37<string>(667813586u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountBlobList).TypeHandle), GameAccountBlobList.Parser, new string[]
				{
					Module.smethod_34<string>(3827836034u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountReference).TypeHandle), AccountReference.Parser, new string[]
				{
					Module.smethod_34<string>(4055669268u),
					Module.smethod_36<string>(3344961058u),
					Module.smethod_34<string>(2868770521u),
					Module.smethod_35<string>(1558626496u),
					Module.smethod_33<string>(3438383485u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(Identity).TypeHandle), Identity.Parser, new string[]
				{
					Module.smethod_37<string>(1020594392u),
					Module.smethod_35<string>(60202740u),
					Module.smethod_34<string>(2711173956u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(ProgramTag).TypeHandle), ProgramTag.Parser, new string[]
				{
					Module.smethod_35<string>(2043171339u),
					Module.smethod_37<string>(231685558u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(RegionTag).TypeHandle), RegionTag.Parser, new string[]
				{
					Module.smethod_36<string>(1013076684u),
					Module.smethod_35<string>(3417889114u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountFieldTags).TypeHandle), AccountFieldTags.Parser, new string[]
				{
					Module.smethod_34<string>(3714613321u),
					Module.smethod_37<string>(3881744716u),
					Module.smethod_37<string>(1544342937u),
					Module.smethod_36<string>(567446948u),
					Module.smethod_37<string>(1865736050u),
					Module.smethod_37<string>(786821796u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountFieldTags).TypeHandle), GameAccountFieldTags.Parser, new string[]
				{
					Module.smethod_35<string>(1146429859u),
					Module.smethod_37<string>(3618794752u),
					Module.smethod_34<string>(4249369626u),
					Module.smethod_35<string>(2573432402u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountFieldOptions).TypeHandle), AccountFieldOptions.Parser, new string[]
				{
					Module.smethod_35<string>(3482793990u),
					Module.smethod_37<string>(1602786086u),
					Module.smethod_37<string>(1398220329u),
					Module.smethod_37<string>(346391002u),
					Module.smethod_33<string>(1891345338u),
					Module.smethod_37<string>(3677178959u),
					Module.smethod_35<string>(3706715300u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountFieldOptions).TypeHandle), GameAccountFieldOptions.Parser, new string[]
				{
					Module.smethod_35<string>(3482793990u),
					Module.smethod_36<string>(2873946921u),
					Module.smethod_33<string>(3738401203u),
					Module.smethod_34<string>(1586334612u),
					Module.smethod_33<string>(1731648489u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(SubscriberReference).TypeHandle), SubscriberReference.Parser, new string[]
				{
					Module.smethod_35<string>(4063073269u),
					Module.smethod_35<string>(1666543649u),
					Module.smethod_36<string>(1724927668u),
					Module.smethod_34<string>(2675333323u),
					Module.smethod_33<string>(2709501594u),
					Module.smethod_37<string>(786821796u),
					Module.smethod_34<string>(2769069935u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountLevelInfo).TypeHandle), AccountLevelInfo.Parser, new string[]
				{
					Module.smethod_35<string>(2162935679u),
					Module.smethod_36<string>(1750312069u),
					Module.smethod_33<string>(651702376u),
					Module.smethod_35<string>(3636633646u),
					Module.smethod_35<string>(1466858526u),
					Module.smethod_36<string>(503400800u),
					Module.smethod_35<string>(2153792435u),
					Module.smethod_34<string>(309186775u),
					Module.smethod_36<string>(1869612758u),
					Module.smethod_36<string>(2636718283u),
					Module.smethod_33<string>(2222145487u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(PrivacyInfo).TypeHandle), PrivacyInfo.Parser, new string[]
				{
					Module.smethod_33<string>(221238895u),
					Module.smethod_34<string>(1023914940u),
					Module.smethod_35<string>(167269936u),
					Module.smethod_34<string>(4194042892u)
				}, null, new Type[]
				{
					AccountTypesReflection.smethod_2(typeof(PrivacyInfo.Types.GameInfoPrivacy).TypeHandle)
				}, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(ParentalControlInfo).TypeHandle), ParentalControlInfo.Parser, new string[]
				{
					Module.smethod_35<string>(2895354700u),
					Module.smethod_35<string>(2503634067u),
					Module.smethod_37<string>(3472672144u),
					Module.smethod_35<string>(1253574091u),
					Module.smethod_35<string>(176413180u),
					Module.smethod_37<string>(3881715245u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameLevelInfo).TypeHandle), GameLevelInfo.Parser, new string[]
				{
					Module.smethod_33<string>(638587702u),
					Module.smethod_35<string>(1482311824u),
					Module.smethod_36<string>(3681454452u),
					Module.smethod_36<string>(69510600u),
					Module.smethod_35<string>(3235769769u),
					Module.smethod_33<string>(1332460824u),
					Module.smethod_35<string>(2162935679u),
					Module.smethod_34<string>(602381348u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameTimeInfo).TypeHandle), GameTimeInfo.Parser, new string[]
				{
					Module.smethod_36<string>(1166388311u),
					Module.smethod_33<string>(1942391842u),
					Module.smethod_34<string>(621305125u),
					Module.smethod_33<string>(2261785540u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameTimeRemainingInfo).TypeHandle), GameTimeRemainingInfo.Parser, new string[]
				{
					Module.smethod_33<string>(2153135195u),
					Module.smethod_36<string>(3597372371u),
					Module.smethod_36<string>(1423817952u),
					Module.smethod_33<string>(357125834u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameStatus).TypeHandle), GameStatus.Parser, new string[]
				{
					Module.smethod_33<string>(2862641106u),
					Module.smethod_37<string>(1164565617u),
					Module.smethod_34<string>(847188227u),
					Module.smethod_37<string>(700380119u),
					Module.smethod_35<string>(3273115666u),
					Module.smethod_35<string>(2881395033u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(RAFInfo).TypeHandle), RAFInfo.Parser, new string[]
				{
					Module.smethod_33<string>(3208264152u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameSessionInfo).TypeHandle), GameSessionInfo.Parser, new string[]
				{
					Module.smethod_37<string>(200386278u),
					Module.smethod_33<string>(4142240628u),
					Module.smethod_36<string>(885479598u),
					Module.smethod_36<string>(2624978747u),
					Module.smethod_35<string>(3762837287u),
					Module.smethod_36<string>(3235659646u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameSessionUpdateInfo).TypeHandle), GameSessionUpdateInfo.Parser, new string[]
				{
					Module.smethod_35<string>(3622957298u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameSessionLocation).TypeHandle), GameSessionLocation.Parser, new string[]
				{
					Module.smethod_36<string>(3380344736u),
					Module.smethod_33<string>(651702376u),
					Module.smethod_37<string>(667872528u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(CAIS).TypeHandle), CAIS.Parser, new string[]
				{
					Module.smethod_33<string>(3559032343u),
					Module.smethod_36<string>(3111175559u),
					Module.smethod_34<string>(3454896507u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountList).TypeHandle), GameAccountList.Parser, new string[]
				{
					Module.smethod_35<string>(4244548940u),
					Module.smethod_35<string>(2121056678u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountState).TypeHandle), AccountState.Parser, new string[]
				{
					Module.smethod_37<string>(3560410545u),
					Module.smethod_34<string>(1448017777u),
					Module.smethod_35<string>(4075410058u),
					Module.smethod_36<string>(3525029826u),
					Module.smethod_36<string>(182255151u),
					Module.smethod_35<string>(2466648525u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AccountStateTagged).TypeHandle), AccountStateTagged.Parser, new string[]
				{
					Module.smethod_37<string>(962121772u),
					Module.smethod_34<string>(2675333323u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountState).TypeHandle), GameAccountState.Parser, new string[]
				{
					Module.smethod_36<string>(3525029826u),
					Module.smethod_36<string>(865278595u),
					Module.smethod_35<string>(125390935u),
					Module.smethod_37<string>(2450079127u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(GameAccountStateTagged).TypeHandle), GameAccountStateTagged.Parser, new string[]
				{
					Module.smethod_37<string>(1838651123u),
					Module.smethod_34<string>(1550493979u)
				}, null, null, null),
				new GeneratedCodeInfo(AccountTypesReflection.smethod_2(typeof(AuthorizedData).TypeHandle), AuthorizedData.Parser, new string[]
				{
					Module.smethod_35<string>(874396530u),
					Module.smethod_34<string>(3895916200u)
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
