using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class FloatValue : IMessage<FloatValue>, IEquatable<FloatValue>, IDeepCloneable<FloatValue>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FloatValue.__c __9 = new FloatValue.__c();

			internal FloatValue cctor>b__24_0()
			{
				return new FloatValue();
			}
		}

		private static readonly MessageParser<FloatValue> _parser = new MessageParser<FloatValue>(new Func<FloatValue>(FloatValue.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private float value_;

		public static MessageParser<FloatValue> Parser
		{
			get
			{
				return FloatValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloatValue.Descriptor;
			}
		}

		public float Value
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

		public FloatValue()
		{
		}

		public FloatValue(FloatValue other) : this()
		{
			this.value_ = other.value_;
		}

		public FloatValue Clone()
		{
			return new FloatValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FloatValue);
		}

		public bool Equals(FloatValue other)
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
				switch ((arg_43_0 ^ -1153151227) % 7)
				{
				case 0:
					return false;
				case 2:
					goto IL_75;
				case 3:
					return true;
				case 4:
					arg_43_0 = ((this.Value != other.Value) ? -1205176748 : -943673852);
					continue;
				case 5:
					goto IL_12;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = -1962732247;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? -537062083 : -1141169107);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_71:
				uint arg_55_0 = 2477020909u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_55_0 ^ 2362435684u)) % 4u)
					{
					case 0u:
						goto IL_71;
					case 1u:
						arg_55_0 = (((this.Value != 0f) ? 3337902413u : 3795496372u) ^ num2 * 2079548063u);
						continue;
					case 2u:
						num ^= this.Value.GetHashCode();
						arg_55_0 = (num2 * 1032941155u ^ 2729592665u);
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
			if (this.Value != 0f)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 4101470090u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 3063682080u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 2u:
							output.WriteRawTag(13);
							arg_44_0 = (num * 3816760559u ^ 1153115841u);
							continue;
						case 3u:
							output.WriteFloat(this.Value);
							arg_44_0 = (num * 1308207327u ^ 607119636u);
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
				IL_64:
				uint arg_48_0 = 3111294588u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_48_0 ^ 3832369453u)) % 4u)
					{
					case 0u:
						num += 5;
						arg_48_0 = (num2 * 241780577u ^ 2574969331u);
						continue;
					case 1u:
						arg_48_0 = (((this.Value == 0f) ? 3900006383u : 4102642737u) ^ num2 * 3110787796u);
						continue;
					case 3u:
						goto IL_64;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FloatValue other)
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
				switch ((num = (arg_37_0 ^ 2055920025u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 1u:
					this.Value = other.Value;
					arg_37_0 = (num * 3615480091u ^ 3431823127u);
					continue;
				case 2u:
					goto IL_12;
				case 4u:
					return;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 873840231u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value != 0f) ? 1652167601u : 1377062191u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) != 0u) ? 1024210798u : 1426770414u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 1233019520u)) % 7u)
					{
					case 0u:
						this.Value = input.ReadFloat();
						arg_72_0 = 1216984509u;
						continue;
					case 1u:
						arg_72_0 = (num2 * 2024317045u ^ 838402263u);
						continue;
					case 2u:
						goto IL_A9;
					case 3u:
						input.SkipLastField();
						arg_72_0 = (num2 * 2617011055u ^ 450168456u);
						continue;
					case 5u:
						arg_72_0 = ((num != 13u) ? 507287446u : 1573940726u);
						continue;
					case 6u:
						arg_72_0 = 1024210798u;
						continue;
					}
					return;
				}
			}
		}
	}
}
