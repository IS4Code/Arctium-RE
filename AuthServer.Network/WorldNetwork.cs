using Framework.Constants.Misc;
using Framework.Logging;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace AuthServer.Network
{
	public class WorldNetwork
	{
		public volatile bool listenSocket = true;

		private TcpListener listener;

		public bool Start(string host, int port)
		{
			bool result;
			try
			{
				this.listener = WorldNetwork.smethod_1(WorldNetwork.smethod_0(host), port);
				WorldNetwork.smethod_2(this.listener);
				result = true;
			}
			catch (Exception exception_)
			{
				while (true)
				{
					IL_87:
					uint arg_29_0 = 1724732895u;
					while (true)
					{
						uint num;
						switch ((num = (arg_29_0 ^ 215196056u)) % 4u)
						{
						case 0u:
							Log.Message();
							arg_29_0 = (num * 1376418211u ^ 469886417u);
							continue;
						case 2u:
							goto IL_87;
						case 3u:
							Log.Message(LogType.Error, Module.smethod_37<string>(2717862335u), new object[]
							{
								WorldNetwork.smethod_3(exception_)
							});
							arg_29_0 = (num * 946542784u ^ 1670786100u);
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:
				result = false;
			}
			return result;
		}

		public void AcceptConnectionThread()
		{
			WorldNetwork.smethod_5(WorldNetwork.smethod_4(new ThreadStart(this.AcceptConnection)));
		}

		[AsyncStateMachine(typeof(WorldNetwork.<AcceptConnection>d__4))]
		private void AcceptConnection()
		{
			WorldNetwork.<AcceptConnection>d__4 <AcceptConnection>d__;
			<AcceptConnection>d__.__4__this = this;
			while (true)
			{
				IL_94:
				uint arg_70_0 = 4102925469u;
				while (true)
				{
					uint num;
					switch ((num = (arg_70_0 ^ 2445955702u)) % 6u)
					{
					case 0u:
						<AcceptConnection>d__.__1__state = -1;
						arg_70_0 = (num * 3555178732u ^ 551048441u);
						continue;
					case 1u:
						<AcceptConnection>d__.__t__builder = AsyncVoidMethodBuilder.Create();
						arg_70_0 = (num * 4216505225u ^ 3917185513u);
						continue;
					case 2u:
					{
						AsyncVoidMethodBuilder __t__builder;
						__t__builder.Start<WorldNetwork.<AcceptConnection>d__4>(ref <AcceptConnection>d__);
						arg_70_0 = (num * 1497386464u ^ 1098818976u);
						continue;
					}
					case 3u:
					{
						AsyncVoidMethodBuilder __t__builder = <AcceptConnection>d__.__t__builder;
						arg_70_0 = (num * 3963560649u ^ 1801078611u);
						continue;
					}
					case 5u:
						goto IL_94;
					}
					return;
				}
			}
		}

		public void AcceptConnectionThread2()
		{
			WorldNetwork.smethod_5(WorldNetwork.smethod_4(new ThreadStart(this.AcceptConnection2)));
		}

		[AsyncStateMachine(typeof(WorldNetwork.<AcceptConnection2>d__6))]
		private void AcceptConnection2()
		{
			WorldNetwork.<AcceptConnection2>d__6 <AcceptConnection2>d__;
			<AcceptConnection2>d__.__4__this = this;
			<AcceptConnection2>d__.__t__builder = AsyncVoidMethodBuilder.Create();
			while (true)
			{
				IL_7E:
				uint arg_5E_0 = 2123606309u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5E_0 ^ 587440242u)) % 5u)
					{
					case 0u:
						goto IL_7E;
					case 2u:
					{
						AsyncVoidMethodBuilder __t__builder = <AcceptConnection2>d__.__t__builder;
						arg_5E_0 = (num * 995768624u ^ 917102891u);
						continue;
					}
					case 3u:
						<AcceptConnection2>d__.__1__state = -1;
						arg_5E_0 = (num * 2447264840u ^ 119976406u);
						continue;
					case 4u:
					{
						AsyncVoidMethodBuilder __t__builder;
						__t__builder.Start<WorldNetwork.<AcceptConnection2>d__6>(ref <AcceptConnection2>d__);
						arg_5E_0 = (num * 973801686u ^ 223050679u);
						continue;
					}
					}
					return;
				}
			}
		}

		static IPAddress smethod_0(string string_0)
		{
			return IPAddress.Parse(string_0);
		}

		static TcpListener smethod_1(IPAddress ipaddress_0, int int_0)
		{
			return new TcpListener(ipaddress_0, int_0);
		}

		static void smethod_2(TcpListener tcpListener_0)
		{
			tcpListener_0.Start();
		}

		static string smethod_3(Exception exception_0)
		{
			return exception_0.Message;
		}

		static Thread smethod_4(ThreadStart threadStart_0)
		{
			return new Thread(threadStart_0);
		}

		static void smethod_5(Thread thread_0)
		{
			thread_0.Start();
		}
	}
}
