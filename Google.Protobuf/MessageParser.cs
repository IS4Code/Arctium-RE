using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public class MessageParser
	{
		private Func<IMessage> factory;

		internal MessageParser(Func<IMessage> factory)
		{
			this.factory = factory;
		}

		internal IMessage CreateTemplate()
		{
			return this.factory();
		}

		public IMessage ParseFrom(byte[] data)
		{
			Preconditions.CheckNotNull<byte[]>(data, Module.smethod_35<string>(3890457523u));
			IMessage expr_1C = this.factory();
			expr_1C.MergeFrom(data);
			return expr_1C;
		}

		public IMessage ParseFrom(ByteString data)
		{
			Preconditions.CheckNotNull<ByteString>(data, Module.smethod_37<string>(1222507759u));
			IMessage expr_1C = this.factory();
			expr_1C.MergeFrom(data);
			return expr_1C;
		}

		public IMessage ParseFrom(Stream input)
		{
			IMessage expr_0B = this.factory();
			expr_0B.MergeFrom(input);
			return expr_0B;
		}

		public IMessage ParseDelimitedFrom(Stream input)
		{
			IMessage expr_0B = this.factory();
			expr_0B.MergeDelimitedFrom(input);
			return expr_0B;
		}

		public IMessage ParseFrom(CodedInputStream input)
		{
			IMessage expr_0B = this.factory();
			expr_0B.MergeFrom(input);
			return expr_0B;
		}

		public IMessage ParseJson(string json)
		{
			IMessage message = this.factory();
			JsonParser.Default.Merge(message, json);
			return message;
		}
	}
	[ComVisible(true)]
	public sealed class MessageParser<T> : MessageParser where T : object, IMessage<T>
	{
		private readonly Func<T> factory;

		public MessageParser(Func<T> factory) : base(() => factory())
		{
			this.factory = factory;
		}

		internal new T CreateTemplate()
		{
			return this.factory();
		}

		public new T ParseFrom(byte[] data)
		{
			Preconditions.CheckNotNull<byte[]>(data, Module.smethod_37<string>(1222507759u));
			T expr_1C = this.factory();
			expr_1C.MergeFrom(data);
			return expr_1C;
		}

		public new T ParseFrom(ByteString data)
		{
			Preconditions.CheckNotNull<ByteString>(data, Module.smethod_34<string>(87936628u));
			T expr_1C = this.factory();
			expr_1C.MergeFrom(data);
			return expr_1C;
		}

		public new T ParseFrom(Stream input)
		{
			T expr_0B = this.factory();
			expr_0B.MergeFrom(input);
			return expr_0B;
		}

		public new T ParseDelimitedFrom(Stream input)
		{
			T expr_0B = this.factory();
			expr_0B.MergeDelimitedFrom(input);
			return expr_0B;
		}

		public new T ParseFrom(CodedInputStream input)
		{
			T result = this.factory();
			result.MergeFrom(input);
			return result;
		}

		public new T ParseJson(string json)
		{
			T t = this.factory();
			JsonParser.Default.Merge(t, json);
			return t;
		}
	}
}
