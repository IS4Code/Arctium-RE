using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class BytesValue : IMessage, IMessage<BytesValue>, IEquatable<BytesValue>, IDeepCloneable<BytesValue>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BytesValue.__c __9 = new BytesValue.__c();

			internal BytesValue cctor>b__24_0()
			{
				return new BytesValue();
			}
		}

		private static readonly MessageParser<BytesValue> _parser = new MessageParser<BytesValue>(new Func<BytesValue>(BytesValue.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private ByteString value_ = ByteString.Empty;

		public static MessageParser<BytesValue> Parser
		{
			get
			{
				return BytesValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BytesValue.Descriptor;
			}
		}

		public ByteString Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public BytesValue()
		{
		}

		public BytesValue(BytesValue other) : this()
		{
			this.value_ = other.value_;
		}

		public BytesValue Clone()
		{
			return new BytesValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BytesValue);
		}

		public bool Equals(BytesValue other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 683592313) % 7)
				{
				case 0:
					arg_48_0 = ((!(this.Value != other.Value)) ? 652235535 : 996578275);
					continue;
				case 2:
					return false;
				case 3:
					goto IL_7A;
				case 4:
					return true;
				case 5:
					goto IL_12;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 1218751243;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 618196101 : 2036451939);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Value.Length != 0)
			{
				while (true)
				{
					IL_49:
					uint arg_31_0 = 2275274893u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_31_0 ^ 3324681876u)) % 3u)
						{
						case 0u:
							goto IL_49;
						case 2u:
							num ^= BytesValue.smethod_0(this.Value);
							arg_31_0 = (num2 * 2954361594u ^ 2329351346u);
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
			if (this.Value.Length != 0)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 3631218858u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 3322845955u)) % 4u)
						{
						case 1u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 859552242u ^ 1997460187u);
							continue;
						case 2u:
							output.WriteBytes(this.Value);
							arg_44_0 = (num * 2944360117u ^ 3585588585u);
							continue;
						case 3u:
							goto IL_60;
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
				IL_70:
				uint arg_54_0 = 2195808887u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_54_0 ^ 3955346414u)) % 4u)
					{
					case 1u:
						arg_54_0 = (((this.Value.Length != 0) ? 1500120201u : 1924405691u) ^ num2 * 1083790369u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Value);
						arg_54_0 = (num2 * 2034812408u ^ 1168620562u);
						continue;
					case 3u:
						goto IL_70;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(BytesValue other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 2444393304u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 1u:
					return;
				case 2u:
					goto IL_2D;
				case 3u:
					this.Value = other.Value;
					arg_37_0 = (num * 1148991057u ^ 1649330358u);
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 3417597038u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value.Length == 0) ? 3520603776u : 3767567374u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) == 0u) ? 680166988u : 1821107942u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 8919087u)) % 7u)
					{
					case 0u:
						this.Value = input.ReadBytes();
						arg_72_0 = 157599103u;
						continue;
					case 1u:
						arg_72_0 = ((num == 10u) ? 1443811098u : 1547626170u);
						continue;
					case 2u:
						arg_72_0 = (num2 * 2347725086u ^ 3138862833u);
						continue;
					case 3u:
						goto IL_A9;
					case 4u:
						input.SkipLastField();
						arg_72_0 = (num2 * 2664935826u ^ 1414364828u);
						continue;
					case 6u:
						arg_72_0 = 1821107942u;
						continue;
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
