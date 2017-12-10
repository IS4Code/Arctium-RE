using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public static class AuthenticationServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.descriptor;
			}
		}

		static AuthenticationServiceReflection()
		{
			AuthenticationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(AuthenticationServiceReflection.smethod_1(AuthenticationServiceReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(1671797463u),
				Module.smethod_37<string>(2597498459u),
				Module.smethod_36<string>(2603630031u),
				Module.smethod_37<string>(3795420923u),
				Module.smethod_37<string>(1048976043u),
				Module.smethod_33<string>(1072181836u),
				Module.smethod_36<string>(265189519u),
				Module.smethod_37<string>(1896298555u),
				Module.smethod_34<string>(4056494752u),
				Module.smethod_37<string>(2100775899u),
				Module.smethod_36<string>(2985543759u),
				Module.smethod_33<string>(254025580u),
				Module.smethod_35<string>(3239813271u),
				Module.smethod_36<string>(2209976767u),
				Module.smethod_36<string>(647103247u),
				Module.smethod_35<string>(1267250439u),
				Module.smethod_34<string>(1056923168u),
				Module.smethod_34<string>(4227051120u),
				Module.smethod_36<string>(3367457487u),
				Module.smethod_35<string>(2932133959u),
				Module.smethod_35<string>(2274613015u),
				Module.smethod_33<string>(3116866380u),
				Module.smethod_34<string>(3102211776u),
				Module.smethod_35<string>(302050183u),
				Module.smethod_33<string>(1378460860u),
				Module.smethod_35<string>(651891815u),
				Module.smethod_34<string>(1602425984u),
				Module.smethod_37<string>(4292143483u),
				Module.smethod_37<string>(1545698603u),
				Module.smethod_36<string>(2973804223u),
				Module.smethod_36<string>(1410930703u),
				Module.smethod_34<string>(3272768144u),
				Module.smethod_34<string>(3647714592u),
				Module.smethod_36<string>(2638848639u),
				Module.smethod_36<string>(1075975119u),
				Module.smethod_37<string>(1808530683u),
				Module.smethod_36<string>(2245195375u),
				Module.smethod_35<string>(483242535u),
				Module.smethod_35<string>(4120688887u),
				Module.smethod_37<string>(4204375611u),
				Module.smethod_33<string>(3834341820u),
				Module.smethod_35<string>(2148126055u),
				Module.smethod_36<string>(1457888847u),
				Module.smethod_35<string>(3463167943u),
				Module.smethod_33<string>(2198029308u),
				Module.smethod_36<string>(682321855u),
				Module.smethod_37<string>(4058253003u),
				Module.smethod_35<string>(833084167u),
				Module.smethod_37<string>(961208171u),
				Module.smethod_35<string>(1182925799u),
				Module.smethod_34<string>(3715382016u),
				Module.smethod_36<string>(276929055u),
				Module.smethod_37<string>(55530923u),
				Module.smethod_36<string>(1064235583u),
				Module.smethod_33<string>(765902812u),
				Module.smethod_35<string>(4162851207u),
				Module.smethod_33<string>(1584059068u),
				Module.smethod_33<string>(1686152076u),
				Module.smethod_34<string>(715810432u),
				Module.smethod_35<string>(1532767431u),
				Module.smethod_36<string>(3390936559u),
				Module.smethod_37<string>(3503175707u),
				Module.smethod_36<string>(4178243087u),
				Module.smethod_36<string>(2615369567u),
				Module.smethod_37<string>(1954653291u),
				Module.smethod_36<string>(2926846079u),
				Module.smethod_37<string>(3824834059u),
				Module.smethod_34<string>(3408102992u),
				Module.smethod_33<string>(558892412u),
				Module.smethod_35<string>(1785741351u),
				Module.smethod_33<string>(2399390940u),
				Module.smethod_33<string>(1479141676u),
				Module.smethod_33<string>(3217547196u),
				Module.smethod_36<string>(3308759807u),
				Module.smethod_37<string>(3328111499u),
				Module.smethod_37<string>(2977511547u),
				Module.smethod_36<string>(2915106543u),
				Module.smethod_34<string>(3953605808u),
				Module.smethod_33<string>(3421733212u),
				Module.smethod_37<string>(1078389179u),
				Module.smethod_35<string>(1478062039u),
				Module.smethod_37<string>(3269756763u),
				Module.smethod_33<string>(1785420700u),
				Module.smethod_37<string>(172711931u),
				Module.smethod_33<string>(2603576956u),
				Module.smethod_34<string>(954034224u),
				Module.smethod_35<string>(3492787191u),
				Module.smethod_34<string>(204141328u),
				Module.smethod_35<string>(512861783u),
				Module.smethod_34<string>(3749215728u),
				Module.smethod_33<string>(2807762972u),
				Module.smethod_35<string>(2835266247u),
				Module.smethod_36<string>(3678933999u),
				Module.smethod_33<string>(224873171u)
			})), new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				ContentHandleTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(ModuleLoadRequest).TypeHandle), ModuleLoadRequest.Parser, new string[]
				{
					Module.smethod_34<string>(2249429936u),
					Module.smethod_37<string>(2364197399u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(ModuleNotification).TypeHandle), ModuleNotification.Parser, new string[]
				{
					Module.smethod_37<string>(2334784263u),
					Module.smethod_37<string>(552518722u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(ModuleMessageRequest).TypeHandle), ModuleMessageRequest.Parser, new string[]
				{
					Module.smethod_34<string>(2155693324u),
					Module.smethod_34<string>(1507301564u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(LogonRequest).TypeHandle), LogonRequest.Parser, new string[]
				{
					Module.smethod_37<string>(700380119u),
					Module.smethod_33<string>(519548390u),
					Module.smethod_37<string>(2831860475u),
					Module.smethod_37<string>(936421982u),
					Module.smethod_33<string>(3069454152u),
					Module.smethod_35<string>(2261786624u),
					Module.smethod_34<string>(3627815749u),
					Module.smethod_36<string>(4269413895u),
					Module.smethod_34<string>(2315503181u),
					Module.smethod_36<string>(2561855285u),
					Module.smethod_33<string>(1337704646u),
					Module.smethod_33<string>(2098257061u),
					Module.smethod_34<string>(2784186241u),
					Module.smethod_36<string>(446998546u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(LogonResult).TypeHandle), LogonResult.Parser, new string[]
				{
					Module.smethod_36<string>(1680857496u),
					Module.smethod_34<string>(750206468u),
					Module.smethod_33<string>(1846560140u),
					Module.smethod_34<string>(3653059453u),
					Module.smethod_34<string>(3993609865u),
					Module.smethod_33<string>(2068294760u),
					Module.smethod_35<string>(1558626496u),
					Module.smethod_34<string>(2361677583u),
					Module.smethod_34<string>(2267940971u),
					Module.smethod_35<string>(330252836u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(GenerateSSOTokenRequest).TypeHandle), GenerateSSOTokenRequest.Parser, new string[]
				{
					Module.smethod_34<string>(3421418748u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(GenerateSSOTokenResponse).TypeHandle), GenerateSSOTokenResponse.Parser, new string[]
				{
					Module.smethod_35<string>(2023905647u),
					Module.smethod_35<string>(1631335057u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(LogonUpdateRequest).TypeHandle), LogonUpdateRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1607588472u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(LogonQueueUpdateRequest).TypeHandle), LogonQueueUpdateRequest.Parser, new string[]
				{
					Module.smethod_37<string>(844557641u),
					Module.smethod_33<string>(2125898601u),
					Module.smethod_34<string>(327135486u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(AccountSettingsNotification).TypeHandle), AccountSettingsNotification.Parser, new string[]
				{
					Module.smethod_34<string>(2708960664u),
					Module.smethod_35<string>(861853458u),
					Module.smethod_37<string>(1341250730u),
					Module.smethod_33<string>(329889240u),
					Module.smethod_37<string>(3094309432u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(ServerStateChangeRequest).TypeHandle), ServerStateChangeRequest.Parser, new string[]
				{
					Module.smethod_36<string>(3718803416u),
					Module.smethod_36<string>(3428060496u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(VersionInfo).TypeHandle), VersionInfo.Parser, new string[]
				{
					Module.smethod_34<string>(3338222276u),
					Module.smethod_37<string>(172564576u),
					Module.smethod_37<string>(4146138759u),
					Module.smethod_34<string>(1959067768u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(VersionInfoNotification).TypeHandle), VersionInfoNotification.Parser, new string[]
				{
					Module.smethod_36<string>(840651810u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(MemModuleLoadRequest).TypeHandle), MemModuleLoadRequest.Parser, new string[]
				{
					Module.smethod_35<string>(2121056678u),
					Module.smethod_36<string>(2835900298u),
					Module.smethod_37<string>(669257665u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(MemModuleLoadResponse).TypeHandle), MemModuleLoadResponse.Parser, new string[]
				{
					Module.smethod_35<string>(874396530u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(SelectGameAccountRequest).TypeHandle), SelectGameAccountRequest.Parser, new string[]
				{
					Module.smethod_36<string>(1993931775u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(GameAccountSelectedRequest).TypeHandle), GameAccountSelectedRequest.Parser, new string[]
				{
					Module.smethod_37<string>(552518722u),
					Module.smethod_33<string>(1846560140u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(GenerateWebCredentialsRequest).TypeHandle), GenerateWebCredentialsRequest.Parser, new string[]
				{
					Module.smethod_34<string>(3421418748u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(GenerateWebCredentialsResponse).TypeHandle), GenerateWebCredentialsResponse.Parser, new string[]
				{
					Module.smethod_33<string>(2279038113u)
				}, null, null, null),
				new GeneratedCodeInfo(AuthenticationServiceReflection.smethod_2(typeof(VerifyWebCredentialsRequest).TypeHandle), VerifyWebCredentialsRequest.Parser, new string[]
				{
					Module.smethod_36<string>(499140088u)
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
