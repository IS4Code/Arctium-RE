using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class BlockedPlayer : IMessage<BlockedPlayer>, IEquatable<BlockedPlayer>, IDeepCloneable<BlockedPlayer>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BlockedPlayer.__c __9 = new BlockedPlayer.__c();

			internal BlockedPlayer cctor>b__39_0()
			{
				return new BlockedPlayer();
			}
		}

		private static readonly MessageParser<BlockedPlayer> _parser = new MessageParser<BlockedPlayer>(new Func<BlockedPlayer>(BlockedPlayer.__c.__9.<.cctor>b__39_0));

		public const int AccountIdFieldNumber = 1;

		private EntityId accountId_;

		public const int NameFieldNumber = 2;

		private string name_ = "";

		public const int RoleFieldNumber = 3;

		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(26u);

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public const int PrivilegesFieldNumber = 4;

		private ulong privileges_;

		public static MessageParser<BlockedPlayer> Parser
		{
			get
			{
				return BlockedPlayer._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayer.Descriptor;
			}
		}

		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		public ulong Privileges
		{
			get
			{
				return this.privileges_;
			}
			set
			{
				this.privileges_ = value;
			}
		}

		public BlockedPlayer()
		{
		}

		public BlockedPlayer(BlockedPlayer other) : this()
		{
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
			this.name_ = other.name_;
			this.role_ = other.role_.Clone();
			this.privileges_ = other.privileges_;
		}

		public BlockedPlayer Clone()
		{
			return new BlockedPlayer(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayer);
		}

		public bool Equals(BlockedPlayer other)
		{
			if (other == null)
			{
				goto IL_42;
			}
			goto IL_121;
			int arg_D3_0;
			while (true)
			{
				IL_CE:
				switch ((arg_D3_0 ^ -1078661309) % 13)
				{
				case 0:
					return false;
				case 1:
					goto IL_121;
				case 2:
					return false;
				case 4:
					return false;
				case 5:
					arg_D3_0 = ((!this.role_.Equals(other.role_)) ? -1481469245 : -753737616);
					continue;
				case 6:
					arg_D3_0 = ((!BlockedPlayer.smethod_0(this.AccountId, other.AccountId)) ? -1902098511 : -776355673);
					continue;
				case 7:
					arg_D3_0 = ((!BlockedPlayer.smethod_1(this.Name, other.Name)) ? -1991359489 : -1525429261);
					continue;
				case 8:
					return false;
				case 9:
					goto IL_42;
				case 10:
					return false;
				case 11:
					return true;
				case 12:
					arg_D3_0 = ((this.Privileges == other.Privileges) ? -1853478510 : -1652919627);
					continue;
				}
				break;
			}
			return true;
			IL_42:
			arg_D3_0 = -1958768719;
			goto IL_CE;
			IL_121:
			arg_D3_0 = ((other != this) ? -1012304817 : -423079104);
			goto IL_CE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_128:
				uint arg_F7_0 = 3319762844u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F7_0 ^ 2426251676u)) % 9u)
					{
					case 0u:
						num ^= this.Privileges.GetHashCode();
						arg_F7_0 = (num2 * 2864286044u ^ 3290563877u);
						continue;
					case 1u:
						num ^= BlockedPlayer.smethod_2(this.role_);
						arg_F7_0 = 4203931261u;
						continue;
					case 2u:
						arg_F7_0 = ((BlockedPlayer.smethod_3(this.Name) != 0) ? 3318404011u : 3199914680u);
						continue;
					case 4u:
						num ^= BlockedPlayer.smethod_2(this.Name);
						arg_F7_0 = (num2 * 1248675842u ^ 2328084182u);
						continue;
					case 5u:
						arg_F7_0 = (((this.Privileges == 0uL) ? 1261548989u : 350226813u) ^ num2 * 35458580u);
						continue;
					case 6u:
						arg_F7_0 = (((this.accountId_ != null) ? 2929698373u : 3011058366u) ^ num2 * 3394385180u);
						continue;
					case 7u:
						num ^= BlockedPlayer.smethod_2(this.AccountId);
						arg_F7_0 = (num2 * 4037650652u ^ 323654850u);
						continue;
					case 8u:
						goto IL_128;
					}
					return num;
				}
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountId_ != null)
			{
				goto IL_8A;
			}
			goto IL_13C;
			uint arg_F8_0;
			while (true)
			{
				IL_F3:
				uint num;
				switch ((num = (arg_F8_0 ^ 2302662536u)) % 10u)
				{
				case 1u:
					output.WriteRawTag(10);
					arg_F8_0 = (num * 1355044995u ^ 1019533478u);
					continue;
				case 2u:
					this.role_.WriteTo(output, BlockedPlayer._repeated_role_codec);
					arg_F8_0 = ((this.Privileges == 0uL) ? 3264258472u : 3705879998u);
					continue;
				case 3u:
					output.WriteUInt64(this.Privileges);
					arg_F8_0 = (num * 607017837u ^ 3001692191u);
					continue;
				case 4u:
					goto IL_8A;
				case 5u:
					output.WriteMessage(this.AccountId);
					arg_F8_0 = (num * 2969667800u ^ 898114965u);
					continue;
				case 6u:
					output.WriteString(this.Name);
					arg_F8_0 = (num * 997679811u ^ 1400150140u);
					continue;
				case 7u:
					goto IL_13C;
				case 8u:
					output.WriteRawTag(32);
					arg_F8_0 = (num * 1617536824u ^ 2670085483u);
					continue;
				case 9u:
					output.WriteRawTag(18);
					arg_F8_0 = (num * 574638090u ^ 2769511200u);
					continue;
				}
				break;
			}
			return;
			IL_8A:
			arg_F8_0 = 2262117019u;
			goto IL_F3;
			IL_13C:
			arg_F8_0 = ((BlockedPlayer.smethod_3(this.Name) != 0) ? 3686600121u : 2842540346u);
			goto IL_F3;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_133:
				uint arg_102_0 = 3495099032u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_102_0 ^ 2519829747u)) % 9u)
					{
					case 0u:
						arg_102_0 = (((this.Privileges != 0uL) ? 1073431962u : 1219905381u) ^ num2 * 334755298u);
						continue;
					case 1u:
						arg_102_0 = (((this.accountId_ != null) ? 2868053833u : 2780194460u) ^ num2 * 2278733959u);
						continue;
					case 3u:
						goto IL_133;
					case 4u:
						arg_102_0 = ((BlockedPlayer.smethod_3(this.Name) == 0) ? 2682869793u : 2634170580u);
						continue;
					case 5u:
						num += this.role_.CalculateSize(BlockedPlayer._repeated_role_codec);
						arg_102_0 = 2891170539u;
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_102_0 = (num2 * 17532728u ^ 2140370169u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
						arg_102_0 = (num2 * 3224729489u ^ 4278460220u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_102_0 = (num2 * 2466941925u ^ 475894722u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(BlockedPlayer other)
		{
			if (other == null)
			{
				goto IL_C9;
			}
			goto IL_15C;
			uint arg_114_0;
			while (true)
			{
				IL_10F:
				uint num;
				switch ((num = (arg_114_0 ^ 3633073387u)) % 11u)
				{
				case 1u:
					this.Name = other.Name;
					arg_114_0 = (num * 2686799198u ^ 3645525674u);
					continue;
				case 2u:
					arg_114_0 = ((BlockedPlayer.smethod_3(other.Name) == 0) ? 3431186452u : 3528022714u);
					continue;
				case 3u:
					goto IL_15C;
				case 4u:
					goto IL_C9;
				case 5u:
					this.accountId_ = new EntityId();
					arg_114_0 = (num * 3495464189u ^ 4102720120u);
					continue;
				case 6u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_114_0 = 2568481129u;
					continue;
				case 7u:
					this.Privileges = other.Privileges;
					arg_114_0 = (num * 537714060u ^ 1058620960u);
					continue;
				case 8u:
					this.role_.Add(other.role_);
					arg_114_0 = ((other.Privileges != 0uL) ? 4084748703u : 2537847120u);
					continue;
				case 9u:
					return;
				case 10u:
					arg_114_0 = (((this.accountId_ == null) ? 1360126517u : 448991246u) ^ num * 2910243082u);
					continue;
				}
				break;
			}
			return;
			IL_C9:
			arg_114_0 = 2297694365u;
			goto IL_10F;
			IL_15C:
			arg_114_0 = ((other.accountId_ == null) ? 2568481129u : 3124463263u);
			goto IL_10F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_259:
				uint num;
				uint arg_1ED_0 = ((num = input.ReadTag()) != 0u) ? 3724992296u : 3669460808u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1ED_0 ^ 4126607913u)) % 20u)
					{
					case 0u:
						arg_1ED_0 = (num2 * 1415317846u ^ 49771698u);
						continue;
					case 1u:
						arg_1ED_0 = (num2 * 1333339048u ^ 1338437474u);
						continue;
					case 2u:
						arg_1ED_0 = (((num == 10u) ? 2772845016u : 3492789934u) ^ num2 * 3468762756u);
						continue;
					case 3u:
						this.Name = input.ReadString();
						arg_1ED_0 = 3693980938u;
						continue;
					case 4u:
						arg_1ED_0 = ((num == 24u) ? 2909859459u : 3519812658u);
						continue;
					case 5u:
						input.ReadMessage(this.accountId_);
						arg_1ED_0 = 2257105830u;
						continue;
					case 6u:
						this.role_.AddEntriesFrom(input, BlockedPlayer._repeated_role_codec);
						arg_1ED_0 = 2204226384u;
						continue;
					case 7u:
						arg_1ED_0 = (((num == 26u) ? 1865512977u : 1855948309u) ^ num2 * 3539600598u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_1ED_0 = 2315461821u;
						continue;
					case 10u:
						arg_1ED_0 = (((num != 32u) ? 3504513667u : 2388138679u) ^ num2 * 3670020557u);
						continue;
					case 11u:
						goto IL_259;
					case 12u:
						arg_1ED_0 = (num2 * 627121355u ^ 1985131637u);
						continue;
					case 13u:
						arg_1ED_0 = ((num <= 18u) ? 3906587783u : 3116866901u);
						continue;
					case 14u:
						arg_1ED_0 = 3724992296u;
						continue;
					case 15u:
						arg_1ED_0 = (num2 * 3474604631u ^ 2078883987u);
						continue;
					case 16u:
						this.Privileges = input.ReadUInt64();
						arg_1ED_0 = 3693980938u;
						continue;
					case 17u:
						arg_1ED_0 = ((this.accountId_ != null) ? 3417821488u : 2221401571u);
						continue;
					case 18u:
						this.accountId_ = new EntityId();
						arg_1ED_0 = (num2 * 3701692838u ^ 2269210572u);
						continue;
					case 19u:
						arg_1ED_0 = (((num == 18u) ? 3219019011u : 2284052784u) ^ num2 * 2142734535u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
