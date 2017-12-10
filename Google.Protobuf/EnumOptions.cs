using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class EnumOptions : IMessage<EnumOptions>, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>, IMessage
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

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

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
				goto IL_92;
			}
			goto IL_E2;
			int arg_9C_0;
			while (true)
			{
				IL_97:
				switch ((arg_9C_0 ^ -1910624679) % 11)
				{
				case 0:
					goto IL_92;
				case 1:
					arg_9C_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? -548063137 : -394165008);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					goto IL_E2;
				case 7:
					arg_9C_0 = ((this.Deprecated == other.Deprecated) ? -375963255 : -436903318);
					continue;
				case 9:
					arg_9C_0 = ((this.AllowAlias == other.AllowAlias) ? -1677668598 : -227991586);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_92:
			arg_9C_0 = -213049431;
			goto IL_97;
			IL_E2:
			arg_9C_0 = ((other != this) ? -217875738 : -632653244);
			goto IL_97;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B8:
				uint arg_94_0 = 662764307u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_94_0 ^ 434661889u)) % 6u)
					{
					case 0u:
						goto IL_B8;
					case 1u:
						num ^= this.AllowAlias.GetHashCode();
						arg_94_0 = (num2 * 1317999291u ^ 3303951973u);
						continue;
					case 2u:
						arg_94_0 = ((this.AllowAlias ? 3856317054u : 3628110016u) ^ num2 * 1870355635u);
						continue;
					case 3u:
						num ^= this.Deprecated.GetHashCode();
						arg_94_0 = (num2 * 1011000578u ^ 2027505433u);
						continue;
					case 5u:
						arg_94_0 = ((!this.Deprecated) ? 1818777787u : 405839696u);
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
				goto IL_3D;
			}
			goto IL_B5;
			uint arg_82_0;
			while (true)
			{
				IL_7D:
				uint num;
				switch ((num = (arg_82_0 ^ 1785996414u)) % 6u)
				{
				case 0u:
					output.WriteRawTag(24);
					output.WriteBool(this.Deprecated);
					arg_82_0 = (num * 3034398429u ^ 3108608839u);
					continue;
				case 2u:
					goto IL_B5;
				case 3u:
					this.uninterpretedOption_.WriteTo(output, EnumOptions._repeated_uninterpretedOption_codec);
					arg_82_0 = 316185959u;
					continue;
				case 4u:
					goto IL_3D;
				case 5u:
					output.WriteRawTag(16);
					output.WriteBool(this.AllowAlias);
					arg_82_0 = (num * 1376385980u ^ 4245688958u);
					continue;
				}
				break;
			}
			return;
			IL_3D:
			arg_82_0 = 910693749u;
			goto IL_7D;
			IL_B5:
			arg_82_0 = ((!this.Deprecated) ? 335654157u : 1033784748u);
			goto IL_7D;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.AllowAlias)
			{
				goto IL_1C;
			}
			goto IL_96;
			uint arg_66_0;
			while (true)
			{
				IL_61:
				uint num2;
				switch ((num2 = (arg_66_0 ^ 183028906u)) % 6u)
				{
				case 0u:
					num += 2;
					arg_66_0 = (num2 * 22908110u ^ 1110365872u);
					continue;
				case 1u:
					num += 2;
					arg_66_0 = (num2 * 2430781488u ^ 3366785547u);
					continue;
				case 2u:
					num += this.uninterpretedOption_.CalculateSize(EnumOptions._repeated_uninterpretedOption_codec);
					arg_66_0 = 1411401061u;
					continue;
				case 3u:
					goto IL_96;
				case 4u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_66_0 = 1560560671u;
			goto IL_61;
			IL_96:
			arg_66_0 = (this.Deprecated ? 1180929110u : 353029240u);
			goto IL_61;
		}

		public void MergeFrom(EnumOptions other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 328842286u)) % 7u)
				{
				case 1u:
					arg_76_0 = ((!other.Deprecated) ? 235929150u : 10855467u);
					continue;
				case 2u:
					this.Deprecated = other.Deprecated;
					arg_76_0 = (num * 343793203u ^ 506585281u);
					continue;
				case 3u:
					goto IL_AD;
				case 4u:
					return;
				case 5u:
					this.AllowAlias = other.AllowAlias;
					arg_76_0 = (num * 4156891808u ^ 1337165750u);
					continue;
				case 6u:
					goto IL_15;
				}
				break;
			}
			this.uninterpretedOption_.Add(other.uninterpretedOption_);
			return;
			IL_15:
			arg_76_0 = 99781312u;
			goto IL_71;
			IL_AD:
			arg_76_0 = (other.AllowAlias ? 800095212u : 1130175222u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_156:
				uint num;
				uint arg_10A_0 = ((num = input.ReadTag()) == 0u) ? 3248300982u : 3320618331u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10A_0 ^ 2281986884u)) % 12u)
					{
					case 0u:
						this.uninterpretedOption_.AddEntriesFrom(input, EnumOptions._repeated_uninterpretedOption_codec);
						arg_10A_0 = 2261241155u;
						continue;
					case 1u:
						arg_10A_0 = (((num == 24u) ? 46542638u : 2096949146u) ^ num2 * 3068586311u);
						continue;
					case 2u:
						this.AllowAlias = input.ReadBool();
						arg_10A_0 = 3399941536u;
						continue;
					case 3u:
						goto IL_156;
					case 4u:
						arg_10A_0 = (num2 * 1468470862u ^ 1088797755u);
						continue;
					case 5u:
						this.Deprecated = input.ReadBool();
						arg_10A_0 = 2261241155u;
						continue;
					case 7u:
						arg_10A_0 = ((num != 16u) ? 2289746029u : 3459762166u);
						continue;
					case 8u:
						arg_10A_0 = 3320618331u;
						continue;
					case 9u:
						arg_10A_0 = (((num == 7994u) ? 100456838u : 1388107801u) ^ num2 * 1218509562u);
						continue;
					case 10u:
						arg_10A_0 = (num2 * 3877783733u ^ 4267172525u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_10A_0 = (num2 * 1283183021u ^ 1051969641u);
						continue;
					}
					return;
				}
			}
		}

		static EnumOptions()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_5A:
				uint arg_42_0 = 2940905022u;
				while (true)
				{
					uint num;
					switch ((num = (arg_42_0 ^ 2278178933u)) % 3u)
					{
					case 0u:
						goto IL_5A;
					case 2u:
						EnumOptions._repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);
						arg_42_0 = (num * 969419338u ^ 3520755602u);
						continue;
					}
					return;
				}
			}
		}
	}
}
