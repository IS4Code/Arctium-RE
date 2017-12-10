using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Api : IMessage<Api>, IEquatable<Api>, IDeepCloneable<Api>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Api.__c __9 = new Api.__c();

			internal Api cctor>b__54_0()
			{
				return new Api();
			}
		}

		private static readonly MessageParser<Api> _parser = new MessageParser<Api>(new Func<Api>(Api.__c.__9.<.cctor>b__54_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int MethodsFieldNumber = 2;

		private static readonly FieldCodec<Method> _repeated_methods_codec;

		private readonly RepeatedField<Method> methods_ = new RepeatedField<Method>();

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int VersionFieldNumber = 4;

		private string version_ = "";

		public const int SourceContextFieldNumber = 5;

		private SourceContext sourceContext_;

		public const int MixinsFieldNumber = 6;

		private static readonly FieldCodec<Mixin> _repeated_mixins_codec;

		private readonly RepeatedField<Mixin> mixins_ = new RepeatedField<Mixin>();

		public const int SyntaxFieldNumber = 7;

		private Syntax syntax_;

		public static MessageParser<Api> Parser
		{
			get
			{
				return Api._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ApiReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Api.Descriptor;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public RepeatedField<Method> Methods
		{
			get
			{
				return this.methods_;
			}
		}

		public RepeatedField<Option> Options
		{
			get
			{
				return this.options_;
			}
		}

		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
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

		public RepeatedField<Mixin> Mixins
		{
			get
			{
				return this.mixins_;
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

		public Api()
		{
		}

		public Api(Api other) : this()
		{
			this.name_ = other.name_;
			this.methods_ = other.methods_.Clone();
			this.options_ = other.options_.Clone();
			this.version_ = other.version_;
			this.SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
			this.mixins_ = other.mixins_.Clone();
			this.syntax_ = other.syntax_;
		}

		public Api Clone()
		{
			return new Api(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Api);
		}

		public bool Equals(Api other)
		{
			if (other == null)
			{
				goto IL_156;
			}
			goto IL_1C6;
			int arg_160_0;
			while (true)
			{
				IL_15B:
				switch ((arg_160_0 ^ -346602447) % 19)
				{
				case 0:
					goto IL_156;
				case 1:
					arg_160_0 = (Api.smethod_0(this.Name, other.Name) ? -1704325421 : -1642518890);
					continue;
				case 3:
					arg_160_0 = ((this.Syntax == other.Syntax) ? -761228795 : -1475230797);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_160_0 = ((!this.options_.Equals(other.options_)) ? -764027783 : -750391997);
					continue;
				case 7:
					arg_160_0 = (Api.smethod_1(this.SourceContext, other.SourceContext) ? -2023673789 : -449988170);
					continue;
				case 8:
					arg_160_0 = ((!Api.smethod_0(this.Version, other.Version)) ? -2119453973 : -1222105613);
					continue;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					goto IL_1C6;
				case 12:
					return false;
				case 13:
					return true;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					arg_160_0 = ((!this.methods_.Equals(other.methods_)) ? -2105640475 : -1818238691);
					continue;
				case 17:
					return false;
				case 18:
					arg_160_0 = ((!this.mixins_.Equals(other.mixins_)) ? -1782281356 : -2092789272);
					continue;
				}
				break;
			}
			return true;
			IL_156:
			arg_160_0 = -1119302020;
			goto IL_15B;
			IL_1C6:
			arg_160_0 = ((other != this) ? -797699822 : -326848124);
			goto IL_15B;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1C7:
				uint arg_186_0 = 483151928u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_186_0 ^ 656733592u)) % 13u)
					{
					case 0u:
						num ^= Api.smethod_3(this.mixins_);
						arg_186_0 = 360122091u;
						continue;
					case 1u:
						arg_186_0 = (((this.Syntax == Syntax.SYNTAX_PROTO2) ? 1046253635u : 916974952u) ^ num2 * 1799291894u);
						continue;
					case 2u:
						goto IL_1C7;
					case 3u:
						num ^= Api.smethod_3(this.options_);
						arg_186_0 = (num2 * 1423521943u ^ 2778778583u);
						continue;
					case 4u:
						arg_186_0 = ((this.sourceContext_ == null) ? 1961392822u : 1400751998u);
						continue;
					case 5u:
						num ^= Api.smethod_3(this.Version);
						arg_186_0 = (num2 * 1412768054u ^ 46988048u);
						continue;
					case 6u:
						num ^= this.Syntax.GetHashCode();
						arg_186_0 = (num2 * 2448716936u ^ 917845329u);
						continue;
					case 8u:
						arg_186_0 = (((Api.smethod_2(this.Name) == 0) ? 2008319100u : 1347036302u) ^ num2 * 473897034u);
						continue;
					case 9u:
						num ^= Api.smethod_3(this.Name);
						arg_186_0 = (num2 * 1835972913u ^ 3405706058u);
						continue;
					case 10u:
						num ^= Api.smethod_3(this.SourceContext);
						arg_186_0 = (num2 * 448925025u ^ 4282748304u);
						continue;
					case 11u:
						arg_186_0 = (((Api.smethod_2(this.Version) == 0) ? 1268914824u : 859267408u) ^ num2 * 2116067912u);
						continue;
					case 12u:
						num ^= Api.smethod_3(this.methods_);
						arg_186_0 = 1274606072u;
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
			if (Api.smethod_2(this.Name) != 0)
			{
				goto IL_104;
			}
			goto IL_1A7;
			uint arg_16A_0;
			while (true)
			{
				IL_165:
				uint num;
				switch ((num = (arg_16A_0 ^ 3246565033u)) % 12u)
				{
				case 0u:
					arg_16A_0 = ((this.sourceContext_ != null) ? 4061048456u : 3190117843u);
					continue;
				case 1u:
					output.WriteRawTag(42);
					output.WriteMessage(this.SourceContext);
					arg_16A_0 = (num * 3422430355u ^ 946740000u);
					continue;
				case 2u:
					this.mixins_.WriteTo(output, Api._repeated_mixins_codec);
					arg_16A_0 = 3225832178u;
					continue;
				case 3u:
					goto IL_104;
				case 4u:
					this.options_.WriteTo(output, Api._repeated_options_codec);
					arg_16A_0 = (((Api.smethod_2(this.Version) != 0) ? 2998250845u : 2712821109u) ^ num * 1188794185u);
					continue;
				case 5u:
					output.WriteRawTag(56);
					arg_16A_0 = (num * 1589568392u ^ 2809229027u);
					continue;
				case 6u:
					goto IL_1A7;
				case 7u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_16A_0 = (num * 2589535238u ^ 550271089u);
					continue;
				case 8u:
					output.WriteRawTag(34);
					output.WriteString(this.Version);
					arg_16A_0 = (num * 4091013533u ^ 1961919569u);
					continue;
				case 10u:
					output.WriteEnum((int)this.Syntax);
					arg_16A_0 = (num * 1841660642u ^ 577258040u);
					continue;
				case 11u:
					arg_16A_0 = (((this.Syntax != Syntax.SYNTAX_PROTO2) ? 4177886523u : 3232150471u) ^ num * 1990184609u);
					continue;
				}
				break;
			}
			return;
			IL_104:
			arg_16A_0 = 4189173370u;
			goto IL_165;
			IL_1A7:
			this.methods_.WriteTo(output, Api._repeated_methods_codec);
			arg_16A_0 = 2665179017u;
			goto IL_165;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1C2:
				uint arg_185_0 = 3515005152u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_185_0 ^ 2448941514u)) % 12u)
					{
					case 0u:
						num += this.mixins_.CalculateSize(Api._repeated_mixins_codec);
						arg_185_0 = 3515229828u;
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_185_0 = (num2 * 4109269571u ^ 1441798833u);
						continue;
					case 2u:
						num += this.options_.CalculateSize(Api._repeated_options_codec);
						arg_185_0 = (((Api.smethod_2(this.Version) == 0) ? 2718871235u : 2395111544u) ^ num2 * 2371454043u);
						continue;
					case 3u:
						arg_185_0 = ((this.sourceContext_ != null) ? 3535556969u : 3438329066u);
						continue;
					case 4u:
						num += this.methods_.CalculateSize(Api._repeated_methods_codec);
						arg_185_0 = 2803402680u;
						continue;
					case 5u:
						goto IL_1C2;
					case 6u:
						arg_185_0 = (((Api.smethod_2(this.Name) == 0) ? 1585209980u : 1462079573u) ^ num2 * 1224269439u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.SourceContext);
						arg_185_0 = (num2 * 1830641409u ^ 264212809u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
						arg_185_0 = (num2 * 164038361u ^ 967320401u);
						continue;
					case 10u:
						arg_185_0 = (((this.Syntax == Syntax.SYNTAX_PROTO2) ? 2354080687u : 3581472721u) ^ num2 * 2193343646u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Syntax);
						arg_185_0 = (num2 * 4066319558u ^ 3214646577u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Api other)
		{
			if (other == null)
			{
				goto IL_36;
			}
			goto IL_1F7;
			uint arg_19F_0;
			while (true)
			{
				IL_19A:
				uint num;
				switch ((num = (arg_19F_0 ^ 286525219u)) % 15u)
				{
				case 0u:
					arg_19F_0 = (((this.sourceContext_ != null) ? 552901493u : 1060573310u) ^ num * 3216527277u);
					continue;
				case 1u:
					arg_19F_0 = (((other.Syntax != Syntax.SYNTAX_PROTO2) ? 3104830951u : 4290574759u) ^ num * 1999647994u);
					continue;
				case 2u:
					this.Version = other.Version;
					arg_19F_0 = (num * 107552016u ^ 3620995360u);
					continue;
				case 3u:
					this.options_.Add(other.options_);
					arg_19F_0 = (((Api.smethod_2(other.Version) != 0) ? 1260352833u : 1703999142u) ^ num * 2478416687u);
					continue;
				case 4u:
					this.Syntax = other.Syntax;
					arg_19F_0 = (num * 3261282669u ^ 2566392979u);
					continue;
				case 5u:
					this.sourceContext_ = new SourceContext();
					arg_19F_0 = (num * 2690917715u ^ 3232982994u);
					continue;
				case 6u:
					this.methods_.Add(other.methods_);
					arg_19F_0 = 908889657u;
					continue;
				case 7u:
					this.mixins_.Add(other.mixins_);
					arg_19F_0 = 435321587u;
					continue;
				case 9u:
					this.SourceContext.MergeFrom(other.SourceContext);
					arg_19F_0 = 459278409u;
					continue;
				case 10u:
					arg_19F_0 = ((other.sourceContext_ != null) ? 1003208373u : 459278409u);
					continue;
				case 11u:
					goto IL_36;
				case 12u:
					goto IL_1F7;
				case 13u:
					return;
				case 14u:
					this.Name = other.Name;
					arg_19F_0 = (num * 396399359u ^ 4053630740u);
					continue;
				}
				break;
			}
			return;
			IL_36:
			arg_19F_0 = 1729446145u;
			goto IL_19A;
			IL_1F7:
			arg_19F_0 = ((Api.smethod_2(other.Name) != 0) ? 2052098666u : 1071719075u);
			goto IL_19A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_330:
				uint num;
				uint arg_2AC_0 = ((num = input.ReadTag()) != 0u) ? 4110862664u : 3824667989u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2AC_0 ^ 3789259971u)) % 26u)
					{
					case 0u:
						arg_2AC_0 = (num2 * 2197230266u ^ 3843197192u);
						continue;
					case 1u:
						arg_2AC_0 = (((num != 18u) ? 1503916128u : 93172511u) ^ num2 * 605257036u);
						continue;
					case 2u:
						this.mixins_.AddEntriesFrom(input, Api._repeated_mixins_codec);
						arg_2AC_0 = 4266255286u;
						continue;
					case 3u:
						this.Version = input.ReadString();
						arg_2AC_0 = 2663096258u;
						continue;
					case 4u:
						this.methods_.AddEntriesFrom(input, Api._repeated_methods_codec);
						arg_2AC_0 = 4266255286u;
						continue;
					case 5u:
						goto IL_330;
					case 6u:
						this.Name = input.ReadString();
						arg_2AC_0 = 4266255286u;
						continue;
					case 7u:
						arg_2AC_0 = ((num <= 26u) ? 2537901777u : 3487289015u);
						continue;
					case 8u:
						this.sourceContext_ = new SourceContext();
						arg_2AC_0 = (num2 * 235980164u ^ 2687174996u);
						continue;
					case 9u:
						arg_2AC_0 = (num2 * 985445888u ^ 2678543798u);
						continue;
					case 10u:
						arg_2AC_0 = (((num != 10u) ? 1704819074u : 937673525u) ^ num2 * 2263173275u);
						continue;
					case 11u:
						arg_2AC_0 = (num2 * 491435352u ^ 783550142u);
						continue;
					case 12u:
						arg_2AC_0 = ((num != 50u) ? 3574117690u : 3286446381u);
						continue;
					case 13u:
						arg_2AC_0 = 4110862664u;
						continue;
					case 14u:
						this.syntax_ = (Syntax)input.ReadEnum();
						arg_2AC_0 = 4266255286u;
						continue;
					case 15u:
						arg_2AC_0 = (((num != 26u) ? 1173995215u : 604647373u) ^ num2 * 3683636443u);
						continue;
					case 16u:
						arg_2AC_0 = (((num == 34u) ? 2866044238u : 2698686721u) ^ num2 * 1006984977u);
						continue;
					case 17u:
						arg_2AC_0 = (num2 * 2971615873u ^ 2884181469u);
						continue;
					case 19u:
						input.SkipLastField();
						arg_2AC_0 = 4266255286u;
						continue;
					case 20u:
						arg_2AC_0 = (((num != 42u) ? 2491170373u : 3861937067u) ^ num2 * 2495504230u);
						continue;
					case 21u:
						this.options_.AddEntriesFrom(input, Api._repeated_options_codec);
						arg_2AC_0 = 4266255286u;
						continue;
					case 22u:
						arg_2AC_0 = ((num > 42u) ? 2913380767u : 3000465087u);
						continue;
					case 23u:
						arg_2AC_0 = (((num == 56u) ? 3592166683u : 2395544196u) ^ num2 * 2438938008u);
						continue;
					case 24u:
						arg_2AC_0 = ((this.sourceContext_ == null) ? 3847898941u : 4071656876u);
						continue;
					case 25u:
						input.ReadMessage(this.sourceContext_);
						arg_2AC_0 = 3348639008u;
						continue;
					}
					return;
				}
			}
		}

		static Api()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_8C:
				uint arg_70_0 = 1556543896u;
				while (true)
				{
					uint num;
					switch ((num = (arg_70_0 ^ 1064954005u)) % 4u)
					{
					case 1u:
						Api._repeated_methods_codec = FieldCodec.ForMessage<Method>(18u, Method.Parser);
						arg_70_0 = (num * 841577041u ^ 3219778555u);
						continue;
					case 2u:
						goto IL_8C;
					case 3u:
						Api._repeated_options_codec = FieldCodec.ForMessage<Option>(26u, Option.Parser);
						Api._repeated_mixins_codec = FieldCodec.ForMessage<Mixin>(50u, Mixin.Parser);
						arg_70_0 = (num * 2049841296u ^ 1703811221u);
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
