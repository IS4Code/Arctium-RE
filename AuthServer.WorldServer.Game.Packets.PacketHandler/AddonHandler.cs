using AuthServer.Network;
using Framework.Constants.Misc;
using Framework.Constants.Net;
using Framework.Logging;
using Framework.Network.Packets;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace AuthServer.WorldServer.Game.Packets.PacketHandler
{
	public class AddonHandler
	{
		private static byte[] addonPublicKey;

		private static byte[] pubKeyOrder;

		public static void HandleAddonInfo(byte[] addonData, WorldClass session, WorldClass2 session2)
		{
			PacketWriter packetWriter = new PacketWriter(ServerMessage.AddonInfo, true);
			while (true)
			{
				IL_372:
				uint arg_304_0 = 1809991266u;
				while (true)
				{
					uint num;
					switch ((num = (arg_304_0 ^ 465668698u)) % 24u)
					{
					case 0u:
					{
						bool flag;
						Log.Message(LogType.Debug, Module.smethod_34<string>(1433819748u), new object[]
						{
							flag
						});
						uint num2;
						Log.Message(LogType.Debug, Module.smethod_35<string>(3521479446u), new object[]
						{
							num2
						});
						arg_304_0 = (num * 3803766880u ^ 310157591u);
						continue;
					}
					case 1u:
					{
						bool flag;
						BitPack bitPack;
						bitPack.Write<bool>(flag);
						bitPack.Write<bool>(true);
						arg_304_0 = (num * 2564976232u ^ 4098056120u);
						continue;
					}
					case 2u:
						session2.Send(ref packetWriter);
						arg_304_0 = (num * 854072662u ^ 909947967u);
						continue;
					case 3u:
						AddonHandler.smethod_0(packetWriter, AddonHandler.addonPublicKey);
						arg_304_0 = 1787484475u;
						continue;
					case 4u:
						session.Send(ref packetWriter);
						arg_304_0 = 1721024912u;
						continue;
					case 5u:
					{
						packetWriter.WriteInt32(0);
						int num3 = 0;
						arg_304_0 = (num * 2826608521u ^ 4236980803u);
						continue;
					}
					case 6u:
					{
						bool flag = true;
						arg_304_0 = (num * 3186595720u ^ 2676385765u);
						continue;
					}
					case 7u:
					{
						PacketReader packetReader;
						uint num2 = packetReader.Read<uint>();
						arg_304_0 = (num * 4197325555u ^ 895042553u);
						continue;
					}
					case 8u:
					{
						BitPack bitPack = new BitPack(packetWriter, 0uL, 0uL, 0uL, 0uL);
						PacketReader packetReader = new PacketReader(addonData, false, true);
						int num4 = packetReader.Read<int>();
						arg_304_0 = (num * 2378964428u ^ 2574027569u);
						continue;
					}
					case 9u:
						return;
					case 11u:
						packetWriter.WriteUInt32(0u);
						arg_304_0 = (num * 3130896976u ^ 2394918073u);
						continue;
					case 12u:
					{
						int num3;
						int num4;
						arg_304_0 = ((num3 >= num4) ? 1751666612u : 1552554250u);
						continue;
					}
					case 13u:
					{
						uint num5;
						Log.Message(LogType.Debug, Module.smethod_35<string>(3521479446u), new object[]
						{
							num5
						});
						packetWriter.WriteUInt8(2);
						arg_304_0 = (num * 2886261538u ^ 754012465u);
						continue;
					}
					case 14u:
						arg_304_0 = (((session2 != null) ? 3483294810u : 2624109236u) ^ num * 2840857279u);
						continue;
					case 15u:
						packetWriter.WriteUInt8(1);
						arg_304_0 = (num * 396774567u ^ 3621888192u);
						continue;
					case 16u:
					{
						PacketReader packetReader;
						string text = packetReader.ReadCString();
						bool flag = !packetReader.Read<bool>();
						arg_304_0 = 37866661u;
						continue;
					}
					case 17u:
					{
						int num3;
						num3++;
						arg_304_0 = (num * 2650975885u ^ 450296731u);
						continue;
					}
					case 18u:
					{
						BitPack bitPack;
						bitPack.Write<bool>(false);
						arg_304_0 = (num * 4029069879u ^ 4124995232u);
						continue;
					}
					case 19u:
					{
						int num4;
						packetWriter.WriteInt32(num4);
						arg_304_0 = (num * 3154899402u ^ 71122105u);
						continue;
					}
					case 20u:
					{
						BitPack bitPack;
						bitPack.Flush();
						bool flag;
						arg_304_0 = ((flag ? 488058857u : 1913203301u) ^ num * 1804616717u);
						continue;
					}
					case 21u:
						goto IL_372;
					case 22u:
					{
						PacketReader packetReader;
						uint num5 = packetReader.Read<uint>();
						bool flag;
						arg_304_0 = ((flag ? 1009495839u : 1036313990u) ^ num * 1645478371u);
						continue;
					}
					case 23u:
					{
						string text;
						Log.Message(LogType.Debug, Module.smethod_35<string>(877436003u), new object[]
						{
							text
						});
						arg_304_0 = 1826827818u;
						continue;
					}
					}
					goto Block_5;
				}
			}
			Block_5:;
		}

		static AddonHandler()
		{
			// Note: this type is marked as 'beforefieldinit'.
			byte[] expr_0A = new byte[256];
			AddonHandler.smethod_1(expr_0A, fieldof(<PrivateImplementationDetails>.C4102E2A032C6E4B4298689D7A09DB08D3D808FA).FieldHandle);
			AddonHandler.addonPublicKey = expr_0A;
			byte[] expr_24 = new byte[256];
			AddonHandler.smethod_1(expr_24, fieldof(<PrivateImplementationDetails>.struct11_0).FieldHandle);
			AddonHandler.pubKeyOrder = expr_24;
		}

		static void smethod_0(BinaryWriter binaryWriter_0, byte[] byte_0)
		{
			binaryWriter_0.Write(byte_0);
		}

		static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}
}
