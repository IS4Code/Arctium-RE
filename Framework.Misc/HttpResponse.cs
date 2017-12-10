using System;
using System.IO;
using System.Text;

namespace Framework.Misc
{
	public class HttpResponse
	{
		public static byte[] Create(HttpCode httpCode, HttpHeader header)
		{
			StringBuilder stringBuilder = HttpResponse.smethod_0();
			StringWriter stringWriter = HttpResponse.smethod_1(stringBuilder);
			try
			{
				HttpResponse.smethod_3(stringWriter, HttpResponse.smethod_2(Module.smethod_34<string>(793455672u), (int)httpCode, httpCode.ToString()));
				while (true)
				{
					IL_14D:
					uint arg_128_0 = 3463570091u;
					while (true)
					{
						uint num;
						switch ((num = (arg_128_0 ^ 3407657466u)) % 6u)
						{
						case 0u:
							goto IL_14D;
						case 1u:
						{
							string arg = DateTime.Now.ToUniversalTime().ToString(Module.smethod_35<string>(3442331584u));
							stringWriter.WriteLine(string.Format(Module.smethod_33<string>(2252403819u), arg));
							arg_128_0 = (num * 3193603854u ^ 2500099970u);
							continue;
						}
						case 3u:
							stringWriter.WriteLine();
							stringWriter.WriteLine(header.Content);
							arg_128_0 = (num * 2561694936u ^ 3069112476u);
							continue;
						case 4u:
							stringWriter.WriteLine(Module.smethod_34<string>(1984368261u));
							stringWriter.WriteLine(Module.smethod_34<string>(672055693u));
							arg_128_0 = (num * 3931759688u ^ 2273372317u);
							continue;
						case 5u:
							stringWriter.WriteLine(string.Format(Module.smethod_37<string>(609665147u), header.ContentLength));
							stringWriter.WriteLine(Module.smethod_35<string>(3987891873u));
							stringWriter.WriteLine(Module.smethod_34<string>(3147617483u));
							arg_128_0 = (num * 2465592752u ^ 1798369301u);
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			finally
			{
				if (stringWriter != null)
				{
					while (true)
					{
						IL_18D:
						uint arg_174_0 = 2977987066u;
						while (true)
						{
							uint num;
							switch ((num = (arg_174_0 ^ 3407657466u)) % 3u)
							{
							case 0u:
								goto IL_18D;
							case 2u:
								((IDisposable)stringWriter).Dispose();
								arg_174_0 = (num * 200705565u ^ 3116199384u);
								continue;
							}
							goto Block_6;
						}
					}
					Block_6:;
				}
			}
			return Encoding.UTF8.GetBytes(stringBuilder.ToString());
		}

		static StringBuilder smethod_0()
		{
			return new StringBuilder();
		}

		static StringWriter smethod_1(StringBuilder stringBuilder_0)
		{
			return new StringWriter(stringBuilder_0);
		}

		static string smethod_2(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		static void smethod_3(TextWriter textWriter_0, string string_0)
		{
			textWriter_0.WriteLine(string_0);
		}
	}
}
