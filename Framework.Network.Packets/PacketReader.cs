using Framework.Constants.Net;
using Framework.Misc;
using Framework.ObjectDefines;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Framework.Network.Packets
{
	public class PacketReader : BinaryReader
	{
		public ClientMessage Opcode
		{
			get;
			set;
		}

		public uint Size
		{
			get;
			set;
		}

		public byte[] Storage
		{
			get;
			set;
		}

		public PacketReader(byte[] data, bool worldPacket = true, bool initiated = true) : base(PacketReader.smethod_0(data))
		{
			while (true)
			{
				IL_1D2:
				uint arg_189_0 = 3156641816u;
				while (true)
				{
					uint num;
					switch ((num = (arg_189_0 ^ 3864136495u)) % 15u)
					{
					case 0u:
						goto IL_1D2;
					case 1u:
						this.Size = this.Read<uint>();
						arg_189_0 = 2743092977u;
						continue;
					case 2u:
						arg_189_0 = (((!initiated) ? 3590482912u : 2412903487u) ^ num * 2994934353u);
						continue;
					case 3u:
						this.Storage = new byte[this.Size - 2u];
						arg_189_0 = (num * 1087116174u ^ 2139534886u);
						continue;
					case 4u:
						goto IL_1D9;
					case 5u:
						arg_189_0 = (((this.Size <= 2u) ? 4116359952u : 3109502271u) ^ num * 334575575u);
						continue;
					case 6u:
						this.Opcode = (ClientMessage)PacketReader.smethod_1(this);
						arg_189_0 = (num * 1057443353u ^ 93166561u);
						continue;
					case 7u:
						this.Size = this.Read<uint>();
						arg_189_0 = (num * 3494330189u ^ 4069919854u);
						continue;
					case 8u:
						this.Opcode = (ClientMessage)PacketReader.smethod_1(this);
						this.Storage = new byte[this.Size - 2u];
						arg_189_0 = (num * 1597543789u ^ 4404019u);
						continue;
					case 9u:
						arg_189_0 = (worldPacket ? 2554908325u : 2897364664u);
						continue;
					case 10u:
						goto IL_1F0;
					case 11u:
						this.Opcode = (ClientMessage)PacketReader.smethod_1(this);
						arg_189_0 = (num * 4166718346u ^ 391895848u);
						continue;
					case 12u:
						PacketReader.smethod_2(data, 6, this.Storage, 0, (int)(this.Size - 2u));
						arg_189_0 = (num * 1810940774u ^ 357029026u);
						continue;
					case 14u:
						this.Storage = new byte[data.Length];
						arg_189_0 = (num * 247058560u ^ 451953824u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			return;
			IL_1D9:
			PacketReader.smethod_2(data, 6, this.Storage, 0, (int)(this.Size - 2u));
			return;
			IL_1F0:
			PacketReader.smethod_2(data, 0, this.Storage, 0, data.Length);
		}

		public T Read<T>()
		{
			return this.Read<T>();
		}

		public SmartGuid ReadGuid()
		{
			SmartGuid smartGuid = new SmartGuid();
			while (true)
			{
				IL_AC:
				uint arg_88_0 = 987742680u;
				while (true)
				{
					uint num;
					switch ((num = (arg_88_0 ^ 1441787658u)) % 6u)
					{
					case 0u:
						goto IL_AC;
					case 1u:
					{
						byte b;
						smartGuid.HighGuid = this.GetSmartGuid(b);
						arg_88_0 = (num * 355414513u ^ 3371240138u);
						continue;
					}
					case 2u:
					{
						byte b = this.Read<byte>();
						arg_88_0 = (num * 1336090768u ^ 1604431491u);
						continue;
					}
					case 4u:
					{
						byte gLength = this.Read<byte>();
						arg_88_0 = (num * 1082293947u ^ 737268760u);
						continue;
					}
					case 5u:
					{
						byte gLength;
						smartGuid.Guid = this.GetSmartGuid(gLength);
						byte b;
						arg_88_0 = (((b > 0) ? 2277857867u : 3763154427u) ^ num * 1623469582u);
						continue;
					}
					}
					return smartGuid;
				}
			}
			return smartGuid;
		}

		public ulong ReadSmartGuid()
		{
			byte gLength = this.Read<byte>();
			byte b = this.Read<byte>();
			ulong arg_21_0 = this.GetSmartGuid(gLength);
			if (b > 0)
			{
				this.GetSmartGuid(b);
			}
			return arg_21_0;
		}

		public ulong GetSmartGuid(byte gLength)
		{
			ulong num = 0uL;
			while (true)
			{
				IL_CA:
				uint arg_9E_0 = 1438227047u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9E_0 ^ 1866872718u)) % 8u)
					{
					case 0u:
						goto IL_CA;
					case 1u:
					{
						byte b = 0;
						arg_9E_0 = (num2 * 682674093u ^ 3834076868u);
						continue;
					}
					case 2u:
					{
						byte b;
						arg_9E_0 = ((b >= 8) ? 1021561707u : 43423272u);
						continue;
					}
					case 3u:
					{
						byte b;
						b += 1;
						arg_9E_0 = 1000440716u;
						continue;
					}
					case 4u:
					{
						byte b;
						num |= (ulong)this.Read<byte>() << (int)(b * 8);
						arg_9E_0 = (num2 * 3146625632u ^ 574776333u);
						continue;
					}
					case 6u:
					{
						byte b;
						arg_9E_0 = (((1 << (int)b & (int)gLength) == 0) ? 1721453453u : 850078106u);
						continue;
					}
					case 7u:
						arg_9E_0 = (num2 * 2277653255u ^ 2526320949u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public string ReadCString()
		{
			StringBuilder stringBuilder = PacketReader.smethod_3();
			while (true)
			{
				IL_A5:
				uint arg_81_0 = 3848595604u;
				while (true)
				{
					uint num;
					switch ((num = (arg_81_0 ^ 2744129681u)) % 6u)
					{
					case 0u:
					{
						char c = PacketReader.smethod_7(PacketReader.smethod_5(PacketReader.smethod_4(), new byte[1]), PacketReader.smethod_6());
						arg_81_0 = (num * 2827065615u ^ 2813486781u);
						continue;
					}
					case 1u:
					{
						char c2 = this.method_0();
						arg_81_0 = (num * 1477345143u ^ 2513410648u);
						continue;
					}
					case 2u:
					{
						char c;
						char c2;
						arg_81_0 = ((c2 != c) ? 3896477412u : 3424037926u);
						continue;
					}
					case 3u:
					{
						char c2;
						PacketReader.smethod_8(stringBuilder, c2);
						c2 = this.method_0();
						arg_81_0 = 3439858363u;
						continue;
					}
					case 4u:
						goto IL_A5;
					}
					goto Block_2;
				}
			}
			Block_2:
			return PacketReader.smethod_9(stringBuilder);
		}

		public string ReadString(uint count)
		{
			byte[] byte_ = this.ReadBytes(count);
			return PacketReader.smethod_5(PacketReader.smethod_4(), byte_);
		}

		public byte[] ReadBytes(uint count)
		{
			return this.method_1((int)count);
		}

		public string ReadStringFromBytes(uint count)
		{
			byte[] array = this.ReadBytes(count);
			while (true)
			{
				IL_3A:
				uint arg_22_0 = 1290115285u;
				while (true)
				{
					uint num;
					switch ((num = (arg_22_0 ^ 1657894067u)) % 3u)
					{
					case 0u:
						goto IL_3A;
					case 1u:
						PacketReader.smethod_10(array);
						arg_22_0 = (num * 3698391708u ^ 2220090647u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return PacketReader.smethod_5(PacketReader.smethod_4(), array);
		}

		public string ReadIPAddress()
		{
			byte[] array = new byte[4];
			int num = 0;
			while (true)
			{
				IL_81:
				uint arg_5D_0 = 1700376117u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5D_0 ^ 2016936146u)) % 6u)
					{
					case 0u:
						array[num] = this.Read<byte>();
						arg_5D_0 = 1376118107u;
						continue;
					case 1u:
						num++;
						arg_5D_0 = (num2 * 1101403398u ^ 2667150997u);
						continue;
					case 2u:
						goto IL_81;
					case 3u:
						arg_5D_0 = (num2 * 2503189178u ^ 1531486581u);
						continue;
					case 5u:
						arg_5D_0 = ((num >= 4) ? 371515074u : 1324051690u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			return PacketReader.smethod_11(new object[]
			{
				array[0],
				Module.smethod_37<string>(3886401134u),
				array[1],
				Module.smethod_35<string>(3143151842u),
				array[2],
				Module.smethod_34<string>(3349943853u),
				array[3]
			});
		}

		public string ReadAccountName()
		{
			StringBuilder stringBuilder = PacketReader.smethod_3();
			byte b = this.Read<byte>();
			while (true)
			{
				IL_B2:
				uint arg_89_0 = 402315765u;
				while (true)
				{
					uint num;
					switch ((num = (arg_89_0 ^ 1923119469u)) % 7u)
					{
					case 1u:
					{
						int num2 = 0;
						arg_89_0 = (num * 1362164820u ^ 1780972646u);
						continue;
					}
					case 2u:
					{
						char[] array = new char[(int)b];
						arg_89_0 = (num * 2588860411u ^ 4044429464u);
						continue;
					}
					case 3u:
						arg_89_0 = (num * 1704855395u ^ 3221030392u);
						continue;
					case 4u:
					{
						int num2;
						char[] array;
						array[num2] = this.method_0();
						PacketReader.smethod_8(stringBuilder, array[num2]);
						num2++;
						arg_89_0 = 1876511029u;
						continue;
					}
					case 5u:
					{
						int num2;
						arg_89_0 = ((num2 >= (int)b) ? 1063834256u : 791108076u);
						continue;
					}
					case 6u:
						goto IL_B2;
					}
					goto Block_2;
				}
			}
			Block_2:
			return PacketReader.smethod_12(PacketReader.smethod_9(stringBuilder), PacketReader.smethod_6());
		}

		public void Skip(int count)
		{
			Stream expr_06 = this.method_2();
			PacketReader.smethod_14(expr_06, PacketReader.smethod_13(expr_06) + (long)count);
		}

		static MemoryStream smethod_0(byte[] byte_0)
		{
			return new MemoryStream(byte_0);
		}

		static ushort smethod_1(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt16();
		}

		static void smethod_2(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static StringBuilder smethod_3()
		{
			return new StringBuilder();
		}

		char method_0()
		{
			return base.ReadChar();
		}

		static Encoding smethod_4()
		{
			return Encoding.UTF8;
		}

		static string smethod_5(Encoding encoding_0, byte[] byte_0)
		{
			return encoding_0.GetString(byte_0);
		}

		static CultureInfo smethod_6()
		{
			return CultureInfo.InvariantCulture;
		}

		static char smethod_7(string string_0, IFormatProvider iformatProvider_0)
		{
			return Convert.ToChar(string_0, iformatProvider_0);
		}

		static StringBuilder smethod_8(StringBuilder stringBuilder_0, char char_0)
		{
			return stringBuilder_0.Append(char_0);
		}

		static string smethod_9(object object_0)
		{
			return object_0.ToString();
		}

		byte[] method_1(int int_0)
		{
			return base.ReadBytes(int_0);
		}

		static void smethod_10(Array array_0)
		{
			Array.Reverse(array_0);
		}

		static string smethod_11(object[] object_0)
		{
			return string.Concat(object_0);
		}

		static string smethod_12(string string_0, CultureInfo cultureInfo_0)
		{
			return string_0.ToUpper(cultureInfo_0);
		}

		Stream method_2()
		{
			return base.BaseStream;
		}

		static long smethod_13(Stream stream_0)
		{
			return stream_0.Position;
		}

		static void smethod_14(Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}
	}
}
