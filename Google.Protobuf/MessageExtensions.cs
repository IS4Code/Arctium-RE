using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public static class MessageExtensions
	{
		public static void MergeFrom(this IMessage message, byte[] data)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_36<string>(123557471u));
			while (true)
			{
				IL_88:
				uint arg_68_0 = 3957484449u;
				while (true)
				{
					uint num;
					switch ((num = (arg_68_0 ^ 3942961502u)) % 5u)
					{
					case 1u:
						Preconditions.CheckNotNull<byte[]>(data, Module.smethod_33<string>(4183796496u));
						arg_68_0 = (num * 2194003209u ^ 3387356842u);
						continue;
					case 2u:
					{
						CodedInputStream codedInputStream;
						message.MergeFrom(codedInputStream);
						codedInputStream.CheckReadEndOfStreamTag();
						arg_68_0 = (num * 1632326612u ^ 1254292727u);
						continue;
					}
					case 3u:
					{
						CodedInputStream codedInputStream = new CodedInputStream(data);
						arg_68_0 = (num * 2361737144u ^ 3366543172u);
						continue;
					}
					case 4u:
						goto IL_88;
					}
					return;
				}
			}
		}

		public static void MergeFrom(this IMessage message, ByteString data)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_37<string>(1018619835u));
			while (true)
			{
				IL_88:
				uint arg_68_0 = 1294777110u;
				while (true)
				{
					uint num;
					switch ((num = (arg_68_0 ^ 774803952u)) % 5u)
					{
					case 1u:
					{
						CodedInputStream codedInputStream;
						message.MergeFrom(codedInputStream);
						codedInputStream.CheckReadEndOfStreamTag();
						arg_68_0 = (num * 1646138364u ^ 1655964701u);
						continue;
					}
					case 2u:
						goto IL_88;
					case 3u:
						Preconditions.CheckNotNull<ByteString>(data, Module.smethod_36<string>(1708537323u));
						arg_68_0 = (num * 205556053u ^ 3845813091u);
						continue;
					case 4u:
					{
						CodedInputStream codedInputStream = data.CreateCodedInput();
						arg_68_0 = (num * 2511744089u ^ 2886406153u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static void MergeFrom(this IMessage message, Stream input)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_35<string>(2616444679u));
			Preconditions.CheckNotNull<Stream>(input, Module.smethod_34<string>(3703866810u));
			CodedInputStream codedInputStream;
			while (true)
			{
				IL_5C:
				uint arg_44_0 = 1463404901u;
				while (true)
				{
					uint num;
					switch ((num = (arg_44_0 ^ 561544202u)) % 3u)
					{
					case 0u:
						goto IL_5C;
					case 1u:
						codedInputStream = new CodedInputStream(input);
						message.MergeFrom(codedInputStream);
						arg_44_0 = (num * 1287290389u ^ 4230433120u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			codedInputStream.CheckReadEndOfStreamTag();
		}

		public static void MergeDelimitedFrom(this IMessage message, Stream input)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_33<string>(879293356u));
			Preconditions.CheckNotNull<Stream>(input, Module.smethod_36<string>(1587331305u));
			int size;
			while (true)
			{
				IL_55:
				uint arg_3D_0 = 1352182406u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3D_0 ^ 864799055u)) % 3u)
					{
					case 0u:
						goto IL_55;
					case 1u:
						size = (int)CodedInputStream.ReadRawVarint32(input);
						arg_3D_0 = (num * 2731188668u ^ 3872850211u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			Stream input2 = new LimitedInputStream(input, size);
			message.MergeFrom(input2);
		}

		public static byte[] ToByteArray(this IMessage message)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_33<string>(879293356u));
			byte[] expr_1C = new byte[message.CalculateSize()];
			CodedOutputStream codedOutputStream = new CodedOutputStream(expr_1C);
			message.WriteTo(codedOutputStream);
			codedOutputStream.CheckNoSpaceLeft();
			return expr_1C;
		}

		public static void WriteTo(this IMessage message, Stream output)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_37<string>(1018619835u));
			Preconditions.CheckNotNull<Stream>(output, Module.smethod_34<string>(2188551970u));
			CodedOutputStream codedOutputStream = new CodedOutputStream(output);
			message.WriteTo(codedOutputStream);
			codedOutputStream.Flush();
		}

		public static void WriteDelimitedTo(this IMessage message, Stream output)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_37<string>(1018619835u));
			while (true)
			{
				IL_97:
				uint arg_77_0 = 836366938u;
				while (true)
				{
					uint num;
					switch ((num = (arg_77_0 ^ 1222686458u)) % 5u)
					{
					case 0u:
						goto IL_97;
					case 1u:
					{
						Preconditions.CheckNotNull<Stream>(output, Module.smethod_36<string>(1367025601u));
						CodedOutputStream codedOutputStream = new CodedOutputStream(output);
						arg_77_0 = (num * 2302164566u ^ 2110158721u);
						continue;
					}
					case 2u:
					{
						CodedOutputStream codedOutputStream;
						codedOutputStream.WriteRawVarint32((uint)message.CalculateSize());
						arg_77_0 = (num * 762481410u ^ 1229542845u);
						continue;
					}
					case 4u:
					{
						CodedOutputStream codedOutputStream;
						message.WriteTo(codedOutputStream);
						codedOutputStream.Flush();
						arg_77_0 = (num * 187669686u ^ 2466296953u);
						continue;
					}
					}
					return;
				}
			}
		}

		public static ByteString ToByteString(this IMessage message)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_35<string>(2616444679u));
			return ByteString.AttachBytes(message.ToByteArray());
		}
	}
}
