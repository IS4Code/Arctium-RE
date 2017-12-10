using AuthServer.Game.Entities;
using AuthServer.Game.PacketHandler;
using AuthServer.Game.Packets.PacketHandler;
using AuthServer.WorldServer.Game.Packets;
using AuthServer.WorldServer.Managers;
using Framework.Constants.Misc;
using Framework.Cryptography.WoW;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Framework.Network.Packets;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AuthServer.Network
{
	public sealed class WorldClass2 : IDisposable
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

		public WorldClass2()
		{
			this.DataBuffer = new byte[10000];
			this.PacketQueue = WorldClass2.smethod_0();
			this.Crypt = new WoWCrypt();
		}

		public void OnData()
		{
			PacketReader packetReader = null;
			if (WorldClass2.smethod_1(this.PacketQueue) > 0)
			{
				goto IL_13;
			}
			goto IL_B6;
			uint arg_92_0;
			while (true)
			{
				IL_8D:
				uint num;
				switch ((num = (arg_92_0 ^ 728961571u)) % 6u)
				{
				case 1u:
					goto IL_B6;
				case 2u:
					WorldClass2.smethod_6(WorldClass2.smethod_4((IPEndPoint)WorldClass2.smethod_3(this.clientSocket)), Module.smethod_33<string>(1968828782u), WorldClass2.smethod_5((IPEndPoint)WorldClass2.smethod_3(this.clientSocket)));
					arg_92_0 = 1105268257u;
					continue;
				case 3u:
					arg_92_0 = (num * 3788876196u ^ 3971847957u);
					continue;
				case 4u:
					packetReader = (PacketReader)WorldClass2.smethod_2(this.PacketQueue);
					arg_92_0 = (num * 3269895699u ^ 92473324u);
					continue;
				case 5u:
					goto IL_13;
				}
				break;
			}
			PacketManager.InvokeHandler(ref packetReader, this);
			return;
			IL_13:
			arg_92_0 = 1382663277u;
			goto IL_8D;
			IL_B6:
			packetReader = new PacketReader(this.DataBuffer, false, this.initiated);
			arg_92_0 = 1917673249u;
			goto IL_8D;
		}

		public void OnConnect()
		{
			PacketWriter arg_2E_0 = new PacketWriter();
			WorldClass2.smethod_7(this.clientSocket, this.DataBuffer, 0, this.DataBuffer.Length, SocketFlags.None, new AsyncCallback(this.Receive), null);
			arg_2E_0.WriteString(Module.smethod_37<string>(1753682996u), true);
			byte[] array = arg_2E_0.ReadDataToSend(true).Concat(new byte[]
			{
				10
			}).ToArray<byte>();
			while (true)
			{
				IL_99:
				uint arg_81_0 = 1075133308u;
				while (true)
				{
					uint num;
					switch ((num = (arg_81_0 ^ 981761687u)) % 3u)
					{
					case 1u:
						WorldClass2.smethod_8(this.clientSocket, array, 0, array.Length, SocketFlags.None);
						arg_81_0 = (num * 1060128331u ^ 2718837013u);
						continue;
					case 2u:
						goto IL_99;
					}
					return;
				}
			}
		}

		public void Receive(IAsyncResult result)
		{
			try
			{
				int num = WorldClass2.smethod_9(this.clientSocket, result);
				if (num != 0)
				{
					while (true)
					{
						IL_2F9:
						uint arg_297_0 = 2572528862u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_297_0 ^ 2436941003u)) % 21u)
							{
							case 0u:
								this.OnData();
								arg_297_0 = (num2 * 191845251u ^ 4089438739u);
								continue;
							case 1u:
							{
								int num3;
								WorldClass2.smethod_13(this.DataBuffer, num3, this.DataBuffer, 0, num);
								arg_297_0 = (num2 * 2952317215u ^ 3106640863u);
								continue;
							}
							case 2u:
								this.Decode(ref this.DataBuffer);
								arg_297_0 = 3699463717u;
								continue;
							case 3u:
							{
								PacketReader packetReader = new PacketReader(WorldClass2.smethod_11(WorldClass2.smethod_10(), Module.smethod_35<string>(2010718901u)), false, false);
								AuthenticationHandler.HandleAuthChallenge(ref packetReader, this);
								arg_297_0 = 3562505048u;
								continue;
							}
							case 4u:
								arg_297_0 = ((this.initiated ? 243683201u : 1619599055u) ^ num2 * 2769343958u);
								continue;
							case 5u:
								arg_297_0 = (((this.DataBuffer[0] != 10) ? 2585951529u : 2218927161u) ^ num2 * 852434365u);
								continue;
							case 6u:
								WorldClass2.smethod_7(this.clientSocket, this.DataBuffer, 0, this.DataBuffer.Length, SocketFlags.None, new AsyncCallback(this.Receive), null);
								arg_297_0 = 3583348697u;
								continue;
							case 7u:
								arg_297_0 = (num2 * 2462168781u ^ 1574046953u);
								continue;
							case 8u:
							{
								int num3;
								num -= num3;
								arg_297_0 = (num2 * 3321069430u ^ 2857468219u);
								continue;
							}
							case 9u:
								arg_297_0 = (((num == 1) ? 2789009040u : 2979273326u) ^ num2 * 2355032305u);
								continue;
							case 10u:
								goto IL_2F9;
							case 11u:
								arg_297_0 = ((!this.Crypt.IsInitialized) ? 3706980136u : 3470716317u);
								continue;
							case 12u:
							{
								byte[] array;
								PacketReader object_ = new PacketReader(array, true, this.initiated);
								WorldClass2.smethod_14(this.PacketQueue, object_);
								arg_297_0 = (num2 * 2996686111u ^ 503892096u);
								continue;
							}
							case 13u:
							{
								int num3;
								byte[] array = new byte[num3];
								WorldClass2.smethod_13(this.DataBuffer, 0, array, 0, num3);
								arg_297_0 = (num2 * 1078701079u ^ 3964195659u);
								continue;
							}
							case 15u:
								arg_297_0 = (num2 * 20290101u ^ 3912917976u);
								continue;
							case 16u:
								this.OnData();
								arg_297_0 = 4052475486u;
								continue;
							case 17u:
								arg_297_0 = (num2 * 262316136u ^ 981525821u);
								continue;
							case 18u:
							{
								int num3 = (int)(WorldClass2.smethod_12(this.DataBuffer, 0) + 4);
								arg_297_0 = (num2 * 1131685819u ^ 2940057169u);
								continue;
							}
							case 19u:
								arg_297_0 = ((num <= 0) ? 3545246949u : 3010332424u);
								continue;
							case 20u:
								arg_297_0 = ((this.DataBuffer[num - 1] != 10) ? 4052475486u : 3450847892u);
								continue;
							}
							goto Block_9;
						}
					}
					Block_9:;
				}
			}
			catch (Exception exception_)
			{
				while (true)
				{
					IL_3A1:
					uint arg_311_0 = 3652770445u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_311_0 ^ 2436941003u)) % 4u)
						{
						case 0u:
							goto IL_3A1;
						case 1u:
							Manager.WorldMgr.DeleteSession(this.Character.Guid);
							arg_311_0 = (num2 * 3029153242u ^ 155694202u);
							continue;
						case 2u:
							Log.Message(LogType.Error, Module.smethod_36<string>(3490486299u), new object[]
							{
								WorldClass2.smethod_15(exception_)
							});
							arg_311_0 = (((this.Character == null) ? 4239559022u : 4123036076u) ^ num2 * 3280453029u);
							continue;
						}
						goto Block_11;
					}
				}
				Block_11:
				CharacterHandler.chatRunning = false;
			}
		}

		private void Decode(ref byte[] data)
		{
			this.Crypt.Decrypt(data, 4);
		}

		public void Send(ref PacketWriter packet)
		{
			byte[] array = packet.ReadDataToSend(false);
			try
			{
				if (this.Crypt.IsInitialized)
				{
					goto IL_19;
				}
				goto IL_D0;
				uint arg_A8_0;
				while (true)
				{
					IL_A3:
					uint num;
					switch ((num = (arg_A8_0 ^ 283575599u)) % 7u)
					{
					case 0u:
						WorldClass2.smethod_16(packet);
						arg_A8_0 = (num * 935397368u ^ 752419448u);
						continue;
					case 2u:
						WorldClass2.smethod_8(this.clientSocket, array, 0, array.Length, SocketFlags.None);
						arg_A8_0 = (num * 3241794667u ^ 1690790458u);
						continue;
					case 3u:
						this.Crypt.Encrypt(array, 4);
						arg_A8_0 = (num * 3789761871u ^ 961221312u);
						continue;
					case 4u:
						array[0] = (byte)(255 & array.Length - 4);
						array[1] = (byte)(255 & array.Length - 4 >> 8);
						arg_A8_0 = (num * 3960662139u ^ 3351327311u);
						continue;
					case 5u:
						goto IL_19;
					case 6u:
						goto IL_D0;
					}
					break;
				}
				return;
				IL_19:
				arg_A8_0 = 1383073911u;
				goto IL_A3;
				IL_D0:
				Log.Message(LogType.Packet, Module.smethod_33<string>(332516270u), new object[]
				{
					packet.Opcode,
					packet.Size
				});
				arg_A8_0 = 516732805u;
				goto IL_A3;
			}
			catch (Exception exception_)
			{
				Log.Message(LogType.Error, Module.smethod_33<string>(3822441984u), new object[]
				{
					WorldClass2.smethod_15(exception_)
				});
				Log.Message();
				while (true)
				{
					IL_172:
					uint arg_13A_0 = 653994054u;
					while (true)
					{
						uint num;
						switch ((num = (arg_13A_0 ^ 283575599u)) % 3u)
						{
						case 1u:
							CharacterHandler.chatRunning = false;
							WorldClass2.smethod_17(this.clientSocket);
							arg_13A_0 = (num * 3561998556u ^ 1357924445u);
							continue;
						case 2u:
							goto IL_172;
						}
						goto Block_5;
					}
				}
				Block_5:;
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

		static string smethod_15(Exception exception_0)
		{
			return exception_0.Message;
		}

		static void smethod_16(BinaryWriter binaryWriter_0)
		{
			binaryWriter_0.Flush();
		}

		static void smethod_17(Socket socket_0)
		{
			socket_0.Close();
		}
	}
}
