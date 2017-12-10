using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class NoData : IMessage<NoData>, IEquatable<NoData>, IDeepCloneable<NoData>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly NoData.__c __9 = new NoData.__c();

			internal NoData cctor>b__19_0()
			{
				return new NoData();
			}
		}

		private static readonly MessageParser<NoData> _parser = new MessageParser<NoData>(new Func<NoData>(NoData.__c.__9.<.cctor>b__19_0));

		public static MessageParser<NoData> Parser
		{
			get
			{
				return NoData._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NoData.Descriptor;
			}
		}

		public NoData()
		{
		}

		public NoData(NoData other) : this()
		{
		}

		public NoData Clone()
		{
			return new NoData(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as NoData);
		}

		public bool Equals(NoData other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 118265190;
			IL_08:
			switch ((arg_0D_0 ^ 1436244536) % 4)
			{
			case 0:
				goto IL_03;
			case 2:
				return false;
			case 3:
				IL_27:
				arg_0D_0 = 8851293;
				goto IL_08;
			}
			return true;
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

		public void MergeFrom(NoData other)
		{
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4D:
				int arg_27_0 = (input.ReadTag() != 0u) ? -1815302333 : -91638782;
				while (true)
				{
					switch ((arg_27_0 ^ -33769758) % 4)
					{
					case 1:
						input.SkipLastField();
						arg_27_0 = -857573356;
						continue;
					case 2:
						goto IL_4D;
					case 3:
						arg_27_0 = -1815302333;
						continue;
					}
					return;
				}
			}
		}
	}
}
