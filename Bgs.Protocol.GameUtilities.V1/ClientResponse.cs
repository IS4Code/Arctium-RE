using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class ClientResponse : IMessage<ClientResponse>, IEquatable<ClientResponse>, IDeepCloneable<ClientResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ClientResponse.__c __9 = new ClientResponse.__c();

			internal ClientResponse cctor>b__24_0()
			{
				return new ClientResponse();
			}
		}

		private static readonly MessageParser<ClientResponse> _parser = new MessageParser<ClientResponse>(new Func<ClientResponse>(ClientResponse.__c.__9.<.cctor>b__24_0));

		public const int AttributeFieldNumber = 1;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public static MessageParser<ClientResponse> Parser
		{
			get
			{
				return ClientResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientResponse.Descriptor;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public ClientResponse()
		{
		}

		public ClientResponse(ClientResponse other) : this()
		{
			this.attribute_ = other.attribute_.Clone();
		}

		public ClientResponse Clone()
		{
			return new ClientResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ClientResponse);
		}

		public bool Equals(ClientResponse other)
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
				switch ((arg_48_0 ^ -1093743989) % 7)
				{
				case 0:
					goto IL_3E;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_7A;
				case 5:
					return true;
				case 6:
					arg_48_0 = ((!this.attribute_.Equals(other.attribute_)) ? -113119311 : -761561000);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1938954141;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1143993268 : -436043903);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ClientResponse.smethod_0(this.attribute_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.attribute_.WriteTo(output, ClientResponse._repeated_attribute_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.attribute_.CalculateSize(ClientResponse._repeated_attribute_codec);
		}

		public void MergeFrom(ClientResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.attribute_.Add(other.attribute_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 1189480128u : 690527245u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 1760580142u)) % 7u)
					{
					case 0u:
						arg_77_0 = (num2 * 197953883u ^ 3739829084u);
						continue;
					case 1u:
						input.SkipLastField();
						arg_77_0 = (num2 * 1273257394u ^ 3253726107u);
						continue;
					case 2u:
						goto IL_AE;
					case 3u:
						this.attribute_.AddEntriesFrom(input, ClientResponse._repeated_attribute_codec);
						arg_77_0 = 1115982887u;
						continue;
					case 4u:
						arg_77_0 = 1189480128u;
						continue;
					case 6u:
						arg_77_0 = ((num != 10u) ? 900825556u : 1977270860u);
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
