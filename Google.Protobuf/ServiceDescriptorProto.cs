using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ServiceDescriptorProto.__c __9 = new ServiceDescriptorProto.__c();

			internal ServiceDescriptorProto cctor>b__34_0()
			{
				return new ServiceDescriptorProto();
			}
		}

		private static readonly MessageParser<ServiceDescriptorProto> _parser = new MessageParser<ServiceDescriptorProto>(new Func<ServiceDescriptorProto>(ServiceDescriptorProto.__c.__9.<.cctor>b__34_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int MethodFieldNumber = 2;

		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec = FieldCodec.ForMessage<MethodDescriptorProto>(18u, MethodDescriptorProto.Parser);

		private readonly RepeatedField<MethodDescriptorProto> method_ = new RepeatedField<MethodDescriptorProto>();

		public const int OptionsFieldNumber = 3;

		private ServiceOptions options_;

		public static MessageParser<ServiceDescriptorProto> Parser
		{
			get
			{
				return ServiceDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServiceDescriptorProto.Descriptor;
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

		public RepeatedField<MethodDescriptorProto> Method
		{
			get
			{
				return this.method_;
			}
		}

		public ServiceOptions Options
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

		public ServiceDescriptorProto()
		{
		}

		public ServiceDescriptorProto(ServiceDescriptorProto other) : this()
		{
			while (true)
			{
				IL_62:
				uint arg_46_0 = 3915433139u;
				while (true)
				{
					uint num;
					switch ((num = (arg_46_0 ^ 2623770550u)) % 4u)
					{
					case 0u:
						this.method_ = other.method_.Clone();
						arg_46_0 = (num * 3572982429u ^ 1534429033u);
						continue;
					case 1u:
						this.name_ = other.name_;
						arg_46_0 = (num * 3271020854u ^ 1656734284u);
						continue;
					case 2u:
						goto IL_62;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		public ServiceDescriptorProto Clone()
		{
			return new ServiceDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ServiceDescriptorProto);
		}

		public bool Equals(ServiceDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_9F;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ 1852889617) % 11)
				{
				case 0:
					goto IL_9F;
				case 1:
					goto IL_EF;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 6:
					arg_A9_0 = (this.method_.Equals(other.method_) ? 623059947 : 625696740);
					continue;
				case 7:
					arg_A9_0 = ((!ServiceDescriptorProto.smethod_1(this.Options, other.Options)) ? 398835058 : 648796043);
					continue;
				case 8:
					return false;
				case 9:
					arg_A9_0 = (ServiceDescriptorProto.smethod_0(this.Name, other.Name) ? 1694340483 : 1810479323);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9F:
			arg_A9_0 = 2044946979;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other != this) ? 830976242 : 1295161829);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D8:
				uint arg_B0_0 = 177291415u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B0_0 ^ 929857437u)) % 7u)
					{
					case 0u:
						num ^= ServiceDescriptorProto.smethod_3(this.Name);
						arg_B0_0 = (num2 * 2386536750u ^ 2982497503u);
						continue;
					case 1u:
						num ^= ServiceDescriptorProto.smethod_3(this.Options);
						arg_B0_0 = (num2 * 420513294u ^ 3747168286u);
						continue;
					case 3u:
						arg_B0_0 = (((ServiceDescriptorProto.smethod_2(this.Name) == 0) ? 5405613u : 110106025u) ^ num2 * 2983120147u);
						continue;
					case 4u:
						goto IL_D8;
					case 5u:
						num ^= ServiceDescriptorProto.smethod_3(this.method_);
						arg_B0_0 = 709404783u;
						continue;
					case 6u:
						arg_B0_0 = (((this.options_ == null) ? 1752114704u : 819068229u) ^ num2 * 4221174041u);
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
			if (ServiceDescriptorProto.smethod_2(this.Name) != 0)
			{
				goto IL_79;
			}
			goto IL_C2;
			uint arg_9A_0;
			while (true)
			{
				IL_95:
				uint num;
				switch ((num = (arg_9A_0 ^ 532561702u)) % 7u)
				{
				case 0u:
					goto IL_C2;
				case 2u:
					output.WriteRawTag(10);
					arg_9A_0 = (num * 3668039352u ^ 1289889501u);
					continue;
				case 3u:
					goto IL_79;
				case 4u:
					output.WriteRawTag(26);
					output.WriteMessage(this.Options);
					arg_9A_0 = (num * 906297353u ^ 3698276626u);
					continue;
				case 5u:
					arg_9A_0 = (((this.options_ != null) ? 505584614u : 2043325018u) ^ num * 3095347555u);
					continue;
				case 6u:
					output.WriteString(this.Name);
					arg_9A_0 = (num * 682150429u ^ 2160442459u);
					continue;
				}
				break;
			}
			return;
			IL_79:
			arg_9A_0 = 256114714u;
			goto IL_95;
			IL_C2:
			this.method_.WriteTo(output, ServiceDescriptorProto._repeated_method_codec);
			arg_9A_0 = 2101951229u;
			goto IL_95;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_E4:
				uint arg_BC_0 = 2304351466u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BC_0 ^ 2167656146u)) % 7u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_BC_0 = (num2 * 3202721304u ^ 893593654u);
						continue;
					case 2u:
						arg_BC_0 = (((ServiceDescriptorProto.smethod_2(this.Name) != 0) ? 741262376u : 1849360262u) ^ num2 * 1047661160u);
						continue;
					case 3u:
						arg_BC_0 = (((this.options_ != null) ? 3235249978u : 3813721582u) ^ num2 * 3695095661u);
						continue;
					case 4u:
						goto IL_E4;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_BC_0 = (num2 * 794490854u ^ 1837980342u);
						continue;
					case 6u:
						num += this.method_.CalculateSize(ServiceDescriptorProto._repeated_method_codec);
						arg_BC_0 = 3137531978u;
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ServiceDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_76;
			}
			goto IL_10D;
			uint arg_CD_0;
			while (true)
			{
				IL_C8:
				uint num;
				switch ((num = (arg_CD_0 ^ 2883181534u)) % 9u)
				{
				case 0u:
					this.Name = other.Name;
					arg_CD_0 = (num * 3524469547u ^ 1998055568u);
					continue;
				case 1u:
					this.method_.Add(other.method_);
					arg_CD_0 = ((other.options_ == null) ? 2612692522u : 2955395459u);
					continue;
				case 2u:
					goto IL_76;
				case 3u:
					goto IL_10D;
				case 4u:
					arg_CD_0 = (((this.options_ != null) ? 728042495u : 2091950185u) ^ num * 854758425u);
					continue;
				case 5u:
					return;
				case 6u:
					this.options_ = new ServiceOptions();
					arg_CD_0 = (num * 3112143849u ^ 119982488u);
					continue;
				case 8u:
					this.Options.MergeFrom(other.Options);
					arg_CD_0 = 2612692522u;
					continue;
				}
				break;
			}
			return;
			IL_76:
			arg_CD_0 = 3519896567u;
			goto IL_C8;
			IL_10D:
			arg_CD_0 = ((ServiceDescriptorProto.smethod_2(other.Name) != 0) ? 2578254665u : 3159312077u);
			goto IL_C8;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_19C:
				uint num;
				uint arg_148_0 = ((num = input.ReadTag()) != 0u) ? 477095729u : 714123276u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_148_0 ^ 1004400636u)) % 14u)
					{
					case 0u:
						arg_148_0 = 477095729u;
						continue;
					case 1u:
						this.Name = input.ReadString();
						arg_148_0 = 1611562630u;
						continue;
					case 3u:
						this.method_.AddEntriesFrom(input, ServiceDescriptorProto._repeated_method_codec);
						arg_148_0 = 34718618u;
						continue;
					case 4u:
						arg_148_0 = (num2 * 2326279954u ^ 1754510403u);
						continue;
					case 5u:
						arg_148_0 = (((num != 18u) ? 1768803414u : 1023665341u) ^ num2 * 1195432452u);
						continue;
					case 6u:
						arg_148_0 = ((this.options_ != null) ? 711282343u : 1389860263u);
						continue;
					case 7u:
						input.ReadMessage(this.options_);
						arg_148_0 = 1302512855u;
						continue;
					case 8u:
						arg_148_0 = (num2 * 3404951067u ^ 969688597u);
						continue;
					case 9u:
						arg_148_0 = ((num != 10u) ? 426747805u : 1577486525u);
						continue;
					case 10u:
						arg_148_0 = (((num != 26u) ? 4268657928u : 3101548454u) ^ num2 * 971632228u);
						continue;
					case 11u:
						this.options_ = new ServiceOptions();
						arg_148_0 = (num2 * 3838711229u ^ 3281683080u);
						continue;
					case 12u:
						input.SkipLastField();
						arg_148_0 = (num2 * 2462231960u ^ 1304694775u);
						continue;
					case 13u:
						goto IL_19C;
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
