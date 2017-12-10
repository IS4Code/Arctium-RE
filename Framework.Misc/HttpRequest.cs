using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Framework.Misc
{
	public class HttpRequest
	{
		public static HttpHeader Parse(byte[] data)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			HttpHeader httpHeader;
			while (true)
			{
				IL_3A:
				uint arg_21_0 = 3306270342u;
				while (true)
				{
					uint num;
					switch ((num = (arg_21_0 ^ 2399452373u)) % 3u)
					{
					case 1u:
						httpHeader = new HttpHeader();
						arg_21_0 = (num * 2817185367u ^ 950298830u);
						continue;
					case 2u:
						goto IL_3A;
					}
					goto Block_1;
				}
			}
			Block_1:
			StreamReader streamReader = HttpRequest.smethod_1(HttpRequest.smethod_0(data));
			try
			{
				string[] array = HttpRequest.smethod_3(HttpRequest.smethod_2(streamReader), new string[]
				{
					Module.smethod_36<string>(2793817990u)
				}, StringSplitOptions.RemoveEmptyEntries);
				dictionary.Add(Module.smethod_36<string>(4166278524u), array[0]);
				while (true)
				{
					IL_2F0:
					uint arg_2A2_0 = 3324084926u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2A2_0 ^ 2399452373u)) % 16u)
						{
						case 0u:
							dictionary.Add(HttpRequest.smethod_5(HttpRequest.smethod_4(array[0], Module.smethod_34<string>(3401163952u), "")), array[1]);
							arg_2A2_0 = (num * 476152534u ^ 4072731649u);
							continue;
						case 1u:
							dictionary.Add(HttpRequest.smethod_5(HttpRequest.smethod_4(array[0], Module.smethod_37<string>(1807587611u), "")), __c__DisplayClass0_.val);
							arg_2A2_0 = (num * 3971791676u ^ 413243399u);
							continue;
						case 2u:
							dictionary.Add(Module.smethod_35<string>(2307915410u), array[2]);
							arg_2A2_0 = (num * 1182890423u ^ 4235378950u);
							continue;
						case 3u:
							arg_2A2_0 = (((array.Length != 2) ? 855930612u : 387368386u) ^ num * 930194861u);
							continue;
						case 4u:
							arg_2A2_0 = (num * 1032400525u ^ 950737695u);
							continue;
						case 5u:
							goto IL_2F0;
						case 6u:
							arg_2A2_0 = ((array.Length > 2) ? 3461943362u : 3679532412u);
							continue;
						case 7u:
						{
							string val = "";
							arg_2A2_0 = (num * 3808812237u ^ 3319968580u);
							continue;
						}
						case 9u:
						{
							string value = HttpRequest.smethod_2(streamReader);
							arg_2A2_0 = 3047714249u;
							continue;
						}
						case 10u:
							from s in array.Skip(1)
							select __c__DisplayClass0_.val = HttpRequest.__c__DisplayClass0_0.smethod_0(__c__DisplayClass0_.val, s);
							arg_2A2_0 = (num * 4171598521u ^ 1227765102u);
							continue;
						case 11u:
							dictionary.Add(Module.smethod_35<string>(168686531u), array[1]);
							arg_2A2_0 = (num * 1451970874u ^ 4272024969u);
							continue;
						case 12u:
						{
							string value;
							dictionary.Add(Module.smethod_37<string>(2538023825u), value);
							arg_2A2_0 = (num * 2805342277u ^ 1441398903u);
							continue;
						}
						case 13u:
							arg_2A2_0 = (num * 3001626507u ^ 3895757572u);
							continue;
						case 14u:
							arg_2A2_0 = ((!HttpRequest.smethod_6(streamReader)) ? 3016499402u : 3543724653u);
							continue;
						case 15u:
							array = HttpRequest.smethod_3(HttpRequest.smethod_2(streamReader), new string[]
							{
								Module.smethod_37<string>(2625673813u)
							}, StringSplitOptions.RemoveEmptyEntries);
							arg_2A2_0 = 2794843318u;
							continue;
						}
						goto Block_11;
					}
				}
				Block_11:;
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_330:
						uint arg_317_0 = 3947859753u;
						while (true)
						{
							uint num;
							switch ((num = (arg_317_0 ^ 2399452373u)) % 3u)
							{
							case 0u:
								goto IL_330;
							case 1u:
								HttpRequest.smethod_7(streamReader);
								arg_317_0 = (num * 3360653210u ^ 620005523u);
								continue;
							}
							goto Block_14;
						}
					}
					Block_14:;
				}
			}
			PropertyInfo[] array2 = HttpRequest.smethod_8(typeof(HttpHeader).TypeHandle).method_0();
			while (true)
			{
				IL_4BC:
				uint arg_482_0 = 4012525880u;
				while (true)
				{
					uint num;
					switch ((num = (arg_482_0 ^ 2399452373u)) % 11u)
					{
					case 1u:
					{
						PropertyInfo propertyInfo;
						object object_;
						HttpRequest.smethod_14(propertyInfo, httpHeader, HttpRequest.smethod_13(object_, HttpRequest.smethod_10(propertyInfo)));
						arg_482_0 = 4111537041u;
						continue;
					}
					case 2u:
						arg_482_0 = (num * 3971535260u ^ 1415198776u);
						continue;
					case 3u:
					{
						PropertyInfo propertyInfo;
						object object_;
						HttpRequest.smethod_14(propertyInfo, httpHeader, HttpRequest.smethod_13(HttpRequest.smethod_12(object_), HttpRequest.smethod_10(propertyInfo)));
						arg_482_0 = (num * 3214644057u ^ 2517217410u);
						continue;
					}
					case 4u:
						arg_482_0 = (num * 2530784154u ^ 4106248223u);
						continue;
					case 5u:
					{
						int num2;
						PropertyInfo propertyInfo = array2[num2];
						object object_ = null;
						arg_482_0 = (dictionary.TryGetValue(HttpRequest.smethod_5(HttpRequest.smethod_9(propertyInfo)), out object_) ? 2568737180u : 4111537041u);
						continue;
					}
					case 6u:
					{
						int num2;
						num2++;
						arg_482_0 = 3992009476u;
						continue;
					}
					case 7u:
					{
						int num2 = 0;
						arg_482_0 = (num * 1310724303u ^ 1775278383u);
						continue;
					}
					case 8u:
					{
						PropertyInfo propertyInfo;
						arg_482_0 = (((!HttpRequest.smethod_11(HttpRequest.smethod_10(propertyInfo), HttpRequest.smethod_8(typeof(int).TypeHandle))) ? 674557239u : 1071341423u) ^ num * 3742317054u);
						continue;
					}
					case 9u:
					{
						int num2;
						arg_482_0 = ((num2 >= array2.Length) ? 2637554276u : 2694170979u);
						continue;
					}
					case 10u:
						goto IL_4BC;
					}
					return httpHeader;
				}
			}
			return httpHeader;
		}

		static MemoryStream smethod_0(byte[] byte_0)
		{
			return new MemoryStream(byte_0);
		}

		static StreamReader smethod_1(Stream stream_0)
		{
			return new StreamReader(stream_0);
		}

		static string smethod_2(TextReader textReader_0)
		{
			return textReader_0.ReadLine();
		}

		static string[] smethod_3(string string_0, string[] string_1, StringSplitOptions stringSplitOptions_0)
		{
			return string_0.Split(string_1, stringSplitOptions_0);
		}

		static string smethod_4(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static string smethod_5(string string_0)
		{
			return string_0.ToLower();
		}

		static bool smethod_6(StreamReader streamReader_0)
		{
			return streamReader_0.EndOfStream;
		}

		static void smethod_7(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		PropertyInfo[] method_0()
		{
			return base.GetProperties();
		}

		static string smethod_9(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static Type smethod_10(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.PropertyType;
		}

		static bool smethod_11(Type type_0, Type type_1)
		{
			return type_0 == type_1;
		}

		static int smethod_12(object object_0)
		{
			return Convert.ToInt32(object_0);
		}

		static object smethod_13(object object_0, Type type_0)
		{
			return Convert.ChangeType(object_0, type_0);
		}

		static void smethod_14(PropertyInfo propertyInfo_0, object object_0, object object_1)
		{
			propertyInfo_0.SetValue(object_0, object_1);
		}
	}
}
