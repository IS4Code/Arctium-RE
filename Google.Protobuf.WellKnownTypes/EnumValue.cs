using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class EnumValue : IMessage<EnumValue>, IEquatable<EnumValue>, IDeepCloneable<EnumValue>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EnumValue.__c __9 = new EnumValue.__c();

			internal EnumValue cctor>b__34_0()
			{
				return new EnumValue();
			}
		}

		private static readonly MessageParser<EnumValue> _parser = new MessageParser<EnumValue>(new Func<EnumValue>(EnumValue.__c.__9.<.cctor>b__34_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int NumberFieldNumber = 2;

		private int number_;

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public static MessageParser<EnumValue> Parser
		{
			get
			{
				return EnumValue._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return TypeReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumValue.Descriptor;
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

		public RepeatedField<Option> Options
		{
			get
			{
				return this.options_;
			}
		}

		public EnumValue()
		{
		}

		public EnumValue(EnumValue other) : this()
		{
			while (true)
			{
				IL_5D:
				uint arg_41_0 = 2231445404u;
				while (true)
				{
					uint num;
					switch ((num = (arg_41_0 ^ 3501973671u)) % 4u)
					{
					case 0u:
						goto IL_5D;
					case 2u:
						this.number_ = other.number_;
						arg_41_0 = (num * 3867589287u ^ 2608261520u);
						continue;
					case 3u:
						this.name_ = other.name_;
						arg_41_0 = (num * 4209793879u ^ 632356952u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.options_ = other.options_.Clone();
		}

		public EnumValue Clone()
		{
			return new EnumValue(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EnumValue);
		}

		public bool Equals(EnumValue other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ -512433185) % 11)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					return false;
				case 4:
					return false;
				case 5:
					arg_A1_0 = (this.options_.Equals(other.options_) ? -1903133210 : -1480881117);
					continue;
				case 6:
					arg_A1_0 = (EnumValue.smethod_0(this.Name, other.Name) ? -1595995581 : -868962309);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_E7;
				case 9:
					arg_A1_0 = ((this.Number != other.Number) ? -938339373 : -174484004);
					continue;
				case 10:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_A1_0 = -418076002;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other == this) ? -1586976045 : -1055215621);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D6:
				uint arg_AE_0 = 1064988111u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 2040140237u)) % 7u)
					{
					case 0u:
						num ^= this.options_.GetHashCode();
						arg_AE_0 = 1995710253u;
						continue;
					case 1u:
						arg_AE_0 = (((EnumValue.smethod_1(this.Name) != 0) ? 3537811022u : 3185120199u) ^ num2 * 3832647134u);
						continue;
					case 2u:
						goto IL_D6;
					case 3u:
						num ^= this.Number.GetHashCode();
						arg_AE_0 = (num2 * 3607780221u ^ 3418595652u);
						continue;
					case 5u:
						arg_AE_0 = ((this.Number != 0) ? 634032249u : 632418720u);
						continue;
					case 6u:
						num ^= EnumValue.smethod_2(this.Name);
						arg_AE_0 = (num2 * 1633772049u ^ 1425987156u);
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
			if (EnumValue.smethod_1(this.Name) != 0)
			{
				goto IL_8C;
			}
			goto IL_CD;
			uint arg_96_0;
			while (true)
			{
				IL_91:
				uint num;
				switch ((num = (arg_96_0 ^ 3822672813u)) % 7u)
				{
				case 0u:
					goto IL_8C;
				case 1u:
					output.WriteString(this.Name);
					arg_96_0 = (num * 62901661u ^ 3564975114u);
					continue;
				case 2u:
					output.WriteRawTag(16);
					output.WriteInt32(this.Number);
					arg_96_0 = (num * 643378683u ^ 3800657900u);
					continue;
				case 3u:
					this.options_.WriteTo(output, EnumValue._repeated_options_codec);
					arg_96_0 = 4027557071u;
					continue;
				case 5u:
					output.WriteRawTag(10);
					arg_96_0 = (num * 4187124983u ^ 3646678561u);
					continue;
				case 6u:
					goto IL_CD;
				}
				break;
			}
			return;
			IL_8C:
			arg_96_0 = 4280372631u;
			goto IL_91;
			IL_CD:
			arg_96_0 = ((this.Number != 0) ? 3708351789u : 4283168876u);
			goto IL_91;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (EnumValue.smethod_1(this.Name) != 0)
			{
				goto IL_21;
			}
			goto IL_B6;
			uint arg_83_0;
			while (true)
			{
				IL_7E:
				uint num2;
				switch ((num2 = (arg_83_0 ^ 549983787u)) % 6u)
				{
				case 1u:
					num += this.options_.CalculateSize(EnumValue._repeated_options_codec);
					arg_83_0 = 2013680429u;
					continue;
				case 2u:
					goto IL_B6;
				case 3u:
					num += 1 + CodedOutputStream.ComputeInt32Size(this.Number);
					arg_83_0 = (num2 * 1440779219u ^ 296200937u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_83_0 = (num2 * 2107870636u ^ 1372212505u);
					continue;
				case 5u:
					goto IL_21;
				}
				break;
			}
			return num;
			IL_21:
			arg_83_0 = 342233061u;
			goto IL_7E;
			IL_B6:
			arg_83_0 = ((this.Number != 0) ? 1239656696u : 1726837248u);
			goto IL_7E;
		}

		public void MergeFrom(EnumValue other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 567684231u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					goto IL_AD;
				case 2u:
					return;
				case 4u:
					this.Name = other.Name;
					arg_76_0 = (num * 2625073886u ^ 1296062046u);
					continue;
				case 5u:
					arg_76_0 = ((other.Number == 0) ? 714936557u : 1588040007u);
					continue;
				case 6u:
					this.Number = other.Number;
					arg_76_0 = (num * 3772068530u ^ 2658697069u);
					continue;
				}
				break;
			}
			this.options_.Add(other.options_);
			return;
			IL_6C:
			arg_76_0 = 709932626u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((EnumValue.smethod_1(other.Name) != 0) ? 1210845964u : 795305684u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_150:
				uint num;
				uint arg_104_0 = ((num = input.ReadTag()) == 0u) ? 416293401u : 409600358u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_104_0 ^ 666589009u)) % 12u)
					{
					case 0u:
						this.Name = input.ReadString();
						arg_104_0 = 1442496323u;
						continue;
					case 1u:
						goto IL_150;
					case 2u:
						this.options_.AddEntriesFrom(input, EnumValue._repeated_options_codec);
						arg_104_0 = 974920364u;
						continue;
					case 3u:
						arg_104_0 = 409600358u;
						continue;
					case 4u:
						arg_104_0 = (((num != 26u) ? 3122312244u : 3964631275u) ^ num2 * 287224782u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_104_0 = (num2 * 1486795301u ^ 2674616021u);
						continue;
					case 6u:
						arg_104_0 = (num2 * 2771715597u ^ 3298766406u);
						continue;
					case 7u:
						this.Number = input.ReadInt32();
						arg_104_0 = 1381355227u;
						continue;
					case 9u:
						arg_104_0 = (((num != 16u) ? 750795827u : 1747017632u) ^ num2 * 2740766954u);
						continue;
					case 10u:
						arg_104_0 = (num2 * 3564854786u ^ 2945959352u);
						continue;
					case 11u:
						arg_104_0 = ((num == 10u) ? 1937252605u : 1686097524u);
						continue;
					}
					return;
				}
			}
		}

		static EnumValue()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 63682824u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 75839514u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 1u:
						EnumValue._repeated_options_codec = FieldCodec.ForMessage<Option>(26u, Option.Parser);
						arg_3F_0 = (num * 2933116177u ^ 3836487746u);
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

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
