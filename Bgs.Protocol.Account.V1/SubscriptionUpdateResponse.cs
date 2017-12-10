using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscriptionUpdateResponse : IMessage<SubscriptionUpdateResponse>, IEquatable<SubscriptionUpdateResponse>, IDeepCloneable<SubscriptionUpdateResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscriptionUpdateResponse.__c __9 = new SubscriptionUpdateResponse.__c();

			internal SubscriptionUpdateResponse cctor>b__24_0()
			{
				return new SubscriptionUpdateResponse();
			}
		}

		private static readonly MessageParser<SubscriptionUpdateResponse> _parser = new MessageParser<SubscriptionUpdateResponse>(new Func<SubscriptionUpdateResponse>(SubscriptionUpdateResponse.__c.__9.<.cctor>b__24_0));

		public const int RefFieldNumber = 1;

		private static readonly FieldCodec<SubscriberReference> _repeated_ref_codec = FieldCodec.ForMessage<SubscriberReference>(10u, SubscriberReference.Parser);

		private readonly RepeatedField<SubscriberReference> ref_ = new RepeatedField<SubscriberReference>();

		public static MessageParser<SubscriptionUpdateResponse> Parser
		{
			get
			{
				return SubscriptionUpdateResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriptionUpdateResponse.Descriptor;
			}
		}

		public RepeatedField<SubscriberReference> Ref
		{
			get
			{
				return this.ref_;
			}
		}

		public SubscriptionUpdateResponse()
		{
		}

		public SubscriptionUpdateResponse(SubscriptionUpdateResponse other) : this()
		{
			this.ref_ = other.ref_.Clone();
		}

		public SubscriptionUpdateResponse Clone()
		{
			return new SubscriptionUpdateResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriptionUpdateResponse);
		}

		public bool Equals(SubscriptionUpdateResponse other)
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
				switch ((arg_48_0 ^ -1766069471) % 7)
				{
				case 0:
					return false;
				case 1:
					goto IL_7A;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_3E;
				case 6:
					arg_48_0 = (this.ref_.Equals(other.ref_) ? -591953562 : -611880218);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -314018968;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -395265759 : -110640070);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ SubscriptionUpdateResponse.smethod_0(this.ref_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.ref_.WriteTo(output, SubscriptionUpdateResponse._repeated_ref_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.ref_.CalculateSize(SubscriptionUpdateResponse._repeated_ref_codec);
		}

		public void MergeFrom(SubscriptionUpdateResponse other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 1983725271;
			IL_08:
			switch ((arg_0D_0 ^ 2096316593) % 4)
			{
			case 0:
				goto IL_03;
			case 2:
				return;
			case 3:
				IL_27:
				this.ref_.Add(other.ref_);
				arg_0D_0 = 193908724;
				goto IL_08;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) == 0u) ? 2519376809u : 3420373307u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 3424488679u)) % 7u)
					{
					case 0u:
						goto IL_AE;
					case 1u:
						arg_77_0 = ((num == 10u) ? 2764384404u : 3521703815u);
						continue;
					case 2u:
						arg_77_0 = 3420373307u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_77_0 = (num2 * 4092986896u ^ 2399762539u);
						continue;
					case 5u:
						this.ref_.AddEntriesFrom(input, SubscriptionUpdateResponse._repeated_ref_codec);
						arg_77_0 = 4050220892u;
						continue;
					case 6u:
						arg_77_0 = (num2 * 3647175931u ^ 58767384u);
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
