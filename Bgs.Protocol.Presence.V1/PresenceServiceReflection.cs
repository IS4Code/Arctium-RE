using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public static class PresenceServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.descriptor;
			}
		}

		static PresenceServiceReflection()
		{
			PresenceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(PresenceServiceReflection.smethod_1(PresenceServiceReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(1358581018u),
				Module.smethod_37<string>(1431022630u),
				Module.smethod_37<string>(86977558u),
				Module.smethod_37<string>(1635499974u),
				Module.smethod_33<string>(2602066087u),
				Module.smethod_35<string>(2365943594u),
				Module.smethod_36<string>(3335209386u),
				Module.smethod_33<string>(1886002839u),
				Module.smethod_34<string>(3665812885u),
				Module.smethod_37<string>(934300070u),
				Module.smethod_33<string>(4039841351u),
				Module.smethod_34<string>(20625157u),
				Module.smethod_37<string>(3738628150u),
				Module.smethod_33<string>(2301435831u),
				Module.smethod_33<string>(2403528839u),
				Module.smethod_36<string>(914592122u),
				Module.smethod_37<string>(1839505782u),
				Module.smethod_33<string>(665123319u),
				Module.smethod_33<string>(767216327u),
				Module.smethod_35<string>(4283801034u),
				Module.smethod_35<string>(1961396570u),
				Module.smethod_33<string>(3323778103u),
				Module.smethod_34<string>(3736255925u),
				Module.smethod_35<string>(1653717258u),
				Module.smethod_34<string>(2986363029u),
				Module.smethod_37<string>(2891305638u),
				Module.smethod_36<string>(1284766314u),
				Module.smethod_33<string>(3527964119u),
				Module.smethod_35<string>(996196314u),
				Module.smethod_35<string>(338675370u),
				Module.smethod_34<string>(736684341u),
				Module.smethod_37<string>(3183550854u),
				Module.smethod_37<string>(2832950902u),
				Module.smethod_35<string>(2003558890u),
				Module.smethod_36<string>(1666680042u),
				Module.smethod_35<string>(2353400522u)
			})), new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				PresenceTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(SubscribeRequest).TypeHandle), SubscribeRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_34<string>(3169466458u),
					Module.smethod_37<string>(1316110889u),
					Module.smethod_37<string>(700380119u),
					Module.smethod_37<string>(1751855794u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(SubscribeNotificationRequest).TypeHandle), SubscribeNotificationRequest.Parser, new string[]
				{
					Module.smethod_37<string>(2453674589u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(UnsubscribeRequest).TypeHandle), UnsubscribeRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_36<string>(1294600521u),
					Module.smethod_35<string>(4063073269u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(UpdateRequest).TypeHandle), UpdateRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1666543649u),
					Module.smethod_34<string>(2594499725u),
					Module.smethod_37<string>(1722648955u),
					Module.smethod_34<string>(1899727192u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(QueryRequest).TypeHandle), QueryRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1666543649u),
					Module.smethod_34<string>(2781972949u),
					Module.smethod_37<string>(3916609987u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(QueryResponse).TypeHandle), QueryResponse.Parser, new string[]
				{
					Module.smethod_33<string>(3778357763u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceServiceReflection.smethod_2(typeof(OwnershipRequest).TypeHandle), OwnershipRequest.Parser, new string[]
				{
					Module.smethod_33<string>(3081156634u),
					Module.smethod_33<string>(2978155057u)
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
