using AuthServer.AuthServer.JsonObjects;
using Bgs.Protocol;
using Framework.Constants.Misc;
using Framework.Cryptography.BNet;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Framework.Misc;
using Framework.Serialization;
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

namespace AuthServer.AuthServer.Network
{
	public class RestSession : IDisposable
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

		public RestSession(Socket socket)
		{
			this.client = socket;
		}

		public string GetCInfo()
		{
			IPEndPoint ipendPoint_ = RestSession.smethod_0(this.client) as IPEndPoint;
			return RestSession.smethod_3(RestSession.smethod_1(ipendPoint_), Module.smethod_35<string>(2164558557u), RestSession.smethod_2(ipendPoint_));
		}

		public void Accept()
		{
			RestSession.smethod_4();
			X509Certificate2 x509Certificate_;
			while (true)
			{
				IL_82:
				uint arg_65_0 = 3907938690u;
				while (true)
				{
					uint num;
					switch ((num = (arg_65_0 ^ 3175972147u)) % 4u)
					{
					case 0u:
						x509Certificate_ = RestSession.smethod_7(Globals.CertData);
						arg_65_0 = (num * 4011506567u ^ 300618885u);
						continue;
					case 1u:
						this.nStream = RestSession.smethod_5(this.client);
						this.sslStream = RestSession.smethod_6(this.nStream, false, new RemoteCertificateValidationCallback(this.App_CertificateValidation));
						arg_65_0 = (num * 1806681062u ^ 4172582821u);
						continue;
					case 3u:
						goto IL_82;
					}
					goto Block_1;
				}
			}
			Block_1:
			RestSession.smethod_8();
			try
			{
				RestSession.smethod_9(this.sslStream, x509Certificate_, false, SslProtocols.Tls12, false);
				int num2 = 0;
				while (true)
				{
					IL_5F9:
					uint arg_573_0 = 2170226920u;
					while (true)
					{
						uint num;
						switch ((num = (arg_573_0 ^ 3175972147u)) % 30u)
						{
						case 1u:
							RestSession.smethod_12(this.client);
							arg_573_0 = 2556496177u;
							continue;
						case 2u:
							arg_573_0 = (num * 1744763105u ^ 3406682519u);
							continue;
						case 3u:
							goto IL_5F9;
						case 4u:
							arg_573_0 = (num * 585180848u ^ 3852376867u);
							continue;
						case 5u:
						{
							string text;
							HttpHeader header = new HttpHeader
							{
								ContentLength = RestSession.smethod_14(text),
								Content = text
							};
							byte[] byte_ = HttpResponse.Create(HttpCode.OK, header);
							arg_573_0 = (num * 2775480801u ^ 3304877568u);
							continue;
						}
						case 6u:
						{
							byte[] byte_2;
							RestSession.smethod_15(this.sslStream, byte_2);
							arg_573_0 = (num * 1250492958u ^ 673772331u);
							continue;
						}
						case 7u:
						{
							byte[] array = new byte[num2];
							arg_573_0 = (num * 2719918147u ^ 2287814592u);
							continue;
						}
						case 8u:
						{
							int num3;
							arg_573_0 = (((num3 == 0) ? 4097782074u : 3496280056u) ^ num * 161494277u);
							continue;
						}
						case 9u:
						{
							HttpHeader header2;
							byte[] byte_2 = HttpResponse.Create(HttpCode.OK, header2);
							arg_573_0 = (num * 3879896502u ^ 3651918943u);
							continue;
						}
						case 10u:
						{
							byte[] array;
							HttpHeader httpHeader = HttpRequest.Parse(array);
							arg_573_0 = ((!RestSession.smethod_13(httpHeader.Method, Module.smethod_33<string>(3773212618u))) ? 2403055654u : 2357400434u);
							continue;
						}
						case 11u:
						{
							HttpHeader httpHeader;
							arg_573_0 = ((!RestSession.smethod_13(httpHeader.Method, Module.smethod_37<string>(3361680046u))) ? 2215941699u : 4202937684u);
							continue;
						}
						case 12u:
						{
							byte[] array;
							arg_573_0 = (((array.Length != 0) ? 2819837061u : 3242441858u) ^ num * 1932756245u);
							continue;
						}
						case 13u:
						{
							int num4 = 0;
							arg_573_0 = (num * 1257474539u ^ 2631169849u);
							continue;
						}
						case 14u:
						{
							LogonForm logonForm;
							arg_573_0 = (((!RestSession.smethod_13(logonForm[Module.smethod_36<string>(2861509726u)], Module.smethod_37<string>(235398904u))) ? 1053858572u : 1055173549u) ^ num * 2475641201u);
							continue;
						}
						case 15u:
						{
							byte[] array;
							arg_573_0 = (((array == null) ? 3243205583u : 2710869470u) ^ num * 891484237u);
							continue;
						}
						case 16u:
						{
							LogonForm logonForm;
							arg_573_0 = ((RestSession.smethod_13(logonForm[Module.smethod_36<string>(2250828827u)], Module.smethod_36<string>(837291206u)) ? 498799901u : 678006082u) ^ num * 2492023149u);
							continue;
						}
						case 17u:
						{
							int num4;
							int num3 = num4++;
							arg_573_0 = (num * 1111030318u ^ 3356779107u);
							continue;
						}
						case 18u:
						{
							string text2;
							HttpHeader header2 = new HttpHeader
							{
								ContentLength = RestSession.smethod_14(text2),
								Content = text2
							};
							arg_573_0 = (num * 3964775577u ^ 694209648u);
							continue;
						}
						case 19u:
							RestSession.smethod_12(this.client);
							arg_573_0 = 2972599719u;
							continue;
						case 20u:
						{
							string text2 = Json.CreateString<PostLogonForm>(new PostLogonForm
							{
								AuthenticationState = AuthenticationState.Done,
								LoginTicket = Module.smethod_36<string>(304136250u)
							});
							arg_573_0 = (num * 360167075u ^ 3963249545u);
							continue;
						}
						case 21u:
							RestSession.smethod_16(Module.smethod_33<string>(3715608777u));
							arg_573_0 = 2215941699u;
							continue;
						case 22u:
						{
							byte[] byte_;
							RestSession.smethod_15(this.sslStream, byte_);
							arg_573_0 = (num * 777717677u ^ 724990205u);
							continue;
						}
						case 24u:
						{
							byte[] array;
							RestSession.smethod_11(this.dataBuffer, array, num2);
							arg_573_0 = (num * 2219576960u ^ 2407803994u);
							continue;
						}
						case 25u:
						{
							string text = Json.CreateString<FormInputs>(new FormInputs
							{
								Type = Module.smethod_37<string>(3946023123u),
								Inputs = new List<FormInput>(),
								Inputs = 
								{
									new FormInput
									{
										Id = Module.smethod_34<string>(1157598820u),
										Type = Module.smethod_35<string>(660958023u),
										Label = Module.smethod_36<string>(4155214069u),
										MaxLength = 320
									},
									new FormInput
									{
										Id = Module.smethod_35<string>(269237390u),
										Type = Module.smethod_35<string>(269237390u),
										Label = Module.smethod_33<string>(4156767494u),
										MaxLength = 16
									},
									new FormInput
									{
										Id = Module.smethod_33<string>(3613515769u),
										Type = Module.smethod_37<string>(3303236897u),
										Label = Module.smethod_33<string>(187751233u)
									}
								}
							});
							arg_573_0 = (num * 1698536323u ^ 3749898327u);
							continue;
						}
						case 26u:
							arg_573_0 = (num * 3176669753u ^ 3512643481u);
							continue;
						case 27u:
						{
							HttpHeader httpHeader;
							LogonForm logonForm = Json.CreateObject<LogonForm>(httpHeader.Content);
							arg_573_0 = (num * 207156555u ^ 3087242650u);
							continue;
						}
						case 28u:
							arg_573_0 = ((num2 == 0) ? 3622369844u : 3326415920u);
							continue;
						case 29u:
							num2 = RestSession.smethod_10(this.sslStream, this.dataBuffer, 0, this.dataBuffer.Length);
							arg_573_0 = 3087035324u;
							continue;
						}
						goto Block_12;
					}
				}
				Block_12:;
			}
			catch (Exception)
			{
				while (true)
				{
					IL_643:
					uint arg_60F_0 = 2706351906u;
					while (true)
					{
						uint num;
						switch ((num = (arg_60F_0 ^ 3175972147u)) % 3u)
						{
						case 1u:
							RestSession.smethod_12(this.client);
							arg_60F_0 = (num * 734591689u ^ 879456549u);
							continue;
						case 2u:
							goto IL_643;
						}
						goto Block_14;
					}
				}
				Block_14:
				this.Dispose();
			}
		}

