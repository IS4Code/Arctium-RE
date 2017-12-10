using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public static class FriendsServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.descriptor;
			}
		}

		static FriendsServiceReflection()
		{
			FriendsServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(FriendsServiceReflection.smethod_1(FriendsServiceReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(1791287016u),
				Module.smethod_35<string>(2893294431u),
				Module.smethod_36<string>(1108140685u),
				Module.smethod_36<string>(1320517511u),
				Module.smethod_37<string>(2863395523u),
				Module.smethod_36<string>(2871651495u),
				Module.smethod_33<string>(887974100u),
				Module.smethod_35<string>(2235773487u),
				Module.smethod_36<string>(2477998231u),
				Module.smethod_36<string>(533210983u),
				Module.smethod_37<string>(1168750499u),
				Module.smethod_36<string>(1702431239u),
				Module.smethod_33<string>(69817844u),
				Module.smethod_34<string>(4108633128u),
				Module.smethod_37<string>(584260067u),
				Module.smethod_34<string>(3358740232u),
				Module.smethod_35<string>(4039687039u),
				Module.smethod_37<string>(1431582579u),
				Module.smethod_33<string>(685200276u),
				Module.smethod_33<string>(4059918308u),
				Module.smethod_36<string>(1761128919u),
				Module.smethod_34<string>(1109061544u),
				Module.smethod_35<string>(103137981u),
				Module.smethod_37<string>(87537507u),
				Module.smethod_33<string>(2423605796u),
				Module.smethod_37<string>(1285459971u),
				Module.smethod_37<string>(934860019u),
				Module.smethod_35<string>(3424328415u),
				Module.smethod_33<string>(787293284u),
				Module.smethod_34<string>(3529296600u),
				Module.smethod_33<string>(2627791812u),
				Module.smethod_37<string>(1577705187u),
				Module.smethod_36<string>(2131303111u),
				Module.smethod_37<string>(2775627651u),
				Module.smethod_33<string>(991479300u),
				Module.smethod_35<string>(2459128159u),
				Module.smethod_35<string>(136723695u),
				Module.smethod_35<string>(3774170047u),
				Module.smethod_35<string>(486565327u),
				Module.smethod_37<string>(1080982627u),
				Module.smethod_35<string>(1801607215u),
				Module.smethod_37<string>(2278905091u),
				Module.smethod_34<string>(2200067176u),
				Module.smethod_34<string>(2575013624u),
				Module.smethod_33<string>(2831977828u),
				Module.smethod_37<string>(379782723u),
				Module.smethod_37<string>(701441075u),
				Module.smethod_36<string>(3218346615u),
				Module.smethod_34<string>(2472124680u),
				Module.smethod_36<string>(92599575u),
				Module.smethod_37<string>(3097286003u),
				Module.smethod_37<string>(350841123u),
				Module.smethod_37<string>(241171u),
				Module.smethod_37<string>(1548763587u),
				Module.smethod_34<string>(222445992u),
				Module.smethod_36<string>(3600260343u),
				Module.smethod_37<string>(1402640979u),
				Module.smethod_34<string>(4142466840u),
				Module.smethod_37<string>(2600563443u),
				Module.smethod_36<string>(1261819831u),
				Module.smethod_36<string>(3993913607u),
				Module.smethod_34<string>(2642681048u),
				Module.smethod_35<string>(2754264399u),
				Module.smethod_33<string>(3749402708u),
				Module.smethod_33<string>(2829153444u),
				Module.smethod_36<string>(856427031u),
				Module.smethod_35<string>(124180623u),
				Module.smethod_36<string>(1643733559u),
				Module.smethod_36<string>(80860039u),
				Module.smethod_37<string>(2542208707u),
				Module.smethod_36<string>(1631994023u),
				Module.smethod_36<string>(69120503u),
				Module.smethod_35<string>(3104106031u),
				Module.smethod_37<string>(3944608515u),
				Module.smethod_35<string>(3453947663u),
				Module.smethod_35<string>(2796426719u),
				Module.smethod_37<string>(496963731u),
				Module.smethod_33<string>(3953588724u),
				Module.smethod_37<string>(3009518131u),
				Module.smethod_34<string>(2710348472u),
				Module.smethod_36<string>(127818183u),
				Module.smethod_37<string>(1460995715u),
				Module.smethod_35<string>(1620414863u),
				Module.smethod_33<string>(274003860u),
				Module.smethod_37<string>(2308318227u),
				Module.smethod_34<string>(460669784u),
				Module.smethod_35<string>(3285298383u),
				Module.smethod_37<string>(4061317987u),
				Module.smethod_36<string>(509731911u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				FriendsTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				RoleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(SubscribeRequest).TypeHandle), SubscribeRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_37<string>(1316110889u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(SubscribeResponse).TypeHandle), SubscribeResponse.Parser, new string[]
				{
					Module.smethod_36<string>(4121675763u),
					Module.smethod_34<string>(3255851288u),
					Module.smethod_34<string>(4165554041u),
					Module.smethod_36<string>(1553402902u),
					Module.smethod_35<string>(39572664u),
					Module.smethod_35<string>(655214607u),
					Module.smethod_33<string>(3526956873u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(UnsubscribeRequest).TypeHandle), UnsubscribeRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_33<string>(3239342614u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(GenericFriendRequest).TypeHandle), GenericFriendRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_37<string>(2309644422u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(GenericFriendResponse).TypeHandle), GenericFriendResponse.Parser, new string[]
				{
					Module.smethod_37<string>(204630102u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(AssignRoleRequest).TypeHandle), AssignRoleRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_35<string>(1657194122u),
					Module.smethod_34<string>(4237384889u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(ViewFriendsRequest).TypeHandle), ViewFriendsRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2714350708u),
					Module.smethod_36<string>(1978914170u),
					Module.smethod_36<string>(1553402902u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(ViewFriendsResponse).TypeHandle), ViewFriendsResponse.Parser, new string[]
				{
					Module.smethod_37<string>(1285666268u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(UpdateFriendStateRequest).TypeHandle), UpdateFriendStateRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_34<string>(3840532677u),
					Module.smethod_33<string>(4205493237u),
					Module.smethod_37<string>(1665502530u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(FriendNotification).TypeHandle), FriendNotification.Parser, new string[]
				{
					Module.smethod_33<string>(649994153u),
					Module.smethod_37<string>(965451995u),
					Module.smethod_35<string>(759165294u),
					Module.smethod_33<string>(542756000u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(UpdateFriendStateNotification).TypeHandle), UpdateFriendStateNotification.Parser, new string[]
				{
					Module.smethod_36<string>(417188363u),
					Module.smethod_33<string>(1846560140u),
					Module.smethod_34<string>(573892497u),
					Module.smethod_36<string>(4043002107u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsServiceReflection.smethod_2(typeof(InvitationNotification).TypeHandle), InvitationNotification.Parser, new string[]
				{
					Module.smethod_37<string>(3741310011u),
					Module.smethod_36<string>(1993931775u),
					Module.smethod_36<string>(3148134426u),
					Module.smethod_36<string>(1920831614u),
					Module.smethod_37<string>(1053101983u)
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
