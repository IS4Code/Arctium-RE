using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Attribute : IMessage<Attribute>, IEquatable<Attribute>, IDeepCloneable<Attribute>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Attribute.__c __9 = new Attribute.__c();

			internal Attribute cctor>b__29_0()
			{
				return new Attribute();
			}
		}

		private static readonly MessageParser<Attribute> _parser = new MessageParser<Attribute>(new Func<Attribute>(Attribute.__c.__9.<.cctor>b__29_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int ValueFieldNumber = 2;

		private Variant value_;

		public static MessageParser<Attribute> Parser
		{
			get
			{
				return Attribute._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Attribute.Descriptor;
			}
		}

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public Variant Value
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

		public Attribute()
		{
		}

		public Attribute(Attribute other) : this()
		{
			this.name_ = other.name_;
			this.Value = ((other.value_ != null) ? other.Value.Clone() : null);
		}

		public Attribute Clone()
		{
			return new Attribute(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Attribute);
		}

		public bool Equals(Attribute other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -397246943) % 9)
				{
				case 0:
					goto IL_B5;
				case 2:
					arg_77_0 = (Attribute.smethod_0(this.Name, other.Name) ? -908047197 : -764957006);
					continue;
				case 3:
					return false;
				case 4:
					arg_77_0 = (Attribute.smethod_1(this.Value, other.Value) ? -1104395530 : -19163910);
					continue;
				case 5:
					return true;
				case 6:
					goto IL_15;
				case 7:
					return false;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -98832027;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? -892104369 : -908873573);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ Attribute.smethod_2(this.Name) ^ Attribute.smethod_2(this.Value);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			while (true)
			{
				IL_7A:
				uint arg_5A_0 = 3892346721u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 3085630562u)) % 5u)
					{
					case 0u:
						goto IL_7A;
					case 1u:
						output.WriteRawTag(18);
						arg_5A_0 = (num * 1185210585u ^ 1416897137u);
						continue;
					case 2u:
						output.WriteMessage(this.Value);
						arg_5A_0 = (num * 2099161203u ^ 542558782u);
						continue;
					case 3u:
						output.WriteString(this.Name);
						arg_5A_0 = (num * 2513104209u ^ 2041399234u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeStringSize(this.Name)) + (1 + CodedOutputStream.ComputeMessageSize(this.Value));
		}

		public void MergeFrom(Attribute other)
		{
			if (other == null)
			{
				goto IL_5C;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 547831224u)) % 9u)
				{
				case 0u:
					this.Name = other.Name;
					arg_BC_0 = (num * 1774095613u ^ 3682209267u);
					continue;
				case 1u:
					this.value_ = new Variant();
					arg_BC_0 = (num * 424544086u ^ 2201794949u);
					continue;
				case 2u:
					arg_BC_0 = ((other.value_ != null) ? 814509243u : 1434468247u);
					continue;
				case 3u:
					goto IL_5C;
				case 5u:
					arg_BC_0 = (((this.value_ == null) ? 356394885u : 138452319u) ^ num * 4209913508u);
					continue;
				case 6u:
					return;
				case 7u:
					goto IL_FC;
				case 8u:
					this.Value.MergeFrom(other.Value);
					arg_BC_0 = 1434468247u;
					continue;
				}
				break;
			}
			return;
			IL_5C:
			arg_BC_0 = 1805810552u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((Attribute.smethod_3(other.Name) == 0) ? 1026070909u : 1029918366u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_153:
				uint num;
				uint arg_107_0 = ((num = input.ReadTag()) != 0u) ? 265423580u : 1712036896u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_107_0 ^ 1437190637u)) % 12u)
					{
					case 0u:
						arg_107_0 = 265423580u;
						continue;
					case 1u:
						arg_107_0 = ((num == 10u) ? 819515532u : 1809132943u);
						continue;
					case 2u:
						arg_107_0 = (((num != 18u) ? 2721404663u : 4019503450u) ^ num2 * 3297885908u);
						continue;
					case 3u:
						arg_107_0 = ((this.value_ != null) ? 1786109682u : 1601053971u);
						continue;
					case 4u:
						goto IL_153;
					case 6u:
						this.value_ = new Variant();
						arg_107_0 = (num2 * 1541781704u ^ 231237762u);
						continue;
					case 7u:
						input.ReadMessage(this.value_);
						arg_107_0 = 585932897u;
						continue;
					case 8u:
						arg_107_0 = (num2 * 2875010486u ^ 3672313057u);
						continue;
					case 9u:
						this.Name = input.ReadString();
						arg_107_0 = 1313421314u;
						continue;
					case 10u:
						input.SkipLastField();
						arg_107_0 = (num2 * 3827489861u ^ 1712042071u);
						continue;
					case 11u:
						arg_107_0 = (num2 * 2718028517u ^ 2222053546u);
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

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
