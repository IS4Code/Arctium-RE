using System;
using System.Globalization;

namespace Framework.Network.Packets
{
	public class BitUnpack
	{
		public PacketReader reader;

		private int Position;

		private byte Value;

		public BitUnpack(PacketReader reader)
		{
			while (true)
			{
				IL_39:
				uint arg_21_0 = 3619155731u;
				while (true)
				{
					uint num;
					switch ((num = (arg_21_0 ^ 3422909037u)) % 3u)
					{
					case 0u:
						goto IL_39;
					case 2u:
						this.reader = reader;
						arg_21_0 = (num * 1788001478u ^ 905818698u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Position = 8;
			this.Value = 0;
		}

		public bool GetBit()
		{
			if (this.Position == 8)
			{
				goto IL_32;
			}
			goto IL_58;
			uint arg_3C_0;
			while (true)
			{
				IL_37:
				uint num;
				switch ((num = (arg_3C_0 ^ 497678941u)) % 4u)
				{
				case 0u:
					goto IL_32;
				case 1u:
					this.Value = this.reader.Read<byte>();
					this.Position = 0;
					arg_3C_0 = (num * 2850176051u ^ 881797017u);
					continue;
				case 3u:
					goto IL_58;
				}
				break;
			}
			int value;
			return BitUnpack.smethod_0(value >> 7);
			IL_32:
			arg_3C_0 = 475497020u;
			goto IL_37;
			IL_58:
			value = (int)this.Value;
			this.Value = (byte)(2 * value);
			this.Position++;
			arg_3C_0 = 1735234387u;
			goto IL_37;
		}

		public T GetBits<T>(byte bitCount)
		{
			int num = 0;
			while (true)
			{
				IL_99:
				uint arg_71_0 = 2709643282u;
				while (true)
				{
					uint num2;
					int arg_47_0;
					switch ((num2 = (arg_71_0 ^ 4046007670u)) % 7u)
					{
					case 0u:
						goto IL_99;
					case 1u:
					{
						if (!this.GetBit())
						{
							arg_71_0 = 2840728327u;
							continue;
						}
						int num3;
						arg_47_0 = (1 << num3 | num);
						goto IL_47;
					}
					case 2u:
						arg_47_0 = num;
						goto IL_47;
					case 3u:
						arg_71_0 = (num2 * 2404994528u ^ 3373856103u);
						continue;
					case 5u:
					{
						int num3;
						arg_71_0 = ((num3 >= 0) ? 2463017341u : 3620381330u);
						continue;
					}
					case 6u:
					{
						int num3 = (int)(checked(bitCount - 1));
						arg_71_0 = (num2 * 2650002771u ^ 1736851699u);
						continue;
					}
					}
					goto Block_3;
					IL_47:
					num = arg_47_0;
					checked
					{
						int num3;
						num3--;
						arg_71_0 = 3409958279u;
					}
				}
			}
			Block_3:
			return (T)((object)BitUnpack.smethod_3(num, BitUnpack.smethod_1(typeof(T).TypeHandle), BitUnpack.smethod_2()));
		}

		public T GetNameLength<T>(byte bitCount)
		{
			int num = 0;
			while (true)
			{
				IL_B3:
				uint arg_87_0 = 3218337352u;
				while (true)
				{
					uint num2;
					int arg_61_0;
					switch ((num2 = (arg_87_0 ^ 2211964791u)) % 8u)
					{
					case 0u:
						goto IL_B3;
					case 1u:
					{
						if (!this.GetBit())
						{
							arg_87_0 = 3412645637u;
							continue;
						}
						int num3;
						arg_61_0 = (1 << num3 | num);
						goto IL_61;
					}
					case 2u:
						arg_61_0 = num;
						goto IL_61;
					case 3u:
						checked
						{
							int num3;
							num3--;
						}
						arg_87_0 = (num2 * 501925676u ^ 199027471u);
						continue;
					case 4u:
					{
						int num3;
						arg_87_0 = ((num3 >= 0) ? 2498537230u : 4019268314u);
						continue;
					}
					case 6u:
					{
						int num3 = (int)(checked(bitCount - 1));
						arg_87_0 = (num2 * 3080884236u ^ 249762499u);
						continue;
					}
					case 7u:
						this.GetBit();
						arg_87_0 = (num2 * 1040566224u ^ 4030753881u);
						continue;
					}
					goto Block_3;
					IL_61:
					num = arg_61_0;
					arg_87_0 = 3501782828u;
				}
			}
			Block_3:
			return (T)((object)BitUnpack.smethod_3(num, BitUnpack.smethod_1(typeof(T).TypeHandle), BitUnpack.smethod_2()));
		}

		public ulong GetPackedValue(byte[] mask, byte[] bytes)
		{
			bool[] array = new bool[mask.Length];
			byte[] array2 = new byte[bytes.Length];
			while (true)
			{
				IL_146:
				uint arg_108_0 = 441439160u;
				while (true)
				{
					uint num;
					switch ((num = (arg_108_0 ^ 933494351u)) % 12u)
					{
					case 1u:
					{
						int num2;
						array[num2] = this.GetBit();
						arg_108_0 = 100237289u;
						continue;
					}
					case 2u:
					{
						byte b;
						b += 1;
						arg_108_0 = 1431210321u;
						continue;
					}
					case 3u:
					{
						int num2 = 0;
						arg_108_0 = (num * 3603751290u ^ 3824160768u);
						continue;
					}
					case 4u:
					{
						byte b;
						arg_108_0 = (array[(int)mask[(int)b]] ? 1046048734u : 1931556653u);
						continue;
					}
					case 5u:
						arg_108_0 = (num * 282635419u ^ 972547060u);
						continue;
					case 6u:
					{
						int num2;
						num2++;
						arg_108_0 = (num * 1247566402u ^ 658749947u);
						continue;
					}
					case 7u:
						goto IL_146;
					case 8u:
					{
						int num2;
						arg_108_0 = ((num2 < array.Length) ? 1770688634u : 1352437388u);
						continue;
					}
					case 9u:
					{
						byte b;
						array2[(int)bytes[(int)b]] = (this.reader.Read<byte>() ^ 1);
						arg_108_0 = (num * 2213970219u ^ 2011673462u);
						continue;
					}
					case 10u:
					{
						byte b;
						arg_108_0 = (((int)b < bytes.Length) ? 1631324147u : 952807511u);
						continue;
					}
					case 11u:
					{
						byte b = 0;
						arg_108_0 = (num * 2097342126u ^ 297623515u);
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:
			return BitUnpack.smethod_4(array2, 0);
		}

		static bool smethod_0(int int_0)
		{
			return Convert.ToBoolean(int_0);
		}

		static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static CultureInfo smethod_2()
		{
			return CultureInfo.InvariantCulture;
		}

		static object smethod_3(object object_0, Type type_0, IFormatProvider iformatProvider_0)
		{
			return Convert.ChangeType(object_0, type_0, iformatProvider_0);
		}

		static ulong smethod_4(byte[] byte_0, int int_0)
		{
			return BitConverter.ToUInt64(byte_0, int_0);
		}
	}
}
