using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Report.V1
{
	[DebuggerNonUserCode]
	public static class ReportServiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.descriptor;
			}
		}

		static ReportServiceReflection()
		{
			ReportServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(ReportServiceReflection.smethod_1(ReportServiceReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(2533459598u),
				Module.smethod_33<string>(838843411u),
				Module.smethod_34<string>(435782033u),
				Module.smethod_36<string>(1309618126u),
				Module.smethod_33<string>(1759092675u),
				Module.smethod_34<string>(60835585u),
				Module.smethod_33<string>(3599591203u),
				Module.smethod_36<string>(4029972366u),
				Module.smethod_34<string>(2481070641u),
				Module.smethod_37<string>(3300849746u),
				Module.smethod_33<string>(1963278691u),
				Module.smethod_37<string>(203804914u),
				Module.smethod_35<string>(3233142862u),
				Module.smethod_37<string>(1401727378u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ReportServiceReflection.smethod_2(typeof(Report).TypeHandle), Report.Parser, new string[]
				{
					Module.smethod_37<string>(2775008760u),
					Module.smethod_33<string>(4205493237u),
					Module.smethod_36<string>(3387350928u),
					Module.smethod_37<string>(4148231200u),
					Module.smethod_33<string>(218315834u),
					Module.smethod_34<string>(3710393108u)
				}, null, null, null),
				new GeneratedCodeInfo(ReportServiceReflection.smethod_2(typeof(SendReportRequest).TypeHandle), SendReportRequest.Parser, new string[]
				{
					Module.smethod_33<string>(2282672389u)
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
