using System;
using System.IO;

namespace Google.Protobuf
{
	internal sealed class LimitedInputStream : Stream
	{
		private readonly Stream proxied;

		private int bytesLeft;

		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public override long Length
		{
			get
			{
				throw LimitedInputStream.smethod_0();
			}
		}

		public override long Position
		{
			get
			{
				throw LimitedInputStream.smethod_0();
			}
			set
			{
				throw LimitedInputStream.smethod_0();
			}
		}

		internal LimitedInputStream(Stream proxied, int size)
		{
			while (true)
			{
				IL_53:
				uint arg_37_0 = 4003410864u;
				while (true)
				{
					uint num;
					switch ((num = (arg_37_0 ^ 2648308497u)) % 4u)
					{
					case 1u:
						this.proxied = proxied;
						arg_37_0 = (num * 2611616036u ^ 1752725666u);
						continue;
					case 2u:
						goto IL_53;
					case 3u:
						this.bytesLeft = size;
						arg_37_0 = (num * 3914505600u ^ 3519685525u);
						continue;
					}
					return;
				}
			}
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.bytesLeft > 0)
			{
				while (true)
				{
					IL_61:
					uint arg_45_0 = 1171296126u;
					while (true)
					{
						uint num;
						switch ((num = (arg_45_0 ^ 370393729u)) % 4u)
						{
						case 0u:
							goto IL_61;
						case 2u:
						{
							int num2;
							return num2;
						}
						case 3u:
						{
							int num2 = LimitedInputStream.smethod_2(this.proxied, buffer, offset, LimitedInputStream.smethod_1(this.bytesLeft, count));
							this.bytesLeft -= num2;
							arg_45_0 = (num * 134526951u ^ 422163270u);
							continue;
						}
						}
						goto Block_2;
					}
				}
				Block_2:
				return 0;
			}
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw LimitedInputStream.smethod_0();
		}

		public override void SetLength(long value)
		{
			throw LimitedInputStream.smethod_0();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw LimitedInputStream.smethod_0();
		}

		static NotSupportedException smethod_0()
		{
			return new NotSupportedException();
		}

		static int smethod_1(int int_0, int int_1)
		{
			return Math.Min(int_0, int_1);
		}

		static int smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			return stream_0.Read(byte_0, int_0, int_1);
		}
	}
}
