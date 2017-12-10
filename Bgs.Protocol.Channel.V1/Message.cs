using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class Message : IMessage<Message>, IEquatable<Message>, IDeepCloneable<Message>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Message.__c __9 = new Message.__c();

			internal Message cctor>b__29_0()
			{
				return new Message();
			}
		}

		private static readonly MessageParser<Message> _parser = new MessageParser<Message>(new Func<Message>(Message.__c.__9.<.cctor>b__29_0));

		public const int AttributeFieldNumber = 1;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int RoleFieldNumber = 2;

		private uint role_;

		public static MessageParser<Message> Parser
		{
			get
			{
				return Message._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Message.Descriptor;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public uint Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		public Message()
		{
		}

		public Message(Message other) : this()
		{
			this.attribute_ = other.attribute_.Clone();
			this.role_ = other.role_;
		}

		public Message Clone()
		{
			return new Message(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Message);
		}

		public bool Equals(Message other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 917011753) % 9)
				{
				case 0:
					goto IL_B0;
				case 1:
					return false;
				case 3:
					arg_72_0 = (this.attribute_.Equals(other.attribute_) ? 142559893 : 880211137);
					continue;
				case 4:
					arg_72_0 = ((this.Role != other.Role) ? 1760297628 : 977368931);
					continue;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					goto IL_15;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1583712050;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1824785408 : 655392523);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ Message.smethod_0(this.attribute_);
			if (this.Role != 0u)
			{
				while (true)
				{
					IL_55:
					uint arg_3D_0 = 1628807470u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_3D_0 ^ 968989574u)) % 3u)
						{
						case 1u:
							num ^= this.Role.GetHashCode();
							arg_3D_0 = (num2 * 1374681289u ^ 792880783u);
							continue;
						case 2u:
							goto IL_55;
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
			this.attribute_.WriteTo(output, Message._repeated_attribute_codec);
			while (true)
			{
				IL_91:
				uint arg_71_0 = 4072673482u;
				while (true)
				{
					uint num;
					switch ((num = (arg_71_0 ^ 2467167577u)) % 5u)
					{
					case 0u:
						output.WriteUInt32(this.Role);
						arg_71_0 = (num * 1880385083u ^ 2315297312u);
						continue;
					case 1u:
						arg_71_0 = (((this.Role == 0u) ? 1382626764u : 325588656u) ^ num * 3937749765u);
						continue;
					case 3u:
						goto IL_91;
					case 4u:
						output.WriteRawTag(16);
						arg_71_0 = (num * 1569248049u ^ 2719746406u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_94:
				uint arg_74_0 = 1125617646u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_74_0 ^ 1345921330u)) % 5u)
					{
					case 0u:
						goto IL_94;
					case 1u:
						arg_74_0 = (((this.Role == 0u) ? 1382871014u : 355662388u) ^ num2 * 414887864u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Role);
						arg_74_0 = (num2 * 4130484164u ^ 3942499270u);
						continue;
					case 4u:
						num += this.attribute_.CalculateSize(Message._repeated_attribute_codec);
						arg_74_0 = (num2 * 2376997406u ^ 1763857127u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Message other)
		{
			if (other == null)
			{
				goto IL_03;
			}
			goto IL_75;
			uint arg_51_0;
			while (true)
			{
				IL_4C:
				uint num;
				switch ((num = (arg_51_0 ^ 660388135u)) % 6u)
				{
				case 0u:
					this.Role = other.Role;
					arg_51_0 = (num * 444549921u ^ 1667334955u);
					continue;
				case 1u:
					arg_51_0 = (((other.Role != 0u) ? 1395285971u : 2109604639u) ^ num * 19252138u);
					continue;
				case 2u:
					return;
				case 3u:
					goto IL_75;
				case 5u:
					goto IL_03;
				}
				break;
			}
			return;
			IL_03:
			arg_51_0 = 744721893u;
			goto IL_4C;
			IL_75:
			this.attribute_.Add(other.attribute_);
			arg_51_0 = 1764741318u;
			goto IL_4C;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F6:
				uint num;
				uint arg_B6_0 = ((num = input.ReadTag()) == 0u) ? 97398078u : 1971738860u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B6_0 ^ 1083856943u)) % 9u)
					{
					case 0u:
						this.attribute_.AddEntriesFrom(input, Message._repeated_attribute_codec);
						arg_B6_0 = 623170901u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_B6_0 = (num2 * 3927630755u ^ 1898451081u);
						continue;
					case 2u:
						arg_B6_0 = (num2 * 1922622400u ^ 3214214022u);
						continue;
					case 3u:
						arg_B6_0 = ((num == 10u) ? 238611348u : 547080935u);
						continue;
					case 4u:
						arg_B6_0 = 1971738860u;
						continue;
					case 5u:
						arg_B6_0 = (((num != 16u) ? 927062066u : 395756235u) ^ num2 * 1280070879u);
						continue;
					case 6u:
						goto IL_F6;
					case 7u:
						this.Role = input.ReadUInt32();
						arg_B6_0 = 626543110u;
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
