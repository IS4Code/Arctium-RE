using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class ListValue : IMessage<ListValue>, IEquatable<ListValue>, IDeepCloneable<ListValue>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ListValue.__c __9 = new ListValue.__c();

			internal ListValue cctor>b__24_0()
			{
				return new ListValue();
			}
		}

		private static readonly MessageParser<ListValue> _parser = new MessageParser<ListValue>(new Func<ListValue>(ListValue.__c.__9.<.cctor>b__24_0));

		public const int ValuesFieldNumber = 1;

		private static readonly FieldCodec<Value> _repeated_values_codec;

		private readonly RepeatedField<Value> values_ = new RepeatedField<Value>();

		public static MessageParser<ListValue> Parser
		{
			get
			{
				return ListValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return StructReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListValue.Descriptor;
			}
		}

		public RepeatedField<Value> Values
		{
			get
			{
				return this.values_;
			}
		}

		public ListValue()
		{
		}

		public ListValue(ListValue other) : this()
		{
			this.values_ = other.values_.Clone();
		}

		public ListValue Clone()
		{
			return new ListValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ListValue);
		}

		public bool Equals(ListValue other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -1100707998) % 7)
				{
				case 0:
					return false;
				case 2:
					goto IL_3E;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					goto IL_7A;
				case 6:
					arg_48_0 = ((!this.values_.Equals(other.values_)) ? -685558879 : -1933748675);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -2117391217;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -2086324249 : -1862265693);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ListValue.smethod_0(this.values_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.values_.WriteTo(output, ListValue._repeated_values_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.values_.CalculateSize(ListValue._repeated_values_codec);
		}

		public void MergeFrom(ListValue other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 964395865;
			IL_08:
			switch ((arg_0D_0 ^ 1561758888) % 4)
			{
			case 1:
				return;
			case 2:
				IL_27:
				this.values_.Add(other.values_);
				arg_0D_0 = 106197376;
				goto IL_08;
			case 3:
				goto IL_03;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) == 0u) ? 1669581523u : 1014981123u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 509924749u)) % 6u)
					{
					case 0u:
						arg_68_0 = 1014981123u;
						continue;
					case 1u:
						this.values_.AddEntriesFrom(input, ListValue._repeated_values_codec);
						arg_68_0 = 1687690660u;
						continue;
					case 2u:
						arg_68_0 = ((num != 10u) ? 1223323390u : 502915878u);
						continue;
					case 3u:
						goto IL_9B;
					case 5u:
						input.SkipLastField();
						arg_68_0 = (num2 * 3691145874u ^ 2775750706u);
						continue;
					}
					return;
				}
			}
		}

		static ListValue()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 1697726623u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 1568696848u)) % 3u)
					{
					case 1u:
						ListValue._repeated_values_codec = FieldCodec.ForMessage<Value>(10u, Value.Parser);
						arg_3F_0 = (num * 1159609478u ^ 3885751130u);
						continue;
					case 2u:
						goto IL_57;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
