using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Framework.Logging.IO
{
	public class LogWriter : IDisposable
	{
		private FileStream logStream;

		public string LogFile
		{
			get;
			set;
		}

		public LogWriter(string directory, string file)
		{
			this.LogFile = string.Format(Module.smethod_36<string>(4256782u), directory, DateTime.Now.ToString(Module.smethod_34<string>(1967451405u)), file);
			this.logStream = new FileStream(this.LogFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite, 4096, true);
		}

		[AsyncStateMachine(typeof(LogWriter.<Write>d__6))]
		public Task Write(string logMessage)
		{
			LogWriter.<Write>d__6 <Write>d__;
			<Write>d__.__4__this = this;
			while (true)
			{
				IL_86:
				uint arg_66_0 = 3441431780u;
				while (true)
				{
					uint num;
					switch ((num = (arg_66_0 ^ 3941022718u)) % 5u)
					{
					case 0u:
					{
						AsyncTaskMethodBuilder __t__builder = <Write>d__.__t__builder;
						arg_66_0 = (num * 4128570838u ^ 1090046890u);
						continue;
					}
					case 1u:
						<Write>d__.logMessage = logMessage;
						<Write>d__.__t__builder = AsyncTaskMethodBuilder.Create();
						<Write>d__.__1__state = -1;
						arg_66_0 = (num * 830523851u ^ 2357483913u);
						continue;
					case 2u:
					{
						AsyncTaskMethodBuilder __t__builder;
						__t__builder.Start<LogWriter.<Write>d__6>(ref <Write>d__);
						arg_66_0 = (num * 1718702455u ^ 1371248976u);
						continue;
					}
					case 4u:
						goto IL_86;
					}
					goto Block_1;
				}
			}
			Block_1:
			return <Write>d__.__t__builder.Task;
		}

		public void Dispose()
		{
			this.LogFile = "";
			LogWriter.smethod_0(this.logStream);
		}

		static void smethod_0(Stream stream_0)
		{
			stream_0.Dispose();
		}
	}
}
