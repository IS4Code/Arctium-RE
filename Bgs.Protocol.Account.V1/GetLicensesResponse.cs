using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetLicensesResponse : IMessage<GetLicensesResponse>, IEquatable<GetLicensesResponse>, IDeepCloneable<GetLicensesResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetLicensesResponse.__c __9 = new GetLicensesResponse.__c();

			internal GetLicensesResponse cctor>b__24_0()
			{
				return new GetLicensesResponse();
			}
		}

		private static readonly MessageParser<GetLicensesResponse> _parser = new MessageParser<GetLicensesResponse>(new Func<GetLicensesResponse>(GetLicensesResponse.__c.__9.<.cctor>b__24_0));

		public const int LicensesFieldNumber = 1;

		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec;

		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		public static MessageParser<GetLicensesResponse> Parser
		{
			get
			{
				return GetLicensesResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLicensesResponse.Descriptor;
			}
		}

		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		public GetLicensesResponse()
		{
		}

		public GetLicensesResponse(GetLicensesResponse other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 2206327624u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 2851254482u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 1u:
						this.licenses_ = other.licenses_.Clone();
						arg_2B_0 = (num * 4130054089u ^ 1660521777u);
						continue;
					}
					return;
				}
			}
		}

		public GetLicensesResponse Clone()
		{
			return new GetLicensesResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetLicensesResponse);
		}

		public bool Equals(GetLicensesResponse other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -287515574) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return true;
				case 2:
					goto IL_7A;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_48_0 = (this.licenses_.Equals(other.licenses_) ? -101443845 : -796685897);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -713448591;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -535255561 : -802819687);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ GetLicensesResponse.smethod_0(this.licenses_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.licenses_.WriteTo(output, GetLicensesResponse._repeated_licenses_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.licenses_.CalculateSize(GetLicensesResponse._repeated_licenses_codec);
		}

		public void MergeFrom(GetLicensesResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.licenses_.Add(other.licenses_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) == 0u) ? 2574315613u : 3852361241u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 4187634862u)) % 6u)
					{
					case 0u:
						goto IL_9B;
					case 1u:
						arg_68_0 = ((num == 10u) ? 3139395910u : 2965425019u);
						continue;
					case 2u:
						this.licenses_.AddEntriesFrom(input, GetLicensesResponse._repeated_licenses_codec);
						arg_68_0 = 2171913076u;
						continue;
					case 4u:
						arg_68_0 = 3852361241u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_68_0 = (num2 * 131208628u ^ 2876275120u);
						continue;
					}
					return;
				}
			}
		}

		static GetLicensesResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 31179470u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 412345023u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 2u:
						GetLicensesResponse._repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(10u, AccountLicense.Parser);
						arg_3F_0 = (num * 2098488761u ^ 574038117u);
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
