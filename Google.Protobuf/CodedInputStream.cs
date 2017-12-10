using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class CodedInputStream
	{
		private readonly byte[] buffer;

		private int bufferSize;

		private int bufferSizeAfterLimit;

		private int bufferPos;

		private readonly Stream input;

		private uint lastTag;

		private uint nextTag;

		private bool hasNextTag;

		internal const int DefaultRecursionLimit = 64;

		internal const int DefaultSizeLimit = 67108864;

		internal const int BufferSize = 4096;

		private int totalBytesRetired;

		private int currentLimit = 2147483647;

		private int recursionDepth;

		private readonly int recursionLimit;

		private readonly int sizeLimit;

		public long Position
		{
			get
			{
				if (this.input != null)
				{
					return CodedInputStream.smethod_1(this.input) - (long)(this.bufferSize + this.bufferSizeAfterLimit - this.bufferPos);
				}
				return (long)this.bufferPos;
			}
		}

		internal uint LastTag
		{
			get
			{
				return this.lastTag;
			}
		}

		public int SizeLimit
		{
			get
			{
				return this.sizeLimit;
			}
		}

		public int RecursionLimit
		{
			get
			{
				return this.recursionLimit;
			}
		}

		internal bool ReachedLimit
		{
			get
			{
				return this.currentLimit != 2147483647 && this.totalBytesRetired + this.bufferPos >= this.currentLimit;
			}
		}

		public bool IsAtEnd
		{
			get
			{
				return this.bufferPos == this.bufferSize && !this.RefillBuffer(false);
			}
		}

		public CodedInputStream(byte[] buffer) : this(null, Preconditions.CheckNotNull<byte[]>(buffer, Module.smethod_34<string>(158792410u)), 0, buffer.Length)
		{
		}

		public CodedInputStream(byte[] buffer, int offset, int length) : this(null, Preconditions.CheckNotNull<byte[]>(buffer, Module.smethod_33<string>(4137391514u)), offset, offset + length)
		{
			while (true)
			{
				IL_E1:
				uint arg_B5_0 = 4105809620u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B5_0 ^ 3055581533u)) % 8u)
					{
					case 0u:
						goto IL_E8;
					case 1u:
						arg_B5_0 = (((offset >= 0) ? 4187037825u : 2165485583u) ^ num * 635038362u);
						continue;
					case 2u:
						goto IL_E1;
					case 4u:
						goto IL_102;
					case 5u:
						arg_B5_0 = (((offset + length <= buffer.Length) ? 2611700846u : 3673290905u) ^ num * 660699824u);
						continue;
					case 6u:
						arg_B5_0 = (((offset > buffer.Length) ? 4145083265u : 2421336766u) ^ num * 3312781942u);
						continue;
					case 7u:
						arg_B5_0 = ((length < 0) ? 2770183273u : 2368368432u);
						continue;
					}
					goto Block_5;
				}
			}
			Block_5:
			return;
			IL_E8:
			throw CodedInputStream.smethod_0(Module.smethod_36<string>(2579925932u), Module.smethod_36<string>(944709867u));
			IL_102:
			throw CodedInputStream.smethod_0(Module.smethod_37<string>(2099803356u), Module.smethod_33<string>(1031020676u));
		}

		public CodedInputStream(Stream input) : this(input, new byte[4096], 0, 0)
		{
			Preconditions.CheckNotNull<Stream>(input, Module.smethod_35<string>(2407332993u));
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize)
		{
			this.input = input;
			this.buffer = buffer;
			this.bufferPos = bufferPos;
			this.bufferSize = bufferSize;
			this.sizeLimit = 67108864;
			this.recursionLimit = 64;
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit) : this(input, buffer, bufferPos, bufferSize)
		{
			while (true)
			{
				IL_96:
				uint arg_6E_0 = 795374245u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6E_0 ^ 775856385u)) % 7u)
					{
					case 0u:
						arg_6E_0 = ((recursionLimit > 0) ? 269118455u : 1545511542u);
						continue;
					case 1u:
						goto IL_9D;
					case 2u:
						this.sizeLimit = sizeLimit;
						this.recursionLimit = recursionLimit;
						arg_6E_0 = 126081230u;
						continue;
					case 3u:
						goto IL_96;
					case 5u:
						arg_6E_0 = (((sizeLimit <= 0) ? 691199968u : 700376769u) ^ num * 2166325011u);
						continue;
					case 6u:
						goto IL_B7;
					}
					goto Block_3;
				}
			}
			Block_3:
			return;
			IL_9D:
			throw CodedInputStream.smethod_0(Module.smethod_36<string>(2684209016u), Module.smethod_33<string>(2066477622u));
			IL_B7:
			throw CodedInputStream.smethod_0(Module.smethod_33<string>(2878076541u), Module.smethod_36<string>(4050255904u));
		}

		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit)
		{
			return new CodedInputStream(input, new byte[4096], 0, 0, sizeLimit, recursionLimit);
		}

		internal void CheckReadEndOfStreamTag()
		{
			if (this.lastTag != 0u)
			{
				throw InvalidProtocolBufferException.MoreDataAvailable();
			}
		}

		public uint PeekTag()
		{
			if (this.hasNextTag)
			{
				goto IL_08;
			}
			goto IL_48;
			uint arg_28_0;
			while (true)
			{
				IL_23:
				uint num;
				switch ((num = (arg_28_0 ^ 843549161u)) % 5u)
				{
				case 0u:
					this.hasNextTag = true;
					arg_28_0 = (num * 144223796u ^ 2669347567u);
					continue;
				case 2u:
					goto IL_48;
				case 3u:
					goto IL_08;
				case 4u:
					goto IL_70;
				}
				break;
			}
			uint num2;
			this.lastTag = num2;
			return this.nextTag;
			IL_70:
			return this.nextTag;
			IL_08:
			arg_28_0 = 1162068261u;
			goto IL_23;
			IL_48:
			num2 = this.lastTag;
			this.nextTag = this.ReadTag();
			arg_28_0 = 1996846084u;
			goto IL_23;
		}

		public uint ReadTag()
		{
			if (this.hasNextTag)
			{
				goto IL_12C;
			}
			goto IL_260;
			uint arg_1F0_0;
			while (true)
			{
				IL_1EB:
				uint num;
				switch ((num = (arg_1F0_0 ^ 3473818248u)) % 21u)
				{
				case 0u:
					this.lastTag = this.ReadRawVarint32();
					arg_1F0_0 = 4258493852u;
					continue;
				case 1u:
					this.lastTag = this.ReadRawVarint32();
					arg_1F0_0 = (num * 1928200741u ^ 984766884u);
					continue;
				case 2u:
				{
					int num2;
					int num3;
					num2 |= num3 << 7;
					arg_1F0_0 = (num * 2870894154u ^ 3386794191u);
					continue;
				}
				case 3u:
					arg_1F0_0 = (this.IsAtEnd ? 3602356442u : 2446105956u);
					continue;
				case 4u:
					arg_1F0_0 = ((this.lastTag == 0u) ? 2348968086u : 2303431287u);
					continue;
				case 5u:
				{
					int num2;
					this.lastTag = (uint)num2;
					arg_1F0_0 = (num * 2253391335u ^ 2512173805u);
					continue;
				}
				case 6u:
					this.hasNextTag = false;
					arg_1F0_0 = (num * 242178369u ^ 2396804050u);
					continue;
				case 7u:
					goto IL_12C;
				case 8u:
					goto IL_260;
				case 9u:
				{
					int num3;
					int num2 = num3 & 127;
					arg_1F0_0 = 4275598682u;
					continue;
				}
				case 10u:
					this.lastTag = this.nextTag;
					arg_1F0_0 = (num * 2614616463u ^ 266469774u);
					continue;
				case 11u:
				{
					int num3;
					arg_1F0_0 = (((num3 >= 128) ? 4053449985u : 2233079898u) ^ num * 3568448975u);
					continue;
				}
				case 12u:
					goto IL_275;
				case 13u:
					this.bufferPos -= 2;
					arg_1F0_0 = 3949501264u;
					continue;
				case 15u:
					arg_1F0_0 = (num * 3391944534u ^ 1178678178u);
					continue;
				case 16u:
					goto IL_285;
				case 17u:
				{
					int num3;
					this.lastTag = (uint)num3;
					arg_1F0_0 = (num * 2219623533u ^ 4172071489u);
					continue;
				}
				case 18u:
				{
					byte[] arg_62_0 = this.buffer;
					int num4 = this.bufferPos;
					this.bufferPos = num4 + 1;
					int num3;
					arg_1F0_0 = ((((num3 = arg_62_0[num4]) < 128) ? 950429324u : 1470973633u) ^ num * 1299985402u);
					continue;
				}
				case 19u:
				{
					byte[] arg_37_0 = this.buffer;
					int num4 = this.bufferPos;
					this.bufferPos = num4 + 1;
					int num3 = arg_37_0[num4];
					arg_1F0_0 = (num * 296800850u ^ 1922126118u);
					continue;
				}
				case 20u:
					goto IL_28B;
				}
				break;
			}
			goto IL_27E;
			IL_275:
			this.lastTag = 0u;
			return 0u;
			IL_27E:
			return this.lastTag;
			IL_285:
			throw InvalidProtocolBufferException.InvalidTag();
			IL_28B:
			return this.lastTag;
			IL_12C:
			arg_1F0_0 = 2318356756u;
			goto IL_1EB;
			IL_260:
			arg_1F0_0 = ((this.bufferPos + 2 > this.bufferSize) ? 3868930545u : 2295496730u);
			goto IL_1EB;
		}

		public void SkipLastField()
		{
			if (this.lastTag == 0u)
			{
				goto IL_1B;
			}
			goto IL_DA;
			uint arg_91_0;
			WireFormat.WireType tagWireType;
			while (true)
			{
				IL_8C:
				uint num;
				int size;
				switch ((num = (arg_91_0 ^ 216291838u)) % 15u)
				{
				case 0u:
					return;
				case 1u:
					this.SkipRawBytes(size);
					arg_91_0 = (num * 3252926349u ^ 3202087247u);
					continue;
				case 2u:
					switch (tagWireType)
					{
					case WireFormat.WireType.Varint:
						goto IL_3D;
					case WireFormat.WireType.Fixed64:
						goto IL_0D;
					case WireFormat.WireType.LengthDelimited:
						goto IL_2F;
					case WireFormat.WireType.StartGroup:
						goto IL_22;
					case WireFormat.WireType.EndGroup:
						break;
					case WireFormat.WireType.Fixed32:
						goto IL_EE;
					default:
						arg_91_0 = (num * 875934909u ^ 2465386267u);
						continue;
					}
					break;
				case 3u:
					goto IL_EE;
				case 4u:
					goto IL_3D;
				case 5u:
					return;
				case 6u:
					goto IL_2F;
				case 8u:
					return;
				case 9u:
					return;
				case 10u:
					goto IL_22;
				case 11u:
					goto IL_DA;
				case 12u:
					goto IL_1B;
				case 13u:
					goto IL_0D;
				case 14u:
					goto IL_F9;
				}
				break;
				IL_0D:
				this.ReadFixed64();
				arg_91_0 = 199393957u;
				continue;
				IL_22:
				this.SkipGroup();
				arg_91_0 = 531198599u;
				continue;
				IL_2F:
				size = this.ReadLength();
				arg_91_0 = 937284604u;
				continue;
				IL_3D:
				this.ReadRawVarint32();
				arg_91_0 = 1298294393u;
			}
			return;
			IL_EE:
			this.ReadFixed32();
			return;
			IL_F9:
			throw CodedInputStream.smethod_2(Module.smethod_34<string>(1950534549u));
			IL_1B:
			arg_91_0 = 1897579666u;
			goto IL_8C;
			IL_DA:
			tagWireType = WireFormat.GetTagWireType(this.lastTag);
			arg_91_0 = 1149262345u;
			goto IL_8C;
		}

		private void SkipGroup()
		{
			this.recursionDepth++;
			while (true)
			{
				IL_103:
				uint arg_CE_0 = 4083027391u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CE_0 ^ 3668092328u)) % 10u)
					{
					case 0u:
						this.recursionDepth--;
						arg_CE_0 = (num * 1200733701u ^ 2869581373u);
						continue;
					case 1u:
						goto IL_10A;
					case 2u:
					{
						uint num2;
						arg_CE_0 = (((num2 == 0u) ? 1156442343u : 1656609996u) ^ num * 1373211518u);
						continue;
					}
					case 3u:
						goto IL_103;
					case 4u:
					{
						uint num2 = this.ReadTag();
						arg_CE_0 = 3291722014u;
						continue;
					}
					case 5u:
					{
						uint num2;
						arg_CE_0 = (((WireFormat.GetTagWireType(num2) != WireFormat.WireType.EndGroup) ? 4252641792u : 3120290318u) ^ num * 2023774452u);
						continue;
					}
					case 6u:
						this.SkipLastField();
						arg_CE_0 = 4170186089u;
						continue;
					case 8u:
						goto IL_110;
					case 9u:
						arg_CE_0 = (((this.recursionDepth >= this.recursionLimit) ? 2276855929u : 3951636107u) ^ num * 1840386265u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			return;
			IL_10A:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_110:
			throw InvalidProtocolBufferException.RecursionLimitExceeded();
		}

		public double ReadDouble()
		{
			return CodedInputStream.smethod_3((long)this.ReadRawLittleEndian64());
		}

		public float ReadFloat()
		{
			if (BitConverter.IsLittleEndian)
			{
				goto IL_34;
			}
			goto IL_AC;
			uint arg_84_0;
			byte[] array;
			while (true)
			{
				IL_7F:
				uint num;
				switch ((num = (arg_84_0 ^ 3485784093u)) % 7u)
				{
				case 0u:
					goto IL_AC;
				case 1u:
					arg_84_0 = (((4 > this.bufferSize - this.bufferPos) ? 3912687515u : 3243081089u) ^ num * 3128540336u);
					continue;
				case 2u:
					goto IL_BB;
				case 4u:
					ByteArray.Reverse(array);
					arg_84_0 = (num * 1462737641u ^ 3256312271u);
					continue;
				case 5u:
					goto IL_34;
				case 6u:
					arg_84_0 = (((!BitConverter.IsLittleEndian) ? 1832188435u : 825894561u) ^ num * 276359282u);
					continue;
				}
				break;
			}
			goto IL_DB;
			IL_BB:
			float arg_DA_0 = CodedInputStream.smethod_4(this.buffer, this.bufferPos);
			this.bufferPos += 4;
			return arg_DA_0;
			IL_DB:
			return CodedInputStream.smethod_4(array, 0);
			IL_34:
			arg_84_0 = 3505293392u;
			goto IL_7F;
			IL_AC:
			array = this.ReadRawBytes(4);
			arg_84_0 = 3875258764u;
			goto IL_7F;
		}

		public ulong ReadUInt64()
		{
			return this.ReadRawVarint64();
		}

		public long ReadInt64()
		{
			return (long)this.ReadRawVarint64();
		}

		public int ReadInt32()
		{
			return (int)this.ReadRawVarint32();
		}

		public ulong ReadFixed64()
		{
			return this.ReadRawLittleEndian64();
		}

		public uint ReadFixed32()
		{
			return this.ReadRawLittleEndian32();
		}

		public bool ReadBool()
		{
			return this.ReadRawVarint32() > 0u;
		}

		public string ReadString()
		{
			int num = this.ReadLength();
			while (true)
			{
				IL_7D:
				uint arg_59_0 = 2897944458u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_59_0 ^ 3853002500u)) % 6u)
					{
					case 0u:
						goto IL_84;
					case 1u:
						goto IL_AA;
					case 2u:
						arg_59_0 = (((num != 0) ? 1371295095u : 232031949u) ^ num2 * 771795367u);
						continue;
					case 3u:
						goto IL_7D;
					case 5u:
						arg_59_0 = ((num <= this.bufferSize - this.bufferPos) ? 2296444942u : 3697458936u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			goto IL_B0;
			IL_84:
			string arg_A9_0 = CodedInputStream.smethod_5(CodedOutputStream.Utf8Encoding, this.buffer, this.bufferPos, num);
			this.bufferPos += num;
			return arg_A9_0;
			IL_AA:
			return "";
			IL_B0:
			return CodedInputStream.smethod_5(CodedOutputStream.Utf8Encoding, this.ReadRawBytes(num), 0, num);
		}

		public void ReadMessage(IMessage builder)
		{
			int byteLimit = this.ReadLength();
			if (this.recursionDepth >= this.recursionLimit)
			{
				goto IL_18;
			}
			goto IL_D1;
			uint arg_A0_0;
			int oldLimit;
			while (true)
			{
				IL_9B:
				uint num;
				switch ((num = (arg_A0_0 ^ 3594406295u)) % 9u)
				{
				case 1u:
					goto IL_D1;
				case 2u:
					goto IL_E0;
				case 3u:
					goto IL_E6;
				case 4u:
					builder.MergeFrom(this);
					this.CheckReadEndOfStreamTag();
					arg_A0_0 = (num * 668934549u ^ 3320989511u);
					continue;
				case 5u:
					this.recursionDepth--;
					this.PopLimit(oldLimit);
					arg_A0_0 = 3753135618u;
					continue;
				case 6u:
					this.recursionDepth++;
					arg_A0_0 = (num * 3605077701u ^ 1442008241u);
					continue;
				case 7u:
					arg_A0_0 = (((!this.ReachedLimit) ? 1131663392u : 1455061091u) ^ num * 2448985038u);
					continue;
				case 8u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_E0:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_E6:
			throw InvalidProtocolBufferException.RecursionLimitExceeded();
			IL_18:
			arg_A0_0 = 3717192022u;
			goto IL_9B;
			IL_D1:
			oldLimit = this.PushLimit(byteLimit);
			arg_A0_0 = 3338082229u;
			goto IL_9B;
		}

		public ByteString ReadBytes()
		{
			int num = this.ReadLength();
			while (true)
			{
				IL_82:
				uint arg_62_0 = 1567729408u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 1637773446u)) % 5u)
					{
					case 0u:
						goto IL_82;
					case 1u:
						arg_62_0 = (((num > 0) ? 1867247043u : 1970150730u) ^ num2 * 3990839928u);
						continue;
					case 2u:
						goto IL_89;
					case 3u:
						arg_62_0 = (((num > this.bufferSize - this.bufferPos) ? 1667764960u : 435160074u) ^ num2 * 3095056575u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			goto IL_AA;
			IL_89:
			ByteString arg_A9_0 = ByteString.CopyFrom(this.buffer, this.bufferPos, num);
			this.bufferPos += num;
			return arg_A9_0;
			IL_AA:
			return ByteString.AttachBytes(this.ReadRawBytes(num));
		}

		public uint ReadUInt32()
		{
			return this.ReadRawVarint32();
		}

		public int ReadEnum()
		{
			return (int)this.ReadRawVarint32();
		}

		public int ReadSFixed32()
		{
			return (int)this.ReadRawLittleEndian32();
		}

		public long ReadSFixed64()
		{
			return (long)this.ReadRawLittleEndian64();
		}

		public int ReadSInt32()
		{
			return CodedInputStream.DecodeZigZag32(this.ReadRawVarint32());
		}

		public long ReadSInt64()
		{
			return CodedInputStream.DecodeZigZag64(this.ReadRawVarint64());
		}

		public int ReadLength()
		{
			return (int)this.ReadRawVarint32();
		}

		public bool MaybeConsumeTag(uint tag)
		{
			if (this.PeekTag() == tag)
			{
				this.hasNextTag = false;
				return true;
			}
			return false;
		}

		private uint SlowReadRawVarint32()
		{
			int num = (int)this.ReadRawByte();
			int num3;
			while (true)
			{
				IL_288:
				uint arg_21F_0 = 2494979447u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_21F_0 ^ 3418350901u)) % 23u)
					{
					case 0u:
						return (uint)num3;
					case 1u:
						return (uint)num;
					case 3u:
					{
						int num4;
						num4++;
						arg_21F_0 = 2554834133u;
						continue;
					}
					case 4u:
						num3 |= (num = (int)this.ReadRawByte()) << 28;
						arg_21F_0 = (((num >= 128) ? 3681311557u : 2476857353u) ^ num2 * 1734438028u);
						continue;
					case 5u:
						goto IL_288;
					case 6u:
						num3 |= num << 14;
						arg_21F_0 = (num2 * 459560486u ^ 2682837157u);
						continue;
					case 7u:
					{
						int num4 = 0;
						arg_21F_0 = (num2 * 2618328153u ^ 1651887273u);
						continue;
					}
					case 8u:
						num3 |= (num & 127) << 21;
						arg_21F_0 = 2672725996u;
						continue;
					case 9u:
						arg_21F_0 = ((this.ReadRawByte() < 128) ? 4259782305u : 2517833240u);
						continue;
					case 10u:
						goto IL_293;
					case 11u:
						arg_21F_0 = (num2 * 1187933065u ^ 300630263u);
						continue;
					case 12u:
						num3 = (num & 127);
						arg_21F_0 = (((num = (int)this.ReadRawByte()) < 128) ? 4028052120u : 4031939389u);
						continue;
					case 13u:
						num3 |= num << 7;
						arg_21F_0 = (num2 * 3923040291u ^ 436777168u);
						continue;
					case 14u:
						arg_21F_0 = ((((num = (int)this.ReadRawByte()) >= 128) ? 3503358724u : 3786568342u) ^ num2 * 2057946794u);
						continue;
					case 15u:
						num3 |= (num & 127) << 7;
						arg_21F_0 = 3385038264u;
						continue;
					case 16u:
						arg_21F_0 = (num2 * 2239769208u ^ 1246018549u);
						continue;
					case 17u:
					{
						int num4;
						arg_21F_0 = ((num4 >= 5) ? 3691206458u : 2737399246u);
						continue;
					}
					case 18u:
						arg_21F_0 = ((((num = (int)this.ReadRawByte()) < 128) ? 2996681071u : 2391661239u) ^ num2 * 60861131u);
						continue;
					case 19u:
						arg_21F_0 = (num2 * 4080467692u ^ 2433901261u);
						continue;
					case 20u:
						num3 |= (num & 127) << 14;
						arg_21F_0 = 2221719431u;
						continue;
					case 21u:
						arg_21F_0 = (((num < 128) ? 2147615258u : 2480450257u) ^ num2 * 2779953663u);
						continue;
					case 22u:
						num3 |= num << 21;
						arg_21F_0 = (num2 * 736477684u ^ 1309517483u);
						continue;
					}
					goto Block_8;
				}
			}
			Block_8:
			return (uint)num3;
			IL_293:
			throw InvalidProtocolBufferException.MalformedVarint();
		}

		internal uint ReadRawVarint32()
		{
			if (this.bufferPos + 5 > this.bufferSize)
			{
				goto IL_241;
			}
			goto IL_2E0;
			uint arg_272_0;
			int num2;
			int num3;
			int num4;
			while (true)
			{
				IL_26D:
				uint num;
				switch ((num = (arg_272_0 ^ 3279982842u)) % 24u)
				{
				case 0u:
					num2 |= (num3 & 127) << 7;
					arg_272_0 = 4106779700u;
					continue;
				case 1u:
					num2 |= num3 << 14;
					arg_272_0 = (num * 2099631965u ^ 2426853294u);
					continue;
				case 2u:
					goto IL_241;
				case 3u:
					num2 |= (num3 & 127) << 14;
					arg_272_0 = 3762280186u;
					continue;
				case 4u:
					arg_272_0 = (((num3 >= 128) ? 3888434060u : 3230110178u) ^ num * 1744454279u);
					continue;
				case 5u:
					arg_272_0 = (num * 890748299u ^ 3649802996u);
					continue;
				case 6u:
					goto IL_303;
				case 7u:
					arg_272_0 = (num * 2669149444u ^ 4188353389u);
					continue;
				case 8u:
				{
					byte[] arg_1B7_0 = this.buffer;
					num4 = this.bufferPos;
					this.bufferPos = num4 + 1;
					arg_272_0 = ((((num3 = arg_1B7_0[num4]) >= 128) ? 64094121u : 33788384u) ^ num * 89356256u);
					continue;
				}
				case 9u:
				{
					int num5 = 0;
					arg_272_0 = (num * 4200415343u ^ 1980682066u);
					continue;
				}
				case 10u:
					num2 |= num3 << 21;
					arg_272_0 = (num * 4183951820u ^ 1722326823u);
					continue;
				case 11u:
				{
					int num5;
					arg_272_0 = ((num5 >= 5) ? 3527917750u : 3273196900u);
					continue;
				}
				case 12u:
					goto IL_30A;
				case 13u:
					return (uint)num2;
				case 14u:
				{
					byte[] arg_122_0 = this.buffer;
					num4 = this.bufferPos;
					this.bufferPos = num4 + 1;
					arg_272_0 = ((((num3 = arg_122_0[num4]) < 128) ? 3565351491u : 4152685305u) ^ num * 49595068u);
					continue;
				}
				case 15u:
					arg_272_0 = (((num3 < 128) ? 1999244824u : 398399328u) ^ num * 186532357u);
					continue;
				case 16u:
					num2 |= num3 << 7;
					arg_272_0 = (num * 780565301u ^ 1203515011u);
					continue;
				case 18u:
				{
					num2 = (num3 & 127);
					byte[] arg_9F_0 = this.buffer;
					num4 = this.bufferPos;
					this.bufferPos = num4 + 1;
					arg_272_0 = (((num3 = arg_9F_0[num4]) >= 128) ? 2173382714u : 3175365850u);
					continue;
				}
				case 19u:
				{
					num2 |= (num3 & 127) << 21;
					int arg_77_0 = num2;
					byte[] arg_71_0 = this.buffer;
					num4 = this.bufferPos;
					this.bufferPos = num4 + 1;
					num2 = (arg_77_0 | (num3 = arg_71_0[num4]) << 28);
					arg_272_0 = 2263177157u;
					continue;
				}
				case 20u:
					return (uint)num3;
				case 21u:
					goto IL_2E0;
				case 22u:
					arg_272_0 = ((this.ReadRawByte() < 128) ? 3539851855u : 2680636509u);
					continue;
				case 23u:
				{
					int num5;
					num5++;
					arg_272_0 = 2741648369u;
					continue;
				}
				}
				break;
			}
			return (uint)num2;
			IL_303:
			return this.SlowReadRawVarint32();
			IL_30A:
			throw InvalidProtocolBufferException.MalformedVarint();
			IL_241:
			arg_272_0 = 2274601772u;
			goto IL_26D;
			IL_2E0:
			byte[] arg_2F7_0 = this.buffer;
			num4 = this.bufferPos;
			this.bufferPos = num4 + 1;
			num3 = arg_2F7_0[num4];
			arg_272_0 = 2187291510u;
			goto IL_26D;
		}

		internal static uint ReadRawVarint32(Stream input)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				IL_170:
				uint arg_118_0 = (num2 < 32) ? 2765393581u : 2548159426u;
				while (true)
				{
					uint num3;
					switch ((num3 = (arg_118_0 ^ 3646265261u)) % 15u)
					{
					case 0u:
					{
						int expr_EB = CodedInputStream.smethod_6(input);
						if (expr_EB == -1)
						{
							goto Block_4;
						}
						arg_118_0 = (((expr_EB & 128) == 0) ? 2162612612u : 2608631623u);
						continue;
					}
					case 1u:
						arg_118_0 = ((num2 < 64) ? 2251615257u : 4175910191u);
						continue;
					case 2u:
						arg_118_0 = (num3 * 3834085602u ^ 1974180542u);
						continue;
					case 3u:
					{
						int num4;
						arg_118_0 = (((num4 != -1) ? 499273271u : 604089970u) ^ num3 * 1734040573u);
						continue;
					}
					case 4u:
						goto IL_180;
					case 5u:
						num2 += 7;
						arg_118_0 = 4199510848u;
						continue;
					case 6u:
						arg_118_0 = 2765393581u;
						continue;
					case 7u:
						num2 += 7;
						arg_118_0 = 2860650326u;
						continue;
					case 8u:
					{
						int num4;
						num |= (num4 & 127) << num2;
						arg_118_0 = 4179695946u;
						continue;
					}
					case 9u:
					{
						int num4 = CodedInputStream.smethod_6(input);
						arg_118_0 = 3235844255u;
						continue;
					}
					case 11u:
					{
						int num4;
						arg_118_0 = ((((num4 & 128) != 0) ? 702572663u : 1678848673u) ^ num3 * 1391402526u);
						continue;
					}
					case 12u:
						return (uint)num;
					case 13u:
						goto IL_170;
					case 14u:
						return (uint)num;
					}
					goto Block_6;
				}
			}
			Block_4:
			throw InvalidProtocolBufferException.TruncatedMessage();
			Block_6:
			goto IL_186;
			IL_180:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_186:
			throw InvalidProtocolBufferException.MalformedVarint();
		}

		internal ulong ReadRawVarint64()
		{
			int num = 0;
			while (true)
			{
				IL_AA:
				uint arg_82_0 = 3464255710u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_82_0 ^ 3687335287u)) % 7u)
					{
					case 0u:
						num += 7;
						arg_82_0 = 4289862063u;
						continue;
					case 1u:
					{
						ulong num3 = 0uL;
						arg_82_0 = (num2 * 9274271u ^ 59965272u);
						continue;
					}
					case 2u:
						goto IL_AA;
					case 3u:
						arg_82_0 = ((num >= 64) ? 3463336456u : 2532640387u);
						continue;
					case 4u:
					{
						byte b = this.ReadRawByte();
						ulong num3;
						num3 |= (ulong)((ulong)((long)(b & 127)) << num);
						arg_82_0 = (((b & 128) != 0) ? 2842789293u : 2754475659u);
						continue;
					}
					case 6u:
					{
						ulong num3;
						return num3;
					}
					}
					goto Block_3;
				}
			}
			Block_3:
			throw InvalidProtocolBufferException.MalformedVarint();
		}

		internal uint ReadRawLittleEndian32()
		{
			uint arg_1E_0 = (uint)this.ReadRawByte();
			uint num = (uint)this.ReadRawByte();
			uint num2 = (uint)this.ReadRawByte();
			uint num3 = (uint)this.ReadRawByte();
			return arg_1E_0 | num << 8 | num2 << 16 | num3 << 24;
		}

		internal ulong ReadRawLittleEndian64()
		{
			ulong arg_45_0 = (ulong)this.ReadRawByte();
			ulong num = (ulong)this.ReadRawByte();
			ulong num2 = (ulong)this.ReadRawByte();
			ulong num3 = (ulong)this.ReadRawByte();
			ulong num4 = (ulong)this.ReadRawByte();
			ulong num5 = (ulong)this.ReadRawByte();
			ulong num6 = (ulong)this.ReadRawByte();
			ulong num7 = (ulong)this.ReadRawByte();
			return arg_45_0 | num << 8 | num2 << 16 | num3 << 24 | num4 << 32 | num5 << 40 | num6 << 48 | num7 << 56;
		}

		internal static int DecodeZigZag32(uint n)
		{
			return (int)(n >> 1 ^ -(int)(n & 1u));
		}

		internal static long DecodeZigZag64(ulong n)
		{
			return (long)(n >> 1 ^ -(long)(n & 1uL));
		}

		internal int PushLimit(int byteLimit)
		{
			if (byteLimit < 0)
			{
				goto IL_46;
			}
			goto IL_78;
			uint arg_50_0;
			int num2;
			while (true)
			{
				IL_4B:
				uint num;
				switch ((num = (arg_50_0 ^ 2735523281u)) % 7u)
				{
				case 1u:
					goto IL_90;
				case 2u:
					goto IL_46;
				case 3u:
					goto IL_96;
				case 4u:
					num2 = this.currentLimit;
					arg_50_0 = (((byteLimit <= num2) ? 588888188u : 1005381115u) ^ num * 269960379u);
					continue;
				case 5u:
					goto IL_78;
				case 6u:
					this.currentLimit = byteLimit;
					this.RecomputeBufferSizeAfterLimit();
					arg_50_0 = 3547802966u;
					continue;
				}
				break;
			}
			return num2;
			IL_90:
			throw InvalidProtocolBufferException.NegativeSize();
			IL_96:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_46:
			arg_50_0 = 3055544971u;
			goto IL_4B;
			IL_78:
			byteLimit += this.totalBytesRetired + this.bufferPos;
			arg_50_0 = 3404370136u;
			goto IL_4B;
		}

		private void RecomputeBufferSizeAfterLimit()
		{
			this.bufferSize += this.bufferSizeAfterLimit;
			int num = this.totalBytesRetired + this.bufferSize;
			while (true)
			{
				IL_B5:
				uint arg_91_0 = 3290214909u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_91_0 ^ 3100274198u)) % 6u)
					{
					case 0u:
						this.bufferSizeAfterLimit = num - this.currentLimit;
						this.bufferSize -= this.bufferSizeAfterLimit;
						arg_91_0 = (num2 * 393322617u ^ 1672770352u);
						continue;
					case 1u:
						arg_91_0 = (((num <= this.currentLimit) ? 2753221319u : 3208512394u) ^ num2 * 1742307460u);
						continue;
					case 3u:
						this.bufferSizeAfterLimit = 0;
						arg_91_0 = 2418410008u;
						continue;
					case 4u:
						return;
					case 5u:
						goto IL_B5;
					}
					return;
				}
			}
		}

		internal void PopLimit(int oldLimit)
		{
			this.currentLimit = oldLimit;
			this.RecomputeBufferSizeAfterLimit();
		}

		private bool RefillBuffer(bool mustSucceed)
		{
			if (this.bufferPos < this.bufferSize)
			{
				goto IL_97;
			}
			goto IL_217;
			uint arg_1AB_0;
			while (true)
			{
				IL_1A6:
				uint num;
				switch ((num = (arg_1AB_0 ^ 2758101618u)) % 20u)
				{
				case 0u:
					return false;
				case 1u:
					arg_1AB_0 = ((this.bufferSize == 0) ? 4237450053u : 3753781680u);
					continue;
				case 2u:
					this.bufferPos = 0;
					this.bufferSize = ((this.input == null) ? 0 : CodedInputStream.smethod_7(this.input, this.buffer, 0, this.buffer.Length));
					arg_1AB_0 = 3014807158u;
					continue;
				case 3u:
					goto IL_233;
				case 5u:
					goto IL_23B;
				case 6u:
					arg_1AB_0 = (((!mustSucceed) ? 241612496u : 967117457u) ^ num * 3458513293u);
					continue;
				case 7u:
					arg_1AB_0 = ((mustSucceed ? 3018651586u : 2316642734u) ^ num * 3607192857u);
					continue;
				case 8u:
					goto IL_241;
				case 9u:
					goto IL_251;
				case 10u:
					this.RecomputeBufferSizeAfterLimit();
					arg_1AB_0 = 4081370257u;
					continue;
				case 11u:
					return false;
				case 12u:
					goto IL_261;
				case 13u:
				{
					int num2;
					arg_1AB_0 = (((num2 <= this.sizeLimit) ? 1299469164u : 1364638650u) ^ num * 3651766796u);
					continue;
				}
				case 14u:
				{
					int num2;
					arg_1AB_0 = (((num2 < 0) ? 806268128u : 1618192280u) ^ num * 303689379u);
					continue;
				}
				case 15u:
					goto IL_97;
				case 16u:
					arg_1AB_0 = (((this.bufferSize >= 0) ? 3915762819u : 3216895022u) ^ num * 3397340665u);
					continue;
				case 17u:
					goto IL_217;
				case 18u:
					this.totalBytesRetired += this.bufferSize;
					arg_1AB_0 = 4004614912u;
					continue;
				case 19u:
				{
					int num2 = this.totalBytesRetired + this.bufferSize + this.bufferSizeAfterLimit;
					arg_1AB_0 = (num * 1102194507u ^ 847959022u);
					continue;
				}
				}
				break;
			}
			return true;
			IL_233:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_23B:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_241:
			throw CodedInputStream.smethod_2(Module.smethod_34<string>(3441168009u));
			IL_251:
			throw CodedInputStream.smethod_2(Module.smethod_35<string>(2155492349u));
			IL_261:
			throw InvalidProtocolBufferException.SizeLimitExceeded();
			IL_97:
			arg_1AB_0 = 3424268023u;
			goto IL_1A6;
			IL_217:
			arg_1AB_0 = ((this.totalBytesRetired + this.bufferSize != this.currentLimit) ? 3852252224u : 3817785332u);
			goto IL_1A6;
		}

		internal byte ReadRawByte()
		{
			if (this.bufferPos == this.bufferSize)
			{
				while (true)
				{
					IL_42:
					uint arg_2A_0 = 4040314937u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2A_0 ^ 4163407359u)) % 3u)
						{
						case 0u:
							goto IL_42;
						case 2u:
							this.RefillBuffer(true);
							arg_2A_0 = (num * 883459474u ^ 3285745337u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			byte[] arg_60_0 = this.buffer;
			int num2 = this.bufferPos;
			this.bufferPos = num2 + 1;
			return arg_60_0[num2];
		}

		internal byte[] ReadRawBytes(int size)
		{
			if (size < 0)
			{
				goto IL_CB;
			}
			goto IL_43F;
			uint arg_396_0;
			List<byte[]> list;
			byte[] array2;
			int num3;
			byte[] array3;
			byte[] array4;
			int num7;
			while (true)
			{
				IL_391:
				uint num;
				int arg_EB_0;
				int num8;
				switch ((num = (arg_396_0 ^ 4198500303u)) % 35u)
				{
				case 0u:
					arg_396_0 = (num * 1583257911u ^ 2317854726u);
					continue;
				case 1u:
					goto IL_45B;
				case 2u:
				{
					byte[] array;
					list.Add(array);
					arg_396_0 = (num * 2669546329u ^ 1320475763u);
					continue;
				}
				case 3u:
				{
					byte[] array;
					int num2;
					num2 -= array.Length;
					arg_396_0 = (num * 4192541851u ^ 128370559u);
					continue;
				}
				case 4u:
					this.RefillBuffer(true);
					arg_396_0 = (num * 2838157372u ^ 2314411635u);
					continue;
				case 5u:
					arg_396_0 = ((size >= this.buffer.Length) ? 4054630116u : 3494658266u);
					continue;
				case 6u:
					goto IL_47F;
				case 7u:
					if (this.input != null)
					{
						arg_396_0 = 2186150901u;
						continue;
					}
					arg_EB_0 = -1;
					goto IL_EB;
				case 8u:
					CodedInputStream.smethod_8(this.buffer, 0, array2, num3, this.bufferSize);
					arg_396_0 = 3670660346u;
					continue;
				case 9u:
					arg_396_0 = ((size <= this.bufferSize - this.bufferPos) ? 4145414909u : 3180445376u);
					continue;
				case 10u:
					this.RefillBuffer(true);
					arg_396_0 = (num * 340903748u ^ 2855422178u);
					continue;
				case 11u:
				{
					int num2;
					arg_396_0 = ((num2 <= 0) ? 3397405552u : 2828618787u);
					continue;
				}
				case 12u:
					goto IL_49B;
				case 13u:
					num3 += this.bufferSize;
					arg_396_0 = (num * 1512197290u ^ 4214158784u);
					continue;
				case 14u:
				{
					byte[] array;
					int num4;
					arg_396_0 = ((num4 >= array.Length) ? 3816933501u : 3703400626u);
					continue;
				}
				case 15u:
				{
					int num5 = this.bufferSize;
					this.totalBytesRetired += this.bufferSize;
					this.bufferPos = 0;
					arg_396_0 = (num * 1391487145u ^ 3026251098u);
					continue;
				}
				case 16u:
					arg_396_0 = ((size - num3 > this.bufferSize) ? 3357071582u : 2262020265u);
					continue;
				case 17u:
					array3 = new byte[size];
					arg_396_0 = (num * 3404612690u ^ 1239836236u);
					continue;
				case 18u:
					this.bufferPos = this.bufferSize;
					arg_396_0 = (num * 1507912885u ^ 691528269u);
					continue;
				case 19u:
					arg_396_0 = (num * 2362500617u ^ 1123306658u);
					continue;
				case 20u:
				{
					int num6 = this.bufferPos;
					arg_396_0 = 2716249524u;
					continue;
				}
				case 21u:
					array2 = new byte[size];
					num3 = this.bufferSize - this.bufferPos;
					ByteArray.Copy(this.buffer, this.bufferPos, array2, 0, num3);
					this.bufferPos = this.bufferSize;
					arg_396_0 = (num * 3945553975u ^ 4215046507u);
					continue;
				case 23u:
					goto IL_548;
				case 24u:
					array4 = new byte[size];
					arg_396_0 = (num * 1938307283u ^ 3597995925u);
					continue;
				case 25u:
				{
					int num6;
					ByteArray.Copy(this.buffer, num6, array3, 0, num7);
					arg_396_0 = (num * 647542001u ^ 2646979897u);
					continue;
				}
				case 26u:
				{
					byte[] array;
					int num4;
					arg_EB_0 = CodedInputStream.smethod_7(this.input, array, num4, array.Length - num4);
					goto IL_EB;
				}
				case 27u:
					goto IL_CB;
				case 28u:
				{
					this.bufferSize = 0;
					int num5;
					int num6;
					int num2 = size - (num5 - num6);
					list = new List<byte[]>();
					arg_396_0 = (num * 2931708483u ^ 2690219271u);
					continue;
				}
				case 29u:
					goto IL_54E;
				case 30u:
				{
					int num2;
					byte[] array = new byte[CodedInputStream.smethod_9(num2, this.buffer.Length)];
					int num4 = 0;
					arg_396_0 = 4262424359u;
					continue;
				}
				case 31u:
					goto IL_43F;
				case 32u:
					arg_396_0 = (((num8 > 0) ? 99622287u : 1347347889u) ^ num * 472951448u);
					continue;
				case 33u:
				{
					int num5;
					int num6;
					num7 = num5 - num6;
					arg_396_0 = (num * 1808256215u ^ 2179633551u);
					continue;
				}
				case 34u:
				{
					this.totalBytesRetired += num8;
					int num4;
					num4 += num8;
					arg_396_0 = 3649006730u;
					continue;
				}
				}
				break;
				IL_EB:
				num8 = arg_EB_0;
				arg_396_0 = 4062446728u;
			}
			goto IL_4A1;
			IL_45B:
			ByteArray.Copy(this.buffer, this.bufferPos, array4, 0, size);
			this.bufferPos += size;
			return array4;
			IL_47F:
			ByteArray.Copy(this.buffer, 0, array2, num3, size - num3);
			this.bufferPos = size - num3;
			return array2;
			IL_49B:
			throw InvalidProtocolBufferException.NegativeSize();
			IL_4A1:
			using (List<byte[]>.Enumerator enumerator = list.GetEnumerator())
			{
				while (true)
				{
					IL_52A:
					uint arg_4FD_0 = enumerator.MoveNext() ? 3095270417u : 2442424314u;
					while (true)
					{
						uint num;
						switch ((num = (arg_4FD_0 ^ 4198500303u)) % 5u)
						{
						case 0u:
						{
							byte[] current;
							num7 += current.Length;
							arg_4FD_0 = (num * 3371994623u ^ 404198586u);
							continue;
						}
						case 2u:
							arg_4FD_0 = 3095270417u;
							continue;
						case 3u:
							goto IL_52A;
						case 4u:
						{
							byte[] current = enumerator.Current;
							CodedInputStream.smethod_8(current, 0, array3, num7, current.Length);
							arg_4FD_0 = 2354534497u;
							continue;
						}
						}
						goto Block_13;
					}
				}
				Block_13:
				return array3;
			}
			IL_548:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_54E:
			this.SkipRawBytes(this.currentLimit - this.totalBytesRetired - this.bufferPos);
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_CB:
			arg_396_0 = 3787950150u;
			goto IL_391;
			IL_43F:
			arg_396_0 = ((this.totalBytesRetired + this.bufferPos + size > this.currentLimit) ? 2838122396u : 2529660600u);
			goto IL_391;
		}

		private void SkipRawBytes(int size)
		{
			if (size < 0)
			{
				goto IL_FB;
			}
			goto IL_1AF;
			uint arg_157_0;
			while (true)
			{
				IL_152:
				uint num;
				switch ((num = (arg_157_0 ^ 675223999u)) % 15u)
				{
				case 0u:
					this.totalBytesRetired += this.bufferSize;
					this.bufferPos = 0;
					arg_157_0 = (num * 2042037585u ^ 3275181463u);
					continue;
				case 1u:
					arg_157_0 = (((this.input != null) ? 1111826091u : 689824421u) ^ num * 3861121661u);
					continue;
				case 2u:
					return;
				case 3u:
					goto IL_FB;
				case 4u:
					goto IL_1AF;
				case 5u:
				{
					this.bufferSize = 0;
					int num2;
					arg_157_0 = (((num2 >= size) ? 578666474u : 394180680u) ^ num * 3300267338u);
					continue;
				}
				case 7u:
					arg_157_0 = ((size > this.bufferSize - this.bufferPos) ? 2062244670u : 1844427517u);
					continue;
				case 8u:
					this.SkipRawBytes(this.currentLimit - this.totalBytesRetired - this.bufferPos);
					arg_157_0 = (num * 3432233981u ^ 4173888967u);
					continue;
				case 9u:
				{
					int num2 = this.bufferSize - this.bufferPos;
					arg_157_0 = 248771127u;
					continue;
				}
				case 10u:
					goto IL_1CC;
				case 11u:
					this.bufferPos += size;
					arg_157_0 = (num * 512570349u ^ 2989942840u);
					continue;
				case 12u:
				{
					int num2;
					this.SkipImpl(size - num2);
					this.totalBytesRetired += size - num2;
					arg_157_0 = 236606122u;
					continue;
				}
				case 13u:
					goto IL_1D2;
				case 14u:
					goto IL_1D8;
				}
				break;
			}
			return;
			IL_1CC:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_1D2:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_1D8:
			throw InvalidProtocolBufferException.NegativeSize();
			IL_FB:
			arg_157_0 = 1190105578u;
			goto IL_152;
			IL_1AF:
			arg_157_0 = ((this.totalBytesRetired + this.bufferPos + size > this.currentLimit) ? 1175312733u : 777567675u);
			goto IL_152;
		}

		private void SkipImpl(int amountToSkip)
		{
			if (CodedInputStream.smethod_10(this.input))
			{
				goto IL_C8;
			}
			goto IL_141;
			uint arg_104_0;
			byte[] array;
			while (true)
			{
				IL_FF:
				uint num;
				switch ((num = (arg_104_0 ^ 3026985626u)) % 12u)
				{
				case 0u:
				{
					long num2;
					arg_104_0 = (((CodedInputStream.smethod_1(this.input) == num2 + (long)amountToSkip) ? 512983504u : 1388170089u) ^ num * 1523900090u);
					continue;
				}
				case 1u:
					goto IL_159;
				case 3u:
					goto IL_C8;
				case 4u:
				{
					long num2 = CodedInputStream.smethod_1(this.input);
					arg_104_0 = (num * 4274641188u ^ 1918555231u);
					continue;
				}
				case 5u:
				{
					int num3 = CodedInputStream.smethod_7(this.input, array, 0, CodedInputStream.smethod_9(array.Length, amountToSkip));
					arg_104_0 = 3097663354u;
					continue;
				}
				case 6u:
					goto IL_141;
				case 7u:
					goto IL_15F;
				case 8u:
				{
					int num3;
					arg_104_0 = (((num3 > 0) ? 1079543017u : 1976489343u) ^ num * 538338490u);
					continue;
				}
				case 9u:
				{
					Stream expr_4A = this.input;
					CodedInputStream.smethod_11(expr_4A, CodedInputStream.smethod_1(expr_4A) + (long)amountToSkip);
					arg_104_0 = (num * 3918813266u ^ 2965109464u);
					continue;
				}
				case 10u:
					arg_104_0 = ((amountToSkip <= 0) ? 3550478304u : 3594009823u);
					continue;
				case 11u:
				{
					int num3;
					amountToSkip -= num3;
					arg_104_0 = 2956050980u;
					continue;
				}
				}
				break;
			}
			return;
			IL_159:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_15F:
			throw InvalidProtocolBufferException.TruncatedMessage();
			IL_C8:
			arg_104_0 = 2542451118u;
			goto IL_FF;
			IL_141:
			array = new byte[CodedInputStream.smethod_9(1024, amountToSkip)];
			arg_104_0 = 2956050980u;
			goto IL_FF;
		}

		static ArgumentOutOfRangeException smethod_0(string string_0, string string_1)
		{
			return new ArgumentOutOfRangeException(string_0, string_1);
		}

		static long smethod_1(Stream stream_0)
		{
			return stream_0.Position;
		}

		static InvalidOperationException smethod_2(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static double smethod_3(long long_0)
		{
			return BitConverter.Int64BitsToDouble(long_0);
		}

		static float smethod_4(byte[] byte_0, int int_0)
		{
			return BitConverter.ToSingle(byte_0, int_0);
		}

		static string smethod_5(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
		{
			return encoding_0.GetString(byte_0, int_0, int_1);
		}

		static int smethod_6(Stream stream_0)
		{
			return stream_0.ReadByte();
		}

		static int smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			return stream_0.Read(byte_0, int_0, int_1);
		}

		static void smethod_8(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static int smethod_9(int int_0, int int_1)
		{
			return Math.Min(int_0, int_1);
		}

		static bool smethod_10(Stream stream_0)
		{
			return stream_0.CanSeek;
		}

		static void smethod_11(Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}
	}
}
