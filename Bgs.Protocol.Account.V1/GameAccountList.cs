using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountList : IMessage<GameAccountList>, IEquatable<GameAccountList>, IDeepCloneable<GameAccountList>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountList.__c __9 = new GameAccountList.__c();

			internal GameAccountList cctor>b__29_0()
			{
				return new GameAccountList();
			}
		}

		private static readonly MessageParser<GameAccountList> _parser = new MessageParser<GameAccountList>(new Func<GameAccountList>(GameAccountList.__c.__9.<.cctor>b__29_0));

		public const int RegionFieldNumber = 3;

		private uint region_;

		public const int HandleFieldNumber = 4;

		private static readonly FieldCodec<GameAccountHandle> _repeated_handle_codec = FieldCodec.ForMessage<GameAccountHandle>(34u, GameAccountHandle.Parser);

		private readonly RepeatedField<GameAccountHandle> handle_ = new RepeatedField<GameAccountHandle>();

		public static MessageParser<GameAccountList> Parser
		{
			get
			{
				return GameAccountList._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[30];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountList.Descriptor;
			}
		}

		public uint Region
		{
			get
			{
				return this.region_;
			}
			set
			{
				this.region_ = value;
			}
		}

		public RepeatedField<GameAccountHandle> Handle
		{
			get
			{
				return this.handle_;
			}
		}

		public GameAccountList()
		{
		}

		public GameAccountList(GameAccountList other) : this()
		{
			this.region_ = other.region_;
			this.handle_ = other.handle_.Clone();
		}

		public GameAccountList Clone()
		{
			return new GameAccountList(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountList);
		}

		public bool Equals(GameAccountList other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ -522220772) % 9)
				{
				case 1:
					return true;
				case 2:
					arg_72_0 = (this.handle_.Equals(other.handle_) ? -129434358 : -1981631962);
					continue;
				case 3:
					arg_72_0 = ((this.Region != other.Region) ? -59806053 : -1499219566);
					continue;
				case 4:
					return false;
				case 5:
					goto IL_B0;
				case 6:
					goto IL_15;
				case 7:
					return false;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = -254910296;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? -1491032248 : -2145001292);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Region != 0u)
			{
				while (true)
				{
					IL_47:
					uint arg_2F_0 = 2190453388u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2F_0 ^ 2256295204u)) % 3u)
						{
						case 0u:
							goto IL_47;
						case 1u:
							num ^= this.Region.GetHashCode();
							arg_2F_0 = (num2 * 3802467911u ^ 620032336u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num ^ this.handle_.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Region != 0u)
			{
				goto IL_2D;
			}
			goto IL_53;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 4059160018u)) % 4u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					goto IL_53;
				case 2u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.Region);
					arg_37_0 = (num * 739412060u ^ 855865399u);
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 2404234064u;
			goto IL_32;
			IL_53:
			this.handle_.WriteTo(output, GameAccountList._repeated_handle_codec);
			arg_37_0 = 3341864853u;
			goto IL_32;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_8C:
				uint arg_6C_0 = 2198202643u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6C_0 ^ 3555375618u)) % 5u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
						arg_6C_0 = (num2 * 547832345u ^ 3807745854u);
						continue;
					case 2u:
						num += this.handle_.CalculateSize(GameAccountList._repeated_handle_codec);
						arg_6C_0 = 3480659261u;
						continue;
					case 4u:
						arg_6C_0 = (((this.Region == 0u) ? 1052384729u : 1120422605u) ^ num2 * 3000415128u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountList other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 2954756466u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					goto IL_63;
				case 2u:
					this.Region = other.Region;
					arg_37_0 = (num * 3150064969u ^ 430821387u);
					continue;
				case 4u:
					return;
				}
				break;
			}
			this.handle_.Add(other.handle_);
			return;
			IL_2D:
			arg_37_0 = 2531668989u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Region != 0u) ? 3794845878u : 2957075695u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_E2:
				uint num;
				uint arg_A7_0 = ((num = input.ReadTag()) == 0u) ? 2774671074u : 3629401495u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A7_0 ^ 2836771334u)) % 8u)
					{
					case 0u:
						this.handle_.AddEntriesFrom(input, GameAccountList._repeated_handle_codec);
						arg_A7_0 = 3914515093u;
						continue;
					case 1u:
						arg_A7_0 = ((num != 24u) ? 3989558872u : 3295525467u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_A7_0 = (num2 * 1924731349u ^ 4038939879u);
						continue;
					case 3u:
						goto IL_E2;
					case 5u:
						this.Region = input.ReadUInt32();
						arg_A7_0 = 3914515093u;
						continue;
					case 6u:
						arg_A7_0 = (((num != 34u) ? 1197756382u : 951955388u) ^ num2 * 1260106519u);
						continue;
					case 7u:
						arg_A7_0 = 3629401495u;
						continue;
					}
					return;
				}
			}
		}
	}
}
