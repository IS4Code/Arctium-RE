using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAccountResponse : IMessage<GetAccountResponse>, IEquatable<GetAccountResponse>, IDeepCloneable<GetAccountResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAccountResponse.__c __9 = new GetAccountResponse.__c();

			internal GetAccountResponse cctor>b__54_0()
			{
				return new GetAccountResponse();
			}
		}

		private static readonly MessageParser<GetAccountResponse> _parser = new MessageParser<GetAccountResponse>(new Func<GetAccountResponse>(GetAccountResponse.__c.__9.<.cctor>b__54_0));

		public const int BlobFieldNumber = 11;

		private AccountBlob blob_;

		public const int IdFieldNumber = 12;

		private AccountId id_;

		public const int EmailFieldNumber = 13;

		private static readonly FieldCodec<string> _repeated_email_codec = FieldCodec.ForString(106u);

		private readonly RepeatedField<string> email_ = new RepeatedField<string>();

		public const int BattleTagFieldNumber = 14;

		private string battleTag_ = "";

		public const int FullNameFieldNumber = 15;

		private string fullName_ = "";

		public const int LinksFieldNumber = 16;

		private static readonly FieldCodec<GameAccountLink> _repeated_links_codec = FieldCodec.ForMessage<GameAccountLink>(130u, GameAccountLink.Parser);

		private readonly RepeatedField<GameAccountLink> links_ = new RepeatedField<GameAccountLink>();

		public const int ParentalControlInfoFieldNumber = 17;

		private ParentalControlInfo parentalControlInfo_;

		public static MessageParser<GetAccountResponse> Parser
		{
			get
			{
				return GetAccountResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountResponse.Descriptor;
			}
		}

		public AccountBlob Blob
		{
			get
			{
				return this.blob_;
			}
			set
			{
				this.blob_ = value;
			}
		}

		public AccountId Id
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

		public RepeatedField<string> Email
		{
			get
			{
				return this.email_;
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

		public string FullName
		{
			get
			{
				return this.fullName_;
			}
			set
			{
				this.fullName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public RepeatedField<GameAccountLink> Links
		{
			get
			{
				return this.links_;
			}
		}

		public ParentalControlInfo ParentalControlInfo
		{
			get
			{
				return this.parentalControlInfo_;
			}
			set
			{
				this.parentalControlInfo_ = value;
			}
		}

		public GetAccountResponse()
		{
		}

		public GetAccountResponse(GetAccountResponse other) : this()
		{
			while (true)
			{
				IL_E4:
				uint arg_C0_0 = 479651392u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C0_0 ^ 1281516825u)) % 6u)
					{
					case 0u:
						this.links_ = other.links_.Clone();
						arg_C0_0 = (num * 3462141348u ^ 1755973166u);
						continue;
					case 1u:
						this.Blob = ((other.blob_ != null) ? other.Blob.Clone() : null);
						arg_C0_0 = 102782118u;
						continue;
					case 2u:
						goto IL_E4;
					case 3u:
						this.ParentalControlInfo = ((other.parentalControlInfo_ != null) ? other.ParentalControlInfo.Clone() : null);
						arg_C0_0 = 1621667645u;
						continue;
					case 5u:
						this.Id = ((other.id_ != null) ? other.Id.Clone() : null);
						this.email_ = other.email_.Clone();
						this.battleTag_ = other.battleTag_;
						this.fullName_ = other.fullName_;
						arg_C0_0 = 367259481u;
						continue;
					}
					return;
				}
			}
		}

		public GetAccountResponse Clone()
		{
			return new GetAccountResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountResponse);
		}

		public bool Equals(GetAccountResponse other)
		{
			if (other == null)
			{
				goto IL_76;
			}
			goto IL_1CB;
			int arg_165_0;
			while (true)
			{
				IL_160:
				switch ((arg_165_0 ^ -54131751) % 19)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					arg_165_0 = ((!this.links_.Equals(other.links_)) ? -363934197 : -982048418);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_165_0 = (GetAccountResponse.smethod_1(this.FullName, other.FullName) ? -1859047777 : -577609901);
					continue;
				case 6:
					return false;
				case 7:
					goto IL_1CB;
				case 8:
					return false;
				case 9:
					arg_165_0 = (GetAccountResponse.smethod_1(this.BattleTag, other.BattleTag) ? -784918044 : -1632760735);
					continue;
				case 10:
					return false;
				case 11:
					arg_165_0 = (GetAccountResponse.smethod_0(this.Id, other.Id) ? -1570142478 : -561847734);
					continue;
				case 12:
					arg_165_0 = ((!GetAccountResponse.smethod_0(this.Blob, other.Blob)) ? -1547833582 : -1816023599);
					continue;
				case 13:
					goto IL_76;
				case 14:
					return false;
				case 15:
					arg_165_0 = (GetAccountResponse.smethod_0(this.ParentalControlInfo, other.ParentalControlInfo) ? -1401973885 : -621972691);
					continue;
				case 16:
					return false;
				case 18:
					arg_165_0 = ((!this.email_.Equals(other.email_)) ? -150233498 : -632775231);
					continue;
				}
				break;
			}
			return true;
			IL_76:
			arg_165_0 = -466090710;
			goto IL_160;
			IL_1CB:
			arg_165_0 = ((other == this) ? -2146376582 : -1560394186);
			goto IL_160;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1E6:
				uint arg_1A1_0 = 1261687381u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1A1_0 ^ 689187467u)) % 14u)
					{
					case 0u:
						num ^= GetAccountResponse.smethod_2(this.ParentalControlInfo);
						arg_1A1_0 = (num2 * 1827158351u ^ 422305972u);
						continue;
					case 2u:
						num ^= GetAccountResponse.smethod_2(this.email_);
						arg_1A1_0 = 2018948355u;
						continue;
					case 3u:
						num ^= GetAccountResponse.smethod_2(this.links_);
						arg_1A1_0 = 428135084u;
						continue;
					case 4u:
						arg_1A1_0 = (((this.blob_ == null) ? 4085702112u : 2240817162u) ^ num2 * 2546929943u);
						continue;
					case 5u:
						goto IL_1E6;
					case 6u:
						num ^= GetAccountResponse.smethod_2(this.FullName);
						arg_1A1_0 = (num2 * 1300329417u ^ 3524503772u);
						continue;
					case 7u:
						num ^= GetAccountResponse.smethod_2(this.BattleTag);
						arg_1A1_0 = (num2 * 3241925919u ^ 1869559610u);
						continue;
					case 8u:
						num ^= GetAccountResponse.smethod_2(this.Id);
						arg_1A1_0 = (num2 * 3309103230u ^ 579123001u);
						continue;
					case 9u:
						arg_1A1_0 = (((this.parentalControlInfo_ != null) ? 844261367u : 256005396u) ^ num2 * 2482038214u);
						continue;
					case 10u:
						arg_1A1_0 = ((GetAccountResponse.smethod_3(this.FullName) != 0) ? 77816953u : 491133662u);
						continue;
					case 11u:
						num ^= GetAccountResponse.smethod_2(this.Blob);
						arg_1A1_0 = (num2 * 4191679910u ^ 1600462720u);
						continue;
					case 12u:
						arg_1A1_0 = (((GetAccountResponse.smethod_3(this.BattleTag) == 0) ? 3991739005u : 2184565778u) ^ num2 * 139556476u);
						continue;
					case 13u:
						arg_1A1_0 = ((this.id_ == null) ? 959548257u : 1867189343u);
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
			if (this.blob_ != null)
			{
				goto IL_184;
			}
			goto IL_205;
			uint arg_1B1_0;
			while (true)
			{
				IL_1AC:
				uint num;
				switch ((num = (arg_1B1_0 ^ 2508102449u)) % 14u)
				{
				case 1u:
					output.WriteRawTag(90);
					output.WriteMessage(this.Blob);
					arg_1B1_0 = (num * 1866735970u ^ 4246894417u);
					continue;
				case 2u:
					goto IL_184;
				case 3u:
					arg_1B1_0 = ((GetAccountResponse.smethod_3(this.FullName) == 0) ? 4082869034u : 3608655385u);
					continue;
				case 4u:
					this.email_.WriteTo(output, GetAccountResponse._repeated_email_codec);
					arg_1B1_0 = ((GetAccountResponse.smethod_3(this.BattleTag) == 0) ? 4292127244u : 2153727368u);
					continue;
				case 5u:
					output.WriteRawTag(114);
					output.WriteString(this.BattleTag);
					arg_1B1_0 = (num * 394601763u ^ 3795556935u);
					continue;
				case 6u:
					output.WriteRawTag(122);
					output.WriteString(this.FullName);
					arg_1B1_0 = (num * 2916977120u ^ 2615298090u);
					continue;
				case 7u:
					this.links_.WriteTo(output, GetAccountResponse._repeated_links_codec);
					arg_1B1_0 = 2472828314u;
					continue;
				case 8u:
					goto IL_205;
				case 9u:
					output.WriteMessage(this.Id);
					arg_1B1_0 = (num * 3653663604u ^ 3923605011u);
					continue;
				case 10u:
					output.WriteRawTag(138, 1);
					arg_1B1_0 = (num * 216250869u ^ 266659751u);
					continue;
				case 11u:
					output.WriteRawTag(98);
					arg_1B1_0 = (num * 4290992709u ^ 1195913795u);
					continue;
				case 12u:
					output.WriteMessage(this.ParentalControlInfo);
					arg_1B1_0 = (num * 2388941305u ^ 1692789867u);
					continue;
				case 13u:
					arg_1B1_0 = (((this.parentalControlInfo_ != null) ? 4253279548u : 3539904296u) ^ num * 1475994117u);
					continue;
				}
				break;
			}
			return;
			IL_184:
			arg_1B1_0 = 3291191894u;
			goto IL_1AC;
			IL_205:
			arg_1B1_0 = ((this.id_ == null) ? 3476899431u : 4012930086u);
			goto IL_1AC;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.blob_ != null)
			{
				goto IL_5E;
			}
			goto IL_1C4;
			uint arg_178_0;
			while (true)
			{
				IL_173:
				uint num2;
				switch ((num2 = (arg_178_0 ^ 1730372379u)) % 12u)
				{
				case 1u:
					arg_178_0 = ((GetAccountResponse.smethod_3(this.FullName) == 0) ? 1025775248u : 1621150102u);
					continue;
				case 2u:
					num += this.email_.CalculateSize(GetAccountResponse._repeated_email_codec);
					arg_178_0 = ((GetAccountResponse.smethod_3(this.BattleTag) != 0) ? 626561552u : 1311549854u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
					arg_178_0 = (num2 * 3064277846u ^ 454720300u);
					continue;
				case 4u:
					goto IL_1C4;
				case 5u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.FullName);
					arg_178_0 = (num2 * 640624455u ^ 1598480011u);
					continue;
				case 6u:
					num += 2 + CodedOutputStream.ComputeMessageSize(this.ParentalControlInfo);
					arg_178_0 = (num2 * 1198731823u ^ 1833155529u);
					continue;
				case 7u:
					arg_178_0 = (((this.parentalControlInfo_ != null) ? 345939954u : 158128700u) ^ num2 * 3466193153u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
					arg_178_0 = (num2 * 1595871187u ^ 277859929u);
					continue;
				case 9u:
					goto IL_5E;
				case 10u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Blob);
					arg_178_0 = (num2 * 1667151040u ^ 1241352719u);
					continue;
				case 11u:
					num += this.links_.CalculateSize(GetAccountResponse._repeated_links_codec);
					arg_178_0 = 442576372u;
					continue;
				}
				break;
			}
			return num;
			IL_5E:
			arg_178_0 = 853500629u;
			goto IL_173;
			IL_1C4:
			arg_178_0 = ((this.id_ != null) ? 233851591u : 833399309u);
			goto IL_173;
		}

		public void MergeFrom(GetAccountResponse other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_2D1;
			uint arg_261_0;
			while (true)
			{
				IL_25C:
				uint num;
				switch ((num = (arg_261_0 ^ 2397362828u)) % 21u)
				{
				case 0u:
					this.links_.Add(other.links_);
					arg_261_0 = 2815985814u;
					continue;
				case 1u:
					this.parentalControlInfo_ = new ParentalControlInfo();
					arg_261_0 = (num * 3115925488u ^ 3058842625u);
					continue;
				case 2u:
					arg_261_0 = (((this.blob_ != null) ? 3977295776u : 2942386337u) ^ num * 1816651780u);
					continue;
				case 3u:
					arg_261_0 = (((GetAccountResponse.smethod_3(other.BattleTag) == 0) ? 1215152096u : 1604483164u) ^ num * 1234499639u);
					continue;
				case 4u:
					this.ParentalControlInfo.MergeFrom(other.ParentalControlInfo);
					arg_261_0 = 3836900061u;
					continue;
				case 5u:
					this.FullName = other.FullName;
					arg_261_0 = (num * 3959135758u ^ 3576130709u);
					continue;
				case 6u:
					arg_261_0 = ((other.id_ == null) ? 3594909369u : 4261921247u);
					continue;
				case 7u:
					arg_261_0 = ((GetAccountResponse.smethod_3(other.FullName) == 0) ? 4202723027u : 4279121033u);
					continue;
				case 8u:
					arg_261_0 = (((this.id_ == null) ? 3590348288u : 2628872039u) ^ num * 2388461246u);
					continue;
				case 10u:
					arg_261_0 = (((this.parentalControlInfo_ == null) ? 3000688374u : 4050319923u) ^ num * 2327021554u);
					continue;
				case 11u:
					arg_261_0 = (((other.parentalControlInfo_ == null) ? 2329168687u : 3139100319u) ^ num * 690466973u);
					continue;
				case 12u:
					this.id_ = new AccountId();
					arg_261_0 = (num * 1316791261u ^ 288449283u);
					continue;
				case 13u:
					goto IL_2D1;
				case 14u:
					this.Id.MergeFrom(other.Id);
					arg_261_0 = 3594909369u;
					continue;
				case 15u:
					this.blob_ = new AccountBlob();
					arg_261_0 = (num * 3962916789u ^ 991979929u);
					continue;
				case 16u:
					this.email_.Add(other.email_);
					arg_261_0 = 3758616554u;
					continue;
				case 17u:
					this.BattleTag = other.BattleTag;
					arg_261_0 = (num * 2247317993u ^ 3497045952u);
					continue;
				case 18u:
					return;
				case 19u:
					this.Blob.MergeFrom(other.Blob);
					arg_261_0 = 2622196731u;
					continue;
				case 20u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_261_0 = 2509255321u;
			goto IL_25C;
			IL_2D1:
			arg_261_0 = ((other.blob_ == null) ? 2622196731u : 4224406355u);
			goto IL_25C;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3EF:
				uint num;
				uint arg_353_0 = ((num = input.ReadTag()) != 0u) ? 3007706144u : 4155461288u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_353_0 ^ 2603989750u)) % 32u)
					{
					case 0u:
						arg_353_0 = (num2 * 2996609483u ^ 4028759764u);
						continue;
					case 1u:
						arg_353_0 = (((num != 98u) ? 2317189061u : 4026275928u) ^ num2 * 3279174933u);
						continue;
					case 2u:
						goto IL_3EF;
					case 3u:
						this.id_ = new AccountId();
						arg_353_0 = (num2 * 2291091017u ^ 2488680583u);
						continue;
					case 4u:
						arg_353_0 = (num2 * 1815957772u ^ 4038091044u);
						continue;
					case 5u:
						arg_353_0 = ((this.blob_ != null) ? 4210736891u : 3104335404u);
						continue;
					case 6u:
						arg_353_0 = (((num == 106u) ? 2438996744u : 3106865980u) ^ num2 * 2972184403u);
						continue;
					case 7u:
						input.ReadMessage(this.parentalControlInfo_);
						arg_353_0 = 3528790548u;
						continue;
					case 8u:
						arg_353_0 = ((num > 122u) ? 2947448445u : 3556524967u);
						continue;
					case 9u:
						arg_353_0 = (((num == 138u) ? 2236027406u : 4227820135u) ^ num2 * 542562905u);
						continue;
					case 10u:
						input.ReadMessage(this.id_);
						arg_353_0 = 3528790548u;
						continue;
					case 11u:
						arg_353_0 = ((num == 130u) ? 2889489765u : 3364919263u);
						continue;
					case 12u:
						this.email_.AddEntriesFrom(input, GetAccountResponse._repeated_email_codec);
						arg_353_0 = 2582074290u;
						continue;
					case 13u:
						input.ReadMessage(this.blob_);
						arg_353_0 = 3675929304u;
						continue;
					case 14u:
						arg_353_0 = (num2 * 1851863215u ^ 3485085030u);
						continue;
					case 15u:
						this.parentalControlInfo_ = new ParentalControlInfo();
						arg_353_0 = (num2 * 983197300u ^ 952587261u);
						continue;
					case 16u:
						input.SkipLastField();
						arg_353_0 = 3528790548u;
						continue;
					case 17u:
						arg_353_0 = (((num != 114u) ? 2269309509u : 3192992782u) ^ num2 * 1585834796u);
						continue;
					case 18u:
						arg_353_0 = (num2 * 3216014152u ^ 1290226742u);
						continue;
					case 19u:
						this.links_.AddEntriesFrom(input, GetAccountResponse._repeated_links_codec);
						arg_353_0 = 4142524843u;
						continue;
					case 20u:
						this.BattleTag = input.ReadString();
						arg_353_0 = 3528790548u;
						continue;
					case 21u:
						arg_353_0 = 3007706144u;
						continue;
					case 22u:
						arg_353_0 = ((num <= 106u) ? 3108291594u : 2583847518u);
						continue;
					case 23u:
						this.FullName = input.ReadString();
						arg_353_0 = 3361445046u;
						continue;
					case 24u:
						arg_353_0 = (num2 * 620073922u ^ 1361714902u);
						continue;
					case 25u:
						arg_353_0 = ((this.parentalControlInfo_ != null) ? 4133370545u : 2647163481u);
						continue;
					case 26u:
						this.blob_ = new AccountBlob();
						arg_353_0 = (num2 * 1276933077u ^ 3715895705u);
						continue;
					case 27u:
						arg_353_0 = ((this.id_ != null) ? 3966189980u : 3242264245u);
						continue;
					case 28u:
						arg_353_0 = (((num != 90u) ? 1685858999u : 55517043u) ^ num2 * 1632196280u);
						continue;
					case 29u:
						arg_353_0 = (num2 * 479623307u ^ 543672683u);
						continue;
					case 31u:
						arg_353_0 = (((num != 122u) ? 3626143661u : 3845980552u) ^ num2 * 3399046487u);
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
