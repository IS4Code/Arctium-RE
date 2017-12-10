using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Int64Value : IMessage<Int64Value>, IEquatable<Int64Value>, IDeepCloneable<Int64Value>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Int64Value.__c __9 = new Int64Value.__c();

			internal Int64Value cctor>b__24_0()
			{
				return new Int64Value();
			}
		}

		private static readonly MessageParser<Int64Value> _parser = new MessageParser<Int64Value>(new Func<Int64Value>(Int64Value.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private long value_;

		public static MessageParser<Int64Value> Parser
		{
			get
			{
				return Int64Value._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Int64Value.Descriptor;
			}
		}

		public long Value
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

		public Int64Value()
		{
		}

		public Int64Value(Int64Value other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 520537951u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 198464487u)) % 3u)
					{
					case 1u:
						this.value_ = other.value_;
						arg_26_0 = (num * 2817859888u ^ 965486303u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public Int64Value Clone()
		{
			return new Int64Value(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Int64Value);
		}

		public bool Equals(Int64Value other)
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
				switch ((arg_43_0 ^ -1797088729) % 7)
				{
				case 0:
					return false;
				case 1:
					goto IL_75;
				case 2:
					arg_43_0 = ((this.Value != other.Value) ? -1663479058 : -1366623856);
					continue;
				case 3:
					return false;
				case 4:
					return true;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = -498087108;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? -1491460870 : -953711739);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 113187288u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 458116053u)) % 4u)
					{
					case 0u:
						num ^= this.Value.GetHashCode();
						arg_50_0 = (num2 * 2513678705u ^ 3557916122u);
						continue;
					case 1u:
						arg_50_0 = (((this.Value == 0L) ? 3453337413u : 4184709066u) ^ num2 * 4105978579u);
						continue;
					case 2u:
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
			if (this.Value != 0L)
			{
				while (true)
				{
					IL_5A:
					uint arg_3E_0 = 844406692u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 1481640981u)) % 4u)
						{
						case 0u:
							output.WriteInt64(this.Value);
							arg_3E_0 = (num * 546958130u ^ 903410522u);
							continue;
						case 1u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 3145577355u ^ 641928094u);
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
			if (this.Value != 0L)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 1363249360u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 1578089428u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 1u:
							num += 1 + CodedOutputStream.ComputeInt64Size(this.Value);
							arg_2E_0 = (num2 * 2699531435u ^ 2711705217u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(Int64Value other)
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
				switch ((num = (arg_37_0 ^ 1924256238u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 2u:
					goto IL_2D;
				case 3u:
					return;
				case 4u:
					this.Value = other.Value;
					arg_37_0 = (num * 1026267401u ^ 464423223u);
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1994140865u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value == 0L) ? 1318213219u : 1055165530u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_95:
				uint num;
				uint arg_62_0 = ((num = input.ReadTag()) != 0u) ? 3177752674u : 4171684265u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 2371339411u)) % 6u)
					{
					case 0u:
						this.Value = input.ReadInt64();
						arg_62_0 = 2986402692u;
						continue;
					case 1u:
						arg_62_0 = ((num == 8u) ? 2294375095u : 3895454993u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_62_0 = (num2 * 2762577601u ^ 616273030u);
						continue;
					case 3u:
						arg_62_0 = 3177752674u;
						continue;
					case 5u:
						goto IL_95;
					}
					return;
				}
			}
		}
	}
}
