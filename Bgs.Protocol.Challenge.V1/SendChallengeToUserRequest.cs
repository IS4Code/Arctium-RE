using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class SendChallengeToUserRequest : IMessage<SendChallengeToUserRequest>, IEquatable<SendChallengeToUserRequest>, IDeepCloneable<SendChallengeToUserRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendChallengeToUserRequest.__c __9 = new SendChallengeToUserRequest.__c();

			internal SendChallengeToUserRequest cctor>b__59_0()
			{
				return new SendChallengeToUserRequest();
			}
		}

		private static readonly MessageParser<SendChallengeToUserRequest> _parser = new MessageParser<SendChallengeToUserRequest>(new Func<SendChallengeToUserRequest>(SendChallengeToUserRequest.__c.__9.<.cctor>b__59_0));

		public const int PeerIdFieldNumber = 1;

		private ProcessId peerId_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int ChallengesFieldNumber = 3;

		private static readonly FieldCodec<Challenge> _repeated_challenges_codec;

		private readonly RepeatedField<Challenge> challenges_ = new RepeatedField<Challenge>();

		public const int ContextFieldNumber = 4;

		private uint context_;

		public const int TimeoutFieldNumber = 5;

		private ulong timeout_;

		public const int AttributesFieldNumber = 6;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attributes_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attributes_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int HostFieldNumber = 7;

		private ProcessId host_;

		public const int AccountIdFieldNumber = 8;

		private EntityId accountId_;

		public static MessageParser<SendChallengeToUserRequest> Parser
		{
			get
			{
				return SendChallengeToUserRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendChallengeToUserRequest.Descriptor;
			}
		}

		public ProcessId PeerId
		{
			get
			{
				return this.peerId_;
			}
			set
			{
				this.peerId_ = value;
			}
		}

		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		public RepeatedField<Challenge> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		public uint Context
		{
			get
			{
				return this.context_;
			}
			set
			{
				this.context_ = value;
			}
		}

		public ulong Timeout
		{
			get
			{
				return this.timeout_;
			}
			set
			{
				this.timeout_ = value;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
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

		public SendChallengeToUserRequest()
		{
		}

		public SendChallengeToUserRequest(SendChallengeToUserRequest other) : this()
		{
			this.PeerId = ((other.peerId_ != null) ? other.PeerId.Clone() : null);
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.challenges_ = other.challenges_.Clone();
			this.context_ = other.context_;
			this.timeout_ = other.timeout_;
			this.attributes_ = other.attributes_.Clone();
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
		}

		public SendChallengeToUserRequest Clone()
		{
			return new SendChallengeToUserRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendChallengeToUserRequest);
		}

		public bool Equals(SendChallengeToUserRequest other)
		{
			if (other == null)
			{
				goto IL_D2;
			}
			goto IL_1F8;
			int arg_18A_0;
			while (true)
			{
				IL_185:
				switch ((arg_18A_0 ^ 816392964) % 21)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_18A_0 = ((this.Timeout == other.Timeout) ? 1973683729 : 148476780);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_18A_0 = (this.challenges_.Equals(other.challenges_) ? 805276243 : 2119394059);
					continue;
				case 6:
					return false;
				case 7:
					arg_18A_0 = (SendChallengeToUserRequest.smethod_0(this.AccountId, other.AccountId) ? 1555641405 : 1101387317);
					continue;
				case 8:
					arg_18A_0 = ((!SendChallengeToUserRequest.smethod_0(this.GameAccountId, other.GameAccountId)) ? 1528555393 : 702295765);
					continue;
				case 9:
					return false;
				case 10:
					goto IL_D2;
				case 11:
					goto IL_1F8;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					arg_18A_0 = (SendChallengeToUserRequest.smethod_0(this.Host, other.Host) ? 1505249358 : 117806071);
					continue;
				case 15:
					return true;
				case 16:
					arg_18A_0 = ((!this.attributes_.Equals(other.attributes_)) ? 710476854 : 347249981);
					continue;
				case 17:
					arg_18A_0 = ((this.Context == other.Context) ? 321762354 : 1765115181);
					continue;
				case 18:
					arg_18A_0 = (SendChallengeToUserRequest.smethod_0(this.PeerId, other.PeerId) ? 91940777 : 1659164101);
					continue;
				case 19:
					return false;
				}
				break;
			}
			return true;
			IL_D2:
			arg_18A_0 = 393889798;
			goto IL_185;
			IL_1F8:
			arg_18A_0 = ((other != this) ? 390114534 : 1676343103);
			goto IL_185;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.peerId_ != null)
			{
				goto IL_152;
			}
			goto IL_1CD;
			uint arg_17D_0;
			while (true)
			{
				IL_178:
				uint num2;
				switch ((num2 = (arg_17D_0 ^ 1469526432u)) % 13u)
				{
				case 1u:
					arg_17D_0 = ((this.accountId_ != null) ? 430245170u : 952864368u);
					continue;
				case 2u:
					goto IL_152;
				case 3u:
					num ^= this.Context.GetHashCode();
					arg_17D_0 = (num2 * 1594817049u ^ 4017173347u);
					continue;
				case 4u:
					num ^= SendChallengeToUserRequest.smethod_1(this.challenges_);
					arg_17D_0 = 1250183453u;
					continue;
				case 5u:
					num ^= this.Timeout.GetHashCode();
					arg_17D_0 = (num2 * 3849238828u ^ 196421032u);
					continue;
				case 6u:
					num ^= SendChallengeToUserRequest.smethod_1(this.GameAccountId);
					arg_17D_0 = (num2 * 2094139658u ^ 1429997788u);
					continue;
				case 7u:
					arg_17D_0 = (((this.Timeout != 0uL) ? 685310268u : 1850228172u) ^ num2 * 2038103430u);
					continue;
				case 8u:
					goto IL_1CD;
				case 9u:
					num ^= this.attributes_.GetHashCode();
					arg_17D_0 = ((this.host_ != null) ? 1441635804u : 2268952u);
					continue;
				case 10u:
					num ^= this.AccountId.GetHashCode();
					arg_17D_0 = (num2 * 3203737752u ^ 3372976320u);
					continue;
				case 11u:
					num ^= SendChallengeToUserRequest.smethod_1(this.PeerId);
					arg_17D_0 = (num2 * 2827307540u ^ 3774910836u);
					continue;
				case 12u:
					num ^= this.Host.GetHashCode();
					arg_17D_0 = (num2 * 3756368091u ^ 428445964u);
					continue;
				}
				break;
			}
			return num;
			IL_152:
			arg_17D_0 = 673712767u;
			goto IL_178;
			IL_1CD:
			arg_17D_0 = ((this.gameAccountId_ == null) ? 1301436228u : 552034812u);
			goto IL_178;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.peerId_ != null)
			{
				goto IL_17F;
			}
			goto IL_25D;
			uint arg_1F9_0;
			while (true)
			{
				IL_1F4:
				uint num;
				switch ((num = (arg_1F9_0 ^ 955934729u)) % 18u)
				{
				case 0u:
					output.WriteMessage(this.Host);
					arg_1F9_0 = (num * 2864177080u ^ 4245169873u);
					continue;
				case 1u:
					output.WriteMessage(this.AccountId);
					arg_1F9_0 = (num * 1219684917u ^ 339204139u);
					continue;
				case 2u:
					output.WriteRawTag(58);
					arg_1F9_0 = (num * 3952257102u ^ 1552132723u);
					continue;
				case 3u:
					output.WriteRawTag(18);
					output.WriteMessage(this.GameAccountId);
					arg_1F9_0 = (num * 23210236u ^ 4238181025u);
					continue;
				case 4u:
					goto IL_17F;
				case 5u:
					output.WriteUInt64(this.Timeout);
					arg_1F9_0 = (num * 1502014313u ^ 2491244335u);
					continue;
				case 6u:
					output.WriteRawTag(40);
					arg_1F9_0 = (num * 3149943451u ^ 1360100766u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					arg_1F9_0 = (num * 1921872438u ^ 2561342248u);
					continue;
				case 8u:
					arg_1F9_0 = ((this.accountId_ == null) ? 1552866474u : 390361845u);
					continue;
				case 9u:
					arg_1F9_0 = (((this.Timeout != 0uL) ? 4157300384u : 3926136477u) ^ num * 2811803877u);
					continue;
				case 10u:
					this.challenges_.WriteTo(output, SendChallengeToUserRequest._repeated_challenges_codec);
					output.WriteRawTag(37);
					arg_1F9_0 = 1267132571u;
					continue;
				case 11u:
					output.WriteMessage(this.PeerId);
					arg_1F9_0 = (num * 3157523864u ^ 2914234364u);
					continue;
				case 12u:
					output.WriteFixed32(this.Context);
					arg_1F9_0 = (num * 1346696627u ^ 3704766764u);
					continue;
				case 14u:
					output.WriteRawTag(66);
					arg_1F9_0 = (num * 2513242981u ^ 286329848u);
					continue;
				case 15u:
					this.attributes_.WriteTo(output, SendChallengeToUserRequest._repeated_attributes_codec);
					arg_1F9_0 = 1009243425u;
					continue;
				case 16u:
					arg_1F9_0 = (((this.host_ == null) ? 2172956529u : 3234786095u) ^ num * 1682611006u);
					continue;
				case 17u:
					goto IL_25D;
				}
				break;
			}
			return;
			IL_17F:
			arg_1F9_0 = 681367556u;
			goto IL_1F4;
			IL_25D:
			arg_1F9_0 = ((this.gameAccountId_ != null) ? 1310861030u : 324831717u);
			goto IL_1F4;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1F7:
				uint arg_1B2_0 = 4277040145u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1B2_0 ^ 4261678620u)) % 14u)
					{
					case 0u:
						goto IL_1F7;
					case 2u:
						arg_1B2_0 = (((this.host_ == null) ? 1905378242u : 1360465286u) ^ num2 * 169161333u);
						continue;
					case 3u:
						arg_1B2_0 = (((this.peerId_ != null) ? 2309856662u : 4221978431u) ^ num2 * 2553749829u);
						continue;
					case 4u:
						arg_1B2_0 = ((this.accountId_ != null) ? 3904465319u : 4048428569u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_1B2_0 = (num2 * 738502519u ^ 317467380u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_1B2_0 = (num2 * 1227799301u ^ 351687520u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.PeerId);
						arg_1B2_0 = (num2 * 3574357804u ^ 3703084890u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_1B2_0 = (num2 * 1366126951u ^ 3821280909u);
						continue;
					case 9u:
						num += this.challenges_.CalculateSize(SendChallengeToUserRequest._repeated_challenges_codec);
						num += 5;
						arg_1B2_0 = 4280288494u;
						continue;
					case 10u:
						arg_1B2_0 = ((this.gameAccountId_ != null) ? 3056721470u : 3443237155u);
						continue;
					case 11u:
						num += this.attributes_.CalculateSize(SendChallengeToUserRequest._repeated_attributes_codec);
						arg_1B2_0 = 2626270988u;
						continue;
					case 12u:
						arg_1B2_0 = (((this.Timeout != 0uL) ? 307235245u : 1926437689u) ^ num2 * 119794727u);
						continue;
					case 13u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Timeout);
						arg_1B2_0 = (num2 * 1424215640u ^ 244967887u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(SendChallengeToUserRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_346;
			uint arg_2CA_0;
			while (true)
			{
				IL_2C5:
				uint num;
				switch ((num = (arg_2CA_0 ^ 2413271149u)) % 24u)
				{
				case 0u:
					arg_2CA_0 = ((other.accountId_ == null) ? 3313360130u : 3632322190u);
					continue;
				case 1u:
					arg_2CA_0 = (((this.gameAccountId_ == null) ? 398630482u : 2020060101u) ^ num * 1372634115u);
					continue;
				case 2u:
					this.accountId_ = new EntityId();
					arg_2CA_0 = (num * 2843947674u ^ 3614761691u);
					continue;
				case 3u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_2CA_0 = 3190399691u;
					continue;
				case 4u:
					this.Context = other.Context;
					arg_2CA_0 = (num * 3455852336u ^ 2579632816u);
					continue;
				case 5u:
					this.peerId_ = new ProcessId();
					arg_2CA_0 = (num * 3844646213u ^ 2750565969u);
					continue;
				case 6u:
					arg_2CA_0 = (((this.peerId_ == null) ? 3636307108u : 3277677204u) ^ num * 1633066382u);
					continue;
				case 8u:
					this.Host.MergeFrom(other.Host);
					arg_2CA_0 = 2820718261u;
					continue;
				case 9u:
					this.attributes_.Add(other.attributes_);
					arg_2CA_0 = ((other.host_ == null) ? 2820718261u : 4244212060u);
					continue;
				case 10u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_2CA_0 = 3313360130u;
					continue;
				case 11u:
					arg_2CA_0 = (((this.accountId_ == null) ? 2850665524u : 2189101812u) ^ num * 3660117225u);
					continue;
				case 12u:
					this.gameAccountId_ = new EntityId();
					arg_2CA_0 = (num * 1210595705u ^ 3500073690u);
					continue;
				case 13u:
					arg_2CA_0 = ((other.Timeout == 0uL) ? 2429696588u : 4274268070u);
					continue;
				case 14u:
					this.challenges_.Add(other.challenges_);
					arg_2CA_0 = 3539660549u;
					continue;
				case 15u:
					goto IL_346;
				case 16u:
					arg_2CA_0 = (((other.Context != 0u) ? 1436063009u : 737944080u) ^ num * 3919293836u);
					continue;
				case 17u:
					arg_2CA_0 = (((this.host_ == null) ? 3478300605u : 2331119807u) ^ num * 1742705426u);
					continue;
				case 18u:
					this.host_ = new ProcessId();
					arg_2CA_0 = (num * 49937716u ^ 3084086821u);
					continue;
				case 19u:
					this.Timeout = other.Timeout;
					arg_2CA_0 = (num * 1372806293u ^ 2825826155u);
					continue;
				case 20u:
					arg_2CA_0 = ((other.gameAccountId_ != null) ? 4242529956u : 3190399691u);
					continue;
				case 21u:
					this.PeerId.MergeFrom(other.PeerId);
					arg_2CA_0 = 3051121609u;
					continue;
				case 22u:
					goto IL_18;
				case 23u:
					return;
				}
				break;
			}
			return;
			IL_18:
			arg_2CA_0 = 3273901026u;
			goto IL_2C5;
			IL_346:
			arg_2CA_0 = ((other.peerId_ == null) ? 3051121609u : 2477138227u);
			goto IL_2C5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4CA:
				uint num;
				uint arg_412_0 = ((num = input.ReadTag()) == 0u) ? 647491844u : 369582362u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_412_0 ^ 281869114u)) % 39u)
					{
					case 0u:
						arg_412_0 = (num2 * 2370262348u ^ 625348009u);
						continue;
					case 1u:
						arg_412_0 = ((this.accountId_ != null) ? 946546012u : 1909102051u);
						continue;
					case 2u:
						arg_412_0 = ((num == 58u) ? 1064637769u : 306423866u);
						continue;
					case 3u:
						arg_412_0 = (num2 * 2156536632u ^ 1510389421u);
						continue;
					case 4u:
						arg_412_0 = (num2 * 1827677848u ^ 1880116493u);
						continue;
					case 5u:
						arg_412_0 = ((num > 37u) ? 652979775u : 1642881363u);
						continue;
					case 6u:
						this.gameAccountId_ = new EntityId();
						arg_412_0 = (num2 * 726811745u ^ 3242506835u);
						continue;
					case 7u:
						this.Timeout = input.ReadUInt64();
						arg_412_0 = 109179357u;
						continue;
					case 8u:
						this.attributes_.AddEntriesFrom(input, SendChallengeToUserRequest._repeated_attributes_codec);
						arg_412_0 = 109179357u;
						continue;
					case 9u:
						arg_412_0 = (num2 * 691471312u ^ 3322499965u);
						continue;
					case 10u:
						arg_412_0 = (num2 * 22859438u ^ 67724487u);
						continue;
					case 11u:
						arg_412_0 = ((this.gameAccountId_ == null) ? 1248685920u : 607233097u);
						continue;
					case 12u:
						arg_412_0 = ((this.host_ == null) ? 530350799u : 96245598u);
						continue;
					case 13u:
						arg_412_0 = 369582362u;
						continue;
					case 14u:
						arg_412_0 = (num2 * 238127734u ^ 3657844558u);
						continue;
					case 15u:
						input.ReadMessage(this.accountId_);
						arg_412_0 = 109179357u;
						continue;
					case 16u:
						arg_412_0 = ((num != 26u) ? 1874173965u : 1779664189u);
						continue;
					case 17u:
						arg_412_0 = (((num == 10u) ? 3870741577u : 3762541268u) ^ num2 * 1846989393u);
						continue;
					case 18u:
						arg_412_0 = ((num <= 50u) ? 338537226u : 986738219u);
						continue;
					case 19u:
						arg_412_0 = (num2 * 830921104u ^ 3597228112u);
						continue;
					case 20u:
						this.Context = input.ReadFixed32();
						arg_412_0 = 1640669429u;
						continue;
					case 21u:
						arg_412_0 = (((num != 66u) ? 3134415600u : 3386884291u) ^ num2 * 2009525793u);
						continue;
					case 22u:
						this.accountId_ = new EntityId();
						arg_412_0 = (num2 * 3974740629u ^ 748817169u);
						continue;
					case 23u:
						arg_412_0 = (((num <= 18u) ? 512957089u : 1886270726u) ^ num2 * 3309142974u);
						continue;
					case 24u:
						arg_412_0 = ((this.peerId_ != null) ? 528653029u : 1040259667u);
						continue;
					case 25u:
						arg_412_0 = (((num != 37u) ? 1225833052u : 1164309908u) ^ num2 * 1917369485u);
						continue;
					case 26u:
						input.ReadMessage(this.gameAccountId_);
						arg_412_0 = 466356868u;
						continue;
					case 27u:
						arg_412_0 = (((num == 50u) ? 517697390u : 1293653249u) ^ num2 * 1935495216u);
						continue;
					case 28u:
						goto IL_4CA;
					case 29u:
						this.host_ = new ProcessId();
						arg_412_0 = (num2 * 2223429746u ^ 3880226884u);
						continue;
					case 30u:
						arg_412_0 = (((num == 40u) ? 774072884u : 350506528u) ^ num2 * 2101220189u);
						continue;
					case 31u:
						arg_412_0 = (((num != 18u) ? 2150171325u : 3482793705u) ^ num2 * 2824219719u);
						continue;
					case 32u:
						input.ReadMessage(this.peerId_);
						arg_412_0 = 120592769u;
						continue;
					case 33u:
						input.SkipLastField();
						arg_412_0 = 1473868248u;
						continue;
					case 34u:
						this.challenges_.AddEntriesFrom(input, SendChallengeToUserRequest._repeated_challenges_codec);
						arg_412_0 = 109179357u;
						continue;
					case 35u:
						this.peerId_ = new ProcessId();
						arg_412_0 = (num2 * 249684622u ^ 2381848795u);
						continue;
					case 36u:
						arg_412_0 = (num2 * 2339161036u ^ 843008628u);
						continue;
					case 38u:
						input.ReadMessage(this.host_);
						arg_412_0 = 66601032u;
						continue;
					}
					return;
				}
			}
		}

		static SendChallengeToUserRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 1549260459u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5F_0 ^ 1473151001u)) % 4u)
					{
					case 1u:
						SendChallengeToUserRequest._repeated_attributes_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(50u, Bgs.Protocol.Attribute.Parser);
						arg_5F_0 = (num * 4702695u ^ 3901611306u);
						continue;
					case 2u:
						SendChallengeToUserRequest._repeated_challenges_codec = FieldCodec.ForMessage<Challenge>(26u, Challenge.Parser);
						arg_5F_0 = (num * 1581132335u ^ 2196407098u);
						continue;
					case 3u:
						goto IL_7B;
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
