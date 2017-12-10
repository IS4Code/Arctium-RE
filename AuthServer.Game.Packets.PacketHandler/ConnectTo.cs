using Framework.Cryptography.WoW;
using Framework.Misc;
using Framework.Network.Packets;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace AuthServer.Game.Packets.PacketHandler
{
	internal class ConnectTo
	{
		public class ConnectPayload
		{
			public IPEndPoint Where;

			public uint Adler32;

			public byte XorMagic = 42;

			public byte[] PanamaKey = new byte[32];
		}

		public ulong Key;

		public ConnectTo.ConnectPayload Payload;

		public byte Con;

		public string Haiku = Module.smethod_35<string>(848950031u);

		public byte[] PiDigits;

		private RsaCrypt Crypt;

		public ConnectTo()
		{
			byte[] expr_1B = new byte[130];
			ConnectTo.smethod_0(expr_1B, fieldof(<PrivateImplementationDetails>.struct10_0).FieldHandle);
			this.PiDigits = expr_1B;
			base..ctor();
			while (true)
			{
				IL_11C:
				uint arg_F8_0 = 3993814791u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F8_0 ^ 2867687330u)) % 6u)
					{
					case 0u:
						goto IL_11C;
					case 2u:
						this.Crypt = new RsaCrypt();
						arg_F8_0 = (num * 2459550961u ^ 137469758u);
						continue;
					case 3u:
						this.Payload.PanamaKey = Module.smethod_33<string>(3050187087u).ToByteArray();
						this.Payload.Adler32 = 2695261200u;
						arg_F8_0 = (num * 3197803142u ^ 1130187682u);
						continue;
					case 4u:
						this.Crypt.InitializeEncryption<byte[]>(RsaStore.D, RsaStore.P, RsaStore.Q, RsaStore.DP, RsaStore.DQ, RsaStore.InverseQ, false);
						this.Crypt.InitializeDecryption<byte[]>(RsaStore.Exponent, RsaStore.Modulus, false);
						arg_F8_0 = (num * 2948528008u ^ 2475682229u);
						continue;
					case 5u:
						this.Payload = new ConnectTo.ConnectPayload();
						arg_F8_0 = (num * 4055527431u ^ 2615824410u);
						continue;
					}
					return;
				}
			}
		}

		public void Write(PacketWriter pw)
		{
			byte[] data = ConnectTo.smethod_2((ushort)ConnectTo.smethod_1(this.Payload.Where));
			while (true)
			{
				IL_378:
				uint arg_316_0 = 2359871361u;
				while (true)
				{
					uint num;
					switch ((num = (arg_316_0 ^ 3640945304u)) % 21u)
					{
					case 0u:
					{
						byte[] array;
						ConnectTo.smethod_6(ConnectTo.smethod_5(ConnectTo.smethod_4(this.Payload.Where)), 0, array, 0, 4);
						arg_316_0 = (num * 1857866438u ^ 170169674u);
						continue;
					}
					case 1u:
					{
						HmacHash hmacHash;
						hmacHash.Process(this.Payload.PanamaKey, 32);
						hmacHash.Process(this.PiDigits, 108);
						arg_316_0 = (num * 2969400312u ^ 2067020106u);
						continue;
					}
					case 2u:
					{
						byte b = 3;
						arg_316_0 = (num * 3485038105u ^ 1438866377u);
						continue;
					}
					case 3u:
						pw.WriteUInt32(14u);
						arg_316_0 = (num * 3418873817u ^ 174626620u);
						continue;
					case 4u:
						goto IL_378;
					case 5u:
					{
						byte[] array = new byte[16];
						arg_316_0 = (num * 2999318491u ^ 2160708345u);
						continue;
					}
					case 6u:
						pw.WriteUInt8(this.Con);
						arg_316_0 = (num * 1188346892u ^ 2799591750u);
						continue;
					case 7u:
					{
						ByteBuffer byteBuffer;
						byteBuffer.WriteBytes(this.Payload.PanamaKey, 32u);
						byteBuffer.WriteBytes(this.PiDigits, 108u);
						arg_316_0 = (num * 1445783088u ^ 3500704478u);
						continue;
					}
					case 8u:
					{
						byte[] array;
						ByteBuffer byteBuffer;
						byteBuffer.WriteBytes(array, 16u);
						byteBuffer.WriteUInt16<int>(ConnectTo.smethod_1(this.Payload.Where));
						byteBuffer.WriteString(this.Haiku);
						arg_316_0 = (num * 4257467946u ^ 1043571886u);
						continue;
					}
					case 9u:
					{
						ByteBuffer byteBuffer = new ByteBuffer();
						byteBuffer.WriteUInt32<uint>(this.Payload.Adler32);
						byte b;
						byteBuffer.WriteUInt8<byte>(b);
						arg_316_0 = (num * 288980273u ^ 1507575052u);
						continue;
					}
					case 10u:
					{
						ByteBuffer byteBuffer;
						pw.WriteBytes(this.Crypt.Encrypt<byte[]>(byteBuffer.GetData(), false), 256);
						arg_316_0 = (num * 627861161u ^ 4032287512u);
						continue;
					}
					case 11u:
					{
						HmacHash hmacHash;
						hmacHash.Finish(ConnectTo.smethod_7((short)this.Payload.XorMagic), 1);
						arg_316_0 = (num * 2043331364u ^ 2720859288u);
						continue;
					}
					case 12u:
					{
						HmacHash hmacHash = new HmacHash(RsaStore.WherePacketHmac);
						byte[] array;
						hmacHash.Process(array, 16);
						byte b;
						hmacHash.Process(ConnectTo.smethod_7((short)b), 1);
						hmacHash.Process(data, 2);
						arg_316_0 = 3742919601u;
						continue;
					}
					case 13u:
					{
						ByteBuffer byteBuffer;
						byteBuffer.WriteUInt8<byte>(this.Payload.XorMagic);
						HmacHash hmacHash;
						byteBuffer.WriteBytes(hmacHash.Digest);
						arg_316_0 = (num * 1057531190u ^ 2240896363u);
						continue;
					}
					case 14u:
					{
						byte[] array;
						ConnectTo.smethod_6(ConnectTo.smethod_5(ConnectTo.smethod_4(this.Payload.Where)), 0, array, 0, 16);
						arg_316_0 = 3211391060u;
						continue;
					}
					case 15u:
					{
						byte b = 1;
						arg_316_0 = (num * 3213198913u ^ 1313716735u);
						continue;
					}
					case 16u:
					{
						HmacHash hmacHash;
						hmacHash.Process(this.Haiku);
						arg_316_0 = (num * 3305604985u ^ 3353461720u);
						continue;
					}
					case 18u:
						pw.WriteUInt64(this.Key);
						arg_316_0 = (num * 1780680709u ^ 1529831126u);
						continue;
					case 19u:
						arg_316_0 = (((ConnectTo.smethod_3(this.Payload.Where) != AddressFamily.InterNetwork) ? 2333103828u : 3804062715u) ^ num * 2627924325u);
						continue;
					case 20u:
					{
						byte b = 2;
						arg_316_0 = (num * 326661819u ^ 2495054369u);
						continue;
					}
					}
					return;
				}
			}
		}

		static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		static int smethod_1(IPEndPoint ipendPoint_0)
		{
			return ipendPoint_0.Port;
		}

		static byte[] smethod_2(ushort ushort_0)
		{
			return BitConverter.GetBytes(ushort_0);
		}

		static AddressFamily smethod_3(EndPoint endPoint_0)
		{
			return endPoint_0.AddressFamily;
		}

		static IPAddress smethod_4(IPEndPoint ipendPoint_0)
		{
			return ipendPoint_0.Address;
		}

		static byte[] smethod_5(IPAddress ipaddress_0)
		{
			return ipaddress_0.GetAddressBytes();
		}

		static void smethod_6(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static byte[] smethod_7(short short_0)
		{
			return BitConverter.GetBytes(short_0);
		}
	}
}
