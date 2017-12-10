using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class ViewFriendsResponse : IMessage<ViewFriendsResponse>, IEquatable<ViewFriendsResponse>, IDeepCloneable<ViewFriendsResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ViewFriendsResponse.__c __9 = new ViewFriendsResponse.__c();

			internal ViewFriendsResponse cctor>b__24_0()
			{
				return new ViewFriendsResponse();
			}
		}

		private static readonly MessageParser<ViewFriendsResponse> _parser = new MessageParser<ViewFriendsResponse>(new Func<ViewFriendsResponse>(ViewFriendsResponse.__c.__9.<.cctor>b__24_0));

		public const int FriendsFieldNumber = 1;

		private static readonly FieldCodec<Friend> _repeated_friends_codec = FieldCodec.ForMessage<Friend>(10u, Friend.Parser);

		private readonly RepeatedField<Friend> friends_ = new RepeatedField<Friend>();

		public static MessageParser<ViewFriendsResponse> Parser
		{
			get
			{
				return ViewFriendsResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ViewFriendsResponse.Descriptor;
			}
		}

		public RepeatedField<Friend> Friends
		{
			get
			{
				return this.friends_;
			}
		}

		public ViewFriendsResponse()
		{
		}

		public ViewFriendsResponse(ViewFriendsResponse other) : this()
		{
			this.friends_ = other.friends_.Clone();
		}

		public ViewFriendsResponse Clone()
		{
			return new ViewFriendsResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ViewFriendsResponse);
		}

		public bool Equals(ViewFriendsResponse other)
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
				switch ((arg_48_0 ^ 351796002) % 7)
				{
				case 0:
					return true;
				case 1:
					goto IL_7A;
				case 2:
					return false;
				case 3:
					goto IL_3E;
				case 4:
					arg_48_0 = ((!this.friends_.Equals(other.friends_)) ? 1546253097 : 2140403594);
					continue;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 2006988750;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 926456398 : 147531392);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ViewFriendsResponse.smethod_0(this.friends_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.friends_.WriteTo(output, ViewFriendsResponse._repeated_friends_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.friends_.CalculateSize(ViewFriendsResponse._repeated_friends_codec);
		}

		public void MergeFrom(ViewFriendsResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.friends_.Add(other.friends_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) != 0u) ? 359049588u : 2126554113u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 128639523u)) % 6u)
					{
					case 0u:
						input.SkipLastField();
						arg_68_0 = (num2 * 1764236601u ^ 4116206068u);
						continue;
					case 1u:
						goto IL_9B;
					case 2u:
						arg_68_0 = 359049588u;
						continue;
					case 3u:
						arg_68_0 = ((num != 10u) ? 1515546423u : 1707017196u);
						continue;
					case 5u:
						this.friends_.AddEntriesFrom(input, ViewFriendsResponse._repeated_friends_codec);
						arg_68_0 = 709866624u;
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
