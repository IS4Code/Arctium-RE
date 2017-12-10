using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Notification.V1
{
	[DebuggerNonUserCode]
	public static class NotificationTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.descriptor;
			}
		}

		static NotificationTypesReflection()
		{
			NotificationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(NotificationTypesReflection.smethod_1(NotificationTypesReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(915210694u),
				Module.smethod_35<string>(4059596405u),
				Module.smethod_34<string>(2634503782u),
				Module.smethod_33<string>(1835459958u),
				Module.smethod_37<string>(1138217465u),
				Module.smethod_34<string>(759771542u),
				Module.smethod_33<string>(1119396710u),
				Module.smethod_33<string>(199147446u),
				Module.smethod_33<string>(1937552966u),
				Module.smethod_34<string>(3554953046u),
				Module.smethod_33<string>(3778051494u),
				Module.smethod_34<string>(2805060150u),
				Module.smethod_35<string>(3751917093u),
				Module.smethod_36<string>(1143359293u),
				Module.smethod_35<string>(4101758725u),
				Module.smethod_35<string>(1779354261u),
				Module.smethod_33<string>(2959895238u),
				Module.smethod_37<string>(3358998185u),
				Module.smethod_34<string>(3452064102u),
				Module.smethod_37<string>(261953353u)
			})), new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(NotificationTypesReflection.smethod_2(typeof(Target).TypeHandle), Target.Parser, new string[]
				{
					Module.smethod_33<string>(3259014625u),
					Module.smethod_37<string>(147837329u)
				}, null, null, null),
				new GeneratedCodeInfo(NotificationTypesReflection.smethod_2(typeof(Subscription).TypeHandle), Subscription.Parser, new string[]
				{
					Module.smethod_36<string>(2806622704u),
					Module.smethod_37<string>(583346466u),
					Module.smethod_33<string>(1021036655u)
				}, null, null, null),
				new GeneratedCodeInfo(NotificationTypesReflection.smethod_2(typeof(Notification).TypeHandle), Notification.Parser, new string[]
				{
					Module.smethod_37<string>(2453261995u),
					Module.smethod_34<string>(3840532677u),
					Module.smethod_35<string>(2172568525u),
					Module.smethod_35<string>(1418463188u),
					Module.smethod_33<string>(1890239415u),
					Module.smethod_33<string>(797178628u),
					Module.smethod_34<string>(2580771227u),
					Module.smethod_33<string>(1883682078u),
					Module.smethod_37<string>(1781268930u),
					Module.smethod_35<string>(3613170380u)
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
