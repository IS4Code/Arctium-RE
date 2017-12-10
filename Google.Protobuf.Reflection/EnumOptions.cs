using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class EnumOptions : IMessage, IMessage<EnumOptions>, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EnumOptions.__c __9 = new EnumOptions.__c();

			internal EnumOptions cctor>b__34_0()
			{
				return new EnumOptions();
			}
		}

		private static readonly MessageParser<EnumOptions> _parser = new MessageParser<EnumOptions>(new Func<EnumOptions>(EnumOptions.__c.__9.<.cctor>b__34_0));

		public const int AllowAliasFieldNumber = 2;

		private bool allowAlias_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<EnumOptions> Parser
		{
			get
			{
				return EnumOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumOptions.Descriptor;
			}
		}

		public bool AllowAlias
		{
			get
			{
				return this.allowAlias_;
			}
			set
			{
				this.allowAlias_ = value;
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

		public EnumOptions()
		{
		}

		public EnumOptions(EnumOptions other) : this()
		{
			this.allowAlias_ = other.allowAlias_;
			this.deprecated_ = other.deprecated_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		public EnumOptions Clone()
		{
			return new EnumOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EnumOptions);
		}

		public bool Equals(EnumOptions other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_DF;
			int arg_99_0;
			while (true)
			{
				IL_94:
				switch ((arg_99_0 ^ 1414317744) % 11)
				{
				case 1:
					return false;
				case 2:
					arg_99_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? 1612475757 : 578211947);
					continue;
				case 3:
					arg_99_0 = ((this.AllowAlias == other.AllowAlias) ? 2003681736 : 2051634553);
					continue;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					goto IL_DF;
				case 7:
					return false;
				case 8:
					arg_99_0 = ((this.Deprecated != other.Deprecated) ? 2014709146 : 397984013);
					continue;
				case 9:
					return false;
				case 10:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_99_0 = 1949715283;
			goto IL_94;
			IL_DF:
			arg_99_0 = ((other == this) ? 1847355445 : 416865994);
			goto IL_94;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B8:
				uint arg_94_0 = 2628788503u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_94_0 ^ 2664330038u)) % 6u)
					{
					case 0u:
						goto IL_B8;
					case 1u:
						num ^= this.Deprecated.GetHashCode();
						arg_94_0 = (num2 * 3088612844u ^ 2060228928u);
						continue;
					case 3u:
						arg_94_0 = (((!this.AllowAlias) ? 1670496378u : 2023273699u) ^ num2 * 3873264503u);
						continue;
					case 4u:
						num ^= this.AllowAlias.GetHashCode();
						arg_94_0 = (num2 * 1896466925u ^ 2521204087u);
						continue;
					case 5u:
						arg_94_0 = (this.Deprecated ? 3375161341u : 3029529444u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			return num ^ this.uninterpretedOption_.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.AllowAlias)
			{
				goto IL_1D;
			}
			goto IL_DE;
			uint arg_A3_0;
			while (true)
			{
				IL_9E:
				uint num;
				switch ((num = (arg_A3_0 ^ 3680659154u)) % 8u)
				{
				case 0u:
					this.uninterpretedOption_.WriteTo(output, EnumOptions._repeated_uninterpretedOption_codec);
					arg_A3_0 = 3052864879u;
					continue;
				case 1u:
					output.WriteRawTag(24);
					arg_A3_0 = (num * 1264655558u ^ 3238696398u);
					continue;
				case 2u:
					output.WriteBool(this.Deprecated);
					arg_A3_0 = (num * 670627874u ^ 4144168030u);
					continue;
				case 3u:
					output.WriteRawTag(16);
					arg_A3_0 = (num * 4058179504u ^ 213761734u);
					continue;
				case 4u:
					output.WriteBool(this.AllowAlias);
					arg_A3_0 = (num * 3611491046u ^ 3592061821u);
					continue;
				case 6u:
					goto IL_1D;
				case 7u:
					goto IL_DE;
				}
				break;
			}
			return;
			IL_1D:
			arg_A3_0 = 3852386825u;
			goto IL_9E;
			IL_DE:
			arg_A3_0 = (this.Deprecated ? 4258244883u : 3943454634u);
			goto IL_9E;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_BC:
				uint arg_94_0 = 855554177u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_94_0 ^ 347450655u)) % 7u)
					{
					case 1u:
						num += 2;
						arg_94_0 = (num2 * 61151757u ^ 1661866742u);
						continue;
					case 2u:
						goto IL_BC;
					case 3u:
						arg_94_0 = ((this.AllowAlias ? 967036353u : 953032434u) ^ num2 * 3228514913u);
						continue;
					case 4u:
						num += this.uninterpretedOption_.CalculateSize(EnumOptions._repeated_uninterpretedOption_codec);
						arg_94_0 = 1925614806u;
						continue;
					case 5u:
						arg_94_0 = ((!this.Deprecated) ? 208280348u : 1477534733u);
						continue;
					case 6u:
						num += 2;
						arg_94_0 = (num2 * 3824206164u ^ 3836465708u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(EnumOptions other)
		{
			if (other == null)
			{
				goto IL_48;
			}
			goto IL_C9;
			uint arg_8E_0;
			while (true)
			{
				IL_89:
				uint num;
				switch ((num = (arg_8E_0 ^ 3270574837u)) % 8u)
				{
				case 0u:
					this.Deprecated = other.Deprecated;
					arg_8E_0 = (num * 1856735907u ^ 4088491635u);
					continue;
				case 1u:
					arg_8E_0 = (other.Deprecated ? 3318043037u : 3255715147u);
					continue;
				case 2u:
					return;
				case 4u:
					goto IL_C9;
				case 5u:
					goto IL_48;
				case 6u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_8E_0 = 3242721382u;
					continue;
				case 7u:
					this.AllowAlias = other.AllowAlias;
					arg_8E_0 = (num * 1897175501u ^ 459337615u);
					continue;
				}
				break;
			}
			return;
			IL_48:
			arg_8E_0 = 2820239599u;
			goto IL_89;
			IL_C9:
			arg_8E_0 = ((!other.AllowAlias) ? 2640845500u : 2671364106u);
			goto IL_89;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_156:
				uint num;
				uint arg_10A_0 = ((num = input.ReadTag()) == 0u) ? 289303029u : 1338614645u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10A_0 ^ 798772916u)) % 12u)
					{
					case 0u:
						arg_10A_0 = 1338614645u;
						continue;
					case 2u:
						arg_10A_0 = (((num != 24u) ? 2232048119u : 2393422935u) ^ num2 * 2223201864u);
						continue;
					case 3u:
						this.Deprecated = input.ReadBool();
						arg_10A_0 = 440804778u;
						continue;
					case 4u:
						this.uninterpretedOption_.AddEntriesFrom(input, EnumOptions._repeated_uninterpretedOption_codec);
						arg_10A_0 = 1215983801u;
						continue;
					case 5u:
						arg_10A_0 = ((num == 16u) ? 1340613640u : 1844476166u);
						continue;
					case 6u:
						arg_10A_0 = (num2 * 667841547u ^ 1164591859u);
						continue;
					case 7u:
						arg_10A_0 = (((num != 7994u) ? 1832245718u : 634264041u) ^ num2 * 534899699u);
						continue;
					case 8u:
						this.AllowAlias = input.ReadBool();
						arg_10A_0 = 956916622u;
						continue;
					case 9u:
						goto IL_156;
					case 10u:
						arg_10A_0 = (num2 * 3154993538u ^ 2846851533u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_10A_0 = (num2 * 1085168814u ^ 554802819u);
						continue;
					}
					return;
				}
			}
		}
	}
}
