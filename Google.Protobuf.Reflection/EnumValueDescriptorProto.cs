using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class EnumValueDescriptorProto : IMessage, IMessage<EnumValueDescriptorProto>, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
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
				goto IL_70;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ 1840541157) % 11)
				{
				case 0:
					arg_A1_0 = ((this.Number == other.Number) ? 878094131 : 1415942322);
					continue;
				case 1:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_70;
				case 5:
					return false;
				case 6:
					goto IL_E7;
				case 7:
					return false;
				case 8:
					arg_A1_0 = ((!EnumValueDescriptorProto.smethod_0(this.Name, other.Name)) ? 1665612210 : 1718659749);
					continue;
				case 9:
					return false;
				case 10:
					arg_A1_0 = ((!EnumValueDescriptorProto.smethod_1(this.Options, other.Options)) ? 46153982 : 710840577);
					continue;
				}
				break;
			}
			return true;
			IL_70:
			arg_A1_0 = 1734122711;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other != this) ? 1913856769 : 1190987048);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (EnumValueDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_61;
			}
			goto IL_E0;
			uint arg_A9_0;
			while (true)
			{
				IL_A4:
				uint num2;
				switch ((num2 = (arg_A9_0 ^ 3869885749u)) % 7u)
				{
				case 0u:
					goto IL_E0;
				case 1u:
					num ^= EnumValueDescriptorProto.smethod_3(this.Name);
					arg_A9_0 = (num2 * 2590166497u ^ 341871494u);
					continue;
				case 2u:
					arg_A9_0 = ((this.options_ == null) ? 3759999374u : 3673493719u);
					continue;
				case 3u:
					goto IL_61;
				case 5u:
					num ^= this.Number.GetHashCode();
					arg_A9_0 = (num2 * 1618593041u ^ 3849097665u);
					continue;
				case 6u:
					num ^= this.Options.GetHashCode();
					arg_A9_0 = (num2 * 280181554u ^ 1013962154u);
					continue;
				}
				break;
			}
			return num;
			IL_61:
			arg_A9_0 = 2643661025u;
			goto IL_A4;
			IL_E0:
			arg_A9_0 = ((this.Number != 0) ? 3134094060u : 3799657384u);
			goto IL_A4;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (EnumValueDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_89;
			}
			goto IL_ED;
			uint arg_B6_0;
			while (true)
			{
				IL_B1:
				uint num;
				switch ((num = (arg_B6_0 ^ 520154637u)) % 7u)
				{
				case 0u:
					goto IL_ED;
				case 1u:
					output.WriteRawTag(26);
					output.WriteMessage(this.Options);
					arg_B6_0 = (num * 2431476233u ^ 3352763537u);
					continue;
				case 2u:
					goto IL_89;
				case 3u:
					arg_B6_0 = ((this.options_ != null) ? 1993183563u : 1360484839u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_B6_0 = (num * 3642561847u ^ 3529179594u);
					continue;
				case 6u:
					output.WriteRawTag(16);
					output.WriteInt32(this.Number);
					arg_B6_0 = (num * 1381156763u ^ 3884862749u);
					continue;
				}
				break;
			}
			return;
			IL_89:
			arg_B6_0 = 1020624441u;
			goto IL_B1;
			IL_ED:
			arg_B6_0 = ((this.Number != 0) ? 1156662935u : 1027245603u);
			goto IL_B1;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_109:
				uint arg_DD_0 = 2168626081u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_DD_0 ^ 2623945568u)) % 8u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_DD_0 = (num2 * 3370437486u ^ 676259282u);
						continue;
					case 1u:
						arg_DD_0 = (((EnumValueDescriptorProto.smethod_2(this.Name) != 0) ? 2052658303u : 2079846117u) ^ num2 * 2102187495u);
						continue;
					case 2u:
						arg_DD_0 = ((this.Number != 0) ? 3718694383u : 3654143070u);
						continue;
					case 4u:
						goto IL_109;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_DD_0 = (num2 * 2637414206u ^ 4200534853u);
						continue;
					case 6u:
						arg_DD_0 = ((this.options_ != null) ? 3190361549u : 2620277667u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Number);
						arg_DD_0 = (num2 * 2144113274u ^ 3956740728u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(EnumValueDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_D6;
			}
			goto IL_149;
			uint arg_101_0;
			while (true)
			{
				IL_FC:
				uint num;
				switch ((num = (arg_101_0 ^ 2361033034u)) % 11u)
				{
				case 0u:
					arg_101_0 = ((other.options_ != null) ? 3326123077u : 3412493915u);
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_149;
				case 3u:
					goto IL_D6;
				case 4u:
					this.Name = other.Name;
					arg_101_0 = (num * 2089651179u ^ 3023085377u);
					continue;
				case 5u:
					arg_101_0 = (((this.options_ == null) ? 351839920u : 521341363u) ^ num * 643450108u);
					continue;
				case 6u:
					this.options_ = new EnumValueOptions();
					arg_101_0 = (num * 1050700606u ^ 3795732595u);
					continue;
				case 7u:
					this.Number = other.Number;
					arg_101_0 = (num * 301779362u ^ 469411551u);
					continue;
				case 9u:
					this.Options.MergeFrom(other.Options);
					arg_101_0 = 3412493915u;
					continue;
				case 10u:
					arg_101_0 = ((other.Number != 0) ? 2721343409u : 2821167881u);
					continue;
				}
				break;
			}
			return;
			IL_D6:
			arg_101_0 = 2678849780u;
			goto IL_FC;
			IL_149:
			arg_101_0 = ((EnumValueDescriptorProto.smethod_2(other.Name) != 0) ? 3366434421u : 3786634388u);
			goto IL_FC;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_197:
				uint num;
				uint arg_143_0 = ((num = input.ReadTag()) == 0u) ? 3153443074u : 4249859298u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_143_0 ^ 3537903097u)) % 14u)
					{
					case 0u:
						goto IL_197;
					case 1u:
						arg_143_0 = ((num == 10u) ? 3562366876u : 2214760667u);
						continue;
					case 2u:
						arg_143_0 = (((num == 16u) ? 1468204330u : 1456427168u) ^ num2 * 913208907u);
						continue;
					case 3u:
						this.Number = input.ReadInt32();
						arg_143_0 = 3746306851u;
						continue;
					case 4u:
						arg_143_0 = (num2 * 819669225u ^ 2810706061u);
						continue;
					case 5u:
						this.Name = input.ReadString();
						arg_143_0 = 2683550779u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_143_0 = (num2 * 1037936867u ^ 1949640027u);
						continue;
					case 7u:
						input.ReadMessage(this.options_);
						arg_143_0 = 2829432039u;
						continue;
					case 8u:
						arg_143_0 = (num2 * 1279973656u ^ 2427267287u);
						continue;
					case 9u:
						arg_143_0 = (((num == 26u) ? 3118754930u : 2591917724u) ^ num2 * 1466250463u);
						continue;
					case 10u:
						arg_143_0 = ((this.options_ != null) ? 2531700482u : 3340471554u);
						continue;
					case 12u:
						arg_143_0 = 4249859298u;
						continue;
					case 13u:
						this.options_ = new EnumValueOptions();
						arg_143_0 = (num2 * 1583626810u ^ 1392843228u);
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
