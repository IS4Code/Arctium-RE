using Framework.Misc;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Framework.Cryptography.BNet
{
	public sealed class SRP6a : IDisposable
	{
		public readonly BigInteger gBN;

		public readonly BigInteger k;

		public readonly byte[] N;

		public readonly byte[] S;

		public readonly byte[] g;

		private SHA256 sha256;

		private BigInteger A;

		private BigInteger BN;

		private BigInteger v;

		private BigInteger b;

		private BigInteger s;

		public byte[] I
		{
			get;
			private set;
		}

		public byte[] S2
		{
			get;
			private set;
		}

		public byte[] V
		{
			get;
			private set;
		}

		public byte[] B
		{
			get;
			private set;
		}

		public byte[] SessionKey
		{
			get;
			private set;
		}

		public byte[] WoWSessionKey
		{
			get;
			private set;
		}

		public byte[] ClientM
		{
			get;
			private set;
		}

		public byte[] ServerM
		{
			get;
			private set;
		}

		public SRP6a(string salt, string accountName = "", string passwordVerifier = "")
		{
			while (true)
			{
				IL_11A:
				uint arg_FA_0 = 1990870343u;
				while (true)
				{
					uint num;
					switch ((num = (arg_FA_0 ^ 1565948384u)) % 5u)
					{
					case 0u:
						this.k = this.MakeBigInteger(SRP6a.smethod_3(this.sha256, this.N.Combine(this.g)));
						this.v = this.MakeBigInteger(passwordVerifier.ToByteArray());
						arg_FA_0 = (num * 10374198u ^ 3275431934u);
						continue;
					case 1u:
						this.S = salt.ToByteArray();
						this.g = new byte[]
						{
							2
						};
						this.BN = this.MakeBigInteger(this.N);
						this.gBN = this.MakeBigInteger(this.g);
						arg_FA_0 = (num * 4125876422u ^ 2637048811u);
						continue;
					case 2u:
					{
						this.sha256 = SRP6a.smethod_0();
						this.I = SRP6a.smethod_3(this.sha256, SRP6a.smethod_2(SRP6a.smethod_1(), accountName));
						byte[] expr_3D = new byte[128];
						SRP6a.smethod_4(expr_3D, fieldof(Framework.<PrivateImplementationDetails>.struct15_3).FieldHandle);
						this.N = expr_3D;
						arg_FA_0 = (num * 2174447120u ^ 1530330669u);
						continue;
					}
					case 3u:
						goto IL_11A;
					}
					return;
				}
			}
		}

		public void CalculateX(string accountName, string password, bool calcB)
		{
			this.I = SRP6a.smethod_3(this.sha256, SRP6a.smethod_2(SRP6a.smethod_1(), accountName));
			while (true)
			{
				IL_A7:
				uint arg_8F_0 = 2553222655u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8F_0 ^ 2695648094u)) % 3u)
					{
					case 0u:
						goto IL_A7;
					case 1u:
					{
						byte[] data = SRP6a.smethod_3(this.sha256, SRP6a.smethod_2(SRP6a.smethod_1(), SRP6a.smethod_6(this.I.ToHexString(), Module.smethod_33<string>(1968828782u), SRP6a.smethod_5(password))));
						BigInteger x = this.MakeBigInteger(SRP6a.smethod_3(this.sha256, this.S.Combine(data)));
						this.CalculateV(x, calcB);
						arg_8F_0 = (num * 1788205373u ^ 735249050u);
						continue;
					}
					}
					return;
				}
			}
		}

		private void CalculateV(BigInteger x, bool calcB)
		{
			this.v = BigInteger.ModPow(this.gBN, x, this.BN);
			this.V = this.v.ToByteArray();
			if (calcB)
			{
				while (true)
				{
					IL_5E:
					uint arg_46_0 = 3956925126u;
					while (true)
					{
						uint num;
						switch ((num = (arg_46_0 ^ 3179056548u)) % 3u)
						{
						case 1u:
							this.CalculateB();
							arg_46_0 = (num * 2378183716u ^ 3313977404u);
							continue;
						case 2u:
							goto IL_5E;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public void CalculateB()
		{
			byte[] array = new byte[128];
			while (true)
			{
				IL_7C:
				uint arg_5C_0 = 3206230607u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5C_0 ^ 2218348064u)) % 5u)
					{
					case 0u:
						this.S2 = array;
						arg_5C_0 = (num * 3988362356u ^ 2556367054u);
						continue;
					case 1u:
						this.b = this.MakeBigInteger(array);
						arg_5C_0 = (num * 3278302294u ^ 3633323988u);
						continue;
					case 3u:
						SRP6a.smethod_8(SRP6a.smethod_7(), array);
						arg_5C_0 = (num * 2572586182u ^ 1454878351u);
						continue;
					case 4u:
						goto IL_7C;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.B = this.GetBytes(((this.k * this.v + BigInteger.ModPow(this.gBN, this.b, this.BN)) % this.BN).ToByteArray(), 128);
		}

		public void CalculateU(byte[] a)
		{
			this.A = this.MakeBigInteger(a);
			while (true)
			{
				IL_5C:
				uint arg_44_0 = 1038568804u;
				while (true)
				{
					uint num;
					switch ((num = (arg_44_0 ^ 1653931647u)) % 3u)
					{
					case 0u:
						goto IL_5C;
					case 2u:
						this.CalculateS(this.MakeBigInteger(SRP6a.smethod_3(this.sha256, a.Combine(this.B))));
						arg_44_0 = (num * 3059919140u ^ 4120859160u);
						continue;
					}
					return;
				}
			}
		}

		private void CalculateS(BigInteger u)
		{
			this.s = BigInteger.ModPow(this.A * BigInteger.ModPow(this.v, u, this.BN) % this.BN, this.b, this.BN);
			this.CalculateSessionKey();
		}

		public void CalculateSessionKey()
		{
			byte[] bytes = this.GetBytes(this.s.ToByteArray(), 128);
			while (true)
			{
				IL_232:
				uint arg_1DC_0 = 4222192858u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1DC_0 ^ 2714582115u)) % 18u)
					{
					case 0u:
					{
						byte[] array = new byte[bytes.Length / 2];
						int num2 = 0;
						arg_1DC_0 = (num * 2523120788u ^ 2676676707u);
						continue;
					}
					case 1u:
					{
						byte[] array;
						byte[] array2;
						this.SessionKey = new byte[array2.Length + array.Length];
						arg_1DC_0 = (num * 2887321725u ^ 2668173759u);
						continue;
					}
					case 2u:
					{
						int num2;
						byte[] array2;
						arg_1DC_0 = ((num2 < array2.Length) ? 3962445998u : 3756537474u);
						continue;
					}
					case 3u:
					{
						int num2;
						byte[] array2;
						array2[num2] = bytes[num2 * 2];
						arg_1DC_0 = 2790075746u;
						continue;
					}
					case 4u:
						this.CalculateWoWSessionKey(this.SessionKey);
						arg_1DC_0 = (num * 1938263627u ^ 2590204091u);
						continue;
					case 5u:
					{
						byte[] array2 = new byte[bytes.Length / 2];
						arg_1DC_0 = (num * 3546247964u ^ 3107755769u);
						continue;
					}
					case 7u:
					{
						byte[] array2;
						int num3;
						arg_1DC_0 = ((num3 < array2.Length) ? 2889917647u : 3904964729u);
						continue;
					}
					case 8u:
					{
						byte[] array;
						int num3;
						this.SessionKey[num3 * 2 + 1] = array[num3];
						num3++;
						arg_1DC_0 = (num * 1551608187u ^ 4285121882u);
						continue;
					}
					case 9u:
					{
						byte[] array;
						int num2;
						array[num2] = bytes[num2 * 2 + 1];
						arg_1DC_0 = (num * 4267992268u ^ 1522922747u);
						continue;
					}
					case 10u:
						arg_1DC_0 = (num * 3995399878u ^ 4053259181u);
						continue;
					case 11u:
					{
						byte[] array2 = this.sha256.ComputeHash(array2);
						arg_1DC_0 = (num * 464323702u ^ 744207489u);
						continue;
					}
					case 12u:
					{
						byte[] array = this.sha256.ComputeHash(array);
						arg_1DC_0 = (num * 3857746972u ^ 965939648u);
						continue;
					}
					case 13u:
					{
						int num3 = 0;
						arg_1DC_0 = (num * 2686872880u ^ 2121102296u);
						continue;
					}
					case 14u:
					{
						int num2;
						num2++;
						arg_1DC_0 = (num * 4053533547u ^ 1941216609u);
						continue;
					}
					case 15u:
						goto IL_232;
					case 16u:
					{
						byte[] array2;
						int num3;
						this.SessionKey[num3 * 2] = array2[num3];
						arg_1DC_0 = 2424620531u;
						continue;
					}
					case 17u:
						arg_1DC_0 = (num * 3198961250u ^ 2158511132u);
						continue;
					}
					return;
				}
			}
		}

		public void CalculateWoWSessionKey(byte[] arr)
		{
			while (true)
			{
				IL_1F8:
				uint arg_1A6_0 = 57912216u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1A6_0 ^ 1862494343u)) % 17u)
					{
					case 0u:
					{
						byte[] array = new byte[arr.Length / 2];
						arg_1A6_0 = (num * 598141279u ^ 3709953262u);
						continue;
					}
					case 1u:
					{
						byte[] array2 = SRP6a.smethod_10(SRP6a.smethod_9(), array2);
						byte[] array = SRP6a.smethod_10(SRP6a.smethod_9(), array);
						arg_1A6_0 = (num * 3150643284u ^ 2166396056u);
						continue;
					}
					case 2u:
					{
						byte[] array2;
						int num2;
						this.WoWSessionKey[num2 * 2] = array2[num2];
						arg_1A6_0 = 2098472953u;
						continue;
					}
					case 3u:
					{
						byte[] array2;
						int num3;
						array2[num3] = arr[num3 * 2];
						arg_1A6_0 = 472270212u;
						continue;
					}
					case 4u:
					{
						byte[] array2 = new byte[arr.Length / 2];
						arg_1A6_0 = (num * 4031285479u ^ 4201713760u);
						continue;
					}
					case 5u:
						arg_1A6_0 = (num * 4069555469u ^ 1090867220u);
						continue;
					case 6u:
					{
						int num3;
						num3++;
						arg_1A6_0 = (num * 428409243u ^ 3952092863u);
						continue;
					}
					case 7u:
					{
						byte[] array2;
						int num3;
						arg_1A6_0 = ((num3 >= array2.Length) ? 435006772u : 552065601u);
						continue;
					}
					case 8u:
					{
						byte[] array;
						int num2;
						this.WoWSessionKey[num2 * 2 + 1] = array[num2];
						arg_1A6_0 = (num * 1049171215u ^ 159242650u);
						continue;
					}
					case 9u:
					{
						int num2;
						num2++;
						arg_1A6_0 = (num * 2545200484u ^ 1484258480u);
						continue;
					}
					case 10u:
					{
						byte[] array;
						byte[] array2;
						this.WoWSessionKey = new byte[array2.Length + array.Length];
						arg_1A6_0 = (num * 2279781675u ^ 167724743u);
						continue;
					}
					case 11u:
					{
						int num3 = 0;
						arg_1A6_0 = (num * 2477893337u ^ 1881340740u);
						continue;
					}
					case 12u:
					{
						byte[] array2;
						int num2;
						arg_1A6_0 = ((num2 < array2.Length) ? 460778666u : 814051148u);
						continue;
					}
					case 13u:
					{
						byte[] array;
						int num3;
						array[num3] = arr[num3 * 2 + 1];
						arg_1A6_0 = (num * 3568307509u ^ 907486368u);
						continue;
					}
					case 15u:
					{
						int num2 = 0;
						arg_1A6_0 = (num * 1158626221u ^ 382197970u);
						continue;
					}
					case 16u:
						goto IL_1F8;
					}
					return;
				}
			}
		}

		public void CalculateClientM(byte[] a)
		{
			byte[] array = SRP6a.smethod_3(this.sha256, this.N);
			while (true)
			{
				IL_140:
				uint arg_113_0 = 2564275220u;
				while (true)
				{
					uint num;
					switch ((num = (arg_113_0 ^ 3263938703u)) % 8u)
					{
					case 0u:
						goto IL_140;
					case 1u:
					{
						byte[] byte_ = array.Combine(SRP6a.smethod_3(this.sha256, SRP6a.smethod_2(SRP6a.smethod_1(), this.I.ToHexString()))).Combine(this.S).Combine(a).Combine(this.B).Combine(this.SessionKey);
						this.ClientM = SRP6a.smethod_3(this.sha256, byte_);
						arg_113_0 = (num * 1130404651u ^ 272827307u);
						continue;
					}
					case 2u:
					{
						int num2;
						arg_113_0 = ((num2 < array.Length) ? 2194615946u : 2393073750u);
						continue;
					}
					case 3u:
					{
						byte[] array2 = SRP6a.smethod_3(this.sha256, this.g);
						arg_113_0 = (num * 3484930294u ^ 4152190963u);
						continue;
					}
					case 4u:
					{
						int num2;
						num2++;
						arg_113_0 = (num * 1293311391u ^ 2582903929u);
						continue;
					}
					case 5u:
					{
						byte[] expr_33_cp_0 = array;
						int num2;
						int expr_33_cp_1 = num2;
						byte[] array2;
						expr_33_cp_0[expr_33_cp_1] ^= array2[num2];
						arg_113_0 = 3974963915u;
						continue;
					}
					case 6u:
					{
						int num2 = 0;
						arg_113_0 = (num * 1672443058u ^ 2395775225u);
						continue;
					}
					}
					return;
				}
			}
		}

		public void CalculateServerM(byte[] m1)
		{
			this.ServerM = this.sha256.ComputeHash(this.GetBytes(this.A.ToByteArray(), 128).Combine(m1).Combine(this.SessionKey));
		}

		public byte[] GetBytes(byte[] data, int count = 64)
		{
			if (data.Length > count)
			{
				goto IL_2A;
			}
			IL_06:
			int arg_10_0 = -1099893497;
			IL_0B:
			byte[] array;
			switch ((arg_10_0 ^ -1023563484) % 4)
			{
			case 0:
				goto IL_06;
			case 2:
				IL_2A:
				array = new byte[count];
				arg_10_0 = -1371147539;
				goto IL_0B;
			case 3:
				return data;
			}
			SRP6a.smethod_11(data, 0, array, 0, 64);
			return array;
		}

		public BigInteger MakeBigInteger(byte[] data)
		{
			return new BigInteger(data.Combine(new byte[1]));
		}

		public void Dispose()
		{
			this.SessionKey = null;
			this.ServerM = null;
		}

		static SHA256Managed smethod_0()
		{
			return new SHA256Managed();
		}

		static Encoding smethod_1()
		{
			return Encoding.UTF8;
		}

		static byte[] smethod_2(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static byte[] smethod_3(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
		{
			return hashAlgorithm_0.ComputeHash(byte_0);
		}

		static void smethod_4(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		static string smethod_5(string string_0)
		{
			return string_0.ToUpper();
		}

		static string smethod_6(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		static RandomNumberGenerator smethod_7()
		{
			return RandomNumberGenerator.Create();
		}

		static void smethod_8(RandomNumberGenerator randomNumberGenerator_0, byte[] byte_0)
		{
			randomNumberGenerator_0.GetBytes(byte_0);
		}

		static SHA1Managed smethod_9()
		{
			return new SHA1Managed();
		}

		static byte[] smethod_10(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
		{
			return hashAlgorithm_0.ComputeHash(byte_0);
		}

		static void smethod_11(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}
	}
}
