using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class AttributeFilter : IMessage<AttributeFilter>, IEquatable<AttributeFilter>, IDeepCloneable<AttributeFilter>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Operation
			{
				MATCH_NONE,
				MATCH_ANY,
				MATCH_ALL,
				MATCH_ALL_MOST_SPECIFIC
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AttributeFilter.__c __9 = new AttributeFilter.__c();

			internal AttributeFilter cctor>b__30_0()
			{
				return new AttributeFilter();
			}
		}

		private static readonly MessageParser<AttributeFilter> _parser = new MessageParser<AttributeFilter>(new Func<AttributeFilter>(AttributeFilter.__c.__9.<.cctor>b__30_0));

		public const int OpFieldNumber = 1;

		private AttributeFilter.Types.Operation op_;

		public const int AttributeFieldNumber = 2;

		private static readonly FieldCodec<Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		public static MessageParser<AttributeFilter> Parser
		{
			get
			{
				return AttributeFilter._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeFilter.Descriptor;
			}
		}

		public AttributeFilter.Types.Operation Op
		{
			get
			{
				return this.op_;
			}
			set
			{
				this.op_ = value;
			}
		}

		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public AttributeFilter()
		{
		}

		public AttributeFilter(AttributeFilter other) : this()
		{
			this.op_ = other.op_;
			this.attribute_ = other.attribute_.Clone();
		}

		public AttributeFilter Clone()
		{
			return new AttributeFilter(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeFilter);
		}

		public bool Equals(AttributeFilter other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1946807198) % 9)
				{
				case 0:
					return false;
				case 2:
					arg_72_0 = ((this.Op != other.Op) ? 1068643491 : 1853057737);
					continue;
				case 3:
					return true;
				case 4:
					goto IL_41;
				case 5:
					goto IL_B0;
				case 6:
					return false;
				case 7:
					arg_72_0 = (this.attribute_.Equals(other.attribute_) ? 390032858 : 1988620071);
					continue;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 797789712;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 1349497312 : 2084391724);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_8E:
				uint arg_6E_0 = 1996022142u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6E_0 ^ 1788315031u)) % 5u)
					{
					case 0u:
						num ^= AttributeFilter.smethod_0(this.attribute_);
						arg_6E_0 = 428627075u;
						continue;
					case 2u:
						arg_6E_0 = (((this.Op == AttributeFilter.Types.Operation.MATCH_NONE) ? 3244598914u : 3887803613u) ^ num2 * 1720588797u);
						continue;
					case 3u:
						goto IL_8E;
					case 4u:
						num ^= this.Op.GetHashCode();
						arg_6E_0 = (num2 * 2888450848u ^ 1638003495u);
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
			if (this.Op != AttributeFilter.Types.Operation.MATCH_NONE)
			{
				goto IL_3B;
			}
			goto IL_65;
			uint arg_45_0;
			while (true)
			{
				IL_40:
				uint num;
				switch ((num = (arg_45_0 ^ 4259520043u)) % 5u)
				{
				case 0u:
					goto IL_3B;
				case 2u:
					goto IL_65;
				case 3u:
					output.WriteEnum((int)this.Op);
					arg_45_0 = (num * 45100453u ^ 1494289585u);
					continue;
				case 4u:
					output.WriteRawTag(8);
					arg_45_0 = (num * 2721099529u ^ 2484777325u);
					continue;
				}
				break;
			}
			return;
			IL_3B:
			arg_45_0 = 2165774735u;
			goto IL_40;
			IL_65:
			this.attribute_.WriteTo(output, AttributeFilter._repeated_attribute_codec);
			arg_45_0 = 2436265336u;
			goto IL_40;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_8C:
				uint arg_6C_0 = 370105057u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6C_0 ^ 1995481097u)) % 5u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Op);
						arg_6C_0 = (num2 * 1668818304u ^ 3706835839u);
						continue;
					case 3u:
						arg_6C_0 = (((this.Op != AttributeFilter.Types.Operation.MATCH_NONE) ? 325120572u : 996688639u) ^ num2 * 1209306944u);
						continue;
					case 4u:
						num += this.attribute_.CalculateSize(AttributeFilter._repeated_attribute_codec);
						arg_6C_0 = 413137883u;
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AttributeFilter other)
		{
			if (other == null)
			{
				goto IL_45;
			}
			goto IL_7F;
			uint arg_4F_0;
			while (true)
			{
				IL_4A:
				uint num;
				switch ((num = (arg_4F_0 ^ 2730507951u)) % 6u)
				{
				case 0u:
					goto IL_45;
				case 2u:
					this.attribute_.Add(other.attribute_);
					arg_4F_0 = 3840456902u;
					continue;
				case 3u:
					this.Op = other.Op;
					arg_4F_0 = (num * 3526410773u ^ 2832359064u);
					continue;
				case 4u:
					goto IL_7F;
				case 5u:
					return;
				}
				break;
			}
			return;
			IL_45:
			arg_4F_0 = 2560921410u;
			goto IL_4A;
			IL_7F:
			arg_4F_0 = ((other.Op != AttributeFilter.Types.Operation.MATCH_NONE) ? 2916209036u : 3365109063u);
			goto IL_4A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F5:
				uint num;
				uint arg_B5_0 = ((num = input.ReadTag()) != 0u) ? 594147930u : 1872496343u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B5_0 ^ 1386747605u)) % 9u)
					{
					case 0u:
						this.attribute_.AddEntriesFrom(input, AttributeFilter._repeated_attribute_codec);
						arg_B5_0 = 481901600u;
						continue;
					case 1u:
						arg_B5_0 = (num2 * 3437492267u ^ 887274129u);
						continue;
					case 2u:
						arg_B5_0 = 594147930u;
						continue;
					case 3u:
						arg_B5_0 = (((num != 18u) ? 1957521271u : 176141500u) ^ num2 * 3581537769u);
						continue;
					case 4u:
						arg_B5_0 = ((num != 8u) ? 802975884u : 1081338731u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_B5_0 = (num2 * 384369197u ^ 2153177057u);
						continue;
					case 7u:
						goto IL_F5;
					case 8u:
						this.op_ = (AttributeFilter.Types.Operation)input.ReadEnum();
						arg_B5_0 = 481901600u;
						continue;
					}
					return;
				}
			}
		}

		static AttributeFilter()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 4244788924u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2369492972u)) % 3u)
					{
					case 1u:
						AttributeFilter._repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18u, Bgs.Protocol.Attribute.Parser);
						arg_3F_0 = (num * 3543738473u ^ 3282758969u);
						continue;
					case 2u:
						goto IL_57;
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
