using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountFieldTags : IMessage<AccountFieldTags>, IEquatable<AccountFieldTags>, IDeepCloneable<AccountFieldTags>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountFieldTags.__c __9 = new AccountFieldTags.__c();

			internal AccountFieldTags cctor>b__49_0()
			{
				return new AccountFieldTags();
			}
		}

		private static readonly MessageParser<AccountFieldTags> _parser = new MessageParser<AccountFieldTags>(new Func<AccountFieldTags>(AccountFieldTags.__c.__9.<.cctor>b__49_0));

		public const int AccountLevelInfoTagFieldNumber = 2;

		private uint accountLevelInfoTag_;

		public const int PrivacyInfoTagFieldNumber = 3;

		private uint privacyInfoTag_;

		public const int ParentalControlInfoTagFieldNumber = 4;

		private uint parentalControlInfoTag_;

		public const int GameLevelInfoTagsFieldNumber = 7;

		private static readonly FieldCodec<ProgramTag> _repeated_gameLevelInfoTags_codec;

		private readonly RepeatedField<ProgramTag> gameLevelInfoTags_ = new RepeatedField<ProgramTag>();

		public const int GameStatusTagsFieldNumber = 9;

		private static readonly FieldCodec<ProgramTag> _repeated_gameStatusTags_codec;

		private readonly RepeatedField<ProgramTag> gameStatusTags_ = new RepeatedField<ProgramTag>();

		public const int GameAccountTagsFieldNumber = 11;

		private static readonly FieldCodec<RegionTag> _repeated_gameAccountTags_codec;

		private readonly RepeatedField<RegionTag> gameAccountTags_ = new RepeatedField<RegionTag>();

		public static MessageParser<AccountFieldTags> Parser
		{
			get
			{
				return AccountFieldTags._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[13];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountFieldTags.Descriptor;
			}
		}

		public uint AccountLevelInfoTag
		{
			get
			{
				return this.accountLevelInfoTag_;
			}
			set
			{
				this.accountLevelInfoTag_ = value;
			}
		}

		public uint PrivacyInfoTag
		{
			get
			{
				return this.privacyInfoTag_;
			}
			set
			{
				this.privacyInfoTag_ = value;
			}
		}

		public uint ParentalControlInfoTag
		{
			get
			{
				return this.parentalControlInfoTag_;
			}
			set
			{
				this.parentalControlInfoTag_ = value;
			}
		}

		public RepeatedField<ProgramTag> GameLevelInfoTags
		{
			get
			{
				return this.gameLevelInfoTags_;
			}
		}

		public RepeatedField<ProgramTag> GameStatusTags
		{
			get
			{
				return this.gameStatusTags_;
			}
		}

		public RepeatedField<RegionTag> GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
		}

		public AccountFieldTags()
		{
		}

		public AccountFieldTags(AccountFieldTags other) : this()
		{
			this.accountLevelInfoTag_ = other.accountLevelInfoTag_;
			this.privacyInfoTag_ = other.privacyInfoTag_;
			this.parentalControlInfoTag_ = other.parentalControlInfoTag_;
			this.gameLevelInfoTags_ = other.gameLevelInfoTags_.Clone();
			this.gameStatusTags_ = other.gameStatusTags_.Clone();
			this.gameAccountTags_ = other.gameAccountTags_.Clone();
		}

		public AccountFieldTags Clone()
		{
			return new AccountFieldTags(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountFieldTags);
		}

		public bool Equals(AccountFieldTags other)
		{
			if (other == null)
			{
				goto IL_CA;
			}
			goto IL_185;
			int arg_127_0;
			while (true)
			{
				IL_122:
				switch ((arg_127_0 ^ 1495762588) % 17)
				{
				case 0:
					arg_127_0 = ((!this.gameStatusTags_.Equals(other.gameStatusTags_)) ? 489718452 : 220199713);
					continue;
				case 2:
					arg_127_0 = ((this.PrivacyInfoTag != other.PrivacyInfoTag) ? 734956148 : 1558150255);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_CA;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					goto IL_185;
				case 8:
					return false;
				case 9:
					arg_127_0 = (this.gameLevelInfoTags_.Equals(other.gameLevelInfoTags_) ? 1853564229 : 938600069);
					continue;
				case 10:
					arg_127_0 = ((this.AccountLevelInfoTag != other.AccountLevelInfoTag) ? 1675769632 : 245276277);
					continue;
				case 11:
					return false;
				case 12:
					arg_127_0 = (this.gameAccountTags_.Equals(other.gameAccountTags_) ? 629296013 : 452130122);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_127_0 = ((this.ParentalControlInfoTag != other.ParentalControlInfoTag) ? 2039362759 : 560995139);
					continue;
				case 16:
					return false;
				}
				break;
			}
			return true;
			IL_CA:
			arg_127_0 = 550431555;
			goto IL_122;
			IL_185:
			arg_127_0 = ((other == this) ? 158377168 : 742562337);
			goto IL_122;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_140:
				uint arg_10F_0 = 2088997715u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10F_0 ^ 563640804u)) % 9u)
					{
					case 0u:
						arg_10F_0 = ((this.PrivacyInfoTag == 0u) ? 570266850u : 393840652u);
						continue;
					case 1u:
						num ^= this.AccountLevelInfoTag.GetHashCode();
						arg_10F_0 = (num2 * 3215873138u ^ 114147050u);
						continue;
					case 2u:
						num ^= this.ParentalControlInfoTag.GetHashCode();
						arg_10F_0 = (num2 * 2988552919u ^ 2394621992u);
						continue;
					case 3u:
						goto IL_140;
					case 4u:
						num ^= this.gameLevelInfoTags_.GetHashCode();
						num ^= this.gameStatusTags_.GetHashCode();
						num ^= this.gameAccountTags_.GetHashCode();
						arg_10F_0 = 124131471u;
						continue;
					case 5u:
						arg_10F_0 = ((this.ParentalControlInfoTag == 0u) ? 1121698003u : 1325794201u);
						continue;
					case 6u:
						arg_10F_0 = (((this.AccountLevelInfoTag == 0u) ? 892132553u : 1522330217u) ^ num2 * 2472933185u);
						continue;
					case 8u:
						num ^= this.PrivacyInfoTag.GetHashCode();
						arg_10F_0 = (num2 * 4228965756u ^ 279453826u);
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
			if (this.AccountLevelInfoTag != 0u)
			{
				goto IL_DA;
			}
			goto IL_16F;
			uint arg_127_0;
			while (true)
			{
				IL_122:
				uint num;
				switch ((num = (arg_127_0 ^ 1952857112u)) % 11u)
				{
				case 0u:
					this.gameAccountTags_.WriteTo(output, AccountFieldTags._repeated_gameAccountTags_codec);
					arg_127_0 = (num * 1471932312u ^ 3759409331u);
					continue;
				case 1u:
					output.WriteRawTag(21);
					output.WriteFixed32(this.AccountLevelInfoTag);
					arg_127_0 = (num * 1431086317u ^ 4014176796u);
					continue;
				case 2u:
					goto IL_DA;
				case 3u:
					arg_127_0 = ((this.ParentalControlInfoTag != 0u) ? 1987839027u : 845581436u);
					continue;
				case 4u:
					output.WriteRawTag(37);
					arg_127_0 = (num * 2308537614u ^ 392603193u);
					continue;
				case 5u:
					output.WriteRawTag(29);
					output.WriteFixed32(this.PrivacyInfoTag);
					arg_127_0 = (num * 717941418u ^ 2551598687u);
					continue;
				case 7u:
					goto IL_16F;
				case 8u:
					this.gameStatusTags_.WriteTo(output, AccountFieldTags._repeated_gameStatusTags_codec);
					arg_127_0 = (num * 3467609849u ^ 31581909u);
					continue;
				case 9u:
					output.WriteFixed32(this.ParentalControlInfoTag);
					arg_127_0 = (num * 3099116267u ^ 2508632981u);
					continue;
				case 10u:
					this.gameLevelInfoTags_.WriteTo(output, AccountFieldTags._repeated_gameLevelInfoTags_codec);
					arg_127_0 = 1891037733u;
					continue;
				}
				break;
			}
			return;
			IL_DA:
			arg_127_0 = 1071323166u;
			goto IL_122;
			IL_16F:
			arg_127_0 = ((this.PrivacyInfoTag == 0u) ? 667479109u : 634736833u);
			goto IL_122;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_125:
				uint arg_F4_0 = 3511828047u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F4_0 ^ 3235747853u)) % 9u)
					{
					case 0u:
						arg_F4_0 = ((this.ParentalControlInfoTag == 0u) ? 2693409330u : 3057319775u);
						continue;
					case 1u:
						arg_F4_0 = ((this.PrivacyInfoTag == 0u) ? 3552167299u : 3600748487u);
						continue;
					case 2u:
						arg_F4_0 = (((this.AccountLevelInfoTag != 0u) ? 2069477640u : 520171612u) ^ num2 * 488605024u);
						continue;
					case 3u:
						num += 5;
						arg_F4_0 = (num2 * 790136146u ^ 3633927479u);
						continue;
					case 4u:
						num += this.gameLevelInfoTags_.CalculateSize(AccountFieldTags._repeated_gameLevelInfoTags_codec);
						num += this.gameStatusTags_.CalculateSize(AccountFieldTags._repeated_gameStatusTags_codec);
						num += this.gameAccountTags_.CalculateSize(AccountFieldTags._repeated_gameAccountTags_codec);
						arg_F4_0 = 3171609002u;
						continue;
					case 5u:
						goto IL_125;
					case 6u:
						num += 5;
						arg_F4_0 = (num2 * 3960443743u ^ 109791068u);
						continue;
					case 7u:
						num += 5;
						arg_F4_0 = (num2 * 3679962122u ^ 1731685166u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountFieldTags other)
		{
			if (other == null)
			{
				goto IL_A4;
			}
			goto IL_152;
			uint arg_10A_0;
			while (true)
			{
				IL_105:
				uint num;
				switch ((num = (arg_10A_0 ^ 3089493893u)) % 11u)
				{
				case 0u:
					goto IL_152;
				case 1u:
					return;
				case 2u:
					this.ParentalControlInfoTag = other.ParentalControlInfoTag;
					arg_10A_0 = (num * 3250220199u ^ 2279995418u);
					continue;
				case 3u:
					this.gameAccountTags_.Add(other.gameAccountTags_);
					arg_10A_0 = (num * 3279546606u ^ 3569464995u);
					continue;
				case 4u:
					arg_10A_0 = ((other.ParentalControlInfoTag != 0u) ? 4268857209u : 3772302462u);
					continue;
				case 5u:
					goto IL_A4;
				case 6u:
					this.gameLevelInfoTags_.Add(other.gameLevelInfoTags_);
					this.gameStatusTags_.Add(other.gameStatusTags_);
					arg_10A_0 = 2805786857u;
					continue;
				case 7u:
					this.AccountLevelInfoTag = other.AccountLevelInfoTag;
					arg_10A_0 = (num * 3266444576u ^ 1450688877u);
					continue;
				case 8u:
					arg_10A_0 = ((other.PrivacyInfoTag == 0u) ? 3993273861u : 3027402931u);
					continue;
				case 9u:
					this.PrivacyInfoTag = other.PrivacyInfoTag;
					arg_10A_0 = (num * 3874647367u ^ 2778813439u);
					continue;
				}
				break;
			}
			return;
			IL_A4:
			arg_10A_0 = 3049224193u;
			goto IL_105;
			IL_152:
			arg_10A_0 = ((other.AccountLevelInfoTag == 0u) ? 3728477069u : 3456777146u);
			goto IL_105;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2C0:
				uint num;
				uint arg_244_0 = ((num = input.ReadTag()) == 0u) ? 3212691713u : 2364452976u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_244_0 ^ 3793294634u)) % 24u)
					{
					case 0u:
						arg_244_0 = (((num == 29u) ? 2705414539u : 3106142341u) ^ num2 * 503420558u);
						continue;
					case 1u:
						arg_244_0 = (((num != 90u) ? 278332316u : 1775220668u) ^ num2 * 3642053194u);
						continue;
					case 2u:
						arg_244_0 = (((num != 21u) ? 2636951632u : 3808365610u) ^ num2 * 263334685u);
						continue;
					case 4u:
						arg_244_0 = (num2 * 1301623319u ^ 608095131u);
						continue;
					case 5u:
						goto IL_2C0;
					case 6u:
						arg_244_0 = (num2 * 1538288903u ^ 521082820u);
						continue;
					case 7u:
						arg_244_0 = (((num == 37u) ? 1997083948u : 1289045908u) ^ num2 * 2696957328u);
						continue;
					case 8u:
						this.gameLevelInfoTags_.AddEntriesFrom(input, AccountFieldTags._repeated_gameLevelInfoTags_codec);
						arg_244_0 = 2601868106u;
						continue;
					case 9u:
						this.PrivacyInfoTag = input.ReadFixed32();
						arg_244_0 = 2837754718u;
						continue;
					case 10u:
						this.AccountLevelInfoTag = input.ReadFixed32();
						arg_244_0 = 3884028060u;
						continue;
					case 11u:
						arg_244_0 = ((num != 58u) ? 3897001827u : 3330181490u);
						continue;
					case 12u:
						input.SkipLastField();
						arg_244_0 = 3233662845u;
						continue;
					case 13u:
						arg_244_0 = (num2 * 3293973076u ^ 1363621299u);
						continue;
					case 14u:
						this.ParentalControlInfoTag = input.ReadFixed32();
						arg_244_0 = 3701709729u;
						continue;
					case 15u:
						arg_244_0 = (num2 * 1681513757u ^ 2972825900u);
						continue;
					case 16u:
						arg_244_0 = (num2 * 835942005u ^ 1095648791u);
						continue;
					case 17u:
						arg_244_0 = (((num == 74u) ? 2977454448u : 4274995012u) ^ num2 * 1761533279u);
						continue;
					case 18u:
						arg_244_0 = ((num > 37u) ? 2616572665u : 2888917320u);
						continue;
					case 19u:
						arg_244_0 = (num2 * 99220778u ^ 2857604665u);
						continue;
					case 20u:
						this.gameAccountTags_.AddEntriesFrom(input, AccountFieldTags._repeated_gameAccountTags_codec);
						arg_244_0 = 3064879095u;
						continue;
					case 21u:
						this.gameStatusTags_.AddEntriesFrom(input, AccountFieldTags._repeated_gameStatusTags_codec);
						arg_244_0 = 2859470375u;
						continue;
					case 22u:
						arg_244_0 = (num2 * 1257955773u ^ 3900045993u);
						continue;
					case 23u:
						arg_244_0 = 2364452976u;
						continue;
					}
					return;
				}
			}
		}

		static AccountFieldTags()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_8C:
				uint arg_70_0 = 71599001u;
				while (true)
				{
					uint num;
					switch ((num = (arg_70_0 ^ 1657912444u)) % 4u)
					{
					case 1u:
						AccountFieldTags._repeated_gameLevelInfoTags_codec = FieldCodec.ForMessage<ProgramTag>(58u, ProgramTag.Parser);
						arg_70_0 = (num * 3060174800u ^ 2379504694u);
						continue;
					case 2u:
						AccountFieldTags._repeated_gameStatusTags_codec = FieldCodec.ForMessage<ProgramTag>(74u, ProgramTag.Parser);
						AccountFieldTags._repeated_gameAccountTags_codec = FieldCodec.ForMessage<RegionTag>(90u, RegionTag.Parser);
						arg_70_0 = (num * 3515518794u ^ 2241834260u);
						continue;
					case 3u:
						goto IL_8C;
					}
					return;
				}
			}
		}
	}
}
