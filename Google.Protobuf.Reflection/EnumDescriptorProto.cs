using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class EnumDescriptorProto : IMessage, IMessage<EnumDescriptorProto>, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EnumDescriptorProto.__c __9 = new EnumDescriptorProto.__c();

			internal EnumDescriptorProto cctor>b__34_0()
			{
				return new EnumDescriptorProto();
			}
		}

		private static readonly MessageParser<EnumDescriptorProto> _parser = new MessageParser<EnumDescriptorProto>(new Func<EnumDescriptorProto>(EnumDescriptorProto.__c.__9.<.cctor>b__34_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int ValueFieldNumber = 2;

		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec = FieldCodec.ForMessage<EnumValueDescriptorProto>(18u, EnumValueDescriptorProto.Parser);

		private readonly RepeatedField<EnumValueDescriptorProto> value_ = new RepeatedField<EnumValueDescriptorProto>();

		public const int OptionsFieldNumber = 3;

		private EnumOptions options_;

		public static MessageParser<EnumDescriptorProto> Parser
		{
			get
			{
				return EnumDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumDescriptorProto.Descriptor;
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

		public RepeatedField<EnumValueDescriptorProto> Value
		{
			get
			{
				return this.value_;
			}
		}

		public EnumOptions Options
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

		public EnumDescriptorProto()
		{
		}

		public EnumDescriptorProto(EnumDescriptorProto other) : this()
		{
			while (true)
			{
				IL_4F:
				uint arg_37_0 = 3583027738u;
				while (true)
				{
					uint num;
					switch ((num = (arg_37_0 ^ 3207444171u)) % 3u)
					{
					case 1u:
						this.name_ = other.name_;
						this.value_ = other.value_.Clone();
						arg_37_0 = (num * 4051144683u ^ 1466357238u);
						continue;
					case 2u:
						goto IL_4F;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		public EnumDescriptorProto Clone()
		{
			return new EnumDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EnumDescriptorProto);
		}

		public bool Equals(EnumDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -1414053471) % 11)
				{
				case 0:
					return false;
				case 2:
					return true;
				case 3:
					goto IL_EC;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_A6_0 = (this.value_.Equals(other.value_) ? -1821096414 : -143280070);
					continue;
				case 8:
					goto IL_70;
				case 9:
					arg_A6_0 = (EnumDescriptorProto.smethod_1(this.Options, other.Options) ? -1728868168 : -1752064520);
					continue;
				case 10:
					arg_A6_0 = (EnumDescriptorProto.smethod_0(this.Name, other.Name) ? -1455985321 : -1426572226);
					continue;
				}
				break;
			}
			return true;
			IL_70:
			arg_A6_0 = -1968910298;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? -604279226 : -1191623345);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_DB:
				uint arg_B3_0 = 1419085585u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 1782627800u)) % 7u)
					{
					case 0u:
						goto IL_DB;
					case 1u:
						num ^= EnumDescriptorProto.smethod_3(this.Name);
						arg_B3_0 = (num2 * 4083131951u ^ 3280901643u);
						continue;
					case 2u:
						num ^= EnumDescriptorProto.smethod_3(this.value_);
						arg_B3_0 = 1250246935u;
						continue;
					case 3u:
						arg_B3_0 = (((this.options_ == null) ? 3645083910u : 3575554912u) ^ num2 * 3069653675u);
						continue;
					case 4u:
						arg_B3_0 = (((EnumDescriptorProto.smethod_2(this.Name) != 0) ? 3830717957u : 3890084150u) ^ num2 * 374788069u);
						continue;
					case 5u:
						num ^= EnumDescriptorProto.smethod_3(this.Options);
						arg_B3_0 = (num2 * 503295642u ^ 2311602033u);
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
			if (EnumDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_10;
			}
			goto IL_D6;
			uint arg_AA_0;
			while (true)
			{
				IL_A5:
				uint num;
				switch ((num = (arg_AA_0 ^ 2576308299u)) % 8u)
				{
				case 0u:
					output.WriteMessage(this.Options);
					arg_AA_0 = (num * 646676745u ^ 2468427693u);
					continue;
				case 1u:
					arg_AA_0 = (((this.options_ == null) ? 3773583719u : 3009899908u) ^ num * 2036100962u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_AA_0 = (num * 3793222529u ^ 2632587274u);
					continue;
				case 3u:
					output.WriteString(this.Name);
					arg_AA_0 = (num * 2989553306u ^ 2044931977u);
					continue;
				case 4u:
					goto IL_D6;
				case 5u:
					output.WriteRawTag(26);
					arg_AA_0 = (num * 2601738234u ^ 4084689985u);
					continue;
				case 7u:
					goto IL_10;
				}
				break;
			}
			return;
			IL_10:
			arg_AA_0 = 3646755121u;
			goto IL_A5;
			IL_D6:
			this.value_.WriteTo(output, EnumDescriptorProto._repeated_value_codec);
			arg_AA_0 = 3022488434u;
			goto IL_A5;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_CE:
				uint arg_AA_0 = 2040518267u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AA_0 ^ 770840654u)) % 6u)
					{
					case 0u:
						num += this.value_.CalculateSize(EnumDescriptorProto._repeated_value_codec);
						arg_AA_0 = ((this.options_ == null) ? 1868083158u : 269235015u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_AA_0 = (num2 * 3328087006u ^ 389403416u);
						continue;
					case 2u:
						goto IL_CE;
					case 3u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_AA_0 = (num2 * 4135452238u ^ 2331068402u);
						continue;
					case 5u:
						arg_AA_0 = (((EnumDescriptorProto.smethod_2(this.Name) != 0) ? 867209106u : 1556891879u) ^ num2 * 123471139u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(EnumDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_C0;
			}
			goto IL_126;
			uint arg_E2_0;
			while (true)
			{
				IL_DD:
				uint num;
				switch ((num = (arg_E2_0 ^ 2527487274u)) % 10u)
				{
				case 0u:
					this.value_.Add(other.value_);
					arg_E2_0 = 3514047607u;
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_C0;
				case 3u:
					arg_E2_0 = (((this.options_ == null) ? 4218478974u : 3763324286u) ^ num * 3160968643u);
					continue;
				case 4u:
					this.Name = other.Name;
					arg_E2_0 = (num * 2325998445u ^ 4222070794u);
					continue;
				case 5u:
					arg_E2_0 = (((other.options_ != null) ? 4059454748u : 3238382039u) ^ num * 1948486255u);
					continue;
				case 6u:
					goto IL_126;
				case 7u:
					this.Options.MergeFrom(other.Options);
					arg_E2_0 = 2489321604u;
					continue;
				case 9u:
					this.options_ = new EnumOptions();
					arg_E2_0 = (num * 3234058922u ^ 689252287u);
					continue;
				}
				break;
			}
			return;
			IL_C0:
			arg_E2_0 = 3440882639u;
			goto IL_DD;
			IL_126:
			arg_E2_0 = ((EnumDescriptorProto.smethod_2(other.Name) != 0) ? 4180653882u : 2585039066u);
			goto IL_DD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1B2:
				uint num;
				uint arg_15A_0 = ((num = input.ReadTag()) != 0u) ? 4196627856u : 2193591558u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_15A_0 ^ 3116675066u)) % 15u)
					{
					case 0u:
						input.SkipLastField();
						arg_15A_0 = (num2 * 4250599422u ^ 1951220087u);
						continue;
					case 1u:
						this.Name = input.ReadString();
						arg_15A_0 = 2345823838u;
						continue;
					case 2u:
						arg_15A_0 = (num2 * 1825089361u ^ 2225799342u);
						continue;
					case 4u:
						arg_15A_0 = (((num == 18u) ? 1556105368u : 118657317u) ^ num2 * 891016683u);
						continue;
					case 5u:
						arg_15A_0 = 4196627856u;
						continue;
					case 6u:
						arg_15A_0 = ((this.options_ != null) ? 2217100484u : 4064708417u);
						continue;
					case 7u:
						arg_15A_0 = ((num != 10u) ? 2410080337u : 3970536255u);
						continue;
					case 8u:
						this.value_.AddEntriesFrom(input, EnumDescriptorProto._repeated_value_codec);
						arg_15A_0 = 4154108200u;
						continue;
					case 9u:
						arg_15A_0 = (num2 * 2733460576u ^ 238979075u);
						continue;
					case 10u:
						goto IL_1B2;
					case 11u:
						arg_15A_0 = (((num != 26u) ? 1478256780u : 2073274236u) ^ num2 * 3040836509u);
						continue;
					case 12u:
						this.options_ = new EnumOptions();
						arg_15A_0 = (num2 * 840218256u ^ 853647348u);
						continue;
					case 13u:
						arg_15A_0 = (num2 * 2638765897u ^ 1786780257u);
						continue;
					case 14u:
						input.ReadMessage(this.options_);
						arg_15A_0 = 2565326211u;
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
