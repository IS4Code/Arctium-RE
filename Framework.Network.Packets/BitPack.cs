using System;
using System.Globalization;
using System.Text;

namespace Framework.Network.Packets
{
	public class BitPack
	{
		private PacketWriter writer;

		private byte[] GuidBytes;

		private byte[] GuildGuidBytes;

		private byte[] TransportGuidBytes;

		private byte[] TargetGuidBytes;

		private byte BitPosition
		{
			get;
			set;
		}

		private byte BitValue
		{
			get;
			set;
		}

		public ulong Guid
		{
			set
			{
				this.GuidBytes = BitPack.smethod_0(value);
			}
		}

		public ulong GuildGuid
		{
			set
			{
				this.GuildGuidBytes = BitPack.smethod_0(value);
			}
		}

		public ulong TargetGuid
		{
			set
			{
				this.TargetGuidBytes = BitPack.smethod_0(value);
			}
		}

		public ulong TransportGuid
		{
			set
			{
				this.TransportGuidBytes = BitPack.smethod_0(value);
			}
		}

		public BitPack(PacketWriter writer, ulong guid = 0uL, ulong guildGuid = 0uL, ulong targetGuid = 0uL, ulong transportGuid = 0uL)
		{
			this.Guid = guid;
			this.GuildGuid = guildGuid;
			this.TargetGuid = targetGuid;
			this.TransportGuid = transportGuid;
			this.writer = writer;
			this.BitPosition = 8;
		}

