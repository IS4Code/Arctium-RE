using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public static class InvitationTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.descriptor;
			}
		}

		static InvitationTypesReflection()
		{
			InvitationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(InvitationTypesReflection.smethod_1(InvitationTypesReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(1245704574u),
				Module.smethod_34<string>(1257299406u),
				Module.smethod_36<string>(3273991253u),
				Module.smethod_37<string>(760797825u),
				Module.smethod_37<string>(410197873u),
				Module.smethod_36<string>(2880337989u),
				Module.smethod_33<string>(1861087006u),
				Module.smethod_34<string>(1529356910u),
				Module.smethod_35<string>(1026175917u),
				Module.smethod_33<string>(122681486u),
				Module.smethod_33<string>(224774494u),
				Module.smethod_33<string>(1963180014u),
				Module.smethod_35<string>(2691059437u),
				Module.smethod_33<string>(2781336270u),
				Module.smethod_36<string>(1317464469u),
				Module.smethod_33<string>(326867502u),
				Module.smethod_33<string>(3701585534u),
				Module.smethod_35<string>(3698422013u),
				Module.smethod_37<string>(205720529u),
				Module.smethod_36<string>(2474945189u),
				Module.smethod_34<string>(200127486u),
				Module.smethod_33<string>(3803678542u),
				Module.smethod_36<string>(1699378197u),
				Module.smethod_35<string>(1418179869u),
				Module.smethod_33<string>(428960510u),
				Module.smethod_37<string>(1053043041u),
				Module.smethod_34<string>(2245416094u),
				Module.smethod_35<string>(3083063389u),
				Module.smethod_34<string>(1495523198u),
				Module.smethod_34<string>(1870469646u),
				Module.smethod_36<string>(2081291925u),
				Module.smethod_34<string>(1120576750u),
				Module.smethod_35<string>(2425542445u),
				Module.smethod_37<string>(556320481u),
				Module.smethod_35<string>(3643716621u)
			})), new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(Invitation).TypeHandle), Invitation.Parser, new string[]
				{
					Module.smethod_34<string>(4055669268u),
					Module.smethod_36<string>(4048185505u),
					Module.smethod_33<string>(432693463u),
					Module.smethod_33<string>(2612257700u),
					Module.smethod_34<string>(2930829924u),
					Module.smethod_33<string>(3481460460u),
					Module.smethod_37<string>(3536773725u),
					Module.smethod_37<string>(2251201273u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(InvitationSuggestion).TypeHandle), InvitationSuggestion.Parser, new string[]
				{
					Module.smethod_33<string>(4242012875u),
					Module.smethod_33<string>(1250849719u),
					Module.smethod_33<string>(816248339u),
					Module.smethod_36<string>(612867282u),
					Module.smethod_36<string>(1565059903u),
					Module.smethod_35<string>(1531273800u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(InvitationTarget).TypeHandle), InvitationTarget.Parser, new string[]
				{
					Module.smethod_36<string>(3432321208u),
					Module.smethod_33<string>(2222145487u),
					Module.smethod_37<string>(88922644u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(InvitationParams).TypeHandle), InvitationParams.Parser, new string[]
				{
					Module.smethod_33<string>(3481460460u),
					Module.smethod_33<string>(272996614u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(SendInvitationRequest).TypeHandle), SendInvitationRequest.Parser, new string[]
				{
					Module.smethod_35<string>(3084196665u),
					Module.smethod_35<string>(1657194122u),
					Module.smethod_36<string>(343698105u),
					Module.smethod_33<string>(1084595533u),
					Module.smethod_33<string>(649994153u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(SendInvitationResponse).TypeHandle), SendInvitationResponse.Parser, new string[]
				{
					Module.smethod_36<string>(2734280159u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(UpdateInvitationRequest).TypeHandle), UpdateInvitationRequest.Parser, new string[]
				{
					Module.smethod_36<string>(1709744993u),
					Module.smethod_33<string>(1410546568u),
					Module.smethod_33<string>(2548096522u)
				}, null, null, null),
				new GeneratedCodeInfo(InvitationTypesReflection.smethod_2(typeof(GenericInvitationRequest).TypeHandle), GenericInvitationRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_33<string>(3091348247u),
					Module.smethod_33<string>(1410546568u),
					Module.smethod_36<string>(2826823707u),
					Module.smethod_35<string>(789711535u),
					Module.smethod_36<string>(219214018u),
					Module.smethod_34<string>(2809429945u),
					Module.smethod_36<string>(3148134426u)
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
