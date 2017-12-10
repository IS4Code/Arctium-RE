using System;

namespace Framework.Cryptography
{
	public sealed class SARC4
	{
		private byte[] s;

		private byte tmp;

		private byte tmp2;

		public SARC4()
		{
			this.s = new byte[256];
			this.tmp = 0;
			this.tmp2 = 0;
		}

		public void PrepareKey(byte[] key)
		{
			int num = 0;
			while (true)
			{
				IL_159:
				uint arg_11B_0 = 596633954u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_11B_0 ^ 1636435107u)) % 12u)
					{
					case 0u:
						arg_11B_0 = (num2 * 1137262568u ^ 4232918736u);
						continue;
					case 1u:
					{
						int num3 = 0;
						int num4 = 0;
						arg_11B_0 = (num2 * 902121721u ^ 3907740830u);
						continue;
					}
					case 2u:
					{
						int num4;
						int num3 = (int)((byte)((num3 + (int)this.s[num4] + (int)key[num4 % key.Length]) % 256));
						byte b = this.s[num4];
						arg_11B_0 = 58710329u;
						continue;
					}
					case 3u:
						goto IL_159;
					case 4u:
					{
						int num4;
						num4++;
						arg_11B_0 = (num2 * 1156866267u ^ 3165203104u);
						continue;
					}
					case 5u:
						arg_11B_0 = ((num < 256) ? 1820122929u : 969498250u);
						continue;
					case 6u:
						this.s[num] = (byte)num;
						num++;
						arg_11B_0 = 2129022438u;
						continue;
					case 7u:
					{
						int num4;
						arg_11B_0 = ((num4 >= 256) ? 1216862808u : 1105516645u);
						continue;
					}
					case 8u:
					{
						int num3;
						byte b;
						this.s[num3] = b;
						arg_11B_0 = (num2 * 3649499085u ^ 1967475591u);
						continue;
					}
					case 9u:
						arg_11B_0 = (num2 * 3633298005u ^ 2674091763u);
						continue;
					case 10u:
					{
						int num3;
						int num4;
						this.s[num4] = this.s[num3];
						arg_11B_0 = (num2 * 1629411718u ^ 2579364187u);
						continue;
					}
					}
					return;
				}
			}
		}

		public void ProcessBuffer(byte[] data, int length)
		{
			int num = 0;
			while (true)
			{
				IL_119:
				uint arg_E6_0 = (num < length) ? 1735696282u : 644965877u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E6_0 ^ 1497147913u)) % 6u)
					{
					case 1u:
						this.tmp = (byte)((int)(this.tmp + 1) % 256);
						arg_E6_0 = 748557597u;
						continue;
					case 2u:
						goto IL_119;
					case 3u:
						arg_E6_0 = 1735696282u;
						continue;
					case 4u:
						this.tmp2 = (byte)((int)(this.tmp2 + this.s[(int)this.tmp]) % 256);
						arg_E6_0 = (num2 * 2775160414u ^ 2707190840u);
						continue;
					case 5u:
					{
						byte b = this.s[(int)this.tmp];
						this.s[(int)this.tmp] = this.s[(int)this.tmp2];
						this.s[(int)this.tmp2] = b;
						data[num] = (this.s[(int)(this.s[(int)this.tmp] + this.s[(int)this.tmp2]) % 256] ^ data[num]);
						num++;
						arg_E6_0 = (num2 * 2145145262u ^ 42414599u);
						continue;
					}
					}
					return;
				}
			}
		}
	}
}
