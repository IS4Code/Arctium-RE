using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class EnumValueOptions : IMessage, IMessage<EnumValueOptions>, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>
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

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

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
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 112232859) % 9)
				{
				case 0:
					arg_72_0 = ((this.Deprecated == other.Deprecated) ? 1914373914 : 516822198);
					continue;
				case 1:
					goto IL_B0;
				case 2:
					return true;
				case 3:
					arg_72_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? 1143907871 : 378601625);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 2118201144;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1000512455 : 1842659762);
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
				switch ((num2 = (arg_36_0 ^ 1125966526u)) % 4u)
				{
				case 0u:
					goto IL_2C;
				case 1u:
					goto IL_52;
				case 2u:
					num ^= this.Deprecated.GetHashCode();
					arg_36_0 = (num2 * 1753158237u ^ 2182088965u);
					continue;
				}
				break;
			}
			return num;
			IL_2C:
			arg_36_0 = 1951907892u;
			goto IL_31;
			IL_52:
			num ^= this.uninterpretedOption_.GetHashCode();
			arg_36_0 = 582789725u;
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
					uint arg_3E_0 = 2604806158u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 2607449397u)) % 4u)
						{
						case 0u:
							goto IL_5A;
						case 1u:
							output.WriteBool(this.Deprecated);
							arg_3E_0 = (num * 3148371814u ^ 2433607889u);
							continue;
						case 3u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 1786734334u ^ 736276914u);
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
			while (true)
			{
				IL_5F:
				uint arg_43_0 = 850947573u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_43_0 ^ 130303860u)) % 4u)
					{
					case 0u:
						num += 2;
						arg_43_0 = (num2 * 4245717394u ^ 3482298782u);
						continue;
					case 1u:
						arg_43_0 = (((!this.Deprecated) ? 2600590822u : 2637173428u) ^ num2 * 134263336u);
						continue;
					case 3u:
						goto IL_5F;
					}
					goto Block_2;
				}
			}
			Block_2:
			return num + this.uninterpretedOption_.CalculateSize(EnumValueOptions._repeated_uninterpretedOption_codec);
		}

		public void MergeFrom(EnumValueOptions other)
		{
			if (other == null)
			{
				goto IL_45;
			}
			goto IL_7F;
			uint arg_4F_0;
			while (true)
			{
				IL_4A:
				uint num;
				switch ((num = (arg_4F_0 ^ 551838217u)) % 6u)
				{
				case 0u:
					goto IL_7F;
				case 1u:
					return;
				case 2u:
					goto IL_45;
				case 4u:
					this.Deprecated = other.Deprecated;
					arg_4F_0 = (num * 2571772505u ^ 819088540u);
					continue;
				case 5u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_4F_0 = 1329798078u;
					continue;
				}
				break;
			}
			return;
			IL_45:
			arg_4F_0 = 783641012u;
			goto IL_4A;
			IL_7F:
			arg_4F_0 = (other.Deprecated ? 666919087u : 218676010u);
			goto IL_4A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_10B:
				uint num;
				uint arg_C7_0 = ((num = input.ReadTag()) != 0u) ? 603123006u : 1419274826u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C7_0 ^ 514801088u)) % 10u)
					{
					case 0u:
						input.SkipLastField();
						arg_C7_0 = (num2 * 1304296175u ^ 503759671u);
						continue;
					case 1u:
						this.Deprecated = input.ReadBool();
						arg_C7_0 = 1994466746u;
						continue;
					case 2u:
						goto IL_10B;
					case 3u:
						arg_C7_0 = 603123006u;
						continue;
					case 5u:
						this.uninterpretedOption_.AddEntriesFrom(input, EnumValueOptions._repeated_uninterpretedOption_codec);
						arg_C7_0 = 381322450u;
						continue;
					case 6u:
						arg_C7_0 = ((num != 8u) ? 981856979u : 1014376005u);
						continue;
					case 7u:
						arg_C7_0 = (num2 * 2635247053u ^ 542743533u);
						continue;
					case 8u:
						arg_C7_0 = (num2 * 364549348u ^ 3236089978u);
						continue;
					case 9u:
						arg_C7_0 = (((num == 7994u) ? 1613855263u : 1415847954u) ^ num2 * 194241794u);
						continue;
					}
					return;
				}
			}
		}
	}
}
