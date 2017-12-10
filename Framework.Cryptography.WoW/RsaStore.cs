using System;
using System.Runtime.CompilerServices;

namespace Framework.Cryptography.WoW
{
	public class RsaStore
	{
		public static byte[] D;

		public static byte[] DP;

		public static byte[] DQ;

		public static byte[] Exponent;

		public static byte[] InverseQ;

		public static byte[] Modulus;

		public static byte[] P;

		public static byte[] Q;

		public static byte[] WherePacketHmac;

		static RsaStore()
		{
			// Note: this type is marked as 'beforefieldinit'.
			byte[] expr_0A = new byte[256];
			RsaStore.smethod_0(expr_0A, fieldof(Framework.<PrivateImplementationDetails>.struct16_0).FieldHandle);
			RsaStore.D = expr_0A;
			byte[] expr_24 = new byte[128];
			RsaStore.smethod_0(expr_24, fieldof(Framework.<PrivateImplementationDetails>.F49E8741F7968D6D836AC31B66B178C67D2CD2D1).FieldHandle);
			RsaStore.DP = expr_24;
			while (true)
			{
				IL_14B:
				uint arg_127_0 = 3123678134u;
				while (true)
				{
					uint num;
					switch ((num = (arg_127_0 ^ 3909798529u)) % 6u)
					{
					case 0u:
					{
						byte[] expr_EE = new byte[128];
						RsaStore.smethod_0(expr_EE, fieldof(Framework.<PrivateImplementationDetails>.struct15_0).FieldHandle);
						RsaStore.Q = expr_EE;
						byte[] expr_105 = new byte[64];
						RsaStore.smethod_0(expr_105, fieldof(Framework.<PrivateImplementationDetails>.struct14_0).FieldHandle);
						RsaStore.WherePacketHmac = expr_105;
						arg_127_0 = (num * 2822589078u ^ 89342793u);
						continue;
					}
					case 1u:
					{
						byte[] expr_C5 = new byte[128];
						RsaStore.smethod_0(expr_C5, fieldof(Framework.<PrivateImplementationDetails>.BFED396B36E39E6B4D9C773432CEE8616631C5A0).FieldHandle);
						RsaStore.P = expr_C5;
						arg_127_0 = (num * 749206368u ^ 2764065413u);
						continue;
					}
					case 3u:
					{
						byte[] expr_89 = new byte[128];
						RsaStore.smethod_0(expr_89, fieldof(Framework.<PrivateImplementationDetails>.struct15_1).FieldHandle);
						RsaStore.DQ = expr_89;
						RsaStore.Exponent = new byte[]
						{
							1,
							0,
							1
						};
						arg_127_0 = (num * 2260426298u ^ 2014626594u);
						continue;
					}
					case 4u:
						goto IL_14B;
					case 5u:
					{
						byte[] expr_43 = new byte[128];
						RsaStore.smethod_0(expr_43, fieldof(Framework.<PrivateImplementationDetails>.struct15_2).FieldHandle);
						RsaStore.InverseQ = expr_43;
						byte[] expr_5D = new byte[256];
						RsaStore.smethod_0(expr_5D, fieldof(Framework.<PrivateImplementationDetails>.struct16_1).FieldHandle);
						RsaStore.Modulus = expr_5D;
						arg_127_0 = (num * 4028678003u ^ 3241436557u);
						continue;
					}
					}
					return;
				}
			}
		}

		static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}
}
