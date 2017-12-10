using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class ServiceOptions : IMessage<ServiceOptions>, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ServiceOptions.__c __9 = new ServiceOptions.__c();

			internal ServiceOptions cctor>b__29_0()
			{
				return new ServiceOptions();
			}
		}

		private static readonly MessageParser<ServiceOptions> _parser = new MessageParser<ServiceOptions>(new Func<ServiceOptions>(ServiceOptions.__c.__9.<.cctor>b__29_0));

		public const int DeprecatedFieldNumber = 33;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<ServiceOptions> Parser
		{
			get
			{
				return ServiceOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[14];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServiceOptions.Descriptor;
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

		public ServiceOptions()
		{
		}

		public ServiceOptions(ServiceOptions other) : this()
		{
			this.deprecated_ = other.deprecated_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		public ServiceOptions Clone()
		{
			return new ServiceOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ServiceOptions);
		}

		public bool Equals(ServiceOptions other)
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
				switch ((arg_72_0 ^ 1497457986) % 9)
				{
				case 0:
					arg_72_0 = ((this.Deprecated == other.Deprecated) ? 429105679 : 1990780323);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_72_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? 1730501385 : 65736315);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_15;
				case 7:
					goto IL_B0;
				case 8:
					return true;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 600873974;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 827867747 : 2142035229);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_88:
				uint arg_68_0 = 33129707u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 612868284u)) % 5u)
					{
					case 0u:
						num ^= this.Deprecated.GetHashCode();
						arg_68_0 = (num2 * 3581037055u ^ 1990417967u);
						continue;
					case 1u:
						arg_68_0 = ((this.Deprecated ? 1217271159u : 184188442u) ^ num2 * 3351934660u);
						continue;
					case 3u:
						num ^= this.uninterpretedOption_.GetHashCode();
						arg_68_0 = 1581433151u;
						continue;
					case 4u:
						goto IL_88;
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
				goto IL_08;
			}
			goto IL_68;
			uint arg_48_0;
			while (true)
			{
				IL_43:
				uint num;
				switch ((num = (arg_48_0 ^ 356669802u)) % 5u)
				{
				case 0u:
					output.WriteBool(this.Deprecated);
					arg_48_0 = (num * 2308284551u ^ 1780445041u);
					continue;
				case 1u:
					output.WriteRawTag(136, 2);
					arg_48_0 = (num * 2506855745u ^ 2371669128u);
					continue;
				case 2u:
					goto IL_68;
				case 3u:
					goto IL_08;
				}
				break;
			}
			return;
			IL_08:
			arg_48_0 = 772406895u;
			goto IL_43;
			IL_68:
			this.uninterpretedOption_.WriteTo(output, ServiceOptions._repeated_uninterpretedOption_codec);
			arg_48_0 = 70425635u;
			goto IL_43;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_7D:
				uint arg_5D_0 = 3680371879u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5D_0 ^ 3897290757u)) % 5u)
					{
					case 0u:
						goto IL_7D;
					case 1u:
						num += this.uninterpretedOption_.CalculateSize(ServiceOptions._repeated_uninterpretedOption_codec);
						arg_5D_0 = 4086081376u;
						continue;
					case 2u:
						num += 3;
						arg_5D_0 = (num2 * 3804460350u ^ 1732471324u);
						continue;
					case 3u:
						arg_5D_0 = (((!this.Deprecated) ? 3564392216u : 3863840967u) ^ num2 * 2853866260u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ServiceOptions other)
		{
			if (other == null)
			{
				goto IL_2A;
			}
			goto IL_7F;
			uint arg_4F_0;
			while (true)
			{
				IL_4A:
				uint num;
				switch ((num = (arg_4F_0 ^ 1223674233u)) % 6u)
				{
				case 0u:
					goto IL_7F;
				case 1u:
					return;
				case 3u:
					this.Deprecated = other.Deprecated;
					arg_4F_0 = (num * 4134251136u ^ 2100993506u);
					continue;
				case 4u:
					goto IL_2A;
				case 5u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_4F_0 = 214616627u;
					continue;
				}
				break;
			}
			return;
			IL_2A:
			arg_4F_0 = 1453366984u;
			goto IL_4A;
			IL_7F:
			arg_4F_0 = ((!other.Deprecated) ? 138041442u : 105151526u);
			goto IL_4A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_FC:
				uint num;
				uint arg_BC_0 = ((num = input.ReadTag()) != 0u) ? 4240342789u : 4182014873u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BC_0 ^ 3579890717u)) % 9u)
					{
					case 0u:
						arg_BC_0 = 4240342789u;
						continue;
					case 1u:
						this.uninterpretedOption_.AddEntriesFrom(input, ServiceOptions._repeated_uninterpretedOption_codec);
						arg_BC_0 = 2980647309u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_BC_0 = (num2 * 854246258u ^ 929116971u);
						continue;
					case 3u:
						arg_BC_0 = (((num == 7994u) ? 2551787289u : 3587348536u) ^ num2 * 3322622858u);
						continue;
					case 4u:
						arg_BC_0 = ((num == 264u) ? 3701771259u : 4131248299u);
						continue;
					case 5u:
						this.Deprecated = input.ReadBool();
						arg_BC_0 = 2980647309u;
						continue;
					case 6u:
						goto IL_FC;
					case 7u:
						arg_BC_0 = (num2 * 3922085231u ^ 3246922977u);
						continue;
					}
					return;
				}
			}
		}
	}
}
