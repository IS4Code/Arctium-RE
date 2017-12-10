using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscriptionUpdateRequest : IMessage<SubscriptionUpdateRequest>, IEquatable<SubscriptionUpdateRequest>, IDeepCloneable<SubscriptionUpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscriptionUpdateRequest.__c __9 = new SubscriptionUpdateRequest.__c();

			internal SubscriptionUpdateRequest cctor>b__24_0()
			{
				return new SubscriptionUpdateRequest();
			}
		}

		private static readonly MessageParser<SubscriptionUpdateRequest> _parser = new MessageParser<SubscriptionUpdateRequest>(new Func<SubscriptionUpdateRequest>(SubscriptionUpdateRequest.__c.__9.<.cctor>b__24_0));

		public const int RefFieldNumber = 2;

		private static readonly FieldCodec<SubscriberReference> _repeated_ref_codec = FieldCodec.ForMessage<SubscriberReference>(18u, SubscriberReference.Parser);

		private readonly RepeatedField<SubscriberReference> ref_ = new RepeatedField<SubscriberReference>();

		public static MessageParser<SubscriptionUpdateRequest> Parser
		{
			get
			{
				return SubscriptionUpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriptionUpdateRequest.Descriptor;
			}
		}

		public RepeatedField<SubscriberReference> Ref
		{
			get
			{
				return this.ref_;
			}
		}

		public SubscriptionUpdateRequest()
		{
		}

		public SubscriptionUpdateRequest(SubscriptionUpdateRequest other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 874902804u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 1942352146u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 2u:
						this.ref_ = other.ref_.Clone();
						arg_2B_0 = (num * 3000122428u ^ 4119397752u);
						continue;
					}
					return;
				}
			}
		}

		public SubscriptionUpdateRequest Clone()
		{
			return new SubscriptionUpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriptionUpdateRequest);
		}

		public bool Equals(SubscriptionUpdateRequest other)
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
				switch ((arg_48_0 ^ 1978412385) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					arg_48_0 = ((!this.ref_.Equals(other.ref_)) ? 1650721842 : 921575739);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_7A;
				case 5:
					return true;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 482754061;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 251604682 : 295902617);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ SubscriptionUpdateRequest.smethod_0(this.ref_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.ref_.WriteTo(output, SubscriptionUpdateRequest._repeated_ref_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.ref_.CalculateSize(SubscriptionUpdateRequest._repeated_ref_codec);
		}

		public void MergeFrom(SubscriptionUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ref_.Add(other.ref_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 2726365516u : 3963361502u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 3133808744u)) % 7u)
					{
					case 0u:
						arg_77_0 = 2726365516u;
						continue;
					case 1u:
						this.ref_.AddEntriesFrom(input, SubscriptionUpdateRequest._repeated_ref_codec);
						arg_77_0 = 4217827931u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_77_0 = (num2 * 2028951747u ^ 3589913881u);
						continue;
					case 3u:
						arg_77_0 = ((num != 18u) ? 3946902280u : 2492028482u);
						continue;
					case 5u:
						goto IL_AE;
					case 6u:
						arg_77_0 = (num2 * 2291759807u ^ 699893044u);
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
