using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public static class ChannelTypesReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.descriptor;
			}
		}

		static ChannelTypesReflection()
		{
			ChannelTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(ChannelTypesReflection.smethod_1(ChannelTypesReflection.smethod_0(new string[]
			{
				Module.smethod_34<string>(2670550786u),
				Module.smethod_37<string>(2568733685u),
				Module.smethod_35<string>(2883301230u),
				Module.smethod_33<string>(3092355493u),
				Module.smethod_36<string>(2472057217u),
				Module.smethod_36<string>(2530754897u),
				Module.smethod_36<string>(967881377u),
				Module.smethod_35<string>(2817623433u),
				Module.smethod_33<string>(3561758050u),
				Module.smethod_36<string>(192314385u),
				Module.smethod_36<string>(2924408161u),
				Module.smethod_37<string>(85120885u),
				Module.smethod_34<string>(1442822498u),
				Module.smethod_37<string>(289598229u),
				Module.smethod_36<string>(1349795105u),
				Module.smethod_36<string>(4081888881u),
				Module.smethod_36<string>(2519015361u),
				Module.smethod_35<string>(2202264809u),
				Module.smethod_33<string>(2129631554u),
				Module.smethod_36<string>(1743448369u),
				Module.smethod_33<string>(2947787810u),
				Module.smethod_33<string>(3049880818u),
				Module.smethod_33<string>(493319042u),
				Module.smethod_37<string>(2977688373u),
				Module.smethod_35<string>(229701977u),
				Module.smethod_35<string>(1237064553u),
				Module.smethod_36<string>(3688235617u),
				Module.smethod_35<string>(2552106441u),
				Module.smethod_37<string>(2627088421u),
				Module.smethod_34<string>(2908774578u),
				Module.smethod_33<string>(1515661314u),
				Module.smethod_37<string>(2480965813u),
				Module.smethod_36<string>(3282842817u),
				Module.smethod_35<string>(271864297u),
				Module.smethod_34<string>(1783935234u),
				Module.smethod_34<string>(659095890u),
				Module.smethod_37<string>(2130365861u),
				Module.smethod_33<string>(388401650u),
				Module.smethod_34<string>(2805885634u)
			})), new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedCodeInfo(null, new GeneratedCodeInfo[]
			{
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(ChannelId).TypeHandle), ChannelId.Parser, new string[]
				{
					Module.smethod_33<string>(1649840030u),
					Module.smethod_34<string>(4183239592u),
					Module.smethod_35<string>(4021477587u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(Message).TypeHandle), Message.Parser, new string[]
				{
					Module.smethod_37<string>(1754272416u),
					Module.smethod_35<string>(2560812294u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(ListChannelsOptions).TypeHandle), ListChannelsOptions.Parser, new string[]
				{
					Module.smethod_34<string>(3969134856u),
					Module.smethod_34<string>(3875398244u),
					Module.smethod_33<string>(1982348402u),
					Module.smethod_36<string>(2505595523u),
					Module.smethod_34<string>(4156608080u),
					Module.smethod_36<string>(4257141770u),
					Module.smethod_35<string>(3602481294u),
					Module.smethod_35<string>(1769798451u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(ChannelDescription).TypeHandle), ChannelDescription.Parser, new string[]
				{
					Module.smethod_37<string>(1199371946u),
					Module.smethod_37<string>(85415595u),
					Module.smethod_36<string>(3718803416u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(ChannelInfo).TypeHandle), ChannelInfo.Parser, new string[]
				{
					Module.smethod_33<string>(3264357124u),
					Module.smethod_35<string>(188389614u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(ChannelState).TypeHandle), ChannelState.Parser, new string[]
				{
					Module.smethod_34<string>(3125505348u),
					Module.smethod_35<string>(49076263u),
					Module.smethod_33<string>(4205493237u),
					Module.smethod_37<string>(3741310011u),
					Module.smethod_34<string>(3312978572u),
					Module.smethod_37<string>(3507566886u),
					Module.smethod_34<string>(2497012431u),
					Module.smethod_33<string>(1982348402u),
					Module.smethod_34<string>(2403275819u),
					Module.smethod_34<string>(4250344692u),
					Module.smethod_34<string>(3421418748u),
					Module.smethod_37<string>(3065603600u),
					Module.smethod_34<string>(396397089u),
					Module.smethod_37<string>(2802653636u)
				}, null, new Type[]
				{
					ChannelTypesReflection.smethod_2(typeof(ChannelState.Types.PrivacyLevel).TypeHandle)
				}, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(MemberState).TypeHandle), MemberState.Parser, new string[]
				{
					Module.smethod_37<string>(1754272416u),
					Module.smethod_36<string>(1553402902u),
					Module.smethod_37<string>(759059036u),
					Module.smethod_35<string>(2273479739u),
					Module.smethod_36<string>(283485193u)
				}, null, null, null),
				new GeneratedCodeInfo(ChannelTypesReflection.smethod_2(typeof(Member).TypeHandle), Member.Parser, new string[]
				{
					Module.smethod_33<string>(3259014625u),
					Module.smethod_34<string>(3340641939u)
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
