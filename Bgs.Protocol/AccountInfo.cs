using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class AccountInfo : IMessage<AccountInfo>, IEquatable<AccountInfo>, IDeepCloneable<AccountInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountInfo.__c __9 = new AccountInfo.__c();

			internal AccountInfo cctor>b__49_0()
			{
				return new AccountInfo();
			}
		}

		private static readonly MessageParser<AccountInfo> _parser = new MessageParser<AccountInfo>(new Func<AccountInfo>(AccountInfo.__c.__9.<.cctor>b__49_0));

		public const int AccountPaidFieldNumber = 1;

		private bool accountPaid_;

		public const int CountryIdFieldNumber = 2;

		private uint countryId_;

		public const int BattleTagFieldNumber = 3;

		private string battleTag_ = "";

		public const int ManualReviewFieldNumber = 4;

		private bool manualReview_;

		public const int IdentityFieldNumber = 5;

		private Identity identity_;

		public const int AccountMutedFieldNumber = 6;

		private bool accountMuted_;

		public static MessageParser<AccountInfo> Parser
		{
			get
			{
				return AccountInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountInfo.Descriptor;
			}
		}

		public bool AccountPaid
		{
			get
			{
				return this.accountPaid_;
			}
			set
			{
				this.accountPaid_ = value;
			}
		}

		public uint CountryId
		{
			get
			{
				return this.countryId_;
			}
			set
			{
				this.countryId_ = value;
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
				this.battleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool ManualReview
		{
			get
			{
				return this.manualReview_;
			}
			set
			{
				this.manualReview_ = value;
			}
		}

		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		public bool AccountMuted
		{
			get
			{
				return this.accountMuted_;
			}
			set
			{
				this.accountMuted_ = value;
			}
		}

		public AccountInfo()
		{
		}

		public AccountInfo(AccountInfo other) : this()
		{
			while (true)
			{
				IL_8B:
				uint arg_6B_0 = 1226152285u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6B_0 ^ 383966984u)) % 5u)
					{
					case 0u:
						goto IL_8B;
					case 1u:
						this.countryId_ = other.countryId_;
						this.battleTag_ = other.battleTag_;
						arg_6B_0 = (num * 1303063284u ^ 1495185889u);
						continue;
					case 2u:
						this.accountPaid_ = other.accountPaid_;
						arg_6B_0 = (num * 2906765502u ^ 1568155813u);
						continue;
					case 3u:
						this.manualReview_ = other.manualReview_;
						arg_6B_0 = (num * 56701258u ^ 3827539971u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Identity = ((other.identity_ != null) ? other.Identity.Clone() : null);
			this.accountMuted_ = other.accountMuted_;
		}

		public AccountInfo Clone()
		{
			return new AccountInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountInfo);
		}

		public bool Equals(AccountInfo other)
		{
			if (other == null)
			{
				goto IL_A0;
			}
			goto IL_17D;
			int arg_11F_0;
			while (true)
			{
				IL_11A:
				switch ((arg_11F_0 ^ -1446213176) % 17)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_11F_0 = ((this.ManualReview == other.ManualReview) ? -1032075495 : -1486551266);
					continue;
				case 4:
					return false;
				case 5:
					arg_11F_0 = ((this.AccountPaid == other.AccountPaid) ? -2030893801 : -1222297370);
					continue;
				case 6:
					goto IL_17D;
				case 7:
					arg_11F_0 = ((this.AccountMuted == other.AccountMuted) ? -204118446 : -2267457);
					continue;
				case 8:
					return false;
				case 9:
					goto IL_A0;
				case 10:
					return false;
				case 11:
					arg_11F_0 = (AccountInfo.smethod_0(this.BattleTag, other.BattleTag) ? -47535640 : -978693882);
					continue;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					arg_11F_0 = ((this.CountryId != other.CountryId) ? -776955049 : -1561107326);
					continue;
				case 16:
					arg_11F_0 = (AccountInfo.smethod_1(this.Identity, other.Identity) ? -1041831010 : -1814257051);
					continue;
				}
				break;
			}
			return true;
			IL_A0:
			arg_11F_0 = -667318091;
			goto IL_11A;
			IL_17D:
			arg_11F_0 = ((other != this) ? -1434840396 : -1869876481);
			goto IL_11A;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.AccountPaid)
			{
				goto IL_F4;
			}
			goto IL_1D4;
			uint arg_184_0;
			while (true)
			{
				IL_17F:
				uint num2;
				switch ((num2 = (arg_184_0 ^ 3109503115u)) % 13u)
				{
				case 0u:
					goto IL_1D4;
				case 1u:
					arg_184_0 = ((!this.ManualReview) ? 2237091721u : 4039113313u);
					continue;
				case 2u:
					arg_184_0 = ((this.identity_ == null) ? 2200419523u : 3375047175u);
					continue;
				case 3u:
					num ^= this.AccountMuted.GetHashCode();
					arg_184_0 = (num2 * 3253824608u ^ 3053126659u);
					continue;
				case 4u:
					arg_184_0 = (this.AccountMuted ? 2918086254u : 2395551203u);
					continue;
				case 5u:
					goto IL_F4;
				case 6u:
					num ^= this.AccountPaid.GetHashCode();
					arg_184_0 = (num2 * 4128534398u ^ 984653995u);
					continue;
				case 7u:
					num ^= this.CountryId.GetHashCode();
					arg_184_0 = (num2 * 788223343u ^ 2822702838u);
					continue;
				case 8u:
					num ^= this.BattleTag.GetHashCode();
					arg_184_0 = (num2 * 3769597176u ^ 1571805169u);
					continue;
				case 10u:
					arg_184_0 = ((this.BattleTag.Length != 0) ? 2147988335u : 2831508241u);
					continue;
				case 11u:
					num ^= this.Identity.GetHashCode();
					arg_184_0 = (num2 * 316371058u ^ 727883419u);
					continue;
				case 12u:
					num ^= this.ManualReview.GetHashCode();
					arg_184_0 = (num2 * 2057658846u ^ 3324088165u);
					continue;
				}
				break;
			}
			return num;
			IL_F4:
			arg_184_0 = 2512670171u;
			goto IL_17F;
			IL_1D4:
			arg_184_0 = ((this.CountryId == 0u) ? 4156619256u : 3180263001u);
			goto IL_17F;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.AccountPaid)
			{
				goto IL_41;
			}
			goto IL_225;
			uint arg_1C9_0;
			while (true)
			{
				IL_1C4:
				uint num;
				switch ((num = (arg_1C9_0 ^ 1970039153u)) % 16u)
				{
				case 0u:
					output.WriteBool(this.ManualReview);
					arg_1C9_0 = (num * 490233699u ^ 4251193978u);
					continue;
				case 1u:
					output.WriteRawTag(42);
					arg_1C9_0 = (num * 3759737133u ^ 49692360u);
					continue;
				case 2u:
					output.WriteBool(this.AccountMuted);
					arg_1C9_0 = (num * 1893858779u ^ 1142958765u);
					continue;
				case 3u:
					output.WriteRawTag(26);
					output.WriteString(this.BattleTag);
					arg_1C9_0 = (num * 3860963783u ^ 2654747227u);
					continue;
				case 4u:
					output.WriteMessage(this.Identity);
					arg_1C9_0 = (num * 1981656809u ^ 998057170u);
					continue;
				case 5u:
					output.WriteRawTag(21);
					output.WriteFixed32(this.CountryId);
					arg_1C9_0 = (num * 742392008u ^ 2944345039u);
					continue;
				case 6u:
					arg_1C9_0 = ((AccountInfo.smethod_2(this.BattleTag) == 0) ? 300947550u : 1045542050u);
					continue;
				case 7u:
					arg_1C9_0 = (this.AccountMuted ? 237442825u : 1315476795u);
					continue;
				case 8u:
					output.WriteRawTag(48);
					arg_1C9_0 = (num * 3896638193u ^ 4069234219u);
					continue;
				case 9u:
					output.WriteRawTag(32);
					arg_1C9_0 = (num * 62325700u ^ 3990507877u);
					continue;
				case 11u:
					arg_1C9_0 = ((this.identity_ != null) ? 780728384u : 152046870u);
					continue;
				case 12u:
					output.WriteRawTag(8);
					output.WriteBool(this.AccountPaid);
					arg_1C9_0 = (num * 3896038350u ^ 1686855828u);
					continue;
				case 13u:
					goto IL_225;
				case 14u:
					goto IL_41;
				case 15u:
					arg_1C9_0 = ((!this.ManualReview) ? 584715562u : 709179352u);
					continue;
				}
				break;
			}
			return;
			IL_41:
			arg_1C9_0 = 1099948525u;
			goto IL_1C4;
			IL_225:
			arg_1C9_0 = ((this.CountryId != 0u) ? 1500258980u : 1577328039u);
			goto IL_1C4;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1C1:
				uint arg_17C_0 = 2674401755u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_17C_0 ^ 3177189115u)) % 14u)
					{
					case 0u:
						arg_17C_0 = (this.ManualReview ? 3904407418u : 3999617471u);
						continue;
					case 1u:
						arg_17C_0 = ((!this.AccountMuted) ? 4071364565u : 2575299501u);
						continue;
					case 2u:
						arg_17C_0 = ((this.identity_ == null) ? 2234446268u : 4268384194u);
						continue;
					case 3u:
						num += 2;
						arg_17C_0 = (num2 * 4034742325u ^ 1357873988u);
						continue;
					case 4u:
						arg_17C_0 = (((!this.AccountPaid) ? 478260637u : 904326254u) ^ num2 * 1489856263u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
						arg_17C_0 = (num2 * 1208316776u ^ 4221205431u);
						continue;
					case 6u:
						num += 2;
						arg_17C_0 = (num2 * 3922223841u ^ 3269755715u);
						continue;
					case 7u:
						goto IL_1C1;
					case 8u:
						arg_17C_0 = ((this.CountryId != 0u) ? 3857878676u : 2574134131u);
						continue;
					case 9u:
						num += 5;
						arg_17C_0 = (num2 * 3027506607u ^ 1469369746u);
						continue;
					case 11u:
						num += 2;
						arg_17C_0 = (num2 * 4141901996u ^ 39688979u);
						continue;
					case 12u:
						arg_17C_0 = ((AccountInfo.smethod_2(this.BattleTag) != 0) ? 3420989704u : 2325420047u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
						arg_17C_0 = (num2 * 153808425u ^ 766177693u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountInfo other)
		{
			if (other == null)
			{
				goto IL_11F;
			}
			goto IL_22C;
			uint arg_1CC_0;
			while (true)
			{
				IL_1C7:
				uint num;
				switch ((num = (arg_1CC_0 ^ 3822585588u)) % 17u)
				{
				case 0u:
					arg_1CC_0 = (((this.identity_ != null) ? 4124676349u : 3606050910u) ^ num * 3498863663u);
					continue;
				case 1u:
					return;
				case 2u:
					arg_1CC_0 = ((other.CountryId == 0u) ? 2427754532u : 2498065771u);
					continue;
				case 3u:
					this.identity_ = new Identity();
					arg_1CC_0 = (num * 1410965643u ^ 3314300115u);
					continue;
				case 4u:
					this.AccountMuted = other.AccountMuted;
					arg_1CC_0 = (num * 1786843617u ^ 3140260210u);
					continue;
				case 5u:
					arg_1CC_0 = (other.ManualReview ? 2646903915u : 3578569216u);
					continue;
				case 6u:
					goto IL_11F;
				case 7u:
					arg_1CC_0 = (other.AccountMuted ? 2148253618u : 2676354548u);
					continue;
				case 8u:
					goto IL_22C;
				case 9u:
					this.ManualReview = other.ManualReview;
					arg_1CC_0 = (num * 2735205992u ^ 513638552u);
					continue;
				case 11u:
					arg_1CC_0 = ((AccountInfo.smethod_2(other.BattleTag) != 0) ? 4233996820u : 4129660866u);
					continue;
				case 12u:
					this.CountryId = other.CountryId;
					arg_1CC_0 = (num * 108763866u ^ 1509131074u);
					continue;
				case 13u:
					this.AccountPaid = other.AccountPaid;
					arg_1CC_0 = (num * 130733476u ^ 4165354620u);
					continue;
				case 14u:
					this.Identity.MergeFrom(other.Identity);
					arg_1CC_0 = 3231454485u;
					continue;
				case 15u:
					arg_1CC_0 = ((other.identity_ != null) ? 4079779648u : 3231454485u);
					continue;
				case 16u:
					this.BattleTag = other.BattleTag;
					arg_1CC_0 = (num * 2207235965u ^ 2806322850u);
					continue;
				}
				break;
			}
			return;
			IL_11F:
			arg_1CC_0 = 2349844885u;
			goto IL_1C7;
			IL_22C:
			arg_1CC_0 = ((!other.AccountPaid) ? 2842356308u : 3289287950u);
			goto IL_1C7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2DD:
				uint num;
				uint arg_25D_0 = ((num = input.ReadTag()) == 0u) ? 1557493971u : 38314372u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_25D_0 ^ 761689756u)) % 25u)
					{
					case 0u:
						arg_25D_0 = (num2 * 2554196330u ^ 1602145266u);
						continue;
					case 1u:
						this.AccountMuted = input.ReadBool();
						arg_25D_0 = 494594660u;
						continue;
					case 2u:
						arg_25D_0 = (((num != 21u) ? 2517148524u : 2448600058u) ^ num2 * 3135029169u);
						continue;
					case 3u:
						this.CountryId = input.ReadFixed32();
						arg_25D_0 = 785443201u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_25D_0 = 1479375679u;
						continue;
					case 5u:
						input.ReadMessage(this.identity_);
						arg_25D_0 = 494594660u;
						continue;
					case 6u:
						arg_25D_0 = (((num == 26u) ? 2723767362u : 2588386741u) ^ num2 * 2934454527u);
						continue;
					case 7u:
						arg_25D_0 = (((num == 48u) ? 1984401358u : 441946300u) ^ num2 * 2524852756u);
						continue;
					case 8u:
						arg_25D_0 = (num2 * 3423325031u ^ 1570761167u);
						continue;
					case 9u:
						arg_25D_0 = (num2 * 3018743075u ^ 10497790u);
						continue;
					case 10u:
						goto IL_2DD;
					case 11u:
						arg_25D_0 = (num2 * 4268840847u ^ 2891730950u);
						continue;
					case 12u:
						this.identity_ = new Identity();
						arg_25D_0 = (num2 * 1924416502u ^ 3917220849u);
						continue;
					case 13u:
						arg_25D_0 = (num2 * 2060601623u ^ 3542965953u);
						continue;
					case 14u:
						arg_25D_0 = 38314372u;
						continue;
					case 16u:
						arg_25D_0 = (((num != 42u) ? 1875924937u : 1272864019u) ^ num2 * 2945580799u);
						continue;
					case 17u:
						arg_25D_0 = (((num == 8u) ? 187350121u : 1471764366u) ^ num2 * 1257540567u);
						continue;
					case 18u:
						arg_25D_0 = ((num == 32u) ? 1569418069u : 1941395528u);
						continue;
					case 19u:
						arg_25D_0 = ((this.identity_ == null) ? 566839550u : 1742574557u);
						continue;
					case 20u:
						this.AccountPaid = input.ReadBool();
						arg_25D_0 = 2025248002u;
						continue;
					case 21u:
						arg_25D_0 = (num2 * 2124245324u ^ 3911063608u);
						continue;
					case 22u:
						arg_25D_0 = ((num > 26u) ? 589814287u : 1533458525u);
						continue;
					case 23u:
						this.BattleTag = input.ReadString();
						arg_25D_0 = 566411953u;
						continue;
					case 24u:
						this.ManualReview = input.ReadBool();
						arg_25D_0 = 2136745443u;
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
