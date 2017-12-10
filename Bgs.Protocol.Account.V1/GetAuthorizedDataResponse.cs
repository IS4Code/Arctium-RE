using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAuthorizedDataResponse : IMessage<GetAuthorizedDataResponse>, IEquatable<GetAuthorizedDataResponse>, IDeepCloneable<GetAuthorizedDataResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAuthorizedDataResponse.__c __9 = new GetAuthorizedDataResponse.__c();

			internal GetAuthorizedDataResponse cctor>b__24_0()
			{
				return new GetAuthorizedDataResponse();
			}
		}

		private static readonly MessageParser<GetAuthorizedDataResponse> _parser = new MessageParser<GetAuthorizedDataResponse>(new Func<GetAuthorizedDataResponse>(GetAuthorizedDataResponse.__c.__9.<.cctor>b__24_0));

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<AuthorizedData> _repeated_data_codec = FieldCodec.ForMessage<AuthorizedData>(10u, AuthorizedData.Parser);

		private readonly RepeatedField<AuthorizedData> data_ = new RepeatedField<AuthorizedData>();

		public static MessageParser<GetAuthorizedDataResponse> Parser
		{
			get
			{
				return GetAuthorizedDataResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[27];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAuthorizedDataResponse.Descriptor;
			}
		}

		public RepeatedField<AuthorizedData> Data
		{
			get
			{
				return this.data_;
			}
		}

		public GetAuthorizedDataResponse()
		{
		}

		public GetAuthorizedDataResponse(GetAuthorizedDataResponse other) : this()
		{
			this.data_ = other.data_.Clone();
		}

		public GetAuthorizedDataResponse Clone()
		{
			return new GetAuthorizedDataResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAuthorizedDataResponse);
		}

		public bool Equals(GetAuthorizedDataResponse other)
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
				switch ((arg_48_0 ^ -1931417315) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					return false;
				case 2:
					goto IL_3E;
				case 3:
					arg_48_0 = ((!this.data_.Equals(other.data_)) ? -109050142 : -688286187);
					continue;
				case 4:
					return true;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1628249450;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -219058854 : -797118600);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ GetAuthorizedDataResponse.smethod_0(this.data_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.data_.WriteTo(output, GetAuthorizedDataResponse._repeated_data_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.data_.CalculateSize(GetAuthorizedDataResponse._repeated_data_codec);
		}

		public void MergeFrom(GetAuthorizedDataResponse other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -1115598663;
			IL_08:
			switch ((arg_0D_0 ^ -1928457469) % 4)
			{
			case 1:
				IL_27:
				this.data_.Add(other.data_);
				arg_0D_0 = -1476075793;
				goto IL_08;
			case 2:
				return;
			case 3:
				goto IL_03;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) == 0u) ? 2105610770u : 1173120909u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 68476262u)) % 6u)
					{
					case 0u:
						arg_68_0 = 1173120909u;
						continue;
					case 1u:
						goto IL_9B;
					case 3u:
						input.SkipLastField();
						arg_68_0 = (num2 * 2699704939u ^ 818698708u);
						continue;
					case 4u:
						this.data_.AddEntriesFrom(input, GetAuthorizedDataResponse._repeated_data_codec);
						arg_68_0 = 1439354213u;
						continue;
					case 5u:
						arg_68_0 = ((num == 10u) ? 1983802908u : 40186165u);
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
