using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public static class WrappersReflection
	{
		private static FileDescriptor descriptor;

		internal const int WrapperValueFieldNumber = 1;

		public static FileDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.descriptor;
			}
		}

		static WrappersReflection()
		{
			WrappersReflection.descriptor = FileDescriptor.FromGeneratedCode(WrappersReflection.smethod_1(WrappersReflection.smethod_0(new string[]
			{
				Module.smethod_33<string>(3498100495u),
				Module.smethod_36<string>(82315314u),
				Module.smethod_33<string>(21289455u),
				Module.smethod_33<string>(123382463u),
				Module.smethod_36<string>(3601715618u),
				Module.smethod_34<string>(738335309u),
				Module.smethod_36<string>(475968578u),
				Module.smethod_33<string>(3193233663u),
				Module.smethod_33<string>(636671887u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(DoubleValue).TypeHandle), DoubleValue.Parser, new string[]
				{
					Module.smethod_33<string>(3388245550u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(FloatValue).TypeHandle), FloatValue.Parser, new string[]
				{
					Module.smethod_35<string>(1515047581u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(Int64Value).TypeHandle), Int64Value.Parser, new string[]
				{
					Module.smethod_36<string>(994248421u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(UInt64Value).TypeHandle), UInt64Value.Parser, new string[]
				{
					Module.smethod_35<string>(1515047581u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(Int32Value).TypeHandle), Int32Value.Parser, new string[]
				{
					Module.smethod_33<string>(3388245550u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(UInt32Value).TypeHandle), UInt32Value.Parser, new string[]
				{
					Module.smethod_37<string>(1696359745u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(BoolValue).TypeHandle), BoolValue.Parser, new string[]
				{
					Module.smethod_34<string>(1800026606u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(StringValue).TypeHandle), StringValue.Parser, new string[]
				{
					Module.smethod_33<string>(3388245550u)
				}, null, null, null),
				new GeneratedCodeInfo(WrappersReflection.smethod_2(typeof(BytesValue).TypeHandle), BytesValue.Parser, new string[]
				{
					Module.smethod_35<string>(1515047581u)
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

		static System.Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
