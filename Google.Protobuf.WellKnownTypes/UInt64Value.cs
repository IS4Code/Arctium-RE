using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class UInt64Value : IMessage<UInt64Value>, IEquatable<UInt64Value>, IDeepCloneable<UInt64Value>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UInt64Value.__c __9 = new UInt64Value.__c();

			internal UInt64Value cctor>b__24_0()
			{
				return new UInt64Value();
			}
		}

		private static readonly MessageParser<UInt64Value> _parser = new MessageParser<UInt64Value>(new Func<UInt64Value>(UInt64Value.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private ulong value_;

		public static MessageParser<UInt64Value> Parser
		{
			get
			{
				return UInt64Value._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UInt64Value.Descriptor;
			}
		}

		public ulong Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		public UInt64Value()
		{
		}

		public UInt64Value(UInt64Value other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 2692623055u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 2647586696u)) % 3u)
					{
					case 1u:
						this.value_ = other.value_;
						arg_26_0 = (num * 480328232u ^ 1226890301u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public UInt64Value Clone()
		{
			return new UInt64Value(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UInt64Value);
		}

		public bool Equals(UInt64Value other)
		{
			if (other == null)
			{
				goto IL_39;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ 1501754317) % 7)
				{
				case 0:
					goto IL_39;
				case 1:
					return false;
				case 2:
					goto IL_75;
				case 3:
					return true;
				case 5:
					return false;
				case 6:
					arg_43_0 = ((this.Value == other.Value) ? 2110735878 : 887388975);
					continue;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = 496968355;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? 1098447721 : 1396165205);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Value != 0uL)
			{
				while (true)
				{
					IL_47:
					uint arg_2F_0 = 1478230784u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2F_0 ^ 1606704892u)) % 3u)
						{
						case 0u:
							goto IL_47;
						case 1u:
							num ^= this.Value.GetHashCode();
							arg_2F_0 = (num2 * 3602546017u ^ 2671420245u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Value != 0uL)
			{
				while (true)
				{
					IL_47:
					uint arg_2F_0 = 4031822136u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2F_0 ^ 2432157601u)) % 3u)
						{
						case 0u:
							goto IL_47;
						case 2u:
							output.WriteRawTag(8);
							output.WriteUInt64(this.Value);
							arg_2F_0 = (num * 4072525251u ^ 925261882u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_6B:
				uint arg_4F_0 = 3030850040u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F_0 ^ 3198133029u)) % 4u)
					{
					case 0u:
						goto IL_6B;
					case 1u:
						arg_4F_0 = (((this.Value != 0uL) ? 739238963u : 431717382u) ^ num2 * 3773124041u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Value);
						arg_4F_0 = (num2 * 1275667473u ^ 3291009088u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UInt64Value other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 2683627219u)) % 5u)
				{
				case 0u:
					this.Value = other.Value;
					arg_37_0 = (num * 3950873742u ^ 3944701421u);
					continue;
				case 1u:
					return;
				case 3u:
					goto IL_12;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 2234959634u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value != 0uL) ? 3344006917u : 2690974041u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_95:
				uint num;
				uint arg_62_0 = ((num = input.ReadTag()) != 0u) ? 2640323563u : 2621535426u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 4293315933u)) % 6u)
					{
					case 0u:
						arg_62_0 = 2640323563u;
						continue;
					case 2u:
						goto IL_95;
					case 3u:
						this.Value = input.ReadUInt64();
						arg_62_0 = 2725199347u;
						continue;
					case 4u:
						arg_62_0 = ((num != 8u) ? 3207784056u : 2548953166u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_62_0 = (num2 * 158718183u ^ 715922320u);
						continue;
					}
					return;
				}
			}
		}
	}
}