		public void Write<T>(T bit)
		{
			byte bitPosition = this.BitPosition - 1;
			while (true)
			{
				IL_114:
				uint arg_E8_0 = 1652849313u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E8_0 ^ 140211783u)) % 8u)
					{
					case 0u:
						goto IL_114;
					case 1u:
						this.BitValue |= (byte)(1 << (int)this.BitPosition);
						arg_E8_0 = (num * 1776002121u ^ 345365165u);
						continue;
					case 2u:
						this.writer.WriteUInt8(this.BitValue);
						this.BitValue = 0;
						arg_E8_0 = (num * 1665770702u ^ 1806027702u);
						continue;
					case 3u:
						arg_E8_0 = ((this.BitPosition != 0) ? 318830762u : 1370622304u);
						continue;
					case 4u:
						arg_E8_0 = (((!BitPack.smethod_2(bit, BitPack.smethod_1())) ? 183628340u : 963482438u) ^ num * 100361154u);
						continue;
					case 6u:
						this.BitPosition = bitPosition;
						arg_E8_0 = (num * 2241878331u ^ 3402166817u);
						continue;
					case 7u:
						this.BitPosition = 8;
						arg_E8_0 = (num * 4265802296u ^ 648773005u);
						continue;
					}
					return;
				}
			}
		}

		public void Write<T>(T bit, int count)
		{
			checked
			{
				int num = count - 1;
				while (true)
				{
					IL_7F:
					int arg_59_0 = (num >= 0) ? 429789314 : 61619512;
					while (true)
					{
						switch ((arg_59_0 ^ 250283959) % 4)
						{
						case 0:
							arg_59_0 = 429789314;
							continue;
						case 1:
							this.Write<T>((T)((object)BitPack.smethod_5(BitPack.smethod_3(bit) >> num & 1, BitPack.smethod_4(typeof(T).TypeHandle))));
							num--;
							arg_59_0 = 1923155801;
							continue;
						case 2:
							goto IL_7F;
						}
						return;
					}
				}
			}
		}

		public void WriteStringLength(string data, int count)
		{
			int bit = BitPack.smethod_7(BitPack.smethod_6(), data).Length;
			this.Write<int>(bit, count);
		}

		public void WriteGuidMask(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_72:
				uint arg_46_0 = ((int)b >= order.Length) ? 742699901u : 1831024341u;
				while (true)
				{
					uint num;
					switch ((num = (arg_46_0 ^ 13696436u)) % 5u)
					{
					case 0u:
						arg_46_0 = 1831024341u;
						continue;
					case 2u:
						this.Write<byte>(this.GuidBytes[(int)order[(int)b]]);
						arg_46_0 = 229046717u;
						continue;
					case 3u:
						goto IL_72;
					case 4u:
						b += 1;
						arg_46_0 = (num * 4239758255u ^ 2295222825u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteGuildGuidMask(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_5D:
				int arg_37_0 = ((int)b >= order.Length) ? -1778762875 : -1883923476;
				while (true)
				{
					switch ((arg_37_0 ^ -1645389830) % 4)
					{
					case 0:
						arg_37_0 = -1883923476;
						continue;
					case 1:
						goto IL_5D;
					case 2:
						this.Write<byte>(this.GuildGuidBytes[(int)order[(int)b]]);
						b += 1;
						arg_37_0 = -1446034705;
						continue;
					}
					return;
				}
			}
		}

		public void WriteTargetGuidMask(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_87:
				uint arg_63_0 = 2618047285u;
				while (true)
				{
					uint num;
					switch ((num = (arg_63_0 ^ 3831443114u)) % 6u)
					{
					case 0u:
						b += 1;
						arg_63_0 = (num * 355054239u ^ 1756138953u);
						continue;
					case 1u:
						this.Write<byte>(this.TargetGuidBytes[(int)order[(int)b]]);
						arg_63_0 = 2753277804u;
						continue;
					case 3u:
						arg_63_0 = (((int)b >= order.Length) ? 2790138570u : 3544108679u);
						continue;
					case 4u:
						goto IL_87;
					case 5u:
						arg_63_0 = (num * 232588484u ^ 3538207119u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteTransportGuidMask(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_71:
				uint arg_51_0 = 3651688635u;
				while (true)
				{
					uint num;
					switch ((num = (arg_51_0 ^ 2962787270u)) % 5u)
					{
					case 0u:
						goto IL_71;
					case 2u:
						this.Write<byte>(this.TransportGuidBytes[(int)order[(int)b]]);
						b += 1;
						arg_51_0 = 2933615343u;
						continue;
					case 3u:
						arg_51_0 = (((int)b < order.Length) ? 3875957300u : 3070195006u);
						continue;
					case 4u:
						arg_51_0 = (num * 2812235026u ^ 1416961317u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteGuidBytes(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_A9:
				uint arg_76_0 = ((int)b < order.Length) ? 3203827650u : 3066299643u;
				while (true)
				{
					uint num;
					switch ((num = (arg_76_0 ^ 3612932043u)) % 6u)
					{
					case 0u:
						goto IL_A9;
					case 1u:
						arg_76_0 = ((this.GuidBytes[(int)order[(int)b]] == 0) ? 2220640897u : 3843280124u);
						continue;
					case 2u:
						b += 1;
						arg_76_0 = 3638058699u;
						continue;
					case 3u:
						arg_76_0 = 3203827650u;
						continue;
					case 5u:
						this.writer.WriteUInt8(this.GuidBytes[(int)order[(int)b]] ^ 1);
						arg_76_0 = (num * 3407355055u ^ 1112749080u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteGuildGuidBytes(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_B8:
				uint arg_90_0 = 2294763294u;
				while (true)
				{
					uint num;
					switch ((num = (arg_90_0 ^ 2510344227u)) % 7u)
					{
					case 0u:
						goto IL_B8;
					case 1u:
						arg_90_0 = (num * 1299295679u ^ 1938888267u);
						continue;
					case 2u:
						arg_90_0 = (((int)b >= order.Length) ? 3912687287u : 2895310131u);
						continue;
					case 3u:
						this.writer.WriteUInt8(this.GuildGuidBytes[(int)order[(int)b]] ^ 1);
						arg_90_0 = (num * 414783976u ^ 1115128758u);
						continue;
					case 4u:
						arg_90_0 = ((this.GuildGuidBytes[(int)order[(int)b]] != 0) ? 3419106966u : 2724594366u);
						continue;
					case 6u:
						b += 1;
						arg_90_0 = 3930591688u;
						continue;
					}
					return;
				}
			}
		}

		public void WriteTargetGuidBytes(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_B8:
				uint arg_90_0 = 44758558u;
				while (true)
				{
					uint num;
					switch ((num = (arg_90_0 ^ 182393944u)) % 7u)
					{
					case 0u:
						this.writer.WriteUInt8(this.TargetGuidBytes[(int)order[(int)b]] ^ 1);
						arg_90_0 = (num * 2324142117u ^ 3197070114u);
						continue;
					case 2u:
						arg_90_0 = (num * 3083810847u ^ 1890738461u);
						continue;
					case 3u:
						arg_90_0 = (((int)b >= order.Length) ? 1389107581u : 97734117u);
						continue;
					case 4u:
						b += 1;
						arg_90_0 = 982699879u;
						continue;
					case 5u:
						goto IL_B8;
					case 6u:
						arg_90_0 = ((this.TargetGuidBytes[(int)order[(int)b]] != 0) ? 561474180u : 627091182u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteTransportGuidBytes(params byte[] order)
		{
			byte b = 0;
			while (true)
			{
				IL_B8:
				uint arg_90_0 = 4089021566u;
				while (true)
				{
					uint num;
					switch ((num = (arg_90_0 ^ 4098104018u)) % 7u)
					{
					case 0u:
						arg_90_0 = (((int)b < order.Length) ? 3191731948u : 2330085967u);
						continue;
					case 1u:
						arg_90_0 = (num * 527965989u ^ 2994918719u);
						continue;
					case 2u:
						b += 1;
						arg_90_0 = 2700875747u;
						continue;
					case 3u:
						this.writer.WriteUInt8(this.TransportGuidBytes[(int)order[(int)b]] ^ 1);
						arg_90_0 = (num * 388758195u ^ 2771035326u);
						continue;
					case 5u:
						goto IL_B8;
					case 6u:
						arg_90_0 = ((this.TransportGuidBytes[(int)order[(int)b]] != 0) ? 2424527978u : 3731129878u);
						continue;
					}
					return;
				}
			}
		}

		public void Flush()
		{
			this.writer.WriteUInt8(this.BitValue);
			this.BitValue = 0;
			this.BitPosition = 8;
		}

		static byte[] smethod_0(ulong ulong_0)
		{
			return BitConverter.GetBytes(ulong_0);
		}

		static CultureInfo smethod_1()
		{
			return CultureInfo.InvariantCulture;
		}

		static bool smethod_2(object object_0, IFormatProvider iformatProvider_0)
		{
			return Convert.ToBoolean(object_0, iformatProvider_0);
		}

		static int smethod_3(object object_0)
		{
			return Convert.ToInt32(object_0);
		}

		static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static object smethod_5(object object_0, Type type_0)
		{
			return Convert.ChangeType(object_0, type_0);
		}

		static Encoding smethod_6()
		{
			return Encoding.UTF8;
		}

		static byte[] smethod_7(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}
	}
}
