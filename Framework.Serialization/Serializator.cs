using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Framework.Serialization
{
	public class Serializator
	{
		public static void Save<T>(List<T> charList, string file)
		{
			FileStream fileStream = Serializator.smethod_0(file, FileMode.Create);
			try
			{
				Serializator.smethod_2(Serializator.smethod_1(), fileStream, charList);
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_4B:
						uint arg_33_0 = 804601919u;
						while (true)
						{
							uint num;
							switch ((num = (arg_33_0 ^ 1403878915u)) % 3u)
							{
							case 0u:
								goto IL_4B;
							case 1u:
								Serializator.smethod_3(fileStream);
								arg_33_0 = (num * 4098417610u ^ 1804271180u);
								continue;
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
			}
		}

		public static void Save2<T, T2>(Dictionary<T, T2> dic, string file)
		{
			FileStream fileStream = Serializator.smethod_0(file, FileMode.Create);
			try
			{
				Serializator.smethod_2(Serializator.smethod_1(), fileStream, dic);
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_4B:
						uint arg_33_0 = 2703141299u;
						while (true)
						{
							uint num;
							switch ((num = (arg_33_0 ^ 2511251952u)) % 3u)
							{
							case 1u:
								Serializator.smethod_3(fileStream);
								arg_33_0 = (num * 3945790786u ^ 4177737970u);
								continue;
							case 2u:
								goto IL_4B;
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
			}
		}

		public static List<T> Get<T>(string file)
		{
			if (!Serializator.smethod_4(file))
			{
				return null;
			}
			FileStream fileStream = Serializator.smethod_0(file, FileMode.Open);
			List<T> result;
			try
			{
				result = (List<T>)Serializator.smethod_5(Serializator.smethod_1(), fileStream);
			}
			catch
			{
				result = null;
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_65:
						uint arg_4D_0 = 1696969754u;
						while (true)
						{
							uint num;
							switch ((num = (arg_4D_0 ^ 2131503219u)) % 3u)
							{
							case 0u:
								goto IL_65;
							case 1u:
								Serializator.smethod_3(fileStream);
								arg_4D_0 = (num * 3729924721u ^ 992887841u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			return result;
		}

		public static Dictionary<T, T2> Get2<T, T2>(string file)
		{
			if (!Serializator.smethod_4(file))
			{
				return null;
			}
			FileStream fileStream = Serializator.smethod_0(file, FileMode.Open);
			Dictionary<T, T2> result;
			try
			{
				result = (Dictionary<T, T2>)Serializator.smethod_5(Serializator.smethod_1(), fileStream);
			}
			catch
			{
				while (true)
				{
					IL_5C:
					uint arg_33_0 = 2332307995u;
					while (true)
					{
						uint num;
						switch ((num = (arg_33_0 ^ 2725480770u)) % 3u)
						{
						case 1u:
							result = null;
							arg_33_0 = (num * 3158769671u ^ 3855982817u);
							continue;
						case 2u:
							goto IL_5C;
						}
						goto Block_6;
					}
				}
				Block_6:;
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_9A:
						uint arg_82_0 = 3298939252u;
						while (true)
						{
							uint num;
							switch ((num = (arg_82_0 ^ 2725480770u)) % 3u)
							{
							case 1u:
								Serializator.smethod_3(fileStream);
								arg_82_0 = (num * 2435844654u ^ 983069321u);
								continue;
							case 2u:
								goto IL_9A;
							}
							goto Block_9;
						}
					}
					Block_9:;
				}
			}
			return result;
		}

		static FileStream smethod_0(string string_0, FileMode fileMode_0)
		{
			return new FileStream(string_0, fileMode_0);
		}

		static BinaryFormatter smethod_1()
		{
			return new BinaryFormatter();
		}

		static void smethod_2(BinaryFormatter binaryFormatter_0, Stream stream_0, object object_0)
		{
			binaryFormatter_0.Serialize(stream_0, object_0);
		}

		static void smethod_3(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static bool smethod_4(string string_0)
		{
			return File.Exists(string_0);
		}

		static object smethod_5(BinaryFormatter binaryFormatter_0, Stream stream_0)
		{
			return binaryFormatter_0.Deserialize(stream_0);
		}
	}
}
