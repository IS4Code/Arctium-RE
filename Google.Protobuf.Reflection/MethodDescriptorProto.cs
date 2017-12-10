using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class MethodDescriptorProto : IMessage, IMessage<MethodDescriptorProto>, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MethodDescriptorProto.__c __9 = new MethodDescriptorProto.__c();

			internal MethodDescriptorProto cctor>b__49_0()
			{
				return new MethodDescriptorProto();
			}
		}

		private static readonly MessageParser<MethodDescriptorProto> _parser = new MessageParser<MethodDescriptorProto>(new Func<MethodDescriptorProto>(MethodDescriptorProto.__c.__9.<.cctor>b__49_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int InputTypeFieldNumber = 2;

		private string inputType_ = "";

		public const int OutputTypeFieldNumber = 3;

		private string outputType_ = "";

		public const int OptionsFieldNumber = 4;

		private MethodOptions options_;

		public const int ClientStreamingFieldNumber = 5;

		private bool clientStreaming_;

		public const int ServerStreamingFieldNumber = 6;

		private bool serverStreaming_;

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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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
				this.inputType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
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
				this.outputType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
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

		public bool ClientStreaming
		{
			get
			{
				return this.clientStreaming_;
			}
			set
			{
				this.clientStreaming_ = value;
			}
		}

		public bool ServerStreaming
		{
			get
			{
				return this.serverStreaming_;
			}
			set
			{
				this.serverStreaming_ = value;
			}
		}

		public MethodDescriptorProto()
		{
		}

		public MethodDescriptorProto(MethodDescriptorProto other) : this()
		{
			while (true)
			{
				IL_98:
				uint arg_7C_0 = 2405109006u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7C_0 ^ 2652514747u)) % 4u)
					{
					case 1u:
						this.name_ = other.name_;
						this.inputType_ = other.inputType_;
						this.outputType_ = other.outputType_;
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_7C_0 = 3773839196u;
						continue;
					case 2u:
						goto IL_98;
					case 3u:
						this.clientStreaming_ = other.clientStreaming_;
						this.serverStreaming_ = other.serverStreaming_;
						arg_7C_0 = (num * 3617631254u ^ 384818245u);
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
				goto IL_18;
			}
			goto IL_187;
			int arg_129_0;
			while (true)
			{
				IL_124:
				switch ((arg_129_0 ^ 1856387667) % 17)
				{
				case 0:
					goto IL_187;
				case 1:
					arg_129_0 = (MethodDescriptorProto.smethod_0(this.Name, other.Name) ? 588876622 : 1143197039);
					continue;
				case 3:
					arg_129_0 = (MethodDescriptorProto.smethod_0(this.OutputType, other.OutputType) ? 682031678 : 1527964475);
					continue;
				case 4:
					arg_129_0 = ((this.ServerStreaming != other.ServerStreaming) ? 1590855159 : 1295325756);
					continue;
				case 5:
					return false;
				case 6:
					arg_129_0 = ((!MethodDescriptorProto.smethod_0(this.InputType, other.InputType)) ? 1358664354 : 823722263);
					continue;
				case 7:
					return false;
				case 8:
					return true;
				case 9:
					return false;
				case 10:
					arg_129_0 = (MethodDescriptorProto.smethod_1(this.Options, other.Options) ? 1108395920 : 48363898);
					continue;
				case 11:
					arg_129_0 = ((this.ClientStreaming == other.ClientStreaming) ? 1013513883 : 122824866);
					continue;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_129_0 = 1381821593;
			goto IL_124;
			IL_187:
			arg_129_0 = ((other == this) ? 2063157060 : 77360636);
			goto IL_124;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (MethodDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_8B;
			}
			goto IL_1CD;
			uint arg_17D_0;
			while (true)
			{
				IL_178:
				uint num2;
				switch ((num2 = (arg_17D_0 ^ 1400779731u)) % 13u)
				{
				case 0u:
					num ^= MethodDescriptorProto.smethod_3(this.InputType);
					arg_17D_0 = (num2 * 2980424820u ^ 3434606287u);
					continue;
				case 1u:
					arg_17D_0 = ((MethodDescriptorProto.smethod_2(this.OutputType) != 0) ? 449912605u : 2058606906u);
					continue;
				case 2u:
					num ^= this.ClientStreaming.GetHashCode();
					arg_17D_0 = (num2 * 2115050868u ^ 3141444548u);
					continue;
				case 4u:
					num ^= MethodDescriptorProto.smethod_3(this.OutputType);
					arg_17D_0 = (num2 * 443114385u ^ 3183072148u);
					continue;
				case 5u:
					arg_17D_0 = ((this.options_ != null) ? 431416480u : 1942010819u);
					continue;
				case 6u:
					arg_17D_0 = ((!this.ServerStreaming) ? 37677417u : 1104892995u);
					continue;
				case 7u:
					num ^= MethodDescriptorProto.smethod_3(this.Options);
					arg_17D_0 = (num2 * 2789599042u ^ 1441786725u);
					continue;
				case 8u:
					goto IL_8B;
				case 9u:
					arg_17D_0 = ((!this.ClientStreaming) ? 1735363604u : 1922806615u);
					continue;
				case 10u:
					num ^= MethodDescriptorProto.smethod_3(this.Name);
					arg_17D_0 = (num2 * 186518702u ^ 1899873518u);
					continue;
				case 11u:
					num ^= this.ServerStreaming.GetHashCode();
					arg_17D_0 = (num2 * 3488732708u ^ 3495565609u);
					continue;
				case 12u:
					goto IL_1CD;
				}
				break;
			}
			return num;
			IL_8B:
			arg_17D_0 = 784007402u;
			goto IL_178;
			IL_1CD:
			arg_17D_0 = ((MethodDescriptorProto.smethod_2(this.InputType) != 0) ? 1389342487u : 1687508511u);
			goto IL_178;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (MethodDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_108;
			}
			goto IL_22E;
			uint arg_1D2_0;
			while (true)
			{
				IL_1CD:
				uint num;
				switch ((num = (arg_1D2_0 ^ 1400091364u)) % 16u)
				{
				case 0u:
					arg_1D2_0 = ((!this.ServerStreaming) ? 1419176703u : 896251276u);
					continue;
				case 1u:
					output.WriteRawTag(18);
					arg_1D2_0 = (num * 3684955755u ^ 276784805u);
					continue;
				case 2u:
					arg_1D2_0 = ((this.options_ != null) ? 1062504061u : 456273560u);
					continue;
				case 3u:
					output.WriteBool(this.ServerStreaming);
					arg_1D2_0 = (num * 3862439567u ^ 4088377826u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_1D2_0 = (num * 1523445639u ^ 3760260998u);
					continue;
				case 5u:
					output.WriteRawTag(26);
					output.WriteString(this.OutputType);
					arg_1D2_0 = (num * 1005331873u ^ 2213208019u);
					continue;
				case 6u:
					goto IL_108;
				case 7u:
					output.WriteRawTag(40);
					arg_1D2_0 = (num * 1933754087u ^ 3274314904u);
					continue;
				case 8u:
					output.WriteRawTag(48);
					arg_1D2_0 = (num * 3405675876u ^ 1907869655u);
					continue;
				case 9u:
					output.WriteRawTag(34);
					output.WriteMessage(this.Options);
					arg_1D2_0 = (num * 3909346343u ^ 1487825367u);
					continue;
				case 10u:
					output.WriteString(this.InputType);
					arg_1D2_0 = (num * 298920303u ^ 2077003037u);
					continue;
				case 12u:
					arg_1D2_0 = ((!this.ClientStreaming) ? 1978082244u : 829652019u);
					continue;
				case 13u:
					output.WriteBool(this.ClientStreaming);
					arg_1D2_0 = (num * 2578016986u ^ 596832182u);
					continue;
				case 14u:
					goto IL_22E;
				case 15u:
					arg_1D2_0 = ((MethodDescriptorProto.smethod_2(this.OutputType) == 0) ? 137949094u : 534495409u);
					continue;
				}
				break;
			}
			return;
			IL_108:
			arg_1D2_0 = 1125238752u;
			goto IL_1CD;
			IL_22E:
			arg_1D2_0 = ((MethodDescriptorProto.smethod_2(this.InputType) != 0) ? 1634715285u : 1473762555u);
			goto IL_1CD;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1E3:
				uint arg_19E_0 = 1472167968u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_19E_0 ^ 1126774170u)) % 14u)
					{
					case 0u:
						arg_19E_0 = (this.ServerStreaming ? 1923166495u : 640313440u);
						continue;
					case 1u:
						num += 2;
						arg_19E_0 = (num2 * 1911489878u ^ 517567950u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_19E_0 = (num2 * 2229215965u ^ 2924603801u);
						continue;
					case 3u:
						arg_19E_0 = (this.ClientStreaming ? 2125258454u : 13823414u);
						continue;
					case 4u:
						goto IL_1E3;
					case 5u:
						arg_19E_0 = ((this.options_ != null) ? 1888906259u : 1888779497u);
						continue;
					case 6u:
						num += 2;
						arg_19E_0 = (num2 * 3588294109u ^ 3302125866u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.OutputType);
						arg_19E_0 = (num2 * 3859621990u ^ 3477334815u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_19E_0 = (num2 * 465978042u ^ 3515229027u);
						continue;
					case 10u:
						arg_19E_0 = ((MethodDescriptorProto.smethod_2(this.OutputType) == 0) ? 2019469257u : 1118443891u);
						continue;
					case 11u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.InputType);
						arg_19E_0 = (num2 * 2978703866u ^ 2436368176u);
						continue;
					case 12u:
						arg_19E_0 = (((MethodDescriptorProto.smethod_2(this.Name) == 0) ? 935525887u : 1808235100u) ^ num2 * 2523572771u);
						continue;
					case 13u:
						arg_19E_0 = ((MethodDescriptorProto.smethod_2(this.InputType) == 0) ? 81721818u : 178703427u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(MethodDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_130;
			}
			goto IL_231;
			uint arg_1D1_0;
			while (true)
			{
				IL_1CC:
				uint num;
				switch ((num = (arg_1D1_0 ^ 1246299698u)) % 17u)
				{
				case 0u:
					this.InputType = other.InputType;
					arg_1D1_0 = (num * 42889674u ^ 1120208700u);
					continue;
				case 1u:
					this.Options.MergeFrom(other.Options);
					arg_1D1_0 = 1707383733u;
					continue;
				case 2u:
					arg_1D1_0 = ((MethodDescriptorProto.smethod_2(other.OutputType) == 0) ? 783350378u : 1277288044u);
					continue;
				case 3u:
					this.options_ = new MethodOptions();
					arg_1D1_0 = (num * 57500992u ^ 240924492u);
					continue;
				case 4u:
					arg_1D1_0 = (other.ClientStreaming ? 216928543u : 1687863831u);
					continue;
				case 5u:
					goto IL_130;
				case 6u:
					this.ServerStreaming = other.ServerStreaming;
					arg_1D1_0 = (num * 2442118348u ^ 907215516u);
					continue;
				case 7u:
					goto IL_231;
				case 8u:
					arg_1D1_0 = (((this.options_ != null) ? 2846688826u : 2216292137u) ^ num * 4116975065u);
					continue;
				case 9u:
					arg_1D1_0 = ((other.options_ != null) ? 496042260u : 1707383733u);
					continue;
				case 10u:
					return;
				case 12u:
					this.OutputType = other.OutputType;
					arg_1D1_0 = (num * 2713238071u ^ 33174104u);
					continue;
				case 13u:
					this.Name = other.Name;
					arg_1D1_0 = (num * 155083413u ^ 4217037799u);
					continue;
				case 14u:
					arg_1D1_0 = ((!other.ServerStreaming) ? 1506299108u : 305217496u);
					continue;
				case 15u:
					arg_1D1_0 = ((MethodDescriptorProto.smethod_2(other.InputType) == 0) ? 797611916u : 375840586u);
					continue;
				case 16u:
					this.ClientStreaming = other.ClientStreaming;
					arg_1D1_0 = (num * 607066731u ^ 1911456728u);
					continue;
				}
				break;
			}
			return;
			IL_130:
			arg_1D1_0 = 718626964u;
			goto IL_1CC;
			IL_231:
			arg_1D1_0 = ((MethodDescriptorProto.smethod_2(other.Name) == 0) ? 1942688741u : 983820104u);
			goto IL_1CC;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_29C:
				uint num;
				uint arg_228_0 = ((num = input.ReadTag()) != 0u) ? 2766033911u : 2392756996u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_228_0 ^ 3416232073u)) % 22u)
					{
					case 0u:
						arg_228_0 = 2766033911u;
						continue;
					case 1u:
						arg_228_0 = (((num == 40u) ? 112364945u : 214908489u) ^ num2 * 2322183902u);
						continue;
					case 2u:
						this.Name = input.ReadString();
						arg_228_0 = 2493853118u;
						continue;
					case 3u:
						this.options_ = new MethodOptions();
						arg_228_0 = (num2 * 2666197392u ^ 1227688579u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_228_0 = 2570009770u;
						continue;
					case 5u:
						this.OutputType = input.ReadString();
						arg_228_0 = 3918139171u;
						continue;
					case 6u:
						this.ClientStreaming = input.ReadBool();
						arg_228_0 = 3918139171u;
						continue;
					case 7u:
						arg_228_0 = ((num != 34u) ? 4261503472u : 3650679066u);
						continue;
					case 8u:
						arg_228_0 = (((num != 48u) ? 628936211u : 1152494331u) ^ num2 * 821030988u);
						continue;
					case 10u:
						input.ReadMessage(this.options_);
						arg_228_0 = 3918139171u;
						continue;
					case 11u:
						arg_228_0 = (((num != 10u) ? 2240741410u : 4170148655u) ^ num2 * 4203449008u);
						continue;
					case 12u:
						this.ServerStreaming = input.ReadBool();
						arg_228_0 = 3918139171u;
						continue;
					case 13u:
						arg_228_0 = (num2 * 2618060391u ^ 420072450u);
						continue;
					case 14u:
						arg_228_0 = ((num <= 26u) ? 3473358024u : 2470560010u);
						continue;
					case 15u:
						arg_228_0 = (num2 * 4256915429u ^ 905049964u);
						continue;
					case 16u:
						goto IL_29C;
					case 17u:
						arg_228_0 = (num2 * 744213813u ^ 1946117616u);
						continue;
					case 18u:
						arg_228_0 = (((num != 26u) ? 1183463220u : 1899143432u) ^ num2 * 810057445u);
						continue;
					case 19u:
						arg_228_0 = ((this.options_ == null) ? 2945224276u : 2952553427u);
						continue;
					case 20u:
						this.InputType = input.ReadString();
						arg_228_0 = 3918139171u;
						continue;
					case 21u:
						arg_228_0 = (((num != 18u) ? 1984269892u : 360848630u) ^ num2 * 3509702517u);
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
