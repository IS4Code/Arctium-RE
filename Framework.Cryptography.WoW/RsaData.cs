using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Framework.Cryptography.WoW
{
	public class RsaData
	{
		public RSAParameters RsaParams;

		public RsaData(int keySize = 4096)
		{
			while (true)
			{
				IL_200:
				uint arg_1C7_0 = 1002716060u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1C7_0 ^ 1205183536u)) % 11u)
					{
					case 1u:
					{
						RSACryptoServiceProvider rSACryptoServiceProvider = null;
						arg_1C7_0 = (num * 713026611u ^ 506908512u);
						continue;
					}
					case 2u:
						this.RsaParams.Modulus = this.RsaParams.Modulus.Reverse<byte>().ToArray<byte>();
						arg_1C7_0 = (num * 2525738492u ^ 3687538248u);
						continue;
					case 3u:
						RsaData.smethod_0(false);
						arg_1C7_0 = (num * 3731004226u ^ 2956488030u);
						continue;
					case 4u:
						this.RsaParams.P = this.RsaParams.P.Reverse<byte>().ToArray<byte>();
						arg_1C7_0 = (num * 1033657867u ^ 3740220601u);
						continue;
					case 5u:
					{
						RSACryptoServiceProvider rSACryptoServiceProvider;
						this.RsaParams = RsaData.smethod_3(rSACryptoServiceProvider, true);
						arg_1C7_0 = (num * 2199710247u ^ 2215492508u);
						continue;
					}
					case 6u:
						goto IL_200;
					case 7u:
						this.RsaParams.D = this.RsaParams.D.Reverse<byte>().ToArray<byte>();
						arg_1C7_0 = (num * 1816969130u ^ 1094325837u);
						continue;
					case 8u:
						this.RsaParams.Q = this.RsaParams.Q.Reverse<byte>().ToArray<byte>();
						arg_1C7_0 = (num * 4187008596u ^ 2383157349u);
						continue;
					case 9u:
						this.RsaParams.DP = this.RsaParams.DP.Reverse<byte>().ToArray<byte>();
						this.RsaParams.DQ = this.RsaParams.DQ.Reverse<byte>().ToArray<byte>();
						this.RsaParams.Exponent = this.RsaParams.Exponent.Reverse<byte>().ToArray<byte>();
						this.RsaParams.InverseQ = this.RsaParams.InverseQ.Reverse<byte>().ToArray<byte>();
						arg_1C7_0 = (num * 1597038983u ^ 1302256598u);
						continue;
					case 10u:
					{
						RSACryptoServiceProvider rSACryptoServiceProvider = RsaData.smethod_1(keySize);
						RsaData.smethod_2(rSACryptoServiceProvider, false);
						arg_1C7_0 = (num * 4124139865u ^ 3038071029u);
						continue;
					}
					}
					return;
				}
			}
		}

		private void WritePublicByteArray(ref StringBuilder sb, string name, byte[] data)
		{
			RsaData.smethod_4(sb, Module.smethod_33<string>(1101739191u), name);
			int num = 0;
			while (true)
			{
				IL_119:
				uint arg_E8_0 = 1108752587u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E8_0 ^ 487924337u)) % 9u)
					{
					case 0u:
						RsaData.smethod_6(sb, RsaData.smethod_5(Module.smethod_37<string>(785053536u), data[num]));
						arg_E8_0 = 1368211678u;
						continue;
					case 1u:
						arg_E8_0 = (num2 * 2447526073u ^ 1700002614u);
						continue;
					case 2u:
						RsaData.smethod_6(sb, RsaData.smethod_5(Module.smethod_35<string>(504568496u), data[num]));
						arg_E8_0 = (num2 * 2255774017u ^ 1823880514u);
						continue;
					case 3u:
						RsaData.smethod_7(sb);
						arg_E8_0 = (num2 * 3951439401u ^ 3110322468u);
						continue;
					case 4u:
						goto IL_119;
					case 6u:
						num++;
						arg_E8_0 = 530930524u;
						continue;
					case 7u:
						arg_E8_0 = ((num == data.Length - 1) ? 677679341u : 968760102u);
						continue;
					case 8u:
						arg_E8_0 = ((num < data.Length) ? 585820464u : 370895953u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteRSAParamsToFile(string file)
		{
			StreamWriter streamWriter = RsaData.smethod_9(RsaData.smethod_8(file, FileMode.Append, FileAccess.Write));
			try
			{
				StringBuilder stringBuilder = RsaData.smethod_10();
				RsaData.smethod_11(stringBuilder, Module.smethod_35<string>(2980812616u));
				while (true)
				{
					IL_215:
					uint arg_1DC_0 = 2660740231u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1DC_0 ^ 2343539775u)) % 11u)
						{
						case 0u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_34<string>(3759193544u), this.RsaParams.Modulus);
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_35<string>(2603051650u), this.RsaParams.P);
							arg_1DC_0 = (num * 2314009292u ^ 2798169866u);
							continue;
						case 1u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_36<string>(3595999631u), this.RsaParams.DQ);
							arg_1DC_0 = (num * 1905519383u ^ 3451028897u);
							continue;
						case 2u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_36<string>(2302295288u), this.RsaParams.InverseQ);
							arg_1DC_0 = (num * 3514015804u ^ 328205161u);
							continue;
						case 3u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_33<string>(500883625u), this.RsaParams.Q);
							RsaData.smethod_11(stringBuilder, Module.smethod_36<string>(1763956934u));
							arg_1DC_0 = (num * 1093455388u ^ 2412630581u);
							continue;
						case 4u:
							RsaData.smethod_11(stringBuilder, Module.smethod_36<string>(325567501u));
							arg_1DC_0 = (num * 1680973235u ^ 4159792120u);
							continue;
						case 5u:
							goto IL_215;
						case 6u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_37<string>(1281746625u), this.RsaParams.Exponent);
							arg_1DC_0 = (num * 2814766445u ^ 867682328u);
							continue;
						case 7u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_33<string>(1529783234u), this.RsaParams.DP);
							arg_1DC_0 = (num * 3044007253u ^ 3248738298u);
							continue;
						case 8u:
							RsaData.smethod_13(streamWriter, RsaData.smethod_12(stringBuilder));
							arg_1DC_0 = (num * 1302357578u ^ 81819689u);
							continue;
						case 10u:
							this.WritePublicByteArray(ref stringBuilder, Module.smethod_34<string>(495328980u), this.RsaParams.D);
							arg_1DC_0 = (num * 692187761u ^ 2461323819u);
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			finally
			{
				if (streamWriter != null)
				{
					while (true)
					{
						IL_253:
						uint arg_23B_0 = 3085176007u;
						while (true)
						{
							uint num;
							switch ((num = (arg_23B_0 ^ 2343539775u)) % 3u)
							{
							case 0u:
								goto IL_253;
							case 1u:
								RsaData.smethod_14(streamWriter);
								arg_23B_0 = (num * 4268890230u ^ 3143724438u);
								continue;
							}
							goto Block_6;
						}
					}
					Block_6:;
				}
			}
			this.RsaParams = default(RSAParameters);
		}

		static void smethod_0(bool bool_0)
		{
			RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
		}

		static RSACryptoServiceProvider smethod_1(int int_0)
		{
			return new RSACryptoServiceProvider(int_0);
		}

		static void smethod_2(RSACryptoServiceProvider rsacryptoServiceProvider_0, bool bool_0)
		{
			rsacryptoServiceProvider_0.PersistKeyInCsp = bool_0;
		}

		static RSAParameters smethod_3(RSA rsa_0, bool bool_0)
		{
			return rsa_0.ExportParameters(bool_0);
		}

		static StringBuilder smethod_4(StringBuilder stringBuilder_0, string string_0, object object_0)
		{
			return stringBuilder_0.AppendFormat(string_0, object_0);
		}

		static string smethod_5(string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}

		static StringBuilder smethod_6(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.Append(string_0);
		}

		static StringBuilder smethod_7(StringBuilder stringBuilder_0)
		{
			return stringBuilder_0.AppendLine();
		}

		static FileStream smethod_8(string string_0, FileMode fileMode_0, FileAccess fileAccess_0)
		{
			return new FileStream(string_0, fileMode_0, fileAccess_0);
		}

		static StreamWriter smethod_9(Stream stream_0)
		{
			return new StreamWriter(stream_0);
		}

		static StringBuilder smethod_10()
		{
			return new StringBuilder();
		}

		static StringBuilder smethod_11(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.AppendLine(string_0);
		}

		static string smethod_12(object object_0)
		{
			return object_0.ToString();
		}

		static void smethod_13(TextWriter textWriter_0, string string_0)
		{
			textWriter_0.WriteLine(string_0);
		}

		static void smethod_14(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}
}
