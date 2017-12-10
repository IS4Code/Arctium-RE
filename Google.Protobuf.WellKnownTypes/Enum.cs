using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Enum : IMessage<Enum>, IEquatable<Enum>, IDeepCloneable<Enum>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Enum.__c __9 = new Enum.__c();

			internal Enum cctor>b__44_0()
			{
				return new Enum();
			}
		}

		private static readonly MessageParser<Enum> _parser = new MessageParser<Enum>(new Func<Enum>(Enum.__c.__9.<.cctor>b__44_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int EnumvalueFieldNumber = 2;

		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec;

		private readonly RepeatedField<EnumValue> enumvalue_ = new RepeatedField<EnumValue>();

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int SourceContextFieldNumber = 4;

		private SourceContext sourceContext_;

		public const int SyntaxFieldNumber = 5;

		private Syntax syntax_;

		public static MessageParser<Enum> Parser
		{
			get
			{
				return Enum._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return TypeReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Enum.Descriptor;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public RepeatedField<EnumValue> Enumvalue
		{
			get
			{
				return this.enumvalue_;
			}
		}

		public RepeatedField<Option> Options
		{
			get
			{
				return this.options_;
			}
		}

		public SourceContext SourceContext
		{
			get
			{
				return this.sourceContext_;
			}
			set
			{
				this.sourceContext_ = value;
			}
		}

		public Syntax Syntax
		{
			get
			{
				return this.syntax_;
			}
			set
			{
				this.syntax_ = value;
			}
		}

		public Enum()
		{
		}

		public Enum(Enum other) : this()
		{
			while (true)
			{
				IL_73:
				uint arg_57_0 = 3538489200u;
				while (true)
				{
					uint num;
					switch ((num = (arg_57_0 ^ 2930211458u)) % 4u)
					{
					case 1u:
						this.options_ = other.options_.Clone();
						arg_57_0 = (num * 2928075236u ^ 1734520718u);
						continue;
					case 2u:
						this.name_ = other.name_;
						this.enumvalue_ = other.enumvalue_.Clone();
						arg_57_0 = (num * 2971254826u ^ 2493607435u);
						continue;
					case 3u:
						goto IL_73;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
			this.syntax_ = other.syntax_;
		}

		public Enum Clone()
		{
			return new Enum(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Enum);
		}

		public bool Equals(Enum other)
		{
			if (other == null)
			{
				goto IL_42;
			}
			goto IL_158;
			int arg_102_0;
			while (true)
			{
				IL_FD:
				switch ((arg_102_0 ^ 323937694) % 15)
				{
				case 0:
					return false;
				case 1:
					arg_102_0 = (this.options_.Equals(other.options_) ? 1778596814 : 102109882);
					continue;
				case 2:
					return false;
				case 3:
					arg_102_0 = ((!this.enumvalue_.Equals(other.enumvalue_)) ? 740800639 : 929888477);
					continue;
				case 4:
					goto IL_158;
				case 5:
					arg_102_0 = (Enum.smethod_1(this.SourceContext, other.SourceContext) ? 1971345696 : 1379682474);
					continue;
				case 6:
					return false;
				case 8:
					arg_102_0 = ((!Enum.smethod_0(this.Name, other.Name)) ? 648473018 : 1229851147);
					continue;
				case 9:
					return false;
				case 10:
					goto IL_42;
				case 11:
					arg_102_0 = ((this.Syntax != other.Syntax) ? 2026398253 : 32462452);
					continue;
				case 12:
					return true;
				case 13:
					return false;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_42:
			arg_102_0 = 983936600;
			goto IL_FD;
			IL_158:
			arg_102_0 = ((other == this) ? 1478286811 : 55114972);
			goto IL_FD;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_13F:
				uint arg_10E_0 = 3175788660u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10E_0 ^ 2850771719u)) % 9u)
					{
					case 0u:
						num ^= Enum.smethod_3(this.enumvalue_);
						arg_10E_0 = 2443717634u;
						continue;
					case 1u:
						arg_10E_0 = (((Enum.smethod_2(this.Name) == 0) ? 1600633408u : 330990562u) ^ num2 * 2337405627u);
						continue;
					case 2u:
						arg_10E_0 = ((this.Syntax == Syntax.SYNTAX_PROTO2) ? 3326155321u : 2847979292u);
						continue;
					case 3u:
						num ^= Enum.smethod_3(this.options_);
						arg_10E_0 = (((this.sourceContext_ != null) ? 1873911089u : 650506936u) ^ num2 * 3546672271u);
						continue;
					case 4u:
						goto IL_13F;
					case 5u:
						num ^= Enum.smethod_3(this.Name);
						arg_10E_0 = (num2 * 1153348899u ^ 4024587629u);
						continue;
					case 6u:
						num ^= Enum.smethod_3(this.SourceContext);
						arg_10E_0 = (num2 * 1558307675u ^ 3816601244u);
						continue;
					case 7u:
						num ^= this.Syntax.GetHashCode();
						arg_10E_0 = (num2 * 2730713023u ^ 2260152092u);
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
			if (Enum.smethod_2(this.Name) != 0)
			{
				goto IL_68;
			}
			goto IL_ED;
			uint arg_B6_0;
			while (true)
			{
				IL_B1:
				uint num;
				switch ((num = (arg_B6_0 ^ 2815538788u)) % 7u)
				{
				case 0u:
					arg_B6_0 = ((this.Syntax == Syntax.SYNTAX_PROTO2) ? 2277914679u : 2578697149u);
					continue;
				case 2u:
					output.WriteRawTag(40);
					output.WriteEnum((int)this.Syntax);
					arg_B6_0 = (num * 577449077u ^ 1536288794u);
					continue;
				case 3u:
					goto IL_68;
				case 4u:
					output.WriteRawTag(34);
					output.WriteMessage(this.SourceContext);
					arg_B6_0 = (num * 3691026681u ^ 2073463643u);
					continue;
				case 5u:
					goto IL_ED;
				case 6u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_B6_0 = (num * 3030877554u ^ 3203150973u);
					continue;
				}
				break;
			}
			return;
			IL_68:
			arg_B6_0 = 3144001046u;
			goto IL_B1;
			IL_ED:
			this.enumvalue_.WriteTo(output, Enum._repeated_enumvalue_codec);
			this.options_.WriteTo(output, Enum._repeated_options_codec);
			arg_B6_0 = ((this.sourceContext_ == null) ? 3497959824u : 3576529031u);
			goto IL_B1;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (Enum.smethod_2(this.Name) != 0)
			{
				goto IL_7C;
			}
			goto IL_11E;
			uint arg_ED_0;
			while (true)
			{
				IL_E8:
				uint num2;
				switch ((num2 = (arg_ED_0 ^ 4212539262u)) % 9u)
				{
				case 0u:
					arg_ED_0 = (((this.sourceContext_ != null) ? 1975020876u : 1521070902u) ^ num2 * 1925253417u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.SourceContext);
					arg_ED_0 = (num2 * 4255239174u ^ 978256858u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Syntax);
					arg_ED_0 = (num2 * 473149217u ^ 2599256690u);
					continue;
				case 4u:
					goto IL_7C;
				case 5u:
					num += this.options_.CalculateSize(Enum._repeated_options_codec);
					arg_ED_0 = (num2 * 37516900u ^ 3433726418u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_ED_0 = (num2 * 1847287784u ^ 1026785608u);
					continue;
				case 7u:
					goto IL_11E;
				case 8u:
					arg_ED_0 = ((this.Syntax == Syntax.SYNTAX_PROTO2) ? 3086837647u : 3611449379u);
					continue;
				}
				break;
			}
			return num;
			IL_7C:
			arg_ED_0 = 3051319952u;
			goto IL_E8;
			IL_11E:
			num += this.enumvalue_.CalculateSize(Enum._repeated_enumvalue_codec);
			arg_ED_0 = 2651850509u;
			goto IL_E8;
		}

		public void MergeFrom(Enum other)
		{
			if (other == null)
			{
				goto IL_128;
			}
			goto IL_17E;
			uint arg_132_0;
			while (true)
			{
				IL_12D:
				uint num;
				switch ((num = (arg_132_0 ^ 680727599u)) % 12u)
				{
				case 0u:
					goto IL_128;
				case 1u:
					this.SourceContext.MergeFrom(other.SourceContext);
					arg_132_0 = 1637777896u;
					continue;
				case 2u:
					arg_132_0 = (((this.sourceContext_ == null) ? 1917014278u : 290389564u) ^ num * 897249047u);
					continue;
				case 3u:
					this.sourceContext_ = new SourceContext();
					arg_132_0 = (num * 2332069736u ^ 331275646u);
					continue;
				case 4u:
					this.Syntax = other.Syntax;
					arg_132_0 = (num * 3092998437u ^ 3086424557u);
					continue;
				case 5u:
					return;
				case 7u:
					this.enumvalue_.Add(other.enumvalue_);
					arg_132_0 = 207582298u;
					continue;
				case 8u:
					goto IL_17E;
				case 9u:
					this.options_.Add(other.options_);
					arg_132_0 = (((other.sourceContext_ == null) ? 1569350962u : 500169443u) ^ num * 274732594u);
					continue;
				case 10u:
					this.Name = other.Name;
					arg_132_0 = (num * 1235462621u ^ 973384326u);
					continue;
				case 11u:
					arg_132_0 = ((other.Syntax != Syntax.SYNTAX_PROTO2) ? 963732999u : 2100559397u);
					continue;
				}
				break;
			}
			return;
			IL_128:
			arg_132_0 = 1606897650u;
			goto IL_12D;
			IL_17E:
			arg_132_0 = ((Enum.smethod_2(other.Name) == 0) ? 1529945420u : 1249382269u);
			goto IL_12D;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_24C:
				uint num;
				uint arg_1E4_0 = ((num = input.ReadTag()) == 0u) ? 2438217364u : 3601903610u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1E4_0 ^ 3148470077u)) % 19u)
					{
					case 0u:
						this.Name = input.ReadString();
						arg_1E4_0 = 2356201729u;
						continue;
					case 1u:
						arg_1E4_0 = ((num > 18u) ? 4036028587u : 4072887269u);
						continue;
					case 2u:
						this.syntax_ = (Syntax)input.ReadEnum();
						arg_1E4_0 = 2356201729u;
						continue;
					case 3u:
						arg_1E4_0 = (((num != 34u) ? 3734350188u : 4153943160u) ^ num2 * 420117721u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_1E4_0 = 2857703609u;
						continue;
					case 5u:
						this.enumvalue_.AddEntriesFrom(input, Enum._repeated_enumvalue_codec);
						arg_1E4_0 = 2356201729u;
						continue;
					case 7u:
						arg_1E4_0 = ((num == 26u) ? 3634850451u : 3837480599u);
						continue;
					case 8u:
						input.ReadMessage(this.sourceContext_);
						arg_1E4_0 = 2356201729u;
						continue;
					case 9u:
						arg_1E4_0 = (((num == 18u) ? 2086820956u : 795988050u) ^ num2 * 304719182u);
						continue;
					case 10u:
						this.sourceContext_ = new SourceContext();
						arg_1E4_0 = (num2 * 362958596u ^ 3326029782u);
						continue;
					case 11u:
						arg_1E4_0 = (num2 * 2737512034u ^ 3862176137u);
						continue;
					case 12u:
						arg_1E4_0 = (((num != 40u) ? 3156659778u : 3337719861u) ^ num2 * 3158042064u);
						continue;
					case 13u:
						arg_1E4_0 = (((num == 10u) ? 3810754177u : 4131919989u) ^ num2 * 1506371928u);
						continue;
					case 14u:
						goto IL_24C;
					case 15u:
						arg_1E4_0 = ((this.sourceContext_ != null) ? 2282154210u : 2434721328u);
						continue;
					case 16u:
						this.options_.AddEntriesFrom(input, Enum._repeated_options_codec);
						arg_1E4_0 = 2356201729u;
						continue;
					case 17u:
						arg_1E4_0 = (num2 * 977052978u ^ 698700476u);
						continue;
					case 18u:
						arg_1E4_0 = 3601903610u;
						continue;
					}
					return;
				}
			}
		}

		static Enum()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 872438385u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5F_0 ^ 948318239u)) % 4u)
					{
					case 0u:
						goto IL_7B;
					case 2u:
						Enum._repeated_enumvalue_codec = FieldCodec.ForMessage<EnumValue>(18u, EnumValue.Parser);
						arg_5F_0 = (num * 286300465u ^ 2298908978u);
						continue;
					case 3u:
						Enum._repeated_options_codec = FieldCodec.ForMessage<Option>(26u, Option.Parser);
						arg_5F_0 = (num * 1331024777u ^ 2765478853u);
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
