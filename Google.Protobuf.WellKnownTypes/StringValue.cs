using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class StringValue : IMessage<StringValue>, IMessage, IEquatable<StringValue>, IDeepCloneable<StringValue>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly StringValue.__c __9 = new StringValue.__c();

			internal StringValue cctor>b__24_0()
			{
				return new StringValue();
			}
		}

		private static readonly MessageParser<StringValue> _parser = new MessageParser<StringValue>(new Func<StringValue>(StringValue.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private string value_ = "";

		public static MessageParser<StringValue> Parser
		{
			get
			{
				return StringValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StringValue.Descriptor;
			}
		}

		public string Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public StringValue()
		{
		}

		public StringValue(StringValue other) : this()
		{
			this.value_ = other.value_;
		}

		public StringValue Clone()
		{
			return new StringValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as StringValue);
		}

		public bool Equals(StringValue other)
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
				switch ((arg_48_0 ^ -1263802105) % 7)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					arg_48_0 = (StringValue.smethod_0(this.Value, other.Value) ? -141375324 : -260536584);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_7A;
				case 5:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1200080730;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1836947825 : -1933936153);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 763514593u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 175983276u)) % 4u)
					{
					case 0u:
						num ^= StringValue.smethod_2(this.Value);
						arg_52_0 = (num2 * 3783353000u ^ 1448269218u);
						continue;
					case 1u:
						arg_52_0 = (((StringValue.smethod_1(this.Value) != 0) ? 3858043379u : 3360361697u) ^ num2 * 3573188143u);
						continue;
					case 3u:
						goto IL_6E;
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
			if (StringValue.smethod_1(this.Value) != 0)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 90788105u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 824169899u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 1u:
							output.WriteString(this.Value);
							arg_44_0 = (num * 3149218996u ^ 2104094208u);
							continue;
						case 2u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 3732086352u ^ 938894630u);
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
				IL_70:
				uint arg_54_0 = 2796195775u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_54_0 ^ 3793409952u)) % 4u)
					{
					case 0u:
						goto IL_70;
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
						arg_54_0 = (num2 * 831506503u ^ 1421556553u);
						continue;
					case 3u:
						arg_54_0 = (((StringValue.smethod_1(this.Value) == 0) ? 1473366872u : 13810999u) ^ num2 * 2307889566u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(StringValue other)
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
				switch ((num = (arg_37_0 ^ 171763367u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 2u:
					this.Value = other.Value;
					arg_37_0 = (num * 108128614u ^ 4220800551u);
					continue;
				case 3u:
					goto IL_63;
				case 4u:
					return;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1741970253u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((StringValue.smethod_1(other.Value) == 0) ? 867908447u : 875443955u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) == 0u) ? 54247302u : 207229117u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 410145730u)) % 7u)
					{
					case 0u:
						arg_72_0 = (num2 * 1062902489u ^ 1139187804u);
						continue;
					case 1u:
						input.SkipLastField();
						arg_72_0 = (num2 * 1448371858u ^ 3470927109u);
						continue;
					case 3u:
						arg_72_0 = 207229117u;
						continue;
					case 4u:
						this.Value = input.ReadString();
						arg_72_0 = 1046130945u;
						continue;
					case 5u:
						arg_72_0 = ((num == 10u) ? 1286828698u : 277419307u);
						continue;
					case 6u:
						goto IL_A9;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
