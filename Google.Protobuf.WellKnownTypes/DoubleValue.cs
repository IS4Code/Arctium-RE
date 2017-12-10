using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class DoubleValue : IMessage<DoubleValue>, IEquatable<DoubleValue>, IDeepCloneable<DoubleValue>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly DoubleValue.__c __9 = new DoubleValue.__c();

			internal DoubleValue cctor>b__24_0()
			{
				return new DoubleValue();
			}
		}

		private static readonly MessageParser<DoubleValue> _parser = new MessageParser<DoubleValue>(new Func<DoubleValue>(DoubleValue.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private double value_;

		public static MessageParser<DoubleValue> Parser
		{
			get
			{
				return DoubleValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoubleValue.Descriptor;
			}
		}

		public double Value
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

		public DoubleValue()
		{
		}

		public DoubleValue(DoubleValue other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 48172625u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 380464856u)) % 3u)
					{
					case 1u:
						this.value_ = other.value_;
						arg_26_0 = (num * 2278192809u ^ 3307742096u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public DoubleValue Clone()
		{
			return new DoubleValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as DoubleValue);
		}

		public bool Equals(DoubleValue other)
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
				switch ((arg_43_0 ^ 483590106) % 7)
				{
				case 0:
					arg_43_0 = ((this.Value == other.Value) ? 2014721059 : 2082864806);
					continue;
				case 1:
					goto IL_75;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = 1917965878;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? 1446728904 : 556084107);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_75:
				uint arg_59_0 = 1522342965u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_59_0 ^ 160217918u)) % 4u)
					{
					case 0u:
						goto IL_75;
					case 1u:
						num ^= this.Value.GetHashCode();
						arg_59_0 = (num2 * 2310797616u ^ 1464086320u);
						continue;
					case 3u:
						arg_59_0 = (((this.Value == 0.0) ? 3796185736u : 3635792463u) ^ num2 * 1376322328u);
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
			if (this.Value != 0.0)
			{
				while (true)
				{
					IL_64:
					uint arg_48_0 = 1329153961u;
					while (true)
					{
						uint num;
						switch ((num = (arg_48_0 ^ 796802158u)) % 4u)
						{
						case 0u:
							goto IL_64;
						case 1u:
							output.WriteDouble(this.Value);
							arg_48_0 = (num * 2883265639u ^ 933437999u);
							continue;
						case 3u:
							output.WriteRawTag(9);
							arg_48_0 = (num * 2731574727u ^ 1833438334u);
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
				IL_69:
				uint arg_4D_0 = 997792255u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 1247449349u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 2u:
						arg_4D_0 = (((this.Value != 0.0) ? 4221771738u : 2627344140u) ^ num2 * 3859031916u);
						continue;
					case 3u:
						num += 9;
						arg_4D_0 = (num2 * 4122098634u ^ 833233586u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(DoubleValue other)
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
				switch ((num = (arg_37_0 ^ 1171860348u)) % 5u)
				{
				case 0u:
					this.Value = other.Value;
					arg_37_0 = (num * 775242876u ^ 1555530578u);
					continue;
				case 1u:
					goto IL_63;
				case 2u:
					return;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 1613566495u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value == 0.0) ? 421661698u : 474519248u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_96:
				uint num;
				uint arg_63_0 = ((num = input.ReadTag()) == 0u) ? 3886970757u : 2318846320u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 2444209093u)) % 6u)
					{
					case 0u:
						input.SkipLastField();
						arg_63_0 = (num2 * 3228265537u ^ 3792805188u);
						continue;
					case 1u:
						goto IL_96;
					case 2u:
						arg_63_0 = 2318846320u;
						continue;
					case 3u:
						arg_63_0 = ((num != 9u) ? 2376670895u : 3775468028u);
						continue;
					case 5u:
						this.Value = input.ReadDouble();
						arg_63_0 = 2811976366u;
						continue;
					}
					return;
				}
			}
		}
	}
}
