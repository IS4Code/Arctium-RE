using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAccountRequest : IMessage<GetAccountRequest>, IEquatable<GetAccountRequest>, IDeepCloneable<GetAccountRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAccountRequest.__c __9 = new GetAccountRequest.__c();

			internal GetAccountRequest cctor>b__64_0()
			{
				return new GetAccountRequest();
			}
		}

		private static readonly MessageParser<GetAccountRequest> _parser = new MessageParser<GetAccountRequest>(new Func<GetAccountRequest>(GetAccountRequest.__c.__9.<.cctor>b__64_0));

		public const int RefFieldNumber = 1;

		private AccountReference ref_;

		public const int FetchAllFieldNumber = 10;

		private bool fetchAll_;

		public const int FetchBlobFieldNumber = 11;

		private bool fetchBlob_;

		public const int FetchIdFieldNumber = 12;

		private bool fetchId_;

		public const int FetchEmailFieldNumber = 13;

		private bool fetchEmail_;

		public const int FetchBattleTagFieldNumber = 14;

		private bool fetchBattleTag_;

		public const int FetchFullNameFieldNumber = 15;

		private bool fetchFullName_;

		public const int FetchLinksFieldNumber = 16;

		private bool fetchLinks_;

		public const int FetchParentalControlsFieldNumber = 17;

		private bool fetchParentalControls_;

		public static MessageParser<GetAccountRequest> Parser
		{
			get
			{
				return GetAccountRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountRequest.Descriptor;
			}
		}

		public AccountReference Ref
		{
			get
			{
				return this.ref_;
			}
			set
			{
				this.ref_ = value;
			}
		}

		public bool FetchAll
		{
			get
			{
				return this.fetchAll_;
			}
			set
			{
				this.fetchAll_ = value;
			}
		}

		public bool FetchBlob
		{
			get
			{
				return this.fetchBlob_;
			}
			set
			{
				this.fetchBlob_ = value;
			}
		}

		public bool FetchId
		{
			get
			{
				return this.fetchId_;
			}
			set
			{
				this.fetchId_ = value;
			}
		}

		public bool FetchEmail
		{
			get
			{
				return this.fetchEmail_;
			}
			set
			{
				this.fetchEmail_ = value;
			}
		}

		public bool FetchBattleTag
		{
			get
			{
				return this.fetchBattleTag_;
			}
			set
			{
				this.fetchBattleTag_ = value;
			}
		}

		public bool FetchFullName
		{
			get
			{
				return this.fetchFullName_;
			}
			set
			{
				this.fetchFullName_ = value;
			}
		}

		public bool FetchLinks
		{
			get
			{
				return this.fetchLinks_;
			}
			set
			{
				this.fetchLinks_ = value;
			}
		}

		public bool FetchParentalControls
		{
			get
			{
				return this.fetchParentalControls_;
			}
			set
			{
				this.fetchParentalControls_ = value;
			}
		}

		public GetAccountRequest()
		{
		}

		public GetAccountRequest(GetAccountRequest other) : this()
		{
			while (true)
			{
				IL_F8:
				uint arg_D0_0 = 3142363072u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D0_0 ^ 4020977170u)) % 7u)
					{
					case 0u:
						this.fetchAll_ = other.fetchAll_;
						arg_D0_0 = (num * 3822196430u ^ 1409698025u);
						continue;
					case 2u:
						this.fetchBattleTag_ = other.fetchBattleTag_;
						this.fetchFullName_ = other.fetchFullName_;
						this.fetchLinks_ = other.fetchLinks_;
						this.fetchParentalControls_ = other.fetchParentalControls_;
						arg_D0_0 = (num * 3682265239u ^ 3664450586u);
						continue;
					case 3u:
						this.Ref = ((other.ref_ != null) ? other.Ref.Clone() : null);
						arg_D0_0 = 4103299969u;
						continue;
					case 4u:
						this.fetchBlob_ = other.fetchBlob_;
						arg_D0_0 = (num * 2315855216u ^ 1828915943u);
						continue;
					case 5u:
						goto IL_F8;
					case 6u:
						this.fetchId_ = other.fetchId_;
						this.fetchEmail_ = other.fetchEmail_;
						arg_D0_0 = (num * 99097471u ^ 131928831u);
						continue;
					}
					return;
				}
			}
		}

		public GetAccountRequest Clone()
		{
			return new GetAccountRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountRequest);
		}

		public bool Equals(GetAccountRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_20E;
			int arg_198_0;
			while (true)
			{
				IL_193:
				switch ((arg_198_0 ^ -847805793) % 23)
				{
				case 0:
					return false;
				case 1:
					arg_198_0 = ((this.FetchBlob != other.FetchBlob) ? -589754747 : -2085603656);
					continue;
				case 2:
					goto IL_20E;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_198_0 = ((this.FetchFullName != other.FetchFullName) ? -1435074159 : -1511765467);
					continue;
				case 7:
					return false;
				case 8:
					return true;
				case 9:
					arg_198_0 = ((!GetAccountRequest.smethod_0(this.Ref, other.Ref)) ? -1172084261 : -437085979);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 13:
					arg_198_0 = ((this.FetchParentalControls != other.FetchParentalControls) ? -944139996 : -1892609862);
					continue;
				case 14:
					arg_198_0 = ((this.FetchId == other.FetchId) ? -265351608 : -474810593);
					continue;
				case 15:
					arg_198_0 = ((this.FetchEmail != other.FetchEmail) ? -2065838753 : -430528170);
					continue;
				case 16:
					arg_198_0 = ((this.FetchAll != other.FetchAll) ? -1844580872 : -678151045);
					continue;
				case 17:
					arg_198_0 = ((this.FetchBattleTag == other.FetchBattleTag) ? -1665983072 : -1697630007);
					continue;
				case 18:
					arg_198_0 = ((this.FetchLinks != other.FetchLinks) ? -994345468 : -2043592771);
					continue;
				case 19:
					goto IL_18;
				case 20:
					return false;
				case 21:
					return false;
				case 22:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_198_0 = -381583474;
			goto IL_193;
			IL_20E:
			arg_198_0 = ((other == this) ? -1677138455 : -589822004);
			goto IL_193;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.ref_ != null)
			{
				goto IL_24A;
			}
			goto IL_2BC;
			uint arg_254_0;
			while (true)
			{
				IL_24F:
				uint num2;
				switch ((num2 = (arg_254_0 ^ 172632704u)) % 19u)
				{
				case 0u:
					goto IL_24A;
				case 1u:
					arg_254_0 = ((!this.FetchEmail) ? 1745150730u : 1005635232u);
					continue;
				case 2u:
					arg_254_0 = ((!this.FetchBattleTag) ? 721837195u : 1754135228u);
					continue;
				case 3u:
					num ^= this.FetchBattleTag.GetHashCode();
					arg_254_0 = (num2 * 1173068787u ^ 987013247u);
					continue;
				case 4u:
					arg_254_0 = ((!this.FetchId) ? 1810738072u : 966365681u);
					continue;
				case 5u:
					num ^= this.FetchAll.GetHashCode();
					arg_254_0 = (num2 * 3904229107u ^ 1988930586u);
					continue;
				case 6u:
					goto IL_2BC;
				case 7u:
					num ^= this.FetchFullName.GetHashCode();
					arg_254_0 = (num2 * 3419487808u ^ 1905751278u);
					continue;
				case 8u:
					arg_254_0 = (this.FetchLinks ? 520125827u : 243129350u);
					continue;
				case 9u:
					num ^= this.FetchEmail.GetHashCode();
					arg_254_0 = (num2 * 1872591073u ^ 1805413162u);
					continue;
				case 10u:
					arg_254_0 = ((!this.FetchParentalControls) ? 792126276u : 1825209133u);
					continue;
				case 11u:
					num ^= this.FetchLinks.GetHashCode();
					arg_254_0 = (num2 * 3307674613u ^ 3384429273u);
					continue;
				case 12u:
					arg_254_0 = ((!this.FetchFullName) ? 1821586542u : 1375238418u);
					continue;
				case 13u:
					arg_254_0 = ((!this.FetchBlob) ? 2078565473u : 393464365u);
					continue;
				case 14u:
					num ^= this.FetchParentalControls.GetHashCode();
					arg_254_0 = (num2 * 500526509u ^ 1515731373u);
					continue;
				case 16u:
					num ^= this.FetchId.GetHashCode();
					arg_254_0 = (num2 * 395151427u ^ 467057931u);
					continue;
				case 17u:
					num ^= this.FetchBlob.GetHashCode();
					arg_254_0 = (num2 * 681424433u ^ 4093877116u);
					continue;
				case 18u:
					num ^= GetAccountRequest.smethod_1(this.Ref);
					arg_254_0 = (num2 * 1394005301u ^ 1281172675u);
					continue;
				}
				break;
			}
			return num;
			IL_24A:
			arg_254_0 = 1489681897u;
			goto IL_24F;
			IL_2BC:
			arg_254_0 = ((!this.FetchAll) ? 964836620u : 1010878098u);
			goto IL_24F;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.ref_ != null)
			{
				goto IL_12C;
			}
			goto IL_338;
			uint arg_2C0_0;
			while (true)
			{
				IL_2BB:
				uint num;
				switch ((num = (arg_2C0_0 ^ 2369489846u)) % 23u)
				{
				case 0u:
					output.WriteBool(this.FetchBlob);
					arg_2C0_0 = (num * 2427286944u ^ 1923477231u);
					continue;
				case 1u:
					goto IL_338;
				case 2u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Ref);
					arg_2C0_0 = (num * 1232238613u ^ 907633668u);
					continue;
				case 3u:
					output.WriteRawTag(112);
					output.WriteBool(this.FetchBattleTag);
					arg_2C0_0 = (num * 4217483469u ^ 1753719411u);
					continue;
				case 4u:
					output.WriteRawTag(96);
					arg_2C0_0 = (num * 1925778880u ^ 1384232404u);
					continue;
				case 5u:
					output.WriteBool(this.FetchFullName);
					arg_2C0_0 = (num * 904598182u ^ 3217422111u);
					continue;
				case 6u:
					output.WriteRawTag(120);
					arg_2C0_0 = (num * 103534462u ^ 668942089u);
					continue;
				case 7u:
					arg_2C0_0 = ((!this.FetchBlob) ? 4244579471u : 3495363650u);
					continue;
				case 8u:
					output.WriteRawTag(104);
					output.WriteBool(this.FetchEmail);
					arg_2C0_0 = (num * 2045840464u ^ 1685900143u);
					continue;
				case 9u:
					arg_2C0_0 = (this.FetchBattleTag ? 3172432739u : 4190365922u);
					continue;
				case 11u:
					arg_2C0_0 = (this.FetchParentalControls ? 2833731190u : 3435499945u);
					continue;
				case 12u:
					output.WriteRawTag(128, 1);
					output.WriteBool(this.FetchLinks);
					arg_2C0_0 = (num * 3309038210u ^ 1096503054u);
					continue;
				case 13u:
					output.WriteRawTag(136, 1);
					arg_2C0_0 = (num * 4197704706u ^ 377552212u);
					continue;
				case 14u:
					goto IL_12C;
				case 15u:
					arg_2C0_0 = ((!this.FetchId) ? 3939138300u : 3905455935u);
					continue;
				case 16u:
					output.WriteRawTag(88);
					arg_2C0_0 = (num * 402469874u ^ 2316022497u);
					continue;
				case 17u:
					arg_2C0_0 = ((!this.FetchLinks) ? 2996997712u : 3295027801u);
					continue;
				case 18u:
					arg_2C0_0 = ((!this.FetchFullName) ? 3633228413u : 3132747040u);
					continue;
				case 19u:
					output.WriteRawTag(80);
					output.WriteBool(this.FetchAll);
					arg_2C0_0 = (num * 856705979u ^ 1509747949u);
					continue;
				case 20u:
					arg_2C0_0 = ((!this.FetchEmail) ? 2282417919u : 2978756403u);
					continue;
				case 21u:
					output.WriteBool(this.FetchParentalControls);
					arg_2C0_0 = (num * 2768266595u ^ 1990670159u);
					continue;
				case 22u:
					output.WriteBool(this.FetchId);
					arg_2C0_0 = (num * 1267434991u ^ 337737410u);
					continue;
				}
				break;
			}
			return;
			IL_12C:
			arg_2C0_0 = 3183629405u;
			goto IL_2BB;
			IL_338:
			arg_2C0_0 = ((!this.FetchAll) ? 4069857517u : 3300333494u);
			goto IL_2BB;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_273:
				uint arg_216_0 = 3013214507u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_216_0 ^ 3457195625u)) % 20u)
					{
					case 0u:
						arg_216_0 = (this.FetchEmail ? 4077784508u : 3569317063u);
						continue;
					case 1u:
						num += 2;
						arg_216_0 = (num2 * 1838888546u ^ 3748000077u);
						continue;
					case 2u:
						num += 3;
						arg_216_0 = (num2 * 3261385715u ^ 2270454923u);
						continue;
					case 3u:
						arg_216_0 = ((!this.FetchAll) ? 3174684510u : 3276314909u);
						continue;
					case 4u:
						num += 2;
						arg_216_0 = (num2 * 852173208u ^ 1796192190u);
						continue;
					case 5u:
						goto IL_273;
					case 6u:
						num += 3;
						arg_216_0 = (num2 * 747507874u ^ 787724872u);
						continue;
					case 7u:
						num += 2;
						arg_216_0 = (num2 * 3101292130u ^ 219650584u);
						continue;
					case 8u:
						arg_216_0 = ((!this.FetchFullName) ? 4120328006u : 3026889142u);
						continue;
					case 9u:
						num += 2;
						arg_216_0 = (num2 * 2482290284u ^ 1848178857u);
						continue;
					case 10u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Ref);
						arg_216_0 = (num2 * 380823123u ^ 1600518860u);
						continue;
					case 11u:
						num += 2;
						arg_216_0 = (num2 * 3687304856u ^ 2621229669u);
						continue;
					case 12u:
						arg_216_0 = (this.FetchParentalControls ? 2784508415u : 3189036708u);
						continue;
					case 14u:
						arg_216_0 = (this.FetchBattleTag ? 4068575594u : 3066288557u);
						continue;
					case 15u:
						arg_216_0 = (this.FetchLinks ? 2416537167u : 4189155993u);
						continue;
					case 16u:
						num += 2;
						arg_216_0 = (num2 * 1084184877u ^ 2157567756u);
						continue;
					case 17u:
						arg_216_0 = ((!this.FetchId) ? 3996088549u : 2297166464u);
						continue;
					case 18u:
						arg_216_0 = (((this.ref_ != null) ? 3370290961u : 3289391552u) ^ num2 * 3935693519u);
						continue;
					case 19u:
						arg_216_0 = ((!this.FetchBlob) ? 2614130276u : 4177985121u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetAccountRequest other)
		{
			if (other == null)
			{
				goto IL_280;
			}
			goto IL_302;
			uint arg_28A_0;
			while (true)
			{
				IL_285:
				uint num;
				switch ((num = (arg_28A_0 ^ 673477329u)) % 23u)
				{
				case 0u:
					goto IL_280;
				case 1u:
					arg_28A_0 = (other.FetchLinks ? 1604185315u : 2080222985u);
					continue;
				case 2u:
					arg_28A_0 = ((!other.FetchFullName) ? 1387670941u : 579867938u);
					continue;
				case 3u:
					return;
				case 4u:
					this.FetchFullName = other.FetchFullName;
					arg_28A_0 = (num * 1068212818u ^ 2169781323u);
					continue;
				case 5u:
					this.FetchParentalControls = other.FetchParentalControls;
					arg_28A_0 = (num * 2373865870u ^ 1833459914u);
					continue;
				case 6u:
					this.FetchAll = other.FetchAll;
					arg_28A_0 = (num * 1619829963u ^ 2694937319u);
					continue;
				case 7u:
					goto IL_302;
				case 8u:
					arg_28A_0 = ((!other.FetchBattleTag) ? 409361859u : 948422999u);
					continue;
				case 9u:
					this.FetchBlob = other.FetchBlob;
					arg_28A_0 = (num * 3846366214u ^ 299201568u);
					continue;
				case 10u:
					this.Ref.MergeFrom(other.Ref);
					arg_28A_0 = 2050757583u;
					continue;
				case 11u:
					this.ref_ = new AccountReference();
					arg_28A_0 = (num * 579010534u ^ 2698437859u);
					continue;
				case 13u:
					arg_28A_0 = (other.FetchParentalControls ? 2129701518u : 956330872u);
					continue;
				case 14u:
					arg_28A_0 = (other.FetchAll ? 2056916435u : 2065859697u);
					continue;
				case 15u:
					arg_28A_0 = (other.FetchId ? 409574630u : 1255531028u);
					continue;
				case 16u:
					arg_28A_0 = (other.FetchEmail ? 1321952580u : 1003518474u);
					continue;
				case 17u:
					this.FetchEmail = other.FetchEmail;
					arg_28A_0 = (num * 1541112811u ^ 3251805901u);
					continue;
				case 18u:
					this.FetchBattleTag = other.FetchBattleTag;
					arg_28A_0 = (num * 3031463927u ^ 1445160329u);
					continue;
				case 19u:
					arg_28A_0 = (other.FetchBlob ? 1525578258u : 1075483826u);
					continue;
				case 20u:
					this.FetchLinks = other.FetchLinks;
					arg_28A_0 = (num * 4071698923u ^ 1757439727u);
					continue;
				case 21u:
					this.FetchId = other.FetchId;
					arg_28A_0 = (num * 1545862157u ^ 892198623u);
					continue;
				case 22u:
					arg_28A_0 = (((this.ref_ == null) ? 4058487060u : 3861223325u) ^ num * 4156128112u);
					continue;
				}
				break;
			}
			return;
			IL_280:
			arg_28A_0 = 1290491901u;
			goto IL_285;
			IL_302:
			arg_28A_0 = ((other.ref_ == null) ? 2050757583u : 1076001753u);
			goto IL_285;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_448:
				uint num;
				uint arg_39C_0 = ((num = input.ReadTag()) == 0u) ? 2989231291u : 3245901478u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_39C_0 ^ 3952351511u)) % 36u)
					{
					case 0u:
						arg_39C_0 = 3245901478u;
						continue;
					case 1u:
						this.FetchParentalControls = input.ReadBool();
						arg_39C_0 = 3783385365u;
						continue;
					case 2u:
						arg_39C_0 = (((num != 128u) ? 3267756230u : 3861666492u) ^ num2 * 1266392662u);
						continue;
					case 3u:
						arg_39C_0 = (num2 * 3200685881u ^ 855117821u);
						continue;
					case 5u:
						arg_39C_0 = ((num <= 96u) ? 2656000491u : 3115938048u);
						continue;
					case 6u:
						arg_39C_0 = ((this.ref_ == null) ? 3297236128u : 3840928548u);
						continue;
					case 7u:
						this.FetchLinks = input.ReadBool();
						arg_39C_0 = 2707356377u;
						continue;
					case 8u:
						arg_39C_0 = (num2 * 549510053u ^ 116389293u);
						continue;
					case 9u:
						input.SkipLastField();
						arg_39C_0 = 3604515569u;
						continue;
					case 10u:
						arg_39C_0 = (num2 * 3045130534u ^ 3025043329u);
						continue;
					case 11u:
						arg_39C_0 = (num2 * 1782718454u ^ 2926477304u);
						continue;
					case 12u:
						arg_39C_0 = (((num != 80u) ? 2128333104u : 55862190u) ^ num2 * 1951667292u);
						continue;
					case 13u:
						this.FetchFullName = input.ReadBool();
						arg_39C_0 = 3978009603u;
						continue;
					case 14u:
						this.FetchBattleTag = input.ReadBool();
						arg_39C_0 = 3074076605u;
						continue;
					case 15u:
						arg_39C_0 = (((num != 112u) ? 2495303002u : 2415822599u) ^ num2 * 3875813950u);
						continue;
					case 16u:
						arg_39C_0 = (((num <= 80u) ? 3860326805u : 3750893487u) ^ num2 * 4061641522u);
						continue;
					case 17u:
						arg_39C_0 = ((num != 120u) ? 4250205201u : 3331126958u);
						continue;
					case 18u:
						arg_39C_0 = (((num == 10u) ? 2239717267u : 2585195037u) ^ num2 * 3759650949u);
						continue;
					case 19u:
						arg_39C_0 = (((num != 96u) ? 1115791081u : 23196779u) ^ num2 * 1753324244u);
						continue;
					case 20u:
						arg_39C_0 = (num2 * 2494555315u ^ 269106665u);
						continue;
					case 21u:
						arg_39C_0 = (((num == 136u) ? 3982057351u : 3130771015u) ^ num2 * 591428593u);
						continue;
					case 22u:
						arg_39C_0 = (num2 * 1583998082u ^ 2538758246u);
						continue;
					case 23u:
						input.ReadMessage(this.ref_);
						arg_39C_0 = 3206408308u;
						continue;
					case 24u:
						this.FetchId = input.ReadBool();
						arg_39C_0 = 3783385365u;
						continue;
					case 25u:
						arg_39C_0 = (((num != 104u) ? 1749119998u : 1716007532u) ^ num2 * 2770328650u);
						continue;
					case 26u:
						goto IL_448;
					case 27u:
						arg_39C_0 = (num2 * 3705748970u ^ 2166348395u);
						continue;
					case 28u:
						this.FetchBlob = input.ReadBool();
						arg_39C_0 = 3783385365u;
						continue;
					case 29u:
						this.FetchAll = input.ReadBool();
						arg_39C_0 = 3783385365u;
						continue;
					case 30u:
						arg_39C_0 = (num2 * 50782457u ^ 2856421967u);
						continue;
					case 31u:
						this.ref_ = new AccountReference();
						arg_39C_0 = (num2 * 2098915091u ^ 2017562289u);
						continue;
					case 32u:
						arg_39C_0 = ((num != 88u) ? 4164132456u : 4266700635u);
						continue;
					case 33u:
						this.FetchEmail = input.ReadBool();
						arg_39C_0 = 2536512847u;
						continue;
					case 34u:
						arg_39C_0 = (num2 * 49989246u ^ 1093750305u);
						continue;
					case 35u:
						arg_39C_0 = ((num <= 112u) ? 3243707350u : 4276857262u);
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
