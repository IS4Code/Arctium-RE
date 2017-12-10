using Framework.Constants.Net;
using Framework.Misc;
using System;
using System.IO;
using System.Text;

namespace Framework.Network.Packets
{
	public class AuthPacket
	{
		private object stream;

		private byte bytePart;

		private byte preByte;

		private int count;

		public AuthPacketHeader Header
		{
			get;
			set;
		}

		public byte[] Data
		{
			get;
			set;
		}

		public int ProcessedBytes
		{
			get;
			set;
		}

		public AuthPacket()
		{
			while (true)
			{
				IL_42:
				uint arg_2A_0 = 575686330u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2A_0 ^ 1375028428u)) % 3u)
					{
					case 1u:
						this.stream = AuthPacket.smethod_1(AuthPacket.smethod_0());
						arg_2A_0 = (num * 3148369998u ^ 2997472847u);
						continue;
					case 2u:
						goto IL_42;
					}
					return;
				}
			}
		}

		public AuthPacket(byte[] data, int size)
		{
			while (true)
			{
				IL_C9:
				uint arg_A5_0 = 1445719530u;
				while (true)
				{
					uint num;
					switch ((num = (arg_A5_0 ^ 859620147u)) % 6u)
					{
					case 1u:
						this.Header.Message = this.Read<byte>(6);
						arg_A5_0 = (num * 1334912898u ^ 628600217u);
						continue;
					case 2u:
						arg_A5_0 = ((this.Read<bool>(1) ? 393606493u : 137688773u) ^ num * 4214401147u);
						continue;
					case 3u:
						this.stream = AuthPacket.smethod_3(AuthPacket.smethod_2(data));
						this.Header = new AuthPacketHeader();
						arg_A5_0 = (num * 515657235u ^ 1769185713u);
						continue;
					case 4u:
						this.Header.Channel = (AuthChannel)this.Read<byte>(4);
						arg_A5_0 = (num * 2930748750u ^ 179895641u);
						continue;
					case 5u:
						goto IL_C9;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.Data = new byte[size];
			AuthPacket.smethod_4(data, 0, this.Data, 0, size);
		}

		public AuthPacket(AuthServerMessage message, AuthChannel channel = AuthChannel.None)
		{
			while (true)
			{
				IL_111:
				uint arg_E5_0 = 4169648401u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E5_0 ^ 2523131924u)) % 8u)
					{
					case 0u:
						goto IL_111;
					case 2u:
						this.Header = new AuthPacketHeader();
						arg_E5_0 = (num * 4138080164u ^ 2675252904u);
						continue;
					case 3u:
						this.Write<byte>((byte)this.Header.Channel, 4);
						arg_E5_0 = (num * 3127461979u ^ 2628254444u);
						continue;
					case 4u:
						this.Header.Message = (byte)message;
						arg_E5_0 = (num * 1888841257u ^ 182257382u);
						continue;
					case 5u:
						this.stream = AuthPacket.smethod_1(AuthPacket.smethod_0());
						arg_E5_0 = (num * 4268182235u ^ 1808986985u);
						continue;
					case 6u:
					{
						this.Header.Channel = channel;
						bool flag = channel > AuthChannel.None;
						this.Write<byte>(this.Header.Message, 6);
						arg_E5_0 = (num * 1702613302u ^ 3433456695u);
						continue;
					}
					case 7u:
					{
						bool flag;
						this.Write<bool>(flag, 1);
						arg_E5_0 = (((!flag) ? 1611924362u : 28007344u) ^ num * 3110452489u);
						continue;
					}
					}
					return;
				}
			}
		}

		public void Finish()
		{
			BinaryWriter binaryWriter_ = this.stream as BinaryWriter;
			this.Data = new byte[AuthPacket.smethod_6(AuthPacket.smethod_5(binaryWriter_))];
			AuthPacket.smethod_7(AuthPacket.smethod_5(binaryWriter_), 0L, SeekOrigin.Begin);
			while (true)
			{
				IL_E1:
				uint arg_B9_0 = 1466481927u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B9_0 ^ 1551557017u)) % 7u)
					{
					case 0u:
						arg_B9_0 = (num * 2253729810u ^ 227172829u);
						continue;
					case 2u:
					{
						int num2;
						arg_B9_0 = ((num2 < this.Data.Length) ? 2122156349u : 255820720u);
						continue;
					}
					case 3u:
						AuthPacket.smethod_9(binaryWriter_);
						arg_B9_0 = (num * 567103296u ^ 58757299u);
						continue;
					case 4u:
						goto IL_E1;
					case 5u:
					{
						int num2;
						this.Data[num2] = (byte)AuthPacket.smethod_8(AuthPacket.smethod_5(binaryWriter_));
						num2++;
						arg_B9_0 = 1863802127u;
						continue;
					}
					case 6u:
					{
						int num2 = 0;
						arg_B9_0 = (num * 2791334335u ^ 1099283738u);
						continue;
					}
					}
					return;
				}
			}
		}

		public T Read<T>()
		{
			BinaryReader expr_0B = this.stream as BinaryReader;
			if (expr_0B == null)
			{
				throw AuthPacket.smethod_10("");
			}
			return expr_0B.Read<T>();
		}

		public byte[] Read(int count)
		{
			BinaryReader expr_0B = this.stream as BinaryReader;
			if (expr_0B == null)
			{
				throw AuthPacket.smethod_10("");
			}
			this.ProcessedBytes += count;
			return AuthPacket.smethod_11(expr_0B, count);
		}

		public string ReadString(int count)
		{
			return AuthPacket.smethod_13(AuthPacket.smethod_12(), this.Read(count));
		}

		public T Read<T>(int bits)
		{
			ulong num = 0uL;
			int num2 = 0;
			while (true)
			{
				IL_174:
				uint arg_137_0 = 3555674250u;
				while (true)
				{
					uint num3;
					switch ((num3 = (arg_137_0 ^ 3548092431u)) % 12u)
					{
					case 0u:
						arg_137_0 = (((num2 < bits) ? 1393347338u : 1826137086u) ^ num3 * 3315800535u);
						continue;
					case 1u:
						num2 = bits;
						arg_137_0 = (num3 * 2296605026u ^ 3989491448u);
						continue;
					case 2u:
						goto IL_174;
					case 3u:
						this.bytePart = this.Read<byte>();
						arg_137_0 = (num3 * 1061505809u ^ 2825260414u);
						continue;
					case 5u:
						bits -= num2;
						arg_137_0 = 3196994772u;
						continue;
					case 6u:
						arg_137_0 = ((this.count % 8 != 0) ? 2688345364u : 3582494364u);
						continue;
					case 7u:
					{
						int num4;
						num |= (ulong)((ulong)(this.bytePart >> num4 & (int)((byte)(1 << num2) - 1)) << bits);
						this.count += num2;
						arg_137_0 = (num3 * 711456157u ^ 1145706872u);
						continue;
					}
					case 8u:
						arg_137_0 = ((bits != 0) ? 3190377533u : 3490406871u);
						continue;
					case 9u:
						arg_137_0 = (num3 * 4100535845u ^ 100802830u);
						continue;
					case 10u:
						this.ProcessedBytes++;
						arg_137_0 = (num3 * 1932297174u ^ 2224319960u);
						continue;
					case 11u:
					{
						int num4 = this.count & 7;
						num2 = 8 - num4;
						arg_137_0 = 3565036863u;
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:
			return (T)((object)AuthPacket.smethod_15(num, AuthPacket.smethod_14(typeof(T).TypeHandle)));
		}

		public string ReadFourCC()
		{
			byte[] array = AuthPacket.smethod_16(this.Read<uint>(32));
			while (true)
			{
				IL_40:
				uint arg_28_0 = 1971614857u;
				while (true)
				{
					uint num;
					switch ((num = (arg_28_0 ^ 546170987u)) % 3u)
					{
					case 0u:
						goto IL_40;
					case 2u:
						AuthPacket.smethod_17(array);
						arg_28_0 = (num * 568442981u ^ 4157547354u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return AuthPacket.smethod_18(AuthPacket.smethod_13(AuthPacket.smethod_12(), array), new char[1]);
		}

		public void Write<T>(T value)
		{
			BinaryWriter binaryWriter = this.stream as BinaryWriter;
			while (true)
			{
				IL_1FB:
				uint arg_18E_0 = 3721335647u;
				while (true)
				{
					uint num;
					switch ((num = (arg_18E_0 ^ 3850814296u)) % 24u)
					{
					case 0u:
						return;
					case 1u:
						goto IL_107;
					case 2u:
						goto IL_14F;
					case 3u:
						this.Flush();
						arg_18E_0 = (num * 825481829u ^ 3064178000u);
						continue;
					case 4u:
						goto IL_11F;
					case 5u:
						goto IL_137;
					case 6u:
						arg_18E_0 = (num * 4014390826u ^ 3274484134u);
						continue;
					case 7u:
					{
						TypeCode typeCode;
						switch (typeCode)
						{
						case TypeCode.SByte:
							goto IL_234;
						case TypeCode.Byte:
							goto IL_107;
						case TypeCode.Int16:
							goto IL_94;
						case TypeCode.UInt16:
							goto IL_20F;
						case TypeCode.Int32:
							goto IL_11F;
						case TypeCode.UInt32:
							goto IL_137;
						case TypeCode.Int64:
							goto IL_222;
						case TypeCode.UInt64:
							goto IL_247;
						case TypeCode.Single:
							goto IL_14F;
						default:
							arg_18E_0 = (num * 2762671822u ^ 313630772u);
							continue;
						}
						break;
					}
					case 8u:
						return;
					case 9u:
						goto IL_204;
					case 10u:
						goto IL_20F;
					case 11u:
						return;
					case 12u:
					{
						TypeCode typeCode = AuthPacket.smethod_19(AuthPacket.smethod_14(typeof(T).TypeHandle));
						arg_18E_0 = 2367109391u;
						continue;
					}
					case 13u:
						goto IL_94;
					case 14u:
						goto IL_222;
					case 15u:
					{
						byte[] byte_ = value as byte[];
						AuthPacket.smethod_39(binaryWriter, byte_);
						arg_18E_0 = (num * 3201777706u ^ 281211471u);
						continue;
					}
					case 16u:
						goto IL_234;
					case 18u:
						arg_18E_0 = ((!AuthPacket.smethod_38(AuthPacket.smethod_14(typeof(T).TypeHandle), AuthPacket.smethod_14(typeof(byte[]).TypeHandle))) ? 2322063593u : 3547962235u);
						continue;
					case 19u:
						goto IL_1FB;
					case 20u:
						goto IL_247;
					case 21u:
						return;
					case 22u:
						return;
					case 23u:
						arg_18E_0 = (((binaryWriter != null) ? 3400374826u : 2994678575u) ^ num * 3971327378u);
						continue;
					}
					goto Block_4;
					IL_94:
					AuthPacket.smethod_25(binaryWriter, AuthPacket.smethod_24(value));
					arg_18E_0 = 2155509429u;
					continue;
					IL_107:
					AuthPacket.smethod_23(binaryWriter, AuthPacket.smethod_22(value));
					arg_18E_0 = 3704779824u;
					continue;
					IL_11F:
					AuthPacket.smethod_29(binaryWriter, AuthPacket.smethod_28(value));
					arg_18E_0 = 3309188710u;
					continue;
					IL_137:
					AuthPacket.smethod_31(binaryWriter, AuthPacket.smethod_30(value));
					arg_18E_0 = 2848762291u;
					continue;
					IL_14F:
					AuthPacket.smethod_37(binaryWriter, AuthPacket.smethod_36(value));
					arg_18E_0 = 2335994440u;
				}
			}
			Block_4:
			return;
			IL_204:
			throw AuthPacket.smethod_10("");
			IL_20F:
			AuthPacket.smethod_27(binaryWriter, AuthPacket.smethod_26(value));
			return;
			IL_222:
			AuthPacket.smethod_33(binaryWriter, AuthPacket.smethod_32(value));
			return;
			IL_234:
			AuthPacket.smethod_21(binaryWriter, AuthPacket.smethod_20(value));
			return;
			IL_247:
			AuthPacket.smethod_35(binaryWriter, AuthPacket.smethod_34(value));
		}

		public void Write<T>(T value, int bits)
		{
			BinaryWriter binaryWriter_ = this.stream as BinaryWriter;
			int num = 0;
			int num2 = 0;
			byte value2;
			while (true)
			{
				IL_236:
				uint arg_1EC_0 = 3853054254u;
				while (true)
				{
					uint num3;
					switch ((num3 = (arg_1EC_0 ^ 3822343185u)) % 15u)
					{
					case 0u:
						this.preByte = 0;
						arg_1EC_0 = (num3 * 1308454025u ^ 2360235369u);
						continue;
					case 1u:
						num = bits;
						arg_1EC_0 = (num3 * 615170171u ^ 1083175457u);
						continue;
					case 2u:
						goto IL_236;
					case 3u:
						num2 = (this.count & 7);
						arg_1EC_0 = ((num2 != 0) ? 4047609542u : 3817100251u);
						continue;
					case 4u:
						num = 8 - num2;
						arg_1EC_0 = ((num >= bits) ? 2275874581u : 2260975821u);
						continue;
					case 5u:
						arg_1EC_0 = ((bits != 0) ? 2292956640u : 2290361256u);
						continue;
					case 6u:
						arg_1EC_0 = (num3 * 1271639527u ^ 1190542238u);
						continue;
					case 7u:
						arg_1EC_0 = (((num2 != 0) ? 4225350203u : 3087155715u) ^ num3 * 567680321u);
						continue;
					case 8u:
						bits -= num;
						arg_1EC_0 = (num3 * 1418491570u ^ 710958391u);
						continue;
					case 9u:
						this.Write<byte>(value2);
						arg_1EC_0 = 3397105997u;
						continue;
					case 10u:
					{
						Stream expr_D1 = AuthPacket.smethod_5(binaryWriter_);
						AuthPacket.smethod_41(expr_D1, AuthPacket.smethod_40(expr_D1) - 1L);
						arg_1EC_0 = (num3 * 2093632183u ^ 3005065087u);
						continue;
					}
					case 12u:
					{
						ulong num4;
						value2 = (byte)(((ulong)this.preByte & (ulong)(~(ulong)((1L << (num & 31)) - 1L << (num2 & 31)))) | (num4 >> bits - num & (ulong)((long)((1 << num) - 1))) << num2);
						this.count += num;
						arg_1EC_0 = 3527270891u;
						continue;
					}
					case 13u:
					{
						ulong num4 = (ulong)AuthPacket.smethod_15(value, AuthPacket.smethod_14(typeof(ulong).TypeHandle));
						value2 = 0;
						arg_1EC_0 = (num3 * 2889322655u ^ 1901488133u);
						continue;
					}
					case 14u:
						arg_1EC_0 = (((AuthPacket.smethod_6(AuthPacket.smethod_5(binaryWriter_)) <= 0L) ? 1517721775u : 1685766937u) ^ num3 * 506475948u);
						continue;
					}
					goto Block_6;
				}
			}
			Block_6:
			this.preByte = value2;
		}

		public void Flush()
		{
			int num = 8 - (this.count & 7);
			if (num < 8)
			{
				while (true)
				{
					IL_43:
					uint arg_2B_0 = 1476457130u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2B_0 ^ 1174923224u)) % 3u)
						{
						case 1u:
							this.Write<int>(0, num);
							arg_2B_0 = (num2 * 3963131986u ^ 3346701059u);
							continue;
						case 2u:
							goto IL_43;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			this.preByte = 0;
		}

		public void WriteString(string data, int bits, bool isCString = true, int additionalCount = 0)
		{
			byte[] array = AuthPacket.smethod_42(AuthPacket.smethod_12(), data);
			while (true)
			{
				IL_BA:
				uint arg_92_0 = 88256940u;
				while (true)
				{
					uint num;
					switch ((num = (arg_92_0 ^ 1145632018u)) % 7u)
					{
					case 1u:
						this.Write<int>(array.Length + additionalCount, bits);
						arg_92_0 = (num * 3933157738u ^ 3858785379u);
						continue;
					case 2u:
						this.Flush();
						arg_92_0 = 1411661349u;
						continue;
					case 3u:
						this.Write<byte[]>(array);
						arg_92_0 = (num * 3707020536u ^ 2244404174u);
						continue;
					case 4u:
						goto IL_BA;
					case 5u:
						arg_92_0 = (((!isCString) ? 3123080973u : 3522398342u) ^ num * 866731608u);
						continue;
					case 6u:
						this.Write<byte[]>(new byte[1]);
						arg_92_0 = (num * 4187764293u ^ 4101948329u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteFourCC(string data)
		{
			byte[] value = AuthPacket.smethod_42(AuthPacket.smethod_12(), data);
			while (true)
			{
				IL_3F:
				uint arg_27_0 = 2115914845u;
				while (true)
				{
					uint num;
					switch ((num = (arg_27_0 ^ 427277530u)) % 3u)
					{
					case 1u:
						this.Write<byte[]>(value);
						arg_27_0 = (num * 1839703030u ^ 159873758u);
						continue;
					case 2u:
						goto IL_3F;
					}
					return;
				}
			}
		}

		static MemoryStream smethod_0()
		{
			return new MemoryStream();
		}

		static BinaryWriter smethod_1(Stream stream_0)
		{
			return new BinaryWriter(stream_0);
		}

		static MemoryStream smethod_2(byte[] byte_0)
		{
			return new MemoryStream(byte_0);
		}

		static BinaryReader smethod_3(Stream stream_0)
		{
			return new BinaryReader(stream_0);
		}

		static void smethod_4(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static Stream smethod_5(BinaryWriter binaryWriter_0)
		{
			return binaryWriter_0.BaseStream;
		}

		static long smethod_6(Stream stream_0)
		{
			return stream_0.Length;
		}

		static long smethod_7(Stream stream_0, long long_0, SeekOrigin seekOrigin_0)
		{
			return stream_0.Seek(long_0, seekOrigin_0);
		}

		static int smethod_8(Stream stream_0)
		{
			return stream_0.ReadByte();
		}

		static void smethod_9(BinaryWriter binaryWriter_0)
		{
			binaryWriter_0.Dispose();
		}

		static InvalidOperationException smethod_10(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static byte[] smethod_11(BinaryReader binaryReader_0, int int_0)
		{
			return binaryReader_0.ReadBytes(int_0);
		}

		static Encoding smethod_12()
		{
			return Encoding.UTF8;
		}

		static string smethod_13(Encoding encoding_0, byte[] byte_0)
		{
			return encoding_0.GetString(byte_0);
		}

		static Type smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static object smethod_15(object object_0, Type type_0)
		{
			return Convert.ChangeType(object_0, type_0);
		}

		static byte[] smethod_16(uint uint_0)
		{
			return BitConverter.GetBytes(uint_0);
		}

		static void smethod_17(Array array_0)
		{
			Array.Reverse(array_0);
		}

		static string smethod_18(string string_0, char[] char_0)
		{
			return string_0.Trim(char_0);
		}

		static TypeCode smethod_19(Type type_0)
		{
			return Type.GetTypeCode(type_0);
		}

		static sbyte smethod_20(object object_0)
		{
			return Convert.ToSByte(object_0);
		}

		static void smethod_21(BinaryWriter binaryWriter_0, sbyte sbyte_0)
		{
			binaryWriter_0.Write(sbyte_0);
		}

		static byte smethod_22(object object_0)
		{
			return Convert.ToByte(object_0);
		}

		static void smethod_23(BinaryWriter binaryWriter_0, byte byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static short smethod_24(object object_0)
		{
			return Convert.ToInt16(object_0);
		}

		static void smethod_25(BinaryWriter binaryWriter_0, short short_0)
		{
			binaryWriter_0.Write(short_0);
		}

		static ushort smethod_26(object object_0)
		{
			return Convert.ToUInt16(object_0);
		}

		static void smethod_27(BinaryWriter binaryWriter_0, ushort ushort_0)
		{
			binaryWriter_0.Write(ushort_0);
		}

		static int smethod_28(object object_0)
		{
			return Convert.ToInt32(object_0);
		}

		static void smethod_29(BinaryWriter binaryWriter_0, int int_0)
		{
			binaryWriter_0.Write(int_0);
		}

		static uint smethod_30(object object_0)
		{
			return Convert.ToUInt32(object_0);
		}

		static void smethod_31(BinaryWriter binaryWriter_0, uint uint_0)
		{
			binaryWriter_0.Write(uint_0);
		}

		static long smethod_32(object object_0)
		{
			return Convert.ToInt64(object_0);
		}

		static void smethod_33(BinaryWriter binaryWriter_0, long long_0)
		{
			binaryWriter_0.Write(long_0);
		}

		static ulong smethod_34(object object_0)
		{
			return Convert.ToUInt64(object_0);
		}

		static void smethod_35(BinaryWriter binaryWriter_0, ulong ulong_0)
		{
			binaryWriter_0.Write(ulong_0);
		}

		static float smethod_36(object object_0)
		{
			return Convert.ToSingle(object_0);
		}

		static void smethod_37(BinaryWriter binaryWriter_0, float float_0)
		{
			binaryWriter_0.Write(float_0);
		}

		static bool smethod_38(Type type_0, Type type_1)
		{
			return type_0 == type_1;
		}

		static void smethod_39(BinaryWriter binaryWriter_0, byte[] byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static long smethod_40(Stream stream_0)
		{
			return stream_0.Position;
		}

		static void smethod_41(Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}

		static byte[] smethod_42(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}
	}
}
