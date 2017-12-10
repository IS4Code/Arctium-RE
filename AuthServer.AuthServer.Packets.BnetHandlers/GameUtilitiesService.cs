using AuthServer.AuthServer.Attributes;
using AuthServer.AuthServer.JsonObjects;
using AuthServer.Network;
using Bgs.Protocol;
using Bgs.Protocol.GameUtilities.V1;
using Framework.Constants.Net;
using Framework.Misc;
using Framework.Serialization;
using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace AuthServer.AuthServer.Packets.BnetHandlers
{
	[BnetService(BnetServiceHash.GameUtilitiesService)]
	public class GameUtilitiesService : BnetServiceBase
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameUtilitiesService.__c __9 = new GameUtilitiesService.__c();

			public static Func<int, byte> __9__0_0;

			internal byte HandleClientRequestb__0_0(int x)
			{
				return GameUtilitiesService.__c.smethod_0(x);
			}

			static byte smethod_0(int int_0)
			{
				return Convert.ToByte(int_0);
			}
		}

		[BnetServiceBase.BnetMethodAttribute(1u)]
		public static void HandleClientRequest(AuthSession session, ClientRequest clientRequest)
		{
			string name;
			ClientResponse clientResponse;
			if (GameUtilitiesService.smethod_0(clientRequest.Attribute[0].Name, Module.smethod_37<string>(1549087768u)))
			{
				IEnumerator<Bgs.Protocol.Attribute> enumerator = clientRequest.Attribute.GetEnumerator();
				try
				{
					while (true)
					{
						IL_156:
						uint arg_11E_0 = GameUtilitiesService.smethod_2(enumerator) ? 707215618u : 982195081u;
						while (true)
						{
							uint num;
							switch ((num = (arg_11E_0 ^ 1820510042u)) % 7u)
							{
							case 0u:
								arg_11E_0 = 707215618u;
								continue;
							case 1u:
								goto IL_156;
							case 2u:
							{
								Bgs.Protocol.Attribute current = enumerator.Current;
								arg_11E_0 = (GameUtilitiesService.smethod_0(current.Name, Module.smethod_35<string>(2108436570u)) ? 1292263614u : 39044470u);
								continue;
							}
							case 3u:
							{
								Bgs.Protocol.Attribute current;
								IEnumerable<int> arg_C7_0 = Json.CreateObject<RealmListTicketClientInformation>(GameUtilitiesService.smethod_1(current.Value.BlobValue.ToStringUtf8(), Module.smethod_34<string>(607107096u), "")).Info.Secret;
								Func<int, byte> arg_C7_1;
								if ((arg_C7_1 = GameUtilitiesService.__c.__9__0_0) == null)
								{
									arg_C7_1 = (GameUtilitiesService.__c.__9__0_0 = new Func<int, byte>(GameUtilitiesService.__c.__9.HandleClientRequestb__0_0));
								}
								Globals.Secret = arg_C7_0.Select(arg_C7_1).ToArray<byte>();
								arg_11E_0 = 1388634718u;
								continue;
							}
							case 4u:
								arg_11E_0 = (num * 3357184604u ^ 1408942728u);
								continue;
							case 6u:
							{
								Bgs.Protocol.Attribute current;
								GameUtilitiesService.smethod_0(current.Name, "");
								arg_11E_0 = 390289400u;
								continue;
							}
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_19C:
							uint arg_183_0 = 1000108845u;
							while (true)
							{
								uint num;
								switch ((num = (arg_183_0 ^ 1820510042u)) % 3u)
								{
								case 0u:
									goto IL_19C;
								case 2u:
									GameUtilitiesService.smethod_3(enumerator);
									arg_183_0 = (num * 2856457603u ^ 3035350054u);
									continue;
								}
								goto Block_14;
							}
						}
						Block_14:;
					}
				}
				name = Module.smethod_35<string>(1450915626u);
				clientResponse = new ClientResponse();
				goto IL_205;
			}
			goto IL_6F3;
			uint arg_682_0;
			while (true)
			{
				IL_67D:
				uint num;
				switch ((num = (arg_682_0 ^ 1820510042u)) % 21u)
				{
				case 0u:
				{
					ClientResponse message = new ClientResponse();
					arg_682_0 = (num * 1960178030u ^ 3375314732u);
					continue;
				}
				case 1u:
					clientResponse.Attribute.Add(new Bgs.Protocol.Attribute
					{
						Name = name,
						Value = new Variant
						{
							BlobValue = ByteString.CopyFromUtf8(Module.smethod_36<string>(2871343933u))
						}
					});
					session.Send(clientResponse);
					arg_682_0 = (num * 2849486171u ^ 3438062413u);
					continue;
				case 2u:
				{
					ClientResponse clientResponse2 = new ClientResponse();
					arg_682_0 = (num * 1708365464u ^ 846537027u);
					continue;
				}
				case 3u:
				{
					ClientResponse clientResponse3;
					clientResponse3.Attribute.Add(new Bgs.Protocol.Attribute
					{
						Name = Module.smethod_35<string>(1814716925u),
						Value = new Variant
						{
							BlobValue = ByteString.CopyFromUtf8(Module.smethod_34<string>(904052351u))
						}
					});
					RealmListServerIPAddresses realmListServerIPAddresses = new RealmListServerIPAddresses();
					arg_682_0 = (num * 1691718091u ^ 3467647916u);
					continue;
				}
				case 4u:
				{
					RealmListServerIPAddresses realmListServerIPAddresses;
					realmListServerIPAddresses.Families.Add(new Family
					{
						Id = 2,
						Addresses = new List<AuthServer.AuthServer.JsonObjects.Address>()
					});
					arg_682_0 = (num * 78695267u ^ 2554691107u);
					continue;
				}
				case 5u:
					arg_682_0 = (GameUtilitiesService.smethod_0(clientRequest.Attribute[0].Name, Module.smethod_33<string>(3445444445u)) ? 1552249222u : 2080562207u);
					continue;
				case 6u:
					return;
				case 7u:
				{
					ClientResponse clientResponse3;
					RealmListServerIPAddresses realmListServerIPAddresses;
					clientResponse3.Attribute.Add(new Bgs.Protocol.Attribute
					{
						Name = Module.smethod_35<string>(2074000899u),
						Value = new Variant
						{
							BlobValue = ByteString.CopyFrom(GameUtilitiesService.GetCompressedData(Module.smethod_35<string>(2339801210u), Json.CreateString<RealmListServerIPAddresses>(realmListServerIPAddresses)))
						}
					});
					clientResponse3.Attribute.Add(new Bgs.Protocol.Attribute
					{
						Name = Module.smethod_33<string>(2686709168u),
						Value = new Variant
						{
							BlobValue = ByteString.CopyFrom(Globals.JoinSecret)
						}
					});
					session.Send(clientResponse3);
					arg_682_0 = (num * 1149426949u ^ 1180628059u);
					continue;
				}
				case 8u:
				{
					ClientResponse clientResponse2;
					session.Send(clientResponse2);
					arg_682_0 = (num * 3033014184u ^ 922385703u);
					continue;
				}
				case 9u:
					return;
				case 10u:
				{
					RealmListServerIPAddresses realmListServerIPAddresses;
					realmListServerIPAddresses.Families = new List<Family>();
					arg_682_0 = (num * 3674508602u ^ 631681376u);
					continue;
				}
				case 11u:
				{
					ClientResponse clientResponse2;
					RealmListUpdates realmListUpdates;
					clientResponse2.Attribute.Add(new Bgs.Protocol.Attribute
					{
						Name = Module.smethod_33<string>(2409987499u),
						Value = new Variant
						{
							BlobValue = ByteString.CopyFrom(GameUtilitiesService.GetCompressedData(Module.smethod_36<string>(966958691u), Json.CreateString<RealmListUpdates>(realmListUpdates)))
						}
					});
					RealmCharacterCountList dataObject = new RealmCharacterCountList();
					clientResponse2.Attribute.Add(new Bgs.Protocol.Attribute
					{
						Name = Module.smethod_36<string>(4040564189u),
						Value = new Variant
						{
							BlobValue = ByteString.CopyFrom(GameUtilitiesService.GetCompressedData(Module.smethod_33<string>(2576241685u), Json.CreateString<RealmCharacterCountList>(dataObject)))
						}
					});
					arg_682_0 = (num * 716287039u ^ 3546797012u);
					continue;
				}
				case 12u:
				{
					RealmListUpdates realmListUpdates = new RealmListUpdates();
					realmListUpdates.Updates = new List<RealmListUpdate>
					{
						new RealmListUpdate
						{
							WowRealmAddress = 1u,
							Update = new Update
							{
								WowRealmAddress = 1,
								CfgTimezonesID = 2,
								PopulationState = 1,
								CfgCategoriesID = 1,
								Version = new ClientVersion
								{
									Major = 7,
									Minor = 1,
									Revision = 0,
									Build = 22996
								},
								CfgRealmsID = 1,
								Flags = 4,
								CfgConfigsID = 1,
								CfgLanguagesID = 1,
								Name = Module.smethod_36<string>(4208195762u)
							}
						}
					};
					arg_682_0 = (num * 2759149309u ^ 1324415408u);
					continue;
				}
				case 13u:
				{
					RealmListServerIPAddresses realmListServerIPAddresses;
					realmListServerIPAddresses.Families.Add(new Family
					{
						Id = 1,
						Addresses = new List<AuthServer.AuthServer.JsonObjects.Address>
						{
							new AuthServer.AuthServer.JsonObjects.Address
							{
								Ip = Module.smethod_33<string>(1362828071u),
								Port = 8085
							}
						}
					});
					arg_682_0 = (num * 2455873529u ^ 3627955475u);
					continue;
				}
				case 14u:
				{
					ClientResponse message;
					session.Send(message);
					arg_682_0 = (num * 1672891969u ^ 1215791913u);
					continue;
				}
				case 16u:
				{
					Globals.JoinSecret = new byte[0].GenerateRandomKey(32);
					SHA256Managed expr_226 = GameUtilitiesService.smethod_4();
					GameUtilitiesService.smethod_5(expr_226, Globals.Secret, 0, Globals.Secret.Length, Globals.Secret, 0);
					GameUtilitiesService.smethod_6(expr_226, Globals.JoinSecret, 0, Globals.JoinSecret.Length);
					Globals.SessionKey = GameUtilitiesService.smethod_7(expr_226);
					ClientResponse clientResponse3 = new ClientResponse();
					arg_682_0 = (num * 181368554u ^ 2569788186u);
					continue;
				}
				case 17u:
					goto IL_205;
				case 18u:
					return;
				case 19u:
					arg_682_0 = ((!GameUtilitiesService.smethod_0(clientRequest.Attribute[0].Name, Module.smethod_36<string>(2188320489u))) ? 1384141042u : 1913633765u);
					continue;
				case 20u:
					goto IL_6F3;
				}
				break;
			}
			return;
			IL_205:
			arg_682_0 = 513478610u;
			goto IL_67D;
			IL_6F3:
			arg_682_0 = ((!GameUtilitiesService.smethod_0(clientRequest.Attribute[0].Name, Module.smethod_35<string>(2192477891u))) ? 1776235731u : 1794780940u);
			goto IL_67D;
		}

		public static byte[] GetCompressedData(string name, string data)
		{
			byte[] expr_25 = GameUtilitiesService.smethod_10(GameUtilitiesService.smethod_8(), GameUtilitiesService.smethod_9(name, Module.smethod_35<string>(2164558557u), data, Module.smethod_37<string>(3157143760u)));
			byte[] second = GameUtilitiesService.Compress(expr_25, CompressionLevel.Fastest);
			IEnumerable<byte> second2 = GameUtilitiesService.smethod_11(GameUtilitiesService.Adler32_Default(expr_25)).Reverse<byte>();
			return GameUtilitiesService.smethod_12(expr_25.Length).Concat(new byte[]
			{
				120,
				156
			}).Concat(second).Concat(second2).ToArray<byte>();
		}

		public static uint Adler32_Default(byte[] data)
		{
			uint num = 1u;
			uint num3;
			while (true)
			{
				IL_A3:
				uint arg_7B_0 = 1102937597u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_7B_0 ^ 500557560u)) % 7u)
					{
					case 1u:
						num3 = 0u;
						arg_7B_0 = (num2 * 1616695776u ^ 4202125215u);
						continue;
					case 2u:
					{
						int num4;
						arg_7B_0 = ((num4 < data.Length) ? 1771880901u : 278308620u);
						continue;
					}
					case 3u:
					{
						int num4;
						num = (num + (uint)data[num4]) % 65521u;
						arg_7B_0 = 1663332107u;
						continue;
					}
					case 4u:
						goto IL_A3;
					case 5u:
					{
						int num4 = 0;
						arg_7B_0 = (num2 * 2756776724u ^ 4207301681u);
						continue;
					}
					case 6u:
					{
						num3 = (num3 + num) % 65521u;
						int num4;
						num4++;
						arg_7B_0 = (num2 * 3491861519u ^ 1026351232u);
						continue;
					}
					}
					goto Block_2;
				}
			}
			Block_2:
			return (num3 << 16) + num;
		}

		[BnetServiceBase.BnetMethodAttribute(10u)]
		public static void HandleGetAllValuesForAttributeRequest(AuthSession session, GetAllValuesForAttributeRequest getAllValuesForAttributeRequest)
		{
			if (GameUtilitiesService.smethod_0(getAllValuesForAttributeRequest.AttributeKey, Module.smethod_34<string>(1676619706u)))
			{
				while (true)
				{
					IL_99:
					uint arg_79_0 = 2982734585u;
					while (true)
					{
						uint num;
						switch ((num = (arg_79_0 ^ 4261002523u)) % 5u)
						{
						case 0u:
							goto IL_99;
						case 2u:
						{
							GetAllValuesForAttributeResponse getAllValuesForAttributeResponse;
							getAllValuesForAttributeResponse.AttributeValue.Add(new Variant
							{
								StringValue = Module.smethod_34<string>(3567087365u)
							});
							arg_79_0 = (num * 326043060u ^ 433382969u);
							continue;
						}
						case 3u:
						{
							GetAllValuesForAttributeResponse getAllValuesForAttributeResponse = new GetAllValuesForAttributeResponse();
							arg_79_0 = (num * 1354836642u ^ 4091919859u);
							continue;
						}
						case 4u:
						{
							GetAllValuesForAttributeResponse getAllValuesForAttributeResponse;
							session.Send(getAllValuesForAttributeResponse);
							arg_79_0 = (num * 122349368u ^ 2297805052u);
							continue;
						}
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		private static byte[] Compress(byte[] data, CompressionLevel level)
		{
			MemoryStream memoryStream = GameUtilitiesService.smethod_13();
			byte[] result;
			try
			{
				DeflateStream deflateStream = GameUtilitiesService.smethod_14(memoryStream, level);
				try
				{
					GameUtilitiesService.smethod_15(deflateStream, data, 0, data.Length);
					GameUtilitiesService.smethod_16(deflateStream);
				}
				finally
				{
					if (deflateStream != null)
					{
						while (true)
						{
							IL_56:
							uint arg_3E_0 = 3412742121u;
							while (true)
							{
								uint num;
								switch ((num = (arg_3E_0 ^ 3721170959u)) % 3u)
								{
								case 0u:
									goto IL_56;
								case 2u:
									GameUtilitiesService.smethod_3(deflateStream);
									arg_3E_0 = (num * 3870129308u ^ 1831973755u);
									continue;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
				result = GameUtilitiesService.smethod_17(memoryStream);
			}
			finally
			{
				if (memoryStream != null)
				{
					while (true)
					{
						IL_9C:
						uint arg_84_0 = 3135978255u;
						while (true)
						{
							uint num;
							switch ((num = (arg_84_0 ^ 3721170959u)) % 3u)
							{
							case 1u:
								GameUtilitiesService.smethod_3(memoryStream);
								arg_84_0 = (num * 2134525440u ^ 387129097u);
								continue;
							case 2u:
								goto IL_9C;
							}
							goto Block_10;
						}
					}
					Block_10:;
				}
			}
			return result;
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static string smethod_1(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		static bool smethod_2(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_3(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static SHA256Managed smethod_4()
		{
			return new SHA256Managed();
		}

		static int smethod_5(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
		{
			return hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
		}

		static byte[] smethod_6(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
		{
			return hashAlgorithm_0.TransformFinalBlock(byte_0, int_0, int_1);
		}

		static byte[] smethod_7(HashAlgorithm hashAlgorithm_0)
		{
			return hashAlgorithm_0.Hash;
		}

		static Encoding smethod_8()
		{
			return Encoding.UTF8;
		}

		static string smethod_9(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
		}

		static byte[] smethod_10(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static byte[] smethod_11(uint uint_0)
		{
			return BitConverter.GetBytes(uint_0);
		}

		static byte[] smethod_12(int int_0)
		{
			return BitConverter.GetBytes(int_0);
		}

		static MemoryStream smethod_13()
		{
			return new MemoryStream();
		}

		static DeflateStream smethod_14(Stream stream_0, CompressionLevel compressionLevel_0)
		{
			return new DeflateStream(stream_0, compressionLevel_0);
		}

		static void smethod_15(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		static void smethod_16(Stream stream_0)
		{
			stream_0.Flush();
		}

		static byte[] smethod_17(MemoryStream memoryStream_0)
		{
			return memoryStream_0.ToArray();
		}
	}
}
