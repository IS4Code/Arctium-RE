using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountServiceRegion : IMessage<AccountServiceRegion>, IEquatable<AccountServiceRegion>, IDeepCloneable<AccountServiceRegion>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountServiceRegion.__c __9 = new AccountServiceRegion.__c();

			internal AccountServiceRegion cctor>b__29_0()
			{
				return new AccountServiceRegion();
			}
		}

		private static readonly MessageParser<AccountServiceRegion> _parser = new MessageParser<AccountServiceRegion>(new Func<AccountServiceRegion>(AccountServiceRegion.__c.__9.<.cctor>b__29_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int ShardFieldNumber = 2;

		private string shard_ = "";

		public static MessageParser<AccountServiceRegion> Parser
		{
			get
			{
				return AccountServiceRegion._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountServiceRegion.Descriptor;
			}
		}

		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		public string Shard
		{
			get
			{
				return this.shard_;
			}
			set
			{
				this.shard_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public AccountServiceRegion()
		{
		}

		public AccountServiceRegion(AccountServiceRegion other) : this()
		{
			this.id_ = other.id_;
			this.shard_ = other.shard_;
		}

		public AccountServiceRegion Clone()
		{
			return new AccountServiceRegion(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountServiceRegion);
		}

		public bool Equals(AccountServiceRegion other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ -243784355) % 9)
				{
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					arg_72_0 = ((this.Id == other.Id) ? -474019286 : -1454842775);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_41;
				case 7:
					goto IL_B0;
				case 8:
					arg_72_0 = (AccountServiceRegion.smethod_0(this.Shard, other.Shard) ? -285594393 : -78928658);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = -1761915908;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? -920005855 : -591651993);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.Id.GetHashCode() ^ this.Shard.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(8);
			while (true)
			{
				IL_79:
				uint arg_59_0 = 1558647255u;
				while (true)
				{
					uint num;
					switch ((num = (arg_59_0 ^ 1901724315u)) % 5u)
					{
					case 0u:
						output.WriteString(this.Shard);
						arg_59_0 = (num * 3240259012u ^ 4000651009u);
						continue;
					case 2u:
						output.WriteRawTag(18);
						arg_59_0 = (num * 3962168832u ^ 2372137528u);
						continue;
					case 3u:
						goto IL_79;
					case 4u:
						output.WriteUInt32(this.Id);
						arg_59_0 = (num * 547823106u ^ 3543405076u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.Id)) + (1 + CodedOutputStream.ComputeStringSize(this.Shard));
		}

		public void MergeFrom(AccountServiceRegion other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 106138988u)) % 7u)
				{
				case 0u:
					goto IL_B2;
				case 1u:
					return;
				case 2u:
					this.Id = other.Id;
					arg_7B_0 = (num * 2047854339u ^ 2498826554u);
					continue;
				case 3u:
					arg_7B_0 = ((AccountServiceRegion.smethod_1(other.Shard) == 0) ? 524268752u : 1267221343u);
					continue;
				case 4u:
					this.Shard = other.Shard;
					arg_7B_0 = (num * 4205492649u ^ 3871624827u);
					continue;
				case 5u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_7B_0 = 304907078u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((other.Id != 0u) ? 1267497756u : 1177674346u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_103:
				uint num;
				uint arg_BF_0 = ((num = input.ReadTag()) == 0u) ? 2931390880u : 4096333378u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BF_0 ^ 3455439912u)) % 10u)
					{
					case 0u:
						arg_BF_0 = 4096333378u;
						continue;
					case 1u:
						arg_BF_0 = (((num != 18u) ? 418279692u : 955041696u) ^ num2 * 2088151111u);
						continue;
					case 2u:
						arg_BF_0 = ((num == 8u) ? 3143272109u : 3573490085u);
						continue;
					case 3u:
						this.Id = input.ReadUInt32();
						arg_BF_0 = 4205719437u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_BF_0 = (num2 * 4042029960u ^ 2971808628u);
						continue;
					case 6u:
						goto IL_103;
					case 7u:
						arg_BF_0 = (num2 * 2590078781u ^ 949263805u);
						continue;
					case 8u:
						arg_BF_0 = (num2 * 3133103258u ^ 472906564u);
						continue;
					case 9u:
						this.Shard = input.ReadString();
						arg_BF_0 = 3070047468u;
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}
	}
}
