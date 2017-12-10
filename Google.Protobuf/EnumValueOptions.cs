using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class EnumValueOptions : IMessage<EnumValueOptions>, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EnumValueOptions.__c __9 = new EnumValueOptions.__c();

			internal EnumValueOptions cctor>b__29_0()
			{
				return new EnumValueOptions();
			}
		}

		private static readonly MessageParser<EnumValueOptions> _parser = new MessageParser<EnumValueOptions>(new Func<EnumValueOptions>(EnumValueOptions.__c.__9.<.cctor>b__29_0));

		public const int DeprecatedFieldNumber = 1;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<EnumValueOptions> Parser
		{
			get
			{
				return EnumValueOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[13];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumValueOptions.Descriptor;
			}
		}

		public bool Deprecated
		{
			get
			{
				return this.deprecated_;
			}
			set
			{
				this.deprecated_ = value;
			}
		}

		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return this.uninterpretedOption_;
			}
		}

		public EnumValueOptions()
		{
		}

		public EnumValueOptions(EnumValueOptions other) : this()
		{
			this.deprecated_ = other.deprecated_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		public EnumValueOptions Clone()
		{
			return new EnumValueOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EnumValueOptions);
		}

		public bool Equals(EnumValueOptions other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ -437566670) % 9)
				{
				case 1:
					arg_72_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? -938215988 : -1732494269);
					continue;
				case 2:
					goto IL_3C;
				case 3:
					arg_72_0 = ((this.Deprecated == other.Deprecated) ? -625092412 : -538636665);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					goto IL_B0;
				}
				break;
			}
			return true;
			IL_3C:
			arg_72_0 = -1553798042;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? -396439773 : -1140720406);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Deprecated)
			{
				goto IL_2C;
			}
			goto IL_52;
			uint arg_36_0;
			while (true)
			{
				IL_31:
				uint num2;
				switch ((num2 = (arg_36_0 ^ 1868574158u)) % 4u)
				{
				case 0u:
					goto IL_52;
				case 2u:
					goto IL_2C;
				case 3u:
					num ^= this.Deprecated.GetHashCode();
					arg_36_0 = (num2 * 3832777165u ^ 4234247437u);
					continue;
				}
				break;
			}
			return num;
			IL_2C:
			arg_36_0 = 1795489561u;
			goto IL_31;
			IL_52:
			num ^= this.uninterpretedOption_.GetHashCode();
			arg_36_0 = 1147256903u;
			goto IL_31;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Deprecated)
			{
				while (true)
				{
					IL_5A:
					uint arg_3E_0 = 3165138810u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 3302623733u)) % 4u)
						{
						case 0u:
							goto IL_5A;
						case 2u:
							output.WriteBool(this.Deprecated);
							arg_3E_0 = (num * 2642780841u ^ 3534470462u);
							continue;
						case 3u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 2703627813u ^ 193737820u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			this.uninterpretedOption_.WriteTo(output, EnumValueOptions._repeated_uninterpretedOption_codec);
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Deprecated)
			{
				goto IL_1F;
			}
			goto IL_45;
			uint arg_29_0;
			while (true)
			{
				IL_24:
				uint num2;
				switch ((num2 = (arg_29_0 ^ 75194031u)) % 4u)
				{
				case 0u:
					goto IL_45;
				case 2u:
					goto IL_1F;
				case 3u:
					num += 2;
					arg_29_0 = (num2 * 3737109011u ^ 3607457126u);
					continue;
				}
				break;
			}
			return num;
			IL_1F:
			arg_29_0 = 784902496u;
			goto IL_24;
			IL_45:
			num += this.uninterpretedOption_.CalculateSize(EnumValueOptions._repeated_uninterpretedOption_codec);
			arg_29_0 = 1661349550u;
			goto IL_24;
		}

		public void MergeFrom(EnumValueOptions other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 2213461223u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					return;
				case 3u:
					goto IL_63;
				case 4u:
					this.Deprecated = other.Deprecated;
					arg_37_0 = (num * 978845515u ^ 2848557814u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.Add(other.uninterpretedOption_);
			return;
			IL_2D:
			arg_37_0 = 2459211834u;
			goto IL_32;
			IL_63:
			arg_37_0 = (other.Deprecated ? 4110591486u : 2623785893u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_E1:
				uint num;
				uint arg_A6_0 = ((num = input.ReadTag()) == 0u) ? 467991754u : 1542563083u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A6_0 ^ 1888616232u)) % 8u)
					{
					case 0u:
						this.uninterpretedOption_.AddEntriesFrom(input, EnumValueOptions._repeated_uninterpretedOption_codec);
						arg_A6_0 = 931461086u;
						continue;
					case 1u:
						arg_A6_0 = (((num != 7994u) ? 3971671739u : 3104538679u) ^ num2 * 4099945287u);
						continue;
					case 3u:
						arg_A6_0 = ((num == 8u) ? 766682487u : 1250534409u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_A6_0 = (num2 * 2645129090u ^ 4119556278u);
						continue;
					case 5u:
						arg_A6_0 = 1542563083u;
						continue;
					case 6u:
						goto IL_E1;
					case 7u:
						this.Deprecated = input.ReadBool();
						arg_A6_0 = 931461086u;
						continue;
					}
					return;
				}
			}
		}
	}
}
