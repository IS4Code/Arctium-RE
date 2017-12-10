using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public static class ChannelServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.descriptor;
			}
		}

		static ChannelServiceReflection()
		{
			ChannelServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(ChannelServiceReflection.smethod_1(ChannelServiceReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(3524312636u),
				Module.smethod_34<string>(2229118351u),
				Module.smethod_35<string>(544387228u),
				Module.smethod_35<string>(4181833580u),
				Module.smethod_33<string>(2944864749u),
				Module.smethod_37<string>(1606499432u),
				Module.smethod_33<string>(3763021005u),
				Module.smethod_36<string>(2745794668u),
				Module.smethod_36<string>(325177404u),
				Module.smethod_36<string>(3057271180u),
				Module.smethod_35<string>(447519516u),
				Module.smethod_33<string>(3453917597u),
				Module.smethod_35<string>(797361148u),
				Module.smethod_36<string>(718830668u),
				Module.smethod_34<string>(3421625119u),
				Module.smethod_33<string>(1817605085u),
				Module.smethod_34<string>(2671732223u),
				Module.smethod_37<string>(4177880104u),
				Module.smethod_35<string>(3777286556u),
				Module.smethod_36<string>(313437868u),
				Module.smethod_35<string>(4127128188u),
				Module.smethod_34<string>(1546892879u),
				Module.smethod_37<string>(1928157784u),
				Module.smethod_36<string>(2269964652u),
				Module.smethod_35<string>(1497044412u),
				Module.smethod_36<string>(3821098636u),
				Module.smethod_34<string>(3217235039u),
				Module.smethod_36<string>(695351596u),
				Module.smethod_36<string>(3045531644u),
				Module.smethod_36<string>(1482658124u),
				Module.smethod_36<string>(4214751900u),
				Module.smethod_34<string>(2092395695u),
				Module.smethod_33<string>(3964382637u),
				Module.smethod_34<string>(1342502799u),
				Module.smethod_37<string>(525757976u),
				Module.smethod_34<string>(592609903u),
				Module.smethod_35<string>(2196727676u),
				Module.smethod_37<string>(3272202856u),
				Module.smethod_33<string>(3146226381u),
				Module.smethod_37<string>(175158024u),
				Module.smethod_36<string>(3092489788u),
				Module.smethod_36<string>(1529616268u),
				Module.smethod_37<string>(2337112472u),
				Module.smethod_37<string>(3885634888u),
				Module.smethod_36<string>(754049276u),
				Module.smethod_37<string>(788590056u),
				Module.smethod_34<string>(2535009567u),
				Module.smethod_35<string>(1020715820u),
				Module.smethod_37<string>(642467448u),
				Module.smethod_34<string>(2160063119u),
				Module.smethod_35<string>(3343120284u),
				Module.smethod_35<string>(2685599340u),
				Module.smethod_34<string>(285330879u),
				Module.smethod_37<string>(291867496u),
				Module.smethod_34<string>(3830405279u),
				Module.smethod_35<string>(55515564u),
				Module.smethod_37<string>(2132635128u),
				Module.smethod_36<string>(2293443724u),
				Module.smethod_33<string>(3965794829u),
				Module.smethod_36<string>(3462663980u),
				Module.smethod_34<string>(1580726591u),
				Module.smethod_33<string>(3249731581u),
				Module.smethod_34<string>(830833695u),
				Module.smethod_37<string>(2979957640u),
				Module.smethod_37<string>(1635912568u),
				Module.smethod_34<string>(455887247u),
				Module.smethod_33<string>(693169805u),
				Module.smethod_36<string>(3844577708u),
				Module.smethod_34<string>(2876122303u),
				Module.smethod_36<string>(336916940u),
				Module.smethod_36<string>(3069010716u),
				Module.smethod_36<string>(1506137196u),
				Module.smethod_34<string>(1100115583u),
				Module.smethod_36<string>(177296780u),
				Module.smethod_36<string>(2909390556u),
				Module.smethod_37<string>(815645512u),
				Module.smethod_37<string>(465045560u),
				Module.smethod_37<string>(2013567976u),
				Module.smethod_35<string>(3615591004u),
				Module.smethod_36<string>(3303043820u),
				Module.smethod_36<string>(2122084028u),
				Module.smethod_35<string>(3307911692u),
				Module.smethod_37<string>(3065367832u),
				Module.smethod_36<string>(1728430764u),
				Module.smethod_36<string>(4078610812u),
				Module.smethod_34<string>(1270671951u),
				Module.smethod_35<string>(2650390748u),
				Module.smethod_36<string>(3684957548u),
				Module.smethod_35<string>(3000232380u),
				Module.smethod_37<string>(611168168u),
				Module.smethod_36<string>(3673218012u),
				Module.smethod_35<string>(3657753324u),
				Module.smethod_34<string>(2191121215u),
				Module.smethod_37<string>(3007013096u),
				Module.smethod_36<string>(1334777500u),
				Module.smethod_37<string>(4204935560u),
				Module.smethod_36<string>(2885911484u),
				Module.smethod_37<string>(114445608u),
				Module.smethod_36<string>(4055131740u)
			})), new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				ChannelTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(AddMemberRequest).TypeHandle), AddMemberRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_33<string>(1041715912u),
					Module.smethod_35<string>(2692553068u),
					Module.smethod_36<string>(3782294397u),
					Module.smethod_36<string>(3175281664u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(RemoveMemberRequest).TypeHandle), RemoveMemberRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_35<string>(873829892u),
					Module.smethod_33<string>(3909504503u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(UnsubscribeMemberRequest).TypeHandle), UnsubscribeMemberRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_34<string>(503862199u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(SendMessageRequest).TypeHandle), SendMessageRequest.Parser, new string[]
				{
					Module.smethod_37<string>(3916609987u),
					Module.smethod_33<string>(2780121432u),
					Module.smethod_35<string>(3475994334u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(UpdateChannelStateRequest).TypeHandle), UpdateChannelStateRequest.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_36<string>(1230494416u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(UpdateMemberStateRequest).TypeHandle), UpdateMemberStateRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2714350708u),
					Module.smethod_35<string>(314309936u),
					Module.smethod_36<string>(3476391380u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(DissolveRequest).TypeHandle), DissolveRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_33<string>(3909504503u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(SetRolesRequest).TypeHandle), SetRolesRequest.Parser, new string[]
				{
					Module.smethod_36<string>(2537453527u),
					Module.smethod_33<string>(789209099u),
					Module.smethod_36<string>(1126211332u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(JoinNotification).TypeHandle), JoinNotification.Parser, new string[]
				{
					Module.smethod_33<string>(2990864785u),
					Module.smethod_34<string>(1385901585u),
					Module.smethod_34<string>(2764287398u),
					Module.smethod_35<string>(4035437254u),
					Module.smethod_34<string>(1323785393u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(MemberAddedNotification).TypeHandle), MemberAddedNotification.Parser, new string[]
				{
					Module.smethod_36<string>(3817903102u),
					Module.smethod_35<string>(4035437254u),
					Module.smethod_35<string>(409323662u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(LeaveNotification).TypeHandle), LeaveNotification.Parser, new string[]
				{
					Module.smethod_34<string>(1899727192u),
					Module.smethod_33<string>(3323373157u),
					Module.smethod_33<string>(3909504503u),
					Module.smethod_33<string>(4242012875u),
					Module.smethod_36<string>(1133525086u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(MemberRemovedNotification).TypeHandle), MemberRemovedNotification.Parser, new string[]
				{
					Module.smethod_33<string>(2714350708u),
					Module.smethod_36<string>(1126211332u),
					Module.smethod_36<string>(3148134426u),
					Module.smethod_34<string>(14248441u),
					Module.smethod_35<string>(409323662u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(SendMessageNotification).TypeHandle), SendMessageNotification.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_36<string>(3785962563u),
					Module.smethod_34<string>(2510740929u),
					Module.smethod_34<string>(215450163u),
					Module.smethod_34<string>(14248441u),
					Module.smethod_34<string>(1323785393u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(UpdateChannelStateNotification).TypeHandle), UpdateChannelStateNotification.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_33<string>(2121662025u),
					Module.smethod_34<string>(14248441u),
					Module.smethod_35<string>(409323662u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelServiceReflection.smethod_2(typeof(UpdateMemberStateNotification).TypeHandle), UpdateMemberStateNotification.Parser, new string[]
				{
					Module.smethod_35<string>(1797074111u),
					Module.smethod_35<string>(314309936u),
					Module.smethod_33<string>(3425466165u),
					Module.smethod_35<string>(4035437254u),
					Module.smethod_37<string>(583346466u)
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
