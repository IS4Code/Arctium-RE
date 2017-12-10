using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Framework.Serialization
{
	public class Json
	{
		public static string CreateString<T>(T dataObject)
		{
			return Json.smethod_1(Json.smethod_0(), Json.CreateArray<T>(dataObject));
		}

		public static byte[] CreateArray<T>(T dataObject)
		{
			XmlObjectSerializer arg_1C_0 = Json.smethod_3(Json.smethod_2(typeof(T).TypeHandle));
			MemoryStream memoryStream = Json.smethod_4();
			Json.smethod_5(arg_1C_0, memoryStream, dataObject);
			return Json.smethod_6(memoryStream);
		}

		public static T CreateObject<T>(string jsonData)
		{
			return Json.CreateObject<T>(Json.smethod_7(Json.smethod_0(), jsonData));
		}

		public static T CreateObject<T>(byte[] jsonData)
		{
			return Json.CreateObject<T>(Json.smethod_8(jsonData));
		}

		public static T CreateObject<T>(Stream jsonData)
		{
			DataContractJsonSerializer xmlObjectSerializer_ = Json.smethod_3(Json.smethod_2(typeof(T).TypeHandle));
			T result;
			try
			{
				result = (T)((object)Json.smethod_9(xmlObjectSerializer_, jsonData));
			}
			catch (Exception)
			{
				T t;
				while (true)
				{
					IL_56:
					uint arg_27_0 = 186826059u;
					while (true)
					{
						uint num;
						switch ((num = (arg_27_0 ^ 223170181u)) % 3u)
						{
						case 0u:
							goto IL_56;
						case 2u:
							t = default(T);
							arg_27_0 = (num * 4187417331u ^ 2263809355u);
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				result = t;
			}
			return result;
		}

		static Encoding smethod_0()
		{
			return Encoding.UTF8;
		}

		static string smethod_1(Encoding encoding_0, byte[] byte_0)
		{
			return encoding_0.GetString(byte_0);
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static DataContractJsonSerializer smethod_3(Type type_0)
		{
			return new DataContractJsonSerializer(type_0);
		}

		static MemoryStream smethod_4()
		{
			return new MemoryStream();
		}

		static void smethod_5(XmlObjectSerializer xmlObjectSerializer_0, Stream stream_0, object object_0)
		{
			xmlObjectSerializer_0.WriteObject(stream_0, object_0);
		}

		static byte[] smethod_6(MemoryStream memoryStream_0)
		{
			return memoryStream_0.ToArray();
		}

		static byte[] smethod_7(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static MemoryStream smethod_8(byte[] byte_0)
		{
			return new MemoryStream(byte_0);
		}

		static object smethod_9(XmlObjectSerializer xmlObjectSerializer_0, Stream stream_0)
		{
			return xmlObjectSerializer_0.ReadObject(stream_0);
		}
	}
}
