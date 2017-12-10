using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Int32Value : IMessage<Int32Value>, IEquatable<Int32Value>, IDeepCloneable<Int32Value>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Int32Value.__c __9 = new Int32Value.__c();

			internal Int32Value cctor>b__24_0()
			{
				return new Int32Value();
			}
		}

		private static readonly MessageParser<Int32Value> _parser = new MessageParser<Int32Value>(new Func<Int32Value>(Int32Value.__c.__9.<.cctor>b__24_0));

		public const int ValueFieldNumber = 1;

		private int value_;

		public static MessageParser<Int32Value> Parser
		{
			get
			{
				return Int32Value._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return WrappersReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Int32Value.Descriptor;
			}
		}

		public int Value
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

		public Int32Value()
		{
		}

		public Int32Value(Int32Value other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 1804220791u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 1581900384u)) % 3u)
					{
					case 1u:
						this.value_ = other.value_;
						arg_26_0 = (num * 4135993735u ^ 2153646638u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public Int32Value Clone()
		{
			return new Int32Value(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Int32Value);
		}

		public bool Equals(Int32Value other)
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
				switch ((arg_43_0 ^ -1634842932) % 7)
				{
				case 1:
					return false;
				case 2:
					goto IL_39;
				case 3:
					return false;
				case 4:
					arg_43_0 = ((this.Value != other.Value) ? -961057384 : -1124101802);
					continue;
				case 5:
					goto IL_75;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = -866185177;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? -817733575 : -179295982);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 4135753243u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 2564959002u)) % 4u)
					{
					case 0u:
						goto IL_6C;
					case 1u:
						arg_50_0 = (((this.Value == 0) ? 3758658162u : 2951197051u) ^ num2 * 1986698867u);
						continue;
					case 2u:
						num ^= this.Value.GetHashCode();
						arg_50_0 = (num2 * 3961316342u ^ 3761227341u);
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
			if (this.Value != 0)
			{
				while (true)
				{
					IL_47:
					uint arg_2F_0 = 3572854802u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2F_0 ^ 3027452947u)) % 3u)
						{
						case 0u:
							goto IL_47;
						case 1u:
							output.WriteRawTag(8);
							output.WriteInt32(this.Value);
							arg_2F_0 = (num * 1802663389u ^ 3051821361u);
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
			if (this.Value != 0)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 852522544u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 2001946324u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 2u:
							num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
							arg_2E_0 = (num2 * 2797276253u ^ 3481634520u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(Int32Value other)
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
				switch ((num = (arg_37_0 ^ 541808812u)) % 5u)
				{
				case 1u:
					return;
				case 2u:
					goto IL_63;
				case 3u:
					goto IL_2D;
				case 4u:
					this.Value = other.Value;
					arg_37_0 = (num * 2378591240u ^ 2143410110u);
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1089335315u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Value == 0) ? 632715310u : 175303262u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A8:
				uint num;
				uint arg_71_0 = ((num = input.ReadTag()) == 0u) ? 919392537u : 937717755u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_71_0 ^ 905453410u)) % 7u)
					{
					case 0u:
						arg_71_0 = 937717755u;
						continue;
					case 1u:
						arg_71_0 = ((num != 8u) ? 1120270762u : 1875403783u);
						continue;
					case 2u:
						this.Value = input.ReadInt32();
						arg_71_0 = 146764270u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_71_0 = (num2 * 3333569259u ^ 2327061085u);
						continue;
					case 5u:
						arg_71_0 = (num2 * 3984621633u ^ 629657481u);
						continue;
					case 6u:
						goto IL_A8;
					}
					return;
				}
			}
		}
	}
}
