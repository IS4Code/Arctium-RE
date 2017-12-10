using AuthServer.Game.Entities;
using AuthServer.Game.PacketHandler;
using AuthServer.Game.Packets.PacketHandler;
using AuthServer.WorldServer.Game.Packets;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Cryptography.WoW;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Framework.Misc;
using Framework.Network.Packets;
using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AuthServer.Network
{
	public sealed class WorldClass : IDisposable
	{
		public static WorldNetwork world;

		public Socket clientSocket;

		public Queue PacketQueue;

		public WoWCrypt Crypt;

		private byte[] DataBuffer;

		public bool initiated;

		public Account Account
		{
			get;
			set;
		}

		public Character Character
		{
			get;
			set;
		}

		public WorldClass()
		{
			while (true)
			{
				IL_42:
				uint arg_2A_0 = 182109382u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2A_0 ^ 516975182u)) % 3u)
					{
					case 0u:
						goto IL_42;
					case 1u:
						this.DataBuffer = new byte[8192];
						arg_2A_0 = (num * 3173822914u ^ 4165667664u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.PacketQueue = WorldClass.smethod_0();
			this.Crypt = new WoWCrypt();
		}

		public void OnData()
		{
			PacketReader packetReader = null;
			while (true)
			{
				IL_FB:
				uint arg_D3_0 = 1616354313u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D3_0 ^ 2111674241u)) % 7u)
					{
					case 0u:
						arg_D3_0 = (num * 2069654396u ^ 1403410597u);
						continue;
					case 2u:
						arg_D3_0 = (((WorldClass.smethod_1(this.PacketQueue) > 0) ? 3604674588u : 3317756979u) ^ num * 4268029870u);
						continue;
					case 3u:
						goto IL_FB;
					case 4u:
						packetReader = new PacketReader(this.DataBuffer, false, this.initiated);
						arg_D3_0 = 2040588781u;
						continue;
					case 5u:
						WorldClass.smethod_6(WorldClass.smethod_4((IPEndPoint)WorldClass.smethod_3(this.clientSocket)), Module.smethod_35<string>(2164558557u), WorldClass.smethod_5((IPEndPoint)WorldClass.smethod_3(this.clientSocket)));
						PacketManager.InvokeHandler(ref packetReader, this);
						arg_D3_0 = 897637803u;
						continue;
					case 6u:
						packetReader = (PacketReader)WorldClass.smethod_2(this.PacketQueue);
						arg_D3_0 = (num * 1511168572u ^ 2447408611u);
						continue;
					}
					return;
				}
			}
		}

		public void OnConnect()
		{
			PacketWriter arg_2E_0 = new PacketWriter();
			WorldClass.smethod_7(this.clientSocket, this.DataBuffer, 0, this.DataBuffer.Length, SocketFlags.None, new AsyncCallback(this.Receive), null);
			arg_2E_0.WriteString(Module.smethod_37<string>(1753682996u), true);
			byte[] array = arg_2E_0.ReadDataToSend(true).Concat(new byte[]
			{
				10
			}).ToArray<byte>();
			while (true)
			{
				IL_99:
				uint arg_81_0 = 2467266083u;
				while (true)
				{
					uint num;
					switch ((num = (arg_81_0 ^ 3013151267u)) % 3u)
					{
					case 0u:
						goto IL_99;
					case 1u:
						WorldClass.smethod_8(this.clientSocket, array, 0, array.Length, SocketFlags.None);
						arg_81_0 = (num * 4049714595u ^ 726147954u);
						continue;
					}
					return;
				}
			}
		}

		public void Receive(IAsyncResult result)
		{
			try
			{
				int num = WorldClass.smethod_9(this.clientSocket, result);
				while (true)
				{
					IL_303:
					uint arg_2A1_0 = 2144244013u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2A1_0 ^ 2097752605u)) % 21u)
						{
						case 0u:
							arg_2A1_0 = (((this.DataBuffer[0] == 10) ? 3516801827u : 2700854910u) ^ num2 * 2847739512u);
							continue;
						case 1u:
							this.OnData();
							arg_2A1_0 = 1349214829u;
							continue;
						case 2u:
						{
							PacketReader packetReader = new PacketReader(WorldClass.smethod_11(WorldClass.smethod_10(), Module.smethod_36<string>(3253257661u)), false, false);
							arg_2A1_0 = 1263277281u;
							continue;
						}
						case 3u:
							this.Decode(ref this.DataBuffer);
							arg_2A1_0 = 337671581u;
							continue;
						case 4u:
							goto IL_303;
						case 5u:
						{
							byte[] array;
							int num3;
							WorldClass.smethod_13(this.DataBuffer, 0, array, 0, num3);
							arg_2A1_0 = (num2 * 916870607u ^ 1297900287u);
							continue;
						}
						case 6u:
							arg_2A1_0 = ((num <= 0) ? 194039135u : 1722859564u);
							continue;
						case 7u:
							arg_2A1_0 = (num2 * 2848342300u ^ 737308501u);
							continue;
						case 8u:
							arg_2A1_0 = (num2 * 1649544107u ^ 2180403397u);
							continue;
						case 9u:
						{
							int num3 = (int)(WorldClass.smethod_12(this.DataBuffer, 0) + 4);
							arg_2A1_0 = (num2 * 766592189u ^ 1651164332u);
							continue;
						}
						case 10u:
							arg_2A1_0 = ((!this.Crypt.IsInitialized) ? 1207177178u : 1132968486u);
							continue;
						case 11u:
							arg_2A1_0 = (((num == 1) ? 1586097055u : 2122513536u) ^ num2 * 3467687789u);
							continue;
						case 12u:
							arg_2A1_0 = ((this.DataBuffer[num - 1] != 10) ? 1349214829u : 656592899u);
							continue;
						case 13u:
							arg_2A1_0 = (((num == 0) ? 687461565u : 434568810u) ^ num2 * 663281082u);
							continue;
						case 14u:
						{
							byte[] array;
							PacketReader object_ = new PacketReader(array, true, true);
							WorldClass.smethod_14(this.PacketQueue, object_);
							int num3;
							num -= num3;
							WorldClass.smethod_13(this.DataBuffer, num3, this.DataBuffer, 0, num);
							this.OnData();
							arg_2A1_0 = (num2 * 789004399u ^ 1857816743u);
							continue;
						}
						case 15u:
						{
							int num3;
							byte[] array = new byte[num3];
							arg_2A1_0 = (num2 * 152044841u ^ 3418251853u);
							continue;
						}
						case 16u:
							arg_2A1_0 = (num2 * 354584314u ^ 3821096739u);
							continue;
						case 18u:
							WorldClass.smethod_7(this.clientSocket, this.DataBuffer, 0, this.DataBuffer.Length, SocketFlags.None, new AsyncCallback(this.Receive), null);
							arg_2A1_0 = 466592861u;
							continue;
						case 19u:
							arg_2A1_0 = ((this.initiated ? 1275411404u : 788338040u) ^ num2 * 4152913669u);
							continue;
						case 20u:
						{
							PacketReader packetReader;
							AuthenticationHandler.HandleAuthChallenge(ref packetReader, this);
							arg_2A1_0 = (num2 * 2478836290u ^ 3479432470u);
							continue;
						}
						}
						goto Block_9;
					}
				}
				Block_9:;
			}
			catch (Exception)
			{
				while (true)
				{
					IL_343:
					uint arg_314_0 = 794464263u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_314_0 ^ 2097752605u)) % 3u)
						{
						case 0u:
							goto IL_343;
						case 2u:
							CharacterHandler.chatRunning = false;
							arg_314_0 = (num2 * 2798643116u ^ 1282738044u);
							continue;
						}
						goto Block_11;
					}
				}
				Block_11:;
			}
		}

		private void Decode(ref byte[] data)
		{
			this.Crypt.Decrypt(data, 4);
		}

		public static uint Adler32(byte[] data)
		{
			uint num = 55537u;
			uint num4;
			while (true)
			{
				IL_BE:
				uint arg_92_0 = 1454806432u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 235795070u)) % 8u)
					{
					case 0u:
						goto IL_BE;
					case 1u:
					{
						int num3;
						arg_92_0 = ((num3 < data.Length) ? 1132878706u : 328180532u);
						continue;
					}
					case 3u:
						num4 = (num4 + num) % 65521u;
						arg_92_0 = (num2 * 2301135219u ^ 507895184u);
						continue;
					case 4u:
					{
						int num3;
						num = (num + (uint)data[num3]) % 65521u;
						arg_92_0 = 1697866549u;
						continue;
					}
					case 5u:
					{
						int num3 = 0;
						arg_92_0 = (num2 * 3535326672u ^ 1948598311u);
						continue;
					}
					case 6u:
						num4 = 38951u;
						arg_92_0 = (num2 * 1817707444u ^ 3094025011u);
						continue;
					case 7u:
					{
						int num3;
						num3++;
						arg_92_0 = (num2 * 1245978631u ^ 1781619886u);
						continue;
					}
					}
					goto Block_2;
				}
			}
			Block_2:
			return (num4 << 16) + num;
		}

		public void Send(ref PacketWriter packet)
		{
			byte[] array = packet.ReadDataToSend(false);
			try
			{
				Log.Message(LogType.Packet, Module.smethod_36<string>(593506430u), new object[]
				{
					packet.Opcode,
					packet.Size
				});
				byte[] array2;
				int int_;
				uint uint_;
				PacketWriter packetWriter2;
				while (true)
				{
					IL_155:
					uint arg_123_0 = 2199929490u;
					while (true)
					{
						uint num;
						switch ((num = (arg_123_0 ^ 3311393667u)) % 9u)
						{
						case 1u:
						{
							array2 = null;
							byte[] array3;
							int_ = array3.Length;
							uint_ = WorldClass.Adler32(array3);
							arg_123_0 = (num * 68058880u ^ 2153398968u);
							continue;
						}
						case 2u:
							goto IL_155;
						case 3u:
						{
							PacketWriter packetWriter = new PacketWriter(ServerMessage.ResetCompressionContext, true);
							arg_123_0 = (num * 1834449402u ^ 1107624411u);
							continue;
						}
						case 4u:
							if (this.Crypt.IsInitialized)
							{
								arg_123_0 = (num * 3545686980u ^ 39507906u);
								continue;
							}
							goto IL_374;
						case 5u:
						{
							PacketWriter packetWriter;
							this.Send(ref packetWriter);
							packetWriter2 = new PacketWriter(ServerMessage.Compression, true);
							arg_123_0 = (num * 1258462980u ^ 4146404091u);
							continue;
						}
						case 6u:
						{
							byte[] array3;
							byte[] array4;
							array3[1] = array4[1];
							arg_123_0 = (num * 2425788949u ^ 3606182965u);
							continue;
						}
						case 7u:
						{
							byte[] array4 = WorldClass.smethod_15((ushort)packet.Opcode);
							byte[] array3 = new byte[array.Length - 4];
							WorldClass.smethod_13(array, 4, array3, 0, array3.Length);
							array3[0] = array4[0];
							arg_123_0 = (num * 2814429138u ^ 762017105u);
							continue;
						}
						case 8u:
							goto IL_3F8;
						}
						goto Block_4;
					}
				}
				uint arg_3B6_0;
				while (true)
				{
					IL_3B1:
					uint num;
					switch ((num = (arg_3B6_0 ^ 3311393667u)) % 13u)
					{
					case 0u:
						array2 = array2.Combine(new byte[]
						{
							0,
							0,
							255,
							255
						});
						arg_3B6_0 = 4135719112u;
						continue;
					case 1u:
						goto IL_374;
					case 2u:
					{
						WorldClass.smethod_23(packetWriter2, uint_);
						uint uint_2;
						WorldClass.smethod_23(packetWriter2, uint_2);
						WorldClass.smethod_24(packetWriter2, array2);
						arg_3B6_0 = (num * 4105965725u ^ 4017603929u);
						continue;
					}
					case 3u:
					{
						uint uint_2 = WorldClass.Adler32(array2);
						arg_3B6_0 = (num * 977288196u ^ 864158354u);
						continue;
					}
					case 4u:
						array[1] = (byte)(255 & array.Length - 4 >> 8);
						this.Crypt.Encrypt(array, 4);
						arg_3B6_0 = (num * 3558555324u ^ 1587990696u);
						continue;
					case 5u:
						array = packetWriter2.ReadDataToSend(false);
						arg_3B6_0 = (num * 1269215262u ^ 3837774562u);
						continue;
					case 6u:
						arg_3B6_0 = ((((array2[array2.Length - 1] & 8) != 8) ? 3170777306u : 2567516264u) ^ num * 894815154u);
						continue;
					case 7u:
						WorldClass.smethod_25(packet);
						arg_3B6_0 = (num * 214185292u ^ 269952291u);
						continue;
					case 9u:
						goto IL_3F8;
					case 10u:
						array2 = array2.Combine(new byte[1]);
						arg_3B6_0 = (num * 2738487785u ^ 951591865u);
						continue;
					case 11u:
						goto IL_271;
					case 12u:
						WorldClass.smethod_22(packetWriter2, int_);
						arg_3B6_0 = (num * 891587732u ^ 1040375321u);
						continue;
					}
					break;
				}
				return;
				Block_4:
				MemoryStream memoryStream = WorldClass.smethod_16();
				try
				{
					DeflateStream deflateStream = WorldClass.smethod_17(memoryStream, CompressionLevel.Fastest);
					try
					{
						byte[] array3;
						WorldClass.smethod_18(deflateStream, array3, 0, array3.Length);
						while (true)
						{
							IL_1B0:
							uint arg_197_0 = 3252342619u;
							while (true)
							{
								uint num;
								switch ((num = (arg_197_0 ^ 3311393667u)) % 3u)
								{
								case 1u:
									WorldClass.smethod_19(deflateStream);
									arg_197_0 = (num * 3667174594u ^ 498565863u);
									continue;
								case 2u:
									goto IL_1B0;
								}
								goto Block_11;
							}
						}
						Block_11:;
					}
					finally
					{
						if (deflateStream != null)
						{
							while (true)
							{
								IL_1F2:
								uint arg_1D9_0 = 2488757830u;
								while (true)
								{
									uint num;
									switch ((num = (arg_1D9_0 ^ 3311393667u)) % 3u)
									{
									case 0u:
										goto IL_1F2;
									case 2u:
										WorldClass.smethod_20(deflateStream);
										arg_1D9_0 = (num * 1032679818u ^ 1481471478u);
										continue;
									}
									goto Block_14;
								}
							}
							Block_14:;
						}
					}
					array2 = WorldClass.smethod_21(memoryStream);
				}
				finally
				{
					if (memoryStream != null)
					{
						while (true)
						{
							IL_23E:
							uint arg_225_0 = 4248991174u;
							while (true)
							{
								uint num;
								switch ((num = (arg_225_0 ^ 3311393667u)) % 3u)
								{
								case 1u:
									WorldClass.smethod_20(memoryStream);
									arg_225_0 = (num * 4155117569u ^ 3966915401u);
									continue;
								case 2u:
									goto IL_23E;
								}
								goto Block_17;
							}
						}
						Block_17:;
					}
				}
				byte[] expr_24E_cp_0 = array2;
				int expr_24E_cp_1 = 0;
				expr_24E_cp_0[expr_24E_cp_1] -= 1;
				IL_271:
				arg_3B6_0 = 2766555372u;
				goto IL_3B1;
				IL_374:
				WorldClass.smethod_8(this.clientSocket, array, 0, array.Length, SocketFlags.None);
				arg_3B6_0 = 3877238322u;
				goto IL_3B1;
				IL_3F8:
				array[0] = (byte)(255 & array.Length - 4);
				arg_3B6_0 = 4257648992u;
				goto IL_3B1;
			}
			catch (Exception exception_)
			{
				while (true)
				{
					IL_48F:
					uint arg_41C_0 = 3929711820u;
					while (true)
					{
						uint num;
						switch ((num = (arg_41C_0 ^ 3311393667u)) % 4u)
						{
						case 0u:
							goto IL_48F;
						case 2u:
							WorldClass.smethod_27(this.clientSocket);
							CharacterHandler.chatRunning = false;
							arg_41C_0 = (num * 1852355598u ^ 3988322590u);
							continue;
						case 3u:
							Log.Message(LogType.Error, Module.smethod_36<string>(3490486299u), new object[]
							{
								WorldClass.smethod_26(exception_)
							});
							Log.Message();
							arg_41C_0 = (num * 3844434002u ^ 3766579695u);
							continue;
						}
						goto Block_19;
					}
				}
				Block_19:;
			}
		}

		public void Dispose()
		{
			this.Crypt.Dispose();
		}

		static Queue smethod_0()
		{
			return new Queue();
		}

		static int smethod_1(Queue queue_0)
		{
			return queue_0.Count;
		}

		static object smethod_2(Queue queue_0)
		{
			return queue_0.Dequeue();
		}

		static EndPoint smethod_3(Socket socket_0)
		{
			return socket_0.RemoteEndPoint;
		}

		static IPAddress smethod_4(IPEndPoint ipendPoint_0)
		{
			return ipendPoint_0.Address;
		}

		static int smethod_5(IPEndPoint ipendPoint_0)
		{
			return ipendPoint_0.Port;
		}

		static string smethod_6(object object_0, object object_1, object object_2)
		{
			return object_0 + object_1 + object_2;
		}

		static IAsyncResult smethod_7(Socket socket_0, byte[] byte_0, int int_0, int int_1, SocketFlags socketFlags_0, AsyncCallback asyncCallback_0, object object_0)
		{
			return socket_0.BeginReceive(byte_0, int_0, int_1, socketFlags_0, asyncCallback_0, object_0);
		}

		static int smethod_8(Socket socket_0, byte[] byte_0, int int_0, int int_1, SocketFlags socketFlags_0)
		{
			return socket_0.Send(byte_0, int_0, int_1, socketFlags_0);
		}

		static int smethod_9(Socket socket_0, IAsyncResult iasyncResult_0)
		{
			return socket_0.EndReceive(iasyncResult_0);
		}

		static Encoding smethod_10()
		{
			return Encoding.ASCII;
		}

		static byte[] smethod_11(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static ushort smethod_12(byte[] byte_0, int int_0)
		{
			return BitConverter.ToUInt16(byte_0, int_0);
		}

		static void smethod_13(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static void smethod_14(Queue queue_0, object object_0)
		{
			queue_0.Enqueue(object_0);
		}

		static byte[] smethod_15(ushort ushort_0)
		{
			return BitConverter.GetBytes(ushort_0);
		}

		static MemoryStream smethod_16()
		{
			return new MemoryStream();
		}

		static DeflateStream smethod_17(Stream stream_0, CompressionLevel compressionLevel_0)
		{
			return new DeflateStream(stream_0, compressionLevel_0);
		}

		static void smethod_18(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		static void smethod_19(Stream stream_0)
		{
			stream_0.Flush();
		}

		static void smethod_20(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static byte[] smethod_21(MemoryStream memoryStream_0)
		{
			return memoryStream_0.ToArray();
		}

		static void smethod_22(BinaryWriter binaryWriter_0, int int_0)
		{
			binaryWriter_0.Write(int_0);
		}

		static void smethod_23(BinaryWriter binaryWriter_0, uint uint_0)
		{
			binaryWriter_0.Write(uint_0);
		}

		static void smethod_24(BinaryWriter binaryWriter_0, byte[] byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static void smethod_25(BinaryWriter binaryWriter_0)
		{
			binaryWriter_0.Flush();
		}

		static string smethod_26(Exception exception_0)
		{
			return exception_0.Message;
		}

		static void smethod_27(Socket socket_0)
		{
			socket_0.Close();
		}
	}
}
