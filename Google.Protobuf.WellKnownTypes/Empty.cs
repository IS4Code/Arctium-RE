using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Empty : IMessage<Empty>, IEquatable<Empty>, IDeepCloneable<Empty>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Empty.__c __9 = new Empty.__c();

			internal Empty cctor>b__19_0()
			{
				return new Empty();
			}
		}

		private static readonly MessageParser<Empty> _parser = new MessageParser<Empty>(new Func<Empty>(Empty.__c.__9.<.cctor>b__19_0));

		public static MessageParser<Empty> Parser
		{
			get
			{
				return Empty._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return EmptyReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Empty.Descriptor;
			}
		}

		public Empty()
		{
		}

		public Empty(Empty other) : this()
		{
		}

		public Empty Clone()
		{
			return new Empty(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Empty);
		}

		public bool Equals(Empty other)
		{
			return other != null;
		}

		public override int GetHashCode()
		{
			return 1;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
		}

		public int CalculateSize()
		{
			return 0;
		}

		public void MergeFrom(Empty other)
		{
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4D:
				int arg_27_0 = (input.ReadTag() == 0u) ? 1997961641 : 747400071;
				while (true)
				{
					switch ((arg_27_0 ^ 2063866528) % 4)
					{
					case 0:
						goto IL_4D;
					case 2:
						arg_27_0 = 747400071;
						continue;
					case 3:
						input.SkipLastField();
						arg_27_0 = 1511674276;
						continue;
					}
					return;
				}
			}
		}
	}
}
