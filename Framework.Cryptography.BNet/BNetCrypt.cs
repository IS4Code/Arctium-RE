using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Framework.Cryptography.BNet
{
	public sealed class BNetCrypt : IDisposable
	{
		private static readonly byte[] ServerEncryptionKey;

		private static readonly byte[] ServerDecryptionKey;

		private SARC4 SARC4Encrypt;

		private SARC4 SARC4Decrypt;

		public bool IsInitialized
		{
			get;
			set;
		}

		public BNetCrypt(byte[] sessionKey)
		{
			this.IsInitialized = false;
			if (this.IsInitialized)
			{
				throw BNetCrypt.smethod_0(Module.smethod_36<string>(56398324u));
			}
			this.SARC4Encrypt = new SARC4();
			this.SARC4Decrypt = new SARC4();
			HMACSHA256 hashAlgorithm_ = BNetCrypt.smethod_1(sessionKey);
			HMACSHA256 hashAlgorithm_2 = BNetCrypt.smethod_1(sessionKey);
			this.SARC4Encrypt.PrepareKey(BNetCrypt.smethod_2(hashAlgorithm_2, BNetCrypt.ServerEncryptionKey));
			this.SARC4Decrypt.PrepareKey(BNetCrypt.smethod_2(hashAlgorithm_, BNetCrypt.ServerDecryptionKey));
			this.IsInitialized = true;
		}

		public void Encrypt(byte[] data, int count)
		{
			if (this.IsInitialized)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = -407049644;
			IL_0D:
			switch ((arg_12_0 ^ -1406051805) % 4)
			{
			case 0:
				IL_2C:
				this.SARC4Encrypt.ProcessBuffer(data, count);
				arg_12_0 = -2042246406;
				goto IL_0D;
			case 2:
				goto IL_08;
			case 3:
				throw BNetCrypt.smethod_0(Module.smethod_33<string>(2782540870u));
			}
		}

		public void Decrypt(byte[] data, int count)
		{
			if (this.IsInitialized)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = -669052452;
			IL_0D:
			switch ((arg_12_0 ^ -2090713909) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				IL_2C:
				this.SARC4Decrypt.ProcessBuffer(data, count);
				arg_12_0 = -110949926;
				goto IL_0D;
			case 3:
				throw BNetCrypt.smethod_0(Module.smethod_33<string>(2782540870u));
			}
		}

		public void Dispose()
		{
			this.IsInitialized = false;
		}

		static BNetCrypt()
		{
			// Note: this type is marked as 'beforefieldinit'.
			byte[] expr_07 = new byte[16];
			BNetCrypt.smethod_3(expr_07, fieldof(Framework.<PrivateImplementationDetails>.FE5E26F28C22F788D40FAD92147032F58EC76833).FieldHandle);
			BNetCrypt.ServerEncryptionKey = expr_07;
			byte[] expr_1E = new byte[16];
			BNetCrypt.smethod_3(expr_1E, fieldof(Framework.<PrivateImplementationDetails>.F3FAF914B4E2D945DAF4562B7BE04C79D9C0F6CA).FieldHandle);
			BNetCrypt.ServerDecryptionKey = expr_1E;
		}

		static InvalidOperationException smethod_0(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static HMACSHA256 smethod_1(byte[] byte_0)
		{
			return new HMACSHA256(byte_0);
		}

		static byte[] smethod_2(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
		{
			return hashAlgorithm_0.ComputeHash(byte_0);
		}

		static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}
}
