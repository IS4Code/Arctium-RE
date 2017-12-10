using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Google.Protobuf
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
				Module.smethod_33<string>(1267697346u),
				Module.smethod_35<string>(2451761865u),
				Module.smethod_36<string>(2302970369u),
				Module.smethod_33<string>(2187946610u),
				Module.smethod_33<string>(3926352130u),
				Module.smethod_33<string>(3006102866u),
				Module.smethod_35<string>(3459124441u),
				Module.smethod_36<string>(3078537361u),
				Module.smethod_37<string>(4092086789u),
				Module.smethod_33<string>(1369790354u),
				Module.smethod_36<string>(2684884097u),
				Module.smethod_36<string>(1503924305u),
				Module.smethod_36<string>(4236018081u),
				Module.smethod_34<string>(1554038290u),
				Module.smethod_34<string>(1928984738u),
				Module.smethod_36<string>(3460451089u),
				Module.smethod_37<string>(1287287173u),
				Module.smethod_36<string>(334704049u),
				Module.smethod_35<string>(4158807705u),
				Module.smethod_34<string>(3599326898u),
				Module.smethod_37<string>(2689686981u),
				Module.smethod_33<string>(755820114u),
				Module.smethod_37<string>(3887609445u),
				Module.smethod_37<string>(3537009493u),
				Module.smethod_35<string>(1878565561u),
				Module.smethod_35<string>(3851128393u),
				Module.smethod_35<string>(3193607449u),
				Module.smethod_34<string>(3121491506u),
				Module.smethod_33<string>(3109608066u),
				Module.smethod_34<string>(2371598610u),
				Module.smethod_33<string>(3927764322u),
				Module.smethod_33<string>(4029857330u),
				Module.smethod_35<string>(45032761u),
				Module.smethod_35<string>(2017595593u),
				Module.smethod_33<string>(2291451810u),
				Module.smethod_33<string>(2393544818u),
				Module.smethod_37<string>(4004318917u),
				Module.smethod_37<string>(3653718965u),
				Module.smethod_34<string>(4041940770u),
				Module.smethod_36<string>(1550882449u),
				Module.smethod_34<string>(3292047874u),
				Module.smethod_35<string>(1052395337u),
				Module.smethod_33<string>(3313794082u),
				Module.smethod_36<string>(4271236689u),
				Module.smethod_37<string>(1199519301u),
				Module.smethod_34<string>(667422738u),
				Module.smethod_35<string>(2059757913u),
				Module.smethod_37<string>(2046841813u),
				Module.smethod_37<string>(3595364229u),
				Module.smethod_36<string>(3102016433u),
				Module.smethod_36<string>(1539142913u),
				Module.smethod_33<string>(143262066u),
				Module.smethod_36<string>(3090276897u),
				Module.smethod_33<string>(961418322u),
				Module.smethod_34<string>(2337764898u),
				Module.smethod_34<string>(1212925554u),
				Module.smethod_34<string>(1587872002u),
				Module.smethod_37<string>(2748041717u),
				Module.smethod_33<string>(1063511330u),
				Module.smethod_34<string>(2234875954u),
				Module.smethod_37<string>(1871777605u),
				Module.smethod_36<string>(669659633u),
				Module.smethod_33<string>(3310969698u),
				Module.smethod_35<string>(2005052521u),
				Module.smethod_35<string>(1347531577u),
				Module.smethod_35<string>(3320094409u),
				Module.smethod_36<string>(1063312897u),
				Module.smethod_34<string>(3530271666u),
				Module.smethod_33<string>(3515155714u),
				Module.smethod_34<string>(2780378770u),
				Module.smethod_35<string>(32489689u),
				Module.smethod_33<string>(140437682u),
				Module.smethod_36<string>(276006369u),
				Module.smethod_36<string>(3008100145u),
				Module.smethod_34<string>(1655539426u),
				Module.smethod_34<string>(530700082u),
				Module.smethod_35<string>(2047214841u),
				Module.smethod_35<string>(4019777673u),
				Module.smethod_35<string>(3362256729u),
				Module.smethod_35<string>(74652009u),
				Module.smethod_34<string>(3700828034u),
				Module.smethod_35<string>(1389693897u),
				Module.smethod_35<string>(732172953u),
				Module.smethod_34<string>(1826095794u),
				Module.smethod_35<string>(1082014585u),
				Module.smethod_36<string>(1815400817u),
				Module.smethod_36<string>(252527297u),
				Module.smethod_37<string>(3215822677u),
				Module.smethod_36<string>(1039833825u),
				Module.smethod_33<string>(3003278482u),
				Module.smethod_34<string>(4246330850u),
				Module.smethod_36<string>(2267751761u),
				Module.smethod_36<string>(704878241u),
				Module.smethod_33<string>(1778162386u),
				Module.smethod_34<string>(973313954u),
				Module.smethod_37<string>(732209877u),
				Module.smethod_35<string>(913365305u),
				Module.smethod_35<string>(2885928137u),
				Module.smethod_34<string>(3768495458u)
			})), new FileDescriptor[0], new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FileDescriptorSet).TypeHandle), FileDescriptorSet.Parser, new string[]
				{
					Module.smethod_35<string>(1542966915u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FileDescriptorProto).TypeHandle), FileDescriptorProto.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_33<string>(3068851852u),
					Module.smethod_36<string>(2918834666u),
					Module.smethod_33<string>(2960201507u),
					Module.smethod_34<string>(917987220u),
					Module.smethod_33<string>(620940421u),
					Module.smethod_37<string>(1813216572u),
					Module.smethod_35<string>(1948647215u),
					Module.smethod_33<string>(3343756383u),
					Module.smethod_35<string>(1556926582u),
					Module.smethod_34<string>(2174973054u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(DescriptorProto).TypeHandle), DescriptorProto.Parser, new string[]
				{
					Module.smethod_37<string>(2134609685u),
					Module.smethod_36<string>(476111070u),
					Module.smethod_37<string>(3653925262u),
					Module.smethod_37<string>(3420182137u),
					Module.smethod_35<string>(367805016u),
					Module.smethod_36<string>(2256012225u),
					Module.smethod_34<string>(1452743525u),
					Module.smethod_35<string>(1556926582u)
				}, null, null, new GeneratedCodeInfo[]
				{
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(DescriptorProto.Types.ExtensionRange).TypeHandle), DescriptorProto.Types.ExtensionRange.Parser, new string[]
					{
						Module.smethod_33<string>(1221795987u),
						Module.smethod_33<string>(780637270u)
					}, null, null, null)
				}),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FieldDescriptorProto).TypeHandle), FieldDescriptorProto.Parser, new string[]
				{
					Module.smethod_35<string>(3235769769u),
					Module.smethod_36<string>(652736699u),
					Module.smethod_34<string>(46694345u),
					Module.smethod_37<string>(147837329u),
					Module.smethod_37<string>(878273543u),
					Module.smethod_36<string>(1263417598u),
					Module.smethod_36<string>(2360295309u),
					Module.smethod_33<string>(2084441410u),
					Module.smethod_33<string>(2909155003u)
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
					Module.smethod_36<string>(2649665489u),
					Module.smethod_34<string>(1800026606u),
					Module.smethod_35<string>(1556926582u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumValueDescriptorProto).TypeHandle), EnumValueDescriptorProto.Parser, new string[]
				{
					Module.smethod_34<string>(2643656114u),
					Module.smethod_36<string>(652736699u),
					Module.smethod_37<string>(819830394u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(ServiceDescriptorProto).TypeHandle), ServiceDescriptorProto.Parser, new string[]
				{
					Module.smethod_36<string>(2649665489u),
					Module.smethod_37<string>(4209061500u),
					Module.smethod_35<string>(1556926582u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(MethodDescriptorProto).TypeHandle), MethodDescriptorProto.Parser, new string[]
				{
					Module.smethod_35<string>(3235769769u),
					Module.smethod_35<string>(3613530735u),
					Module.smethod_33<string>(946891456u),
					Module.smethod_37<string>(819830394u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FileOptions).TypeHandle), FileOptions.Parser, new string[]
				{
					Module.smethod_33<string>(2250695596u),
					Module.smethod_34<string>(2775802604u),
					Module.smethod_37<string>(1521059769u),
					Module.smethod_37<string>(2163845995u),
					Module.smethod_33<string>(3221991364u),
					Module.smethod_35<string>(2270569513u),
					Module.smethod_34<string>(4220261662u),
					Module.smethod_36<string>(1665532329u),
					Module.smethod_33<string>(230828208u),
					Module.smethod_34<string>(300240814u),
					Module.smethod_37<string>(2631391187u),
					Module.smethod_36<string>(247343899u)
				}, null, new Type[]
				{
					DescriptorReflection.smethod_2(typeof(FileOptions.Types.OptimizeMode).TypeHandle)
				}, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(MessageOptions).TypeHandle), MessageOptions.Parser, new string[]
				{
					Module.smethod_34<string>(3470368766u),
					Module.smethod_34<string>(1557226648u),
					Module.smethod_35<string>(983446959u),
					Module.smethod_35<string>(1892808547u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(FieldOptions).TypeHandle), FieldOptions.Parser, new string[]
				{
					Module.smethod_36<string>(930367343u),
					Module.smethod_37<string>(3770870502u),
					Module.smethod_33<string>(2135487914u),
					Module.smethod_37<string>(2631391187u),
					Module.smethod_36<string>(351626983u),
					Module.smethod_36<string>(693138705u),
					Module.smethod_33<string>(3605546240u)
				}, null, new Type[]
				{
					DescriptorReflection.smethod_2(typeof(FieldOptions.Types.CType).TypeHandle)
				}, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumOptions).TypeHandle), EnumOptions.Parser, new string[]
				{
					Module.smethod_35<string>(3809532711u),
					Module.smethod_35<string>(983446959u),
					Module.smethod_35<string>(1892808547u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(EnumValueOptions).TypeHandle), EnumValueOptions.Parser, new string[]
				{
					Module.smethod_33<string>(4040147620u),
					Module.smethod_36<string>(247343899u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(ServiceOptions).TypeHandle), ServiceOptions.Parser, new string[]
				{
					Module.smethod_36<string>(3859287751u),
					Module.smethod_35<string>(1892808547u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(MethodOptions).TypeHandle), MethodOptions.Parser, new string[]
				{
					Module.smethod_36<string>(3859287751u),
					Module.smethod_36<string>(247343899u)
				}, null, null, null),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(UninterpretedOption).TypeHandle), UninterpretedOption.Parser, new string[]
				{
					Module.smethod_35<string>(3235769769u),
					Module.smethod_37<string>(2368441223u),
					Module.smethod_33<string>(3432734717u),
					Module.smethod_33<string>(3106783682u),
					Module.smethod_34<string>(1998246341u),
					Module.smethod_34<string>(1904509729u),
					Module.smethod_35<string>(1347248258u)
				}, null, null, new GeneratedCodeInfo[]
				{
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(UninterpretedOption.Types.NamePart).TypeHandle), UninterpretedOption.Types.NamePart.Parser, new string[]
					{
						Module.smethod_35<string>(829607303u),
						Module.smethod_34<string>(4071198316u)
					}, null, null, null)
				}),
				new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(SourceCodeInfo).TypeHandle), SourceCodeInfo.Parser, new string[]
				{
					Module.smethod_33<string>(4142240628u)
				}, null, null, new GeneratedCodeInfo[]
				{
					new GeneratedCodeInfo(DescriptorReflection.smethod_2(typeof(SourceCodeInfo.Types.Location).TypeHandle), SourceCodeInfo.Types.Location.Parser, new string[]
					{
						Module.smethod_34<string>(1060880221u),
						Module.smethod_34<string>(3161495563u),
						Module.smethod_35<string>(1599088902u),
						Module.smethod_36<string>(3569917571u)
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
