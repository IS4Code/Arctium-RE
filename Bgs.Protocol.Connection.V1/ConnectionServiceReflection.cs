using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public static class ConnectionServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.descriptor;
			}
		}

		static ConnectionServiceReflection()
		{
			ConnectionServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(ConnectionServiceReflection.smethod_1(ConnectionServiceReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(1663710459u),
				Module.smethod_34<string>(3965533756u),
				Module.smethod_36<string>(520098707u),
				Module.smethod_35<string>(1356031147u),
				Module.smethod_36<string>(1689318963u),
				Module.smethod_33<string>(2554752536u),
				Module.smethod_34<string>(1340908620u),
				Module.smethod_36<string>(1677579427u),
				Module.smethod_33<string>(3475001800u),
				Module.smethod_34<string>(965962172u),
				Module.smethod_36<string>(902012435u),
				Module.smethod_35<string>(390830891u),
				Module.smethod_37<string>(3301173927u),
				Module.smethod_33<string>(3577094808u),
				Module.smethod_37<string>(1197574215u),
				Module.smethod_34<string>(3011250780u),
				Module.smethod_36<string>(496619635u),
				Module.smethod_34<string>(2261357884u),
				Module.smethod_36<string>(1283926163u),
				Module.smethod_35<string>(3720597931u),
				Module.smethod_35<string>(1398193467u),
				Module.smethod_35<string>(740672523u),
				Module.smethod_33<string>(406562792u),
				Module.smethod_36<string>(2441406883u),
				Module.smethod_34<string>(3181807148u),
				Module.smethod_33<string>(2963124568u),
				Module.smethod_33<string>(3065217576u),
				Module.smethod_35<string>(2755397675u),
				Module.smethod_35<string>(432993211u),
				Module.smethod_34<string>(2056967804u),
				Module.smethod_34<string>(3453864652u),
				Module.smethod_37<string>(4060728567u),
				Module.smethod_33<string>(2658257736u),
				Module.smethod_34<string>(3078918204u),
				Module.smethod_33<string>(203788968u),
				Module.smethod_37<string>(2161606199u),
				Module.smethod_34<string>(1204185964u),
				Module.smethod_37<string>(3359528663u),
				Module.smethod_33<string>(2862443752u),
				Module.smethod_34<string>(829239516u),
				Module.smethod_37<string>(3213406055u),
				Module.smethod_35<string>(3901790283u),
				Module.smethod_33<string>(1226131240u),
				Module.smethod_34<string>(3624421020u),
				Module.smethod_36<string>(543577779u),
				Module.smethod_35<string>(1271706507u),
				Module.smethod_36<string>(2094711763u),
				Module.smethod_35<string>(1621548139u)
			})), new FileDescriptor[]
			{
				ContentHandleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(ConnectRequest).TypeHandle), ConnectRequest.Parser, new string[]
				{
					Module.smethod_36<string>(262669066u),
					Module.smethod_37<string>(1139042653u),
					Module.smethod_36<string>(2042570221u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(ConnectionMeteringContentHandles).TypeHandle), ConnectionMeteringContentHandles.Parser, new string[]
				{
					Module.smethod_35<string>(3102972755u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(ConnectResponse).TypeHandle), ConnectResponse.Parser, new string[]
				{
					Module.smethod_34<string>(2190708473u),
					Module.smethod_36<string>(262669066u),
					Module.smethod_34<string>(3569094286u),
					Module.smethod_34<string>(3475357674u),
					Module.smethod_34<string>(2256781718u),
					Module.smethod_33<string>(2683074892u),
					Module.smethod_34<string>(3381621062u),
					Module.smethod_37<string>(1606528903u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(BoundService).TypeHandle), BoundService.Parser, new string[]
				{
					Module.smethod_35<string>(2551746086u),
					Module.smethod_36<string>(94729931u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(BindRequest).TypeHandle), BindRequest.Parser, new string[]
				{
					Module.smethod_36<string>(853148962u),
					Module.smethod_34<string>(624849436u),
					Module.smethod_35<string>(2782750371u),
					Module.smethod_34<string>(2791538023u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(BindResponse).TypeHandle), BindResponse.Parser, new string[]
				{
					Module.smethod_33<string>(3283930458u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(EchoRequest).TypeHandle), EchoRequest.Parser, new string[]
				{
					Module.smethod_36<string>(728664875u),
					Module.smethod_34<string>(1788098658u),
					Module.smethod_37<string>(3622537569u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(EchoResponse).TypeHandle), EchoResponse.Parser, new string[]
				{
					Module.smethod_37<string>(2979751343u),
					Module.smethod_34<string>(2069308494u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(DisconnectRequest).TypeHandle), DisconnectRequest.Parser, new string[]
				{
					Module.smethod_34<string>(3072747859u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(DisconnectNotification).TypeHandle), DisconnectNotification.Parser, new string[]
				{
					Module.smethod_37<string>(1840272028u),
					Module.smethod_35<string>(2972236010u)
				}, null, null, null),
				new GeneratedCodeInfo(ConnectionServiceReflection.smethod_2(typeof(EncryptRequest).TypeHandle), EncryptRequest.Parser, null, null, null, null)
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