		private bool App_CertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		public void Send(byte[] rawdata)
		{
			RestSession.smethod_15(this.sslStream, rawdata);
		}

		public void Send(IMessage message)
		{
			try
			{
				byte[] array = message.ToByteArray();
				byte[] array2 = new Header
				{
					Token = 0u,
					ServiceId = 254u,
					Size = (uint)array.Length
				}.ToByteArray();
				byte[] array3 = new byte[2];
				while (true)
				{
					IL_110:
					uint arg_EB_0 = 3281382246u;
					while (true)
					{
						uint num;
						switch ((num = (arg_EB_0 ^ 2233116095u)) % 6u)
						{
						case 1u:
							array3[0] = (byte)(array2.Length >> 8);
							array3[1] = (byte)(array2.Length & 255);
							array3 = array3.Concat(array2).Concat(array).ToArray<byte>();
							arg_EB_0 = (num * 397377048u ^ 1189005203u);
							continue;
						case 2u:
							goto IL_110;
						case 3u:
							Log.Message(LogType.Error, RestSession.smethod_18(Module.smethod_37<string>(146717431u), RestSession.smethod_17(message)), Array.Empty<object>());
							arg_EB_0 = (num * 4247256910u ^ 511300987u);
							continue;
						case 4u:
							arg_EB_0 = (((array3.Length == 2 + array2.Length + array.Length) ? 3751062502u : 2638181500u) ^ num * 1995585982u);
							continue;
						case 5u:
							RestSession.smethod_15(this.sslStream, array3);
							arg_EB_0 = 3485856961u;
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			catch (SocketException exception_)
			{
				while (true)
				{
					IL_169:
					uint arg_121_0 = 3567765158u;
					while (true)
					{
						uint num;
						switch ((num = (arg_121_0 ^ 2233116095u)) % 3u)
						{
						case 0u:
							goto IL_169;
						case 1u:
							Log.Message(LogType.Error, Module.smethod_36<string>(3490486299u), new object[]
							{
								RestSession.smethod_19(exception_)
							});
							arg_121_0 = (num * 1261360073u ^ 3352763934u);
							continue;
						}
						goto Block_5;
					}
				}
				Block_5:
				RestSession.smethod_20(this.client);
			}
		}

		public void Send(IMessage message, uint serviceHash, uint methodId)
		{
			try
			{
				byte[] array = message.ToByteArray();
				while (true)
				{
					IL_184:
					uint arg_14E_0 = 2552486184u;
					while (true)
					{
						uint num;
						switch ((num = (arg_14E_0 ^ 2204077453u)) % 10u)
						{
						case 0u:
						{
							byte[] array2;
							byte[] array3;
							array2[0] = (byte)(array3.Length >> 8);
							arg_14E_0 = (num * 2469205237u ^ 922619938u);
							continue;
						}
						case 1u:
							arg_14E_0 = (num * 369987135u ^ 995479250u);
							continue;
						case 2u:
							goto IL_184;
						case 3u:
							Log.Message(LogType.Error, RestSession.smethod_18(Module.smethod_34<string>(2746132316u), RestSession.smethod_17(message)), Array.Empty<object>());
							arg_14E_0 = (num * 1089050472u ^ 225111790u);
							continue;
						case 4u:
						{
							byte[] array3;
							byte[] array2 = array2.Concat(array3).Concat(array).ToArray<byte>();
							arg_14E_0 = (((array2.Length == 2 + array3.Length + array.Length) ? 3650143856u : 2376975962u) ^ num * 2239156228u);
							continue;
						}
						case 5u:
						{
							Header expr_61 = new Header();
							uint num2 = this.token;
							this.token = num2 + 1u;
							expr_61.Token = num2;
							expr_61.ServiceId = 0u;
							expr_61.ServiceHash = serviceHash;
							expr_61.MethodId = methodId;
							expr_61.Size = (uint)array.Length;
							byte[] array3 = expr_61.ToByteArray();
							arg_14E_0 = (num * 1606904854u ^ 1376312577u);
							continue;
						}
						case 6u:
						{
							byte[] array2 = new byte[2];
							arg_14E_0 = (num * 3434274782u ^ 1626019935u);
							continue;
						}
						case 7u:
						{
							byte[] array2;
							byte[] array3;
							array2[1] = (byte)(array3.Length & 255);
							arg_14E_0 = (num * 4068384342u ^ 4016607499u);
							continue;
						}
						case 9u:
						{
							byte[] array2;
							RestSession.smethod_15(this.sslStream, array2);
							arg_14E_0 = 3681796951u;
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
					RestSession.smethod_19(exception_)
				});
				RestSession.smethod_20(this.client);
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

		static HttpListener smethod_4()
		{
			return new HttpListener();
		}

		static NetworkStream smethod_5(Socket socket_0)
		{
			return new NetworkStream(socket_0);
		}

		static SslStream smethod_6(Stream stream_0, bool bool_0, RemoteCertificateValidationCallback remoteCertificateValidationCallback_0)
		{
			return new SslStream(stream_0, bool_0, remoteCertificateValidationCallback_0);
		}

		static X509Certificate2 smethod_7(byte[] byte_0)
		{
			return new X509Certificate2(byte_0);
		}

		static X509Chain smethod_8()
		{
			return X509Chain.Create();
		}

		static void smethod_9(SslStream sslStream_0, X509Certificate x509Certificate_0, bool bool_0, SslProtocols sslProtocols_0, bool bool_1)
		{
			sslStream_0.AuthenticateAsServer(x509Certificate_0, bool_0, sslProtocols_0, bool_1);
		}

		static int smethod_10(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			return stream_0.Read(byte_0, int_0, int_1);
		}

		static void smethod_11(Array array_0, Array array_1, int int_0)
		{
			Array.Copy(array_0, array_1, int_0);
		}

		static void smethod_12(Socket socket_0)
		{
			socket_0.Dispose();
		}

		static bool smethod_13(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static int smethod_14(string string_0)
		{
			return string_0.Length;
		}

		static void smethod_15(SslStream sslStream_0, byte[] byte_0)
		{
			sslStream_0.Write(byte_0);
		}

		static void smethod_16(string string_0)
		{
			Console.WriteLine(string_0);
		}

		static string smethod_17(object object_0)
		{
			return object_0.ToString();
		}

		static string smethod_18(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static string smethod_19(Exception exception_0)
		{
			return exception_0.Message;
		}

		static void smethod_20(Socket socket_0)
		{
			socket_0.Close();
		}
	}
}
