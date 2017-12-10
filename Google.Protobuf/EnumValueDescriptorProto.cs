using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EnumValueDescriptorProto.__c __9 = new EnumValueDescriptorProto.__c();

			internal EnumValueDescriptorProto cctor>b__34_0()
			{
				return new EnumValueDescriptorProto();
			}
		}

		private static readonly MessageParser<EnumValueDescriptorProto> _parser = new MessageParser<EnumValueDescriptorProto>(new Func<EnumValueDescriptorProto>(EnumValueDescriptorProto.__c.__9.<.cctor>b__34_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int NumberFieldNumber = 2;

		private int number_;

		public const int OptionsFieldNumber = 3;

		private EnumValueOptions options_;

		public static MessageParser<EnumValueDescriptorProto> Parser
		{
			get
			{
				return EnumValueDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumValueDescriptorProto.Descriptor;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public int Number
		{
			get
			{
				return this.number_;
			}
			set
			{
				this.number_ = value;
			}
		}

		public EnumValueOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		public EnumValueDescriptorProto()
		{
		}

		public EnumValueDescriptorProto(EnumValueDescriptorProto other) : this()
		{
			this.name_ = other.name_;
			this.number_ = other.number_;
			this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		public EnumValueDescriptorProto Clone()
		{
			return new EnumValueDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EnumValueDescriptorProto);
		}

		public bool Equals(EnumValueDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ -974525765) % 11)
				{
				case 0:
					arg_A1_0 = ((this.Number != other.Number) ? -445776076 : -1596871667);
					continue;
				case 1:
					return false;
				case 2:
					arg_A1_0 = ((!EnumValueDescriptorProto.smethod_0(this.Name, other.Name)) ? -1856803592 : -1758011869);
					continue;
				case 3:
					return false;
				case 4:
					arg_A1_0 = ((!EnumValueDescriptorProto.smethod_1(this.Options, other.Options)) ? -492737550 : -1168211758);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_18;
				case 7:
					return true;
				case 8:
					return false;
				case 9:
					goto IL_E7;
				}
				break;
			}
			return true;
			IL_18:
			arg_A1_0 = -832184285;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other != this) ? -1116558190 : -728169520);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_103:
				uint arg_D7_0 = 2830402884u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_D7_0 ^ 3217573507u)) % 8u)
					{
					case 0u:
						goto IL_103;
					case 1u:
						arg_D7_0 = ((this.options_ != null) ? 3073859423u : 3854423472u);
						continue;
					case 2u:
						arg_D7_0 = ((this.Number == 0) ? 2903904874u : 3239804846u);
						continue;
					case 4u:
						num ^= this.Options.GetHashCode();
						arg_D7_0 = (num2 * 815969309u ^ 3857795164u);
						continue;
					case 5u:
						num ^= this.Number.GetHashCode();
						arg_D7_0 = (num2 * 934409641u ^ 3209944543u);
						continue;
					case 6u:
						num ^= EnumValueDescriptorProto.smethod_3(this.Name);
						arg_D7_0 = (num2 * 1269832678u ^ 2666716997u);
						continue;
					case 7u:
						arg_D7_0 = (((EnumValueDescriptorProto.smethod_2(this.Name) != 0) ? 81922766u : 886259282u) ^ num2 * 103638757u);
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
			if (EnumValueDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_22;
			}
			goto IL_103;
			uint arg_C8_0;
			while (true)
			{
				IL_C3:
				uint num;
				switch ((num = (arg_C8_0 ^ 3408774618u)) % 8u)
				{
				case 0u:
					output.WriteString(this.Name);
					arg_C8_0 = (num * 2544968684u ^ 3792851198u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_C8_0 = (num * 1622631856u ^ 408701578u);
					continue;
				case 2u:
					output.WriteRawTag(26);
					output.WriteMessage(this.Options);
					arg_C8_0 = (num * 512366873u ^ 2037853797u);
					continue;
				case 3u:
					output.WriteRawTag(16);
					output.WriteInt32(this.Number);
					arg_C8_0 = (num * 3049131168u ^ 3485748756u);
					continue;
				case 4u:
					goto IL_103;
				case 6u:
					arg_C8_0 = ((this.options_ == null) ? 4218786535u : 4165980936u);
					continue;
				case 7u:
					goto IL_22;
				}
				break;
			}
			return;
			IL_22:
			arg_C8_0 = 2236482371u;
			goto IL_C3;
			IL_103:
			arg_C8_0 = ((this.Number != 0) ? 3565627433u : 4170339828u);
			goto IL_C3;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (EnumValueDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_A5;
			}
			goto IL_E6;
			uint arg_AF_0;
			while (true)
			{
				IL_AA:
				uint num2;
				switch ((num2 = (arg_AF_0 ^ 2491881297u)) % 7u)
				{
				case 0u:
					goto IL_A5;
				case 1u:
					goto IL_E6;
				case 2u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_AF_0 = (num2 * 3220220512u ^ 477537695u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
					arg_AF_0 = (num2 * 216335182u ^ 1492184887u);
					continue;
				case 4u:
					arg_AF_0 = ((this.options_ != null) ? 2675879372u : 2236046817u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeInt32Size(this.Number);
					arg_AF_0 = (num2 * 4268235639u ^ 1156061718u);
					continue;
				}
				break;
			}
			return num;
			IL_A5:
			arg_AF_0 = 3462549981u;
			goto IL_AA;
			IL_E6:
			arg_AF_0 = ((this.Number == 0) ? 3157124139u : 3742658490u);
			goto IL_AA;
		}

		public void MergeFrom(EnumValueDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_93;
			}
			goto IL_149;
			uint arg_101_0;
			while (true)
			{
				IL_FC:
				uint num;
				switch ((num = (arg_101_0 ^ 2633770813u)) % 11u)
				{
				case 0u:
					arg_101_0 = ((other.options_ != null) ? 3896849746u : 3012072221u);
					continue;
				case 1u:
					arg_101_0 = (((this.options_ == null) ? 743721187u : 1296402089u) ^ num * 1318817500u);
					continue;
				case 2u:
					goto IL_149;
				case 4u:
					this.options_ = new EnumValueOptions();
					arg_101_0 = (num * 3634077756u ^ 1328823381u);
					continue;
				case 5u:
					return;
				case 6u:
					goto IL_93;
				case 7u:
					this.Name = other.Name;
					arg_101_0 = (num * 2133214942u ^ 3989571577u);
					continue;
				case 8u:
					arg_101_0 = ((other.Number == 0) ? 3174923586u : 3404604301u);
					continue;
				case 9u:
					this.Options.MergeFrom(other.Options);
					arg_101_0 = 3012072221u;
					continue;
				case 10u:
					this.Number = other.Number;
					arg_101_0 = (num * 2419453955u ^ 1647735634u);
					continue;
				}
				break;
			}
			return;
			IL_93:
			arg_101_0 = 2996794672u;
			goto IL_FC;
			IL_149:
			arg_101_0 = ((EnumValueDescriptorProto.smethod_2(other.Name) != 0) ? 2250272196u : 3266518551u);
			goto IL_FC;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1B0:
				uint num;
				uint arg_158_0 = ((num = input.ReadTag()) != 0u) ? 615741344u : 1703771866u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_158_0 ^ 1132563844u)) % 15u)
					{
					case 0u:
						arg_158_0 = (((num == 16u) ? 1325730666u : 550460469u) ^ num2 * 2800188339u);
						continue;
					case 1u:
						this.Name = input.ReadString();
						arg_158_0 = 366465277u;
						continue;
					case 2u:
						goto IL_1B0;
					case 3u:
						this.options_ = new EnumValueOptions();
						arg_158_0 = (num2 * 4242714385u ^ 632395035u);
						continue;
					case 4u:
						arg_158_0 = ((num == 10u) ? 847778074u : 953651454u);
						continue;
					case 5u:
						input.ReadMessage(this.options_);
						arg_158_0 = 1511996550u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_158_0 = (num2 * 3154744951u ^ 188463784u);
						continue;
					case 7u:
						arg_158_0 = (num2 * 3148781543u ^ 1237399292u);
						continue;
					case 8u:
						arg_158_0 = 615741344u;
						continue;
					case 9u:
						this.Number = input.ReadInt32();
						arg_158_0 = 383292542u;
						continue;
					case 10u:
						arg_158_0 = (((num == 26u) ? 2843326379u : 3097839590u) ^ num2 * 2197681260u);
						continue;
					case 11u:
						arg_158_0 = (num2 * 591246558u ^ 862723688u);
						continue;
					case 13u:
						arg_158_0 = ((this.options_ != null) ? 1614155276u : 627014179u);
						continue;
					case 14u:
						arg_158_0 = (num2 * 1080206112u ^ 2189316550u);
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

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_3(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
