using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Type : IMessage<Type>, IEquatable<Type>, IDeepCloneable<Type>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Type.__c __9 = new Type.__c();

			internal Type cctor>b__49_0()
			{
				return new Type();
			}
		}

		private static readonly MessageParser<Type> _parser = new MessageParser<Type>(new Func<Type>(Type.__c.__9.<.cctor>b__49_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int FieldsFieldNumber = 2;

		private static readonly FieldCodec<Field> _repeated_fields_codec;

		private readonly RepeatedField<Field> fields_ = new RepeatedField<Field>();

		public const int OneofsFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_oneofs_codec;

		private readonly RepeatedField<string> oneofs_ = new RepeatedField<string>();

		public const int OptionsFieldNumber = 4;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int SourceContextFieldNumber = 5;

		private SourceContext sourceContext_;

		public const int SyntaxFieldNumber = 6;

		private Syntax syntax_;

		public static MessageParser<Type> Parser
		{
			get
			{
				return Type._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return TypeReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Type.Descriptor;
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

		public RepeatedField<Field> Fields
		{
			get
			{
				return this.fields_;
			}
		}

		public RepeatedField<string> Oneofs
		{
			get
			{
				return this.oneofs_;
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

		public Type()
		{
		}

		public Type(Type other) : this()
		{
			while (true)
			{
				IL_A7:
				uint arg_8B_0 = 1594218872u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8B_0 ^ 1784191605u)) % 4u)
					{
					case 0u:
						this.options_ = other.options_.Clone();
						this.SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
						this.syntax_ = other.syntax_;
						arg_8B_0 = 30791374u;
						continue;
					case 1u:
						this.name_ = other.name_;
						this.fields_ = other.fields_.Clone();
						this.oneofs_ = other.oneofs_.Clone();
						arg_8B_0 = (num * 1149469267u ^ 1325660066u);
						continue;
					case 2u:
						goto IL_A7;
					}
					return;
				}
			}
		}

		public Type Clone()
		{
			return new Type(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Type);
		}

		public bool Equals(Type other)
		{
			if (other == null)
			{
				goto IL_CF;
			}
			goto IL_18F;
			int arg_131_0;
			while (true)
			{
				IL_12C:
				switch ((arg_131_0 ^ 2114162229) % 17)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_131_0 = ((!this.options_.Equals(other.options_)) ? 208225108 : 1123407628);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					arg_131_0 = (Type.smethod_0(this.Name, other.Name) ? 315116262 : 1121047835);
					continue;
				case 7:
					goto IL_CF;
				case 9:
					arg_131_0 = ((this.Syntax == other.Syntax) ? 1686557502 : 474422881);
					continue;
				case 10:
					arg_131_0 = (Type.smethod_1(this.SourceContext, other.SourceContext) ? 1257128765 : 1117512738);
					continue;
				case 11:
					goto IL_18F;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_131_0 = ((!this.oneofs_.Equals(other.oneofs_)) ? 1826603795 : 1068833382);
					continue;
				case 16:
					arg_131_0 = ((!this.fields_.Equals(other.fields_)) ? 1932502070 : 459823872);
					continue;
				}
				break;
			}
			return true;
			IL_CF:
			arg_131_0 = 648993521;
			goto IL_12C;
			IL_18F:
			arg_131_0 = ((other != this) ? 698317207 : 17421203);
			goto IL_12C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_176:
				uint arg_13D_0 = 3551578512u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_13D_0 ^ 2684541398u)) % 11u)
					{
					case 0u:
						num ^= Type.smethod_3(this.Name);
						arg_13D_0 = (num2 * 598040055u ^ 2934889532u);
						continue;
					case 2u:
						num ^= Type.smethod_3(this.fields_);
						arg_13D_0 = 2465774428u;
						continue;
					case 3u:
						goto IL_176;
					case 4u:
						num ^= this.Syntax.GetHashCode();
						arg_13D_0 = (num2 * 2500589407u ^ 2680514981u);
						continue;
					case 5u:
						arg_13D_0 = (((this.sourceContext_ != null) ? 839243781u : 399095481u) ^ num2 * 118666725u);
						continue;
					case 6u:
						num ^= Type.smethod_3(this.oneofs_);
						arg_13D_0 = (num2 * 3094813739u ^ 194445020u);
						continue;
					case 7u:
						arg_13D_0 = (((Type.smethod_2(this.Name) == 0) ? 1063613245u : 2141242785u) ^ num2 * 3869679140u);
						continue;
					case 8u:
						arg_13D_0 = ((this.Syntax == Syntax.SYNTAX_PROTO2) ? 3810278041u : 4157471634u);
						continue;
					case 9u:
						num ^= Type.smethod_3(this.SourceContext);
						arg_13D_0 = (num2 * 2841999123u ^ 3780500600u);
						continue;
					case 10u:
						num ^= Type.smethod_3(this.options_);
						arg_13D_0 = (num2 * 3491902742u ^ 4053679412u);
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
			if (Type.smethod_2(this.Name) != 0)
			{
				goto IL_111;
			}
			goto IL_150;
			uint arg_11B_0;
			while (true)
			{
				IL_116:
				uint num;
				switch ((num = (arg_11B_0 ^ 3396584263u)) % 10u)
				{
				case 0u:
					goto IL_111;
				case 1u:
					this.options_.WriteTo(output, Type._repeated_options_codec);
					arg_11B_0 = (((this.sourceContext_ != null) ? 3099866348u : 2457687287u) ^ num * 2008561098u);
					continue;
				case 2u:
					arg_11B_0 = ((this.Syntax != Syntax.SYNTAX_PROTO2) ? 3868271045u : 4037443208u);
					continue;
				case 3u:
					output.WriteMessage(this.SourceContext);
					arg_11B_0 = (num * 535794424u ^ 778472253u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_11B_0 = (num * 3939516736u ^ 3141754223u);
					continue;
				case 5u:
					output.WriteRawTag(42);
					arg_11B_0 = (num * 106097591u ^ 1649219793u);
					continue;
				case 6u:
					output.WriteRawTag(48);
					output.WriteEnum((int)this.Syntax);
					arg_11B_0 = (num * 648277266u ^ 1221212588u);
					continue;
				case 8u:
					goto IL_150;
				case 9u:
					this.oneofs_.WriteTo(output, Type._repeated_oneofs_codec);
					arg_11B_0 = (num * 2715144859u ^ 2096967227u);
					continue;
				}
				break;
			}
			return;
			IL_111:
			arg_11B_0 = 3446956009u;
			goto IL_116;
			IL_150:
			this.fields_.WriteTo(output, Type._repeated_fields_codec);
			arg_11B_0 = 3474051324u;
			goto IL_116;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_16F:
				uint arg_13A_0 = 2173434570u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_13A_0 ^ 3983612156u)) % 10u)
					{
					case 0u:
						goto IL_16F;
					case 1u:
						num += this.options_.CalculateSize(Type._repeated_options_codec);
						arg_13A_0 = (num2 * 386158043u ^ 2530997346u);
						continue;
					case 3u:
						arg_13A_0 = (((this.sourceContext_ == null) ? 3515602950u : 2807441700u) ^ num2 * 2101828367u);
						continue;
					case 4u:
						num += this.fields_.CalculateSize(Type._repeated_fields_codec);
						num += this.oneofs_.CalculateSize(Type._repeated_oneofs_codec);
						arg_13A_0 = 2846669633u;
						continue;
					case 5u:
						arg_13A_0 = ((this.Syntax == Syntax.SYNTAX_PROTO2) ? 2360905952u : 3627108046u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Syntax);
						arg_13A_0 = (num2 * 4199339026u ^ 1540921188u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_13A_0 = (num2 * 2710985862u ^ 3305458544u);
						continue;
					case 8u:
						arg_13A_0 = (((Type.smethod_2(this.Name) == 0) ? 3228541812u : 2273499305u) ^ num2 * 3757963089u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SourceContext);
						arg_13A_0 = (num2 * 3802474499u ^ 295355340u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Type other)
		{
			if (other == null)
			{
				goto IL_125;
			}
			goto IL_1A8;
			uint arg_158_0;
			while (true)
			{
				IL_153:
				uint num;
				switch ((num = (arg_158_0 ^ 1530256243u)) % 13u)
				{
				case 0u:
					this.fields_.Add(other.fields_);
					this.oneofs_.Add(other.oneofs_);
					arg_158_0 = 1118211876u;
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_125;
				case 3u:
					arg_158_0 = (((this.sourceContext_ != null) ? 635270549u : 1497180455u) ^ num * 810807132u);
					continue;
				case 4u:
					this.Name = other.Name;
					arg_158_0 = (num * 674857504u ^ 642612187u);
					continue;
				case 5u:
					this.sourceContext_ = new SourceContext();
					arg_158_0 = (num * 3704994604u ^ 183082057u);
					continue;
				case 6u:
					arg_158_0 = ((other.Syntax == Syntax.SYNTAX_PROTO2) ? 315676387u : 1518235027u);
					continue;
				case 8u:
					this.Syntax = other.Syntax;
					arg_158_0 = (num * 1280848897u ^ 2913067011u);
					continue;
				case 9u:
					this.options_.Add(other.options_);
					arg_158_0 = (num * 114902021u ^ 147302606u);
					continue;
				case 10u:
					goto IL_1A8;
				case 11u:
					this.SourceContext.MergeFrom(other.SourceContext);
					arg_158_0 = 1252830302u;
					continue;
				case 12u:
					arg_158_0 = (((other.sourceContext_ != null) ? 4268735796u : 2591164048u) ^ num * 2524571809u);
					continue;
				}
				break;
			}
			return;
			IL_125:
			arg_158_0 = 331129230u;
			goto IL_153;
			IL_1A8:
			arg_158_0 = ((Type.smethod_2(other.Name) == 0) ? 983867771u : 248541686u);
			goto IL_153;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2C4:
				uint num;
				uint arg_24C_0 = ((num = input.ReadTag()) != 0u) ? 3303222548u : 2466391961u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_24C_0 ^ 3932053189u)) % 23u)
					{
					case 0u:
						this.options_.AddEntriesFrom(input, Type._repeated_options_codec);
						arg_24C_0 = 4239985109u;
						continue;
					case 1u:
						arg_24C_0 = ((num > 26u) ? 3057928683u : 2765646242u);
						continue;
					case 2u:
						arg_24C_0 = (num2 * 3090298617u ^ 583141695u);
						continue;
					case 3u:
						this.syntax_ = (Syntax)input.ReadEnum();
						arg_24C_0 = 3755402035u;
						continue;
					case 4u:
						arg_24C_0 = ((num != 34u) ? 2625866792u : 2827263868u);
						continue;
					case 5u:
						arg_24C_0 = ((this.sourceContext_ == null) ? 2444856007u : 4107853847u);
						continue;
					case 6u:
						arg_24C_0 = (num2 * 1731559032u ^ 3494661299u);
						continue;
					case 7u:
						arg_24C_0 = 3303222548u;
						continue;
					case 8u:
						arg_24C_0 = (((num == 26u) ? 4071630309u : 3256478085u) ^ num2 * 1489682256u);
						continue;
					case 9u:
						arg_24C_0 = (((num == 18u) ? 1684128132u : 2065955360u) ^ num2 * 2521500490u);
						continue;
					case 10u:
						arg_24C_0 = (num2 * 3823040250u ^ 1283205715u);
						continue;
					case 11u:
						arg_24C_0 = (num2 * 1141052967u ^ 3212520913u);
						continue;
					case 12u:
						this.sourceContext_ = new SourceContext();
						arg_24C_0 = (num2 * 3317172375u ^ 3407281465u);
						continue;
					case 13u:
						input.ReadMessage(this.sourceContext_);
						arg_24C_0 = 3755402035u;
						continue;
					case 14u:
						this.fields_.AddEntriesFrom(input, Type._repeated_fields_codec);
						arg_24C_0 = 3427043211u;
						continue;
					case 15u:
						arg_24C_0 = (((num == 10u) ? 875231425u : 1133002015u) ^ num2 * 3277510381u);
						continue;
					case 16u:
						arg_24C_0 = (((num != 42u) ? 2870773346u : 3054552501u) ^ num2 * 1559962450u);
						continue;
					case 17u:
						this.Name = input.ReadString();
						arg_24C_0 = 2552326325u;
						continue;
					case 18u:
						goto IL_2C4;
					case 20u:
						this.oneofs_.AddEntriesFrom(input, Type._repeated_oneofs_codec);
						arg_24C_0 = 3755402035u;
						continue;
					case 21u:
						arg_24C_0 = (((num != 48u) ? 229460365u : 1571170583u) ^ num2 * 3536442826u);
						continue;
					case 22u:
						input.SkipLastField();
						arg_24C_0 = 3755402035u;
						continue;
					}
					return;
				}
			}
		}

		static Type()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_76:
				uint arg_5A_0 = 1610957627u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 878504226u)) % 4u)
					{
					case 0u:
						Type._repeated_oneofs_codec = FieldCodec.ForString(26u);
						arg_5A_0 = (num * 2245590197u ^ 2186357532u);
						continue;
					case 1u:
						Type._repeated_fields_codec = FieldCodec.ForMessage<Field>(18u, Field.Parser);
						arg_5A_0 = (num * 1955988881u ^ 3088312643u);
						continue;
					case 3u:
						goto IL_76;
					}
					goto Block_1;
				}
			}
			Block_1:
			Type._repeated_options_codec = FieldCodec.ForMessage<Option>(34u, Option.Parser);
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
