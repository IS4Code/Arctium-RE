using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscriberReference : IMessage<SubscriberReference>, IEquatable<SubscriberReference>, IDeepCloneable<SubscriberReference>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscriberReference.__c __9 = new SubscriberReference.__c();

			internal SubscriberReference cctor>b__54_0()
			{
				return new SubscriberReference();
			}
		}

		private static readonly MessageParser<SubscriberReference> _parser = new MessageParser<SubscriberReference>(new Func<SubscriberReference>(SubscriberReference.__c.__9.<.cctor>b__54_0));

		public const int ObjectIdFieldNumber = 1;

		private ulong objectId_;

		public const int EntityIdFieldNumber = 2;

		private EntityId entityId_;

		public const int AccountOptionsFieldNumber = 3;

		private AccountFieldOptions accountOptions_;

		public const int AccountTagsFieldNumber = 4;

		private AccountFieldTags accountTags_;

		public const int GameAccountOptionsFieldNumber = 5;

		private GameAccountFieldOptions gameAccountOptions_;

		public const int GameAccountTagsFieldNumber = 6;

		private GameAccountFieldTags gameAccountTags_;

		public const int SubscriberIdFieldNumber = 7;

		private ulong subscriberId_;

		public static MessageParser<SubscriberReference> Parser
		{
			get
			{
				return SubscriberReference._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[17];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriberReference.Descriptor;
			}
		}

		public ulong ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		public AccountFieldOptions AccountOptions
		{
			get
			{
				return this.accountOptions_;
			}
			set
			{
				this.accountOptions_ = value;
			}
		}

		public AccountFieldTags AccountTags
		{
			get
			{
				return this.accountTags_;
			}
			set
			{
				this.accountTags_ = value;
			}
		}

		public GameAccountFieldOptions GameAccountOptions
		{
			get
			{
				return this.gameAccountOptions_;
			}
			set
			{
				this.gameAccountOptions_ = value;
			}
		}

		public GameAccountFieldTags GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
			set
			{
				this.gameAccountTags_ = value;
			}
		}

		public ulong SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		public SubscriberReference()
		{
		}

		public SubscriberReference(SubscriberReference other) : this()
		{
			while (true)
			{
				IL_113:
				uint arg_EB_0 = 3878078354u;
				while (true)
				{
					uint num;
					switch ((num = (arg_EB_0 ^ 3470425393u)) % 7u)
					{
					case 0u:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						this.AccountOptions = ((other.accountOptions_ != null) ? other.AccountOptions.Clone() : null);
						arg_EB_0 = 4042412614u;
						continue;
					case 1u:
						this.AccountTags = ((other.accountTags_ != null) ? other.AccountTags.Clone() : null);
						this.GameAccountOptions = ((other.gameAccountOptions_ != null) ? other.GameAccountOptions.Clone() : null);
						arg_EB_0 = 3626625434u;
						continue;
					case 2u:
						goto IL_113;
					case 3u:
						this.objectId_ = other.objectId_;
						arg_EB_0 = (num * 938022077u ^ 615892570u);
						continue;
					case 4u:
						this.GameAccountTags = ((other.gameAccountTags_ != null) ? other.GameAccountTags.Clone() : null);
						arg_EB_0 = 3265104969u;
						continue;
					case 6u:
						this.subscriberId_ = other.subscriberId_;
						arg_EB_0 = (num * 899562094u ^ 3834362183u);
						continue;
					}
					return;
				}
			}
		}

		public SubscriberReference Clone()
		{
			return new SubscriberReference(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriberReference);
		}

		public bool Equals(SubscriberReference other)
		{
			if (other == null)
			{
				goto IL_A8;
			}
			goto IL_1C1;
			int arg_15B_0;
			while (true)
			{
				IL_156:
				switch ((arg_15B_0 ^ 870814755) % 19)
				{
				case 0:
					return false;
				case 1:
					arg_15B_0 = ((this.SubscriberId != other.SubscriberId) ? 1604103459 : 1755470665);
					continue;
				case 2:
					arg_15B_0 = ((!SubscriberReference.smethod_0(this.EntityId, other.EntityId)) ? 436012102 : 969436390);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_1C1;
				case 5:
					return false;
				case 7:
					return false;
				case 8:
					return true;
				case 9:
					arg_15B_0 = (SubscriberReference.smethod_0(this.GameAccountOptions, other.GameAccountOptions) ? 2095258153 : 1341487181);
					continue;
				case 10:
					arg_15B_0 = ((this.ObjectId != other.ObjectId) ? 1312054081 : 542836266);
					continue;
				case 11:
					return false;
				case 12:
					goto IL_A8;
				case 13:
					arg_15B_0 = (SubscriberReference.smethod_0(this.AccountTags, other.AccountTags) ? 1370294590 : 195704075);
					continue;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					return false;
				case 17:
					arg_15B_0 = (SubscriberReference.smethod_0(this.AccountOptions, other.AccountOptions) ? 1643919212 : 1657169448);
					continue;
				case 18:
					arg_15B_0 = ((!SubscriberReference.smethod_0(this.GameAccountTags, other.GameAccountTags)) ? 1327796316 : 969703822);
					continue;
				}
				break;
			}
			return true;
			IL_A8:
			arg_15B_0 = 1708178656;
			goto IL_156;
			IL_1C1:
			arg_15B_0 = ((other != this) ? 82528247 : 1423204394);
			goto IL_156;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.ObjectId != 0uL)
			{
				goto IL_7F;
			}
			goto IL_212;
			uint arg_1BA_0;
			while (true)
			{
				IL_1B5:
				uint num2;
				switch ((num2 = (arg_1BA_0 ^ 592738820u)) % 15u)
				{
				case 0u:
					arg_1BA_0 = ((this.gameAccountTags_ == null) ? 2079259792u : 385679097u);
					continue;
				case 1u:
					arg_1BA_0 = ((this.SubscriberId == 0uL) ? 972815222u : 1071404103u);
					continue;
				case 2u:
					arg_1BA_0 = ((this.accountTags_ == null) ? 734258142u : 406506927u);
					continue;
				case 3u:
					num ^= this.ObjectId.GetHashCode();
					arg_1BA_0 = (num2 * 3966838733u ^ 2697437654u);
					continue;
				case 4u:
					arg_1BA_0 = ((this.accountOptions_ != null) ? 1818570295u : 1880306154u);
					continue;
				case 5u:
					arg_1BA_0 = ((this.gameAccountOptions_ == null) ? 1460870444u : 717026280u);
					continue;
				case 6u:
					num ^= this.GameAccountTags.GetHashCode();
					arg_1BA_0 = (num2 * 113704632u ^ 4113459016u);
					continue;
				case 7u:
					num ^= this.SubscriberId.GetHashCode();
					arg_1BA_0 = (num2 * 878328212u ^ 2305708746u);
					continue;
				case 8u:
					num ^= this.AccountOptions.GetHashCode();
					arg_1BA_0 = (num2 * 408402000u ^ 3914384922u);
					continue;
				case 10u:
					goto IL_7F;
				case 11u:
					goto IL_212;
				case 12u:
					num ^= this.EntityId.GetHashCode();
					arg_1BA_0 = (num2 * 2490094956u ^ 1587940659u);
					continue;
				case 13u:
					num ^= this.AccountTags.GetHashCode();
					arg_1BA_0 = (num2 * 568100481u ^ 3810651381u);
					continue;
				case 14u:
					num ^= this.GameAccountOptions.GetHashCode();
					arg_1BA_0 = (num2 * 2954621190u ^ 2789046948u);
					continue;
				}
				break;
			}
			return num;
			IL_7F:
			arg_1BA_0 = 1542418902u;
			goto IL_1B5;
			IL_212:
			arg_1BA_0 = ((this.entityId_ == null) ? 608945671u : 746312435u);
			goto IL_1B5;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.ObjectId != 0uL)
			{
				goto IL_1C8;
			}
			goto IL_2B4;
			uint arg_244_0;
			while (true)
			{
				IL_23F:
				uint num;
				switch ((num = (arg_244_0 ^ 3837819567u)) % 21u)
				{
				case 0u:
					arg_244_0 = ((this.gameAccountTags_ == null) ? 3726325411u : 3343218632u);
					continue;
				case 2u:
					output.WriteMessage(this.EntityId);
					arg_244_0 = (num * 2848878748u ^ 2535032651u);
					continue;
				case 3u:
					output.WriteMessage(this.AccountOptions);
					arg_244_0 = (num * 4287549339u ^ 1484796846u);
					continue;
				case 4u:
					output.WriteMessage(this.GameAccountTags);
					arg_244_0 = (num * 4121922236u ^ 483301287u);
					continue;
				case 5u:
					goto IL_1C8;
				case 6u:
					output.WriteUInt64(this.ObjectId);
					arg_244_0 = (num * 898961383u ^ 4100560217u);
					continue;
				case 7u:
					arg_244_0 = ((this.accountOptions_ == null) ? 3308872219u : 2650864916u);
					continue;
				case 8u:
					output.WriteRawTag(50);
					arg_244_0 = (num * 823222386u ^ 3754626430u);
					continue;
				case 9u:
					arg_244_0 = ((this.accountTags_ == null) ? 2562729434u : 3160356357u);
					continue;
				case 10u:
					output.WriteRawTag(8);
					arg_244_0 = (num * 4249088849u ^ 968670116u);
					continue;
				case 11u:
					output.WriteRawTag(42);
					output.WriteMessage(this.GameAccountOptions);
					arg_244_0 = (num * 1005051892u ^ 2775988075u);
					continue;
				case 12u:
					arg_244_0 = ((this.gameAccountOptions_ != null) ? 2328243937u : 3366746931u);
					continue;
				case 13u:
					goto IL_2B4;
				case 14u:
					arg_244_0 = ((this.SubscriberId != 0uL) ? 2817225217u : 3291656603u);
					continue;
				case 15u:
					output.WriteRawTag(26);
					arg_244_0 = (num * 3851038369u ^ 2915962075u);
					continue;
				case 16u:
					output.WriteRawTag(56);
					arg_244_0 = (num * 3274550153u ^ 238216296u);
					continue;
				case 17u:
					output.WriteMessage(this.AccountTags);
					arg_244_0 = (num * 4123879329u ^ 829169099u);
					continue;
				case 18u:
					output.WriteUInt64(this.SubscriberId);
					arg_244_0 = (num * 3606109994u ^ 1131832577u);
					continue;
				case 19u:
					output.WriteRawTag(34);
					arg_244_0 = (num * 1929795798u ^ 2456274626u);
					continue;
				case 20u:
					output.WriteRawTag(18);
					arg_244_0 = (num * 879265307u ^ 271929368u);
					continue;
				}
				break;
			}
			return;
			IL_1C8:
			arg_244_0 = 3039430438u;
			goto IL_23F;
			IL_2B4:
			arg_244_0 = ((this.entityId_ == null) ? 3261736603u : 4218128622u);
			goto IL_23F;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.ObjectId != 0uL)
			{
				goto IL_85;
			}
			goto IL_217;
			uint arg_1BF_0;
			while (true)
			{
				IL_1BA:
				uint num2;
				switch ((num2 = (arg_1BF_0 ^ 4192880492u)) % 15u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountOptions);
					arg_1BF_0 = (num2 * 212289971u ^ 4091149460u);
					continue;
				case 2u:
					arg_1BF_0 = ((this.gameAccountTags_ == null) ? 3678693706u : 4076523319u);
					continue;
				case 3u:
					arg_1BF_0 = ((this.gameAccountOptions_ != null) ? 2255529217u : 3340868515u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
					arg_1BF_0 = (num2 * 1103076458u ^ 3595335354u);
					continue;
				case 5u:
					arg_1BF_0 = ((this.accountOptions_ == null) ? 2683183342u : 3282706528u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
					arg_1BF_0 = (num2 * 3082325268u ^ 3018886381u);
					continue;
				case 7u:
					arg_1BF_0 = ((this.SubscriberId != 0uL) ? 2938186093u : 2542746578u);
					continue;
				case 8u:
					goto IL_217;
				case 9u:
					arg_1BF_0 = ((this.accountTags_ != null) ? 2999580672u : 4115358722u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
					arg_1BF_0 = (num2 * 3902378888u ^ 89733210u);
					continue;
				case 11u:
					goto IL_85;
				case 12u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountOptions);
					arg_1BF_0 = (num2 * 179257675u ^ 3419544682u);
					continue;
				case 13u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
					arg_1BF_0 = (num2 * 1375376437u ^ 1749332975u);
					continue;
				case 14u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountTags);
					arg_1BF_0 = (num2 * 2240860530u ^ 3181079244u);
					continue;
				}
				break;
			}
			return num;
			IL_85:
			arg_1BF_0 = 3396263625u;
			goto IL_1BA;
			IL_217:
			arg_1BF_0 = ((this.entityId_ == null) ? 3542491260u : 3076830923u);
			goto IL_1BA;
		}

		public void MergeFrom(SubscriberReference other)
		{
			if (other == null)
			{
				goto IL_209;
			}
			goto IL_3A9;
			uint arg_321_0;
			while (true)
			{
				IL_31C:
				uint num;
				switch ((num = (arg_321_0 ^ 3320593627u)) % 27u)
				{
				case 0u:
					this.gameAccountOptions_ = new GameAccountFieldOptions();
					arg_321_0 = (num * 1913329696u ^ 2945321162u);
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_3A9;
				case 3u:
					this.gameAccountTags_ = new GameAccountFieldTags();
					arg_321_0 = (num * 1797178590u ^ 1805039602u);
					continue;
				case 4u:
					arg_321_0 = (((this.gameAccountOptions_ != null) ? 250204746u : 1268926348u) ^ num * 2008660328u);
					continue;
				case 5u:
					this.accountTags_ = new AccountFieldTags();
					arg_321_0 = (num * 1309407819u ^ 2912128883u);
					continue;
				case 6u:
					this.GameAccountTags.MergeFrom(other.GameAccountTags);
					arg_321_0 = 3674878443u;
					continue;
				case 7u:
					arg_321_0 = ((other.gameAccountTags_ == null) ? 3674878443u : 3980489486u);
					continue;
				case 8u:
					arg_321_0 = (((this.entityId_ == null) ? 2701348995u : 3013348219u) ^ num * 645978031u);
					continue;
				case 9u:
					arg_321_0 = (((this.accountOptions_ != null) ? 3388698257u : 2341267386u) ^ num * 3615023683u);
					continue;
				case 10u:
					goto IL_209;
				case 11u:
					this.SubscriberId = other.SubscriberId;
					arg_321_0 = (num * 3220385875u ^ 2911180766u);
					continue;
				case 12u:
					arg_321_0 = ((other.accountOptions_ == null) ? 3013309846u : 3271423113u);
					continue;
				case 13u:
					this.AccountTags.MergeFrom(other.AccountTags);
					arg_321_0 = 3542425967u;
					continue;
				case 14u:
					this.GameAccountOptions.MergeFrom(other.GameAccountOptions);
					arg_321_0 = 2564978985u;
					continue;
				case 15u:
					arg_321_0 = ((other.accountTags_ != null) ? 2165806342u : 3542425967u);
					continue;
				case 16u:
					arg_321_0 = (((this.gameAccountTags_ != null) ? 1091015560u : 1937602327u) ^ num * 1130034142u);
					continue;
				case 18u:
					this.AccountOptions.MergeFrom(other.AccountOptions);
					arg_321_0 = 3013309846u;
					continue;
				case 19u:
					this.ObjectId = other.ObjectId;
					arg_321_0 = (num * 2538767675u ^ 1587528258u);
					continue;
				case 20u:
					this.entityId_ = new EntityId();
					arg_321_0 = (num * 1618110388u ^ 1248278375u);
					continue;
				case 21u:
					arg_321_0 = ((other.SubscriberId != 0uL) ? 2583428730u : 2206227949u);
					continue;
				case 22u:
					arg_321_0 = (((this.accountTags_ != null) ? 3989176164u : 2709918700u) ^ num * 404614675u);
					continue;
				case 23u:
					this.accountOptions_ = new AccountFieldOptions();
					arg_321_0 = (num * 737848842u ^ 3103570177u);
					continue;
				case 24u:
					arg_321_0 = ((other.gameAccountOptions_ != null) ? 3565125863u : 2564978985u);
					continue;
				case 25u:
					arg_321_0 = ((other.entityId_ != null) ? 3761599599u : 3707722186u);
					continue;
				case 26u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_321_0 = 3707722186u;
					continue;
				}
				break;
			}
			return;
			IL_209:
			arg_321_0 = 2922007502u;
			goto IL_31C;
			IL_3A9:
			arg_321_0 = ((other.ObjectId != 0uL) ? 2576940158u : 2689064261u);
			goto IL_31C;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_486:
				uint num;
				uint arg_3D6_0 = ((num = input.ReadTag()) == 0u) ? 2820348397u : 2797522979u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3D6_0 ^ 2884098913u)) % 37u)
					{
					case 0u:
						this.accountTags_ = new AccountFieldTags();
						arg_3D6_0 = (num2 * 254400894u ^ 1097125908u);
						continue;
					case 1u:
						input.ReadMessage(this.accountOptions_);
						arg_3D6_0 = 2382951512u;
						continue;
					case 2u:
						arg_3D6_0 = ((num > 26u) ? 3217443451u : 3683950347u);
						continue;
					case 3u:
						arg_3D6_0 = (num2 * 1379385328u ^ 2780347387u);
						continue;
					case 4u:
						arg_3D6_0 = (((num != 18u) ? 3744474575u : 3267580135u) ^ num2 * 39241765u);
						continue;
					case 5u:
						arg_3D6_0 = ((num != 50u) ? 3533704238u : 2258309840u);
						continue;
					case 7u:
						this.gameAccountTags_ = new GameAccountFieldTags();
						arg_3D6_0 = (num2 * 2822986582u ^ 1731809301u);
						continue;
					case 8u:
						arg_3D6_0 = (num2 * 2359930653u ^ 1275683083u);
						continue;
					case 9u:
						arg_3D6_0 = (((num != 26u) ? 2452474370u : 2561095841u) ^ num2 * 1419572983u);
						continue;
					case 10u:
						input.ReadMessage(this.gameAccountOptions_);
						arg_3D6_0 = 4085691931u;
						continue;
					case 11u:
						input.ReadMessage(this.accountTags_);
						arg_3D6_0 = 3248037702u;
						continue;
					case 12u:
						this.entityId_ = new EntityId();
						arg_3D6_0 = (num2 * 2611487500u ^ 3495333278u);
						continue;
					case 13u:
						this.gameAccountOptions_ = new GameAccountFieldOptions();
						arg_3D6_0 = (num2 * 531221204u ^ 3468462154u);
						continue;
					case 14u:
						arg_3D6_0 = ((num <= 42u) ? 3806467273u : 3069250588u);
						continue;
					case 15u:
						arg_3D6_0 = (num2 * 740595601u ^ 330461745u);
						continue;
					case 16u:
						input.ReadMessage(this.entityId_);
						arg_3D6_0 = 3485358077u;
						continue;
					case 17u:
						arg_3D6_0 = (num2 * 1583982753u ^ 1070572410u);
						continue;
					case 18u:
						arg_3D6_0 = 2797522979u;
						continue;
					case 19u:
						this.ObjectId = input.ReadUInt64();
						arg_3D6_0 = 3485358077u;
						continue;
					case 20u:
						goto IL_486;
					case 21u:
						this.SubscriberId = input.ReadUInt64();
						arg_3D6_0 = 3485358077u;
						continue;
					case 22u:
						arg_3D6_0 = (((num == 8u) ? 1620283286u : 1885571492u) ^ num2 * 1378070929u);
						continue;
					case 23u:
						arg_3D6_0 = ((this.accountOptions_ != null) ? 2232383629u : 2753369266u);
						continue;
					case 24u:
						arg_3D6_0 = ((this.gameAccountOptions_ == null) ? 3226156196u : 3097684334u);
						continue;
					case 25u:
						arg_3D6_0 = (((num != 56u) ? 381296148u : 382255902u) ^ num2 * 1394114657u);
						continue;
					case 26u:
						arg_3D6_0 = (((num != 34u) ? 2798400557u : 3366885643u) ^ num2 * 3885296992u);
						continue;
					case 27u:
						input.ReadMessage(this.gameAccountTags_);
						arg_3D6_0 = 3054229716u;
						continue;
					case 28u:
						arg_3D6_0 = ((this.accountTags_ == null) ? 3999106284u : 2620021874u);
						continue;
					case 29u:
						this.accountOptions_ = new AccountFieldOptions();
						arg_3D6_0 = (num2 * 299184746u ^ 219102163u);
						continue;
					case 30u:
						arg_3D6_0 = ((this.gameAccountTags_ == null) ? 2264522488u : 3559330931u);
						continue;
					case 31u:
						arg_3D6_0 = (num2 * 1466308959u ^ 2882198971u);
						continue;
					case 32u:
						arg_3D6_0 = (num2 * 596152625u ^ 1383138580u);
						continue;
					case 33u:
						arg_3D6_0 = (num2 * 2073714541u ^ 1258416364u);
						continue;
					case 34u:
						input.SkipLastField();
						arg_3D6_0 = 3094751631u;
						continue;
					case 35u:
						arg_3D6_0 = (((num != 42u) ? 945908855u : 134834932u) ^ num2 * 1128666773u);
						continue;
					case 36u:
						arg_3D6_0 = ((this.entityId_ != null) ? 2254539982u : 3439624829u);
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
	}
}
