using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountServiceConfig : IMessage<AccountServiceConfig>, IEquatable<AccountServiceConfig>, IDeepCloneable<AccountServiceConfig>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountServiceConfig.__c __9 = new AccountServiceConfig.__c();

			internal AccountServiceConfig cctor>b__24_0()
			{
				return new AccountServiceConfig();
			}
		}

		private static readonly MessageParser<AccountServiceConfig> _parser = new MessageParser<AccountServiceConfig>(new Func<AccountServiceConfig>(AccountServiceConfig.__c.__9.<.cctor>b__24_0));

		public const int RegionFieldNumber = 1;

		private static readonly FieldCodec<AccountServiceRegion> _repeated_region_codec = FieldCodec.ForMessage<AccountServiceRegion>(10u, AccountServiceRegion.Parser);

		private readonly RepeatedField<AccountServiceRegion> region_ = new RepeatedField<AccountServiceRegion>();

		public static MessageParser<AccountServiceConfig> Parser
		{
			get
			{
				return AccountServiceConfig._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountServiceConfig.Descriptor;
			}
		}

		public RepeatedField<AccountServiceRegion> Region
		{
			get
			{
				return this.region_;
			}
		}

		public AccountServiceConfig()
		{
		}

		public AccountServiceConfig(AccountServiceConfig other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 2477417075u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 3562155325u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 2u:
						this.region_ = other.region_.Clone();
						arg_2B_0 = (num * 1391465202u ^ 1294393050u);
						continue;
					}
					return;
				}
			}
		}

		public AccountServiceConfig Clone()
		{
			return new AccountServiceConfig(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountServiceConfig);
		}

		public bool Equals(AccountServiceConfig other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 458845330) % 7)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					goto IL_7A;
				case 3:
					arg_48_0 = (this.region_.Equals(other.region_) ? 231946564 : 534426896);
					continue;
				case 4:
					return false;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 272688443;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 341716713 : 1852000686);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ AccountServiceConfig.smethod_0(this.region_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.region_.WriteTo(output, AccountServiceConfig._repeated_region_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.region_.CalculateSize(AccountServiceConfig._repeated_region_codec);
		}

		public void MergeFrom(AccountServiceConfig other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 1721761647;
			IL_08:
			switch ((arg_0D_0 ^ 1144188344) % 4)
			{
			case 0:
				goto IL_03;
			case 2:
				IL_27:
				this.region_.Add(other.region_);
				arg_0D_0 = 118179777;
				goto IL_08;
			case 3:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) == 0u) ? 3753807522u : 3187151134u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 4273110258u)) % 7u)
					{
					case 0u:
						arg_77_0 = (num2 * 2701175227u ^ 1840857u);
						continue;
					case 1u:
						goto IL_AE;
					case 2u:
						this.region_.AddEntriesFrom(input, AccountServiceConfig._repeated_region_codec);
						arg_77_0 = 3161121141u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_77_0 = (num2 * 3359973636u ^ 3415457950u);
						continue;
					case 4u:
						arg_77_0 = 3187151134u;
						continue;
					case 5u:
						arg_77_0 = ((num == 10u) ? 2874743884u : 2483781880u);
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
