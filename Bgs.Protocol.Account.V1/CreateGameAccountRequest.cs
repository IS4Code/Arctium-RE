using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class CreateGameAccountRequest : IMessage<CreateGameAccountRequest>, IEquatable<CreateGameAccountRequest>, IDeepCloneable<CreateGameAccountRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CreateGameAccountRequest.__c __9 = new CreateGameAccountRequest.__c();

			internal CreateGameAccountRequest cctor>b__39_0()
			{
				return new CreateGameAccountRequest();
			}
		}

		private static readonly MessageParser<CreateGameAccountRequest> _parser = new MessageParser<CreateGameAccountRequest>(new Func<CreateGameAccountRequest>(CreateGameAccountRequest.__c.__9.<.cctor>b__39_0));

		public const int AccountFieldNumber = 1;

		private AccountId account_;

		public const int RegionFieldNumber = 2;

		private uint region_;

		public const int ProgramFieldNumber = 3;

		private uint program_;

		public const int RealmPermissionsFieldNumber = 4;

		private uint realmPermissions_;

		public static MessageParser<CreateGameAccountRequest> Parser
		{
			get
			{
				return CreateGameAccountRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateGameAccountRequest.Descriptor;
			}
		}

		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
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

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public uint RealmPermissions
		{
			get
			{
				return this.realmPermissions_;
			}
			set
			{
				this.realmPermissions_ = value;
			}
		}

		public CreateGameAccountRequest()
		{
		}

		public CreateGameAccountRequest(CreateGameAccountRequest other) : this()
		{
			this.Account = ((other.account_ != null) ? other.Account.Clone() : null);
			this.region_ = other.region_;
			this.program_ = other.program_;
			this.realmPermissions_ = other.realmPermissions_;
		}

		public CreateGameAccountRequest Clone()
		{
			return new CreateGameAccountRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as CreateGameAccountRequest);
		}

		public bool Equals(CreateGameAccountRequest other)
		{
			if (other == null)
			{
				goto IL_95;
			}
			goto IL_114;
			int arg_C6_0;
			while (true)
			{
				IL_C1:
				switch ((arg_C6_0 ^ -249003560) % 13)
				{
				case 1:
					return false;
				case 2:
					arg_C6_0 = ((this.RealmPermissions == other.RealmPermissions) ? -1568411290 : -766468944);
					continue;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_95;
				case 8:
					return false;
				case 9:
					goto IL_114;
				case 10:
					arg_C6_0 = ((this.Program != other.Program) ? -140775456 : -148313624);
					continue;
				case 11:
					arg_C6_0 = ((this.Region == other.Region) ? -365824200 : -1993322555);
					continue;
				case 12:
					arg_C6_0 = (CreateGameAccountRequest.smethod_0(this.Account, other.Account) ? -31535094 : -1766770922);
					continue;
				}
				break;
			}
			return true;
			IL_95:
			arg_C6_0 = -749154874;
			goto IL_C1;
			IL_114:
			arg_C6_0 = ((other == this) ? -1802759528 : -1583395068);
			goto IL_C1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.account_ != null)
			{
				goto IL_42;
			}
			goto IL_12E;
			uint arg_EE_0;
			while (true)
			{
				IL_E9:
				uint num2;
				switch ((num2 = (arg_EE_0 ^ 2785630348u)) % 9u)
				{
				case 1u:
					num ^= this.RealmPermissions.GetHashCode();
					arg_EE_0 = (num2 * 850646462u ^ 512667317u);
					continue;
				case 2u:
					num ^= this.Program.GetHashCode();
					arg_EE_0 = (num2 * 3765859058u ^ 4158812337u);
					continue;
				case 3u:
					num ^= CreateGameAccountRequest.smethod_1(this.Account);
					arg_EE_0 = (num2 * 438115614u ^ 1675864493u);
					continue;
				case 4u:
					arg_EE_0 = ((this.RealmPermissions == 0u) ? 2338612997u : 3061241508u);
					continue;
				case 5u:
					arg_EE_0 = ((this.Program != 0u) ? 3463778334u : 2801528501u);
					continue;
				case 6u:
					goto IL_42;
				case 7u:
					num ^= this.Region.GetHashCode();
					arg_EE_0 = (num2 * 4284914041u ^ 1084826133u);
					continue;
				case 8u:
					goto IL_12E;
				}
				break;
			}
			return num;
			IL_42:
			arg_EE_0 = 2381333668u;
			goto IL_E9;
			IL_12E:
			arg_EE_0 = ((this.Region == 0u) ? 3940457649u : 2514744904u);
			goto IL_E9;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.account_ != null)
			{
				goto IL_37;
			}
			goto IL_167;
			uint arg_11F_0;
			while (true)
			{
				IL_11A:
				uint num;
				switch ((num = (arg_11F_0 ^ 230160784u)) % 11u)
				{
				case 0u:
					arg_11F_0 = ((this.Program != 0u) ? 1163152432u : 242972u);
					continue;
				case 1u:
					output.WriteRawTag(16);
					output.WriteUInt32(this.Region);
					arg_11F_0 = (num * 3337491222u ^ 2540617464u);
					continue;
				case 2u:
					output.WriteUInt32(this.RealmPermissions);
					arg_11F_0 = (num * 2657175359u ^ 2968884665u);
					continue;
				case 3u:
					output.WriteFixed32(this.Program);
					arg_11F_0 = (num * 2522697288u ^ 4042007004u);
					continue;
				case 4u:
					output.WriteRawTag(29);
					arg_11F_0 = (num * 2154135761u ^ 1732843496u);
					continue;
				case 6u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Account);
					arg_11F_0 = (num * 3869133661u ^ 2698044547u);
					continue;
				case 7u:
					arg_11F_0 = ((this.RealmPermissions != 0u) ? 1456359060u : 525952534u);
					continue;
				case 8u:
					goto IL_37;
				case 9u:
					output.WriteRawTag(32);
					arg_11F_0 = (num * 60057907u ^ 3847843789u);
					continue;
				case 10u:
					goto IL_167;
				}
				break;
			}
			return;
			IL_37:
			arg_11F_0 = 1450557807u;
			goto IL_11A;
			IL_167:
			arg_11F_0 = ((this.Region == 0u) ? 1064297410u : 1495557351u);
			goto IL_11A;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_144:
				uint arg_10F_0 = 174722744u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10F_0 ^ 1550332559u)) % 10u)
					{
					case 0u:
						arg_10F_0 = ((this.Program != 0u) ? 640514914u : 863936304u);
						continue;
					case 1u:
						num += 5;
						arg_10F_0 = (num2 * 2072150188u ^ 127972364u);
						continue;
					case 2u:
						arg_10F_0 = ((this.Region != 0u) ? 56065612u : 1174086001u);
						continue;
					case 3u:
						arg_10F_0 = (((this.account_ == null) ? 3395145120u : 2291644804u) ^ num2 * 4040714363u);
						continue;
					case 5u:
						goto IL_144;
					case 6u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RealmPermissions);
						arg_10F_0 = (num2 * 2587798427u ^ 701951889u);
						continue;
					case 7u:
						arg_10F_0 = ((this.RealmPermissions != 0u) ? 1188017173u : 1853207215u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
						arg_10F_0 = (num2 * 2315640678u ^ 3294837609u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
						arg_10F_0 = (num2 * 302074506u ^ 3806961263u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(CreateGameAccountRequest other)
		{
			if (other == null)
			{
				goto IL_E9;
			}
			goto IL_190;
			uint arg_140_0;
			while (true)
			{
				IL_13B:
				uint num;
				switch ((num = (arg_140_0 ^ 3797545227u)) % 13u)
				{
				case 1u:
					this.Region = other.Region;
					arg_140_0 = (num * 3828092652u ^ 788776153u);
					continue;
				case 2u:
					this.Account.MergeFrom(other.Account);
					arg_140_0 = 2324000607u;
					continue;
				case 3u:
					this.account_ = new AccountId();
					arg_140_0 = (num * 2448363307u ^ 2070372689u);
					continue;
				case 4u:
					goto IL_E9;
				case 5u:
					return;
				case 6u:
					this.Program = other.Program;
					arg_140_0 = (num * 1431110072u ^ 1479859669u);
					continue;
				case 7u:
					goto IL_190;
				case 8u:
					arg_140_0 = ((other.Region == 0u) ? 2915268697u : 3895245419u);
					continue;
				case 9u:
					arg_140_0 = ((other.RealmPermissions == 0u) ? 2975520723u : 2413421588u);
					continue;
				case 10u:
					arg_140_0 = ((other.Program == 0u) ? 3025937005u : 3408588618u);
					continue;
				case 11u:
					this.RealmPermissions = other.RealmPermissions;
					arg_140_0 = (num * 2165102662u ^ 772880809u);
					continue;
				case 12u:
					arg_140_0 = (((this.account_ != null) ? 1225328886u : 2092713020u) ^ num * 1372510715u);
					continue;
				}
				break;
			}
			return;
			IL_E9:
			arg_140_0 = 2230915422u;
			goto IL_13B;
			IL_190:
			arg_140_0 = ((other.account_ != null) ? 2282324118u : 2324000607u);
			goto IL_13B;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1FB:
				uint num;
				uint arg_19B_0 = ((num = input.ReadTag()) != 0u) ? 940774683u : 908233869u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_19B_0 ^ 1997672707u)) % 17u)
					{
					case 0u:
						this.RealmPermissions = input.ReadUInt32();
						arg_19B_0 = 1590267460u;
						continue;
					case 1u:
						arg_19B_0 = ((this.account_ == null) ? 280322639u : 1348662829u);
						continue;
					case 2u:
						this.account_ = new AccountId();
						arg_19B_0 = (num2 * 608468580u ^ 1748666269u);
						continue;
					case 3u:
						input.ReadMessage(this.account_);
						arg_19B_0 = 1590267460u;
						continue;
					case 5u:
						arg_19B_0 = (num2 * 1724913591u ^ 2155323161u);
						continue;
					case 6u:
						arg_19B_0 = ((num > 16u) ? 915436999u : 1607642366u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_19B_0 = 1590267460u;
						continue;
					case 8u:
						this.Region = input.ReadUInt32();
						arg_19B_0 = 76185591u;
						continue;
					case 9u:
						arg_19B_0 = (num2 * 2583620490u ^ 1993622988u);
						continue;
					case 10u:
						arg_19B_0 = (((num == 32u) ? 2336876992u : 4170418802u) ^ num2 * 2412141474u);
						continue;
					case 11u:
						arg_19B_0 = (((num == 10u) ? 1853795121u : 1709766382u) ^ num2 * 3737835416u);
						continue;
					case 12u:
						arg_19B_0 = (((num == 16u) ? 3497549752u : 2548432803u) ^ num2 * 375218965u);
						continue;
					case 13u:
						arg_19B_0 = 940774683u;
						continue;
					case 14u:
						goto IL_1FB;
					case 15u:
						arg_19B_0 = ((num != 29u) ? 1602301337u : 1016270375u);
						continue;
					case 16u:
						this.Program = input.ReadFixed32();
						arg_19B_0 = 1590267460u;
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
