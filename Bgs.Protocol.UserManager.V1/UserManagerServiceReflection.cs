using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public static class UserManagerServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.descriptor;
			}
		}

		static UserManagerServiceReflection()
		{
			UserManagerServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(UserManagerServiceReflection.smethod_1(UserManagerServiceReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(2957993024u),
				Module.smethod_37<string>(2221935492u),
				Module.smethod_37<string>(3770457908u),
				Module.smethod_37<string>(3419857956u),
				Module.smethod_34<string>(3162883371u),
				Module.smethod_36<string>(2042795248u),
				Module.smethod_35<string>(1642951136u),
				Module.smethod_36<string>(3593929232u),
				Module.smethod_35<string>(1992792768u),
				Module.smethod_34<string>(538258235u),
				Module.smethod_34<string>(913204683u),
				Module.smethod_36<string>(1255488720u),
				Module.smethod_34<string>(163311787u),
				Module.smethod_36<string>(2424708976u),
				Module.smethod_33<string>(1366057401u),
				Module.smethod_33<string>(1696343689u),
				Module.smethod_34<string>(2682272363u),
				Module.smethod_37<string>(2453468292u),
				Module.smethod_34<string>(1932379467u),
				Module.smethod_37<string>(3651390756u),
				Module.smethod_34<string>(1182486571u),
				Module.smethod_37<string>(554345924u),
				Module.smethod_33<string>(2616592953u),
				Module.smethod_34<string>(3602721627u),
				Module.smethod_34<string>(3977668075u),
				Module.smethod_37<string>(1956745732u),
				Module.smethod_34<string>(3227775179u),
				Module.smethod_36<string>(3434309072u),
				Module.smethod_35<string>(952334080u),
				Module.smethod_36<string>(308562032u),
				Module.smethod_34<string>(1727989387u),
				Module.smethod_35<string>(3274738544u),
				Module.smethod_35<string>(2617217600u),
				Module.smethod_36<string>(3028916272u),
				Module.smethod_37<string>(700468532u),
				Module.smethod_37<string>(349868580u),
				Module.smethod_33<string>(3843121241u),
				Module.smethod_36<string>(690475760u),
				Module.smethod_34<string>(3023385099u),
				Module.smethod_36<string>(2241609744u),
				Module.smethod_36<string>(678736224u),
				Module.smethod_34<string>(1148652859u),
				Module.smethod_34<string>(1523599307u),
				Module.smethod_34<string>(398759963u),
				Module.smethod_37<string>(1401668436u),
				Module.smethod_34<string>(3943834363u),
				Module.smethod_36<string>(3804483264u),
				Module.smethod_36<string>(3863180944u),
				Module.smethod_33<string>(3640347417u),
				Module.smethod_35<string>(1791047376u),
				Module.smethod_35<string>(1133526432u),
				Module.smethod_34<string>(4215891867u),
				Module.smethod_35<string>(1483368064u),
				Module.smethod_34<string>(3465998971u),
				Module.smethod_37<string>(115978100u),
				Module.smethod_35<string>(3805772528u),
				Module.smethod_33<string>(367722393u),
				Module.smethod_37<string>(4264822788u),
				Module.smethod_33<string>(1185878649u),
				Module.smethod_34<string>(1216320283u),
				Module.smethod_35<string>(518167808u),
				Module.smethod_33<string>(2106127913u),
				Module.smethod_37<string>(3914222836u),
				Module.smethod_35<string>(2840572272u),
				Module.smethod_35<string>(2183051328u),
				Module.smethod_34<string>(3261608891u),
				Module.smethod_35<string>(3498093216u),
				Module.smethod_36<string>(2288567888u),
				Module.smethod_37<string>(4206468052u),
				Module.smethod_34<string>(1761823099u)
			})), new FileDescriptor[]
			{
				UserManagerTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RoleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(SubscribeRequest).TypeHandle), SubscribeRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2714350708u),
					Module.smethod_33<string>(3239342614u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(SubscribeResponse).TypeHandle), SubscribeResponse.Parser, new string[]
				{
					Module.smethod_36<string>(2091741256u),
					Module.smethod_37<string>(2891688761u),
					Module.smethod_36<string>(1553402902u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(UnsubscribeRequest).TypeHandle), UnsubscribeRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_36<string>(3782294397u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(AddRecentPlayersRequest).TypeHandle), AddRecentPlayersRequest.Parser, new string[]
				{
					Module.smethod_35<string>(2434891972u),
					Module.smethod_35<string>(1797074111u),
					Module.smethod_33<string>(1332460824u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(AddRecentPlayersResponse).TypeHandle), AddRecentPlayersResponse.Parser, new string[]
				{
					Module.smethod_36<string>(187356014u),
					Module.smethod_36<string>(3984386962u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(ClearRecentPlayersRequest).TypeHandle), ClearRecentPlayersRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2714350708u),
					Module.smethod_36<string>(2505595523u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(ClearRecentPlayersResponse).TypeHandle), ClearRecentPlayersResponse.Parser, new string[]
				{
					Module.smethod_34<string>(3206282157u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(BlockPlayerRequest).TypeHandle), BlockPlayerRequest.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_36<string>(1978914170u),
					Module.smethod_37<string>(1839859434u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(UnblockPlayerRequest).TypeHandle), UnblockPlayerRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_33<string>(3091348247u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(BlockedPlayerAddedNotification).TypeHandle), BlockedPlayerAddedNotification.Parser, new string[]
				{
					Module.smethod_34<string>(2390316016u),
					Module.smethod_33<string>(1846560140u),
					Module.smethod_34<string>(750206468u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(BlockedPlayerRemovedNotification).TypeHandle), BlockedPlayerRemovedNotification.Parser, new string[]
				{
					Module.smethod_37<string>(2190429915u),
					Module.smethod_37<string>(965451995u),
					Module.smethod_35<string>(915065219u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(RecentPlayersAddedNotification).TypeHandle), RecentPlayersAddedNotification.Parser, new string[]
				{
					Module.smethod_37<string>(2190429915u)
				}, null, null, null),
				new GeneratedCodeInfo(UserManagerServiceReflection.smethod_2(typeof(RecentPlayersRemovedNotification).TypeHandle), RecentPlayersRemovedNotification.Parser, new string[]
				{
					Module.smethod_33<string>(1869155212u)
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
