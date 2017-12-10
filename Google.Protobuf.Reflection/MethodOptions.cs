using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class MethodOptions : IMessage, IMessage<MethodOptions>, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MethodOptions.__c __9 = new MethodOptions.__c();

			internal MethodOptions cctor>b__29_0()
			{
				return new MethodOptions();
			}
		}

		private static readonly MessageParser<MethodOptions> _parser = new MessageParser<MethodOptions>(new Func<MethodOptions>(MethodOptions.__c.__9.<.cctor>b__29_0));

		public const int DeprecatedFieldNumber = 33;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<MethodOptions> Parser
		{
			get
			{
				return MethodOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[15];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MethodOptions.Descriptor;
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

		public MethodOptions()
		{
		}

		public MethodOptions(MethodOptions other) : this()
		{
			this.deprecated_ = other.deprecated_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		public MethodOptions Clone()
		{
			return new MethodOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MethodOptions);
		}

		public bool Equals(MethodOptions other)
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
				switch ((arg_72_0 ^ -570054175) % 9)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					arg_72_0 = ((this.Deprecated == other.Deprecated) ? -323969140 : -908482657);
					continue;
				case 3:
					return false;
				case 4:
					arg_72_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? -1109812132 : -1976419814);
					continue;
				case 5:
					goto IL_15;
				case 7:
					goto IL_B0;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = -252551865;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? -161066970 : -18211626);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Deprecated)
			{
				goto IL_0A;
			}
			goto IL_50;
			uint arg_34_0;
			while (true)
			{
				IL_2F:
				uint num2;
				switch ((num2 = (arg_34_0 ^ 287211555u)) % 4u)
				{
				case 0u:
					goto IL_50;
				case 1u:
					num ^= this.Deprecated.GetHashCode();
					arg_34_0 = (num2 * 1458944778u ^ 922708749u);
					continue;
				case 3u:
					goto IL_0A;
				}
				break;
			}
			return num;
			IL_0A:
			arg_34_0 = 371510130u;
			goto IL_2F;
			IL_50:
			num ^= this.uninterpretedOption_.GetHashCode();
			arg_34_0 = 2140440589u;
			goto IL_2F;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Deprecated)
			{
				goto IL_08;
			}
			goto IL_55;
			uint arg_39_0;
			while (true)
			{
				IL_34:
				uint num;
				switch ((num = (arg_39_0 ^ 2685828587u)) % 4u)
				{
				case 1u:
					output.WriteRawTag(136, 2);
					output.WriteBool(this.Deprecated);
					arg_39_0 = (num * 4246634228u ^ 2215050024u);
					continue;
				case 2u:
					goto IL_08;
				case 3u:
					goto IL_55;
				}
				break;
			}
			return;
			IL_08:
			arg_39_0 = 2466340734u;
			goto IL_34;
			IL_55:
			this.uninterpretedOption_.WriteTo(output, MethodOptions._repeated_uninterpretedOption_codec);
			arg_39_0 = 4176444511u;
			goto IL_34;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_7D:
				uint arg_5D_0 = 4230789937u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5D_0 ^ 3465929929u)) % 5u)
					{
					case 0u:
						goto IL_7D;
					case 2u:
						num += 3;
						arg_5D_0 = (num2 * 1130018381u ^ 3984022599u);
						continue;
					case 3u:
						arg_5D_0 = (((!this.Deprecated) ? 4224658914u : 3273157264u) ^ num2 * 1668928858u);
						continue;
					case 4u:
						num += this.uninterpretedOption_.CalculateSize(MethodOptions._repeated_uninterpretedOption_codec);
						arg_5D_0 = 2656716330u;
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(MethodOptions other)
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
				switch ((num = (arg_4F_0 ^ 860807662u)) % 6u)
				{
				case 0u:
					goto IL_45;
				case 1u:
					return;
				case 3u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_4F_0 = 1023993496u;
					continue;
				case 4u:
					this.Deprecated = other.Deprecated;
					arg_4F_0 = (num * 3468148291u ^ 2799119977u);
					continue;
				case 5u:
					goto IL_7F;
				}
				break;
			}
			return;
			IL_45:
			arg_4F_0 = 83809757u;
			goto IL_4A;
			IL_7F:
			arg_4F_0 = (other.Deprecated ? 1116846244u : 1464362039u);
			goto IL_4A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_FC:
				uint num;
				uint arg_BC_0 = ((num = input.ReadTag()) == 0u) ? 244869978u : 269940415u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BC_0 ^ 1852255009u)) % 9u)
					{
					case 0u:
						arg_BC_0 = 269940415u;
						continue;
					case 2u:
						arg_BC_0 = (((num != 7994u) ? 3045351795u : 4156237468u) ^ num2 * 190727184u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_BC_0 = (num2 * 2174032624u ^ 4241183634u);
						continue;
					case 4u:
						this.uninterpretedOption_.AddEntriesFrom(input, MethodOptions._repeated_uninterpretedOption_codec);
						arg_BC_0 = 1762160498u;
						continue;
					case 5u:
						goto IL_FC;
					case 6u:
						arg_BC_0 = ((num != 264u) ? 186343085u : 136635237u);
						continue;
					case 7u:
						arg_BC_0 = (num2 * 2569615730u ^ 3870281566u);
						continue;
					case 8u:
						this.Deprecated = input.ReadBool();
						arg_BC_0 = 1344522983u;
						continue;
					}
					return;
				}
			}
		}
	}
}
