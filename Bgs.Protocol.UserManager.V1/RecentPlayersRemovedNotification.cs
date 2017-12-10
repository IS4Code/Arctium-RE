using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class RecentPlayersRemovedNotification : IMessage<RecentPlayersRemovedNotification>, IEquatable<RecentPlayersRemovedNotification>, IDeepCloneable<RecentPlayersRemovedNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RecentPlayersRemovedNotification.__c __9 = new RecentPlayersRemovedNotification.__c();

			internal RecentPlayersRemovedNotification cctor>b__24_0()
			{
				return new RecentPlayersRemovedNotification();
			}
		}

		private static readonly MessageParser<RecentPlayersRemovedNotification> _parser = new MessageParser<RecentPlayersRemovedNotification>(new Func<RecentPlayersRemovedNotification>(RecentPlayersRemovedNotification.__c.__9.<.cctor>b__24_0));

		public const int PlayerFieldNumber = 1;

		private static readonly FieldCodec<RecentPlayer> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayer>(10u, RecentPlayer.Parser);

		private readonly RepeatedField<RecentPlayer> player_ = new RepeatedField<RecentPlayer>();

		public static MessageParser<RecentPlayersRemovedNotification> Parser
		{
			get
			{
				return RecentPlayersRemovedNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersRemovedNotification.Descriptor;
			}
		}

		public RepeatedField<RecentPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		public RecentPlayersRemovedNotification()
		{
		}

		public RecentPlayersRemovedNotification(RecentPlayersRemovedNotification other) : this()
		{
			this.player_ = other.player_.Clone();
		}

		public RecentPlayersRemovedNotification Clone()
		{
			return new RecentPlayersRemovedNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersRemovedNotification);
		}

		public bool Equals(RecentPlayersRemovedNotification other)
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
				switch ((arg_48_0 ^ -1128086653) % 7)
				{
				case 1:
					return false;
				case 2:
					arg_48_0 = (this.player_.Equals(other.player_) ? -1978510517 : -769861487);
					continue;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					goto IL_7A;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1894230107;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -569615792 : -1960070258);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ RecentPlayersRemovedNotification.smethod_0(this.player_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.player_.WriteTo(output, RecentPlayersRemovedNotification._repeated_player_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.player_.CalculateSize(RecentPlayersRemovedNotification._repeated_player_codec);
		}

		public void MergeFrom(RecentPlayersRemovedNotification other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -1981457882;
			IL_08:
			switch ((arg_0D_0 ^ -414899836) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				IL_27:
				this.player_.Add(other.player_);
				arg_0D_0 = -499730125;
				goto IL_08;
			case 2:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) == 0u) ? 89162293u : 595678782u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 206768347u)) % 6u)
					{
					case 0u:
						arg_68_0 = 595678782u;
						continue;
					case 1u:
						arg_68_0 = ((num != 10u) ? 1623553462u : 963561662u);
						continue;
					case 2u:
						goto IL_9B;
					case 3u:
						input.SkipLastField();
						arg_68_0 = (num2 * 1940763454u ^ 107829789u);
						continue;
					case 5u:
						this.player_.AddEntriesFrom(input, RecentPlayersRemovedNotification._repeated_player_codec);
						arg_68_0 = 967036283u;
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
