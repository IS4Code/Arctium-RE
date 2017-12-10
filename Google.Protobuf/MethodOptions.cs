using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class MethodOptions : IMessage<MethodOptions>, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>, IMessage
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

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);

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
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 49821427) % 9)
				{
				case 0:
					return true;
				case 1:
					goto IL_B0;
				case 2:
					arg_72_0 = ((this.Deprecated != other.Deprecated) ? 623402464 : 894237102);
					continue;
				case 3:
					goto IL_41;
				case 4:
					arg_72_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? 1204409076 : 747244298);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return false;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 331012446;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1231575750 : 1890664014);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_88:
				uint arg_68_0 = 1766356456u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 2019415767u)) % 5u)
					{
					case 0u:
						num ^= this.uninterpretedOption_.GetHashCode();
						arg_68_0 = 1707643977u;
						continue;
					case 1u:
						num ^= this.Deprecated.GetHashCode();
						arg_68_0 = (num2 * 2040794719u ^ 155732523u);
						continue;
					case 3u:
						goto IL_88;
					case 4u:
						arg_68_0 = ((this.Deprecated ? 975214686u : 2034139678u) ^ num2 * 211047573u);
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
			if (this.Deprecated)
			{
				goto IL_31;
			}
			goto IL_57;
			uint arg_3B_0;
			while (true)
			{
				IL_36:
				uint num;
				switch ((num = (arg_3B_0 ^ 30129478u)) % 4u)
				{
				case 0u:
					goto IL_57;
				case 2u:
					goto IL_31;
				case 3u:
					output.WriteRawTag(136, 2);
					output.WriteBool(this.Deprecated);
					arg_3B_0 = (num * 1594343042u ^ 4254010524u);
					continue;
				}
				break;
			}
			return;
			IL_31:
			arg_3B_0 = 1231131929u;
			goto IL_36;
			IL_57:
			this.uninterpretedOption_.WriteTo(output, MethodOptions._repeated_uninterpretedOption_codec);
			arg_3B_0 = 1198374859u;
			goto IL_36;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_5F:
				uint arg_43_0 = 1334836919u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_43_0 ^ 1967115853u)) % 4u)
					{
					case 0u:
						goto IL_5F;
					case 1u:
						num += 3;
						arg_43_0 = (num2 * 605396567u ^ 3014393125u);
						continue;
					case 2u:
						arg_43_0 = (((!this.Deprecated) ? 3684171696u : 3921957486u) ^ num2 * 2567224919u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			return num + this.uninterpretedOption_.CalculateSize(MethodOptions._repeated_uninterpretedOption_codec);
		}

		public void MergeFrom(MethodOptions other)
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
				switch ((num = (arg_37_0 ^ 3740351164u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					goto IL_63;
				case 3u:
					return;
				case 4u:
					this.Deprecated = other.Deprecated;
					arg_37_0 = (num * 525740416u ^ 839497249u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.Add(other.uninterpretedOption_);
			return;
			IL_2D:
			arg_37_0 = 3794264087u;
			goto IL_32;
			IL_63:
			arg_37_0 = (other.Deprecated ? 3811210586u : 2361294625u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_FC:
				uint num;
				uint arg_BC_0 = ((num = input.ReadTag()) == 0u) ? 979778583u : 676086833u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BC_0 ^ 1238858147u)) % 9u)
					{
					case 0u:
						arg_BC_0 = 676086833u;
						continue;
					case 2u:
						arg_BC_0 = (num2 * 2406314712u ^ 1735247836u);
						continue;
					case 3u:
						goto IL_FC;
					case 4u:
						arg_BC_0 = (((num != 7994u) ? 3123669827u : 2466361192u) ^ num2 * 604729040u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_BC_0 = (num2 * 1207948990u ^ 4249071532u);
						continue;
					case 6u:
						arg_BC_0 = ((num != 264u) ? 625027734u : 64371090u);
						continue;
					case 7u:
						this.uninterpretedOption_.AddEntriesFrom(input, MethodOptions._repeated_uninterpretedOption_codec);
						arg_BC_0 = 1789461388u;
						continue;
					case 8u:
						this.Deprecated = input.ReadBool();
						arg_BC_0 = 1580931613u;
						continue;
					}
					return;
				}
			}
		}
	}
}
