using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Framework.Misc
{
	public static class Extensions
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Extensions.__c __9 = new Extensions.__c();

			internal object cctor>b__11_0(BinaryReader br)
			{
				return Extensions.__c.smethod_0(br);
			}

			internal object cctor>b__11_1(BinaryReader br)
			{
				return Extensions.__c.smethod_1(br);
			}

			internal object cctor>b__11_2(BinaryReader br)
			{
				return Extensions.__c.smethod_2(br);
			}

			internal object cctor>b__11_3(BinaryReader br)
			{
				return Extensions.__c.smethod_3(br);
			}

			internal object cctor>b__11_4(BinaryReader br)
			{
				return Extensions.__c.smethod_4(br);
			}

			internal object cctor>b__11_5(BinaryReader br)
			{
				return Extensions.__c.smethod_5(br);
			}

			internal object cctor>b__11_6(BinaryReader br)
			{
				return Extensions.__c.smethod_6(br);
			}

			internal object cctor>b__11_7(BinaryReader br)
			{
				return Extensions.__c.smethod_7(br);
			}

			internal object cctor>b__11_8(BinaryReader br)
			{
				return Extensions.__c.smethod_8(br);
			}

			internal object cctor>b__11_9(BinaryReader br)
			{
				return Extensions.__c.smethod_9(br);
			}

			internal object cctor>b__11_10(BinaryReader br)
			{
				return Extensions.__c.smethod_10(br);
			}

			internal object cctor>b__11_11(BinaryReader br)
			{
				return Extensions.__c.smethod_11(br);
			}

			static bool smethod_0(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadBoolean();
			}

			static sbyte smethod_1(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadSByte();
			}

			static byte smethod_2(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadByte();
			}

			static char smethod_3(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadChar();
			}

			static short smethod_4(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadInt16();
			}

			static ushort smethod_5(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadUInt16();
			}

			static int smethod_6(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadInt32();
			}

			static uint smethod_7(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadUInt32();
			}

			static float smethod_8(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadSingle();
			}

			static long smethod_9(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadInt64();
			}

			static ulong smethod_10(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadUInt64();
			}

			static double smethod_11(BinaryReader binaryReader_0)
			{
				return binaryReader_0.ReadDouble();
			}
		}

		public static Dictionary<Type, Func<BinaryReader, object>> ReadValue = new Dictionary<Type, Func<BinaryReader, object>>
		{
			{
				Extensions.smethod_0(typeof(bool).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_0)
			},
			{
				Extensions.smethod_0(typeof(sbyte).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_1)
			},
			{
				Extensions.smethod_0(typeof(byte).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_2)
			},
			{
				Extensions.smethod_0(typeof(char).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_3)
			},
			{
				Extensions.smethod_0(typeof(short).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_4)
			},
			{
				Extensions.smethod_0(typeof(ushort).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_5)
			},
			{
				Extensions.smethod_0(typeof(int).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_6)
			},
			{
				Extensions.smethod_0(typeof(uint).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_7)
			},
			{
				Extensions.smethod_0(typeof(float).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_8)
			},
			{
				Extensions.smethod_0(typeof(long).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_9)
			},
			{
				Extensions.smethod_0(typeof(ulong).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_10)
			},
			{
				Extensions.smethod_0(typeof(double).TypeHandle),
				new Func<BinaryReader, object>(Extensions.__c.__9.<.cctor>b__11_11)
			}
		};

		public static BigInteger ToBigInteger<T>(this T value, bool isBigEndian = false)
		{
			BigInteger result = BigInteger.Zero;
			while (true)
			{
				IL_19C:
				uint arg_157_0 = 738196809u;
				while (true)
				{
					uint num;
					switch ((num = (arg_157_0 ^ 1881679713u)) % 14u)
					{
					case 0u:
					{
						byte[] array;
						result = new BigInteger(array.Combine(new byte[1]));
						arg_157_0 = 1243074766u;
						continue;
					}
					case 2u:
						goto IL_1A3;
					case 3u:
						arg_157_0 = (num * 3809464151u ^ 121923501u);
						continue;
					case 4u:
						goto IL_19C;
					case 5u:
						arg_157_0 = (num * 104884441u ^ 2709228320u);
						continue;
					case 6u:
						arg_157_0 = (((!isBigEndian) ? 3935607711u : 2903685637u) ^ num * 874937281u);
						continue;
					case 7u:
					{
						byte[] array = value as byte[];
						arg_157_0 = 852318715u;
						continue;
					}
					case 8u:
					{
						string string_;
						arg_157_0 = ((Extensions.smethod_2(string_, Module.smethod_34<string>(3746852854u)) ? 4030407210u : 4191734426u) ^ num * 2223128030u);
						continue;
					}
					case 9u:
						result = (BigInteger)Extensions.smethod_4(value, Extensions.smethod_0(typeof(BigInteger).TypeHandle));
						arg_157_0 = 215214242u;
						continue;
					case 10u:
					{
						byte[] array;
						Extensions.smethod_3(array);
						arg_157_0 = (num * 2021617067u ^ 188326575u);
						continue;
					}
					case 11u:
						arg_157_0 = (num * 1358535682u ^ 1128118610u);
						continue;
					case 12u:
					{
						string string_ = Extensions.smethod_1(Extensions.smethod_0(typeof(T).TypeHandle));
						arg_157_0 = (num * 1912532131u ^ 2190573618u);
						continue;
					}
					case 13u:
					{
						string string_;
						arg_157_0 = ((Extensions.smethod_2(string_, Module.smethod_33<string>(4146773235u)) ? 1965301917u : 1104158180u) ^ num * 3173283713u);
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:
			return result;
			IL_1A3:
			throw Extensions.smethod_6(Extensions.smethod_5(Module.smethod_34<string>(3653116242u), Extensions.smethod_1(Extensions.smethod_0(typeof(T).TypeHandle))));
		}

		public static T Read<T>(this BinaryReader br)
		{
			Type arg_4C_0;
			if (Extensions.smethod_7(Extensions.smethod_0(typeof(T).TypeHandle)))
			{
				arg_4C_0 = Extensions.smethod_8(Extensions.smethod_0(typeof(T).TypeHandle));
				goto IL_4C;
			}
			IL_22:
			int arg_2C_0 = 901987807;
			IL_27:
			switch ((arg_2C_0 ^ 752898713) % 3)
			{
			case 0:
				goto IL_22;
			case 1:
				arg_4C_0 = Extensions.smethod_0(typeof(T).TypeHandle);
				goto IL_4C;
			}
			Type key;
			return (T)((object)Extensions.ReadValue[key](br));
			IL_4C:
			key = arg_4C_0;
			arg_2C_0 = 2115462080;
			goto IL_27;
		}

		public static uint LeftRotate(this uint value, int shiftCount)
		{
			return value << shiftCount | value >> 32 - shiftCount;
		}

		public static byte[] ToByteArray(this string s)
		{
			byte[] array = new byte[Extensions.smethod_9(s) / 2];
			while (true)
			{
				IL_9B:
				uint arg_77_0 = 1740915620u;
				while (true)
				{
					uint num;
					switch ((num = (arg_77_0 ^ 193058088u)) % 6u)
					{
					case 0u:
					{
						int num2;
						arg_77_0 = ((num2 >= Extensions.smethod_9(s)) ? 1754018344u : 953576485u);
						continue;
					}
					case 1u:
					{
						int num2;
						num2 += 2;
						arg_77_0 = (num * 3520985443u ^ 2491188557u);
						continue;
					}
					case 2u:
					{
						int num2 = 0;
						arg_77_0 = (num * 3641561811u ^ 2529371062u);
						continue;
					}
					case 3u:
					{
						int num2;
						array[num2 / 2] = Extensions.smethod_11(Extensions.smethod_10(s, num2, 2), 16);
						arg_77_0 = 555942589u;
						continue;
					}
					case 5u:
						goto IL_9B;
					}
					return array;
				}
			}
			return array;
		}

		public static byte[] GenerateRandomKey(this byte[] s, int length)
		{
			Random random_ = Extensions.smethod_12((int)((uint)(Guid.NewGuid().GetHashCode() ^ 0 ^ 42)).LeftRotate(13));
			byte[] array;
			while (true)
			{
				IL_13B:
				uint arg_105_0 = 120113419u;
				while (true)
				{
					uint num;
					switch ((num = (arg_105_0 ^ 1256982358u)) % 10u)
					{
					case 0u:
					{
						int num2;
						int num3;
						array[num2] = (byte)num3;
						arg_105_0 = 1719345575u;
						continue;
					}
					case 1u:
					{
						int num3;
						arg_105_0 = (((num3 <= 0) ? 3384374318u : 3091792628u) ^ num * 4266107050u);
						continue;
					}
					case 2u:
						goto IL_13B;
					case 3u:
					{
						int num2;
						arg_105_0 = ((num2 < length) ? 996703468u : 216281029u);
						continue;
					}
					case 4u:
					{
						int num3 = -1;
						arg_105_0 = 56133732u;
						continue;
					}
					case 6u:
					{
						int num2;
						int num3 = (int)(((uint)Extensions.smethod_13(random_, 255)).LeftRotate(1) ^ (uint)num2);
						arg_105_0 = ((num3 <= 255) ? 1923677886u : 1723990471u);
						continue;
					}
					case 7u:
					{
						array = new byte[length];
						int num2 = 0;
						arg_105_0 = (num * 1583590343u ^ 3566949175u);
						continue;
					}
					case 8u:
						arg_105_0 = (num * 1084251023u ^ 3191990515u);
						continue;
					case 9u:
					{
						int num2;
						num2++;
						arg_105_0 = (num * 2817311159u ^ 4236777410u);
						continue;
					}
					}
					return array;
				}
			}
			return array;
		}

		public static bool Compare(this byte[] b, byte[] b2)
		{
			int num = 0;
			while (true)
			{
				IL_8C:
				uint arg_64_0 = 3291318834u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_64_0 ^ 4055349845u)) % 7u)
					{
					case 0u:
						num++;
						arg_64_0 = 3026166759u;
						continue;
					case 1u:
						arg_64_0 = ((b[num] == b2[num]) ? 3750588544u : 3567267048u);
						continue;
					case 3u:
						goto IL_8C;
					case 4u:
						return false;
					case 5u:
						arg_64_0 = (num2 * 2293459859u ^ 2107014082u);
						continue;
					case 6u:
						arg_64_0 = ((num < b2.Length) ? 3202267482u : 3101804024u);
						continue;
					}
					return true;
				}
			}
			return true;
		}

		public static byte[] Combine(this byte[] data, byte[] data2)
		{
			byte[] array = new byte[data.Length + data2.Length];
			Extensions.smethod_14(data, 0, array, 0, data.Length);
			Extensions.smethod_14(data2, 0, array, data.Length, data2.Length);
			return array;
		}

		public static string ToHexString(this byte[] data)
		{
			string string_ = "";
			int num = 0;
			while (true)
			{
				IL_A1:
				uint arg_7C_0 = 3025571063u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_7C_0 ^ 2262366021u)) % 6u)
					{
					case 1u:
						arg_7C_0 = ((num < data.Length) ? 3077999305u : 3082205453u);
						continue;
					case 2u:
					{
						byte b = data[num];
						arg_7C_0 = 3263439534u;
						continue;
					}
					case 3u:
						goto IL_A1;
					case 4u:
						arg_7C_0 = (num2 * 2873672719u ^ 425117212u);
						continue;
					case 5u:
					{
						byte b;
						string_ = Extensions.smethod_15(string_, Extensions.smethod_5(Module.smethod_37<string>(726286206u), b));
						num++;
						arg_7C_0 = (num2 * 2798341389u ^ 3425487517u);
						continue;
					}
					}
					goto Block_2;
				}
			}
			Block_2:
			return Extensions.smethod_16(string_);
		}

		public static BigInteger MakeBigInteger(this byte[] data, bool isBigEndian = false)
		{
			if (isBigEndian)
			{
				while (true)
				{
					IL_35:
					uint arg_1D_0 = 698627849u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1D_0 ^ 930933096u)) % 3u)
						{
						case 0u:
							goto IL_35;
						case 1u:
							Extensions.smethod_3(data);
							arg_1D_0 = (num * 2848130399u ^ 1535533374u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return new BigInteger(data.Combine(new byte[1]));
		}

		public static BigInteger AssignValue<T>(this T value, bool isBigEndian = false)
		{
			BigInteger result = BigInteger.Zero;
			while (true)
			{
				IL_12A:
				uint arg_F5_0 = 953985398u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F5_0 ^ 1752643158u)) % 10u)
					{
					case 0u:
						goto IL_12A;
					case 1u:
						goto IL_131;
					case 2u:
					{
						string string_ = Extensions.smethod_1(Extensions.smethod_0(typeof(T).TypeHandle));
						arg_F5_0 = (num * 1078732044u ^ 3318060986u);
						continue;
					}
					case 4u:
						arg_F5_0 = (num * 3287323447u ^ 3136656083u);
						continue;
					case 5u:
						result = (BigInteger)Extensions.smethod_4(value, Extensions.smethod_0(typeof(BigInteger).TypeHandle));
						arg_F5_0 = 995841158u;
						continue;
					case 6u:
					{
						string string_;
						arg_F5_0 = (((!Extensions.smethod_2(string_, Module.smethod_36<string>(2054699854u))) ? 3601814283u : 3356641915u) ^ num * 2724701389u);
						continue;
					}
					case 7u:
						result = (value as byte[]).MakeBigInteger(isBigEndian);
						arg_F5_0 = 365760265u;
						continue;
					case 8u:
						arg_F5_0 = (num * 393761767u ^ 1734055609u);
						continue;
					case 9u:
					{
						string string_;
						arg_F5_0 = ((Extensions.smethod_2(string_, Module.smethod_36<string>(3151577565u)) ? 1077484870u : 1388529681u) ^ num * 2864711009u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			return result;
			IL_131:
			throw Extensions.smethod_6(Extensions.smethod_5(Module.smethod_33<string>(2248670866u), Extensions.smethod_1(Extensions.smethod_0(typeof(T).TypeHandle))));
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static string smethod_1(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static bool smethod_2(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static void smethod_3(Array array_0)
		{
			Array.Reverse(array_0);
		}

		static object smethod_4(object object_0, Type type_0)
		{
			return Convert.ChangeType(object_0, type_0);
		}

		static string smethod_5(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static NotSupportedException smethod_6(string string_0)
		{
			return new NotSupportedException(string_0);
		}

		static bool smethod_7(Type type_0)
		{
			return type_0.IsEnum;
		}

		static Type smethod_8(Type type_0)
		{
			return type_0.GetEnumUnderlyingType();
		}

		static int smethod_9(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_10(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		static byte smethod_11(string string_0, int int_0)
		{
			return Convert.ToByte(string_0, int_0);
		}

		static Random smethod_12(int int_0)
		{
			return new Random(int_0);
		}

		static int smethod_13(Random random_0, int int_0)
		{
			return random_0.Next(int_0);
		}

		static void smethod_14(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static string smethod_15(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static string smethod_16(string string_0)
		{
			return string_0.ToUpper();
		}
	}
}
