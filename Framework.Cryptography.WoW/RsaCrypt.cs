using Framework.Misc;
using System;
using System.Numerics;

namespace Framework.Cryptography.WoW
{
	public class RsaCrypt : IDisposable
	{
		private BigInteger e;

		private BigInteger n;

		private BigInteger p;

		private BigInteger q;

		private BigInteger dp;

		private BigInteger dq;

		private BigInteger iq;

		private bool isEncryptionInitialized;

		private bool isDecryptionInitialized;

		public RsaCrypt()
		{
			while (true)
			{
				IL_38:
				uint arg_20_0 = 1224067742u;
				while (true)
				{
					uint num;
					switch ((num = (arg_20_0 ^ 650372566u)) % 3u)
					{
					case 1u:
						this.Dispose();
						arg_20_0 = (num * 1464307623u ^ 3537697434u);
						continue;
					case 2u:
						goto IL_38;
					}
					return;
				}
			}
		}

		public void InitializeEncryption(RsaData rsaData)
		{
			this.InitializeEncryption<byte[]>(rsaData.RsaParams.D, rsaData.RsaParams.P, rsaData.RsaParams.Q, rsaData.RsaParams.DP, rsaData.RsaParams.DQ, rsaData.RsaParams.InverseQ, false);
		}

		public void InitializeEncryption<T>(T d, T p, T q, T dp, T dq, T iq, bool isBigEndian = false)
		{
			this.p = p.ToBigInteger(isBigEndian);
			while (true)
			{
				IL_10B:
				uint arg_DF_0 = 2245496402u;
				while (true)
				{
					uint num;
					switch ((num = (arg_DF_0 ^ 4189837469u)) % 8u)
					{
					case 0u:
						goto IL_112;
					case 1u:
						this.dp = dp.ToBigInteger(isBigEndian);
						arg_DF_0 = (num * 3569613934u ^ 3627706137u);
						continue;
					case 2u:
						this.dq = dq.ToBigInteger(isBigEndian);
						this.iq = iq.ToBigInteger(isBigEndian);
						arg_DF_0 = (((!this.p.IsZero) ? 682123864u : 2063844238u) ^ num * 1766608332u);
						continue;
					case 3u:
						arg_DF_0 = (((!this.q.IsZero) ? 640972758u : 1519380307u) ^ num * 119177762u);
						continue;
					case 5u:
						this.isEncryptionInitialized = true;
						arg_DF_0 = 3035994489u;
						continue;
					case 6u:
						goto IL_10B;
					case 7u:
						this.q = q.ToBigInteger(isBigEndian);
						arg_DF_0 = (num * 4056462446u ^ 2986954358u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			return;
			IL_112:
			throw new InvalidOperationException(Module.smethod_34<string>(2154924629u));
		}

		public void InitializeDecryption(RsaData rsaData)
		{
			this.InitializeDecryption<byte[]>(rsaData.RsaParams.Exponent, rsaData.RsaParams.Modulus, false);
		}

		public void InitializeDecryption<T>(T e, T n, bool reverseBytes = false)
		{
			this.e = e.ToBigInteger(reverseBytes);
			this.n = n.ToBigInteger(reverseBytes);
			while (true)
			{
				IL_4D:
				uint arg_35_0 = 1713286744u;
				while (true)
				{
					uint num;
					switch ((num = (arg_35_0 ^ 848976753u)) % 3u)
					{
					case 1u:
						this.isDecryptionInitialized = true;
						arg_35_0 = (num * 481015517u ^ 2168650542u);
						continue;
					case 2u:
						goto IL_4D;
					}
					return;
				}
			}
		}

		public byte[] Encrypt<T>(T data, bool isBigEndian = false)
		{
			if (!this.isEncryptionInitialized)
			{
				goto IL_36;
			}
			goto IL_82;
			uint arg_5D_0;
			BigInteger bigInteger;
			while (true)
			{
				IL_58:
				uint num;
				switch ((num = (arg_5D_0 ^ 679079837u)) % 6u)
				{
				case 0u:
					bigInteger = this.p + bigInteger;
					arg_5D_0 = (num * 1985006744u ^ 19782673u);
					continue;
				case 1u:
					goto IL_EC;
				case 3u:
					goto IL_82;
				case 4u:
					goto IL_36;
				case 5u:
					arg_5D_0 = (((bigInteger.Sign == -1) ? 4028650168u : 2508738494u) ^ num * 699542497u);
					continue;
				}
				break;
			}
			goto IL_FC;
			IL_EC:
			throw RsaCrypt.smethod_0(Module.smethod_33<string>(232536431u));
			IL_FC:
			BigInteger bigInteger2;
			return (bigInteger2 + bigInteger * this.q).ToByteArray();
			IL_36:
			arg_5D_0 = 1134742188u;
			goto IL_58;
			IL_82:
			BigInteger expr_89 = data.ToBigInteger(isBigEndian);
			BigInteger left = BigInteger.ModPow(expr_89 % this.p, this.dp, this.p);
			bigInteger2 = BigInteger.ModPow(expr_89 % this.q, this.dq, this.q);
			bigInteger = this.iq * (left - bigInteger2) % this.p;
			arg_5D_0 = 1070365730u;
			goto IL_58;
		}

		public byte[] Decrypt<T>(T data, bool isBigEndian = false)
		{
			if (this.isDecryptionInitialized)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = 239526367;
			IL_0D:
			BigInteger bigInteger;
			switch ((arg_12_0 ^ 1966150740) % 4)
			{
			case 0:
				IL_2C:
				bigInteger = BigInteger.ModPow(data.ToBigInteger(isBigEndian), this.e, this.n);
				arg_12_0 = 1511172245;
				goto IL_0D;
			case 2:
				goto IL_08;
			case 3:
				throw RsaCrypt.smethod_0(Module.smethod_35<string>(280647186u));
			}
			return bigInteger.ToByteArray();
		}

		public void Dispose()
		{
			this.e = 0;
			while (true)
			{
				IL_C3:
				uint arg_9F_0 = 4065569097u;
				while (true)
				{
					uint num;
					switch ((num = (arg_9F_0 ^ 2974304486u)) % 6u)
					{
					case 0u:
						this.p = 0;
						this.q = 0;
						this.dp = 0;
						arg_9F_0 = (num * 2306955122u ^ 474136700u);
						continue;
					case 2u:
						this.isEncryptionInitialized = false;
						arg_9F_0 = (num * 3870332532u ^ 3333208883u);
						continue;
					case 3u:
						goto IL_C3;
					case 4u:
						this.dq = 0;
						this.iq = 0;
						arg_9F_0 = (num * 4065023096u ^ 1485229962u);
						continue;
					case 5u:
						this.n = 0;
						arg_9F_0 = (num * 413936356u ^ 2893227200u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.isDecryptionInitialized = false;
		}

		static InvalidOperationException smethod_0(string string_0)
		{
			return new InvalidOperationException(string_0);
		}
	}
}
