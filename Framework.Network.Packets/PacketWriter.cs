using Framework.Constants;
using Framework.Constants.Net;
using Framework.ObjectDefines;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace Framework.Network.Packets
{
	public class PacketWriter : BinaryWriter
	{
		public ServerMessage Opcode
		{
			get;
			set;
		}

		public uint Size
		{
			get;
			set;
		}

		public PacketWriter() : base(PacketWriter.smethod_0())
		{
		}

		public PacketWriter(ServerMessage message, bool isWorldPacket = true) : base(PacketWriter.smethod_0())
		{
			this.WritePacketHeader(message, isWorldPacket);
		}

		protected void WritePacketHeader(ServerMessage opcode, bool isWorldPacket = true)
		{
			this.Opcode = opcode;
			if (!isWorldPacket)
			{
				goto IL_0A;
			}
			goto IL_4A;
			uint arg_2A_0;
			while (true)
			{
				IL_25:
				uint num;
				switch ((num = (arg_2A_0 ^ 2379351063u)) % 5u)
				{
				case 0u:
					this.WriteUInt16((ushort)opcode);
					arg_2A_0 = (num * 1189220124u ^ 2296128722u);
					continue;
				case 1u:
					goto IL_58;
				case 2u:
					goto IL_4A;
				case 3u:
					goto IL_0A;
				}
				break;
			}
			return;
			IL_58:
			this.WriteUInt32(0u);
			this.WriteUInt16((ushort)opcode);
			return;
			IL_0A:
			arg_2A_0 = 2205124648u;
			goto IL_25;
			IL_4A:
			this.WriteUInt32(0u);
			arg_2A_0 = 3253440261u;
			goto IL_25;
		}

		public byte[] ReadDataToSend(bool isAuthPacket = false)
		{
			byte[] array = new byte[PacketWriter.smethod_2(PacketWriter.smethod_1(this))];
			while (true)
			{
				IL_157:
				uint arg_11E_0 = 1778740614u;
				while (true)
				{
					uint num;
					switch ((num = (arg_11E_0 ^ 1877401841u)) % 11u)
					{
					case 0u:
					{
						int num2;
						arg_11E_0 = (((long)num2 >= PacketWriter.smethod_2(PacketWriter.smethod_1(this))) ? 1093790467u : 1743095117u);
						continue;
					}
					case 1u:
						arg_11E_0 = (num * 2838672913u ^ 2341229985u);
						continue;
					case 2u:
						array[0] = (byte)(255u & this.Size);
						arg_11E_0 = (num * 1119933883u ^ 3466367558u);
						continue;
					case 3u:
					{
						PacketWriter.smethod_3(this, 0, SeekOrigin.Begin);
						int num2 = 0;
						arg_11E_0 = (num * 3158397280u ^ 3757425747u);
						continue;
					}
					case 4u:
						goto IL_157;
					case 5u:
						arg_11E_0 = (((!isAuthPacket) ? 1910176589u : 1261149097u) ^ num * 3420629264u);
						continue;
					case 6u:
					{
						int num2;
						num2++;
						arg_11E_0 = (num * 406199060u ^ 611498539u);
						continue;
					}
					case 8u:
					{
						int num2;
						array[num2] = (byte)PacketWriter.smethod_4(PacketWriter.smethod_1(this));
						arg_11E_0 = 204451283u;
						continue;
					}
					case 9u:
						this.Size = (uint)(array.Length - 4);
						arg_11E_0 = (num * 2660983120u ^ 3795151527u);
						continue;
					case 10u:
						array[1] = (byte)(255u & this.Size >> 8);
						arg_11E_0 = (num * 3804110805u ^ 3371470262u);
						continue;
					}
					return array;
				}
			}
			return array;
		}

		public void WriteInt8(sbyte data)
		{
			this.method_0(data);
		}

		public void WriteInt16(short data)
		{
			this.method_1(data);
		}

		public void WriteInt32(int data)
		{
			this.method_2(data);
		}

		public void WriteInt64(long data)
		{
			this.method_3(data);
		}

		public void WriteUInt8(byte data)
		{
			this.method_4(data);
		}

		public void WriteUInt16(ushort data)
		{
			this.method_5(data);
		}

		public void WriteUInt32(uint data)
		{
			this.method_6(data);
		}

		public void WriteUInt64(ulong data)
		{
			this.method_7(data);
		}

		public void WriteFloat(float data)
		{
			this.method_8(data);
		}

		public void WriteDouble(double data)
		{
			this.method_9(data);
		}

		public void WriteCString(string data)
		{
			byte[] data2 = PacketWriter.smethod_6(PacketWriter.smethod_5(), data);
			this.WriteBytes(data2, 0);
			this.WriteUInt8(0);
		}

		public void WriteString(string data, bool nullIfEmpty = true)
		{
			byte[] array = PacketWriter.smethod_6(PacketWriter.smethod_5(), data);
			if (array.Length == 0 & nullIfEmpty)
			{
				goto IL_15;
			}
			goto IL_51;
			uint arg_35_0;
			while (true)
			{
				IL_30:
				uint num;
				switch ((num = (arg_35_0 ^ 3811660966u)) % 4u)
				{
				case 1u:
					goto IL_51;
				case 2u:
					array = new byte[1];
					arg_35_0 = (num * 3327909538u ^ 4252286263u);
					continue;
				case 3u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_35_0 = 3517538860u;
			goto IL_30;
			IL_51:
			this.WriteBytes(array, 0);
			arg_35_0 = 2490499242u;
			goto IL_30;
		}

		public void WriteUnixTime()
		{
			DateTime d = new DateTime(1970, 1, 1);
			while (true)
			{
				IL_6B:
				uint arg_4F_0 = 3979516039u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4F_0 ^ 2935553566u)) % 4u)
					{
					case 0u:
						goto IL_6B;
					case 1u:
					{
						TimeSpan timeSpan = DateTime.Now - d;
						arg_4F_0 = (num * 2753946769u ^ 212057177u);
						continue;
					}
					case 2u:
					{
						TimeSpan timeSpan;
						this.WriteUInt32(Convert.ToUInt32(timeSpan.TotalSeconds));
						arg_4F_0 = (num * 3903076465u ^ 2655937991u);
						continue;
					}
					}
					return;
				}
			}
		}

		public void WritePackedTime()
		{
			DateTime now = DateTime.Now;
			this.WriteUInt32(Convert.ToUInt32(now.Year - 2000 << 24 | now.Month - 1 << 20 | now.Day - 1 << 14 | (int)((int)now.DayOfWeek << 11) | now.Hour << 6 | now.Minute));
		}

		public void WriteSmartGuid(SmartGuid guid)
		{
			byte data;
			byte int_;
			byte[] packedGuid = this.GetPackedGuid(guid.Guid, out data, out int_);
			byte int_2;
			byte[] packedGuid2;
			while (true)
			{
				IL_90:
				uint arg_6F_0 = 3222044819u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6F_0 ^ 3599493022u)) % 5u)
					{
					case 0u:
						goto IL_90;
					case 1u:
						this.WriteUInt8(data);
						arg_6F_0 = (num * 1460792118u ^ 2740115011u);
						continue;
					case 2u:
					{
						byte data2;
						this.WriteUInt8(data2);
						PacketWriter.smethod_7(this, packedGuid, 0, (int)int_);
						arg_6F_0 = (num * 3557611683u ^ 3621565152u);
						continue;
					}
					case 3u:
					{
						byte data2;
						packedGuid2 = this.GetPackedGuid(guid.HighGuid, out data2, out int_2);
						arg_6F_0 = (num * 477547735u ^ 363270741u);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:
			PacketWriter.smethod_7(this, packedGuid2, 0, (int)int_2);
		}

		public void WriteSmartGuid(ulong guid, ObjectType type, SmartGuid sGuid = null)
		{
			if (guid != 0uL)
			{
				goto IL_25;
			}
			goto IL_F5;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 1646368848u)) % 10u)
				{
				case 0u:
				{
					byte data;
					this.WriteUInt8(data);
					arg_BF_0 = (num * 860942149u ^ 3453380518u);
					continue;
				}
				case 1u:
				{
					byte data;
					byte count;
					byte[] smartGuid = this.GetSmartGuid((sGuid == null) ? 580726857419194368uL : sGuid.HighGuid, out data, out count);
					arg_BF_0 = 1369678913u;
					continue;
				}
				case 2u:
				{
					byte data2 = 0;
					byte data = 0;
					byte count2;
					byte[] smartGuid2 = this.GetSmartGuid(guid, out data2, out count2);
					arg_BF_0 = (num * 2616288901u ^ 1468100039u);
					continue;
				}
				case 3u:
				{
					byte data2;
					this.WriteUInt8(data2);
					arg_BF_0 = (num * 2677091164u ^ 3202732928u);
					continue;
				}
				case 4u:
					goto IL_F5;
				case 5u:
					return;
				case 6u:
				{
					byte count2;
					byte[] smartGuid2;
					this.WriteBytes(smartGuid2, (int)count2);
					arg_BF_0 = (num * 3836561347u ^ 1058943091u);
					continue;
				}
				case 8u:
					goto IL_25;
				case 9u:
				{
					byte count;
					byte[] smartGuid;
					this.WriteBytes(smartGuid, (int)count);
					arg_BF_0 = (num * 483692983u ^ 3257050584u);
					continue;
				}
				}
				break;
			}
			return;
			IL_25:
			arg_BF_0 = 261752828u;
			goto IL_BA;
			IL_F5:
			this.WriteUInt8(0);
			this.WriteUInt8(0);
			arg_BF_0 = 72102509u;
			goto IL_BA;
		}

		public byte[] GetSmartGuid(ulong guid, out byte gLength, out byte written)
		{
			byte[] array = new byte[8];
			byte b3;
			while (true)
			{
				IL_12D:
				uint arg_F3_0 = 1518229315u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F3_0 ^ 290725482u)) % 11u)
					{
					case 0u:
					{
						byte b;
						gLength = b;
						arg_F3_0 = (num * 3180364157u ^ 2047276469u);
						continue;
					}
					case 1u:
					{
						byte b = 0;
						arg_F3_0 = (num * 1208499002u ^ 4258942106u);
						continue;
					}
					case 2u:
						arg_F3_0 = (((guid & 255uL) != 0uL) ? 937976330u : 1097842365u);
						continue;
					case 3u:
						arg_F3_0 = ((guid == 0uL) ? 568352903u : 1527528247u);
						continue;
					case 4u:
						arg_F3_0 = (num * 2944818540u ^ 2606755564u);
						continue;
					case 6u:
						goto IL_12D;
					case 7u:
					{
						byte b;
						byte b2;
						b |= (byte)(1 << (int)b2);
						array[(int)b3] = (byte)(guid & 255uL);
						b3 += 1;
						arg_F3_0 = (num * 1368850540u ^ 1431029309u);
						continue;
					}
					case 8u:
					{
						b3 = 0;
						byte b2 = 0;
						arg_F3_0 = (num * 3240317237u ^ 2659096902u);
						continue;
					}
					case 9u:
						guid >>= 8;
						arg_F3_0 = 373789784u;
						continue;
					case 10u:
					{
						byte b2;
						b2 += 1;
						arg_F3_0 = (num * 2250317194u ^ 1249084784u);
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			written = b3;
			return array;
		}

		public void WriteSmartGuid(ulong guid, global::GuidType type = global::GuidType.Player)
		{
			SmartGuid guid2 = new SmartGuid
			{
				Type = type,
				CreationBits = guid,
				RealmId = 1
			};
			if (guid == 0uL)
			{
				while (true)
				{
					IL_50:
					uint arg_38_0 = 66514321u;
					while (true)
					{
						uint num;
						switch ((num = (arg_38_0 ^ 2001468684u)) % 3u)
						{
						case 0u:
							goto IL_50;
						case 1u:
							guid2 = new SmartGuid();
							arg_38_0 = (num * 2828181269u ^ 2346161042u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			this.WriteSmartGuid(guid2);
		}

		private byte[] GetPackedGuid(ulong guid, out byte gLength, out byte written)
		{
			byte[] array = new byte[8];
			byte b2;
			while (true)
			{
				IL_116:
				uint arg_E0_0 = 1742355484u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E0_0 ^ 1581815732u)) % 10u)
					{
					case 1u:
						arg_E0_0 = ((guid == 0uL) ? 1503605260u : 1448044057u);
						continue;
					case 2u:
					{
						byte b = 0;
						b2 = 0;
						arg_E0_0 = (num * 1493472980u ^ 2528929882u);
						continue;
					}
					case 3u:
					{
						byte b;
						byte b3;
						b |= (byte)(1 << (int)b3);
						arg_E0_0 = (num * 1673829066u ^ 3877665201u);
						continue;
					}
					case 4u:
						goto IL_116;
					case 5u:
					{
						guid >>= 8;
						byte b3;
						b3 += 1;
						arg_E0_0 = 1766530581u;
						continue;
					}
					case 6u:
					{
						byte b;
						gLength = b;
						arg_E0_0 = (num * 2829906418u ^ 3937713424u);
						continue;
					}
					case 7u:
						array[(int)b2] = (byte)(guid & 255uL);
						b2 += 1;
						arg_E0_0 = (num * 2635804877u ^ 3464196626u);
						continue;
					case 8u:
					{
						byte b3 = 0;
						arg_E0_0 = (num * 3711330271u ^ 714552167u);
						continue;
					}
					case 9u:
						arg_E0_0 = (((guid & 255uL) == 0uL) ? 409227965u : 1744253535u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			written = b2;
			return array;
		}

		public void WriteBytes(byte[] data, int count = 0)
		{
			if (count != 0)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -1897955788;
			IL_08:
			switch ((arg_0D_0 ^ -795743177) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				IL_27:
				PacketWriter.smethod_7(this, data, 0, count);
				arg_0D_0 = -98510427;
				goto IL_08;
			case 3:
				PacketWriter.smethod_8(this, data);
				return;
			}
		}

		public void WriteBitArray(BitArray buffer, int len)
		{
			byte[] array = new byte[PacketWriter.smethod_10((PacketWriter.smethod_9(buffer) + 8) / 8) + 1];
			while (true)
			{
				IL_A3:
				uint arg_83_0 = 2766179428u;
				while (true)
				{
					uint num;
					switch ((num = (arg_83_0 ^ 3138209411u)) % 5u)
					{
					case 0u:
						PacketWriter.smethod_11(buffer, array, 0);
						PacketWriter.smethod_7(this, array, 0, len);
						arg_83_0 = 2437939306u;
						continue;
					case 1u:
						arg_83_0 = (((len > array.Length) ? 627101049u : 1635445140u) ^ num * 3469367682u);
						continue;
					case 2u:
						array = array.Concat(new byte[len - array.Length]).ToArray<byte>();
						arg_83_0 = (num * 88440560u ^ 1331077402u);
						continue;
					case 4u:
						goto IL_A3;
					}
					return;
				}
			}
		}

		public void WriteUInt32Pos(uint data, int pos)
		{
			PacketWriter.smethod_3(this, pos, SeekOrigin.Begin);
			this.WriteUInt32(data);
			PacketWriter.smethod_3(this, (int)PacketWriter.smethod_2(PacketWriter.smethod_1(this)) - 1, SeekOrigin.Begin);
		}

		static MemoryStream smethod_0()
		{
			return new MemoryStream();
		}

		static Stream smethod_1(BinaryWriter binaryWriter_0)
		{
			return binaryWriter_0.BaseStream;
		}

		static long smethod_2(Stream stream_0)
		{
			return stream_0.Length;
		}

		static long smethod_3(BinaryWriter binaryWriter_0, int int_0, SeekOrigin seekOrigin_0)
		{
			return binaryWriter_0.Seek(int_0, seekOrigin_0);
		}

		static int smethod_4(Stream stream_0)
		{
			return stream_0.ReadByte();
		}

		void method_0(sbyte sbyte_0)
		{
			base.Write(sbyte_0);
		}

		void method_1(short short_0)
		{
			base.Write(short_0);
		}

		void method_2(int int_0)
		{
			base.Write(int_0);
		}

		void method_3(long long_0)
		{
			base.Write(long_0);
		}

		void method_4(byte byte_0)
		{
			base.Write(byte_0);
		}

		void method_5(ushort ushort_0)
		{
			base.Write(ushort_0);
		}

		void method_6(uint uint_0)
		{
			base.Write(uint_0);
		}

		void method_7(ulong ulong_0)
		{
			base.Write(ulong_0);
		}

		void method_8(float float_0)
		{
			base.Write(float_0);
		}

		void method_9(double double_0)
		{
			base.Write(double_0);
		}

		static Encoding smethod_5()
		{
			return Encoding.UTF8;
		}

		static byte[] smethod_6(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static void smethod_7(BinaryWriter binaryWriter_0, byte[] byte_0, int int_0, int int_1)
		{
			binaryWriter_0.Write(byte_0, int_0, int_1);
		}

		static void smethod_8(BinaryWriter binaryWriter_0, byte[] byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static int smethod_9(BitArray bitArray_0)
		{
			return bitArray_0.Length;
		}

		static int smethod_10(int int_0)
		{
			return Convert.ToInt32(int_0);
		}

		static void smethod_11(BitArray bitArray_0, Array array_0, int int_0)
		{
			bitArray_0.CopyTo(array_0, int_0);
		}
	}
}
