using Framework.Constants.Misc;
using Framework.Logging;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AuthServer.Network
{
	internal class Server : IDisposable
	{
		private TcpListener listener;

		private bool isRunning;

		public Server(string ip, int port, bool alt = false)
		{
			IPAddress none;
			while (true)
			{
				IL_91:
				uint arg_75_0 = 371310205u;
				while (true)
				{
					uint num;
					switch ((num = (arg_75_0 ^ 1623540390u)) % 4u)
					{
					case 0u:
						goto IL_91;
					case 2u:
						Log.Message(LogType.Normal, Module.smethod_35<string>(2570238857u), new object[]
						{
							ip
						});
						Server.smethod_1(true);
						Server.smethod_2(0);
						arg_75_0 = (num * 1716082200u ^ 2169048995u);
						continue;
					case 3u:
						none = IPAddress.None;
						arg_75_0 = ((Server.smethod_0(ip, ref none) ? 4282623832u : 2167438799u) ^ num * 2015551441u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			try
			{
				this.listener = Server.smethod_3(none, port);
				Server.smethod_4(this.listener);
				if (this.isRunning = Server.smethod_6(Server.smethod_5(this.listener)))
				{
					if (!alt)
					{
						Server.smethod_8(Server.smethod_7(), new Action(this.AcceptConnection));
					}
					else
					{
						Server.smethod_8(Server.smethod_7(), new Action(this.AcceptRestConnection));
					}
				}
			}
			catch (Exception exception_)
			{
				Log.Message(LogType.Error, Module.smethod_37<string>(2717862335u), new object[]
				{
					Server.smethod_9(exception_)
				});
			}
		}

		[AsyncStateMachine(typeof(Server.<AcceptConnection>d__3))]
		private void AcceptConnection()
		{
			Server.<AcceptConnection>d__3 <AcceptConnection>d__;
			<AcceptConnection>d__.__4__this = this;
			<AcceptConnection>d__.__t__builder = AsyncVoidMethodBuilder.Create();
			<AcceptConnection>d__.__1__state = -1;
			while (true)
			{
				IL_58:
				uint arg_40_0 = 198740057u;
				while (true)
				{
					uint num;
					switch ((num = (arg_40_0 ^ 1066125044u)) % 3u)
					{
					case 0u:
						goto IL_58;
					case 2u:
					{
						AsyncVoidMethodBuilder __t__builder = <AcceptConnection>d__.__t__builder;
						__t__builder.Start<Server.<AcceptConnection>d__3>(ref <AcceptConnection>d__);
						arg_40_0 = (num * 2693948230u ^ 4271151357u);
						continue;
					}
					}
					return;
				}
			}
		}

		[AsyncStateMachine(typeof(Server.<AcceptRestConnection>d__4))]
		private void AcceptRestConnection()
		{
			Server.<AcceptRestConnection>d__4 <AcceptRestConnection>d__;
			<AcceptRestConnection>d__.__4__this = this;
			<AcceptRestConnection>d__.__t__builder = AsyncVoidMethodBuilder.Create();
			while (true)
			{
				IL_6B:
				uint arg_4F_0 = 1608828269u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4F_0 ^ 1570516976u)) % 4u)
					{
					case 0u:
						goto IL_6B;
					case 1u:
					{
						<AcceptRestConnection>d__.__1__state = -1;
						AsyncVoidMethodBuilder __t__builder = <AcceptRestConnection>d__.__t__builder;
						arg_4F_0 = (num * 1556040183u ^ 1668645385u);
						continue;
					}
					case 2u:
					{
						AsyncVoidMethodBuilder __t__builder;
						__t__builder.Start<Server.<AcceptRestConnection>d__4>(ref <AcceptRestConnection>d__);
						arg_4F_0 = (num * 1876418357u ^ 882570693u);
						continue;
					}
					}
					return;
				}
			}
		}

		public void Dispose()
		{
			this.listener = null;
			this.isRunning = false;
		}

		static bool smethod_0(string string_0, ref IPAddress ipaddress_0)
		{
			return IPAddress.TryParse(string_0, out ipaddress_0);
		}

		static ConsoleKeyInfo smethod_1(bool bool_0)
		{
			return Console.ReadKey(bool_0);
		}

		static void smethod_2(int int_0)
		{
			Environment.Exit(int_0);
		}

		static TcpListener smethod_3(IPAddress ipaddress_0, int int_0)
		{
			return new TcpListener(ipaddress_0, int_0);
		}

		static void smethod_4(TcpListener tcpListener_0)
		{
			tcpListener_0.Start();
		}

		static Socket smethod_5(TcpListener tcpListener_0)
		{
			return tcpListener_0.Server;
		}

		static bool smethod_6(Socket socket_0)
		{
			return socket_0.IsBound;
		}

		static TaskFactory smethod_7()
		{
			return Task.Factory;
		}

		static Task smethod_8(TaskFactory taskFactory_0, Action action_0)
		{
			return taskFactory_0.StartNew(action_0);
		}

		static string smethod_9(Exception exception_0)
		{
			return exception_0.Message;
		}
	}
}
