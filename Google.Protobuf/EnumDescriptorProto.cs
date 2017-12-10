using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>, IMessage
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

		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec;

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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
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
				IL_8C:
				uint arg_6C_0 = 3067605231u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6C_0 ^ 3282534308u)) % 5u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
						this.value_ = other.value_.Clone();
						arg_6C_0 = (num * 4020333034u ^ 3808781049u);
						continue;
					case 2u:
						this.name_ = other.name_;
						arg_6C_0 = (num * 3155442507u ^ 783862520u);
						continue;
					case 4u:
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_6C_0 = 3882021670u;
						continue;
					}
					return;
				}
			}
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
				goto IL_9F;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ 1886624976) % 11)
				{
				case 0:
					goto IL_9F;
				case 2:
					arg_A9_0 = ((!this.value_.Equals(other.value_)) ? 123054197 : 398040926);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_A9_0 = ((!EnumDescriptorProto.smethod_0(this.Name, other.Name)) ? 1661493125 : 1576630076);
					continue;
				case 7:
					goto IL_EF;
				case 8:
					return true;
				case 9:
					arg_A9_0 = (EnumDescriptorProto.smethod_1(this.Options, other.Options) ? 1667196972 : 595352238);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9F:
			arg_A9_0 = 1276648407;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other == this) ? 1413260294 : 1450805434);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_DB:
				uint arg_B3_0 = 1291876002u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 631270391u)) % 7u)
					{
					case 0u:
						goto IL_DB;
					case 1u:
						arg_B3_0 = (((this.options_ != null) ? 2445503640u : 2730280353u) ^ num2 * 2003872939u);
						continue;
					case 2u:
						arg_B3_0 = (((EnumDescriptorProto.smethod_2(this.Name) == 0) ? 3742497983u : 3570716895u) ^ num2 * 1639481441u);
						continue;
					case 3u:
						num ^= EnumDescriptorProto.smethod_3(this.value_);
						arg_B3_0 = 1084448746u;
						continue;
					case 4u:
						num ^= EnumDescriptorProto.smethod_3(this.Options);
						arg_B3_0 = (num2 * 1295839756u ^ 3805510846u);
						continue;
					case 5u:
						num ^= EnumDescriptorProto.smethod_3(this.Name);
						arg_B3_0 = (num2 * 1220301256u ^ 2893845026u);
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
				goto IL_52;
			}
			goto IL_D5;
			uint arg_A9_0;
			while (true)
			{
				IL_A4:
				uint num;
				switch ((num = (arg_A9_0 ^ 1094489007u)) % 8u)
				{
				case 0u:
					output.WriteString(this.Name);
					arg_A9_0 = (num * 185630707u ^ 3676664600u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_A9_0 = (num * 3520509985u ^ 4130787174u);
					continue;
				case 2u:
					output.WriteMessage(this.Options);
					arg_A9_0 = (num * 758589693u ^ 3585137105u);
					continue;
				case 3u:
					goto IL_52;
				case 5u:
					arg_A9_0 = (((this.options_ != null) ? 1217486249u : 1208438835u) ^ num * 874151248u);
					continue;
				case 6u:
					output.WriteRawTag(26);
					arg_A9_0 = (num * 4175793252u ^ 639736301u);
					continue;
				case 7u:
					goto IL_D5;
				}
				break;
			}
			return;
			IL_52:
			arg_A9_0 = 1526070814u;
			goto IL_A4;
			IL_D5:
			this.value_.WriteTo(output, EnumDescriptorProto._repeated_value_codec);
			arg_A9_0 = 298632682u;
			goto IL_A4;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_E1:
				uint arg_B9_0 = 848173752u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B9_0 ^ 965139766u)) % 7u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_B9_0 = (num2 * 2279762427u ^ 646511382u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_B9_0 = (num2 * 604019361u ^ 2157500547u);
						continue;
					case 2u:
						arg_B9_0 = (((this.options_ != null) ? 2501528436u : 4277347457u) ^ num2 * 1937312347u);
						continue;
					case 3u:
						num += this.value_.CalculateSize(EnumDescriptorProto._repeated_value_codec);
						arg_B9_0 = 675934574u;
						continue;
					case 4u:
						goto IL_E1;
					case 6u:
						arg_B9_0 = (((EnumDescriptorProto.smethod_2(this.Name) != 0) ? 1272159604u : 1949999840u) ^ num2 * 631556696u);
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
				goto IL_C6;
			}
			goto IL_110;
			uint arg_D0_0;
			while (true)
			{
				IL_CB:
				uint num;
				switch ((num = (arg_D0_0 ^ 2870200360u)) % 9u)
				{
				case 0u:
					goto IL_C6;
				case 1u:
					this.Options.MergeFrom(other.Options);
					arg_D0_0 = 2435730751u;
					continue;
				case 2u:
					return;
				case 3u:
					this.options_ = new EnumOptions();
					arg_D0_0 = (num * 2159272460u ^ 66619932u);
					continue;
				case 4u:
					goto IL_110;
				case 6u:
					this.value_.Add(other.value_);
					arg_D0_0 = ((other.options_ != null) ? 2150721879u : 2435730751u);
					continue;
				case 7u:
					this.Name = other.Name;
					arg_D0_0 = (num * 3622892625u ^ 722892405u);
					continue;
				case 8u:
					arg_D0_0 = (((this.options_ == null) ? 1513550212u : 1899512138u) ^ num * 3681705778u);
					continue;
				}
				break;
			}
			return;
			IL_C6:
			arg_D0_0 = 3135374739u;
			goto IL_CB;
			IL_110:
			arg_D0_0 = ((EnumDescriptorProto.smethod_2(other.Name) == 0) ? 2592067091u : 3260497582u);
			goto IL_CB;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1B5:
				uint num;
				uint arg_15D_0 = ((num = input.ReadTag()) == 0u) ? 2340856282u : 3540237648u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_15D_0 ^ 2824732041u)) % 15u)
					{
					case 0u:
						this.value_.AddEntriesFrom(input, EnumDescriptorProto._repeated_value_codec);
						arg_15D_0 = 3187293215u;
						continue;
					case 1u:
						this.Name = input.ReadString();
						arg_15D_0 = 2907445324u;
						continue;
					case 2u:
						arg_15D_0 = (((num != 18u) ? 3766780562u : 3579093109u) ^ num2 * 1719556996u);
						continue;
					case 3u:
						arg_15D_0 = ((num == 10u) ? 4018720891u : 3833540747u);
						continue;
					case 4u:
						this.options_ = new EnumOptions();
						arg_15D_0 = (num2 * 3981716522u ^ 3672651730u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_15D_0 = (num2 * 350980336u ^ 1654171464u);
						continue;
					case 6u:
						arg_15D_0 = (num2 * 301917660u ^ 1220371295u);
						continue;
					case 7u:
						input.ReadMessage(this.options_);
						arg_15D_0 = 4254394807u;
						continue;
					case 8u:
						goto IL_1B5;
					case 10u:
						arg_15D_0 = (num2 * 3768159186u ^ 1191753797u);
						continue;
					case 11u:
						arg_15D_0 = (((num == 26u) ? 963581901u : 455873438u) ^ num2 * 266044788u);
						continue;
					case 12u:
						arg_15D_0 = 3540237648u;
						continue;
					case 13u:
						arg_15D_0 = (num2 * 2083008882u ^ 4230999821u);
						continue;
					case 14u:
						arg_15D_0 = ((this.options_ != null) ? 3655641898u : 3846631941u);
						continue;
					}
					return;
				}
			}
		}

		static EnumDescriptorProto()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 1662712070u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2031148813u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 1u:
						EnumDescriptorProto._repeated_value_codec = FieldCodec.ForMessage<EnumValueDescriptorProto>(18u, EnumValueDescriptorProto.Parser);
						arg_3F_0 = (num * 2639494279u ^ 3772469875u);
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
