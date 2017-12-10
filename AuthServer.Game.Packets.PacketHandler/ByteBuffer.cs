using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace AuthServer.Game.Packets.PacketHandler
{
	public class ByteBuffer : IDisposable
	{
		private byte BitPosition = 8;

		private byte BitValue;

		private BinaryWriter writeStream;

		private BinaryReader readStream;

		public ByteBuffer()
		{
			this.writeStream = ByteBuffer.smethod_1(ByteBuffer.smethod_0());
		}

		public ByteBuffer(byte[] data)
		{
			while (true)
			{
				IL_4A:
				uint arg_32_0 = 1277383585u;
				while (true)
				{
					uint num;
					switch ((num = (arg_32_0 ^ 2012861080u)) % 3u)
					{
					case 0u:
						goto IL_4A;
					case 1u:
						this.readStream = ByteBuffer.smethod_3(ByteBuffer.smethod_2(data));
						arg_32_0 = (num * 2507189274u ^ 3739588549u);
						continue;
					}
					return;
				}
			}
		}

		public void Dispose()
		{
			if (this.writeStream != null)
			{
				goto IL_4B;
			}
			goto IL_81;
			uint arg_55_0;
			while (true)
			{
				IL_50:
				uint num;
				switch ((num = (arg_55_0 ^ 3141536099u)) % 5u)
				{
				case 0u:
					goto IL_4B;
				case 1u:
					ByteBuffer.smethod_5(this.readStream);
					arg_55_0 = (num * 3360933649u ^ 248521375u);
					continue;
				case 3u:
					ByteBuffer.smethod_4(this.writeStream);
					arg_55_0 = (num * 1806868308u ^ 3140808729u);
					continue;
				case 4u:
					goto IL_81;
				}
				break;
			}
			return;
			IL_4B:
			arg_55_0 = 3451079971u;
			goto IL_50;
			IL_81:
			arg_55_0 = ((this.readStream == null) ? 4156338860u : 3236659808u);
			goto IL_50;
		}

		public sbyte ReadInt8()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_6(this.readStream);
		}

		public short ReadInt16()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_7(this.readStream);
		}

		public int ReadInt32()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_8(this.readStream);
		}

		public long ReadInt64()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_9(this.readStream);
		}

		public byte ReadUInt8()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_10(this.readStream);
		}

		public ushort ReadUInt16()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_11(this.readStream);
		}

		public uint ReadUInt32()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_12(this.readStream);
		}

		public ulong ReadUInt64()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_13(this.readStream);
		}

		public float ReadFloat()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_14(this.readStream);
		}

		public double ReadDouble()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_15(this.readStream);
		}

		public string ReadCString()
		{
			this.ResetBitPos();
			StringBuilder stringBuilder;
			while (true)
			{
				IL_C3:
				uint arg_9B_0 = 1215227309u;
				while (true)
				{
					uint num;
					switch ((num = (arg_9B_0 ^ 2004767394u)) % 7u)
					{
					case 0u:
					{
						char c;
						char c2;
						arg_9B_0 = ((c == c2) ? 966518197u : 2082839769u);
						continue;
					}
					case 1u:
					{
						char c = ByteBuffer.smethod_17(this.readStream);
						arg_9B_0 = (num * 1216300234u ^ 329147855u);
						continue;
					}
					case 2u:
						stringBuilder = ByteBuffer.smethod_16();
						arg_9B_0 = (num * 4167127647u ^ 4056163422u);
						continue;
					case 4u:
					{
						char c = ByteBuffer.smethod_17(this.readStream);
						char c2 = ByteBuffer.smethod_20(ByteBuffer.smethod_19(ByteBuffer.smethod_18(), new byte[1]));
						arg_9B_0 = (num * 1188310877u ^ 4251549052u);
						continue;
					}
					case 5u:
						goto IL_C3;
					case 6u:
					{
						char c;
						ByteBuffer.smethod_21(stringBuilder, c);
						arg_9B_0 = 1510893395u;
						continue;
					}
					}
					goto Block_2;
				}
			}
			Block_2:
			return ByteBuffer.smethod_22(stringBuilder);
		}

		public string ReadString(uint length)
		{
			if (length != 0u)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -2091770556;
			IL_08:
			switch ((arg_0D_0 ^ -1865938317) % 4)
			{
			case 0:
				IL_27:
				this.ResetBitPos();
				arg_0D_0 = -275579210;
				goto IL_08;
			case 2:
				goto IL_03;
			case 3:
				return "";
			}
			return ByteBuffer.smethod_19(ByteBuffer.smethod_18(), this.ReadBytes(length));
		}

		public bool ReadBool()
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_23(this.readStream);
		}

		public byte[] ReadBytes(uint count)
		{
			this.ResetBitPos();
			return ByteBuffer.smethod_24(this.readStream, (int)count);
		}

		public void Skip(int count)
		{
			this.ResetBitPos();
			while (true)
			{
				IL_4B:
				uint arg_33_0 = 1271571993u;
				while (true)
				{
					uint num;
					switch ((num = (arg_33_0 ^ 89898627u)) % 3u)
					{
					case 0u:
						goto IL_4B;
					case 2u:
					{
						Stream expr_13 = ByteBuffer.smethod_25(this.readStream);
						ByteBuffer.smethod_27(expr_13, ByteBuffer.smethod_26(expr_13) + (long)count);
						arg_33_0 = (num * 1673848751u ^ 246242862u);
						continue;
					}
					}
					return;
				}
			}
		}

		public byte ReadBit()
		{
			if (this.BitPosition == 8)
			{
				goto IL_3C;
			}
			goto IL_88;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num;
				switch ((num = (arg_64_0 ^ 2495703843u)) % 6u)
				{
				case 0u:
					this.BitPosition += 1;
					arg_64_0 = (num * 874961674u ^ 2504799792u);
					continue;
				case 2u:
					goto IL_88;
				case 3u:
					goto IL_3C;
				case 4u:
					this.BitPosition = 0;
					arg_64_0 = (num * 167866094u ^ 965148865u);
					continue;
				case 5u:
					this.BitValue = this.ReadUInt8();
					arg_64_0 = (num * 199237547u ^ 3430839254u);
					continue;
				}
				break;
			}
			int bitValue;
			return (byte)(bitValue >> 7);
			IL_3C:
			arg_64_0 = 3589106364u;
			goto IL_5F;
			IL_88:
			bitValue = (int)this.BitValue;
			this.BitValue = (byte)(2 * bitValue);
			arg_64_0 = 2785765217u;
			goto IL_5F;
		}

		public bool HasBit()
		{
			if (this.BitPosition == 8)
			{
				goto IL_2D;
			}
			goto IL_53;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 2460502305u)) % 4u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					this.BitValue = this.ReadUInt8();
					this.BitPosition = 0;
					arg_37_0 = (num * 2908268954u ^ 2056153033u);
					continue;
				case 2u:
					goto IL_53;
				}
				break;
			}
			this.BitPosition += 1;
			int bitValue;
			return ByteBuffer.smethod_28(bitValue >> 7);
			IL_2D:
			arg_37_0 = 4001561160u;
			goto IL_32;
			IL_53:
			bitValue = (int)this.BitValue;
			this.BitValue = (byte)(2 * bitValue);
			arg_37_0 = 2301562614u;
			goto IL_32;
		}

		public T ReadBits<T>(int bitCount)
		{
			int num = 0;
			while (true)
			{
				IL_B9:
				uint arg_8D_0 = 3465226812u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8D_0 ^ 2196184328u)) % 8u)
					{
					case 0u:
						arg_8D_0 = (num2 * 1576970896u ^ 3006736875u);
						continue;
					case 1u:
					{
						int num3;
						num |= 1 << num3;
						arg_8D_0 = (num2 * 1102446751u ^ 761069744u);
						continue;
					}
					case 3u:
					{
						int num3;
						arg_8D_0 = ((num3 < 0) ? 3363807146u : 2758948141u);
						continue;
					}
					case 4u:
					{
						int num3 = bitCount - 1;
						arg_8D_0 = (num2 * 3390901102u ^ 2048271424u);
						continue;
					}
					case 5u:
						arg_8D_0 = ((!this.HasBit()) ? 2564258623u : 3838308889u);
						continue;
					case 6u:
						goto IL_B9;
					case 7u:
					{
						int num3;
						num3--;
						arg_8D_0 = 2853753067u;
						continue;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			return (T)((object)ByteBuffer.smethod_30(num, ByteBuffer.smethod_29(typeof(T).TypeHandle)));
		}

		public void WriteInt8<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_32(this.writeStream, ByteBuffer.smethod_31(data));
		}

		public void WriteInt16<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_34(this.writeStream, ByteBuffer.smethod_33(data));
		}

		public void WriteInt32<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_36(this.writeStream, ByteBuffer.smethod_35(data));
		}

		public void WriteInt64<T>(T data)
		{
			this.FlushBits();
			while (true)
			{
				IL_48:
				uint arg_30_0 = 1036369819u;
				while (true)
				{
					uint num;
					switch ((num = (arg_30_0 ^ 2045628314u)) % 3u)
					{
					case 0u:
						goto IL_48;
					case 2u:
						ByteBuffer.smethod_38(this.writeStream, ByteBuffer.smethod_37(data));
						arg_30_0 = (num * 3421296959u ^ 841904661u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteUInt8<T>(T data)
		{
			this.FlushBits();
			while (true)
			{
				IL_48:
				uint arg_30_0 = 2920097871u;
				while (true)
				{
					uint num;
					switch ((num = (arg_30_0 ^ 4038053612u)) % 3u)
					{
					case 0u:
						goto IL_48;
					case 1u:
						ByteBuffer.smethod_40(this.writeStream, ByteBuffer.smethod_39(data));
						arg_30_0 = (num * 232515336u ^ 978410188u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteUInt16<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_42(this.writeStream, ByteBuffer.smethod_41(data));
		}

		public void WriteUInt32<T>(T data)
		{
			this.FlushBits();
			while (true)
			{
				IL_48:
				uint arg_30_0 = 3198963542u;
				while (true)
				{
					uint num;
					switch ((num = (arg_30_0 ^ 2893365727u)) % 3u)
					{
					case 0u:
						goto IL_48;
					case 2u:
						ByteBuffer.smethod_44(this.writeStream, ByteBuffer.smethod_43(data));
						arg_30_0 = (num * 1716597332u ^ 1347428387u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteUInt64<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_46(this.writeStream, ByteBuffer.smethod_45(data));
		}

		public void WriteFloat<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_48(this.writeStream, ByteBuffer.smethod_47(data));
		}

		public void WriteDouble<T>(T data)
		{
			this.FlushBits();
			ByteBuffer.smethod_50(this.writeStream, ByteBuffer.smethod_49(data));
		}

		public void WriteCString(string str)
		{
			if (ByteBuffer.smethod_51(str))
			{
				goto IL_20;
			}
			goto IL_4A;
			uint arg_2A_0;
			while (true)
			{
				IL_25:
				uint num;
				switch ((num = (arg_2A_0 ^ 2656609575u)) % 5u)
				{
				case 0u:
					goto IL_20;
				case 2u:
					goto IL_4A;
				case 3u:
					this.WriteUInt8<int>(0);
					arg_2A_0 = (num * 1886522064u ^ 1900289982u);
					continue;
				case 4u:
					return;
				}
				break;
			}
			return;
			IL_20:
			arg_2A_0 = 3676467903u;
			goto IL_25;
			IL_4A:
			this.WriteString(str);
			this.WriteUInt8<int>(0);
			arg_2A_0 = 2810720667u;
			goto IL_25;
		}

		public void WriteString(string str)
		{
			byte[] data = ByteBuffer.smethod_52(ByteBuffer.smethod_18(), str);
			this.WriteBytes(data);
		}

		public void WriteBytes(byte[] data)
		{
			this.FlushBits();
			ByteBuffer.smethod_53(this.writeStream, data, 0, data.Length);
		}

		public void WriteBytes(byte[] data, uint count)
		{
			this.FlushBits();
			ByteBuffer.smethod_53(this.writeStream, data, 0, (int)count);
		}

		public void WriteBytes(ByteBuffer buffer)
		{
			this.WriteBytes(buffer.GetData());
		}

		public void Replace<T>(int pos, T value)
		{
			int int_ = (int)ByteBuffer.smethod_26(ByteBuffer.smethod_54(this.writeStream));
			ByteBuffer.smethod_55(this.writeStream, pos, SeekOrigin.Begin);
			string text = ByteBuffer.smethod_56(ByteBuffer.smethod_29(typeof(T).TypeHandle));
			while (true)
			{
				IL_704:
				uint arg_627_0 = 1638050503u;
				while (true)
				{
					uint num;
					switch ((num = (arg_627_0 ^ 1694542224u)) % 52u)
					{
					case 0u:
					{
						uint num2;
						arg_627_0 = (((num2 != 423635464u) ? 3714613865u : 2727776960u) ^ num * 2465125661u);
						continue;
					}
					case 1u:
					{
						uint num2;
						arg_627_0 = ((num2 != 765439473u) ? 146628923u : 1181320609u);
						continue;
					}
					case 2u:
						arg_627_0 = (num * 1605995385u ^ 570591926u);
						continue;
					case 3u:
						arg_627_0 = (num * 2857082033u ^ 961444247u);
						continue;
					case 4u:
						arg_627_0 = ((!ByteBuffer.smethod_57(text, Module.smethod_33<string>(3216441273u))) ? 451905569u : 2074048763u);
						continue;
					case 5u:
						arg_627_0 = (num * 4239927339u ^ 46014827u);
						continue;
					case 6u:
						arg_627_0 = (num * 55303795u ^ 1742785194u);
						continue;
					case 7u:
						arg_627_0 = (num * 1348080724u ^ 4188159500u);
						continue;
					case 8u:
						arg_627_0 = (num * 233709226u ^ 1605014112u);
						continue;
					case 9u:
					{
						uint num2;
						arg_627_0 = (((num2 == 697196164u) ? 3448985298u : 3558868657u) ^ num * 1068338810u);
						continue;
					}
					case 10u:
						arg_627_0 = (num * 4184828199u ^ 4069931930u);
						continue;
					case 11u:
						this.WriteInt64<long>(ByteBuffer.smethod_37(value));
						arg_627_0 = 1809284071u;
						continue;
					case 12u:
					{
						uint num2;
						arg_627_0 = (((num2 <= 1283547685u) ? 844171113u : 262452932u) ^ num * 4014795075u);
						continue;
					}
					case 13u:
						arg_627_0 = (num * 3253110964u ^ 2940982788u);
						continue;
					case 14u:
					{
						uint num2;
						arg_627_0 = (((num2 != 1324880019u) ? 2818429901u : 2386097546u) ^ num * 1396287726u);
						continue;
					}
					case 15u:
						this.WriteFloat<float>(ByteBuffer.smethod_47(value));
						arg_627_0 = 132211917u;
						continue;
					case 16u:
						ByteBuffer.smethod_55(this.writeStream, int_, SeekOrigin.Begin);
						arg_627_0 = 1037442282u;
						continue;
					case 17u:
						this.WriteInt8<sbyte>(ByteBuffer.smethod_31(value));
						arg_627_0 = 1327002064u;
						continue;
					case 18u:
						arg_627_0 = (num * 450477039u ^ 2714719670u);
						continue;
					case 19u:
					{
						uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text);
						arg_627_0 = (num * 4068470158u ^ 182657414u);
						continue;
					}
					case 20u:
						this.WriteUInt8<byte>(ByteBuffer.smethod_39(value));
						arg_627_0 = 677785995u;
						continue;
					case 21u:
					{
						uint num2;
						arg_627_0 = (((num2 != 3538687084u) ? 3784888270u : 2296096518u) ^ num * 3771703622u);
						continue;
					}
					case 22u:
						goto IL_704;
					case 23u:
						arg_627_0 = (num * 4267998005u ^ 3401975623u);
						continue;
					case 24u:
						arg_627_0 = (ByteBuffer.smethod_57(text, Module.smethod_37<string>(2367085557u)) ? 184043425u : 311443422u);
						continue;
					case 25u:
						arg_627_0 = (num * 2332540575u ^ 2412614503u);
						continue;
					case 26u:
						this.WriteInt16<short>(ByteBuffer.smethod_33(value));
						arg_627_0 = 814680403u;
						continue;
					case 27u:
						arg_627_0 = (ByteBuffer.smethod_57(text, Module.smethod_33<string>(2781839893u)) ? 2122639723u : 762611598u);
						continue;
					case 28u:
						arg_627_0 = (ByteBuffer.smethod_57(text, Module.smethod_33<string>(116627772u)) ? 134025371u : 1279434374u);
						continue;
					case 29u:
					{
						uint num2;
						arg_627_0 = (((num2 == 1323747186u) ? 1838954536u : 10204720u) ^ num * 1453766222u);
						continue;
					}
					case 30u:
						arg_627_0 = (ByteBuffer.smethod_57(text, Module.smethod_34<string>(2489397489u)) ? 1797296816u : 1811522181u);
						continue;
					case 31u:
					{
						uint num2;
						arg_627_0 = (((num2 == 3409549631u) ? 662254437u : 665021480u) ^ num * 3575541591u);
						continue;
					}
					case 32u:
					{
						uint num2;
						arg_627_0 = ((num2 == 2711245919u) ? 864026850u : 215120303u);
						continue;
					}
					case 33u:
						arg_627_0 = (num * 1089749385u ^ 1938289173u);
						continue;
					case 34u:
						this.WriteInt32<int>(ByteBuffer.smethod_35(value));
						arg_627_0 = 923165457u;
						continue;
					case 35u:
						arg_627_0 = (num * 726906172u ^ 366734052u);
						continue;
					case 36u:
						this.WriteUInt16<ushort>(ByteBuffer.smethod_41(value));
						arg_627_0 = 1327002064u;
						continue;
					case 37u:
					{
						uint num2;
						arg_627_0 = (((num2 > 697196164u) ? 222624305u : 1840450012u) ^ num * 3783047748u);
						continue;
					}
					case 38u:
						arg_627_0 = ((!ByteBuffer.smethod_57(text, Module.smethod_36<string>(950035757u))) ? 899175091u : 779950078u);
						continue;
					case 39u:
						arg_627_0 = (num * 1718563350u ^ 4113844018u);
						continue;
					case 40u:
						this.WriteUInt64<ulong>(ByteBuffer.smethod_45(value));
						arg_627_0 = 1327002064u;
						continue;
					case 41u:
						arg_627_0 = ((!ByteBuffer.smethod_57(text, Module.smethod_35<string>(1254630331u))) ? 1076183673u : 8430830u);
						continue;
					case 42u:
						arg_627_0 = (num * 1591322098u ^ 213133932u);
						continue;
					case 43u:
						arg_627_0 = (num * 3804430574u ^ 1762133146u);
						continue;
					case 44u:
					{
						uint num2;
						arg_627_0 = ((num2 > 1324880019u) ? 1676189624u : 913038541u);
						continue;
					}
					case 45u:
						arg_627_0 = (num * 46792096u ^ 3031530608u);
						continue;
					case 46u:
						arg_627_0 = ((!ByteBuffer.smethod_57(text, Module.smethod_35<string>(2681632874u))) ? 1903291235u : 602944264u);
						continue;
					case 47u:
					{
						uint num2;
						arg_627_0 = (((num2 == 1283547685u) ? 2872933897u : 2744565704u) ^ num * 2536509434u);
						continue;
					}
					case 48u:
						arg_627_0 = (ByteBuffer.smethod_57(text, Module.smethod_35<string>(3073353507u)) ? 1960848480u : 9149034u);
						continue;
					case 49u:
						arg_627_0 = (num * 2116399870u ^ 3150899462u);
						continue;
					case 51u:
						this.WriteUInt32<uint>(ByteBuffer.smethod_43(value));
						arg_627_0 = 1327002064u;
						continue;
					}
					return;
				}
			}
		}

		public bool WriteBit(object bit)
		{
			this.BitPosition -= 1;
			while (true)
			{
				IL_F2:
				uint arg_CA_0 = 1625335300u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CA_0 ^ 1808142760u)) % 7u)
					{
					case 1u:
						arg_CA_0 = ((this.BitPosition == 0) ? 884119853u : 1515143354u);
						continue;
					case 2u:
						this.BitValue |= (byte)(1 << (int)this.BitPosition);
						arg_CA_0 = (num * 501221808u ^ 3594316173u);
						continue;
					case 3u:
						ByteBuffer.smethod_40(this.writeStream, this.BitValue);
						arg_CA_0 = (num * 957592711u ^ 788086247u);
						continue;
					case 4u:
						arg_CA_0 = ((ByteBuffer.smethod_58(bit) ? 2249557286u : 3244849081u) ^ num * 1717938463u);
						continue;
					case 5u:
						this.BitPosition = 8;
						this.BitValue = 0;
						arg_CA_0 = (num * 1311305030u ^ 1907158322u);
						continue;
					case 6u:
						goto IL_F2;
					}
					goto Block_3;
				}
			}
			Block_3:
			return ByteBuffer.smethod_58(bit);
		}

		public void WriteBits(object bit, int count)
		{
			int num = count - 1;
			while (true)
			{
				IL_8F:
				uint arg_6B_0 = 2883024490u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6B_0 ^ 2424808432u)) % 6u)
					{
					case 1u:
						this.WriteBit(ByteBuffer.smethod_35(bit) >> num & 1);
						arg_6B_0 = 3842977497u;
						continue;
					case 2u:
						arg_6B_0 = (num2 * 2170514368u ^ 2594333672u);
						continue;
					case 3u:
						num--;
						arg_6B_0 = (num2 * 2536534661u ^ 1003645477u);
						continue;
					case 4u:
						arg_6B_0 = ((num < 0) ? 2940466672u : 3709056609u);
						continue;
					case 5u:
						goto IL_8F;
					}
					return;
				}
			}
		}

		public void WritePackedTime()
		{
			DateTime now = DateTime.Now;
			this.WriteUInt32<uint>(Convert.ToUInt32(now.Year - 2000 << 24 | now.Month - 1 << 20 | now.Day - 1 << 14 | (int)((int)now.DayOfWeek << 11) | now.Hour << 6 | now.Minute));
		}

		public int GetPosition()
		{
			long num = 0L;
			while (true)
			{
				IL_D3:
				uint arg_AB_0 = 2961494348u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AB_0 ^ 3009875001u)) % 7u)
					{
					case 0u:
						arg_AB_0 = (num2 * 1096810581u ^ 1736428796u);
						continue;
					case 2u:
						arg_AB_0 = (((this.writeStream == null) ? 2755453271u : 4267780409u) ^ num2 * 1242134569u);
						continue;
					case 3u:
						num = ByteBuffer.smethod_26(ByteBuffer.smethod_25(this.readStream));
						arg_AB_0 = (num2 * 3016629675u ^ 2045850323u);
						continue;
					case 4u:
						num = ByteBuffer.smethod_26(ByteBuffer.smethod_54(this.writeStream));
						arg_AB_0 = (num2 * 3894290057u ^ 3404457118u);
						continue;
					case 5u:
						goto IL_D3;
					case 6u:
						arg_AB_0 = ((this.readStream == null) ? 2869123286u : 3813280566u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			return (int)num;
		}

		public void SetPosition(long pos)
		{
			if (this.writeStream != null)
			{
				goto IL_37;
			}
			goto IL_6D;
			uint arg_41_0;
			while (true)
			{
				IL_3C:
				uint num;
				switch ((num = (arg_41_0 ^ 3786834332u)) % 5u)
				{
				case 0u:
					goto IL_6D;
				case 2u:
					goto IL_37;
				case 3u:
					ByteBuffer.smethod_27(ByteBuffer.smethod_25(this.readStream), pos);
					arg_41_0 = (num * 1655322744u ^ 1321440459u);
					continue;
				case 4u:
					goto IL_78;
				}
				break;
			}
			return;
			IL_78:
			ByteBuffer.smethod_27(ByteBuffer.smethod_54(this.writeStream), pos);
			return;
			IL_37:
			arg_41_0 = 2204217955u;
			goto IL_3C;
			IL_6D:
			arg_41_0 = ((this.readStream == null) ? 3692447091u : 4112260037u);
			goto IL_3C;
		}

		public void FlushBits()
		{
			if (this.BitPosition != 8)
			{
				goto IL_2D;
			}
			IL_09:
			int arg_13_0 = -2069191959;
			IL_0E:
			switch ((arg_13_0 ^ -1107548226) % 4)
			{
			case 0:
				goto IL_09;
			case 2:
				IL_2D:
				ByteBuffer.smethod_40(this.writeStream, this.BitValue);
				this.BitValue = 0;
				arg_13_0 = -180495177;
				goto IL_0E;
			case 3:
				return;
			}
			this.BitPosition = 8;
		}

		public void ResetBitPos()
		{
			if (this.BitPosition <= 7)
			{
				goto IL_2D;
			}
			IL_09:
			int arg_13_0 = -135490617;
			IL_0E:
			switch ((arg_13_0 ^ -1494272891) % 4)
			{
			case 1:
				IL_2D:
				this.BitPosition = 8;
				this.BitValue = 0;
				arg_13_0 = -1839859391;
				goto IL_0E;
			case 2:
				return;
			case 3:
				goto IL_09;
			}
		}

		public byte[] GetData()
		{
			Stream currentStream = this.GetCurrentStream();
			byte[] array = new byte[ByteBuffer.smethod_59(currentStream)];
			long long_ = ByteBuffer.smethod_26(currentStream);
			while (true)
			{
				IL_98:
				uint arg_77_0 = 1066532498u;
				while (true)
				{
					uint num;
					switch ((num = (arg_77_0 ^ 513493344u)) % 5u)
					{
					case 1u:
					{
						int num2;
						array[num2] = (byte)ByteBuffer.smethod_61(currentStream);
						num2++;
						arg_77_0 = 1039632003u;
						continue;
					}
					case 2u:
					{
						int num2;
						arg_77_0 = ((num2 < array.Length) ? 535420235u : 120473455u);
						continue;
					}
					case 3u:
					{
						ByteBuffer.smethod_60(currentStream, 0L, SeekOrigin.Begin);
						int num2 = 0;
						arg_77_0 = (num * 952820921u ^ 3161584481u);
						continue;
					}
					case 4u:
						goto IL_98;
					}
					goto Block_2;
				}
			}
			Block_2:
			ByteBuffer.smethod_60(currentStream, long_, SeekOrigin.Begin);
			return array;
		}

		public uint GetSize()
		{
			return (uint)ByteBuffer.smethod_59(this.GetCurrentStream());
		}

		public Stream GetCurrentStream()
		{
			if (this.writeStream != null)
			{
				return ByteBuffer.smethod_54(this.writeStream);
			}
			return ByteBuffer.smethod_25(this.readStream);
		}

		public void Clear()
		{
			this.BitPosition = 8;
			this.BitValue = 0;
			this.writeStream = ByteBuffer.smethod_1(ByteBuffer.smethod_0());
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

		static void smethod_4(BinaryWriter binaryWriter_0)
		{
			binaryWriter_0.Dispose();
		}

		static void smethod_5(BinaryReader binaryReader_0)
		{
			binaryReader_0.Dispose();
		}

		static sbyte smethod_6(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadSByte();
		}

		static short smethod_7(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadInt16();
		}

		static int smethod_8(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadInt32();
		}

		static long smethod_9(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadInt64();
		}

		static byte smethod_10(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadByte();
		}

		static ushort smethod_11(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt16();
		}

		static uint smethod_12(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt32();
		}

		static ulong smethod_13(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadUInt64();
		}

		static float smethod_14(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadSingle();
		}

		static double smethod_15(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadDouble();
		}

		static StringBuilder smethod_16()
		{
			return new StringBuilder();
		}

		static char smethod_17(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadChar();
		}

		static Encoding smethod_18()
		{
			return Encoding.UTF8;
		}

		static string smethod_19(Encoding encoding_0, byte[] byte_0)
		{
			return encoding_0.GetString(byte_0);
		}

		static char smethod_20(string string_0)
		{
			return Convert.ToChar(string_0);
		}

		static StringBuilder smethod_21(StringBuilder stringBuilder_0, char char_0)
		{
			return stringBuilder_0.Append(char_0);
		}

		static string smethod_22(object object_0)
		{
			return object_0.ToString();
		}

		static bool smethod_23(BinaryReader binaryReader_0)
		{
			return binaryReader_0.ReadBoolean();
		}

		static byte[] smethod_24(BinaryReader binaryReader_0, int int_0)
		{
			return binaryReader_0.ReadBytes(int_0);
		}

		static Stream smethod_25(BinaryReader binaryReader_0)
		{
			return binaryReader_0.BaseStream;
		}

		static long smethod_26(Stream stream_0)
		{
			return stream_0.Position;
		}

		static void smethod_27(Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}

		static bool smethod_28(int int_0)
		{
			return Convert.ToBoolean(int_0);
		}

		static Type smethod_29(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static object smethod_30(object object_0, Type type_0)
		{
			return Convert.ChangeType(object_0, type_0);
		}

		static sbyte smethod_31(object object_0)
		{
			return Convert.ToSByte(object_0);
		}

		static void smethod_32(BinaryWriter binaryWriter_0, sbyte sbyte_0)
		{
			binaryWriter_0.Write(sbyte_0);
		}

		static short smethod_33(object object_0)
		{
			return Convert.ToInt16(object_0);
		}

		static void smethod_34(BinaryWriter binaryWriter_0, short short_0)
		{
			binaryWriter_0.Write(short_0);
		}

		static int smethod_35(object object_0)
		{
			return Convert.ToInt32(object_0);
		}

		static void smethod_36(BinaryWriter binaryWriter_0, int int_0)
		{
			binaryWriter_0.Write(int_0);
		}

		static long smethod_37(object object_0)
		{
			return Convert.ToInt64(object_0);
		}

		static void smethod_38(BinaryWriter binaryWriter_0, long long_0)
		{
			binaryWriter_0.Write(long_0);
		}

		static byte smethod_39(object object_0)
		{
			return Convert.ToByte(object_0);
		}

		static void smethod_40(BinaryWriter binaryWriter_0, byte byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static ushort smethod_41(object object_0)
		{
			return Convert.ToUInt16(object_0);
		}

		static void smethod_42(BinaryWriter binaryWriter_0, ushort ushort_0)
		{
			binaryWriter_0.Write(ushort_0);
		}

		static uint smethod_43(object object_0)
		{
			return Convert.ToUInt32(object_0);
		}

		static void smethod_44(BinaryWriter binaryWriter_0, uint uint_0)
		{
			binaryWriter_0.Write(uint_0);
		}

		static ulong smethod_45(object object_0)
		{
			return Convert.ToUInt64(object_0);
		}

		static void smethod_46(BinaryWriter binaryWriter_0, ulong ulong_0)
		{
			binaryWriter_0.Write(ulong_0);
		}

		static float smethod_47(object object_0)
		{
			return Convert.ToSingle(object_0);
		}

		static void smethod_48(BinaryWriter binaryWriter_0, float float_0)
		{
			binaryWriter_0.Write(float_0);
		}

		static double smethod_49(object object_0)
		{
			return Convert.ToDouble(object_0);
		}

		static void smethod_50(BinaryWriter binaryWriter_0, double double_0)
		{
			binaryWriter_0.Write(double_0);
		}

		static bool smethod_51(string string_0)
		{
			return string.IsNullOrEmpty(string_0);
		}

		static byte[] smethod_52(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static void smethod_53(BinaryWriter binaryWriter_0, byte[] byte_0, int int_0, int int_1)
		{
			binaryWriter_0.Write(byte_0, int_0, int_1);
		}

		static Stream smethod_54(BinaryWriter binaryWriter_0)
		{
			return binaryWriter_0.BaseStream;
		}

		static long smethod_55(BinaryWriter binaryWriter_0, int int_0, SeekOrigin seekOrigin_0)
		{
			return binaryWriter_0.Seek(int_0, seekOrigin_0);
		}

		static string smethod_56(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static bool smethod_57(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static bool smethod_58(object object_0)
		{
			return Convert.ToBoolean(object_0);
		}

		static long smethod_59(Stream stream_0)
		{
			return stream_0.Length;
		}

		static long smethod_60(Stream stream_0, long long_0, SeekOrigin seekOrigin_0)
		{
			return stream_0.Seek(long_0, seekOrigin_0);
		}

		static int smethod_61(Stream stream_0)
		{
			return stream_0.ReadByte();
		}
	}
}
