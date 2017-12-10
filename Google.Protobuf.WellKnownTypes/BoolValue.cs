using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class BoolValue : IMessage<BoolValue>, IEquatable<BoolValue>, IDeepCloneable<BoolValue>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BoolValue.__c __9 = new BoolValue.__c();

			internal BoolValue cctor>b__24_0()
			{
				return new BoolValue();
			}
		}

		private static readonly MessageParser<BoolValue> _parser = new MessageParser<BoolValue>(new Func<BoolValue>(BoolValue.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private bool value_;

		public static MessageParser<BoolValue> Parser
		{
			get
			{
				return BoolValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoolValue.Descriptor;
			}
		}

		public bool Value
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

		public BoolValue()
		{
		}

		public BoolValue(BoolValue other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 1769763656u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 1984974658u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 1u:
						this.value_ = other.value_;
						arg_26_0 = (num * 2309130594u ^ 3708433242u);
						continue;
					}
					return;
				}
			}
		}

		public BoolValue Clone()
		{
			return new BoolValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BoolValue);
		}

		public bool Equals(BoolValue other)
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
				switch ((arg_43_0 ^ 641488445) % 7)
				{
				case 0:
					goto IL_39;
				case 1:
					goto IL_75;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					arg_43_0 = ((this.Value == other.Value) ? 1070099383 : 1741206112);
					continue;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = 312997048;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? 21110083 : 1048484400);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 1270096041u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 2108046935u)) % 4u)
					{
					case 1u:
						num ^= this.Value.GetHashCode();
						arg_50_0 = (num2 * 4008933902u ^ 4157047061u);
						continue;
					case 2u:
						arg_50_0 = (((!this.Value) ? 697887751u : 2020163018u) ^ num2 * 975738354u);
						continue;
					case 3u:
						goto IL_6C;
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
			if (this.Value)
			{
				while (true)
				{
					IL_5A:
					uint arg_3E_0 = 2143557810u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 275318803u)) % 4u)
						{
						case 0u:
							output.WriteBool(this.Value);
							arg_3E_0 = (num * 2889550032u ^ 2838278952u);
							continue;
						case 1u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 3252564579u ^ 3918936248u);
							continue;
						case 2u:
							goto IL_5A;
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
				IL_5F:
				uint arg_43_0 = 3788332925u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_43_0 ^ 4185801590u)) % 4u)
					{
					case 0u:
						goto IL_5F;
					case 2u:
						num += 2;
						arg_43_0 = (num2 * 3721250531u ^ 2212888493u);
						continue;
					case 3u:
						arg_43_0 = (((!this.Value) ? 1622309267u : 2145179052u) ^ num2 * 2669066972u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(BoolValue other)
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
				switch ((num = (arg_37_0 ^ 3784576412u)) % 5u)
				{
				case 0u:
					this.Value = other.Value;
					arg_37_0 = (num * 1134764340u ^ 3585724961u);
					continue;
				case 2u:
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
			arg_37_0 = 3645322272u;
			goto IL_32;
			IL_63:
			arg_37_0 = (other.Value ? 3392203467u : 3843024525u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A8:
				uint num;
				uint arg_71_0 = ((num = input.ReadTag()) == 0u) ? 216543058u : 314750847u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_71_0 ^ 446421772u)) % 7u)
					{
					case 0u:
						input.SkipLastField();
						arg_71_0 = (num2 * 131220957u ^ 1819764258u);
						continue;
					case 1u:
						arg_71_0 = (num2 * 3991844700u ^ 1888577468u);
						continue;
					case 2u:
						this.Value = input.ReadBool();
						arg_71_0 = 454504576u;
						continue;
					case 3u:
						goto IL_A8;
					case 4u:
						arg_71_0 = 314750847u;
						continue;
					case 5u:
						arg_71_0 = ((num == 8u) ? 816712489u : 494306207u);
						continue;
					}
					return;
				}
			}
		}
	}
}
