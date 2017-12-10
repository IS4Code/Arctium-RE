using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class ServiceDescriptorProto : IMessage, IMessage<ServiceDescriptorProto>, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
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
				IL_76:
				uint arg_5A_0 = 2586985462u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 2388799341u)) % 4u)
					{
					case 0u:
						goto IL_76;
					case 1u:
						this.method_ = other.method_.Clone();
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_5A_0 = 3774063975u;
						continue;
					case 3u:
						this.name_ = other.name_;
						arg_5A_0 = (num * 2319117189u ^ 1741594619u);
						continue;
					}
					return;
				}
			}
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
				switch ((arg_A9_0 ^ -970905173) % 11)
				{
				case 0:
					goto IL_9F;
				case 1:
					arg_A9_0 = ((!ServiceDescriptorProto.smethod_1(this.Options, other.Options)) ? -2045948823 : -312514582);
					continue;
				case 2:
					arg_A9_0 = (this.method_.Equals(other.method_) ? -463065643 : -230025904);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_A9_0 = (ServiceDescriptorProto.smethod_0(this.Name, other.Name) ? -729311781 : -601466993);
					continue;
				case 7:
					goto IL_EF;
				case 8:
					return false;
				case 10:
					return true;
				}
				break;
			}
			return true;
			IL_9F:
			arg_A9_0 = -731713897;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other != this) ? -1060075145 : -229055960);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D8:
				uint arg_B0_0 = 1230941280u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B0_0 ^ 1412037554u)) % 7u)
					{
					case 0u:
						num ^= ServiceDescriptorProto.smethod_3(this.Options);
						arg_B0_0 = (num2 * 80171073u ^ 1257325832u);
						continue;
					case 1u:
						num ^= ServiceDescriptorProto.smethod_3(this.Name);
						arg_B0_0 = (num2 * 4024418969u ^ 1797240542u);
						continue;
					case 2u:
						num ^= ServiceDescriptorProto.smethod_3(this.method_);
						arg_B0_0 = 1132526429u;
						continue;
					case 4u:
						goto IL_D8;
					case 5u:
						arg_B0_0 = (((this.options_ == null) ? 3605031520u : 3182659546u) ^ num2 * 743664156u);
						continue;
					case 6u:
						arg_B0_0 = (((ServiceDescriptorProto.smethod_2(this.Name) != 0) ? 4082454613u : 3334646929u) ^ num2 * 4093383311u);
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
				goto IL_10;
			}
			goto IL_C0;
			uint arg_98_0;
			while (true)
			{
				IL_93:
				uint num;
				switch ((num = (arg_98_0 ^ 2829698966u)) % 7u)
				{
				case 0u:
					arg_98_0 = (((this.options_ != null) ? 766220131u : 1819722215u) ^ num * 2372394189u);
					continue;
				case 1u:
					output.WriteString(this.Name);
					arg_98_0 = (num * 4052645365u ^ 1853187415u);
					continue;
				case 2u:
					goto IL_C0;
				case 3u:
					output.WriteRawTag(10);
					arg_98_0 = (num * 1549800187u ^ 2430512550u);
					continue;
				case 5u:
					output.WriteRawTag(26);
					output.WriteMessage(this.Options);
					arg_98_0 = (num * 733255398u ^ 1310857037u);
					continue;
				case 6u:
					goto IL_10;
				}
				break;
			}
			return;
			IL_10:
			arg_98_0 = 3672656648u;
			goto IL_93;
			IL_C0:
			this.method_.WriteTo(output, ServiceDescriptorProto._repeated_method_codec);
			arg_98_0 = 2875683514u;
			goto IL_93;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_E4:
				uint arg_BC_0 = 3299074281u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BC_0 ^ 3111380719u)) % 7u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_BC_0 = (num2 * 2083372716u ^ 1838700643u);
						continue;
					case 2u:
						num += this.method_.CalculateSize(ServiceDescriptorProto._repeated_method_codec);
						arg_BC_0 = 2514848954u;
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_BC_0 = (num2 * 534223073u ^ 1634311468u);
						continue;
					case 4u:
						arg_BC_0 = (((ServiceDescriptorProto.smethod_2(this.Name) != 0) ? 3661480746u : 3659165769u) ^ num2 * 884705413u);
						continue;
					case 5u:
						goto IL_E4;
					case 6u:
						arg_BC_0 = (((this.options_ == null) ? 798452100u : 776353969u) ^ num2 * 2513813583u);
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
				goto IL_18;
			}
			goto IL_110;
			uint arg_D0_0;
			while (true)
			{
				IL_CB:
				uint num;
				switch ((num = (arg_D0_0 ^ 76899549u)) % 9u)
				{
				case 0u:
					this.Name = other.Name;
					arg_D0_0 = (num * 1661702705u ^ 4277102814u);
					continue;
				case 1u:
					arg_D0_0 = (((this.options_ != null) ? 3719548682u : 4132882642u) ^ num * 1396069832u);
					continue;
				case 2u:
					goto IL_110;
				case 3u:
					this.Options.MergeFrom(other.Options);
					arg_D0_0 = 39188689u;
					continue;
				case 4u:
					this.method_.Add(other.method_);
					arg_D0_0 = ((other.options_ == null) ? 39188689u : 707141619u);
					continue;
				case 5u:
					return;
				case 7u:
					this.options_ = new ServiceOptions();
					arg_D0_0 = (num * 1171976742u ^ 3964448544u);
					continue;
				case 8u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_D0_0 = 2051598818u;
			goto IL_CB;
			IL_110:
			arg_D0_0 = ((ServiceDescriptorProto.smethod_2(other.Name) != 0) ? 186618578u : 1736297985u);
			goto IL_CB;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_189:
				uint num;
				uint arg_139_0 = ((num = input.ReadTag()) == 0u) ? 1496254667u : 1894080383u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_139_0 ^ 1516660814u)) % 13u)
					{
					case 0u:
						this.options_ = new ServiceOptions();
						arg_139_0 = (num2 * 1684874330u ^ 3315057721u);
						continue;
					case 1u:
						arg_139_0 = (((num == 26u) ? 327529535u : 1625890257u) ^ num2 * 2593732578u);
						continue;
					case 2u:
						goto IL_189;
					case 3u:
						arg_139_0 = (num2 * 3568166799u ^ 1393424897u);
						continue;
					case 4u:
						arg_139_0 = ((num == 10u) ? 585934801u : 977609382u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_139_0 = (num2 * 2144696599u ^ 3682943242u);
						continue;
					case 6u:
						input.ReadMessage(this.options_);
						arg_139_0 = 1289630422u;
						continue;
					case 7u:
						arg_139_0 = (((num == 18u) ? 590631455u : 2047599332u) ^ num2 * 1743976368u);
						continue;
					case 8u:
						this.Name = input.ReadString();
						arg_139_0 = 1289630422u;
						continue;
					case 9u:
						this.method_.AddEntriesFrom(input, ServiceDescriptorProto._repeated_method_codec);
						arg_139_0 = 1289630422u;
						continue;
					case 11u:
						arg_139_0 = ((this.options_ == null) ? 344019157u : 581531207u);
						continue;
					case 12u:
						arg_139_0 = 1894080383u;
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
