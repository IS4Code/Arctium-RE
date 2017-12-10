using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Framework.Cryptography.WoW
{
	public sealed class WoWCrypt : IDisposable
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

		public WoWCrypt()
		{
			this.IsInitialized = false;
		}

		public void Initialize(byte[] sessionKey)
		{
			this.IsInitialized = false;
			while (true)
			{
				IL_12E:
				uint arg_101_0 = 2073740479u;
				while (true)
				{
					uint num;
					switch ((num = (arg_101_0 ^ 2103882194u)) % 8u)
					{
					case 0u:
					{
						byte[] array = new byte[1024];
						byte[] array2 = new byte[1024];
						this.SARC4Encrypt.ProcessBuffer(array, array.Length);
						this.SARC4Decrypt.ProcessBuffer(array2, array2.Length);
						this.IsInitialized = true;
						arg_101_0 = (num * 483766584u ^ 1925911129u);
						continue;
					}
					case 1u:
					{
						this.SARC4Decrypt = new SARC4();
						HMACSHA1 hashAlgorithm_ = WoWCrypt.smethod_1(WoWCrypt.ServerDecryptionKey);
						HMACSHA1 hashAlgorithm_2 = WoWCrypt.smethod_1(WoWCrypt.ServerEncryptionKey);
						arg_101_0 = (num * 1947262690u ^ 1312804196u);
						continue;
					}
					case 2u:
						goto IL_12E;
					case 4u:
					{
						HMACSHA1 hashAlgorithm_2;
						this.SARC4Encrypt.PrepareKey(WoWCrypt.smethod_2(hashAlgorithm_2, sessionKey));
						HMACSHA1 hashAlgorithm_;
						this.SARC4Decrypt.PrepareKey(WoWCrypt.smethod_2(hashAlgorithm_, sessionKey));
						arg_101_0 = (num * 1816278399u ^ 758351854u);
						continue;
					}
					case 5u:
						arg_101_0 = (((!this.IsInitialized) ? 3269098579u : 2838635962u) ^ num * 4003455326u);
						continue;
					case 6u:
						goto IL_135;
					case 7u:
						this.SARC4Encrypt = new SARC4();
						arg_101_0 = 946657131u;
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			return;
			IL_135:
			throw WoWCrypt.smethod_0(Module.smethod_35<string>(3386492916u));
		}

		public void Initialize(byte[] sessionKey, byte[] clientSeed, byte[] serverSeed)
		{
			this.IsInitialized = false;
			if (this.IsInitialized)
			{
				goto IL_E2;
			}
			goto IL_11E;
			uint arg_EC_0;
			while (true)
			{
				IL_E7:
				uint num;
				switch ((num = (arg_EC_0 ^ 411909969u)) % 9u)
				{
				case 0u:
					goto IL_E2;
				case 1u:
				{
					byte[] array = new byte[1024];
					arg_EC_0 = (num * 4112686248u ^ 3760825414u);
					continue;
				}
				case 2u:
				{
					byte[] array2;
					this.SARC4Encrypt.ProcessBuffer(array2, array2.Length);
					arg_EC_0 = (num * 3888587318u ^ 4000620574u);
					continue;
				}
				case 3u:
				{
					this.SARC4Decrypt = new SARC4();
					HMACSHA1 hashAlgorithm_ = WoWCrypt.smethod_1(serverSeed);
					HMACSHA1 hashAlgorithm_2 = WoWCrypt.smethod_1(clientSeed);
					arg_EC_0 = (num * 2152563200u ^ 767503809u);
					continue;
				}
				case 5u:
				{
					HMACSHA1 hashAlgorithm_2;
					this.SARC4Encrypt.PrepareKey(WoWCrypt.smethod_2(hashAlgorithm_2, sessionKey));
					HMACSHA1 hashAlgorithm_;
					this.SARC4Decrypt.PrepareKey(WoWCrypt.smethod_2(hashAlgorithm_, sessionKey));
					byte[] array2 = new byte[1024];
					arg_EC_0 = (num * 2323342343u ^ 3057383575u);
					continue;
				}
				case 6u:
				{
					byte[] array;
					this.SARC4Decrypt.ProcessBuffer(array, array.Length);
					this.IsInitialized = true;
					arg_EC_0 = (num * 162284483u ^ 1051040720u);
					continue;
				}
				case 7u:
					goto IL_11E;
				case 8u:
					goto IL_130;
				}
				break;
			}
			return;
			IL_130:
			throw WoWCrypt.smethod_0(Module.smethod_35<string>(3386492916u));
			IL_E2:
			arg_EC_0 = 1557707004u;
			goto IL_E7;
			IL_11E:
			this.SARC4Encrypt = new SARC4();
			arg_EC_0 = 564654211u;
			goto IL_E7;
		}

		public void Encrypt(byte[] data, int count)
		{
			if (this.IsInitialized)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = 1459186387;
			IL_0D:
			switch ((arg_12_0 ^ 1059757101) % 4)
			{
			case 1:
				IL_2C:
				this.SARC4Encrypt.ProcessBuffer(data, count);
				arg_12_0 = 848727185;
				goto IL_0D;
			case 2:
				throw WoWCrypt.smethod_0(Module.smethod_36<string>(1494787757u));
			case 3:
				goto IL_08;
			}
		}

		public void Decrypt(byte[] data, int count)
		{
			if (this.IsInitialized)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = 768022319;
			IL_0D:
			switch ((arg_12_0 ^ 2044698726) % 4)
			{
			case 0:
				IL_2C:
				this.SARC4Decrypt.ProcessBuffer(data, count);
				arg_12_0 = 558064304;
				goto IL_0D;
			case 1:
				throw WoWCrypt.smethod_0(Module.smethod_37<string>(1106446649u));
			case 3:
				goto IL_08;
			}
		}

		public void Dispose()
		{
			this.IsInitialized = false;
		}

		static WoWCrypt()
		{
			// Note: this type is marked as 'beforefieldinit'.
			byte[] expr_07 = new byte[16];
			WoWCrypt.smethod_3(expr_07, fieldof(Framework.<PrivateImplementationDetails>.A5614CF8A256BD624776F8BBAC105E523496B2BF).FieldHandle);
			WoWCrypt.ServerEncryptionKey = expr_07;
			byte[] expr_1E = new byte[16];
			WoWCrypt.smethod_3(expr_1E, fieldof(Framework.<PrivateImplementationDetails>.B64704505A6F7DA9DC7BB76B2684DEEF1ADFB915).FieldHandle);
			WoWCrypt.ServerDecryptionKey = expr_1E;
		}

		static InvalidOperationException smethod_0(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static HMACSHA1 smethod_1(byte[] byte_0)
		{
			return new HMACSHA1(byte_0);
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
