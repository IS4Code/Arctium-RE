using System;
using System.Security.Cryptography;
using System.Text;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class HmacHash : HMACSHA1
	{
		public byte[] Digest
		{
			get;
			private set;
		}

		public HmacHash(byte[] key) : base(key, true)
		{
			while (true)
			{
				IL_3A:
				uint arg_22_0 = 3010620136u;
				while (true)
				{
					uint num;
					switch ((num = (arg_22_0 ^ 2699801612u)) % 3u)
					{
					case 0u:
						goto IL_3A;
					case 1u:
						HmacHash.smethod_0(this);
						arg_22_0 = (num * 3559114196u ^ 1693912905u);
						continue;
					}
					return;
				}
			}
		}

		public void Process(byte[] data, int length)
		{
			this.method_0(data, 0, length, data, 0);
		}

		public void Process(uint data)
		{
			byte[] array = HmacHash.smethod_1(data);
			this.method_0(array, 0, array.Length, array, 0);
		}

		public void Process(string data)
		{
			byte[] array = HmacHash.smethod_3(HmacHash.smethod_2(), data);
			this.method_0(array, 0, array.Length, array, 0);
		}

		public void Finish(byte[] data, int length)
		{
			this.method_1(data, 0, length);
			while (true)
			{
				IL_42:
				uint arg_2A_0 = 2162501635u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2A_0 ^ 2449147266u)) % 3u)
					{
					case 0u:
						goto IL_42;
					case 2u:
						this.Digest = HmacHash.smethod_4(this);
						arg_2A_0 = (num * 1577460123u ^ 632273006u);
						continue;
					}
					return;
				}
			}
		}

		public void Finish(string data)
		{
			byte[] array = HmacHash.smethod_3(HmacHash.smethod_2(), data);
			while (true)
			{
				IL_50:
				uint arg_38_0 = 3982832027u;
				while (true)
				{
					uint num;
					switch ((num = (arg_38_0 ^ 3859150612u)) % 3u)
					{
					case 1u:
						this.method_1(array, 0, array.Length);
						this.Digest = HmacHash.smethod_4(this);
						arg_38_0 = (num * 2414475336u ^ 1000737194u);
						continue;
					case 2u:
						goto IL_50;
					}
					return;
				}
			}
		}

		static void smethod_0(HashAlgorithm hashAlgorithm_0)
		{
			hashAlgorithm_0.Initialize();
		}

		int method_0(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
		{
			return base.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
		}

		static byte[] smethod_1(uint uint_0)
		{
			return BitConverter.GetBytes(uint_0);
		}

		static Encoding smethod_2()
		{
			return Encoding.ASCII;
		}

		static byte[] smethod_3(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		byte[] method_1(byte[] byte_0, int int_0, int int_1)
		{
			return base.TransformFinalBlock(byte_0, int_0, int_1);
		}

		static byte[] smethod_4(HashAlgorithm hashAlgorithm_0)
		{
			return hashAlgorithm_0.Hash;
		}
	}
}
