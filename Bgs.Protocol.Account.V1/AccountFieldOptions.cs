using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountFieldOptions : IMessage<AccountFieldOptions>, IEquatable<AccountFieldOptions>, IDeepCloneable<AccountFieldOptions>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountFieldOptions.__c __9 = new AccountFieldOptions.__c();

			internal AccountFieldOptions cctor>b__54_0()
			{
				return new AccountFieldOptions();
			}
		}

		private static readonly MessageParser<AccountFieldOptions> _parser = new MessageParser<AccountFieldOptions>(new Func<AccountFieldOptions>(AccountFieldOptions.__c.__9.<.cctor>b__54_0));

		public const int AllFieldsFieldNumber = 1;

		private bool allFields_;

		public const int FieldAccountLevelInfoFieldNumber = 2;

		private bool fieldAccountLevelInfo_;

		public const int FieldPrivacyInfoFieldNumber = 3;

		private bool fieldPrivacyInfo_;

		public const int FieldParentalControlInfoFieldNumber = 4;

		private bool fieldParentalControlInfo_;

		public const int FieldGameLevelInfoFieldNumber = 6;

		private bool fieldGameLevelInfo_;

		public const int FieldGameStatusFieldNumber = 7;

		private bool fieldGameStatus_;

		public const int FieldGameAccountsFieldNumber = 8;

		private bool fieldGameAccounts_;

		public static MessageParser<AccountFieldOptions> Parser
		{
			get
			{
				return AccountFieldOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[15];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountFieldOptions.Descriptor;
			}
		}

		public bool AllFields
		{
			get
			{
				return this.allFields_;
			}
			set
			{
				this.allFields_ = value;
			}
		}

		public bool FieldAccountLevelInfo
		{
			get
			{
				return this.fieldAccountLevelInfo_;
			}
			set
			{
				this.fieldAccountLevelInfo_ = value;
			}
		}

		public bool FieldPrivacyInfo
		{
			get
			{
				return this.fieldPrivacyInfo_;
			}
			set
			{
				this.fieldPrivacyInfo_ = value;
			}
		}

		public bool FieldParentalControlInfo
		{
			get
			{
				return this.fieldParentalControlInfo_;
			}
			set
			{
				this.fieldParentalControlInfo_ = value;
			}
		}

		public bool FieldGameLevelInfo
		{
			get
			{
				return this.fieldGameLevelInfo_;
			}
			set
			{
				this.fieldGameLevelInfo_ = value;
			}
		}

		public bool FieldGameStatus
		{
			get
			{
				return this.fieldGameStatus_;
			}
			set
			{
				this.fieldGameStatus_ = value;
			}
		}

		public bool FieldGameAccounts
		{
			get
			{
				return this.fieldGameAccounts_;
			}
			set
			{
				this.fieldGameAccounts_ = value;
			}
		}

		public AccountFieldOptions()
		{
		}

		public AccountFieldOptions(AccountFieldOptions other) : this()
		{
			while (true)
			{
				IL_D5:
				uint arg_AD_0 = 1734400600u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AD_0 ^ 1156509716u)) % 7u)
					{
					case 0u:
						this.fieldAccountLevelInfo_ = other.fieldAccountLevelInfo_;
						arg_AD_0 = (num * 3700181386u ^ 2312010353u);
						continue;
					case 2u:
						goto IL_D5;
					case 3u:
						this.allFields_ = other.allFields_;
						arg_AD_0 = (num * 2216029725u ^ 3777893453u);
						continue;
					case 4u:
						this.fieldGameLevelInfo_ = other.fieldGameLevelInfo_;
						this.fieldGameStatus_ = other.fieldGameStatus_;
						arg_AD_0 = (num * 2581913572u ^ 4179316797u);
						continue;
					case 5u:
						this.fieldGameAccounts_ = other.fieldGameAccounts_;
						arg_AD_0 = (num * 3738502471u ^ 3750000138u);
						continue;
					case 6u:
						this.fieldPrivacyInfo_ = other.fieldPrivacyInfo_;
						this.fieldParentalControlInfo_ = other.fieldParentalControlInfo_;
						arg_AD_0 = (num * 443046003u ^ 1395747408u);
						continue;
					}
					return;
				}
			}
		}

		public AccountFieldOptions Clone()
		{
			return new AccountFieldOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountFieldOptions);
		}

		public bool Equals(AccountFieldOptions other)
		{
			if (other == null)
			{
				goto IL_10E;
			}
			goto IL_1A5;
			int arg_13F_0;
			while (true)
			{
				IL_13A:
				switch ((arg_13F_0 ^ -1807244442) % 19)
				{
				case 0:
					goto IL_1A5;
				case 1:
					arg_13F_0 = ((this.FieldGameAccounts != other.FieldGameAccounts) ? -1427198393 : -1816969118);
					continue;
				case 2:
					goto IL_10E;
				case 3:
					arg_13F_0 = ((this.FieldGameLevelInfo == other.FieldGameLevelInfo) ? -294151186 : -1520527443);
					continue;
				case 4:
					return false;
				case 5:
					arg_13F_0 = ((this.FieldGameStatus != other.FieldGameStatus) ? -2098688357 : -335818026);
					continue;
				case 6:
					return false;
				case 7:
					arg_13F_0 = ((this.FieldAccountLevelInfo != other.FieldAccountLevelInfo) ? -2008620776 : -931411096);
					continue;
				case 8:
					arg_13F_0 = ((this.FieldParentalControlInfo == other.FieldParentalControlInfo) ? -1183587001 : -1820565844);
					continue;
				case 9:
					return false;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_13F_0 = ((this.FieldPrivacyInfo != other.FieldPrivacyInfo) ? -979620489 : -295355773);
					continue;
				case 14:
					return true;
				case 15:
					return false;
				case 16:
					arg_13F_0 = ((this.AllFields != other.AllFields) ? -29753654 : -873586042);
					continue;
				case 17:
					return false;
				case 18:
					return false;
				}
				break;
			}
			return true;
			IL_10E:
			arg_13F_0 = -346564682;
			goto IL_13A;
			IL_1A5:
			arg_13F_0 = ((other == this) ? -1468516975 : -1787671864);
			goto IL_13A;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_244:
				uint arg_1F7_0 = 657739004u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F7_0 ^ 2018328537u)) % 16u)
					{
					case 0u:
						arg_1F7_0 = ((!this.FieldParentalControlInfo) ? 1904237954u : 1494597706u);
						continue;
					case 1u:
						num ^= this.FieldPrivacyInfo.GetHashCode();
						arg_1F7_0 = (num2 * 2924090806u ^ 1046269903u);
						continue;
					case 2u:
						arg_1F7_0 = ((!this.FieldGameStatus) ? 1889539747u : 283409252u);
						continue;
					case 3u:
						num ^= this.FieldParentalControlInfo.GetHashCode();
						arg_1F7_0 = (num2 * 3986916933u ^ 366774557u);
						continue;
					case 4u:
						goto IL_244;
					case 5u:
						arg_1F7_0 = (((!this.AllFields) ? 2799520071u : 2320080265u) ^ num2 * 3231970094u);
						continue;
					case 6u:
						num ^= this.AllFields.GetHashCode();
						arg_1F7_0 = (num2 * 2842751006u ^ 4007724085u);
						continue;
					case 7u:
						num ^= this.FieldGameLevelInfo.GetHashCode();
						arg_1F7_0 = (num2 * 3707775539u ^ 4256736334u);
						continue;
					case 8u:
						arg_1F7_0 = (this.FieldAccountLevelInfo ? 150181302u : 549798656u);
						continue;
					case 9u:
						arg_1F7_0 = (this.FieldPrivacyInfo ? 10361576u : 2014296601u);
						continue;
					case 10u:
						arg_1F7_0 = (this.FieldGameAccounts ? 1716189671u : 715870853u);
						continue;
					case 11u:
						arg_1F7_0 = (this.FieldGameLevelInfo ? 1016683070u : 129013579u);
						continue;
					case 13u:
						num ^= this.FieldGameStatus.GetHashCode();
						arg_1F7_0 = (num2 * 3874541520u ^ 1475131955u);
						continue;
					case 14u:
						num ^= this.FieldGameAccounts.GetHashCode();
						arg_1F7_0 = (num2 * 1896808131u ^ 3869956031u);
						continue;
					case 15u:
						num ^= this.FieldAccountLevelInfo.GetHashCode();
						arg_1F7_0 = (num2 * 1569769824u ^ 201610144u);
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
			if (this.AllFields)
			{
				goto IL_207;
			}
			goto IL_275;
			uint arg_211_0;
			while (true)
			{
				IL_20C:
				uint num;
				switch ((num = (arg_211_0 ^ 1488801095u)) % 18u)
				{
				case 0u:
					goto IL_207;
				case 1u:
					output.WriteRawTag(16);
					output.WriteBool(this.FieldAccountLevelInfo);
					arg_211_0 = (num * 2643642822u ^ 3932633292u);
					continue;
				case 2u:
					arg_211_0 = ((!this.FieldGameStatus) ? 112498435u : 193152028u);
					continue;
				case 3u:
					output.WriteRawTag(32);
					output.WriteBool(this.FieldParentalControlInfo);
					arg_211_0 = (num * 3831928653u ^ 483677389u);
					continue;
				case 4u:
					output.WriteRawTag(64);
					arg_211_0 = (num * 3359443784u ^ 2897470820u);
					continue;
				case 5u:
					output.WriteRawTag(56);
					arg_211_0 = (num * 3554152190u ^ 2334819098u);
					continue;
				case 6u:
					output.WriteBool(this.AllFields);
					arg_211_0 = (num * 3736973150u ^ 225208312u);
					continue;
				case 7u:
					output.WriteBool(this.FieldGameStatus);
					arg_211_0 = (num * 940186810u ^ 3299924917u);
					continue;
				case 8u:
					arg_211_0 = ((!this.FieldGameAccounts) ? 1256833169u : 1872642671u);
					continue;
				case 9u:
					arg_211_0 = (this.FieldPrivacyInfo ? 1323651035u : 2081019323u);
					continue;
				case 10u:
					output.WriteRawTag(24);
					output.WriteBool(this.FieldPrivacyInfo);
					arg_211_0 = (num * 1800194062u ^ 2300825907u);
					continue;
				case 11u:
					output.WriteBool(this.FieldGameAccounts);
					arg_211_0 = (num * 2803582399u ^ 818750796u);
					continue;
				case 12u:
					output.WriteRawTag(8);
					arg_211_0 = (num * 90231862u ^ 769973875u);
					continue;
				case 13u:
					arg_211_0 = (this.FieldGameLevelInfo ? 1512716618u : 350998787u);
					continue;
				case 14u:
					arg_211_0 = ((!this.FieldParentalControlInfo) ? 346963274u : 229961572u);
					continue;
				case 15u:
					output.WriteRawTag(48);
					output.WriteBool(this.FieldGameLevelInfo);
					arg_211_0 = (num * 2210230699u ^ 4246114476u);
					continue;
				case 17u:
					goto IL_275;
				}
				break;
			}
			return;
			IL_207:
			arg_211_0 = 2112541843u;
			goto IL_20C;
			IL_275:
			arg_211_0 = ((!this.FieldAccountLevelInfo) ? 101576046u : 1965555452u);
			goto IL_20C;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1E6:
				uint arg_199_0 = 3621484426u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_199_0 ^ 3494992494u)) % 16u)
					{
					case 0u:
						arg_199_0 = ((!this.FieldAccountLevelInfo) ? 2267118531u : 2909480571u);
						continue;
					case 1u:
						num += 2;
						arg_199_0 = (num2 * 480172791u ^ 150880866u);
						continue;
					case 2u:
						num += 2;
						arg_199_0 = (num2 * 3205498145u ^ 1719052566u);
						continue;
					case 3u:
						num += 2;
						arg_199_0 = (num2 * 2583900604u ^ 1540675347u);
						continue;
					case 4u:
						arg_199_0 = (((!this.AllFields) ? 861275650u : 395215509u) ^ num2 * 1060856391u);
						continue;
					case 5u:
						num += 2;
						arg_199_0 = (num2 * 3262280307u ^ 4039142572u);
						continue;
					case 6u:
						arg_199_0 = ((!this.FieldGameLevelInfo) ? 3109078661u : 3860456447u);
						continue;
					case 7u:
						num += 2;
						arg_199_0 = (num2 * 2123691916u ^ 1651220970u);
						continue;
					case 8u:
						goto IL_1E6;
					case 9u:
						arg_199_0 = ((!this.FieldParentalControlInfo) ? 4054214200u : 2420370448u);
						continue;
					case 11u:
						arg_199_0 = (this.FieldGameStatus ? 2448343089u : 4142661570u);
						continue;
					case 12u:
						arg_199_0 = ((!this.FieldGameAccounts) ? 3692379972u : 2372968572u);
						continue;
					case 13u:
						arg_199_0 = (this.FieldPrivacyInfo ? 2161463725u : 2203394343u);
						continue;
					case 14u:
						num += 2;
						arg_199_0 = (num2 * 3832568467u ^ 2678157410u);
						continue;
					case 15u:
						num += 2;
						arg_199_0 = (num2 * 3401790325u ^ 843351465u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountFieldOptions other)
		{
			if (other == null)
			{
				goto IL_54;
			}
			goto IL_220;
			uint arg_1C0_0;
			while (true)
			{
				IL_1BB:
				uint num;
				switch ((num = (arg_1C0_0 ^ 2528105642u)) % 17u)
				{
				case 1u:
					return;
				case 2u:
					arg_1C0_0 = (other.FieldPrivacyInfo ? 3928880008u : 2825561522u);
					continue;
				case 3u:
					arg_1C0_0 = ((!other.FieldGameAccounts) ? 3917929187u : 3402943353u);
					continue;
				case 4u:
					this.FieldPrivacyInfo = other.FieldPrivacyInfo;
					arg_1C0_0 = (num * 790076348u ^ 1463744330u);
					continue;
				case 5u:
					arg_1C0_0 = ((!other.FieldParentalControlInfo) ? 2233305437u : 3736020421u);
					continue;
				case 6u:
					arg_1C0_0 = (other.FieldAccountLevelInfo ? 3176569071u : 2988087837u);
					continue;
				case 7u:
					this.AllFields = other.AllFields;
					arg_1C0_0 = (num * 3912963050u ^ 4164892800u);
					continue;
				case 8u:
					goto IL_220;
				case 9u:
					this.FieldGameLevelInfo = other.FieldGameLevelInfo;
					arg_1C0_0 = (num * 1030792841u ^ 4181940248u);
					continue;
				case 10u:
					arg_1C0_0 = (other.FieldGameLevelInfo ? 3831932384u : 3336619138u);
					continue;
				case 11u:
					arg_1C0_0 = ((!other.FieldGameStatus) ? 3361221153u : 3104177287u);
					continue;
				case 12u:
					this.FieldAccountLevelInfo = other.FieldAccountLevelInfo;
					arg_1C0_0 = (num * 1749674316u ^ 234941281u);
					continue;
				case 13u:
					this.FieldGameStatus = other.FieldGameStatus;
					arg_1C0_0 = (num * 1718846243u ^ 1498525446u);
					continue;
				case 14u:
					goto IL_54;
				case 15u:
					this.FieldGameAccounts = other.FieldGameAccounts;
					arg_1C0_0 = (num * 1826048094u ^ 3185106329u);
					continue;
				case 16u:
					this.FieldParentalControlInfo = other.FieldParentalControlInfo;
					arg_1C0_0 = (num * 3265725012u ^ 3129384753u);
					continue;
				}
				break;
			}
			return;
			IL_54:
			arg_1C0_0 = 3313810361u;
			goto IL_1BB;
			IL_220:
			arg_1C0_0 = (other.AllFields ? 2998844572u : 2502458332u);
			goto IL_1BB;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_303:
				uint num;
				uint arg_27F_0 = ((num = input.ReadTag()) == 0u) ? 2439597942u : 3874362131u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_27F_0 ^ 3906075014u)) % 26u)
					{
					case 0u:
						arg_27F_0 = (num2 * 3206045207u ^ 5541088u);
						continue;
					case 1u:
						arg_27F_0 = ((num > 24u) ? 2273924335u : 3549329679u);
						continue;
					case 2u:
						arg_27F_0 = (num2 * 585306669u ^ 1954052232u);
						continue;
					case 3u:
						goto IL_303;
					case 4u:
						arg_27F_0 = (((num == 32u) ? 1717396481u : 26736813u) ^ num2 * 1061518597u);
						continue;
					case 5u:
						this.FieldPrivacyInfo = input.ReadBool();
						arg_27F_0 = 3397456339u;
						continue;
					case 6u:
						arg_27F_0 = (num2 * 3905126725u ^ 437113609u);
						continue;
					case 7u:
						arg_27F_0 = ((num != 56u) ? 4064766205u : 3709868263u);
						continue;
					case 8u:
						arg_27F_0 = (((num != 24u) ? 1738082924u : 2012929459u) ^ num2 * 1258195181u);
						continue;
					case 9u:
						arg_27F_0 = ((num <= 48u) ? 3327860332u : 3771194237u);
						continue;
					case 10u:
						arg_27F_0 = 3874362131u;
						continue;
					case 11u:
						arg_27F_0 = (((num == 48u) ? 4039134311u : 2810634358u) ^ num2 * 2143920380u);
						continue;
					case 12u:
						arg_27F_0 = (((num == 16u) ? 3865620109u : 2701780490u) ^ num2 * 2914058667u);
						continue;
					case 13u:
						this.FieldGameLevelInfo = input.ReadBool();
						arg_27F_0 = 2885830036u;
						continue;
					case 14u:
						this.AllFields = input.ReadBool();
						arg_27F_0 = 3397456339u;
						continue;
					case 15u:
						arg_27F_0 = (num2 * 2141153989u ^ 3269225600u);
						continue;
					case 17u:
						this.FieldParentalControlInfo = input.ReadBool();
						arg_27F_0 = 2416450138u;
						continue;
					case 18u:
						arg_27F_0 = (num2 * 1569294411u ^ 3474960551u);
						continue;
					case 19u:
						arg_27F_0 = (((num != 64u) ? 4137697959u : 3035434187u) ^ num2 * 3548026729u);
						continue;
					case 20u:
						input.SkipLastField();
						arg_27F_0 = 4274448782u;
						continue;
					case 21u:
						arg_27F_0 = (((num == 8u) ? 40932423u : 808892047u) ^ num2 * 2735582247u);
						continue;
					case 22u:
						arg_27F_0 = (num2 * 1565118835u ^ 4030442059u);
						continue;
					case 23u:
						this.FieldAccountLevelInfo = input.ReadBool();
						arg_27F_0 = 3387281585u;
						continue;
					case 24u:
						this.FieldGameAccounts = input.ReadBool();
						arg_27F_0 = 3397456339u;
						continue;
					case 25u:
						this.FieldGameStatus = input.ReadBool();
						arg_27F_0 = 3397456339u;
						continue;
					}
					return;
				}
			}
		}
	}
}
