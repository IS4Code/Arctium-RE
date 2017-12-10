using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal static class DescriptorReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.descriptor;
			}
		}

		static DescriptorReflection()
		{
			DescriptorReflection.descriptor = FileDescriptor.FromGeneratedCode(DescriptorReflection.smethod_1(DescriptorReflection.smethod_0(new string[]
			{
				Module.smethod_36<string>(1133750113u),
				Module.smethod_36<string>(3865843889u),
				Module.smethod_33<string>(4011389919u),
				Module.smethod_37<string>(147719445u),
				Module.smethod_35<string>(2144082553u),
				Module.smethod_37<string>(1345641909u),
				Module.smethod_35<string>(3459124441u),
				Module.smethod_33<string>(551634098u),
				Module.smethod_36<string>(1515663841u),
				Module.smethod_34<string>(3053824082u),
				Module.smethod_33<string>(3108195874u),
				Module.smethod_34<string>(2303931186u),
				Module.smethod_36<string>(4236018081u),
				Module.smethod_34<string>(2135232157u),
				Module.smethod_33<string>(1556921151u),
				Module.smethod_36<string>(928319522u),
				Module.smethod_35<string>(4052590466u),
				Module.smethod_35<string>(3395069522u),
				Module.smethod_36<string>(916579986u),
				Module.smethod_33<string>(1659014159u),
				Module.smethod_33<string>(738764895u),
				Module.smethod_37<string>(347216190u),
				Module.smethod_36<string>(2873106770u),
				Module.smethod_33<string>(22701647u),
				Module.smethod_34<string>(1555895629u),
				Module.smethod_37<string>(2743061118u),
				Module.smethod_36<string>(1298493714u),
				Module.smethod_33<string>(2681356431u),
				Module.smethod_33<string>(1761107167u),
				Module.smethod_34<string>(431056285u),
				Module.smethod_37<string>(1486783918u),
				Module.smethod_33<string>(1045043919u),
				Module.smethod_35<string>(2122189954u),
				Module.smethod_36<string>(2861367234u),
				Module.smethod_33<string>(1965293183u),
				Module.smethod_36<string>(117533922u),
				Module.smethod_37<string>(4087106190u),
				Module.smethod_36<string>(1286754178u),
				Module.smethod_36<string>(3636934226u),
				Module.smethod_36<string>(2074060706u),
				Module.smethod_36<string>(511187186u),
				Module.smethod_35<string>(499468754u),
				Module.smethod_37<string>(4058164590u),
				Module.smethod_36<string>(3554757474u),
				Module.smethod_35<string>(3690205762u),
				Module.smethod_33<string>(838033519u),
				Module.smethod_33<string>(940126527u),
				Module.smethod_33<string>(2678532047u),
				Module.smethod_35<string>(1060121986u),
				Module.smethod_35<string>(402601042u),
				Module.smethod_35<string>(1409963618u),
				Module.smethod_33<string>(1042219535u),
				Module.smethod_35<string>(2725005506u),
				Module.smethod_35<string>(2067484562u),
				Module.smethod_37<string>(1662319662u),
				Module.smethod_33<string>(3700874319u),
				Module.smethod_37<string>(2860242126u),
				Module.smethod_37<string>(113797246u),
				Module.smethod_33<string>(326156287u),
				Module.smethod_34<string>(294333629u),
				Module.smethod_36<string>(2755711410u),
				Module.smethod_33<string>(2882718063u),
				Module.smethod_35<string>(2109646882u),
				Module.smethod_37<string>(406042462u),
				Module.smethod_36<string>(417270898u),
				Module.smethod_34<string>(2339622237u),
				Module.smethod_35<string>(3774530402u),
				Module.smethod_33<string>(3086904079u),
				Module.smethod_37<string>(1457842318u),
				Module.smethod_37<string>(3006364734u),
				Module.smethod_35<string>(1144446626u),
				Module.smethod_35<string>(486925682u),
				Module.smethod_33<string>(530342303u),
				Module.smethod_36<string>(3531278402u),
				Module.smethod_37<string>(2071274350u),
				Module.smethod_37<string>(3619796766u),
				Module.smethod_36<string>(464229042u),
				Module.smethod_35<string>(2598518546u),
				Module.smethod_34<string>(3532129005u),
				Module.smethod_34<string>(3907075453u),
				Module.smethod_36<string>(2420755826u),
				Module.smethod_35<string>(4263402066u),
				Module.smethod_37<string>(1574551790u),
				Module.smethod_34<string>(2407289661u),
				Module.smethod_36<string>(846142770u),
				Module.smethod_36<string>(3578236546u),
				Module.smethod_34<string>(532557421u),
				Module.smethod_34<string>(907503869u),
				Module.smethod_36<string>(2802669554u),
				Module.smethod_37<string>(2421874302u),
				Module.smethod_36<string>(58836242u),
				Module.smethod_36<string>(2790930018u),
				Module.smethod_34<string>(2577846029u),
				Module.smethod_37<string>(1516197054u),
				Module.smethod_35<string>(1675480610u),
				Module.smethod_37<string>(2714119518u),
				Module.smethod_37<string>(2363519566u),
				Module.smethod_35<string>(2333001554u),
				Module.smethod_35<string>(3340364130u),
				Module.smethod_37<string>(4116519326u),
				Module.smethod_34<string>(3873241741u),
				Module.smethod_36<string>(47096706u),
				Module.smethod_34<string>(3123348845u),
				Module.smethod_35<string>(52759410u),
				Module.smethod_37<string>(1866797006u),
				Module.smethod_33<string>(2474346031u),
				Module.smethod_37<string>(726757742u),
				Module.smethod_34<string>(3023235517u),
				Module.smethod_35<string>(263571010u),
				Module.smethod_33<string>(2071622767u),
				Module.smethod_35<string>(613412642u),
				Module.smethod_33<string>(3912121295u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FileDescriptorSet).TypeHandle), FileDescriptorSet.Parser, new string[]
				{
					Module.smethod_35<string>(1542966915u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FileDescriptorProto).TypeHandle), FileDescriptorProto.Parser, new string[]
				{
					Module.smethod_36<string>(2649665489u),
					Module.smethod_33<string>(3068851852u),
					Module.smethod_37<string>(3829225238u),
					Module.smethod_33<string>(2960201507u),
					Module.smethod_37<string>(2952695887u),
					Module.smethod_36<string>(1697472868u),
					Module.smethod_36<string>(2380496312u),
					Module.smethod_34<string>(4181851784u),
					Module.smethod_35<string>(647564994u),
					Module.smethod_34<string>(796587241u),
					Module.smethod_35<string>(1822726893u),
					Module.smethod_35<string>(1485711652u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(DescriptorProto).TypeHandle), DescriptorProto.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_33<string>(3778357763u),
					Module.smethod_37<string>(3653925262u),
					Module.smethod_37<string>(3420182137u),
					Module.smethod_36<string>(2380496312u),
					Module.smethod_34<string>(2268709666u),
					Module.smethod_34<string>(1452743525u),
					Module.smethod_35<string>(1556926582u),
					Module.smethod_34<string>(3905274903u),
					Module.smethod_37<string>(1427987117u)
				}, null, null, new GeneratedCodeInfo[]
				{
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(DescriptorProto.Types.ExtensionRange).TypeHandle), DescriptorProto.Types.ExtensionRange.Parser, new string[]
					{
						Module.smethod_37<string>(3741575250u),
						Module.smethod_35<string>(3991291701u)
					}, null, null, null),
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(DescriptorProto.Types.ReservedRange).TypeHandle), DescriptorProto.Types.ReservedRange.Parser, new string[]
					{
						Module.smethod_37<string>(3741575250u),
						Module.smethod_34<string>(1237606934u)
					}, null, null, null)
				}),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FieldDescriptorProto).TypeHandle), FieldDescriptorProto.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_36<string>(652736699u),
					Module.smethod_37<string>(2017752858u),
					Module.smethod_34<string>(1425080158u),
					Module.smethod_36<string>(3581657107u),
					Module.smethod_35<string>(88045038u),
					Module.smethod_37<string>(323137305u),
					Module.smethod_34<string>(1518816770u),
					Module.smethod_34<string>(2078311244u),
					Module.smethod_37<string>(819830394u)
				}, null, new Type[]
				{
					DescriptorReflection.smethod_2(typeof(FieldDescriptorProto.Types.Type).TypeHandle),
					DescriptorReflection.smethod_2(typeof(FieldDescriptorProto.Types.Label).TypeHandle)
				}, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(OneofDescriptorProto).TypeHandle), OneofDescriptorProto.Parser, new string[]
				{
					Module.smethod_34<string>(2643656114u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumDescriptorProto).TypeHandle), EnumDescriptorProto.Parser, new string[]
				{
					Module.smethod_35<string>(3235769769u),
					Module.smethod_33<string>(3388245550u),
					Module.smethod_35<string>(1556926582u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumValueDescriptorProto).TypeHandle), EnumValueDescriptorProto.Parser, new string[]
				{
					Module.smethod_33<string>(1982348402u),
					Module.smethod_34<string>(3338222276u),
					Module.smethod_34<string>(796587241u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(ServiceDescriptorProto).TypeHandle), ServiceDescriptorProto.Parser, new string[]
				{
					Module.smethod_35<string>(3235769769u),
					Module.smethod_35<string>(2032688536u),
					Module.smethod_33<string>(2909155003u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(MethodDescriptorProto).TypeHandle), MethodDescriptorProto.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_37<string>(3537068435u),
					Module.smethod_36<string>(1821956955u),
					Module.smethod_36<string>(1842157958u),
					Module.smethod_33<string>(2883221686u),
					Module.smethod_34<string>(304873769u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FileOptions).TypeHandle), FileOptions.Parser, new string[]
				{
					Module.smethod_34<string>(2869539216u),
					Module.smethod_33<string>(1816094216u),
					Module.smethod_35<string>(353845349u),
					Module.smethod_37<string>(2163845995u),
					Module.smethod_36<string>(2690067495u),
					Module.smethod_37<string>(3624777365u),
					Module.smethod_35<string>(3837452045u),
					Module.smethod_35<string>(451846337u),
					Module.smethod_36<string>(1810217419u),
					Module.smethod_36<string>(3714602661u),
					Module.smethod_35<string>(983446959u),
					Module.smethod_33<string>(3100522376u),
					Module.smethod_36<string>(1487391468u),
					Module.smethod_33<string>(4187025826u),
					Module.smethod_33<string>(1304513015u),
					Module.smethod_37<string>(4092263615u)
				}, null, new Type[]
				{
					DescriptorReflection.smethod_2(typeof(FileOptions.Types.OptimizeMode).TypeHandle)
				}, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(MessageOptions).TypeHandle), MessageOptions.Parser, new string[]
				{
					Module.smethod_37<string>(440082545u),
					Module.smethod_36<string>(2296414231u),
					Module.smethod_36<string>(3859287751u),
					Module.smethod_33<string>(537403263u),
					Module.smethod_35<string>(1892808547u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FieldOptions).TypeHandle), FieldOptions.Parser, new string[]
				{
					Module.smethod_37<string>(1258168747u),
					Module.smethod_33<string>(2678739639u),
					Module.smethod_35<string>(1886575529u),
					Module.smethod_37<string>(3449477389u),
					Module.smethod_37<string>(2631391187u),
					Module.smethod_36<string>(693138705u),
					Module.smethod_35<string>(1892808547u)
				}, null, new Type[]
				{
					DescriptorReflection.smethod_2(typeof(FieldOptions.Types.CType).TypeHandle),
					DescriptorReflection.smethod_2(typeof(FieldOptions.Types.JSType).TypeHandle)
				}, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumOptions).TypeHandle), EnumOptions.Parser, new string[]
				{
					Module.smethod_33<string>(2454881612u),
					Module.smethod_33<string>(4040147620u),
					Module.smethod_35<string>(1892808547u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumValueOptions).TypeHandle), EnumValueOptions.Parser, new string[]
				{
					Module.smethod_34<string>(1182280200u),
					Module.smethod_33<string>(3605546240u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(ServiceOptions).TypeHandle), ServiceOptions.Parser, new string[]
				{
					Module.smethod_36<string>(3859287751u),
					Module.smethod_37<string>(4092263615u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(MethodOptions).TypeHandle), MethodOptions.Parser, new string[]
				{
					Module.smethod_33<string>(4040147620u),
					Module.smethod_37<string>(4092263615u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(UninterpretedOption).TypeHandle), UninterpretedOption.Parser, new string[]
				{
					Module.smethod_36<string>(2649665489u),
					Module.smethod_33<string>(2020280232u),
					Module.smethod_33<string>(3432734717u),
					Module.smethod_33<string>(3106783682u),
					Module.smethod_37<string>(673825670u),
					Module.smethod_34<string>(1904509729u),
					Module.smethod_36<string>(3497575026u)
				}, null, null, new GeneratedCodeInfo[]
				{
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(UninterpretedOption.Types.NamePart).TypeHandle), UninterpretedOption.Types.NamePart.Parser, new string[]
					{
						Module.smethod_36<string>(154800351u),
						Module.smethod_33<string>(2838436488u)
					}, null, null, null)
				}),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(SourceCodeInfo).TypeHandle), SourceCodeInfo.Parser, new string[]
				{
					Module.smethod_37<string>(2280791235u)
				}, null, null, new GeneratedCodeInfo[]
				{
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(SourceCodeInfo.Types.Location).TypeHandle), SourceCodeInfo.Types.Location.Parser, new string[]
					{
						Module.smethod_36<string>(1934701506u),
						Module.smethod_35<string>(4201253344u),
						Module.smethod_34<string>(967143609u),
						Module.smethod_33<string>(281874712u),
						Module.smethod_35<string>(3061737428u)
					}, null, null, null)
				})
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
