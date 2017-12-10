using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class UInt32Value : IMessage<UInt32Value>, IEquatable<UInt32Value>, IDeepCloneable<UInt32Value>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UInt32Value.__c __9 = new UInt32Value.__c();

			internal UInt32Value cctor>b__24_0()
			{
				return new UInt32Value();
			}
		}

		private static readonly MessageParser<UInt32Value> _parser = new MessageParser<UInt32Value>(new Func<UInt32Value>(UInt32Value.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private uint value_;

		public static MessageParser<UInt32Value> Parser
		{
			get
			{
				return UInt32Value._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UInt32Value.Descriptor;
			}
		}

		public uint Value
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

		public UInt32Value()
		{
		}

		public UInt32Value(UInt32Value other) : this()
		{
			this.value_ = other.value_;
		}

		public UInt32Value Clone()
		{
			return new UInt32Value(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UInt32Value);
		}

		public bool Equals(UInt32Value other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ -846397802) % 7)
				{
				case 0:
					goto IL_75;
				case 2:
					arg_43_0 = ((this.Value != other.Value) ? -553472577 : -527185368);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_12;
				case 5:
					return false;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = -461179523;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? -270039607 : -75345906);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 2802529349u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 3911544564u)) % 4u)
					{
					case 1u:
						arg_50_0 = (((this.Value == 0u) ? 286650167u : 1765746968u) ^ num2 * 1062172667u);
						continue;
					case 2u:
						goto IL_6C;
					case 3u:
						num ^= this.Value.GetHashCode();
						arg_50_0 = (num2 * 1132322786u ^ 3877142610u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Value != 0u)
			{
				while (true)
				{
					IL_5A:
					uint arg_3E_0 = 4237777190u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 2570988535u)) % 4u)
						{
						case 0u:
							goto IL_5A;
						case 1u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 2165976347u ^ 4023923294u);
							continue;
						case 2u:
							output.WriteUInt32(this.Value);
							arg_3E_0 = (num * 2730801902u ^ 3284726508u);
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
			if (this.Value != 0u)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 3442078902u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 3390321382u)) % 3u)
						{
						case 1u:
							num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
							arg_2E_0 = (num2 * 1094621579u ^ 2899980218u);
							continue;
						case 2u:
							goto IL_46;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(UInt32Value other)
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
				switch ((num = (arg_37_0 ^ 537287064u)) % 5u)
				{
				case 1u:
					return;
				case 2u:
					goto IL_63;
				case 3u:
					this.Value = other.Value;
					arg_37_0 = (num * 1409705140u ^ 443985280u);
					continue;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 1785552604u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value == 0u) ? 942233208u : 1382106158u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A8:
				uint num;
				uint arg_71_0 = ((num = input.ReadTag()) != 0u) ? 4173524862u : 2532160509u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_71_0 ^ 2373521243u)) % 7u)
					{
					case 0u:
						input.SkipLastField();
						arg_71_0 = (num2 * 3734822602u ^ 2776843024u);
						continue;
					case 1u:
						goto IL_A8;
					case 3u:
						arg_71_0 = ((num == 8u) ? 3582202604u : 2793884427u);
						continue;
					case 4u:
						this.Value = input.ReadUInt32();
						arg_71_0 = 3470518169u;
						continue;
					case 5u:
						arg_71_0 = (num2 * 1105812581u ^ 327226030u);
						continue;
					case 6u:
						arg_71_0 = 4173524862u;
						continue;
					}
					return;
				}
			}
		}
	}
}
