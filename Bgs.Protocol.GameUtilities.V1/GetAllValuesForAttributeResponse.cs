using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAllValuesForAttributeResponse : IMessage<GetAllValuesForAttributeResponse>, IEquatable<GetAllValuesForAttributeResponse>, IDeepCloneable<GetAllValuesForAttributeResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAllValuesForAttributeResponse.__c __9 = new GetAllValuesForAttributeResponse.__c();

			internal GetAllValuesForAttributeResponse cctor>b__24_0()
			{
				return new GetAllValuesForAttributeResponse();
			}
		}

		private static readonly MessageParser<GetAllValuesForAttributeResponse> _parser = new MessageParser<GetAllValuesForAttributeResponse>(new Func<GetAllValuesForAttributeResponse>(GetAllValuesForAttributeResponse.__c.__9.<.cctor>b__24_0));

		public const int AttributeValueFieldNumber = 1;

		private static readonly FieldCodec<Variant> _repeated_attributeValue_codec;

		private readonly RepeatedField<Variant> attributeValue_ = new RepeatedField<Variant>();

		public static MessageParser<GetAllValuesForAttributeResponse> Parser
		{
			get
			{
				return GetAllValuesForAttributeResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllValuesForAttributeResponse.Descriptor;
			}
		}

		public RepeatedField<Variant> AttributeValue
		{
			get
			{
				return this.attributeValue_;
			}
		}

		public GetAllValuesForAttributeResponse()
		{
		}

		public GetAllValuesForAttributeResponse(GetAllValuesForAttributeResponse other) : this()
		{
			this.attributeValue_ = other.attributeValue_.Clone();
		}

		public GetAllValuesForAttributeResponse Clone()
		{
			return new GetAllValuesForAttributeResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllValuesForAttributeResponse);
		}

		public bool Equals(GetAllValuesForAttributeResponse other)
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
				switch ((arg_48_0 ^ -1781560238) % 7)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 3:
					goto IL_7A;
				case 4:
					goto IL_3E;
				case 5:
					arg_48_0 = ((!this.attributeValue_.Equals(other.attributeValue_)) ? -230659895 : -864873909);
					continue;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1586288690;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -744310394 : -193638282);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ GetAllValuesForAttributeResponse.smethod_0(this.attributeValue_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.attributeValue_.WriteTo(output, GetAllValuesForAttributeResponse._repeated_attributeValue_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.attributeValue_.CalculateSize(GetAllValuesForAttributeResponse._repeated_attributeValue_codec);
		}

		public void MergeFrom(GetAllValuesForAttributeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.attributeValue_.Add(other.attributeValue_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 2364831808u : 4184018896u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 3887700445u)) % 7u)
					{
					case 0u:
						goto IL_AE;
					case 2u:
						arg_77_0 = ((num != 10u) ? 3776427834u : 2453585304u);
						continue;
					case 3u:
						arg_77_0 = (num2 * 983609124u ^ 3919239383u);
						continue;
					case 4u:
						arg_77_0 = 2364831808u;
						continue;
					case 5u:
						this.attributeValue_.AddEntriesFrom(input, GetAllValuesForAttributeResponse._repeated_attributeValue_codec);
						arg_77_0 = 3960184987u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_77_0 = (num2 * 174882595u ^ 2608688051u);
						continue;
					}
					return;
				}
			}
		}

		static GetAllValuesForAttributeResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 288551660u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 759868097u)) % 3u)
					{
					case 1u:
						GetAllValuesForAttributeResponse._repeated_attributeValue_codec = FieldCodec.ForMessage<Variant>(10u, Variant.Parser);
						arg_3F_0 = (num * 1093562222u ^ 556218345u);
						continue;
					case 2u:
						goto IL_57;
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
