using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class CodedOutputStream
	{
		public sealed class OutOfSpaceException : IOException
		{
			internal OutOfSpaceException() : base(Module.smethod_33<string>(1305925207u))
			{
			}
		}

		private const int LittleEndian64Size = 8;

		private const int LittleEndian32Size = 4;

		internal static readonly Encoding Utf8Encoding = CodedOutputStream.smethod_10();

		public static readonly int DefaultBufferSize = 4096;

		private readonly byte[] buffer;

		private readonly int limit;

		private int position;

		private readonly Stream output;

		public long Position
		{
			get
			{
				if (this.output != null)
				{
					return CodedOutputStream.smethod_1(this.output) + (long)this.position;
				}
				return (long)this.position;
			}
		}

		public int SpaceLeft
		{
			get
			{
				if (this.output != null)
				{
					throw CodedOutputStream.smethod_9(Module.smethod_37<string>(2275103332u));
				}
				return this.limit - this.position;
			}
		}

		public static int ComputeDoubleSize(double value)
		{
			return 8;
		}

		public static int ComputeFloatSize(float value)
		{
			return 4;
		}

		public static int ComputeUInt64Size(ulong value)
		{
			return CodedOutputStream.ComputeRawVarint64Size(value);
		}

		public static int ComputeInt64Size(long value)
		{
			return CodedOutputStream.ComputeRawVarint64Size((ulong)value);
		}

		public static int ComputeInt32Size(int value)
		{
			if (value >= 0)
			{
				return CodedOutputStream.ComputeRawVarint32Size((uint)value);
			}
			return 10;
		}

		public static int ComputeFixed64Size(ulong value)
		{
			return 8;
		}

		public static int ComputeFixed32Size(uint value)
		{
			return 4;
		}

		public static int ComputeBoolSize(bool value)
		{
			return 1;
		}

		public static int ComputeStringSize(string value)
		{
			int num = CodedOutputStream.smethod_0(CodedOutputStream.Utf8Encoding, value);
			return CodedOutputStream.ComputeLengthSize(num) + num;
		}

		public static int ComputeGroupSize(IMessage value)
		{
			return value.CalculateSize();
		}

		public static int ComputeMessageSize(IMessage value)
		{
			int num = value.CalculateSize();
			return CodedOutputStream.ComputeLengthSize(num) + num;
		}

		public static int ComputeBytesSize(ByteString value)
		{
			return CodedOutputStream.ComputeLengthSize(value.Length) + value.Length;
		}

		public static int ComputeUInt32Size(uint value)
		{
			return CodedOutputStream.ComputeRawVarint32Size(value);
		}

		public static int ComputeEnumSize(int value)
		{
			return CodedOutputStream.ComputeInt32Size(value);
		}

		public static int ComputeSFixed32Size(int value)
		{
			return 4;
		}

		public static int ComputeSFixed64Size(long value)
		{
			return 8;
		}

		public static int ComputeSInt32Size(int value)
		{
			return CodedOutputStream.ComputeRawVarint32Size(CodedOutputStream.EncodeZigZag32(value));
		}

		public static int ComputeSInt64Size(long value)
		{
			return CodedOutputStream.ComputeRawVarint64Size(CodedOutputStream.EncodeZigZag64(value));
		}

		public static int ComputeLengthSize(int length)
		{
			return CodedOutputStream.ComputeRawVarint32Size((uint)length);
		}

		public static int ComputeRawVarint32Size(uint value)
		{
			if ((value & 4294967168u) == 0u)
			{
				goto IL_18;
			}
			goto IL_A4;
			int arg_66_0;
			while (true)
			{
				IL_61:
				switch ((arg_66_0 ^ 1573471831) % 9)
				{
				case 0:
					arg_66_0 = (((value & 4292870144u) != 0u) ? 1713122773 : 1878921012);
					continue;
				case 1:
					return 1;
				case 2:
					arg_66_0 = (((value & 4026531840u) != 0u) ? 1853067201 : 1009689343);
					continue;
				case 4:
					return 4;
				case 5:
					return 2;
				case 6:
					goto IL_18;
				case 7:
					return 3;
				case 8:
					goto IL_A4;
				}
				break;
			}
			return 5;
			IL_18:
			arg_66_0 = 676432518;
			goto IL_61;
			IL_A4:
			arg_66_0 = (((value & 4294950912u) == 0u) ? 1943007673 : 146156149);
			goto IL_61;
		}

		public static int ComputeRawVarint64Size(ulong value)
		{
			if ((value & 18446744073709551488uL) == 0uL)
			{
				goto IL_138;
			}
			goto IL_1A8;
			int arg_142_0;
			while (true)
			{
				IL_13D:
				switch ((arg_142_0 ^ 759298391) % 19)
				{
				case 0:
					goto IL_138;
				case 1:
					return 3;
				case 2:
					return 8;
				case 3:
					arg_142_0 = (((value & 18446181123756130304uL) != 0uL) ? 1333461163 : 816031495);
					continue;
				case 4:
					arg_142_0 = (((value & 9223372036854775808uL) != 0uL) ? 1784209585 : 474750715);
					continue;
				case 5:
					return 4;
				case 6:
					goto IL_1A8;
				case 7:
					return 2;
				case 8:
					arg_142_0 = (((value & 18446744039349813248uL) != 0uL) ? 144004607 : 2007319370);
					continue;
				case 9:
					arg_142_0 = (((value & 18446744073707454464uL) == 0uL) ? 620627235 : 714197152);
					continue;
				case 10:
					arg_142_0 = (((value & 18446744073441116160uL) != 0uL) ? 371709271 : 954489211);
					continue;
				case 11:
					arg_142_0 = (((value & 18374686479671623680uL) == 0uL) ? 137999893 : 917453704);
					continue;
				case 12:
					return 6;
				case 14:
					arg_142_0 = (((value & 18446739675663040512uL) == 0uL) ? 1644037955 : 1638655890);
					continue;
				case 15:
					return 5;
				case 16:
					return 1;
				case 17:
					return 7;
				case 18:
					return 9;
				}
				break;
			}
			return 10;
			IL_138:
			arg_142_0 = 909890047;
			goto IL_13D;
			IL_1A8:
			arg_142_0 = (((value & 18446744073709535232uL) != 0uL) ? 1845091927 : 133593842);
			goto IL_13D;
		}

		public static int ComputeTagSize(int fieldNumber)
		{
			return CodedOutputStream.ComputeRawVarint32Size(WireFormat.MakeTag(fieldNumber, WireFormat.WireType.Varint));
		}

		public CodedOutputStream(byte[] flatArray) : this(flatArray, 0, flatArray.Length)
		{
		}

		private CodedOutputStream(byte[] buffer, int offset, int length)
		{
			while (true)
			{
				IL_76:
				uint arg_56_0 = 1292876091u;
				while (true)
				{
					uint num;
					switch ((num = (arg_56_0 ^ 2146276990u)) % 5u)
					{
					case 1u:
						this.buffer = buffer;
						arg_56_0 = (num * 2755810275u ^ 3915623592u);
						continue;
					case 2u:
						this.output = null;
						arg_56_0 = (num * 8465455u ^ 1857988948u);
						continue;
					case 3u:
						goto IL_76;
					case 4u:
						this.position = offset;
						this.limit = offset + length;
						arg_56_0 = (num * 262523589u ^ 45561008u);
						continue;
					}
					return;
				}
			}
		}

		private CodedOutputStream(Stream output, byte[] buffer)
		{
			while (true)
			{
				IL_53:
				uint arg_37_0 = 2361766492u;
				while (true)
				{
					uint num;
					switch ((num = (arg_37_0 ^ 3286681291u)) % 4u)
					{
					case 0u:
						goto IL_53;
					case 1u:
						this.buffer = buffer;
						arg_37_0 = (num * 1669105703u ^ 3548401254u);
						continue;
					case 3u:
						this.output = output;
						arg_37_0 = (num * 721343128u ^ 375713146u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.position = 0;
			this.limit = buffer.Length;
		}

		public CodedOutputStream(Stream output) : this(output, CodedOutputStream.DefaultBufferSize)
		{
		}

		public CodedOutputStream(Stream output, int bufferSize) : this(output, new byte[bufferSize])
		{
		}

		public void WriteDouble(double value)
		{
			this.WriteRawLittleEndian64((ulong)CodedOutputStream.smethod_2(value));
		}

		public void WriteFloat(float value)
		{
			byte[] array = CodedOutputStream.smethod_3(value);
			while (true)
			{
				IL_14C:
				uint arg_11B_0 = 1042150926u;
				while (true)
				{
					uint num;
					switch ((num = (arg_11B_0 ^ 1022855066u)) % 9u)
					{
					case 0u:
					{
						byte[] arg_ED_0 = this.buffer;
						int num2 = this.position;
						this.position = num2 + 1;
						arg_ED_0[num2] = array[0];
						byte[] arg_108_0 = this.buffer;
						num2 = this.position;
						this.position = num2 + 1;
						arg_108_0[num2] = array[1];
						arg_11B_0 = (num * 458216763u ^ 884498142u);
						continue;
					}
					case 1u:
						return;
					case 2u:
						goto IL_14C;
					case 4u:
					{
						byte[] arg_A8_0 = this.buffer;
						int num2 = this.position;
						this.position = num2 + 1;
						arg_A8_0[num2] = array[2];
						byte[] arg_C3_0 = this.buffer;
						num2 = this.position;
						this.position = num2 + 1;
						arg_C3_0[num2] = array[3];
						arg_11B_0 = (num * 2383484455u ^ 688700656u);
						continue;
					}
					case 5u:
						this.WriteRawBytes(array, 0, 4);
						arg_11B_0 = 1532374059u;
						continue;
					case 6u:
						arg_11B_0 = ((this.limit - this.position < 4) ? 842348969u : 206970980u);
						continue;
					case 7u:
						ByteArray.Reverse(array);
						arg_11B_0 = (num * 1074657787u ^ 895898004u);
						continue;
					case 8u:
						arg_11B_0 = ((BitConverter.IsLittleEndian ? 4106246718u : 3865512180u) ^ num * 3960773342u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:;
		}

		public void WriteUInt64(ulong value)
		{
			this.WriteRawVarint64(value);
		}

		public void WriteInt64(long value)
		{
			this.WriteRawVarint64((ulong)value);
		}

		public void WriteInt32(int value)
		{
			if (value < 0)
			{
				goto IL_28;
			}
			IL_04:
			int arg_0E_0 = 946990302;
			IL_09:
			switch ((arg_0E_0 ^ 1643762941) % 4)
			{
			case 0:
				IL_28:
				this.WriteRawVarint64((ulong)((long)value));
				arg_0E_0 = 1202023556;
				goto IL_09;
			case 2:
				goto IL_04;
			case 3:
				this.WriteRawVarint32((uint)value);
				return;
			}
		}

		public void WriteFixed64(ulong value)
		{
			this.WriteRawLittleEndian64(value);
		}

		public void WriteFixed32(uint value)
		{
			this.WriteRawLittleEndian32(value);
		}

		public void WriteBool(bool value)
		{
			this.WriteRawByte(value ? 1 : 0);
		}

		public void WriteString(string value)
		{
			int num = CodedOutputStream.smethod_0(CodedOutputStream.Utf8Encoding, value);
			while (true)
			{
				IL_19C:
				uint arg_157_0 = 887200780u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_157_0 ^ 428672786u)) % 14u)
					{
					case 0u:
						this.position += num;
						arg_157_0 = 576530064u;
						continue;
					case 1u:
					{
						byte[] value2 = CodedOutputStream.smethod_7(CodedOutputStream.Utf8Encoding, value);
						arg_157_0 = 743111088u;
						continue;
					}
					case 2u:
						return;
					case 3u:
						arg_157_0 = (num2 * 3739319746u ^ 4238686882u);
						continue;
					case 4u:
					{
						int num3;
						this.buffer[this.position + num3] = (byte)CodedOutputStream.smethod_5(value, num3);
						num3++;
						arg_157_0 = 1717125292u;
						continue;
					}
					case 5u:
						goto IL_19C;
					case 6u:
						CodedOutputStream.smethod_6(CodedOutputStream.Utf8Encoding, value, 0, CodedOutputStream.smethod_4(value), this.buffer, this.position);
						arg_157_0 = 515054194u;
						continue;
					case 7u:
						arg_157_0 = (((num == CodedOutputStream.smethod_4(value)) ? 1803967215u : 493454172u) ^ num2 * 2638214450u);
						continue;
					case 8u:
						this.WriteLength(num);
						arg_157_0 = (((this.limit - this.position < num) ? 125227529u : 1907771947u) ^ num2 * 1824877807u);
						continue;
					case 10u:
					{
						int num3;
						arg_157_0 = ((num3 < num) ? 47776578u : 2121854163u);
						continue;
					}
					case 11u:
						arg_157_0 = (num2 * 1129511727u ^ 632133917u);
						continue;
					case 12u:
					{
						byte[] value2;
						this.WriteRawBytes(value2);
						arg_157_0 = (num2 * 286972294u ^ 188635011u);
						continue;
					}
					case 13u:
					{
						int num3 = 0;
						arg_157_0 = (num2 * 4058509186u ^ 2320074371u);
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:;
		}

		public void WriteMessage(IMessage value)
		{
			this.WriteLength(value.CalculateSize());
			value.WriteTo(this);
		}

		public void WriteBytes(ByteString value)
		{
			this.WriteLength(value.Length);
			value.WriteRawBytesTo(this);
		}

		public void WriteUInt32(uint value)
		{
			this.WriteRawVarint32(value);
		}

		public void WriteEnum(int value)
		{
			this.WriteInt32(value);
		}

		public void WriteSFixed32(int value)
		{
			this.WriteRawLittleEndian32((uint)value);
		}

		public void WriteSFixed64(long value)
		{
			this.WriteRawLittleEndian64((ulong)value);
		}

		public void WriteSInt32(int value)
		{
			this.WriteRawVarint32(CodedOutputStream.EncodeZigZag32(value));
		}

		public void WriteSInt64(long value)
		{
			this.WriteRawVarint64(CodedOutputStream.EncodeZigZag64(value));
		}

		public void WriteLength(int length)
		{
			this.WriteRawVarint32((uint)length);
		}

		public void WriteTag(int fieldNumber, WireFormat.WireType type)
		{
			this.WriteRawVarint32(WireFormat.MakeTag(fieldNumber, type));
		}

		public void WriteTag(uint tag)
		{
			this.WriteRawVarint32(tag);
		}

		public void WriteRawTag(byte b1)
		{
			this.WriteRawByte(b1);
		}

		public void WriteRawTag(byte b1, byte b2)
		{
			this.WriteRawByte(b1);
			while (true)
			{
				IL_3A:
				uint arg_22_0 = 801727837u;
				while (true)
				{
					uint num;
					switch ((num = (arg_22_0 ^ 910562582u)) % 3u)
					{
					case 1u:
						this.WriteRawByte(b2);
						arg_22_0 = (num * 3137870478u ^ 718158186u);
						continue;
					case 2u:
						goto IL_3A;
					}
					return;
				}
			}
		}

		public void WriteRawTag(byte b1, byte b2, byte b3)
		{
			this.WriteRawByte(b1);
			while (true)
			{
				IL_41:
				uint arg_29_0 = 4267844637u;
				while (true)
				{
					uint num;
					switch ((num = (arg_29_0 ^ 4171961337u)) % 3u)
					{
					case 1u:
						this.WriteRawByte(b2);
						this.WriteRawByte(b3);
						arg_29_0 = (num * 496222158u ^ 1064134182u);
						continue;
					case 2u:
						goto IL_41;
					}
					return;
				}
			}
		}

		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4)
		{
			this.WriteRawByte(b1);
			while (true)
			{
				IL_54:
				uint arg_38_0 = 3921160418u;
				while (true)
				{
					uint num;
					switch ((num = (arg_38_0 ^ 3995530740u)) % 4u)
					{
					case 1u:
						this.WriteRawByte(b3);
						arg_38_0 = (num * 3473341805u ^ 850525577u);
						continue;
					case 2u:
						this.WriteRawByte(b2);
						arg_38_0 = (num * 427958664u ^ 122728189u);
						continue;
					case 3u:
						goto IL_54;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.WriteRawByte(b4);
		}

		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5)
		{
			this.WriteRawByte(b1);
			while (true)
			{
				IL_64:
				uint arg_48_0 = 396676301u;
				while (true)
				{
					uint num;
					switch ((num = (arg_48_0 ^ 1446444852u)) % 4u)
					{
					case 0u:
						this.WriteRawByte(b4);
						this.WriteRawByte(b5);
						arg_48_0 = (num * 3652908779u ^ 3652224395u);
						continue;
					case 1u:
						this.WriteRawByte(b2);
						this.WriteRawByte(b3);
						arg_48_0 = (num * 2940860973u ^ 546556693u);
						continue;
					case 2u:
						goto IL_64;
					}
					return;
				}
			}
		}

		internal void WriteRawVarint32(uint value)
		{
			if (value < 128u)
			{
				goto IL_D5;
			}
			goto IL_1B1;
			uint arg_15D_0;
			int num2;
			while (true)
			{
				IL_158:
				uint num;
				switch ((num = (arg_15D_0 ^ 3758189263u)) % 14u)
				{
				case 0u:
					goto IL_1B1;
				case 1u:
					arg_15D_0 = (((this.position < this.limit) ? 1529207393u : 655765694u) ^ num * 2758940381u);
					continue;
				case 2u:
					arg_15D_0 = ((value > 127u) ? 3021644999u : 2533210046u);
					continue;
				case 3u:
					value >>= 7;
					arg_15D_0 = (num * 549875529u ^ 832368376u);
					continue;
				case 4u:
					this.WriteRawByte((byte)((value & 127u) | 128u));
					value >>= 7;
					arg_15D_0 = 3193497729u;
					continue;
				case 5u:
					goto IL_D5;
				case 6u:
					this.WriteRawByte((byte)value);
					arg_15D_0 = 4232400083u;
					continue;
				case 7u:
				{
					byte[] arg_B8_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_B8_0[num2] = (byte)((value & 127u) | 128u);
					arg_15D_0 = 3075319816u;
					continue;
				}
				case 9u:
					arg_15D_0 = (((this.position >= this.limit) ? 4128630608u : 3227788096u) ^ num * 2597326761u);
					continue;
				case 10u:
					goto IL_1BC;
				case 11u:
					arg_15D_0 = (((this.position < this.limit) ? 1026808663u : 1633161372u) ^ num * 681430159u);
					continue;
				case 12u:
					arg_15D_0 = (num * 4234743981u ^ 2707262609u);
					continue;
				case 13u:
					goto IL_1D7;
				}
				break;
			}
			return;
			IL_1BC:
			byte[] arg_1D5_0 = this.buffer;
			num2 = this.position;
			this.position = num2 + 1;
			arg_1D5_0[num2] = (byte)value;
			return;
			IL_1D7:
			byte[] arg_1F0_0 = this.buffer;
			num2 = this.position;
			this.position = num2 + 1;
			arg_1F0_0[num2] = (byte)value;
			return;
			IL_D5:
			arg_15D_0 = 3670994234u;
			goto IL_158;
			IL_1B1:
			arg_15D_0 = ((value <= 127u) ? 3193497729u : 3417679578u);
			goto IL_158;
		}

		internal void WriteRawVarint64(ulong value)
		{
			while (true)
			{
				IL_1D6:
				uint arg_182_0 = (value <= 127uL) ? 2955684844u : 3442650946u;
				while (true)
				{
					uint num;
					switch ((num = (arg_182_0 ^ 2421182365u)) % 14u)
					{
					case 0u:
						arg_182_0 = (((this.position >= this.limit) ? 227603287u : 339070753u) ^ num * 303688050u);
						continue;
					case 1u:
						arg_182_0 = (((this.position >= this.limit) ? 589570940u : 1370223613u) ^ num * 1335478900u);
						continue;
					case 2u:
						return;
					case 4u:
					{
						byte[] arg_119_0 = this.buffer;
						int num2 = this.position;
						this.position = num2 + 1;
						arg_119_0[num2] = (byte)((value & 127uL) | 128uL);
						arg_182_0 = 2239906620u;
						continue;
					}
					case 5u:
						goto IL_1D6;
					case 6u:
					{
						byte[] arg_D9_0 = this.buffer;
						int num2 = this.position;
						this.position = num2 + 1;
						arg_D9_0[num2] = (byte)value;
						arg_182_0 = (num * 1704619481u ^ 1659987415u);
						continue;
					}
					case 7u:
						arg_182_0 = (num * 1193630043u ^ 183496147u);
						continue;
					case 8u:
						this.WriteRawByte((byte)value);
						arg_182_0 = 4055938490u;
						continue;
					case 9u:
						arg_182_0 = ((value <= 127uL) ? 3690142923u : 2242271539u);
						continue;
					case 10u:
						arg_182_0 = 3710855409u;
						continue;
					case 11u:
						value >>= 7;
						arg_182_0 = (num * 2371417993u ^ 3237883841u);
						continue;
					case 12u:
						this.WriteRawByte((byte)((value & 127uL) | 128uL));
						arg_182_0 = 4189705496u;
						continue;
					case 13u:
						value >>= 7;
						arg_182_0 = (num * 1964285014u ^ 1446079730u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:;
		}

		internal void WriteRawLittleEndian32(uint value)
		{
			if (this.position + 4 > this.limit)
			{
				goto IL_13;
			}
			goto IL_133;
			uint arg_FE_0;
			int num2;
			while (true)
			{
				IL_F9:
				uint num;
				switch ((num = (arg_FE_0 ^ 505585958u)) % 10u)
				{
				case 0u:
				{
					byte[] arg_EB_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_EB_0[num2] = (byte)(value >> 24);
					arg_FE_0 = (num * 3819713909u ^ 3335361938u);
					continue;
				}
				case 1u:
					goto IL_133;
				case 2u:
					return;
				case 3u:
					this.WriteRawByte((byte)(value >> 8));
					arg_FE_0 = (num * 834062949u ^ 1528328333u);
					continue;
				case 4u:
					this.WriteRawByte((byte)value);
					arg_FE_0 = (num * 2901390167u ^ 3840055441u);
					continue;
				case 5u:
				{
					byte[] arg_8F_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_8F_0[num2] = (byte)(value >> 16);
					arg_FE_0 = (num * 3472842618u ^ 937490388u);
					continue;
				}
				case 6u:
					this.WriteRawByte((byte)(value >> 16));
					this.WriteRawByte((byte)(value >> 24));
					arg_FE_0 = (num * 1122042672u ^ 2200244190u);
					continue;
				case 7u:
				{
					byte[] arg_38_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_38_0[num2] = (byte)(value >> 8);
					arg_FE_0 = (num * 1797718407u ^ 979136014u);
					continue;
				}
				case 9u:
					goto IL_13;
				}
				break;
			}
			return;
			IL_13:
			arg_FE_0 = 210623056u;
			goto IL_F9;
			IL_133:
			byte[] arg_14C_0 = this.buffer;
			num2 = this.position;
			this.position = num2 + 1;
			arg_14C_0[num2] = (byte)value;
			arg_FE_0 = 1606671431u;
			goto IL_F9;
		}

		internal void WriteRawLittleEndian64(ulong value)
		{
			if (this.position + 8 > this.limit)
			{
				goto IL_1F7;
			}
			goto IL_24E;
			uint arg_201_0;
			int num2;
			while (true)
			{
				IL_1FC:
				uint num;
				switch ((num = (arg_201_0 ^ 2894223195u)) % 16u)
				{
				case 0u:
					goto IL_1F7;
				case 1u:
				{
					byte[] arg_1E7_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_1E7_0[num2] = (byte)(value >> 56);
					arg_201_0 = (num * 1043767649u ^ 1545169823u);
					continue;
				}
				case 2u:
					this.WriteRawByte((byte)(value >> 16));
					arg_201_0 = (num * 2129396568u ^ 4027700374u);
					continue;
				case 3u:
					this.WriteRawByte((byte)(value >> 40));
					this.WriteRawByte((byte)(value >> 48));
					arg_201_0 = (num * 3606319593u ^ 3874645802u);
					continue;
				case 4u:
				{
					byte[] arg_17C_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_17C_0[num2] = (byte)(value >> 32);
					arg_201_0 = (num * 189052906u ^ 1984689724u);
					continue;
				}
				case 6u:
				{
					byte[] arg_130_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_130_0[num2] = (byte)(value >> 8);
					byte[] arg_14D_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_14D_0[num2] = (byte)(value >> 16);
					arg_201_0 = (num * 2841978762u ^ 1138285259u);
					continue;
				}
				case 7u:
					goto IL_24E;
				case 8u:
				{
					byte[] arg_102_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_102_0[num2] = (byte)(value >> 48);
					arg_201_0 = (num * 3922323780u ^ 3715749946u);
					continue;
				}
				case 9u:
					this.WriteRawByte((byte)(value >> 8));
					arg_201_0 = (num * 3719195370u ^ 646700931u);
					continue;
				case 10u:
					goto IL_270;
				case 11u:
					this.WriteRawByte((byte)(value >> 32));
					arg_201_0 = (num * 221975894u ^ 2148201754u);
					continue;
				case 12u:
				{
					byte[] arg_9A_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_9A_0[num2] = (byte)(value >> 24);
					arg_201_0 = (num * 1277761646u ^ 2785170791u);
					continue;
				}
				case 13u:
					this.WriteRawByte((byte)(value >> 24));
					arg_201_0 = (num * 813672558u ^ 974633542u);
					continue;
				case 14u:
					this.WriteRawByte((byte)value);
					arg_201_0 = (num * 3099359224u ^ 852963970u);
					continue;
				case 15u:
				{
					byte[] arg_34_0 = this.buffer;
					num2 = this.position;
					this.position = num2 + 1;
					arg_34_0[num2] = (byte)(value >> 40);
					arg_201_0 = (num * 82202716u ^ 1551013527u);
					continue;
				}
				}
				break;
			}
			return;
			IL_270:
			this.WriteRawByte((byte)(value >> 56));
			return;
			IL_1F7:
			arg_201_0 = 3580523637u;
			goto IL_1FC;
			IL_24E:
			byte[] arg_267_0 = this.buffer;
			num2 = this.position;
			this.position = num2 + 1;
			arg_267_0[num2] = (byte)value;
			arg_201_0 = 3038687917u;
			goto IL_1FC;
		}

		internal void WriteRawByte(byte value)
		{
			if (this.position == this.limit)
			{
				goto IL_0E;
			}
			goto IL_49;
			uint arg_2D_0;
			while (true)
			{
				IL_28:
				uint num;
				switch ((num = (arg_2D_0 ^ 243737460u)) % 4u)
				{
				case 0u:
					goto IL_49;
				case 1u:
					this.RefreshBuffer();
					arg_2D_0 = (num * 503519557u ^ 3641032301u);
					continue;
				case 2u:
					goto IL_0E;
				}
				break;
			}
			return;
			IL_0E:
			arg_2D_0 = 1106378397u;
			goto IL_28;
			IL_49:
			byte[] arg_61_0 = this.buffer;
			int num2 = this.position;
			this.position = num2 + 1;
			arg_61_0[num2] = value;
			arg_2D_0 = 1190717895u;
			goto IL_28;
		}

		internal void WriteRawByte(uint value)
		{
			this.WriteRawByte((byte)value);
		}

		internal void WriteRawBytes(byte[] value)
		{
			this.WriteRawBytes(value, 0, value.Length);
		}

		internal void WriteRawBytes(byte[] value, int offset, int length)
		{
			if (this.limit - this.position >= length)
			{
				goto IL_13;
			}
			goto IL_120;
			uint arg_E7_0;
			int num2;
			while (true)
			{
				IL_E2:
				uint num;
				switch ((num = (arg_E7_0 ^ 635300094u)) % 11u)
				{
				case 0u:
					ByteArray.Copy(value, offset, this.buffer, this.position, num2);
					offset += num2;
					arg_E7_0 = (num * 1450560323u ^ 1365034423u);
					continue;
				case 1u:
					length -= num2;
					this.position = this.limit;
					this.RefreshBuffer();
					arg_E7_0 = (num * 14859642u ^ 1833565904u);
					continue;
				case 2u:
					goto IL_135;
				case 3u:
					arg_E7_0 = (((length > this.limit) ? 4040596147u : 3763799736u) ^ num * 223417365u);
					continue;
				case 4u:
					ByteArray.Copy(value, offset, this.buffer, 0, length);
					arg_E7_0 = (num * 4202779720u ^ 1524812571u);
					continue;
				case 5u:
					return;
				case 6u:
					this.position = length;
					arg_E7_0 = (num * 132727666u ^ 2929647260u);
					continue;
				case 7u:
					goto IL_120;
				case 9u:
					CodedOutputStream.smethod_8(this.output, value, offset, length);
					arg_E7_0 = 1406239620u;
					continue;
				case 10u:
					goto IL_13;
				}
				break;
			}
			return;
			IL_135:
			ByteArray.Copy(value, offset, this.buffer, this.position, length);
			this.position += length;
			return;
			IL_13:
			arg_E7_0 = 540594780u;
			goto IL_E2;
			IL_120:
			num2 = this.limit - this.position;
			arg_E7_0 = 1444932334u;
			goto IL_E2;
		}

		internal static uint EncodeZigZag32(int n)
		{
			return (uint)(n << 1 ^ n >> 31);
		}

		internal static ulong EncodeZigZag64(long n)
		{
			return (ulong)(n << 1 ^ n >> 63);
		}

		private void RefreshBuffer()
		{
			if (this.output != null)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = 47764688;
			IL_0D:
			switch ((arg_12_0 ^ 661826201) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				throw new CodedOutputStream.OutOfSpaceException();
			case 3:
				IL_2C:
				CodedOutputStream.smethod_8(this.output, this.buffer, 0, this.position);
				arg_12_0 = 579313915;
				goto IL_0D;
			}
			this.position = 0;
		}

		public void Flush()
		{
			if (this.output != null)
			{
				while (true)
				{
					IL_3A:
					uint arg_22_0 = 3639014859u;
					while (true)
					{
						uint num;
						switch ((num = (arg_22_0 ^ 2550759192u)) % 3u)
						{
						case 1u:
							this.RefreshBuffer();
							arg_22_0 = (num * 1092280125u ^ 16035329u);
							continue;
						case 2u:
							goto IL_3A;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public void CheckNoSpaceLeft()
		{
			if (this.SpaceLeft != 0)
			{
				throw CodedOutputStream.smethod_9(Module.smethod_33<string>(3651743630u));
			}
		}

		static int smethod_0(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetByteCount(string_0);
		}

		static long smethod_1(Stream stream_0)
		{
			return stream_0.Position;
		}

		static long smethod_2(double double_0)
		{
			return BitConverter.DoubleToInt64Bits(double_0);
		}

		static byte[] smethod_3(float float_0)
		{
			return BitConverter.GetBytes(float_0);
		}

		static int smethod_4(string string_0)
		{
			return string_0.Length;
		}

		static char smethod_5(string string_0, int int_0)
		{
			return string_0[int_0];
		}

		static int smethod_6(Encoding encoding_0, string string_0, int int_0, int int_1, byte[] byte_0, int int_2)
		{
			return encoding_0.GetBytes(string_0, int_0, int_1, byte_0, int_2);
		}

		static byte[] smethod_7(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static void smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		static InvalidOperationException smethod_9(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static Encoding smethod_10()
		{
			return Encoding.UTF8;
		}
	}
}
