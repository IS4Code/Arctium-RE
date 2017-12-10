using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public static class FriendsTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.descriptor;
			}
		}

		static FriendsTypesReflection()
		{
			FriendsTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(FriendsTypesReflection.smethod_1(FriendsTypesReflection.smethod_0(new string[]
			{
				Module.smethod_36<string>(686357540u),
				Module.smethod_35<string>(1452615540u),
				Module.smethod_34<string>(435782033u),
				Module.smethod_36<string>(1855577796u),
				Module.smethod_36<string>(674618004u),
				Module.smethod_36<string>(3406711780u),
				Module.smethod_36<string>(1843838260u),
				Module.smethod_33<string>(1456042981u),
				Module.smethod_34<string>(2516704903u),
				Module.smethod_35<string>(2809819748u),
				Module.smethod_34<string>(1766812007u),
				Module.smethod_37<string>(3710806448u),
				Module.smethod_33<string>(4216790773u),
				Module.smethod_34<string>(1391865559u),
				Module.smethod_35<string>(2152298804u),
				Module.smethod_34<string>(641972663u),
				Module.smethod_36<string>(3013058516u),
				Module.smethod_33<string>(23916485u),
				Module.smethod_36<string>(4182278772u),
				Module.smethod_35<string>(3159661380u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(FriendsTypesReflection.smethod_2(typeof(Friend).TypeHandle), Friend.Parser, new string[]
				{
					Module.smethod_35<string>(915065219u),
					Module.smethod_36<string>(3548343828u),
					Module.smethod_36<string>(1553402902u),
					Module.smethod_34<string>(346621587u),
					Module.smethod_35<string>(2739738094u),
					Module.smethod_37<string>(1110425234u),
					Module.smethod_34<string>(27976939u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsTypesReflection.smethod_2(typeof(FriendInvitation).TypeHandle), FriendInvitation.Parser, new string[]
				{
					Module.smethod_34<string>(2052391638u),
					Module.smethod_33<string>(789209099u),
					Module.smethod_33<string>(1091251547u)
				}, null, null, null),
				new GeneratedCodeInfo(FriendsTypesReflection.smethod_2(typeof(FriendInvitationParams).TypeHandle), FriendInvitationParams.Parser, new string[]
				{
					Module.smethod_33<string>(1743153617u),
					Module.smethod_33<string>(1883682078u),
					Module.smethod_37<string>(700822184u),
					Module.smethod_33<string>(2721006722u),
					Module.smethod_33<string>(4133461207u),
					Module.smethod_36<string>(1553402902u),
					Module.smethod_35<string>(3874154268u),
					Module.smethod_34<string>(3684323920u)
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
