using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class AddRecentPlayersResponse : IMessage<AddRecentPlayersResponse>, IEquatable<AddRecentPlayersResponse>, IDeepCloneable<AddRecentPlayersResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AddRecentPlayersResponse.__c __9 = new AddRecentPlayersResponse.__c();

			internal AddRecentPlayersResponse cctor>b__29_0()
			{
				return new AddRecentPlayersResponse();
			}
		}

		private static readonly MessageParser<AddRecentPlayersResponse> _parser = new MessageParser<AddRecentPlayersResponse>(new Func<AddRecentPlayersResponse>(AddRecentPlayersResponse.__c.__9.<.cctor>b__29_0));

		public const int PlayersAddedFieldNumber = 1;

		private static readonly FieldCodec<RecentPlayer> _repeated_playersAdded_codec = FieldCodec.ForMessage<RecentPlayer>(10u, RecentPlayer.Parser);

		private readonly RepeatedField<RecentPlayer> playersAdded_ = new RepeatedField<RecentPlayer>();

		public const int PlayersRemovedFieldNumber = 3;

		private static readonly FieldCodec<uint> _repeated_playersRemoved_codec;

		private readonly RepeatedField<uint> playersRemoved_ = new RepeatedField<uint>();

		public static MessageParser<AddRecentPlayersResponse> Parser
		{
			get
			{
				return AddRecentPlayersResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRecentPlayersResponse.Descriptor;
			}
		}

		public RepeatedField<RecentPlayer> PlayersAdded
		{
			get
			{
				return this.playersAdded_;
			}
		}

		public RepeatedField<uint> PlayersRemoved
		{
			get
			{
				return this.playersRemoved_;
			}
		}

		public AddRecentPlayersResponse()
		{
		}

		public AddRecentPlayersResponse(AddRecentPlayersResponse other) : this()
		{
			this.playersAdded_ = other.playersAdded_.Clone();
			this.playersRemoved_ = other.playersRemoved_.Clone();
		}

		public AddRecentPlayersResponse Clone()
		{
			return new AddRecentPlayersResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AddRecentPlayersResponse);
		}

		public bool Equals(AddRecentPlayersResponse other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 176477216) % 9)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					goto IL_B5;
				case 4:
					goto IL_6D;
				case 5:
					arg_77_0 = ((!this.playersRemoved_.Equals(other.playersRemoved_)) ? 283808551 : 727294093);
					continue;
				case 6:
					return true;
				case 7:
					return false;
				case 8:
					arg_77_0 = ((!this.playersAdded_.Equals(other.playersAdded_)) ? 352458039 : 1812936545);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 813506732;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 2111360791 : 652091163);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ AddRecentPlayersResponse.smethod_0(this.playersAdded_) ^ AddRecentPlayersResponse.smethod_0(this.playersRemoved_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.playersAdded_.WriteTo(output, AddRecentPlayersResponse._repeated_playersAdded_codec);
			this.playersRemoved_.WriteTo(output, AddRecentPlayersResponse._repeated_playersRemoved_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.playersAdded_.CalculateSize(AddRecentPlayersResponse._repeated_playersAdded_codec) + this.playersRemoved_.CalculateSize(AddRecentPlayersResponse._repeated_playersRemoved_codec);
		}

		public void MergeFrom(AddRecentPlayersResponse other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -295458344;
			IL_08:
			switch ((arg_0D_0 ^ -1509438206) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				IL_27:
				this.playersAdded_.Add(other.playersAdded_);
				arg_0D_0 = -1321928895;
				goto IL_08;
			case 2:
				return;
			}
			this.playersRemoved_.Add(other.playersRemoved_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13E:
				uint num;
				uint arg_F6_0 = ((num = input.ReadTag()) == 0u) ? 2665144016u : 3521722399u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F6_0 ^ 3035604224u)) % 11u)
					{
					case 0u:
						goto IL_13E;
					case 1u:
						arg_F6_0 = (num2 * 778324689u ^ 460498844u);
						continue;
					case 2u:
						this.playersRemoved_.AddEntriesFrom(input, AddRecentPlayersResponse._repeated_playersRemoved_codec);
						arg_F6_0 = 3759339120u;
						continue;
					case 3u:
						arg_F6_0 = (((num == 29u) ? 857220344u : 2018685946u) ^ num2 * 862001913u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_F6_0 = (num2 * 3504640420u ^ 425083717u);
						continue;
					case 5u:
						arg_F6_0 = ((num != 10u) ? 3787717911u : 4168165639u);
						continue;
					case 6u:
						arg_F6_0 = (num2 * 4280721839u ^ 2686153459u);
						continue;
					case 7u:
						this.playersAdded_.AddEntriesFrom(input, AddRecentPlayersResponse._repeated_playersAdded_codec);
						arg_F6_0 = 3595711276u;
						continue;
					case 8u:
						arg_F6_0 = (((num == 26u) ? 947460114u : 1364883434u) ^ num2 * 3668151782u);
						continue;
					case 9u:
						arg_F6_0 = 3521722399u;
						continue;
					}
					return;
				}
			}
		}

		static AddRecentPlayersResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_63:
				uint arg_4B_0 = 2372128739u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4B_0 ^ 2265327875u)) % 3u)
					{
					case 0u:
						goto IL_63;
					case 1u:
						AddRecentPlayersResponse._repeated_playersRemoved_codec = FieldCodec.ForFixed32(26u);
						arg_4B_0 = (num * 4098535366u ^ 1304468820u);
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
