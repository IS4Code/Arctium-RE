using Bgs.Protocol.Channel.V1;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public static class PresenceTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.descriptor;
			}
		}

		static PresenceTypesReflection()
		{
			PresenceTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(PresenceTypesReflection.smethod_1(PresenceTypesReflection.smethod_0(new string[]
			{
				Module.smethod_35<string>(4186083365u),
				Module.smethod_33<string>(197735254u),
				Module.smethod_34<string>(3316729254u),
				Module.smethod_35<string>(2213520533u),
				Module.smethod_35<string>(1555999589u),
				Module.smethod_33<string>(3267586454u),
				Module.smethod_35<string>(1037508677u),
				Module.smethod_36<string>(3505278877u),
				Module.smethod_37<string>(144772345u),
				Module.smethod_37<string>(4089139689u),
				Module.smethod_34<string>(2838893862u),
				Module.smethod_34<string>(1714054518u),
				Module.smethod_33<string>(4187835718u),
				Module.smethod_34<string>(964161622u),
				Module.smethod_34<string>(1339108070u),
				Module.smethod_35<string>(2044871253u),
				Module.smethod_36<string>(2324319085u),
				Module.smethod_34<string>(3759343126u),
				Module.smethod_34<string>(4134289574u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				ChannelTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(PresenceTypesReflection.smethod_2(typeof(RichPresenceLocalizationKey).TypeHandle), RichPresenceLocalizationKey.Parser, new string[]
				{
					Module.smethod_36<string>(2505595523u),
					Module.smethod_36<string>(1743673396u),
					Module.smethod_36<string>(793386104u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceTypesReflection.smethod_2(typeof(FieldKey).TypeHandle), FieldKey.Parser, new string[]
				{
					Module.smethod_35<string>(2043171339u),
					Module.smethod_36<string>(1548752093u),
					Module.smethod_37<string>(2193052834u),
					Module.smethod_33<string>(2928520745u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceTypesReflection.smethod_2(typeof(Field).TypeHandle), Field.Parser, new string[]
				{
					Module.smethod_35<string>(30996058u),
					Module.smethod_37<string>(1696359745u)
				}, null, null, null),
				new GeneratedCodeInfo(PresenceTypesReflection.smethod_2(typeof(FieldOperation).TypeHandle), FieldOperation.Parser, new string[]
				{
					Module.smethod_34<string>(984060465u),
					Module.smethod_34<string>(1096308112u)
				}, null, new Type[]
				{
					PresenceTypesReflection.smethod_2(typeof(FieldOperation.Types.OperationType).TypeHandle)
				}, null),
				new GeneratedCodeInfo(PresenceTypesReflection.smethod_2(typeof(ChannelState).TypeHandle), ChannelState.Parser, new string[]
				{
					Module.smethod_36<string>(1294600521u),
					Module.smethod_35<string>(1849719234u),
					Module.smethod_33<string>(3689073160u),
					Module.smethod_34<string>(2006010865u)
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
