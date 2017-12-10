using AuthServer.Packets;
using Bgs.Protocol;
using Framework.Constants.Misc;
using Framework.Cryptography.BNet;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace AuthServer.Network
{
	public class AuthSession : IDisposable
	{
		private Socket client;

		private NetworkStream nStream;

		private SslStream sslStream;

		private byte[] dataBuffer = new byte[2048];

		private uint token;

		public Account Account
		{
			get;
			set;
		}

		public ListModule Modules
		{
			get;
			set;
		}

		public SRP6a SecureRemotePassword
		{
			get;
			set;
		}

		public BNetCrypt Crypt
		{
			get;
			set;
		}

		public AuthSession(Socket socket)
		{
			while (true)
			{
				IL_49:
				uint arg_31_0 = 2548465828u;
				while (true)
				{
					uint num;
					switch ((num = (arg_31_0 ^ 2539585623u)) % 3u)
					{
					case 1u:
						this.client = socket;
						arg_31_0 = (num * 2589854966u ^ 159818506u);
						continue;
					case 2u:
						goto IL_49;
					}
					return;
				}
			}
		}

		public string GetCInfo()
		{
			IPEndPoint ipendPoint_ = AuthSession.smethod_0(this.client) as IPEndPoint;
			return AuthSession.smethod_3(AuthSession.smethod_1(ipendPoint_), Module.smethod_36<string>(2662777765u), AuthSession.smethod_2(ipendPoint_));
		}

		public void Accept()
		{
			this.nStream = AuthSession.smethod_4(this.client);
			this.sslStream = AuthSession.smethod_5(this.nStream, false, new RemoteCertificateValidationCallback(this.App_CertificateValidation));
			X509Certificate2 x509Certificate_;
			while (true)
			{
				IL_82:
				uint arg_65_0 = 860733640u;
				while (true)
				{
					uint num;
					switch ((num = (arg_65_0 ^ 246562425u)) % 4u)
					{
					case 1u:
						x509Certificate_ = AuthSession.smethod_6(Globals.CertData);
						arg_65_0 = (num * 1229629450u ^ 2865226121u);
						continue;
					case 2u:
						AuthSession.smethod_7();
						arg_65_0 = (num * 587216413u ^ 2305725567u);
						continue;
					case 3u:
						goto IL_82;
					}
					goto Block_1;
				}
			}
			Block_1:
			AuthSession.smethod_8(this.sslStream, x509Certificate_, false, SslProtocols.Tls12, false);
			try
			{
				int num2 = 0;
				while (true)
				{
					IL_309:
					uint arg_2AF_0 = 49108843u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2AF_0 ^ 246562425u)) % 19u)
						{
						case 0u:
						{
							byte[] array;
							int num3;
							byte[] array2;
							AuthSession.smethod_12(array, 2 + num3, array2, 0, array2.Length);
							arg_2AF_0 = (num * 1170099715u ^ 2371495065u);
							continue;
						}
						case 2u:
						{
							num2 = AuthSession.smethod_9(this.sslStream, this.dataBuffer, 0, this.dataBuffer.Length);
							byte[] array = new byte[num2];
							arg_2AF_0 = 1549349530u;
							continue;
						}
						case 3u:
						{
							int num4;
							arg_2AF_0 = ((num4 == 0) ? 1463133268u : 1037717072u);
							continue;
						}
						case 4u:
						{
							byte[] array3;
							byte[] array = array3;
							arg_2AF_0 = (num * 4033826896u ^ 2031620618u);
							continue;
						}
						case 5u:
						{
							byte[] array2;
							Header header;
							PacketManager.InvokeHandler(this, header, array2);
							byte[] array;
							int num3;
							byte[] array3 = new byte[array.Length - (2 + num3 + array2.Length)];
							AuthSession.smethod_12(array, 2 + num3 + array2.Length, array3, 0, array3.Length);
							arg_2AF_0 = (num * 3708909547u ^ 2854981413u);
							continue;
						}
						case 6u:
						{
							byte[] array;
							arg_2AF_0 = (((array.Length != 0) ? 2945062073u : 3965050639u) ^ num * 1155918630u);
							continue;
						}
						case 7u:
						{
							byte[] array;
							int num3 = (int)array[0] << 8 | (int)array[1];
							arg_2AF_0 = 578192904u;
							continue;
						}
						case 8u:
							goto IL_309;
						case 10u:
							arg_2AF_0 = (num * 2487307768u ^ 3498454815u);
							continue;
						case 11u:
							AuthSession.smethod_11(this.client);
							arg_2AF_0 = 1429566910u;
							continue;
						case 12u:
							arg_2AF_0 = (((num2 == 0) ? 626390441u : 591395909u) ^ num * 3512777382u);
							continue;
						case 13u:
						{
							byte[] array;
							AuthSession.smethod_10(this.dataBuffer, array, num2);
							arg_2AF_0 = (num * 1924678482u ^ 1480375202u);
							continue;
						}
						case 14u:
						{
							Header header;
							byte[] array2 = new byte[header.Size];
							arg_2AF_0 = (num * 1432188463u ^ 2010760901u);
							continue;
						}
						case 15u:
						{
							byte[] array;
							arg_2AF_0 = (((array == null) ? 1352117440u : 1641829883u) ^ num * 3270442297u);
							continue;
						}
						case 16u:
						{
							int num3;
							byte[] array2;
							int num4;
							num4 -= 2 + num3 + array2.Length;
							arg_2AF_0 = (num * 1437371291u ^ 225455286u);
							continue;
						}
						case 17u:
						{
							byte[] array;
							int num3;
							Header header = Header.Parser.ParseFrom(new CodedInputStream(array, 2, num3));
							arg_2AF_0 = (num * 1259081135u ^ 326502318u);
							continue;
						}
						case 18u:
						{
							byte[] array;
							int num4 = array.Length;
							arg_2AF_0 = 77016214u;
							continue;
						}
						}
						goto Block_8;
					}
				}
				Block_8:;
			}
			catch
			{
				AuthSession.smethod_13(this.nStream);
				AuthSession.smethod_13(this.sslStream);
				AuthSession.smethod_11(this.client);
				this.Dispose();
			}
		}

		private bool App_CertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		public void Send(byte[] rawdata)
		{
			AuthSession.smethod_14(this.sslStream, rawdata);
		}

		public void Send(IMessage message)
		{
			try
			{
				byte[] array = message.ToByteArray();
				Header expr_0C = new Header();
				uint num = this.token;
				this.token = num + 1u;
				expr_0C.Token = num;
				expr_0C.ServiceId = 254u;
				expr_0C.Size = (uint)array.Length;
				byte[] array2 = expr_0C.ToByteArray();
				byte[] array3 = new byte[]
				{
					(byte)(array2.Length >> 8),
					(byte)(array2.Length & 255)
				}.Concat(array2).Concat(array).ToArray<byte>();
				if (array3.Length != 2 + array2.Length + array.Length)
				{
					goto IL_BD;
				}
				goto IL_E8;
				uint arg_C7_0;
				while (true)
				{
					IL_C2:
					uint num2;
					switch ((num2 = (arg_C7_0 ^ 3498315501u)) % 5u)
					{
					case 0u:
						goto IL_BD;
					case 1u:
						Log.Message(LogType.Error, AuthSession.smethod_16(Module.smethod_34<string>(2746132316u), AuthSession.smethod_15(message)), Array.Empty<object>());
						arg_C7_0 = (num2 * 2776554468u ^ 2779500804u);
						continue;
					case 2u:
						goto IL_E8;
					case 4u:
						arg_C7_0 = (num2 * 1413244438u ^ 368722621u);
						continue;
					}
					break;
				}
				return;
				IL_BD:
				arg_C7_0 = 2237932556u;
				goto IL_C2;
				IL_E8:
				AuthSession.smethod_14(this.sslStream, array3);
				arg_C7_0 = 4047401123u;
				goto IL_C2;
			}
			catch (SocketException exception_)
			{
				Log.Message(LogType.Error, Module.smethod_35<string>(877436003u), new object[]
				{
					AuthSession.smethod_17(exception_)
				});
				AuthSession.smethod_18(this.client);
			}
		}

		public void Send(IMessage message, uint serviceHash, uint methodId)
		{
			try
			{
				byte[] array = message.ToByteArray();
				Header expr_0C = new Header();
				uint num = this.token;
				this.token = num + 1u;
				expr_0C.Token = num;
				expr_0C.ServiceId = 0u;
				expr_0C.ServiceHash = serviceHash;
				expr_0C.MethodId = methodId;
				expr_0C.Size = (uint)array.Length;
				byte[] array2 = expr_0C.ToByteArray();
				while (true)
				{
					IL_152:
					uint arg_125_0 = 366186159u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_125_0 ^ 1624281610u)) % 8u)
						{
						case 0u:
							Log.Message(LogType.Error, AuthSession.smethod_16(Module.smethod_37<string>(146717431u), AuthSession.smethod_15(message)), Array.Empty<object>());
							arg_125_0 = (num2 * 972919856u ^ 2132085211u);
							continue;
						case 1u:
							arg_125_0 = (num2 * 1574694440u ^ 1593343040u);
							continue;
						case 3u:
						{
							byte[] array3;
							AuthSession.smethod_14(this.sslStream, array3);
							arg_125_0 = 2110467816u;
							continue;
						}
						case 4u:
							goto IL_152;
						case 5u:
						{
							byte[] array3 = new byte[2];
							arg_125_0 = (num2 * 163145253u ^ 3423772749u);
							continue;
						}
						case 6u:
						{
							byte[] array3;
							array3[0] = (byte)(array2.Length >> 8);
							arg_125_0 = (num2 * 4016648404u ^ 1584836037u);
							continue;
						}
						case 7u:
						{
							byte[] array3;
							array3[1] = (byte)(array2.Length & 255);
							array3 = array3.Concat(array2).Concat(array).ToArray<byte>();
							arg_125_0 = (((array3.Length != 2 + array2.Length + array.Length) ? 300038973u : 1367012310u) ^ num2 * 1699785961u);
							continue;
						}
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			catch (SocketException exception_)
			{
				Log.Message(LogType.Error, Module.smethod_37<string>(2717862335u), new object[]
				{
					AuthSession.smethod_17(exception_)
				});
				AuthSession.smethod_18(this.client);
			}
		}

		private void SendCompleted(object sender, SocketAsyncEventArgs e)
		{
		}

		public void Dispose()
		{
			this.client = null;
			this.Account = null;
			this.SecureRemotePassword = null;
		}

		static EndPoint smethod_0(Socket socket_0)
		{
			return socket_0.RemoteEndPoint;
		}

		static IPAddress smethod_1(IPEndPoint ipendPoint_0)
		{
			return ipendPoint_0.Address;
		}

		static int smethod_2(IPEndPoint ipendPoint_0)
		{
			return ipendPoint_0.Port;
		}

		static string smethod_3(object object_0, object object_1, object object_2)
		{
			return object_0 + object_1 + object_2;
		}

		static NetworkStream smethod_4(Socket socket_0)
		{
			return new NetworkStream(socket_0);
		}

		static SslStream smethod_5(Stream stream_0, bool bool_0, RemoteCertificateValidationCallback remoteCertificateValidationCallback_0)
		{
			return new SslStream(stream_0, bool_0, remoteCertificateValidationCallback_0);
		}

		static X509Certificate2 smethod_6(byte[] byte_0)
		{
			return new X509Certificate2(byte_0);
		}

		static X509Chain smethod_7()
		{
			return X509Chain.Create();
		}

		static void smethod_8(SslStream sslStream_0, X509Certificate x509Certificate_0, bool bool_0, SslProtocols sslProtocols_0, bool bool_1)
		{
			sslStream_0.AuthenticateAsServer(x509Certificate_0, bool_0, sslProtocols_0, bool_1);
		}

		static int smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			return stream_0.Read(byte_0, int_0, int_1);
		}

		static void smethod_10(Array array_0, Array array_1, int int_0)
		{
			Array.Copy(array_0, array_1, int_0);
		}

		static void smethod_11(Socket socket_0)
		{
			socket_0.Dispose();
		}

		static void smethod_12(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Array.Copy(array_0, int_0, array_1, int_1, int_2);
		}

		static void smethod_13(Stream stream_0)
		{
			stream_0.Dispose();
		}

		static void smethod_14(SslStream sslStream_0, byte[] byte_0)
		{
			sslStream_0.Write(byte_0);
		}

		static string smethod_15(object object_0)
		{
			return object_0.ToString();
		}

		static string smethod_16(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static string smethod_17(Exception exception_0)
		{
			return exception_0.Message;
		}

		static void smethod_18(Socket socket_0)
		{
			socket_0.Close();
		}
	}
}
