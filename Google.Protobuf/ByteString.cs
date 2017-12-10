using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class ByteString : IEnumerable, IEnumerable<byte>, IEquatable<ByteString>
	{
		internal static class Unsafe
		{
			internal static ByteString FromBytes(byte[] bytes)
			{
				return new ByteString(bytes);
			}

			internal static byte[] GetBuffer(ByteString bytes)
			{
				return bytes.bytes;
			}
		}

		private static readonly ByteString empty = new ByteString(new byte[0]);

		private readonly byte[] bytes;

		public static ByteString Empty
		{
			get
			{
				return ByteString.empty;
			}
		}

		public int Length
		{
			get
			{
				return this.bytes.Length;
			}
		}

		public bool IsEmpty
		{
			get
			{
				return this.Length == 0;
			}
		}

		public byte this[int index]
		{
			get
			{
				return this.bytes[index];
			}
		}

		internal static ByteString AttachBytes(byte[] bytes)
		{
			return new ByteString(bytes);
		}

		private ByteString(byte[] bytes)
		{
			this.bytes = bytes;
		}

		public byte[] ToByteArray()
		{
			return (byte[])ByteString.smethod_0(this.bytes);
		}

		public string ToBase64()
		{
			return ByteString.smethod_1(this.bytes);
		}

		public static ByteString FromBase64(string bytes)
		{
			if (!ByteString.smethod_2(bytes, ""))
			{
				return new ByteString(ByteString.smethod_3(bytes));
			}
			return ByteString.Empty;
		}

		public static ByteString CopyFrom(params byte[] bytes)
		{
			return new ByteString((byte[])ByteString.smethod_0(bytes));
		}

		public static ByteString CopyFrom(byte[] bytes, int offset, int count)
		{
			byte[] dst = new byte[count];
			ByteArray.Copy(bytes, offset, dst, 0, count);
			return new ByteString(dst);
		}

		public static ByteString CopyFrom(string text, Encoding encoding)
		{
			return new ByteString(ByteString.smethod_4(encoding, text));
		}

		public static ByteString CopyFromUtf8(string text)
		{
			return ByteString.CopyFrom(text, ByteString.smethod_5());
		}

		public string ToString(Encoding encoding)
		{
			return ByteString.smethod_6(encoding, this.bytes, 0, this.bytes.Length);
		}

		public string ToStringUtf8()
		{
			return this.ToString(ByteString.smethod_5());
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return ((IEnumerable<byte>)this.bytes).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public CodedInputStream CreateCodedInput()
		{
			return new CodedInputStream(this.bytes);
		}

		public static bool operator ==(ByteString lhs, ByteString rhs)
		{
			if (lhs == rhs)
			{
				goto IL_4C;
			}
			goto IL_13F;
			uint arg_EB_0;
			while (true)
			{
				IL_E6:
				uint num;
				switch ((num = (arg_EB_0 ^ 3015203442u)) % 14u)
				{
				case 0u:
					arg_EB_0 = (num * 1526800505u ^ 369249965u);
					continue;
				case 1u:
					return true;
				case 2u:
					goto IL_13F;
				case 3u:
					arg_EB_0 = ((lhs.bytes.Length == rhs.bytes.Length) ? 3810513461u : 2661449894u);
					continue;
				case 4u:
					arg_EB_0 = (((rhs == null) ? 797756859u : 1966787781u) ^ num * 3274123226u);
					continue;
				case 5u:
					return false;
				case 7u:
				{
					int num2 = 0;
					arg_EB_0 = 3362854364u;
					continue;
				}
				case 8u:
					return false;
				case 9u:
				{
					int num2;
					arg_EB_0 = ((rhs.bytes[num2] == lhs.bytes[num2]) ? 2540292665u : 3053227692u);
					continue;
				}
				case 10u:
					goto IL_4C;
				case 11u:
				{
					int num2;
					arg_EB_0 = ((num2 >= lhs.Length) ? 4291605266u : 2382418493u);
					continue;
				}
				case 12u:
					return false;
				case 13u:
				{
					int num2;
					num2++;
					arg_EB_0 = 3284674451u;
					continue;
				}
				}
				break;
			}
			return true;
			IL_4C:
			arg_EB_0 = 3390293503u;
			goto IL_E6;
			IL_13F:
			arg_EB_0 = ((lhs == null) ? 3671513855u : 3857634200u);
			goto IL_E6;
		}

		public static bool operator !=(ByteString lhs, ByteString rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object obj)
		{
			return this == obj as ByteString;
		}

		public override int GetHashCode()
		{
			int num = 23;
			byte[] array = this.bytes;
			while (true)
			{
				IL_A1:
				uint arg_78_0 = 1378755444u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_78_0 ^ 428542771u)) % 7u)
					{
					case 0u:
						arg_78_0 = (num2 * 3625772926u ^ 3541393194u);
						continue;
					case 1u:
					{
						int num3;
						arg_78_0 = ((num3 >= array.Length) ? 1921554962u : 562842858u);
						continue;
					}
					case 2u:
					{
						int num3;
						num3++;
						arg_78_0 = (num2 * 2042663034u ^ 425373550u);
						continue;
					}
					case 3u:
						goto IL_A1;
					case 4u:
					{
						int num3;
						byte b = array[num3];
						num = (num << 8 | (int)b);
						arg_78_0 = 581374215u;
						continue;
					}
					case 6u:
					{
						int num3 = 0;
						arg_78_0 = (num2 * 2147684290u ^ 2262103751u);
						continue;
					}
					}
					return num;
				}
			}
			return num;
		}

		public bool Equals(ByteString other)
		{
			return this == other;
		}

		internal void WriteRawBytesTo(CodedOutputStream outputStream)
		{
			outputStream.WriteRawBytes(this.bytes, 0, this.bytes.Length);
		}

		public void CopyTo(byte[] array, int position)
		{
			ByteArray.Copy(this.bytes, 0, array, position, this.bytes.Length);
		}

		public void WriteTo(Stream outputStream)
		{
			ByteString.smethod_7(outputStream, this.bytes, 0, this.bytes.Length);
		}

		static object smethod_0(Array array_0)
		{
			return array_0.Clone();
		}

		static string smethod_1(byte[] byte_0)
		{
			return Convert.ToBase64String(byte_0);
		}

		static bool smethod_2(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static byte[] smethod_3(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}

		static byte[] smethod_4(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		static Encoding smethod_5()
		{
			return Encoding.UTF8;
		}

		static string smethod_6(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
		{
			return encoding_0.GetString(byte_0, int_0, int_1);
		}

		static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}
	}
}
