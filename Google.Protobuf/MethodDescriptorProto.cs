using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MethodDescriptorProto.__c __9 = new MethodDescriptorProto.__c();

			internal MethodDescriptorProto cctor>b__39_0()
			{
				return new MethodDescriptorProto();
			}
		}

		private static readonly MessageParser<MethodDescriptorProto> _parser = new MessageParser<MethodDescriptorProto>(new Func<MethodDescriptorProto>(MethodDescriptorProto.__c.__9.<.cctor>b__39_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int InputTypeFieldNumber = 2;

		private string inputType_ = "";

		public const int OutputTypeFieldNumber = 3;

		private string outputType_ = "";

		public const int OptionsFieldNumber = 4;

		private MethodOptions options_;

		public static MessageParser<MethodDescriptorProto> Parser
		{
			get
			{
				return MethodDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MethodDescriptorProto.Descriptor;
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

		public string InputType
		{
			get
			{
				return this.inputType_;
			}
			set
			{
				this.inputType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public string OutputType
		{
			get
			{
				return this.outputType_;
			}
			set
			{
				this.outputType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public MethodOptions Options
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

		public MethodDescriptorProto()
		{
		}

		public MethodDescriptorProto(MethodDescriptorProto other) : this()
		{
			while (true)
			{
				IL_7D:
				uint arg_61_0 = 581221705u;
				while (true)
				{
					uint num;
					switch ((num = (arg_61_0 ^ 1044882612u)) % 4u)
					{
					case 0u:
						goto IL_7D;
					case 1u:
						this.name_ = other.name_;
						this.inputType_ = other.inputType_;
						arg_61_0 = (num * 3782165661u ^ 4163353431u);
						continue;
					case 2u:
						this.outputType_ = other.outputType_;
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_61_0 = 1895263839u;
						continue;
					}
					return;
				}
			}
		}

		public MethodDescriptorProto Clone()
		{
			return new MethodDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MethodDescriptorProto);
		}

		public bool Equals(MethodDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ -2014978059) % 13)
				{
				case 0:
					return true;
				case 1:
					goto IL_126;
				case 2:
					arg_D8_0 = (MethodDescriptorProto.smethod_0(this.OutputType, other.OutputType) ? -1775912267 : -1090055461);
					continue;
				case 3:
					arg_D8_0 = (MethodDescriptorProto.smethod_0(this.InputType, other.InputType) ? -194306618 : -2093050594);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_D8_0 = ((!MethodDescriptorProto.smethod_0(this.Name, other.Name)) ? -337311903 : -522167903);
					continue;
				case 8:
					return false;
				case 9:
					goto IL_47;
				case 11:
					return false;
				case 12:
					arg_D8_0 = (MethodDescriptorProto.smethod_1(this.Options, other.Options) ? -604329728 : -2089561045);
					continue;
				}
				break;
			}
			return true;
			IL_47:
			arg_D8_0 = -603852138;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other != this) ? -1718385416 : -1763475731);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_157:
				uint arg_122_0 = 1260690557u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_122_0 ^ 284979794u)) % 10u)
					{
					case 0u:
						num ^= MethodDescriptorProto.smethod_3(this.InputType);
						arg_122_0 = (num2 * 2704247287u ^ 3501608699u);
						continue;
					case 1u:
						num ^= MethodDescriptorProto.smethod_3(this.Name);
						arg_122_0 = (num2 * 3554312208u ^ 2552742566u);
						continue;
					case 3u:
						arg_122_0 = ((MethodDescriptorProto.smethod_2(this.OutputType) != 0) ? 783610434u : 131298277u);
						continue;
					case 4u:
						num ^= MethodDescriptorProto.smethod_3(this.Options);
						arg_122_0 = (num2 * 203015338u ^ 2600451066u);
						continue;
					case 5u:
						goto IL_157;
					case 6u:
						arg_122_0 = ((MethodDescriptorProto.smethod_2(this.InputType) == 0) ? 917533401u : 1919802940u);
						continue;
					case 7u:
						arg_122_0 = (((MethodDescriptorProto.smethod_2(this.Name) == 0) ? 1336910694u : 675122053u) ^ num2 * 1494071120u);
						continue;
					case 8u:
						num ^= MethodDescriptorProto.smethod_3(this.OutputType);
						arg_122_0 = (num2 * 3827869018u ^ 3847497285u);
						continue;
					case 9u:
						arg_122_0 = ((this.options_ != null) ? 1669038770u : 1215221562u);
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
			if (MethodDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_83;
			}
			goto IL_187;
			uint arg_13B_0;
			while (true)
			{
				IL_136:
				uint num;
				switch ((num = (arg_13B_0 ^ 4246778090u)) % 12u)
				{
				case 0u:
					output.WriteString(this.InputType);
					arg_13B_0 = (num * 785514991u ^ 2168223757u);
					continue;
				case 1u:
					output.WriteRawTag(26);
					arg_13B_0 = (num * 1843012254u ^ 551542337u);
					continue;
				case 2u:
					goto IL_187;
				case 3u:
					output.WriteRawTag(34);
					arg_13B_0 = (num * 2469151363u ^ 1352243929u);
					continue;
				case 5u:
					output.WriteString(this.OutputType);
					arg_13B_0 = (num * 3862230041u ^ 2178512632u);
					continue;
				case 6u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_13B_0 = (num * 2010851305u ^ 4184361342u);
					continue;
				case 7u:
					arg_13B_0 = ((this.options_ != null) ? 3714138197u : 3430540358u);
					continue;
				case 8u:
					goto IL_83;
				case 9u:
					output.WriteRawTag(18);
					arg_13B_0 = (num * 3689672559u ^ 1082091125u);
					continue;
				case 10u:
					output.WriteMessage(this.Options);
					arg_13B_0 = (num * 4051759574u ^ 2114533106u);
					continue;
				case 11u:
					arg_13B_0 = ((MethodDescriptorProto.smethod_2(this.OutputType) == 0) ? 3145798957u : 4198917983u);
					continue;
				}
				break;
			}
			return;
			IL_83:
			arg_13B_0 = 2333710072u;
			goto IL_136;
			IL_187:
			arg_13B_0 = ((MethodDescriptorProto.smethod_2(this.InputType) != 0) ? 3261337399u : 3145111033u);
			goto IL_136;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (MethodDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_24;
			}
			goto IL_13A;
			uint arg_FA_0;
			while (true)
			{
				IL_F5:
				uint num2;
				switch ((num2 = (arg_FA_0 ^ 769896633u)) % 9u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
					arg_FA_0 = (num2 * 1612960734u ^ 1168003708u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_FA_0 = (num2 * 1949399072u ^ 245357387u);
					continue;
				case 3u:
					goto IL_13A;
				case 4u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InputType);
					arg_FA_0 = (num2 * 1167323254u ^ 3074109240u);
					continue;
				case 5u:
					arg_FA_0 = ((MethodDescriptorProto.smethod_2(this.OutputType) == 0) ? 407969155u : 512985482u);
					continue;
				case 6u:
					arg_FA_0 = ((this.options_ != null) ? 1475674352u : 1231706162u);
					continue;
				case 7u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.OutputType);
					arg_FA_0 = (num2 * 2720936503u ^ 2636325494u);
					continue;
				case 8u:
					goto IL_24;
				}
				break;
			}
			return num;
			IL_24:
			arg_FA_0 = 451489806u;
			goto IL_F5;
			IL_13A:
			arg_FA_0 = ((MethodDescriptorProto.smethod_2(this.InputType) != 0) ? 390742646u : 586142802u);
			goto IL_F5;
		}

		public void MergeFrom(MethodDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_50;
			}
			goto IL_19D;
			uint arg_14D_0;
			while (true)
			{
				IL_148:
				uint num;
				switch ((num = (arg_14D_0 ^ 3055961201u)) % 13u)
				{
				case 0u:
					this.InputType = other.InputType;
					arg_14D_0 = (num * 696408208u ^ 1894570422u);
					continue;
				case 1u:
					this.OutputType = other.OutputType;
					arg_14D_0 = (num * 2764410862u ^ 1091276823u);
					continue;
				case 2u:
					arg_14D_0 = ((MethodDescriptorProto.smethod_2(other.OutputType) == 0) ? 3609492217u : 2805570288u);
					continue;
				case 3u:
					arg_14D_0 = (((this.options_ == null) ? 785209992u : 465612598u) ^ num * 74693571u);
					continue;
				case 4u:
					arg_14D_0 = ((other.options_ != null) ? 2463013360u : 4259417867u);
					continue;
				case 5u:
					arg_14D_0 = ((MethodDescriptorProto.smethod_2(other.InputType) != 0) ? 3629355743u : 4137437270u);
					continue;
				case 6u:
					this.Name = other.Name;
					arg_14D_0 = (num * 2795820147u ^ 1686844217u);
					continue;
				case 7u:
					return;
				case 9u:
					goto IL_50;
				case 10u:
					this.Options.MergeFrom(other.Options);
					arg_14D_0 = 4259417867u;
					continue;
				case 11u:
					goto IL_19D;
				case 12u:
					this.options_ = new MethodOptions();
					arg_14D_0 = (num * 3990550291u ^ 689945275u);
					continue;
				}
				break;
			}
			return;
			IL_50:
			arg_14D_0 = 2188423605u;
			goto IL_148;
			IL_19D:
			arg_14D_0 = ((MethodDescriptorProto.smethod_2(other.Name) == 0) ? 3361311273u : 4202326721u);
			goto IL_148;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_227:
				uint num;
				uint arg_1BF_0 = ((num = input.ReadTag()) != 0u) ? 101578911u : 1752597329u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1BF_0 ^ 853976030u)) % 19u)
					{
					case 0u:
						arg_1BF_0 = 101578911u;
						continue;
					case 1u:
						arg_1BF_0 = (((num != 18u) ? 2340718058u : 3481081254u) ^ num2 * 3258660831u);
						continue;
					case 2u:
						arg_1BF_0 = (((num != 34u) ? 2027960122u : 1248026866u) ^ num2 * 3402668794u);
						continue;
					case 3u:
						arg_1BF_0 = (num2 * 1161521626u ^ 459419522u);
						continue;
					case 4u:
						this.options_ = new MethodOptions();
						arg_1BF_0 = (num2 * 3202233623u ^ 3495731603u);
						continue;
					case 5u:
						arg_1BF_0 = ((num != 26u) ? 11725218u : 626239679u);
						continue;
					case 6u:
						goto IL_227;
					case 7u:
						this.InputType = input.ReadString();
						arg_1BF_0 = 1564559036u;
						continue;
					case 8u:
						this.OutputType = input.ReadString();
						arg_1BF_0 = 490908716u;
						continue;
					case 9u:
						arg_1BF_0 = (num2 * 3810229024u ^ 2865393260u);
						continue;
					case 10u:
						arg_1BF_0 = ((num <= 18u) ? 1767568521u : 979783326u);
						continue;
					case 11u:
						arg_1BF_0 = ((this.options_ != null) ? 1338444494u : 49819765u);
						continue;
					case 12u:
						input.ReadMessage(this.options_);
						arg_1BF_0 = 490908716u;
						continue;
					case 13u:
						arg_1BF_0 = (num2 * 613214609u ^ 2534897574u);
						continue;
					case 15u:
						arg_1BF_0 = (((num != 10u) ? 3940525580u : 3710610995u) ^ num2 * 2536977806u);
						continue;
					case 16u:
						input.SkipLastField();
						arg_1BF_0 = 2131787405u;
						continue;
					case 17u:
						this.Name = input.ReadString();
						arg_1BF_0 = 1205673567u;
						continue;
					case 18u:
						arg_1BF_0 = (num2 * 3242643688u ^ 3340771524u);
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
