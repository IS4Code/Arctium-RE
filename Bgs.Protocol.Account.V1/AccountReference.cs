using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountReference : IMessage<AccountReference>, IEquatable<AccountReference>, IDeepCloneable<AccountReference>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountReference.__c __9 = new AccountReference.__c();

			internal AccountReference cctor>b__44_0()
			{
				return new AccountReference();
			}
		}

		private static readonly MessageParser<AccountReference> _parser = new MessageParser<AccountReference>(new Func<AccountReference>(AccountReference.__c.__9.<.cctor>b__44_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int EmailFieldNumber = 2;

		private string email_ = "";

		public const int HandleFieldNumber = 3;

		private GameAccountHandle handle_;

		public const int BattleTagFieldNumber = 4;

		private string battleTag_ = "";

		public const int RegionFieldNumber = 10;

		private uint region_;

		public static MessageParser<AccountReference> Parser
		{
			get
			{
				return AccountReference._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountReference.Descriptor;
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

		public string Email
		{
			get
			{
				return this.email_;
			}
			set
			{
				this.email_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public GameAccountHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		public string BattleTag
		{
			get
			{
				return this.battleTag_;
			}
			set
			{
				this.battleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
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

		public AccountReference()
		{
		}

		public AccountReference(AccountReference other) : this()
		{
			while (true)
			{
				IL_9F:
				uint arg_7F_0 = 3813727875u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7F_0 ^ 2858351766u)) % 5u)
					{
					case 0u:
						this.battleTag_ = other.battleTag_;
						this.region_ = other.region_;
						arg_7F_0 = (num * 3387791303u ^ 2790269389u);
						continue;
					case 1u:
						this.Handle = ((other.handle_ != null) ? other.Handle.Clone() : null);
						arg_7F_0 = 3596431072u;
						continue;
					case 2u:
						this.id_ = other.id_;
						this.email_ = other.email_;
						arg_7F_0 = (num * 520347375u ^ 3597235716u);
						continue;
					case 4u:
						goto IL_9F;
					}
					return;
				}
			}
		}

		public AccountReference Clone()
		{
			return new AccountReference(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountReference);
		}

		public bool Equals(AccountReference other)
		{
			if (other == null)
			{
				goto IL_C4;
			}
			goto IL_150;
			int arg_FA_0;
			while (true)
			{
				IL_F5:
				switch ((arg_FA_0 ^ -32262283) % 15)
				{
				case 0:
					arg_FA_0 = (AccountReference.smethod_0(this.Email, other.Email) ? -542389541 : -1605033139);
					continue;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					goto IL_C4;
				case 4:
					arg_FA_0 = ((this.Region == other.Region) ? -1283047372 : -2142836670);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_FA_0 = ((this.Id == other.Id) ? -113991834 : -2022135112);
					continue;
				case 8:
					arg_FA_0 = (AccountReference.smethod_1(this.Handle, other.Handle) ? -1845388416 : -359486316);
					continue;
				case 9:
					goto IL_150;
				case 10:
					arg_FA_0 = (AccountReference.smethod_0(this.BattleTag, other.BattleTag) ? -1413243841 : -1662704724);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_C4:
			arg_FA_0 = -1298380758;
			goto IL_F5;
			IL_150:
			arg_FA_0 = ((other != this) ? -1489201999 : -184327710);
			goto IL_F5;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1A7:
				uint arg_16A_0 = 441256402u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_16A_0 ^ 637252732u)) % 12u)
					{
					case 0u:
						num ^= this.Handle.GetHashCode();
						arg_16A_0 = (num2 * 3299753066u ^ 720179124u);
						continue;
					case 1u:
						arg_16A_0 = ((this.handle_ != null) ? 906299012u : 1461007620u);
						continue;
					case 2u:
						arg_16A_0 = (((this.Id != 0u) ? 2282360749u : 2195970911u) ^ num2 * 1621626364u);
						continue;
					case 4u:
						arg_16A_0 = ((this.BattleTag.Length != 0) ? 1619050585u : 99376814u);
						continue;
					case 5u:
						num ^= this.Id.GetHashCode();
						arg_16A_0 = (num2 * 3757511298u ^ 650915237u);
						continue;
					case 6u:
						goto IL_1A7;
					case 7u:
						arg_16A_0 = ((this.Email.Length != 0) ? 195554548u : 843342621u);
						continue;
					case 8u:
						num ^= this.Email.GetHashCode();
						arg_16A_0 = (num2 * 4085097165u ^ 3492059125u);
						continue;
					case 9u:
						num ^= this.BattleTag.GetHashCode();
						arg_16A_0 = (num2 * 2130152695u ^ 3602388253u);
						continue;
					case 10u:
						arg_16A_0 = ((this.Region == 0u) ? 1337850283u : 1734946127u);
						continue;
					case 11u:
						num ^= this.Region.GetHashCode();
						arg_16A_0 = (num2 * 2316504041u ^ 2406898112u);
						continue;
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
			if (this.Id != 0u)
			{
				goto IL_1D;
			}
			goto IL_1EA;
			uint arg_192_0;
			while (true)
			{
				IL_18D:
				uint num;
				switch ((num = (arg_192_0 ^ 370246798u)) % 15u)
				{
				case 0u:
					output.WriteString(this.Email);
					arg_192_0 = (num * 3517613621u ^ 3136677269u);
					continue;
				case 1u:
					goto IL_1EA;
				case 2u:
					output.WriteUInt32(this.Region);
					arg_192_0 = (num * 1379712177u ^ 3042971532u);
					continue;
				case 3u:
					output.WriteRawTag(26);
					arg_192_0 = (num * 1817032638u ^ 230028878u);
					continue;
				case 4u:
					output.WriteRawTag(34);
					output.WriteString(this.BattleTag);
					arg_192_0 = (num * 1626080147u ^ 2819300711u);
					continue;
				case 5u:
					arg_192_0 = ((this.handle_ != null) ? 798585045u : 1857891452u);
					continue;
				case 6u:
					arg_192_0 = ((this.Region != 0u) ? 145363515u : 1627522659u);
					continue;
				case 7u:
					output.WriteRawTag(13);
					arg_192_0 = (num * 3234270118u ^ 1702433538u);
					continue;
				case 8u:
					output.WriteRawTag(80);
					arg_192_0 = (num * 556772417u ^ 2659189732u);
					continue;
				case 9u:
					output.WriteFixed32(this.Id);
					arg_192_0 = (num * 3542703908u ^ 3470004296u);
					continue;
				case 11u:
					output.WriteRawTag(18);
					arg_192_0 = (num * 4286618011u ^ 9517140u);
					continue;
				case 12u:
					arg_192_0 = ((AccountReference.smethod_2(this.BattleTag) != 0) ? 581469203u : 1240607808u);
					continue;
				case 13u:
					output.WriteMessage(this.Handle);
					arg_192_0 = (num * 1793023723u ^ 2445369746u);
					continue;
				case 14u:
					goto IL_1D;
				}
				break;
			}
			return;
			IL_1D:
			arg_192_0 = 164792592u;
			goto IL_18D;
			IL_1EA:
			arg_192_0 = ((AccountReference.smethod_2(this.Email) == 0) ? 2135897725u : 741951064u);
			goto IL_18D;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_19C:
				uint arg_15F_0 = 2472887069u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_15F_0 ^ 2266531888u)) % 12u)
					{
					case 0u:
						arg_15F_0 = ((AccountReference.smethod_2(this.BattleTag) != 0) ? 3826198804u : 3839347857u);
						continue;
					case 1u:
						arg_15F_0 = ((this.Region == 0u) ? 3485666312u : 2865767667u);
						continue;
					case 2u:
						num += 5;
						arg_15F_0 = (num2 * 574953084u ^ 280649765u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
						arg_15F_0 = (num2 * 3599182241u ^ 3296193963u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
						arg_15F_0 = (num2 * 3482069214u ^ 1066176937u);
						continue;
					case 5u:
						arg_15F_0 = ((AccountReference.smethod_2(this.Email) == 0) ? 3820757983u : 3611733502u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
						arg_15F_0 = (num2 * 4239731216u ^ 419433279u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
						arg_15F_0 = (num2 * 3248918301u ^ 2298426071u);
						continue;
					case 9u:
						arg_15F_0 = (((this.Id == 0u) ? 3853628328u : 2465367683u) ^ num2 * 3170343641u);
						continue;
					case 10u:
						goto IL_19C;
					case 11u:
						arg_15F_0 = ((this.handle_ == null) ? 3927180912u : 4084857763u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountReference other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_1E7;
			uint arg_18F_0;
			while (true)
			{
				IL_18A:
				uint num;
				switch ((num = (arg_18F_0 ^ 3716462683u)) % 15u)
				{
				case 0u:
					arg_18F_0 = ((other.Region != 0u) ? 2785649651u : 2477202374u);
					continue;
				case 1u:
					return;
				case 2u:
					arg_18F_0 = (((this.handle_ != null) ? 3828395177u : 3817908654u) ^ num * 1328640268u);
					continue;
				case 3u:
					this.BattleTag = other.BattleTag;
					arg_18F_0 = (num * 2644069830u ^ 3521374858u);
					continue;
				case 4u:
					this.Email = other.Email;
					arg_18F_0 = (num * 4009049284u ^ 3708226533u);
					continue;
				case 5u:
					this.Id = other.Id;
					arg_18F_0 = (num * 2239219461u ^ 566930408u);
					continue;
				case 6u:
					arg_18F_0 = ((AccountReference.smethod_2(other.BattleTag) != 0) ? 2390506549u : 2620025246u);
					continue;
				case 7u:
					arg_18F_0 = ((other.handle_ == null) ? 2212953832u : 2742568052u);
					continue;
				case 8u:
					goto IL_9A;
				case 9u:
					this.Region = other.Region;
					arg_18F_0 = (num * 4165622435u ^ 2525409342u);
					continue;
				case 10u:
					this.handle_ = new GameAccountHandle();
					arg_18F_0 = (num * 3513940910u ^ 4024632243u);
					continue;
				case 11u:
					arg_18F_0 = ((AccountReference.smethod_2(other.Email) != 0) ? 3356399334u : 2359697233u);
					continue;
				case 12u:
					this.Handle.MergeFrom(other.Handle);
					arg_18F_0 = 2212953832u;
					continue;
				case 14u:
					goto IL_1E7;
				}
				break;
			}
			return;
			IL_9A:
			arg_18F_0 = 2447903419u;
			goto IL_18A;
			IL_1E7:
			arg_18F_0 = ((other.Id != 0u) ? 3395486292u : 3236683939u);
			goto IL_18A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_268:
				uint num;
				uint arg_1F8_0 = ((num = input.ReadTag()) == 0u) ? 707122069u : 785795232u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F8_0 ^ 1173531728u)) % 21u)
					{
					case 0u:
						arg_1F8_0 = (num2 * 169878637u ^ 2575823547u);
						continue;
					case 1u:
						this.Id = input.ReadFixed32();
						arg_1F8_0 = 1250712165u;
						continue;
					case 2u:
						arg_1F8_0 = (num2 * 1418516141u ^ 2895447964u);
						continue;
					case 3u:
						arg_1F8_0 = 785795232u;
						continue;
					case 4u:
						input.ReadMessage(this.handle_);
						arg_1F8_0 = 252553293u;
						continue;
					case 5u:
						arg_1F8_0 = (((num == 80u) ? 3389110747u : 2726625130u) ^ num2 * 299219434u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_1F8_0 = 975665452u;
						continue;
					case 7u:
						arg_1F8_0 = ((num != 26u) ? 1979340972u : 934896368u);
						continue;
					case 8u:
						arg_1F8_0 = ((num <= 18u) ? 1255155228u : 1377478812u);
						continue;
					case 9u:
						arg_1F8_0 = ((this.handle_ == null) ? 225604896u : 200183094u);
						continue;
					case 10u:
						arg_1F8_0 = (num2 * 722759410u ^ 2448035912u);
						continue;
					case 11u:
						arg_1F8_0 = (((num != 13u) ? 1221343140u : 293720676u) ^ num2 * 10603602u);
						continue;
					case 12u:
						this.Email = input.ReadString();
						arg_1F8_0 = 252553293u;
						continue;
					case 13u:
						this.handle_ = new GameAccountHandle();
						arg_1F8_0 = (num2 * 4242699206u ^ 568062358u);
						continue;
					case 15u:
						this.Region = input.ReadUInt32();
						arg_1F8_0 = 252553293u;
						continue;
					case 16u:
						arg_1F8_0 = (((num != 18u) ? 785027658u : 715190365u) ^ num2 * 970941289u);
						continue;
					case 17u:
						arg_1F8_0 = (num2 * 1524712317u ^ 2471041473u);
						continue;
					case 18u:
						arg_1F8_0 = (((num != 34u) ? 1169344147u : 1404875752u) ^ num2 * 3598307522u);
						continue;
					case 19u:
						this.BattleTag = input.ReadString();
						arg_1F8_0 = 565124446u;
						continue;
					case 20u:
						goto IL_268;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
