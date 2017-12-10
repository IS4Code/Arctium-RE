using System;

namespace Google.Protobuf
{
	internal static class ByteArray
	{
		private const int CopyThreshold = 12;

		internal static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
		{
			if (count > 12)
			{
				goto IL_6D;
			}
			goto IL_C6;
			uint arg_91_0;
			int num3;
			while (true)
			{
				IL_8C:
				uint num;
				switch ((num = (arg_91_0 ^ 1930007156u)) % 10u)
				{
				case 0u:
					return;
				case 1u:
					ByteArray.smethod_0(src, srcOffset, dst, dstOffset, count);
					arg_91_0 = (num * 413042327u ^ 1632786903u);
					continue;
				case 2u:
					goto IL_6D;
				case 3u:
				{
					int num2;
					num2++;
					arg_91_0 = (num * 2391009160u ^ 1725920377u);
					continue;
				}
				case 4u:
					goto IL_C6;
				case 6u:
				{
					int num2 = srcOffset;
					arg_91_0 = (num * 2783204400u ^ 4161099569u);
					continue;
				}
				case 7u:
				{
					int num2;
					arg_91_0 = ((num2 >= num3) ? 1788008595u : 1153902532u);
					continue;
				}
				case 8u:
				{
					int num2;
					dst[dstOffset++] = src[num2];
					arg_91_0 = 1859355451u;
					continue;
				}
				case 9u:
					arg_91_0 = (num * 245412605u ^ 736293232u);
					continue;
				}
				break;
			}
			return;
			IL_6D:
			arg_91_0 = 1312584901u;
			goto IL_8C;
			IL_C6:
			num3 = srcOffset + count;
			arg_91_0 = 912022232u;
			goto IL_8C;
		}

		internal static void Reverse(byte[] bytes)
		{
			int num = 0;
			while (true)
			{
				IL_8C:
				uint arg_68_0 = 4044189016u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 2411602661u)) % 6u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
					{
						byte b = bytes[num];
						arg_68_0 = 3824140403u;
						continue;
					}
					case 3u:
					{
						int num3 = bytes.Length - 1;
						arg_68_0 = (num2 * 308520363u ^ 2779861225u);
						continue;
					}
					case 4u:
					{
						int num3;
						bytes[num] = bytes[num3];
						byte b;
						bytes[num3] = b;
						num++;
						num3--;
						arg_68_0 = (num2 * 3442540430u ^ 2982960610u);
						continue;
					}
					case 5u:
					{
						int num3;
						arg_68_0 = ((num >= num3) ? 2606236795u : 3898309236u);
						continue;
					}
					}
					return;
				}
			}
		}

		static void smethod_0(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}
	}
}
