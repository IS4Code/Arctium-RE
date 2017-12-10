using Google.Protobuf.Reflection;
using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public interface IMessage
	{
		MessageDescriptor Descriptor
		{
			get;
		}

		void MergeFrom(CodedInputStream input);

		void WriteTo(CodedOutputStream output);

		int CalculateSize();
	}
	[ComVisible(true)]
	public interface IMessage<T> : IEquatable<T>, IDeepCloneable<T>, IMessage where T : object, IMessage<T>
	{
		void MergeFrom(T message);
	}
}
