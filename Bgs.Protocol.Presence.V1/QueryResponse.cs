using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class QueryResponse : IMessage<QueryResponse>, IEquatable<QueryResponse>, IDeepCloneable<QueryResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly QueryResponse.__c __9 = new QueryResponse.__c();

			internal QueryResponse cctor>b__24_0()
			{
				return new QueryResponse();
			}
		}

		private static readonly MessageParser<QueryResponse> _parser = new MessageParser<QueryResponse>(new Func<QueryResponse>(QueryResponse.__c.__9.<.cctor>b__24_0));

		public const int FieldFieldNumber = 2;

		private static readonly FieldCodec<Field> _repeated_field_codec = FieldCodec.ForMessage<Field>(18u, Bgs.Protocol.Presence.V1.Field.Parser);

		private readonly RepeatedField<Field> field_ = new RepeatedField<Field>();

		public static MessageParser<QueryResponse> Parser
		{
			get
			{
				return QueryResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryResponse.Descriptor;
			}
		}

		public RepeatedField<Field> Field
		{
			get
			{
				return this.field_;
			}
		}

		public QueryResponse()
		{
		}

		public QueryResponse(QueryResponse other) : this()
		{
			this.field_ = other.field_.Clone();
		}

		public QueryResponse Clone()
		{
			return new QueryResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as QueryResponse);
		}

		public bool Equals(QueryResponse other)
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
				switch ((arg_48_0 ^ 1699628692) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return false;
				case 2:
					return true;
				case 4:
					return false;
				case 5:
					goto IL_7A;
				case 6:
					arg_48_0 = ((!this.field_.Equals(other.field_)) ? 1018905243 : 620130648);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 540813264;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 1080980239 : 1905494726);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ QueryResponse.smethod_0(this.field_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.field_.WriteTo(output, QueryResponse._repeated_field_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.field_.CalculateSize(QueryResponse._repeated_field_codec);
		}

		public void MergeFrom(QueryResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.field_.Add(other.field_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) == 0u) ? 1425174024u : 2096751585u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 792860615u)) % 7u)
					{
					case 0u:
						arg_77_0 = (num2 * 1995141066u ^ 2616893159u);
						continue;
					case 1u:
						arg_77_0 = ((num != 18u) ? 1821064951u : 7951922u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_77_0 = (num2 * 228245034u ^ 3230224358u);
						continue;
					case 3u:
						arg_77_0 = 2096751585u;
						continue;
					case 5u:
						this.field_.AddEntriesFrom(input, QueryResponse._repeated_field_codec);
						arg_77_0 = 94887853u;
						continue;
					case 6u:
						goto IL_AE;
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
