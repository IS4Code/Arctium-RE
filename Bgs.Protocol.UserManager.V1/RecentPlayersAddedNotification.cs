using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class RecentPlayersAddedNotification : IMessage<RecentPlayersAddedNotification>, IEquatable<RecentPlayersAddedNotification>, IDeepCloneable<RecentPlayersAddedNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RecentPlayersAddedNotification.__c __9 = new RecentPlayersAddedNotification.__c();

			internal RecentPlayersAddedNotification cctor>b__24_0()
			{
				return new RecentPlayersAddedNotification();
			}
		}

		private static readonly MessageParser<RecentPlayersAddedNotification> _parser = new MessageParser<RecentPlayersAddedNotification>(new Func<RecentPlayersAddedNotification>(RecentPlayersAddedNotification.__c.__9.<.cctor>b__24_0));

		public const int PlayerFieldNumber = 1;

		private static readonly FieldCodec<RecentPlayer> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayer>(10u, RecentPlayer.Parser);

		private readonly RepeatedField<RecentPlayer> player_ = new RepeatedField<RecentPlayer>();

		public static MessageParser<RecentPlayersAddedNotification> Parser
		{
			get
			{
				return RecentPlayersAddedNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersAddedNotification.Descriptor;
			}
		}

		public RepeatedField<RecentPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		public RecentPlayersAddedNotification()
		{
		}

		public RecentPlayersAddedNotification(RecentPlayersAddedNotification other) : this()
		{
			this.player_ = other.player_.Clone();
		}

		public RecentPlayersAddedNotification Clone()
		{
			return new RecentPlayersAddedNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersAddedNotification);
		}

		public bool Equals(RecentPlayersAddedNotification other)
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
				switch ((arg_48_0 ^ -1605967114) % 7)
				{
				case 0:
					goto IL_3E;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					arg_48_0 = ((!this.player_.Equals(other.player_)) ? -985721530 : -471346330);
					continue;
				case 6:
					goto IL_7A;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1525949913;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1093206450 : -120745607);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ RecentPlayersAddedNotification.smethod_0(this.player_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.player_.WriteTo(output, RecentPlayersAddedNotification._repeated_player_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.player_.CalculateSize(RecentPlayersAddedNotification._repeated_player_codec);
		}

		public void MergeFrom(RecentPlayersAddedNotification other)
		{
			if (other == null)
			{
				return;
			}
			this.player_.Add(other.player_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 3828637563u : 3986840069u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 3849154016u)) % 7u)
					{
					case 0u:
						arg_77_0 = 3828637563u;
						continue;
					case 1u:
						this.player_.AddEntriesFrom(input, RecentPlayersAddedNotification._repeated_player_codec);
						arg_77_0 = 3341303209u;
						continue;
					case 2u:
						arg_77_0 = ((num == 10u) ? 2485538122u : 3987021826u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_77_0 = (num2 * 3722752524u ^ 3484474264u);
						continue;
					case 5u:
						goto IL_AE;
					case 6u:
						arg_77_0 = (num2 * 2232310474u ^ 3984029033u);
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
