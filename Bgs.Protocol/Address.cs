using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Address : IMessage<Address>, IEquatable<Address>, IDeepCloneable<Address>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Address.__c __9 = new Address.__c();

			internal Address cctor>b__29_0()
			{
				return new Address();
			}
		}

		private static readonly MessageParser<Address> _parser = new MessageParser<Address>(new Func<Address>(Address.__c.__9.<.cctor>b__29_0));

		public const int Address_FieldNumber = 1;

		private string address_ = "";

		public const int PortFieldNumber = 2;

		private uint port_;

		public static MessageParser<Address> Parser
		{
			get
			{
				return Address._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Address.Descriptor;
			}
		}

		public string Address_
		{
			get
			{
				return this.address_;
			}
			set
			{
				this.address_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public uint Port
		{
			get
			{
				return this.port_;
			}
			set
			{
				this.port_ = value;
			}
		}

		public Address()
		{
		}

		public Address(Address other) : this()
		{
			this.address_ = other.address_;
			this.port_ = other.port_;
		}

		public Address Clone()
		{
			return new Address(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Address);
		}

		public bool Equals(Address other)
		{
			if (other == null)
			{
				goto IL_68;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1141965681) % 9)
				{
				case 0:
					goto IL_B0;
				case 2:
					goto IL_68;
				case 3:
					return false;
				case 4:
					arg_72_0 = (Address.smethod_0(this.Address_, other.Address_) ? 1224884589 : 1585560374);
					continue;
				case 5:
					arg_72_0 = ((this.Port == other.Port) ? 355975896 : 2131483726);
					continue;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_68:
			arg_72_0 = 188933318;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1699268511 : 27009317);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (Address.smethod_1(this.Address_) != 0)
			{
				goto IL_5E;
			}
			goto IL_94;
			uint arg_68_0;
			while (true)
			{
				IL_63:
				uint num2;
				switch ((num2 = (arg_68_0 ^ 540162365u)) % 5u)
				{
				case 0u:
					goto IL_5E;
				case 2u:
					num ^= this.Port.GetHashCode();
					arg_68_0 = (num2 * 2195541771u ^ 1538048316u);
					continue;
				case 3u:
					num ^= Address.smethod_2(this.Address_);
					arg_68_0 = (num2 * 1149761982u ^ 4156151173u);
					continue;
				case 4u:
					goto IL_94;
				}
				break;
			}
			return num;
			IL_5E:
			arg_68_0 = 366305514u;
			goto IL_63;
			IL_94:
			arg_68_0 = ((this.Port == 0u) ? 1262520304u : 1167358681u);
			goto IL_63;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (Address.smethod_1(this.Address_) != 0)
			{
				goto IL_1F;
			}
			goto IL_9B;
			uint arg_6F_0;
			while (true)
			{
				IL_6A:
				uint num;
				switch ((num = (arg_6F_0 ^ 2507342582u)) % 5u)
				{
				case 1u:
					output.WriteRawTag(16);
					output.WriteUInt32(this.Port);
					arg_6F_0 = (num * 2672317964u ^ 4224139948u);
					continue;
				case 2u:
					goto IL_9B;
				case 3u:
					output.WriteRawTag(10);
					output.WriteString(this.Address_);
					arg_6F_0 = (num * 4139644404u ^ 3068099138u);
					continue;
				case 4u:
					goto IL_1F;
				}
				break;
			}
			return;
			IL_1F:
			arg_6F_0 = 4241781515u;
			goto IL_6A;
			IL_9B:
			arg_6F_0 = ((this.Port != 0u) ? 3048208283u : 2242993584u);
			goto IL_6A;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (Address.smethod_1(this.Address_) != 0)
			{
				goto IL_40;
			}
			goto IL_95;
			uint arg_69_0;
			while (true)
			{
				IL_64:
				uint num2;
				switch ((num2 = (arg_69_0 ^ 2618308694u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Address_);
					arg_69_0 = (num2 * 52310661u ^ 2459443852u);
					continue;
				case 2u:
					goto IL_40;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
					arg_69_0 = (num2 * 1011224170u ^ 2720716401u);
					continue;
				case 4u:
					goto IL_95;
				}
				break;
			}
			return num;
			IL_40:
			arg_69_0 = 3003851337u;
			goto IL_64;
			IL_95:
			arg_69_0 = ((this.Port == 0u) ? 2505095833u : 2148466546u);
			goto IL_64;
		}

		public void MergeFrom(Address other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 2007036733u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					goto IL_AD;
				case 2u:
					arg_76_0 = ((other.Port != 0u) ? 889150574u : 454640458u);
					continue;
				case 3u:
					this.Address_ = other.Address_;
					arg_76_0 = (num * 1898859439u ^ 3679643417u);
					continue;
				case 4u:
					this.Port = other.Port;
					arg_76_0 = (num * 3291169591u ^ 2558206111u);
					continue;
				case 5u:
					return;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 962890857u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((Address.smethod_1(other.Address_) == 0) ? 1598209576u : 602829346u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_104:
				uint num;
				uint arg_C0_0 = ((num = input.ReadTag()) == 0u) ? 1049885926u : 846020443u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C0_0 ^ 168299603u)) % 10u)
					{
					case 0u:
						arg_C0_0 = 846020443u;
						continue;
					case 1u:
						this.Address_ = input.ReadString();
						arg_C0_0 = 567788184u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_C0_0 = (num2 * 676841190u ^ 1487617826u);
						continue;
					case 4u:
						goto IL_104;
					case 5u:
						arg_C0_0 = (num2 * 3802216727u ^ 890882430u);
						continue;
					case 6u:
						arg_C0_0 = ((num != 10u) ? 499096013u : 538430626u);
						continue;
					case 7u:
						arg_C0_0 = (num2 * 1418968567u ^ 3758331032u);
						continue;
					case 8u:
						arg_C0_0 = (((num == 16u) ? 1592741762u : 1291171837u) ^ num2 * 2793548394u);
						continue;
					case 9u:
						this.Port = input.ReadUInt32();
						arg_C0_0 = 1019743811u;
						continue;
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
