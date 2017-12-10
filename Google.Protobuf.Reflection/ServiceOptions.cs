using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class ServiceOptions : IMessage, IMessage<ServiceOptions>, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>
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

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

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
				switch ((arg_72_0 ^ -1758739096) % 9)
				{
				case 0:
					arg_72_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? -1888253396 : -1517905336);
					continue;
				case 1:
					arg_72_0 = ((this.Deprecated == other.Deprecated) ? -483985860 : -210393587);
					continue;
				case 2:
					goto IL_B0;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					goto IL_15;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = -506187043;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? -1321179362 : -2037169859);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 374073514u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 1481268609u)) % 4u)
					{
					case 0u:
						goto IL_6C;
					case 2u:
						num ^= this.Deprecated.GetHashCode();
						arg_50_0 = (num2 * 2650918994u ^ 3180135376u);
						continue;
					case 3u:
						arg_50_0 = (((!this.Deprecated) ? 956478894u : 1775457557u) ^ num2 * 2802779062u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			return num ^ this.uninterpretedOption_.GetHashCode();
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
				switch ((num = (arg_39_0 ^ 1852093021u)) % 4u)
				{
				case 0u:
					goto IL_55;
				case 1u:
					output.WriteRawTag(136, 2);
					output.WriteBool(this.Deprecated);
					arg_39_0 = (num * 1858635082u ^ 4052972275u);
					continue;
				case 2u:
					goto IL_08;
				}
				break;
			}
			return;
			IL_08:
			arg_39_0 = 2114046012u;
			goto IL_34;
			IL_55:
			this.uninterpretedOption_.WriteTo(output, ServiceOptions._repeated_uninterpretedOption_codec);
			arg_39_0 = 1737683498u;
			goto IL_34;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_5F:
				uint arg_43_0 = 245102029u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_43_0 ^ 1888696715u)) % 4u)
					{
					case 0u:
						goto IL_5F;
					case 1u:
						num += 3;
						arg_43_0 = (num2 * 1287389257u ^ 4274777725u);
						continue;
					case 2u:
						arg_43_0 = (((!this.Deprecated) ? 2213906878u : 4208026512u) ^ num2 * 4278710321u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			return num + this.uninterpretedOption_.CalculateSize(ServiceOptions._repeated_uninterpretedOption_codec);
		}

		public void MergeFrom(ServiceOptions other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 509251058u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 1u:
					return;
				case 2u:
					this.Deprecated = other.Deprecated;
					arg_37_0 = (num * 2644538263u ^ 2645658054u);
					continue;
				case 4u:
					goto IL_12;
				}
				break;
			}
			this.uninterpretedOption_.Add(other.uninterpretedOption_);
			return;
			IL_12:
			arg_37_0 = 2129946465u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((!other.Deprecated) ? 1676937751u : 1278713125u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_E8:
				uint num;
				uint arg_AD_0 = ((num = input.ReadTag()) == 0u) ? 1153850315u : 1212421989u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AD_0 ^ 1336647724u)) % 8u)
					{
					case 0u:
						input.SkipLastField();
						arg_AD_0 = (num2 * 3674273195u ^ 3201607362u);
						continue;
					case 1u:
						arg_AD_0 = ((num == 264u) ? 1886731503u : 124793680u);
						continue;
					case 2u:
						this.uninterpretedOption_.AddEntriesFrom(input, ServiceOptions._repeated_uninterpretedOption_codec);
						arg_AD_0 = 935786242u;
						continue;
					case 3u:
						this.Deprecated = input.ReadBool();
						arg_AD_0 = 935786242u;
						continue;
					case 4u:
						arg_AD_0 = (((num != 7994u) ? 1425744544u : 464008146u) ^ num2 * 861504877u);
						continue;
					case 5u:
						arg_AD_0 = 1212421989u;
						continue;
					case 6u:
						goto IL_E8;
					}
					return;
				}
			}
		}
	}
}
