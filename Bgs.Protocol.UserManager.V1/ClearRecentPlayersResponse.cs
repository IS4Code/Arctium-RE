using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class ClearRecentPlayersResponse : IMessage<ClearRecentPlayersResponse>, IEquatable<ClearRecentPlayersResponse>, IDeepCloneable<ClearRecentPlayersResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ClearRecentPlayersResponse.__c __9 = new ClearRecentPlayersResponse.__c();

			internal ClearRecentPlayersResponse cctor>b__24_0()
			{
				return new ClearRecentPlayersResponse();
			}
		}

		private static readonly MessageParser<ClearRecentPlayersResponse> _parser = new MessageParser<ClearRecentPlayersResponse>(new Func<ClearRecentPlayersResponse>(ClearRecentPlayersResponse.__c.__9.<.cctor>b__24_0));

		public const int PlayersRemovedFieldNumber = 1;

		private static readonly FieldCodec<uint> _repeated_playersRemoved_codec = FieldCodec.ForFixed32(10u);

		private readonly RepeatedField<uint> playersRemoved_ = new RepeatedField<uint>();

		public static MessageParser<ClearRecentPlayersResponse> Parser
		{
			get
			{
				return ClearRecentPlayersResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearRecentPlayersResponse.Descriptor;
			}
		}

		public RepeatedField<uint> PlayersRemoved
		{
			get
			{
				return this.playersRemoved_;
			}
		}

		public ClearRecentPlayersResponse()
		{
		}

		public ClearRecentPlayersResponse(ClearRecentPlayersResponse other) : this()
		{
			this.playersRemoved_ = other.playersRemoved_.Clone();
		}

		public ClearRecentPlayersResponse Clone()
		{
			return new ClearRecentPlayersResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ClearRecentPlayersResponse);
		}

		public bool Equals(ClearRecentPlayersResponse other)
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
				switch ((arg_48_0 ^ -1655083623) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					return true;
				case 2:
					goto IL_3E;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_48_0 = (this.playersRemoved_.Equals(other.playersRemoved_) ? -89490350 : -1267983531);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1601938418;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -1092524674 : -2000694162);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ClearRecentPlayersResponse.smethod_0(this.playersRemoved_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.playersRemoved_.WriteTo(output, ClearRecentPlayersResponse._repeated_playersRemoved_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.playersRemoved_.CalculateSize(ClearRecentPlayersResponse._repeated_playersRemoved_codec);
		}

		public void MergeFrom(ClearRecentPlayersResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.playersRemoved_.Add(other.playersRemoved_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DB:
				uint num;
				uint arg_A0_0 = ((num = input.ReadTag()) == 0u) ? 970551748u : 1842560647u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A0_0 ^ 2025713626u)) % 8u)
					{
					case 0u:
						input.SkipLastField();
						arg_A0_0 = (num2 * 1999685195u ^ 946908771u);
						continue;
					case 1u:
						arg_A0_0 = (num2 * 3579601320u ^ 688075493u);
						continue;
					case 2u:
						arg_A0_0 = (((num != 13u) ? 28896124u : 615864208u) ^ num2 * 2458255419u);
						continue;
					case 3u:
						arg_A0_0 = 1842560647u;
						continue;
					case 4u:
						this.playersRemoved_.AddEntriesFrom(input, ClearRecentPlayersResponse._repeated_playersRemoved_codec);
						arg_A0_0 = 1793716493u;
						continue;
					case 5u:
						arg_A0_0 = ((num != 10u) ? 184739128u : 1743181190u);
						continue;
					case 7u:
						goto IL_DB;
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
